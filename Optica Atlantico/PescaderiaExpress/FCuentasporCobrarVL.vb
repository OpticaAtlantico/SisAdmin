Imports System.Data.SqlClient
Public Class FCuentasporCobrarVL
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim Seleccionada As String = "Todas"
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.DGCuentasXPagar.DataSource = Nothing
        Me.DGCuentasXPagar.Columns.Clear()
        Me.Close()
    End Sub
    Private Sub LlenarEmpleados()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1),LEN(Apellido))) as Nombre FROM TEmpleado WHERE Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CEmpleados.DataSource = DataT
                Me.CEmpleados.DisplayMember = "Nombre"
                Me.CEmpleados.ValueMember = "IdEmpleado"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Empleados..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    'Private Sub LlenarClientes()
    '    If Conectar() Then
    '        Try
    '            Adaptador = New SqlDataAdapter("SELECT idCliente, Nombre FROM TClientes WHERE Activo=1 ORDER BY Nombre ASC", CNN)
    '            DataT = New DataTable
    '            Adaptador.Fill(DataT)
    '            Me.CCliente.DataSource = DataT
    '            Me.CCliente.DisplayMember = "Nombre"
    '            Me.CCliente.ValueMember = "IdCliente"
    '        Catch ex As Exception
    '            MessageBox.Show("Error al Cargar Datos de los Clientes..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub
    Private Sub LlenarComboPatrocinador()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1),LEN(Apellido))) as Nombre FROM TEmpleado WHERE Activo=1 ORDER BY Nombre", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CPatrocinador.DataSource = DataT
                Me.CPatrocinador.DisplayMember = "Nombre"
                Me.CPatrocinador.ValueMember = "IdEmpleado"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Patrocinadores... " & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub LlenarComboCaja()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TCajas WHERE Mostrar=1 ORDER BY Nombre", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CCaja.DataSource = DataT
                Me.CCaja.DisplayMember = "Nombre"
                Me.CCaja.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de las Cajas... " & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarLocales()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TLocales WHERE Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                NoEjecutar = True
                Adaptador.Fill(DataT)
                Me.CLocal.DataSource = DataT
                Me.CLocal.DataSource = DataT
                Me.CLocal.DisplayMember = "Nombre"
                Me.CLocal.ValueMember = "Id"
                Me.CLocal.SelectedValue = 3
                NoEjecutar = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Locales..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub


    Private Sub FCuentasporCobrarVL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Desde.Value = New DateTime(Date.Now.Year, DateTime.Now().AddMonths(-1).Month, MoverTreintaUno(DateTime.Now), 0, 0, 0, 0)
        Me.Hasta.Value = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, 23, 59, 59, 59)


        '   Me.Desde.Value = DateTime.Now().AddDays(-30).Day
        '    Me.Hasta.Value = DateTime.Now()
        LlenarLocales()
        LlenarEmpleados()
        Me.CCliente.Text = ""
        LlenarComboPatrocinador()
        LlenarComboCaja()
        Select Case VarBuscar
            Case "Cajas", "PosVenta"
                If (TipoCliente = 0) Then
                    Me.RBCliente.Checked = True
                    Me.CCliente.Text = Cliente
                Else
                    Me.RBEmpleado.Checked = True
                    Me.CEmpleados.Text = Cliente
                End If
            Case "BalanceCliente"
                Me.CCliente.Text = Cliente
        End Select

        BCuentas_Click(Nothing, Nothing)
    End Sub
    Private Sub RBEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles RBEmpleado.CheckedChanged
        If (RBEmpleado.Checked) Then
            Me.CEmpleados.Enabled = True
            Me.CPatrocinador.Enabled = False
            Me.CCaja.Enabled = False
            Seleccionada = "Empleado"
        End If
    End Sub
    Private Sub RBCliente_CheckedChanged(sender As Object, e As EventArgs) Handles RBCliente.CheckedChanged
        If (RBCliente.Checked) Then
            Me.CCaja.Enabled = False
            Me.CEmpleados.Enabled = False
            Me.CPatrocinador.Enabled = False
            Seleccionada = "Cliente"
        End If
    End Sub
    Private Sub RBPatrocinador_CheckedChanged(sender As Object, e As EventArgs) Handles RBPatrocinador.CheckedChanged
        If (RBPatrocinador.Checked) Then
            Me.CCaja.Enabled = False
            Me.CEmpleados.Enabled = False
            Me.CPatrocinador.Enabled = True
            Seleccionada = "Patrocinador"
        End If
    End Sub
    Private Sub RBTodas_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodas.CheckedChanged
        If (RBTodas.Checked) Then
            Me.CEmpleados.Enabled = False
            Me.CPatrocinador.Enabled = False
            Me.CCaja.Enabled = False
            Seleccionada = "Todas"
        End If
    End Sub

    Private Sub RBCaja_CheckedChanged(sender As Object, e As EventArgs) Handles RBCaja.CheckedChanged
        If (RBCaja.Checked) Then
            Me.CCaja.Enabled = True
            Me.CEmpleados.Enabled = False
            Me.CPatrocinador.Enabled = False
            Seleccionada = "Caja"
        End If
    End Sub
    Private Sub Diferencias()
        For I = 0 To Me.DGCuentasXPagar.RowCount - 1
            If (Me.DGCuentasXPagar.Item("Total", I).Value <> Me.DGCuentasXPagar.Item("Abonado", I).Value) Then
                Me.DGCuentasXPagar.Item("Total", I).Style.BackColor = Color.Gray
                Me.DGCuentasXPagar.Item("Abonado", I).Style.BackColor = Color.Gray
                Me.DGCuentasXPagar.Item("TotalD", I).Style.BackColor = Color.Gray
                Me.DGCuentasXPagar.Item("AbonadoD", I).Style.BackColor = Color.Gray
                Me.DGCuentasXPagar.Item("Resta", I).Style.BackColor = Color.Gray
                Me.DGCuentasXPagar.Item("RestaD", I).Style.BackColor = Color.Gray
            End If
        Next
    End Sub
    Private Sub ColorearDias()
        For I = 0 To Me.DGCuentasXPagar.RowCount - 1
            If (Me.DGCuentasXPagar.Item("Dias", I).Value.ToString <> "") Then
                Select Case Me.DGCuentasXPagar.Item("Dias", I).Value
                    Case Is >= 0
                        Me.DGCuentasXPagar.Item("Dias", I).Style.BackColor = Color.Green
                    Case Is < 0
                        Me.DGCuentasXPagar.Item("Dias", I).Style.BackColor = Color.Red
                End Select
                If (Me.DGCuentasXPagar.Item("TipoCliente", I).Value = 1) Then
                    Me.DGCuentasXPagar.Item("Verificar", I).Style.BackColor = Color.Gray
                    Me.DGCuentasXPagar.Item("Dias", I).Style.BackColor = Color.Gray
                    Me.DGCuentasXPagar.Item("Cliente", I).Style.ForeColor = Color.Navy
                Else
                    Me.DGCuentasXPagar.Item("Cliente", I).Style.ForeColor = Color.Black
                    Select Case Me.DGCuentasXPagar.Item("Dias", I).Value
                        Case Is > 3
                            Me.DGCuentasXPagar.Item("Verificar", I).Style.BackColor = Color.Orange
                        Case Is = 3
                            Me.DGCuentasXPagar.Item("Verificar", I).Style.BackColor = Color.Green
                        Case Is <= 1
                            Me.DGCuentasXPagar.Item("Verificar", I).Style.BackColor = Color.Red
                        Case Is = 2
                            Me.DGCuentasXPagar.Item("Verificar", I).Style.BackColor = Color.Yellow
                    End Select
                End If
            Else
                Me.DGCuentasXPagar.Item("Dias", I).Style.BackColor = Color.White
            End If
            If (Me.DGCuentasXPagar.Item("TipoCliente", I).Value = 1) Then
                Me.DGCuentasXPagar.Item("Dias", I).Style.ForeColor = Color.Gray
            Else
                Me.DGCuentasXPagar.Item("Dias", I).Style.ForeColor = Color.Black
                Me.DGCuentasXPagar.Item("Dias", I).Style.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                Me.DGCuentasXPagar.Item("Verificar", I).Style.ForeColor = Color.Black
                Me.DGCuentasXPagar.Item("Verificar", I).Style.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            End If
           
        Next
    End Sub

    Private Sub MostrarDetalleCompra()
        If (Me.DGCuentasXPagar.RowCount > 0) Then
            'FExaminarCuentas.LFecha.Text = "Fecha de Venta: " & Me.DGCuentasXPagar.CurrentRow.Cells("FechaCompra").Value
            'FExaminarCuentas.LCliente.Text = "Cliente: " & Me.DGCuentasXPagar.CurrentRow.Cells("Cliente").Value
            'FExaminarCuentas.LTotal.Text = Format(Convert.ToDecimal(Me.DGCuentasXPagar.CurrentRow.Cells("Total").Value), "##,##0.00")
            'FExaminarCuentas.LTotalD.Text = Format(Convert.ToDecimal(Me.DGCuentasXPagar.CurrentRow.Cells("TotalD").Value), "##,##0.00")
            'FExaminarCuentas.LTasaCambioProyectada.Text = CalcularDolar(DateTime.Now, "0")
            'FExaminarCuentas.LTasaCambioProyectada.Text = Format(BsXDolar, "##,##0.00")
            'FExaminarCuentas.LTasaCambioOficial.Text = Format(BsXDolarOficial, "##,##0.00")
            CodVenta = Me.DGCuentasXPagar.CurrentRow.Cells("idVenta").Value
            VarBuscar = "CuentasporCobrar"
            'FExaminarCuentas.Show()
        End If
    End Sub
    'Private Sub MostrarDetCliente()

    '    If (Me.DGCuentasXPagar.RowCount > 0) Then
    '        Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        Try
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("Select Descripcion FROM TClientes WHERE idCliente=@idCliente", CNN)
    '                Comando.Parameters.AddWithValue("@idCliente", Me.DGCuentasXPagar.CurrentRow.Cells("idCliente").Value)
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                Me.GridExaminar.Rows.Clear()
    '                If (DR.Read()) Then
    '                    Me.LDetCliente.Text = DR("Descripcion")
    '                Else
    '                    Me.LDetCliente.Text = ""
    '                End If                                     
    '                DR.Close()
    '                Desconectar()
    '                Me.PanelDetCliente.Visible = True
    '                Cursor = System.Windows.Forms.Cursors.Default
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("ERROR al Mostrar los Datos del Detalle del Cliente. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Desconectar()
    '            Cursor = System.Windows.Forms.Cursors.Default
    '        End Try
    '    End If
    'End Sub

    Private Sub DGCuentasXPagar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCuentasXPagar.CellClick
        '   Dim grid As DataGridView = CType(sender, DataGridView)
        ' Dim Rec As Rectangle
        If (Me.BCuentas.BackColor = Color.Silver) Then
            If (Me.DGCuentasXPagar.RowCount > 0) Then
                 Select Me.DGCuentasXPagar.Columns(e.ColumnIndex).Name
                    Case Is = "Examinar"
                        CodVenta = Me.DGCuentasXPagar.CurrentRow.Cells("idVenta").Value
                        CodCliente = Me.DGCuentasXPagar.CurrentRow.Cells("idCliente").Value
                        Cliente = Me.DGCuentasXPagar.CurrentRow.Cells("Cliente").Value
                        ValTotal = Me.DGCuentasXPagar.CurrentRow.Cells("TotalInic").Value
                        ValTotalD = Me.DGCuentasXPagar.CurrentRow.Cells("TotalD").Value

                        TasaCambioInic = Convert.ToDecimal(Me.DGCuentasXPagar.Item("Tasa", e.RowIndex).Value)
                        CodCompra = Me.DGCuentasXPagar.CurrentRow.Cells("id").Value
                        DiasAtraso = Me.DGCuentasXPagar.CurrentRow.Cells("Dias").Value
                        FechaCompromisoPago = Me.DGCuentasXPagar.CurrentRow.Cells("FechaCobro").Value
                        '      FFormaPagoCliente.ShowDialog()
                        Me.BCuentas_Click(Nothing, Nothing)
                    Case Is = "Detalle"
                        MostrarDetalleCompra()
                    Case Is = "Perdido"
                        VarForma = "CreditosporCobrar"
                        CodCompra = Me.DGCuentasXPagar.CurrentRow.Cells("ID").Value
                        'FCreditosPerdidos.LCliente.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Cliente").Value.ToString
                        'FCreditosPerdidos.LFechaCompra.Text = Me.DGCuentasXPagar.CurrentRow.Cells("FechaCompra").Value
                        'FCreditosPerdidos.LDias.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Dias").Value
                        'FCreditosPerdidos.LPatrocinador.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Patrocinador").Value.ToString
                        'FCreditosPerdidos.LTotal.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Total").Value
                        'FCreditosPerdidos.LAbonado.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Abonado").Value
                        'FCreditosPerdidos.LResta.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Resta").Value
                        'FCreditosPerdidos.ShowDialog()
                        Me.BCuentas_Click(Nothing, Nothing)
                    Case Is = "Verificar"
                        If (Me.DGCuentasXPagar.Columns(e.ColumnIndex).Name = "Verificar") And (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Gray) Then
                            If (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Red) And (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Orange) Then
                                If MsgBox("Se llamo al Cliente, para Verificar Pago de Deuda?", vbYesNo, "MarSoft: Cuentas por Cobrar.") = vbYes Then
                                    Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value = "Ok"
                                Else
                                    Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value = ""
                                End If
                                If (Conectar()) Then
                                    Try
                                        Dim Comando As New SqlCommand("UPDATE TTotalizarCreditos SET Verificar=@Verificar WHERE id=" & Me.DGCuentasXPagar.CurrentRow.Cells("id").Value, CNN)
                                        Comando.Parameters.Add(New SqlParameter("@Verificar", Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value))
                                        Comando.ExecuteReader()
                                        Desconectar()
                                    Catch ex As Exception
                                        MsgBox("Error al Actualizar los Datos de la llamada.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                                        Desconectar()
                                    End Try
                                End If
                            Else
                                MsgBox("El Rango para Realizar la Llamada para Gestionar al Cliente para que Realice su Pago es de 3 o 2 Días Antes. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
                            End If
                        End If
                End Select
            End If
        Else
            If (Me.DGCuentasXPagar.RowCount > 0) Then
                Select Case Me.DGCuentasXPagar.Columns(e.ColumnIndex).Name
                    Case Is = "Examinar"
                        CodVenta = Me.DGCuentasXPagar.CurrentRow.Cells("idVenta").Value
                        CodCliente = Me.DGCuentasXPagar.CurrentRow.Cells("idCliente").Value
                        Cliente = Me.DGCuentasXPagar.CurrentRow.Cells("Cliente").Value
                        ValTotal = Me.DGCuentasXPagar.CurrentRow.Cells("TotalInic").Value
                        ValTotalD = Me.DGCuentasXPagar.CurrentRow.Cells("TotalD").Value
                        TasaCambioInic = Convert.ToDecimal(Me.DGCuentasXPagar.Item("Tasa", e.RowIndex).Value)
                        CodCompra = Me.DGCuentasXPagar.CurrentRow.Cells("id").Value
                        DiasAtraso = Me.DGCuentasXPagar.CurrentRow.Cells("Dias").Value
                        FechaCompromisoPago = Me.DGCuentasXPagar.CurrentRow.Cells("FechaCobro").Value
                        '  FFormaPagoCliente.ShowDialog()
                        BPagadas_Click(Nothing, Nothing)
                    Case Is = "Detalle"
                        MostrarDetalleCompra()
                    Case Is = "Perdido"
                        VarForma = "CreditosporCobrar"
                        'CodCompra = Me.DGCuentasXPagar.CurrentRow.Cells("ID").Value
                        'FCreditosPerdidos.LCliente.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Cliente").Value
                        'FCreditosPerdidos.LFechaCompra.Text = Me.DGCuentasXPagar.CurrentRow.Cells("FechaCompra").Value
                        'FCreditosPerdidos.LDias.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Dias").Value.ToString
                        'FCreditosPerdidos.LPatrocinador.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Patrocinador").Value
                        'FCreditosPerdidos.LTotal.Text = Me.DGCuentasXPagar.CurrentRow.Cells("TotalD").Value
                        'FCreditosPerdidos.LAbonado.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Abonado").Value
                        'FCreditosPerdidos.LResta.Text = Me.DGCuentasXPagar.CurrentRow.Cells("Resta").Value
                        'FCreditosPerdidos.ShowDialog()
                        'Me.BCuentas_Click(Nothing, Nothing)
                    Case Is = "Verificar"
                        If (Me.DGCuentasXPagar.Columns(e.ColumnIndex).Name = "Verificar") And (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Gray) Then
                            If (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Red) And (Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Style.BackColor <> Color.Orange) Then
                                If MsgBox("Se llamo al Cliente, para Verificar Pago de Deuda?", vbYesNo, "MarSoft: Cuentas por Cobrar.") = vbYes Then
                                    Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value = "Ok"
                                Else
                                    Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value = ""
                                End If
                                If (Conectar()) Then
                                    Try
                                        Dim Comando As New SqlCommand("UPDATE TTotalizarCreditos SET Verificar=@Verificar WHERE id=" & Me.DGCuentasXPagar.CurrentRow.Cells("id").Value, CNN)
                                        Comando.Parameters.Add(New SqlParameter("@Verificar", Me.DGCuentasXPagar.CurrentRow.Cells("Verificar").Value))
                                        Comando.ExecuteReader()
                                        Desconectar()
                                    Catch ex As Exception
                                        MsgBox("Error al Actualizar los Datos de la llamada.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                                        Desconectar()
                                    End Try
                                End If
                            Else
                                MsgBox("El Rango para Realizar la Llamada para Gestionar al Cliente para que Realice su Pago es de 3 o 2 Días Antes. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
                            End If
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub BStatus_Click(sender As Object, e As EventArgs) Handles BStatus.Click
        '     CodCliente = Me.CCliente.SelectedValue
        Cliente = Me.CCliente.Text
        '   FStatusCliente.ShowDialog()
    End Sub
    Private Sub ReflejarDolar()
        Dim X As Decimal = CalcularDolar(DateTime.Now, Me.LTotalGeneral.Text)
        For I = 0 To Me.DGCuentasXPagar.RowCount - 1
            If (Me.DGCuentasXPagar.Item("MonedaBase", I).Value.ToString = "Dolar") Then
                Me.DGCuentasXPagar.Item("Total", I).Value = BsXDolarBC * Format(Me.DGCuentasXPagar.Item("TotalD", I).Value, "##,##0.00")
                Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
                Me.DGCuentasXPagar.Item("Abonado", I).Value = BsXDolarBC * Me.DGCuentasXPagar.Item("AbonadoD", I).Value
                Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Format = "##,##0.00"
                Me.DGCuentasXPagar.Item("Resta", I).Value = BsXDolarBC * Me.DGCuentasXPagar.Item("RestaD", I).Value
                Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Format = "##,##0.00"
            End If
        Next
    End Sub
   
    Private Sub BCuentas_Click(sender As Object, e As EventArgs) Handles BCuentas.Click
        Dim Consulta As String = ""
        Me.BCuentas.BackColor = Color.Silver
        Me.BPagadas.BackColor = Color.Transparent
        Me.BStatus.BackColor = Color.Transparent
        Me.BCtasAnuladas.BackColor = Color.Transparent
        VarForma = "FCuentasporCobrar"
        Me.DGCuentasXPagar.DataSource = Nothing
        Me.DGCuentasXPagar.Columns.Clear()

        If (Me.CLocal.SelectedValue <> 3) Then
            Consulta = Consulta & " AND idLocal=" & Me.CLocal.SelectedValue
        Else
            Consulta = ""
        End If

        Select Case Seleccionada
            Case "Todas"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD>0 and Anulado=0 " & Consulta & " ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Empleado"
                If (Me.CEmpleados.SelectedValue = 54) Then
                    Try
                        If Conectar() Then
                            Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD >0 AND Anulado=0 AND TipoCliente=1 ORDER BY FechaCompra ASC", CNN)
                            Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                            Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DGCuentasXPagar.DataSource = DataT
                        End If
                        Desconectar()
                    Catch ex As Exception
                        MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Desconectar()
                    End Try
                Else
                    Try
                        If Conectar() Then
                            Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD >0 AND Anulado=0 AND idCliente=@IdCliente AND TipoCliente=1 ORDER BY FechaCompra ASC", CNN)
                            Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                            Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                            Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                            Adaptador.SelectCommand.Parameters("@idCliente").Value = Me.CEmpleados.SelectedValue
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DGCuentasXPagar.DataSource = DataT
                        End If
                        Desconectar()
                    Catch ex As Exception
                        MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Desconectar()
                    End Try
                End If

            Case "Cliente"
                If (Me.CCliente.Text = "") Then
                    Try
                        If Conectar() Then
                            Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD>0 AND TipoCliente=0 AND Anulado=0 ORDER BY FechaCompra ASC", CNN)
                            Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                            Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DGCuentasXPagar.DataSource = DataT
                        End If
                        Desconectar()
                    Catch ex As Exception
                        MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Desconectar()
                    End Try
                Else
                    Try
                        If Conectar() Then
                            Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD>0 or Resta>1) AND idCliente=@IdCliente AND TipoCliente=0 AND Anulado=0 ORDER BY FechaCompra ASC", CNN)
                            Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                            Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                            Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                            Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                            Adaptador.SelectCommand.Parameters("@idCliente").Value = CodCliente
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DGCuentasXPagar.DataSource = DataT
                        End If
                        Desconectar()
                    Catch ex As Exception
                        MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Desconectar()
                    End Try
                End If


            Case "Patrocinador"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD>0 AND idPatrocinador=@IdPatrocinador AND Anulado=0 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idPatrocinador", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idPatrocinador").Value = Me.CPatrocinador.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Caja"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND RestaD>0 AND Caja=@Caja AND Anulado=0 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@Caja", SqlDbType.NVarChar)
                        Adaptador.SelectCommand.Parameters("@Caja").Value = Me.CCaja.Text
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
        End Select

        Dim Boton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton.Name = "Examinar"
        Me.DGCuentasXPagar.Columns.Add(Boton)
        Me.DGCuentasXPagar.Columns("Examinar").HeaderText = "Exa."
        Me.DGCuentasXPagar.Columns("Examinar").ToolTipText = "Examinar"
        Me.DGCuentasXPagar.Columns("Examinar").Width = 50
        Dim Boton2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton2.Name = "Detalle"
        Me.DGCuentasXPagar.Columns.Add(Boton2)
        Me.DGCuentasXPagar.Columns("Detalle").HeaderText = "Det."
        Me.DGCuentasXPagar.Columns("Detalle").ToolTipText = "Detetalle"
        Me.DGCuentasXPagar.Columns("Detalle").Width = 50
        Dim Boton3 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton3.Name = "Perdido"
        Me.DGCuentasXPagar.Columns.Add(Boton3)
        Me.DGCuentasXPagar.Columns("Perdido").HeaderText = "Per."
        Me.DGCuentasXPagar.Columns("Perdido").ToolTipText = "Crédito Perdido."
        Me.DGCuentasXPagar.Columns("Perdido").Width = 50

        Me.DGCuentasXPagar.Columns("idVenta").HeaderText = "Cód."
        Me.DGCuentasXPagar.Columns("idVenta").Width = 70
        Me.DGCuentasXPagar.Columns("idVenta").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Caja").HeaderText = "Caja"
        Me.DGCuentasXPagar.Columns("Caja").Width = 90
        Me.DGCuentasXPagar.Columns("Caja").ReadOnly = True

        Me.DGCuentasXPagar.Columns("FechaCompra").HeaderText = "F.Venta."
        Me.DGCuentasXPagar.Columns("FechaCompra").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCompra").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCompra").ToolTipText = "Fecha de Venta."
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaCobro").HeaderText = "F.C.P."
        Me.DGCuentasXPagar.Columns("FechaCobro").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCobro").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCobro").ToolTipText = "Fecha de Compromiso de Pago."
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaPago").HeaderText = "F.Pago"
        Me.DGCuentasXPagar.Columns("FechaPago").Width = 70
        Me.DGCuentasXPagar.Columns("FechaPago").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaPago").ToolTipText = "Fecha de Pago."
        Me.DGCuentasXPagar.Columns("FechaPago").DefaultCellStyle.Format = "dd/MM/yy"
        Me.DGCuentasXPagar.Columns("FechaPago").Visible = False

        Me.DGCuentasXPagar.Columns("Dias").HeaderText = "Días"
        Me.DGCuentasXPagar.Columns("Dias").Width = 40
        Me.DGCuentasXPagar.Columns("Dias").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Verificar").HeaderText = "OK?"
        Me.DGCuentasXPagar.Columns("Verificar").Width = 40
        Me.DGCuentasXPagar.Columns("Verificar").ToolTipText = "Se llamo al Cliente?"
        Me.DGCuentasXPagar.Columns("Verificar").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idCliente").Visible = False
        Me.DGCuentasXPagar.Columns("idCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Cliente").HeaderText = "Cliente/Empl."
        Me.DGCuentasXPagar.Columns("Cliente").Width = 160
        Me.DGCuentasXPagar.Columns("Cliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Telf").HeaderText = "Teléfonos"
        Me.DGCuentasXPagar.Columns("Telf").Width = 100
        Me.DGCuentasXPagar.Columns("Telf").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idPatrocinador").Visible = False
        Me.DGCuentasXPagar.Columns("idPatrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TipoCliente").Visible = False
        Me.DGCuentasXPagar.Columns("TipoCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Patrocinador").HeaderText = "Patroc."
        Me.DGCuentasXPagar.Columns("Patrocinador").Width = 130
        Me.DGCuentasXPagar.Columns("Patrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Total").HeaderText = "Total"
        Me.DGCuentasXPagar.Columns("Total").Width = 80
        Me.DGCuentasXPagar.Columns("Total").ToolTipText = "Total de Compra."
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Total").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalD").HeaderText = "Total$"
        Me.DGCuentasXPagar.Columns("TotalD").Width = 80
        Me.DGCuentasXPagar.Columns("TotalD").ToolTipText = "Total de Compra en Dolar."
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalG").HeaderText = "Total Cr."
        Me.DGCuentasXPagar.Columns("TotalG").Width = 80
        Me.DGCuentasXPagar.Columns("TotalG").ToolTipText = "Total de Compra + % por Crédito. "
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalG").ReadOnly = True
        Me.DGCuentasXPagar.Columns("TotalG").Visible = False


        Me.DGCuentasXPagar.Columns("Abonado").HeaderText = "Abon."
        Me.DGCuentasXPagar.Columns("Abonado").Width = 80
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Abonado").ReadOnly = True

        Me.DGCuentasXPagar.Columns("AbonadoD").HeaderText = "Abon.$"
        Me.DGCuentasXPagar.Columns("AbonadoD").Width = 80
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("AbonadoD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Resta").HeaderText = "Resta"
        Me.DGCuentasXPagar.Columns("Resta").Width = 80
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Resta").ReadOnly = True

        Me.DGCuentasXPagar.Columns("RestaD").HeaderText = "Resta$"
        Me.DGCuentasXPagar.Columns("RestaD").Width = 80
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("RestaD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Anulado").Visible = False
        Me.DGCuentasXPagar.Columns("idGasto").Visible = False
        Me.DGCuentasXPagar.Columns("Tasa").Visible = False
        Me.DGCuentasXPagar.Columns("id").Visible = False
        Me.DGCuentasXPagar.Columns("TotalInic").Visible = False
        Me.DGCuentasXPagar.Columns("idLocal").Visible = False

        Me.DGCuentasXPagar.Columns("idCaja").Visible = False
        'Me.DGCuentasXPagar.Columns("Caja").Visible = False

        Me.DGCuentasXPagar.Columns("MonedaBase").Visible = False




        ''  Me.DGCuentasXPagar.Columns("idVenta").Visible = False
        'Me.DGCuentasXPagar.Columns("idVenta").HeaderText = "Cod."
        'Me.DGCuentasXPagar.Columns("idVenta").Width = 70




        Me.DGCuentasXPagar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Caja").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Dias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Verificar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("idCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Telf").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("idPatrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Patrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGCuentasXPagar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ReflejarDolar()

        Me.LTotalGeneral.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Total").Index), "##,##0.00")
        Me.LTotalAbonado.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Abonado").Index), "##,##0.00")
        Me.LTotalResta.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Resta").Index), "##,##0.00")

        Me.LTotalGeneralD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("TotalD").Index), "##,##0.00")
        Me.LTotalAbonadoD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("AbonadoD").Index), "##,##0.00")
        Me.LTotalRestaD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("RestaD").Index), "##,##0.00")

        ColorearDias()

        Me.DGCuentasXPagar.ClearSelection()
    End Sub

    Private Sub BPagadas_Click(sender As Object, e As EventArgs) Handles BPagadas.Click
        Dim Consulta As String = ""    
        If (Me.CLocal.SelectedValue <> 3) Then
            Consulta = Consulta & " AND idLocal=" & Me.CLocal.SelectedValue
        Else
            Consulta = ""
        End If
        Me.BCuentas.BackColor = Color.Transparent
        Me.BPagadas.BackColor = Color.Silver
        Me.BStatus.BackColor = Color.Transparent
        Me.BCtasAnuladas.BackColor = Color.Transparent
        VarForma = "FCuentasporCobrar"
        Me.DGCuentasXPagar.DataSource = Nothing
        Me.DGCuentasXPagar.Columns.Clear()

        Select Case Seleccionada
            Case "Todas"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCreditosPagos WHERE CAST(CONVERT(CHAR(8), FechaPago, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD <=0 or Anulado=1 or Resta <=1 ) " & Consulta & " ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Empleado"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCreditosPagos WHERE CAST(CONVERT(CHAR(8), FechaPago, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD <=0 or Anulado=1 or Resta <=1) AND idCliente=@IdCliente AND TipoCliente=1  ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idCliente").Value = Me.CEmpleados.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Cliente"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCreditosPagos WHERE CAST(CONVERT(CHAR(8), FechaPago, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD <=0 or Anulado=1 or Resta <=1) AND idCliente=@IdCliente AND TipoCliente=0 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idCliente").Value = CodCliente
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Patrocinador"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCreditosPagos WHERE CAST(CONVERT(CHAR(8), FechaPago, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD <=0 or Anulado=1 or Resta <=1) AND idPatrocinador=@IdPatrocinador ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idPatrocinador", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idPatrocinador").Value = Me.CPatrocinador.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Caja"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCreditosPagos WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND (RestaD <=0 or Anulado=1 or Resta <=1) AND idCaja=@idCaja ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idCaja", SqlDbType.NVarChar)
                        Adaptador.SelectCommand.Parameters("@idCaja").Value = Me.CCaja.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
        End Select

        Dim Boton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton.Name = "Examinar"
        Me.DGCuentasXPagar.Columns.Add(Boton)
        Me.DGCuentasXPagar.Columns("Examinar").HeaderText = "Exa."
        Me.DGCuentasXPagar.Columns("Examinar").ToolTipText = "Examinar"
        Me.DGCuentasXPagar.Columns("Examinar").Width = 50
        Dim Boton2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton2.Name = "Detalle"
        Me.DGCuentasXPagar.Columns.Add(Boton2)
        Me.DGCuentasXPagar.Columns("Detalle").HeaderText = "Det."
        Me.DGCuentasXPagar.Columns("Detalle").ToolTipText = "Detetalle"
        Me.DGCuentasXPagar.Columns("Detalle").Width = 50
        Dim Boton3 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton3.Name = "Perdido"
        Me.DGCuentasXPagar.Columns.Add(Boton3)
        Me.DGCuentasXPagar.Columns("Perdido").HeaderText = "Per."
        Me.DGCuentasXPagar.Columns("Perdido").ToolTipText = "Crédito Perdido."
        Me.DGCuentasXPagar.Columns("Perdido").Width = 50

        Me.DGCuentasXPagar.Columns("idVenta").HeaderText = "Cód."
        Me.DGCuentasXPagar.Columns("idVenta").Width = 60
        Me.DGCuentasXPagar.Columns("idVenta").ReadOnly = True
        Me.DGCuentasXPagar.Columns("idVenta").ToolTipText = "Código de la Venta."

        Me.DGCuentasXPagar.Columns("FechaCompra").HeaderText = "F.V."
        Me.DGCuentasXPagar.Columns("FechaCompra").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCompra").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCompra").ToolTipText = "Fecha de la Venta."
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaCobro").HeaderText = "F.C.P."
        Me.DGCuentasXPagar.Columns("FechaCobro").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCobro").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCobro").ToolTipText = "Fecha de Compromiso de Pago."
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaPago").HeaderText = "F.Pago"
        Me.DGCuentasXPagar.Columns("FechaPago").Width = 70
        Me.DGCuentasXPagar.Columns("FechaPago").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaPago").ToolTipText = "Fecha de Pago."
        Me.DGCuentasXPagar.Columns("FechaPago").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("Dias").HeaderText = "Días"
        Me.DGCuentasXPagar.Columns("Dias").Width = 50
        Me.DGCuentasXPagar.Columns("Dias").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Verificar").HeaderText = "Ok?"
        Me.DGCuentasXPagar.Columns("Verificar").Width = 50
        Me.DGCuentasXPagar.Columns("Verificar").ToolTipText = "Se llamo al Cliente?"
        Me.DGCuentasXPagar.Columns("Verificar").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idCliente").Visible = False
        Me.DGCuentasXPagar.Columns("idCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Cliente").HeaderText = "Cliente"
        Me.DGCuentasXPagar.Columns("Cliente").Width = 120
        Me.DGCuentasXPagar.Columns("Cliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Telf").HeaderText = "Teléfonos"
        Me.DGCuentasXPagar.Columns("Telf").Width = 100
        Me.DGCuentasXPagar.Columns("Telf").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idPatrocinador").Visible = False
        Me.DGCuentasXPagar.Columns("idPatrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TipoCliente").Visible = False
        Me.DGCuentasXPagar.Columns("TipoCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Patrocinador").HeaderText = "Patrocinador"
        Me.DGCuentasXPagar.Columns("Patrocinador").Width = 100
        Me.DGCuentasXPagar.Columns("Patrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Total").HeaderText = "Total"
        Me.DGCuentasXPagar.Columns("Total").Width = 85
        Me.DGCuentasXPagar.Columns("Total").ToolTipText = "Total de Compra."
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Total").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalD").HeaderText = "Total $"
        Me.DGCuentasXPagar.Columns("TotalD").Width = 85
        Me.DGCuentasXPagar.Columns("TotalD").ToolTipText = "Total de Compra en Dolar."
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalG").HeaderText = "Total Cr."
        Me.DGCuentasXPagar.Columns("TotalG").Width = 85
        Me.DGCuentasXPagar.Columns("TotalG").ToolTipText = "Total de Compra + % por Crédito. "
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalG").ReadOnly = True
        Me.DGCuentasXPagar.Columns("TotalG").Visible = False


        Me.DGCuentasXPagar.Columns("Abonado").HeaderText = "Abon."
        Me.DGCuentasXPagar.Columns("Abonado").Width = 85
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Abonado").ReadOnly = True

        Me.DGCuentasXPagar.Columns("AbonadoD").HeaderText = "Abon. $"
        Me.DGCuentasXPagar.Columns("AbonadoD").Width = 85
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("AbonadoD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Resta").HeaderText = "Resta"
        Me.DGCuentasXPagar.Columns("Resta").Width = 85
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Resta").ReadOnly = True

        Me.DGCuentasXPagar.Columns("RestaD").HeaderText = "Resta $"
        Me.DGCuentasXPagar.Columns("RestaD").Width = 90
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("RestaD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Anulado").HeaderText = "C.A."
        Me.DGCuentasXPagar.Columns("Anulado").ToolTipText = "Crédito Anulado?"
        Me.DGCuentasXPagar.Columns("Anulado").Width = 60
        Me.DGCuentasXPagar.Columns("Anulado").ReadOnly = True
        Me.DGCuentasXPagar.Columns("id").Visible = False

        Me.DGCuentasXPagar.Columns("TotalInic").Visible = False
        Me.DGCuentasXPagar.Columns("Tasa").Visible = False
        Me.DGCuentasXPagar.Columns("Tasa").Width = 60
        Me.DGCuentasXPagar.Columns("TotalInic").Width = 80
        Me.DGCuentasXPagar.Columns("idlocal").Visible = False
        Me.DGCuentasXPagar.Columns("idCaja").Visible = False
        Me.DGCuentasXPagar.Columns("MonedaBase").Visible = False


        Me.DGCuentasXPagar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaPago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Dias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Verificar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("idCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Telf").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("idPatrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Patrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ReflejarDolar()

        Me.LTotalGeneral.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Total").Index), "##,##0.00")
        Me.LTotalAbonado.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Abonado").Index), "##,##0.00")
        Me.LTotalResta.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Resta").Index), "##,##0.00")

        Me.LTotalGeneralD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("TotalD").Index), "##,##0.00")
        Me.LTotalAbonadoD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("AbonadoD").Index), "##,##0.00")
        Me.LTotalRestaD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("RestaD").Index), "##,##0.00")

        ColorearDias()
        Diferencias()
        Me.DGCuentasXPagar.ClearSelection()
    End Sub
    Private Sub BCtasAnuladas_Click(sender As Object, e As EventArgs) Handles BCtasAnuladas.Click
        Dim Consulta As String = ""
        If (Me.CLocal.SelectedValue <> 3) Then
            Consulta = Consulta & " AND idLocal=" & Me.CLocal.SelectedValue
        Else
            Consulta = ""
        End If
        Me.BCuentas.BackColor = Color.Transparent
        Me.BPagadas.BackColor = Color.Transparent
        Me.BStatus.BackColor = Color.Transparent
        Me.BCtasAnuladas.BackColor = Color.Silver
        VarForma = "FCuentasAnuladas"
        Me.DGCuentasXPagar.DataSource = Nothing
        Me.DGCuentasXPagar.Columns.Clear()
        Select Case Seleccionada
            Case "Todas"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND Resta>0 and Anulado=1 " & Consulta & " ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Empleado"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND Resta >0 AND Anulado=1 AND idCliente=@IdCliente AND TipoCliente=1  ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idCliente").Value = Me.CEmpleados.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Cliente"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND Resta>0 AND idCliente=@IdCliente AND TipoCliente=0 AND Anulado=1 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idCliente").Value = CodCliente
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Patrocinador"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND Resta>0 AND idPatrocinador=@IdPatrocinador AND Anulado=1 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@idPatrocinador", SqlDbType.Int)
                        Adaptador.SelectCommand.Parameters("@idPatrocinador").Value = Me.CPatrocinador.SelectedValue
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
            Case "Caja"
                Try
                    If Conectar() Then
                        Adaptador = New SqlDataAdapter("Select * FROM VTotalizarCredito WHERE CAST(CONVERT(CHAR(8), FechaCompra, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND Caja=@Caja AND Anulado=1 ORDER BY FechaCompra ASC", CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                        Adaptador.SelectCommand.Parameters.Add("@Caja", SqlDbType.NVarChar)
                        Adaptador.SelectCommand.Parameters("@Caja").Value = Me.CCaja.Text
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DGCuentasXPagar.DataSource = DataT
                    End If
                    Desconectar()
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try
        End Select

        Dim Boton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton.Name = "Examinar"
        Me.DGCuentasXPagar.Columns.Add(Boton)
        Me.DGCuentasXPagar.Columns("Examinar").HeaderText = "Exa."
        Me.DGCuentasXPagar.Columns("Examinar").ToolTipText = "Examinar"
        Me.DGCuentasXPagar.Columns("Examinar").Width = 50
        Dim Boton2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton2.Name = "Detalle"
        Me.DGCuentasXPagar.Columns.Add(Boton2)
        Me.DGCuentasXPagar.Columns("Detalle").HeaderText = "Det."
        Me.DGCuentasXPagar.Columns("Detalle").ToolTipText = "Detetalle"
        Me.DGCuentasXPagar.Columns("Detalle").Width = 50
        Dim Boton3 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        Boton3.Name = "Perdido"
        Me.DGCuentasXPagar.Columns.Add(Boton3)
        Me.DGCuentasXPagar.Columns("Perdido").HeaderText = "Per."
        Me.DGCuentasXPagar.Columns("Perdido").ToolTipText = "Crédito Perdido."
        Me.DGCuentasXPagar.Columns("Perdido").Width = 50

        Me.DGCuentasXPagar.Columns("idVenta").HeaderText = "Cód."
        Me.DGCuentasXPagar.Columns("idVenta").Width = 70
        Me.DGCuentasXPagar.Columns("idVenta").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Caja").HeaderText = "Caja"
        Me.DGCuentasXPagar.Columns("Caja").Width = 90
        Me.DGCuentasXPagar.Columns("Caja").ReadOnly = True

        Me.DGCuentasXPagar.Columns("FechaCompra").HeaderText = "F.Venta."
        Me.DGCuentasXPagar.Columns("FechaCompra").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCompra").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCompra").ToolTipText = "Fecha de Venta."
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaCobro").HeaderText = "F.C.P."
        Me.DGCuentasXPagar.Columns("FechaCobro").Width = 70
        Me.DGCuentasXPagar.Columns("FechaCobro").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaCobro").ToolTipText = "Fecha de Compromiso de Pago."
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Format = "dd/MM/yy"

        Me.DGCuentasXPagar.Columns("FechaPago").HeaderText = "F.Pago"
        Me.DGCuentasXPagar.Columns("FechaPago").Width = 70
        Me.DGCuentasXPagar.Columns("FechaPago").ReadOnly = True
        Me.DGCuentasXPagar.Columns("FechaPago").ToolTipText = "Fecha de Pago."
        Me.DGCuentasXPagar.Columns("FechaPago").DefaultCellStyle.Format = "dd/MM/yy"
        Me.DGCuentasXPagar.Columns("FechaPago").Visible = False

        Me.DGCuentasXPagar.Columns("Dias").HeaderText = "Días"
        Me.DGCuentasXPagar.Columns("Dias").Width = 40
        Me.DGCuentasXPagar.Columns("Dias").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Verificar").HeaderText = "OK?"
        Me.DGCuentasXPagar.Columns("Verificar").Width = 40
        Me.DGCuentasXPagar.Columns("Verificar").ToolTipText = "Se llamo al Cliente?"
        Me.DGCuentasXPagar.Columns("Verificar").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idCliente").Visible = False
        Me.DGCuentasXPagar.Columns("idCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Cliente").HeaderText = "Cliente/Empl."
        Me.DGCuentasXPagar.Columns("Cliente").Width = 160
        Me.DGCuentasXPagar.Columns("Cliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Telf").HeaderText = "Teléfonos"
        Me.DGCuentasXPagar.Columns("Telf").Width = 100
        Me.DGCuentasXPagar.Columns("Telf").ReadOnly = True

        Me.DGCuentasXPagar.Columns("idPatrocinador").Visible = False
        Me.DGCuentasXPagar.Columns("idPatrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TipoCliente").Visible = False
        Me.DGCuentasXPagar.Columns("TipoCliente").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Patrocinador").HeaderText = "Patroc."
        Me.DGCuentasXPagar.Columns("Patrocinador").Width = 130
        Me.DGCuentasXPagar.Columns("Patrocinador").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Total").HeaderText = "Total"
        Me.DGCuentasXPagar.Columns("Total").Width = 80
        Me.DGCuentasXPagar.Columns("Total").ToolTipText = "Total de Compra."
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Total").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalD").HeaderText = "Total$"
        Me.DGCuentasXPagar.Columns("TotalD").Width = 80
        Me.DGCuentasXPagar.Columns("TotalD").ToolTipText = "Total de Compra en Dolar."
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("TotalG").HeaderText = "Total Cr."
        Me.DGCuentasXPagar.Columns("TotalG").Width = 80
        Me.DGCuentasXPagar.Columns("TotalG").ToolTipText = "Total de Compra + % por Crédito. "
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("TotalG").ReadOnly = True
        Me.DGCuentasXPagar.Columns("TotalG").Visible = False


        Me.DGCuentasXPagar.Columns("Abonado").HeaderText = "Abon."
        Me.DGCuentasXPagar.Columns("Abonado").Width = 80
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Abonado").ReadOnly = True

        Me.DGCuentasXPagar.Columns("AbonadoD").HeaderText = "Abon.$"
        Me.DGCuentasXPagar.Columns("AbonadoD").Width = 80
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("AbonadoD").ReadOnly = True

        Me.DGCuentasXPagar.Columns("Resta").HeaderText = "Resta"
        Me.DGCuentasXPagar.Columns("Resta").Width = 80
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("Resta").ReadOnly = True

        Me.DGCuentasXPagar.Columns("RestaD").HeaderText = "Resta$"
        Me.DGCuentasXPagar.Columns("RestaD").Width = 80
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Format = "##,##0.00"
        Me.DGCuentasXPagar.Columns("RestaD").ReadOnly = True


        Me.DGCuentasXPagar.Columns("Anulado").Visible = False
        Me.DGCuentasXPagar.Columns("idGasto").Visible = False
        Me.DGCuentasXPagar.Columns("TotalInic").Visible = False
        Me.DGCuentasXPagar.Columns("Tasa").Visible = False
        Me.DGCuentasXPagar.Columns("Tasa").Width = 60
        Me.DGCuentasXPagar.Columns("TotalInic").Width = 80
        Me.DGCuentasXPagar.Columns("idlocal").Visible = False
        Me.DGCuentasXPagar.Columns("id").Visible = False
        Me.DGCuentasXPagar.Columns("TotalG").Visible = False

        Me.DGCuentasXPagar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Caja").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("FechaCobro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Dias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Verificar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("idCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Telf").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("idPatrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Patrocinador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.DGCuentasXPagar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Abonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("Resta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("AbonadoD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DGCuentasXPagar.Columns("RestaD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.DGCuentasXPagar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ReflejarDolar()

        Me.LTotalGeneral.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Total").Index), "##,##0.00")
        Me.LTotalAbonado.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Abonado").Index), "##,##0.00")
        Me.LTotalResta.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("Resta").Index), "##,##0.00")

        Me.LTotalGeneralD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("TotalD").Index), "##,##0.00")
        Me.LTotalAbonadoD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("AbonadoD").Index), "##,##0.00")
        Me.LTotalRestaD.Text = Format(SumarColumna(Me.DGCuentasXPagar, Me.DGCuentasXPagar.Columns("RestaD").Index), "##,##0.00")

        ColorearDias()

        Me.DGCuentasXPagar.ClearSelection()
    End Sub
    Private Sub RBCliente_Click(sender As Object, e As EventArgs) Handles RBCliente.Click
        '   FBuscarClienteEmpleado.ShowDialog()
        Me.CCliente.Text = NombreCliente
        BCuentas_Click(Nothing, Nothing)
    End Sub
   

    Private Sub BSiguiente_Click(sender As Object, e As EventArgs) Handles BSiguiente.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(1)
        BCuentas_Click(Nothing, Nothing)
    End Sub
    Private Sub BAnterior_Click(sender As Object, e As EventArgs) Handles BAnterior.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(-1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(-1)
        BCuentas_Click(Nothing, Nothing)
    End Sub
    Private Sub BExpandir_Click(sender As Object, e As EventArgs) Handles BExpandir.Click
        Me.DGCuentasXPagar.Columns("idVenta").Visible = Not (Me.DGCuentasXPagar.Columns("idVenta").Visible)
        Me.DGCuentasXPagar.Columns("TotalInic").Visible = Not (Me.DGCuentasXPagar.Columns("TotalInic").Visible)
        Me.DGCuentasXPagar.Columns("Tasa").Visible = Not (Me.DGCuentasXPagar.Columns("Tasa").Visible)
    End Sub
    Private Sub DGCuentasXPagar_Sorted(sender As Object, e As EventArgs) Handles DGCuentasXPagar.Sorted
        ColorearDias()
    End Sub
End Class