Imports System.Data.SqlClient

Public Class FRastreo

    Private DataT As DataTable
        Private Adaptador As SqlDataAdapter
        Dim AquiSalto As Boolean = False
        Dim MonedaPagoAux As String = ""
        Dim AuxVarForma As String = ""
        Dim LimpiarGrid As Boolean = False

        Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
            Me.Close()
        End Sub


    Private Sub LlenarCombo()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TCondicion", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.Ccondicion.DataSource = DataT
                Me.Ccondicion.DisplayMember = "Nombre"
                Me.Ccondicion.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de Tipos de Pago..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarRastreo()
        If Conectar() Then

            Dim Comando As New SqlCommand("Select id, FechaPago, Monto, idTipoPago, TipoPago, Observacion FROM VFormaPago Where idOrden=" & CodOrden, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            '  LimpiarGrid = True
            Me.dgv_Datos.Rows.Clear()
            '  LimpiarGrid = False
            Do While DR.Read()
                Me.dgv_Datos.Rows.Add(Me.dgv_Datos.RowCount + 1, Format(DR("FechaPago"), "dd/MM/yyyy hh:mm tt"), IIf(DR("Monto") = 0, "", VFormat(DR("Monto"), 3)), DR("idTipoPago"), DR("TipoPago"), DR("Observacion").ToString, DR("id").ToString)
            Loop
            DR.Close()
        End If
        Desconectar()

    End Sub
    Private Sub FRastreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombo()
        Me.MCFecha.Visible = False
        Me.Ccondicion.Visible = False
        LlenarRastreo()
    End Sub

    Private Sub AgregarRuta_Click(sender As Object, e As EventArgs) Handles AgregarRuta.Click
        Dim Agregar As Boolean = False
        Me.dgv_Datos.EndEdit()
        If (Me.dgv_Datos.RowCount > 0) Then
            If (IIf(Me.dgv_Datos.Rows(Me.dgv_Datos.RowCount - 1).Cells("Monto").Value.ToString = "", 0, Me.dgv_Datos.Rows(Me.dgv_Datos.RowCount - 1).Cells("Monto").Value) = 0) Then
                Agregar = False
            Else
                Agregar = True
            End If
        Else
            Agregar = True
        End If

        Me.MCFecha.Visible = False
        Me.Ccondicion.Visible = False
    End Sub

    Private Sub EliminarRuta_Click(sender As Object, e As EventArgs) Handles EliminarRuta.Click
        If (Me.dgv_Datos.Rows.Count > 0) Then
            Me.dgv_Datos.Rows.RemoveAt(Me.dgv_Datos.CurrentRow.Index)
        Else
            AgregarRuta_Click(Nothing, Nothing)
        End If
        Me.MCFecha.Visible = False
        Me.Ccondicion.Visible = False
    End Sub
    Private Sub ActualizarRuta()
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
        'GuardarRuta()
    End Sub

    'Public Sub GuardarRuta()
    '    For i As Integer = 0 To Me.dgv_Datos.Rows.Count - 1
    '        If (Conectar()) Then
    '            Try
    '                Dim Comando As New SqlCommand("INSERT INTO TFormaPago(idOrden, FechaPago, Monto, idTipoPago, Observacion) VALUES(@idOrden, @FechaPago, @Monto, @idTipoPago, @Observacion)", CNN)
    '                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
    '                Comando.Parameters.Add(New SqlParameter("@FechaPago", Convert.ToDateTime(Me.dgv_Datos.Rows(i).Cells("FechaPago").Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.dgv_Datos.Rows(i).Cells("Monto").Value)))
    '                Comando.Parameters.Add(New SqlParameter("@idTipoPago", Convert.ToString(Me.dgv_Datos.Rows(i).Cells("idTipoPago").Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Observacion", Convert.ToString(Me.dgv_Datos.Rows(i).Cells("Observacion").Value)))
    '                Comando.ExecuteReader()
    '                Desconectar()
    '            Catch ex As Exception
    '                MsgBox("Error al Guardar los Datos de Formas de Pago de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '                Desconectar()
    '            End Try
    '        End If
    '    Next
    'End Sub

    Private Sub GuardarRuta_Click(sender As Object, e As EventArgs) Handles GuardarRuta.Click
        Me.dgv_Datos.EndEdit()

        'If (VefificarDatos() = True) Then
        ActualizarRuta()
            Me.Close()
        'End If
    End Sub


    Private Sub dgv_Datos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_Datos.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            With dgv_Datos
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

    Private Sub dgv_Datos_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgv_Datos.EditingControlShowing
        Select Case Me.dgv_Datos.Columns(Me.dgv_Datos.CurrentCell.ColumnIndex).Name
            Case Is = "Monto"
                Dim validar As TextBox = CType(e.Control, TextBox)
                AddHandler validar.KeyPress, AddressOf validar_Keypress
        End Select
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracter As Char = e.KeyChar
        Dim txt As TextBox = CType(sender, TextBox)
        Select Case Me.dgv_Datos.Columns(Me.dgv_Datos.CurrentCell.ColumnIndex).Name
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
        Me.Ccondicion.Visible = False
        Me.MCFecha.Visible = False
    End Sub
    Private Sub dgv_Datos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Datos.CellClick
        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim Rec As Rectangle
        If (Me.dgv_Datos.RowCount > 0) Then
            OcultarCombos()
            Select Case Me.dgv_Datos.Columns(Me.dgv_Datos.CurrentCell.ColumnIndex).Name
                Case Is = "FechaPago", Is = "FRP"
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex, grid.CurrentCell.RowIndex, False)
                    Me.MCFecha.Location = New Point(Rec.Location.X + grid.Location.X, Rec.Location.Y + grid.Location.Y)
                    Me.MCFecha.BringToFront()
                    Me.MCFecha.Show()
                Case Is = "TipoPago"
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex, grid.CurrentCell.RowIndex, False)
                    Me.Ccondicion.Location = New Point(Rec.Location.X + grid.Location.X, Rec.Location.Y + grid.Location.Y)
                    Me.Ccondicion.BringToFront()
                    Me.Ccondicion.Text = Me.dgv_Datos.CurrentRow.Cells("TipoPago").Value
                    Me.Ccondicion.Show()
                Case "Comentario"
                    VarForma = "FormaPago"
                    FComentarioSolo.TComentario.Text = Me.dgv_Datos.CurrentRow.Cells("Observacion").Value
                    FComentarioSolo.ShowDialog()
            End Select
        End If
    End Sub
    Private Sub MCFecha_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MCFecha.DateSelected
        Select Case Me.dgv_Datos.Columns(Me.dgv_Datos.CurrentCell.ColumnIndex).Name
            Case Is = "FechaPago"
                Me.dgv_Datos.CurrentRow.Cells("FechaPago").Value = e.Start.ToShortDateString()
        End Select
        Me.MCFecha.Visible = False
        Me.Ccondicion.Visible = False
    End Sub
    Private Sub Ccondicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ccondicion.SelectedIndexChanged
        If (Me.dgv_Datos.RowCount > 0) Then
            If Me.Ccondicion.Text <> "System.Data.DataRowView" Then
                Me.dgv_Datos.CurrentRow.Cells("TipoPago").Value = Me.Ccondicion.Text
                Me.dgv_Datos.CurrentRow.Cells("idTipoPago").Value = Me.Ccondicion.SelectedValue
                Me.MCFecha.Visible = False
                Me.Ccondicion.Visible = False
            End If
        End If
    End Sub


    Private Sub dgv_Datos_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_Datos.MouseUp
        If (Me.dgv_Datos.RowCount > 0) Then
            If (dgv_Datos.CurrentCell.ColumnIndex = 0) Then
                If Not Convert.ToBoolean(Me.dgv_Datos.CurrentRow.Cells(0).Value) Then
                    Dim grid As DataGridView = CType(sender, DataGridView)
                    Dim Rec As Rectangle
                    Rec = grid.GetCellDisplayRectangle(grid.CurrentCell.ColumnIndex + 1, grid.CurrentCell.RowIndex, False)
                    Me.MCFecha.Location = New Point(331, Rec.Location.Y + grid.Location.Y)
                    Me.MCFecha.BringToFront()
                    Me.MCFecha.Show()
                Else
                    'Me.dgv_Datos.CurrentRow.Cells("FechaPago").Value = DateTime.Now().ToShortDateString()
                    Me.MCFecha.Visible = False
                End If
            End If
            Me.dgv_Datos.EndEdit()
        End If
    End Sub

    Private Sub dgv_Datos_Scroll(sender As Object, e As ScrollEventArgs) Handles dgv_Datos.Scroll
        Me.MCFecha.Visible = False
        Me.Ccondicion.Visible = False
    End Sub

End Class