Imports System.Data.SqlClient
Public Class FFormaPago
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim AquiSalto As Boolean = False
    Dim MonedaPagoAux As String = ""
    Dim AuxVarForma As String = ""
    Dim LimpiarGrid As Boolean = False

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub CalcularAbonadoRestoDeuda()     
        Me.LAbonadoD.Text = SumarFilasDGBD(Me.GridFormaPago)
        Me.LRestaD.Text = Format(Convert.ToDecimal(Me.LTotalDF.Text) - Convert.ToDecimal(Me.LAbonadoD.Text), "##,##0.00")
        If (Me.LAbonadoD.Text = "") Or (Me.LAbonadoD.Text = "0") Then
            Me.LAbonadoD.Text = "0,00"
        Else
            Me.LAbonadoD.Text = Format(Convert.ToDecimal(Me.LAbonadoD.Text), "##,##0.00")
        End If
        If (Me.LRestaD.Text = "") Or (Me.LRestaD.Text = "0") Then
            Me.LRestaD.Text = "0,00"
        Else
            Me.LRestaD.Text = Format(Convert.ToDecimal(Me.LRestaD.Text), "##,##0.00")
        End If
    End Sub

    Private Sub LlenarComboTipoPago()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TTipoPago", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CTipoPago.DataSource = DataT
                Me.CTipoPago.DisplayMember = "Nombre"
                Me.CTipoPago.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de Tipos de Pago..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarFormaPago()
        If Conectar() Then
            Dim Comando As New SqlCommand("Select id, FechaPago, Monto, idTipoPago, TipoPago, Observacion FROM VFormaPago Where idOrden=" & CodOrden, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            '  LimpiarGrid = True
            Me.GridFormaPago.Rows.Clear()
            '  LimpiarGrid = False
            Do While DR.Read()
                Me.GridFormaPago.Rows.Add(Me.GridFormaPago.RowCount + 1, Format(DR("FechaPago"), "dd/MM/yyyy hh:mm tt"), IIf(DR("Monto") = 0, "", VFormat(DR("Monto"), 3)), DR("idTipoPago"), DR("TipoPago"), DR("Observacion").ToString, DR("id").ToString)
            Loop
            DR.Close()
        End If
        Desconectar()
        'If (Me.GridFormaPago.RowCount = 0) Then
        '    AgregarPago_Click(Nothing, Nothing)
        'End If
    End Sub
    Private Sub FFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboTipoPago()
        Me.MCFechaPago.Visible = False
        Me.CTipoPago.Visible = False
        LlenarFormaPago()
        CalcularAbonadoRestoDeuda()
    End Sub
    Private Function SumarFilasDGBD(DBG As DataGridView) As Decimal
        Dim Suma As Decimal = 0
        For Each fila As DataGridViewRow In DBG.Rows
            If (Convert.ToString(fila.Cells("Monto").Value) <> "") Then
                Suma = Suma + Convert.ToDecimal(fila.Cells("Monto").Value)
            End If
        Next
        Return (Suma)
    End Function

    Private Sub AgregarPago_Click(sender As Object, e As EventArgs) Handles AgregarPago.Click
        Dim Agregar As Boolean = False
        Me.GridFormaPago.EndEdit()
        Dim Saldo As Double = Convert.ToDecimal(Me.LTotalDF.Text) - SumarFilasDGBD(Me.GridFormaPago)
        If (Saldo <= 0) Then
            Agregar = False
        Else
            If (Me.GridFormaPago.RowCount > 0) Then
                If (IIf(Me.GridFormaPago.Rows(Me.GridFormaPago.RowCount - 1).Cells("Monto").Value.ToString = "", 0, Me.GridFormaPago.Rows(Me.GridFormaPago.RowCount - 1).Cells("Monto").Value) = 0) Then
                    Agregar = False
                Else
                    Agregar = True
                End If
            Else
                Agregar = True
            End If
        End If
        If (Agregar) Then
            Me.GridFormaPago.Rows.Add(Me.GridFormaPago.RowCount + 1, Format(DateTime.Now, "dd/MM/yyyy hh:mm tt"), VFormat(Saldo, 3), 1, "Divisas", "", 0)
        Else
            MsgBox("Saldo en Cero(0), No se puede Agregar mas Pagos. ", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
        CalcularAbonadoRestoDeuda()
        Me.MCFechaPago.Visible = False
        Me.CTipoPago.Visible = False
        If (Me.GridFormaPago.RowCount > 0) Then
            Me.GridFormaPago.CurrentCell = Me.GridFormaPago.Rows(Me.GridFormaPago.RowCount - 1).Cells("Monto")
        End If
    End Sub

    Private Sub EliminarPago_Click(sender As Object, e As EventArgs) Handles EliminarPago.Click
        If (Me.GridFormaPago.Rows.Count > 0) Then
            Me.GridFormaPago.Rows.RemoveAt(Me.GridFormaPago.CurrentRow.Index)
            CalcularAbonadoRestoDeuda()
        Else
            AgregarPago_Click(Nothing, Nothing)
        End If
        Me.MCFechaPago.Visible = False
        Me.CTipoPago.Visible = False
    End Sub
    Private Sub ActualizarFormasPago()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("DELETE FROM TFormaPago WHERE idOrden=" & CodOrden, CNN)
                Comando.ExecuteReader()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Eliminar Datos Formas Pago.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        GuardarFormaPago()
    End Sub
    'Private Sub ActualizarTotalizar()
    '    If (Conectar()) Then
    '        Try
    '            Dim Comando As New SqlCommand("UPDATE TTotalizar SET TotalCancelado=@TotalCancelado,Saldo=@Saldo,TotalCanceladoD=@TotalCanceladoD,SaldoD=@SaldoD, Resta2=@Resta2 WHERE idCompra=" & CodCompra, CNN)
    '            Comando.Parameters.Add(New SqlParameter("@TotalCancelado", Convert.ToDecimal(Me.LAbonadoBs.Text)))
    '            Comando.Parameters.Add(New SqlParameter("@Saldo", Convert.ToDecimal(Me.LRestaBs.Text)))
    '            Comando.Parameters.Add(New SqlParameter("@TotalCanceladoD", Convert.ToDecimal(Me.LAbonadoD.Text)))
    '            Comando.Parameters.Add(New SqlParameter("@SaldoD", Convert.ToDecimal(Me.LRestaD.Text)))
    '            Comando.Parameters.Add(New SqlParameter("@Resta2", Convert.ToDecimal(Me.LRestaBs.Text)))
    '            Comando.ExecuteReader()
    '            Desconectar()
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar los Datos al Totalizar la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    'End Sub
    Function VefificarDatos() As Boolean
        Dim Valor As Boolean = True
        Valor = DatosCompletos(GridFormaPago, 1)
        'If (Valor = False) Then
        '    MsgBox("Vefifique las Fechas Compromiso de Pago, No pueden Ser Vacias. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
        '    Return (Valor)
        'Else
        '    For i As Integer = 0 To Me.GridFormaPago.Rows.Count - 1
        '        If (Me.GridFormaPago.Rows(i).Cells("FRP").Value.ToString = "") And (Me.GridFormaPago.Rows(i).Cells("MRP").Value.ToString <> "") And (Me.GridFormaPago.Rows(i).Cells("MRP").Value.ToString <> "0,00") Then
        '            Valor = False
        '            MsgBox("Debe Agregar la Fecha Real de Pago, en las Líneas que tengan Monto Real de Pago. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
        '            Return (Valor)
        '        End If
        '    Next
        '    'For i As Integer = 0 To Me.GridFormaPago.Rows.Count - 1
        '    '    If (Me.GridFormaPago.Rows(i).Cells("Banco").Value = "") And (Me.GridFormaPago.Rows(i).Cells("Tipo").Value = "Transferencia") Then
        '    '        Valor = False
        '    '        MsgBox("Vefifique los Bancos de la Empresa, No pueden Ser Vacios. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
        '    '        Return (Valor)
        '    '    End If
        '    'Next
        '    'If (Valor) Then
        '    '    For i As Integer = 0 To Me.GridFormaPago.Rows.Count - 1
        '    '        If (Me.GridFormaPago.Rows(i).Cells("BancoProv").Value = "") And (Me.GridFormaPago.Rows(i).Cells("Tipo").Value = "Transferencia") Then
        '    '            Valor = False
        '    '            MsgBox("Vefifique los Bancos de los Proveedores, No pueden Ser Vacios. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
        '    '            Return (Valor)
        '    '        End If
        '    '    Next
        '    'End If
        'End If
        Return Valor
    End Function

    Public Sub GuardarFormaPago()
        For i As Integer = 0 To Me.GridFormaPago.Rows.Count - 1
            If (Conectar()) Then
                Try
                    Dim Comando As New SqlCommand("INSERT INTO TFormaPago(idOrden, FechaPago, Monto, idTipoPago, Observacion) VALUES(@idOrden, @FechaPago, @Monto, @idTipoPago, @Observacion)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                    Comando.Parameters.Add(New SqlParameter("@FechaPago", Convert.ToDateTime(Me.GridFormaPago.Rows(i).Cells("FechaPago").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.GridFormaPago.Rows(i).Cells("Monto").Value)))                   
                    Comando.Parameters.Add(New SqlParameter("@idTipoPago", Convert.ToString(Me.GridFormaPago.Rows(i).Cells("idTipoPago").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Observacion", Convert.ToString(Me.GridFormaPago.Rows(i).Cells("Observacion").Value)))                  
                    Comando.ExecuteReader()
                    Desconectar()
                Catch ex As Exception
                    MsgBox("Error al Guardar los Datos de Formas de Pago de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            End If
        Next
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Me.GridFormaPago.EndEdit()
        If (Convert.ToDecimal(Me.LAbonadoD.Text) <= Convert.ToDecimal(Me.LTotalDF.Text)) Then
            ' If (Me.GridFormaPago.RowCount >= 1) Then
            If (VefificarDatos() = True) Then
                ActualizarFormasPago()
                Me.Close()
            End If
            'Else
            '  MsgBox("Debe Agregar la Forma de Pago Antes de Guardar. ", MsgBoxStyle.Information, "MarSoft: Información.")
            '  End If
        Else
        MsgBox("Lo Abonado: " & Me.LAbonadoD.Text & " no puede Ser Mayor al Total: " & Me.LTotalDF.Text & " a Cancelar. ", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub
    Private Sub GridFormaPago_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridFormaPago.CellEndEdit
        'If (LimpiarGrid = False) Then
        '    If (Me.GridFormaPago.RowCount - 1 >= 0) Then
        '        If (Me.GridFormaPago.CurrentCell.ColumnIndex = 2) Then
        '            If (Me.GridFormaPago.CurrentCell.Value.ToString = "") Then
        '                Me.GridFormaPago.CurrentCell.Value = "0,0000"
        '            Else
        '                Me.GridFormaPago.CurrentCell.Value = Format(Convert.ToDecimal(Me.GridFormaPago.CurrentCell.Value.ToString), "##,##0.0000")
        '            End If
        '            Select Case Me.GridFormaPago.CurrentRow.Cells("Tipo").Value
        '                Case "Efectivo"
        '                    If (Me.GridFormaPago.CurrentRow.Cells("Programado").Value = True) Then
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("Monto").Value.ToString)
        '                    Else
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("MRP").Value.ToString)
        '                    End If
        '                    Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Format(MontoEfect, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Value = Format(PorcEfect, "##,##0.0000")
        '                Case Else
        '                    Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Format(Me.GridFormaPago.CurrentRow.Cells("MRP").Value, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Value = 0
        '            End Select
        '            CalcularAbonadoRestoDeuda()
        '        End If
        '        If (Me.GridFormaPago.CurrentCell.ColumnIndex = 4) Then
        '            If (Me.GridFormaPago.CurrentRow.Cells("MRPD").Value = Nothing) Then
        '                Me.GridFormaPago.CurrentRow.Cells("MRP").Value = ""
        '            Else
        '                If (Me.GridFormaPago.CurrentRow.Cells("MRPD").Value.ToString = "") Then
        '                    Me.GridFormaPago.CurrentRow.Cells("MRP").Value = ""
        '                Else
        '                    Me.GridFormaPago.CurrentRow.Cells("MRP").Value = Format(Me.GridFormaPago.CurrentRow.Cells("MRPD").Value * BsXDolar, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("Programado").Value = False
        '                End If
        '            End If
        '            Select Case Me.GridFormaPago.CurrentRow.Cells("Tipo").Value
        '                Case "Efectivo"
        '                    If (Me.GridFormaPago.CurrentRow.Cells("Programado").Value = True) Then
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("Monto").Value.ToString)
        '                    Else
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("MRP").Value.ToString)
        '                    End If
        '                    Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Format(MontoEfect, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Tag = Format(PorcEfect, "##,##0.0000")
        '                Case Else
        '                    If (Me.GridFormaPago.CurrentRow.Cells("Programado").Value = True) Then
        '                        Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Me.GridFormaPago.CurrentRow.Cells("Monto").Value
        '                    Else
        '                        Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Me.GridFormaPago.CurrentRow.Cells("MRP").Value
        '                    End If
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Tag = 0
        '            End Select
        '            CalcularAbonadoRestoDeuda()
        '        End If
        '        If (Me.GridFormaPago.CurrentCell.ColumnIndex = 5) Then
        '            Dim Valor As Decimal = 0
        '            If (Me.GridFormaPago.CurrentRow.Cells("MRP").Value = Nothing) Then
        '                Me.GridFormaPago.CurrentRow.Cells("MRPD").Value = 0
        '            Else
        '                If (Me.GridFormaPago.CurrentRow.Cells("MRP").Value.ToString = "") Then
        '                    Me.GridFormaPago.CurrentRow.Cells("MRPD").Value = ""
        '                Else
        '                    Me.GridFormaPago.CurrentRow.Cells("MRPD").Value = Format(Convert.ToDecimal(Me.GridFormaPago.CurrentRow.Cells("MRP").Value) / BsXDolar, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("Programado").Value = False
        '                End If

        '            End If
        '            Select Case Me.GridFormaPago.CurrentRow.Cells("Tipo").Value
        '                Case "Efectivo"
        '                    If (Me.GridFormaPago.CurrentRow.Cells("Programado").Value = True) Then
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("Monto").Value.ToString)
        '                    Else
        '                        CalcularEfectivo(Date.Now(), Me.GridFormaPago.CurrentRow.Cells("MRP").Value.ToString)
        '                    End If
        '                    Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Format(MontoEfect, "##,##0.0000")
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Tag = Format(PorcEfect, "##,##0.0000")
        '                Case Else
        '                    If (Me.GridFormaPago.CurrentRow.Cells("Programado").Value = True) Then
        '                        Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Me.GridFormaPago.CurrentRow.Cells("Monto").Value
        '                    Else
        '                        Me.GridFormaPago.CurrentRow.Cells("MontoEfectivo").Value = Me.GridFormaPago.CurrentRow.Cells("MRP").Value
        '                    End If
        '                    Me.GridFormaPago.CurrentRow.Cells("PorcEfectivo").Tag = 0
        '            End Select
        '            CalcularAbonadoRestoDeuda()
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub GridFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles GridFormaPago.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            With GridFormaPago
                If ((.CurrentCell.ColumnIndex) < (.Columns.Count - 1)) Then
                    If (.CurrentCell.ColumnIndex + 1 = 3) Then
                        .CurrentCell = .Item(.CurrentCell.ColumnIndex + 2, .CurrentCell.RowIndex)
                    Else
                        .CurrentCell = .Item(.CurrentCell.ColumnIndex + 1, .CurrentCell.RowIndex)
                    End If

                ElseIf ((.CurrentCell.RowIndex) <> (.Rows.Count - 1)) Then
                    .CurrentCell = .Item(0, .CurrentCell.RowIndex + 1)
                ElseIf ((.CurrentCell.RowIndex) = (.Rows.Count - 1)) Then
                    .CurrentCell = .Item(0, 0)
                End If
            End With
        End If
    End Sub

    Private Sub GridFormaPago_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridFormaPago.EditingControlShowing
        Select Case Me.GridFormaPago.Columns(Me.GridFormaPago.CurrentCell.ColumnIndex).Name
            Case Is = "Monto"
                Dim validar As TextBox = CType(e.Control, TextBox)
                AddHandler validar.KeyPress, AddressOf validar_Keypress
        End Select
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracter As Char = e.KeyChar
        Dim txt As TextBox = CType(sender, TextBox)
        Select Case Me.GridFormaPago.Columns(Me.GridFormaPago.CurrentCell.ColumnIndex).Name
            Case Is = "Monto"
                If (caracter = ".") Then
                    caracter = ","
                    e.KeyChar = ","
                End If
                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If           
        End Select
    End Sub

    Private Sub OcultarCombos()  
        Me.CTipoPago.Visible = False    
        Me.MCFechaPago.Visible = False
    End Sub
    Private Sub GridFormaPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridFormaPago.CellClick
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim Rec As Rectangle
        If (Me.GridFormaPago.RowCount > 0) Then
            OcultarCombos()
            Select Case Me.GridFormaPago.Columns(Me.GridFormaPago.CurrentCell.ColumnIndex).Name
                Case Is = "FechaPago", Is = "FRP"
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex, grid.CurrentCell.RowIndex, False)
                    Me.MCFechaPago.Location = New Point(Rec.Location.X + grid.Location.X, Rec.Location.Y + grid.Location.Y)
                    Me.MCFechaPago.BringToFront()
                    Me.MCFechaPago.Show()
                Case Is = "TipoPago"
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex, grid.CurrentCell.RowIndex, False)
                    Me.CTipoPago.Location = New Point(Rec.Location.X + grid.Location.X, Rec.Location.Y + grid.Location.Y)
                    Me.CTipoPago.BringToFront()
                    Me.CTipoPago.Text = Me.GridFormaPago.CurrentRow.Cells("TipoPago").Value
                    Me.CTipoPago.Show()
                Case "Comentario"
                    VarForma = "FormaPago"
                    FComentarioSolo.TComentario.Text = Me.GridFormaPago.CurrentRow.Cells("Observacion").Value
                    FComentarioSolo.ShowDialog()
            End Select
        End If
    End Sub
    Private Sub MCFechaPago_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MCFechaPago.DateSelected
        Select Case Me.GridFormaPago.Columns(Me.GridFormaPago.CurrentCell.ColumnIndex).Name
            Case Is = "FechaPago"
                Me.GridFormaPago.CurrentRow.Cells("FechaPago").Value = e.Start.ToShortDateString()
        End Select
        CalcularAbonadoRestoDeuda()
        Me.MCFechaPago.Visible = False
        Me.CTipoPago.Visible = False
    End Sub
    Private Sub CTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CTipoPago.SelectedIndexChanged
        If (Me.GridFormaPago.RowCount > 0) Then
            If Me.CTipoPago.Text <> "System.Data.DataRowView" Then
                Me.GridFormaPago.CurrentRow.Cells("TipoPago").Value = Me.CTipoPago.Text
                Me.GridFormaPago.CurrentRow.Cells("idTipoPago").Value = Me.CTipoPago.SelectedValue
                Me.MCFechaPago.Visible = False
                Me.CTipoPago.Visible = False
            End If
        End If
    End Sub

  
    Private Sub GridFormaPago_MouseUp(sender As Object, e As MouseEventArgs) Handles GridFormaPago.MouseUp
        If (Me.GridFormaPago.RowCount > 0) Then
            If (GridFormaPago.CurrentCell.ColumnIndex = 0) Then
                If Not Convert.ToBoolean(Me.GridFormaPago.CurrentRow.Cells(0).Value) Then
                    Dim grid As DataGridView = CType(sender, DataGridView)
                    Dim Rec As Rectangle
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex + 1, grid.CurrentCell.RowIndex, False)
                    Me.MCFechaPago.Location = New Point(331, Rec.Location.Y + grid.Location.Y)
                    Me.MCFechaPago.BringToFront()
                    Me.MCFechaPago.Show()
                Else
                    'Me.GridFormaPago.CurrentRow.Cells("FechaPago").Value = DateTime.Now().ToShortDateString()
                    Me.MCFechaPago.Visible = False
                End If
            End If
            Me.GridFormaPago.EndEdit()
            CalcularAbonadoRestoDeuda()
        End If
    End Sub
  
    Private Sub GridFormaPago_Scroll(sender As Object, e As ScrollEventArgs) Handles GridFormaPago.Scroll
        Me.MCFechaPago.Visible = False
        Me.CTipoPago.Visible = False
    End Sub

End Class