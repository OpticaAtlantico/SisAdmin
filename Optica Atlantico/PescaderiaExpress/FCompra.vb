

Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FCompra
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    'Dim ActivarNegativos As Boolean = False
    Dim RespMensaje As String = ""
    Dim aqui As Boolean = False
    Dim ExisteProv As Boolean = False
    Dim AuxVarForma As String = ""
    Dim RecepcionActiva As String = ""

    Dim N_idUnidadProducto As Integer = 0
    Dim N_CostoD As Decimal = 0
    Dim N_Costo As Decimal = 0
    Dim N_PorcCosto As Decimal = 0
    Dim N_Costo2D As Decimal = 0
    Dim N_Costo2 As Decimal = 0
    Dim N_CostoCalD As Decimal = 0
    Dim N_Capacidad As Decimal = 0
    Dim N_UnidadCapacidad As String = ""
    Dim N_idUnidadCapacidad As Integer = 0
    Dim N_idUnidadAlterna As Integer = 0
    Dim N_UnidadAlterna As String = ""
    Dim N_FactorAterno As String = ""
    Dim N_TipoFactorAlterno As String = ""
    Dim N_UnidadProducto As String = ""
    Dim N_CalculoCap As Boolean = False
    Dim NuevoCosto As Decimal = 0
    Dim NuevoCostoD As Decimal = 0


    'Private Sub ActualizarCostoEspeciesUnidas()
    '    Dim CostoFinal As Decimal = 0
    '    Dim Precio1 As Decimal = 0
    '    Dim Precio2 As Decimal = 0
    '    Dim Precio3 As Decimal = 0

    '    If (Conectar()) Then
    '        Try
    '            'Cojinua
    '            Dim Comando As New SqlCommand("SELECT SUM(Costo*CantidadReal) as CostoXKg ,SUM(CantidadReal) AS KG, SUM(Precio*CantidadReal) as Precio1XKg, SUM(Precio2*CantidadReal) as Precio2XKg, SUM(Precio3*CantidadReal) as Precio3XKg FROM VActualizarCostoPrecios WHERE (idProducto=@idCoj OR idProducto=@idCojP) AND Fecha=@Fecha1", CNN)
    '            Comando.Parameters.Add(New SqlParameter("@Fecha1", Me.FechaFactura.Value.Date))
    '            Comando.Parameters.Add(New SqlParameter("@idCoj", 140))
    '            Comando.Parameters.Add(New SqlParameter("@idCojP", 5))
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            If DR.Read() Then
    '                If (DR("CostoXKg").ToString <> "") Then
    '                    If (DR("CostoXKg") = 0) Then
    '                        CostoFinal = 0
    '                        Precio1 = 0
    '                        Precio2 = 0
    '                        Precio3 = 0
    '                    Else
    '                        CostoFinal = DR("CostoXKg") / DR("KG")
    '                        Precio1 = DR("Precio1XKg") / DR("KG")
    '                        Precio2 = DR("Precio2XKg") / DR("KG")
    '                        Precio3 = DR("Precio3XKg") / DR("KG")
    '                    End If
    '                    DR.Close()
    '                    Comando.CommandText = "Update TNewProducto SET Costo=@CostoC, Precio1=@Precio1C, Precio2=@Precio2C, Precio3=@Precio3C WHERE idProducto=142"
    '                    Comando.Parameters.Add(New SqlParameter("@CostoC", CostoFinal))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio1C", Precio1))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio2C", Precio2))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio3C", Precio3))
    '                    DR = Comando.ExecuteReader()
    '                End If
    '            End If
    '            DR.Close()
    '            'Bonita Pintada
    '            Comando.CommandText = "SELECT SUM(Costo*CantidadReal) as CostoXKg ,SUM(CantidadReal) AS KG, SUM(Precio*CantidadReal) as Precio1XKg, SUM(Precio2*CantidadReal) as Precio2XKg, SUM(Precio3*CantidadReal) as Precio3XKg FROM VActualizarCostoPrecios WHERE (idProducto=@idBP OR idProducto=@idBPP) AND Fecha=@Fecha2"
    '            Comando.Parameters.Add(New SqlParameter("@Fecha2", Me.FechaFactura.Value.Date))
    '            Comando.Parameters.Add(New SqlParameter("@idBP", 9))
    '            Comando.Parameters.Add(New SqlParameter("@idBPP", 88))
    '            DR = Comando.ExecuteReader()
    '            If DR.Read() Then
    '                If (DR("CostoXKg").ToString <> "") Then
    '                    If (DR("CostoXKg") = 0) Then
    '                        CostoFinal = 0
    '                        Precio1 = 0
    '                        Precio2 = 0
    '                        Precio3 = 0
    '                    Else
    '                        CostoFinal = DR("CostoXKg") / DR("KG")
    '                        Precio1 = DR("Precio1XKg") / DR("KG")
    '                        Precio2 = DR("Precio2XKg") / DR("KG")
    '                        Precio3 = DR("Precio3XKg") / DR("KG")
    '                    End If
    '                    DR.Close()
    '                    Comando.CommandText = "Update TNewProducto SET Costo=@CostoBP, Precio1=@Precio1BP, Precio2=@Precio2BP, Precio3=@Precio3BP WHERE idProducto=143"
    '                    Comando.Parameters.Add(New SqlParameter("@CostoBP", CostoFinal))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio1BP", Precio1))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio2BP", Precio2))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio3BP", Precio3))
    '                    DR = Comando.ExecuteReader()
    '                End If
    '            End If
    '            DR.Close()
    '            'Bonita Blanca
    '            Comando.CommandText = "SELECT SUM(Costo*CantidadReal) as CostoXKg ,SUM(CantidadReal) AS KG, SUM(Precio*CantidadReal) as Precio1XKg, SUM(Precio2*CantidadReal) as Precio2XKg, SUM(Precio3*CantidadReal) as Precio3XKg FROM VActualizarCostoPrecios WHERE (idProducto=@idBB OR idProducto=@idBBP) AND Fecha=@Fecha3"
    '            Comando.Parameters.Add(New SqlParameter("@Fecha3", Me.FechaFactura.Value.Date))
    '            Comando.Parameters.Add(New SqlParameter("@idBB", 25))
    '            Comando.Parameters.Add(New SqlParameter("@idBBP", 96))
    '            DR = Comando.ExecuteReader()
    '            If DR.Read() Then
    '                If (DR("CostoXKg").ToString <> "") Then
    '                    If (DR("CostoXKg") = 0) Then
    '                        CostoFinal = 0
    '                        Precio1 = 0
    '                        Precio2 = 0
    '                        Precio3 = 0
    '                    Else
    '                        CostoFinal = DR("CostoXKg") / DR("KG")
    '                        Precio1 = DR("Precio1XKg") / DR("KG")
    '                        Precio2 = DR("Precio2XKg") / DR("KG")
    '                        Precio3 = DR("Precio3XKg") / DR("KG")
    '                    End If
    '                    DR.Close()
    '                    Comando.CommandText = "Update TNewProducto SET Costo=@CostoBB, Precio1=@Precio1BB, Precio2=@Precio2BB, Precio3=@Precio3BB WHERE idProducto=144"
    '                    Comando.Parameters.Add(New SqlParameter("@CostoBB", CostoFinal))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio1BB", Precio1))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio2BB", Precio2))
    '                    Comando.Parameters.Add(New SqlParameter("@Precio3BB", Precio3))
    '                    DR = Comando.ExecuteReader()
    '                End If
    '            End If
    '            DR.Close()
    '            Desconectar()
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar los Costos de las Especies Unidas.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    'End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub


    'Private Sub BInventario_Click(sender As Object, e As EventArgs)
    '    FProducto.ShowDialog()
    'End Sub

    'Private Sub BBuscarArt_Click(sender As Object, e As EventArgs) Handles BBuscarArt.Click
    '    VarBuscar = "CompraProd"
    '    FBuscar.ShowDialog()
    '    Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Costo")
    '    Me.GridCompra.BeginEdit(True)
    'End Sub
    Private Sub LlenarComboDepositos()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idDeposito, Nombre FROM TDeposito ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CDeposito.DataSource = DataT
                Me.CDeposito.DisplayMember = "Nombre"
                Me.CDeposito.ValueMember = "IdDeposito"
                If (Me.CDeposito.Items.Count > 0) Then
                    Me.CDeposito.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    'Private Sub LlenarComboProveedoresC()
    '    If Conectar() Then
    '        Try
    '            Adaptador = New SqlDataAdapter("SELECT idProveedor, Nombre FROM TProveedor WHERE Activo=1 AND Otros=0 ORDER BY Nombre ASC", CNN)
    '            DataT = New DataTable
    '            Adaptador.Fill(DataT)
    '            Me.CProveedor.DataSource = DataT
    '            Me.CProveedor.DisplayMember = "Nombre"
    '            Me.CProveedor.ValueMember = "IdProveedor"
    '            If (Me.CProveedor.Items.Count > 0) Then
    '                Me.CProveedor.SelectedIndex = 0
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub
    'Private Sub LlenarComboProveedoresR()
    '    If Conectar() Then
    '        Try
    '            Adaptador = New SqlDataAdapter("SELECT idProveedor, Nombre FROM TProveedor WHERE Activo=1  AND Otros=0 ORDER BY Nombre ASC", CNN)
    '            DataT = New DataTable
    '            Adaptador.Fill(DataT)
    '            Me.CProveedorR.DataSource = DataT
    '            Me.CProveedorR.DisplayMember = "Nombre"
    '            Me.CProveedorR.ValueMember = "IdProveedor"
    '            If (Me.CProveedorR.Items.Count > 0) Then
    '                Me.CProveedorR.SelectedIndex = 0
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub

    Private Sub LlenarComboCompradores()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido))) as Nombre FROM TEmpleado WHERE Activo=1 AND CompraAlMayor=1  ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CComprador.DataSource = DataT
                Me.CComprador.DisplayMember = "Nombre"
                Me.CComprador.ValueMember = "IdEmpleado"
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarNumDocumento()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idCompra FROM TCompras ORDER BY idCompra ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                If (DataT.Rows.Count > 0) Then
                    Dim dr As DataRow = DataT.Rows(DataT.Rows.Count - 1)
                    Me.LNumDoc.Text = Trim(dr("idcompra").ToString) + 1
                    CodCompra = Me.LNumDoc.Text
                    Me.LNumDoc.Text = RellenarCeros(Me.LNumDoc.Text, 10)
                Else
                    Me.LNumDoc.Text = 1
                    CodCompra = Me.LNumDoc.Text
                    Me.LNumDoc.Text = RellenarCeros(Me.LNumDoc.Text, 10)
                End If
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub EliminarFormasPago()
        If (Conectar()) Then
            Try
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                Dim Comando As New SqlCommand("DELETE FROM TFormasPago WHERE idCompra=" & CodCompra, CNN)
                Dim DR = Comando.ExecuteReader()
                DR.Close()
                Desconectar()
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Eliminar Formas de Pago de la Compra." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub EliminarGastosx()
        For i = 0 To Me.GridCompra.RowCount - 1
            If (Me.GridCompra.Item("Gasto", i).Value.ToString <> "") Then
                If (Me.GridCompra.Item("Gasto", i).Value <> 0) Then
                    EliminarGastoX(Me.GridCompra.Item("Gasto", i).Value.ToString)
                End If
            End If
        Next
    End Sub
    Private Sub FCompra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Si Realizó algún Cambio, debe <<GUARDAR LA COMPRA>> antes de continuar si no  perderá los cambios realizados. Desea Continuar? ", vbYesNo, "MarSoft: Buscar Datos.") = vbYes Then
            'ActualizarCostoEspeciesUnidas()
            '  EliminarFormasPago()
            If (Me.TCodImprimir.Text = "") Then
                EliminarGastosx()
            End If
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub MostrarCompra()
        Try
            If Conectar4() Then
                Dim Comando4 As New SqlCommand("Select * FROM VDetalleCompra WHERE idCompra=@idCompra", CNN4)
                Comando4.Parameters.AddWithValue("@idCompra", CodCompraGastos)
                Dim DatosArt As SqlDataReader = Comando4.ExecuteReader()
                Me.GridCompra.Rows.Clear()
                Do While DatosArt.Read()
                    Dim TipoFactorAlt As String
                    If DatosArt("TipoFactorAlt").ToString = "" Then
                        TipoFactorAlt = DatosArt("Unidad").ToString & " X"
                    Else
                        TipoFactorAlt = DatosArt("TipoFactorAlt").ToString
                    End If
                    Me.GridCompra.Rows.Add(Me.GridCompra.RowCount + 1, DatosArt("Codigo"), DatosArt("Producto"), DatosArt("Unidad"), DatosArt("idUnidad"), VFormat(DatosArt("Cantidad"), 2), DatosArt("Stock").ToString, VFormat(DatosArt("Costo"), 4), VFormat(DatosArt("CostoD"), 4), VFormat(DatosArt("SubTotal"), 4), VFormat(DatosArt("Descuento"), 4), VFormat(DatosArt("Impuesto"), 4), DatosArt("NomAlicuota"), DatosArt("idAlicuota"), VFormat(DatosArt("Alicuota"), 4), VFormat(DatosArt("TotalD"), 4), VFormat(DatosArt("Total"), 4), DatosArt("Balanza"), VFormat(DatosArt("CostoCal"), 4), VFormat(DatosArt("CostoCalD"), 4), VFormat(DatosArt("Precio1"), 4), DatosArt("Observaciones"), DatosArt("Precio2"), DatosArt("Precio3"), DatosArt("Precio4"), DatosArt("PrecioE"), DatosArt("PrecioD1"), DatosArt("PrecioD2"), DatosArt("PrecioD3"), DatosArt("PrecioD4"), DatosArt("PrecioDE"), DatosArt("UnidadAlt"), DatosArt("FactorAlt"), DatosArt("CostoAgregado"), DatosArt("CostoAgregadoD"), VFormat(DatosArt("CostoCal"), 4), VFormat(DatosArt("CostoCalD"), 4), DatosArt("idTipoProducto"), DatosArt("Empaquetado"), DatosArt("idEmpaquetado"), DatosArt("CantEmpaquetado"), TipoFactorAlt, DatosArt("Venta"), DatosArt("SelAlterno"), DatosArt("CostoUnitario"), DatosArt("CostoUnitarioD"), DatosArt("idCategoriaInt"), DatosArt("Capacidad"), DatosArt("idGastoCompra"))
                    If (DatosArt("idGastoCompra") <> 0) Then
                        Me.GridCompra.Item("Gasto", Me.GridCompra.RowCount - 1).Style.BackColor = Color.LightGreen
                    End If
                Loop
                DatosArt.Close()
                'VFormat(1, "1")
                Comando4.CommandText = "Select * FROM VCompras WHERE idCompra=@idCompra2"
                Comando4.Parameters.AddWithValue("@idCompra2", CodCompraGastos)
                DatosArt = Comando4.ExecuteReader()
                Do While DatosArt.Read()
                    MonedaBase = DatosArt("MonedaBase").ToString
                    MonedaPago = DatosArt("MonedaPago").ToString
                    Me.CDeposito.Text = DatosArt("Deposito").ToString
                    Me.TCodProveedor.Text = DatosArt("idProveedor").ToString
                    Me.FechaRegistro.Value = DatosArt("Fecha").ToString
                    Me.LTotalBs.Text = Format(Convert.ToDouble(DatosArt("Total").ToString), "##,##0.0000")
                    Me.LIVAD.Text = Format(Convert.ToDouble(DatosArt("IVA").ToString), "##,##0.0000")
                    Me.LTotalD.Text = Format(Convert.ToDouble(DatosArt("TotalD").ToString), "##,##0.0000")
                    ' FFormaPago.BGuardarFactura.Tag = DatosArt("PDF").ToString
                    Me.CTipoCompra.Text = DatosArt("TipoCompra").ToString
                    Me.CComprador.Text = DatosArt("Comprador").ToString
                    Me.CBCompraEnEfectivo.Checked = DatosArt("CompraEnEfectivo").ToString
                    Me.TNumFactura.Text = DatosArt("NFactura").ToString
                    Me.TNumControl.Text = DatosArt("NControl").ToString
                    Me.FechaFactura.Value = DatosArt("FechaFactura").ToString
                    Me.TSerial.Text = DatosArt("SerialMaqFiscal").ToString
                    Me.CTipoDoc.Text = DatosArt("TipoDoc").ToString
                    Me.CBLibro.Checked = DatosArt("Libro").ToString
                Loop
                DatosArt.Close()

                Comando4.CommandText = "Select ISNULL(Sum(Monto),0) as Monto FROM TGastosComprasForaneas WHERE idCompra=@idCompra3"
                Comando4.Parameters.AddWithValue("@idCompra3", CodCompraGastos)
                DatosArt = Comando4.ExecuteReader()
                If (DatosArt.Read()) Then
                    If (MonedaBase = "Bolívar") Then
                        Me.TGastos.Tag = Format(DatosArt("Monto"), "##,##0.0000")
                    Else
                        Me.TGastos.Tag = Format(DatosArt("Monto"), "##,##0.0000")
                    End If
                Else
                    Me.TGastos.Tag = 0
                End If
                DatosArt.Close()
                Desconectar4()
            End If
            '  DarFormatoGril()
            ActivarGuardar = False
            Me.BGuardar.Enabled = False
            Me.BActualizar.Enabled = True
            Me.BEliminarCompra.Enabled = True
            Me.TabControl1.SelectedIndex = 0
            Me.TCodImprimir.Text = CodCompraGastos
            Me.LNumDoc.Text = RellenarCeros(CodCompraGastos.ToString, 10)
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos de los Detalles de la Compra. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar2()
        End Try
    End Sub

    Private Sub LlenarLocales()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TLocales WHERE id<>3 and Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                NoEjecutar = True
                Adaptador.Fill(DataT)
                Me.CLocal.DataSource = DataT
                Me.CLocal.DataSource = DataT
                Me.CLocal.DisplayMember = "Nombre"
                Me.CLocal.ValueMember = "Id"
                Me.CLocal.SelectedValue = 6
                NoEjecutar = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Locales..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub LlenarLocalesLista()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT id, Nombre FROM TLocales WHERE Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                NoEjecutar = True
                Adaptador.Fill(DataT)
                Me.CLocalLista.DataSource = DataT
                Me.CLocalLista.DataSource = DataT
                Me.CLocalLista.DisplayMember = "Nombre"
                Me.CLocalLista.ValueMember = "Id"
                Me.CLocalLista.SelectedValue = 3
                NoEjecutar = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Locales..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub MostrarDatosRecepcion()
        Try
            If Conectar2() Then
                Dim Comando2 As New SqlCommand("Select * FROM VRecepcionPedidos WHERE idCompra=@idCompra", CNN2)
                Comando2.Parameters.AddWithValue("@idCompra", CodRecepcion)
                Dim DR As SqlDataReader = Comando2.ExecuteReader()
                Do While DR.Read()
                    Me.TCodProveedor.Text = DR("idProveedor")
                    Me.TNumFactura.Text = DR("NFactura").ToString
                    Me.FechaFactura.Text = DR("FechaFactura")
                    Me.FechaRegistro.Text = Format(Date.Now(), "G")
                    Me.CComprador.Text = DR("Comprador").ToString
                    Me.TTasa.Text = Format(DR("TasaSel"), "##,##0.00")
                    CodPDF = DR("PDF")
                    Me.LEvidencia.Tag = DR("PDF")
                    Me.LEvidencia.Text = "Evidencia: " & DR("PDF")
                    MonedaBase = DR("MonedaBase")
                    ValidarMonedaBase()
                Loop
                DR.Close()
                Comando2.CommandText = "Select * FROM VDetalleRecepcionPedidos WHERE idCompra=@idCompra1"
                Comando2.Parameters.AddWithValue("@idCompra1", CodRecepcion)
                DR = Comando2.ExecuteReader()
                Me.GridCompra.Rows.Clear()
                Do While DR.Read()
                    If (Conectar5()) Then
                        Dim Comando5 As New SqlCommand("Select  * FROM VNewProducto WHERE idProducto=@idProducto1", CNN5)
                        Comando5.Parameters.AddWithValue("@idProducto1", DR("idProducto"))
                        Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                        Do While DR5.Read()
                            Dim I As Integer = 0
                            Dim CostoXX As Decimal = 0
                            Dim CostoDXX As Decimal = 0
                            Dim TipoFactorAlt As String = ""
                            If DR5("TipoFactorAlt").ToString = "" Then
                                TipoFactorAlt = DR5("Unidad") & " X"
                            Else
                                TipoFactorAlt = DR5("TipoFactorAlt")
                            End If
                            If (DR5("TipoCostoAlt").ToString) Then
                                CostoXX = DR5("Costo") / DR5("FactorAlt")
                                CostoDXX = DR5("CostoD") / DR5("FactorAlt")
                            Else
                                CostoXX = DR5("Costo")
                                CostoDXX = DR5("CostoD")
                            End If
                            Me.GridCompra.Rows.Add(I + 1, DR5("idProducto"), DR5("NombreCorto"), DR("Unidad"), DR("idUnidad"), VFormat(DR("Cantidad"), 3), VFormat(DR("Cantidad"), 3), VFormat(CostoXX, 4), VFormat(CostoDXX, 4), 0, VFormat(CostoDXX * DR("Cantidad"), 4), VFormat((CostoDXX / 100) * DR5("IVAC"), 4), DR5("NIVAC"), DR5("idIVAC"), DR5("IVAC"), VFormat(CostoDXX * DR("Cantidad"), 4), VFormat(CostoXX * DR("Cantidad"), 4), DR5("Decimal"), DR5("Costo2"), DR5("Costo2D"), "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, DR5("UnidadAlt"), DR5("FactorAlt"), 0, 0, DR5("CostoCalUnid"), DR5("CostoCalUnidD"), DR5("idTipoProducto"), DR5("Empaquetado"), TipoFactorAlt, DR5("Venta"), DR("SelAlterno"), DR5("CostoCalUnid"), DR5("CostoCalUnidD"), DR5("idCategoriaInt"), VFormat(DR5("Capacidad"), 2), 0, DR5("idUnidadCapacidad"), DR5("UnidadCapacidad"), DR5("CalculoCap"), 0, DR5("VentaUnidAlt"), DR5("Precio1"), DR5("PrecioD1"))
                            If (Me.GridCompra.RowCount > 0) Then
                                CalcularStock(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Codigo").Value, Me.GridCompra.RowCount - 1)
                                TotalizarLinea(Me.GridCompra.RowCount - 1)
                                CalcularCostoCalculado(Me.GridCompra.RowCount - 1)
                                If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Venta").Value = True) Then
                                    Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.Red
                                Else
                                    Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.White
                                End If
                                ValidarMonedaBase()
                            End If
                        Loop
                    End If
                    Desconectar5()                
                Loop
                DR.Close()
            End If
            Desconectar2()
            Me.GridCompra.ClearSelection()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de Recepción del Mercancia. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar2()
        End Try
    End Sub
    Private Sub ValidarDatosRecepcion()
        Dim Descuento As Decimal = 0

        For Each row As DataGridViewRow In Me.GridCompra.Rows
            If (MonedaBase = "Bolívar") Then
                Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
            Else
                Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
            End If
            Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(Descuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
            CalcularStock(Me.GridCompra.Rows(row.Index).Cells("Codigo").Value, row.Index)
            TotalizarLinea(row.Index)
            CalcularCostoCalculado(row.Index)




            'row.Cells("SubTotal").Value = IIf(row.Cells("SubTotal").Value = Nothing, 0, row.Cells("SubTotal").Value)
            'If (row.Cells("SubTotal").Value.ToString = "") Then
            '    row.Cells("SubTotal").Value = "0"
            'End If
            'If (Me.GridCompra.Columns(e.ColumnIndex).Name = "SubTotal") Then
            '    row.Cells("Costo").Value = Convert.ToDecimal(Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value) / row.Cells("Cantidad").Value
            '    row.Cells("CostoD").Value = Convert.ToDecimal(Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value) / row.Cells("Cantidad").Value
            'End If

            'row.Cells("Costo").Value = IIf(Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value = Nothing, 0, row.Cells("Costo").Value)
            'If (Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value.ToString = "") Then
            '    row.Cells("Costo").Value = "0"
            'End If
            'Select Case Me.GridCompra.Columns(e.ColumnIndex).Name
            '    Case "Costo", "CostoD", "Unidad", "Descuento", "Alicuota", "SubTotal"
            '        If (MonedaBase = "Bolívar") Then
            '            Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
            '        Else
            '            Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
            '        End If
            '        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(Descuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
            '        TotalizarLinea(e.RowIndex)
            '        CalcularCostoCalculado(e.RowIndex)
            '    Case "Cantidad"
            '        If (MonedaBase = "Bolívar") Then
            '            Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
            '        Else
            '            Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
            '        End If
            '        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(Descuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
            '        CalcularStock(Me.GridCompra.Rows(e.RowIndex).Cells("Codigo").Value, e.RowIndex)
            '        TotalizarLinea(e.RowIndex)
            '        CalcularCostoCalculado(e.RowIndex)
            'End Select
        Next
    End Sub
    Private Sub FCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MarSoft: Compras - Usuario: " & UsuarioActivo
        Me.Proyectada.Text = CalcularDolar(Me.FechaFactura.Value, "0")
        Me.Proyectada.Text = Format(BsXDolar, "##,##0.00")
        Me.Paralelo.Text = Format(BsXDolarOficial, "##,##0.00")
        Me.BancoCentral.Text = Format(BsXDolarBC, "##,##0.00")
        Me.Efectivo.Text = Format(BsXDolarEfectivo, "##,##0.00")

        Me.Proyectada.Tag = Format(BsXDolar, "##,##0.00")
        Me.Paralelo.Tag = Format(BsXDolarOficial, "##,##0.00")
        Me.BancoCentral.Tag = Format(BsXDolarBC, "##,##0.00")
        Me.Efectivo.Tag = Format(BsXDolarEfectivo, "##,##0.00")
        BancoCentral_Click(Nothing, Nothing)
        LlenarLocales()
        LlenarLocalesLista()
        BBuscar_Click(Nothing, Nothing)
        InicializarFormas()
        LlenarComboDepositos()

        ' LlenarComboProveedoresC()
        LlenarComboCompradores()
        LlenarNumDocumento()
        '   LlenarComboSubCategoriasCF()
        Me.FechaFactura.Text = Format(Date.Now(), "G")
        Me.FechaRegistro.Text = Format(Date.Now(), "G")
        Me.FEchaOrdenC.Text = Format(Date.Now(), "G")

        Me.LIVABs.Text = "0,00"
        Me.LSubTotalBs.Text = "0,00"
        Me.LTotalBs.Text = "0,00"
        Me.LIVAD.Text = "0,00"
        Me.LSubTotalD.Text = "0,00"
        Me.LTotalD.Text = "0,00"
        Me.TGastos.Tag = "0,00"
        Me.TGastos.Tag = "0,00"
        Me.CTipoCompra.Text = "Sin Gastos Asoc."
        Me.CTipoDoc.Text = "Nota Entrega"
        Me.CDeposito.Text = "Planta Baja"
        Me.GridCompra.Rows.Clear()
        '   AuxCambio = True
        ActivarGuardar = False
        Me.Desde.Value = Date.Now()
        Me.Hasta.Value = Date.Now()
        MonedaBase = "Dolar"
        MonedaPago = "Dolar"
        ValidarMonedaBase()

        If (VarForma = "Gastos") Then
            MostrarCompra()
        End If
        If (VarForma = "Recepcion") Then
            If (CompraIngresada) Then             
                MostrarCompra()
            Else
                RecepcionActiva = "Recepcion"
                MostrarDatosRecepcion()
                ValidarDatosRecepcion()
            End If
            CompraIngresada = False
        End If
        Cursor = System.Windows.Forms.Cursors.Default
        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs)
        Dim Total As Integer
        If (Me.GridCompra.Rows.Count > 0) Then
            Me.GridCompra.Rows.RemoveAt(Me.GridCompra.CurrentRow.Index)
            If Me.GridCompra.RowCount >= 1 Then
                For Each row As DataGridViewRow In Me.GridCompra.Rows
                    If (row.Cells("Total").Value = "") Then
                    Else
                        Total += Convert.ToDecimal(row.Cells("Total").Value)
                    End If
                Next
                Me.LTotalD.Text = Format(Total, "##,##0.00")

                ' Me.LIVA.Text = "0"
                ' Me.LIVA.Text = CalcularIVA(Convert.ToDecimal(Me.LTotal.Text), 12) ' arreglar aqui el IVA quitar el 12 por la variable IVA...............
            End If
        Else
            Me.LTotalD.Text = "0"
            ' Me.LIVA.Text = "0"
        End If
    End Sub

    Private Sub GridCompra_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCompra.CellClick
        If (Me.GridCompra.RowCount > 0) Then
            If (Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("SelAlterno").Value) Then
                Me.BUnidAlt.Tag = "Alterna"
                Me.BUnidAlt.Text = "&Unidad" & " (" & VFormat(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("FactorAlt").Value, 2) & ")"
                Me.BUnidAlt.ToolTipText = "Unidad."
                Me.BUnidAlt.BackColor = Color.Gainsboro
            Else
                Me.BUnidAlt.Tag = "Unidad"
                Me.BUnidAlt.Text = "&Unidad Alt."
                Me.BUnidAlt.ToolTipText = "Unidad Alterna."
                Me.BUnidAlt.BackColor = Color.White
            End If

            Me.BGasto.Text = "Gasto: " & Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Gasto").Value
        End If
        Select Case e.ColumnIndex
            Case 0
                VarBuscar = "CompraProd"
                FBuscarOrden.LTitulo.Text = "Listado de Productos Terminados."
                If (Me.GridCompra.RowCount > 0) Then
                    FBuscarOrden.LTitulo.Tag = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
                Else
                    FBuscarOrden.LTitulo.Tag = -1
                End If
                FBuscarOrden.ShowDialog()
                If (Me.GridCompra.RowCount > 0) Then
                    'If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Tipo").Value = 2) Then 'Si el Producto es Compuesto Calcular el Costo.
                    '    If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Empaquetado").Value = True) Then
                    '        ActualizarCostoProductoCompuesto(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("idEmpaquetado").Value, Me.GridCompra)
                    '    Else
                    '        ActualizarCostoProductoCompuesto(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Codigo").Value, Me.GridCompra)
                    '    End If
                    'End If
                    TotalizarLinea(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad").RowIndex)
                    CalcularCostoCalculado(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad").RowIndex)
                    If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Venta").Value = True) Then
                        Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.Red
                    Else
                        Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.White
                    End If
                    If (Me.GridCompra.RowCount > 0) Then
                        Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad")
                        Me.GridCompra.BeginEdit(True)
                    End If

                End If
            Case 12
                BAli_Click(Nothing, Nothing)
                TotalizarLinea(e.RowIndex)
                CalcularCostoCalculado(e.RowIndex)
            Case 20
                BPrecios_Click(Nothing, Nothing)
            Case 21
                VarForma = "ObservacionCompra"
                FComentarioSolo.TComentario.Text = Me.GridCompra.CurrentRow.Cells("ObservacionLineaCompra").Value
                FComentarioSolo.ShowDialog()
            Case 46
                MontoGasto = Me.GridCompra.CurrentRow.Cells("Total").Value
                '   MontoGastoD = Me.GridCompra.CurrentRow.Cells("TotalD").Value
                '  FGastos.TNombre.Text = "Compra de: " & Me.GridCompra.CurrentRow.Cells("Articulo").Value & "."
                idGastoDesdeCompra = IIf(Me.GridCompra.CurrentRow.Cells("Gasto").Value.ToString = "", 0, Me.GridCompra.CurrentRow.Cells("Gasto").Value)
                VarForma = "GastoCompra"
                '    FGastos.ShowDialog()
                Me.GridCompra.CurrentRow.Cells("Gasto").Value = idGastoDesdeCompra
                Me.GridCompra.CurrentRow.DefaultCellStyle.BackColor = IIf(idGastoDesdeCompra = 0, Color.White, Color.LightCoral)
        End Select
    End Sub
    Private Sub CalcularCostoCalculado(Indice As Integer)
        Dim CostoBruto As Decimal = 0
        Dim PorcionImpuesto As Decimal = 0
        Dim NuevoCostoCalculadoSinImpuesto As Decimal = 0
        Dim NuevoCostoCalculadoSinImpuestoD As Decimal = 0
        Dim SumaCostos As Decimal = 0
        If (MonedaBase = "Bolívar") Then
            CostoBruto = Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Costo").Value)
            PorcionImpuesto = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Costo").Value) / 100) * Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("ValorAlicuota").Value) 'Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value) / Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Cantidad").Value)
            SumaCostos = Convert.ToDecimal(IIf(Me.TGastos.Tag = "", 0, Convert.ToDecimal(Me.TGastos.Tag))) + Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoAgregado").Value.ToString)
        Else
            CostoBruto = Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoD").Value)
            PorcionImpuesto = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoD").Value) / 100) * Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("ValorAlicuota").Value) 'Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value) / Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Cantidad").Value)
            SumaCostos = Convert.ToDecimal(IIf(Me.TGastosD.Tag = "", 0, Convert.ToDecimal(Me.TGastosD.Tag))) + Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoAgregado").Value.ToString)
        End If
        Dim Divide As Decimal = SumarColumna(Me.GridCompra, 5)
        Dim PorcionCosto As Decimal = SumaCostos / IIf(Divide = 0, 1, Divide)
        Dim NuevoCostoCalculado As Decimal = 0
        If (Me.CBCompraEnEfectivo.Checked = True) Then
            CalcularEfectivo(Me.FechaFactura.Value.Date, Me.GridCompra.Rows(Indice).Cells("Costo").Value.ToString)
            Me.MPEfectivo.Text = "% Efectivo: " & Format(PorcEfect, "##,##0.0000") & "."
            Me.MPEfectivo.Visible = True
        Else
            MontoEfect = 0
            PorcEfect = 0
        End If

        If (Me.CBIncluirGastos.Checked) Then
            NuevoCostoCalculado = CostoBruto + PorcionCosto + (CostoBruto * PorcEfect) / 100 + PorcionImpuesto
        Else
            NuevoCostoCalculado = CostoBruto
        End If
        If (MonedaBase = "Bolívar") Then
            Me.GridCompra.Rows(Indice).Cells("CostoCal").Value = Format(NuevoCostoCalculado, "##,##0.0000")
            Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value = Format(NuevoCostoCalculado / BsXDolar, "##,##0.0000")
        Else
            Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value = Format(NuevoCostoCalculado, "##,##0.0000")
            Me.GridCompra.Rows(Indice).Cells("CostoCal").Value = Format(NuevoCostoCalculado * BsXDolar, "##,##0.0000")
        End If
        If (Me.BUnidAlt.Tag = "Alterna") Then
            If (Me.GridCompra.Rows(Indice).Cells("CalculoCap").Value) Then
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Costo").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
            Else
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Costo").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("FactorAlt").Value)), "##,##0.0000")
            End If
        Else
            If (Me.GridCompra.Rows(Indice).Cells("CalculoCap").Value) Then
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Costo").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoD").Value) / (Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Capacidad").Value)), "##,##0.0000")
            Else
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value))
                Me.GridCompra.Rows(Indice).Cells("CostoCalUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value))
                Me.GridCompra.Rows(Indice).Cells("CostoUnitario").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("Costo").Value))
                Me.GridCompra.Rows(Indice).Cells("CostoUnitarioD").Value = Format(Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("CostoD").Value))
            End If
        End If
    End Sub
    Private Sub Totalizar()
        Dim TotalD As Decimal = 0
        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim Impuesto As Decimal = 0
        Dim DescuentoX As Decimal = 0
        If Me.GridCompra.RowCount >= 1 Then
            For Each row As DataGridViewRow In Me.GridCompra.Rows
                If (row.Cells("TotalD").Value.ToString <> "") Then
                    TotalD += Convert.ToDecimal(row.Cells("TotalD").Value)
                End If
                If (row.Cells("Total").Value.ToString <> "") Then
                    Total += Convert.ToDecimal(row.Cells("Total").Value)
                End If
                If (row.Cells("SubTotal").Value.ToString <> "") Then
                    SubTotal += Convert.ToDecimal(row.Cells("SubTotal").Value)
                End If
                If (row.Cells("Impuesto").Value.ToString <> "") Then
                    Impuesto += Convert.ToDecimal(row.Cells("Impuesto").Value)
                End If
                If (row.Cells("Descuento").Value.ToString <> "") Then
                    DescuentoX += Convert.ToDecimal(row.Cells("Descuento").Value)
                End If
            Next
        End If
        If (Me.CBIncluirGastos.Checked) Then
            Total = Total + Convert.ToDecimal(Me.TGastos.Tag)
            TotalD = TotalD + Convert.ToDecimal(Me.TGastosD.Tag)
        End If
        Select Case MonedaBase
            Case "Bolívar"
                Me.LIVABs.Text = Format(Impuesto, "##,##0.0000")
                Me.LIVAD.Text = Format(Impuesto / BsXDolar, "##,##0.0000")

                Me.LSubTotalBs.Text = Format(SubTotal, "##,##0.0000")
                Me.LSubTotalD.Text = Format(SubTotal / BsXDolar, "##,##0.0000")

                Me.LDescuentoLinea.Text = Format(DescuentoX, "##,##0.0000")
                Me.LDescuentoLineaD.Text = Format(DescuentoX / BsXDolar, "##,##0.0000")

                Me.LDescuento.Text = Format(NuevoDescuentoGral, "##,##0.0000")
                Me.LDescuentoD.Text = Format(NuevoDescuentoDGral, "##,##0.0000")

                Me.LTotalBs.Text = Format(Total - NuevoDescuentoGral, "##,##0.0000")
                Me.LTotalD.Text = Format(TotalD - NuevoDescuentoDGral, "##,##0.0000")
            Case "Dolar"
                Me.LIVAD.Text = Format(Impuesto, "##,##0.0000")
                Me.LIVABs.Text = Format(Impuesto * BsXDolar, "##,##0.0000")

                Me.LSubTotalD.Text = Format(SubTotal, "##,##0.0000")
                Me.LSubTotalBs.Text = Format(SubTotal * BsXDolar, "##,##0.0000")

                Me.LDescuentoLinea.Text = Format(DescuentoX * BsXDolar, "##,##0.0000")
                Me.LDescuentoLineaD.Text = Format(DescuentoX, "##,##0.0000")

                Me.LDescuento.Text = Format(NuevoDescuentoGral, "##,##0.0000")
                Me.LDescuentoD.Text = Format(NuevoDescuentoDGral, "##,##0.0000")

                Me.LTotalD.Text = Format(TotalD - NuevoDescuentoDGral, "##,##0.0000")
                Me.LTotalBs.Text = Format(Total - NuevoDescuentoGral, "##,##0.0000")
        End Select
    End Sub

    Private Sub TotalizarLinea(Indice As Integer)
        BsXDolar = Convert.ToDecimal(Me.TTasa.Text)
        Select Case MonedaBase
            Case "Bolívar"
                '  Me.GridCompra.Rows(Indice).Cells("Cantidad").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Cantidad").Value), "##,##0.00")
                Me.GridCompra.Rows(Indice).Cells("Costo").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Costo").Value), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("CostoD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Costo").Value) / BsXDolar, "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoCal").Value) / BsXDolar, "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("SubTotal").Value = IIf(Me.GridCompra.Rows(Indice).Cells("Cantidad").Value.ToString = "", 0, (Me.GridCompra.Rows(Indice).Cells("Cantidad").Value) * Me.GridCompra.Rows(Indice).Cells("Costo").Value) - Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Descuento").Value)
                Me.GridCompra.Rows(Indice).Cells("SubTotal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("Impuesto").Value = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value) / 100) * Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("ValorAlicuota").Value)
                Me.GridCompra.Rows(Indice).Cells("Impuesto").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("Total").Value = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value) + Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value))
                Me.GridCompra.Rows(Indice).Cells("Total").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Total").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("TotalD").Value = Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Total").Value) / BsXDolar
                Me.GridCompra.Rows(Indice).Cells("TotalD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("TotalD").Value), "##,##0.0000")
            Case "Dolar"
                Me.GridCompra.Rows(Indice).Cells("CostoD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoD").Value), "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("Costo").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoD").Value) / BsXDolar, "##,##0.0000")
                Me.GridCompra.Rows(Indice).Cells("CostoCal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("CostoCalD").Value) / BsXDolar, "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("SubTotal").Value = IIf(Me.GridCompra.Rows(Indice).Cells("Cantidad").Value.ToString = "", 0, Me.GridCompra.Rows(Indice).Cells("Cantidad").Value) * Me.GridCompra.Rows(Indice).Cells("CostoD").Value - Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Descuento").Value)
                Me.GridCompra.Rows(Indice).Cells("SubTotal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("Impuesto").Value = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value) / 100) * Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("ValorAlicuota").Value)
                Me.GridCompra.Rows(Indice).Cells("Impuesto").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("TotalD").Value = (Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("SubTotal").Value) + Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Impuesto").Value))
                Me.GridCompra.Rows(Indice).Cells("TotalD").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("TotalD").Value), "##,##0.0000")

                Me.GridCompra.Rows(Indice).Cells("Total").Value = Convert.ToDecimal(Me.GridCompra.Rows(Indice).Cells("TotalD").Value.ToString) * BsXDolar
                Me.GridCompra.Rows(Indice).Cells("Total").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Indice).Cells("Total").Value), "##,##0.0000")
        End Select
        Totalizar()
    End Sub

    Private Sub GridCompra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridCompra.CellEndEdit
        Dim Descuento As Decimal = 0
        Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value = IIf(Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value = Nothing, 0, Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value)
        If (Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value.ToString = "") Then
            Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value = "0"
        End If
        If (Me.GridCompra.Columns(e.ColumnIndex).Name = "SubTotal") Then
            Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value = Convert.ToDecimal(Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value) / Me.GridCompra.Rows(e.RowIndex).Cells("Cantidad").Value
            Me.GridCompra.Rows(e.RowIndex).Cells("CostoD").Value = Convert.ToDecimal(Me.GridCompra.Rows(e.RowIndex).Cells("SubTotal").Value) / Me.GridCompra.Rows(e.RowIndex).Cells("Cantidad").Value
        End If

        Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value = IIf(Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value = Nothing, 0, Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value)
        If (Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value.ToString = "") Then
            Me.GridCompra.Rows(e.RowIndex).Cells("Costo").Value = "0"
        End If
        Select Case Me.GridCompra.Columns(e.ColumnIndex).Name
            Case "Costo", "CostoD", "Unidad", "Descuento", "Alicuota", "SubTotal"
                If (MonedaBase = "Bolívar") Then
                    Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
                Else
                    Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
                End If
                Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(Descuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
                TotalizarLinea(e.RowIndex)
                CalcularCostoCalculado(e.RowIndex)
            Case "Cantidad"
                If (MonedaBase = "Bolívar") Then
                    Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
                Else
                    Descuento = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
                End If
                Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(Descuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
                CalcularStock(Me.GridCompra.Rows(e.RowIndex).Cells("Codigo").Value, e.RowIndex)
                TotalizarLinea(e.RowIndex)
                CalcularCostoCalculado(e.RowIndex)
        End Select
    End Sub

    Private Sub BTotalizar_Click(sender As Object, e As EventArgs) Handles BTotalizar.Click
        If Me.GridCompra.RowCount >= 1 Then
            If (Me.CDeposito.Text <> "") Then
                If (Me.TCodProveedor.Text <> "") Then
                    Totalizar()
                    If (Convert.ToDouble(Me.LTotalBs.Text) > 0) Then
                        VarForma = "FTotalizarCompra"
                        FechaXCompra = Me.FechaFactura.Value
                        CodProveedor = Me.TCodProveedor.Text
                        Proveedor = Me.LProveedor2.Text
                        ' FTotalizarCompra.TTasa.Text = Me.TTasa.Text
                        '   FTotalizarCompra.ShowDialog()
                    Else
                        MsgBox("Debe Agregar Productos a la Compra antes de Totalizar. ", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                Else
                    MsgBox("Debe Seleccionar un Proveedor.", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.BProveedor.Focus()
                End If
            Else
                MsgBox("Debe Seleccionar un Depósito", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.CDeposito.Select()
            End If
        Else
            MsgBox("Debe Agregar Productos a la Compra antes de Totalizar. ", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub
    Private Sub ActualizarRecepcion()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TRecepcionPedidos SET Ingresada=1, CodCompra=" & CodCompra & " where idCompra=" & CodRecepcion, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos de la Recepcion de Pedidos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub GuardarCompra()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TCompras(idLocal, idDeposito, idProveedor,Fecha,SubTotal,DescGral,IVA,Total,SubTotalD,DescGralD,IVAD,TotalD,PDF,TipoCompra, idComprador, CompraEnEfectivo, NFactura, NControl, FechaFactura,SerialMaqFiscal,MonedaBase, MonedaPago, TipoDoc, Libro,TasaSel,Usuario, IncluirGastos,FacturaCredito) VALUES(@idLocal, @idDeposito,@idProveedor,@Fecha,@SubTotal,@DescGral,@IVA,@Total,@SubTotalD,@DescGralD,@IVAD,@TotalD,@PDF,@TipoCompra, @idComprador, @CompraEnEfectivo, @NFactura, @NControl, @FechaFactura, @SerialMaqFiscal, @MonedaBase, @MonedaPago, @TipoDoc, @Libro,@TasaSel,@Usuario, @IncluirGastos,@FacturaCredito)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idLocal", Me.CLocal.SelectedValue.ToString))
                Comando.Parameters.Add(New SqlParameter("@idDeposito", Me.CDeposito.SelectedValue.ToString))
                Comando.Parameters.Add(New SqlParameter("@idProveedor", Me.TCodProveedor.Text.ToString))
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaRegistro.Value))
                Comando.Parameters.Add(New SqlParameter("@SubTotal", Convert.ToDecimal(Me.LSubTotalBs.Text)))
                Comando.Parameters.Add(New SqlParameter("@DescGral", Convert.ToDecimal(Me.LDescuento.Text)))
                Comando.Parameters.Add(New SqlParameter("@IVA", Convert.ToDecimal(Me.LIVABs.Text)))
                Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(Me.LTotalBs.Text)))
                Comando.Parameters.Add(New SqlParameter("@SubTotalD", Convert.ToDecimal(Me.LSubTotalD.Text)))
                Comando.Parameters.Add(New SqlParameter("@DescGralD", Convert.ToDecimal(Me.LDescuentoD.Text)))
                Comando.Parameters.Add(New SqlParameter("@IvaD", Convert.ToDecimal(Me.LIVAD.Text)))
                Comando.Parameters.Add(New SqlParameter("@TotalD", Convert.ToDecimal(Me.LTotalD.Text)))
                Comando.Parameters.Add(New SqlParameter("@PDF", Convert.ToInt16(Me.LEvidencia.Tag)))
                Comando.Parameters.Add(New SqlParameter("@TipoCompra", Me.CTipoCompra.Text))
                Comando.Parameters.Add(New SqlParameter("@idComprador", Me.CComprador.SelectedValue.ToString))
                Comando.Parameters.Add(New SqlParameter("@CompraEnEfectivo", Me.CBCompraEnEfectivo.Checked))
                Comando.Parameters.Add(New SqlParameter("@NFactura", Me.TNumFactura.Text.ToString))
                Comando.Parameters.Add(New SqlParameter("@NControl", Me.TNumControl.Text.ToString))
                Comando.Parameters.Add(New SqlParameter("@FechaFactura", Me.FechaFactura.Value))
                Comando.Parameters.Add(New SqlParameter("@SerialMaqFiscal", Me.TSerial.Text.ToString))
                Comando.Parameters.Add(New SqlParameter("@MonedaBase", MonedaBase))
                Comando.Parameters.Add(New SqlParameter("@MonedaPago", MonedaPago))
                Comando.Parameters.Add(New SqlParameter("@TipoDoc", Me.CTipoDoc.Text))
                Comando.Parameters.Add(New SqlParameter("@Libro", Me.CBLibro.Checked))
                Comando.Parameters.Add(New SqlParameter("@TasaSel", Convert.ToDecimal(Me.TTasa.Text)))
                Comando.Parameters.Add(New SqlParameter("@Usuario", UsuarioActivo))
                Comando.Parameters.Add(New SqlParameter("@IncluirGastos", Me.CBIncluirGastos.Checked))
                Comando.Parameters.Add(New SqlParameter("@FacturaCredito", Me.CBFacturaCredito.Checked))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                DataT = New DataTable
                Adaptador = New SqlDataAdapter("Select * FROM TCompras", CNN)
                Adaptador.Fill(DataT)
                Dim Fila As DataRow = DataT.Rows(DataT.Rows.Count - 1)
                CodCompra = Trim(Fila("idcompra").ToString)
                Me.LNumDoc.Text = RellenarCeros(Trim(Fila("idcompra").ToString), 10)
                Desconectar()
                If (RecepcionActiva = "Recepcion") Then
                    ActualizarRecepcion()
                End If

            Catch ex As Exception
                MsgBox("Error al Guardar los Datos de la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If

    End Sub

    Private Sub ActualizarCompra()
        'If (Conectar()) Then
        '    Try
        '        Dim Comando As New SqlCommand("UPDATE  TCompras SET idLocal=@idLocal, idDeposito=@idDeposito, idProveedor=@idProveedor,Fecha=@Fecha,SubTotalD=@SubTotalD,DescGralD=@DescGralD,IVAD=@IVAD,TotalD=@TotalD,SubTotal=@SubTotal,DescGral=@DescGral,IVA=@IVA,Total=@Total,PDF=@PDF, TipoCompra=@TipoCompra, idComprador=@idComprador, CompraEnEfectivo=@CompraEnEfectivo, NFactura=@NFactura,NControl=@NControl, FechaFactura=@FechaFactura,SerialMaqFiscal=@SerialMaqFiscal,MonedaBase=@MonedaBase,MonedaPago=@MonedaPago,TipoDoc=@TipoDoc,Libro=@Libro,TasaSel=@TasaSel, IncluirGastos=@IncluirGastos, FacturaCredito=@FacturaCredito WHERE idCompra=" & CodCompra, CNN)
        '        Comando.Parameters.Add(New SqlParameter("@idLocal", Me.CLocal.SelectedValue.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@idDeposito", Me.CDeposito.SelectedValue.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@idProveedor", Convert.ToInt64(Me.TCodProveedor.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaRegistro.Value))
        '        Comando.Parameters.Add(New SqlParameter("@SubTotal", Convert.ToDecimal(Me.LSubTotalBs.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@DescGral", Convert.ToDecimal(Me.LDescuento.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@IVA", Convert.ToDecimal(Me.LIVABs.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(Me.LTotalBs.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@SubTotalD", Convert.ToDecimal(Me.LSubTotalD.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@DescGralD", Convert.ToDecimal(Me.LDescuentoD.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@IvaD", Convert.ToDecimal(Me.LIVAD.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@TotalD", Convert.ToDecimal(Me.LTotalD.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@PDF", Convert.ToInt16(FFormaPago.BGuardarFactura.Tag)))
        '        Comando.Parameters.Add(New SqlParameter("@TipoCompra", Me.CTipoCompra.Text))
        '        Comando.Parameters.Add(New SqlParameter("@idComprador", Me.CComprador.SelectedValue.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@CompraEnEfectivo", Me.CBCompraEnEfectivo.Checked))
        '        Comando.Parameters.Add(New SqlParameter("@NFactura", Me.TNumFactura.Text.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@NControl", Me.TNumControl.Text.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@FechaFactura", Me.FechaFactura.Value))
        '        Comando.Parameters.Add(New SqlParameter("@SerialMaqFiscal", Me.TSerial.Text.ToString))
        '        Comando.Parameters.Add(New SqlParameter("@MonedaBase", MonedaBase))
        '        Comando.Parameters.Add(New SqlParameter("@MonedaPago", MonedaPago))
        '        Comando.Parameters.Add(New SqlParameter("@TipoDoc", Me.CTipoDoc.Text))
        '        Comando.Parameters.Add(New SqlParameter("@Libro", Me.CBLibro.Checked))
        '        Comando.Parameters.Add(New SqlParameter("@TasaSel", Convert.ToDecimal(Me.TTasa.Text)))
        '        Comando.Parameters.Add(New SqlParameter("@IncluirGastos", Me.CBIncluirGastos.Checked))
        '        Comando.Parameters.Add(New SqlParameter("@FacturaCredito", Me.CBFacturaCredito.Checked))
        '        Dim DR As SqlDataReader = Comando.ExecuteReader()
        '        DR.Close()
        '        Desconectar()
        '    Catch ex As Exception
        '        MsgBox("Error al Guardar los Datos de la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
        '        Desconectar()
        '    End Try
        'End If
    End Sub
    Private Sub GuardarDetalleCompra()
        Dim Cod As String = ""
        For i As Integer = 0 To Me.GridCompra.Rows.Count - 1
            If (Conectar()) Then
                Try
                    Dim Comando As New SqlCommand("INSERT INTO TDetalleCompra(idCompra,idProducto,idUnidad,Cantidad,Stock, Costo,CostoD,Descuento,SubTotal,Impuesto,Alicuota,idAlicuota,ValorAlicuota,TotalD,Total,Balanza,CostoCal, CostoCalD,Precio1,Observaciones,Precio2,Precio3,Precio4,PrecioE,PrecioD1,PrecioD2,PrecioD3,PrecioD4,PrecioDE,UnidadAlt, FactorAlt,CostoAgregado, CostoAgregadoD,Costo2, Costo2D,Tipo,Empaquetado,TipoFactorAlt,Venta,SelAlterno,CostoUnitario,CostoUnitarioD,idCategoriaInt,Capacidad,idGastoCompra, CalculoCap,idUnidadCapacidad,UnidadCapacidad,PorcDesc, PrecioAnt, PrecioAntD) VALUES(@idCompra, @idProducto,@idUnidad,@Cantidad,@Stock1, @Costo,@CostoD,@Descuento,@SubTotal,@Impuesto,@Alicuota,@idAlicuota,@ValorAlicuota,@TotalD,@Total,@Balanza,@CostoCal, @CostoCalD, @Precio1,@Observaciones, @Precio2,@Precio3,@Precio4,@PrecioE,@PrecioD1,@PrecioD2,@PrecioD3,@PrecioD4,@PrecioDE, @UnidadAlt, @FactorAlt, @CostoAgregado, @CostoAgregadoD,@Costo2,@Costo2D,@Tipo,@Empaquetado,@TipoFactorAlt,@Venta,@SelAlterno,@CostoUnitario,@CostoUnitarioD,@idCategoriaInt,@Capacidad,@idGastoCompra,@CalculoCap,@idUnidadCapacidad,@UnidadCapacidad,@PorcDesc, @PrecioAnt, @PrecioAntD)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@idCompra", CodCompra))
                    Comando.Parameters.Add(New SqlParameter("@idProducto", Me.GridCompra.Rows(i).Cells("Codigo").Value))
                    Comando.Parameters.Add(New SqlParameter("@idUnidad", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("idUnidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Cantidad", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Cantidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Stock1", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Stock").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Costo", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Costo").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoD", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Descuento", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Descuento").Value)))
                    Comando.Parameters.Add(New SqlParameter("@SubTotal", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("SubTotal").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Impuesto", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Impuesto").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Alicuota", Me.GridCompra.Rows(i).Cells("Alicuota").Value))
                    Comando.Parameters.Add(New SqlParameter("@idAlicuota", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("idAlicuota").Value)))
                    Comando.Parameters.Add(New SqlParameter("@ValorAlicuota", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("ValorAlicuota").Value)))
                    Comando.Parameters.Add(New SqlParameter("@TotalD", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("TotalD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Total").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Balanza", Me.GridCompra.Rows(i).Cells("Balanza").Value))
                    Comando.Parameters.Add(New SqlParameter("@CostoCal", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCal").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoCalD", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCalD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio1", Convert.ToDecimal(IIf(Me.GridCompra.Rows(i).Cells("Precio1").Value.ToString = "", "0", Me.GridCompra.Rows(i).Cells("Precio1").Value))))
                    Comando.Parameters.Add(New SqlParameter("@Observaciones", Me.GridCompra.Rows(i).Cells("ObservacionLineaCompra").Value))
                    Comando.Parameters.Add(New SqlParameter("@Precio2", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio2").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio3", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio3").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio4", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio4").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioE", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioE").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD1", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD1").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD2", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD2").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD3", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD3").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD4", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD4").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioDE", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioDE").Value)))
                    Comando.Parameters.Add(New SqlParameter("@UnidadAlt", Me.GridCompra.Rows(i).Cells("UnidadAlt").Value))
                    Comando.Parameters.Add(New SqlParameter("@FactorAlt", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("FactorAlt").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoAgregado", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoAgregado").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoAgregadoD", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoAgregadoD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Costo2", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCalUnitario").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Costo2D", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCalUnitarioD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Tipo", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Tipo").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Empaquetado", Me.GridCompra.Rows(i).Cells("Empaquetado").Value))
                    Comando.Parameters.Add(New SqlParameter("@TipoFactorAlt", Me.GridCompra.Rows(i).Cells("TipoFactorAlt").Value))
                    Comando.Parameters.Add(New SqlParameter("@Venta", Me.GridCompra.Rows(i).Cells("Venta").Value))
                    Comando.Parameters.Add(New SqlParameter("@SelAlterno", Me.GridCompra.Rows(i).Cells("SelAlterno").Value))
                    Comando.Parameters.Add(New SqlParameter("@CostoUnitario", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCalUnitario").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoUnitarioD", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCalUnitarioD").Value)))
                    Comando.Parameters.Add(New SqlParameter("@idCategoriaInt", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("idCatInt").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Capacidad", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Capacidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@idGastoCompra", IIf(Me.GridCompra.Rows(i).Cells("Gasto").Value.ToString = "", 0, Me.GridCompra.Rows(i).Cells("Gasto").Value)))
                    Comando.Parameters.Add(New SqlParameter("@CalculoCap", Me.GridCompra.Rows(i).Cells("CalculoCap").Value))
                    Comando.Parameters.Add(New SqlParameter("@idUnidadCapacidad", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("idUnidadCapacidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@UnidadCapacidad", Me.GridCompra.Rows(i).Cells("UnidadCapacidad").Value))
                    Comando.Parameters.Add(New SqlParameter("@PorcDesc", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("DescLinea").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioAnt", Convert.ToDecimal(IIf(Me.GridCompra.Rows(i).Cells("PrecioAnt").Value.ToString = "", "0", Me.GridCompra.Rows(i).Cells("PrecioAnt").Value))))
                    Comando.Parameters.Add(New SqlParameter("@PrecioAntD", Convert.ToDecimal(IIf(Me.GridCompra.Rows(i).Cells("PrecioAntD").Value.ToString = "", "0", Me.GridCompra.Rows(i).Cells("PrecioAntD").Value))))

                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Cod = Me.GridCompra.Rows(i).Cells("Codigo").Value
                    Dim CostoCalculadoD As Decimal = 0
                    Dim CostoCalculado As Decimal = 0

                    Comando.CommandText = "UPDATE TNewProducto SET Costo=@ActCosto,Costo2=@ActCosto2, CostoCalUnid=@CostoCalUnid, CostoD=@ActCostoD,Costo2D=@ActCosto2D, CostoCalUnidD=@CostoCalUnidD, TipoCostoAlt=@TipoCostoAlt, Precio1=@Precio1C,Precio2=@Precio2C,Precio3=@Precio3C,Precio4=@Precio4C, PrecioEfectivo=@PrecioEC,PrecioD1=@PrecioD1C,PrecioD2=@PrecioD2C,PrecioD3=@PrecioD3C,PrecioD4=@PrecioD4C, PrecioEfectivoD=@PrecioDEC,TipoCosto=@TipoCosto, TipoCompra=@TipoCompra, CalculoCap=@CalculoCap WHERE idProducto=" & Cod
                    Comando.Parameters.Add(New SqlParameter("@ActCosto", Convert.ToDecimal(Me.GridCompra.Item("Costo", i).Value)))
                    Comando.Parameters.Add(New SqlParameter("@ActCosto2", Convert.ToDecimal(Me.GridCompra.Item("CostoCal", i).Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoCalUnid", Convert.ToDecimal(Me.GridCompra.Item("CostoCalUnitario", i).Value)))

                    Comando.Parameters.Add(New SqlParameter("@ActCostoD", Convert.ToDecimal(Me.GridCompra.Item("CostoD", i).Value)))
                    Comando.Parameters.Add(New SqlParameter("@ActCosto2D", Convert.ToDecimal(Me.GridCompra.Item("CostoCalD", i).Value)))
                    Comando.Parameters.Add(New SqlParameter("@CostoCalUnidD", Convert.ToDecimal(Me.GridCompra.Item("CostoCalUnitarioD", i).Value)))

                    Comando.Parameters.Add(New SqlParameter("@TipoCostoAlt", Me.GridCompra.Rows(i).Cells("SelAlterno").Value))

                    Comando.Parameters.Add(New SqlParameter("@Precio1C", Convert.ToDecimal(IIf(Me.GridCompra.Rows(i).Cells("Precio1").Value.ToString = "", "0", Me.GridCompra.Rows(i).Cells("Precio1").Value))))
                    Comando.Parameters.Add(New SqlParameter("@Precio2C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio2").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio3C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio3").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio4C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("Precio4").Value))) 'Convert.ToDecimal(Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCal").Value) + (Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("CostoCal").Value) * PPrecio4) / 100)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioEC", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioE").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD1C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD1").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD2C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD2").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD3C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD3").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioD4C", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioD4").Value)))
                    Comando.Parameters.Add(New SqlParameter("@PrecioDEC", Convert.ToDecimal(Me.GridCompra.Rows(i).Cells("PrecioDE").Value)))
                    If (Me.CTipoCompra.Text = "Con Gastos Asoc.") Then
                        Comando.Parameters.Add(New SqlParameter("@TipoCosto", 2))
                        Comando.Parameters.Add(New SqlParameter("@TipoCompra", "Con Gastos Asoc."))
                    Else
                        Comando.Parameters.Add(New SqlParameter("@TipoCosto", 1))
                        Comando.Parameters.Add(New SqlParameter("@TipoCompra", "Sin Gastos Asoc."))
                    End If
                    DR = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                Catch ex As Exception
                    MsgBox("Error al Guardar los Datos del Detalle de la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            End If
        Next
    End Sub
    Private Sub GuardarTotalizar()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TTotalizar(idCompra, NumDoc, TotalBruto, Descuento, Flete, Iva, TotalNeto, TotalCancelado,Saldo,TotalBrutoD, DescuentoD, FleteD, IvaD, TotalNetoD, TotalCanceladoD,SaldoD,FechaEmision,FechaVenc,Resta2,TasaCambioI) VALUES(@idCompra, @NumDoc, @TotalBruto, @Descuento, @Flete, @Iva, @TotalNeto, @TotalCancelado,@Saldo,@TotalBrutoD, @DescuentoD, @FleteD, @IvaD, @TotalNetoD, @TotalCanceladoD,@SaldoD,@FechaEmision,@FechaVenc,@Resta2,@TasaCambioI)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCompra", CodCompra))
                Comando.Parameters.Add(New SqlParameter("@NumDoc", Num_Doc))
                Comando.Parameters.Add(New SqlParameter("@TotalBruto", TotalBruto_))
                Comando.Parameters.Add(New SqlParameter("@Descuento", Descuento_))
                Comando.Parameters.Add(New SqlParameter("@Flete", Flete_))
                Comando.Parameters.Add(New SqlParameter("@iva", IVA_))
                Comando.Parameters.Add(New SqlParameter("@TotalNeto", TotalNeto_))
                Comando.Parameters.Add(New SqlParameter("@TotalCancelado", TotalCancelado_))
                Comando.Parameters.Add(New SqlParameter("@Saldo", Saldo_))
                Comando.Parameters.Add(New SqlParameter("@TotalBrutoD", TotalBrutoD_))
                Comando.Parameters.Add(New SqlParameter("@DescuentoD", DescuentoD_))
                Comando.Parameters.Add(New SqlParameter("@FleteD", FleteD_))
                Comando.Parameters.Add(New SqlParameter("@ivaD", IVAD_))
                Comando.Parameters.Add(New SqlParameter("@TotalNetoD", TotalNetoD_))
                Comando.Parameters.Add(New SqlParameter("@TotalCanceladoD", TotalCanceladoD_))
                Comando.Parameters.Add(New SqlParameter("@SaldoD", SaldoD_))
                Comando.Parameters.Add(New SqlParameter("@FechaEmision", FechaEmision_))
                Comando.Parameters.Add(New SqlParameter("@FechaVenc", FechaVencimiento_))
                Comando.Parameters.Add(New SqlParameter("@Resta2", Saldo_))
                Comando.Parameters.Add(New SqlParameter("@TasaCambioI", BsXDolar))
                Comando.ExecuteReader()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos al Totalizar la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub ActualizarTotalizar()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TTotalizar SET NumDoc=@NumDoc, TotalBruto=@TotalBruto, Descuento=@Descuento, Flete=@Flete, Iva=@Iva, TotalNeto=@TotalNeto, TotalCancelado=@TotalCancelado, Saldo=@Saldo, TotalNetoD=@TotalNetoD, TotalCanceladoD=@TotalCanceladoD, SaldoD=@SaldoD, FechaEmision=@FechaEmision, FechaVenc=@FechaVenc WHERE idCompra=" & CodCompra, CNN)
                Comando.Parameters.Add(New SqlParameter("@NumDoc", Num_Doc))
                Comando.Parameters.Add(New SqlParameter("@TotalBruto", TotalBruto_))
                Comando.Parameters.Add(New SqlParameter("@Descuento", Descuento_))
                Comando.Parameters.Add(New SqlParameter("@Flete", Flete_))
                Comando.Parameters.Add(New SqlParameter("@iva", IVA_))
                Comando.Parameters.Add(New SqlParameter("@TotalNeto", TotalNeto_))
                Comando.Parameters.Add(New SqlParameter("@TotalCancelado", TotalCancelado_))
                Comando.Parameters.Add(New SqlParameter("@Saldo", Saldo_))

                Comando.Parameters.Add(New SqlParameter("@TotalNetoD", TotalNetoD_))
                Comando.Parameters.Add(New SqlParameter("@TotalCanceladoD", TotalCanceladoD_))
                Comando.Parameters.Add(New SqlParameter("@SaldoD", SaldoD_))

                Comando.Parameters.Add(New SqlParameter("@FechaEmision", FechaEmision_))
                Comando.Parameters.Add(New SqlParameter("@FechaVenc", FechaVencimiento_))
                Comando.ExecuteReader()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar los Datos al Totalizar la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

    Public Sub GuardarFormaPago()
        'If (Conectar()) Then
        '    Try
        '        Dim Comando As New SqlCommand("DELETE FROM TFormasPago WHERE idCompra=" & 1, CNN)
        '        Comando.ExecuteReader()
        '        Desconectar()
        '    Catch ex As Exception
        '        MsgBox("Error al Eliminar Datos Formas Pago.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
        '        Desconectar()
        '    End Try
        'End If
        'For i As Integer = 0 To FFormaPago.GridFormaPago.Rows.Count - 1
        '    If (Conectar()) Then
        '        Try
        '            Dim Comando As New SqlCommand("INSERT INTO TFormasPago(idCompra,Programado, Fecha, Monto,FechaR, MontoRD, MontoR, TipoMoneda, Tipo,PTP, Comentario, PDF, MontoEfectivo, PorcEfectivo, Tasa) VALUES(@idCompra, @Programado, @Fecha, @Monto,@FechaR, @MontoRD,@MontoR, @TipoMoneda, @Tipo, @PTP, @Comentario,@PDF, @MontoEfectivo, @PorcEfectivo, @Tasa)", CNN)
        '            Comando.Parameters.Add(New SqlParameter("@idCompra", CodCompra))
        '            Comando.Parameters.Add(New SqlParameter("@Programado", FFormaPago.GridFormaPago.Rows(i).Cells("Programado").Value))
        '            Comando.Parameters.Add(New SqlParameter("@Fecha", Convert.ToDateTime(FFormaPago.GridFormaPago.Rows(i).Cells("Fecha").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("Monto").Value)))
        '            If (FFormaPago.GridFormaPago.Rows(i).Cells("FRP").Value = "") Then
        '                Comando.Parameters.Add(New SqlParameter("@FechaR", Convert.ToDateTime("01/01/2000")))
        '            Else
        '                Comando.Parameters.Add(New SqlParameter("@FechaR", Convert.ToDateTime(FFormaPago.GridFormaPago.Rows(i).Cells("FRP").Value)))
        '            End If
        '            If (FFormaPago.GridFormaPago.Rows(i).Cells("MRPD").Value.ToString = "") Then
        '                Comando.Parameters.Add(New SqlParameter("@MontoRD", "0"))
        '            Else
        '                Comando.Parameters.Add(New SqlParameter("@MontoRD", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MRPD").Value)))
        '            End If
        '            If (FFormaPago.GridFormaPago.Rows(i).Cells("MRP").Value.ToString = "") Then
        '                Comando.Parameters.Add(New SqlParameter("@MontoR", "0"))
        '            Else
        '                Comando.Parameters.Add(New SqlParameter("@MontoR", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MRP").Value)))
        '            End If
        '            Comando.Parameters.Add(New SqlParameter("@TipoMoneda", Convert.ToString(FFormaPago.GridFormaPago.Rows(i).Cells("TipoMoneda").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@Tipo", Convert.ToString(FFormaPago.GridFormaPago.Rows(i).Cells("Tipo").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@PTP", FFormaPago.GridFormaPago.Rows(i).Cells("PTP").Value))
        '            Comando.Parameters.Add(New SqlParameter("@Comentario", Convert.ToString(FFormaPago.GridFormaPago.Rows(i).Cells("Comentario").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@PDF", Convert.ToInt16(FFormaPago.GridFormaPago.Rows(i).Cells("PDF").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@MontoEfectivo", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MontoEfectivo").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@PorcEfectivo", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("PorcEfectivo").Value)))
        '            Comando.Parameters.Add(New SqlParameter("@Tasa", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("Tasa").Value)))

        '            'Comando.Parameters.Add(New SqlParameter("@Programado", FFormaPago.GridFormaPago.Rows(i).Cells("Programado").Value))
        '            'Comando.Parameters.Add(New SqlParameter("@Fecha", Convert.ToDateTime(FFormaPago.GridFormaPago.Rows(i).Cells("Fecha").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("Monto").Value)))
        '            'If (FFormaPago.GridFormaPago.Rows(i).Cells("FRP").Value = "") Then
        '            '    Comando.Parameters.Add(New SqlParameter("@FechaR", Convert.ToDateTime("01/01/2000")))
        '            'Else
        '            '    Comando.Parameters.Add(New SqlParameter("@FechaR", Convert.ToDateTime(FFormaPago.GridFormaPago.Rows(i).Cells("FRP").Value)))
        '            'End If
        '            'If (FFormaPago.GridFormaPago.Rows(i).Cells("MRP").Value = "") Then
        '            '    Comando.Parameters.Add(New SqlParameter("@MontoR", "0"))
        '            'Else
        '            '    Comando.Parameters.Add(New SqlParameter("@MontoR", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MRP").Value)))
        '            'End If
        '            '' Comando.Parameters.Add(New SqlParameter("@FechaR", Convert.ToDateTime(FFormaPago.GridFormaPago.Rows(i).Cells("FRP").Value)))
        '            '' Comando.Parameters.Add(New SqlParameter("@MontoR", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MRP").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@Tipo", Convert.ToString(FFormaPago.GridFormaPago.Rows(i).Cells("Tipo").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@PTP", FFormaPago.GridFormaPago.Rows(i).Cells("PTP").Value))
        '            'Comando.Parameters.Add(New SqlParameter("@Comentario", Convert.ToString(FFormaPago.GridFormaPago.Rows(i).Cells("Comentario").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@PDF", Convert.ToInt16(FFormaPago.GridFormaPago.Rows(i).Cells("PDF").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@MontoEfectivo", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("MontoEfectivo").Value)))
        '            'Comando.Parameters.Add(New SqlParameter("@PorcEfectivo", Convert.ToDecimal(FFormaPago.GridFormaPago.Rows(i).Cells("PorcEfectivo").Value)))
        '            Comando.ExecuteReader()
        '            Desconectar()
        '        Catch ex As Exception
        '            MsgBox("Error al Guardar los Datos de Formas de Pago de la Compra.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
        '            Desconectar()
        '        End Try
        '    End If
        ' Next
    End Sub
    Private Sub InicializarFormas()
        Me.TCodImprimir.Text = ""
        'FTotalizarCompra.TNumDoc.Text = ""
        'FTotalizarCompra.TTotalBruto.Text = ""
        'FTotalizarCompra.TDescuento.Text = ""
        'FTotalizarCompra.TFlete.Text = ""
        'FTotalizarCompra.TIVA.Text = ""
        'FTotalizarCompra.TTotalNeto.Text = ""
        'FTotalizarCompra.TTotalCancelado.Text = ""
        'FTotalizarCompra.TSaldo.Text = ""
        'FTotalizarCompra.FechaEmision.Value = DateTime.Now()
        'FTotalizarCompra.FechaVenc.Value = DateTime.Now()
        Me.TCodProveedor.Text = ""
        Me.LProveedor2.Text = ""
        Me.LAlias2.Text = ""
        Me.TRIF.Text = ""
        Me.FechaFactura.Text = Format(Date.Now(), "G")
        Me.FechaRegistro.Text = Format(Date.Now(), "G")
        Me.FEchaOrdenC.Text = Format(Date.Now(), "G")
        Me.LIVABs.Text = "0.00"
        Me.LSubTotalBs.Text = "0.00"
        Me.LTotalBs.Text = "0.00"
        Me.LIVAD.Text = "0.00"
        Me.LSubTotalD.Text = "0.00"
        Me.LTotalD.Text = "0.00"
        Me.LDescuento.Text = "0.00"
        Me.LDescuentoD.Text = "0.00"
        Me.CTipoCompra.Text = "Sin Gastos Asoc."
        Me.CTipoDoc.Text = "Nota Entrega"
        Me.CComprador.Text = ""
        Me.CDeposito.Text = "Planta Baja"
        Me.TGastos.Text = "Bs. 0.00"
        Me.TGastosD.Text = "$. 0.00"
        Me.TGastosD.Tag = "0.00"
        Me.TGastos.Tag = "0.00"
        Me.TNumFactura.Text = ""
        Me.TNumControl.Text = ""
        Me.GridCompra.Rows.Clear()
        ActivarGuardar = False
        Me.BGuardar.Enabled = True
        Me.BActualizar.Enabled = False
        Me.BUnidAlt.Tag = "Unidad"
        Me.BUnidAlt.Text = "&Unidad Alt."
        Me.BUnidAlt.ToolTipText = "Unidad Alterna."
        LlenarNumDocumento()
        MonedaBase = "Dolar"
        MonedaPago = "Dolar"
        BMonedaBase.Image = Me.ImagenD.Image
        BMonedaPago.Image = Me.ImagenD.Image
        BancoCentral_Click(Nothing, Nothing)
        NuevoCosto = 0
        NuevoCostoD = 0
        NuevoDescuento = 0
        NuevoDescuentoD = 0
        NuevoDescuentoGral = 0
        NuevoDescuentoDGral = 0
        NuevoPorcGral = 0
        Me.TUsuario.Text = UsuarioActivo
        CodPDF = 0
        Me.BPDF.Tag = 0
        Me.BPDF.Text = "Factura: 0"
        Me.CLocal.Text = ""
        Me.CBLibro.Checked = False
    End Sub


    Private Sub RestaurarFormas()
        Me.TCodImprimir.Text = ""
        'FTotalizarCompra.TNumDoc.Text = ""
        'FTotalizarCompra.TTotalBruto.Text = ""
        'FTotalizarCompra.TDescuento.Text = ""
        'FTotalizarCompra.TFlete.Text = ""
        'FTotalizarCompra.TIVA.Text = ""
        'FTotalizarCompra.TTotalNeto.Text = ""
        'FTotalizarCompra.TTotalCancelado.Text = ""
        'FTotalizarCompra.TSaldo.Text = ""
        'FTotalizarCompra.FechaEmision.Value = DateTime.Now()
        'FTotalizarCompra.FechaVenc.Value = DateTime.Now()
        'Me.TCodProveedor.Text = ""
        'Me.LProveedor2.Text = ""
        'Me.LAlias2.Text = ""
        'Me.TRIF.Text = ""
        Me.FechaFactura.Text = Format(Date.Now(), "G")
        Me.FechaRegistro.Text = Format(Date.Now(), "G")
        Me.FEchaOrdenC.Text = Format(Date.Now(), "G")
        Me.LIVABs.Text = "0.00"
        Me.LSubTotalBs.Text = "0.00"
        Me.LTotalBs.Text = "0.00"
        Me.LIVAD.Text = "0.00"
        Me.LSubTotalD.Text = "0.00"
        Me.LTotalD.Text = "0.00"
        Me.LDescuento.Text = "0.00"
        Me.LDescuentoD.Text = "0.00"
        Me.CTipoCompra.Text = "Sin Gastos Asoc."
        Me.CTipoDoc.Text = "Nota Entrega"
        Me.CDeposito.Text = "Planta Baja"
        Me.TGastos.Text = "Bs. 0.00"
        Me.TGastosD.Text = "$. 0.00"
        Me.TGastosD.Tag = "0.00"
        Me.TGastos.Tag = "0.00"
        Me.TNumFactura.Text = ""
        Me.TNumControl.Text = ""
        ActivarGuardar = False
        Me.BGuardar.Enabled = True
        Me.BActualizar.Enabled = False
        Me.BUnidAlt.Tag = "Unidad"
        Me.BUnidAlt.Text = "&Unidad Alt."
        Me.BUnidAlt.ToolTipText = "Unidad Alterna."
        LlenarNumDocumento()
        '    MonedaBase = "Dolar"
        '  MonedaPago = "Dolar"
        '  BMonedaBase.Image = Me.ImagenD.Image
        '  BMonedaPago.Image = Me.ImagenD.Image
        BancoCentral_Click(Nothing, Nothing)
        NuevoCosto = 0
        NuevoCostoD = 0
        NuevoDescuento = 0
        NuevoDescuentoD = 0
        NuevoDescuentoGral = 0
        NuevoDescuentoDGral = 0
        NuevoPorcGral = 0
        Me.TUsuario.Text = UsuarioActivo
        Totalizar()
    End Sub

    Function VefificarDatos() As Boolean
        Dim Valor As Boolean = True
        Valor = DatosCompletosMayorCero(Me.GridCompra, 7)
        If (Valor = False) Then
            MsgBox("Vefifique los Costos, No pueden Ser Vacios. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
            Return (Valor)
        Else
            Valor = DatosPreciosCompletosMayorCero(Me.GridCompra, 19)
            If (Valor = False) Then
                MsgBox("Vefifique los Precios de los Productos para la Venta. (Resaltados en Rojo). ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
                Return (Valor)
            Else
                Valor = DatosCompletosMayorCero(Me.GridCompra, 5)
                If (Valor = False) Then
                    MsgBox("Vefifique la Cantidad del Producto a Comprar, No pueden Ser Vacios. ", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
                    Return (Valor)
                End If
            End If
        End If
        Return Valor
    End Function


    ' Calculo de Actualizar Costos a Productos Compuestos''''''''''''''''''''''

    Private Sub LlenarPanCompuesto(Codigo As Integer)
        Try
            If (Conectar4()) Then
                Dim Comando4 As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY CostoED DESC) AS Num, Principal, Externo,Excluir, idIngrediente,Ingrediente,idUnidad,Unidad, CantIng,PorcIng, id,CantIngE,CostoED,CostoE,PorcCostoE,CantIngU,CostoUD,CostoU,idCategoriaInt, PorcIngTotal,IdTipoProducto FROM VRecetaGuardada WHERE idProducto=" & Codigo, CNN4)
                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                Me.DGIngrediente2.Rows.Clear()
                Do While DR4.Read()
                    Me.DGIngrediente2.Rows.Add(DR4("id"), DR4("Num"), DR4("Principal"), DR4("Externo"), DR4("Excluir"), DR4("idIngrediente"), DR4("Ingrediente"), DR4("idUnidad"), DR4("Unidad"), Format(DR4("CantIng"), "##,##0.00"), Format(DR4("PorcIng"), "##,##0.00"), Format(DR4("PorcIngTotal"), "##,##0.00"), DR4("idCategoriaInt"), DR4("CantIngE").ToString, DR4("CostoED").ToString, DR4("CostoE").ToString, DR4("PorcCostoE"), DR4("CantIngU").ToString, DR4("CostoUD").ToString, DR4("CostoU").ToString, DR4("idTipoProducto"))
                Loop
                DR4.Close()
            End If
            Desconectar4()
        Catch ex As Exception
            MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar4()
        End Try
    End Sub

    Private Sub BuscarCostoCategoriaInterna(idCatInt As Integer)
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select * FROM VProductoCosto WHERE idCategoriaInt=" & idCatInt & " ORDER BY Fecha DESC, Costo2D DESC", CNN2)
            Dim DR2 As SqlDataReader = Comando2.ExecuteReader()
            If (DR2.Read() = True) Then
                N_UnidadProducto = DR2("UnidadProd")
                N_Costo2D = DR2("CostoCalUnidD")
                N_Costo2 = N_Costo2D * BsXDolar
                N_CostoCalD = DR2("Costo2D")
                N_Capacidad = DR2("Capacidad").ToString
                N_idUnidadCapacidad = DR2("idUnidadCapacidad")
                N_UnidadCapacidad = DR2("UnidadCapacidad")
            Else
                N_UnidadProducto = ""
                N_Costo2D = 0
                N_Costo2 = 0
                N_Capacidad = 1
                N_idUnidadCapacidad = 0
                N_UnidadCapacidad = ""
            End If
            DR2.Close()
        End If
        Desconectar2()
    End Sub
    Private Sub NuevoCostoCalculadoUnidadComp()
        Dim CostoX As Decimal = 0
        Dim CostoDX As Decimal = 0
        For i = 0 To Me.DGIngrediente2.RowCount - 2
            CostoDX = Format(CalcularCostoCompuestoFinal(Me.DGIngrediente2.Item("CantIngUnidad2", i).Value, Me.DGIngrediente2.Item("idUnidad2", i).Value, Me.DGIngrediente2.Item("Capacidad2", i).Value, Me.DGIngrediente2.Item("idUnidadCapacidad2", i).Value, Me.DGIngrediente2.Item("Costo2D2", i).Value), "##,##0.0000")
            CostoX = Format(CostoDX * BsXDolar, "##,##0.0000")
            Me.DGIngrediente2.Item("CostoDU2", i).Value = CostoDX
            Me.DGIngrediente2.Item("CostoU2", i).Value = CostoX




            'If (CostoX Mod 1) = 0 Then
            '    Me.DGIngrediente2.Item("CostoU2", i).Value = Format(CostoX, "##,##0.0000")
            'Else
            '    Me.DGIngrediente2.Item("CostoU2", i).Value = Format(CostoX, "##,##0.0000")
            'End If
            'If (CostoDX Mod 1) = 0 Then
            '    Me.DGIngrediente2.Item("CostoDU2", i).Value = Format(CostoDX, "##,##0.0000")
            'Else
            '    Me.DGIngrediente2.Item("CostoDU2", i).Value = Format(CostoDX, "##,##0.0000")
            'End If
        Next
    End Sub
    Private Sub LlenarEmpaquetado(Codigo As String)
        If (Codigo <> "") Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("Select idIngrediente,CostoTotal, CostoTotalD, Cantidad FROM VCostoProdEmp WHERE idProducto=" & Codigo, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    Me.DGEmpaquetado.Rows.Clear()
                    Do While DR.Read()
                        Me.DGEmpaquetado.Rows.Add(DR("idIngrediente"), DR("Cantidad"), DR("CostoTotalD"), DR("CostoTotal"))
                    Loop
                    DR.Close()
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

    Private Sub ActualizarCostoProductoCompuesto(CodProdCalcular As String, Emp As Boolean)
        Try
            If (Emp = 0) Then
                LlenarPanCompuesto(CodProdCalcular)
                For i = 0 To Me.DGIngrediente2.RowCount - 1
                    If (Conectar3()) Then
                        '  Dim Comando3 As New SqlCommand("Select Costo, CostoD,Costo2, Costo2D, Capacidad,idUnidadCapacidad,UnidadCapacidad,idUnidadAlt,UnidadAlt,FactorAlt, TipoFactorAlt, UnidadProd,idCategoriaInt,CalculoCap FROM VEscalarOtros WHERE idProducto=" & CodProdCalcular & " AND id=" & Me.DGIngrediente2.Item("id2", i).Value, CNN3)
                        Dim Comando3 As New SqlCommand("Select idUnidad,Unidad, CostoCalUnidD, Capacidad,idUnidadCapacidad,UnidadCapacidad, idCategoriaInt, Costo2D,TipoCostoAlt,UnidadAlt FROM VNewProducto WHERE idProducto=" & Me.DGIngrediente2.Item("idIngrediente2", i).Value, CNN3)





                        Dim DR3 As SqlDataReader = Comando3.ExecuteReader()
                        If (DR3.Read() = True) Then
                            If (DR3("idCategoriaInt") = 1) Then
                                'N_CostoD = DR3("CostoD")
                                'N_Costo = DR3("Costo")
                                'N_PorcCosto = 0
                                'N_Costo2D = DR3("Costo2D")
                                'N_Costo2 = N_Costo2D * BsXDolar
                                'N_Capacidad = DR3("Capacidad").ToString
                                'N_UnidadCapacidad = DR3("UnidadCapacidad").ToString
                                'N_idUnidadCapacidad = DR3("idUnidadCapacidad").ToString
                                'N_idUnidadAlterna = DR3("idUnidadAlt").ToString
                                'N_UnidadAlterna = DR3("UnidadAlt").ToString
                                'N_FactorAterno = DR3("FactorAlt").ToString
                                'N_TipoFactorAlterno = DR3("TipoFactorAlt").ToString
                                'N_UnidadProducto = DR3("UnidadProd").ToString
                                'N_CalculoCap = DR3("CalculoCap")



                                N_UnidadProducto = DR3("Unidad")
                                N_Costo2D = DR3("CostoCalUnidD")
                                N_Costo2 = N_Costo2D * BsXDolarBC ' Se Convierte el Valor de Dolar a Bs. con la Tasa Actual del Banco central
                                N_Capacidad = DR3("Capacidad")
                                N_idUnidadCapacidad = DR3("idUnidadCapacidad")
                                N_UnidadCapacidad = DR3("UnidadCapacidad")
                                N_CostoCalD = DR3("Costo2D")









                            Else
                                BuscarCostoCategoriaInterna(DR3("idCategoriaInt"))
                            End If
                            'Me.DGIngrediente2.Item("CostoD2", i).Value = Format(N_CostoD, "##,##0.00")
                            'Me.DGIngrediente2.Item("Costo22", i).Value = Format(N_Costo, "##,##0.00")
                            'Me.DGIngrediente2.Item("PorcCosto2", i).Value = 0
                            'Me.DGIngrediente2.Item("Costo2D2", i).Value = Format(N_Costo2D, "##,##0.00")
                            'Me.DGIngrediente2.Item("Costo222", i).Value = Format(N_Costo2, "##,##0.00")
                            'Me.DGIngrediente2.Item("Capacidad2", i).Value = N_Capacidad
                            'Me.DGIngrediente2.Item("UnidadCapacidad2", i).Value = N_UnidadCapacidad
                            'Me.DGIngrediente2.Item("idUnidadCapacidad2", i).Value = N_idUnidadCapacidad
                            'Me.DGIngrediente2.Item("idUnidadAlt2", i).Value = N_idUnidadAlterna
                            'Me.DGIngrediente2.Item("UnidadAlt2", i).Value = N_UnidadAlterna
                            'Me.DGIngrediente2.Item("FactorAlt2", i).Value = N_FactorAterno
                            'Me.DGIngrediente2.Item("TipoFactorAlt2", i).Value = N_TipoFactorAlterno
                            'Me.DGIngrediente2.Item("UnidadProd2", i).Value = N_UnidadProducto
                            'Me.DGIngrediente2.Item("CalculoCap2", i).Value = N_CalculoCap


                            Me.DGIngrediente2.Item("CostoD2", i).Value = Format(N_CostoD, "##,##0.0000")
                            Me.DGIngrediente2.Item("Costo22", i).Value = Format(N_Costo, "##,##0.0000")
                            Me.DGIngrediente2.Item("PorcCosto2", i).Value = 0
                            Me.DGIngrediente2.Item("Costo2D2", i).Value = Format(N_Costo2D, "##,##0.0000")
                            Me.DGIngrediente2.Item("Costo222", i).Value = Format(N_Costo2, "##,##0.0000")
                            Me.DGIngrediente2.Item("Capacidad2", i).Value = N_Capacidad
                            Me.DGIngrediente2.Item("UnidadCapacidad2", i).Value = N_UnidadCapacidad
                            Me.DGIngrediente2.Item("idUnidadCapacidad2", i).Value = N_idUnidadCapacidad
                            Me.DGIngrediente2.Item("idUnidadAlt2", i).Value = N_idUnidadAlterna
                            Me.DGIngrediente2.Item("UnidadAlt2", i).Value = N_UnidadAlterna
                            Me.DGIngrediente2.Item("FactorAlt2", i).Value = N_FactorAterno
                            Me.DGIngrediente2.Item("TipoFactorAlt2", i).Value = N_TipoFactorAlterno
                            Me.DGIngrediente2.Item("UnidadProd2", i).Value = N_UnidadProducto
                            Me.DGIngrediente2.Item("CalculoCap2", i).Value = N_CalculoCap

















                        End If
                        DR3.Close()
                    End If
                    Desconectar3()
                Next
                NuevoCostoCalculadoUnidadComp()
                NuevoCosto = SumarColumna(DGIngrediente2, 19)
                NuevoCostoD = SumarColumna(DGIngrediente2, 18)
            Else
                LlenarEmpaquetado(CodProdCalcular)
                NuevoCosto = SumarColumna(DGEmpaquetado, 3)
                NuevoCostoD = SumarColumna(DGEmpaquetado, 2)
            End If
            If (NuevoCostoD <> 0) Then
                If (Conectar4()) Then
                    Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2, CostoCalUnidD=@CostoCalUnidD,CostoCalUnid=@CostoCalUnid WHERE idProducto=" & CodProdCalcular, CNN4)
                    Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
                    Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
                    Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
                    Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnidD", NuevoCostoD))
                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnid", NuevoCosto))
                    Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                    DR4.Close()
                End If
                Desconectar4()
            End If
        Catch ex As Exception
            MsgBox("Error al Actualizar Costos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar3()
            Desconectar4()
        End Try
    End Sub
    'Private Sub ActualizarCostoProductoCompuesto(CodProdCalcular As String, Emp As Boolean)
    '    Try
    '        If (Emp = 0) Then
    '            LlenarPanCompuesto(CodProdCalcular)
    '            For i = 0 To Me.DGIngrediente2.RowCount - 1
    '                If (Conectar3()) Then
    '                    Dim Comando3 As New SqlCommand("Select Costo, CostoD,Costo2, Costo2D, Capacidad,idUnidadCapacidad,UnidadCapacidad,idUnidadAlt,UnidadAlt,FactorAlt, TipoFactorAlt, UnidadProd,idCategoriaInt,CalculoCap FROM VEscalarOtros WHERE idProducto=" & CodProdCalcular & " AND id=" & Me.DGIngrediente2.Item("id2", i).Value, CNN3)
    '                    Dim DR3 As SqlDataReader = Comando3.ExecuteReader()
    '                    If (DR3.Read() = True) Then
    '                        If (DR3("idCategoriaInt") = 1) Then
    '                            N_CostoD = DR3("CostoD")
    '                            N_Costo = DR3("Costo")
    '                            N_PorcCosto = 0
    '                            N_Costo2D = DR3("Costo2D")
    '                            N_Costo2 = Me.DGIngrediente2.Item("Costo2D2", i).Value * BsXDolar
    '                            N_Capacidad = DR3("Capacidad").ToString
    '                            N_UnidadCapacidad = DR3("UnidadCapacidad").ToString
    '                            N_idUnidadCapacidad = DR3("idUnidadCapacidad").ToString
    '                            N_idUnidadAlterna = DR3("idUnidadAlt").ToString
    '                            N_UnidadAlterna = DR3("UnidadAlt").ToString
    '                            N_FactorAterno = DR3("FactorAlt").ToString
    '                            N_TipoFactorAlterno = DR3("TipoFactorAlt").ToString
    '                            N_UnidadProducto = DR3("UnidadProd").ToString
    '                            N_CalculoCap = DR3("CalculoCap")
    '                        Else
    '                            BuscarCostoCategoriaInterna(DR3("idCategoriaInt"))
    '                        End If
    '                        Me.DGIngrediente2.Item("CostoD2", i).Value = Format(N_CostoD, "##,##0.00")
    '                        Me.DGIngrediente2.Item("Costo22", i).Value = Format(N_Costo, "##,##0.00")
    '                        Me.DGIngrediente2.Item("PorcCosto2", i).Value = 0
    '                        Me.DGIngrediente2.Item("Costo2D2", i).Value = Format(N_Costo2D, "##,##0.00")
    '                        Me.DGIngrediente2.Item("Costo222", i).Value = Format(N_Costo2, "##,##0.00")
    '                        Me.DGIngrediente2.Item("Capacidad2", i).Value = N_Capacidad
    '                        Me.DGIngrediente2.Item("UnidadCapacidad2", i).Value = N_UnidadCapacidad
    '                        Me.DGIngrediente2.Item("idUnidadCapacidad2", i).Value = N_idUnidadCapacidad
    '                        Me.DGIngrediente2.Item("idUnidadAlt2", i).Value = N_idUnidadAlterna
    '                        Me.DGIngrediente2.Item("UnidadAlt2", i).Value = N_UnidadAlterna
    '                        Me.DGIngrediente2.Item("FactorAlt2", i).Value = N_FactorAterno
    '                        Me.DGIngrediente2.Item("TipoFactorAlt2", i).Value = N_TipoFactorAlterno
    '                        Me.DGIngrediente2.Item("UnidadProd2", i).Value = N_UnidadProducto
    '                        Me.DGIngrediente2.Item("CalculoCap2", i).Value = N_CalculoCap
    '                    End If
    '                    DR3.Close()
    '                End If
    '                Desconectar3()
    '            Next
    '            NuevoCostoCalculadoUnidadComp()
    '            NuevoCosto = SumarColumna(DGIngrediente2, 19)
    '            NuevoCostoD = NuevoCosto * BsXDolar
    '        Else
    '            LlenarEmpaquetado(CodProdCalcular)
    '            NuevoCosto = SumarColumna(DGEmpaquetado, 3)
    '            NuevoCostoD = NuevoCosto * BsXDolar
    '        End If
    '        If (NuevoCostoD <> 0) Then
    '            If (Conectar4()) Then
    '                Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2, CostoCalUnitD=@CostoCalUnitD,CostoCalUnit=@CostoCalUnit WHERE idProducto=" & CodProdCalcular, CNN4)
    '                Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
    '                Comando4.Parameters.Add(New SqlParameter("@CostoCalUnidD", NuevoCostoD))
    '                Comando4.Parameters.Add(New SqlParameter("@CostoCalUnid", NuevoCosto))
    '                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
    '                DR4.Close()
    '            End If
    '            Desconectar4()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error al Actualizar Costos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '        Desconectar3()
    '        Desconectar4()
    '    End Try
    'End Sub
    Private Sub VefiricarCostos(CodigoProd As String)
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY CostoED DESC) AS Num, Principal, Externo,Excluir, idIngrediente,Ingrediente,idUnidad,Unidad, CantIng,PorcIng, id,CantIngE,CostoED,CostoE,PorcCostoE,CantIngU,CostoUD,CostoU,idCategoriaInt, PorcIngTotal, idTipoProducto, Empaquetado, idProdEmpaquetado, CantEmpaquetado FROM VRecetaGuardada WHERE idProducto=" & CodigoProd, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Me.DGIngrediente.Rows.Clear()
                Do While DR.Read()
                    If (DR("idTipoProducto") = 2) Then
                        ActualizarCostoProductoCompuesto(DR("idIngrediente"), DR("Empaquetado"))
                    End If
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try
    End Sub

    Private Sub LlenarPan(Codigo As String)
        If (Codigo <> "") Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY CostoED DESC) AS Num, Principal, Externo,Excluir, idIngrediente,Ingrediente,idUnidad,Unidad, CantIng,PorcIng, id,CantIngE,CostoED,CostoE,PorcCostoE,CantIngU,CostoUD,CostoU,idCategoriaInt, PorcIngTotal, idTipoProducto FROM VRecetaGuardada WHERE idProducto=" & Codigo, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    Me.DGIngrediente.Rows.Clear()
                    Do While DR.Read()
                        Me.DGIngrediente.Rows.Add(DR("id"), DR("Num"), DR("Principal"), DR("Externo"), DR("Excluir"), DR("idIngrediente"), DR("Ingrediente"), DR("idUnidad"), DR("Unidad"), Format(DR("CantIng"), "##,##0.00"), Format(DR("PorcIng"), "##,##0.00"), Format(DR("PorcIngTotal"), "##,##0.00"), DR("idCategoriaInt"), DR("CantIngE").ToString, DR("CostoED").ToString, DR("CostoE").ToString, DR("PorcCostoE"), DR("CantIngU").ToString, DR("CostoUD").ToString, DR("CostoU").ToString, "", "", "", "", "", "", "", "", "", "", "", DR("idTipoProducto"))
                    Loop
                    DR.Close()
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub NuevoCostoCalculadoUnidad()
        Dim CostoX As Decimal = 0
        Dim CostoDX As Decimal = 0
        For i = 0 To DGIngrediente.RowCount - 2
            CostoDX = Format(CalcularCostoCompuestoFinal(Me.DGIngrediente.Item("CantIngUnidadX", i).Value, Me.DGIngrediente.Item("idUnidadX", i).Value, Me.DGIngrediente.Item("CapacidadX", i).Value, Me.DGIngrediente.Item("idUnidadCapacidadX", i).Value, Me.DGIngrediente.Item("Costo2DX", i).Value), "##,##0.0000")
            CostoX = Format(CostoDX * BsXDolar, "##,##0.0000")
            Me.DGIngrediente.Item("CostoUX", i).Value = CostoX
            Me.DGIngrediente.Item("CostoDUX", i).Value = CostoDX

            'If (CostoX Mod 1) = 0 Then
            '    Me.DGIngrediente.Item("CostoUX", i).Value = Format(CostoX, "##,##0.0000")
            'Else
            '    Me.DGIngrediente.Item("CostoUX", i).Value = Format(CostoX, "##,##0.0000")
            'End If
            'If (CostoDX Mod 1) = 0 Then
            '    Me.DGIngrediente.Item("CostoDUX", i).Value = Format(CostoDX, "##,##0.0000")
            'Else
            '    Me.DGIngrediente.Item("CostoDUX", i).Value = Format(CostoDX, "##,##0.0000")
            'End If
        Next
    End Sub
    Public Function SumarColumnaEscaladoAqui(Grid As DataGridView, Columna As Int16) As Decimal
        Dim Total As Decimal = 0
        If Grid.RowCount >= 1 Then
            For Each row As DataGridViewRow In Grid.Rows
                If (row.Cells("IngredienteX").Value.ToString <> "") Then
                    If (row.Cells(Columna).Value.ToString <> "") Then
                        Total += Convert.ToDecimal(row.Cells(Columna).Value)
                    End If
                End If
            Next
        Else
            Total = "0"
        End If
        Return (Total)
    End Function
    'Fin ....................................................................
    Private Sub ActualizarCostosRecetas()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Dim Forma As New FEsperarImpresion
        'Forma.ProgressBar1.Minimum = 0
        'Forma.ProgressBar1.Maximum = Me.GridCompra.RowCount - 1
        'Forma.ProgressBar1.Value = 0
        'VarForma = "Calcular"
        'Forma.Show()
        'Forma.Refresh()
        CalcularDolar(DateTime.Now, 0)
        For Z As Integer = 0 To Me.GridCompra.Rows.Count - 1
            'If Forma.ProgressBar1.Value < Forma.ProgressBar1.Maximum Then
            '    Forma.ProgressBar1.Value += 1
            'End If
            If (Me.GridCompra.Rows(Z).Cells("idCatInt").Value = 1) Then
                If Conectar5() Then
                    Dim Comando5 As New SqlCommand("Select idProducto, Nombre, Empaquetado FROM VRecetaGuardada WHERE idIngrediente=" & Me.GridCompra.Rows(Z).Cells("Codigo").Value & " GROUP By idProducto, Nombre, Empaquetado", CNN5)
                    Dim DP5 As SqlDataReader = Comando5.ExecuteReader()

                    Do While DP5.Read()
                        Try
                            If (DP5("idProducto") = "071367") Then ' aqui8
                                VarBuscar = VarBuscar
                            End If
                            If (DP5("Empaquetado") = 0) Then
                                VefiricarCostos(DP5("idProducto"))
                                LlenarPan(DP5("idProducto"))
                                For i = 0 To Me.DGIngrediente.RowCount - 2
                                    If (Conectar()) Then
                                        Dim Comando As New SqlCommand("Select idUnidad,Unidad, CostoCalUnidD, Capacidad,idUnidadCapacidad,UnidadCapacidad, idCategoriaInt, Costo2D FROM VNewProducto WHERE idProducto=" & Me.DGIngrediente.Item("idIngredienteX", i).Value, CNN)
                                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                                        If (DR.Read() = True) Then
                                            If (DR("idCategoriaInt") = 1) Then
                                                N_UnidadProducto = DR("Unidad")
                                                N_Costo2D = DR("CostoCalUnidD")
                                                N_Costo2 = N_Costo2D * BsXDolarBC ' Se Convierte el Valor de Dolar a Bs. con la Tasa Actual del Banco central
                                                N_Capacidad = DR("Capacidad")
                                                N_idUnidadCapacidad = DR("idUnidadCapacidad")
                                                N_UnidadCapacidad = DR("UnidadCapacidad")
                                                N_CostoCalD = DR("Costo2D")
                                            Else
                                                BuscarCostoCategoriaInterna(DR("idCategoriaInt"))
                                            End If
                                            Me.DGIngrediente.Item("UnidadProdX", i).Value = N_UnidadProducto
                                            Me.DGIngrediente.Item("Costo2DX", i).Value = Format(N_Costo2D, "##,##0.0000")
                                            Me.DGIngrediente.Item("Costo2X", i).Value = Format(N_Costo2, "##,##0.0000")
                                            Me.DGIngrediente.Item("PorcCostoX", i).Value = 0
                                            If (N_Capacidad Mod 1) = 0 Then
                                                Me.DGIngrediente.Item("CapacidadX", i).Value = Format(N_Capacidad, "##,##0")
                                            Else
                                                Me.DGIngrediente.Item("CapacidadX", i).Value = Format(N_Capacidad, "##,##0.00")
                                            End If
                                            Me.DGIngrediente.Item("idUnidadCapacidadX", i).Value = N_idUnidadCapacidad
                                            Me.DGIngrediente.Item("UnidadCapacidadX", i).Value = N_UnidadCapacidad
                                            Me.DGIngrediente.Item("CostoCalDX", i).Value = N_CostoCalD
                                        End If
                                        DR.Close()
                                    End If
                                    Desconectar()
                                Next
                                NuevoCostoCalculadoUnidad()
                                NuevoCosto = SumarColumnaEscaladoAqui(DGIngrediente, 19)
                                NuevoCostoD = SumarColumnaEscaladoAqui(DGIngrediente, 18)
                            Else
                                LlenarEmpaquetado(DP5("idProducto"))
                                NuevoCosto = SumarColumna(DGEmpaquetado, 3)
                                NuevoCostoD = SumarColumna(DGEmpaquetado, 2)
                            End If
                            If (NuevoCostoD <> 0) Then
                                If (Conectar4()) Then
                                    Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2, CostoCalUnidD=@CostoCalUnidD,CostoCalUnid=@CostoCalUnid WHERE idProducto=" & DP5("idProducto"), CNN4)
                                    Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
                                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnidD", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnid", NuevoCosto))
                                    Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                                    DR4.Close()
                                End If
                                Desconectar4()
                            End If
                        Catch ex As Exception
                            MsgBox("Error al Actualizar Datos del Producto: " & DP5("idProducto") & "  " & DP5("Nombre") & "  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                        End Try
                    Loop
                    DP5.Close()
                    Desconectar5()
                End If
            Else
                'Se Buscan Los Productos con CategoriaInterna Iguales para Actualizar su costo
                If Conectar5() Then
                    Dim Comando5 As New SqlCommand("Select idProducto,Nombre, Empaquetado FROM VRecetaGuardada WHERE idCategoriaInt=" & Me.GridCompra.Rows(Z).Cells("idCatInt").Value & " GROUP By idProducto,Nombre, Empaquetado", CNN5)
                    Dim DP5 As SqlDataReader = Comando5.ExecuteReader()
                    Do While DP5.Read()
                        Try
                            If (DP5("idProducto") = "0710325") Then
                                VarBuscar = VarBuscar
                            End If
                            If (DP5("Empaquetado") = 0) Then
                                VefiricarCostos(DP5("idProducto"))
                                LlenarPan(DP5("idProducto"))
                                For i = 0 To Me.DGIngrediente.RowCount - 2
                                    If (Conectar()) Then
                                        Dim Comando As New SqlCommand("Select idUnidad,Unidad, CostoCalUnidD, Capacidad,idUnidadCapacidad,UnidadCapacidad, idCategoriaInt, Costo2D FROM VNewProducto WHERE idProducto=" & Me.DGIngrediente.Item("idIngredienteX", i).Value, CNN)
                                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                                        If (DR.Read() = True) Then
                                            If (DR("idCategoriaInt") = 1) Then
                                                N_UnidadProducto = DR("Unidad")
                                                N_Costo2D = DR("CostoCalUnidD")
                                                N_Costo2 = N_Costo2D * BsXDolarBC ' Se Convierte el Valor de Dolar a Bs. con la Tasa Actual del Banco central
                                                N_Capacidad = DR("Capacidad")
                                                N_idUnidadCapacidad = DR("idUnidadCapacidad")
                                                N_UnidadCapacidad = DR("UnidadCapacidad")
                                                N_CostoCalD = DR("Costo2D")
                                            Else
                                                BuscarCostoCategoriaInterna(DR("idCategoriaInt"))
                                            End If
                                            Me.DGIngrediente.Item("UnidadProdX", i).Value = N_UnidadProducto
                                            Me.DGIngrediente.Item("Costo2DX", i).Value = Format(N_Costo2D, "##,##0.0000")
                                            Me.DGIngrediente.Item("Costo2X", i).Value = Format(N_Costo2, "##,##0.0000")
                                            Me.DGIngrediente.Item("PorcCostoX", i).Value = 0
                                            If (N_Capacidad Mod 1) = 0 Then
                                                Me.DGIngrediente.Item("CapacidadX", i).Value = Format(N_Capacidad, "##,##0")
                                            Else
                                                Me.DGIngrediente.Item("CapacidadX", i).Value = Format(N_Capacidad, "##,##0.00")
                                            End If
                                            Me.DGIngrediente.Item("idUnidadCapacidadX", i).Value = N_idUnidadCapacidad
                                            Me.DGIngrediente.Item("UnidadCapacidadX", i).Value = N_UnidadCapacidad
                                            Me.DGIngrediente.Item("CostoCalDX", i).Value = N_CostoCalD
                                        End If
                                        DR.Close()
                                    End If
                                    Desconectar()
                                Next
                                NuevoCostoCalculadoUnidad()
                                NuevoCosto = SumarColumnaEscaladoAqui(DGIngrediente, 19)
                                NuevoCostoD = SumarColumnaEscaladoAqui(DGIngrediente, 18)
                            Else
                                LlenarEmpaquetado(DP5("idProducto"))
                                NuevoCosto = SumarColumna(DGEmpaquetado, 3)
                                NuevoCostoD = SumarColumna(DGEmpaquetado, 2)
                            End If
                            If (NuevoCostoD <> 0) Then
                                If (Conectar4()) Then
                                    Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2, CostoCalUnidD=@CostoCalUnidD,CostoCalUnid=@CostoCalUnid WHERE idProducto=" & DP5("idProducto"), CNN4)
                                    Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
                                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnidD", NuevoCostoD))
                                    Comando4.Parameters.Add(New SqlParameter("@CostoCalUnid", NuevoCosto))
                                    Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                                    DR4.Close()
                                End If
                                Desconectar4()
                            End If
                        Catch ex As Exception
                            MsgBox("Error al Actualizar Datos del Producto: " & DP5("idProducto") & "  " & DP5("Nombre") & "  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                        End Try
                    Loop
                    DP5.Close()
                    Desconectar5()
                End If
            End If
        Next
        '   Forma.Close()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If (ActivarGuardar = True) Then
            If (Me.CDeposito.Text <> "") Then
                If (Me.TCodProveedor.Text <> "") Then
                    If (Me.TNumFactura.Text <> "") Then
                        If (Me.CComprador.Text <> " ") Then
                            If (Me.CLocal.Text <> "") Then
                                If (Me.CBLibro.Checked) Then
                                    If (VefificarDatos() = True) Then
                                        If MsgBox("Hay algún Gasto en la Compra?, Si lo Hay Recuerde Agregar el Gasto Antes de Guardar, Desea Continuar? ", vbYesNo, "MarSoft: Verificar Gastos.") = vbYes Then
                                            RespMensaje = "Positivos"
                                            Me.GridCompra.EndEdit()
                                            GuardarCompra()
                                            GuardarDetalleCompra()
                                            GuardarTotalizar()
                                            ActualizarCostosRecetas()
                                            InicializarFormas()
                                        End If
                                    End If
                                Else
                                    If MsgBox("La Factura: " & TCodImprimir.Text & " No se Incluirá en el Libro de Compra, desea Continuar? ", vbYesNo, "MarSoft: Libro Compra.") = vbYes Then
                                        If (VefificarDatos() = True) Then
                                            If MsgBox("Hay algún Gasto en la Compra?, Si lo Hay Recuerde Agregar el Gasto Antes de Guardar, Desea Continuar? ", vbYesNo, "MarSoft: Verificar Gastos.") = vbYes Then
                                                RespMensaje = "Positivos"
                                                Me.GridCompra.EndEdit()
                                                GuardarCompra()
                                                GuardarDetalleCompra()
                                                GuardarTotalizar()
                                                ActualizarCostosRecetas()
                                                InicializarFormas()
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                MsgBox("Debe Seleccionar el Local. ", MsgBoxStyle.Information, "MarSoft: Información.")
                                Me.CLocal.Select()
                            End If
                        Else
                            MsgBox("Debe Seleccionar el Comprador. ", MsgBoxStyle.Information, "MarSoft: Información.")
                            Me.CComprador.Select()
                        End If
                    Else
                        MsgBox("Debe Agregar el Número de la Factura.", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.TCodProveedor.Select()
                    End If
                Else
                    MsgBox("Debe Seleccionar un Proveedor.", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TCodProveedor.Select()
                End If
            Else
                MsgBox("Debe Seleccionar un Depósito", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.CDeposito.Select()
            End If
        Else
            MsgBox("Debe Totalizar la Compra antes de Guardarla", MsgBoxStyle.Information, "MarSoft: Información.")
            Me.BTotalizar.Select()
        End If
    End Sub

    Private Sub GridCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles GridCompra.KeyDown
        Dim Libre As Boolean = False
        Dim Cont As Integer = 1
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            With GridCompra
                If ((.CurrentCell.ColumnIndex) < 22) Then
                    Select Case .CurrentCell.ColumnIndex
                        Case 0
                            VarBuscar = "CompraProd"
                            FBuscarOrden.LTitulo.Text = "Listado de Productos Terminados."
                            If (Me.GridCompra.RowCount > 0) Then
                                FBuscarOrden.LTitulo.Tag = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
                            Else
                                FBuscarOrden.LTitulo.Tag = -1
                            End If
                            FBuscarOrden.ShowDialog()
                            If (Me.GridCompra.RowCount > 0) Then
                                'If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Tipo").Value = 2) Then 'Si el Producto es Compuesto Calcular el Costo.
                                '    If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Empaquetado").Value = True) Then
                                '        ActualizarCostoProductoCompuesto(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("idEmpaquetado").Value, Me.GridCompra)
                                '    Else
                                '        ActualizarCostoProductoCompuesto(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Codigo").Value, Me.GridCompra)
                                '    End If
                                'End If
                                TotalizarLinea(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad").RowIndex)
                                CalcularCostoCalculado(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad").RowIndex)
                                If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Venta").Value = True) Then
                                    Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.Red
                                Else
                                    Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.White
                                End If
                                If (Me.GridCompra.RowCount > 0) Then
                                    Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad")
                                    Me.GridCompra.BeginEdit(True)
                                End If
                            End If
                        Case 12
                            VarBuscar = "AlicuotaCompra"
                            FBuscarOrden.LTitulo.Tag = 0
                            FBuscarOrden.ShowDialog()
                            Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("Impuesto").Value = VFormat((Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("Costo").Value) / 100) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("ValorAlicuota").Value), 4)
                            TotalizarLinea(Me.GridCompra.CurrentCell.RowIndex)
                            CalcularCostoCalculado(Me.GridCompra.CurrentCell.RowIndex)
                            Select Case MonedaBase
                                Case "Bolivar"
                                    .CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Total")
                                Case "Dolar"
                                    .CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("TotalD")
                            End Select

                        Case 20
                            BPrecios_Click(Nothing, Nothing)
                            .CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("ObservacionLineaCompra")
                        Case 21
                            BObservacion_Click(Nothing, Nothing)
                            .CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("BProd")
                        Case Else
                            While Libre = False
                                If (.Item(.CurrentCell.ColumnIndex + Cont, .CurrentCell.RowIndex).Visible = True) Then
                                    .CurrentCell = .Item(.CurrentCell.ColumnIndex + Cont, .CurrentCell.RowIndex)
                                    Libre = True
                                Else
                                    Cont = Cont + 1
                                End If
                            End While
                    End Select
                End If
            End With
        End If
    End Sub

    Private Sub TCodImprimir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodImprimir.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumerico(Me.TCodImprimir.Text, e.KeyChar, False)
    End Sub
    Private Sub CalcularMontosFinales()
        For I = 0 To Me.DGVListadoCompras.RowCount - 1
            Select Case Me.DGVListadoCompras.Item("MonedaBase", I).Value
                Case "Bolívar"
                    If (Me.DGVListadoCompras.Item("Total", I).Value.ToString <> "") Then

                        Select Case Me.DGVListadoCompras.Item("MonedaPago", I).Value
                            Case "Bolívar"
                                Me.DGVListadoCompras.Item("TotalF", I).Value = Me.DGVListadoCompras.Item("Total", I).Value
                                Me.DGVListadoCompras.Item("TotalDF", I).Value = Convert.ToDouble(Me.DGVListadoCompras.Item("Total", I).Value) / BsXDolar
                            Case "Dolar"
                                Me.DGVListadoCompras.Item("TotalF", I).Value = Convert.ToDouble(Me.DGVListadoCompras.Item("TotalD", I).Value) * BsXDolar
                                Me.DGVListadoCompras.Item("TotalDF", I).Value = Me.DGVListadoCompras.Item("TotalD", I).Value
                        End Select
                    End If
                Case "Dolar"
                    If (Me.DGVListadoCompras.Item("TotalD", I).Value.ToString <> "") Then
                        Select Case Me.DGVListadoCompras.Item("MonedaPago", I).Value
                            Case "Bolívar"
                                Me.DGVListadoCompras.Item("TotalF", I).Value = BsXDolar * Convert.ToDecimal(Me.DGVListadoCompras.Item("TotalD", I).Value.ToString)
                                Me.DGVListadoCompras.Item("TotalDF", I).Value = Me.DGVListadoCompras.Item("TotalD", I).Value
                            Case "Dolar"
                                Me.DGVListadoCompras.Item("TotalF", I).Value = BsXDolar * Convert.ToDecimal(Me.DGVListadoCompras.Item("TotalD", I).Value.ToString)
                                Me.DGVListadoCompras.Item("TotalDF", I).Value = Me.DGVListadoCompras.Item("TotalD", I).Value
                        End Select
                    End If
            End Select
        Next
        Me.DGVListadoCompras.Columns("TotalF").DefaultCellStyle.Format = "##,##0.0000"
        Me.DGVListadoCompras.Columns("TotalDF").DefaultCellStyle.Format = "##,##0.0000"
    End Sub


    Private Sub SumarColumnaTotal(Grid As DataGridView)
        Dim Total As Decimal
        Dim Abonado As Decimal
        Dim Resta As Decimal
        Dim TotalD As Decimal
        Dim AbonadoD As Decimal
        Dim RestaD As Decimal
        If Grid.RowCount >= 1 Then
            For Each row As DataGridViewRow In Grid.Rows
                If (row.Cells("TotalF").Value.ToString <> "") Then
                    Total += Convert.ToDecimal(row.Cells("TotalF").Value)
                End If
                If (row.Cells("Abonado").Value.ToString <> "") Then
                    Abonado += Convert.ToDecimal(row.Cells("Abonado").Value)
                End If
                If (row.Cells("Resta").Value.ToString <> "") Then
                    Resta += Convert.ToDecimal(row.Cells("Resta").Value)
                End If
                If (row.Cells("TotalDF").Value.ToString <> "") Then
                    TotalD += Convert.ToDecimal(row.Cells("TotalDF").Value)
                End If
                If (row.Cells("AbonadoD").Value.ToString <> "") Then
                    AbonadoD += Convert.ToDecimal(row.Cells("AbonadoD").Value)
                End If
                If (row.Cells("RestaD").Value.ToString <> "") Then
                    RestaD += Convert.ToDecimal(row.Cells("RestaD").Value)
                End If
            Next
        Else
            Total = 0
            Abonado = 0
            Resta = 0
            TotalD = 0
            AbonadoD = 0
            RestaD = 0
        End If

        Me.LTotalCompra.Text = Format(Total, "##,##0.0000")
        Me.LAbonado.Text = Format(Abonado, "##,##0.0000")
        Me.LResta.Text = Format(Resta, "##,##0.0000")

        Me.LTotalCompraD.Text = Format(TotalD, "##,##0.0000")
        Me.LAbonadoD.Text = Format(AbonadoD, "##,##0.0000")
        Me.LRestaD.Text = Format(RestaD, "##,##0.0000")
    End Sub
    Private Sub AgregarAlias()
        For i = 0 To Me.DGVListadoCompras.RowCount - 1
            Me.DGVListadoCompras.Item("Prov", i).ToolTipText = "Alias: " & Me.DGVListadoCompras.Item("Alias", i).Value
            Me.DGVListadoCompras.Item("Evidencia", i).Value = Me.DGVListadoCompras.Item("PDF", i).Value
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("SELECT TOP (1) idGastoCompra FROM TDetalleCompra WHERE (idGastoCompra <> 0) AND (idCompra = @CodCompra)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@CodCompra", Me.DGVListadoCompras.Item("idCompra", i).Value))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    Do While DR.Read()
                        If Not (IsDBNull(DR("idGastoCompra"))) Then
                            Me.DGVListadoCompras.Item("Actualizar", i).Style.BackColor = Color.Red
                        End If
                    Loop
                    DR.Close()
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Verificar si es un Gasto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        Next
    End Sub
    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        Dim Cad As String = ""
        Dim CadFecha As String = ""
        Dim CadOrdenar As String = ""
        Me.DGVListadoCompras.Columns.Clear()
        Select Case Me.CTipoCompraL.Text
            Case "Todas"
                Cad = ""
            Case "Sin Gastos Asoc."
                Cad = " AND TipoCompra='S.G.A.'"
            Case "Con Gastos Asoc."
                Cad = " AND TipoCompra='C.G.A.'"
        End Select
        If (Me.ChProveedor.Checked = True) Then
            Cad = "AND idProveedor=" & Me.TProveedorL.Tag & Cad
        End If

        If (Me.CLocalLista.SelectedValue <> 3) Then
            Cad = Cad & " AND idLocal=" & Me.CLocalLista.SelectedValue
        End If

        If (Me.RBFechaReg.Checked) Then
            CadFecha = "CAST(CONVERT(CHAR(8), Fecha, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT)"
            CadOrdenar = " ORDER BY Fecha ASC"
        Else
            CadFecha = "CAST(CONVERT(CHAR(8), FechaFactura, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT)"
            CadOrdenar = " ORDER BY FechaFactura ASC"
        End If

        Try
            If Conectar() Then
                'If (Me.ChProveedor.Checked = True) Then
                '    Adaptador = New SqlDataAdapter("Select idCompra, FechaFactura, Fecha,TipoCompra, Proveedor AS Prov, Alias, Total, Total AS TotalF,  TotalD, TotalD as TotalDF, Abonado, AbonadoD, Resta,RestaD, idProveedor,idComprador, MonedaBase, MonedaPago, TasaCambioI FROM VListadoCompras WHERE CAST(CONVERT(CHAR(8), Fecha, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT) AND idProveedor=" & Me.TProveedorL.Tag & Cad & " ORDER BY Fecha ASC", CNN)
                'Else
                Adaptador = New SqlDataAdapter("Select idCompra, NFactura, FechaFactura, Fecha,TipoCompra, Proveedor AS Prov, Alias, Total, Total as TotalF, TotalD,TotalD as TotalDF, Abonado, AbonadoD, Resta,RestaD, idProveedor, idComprador, MonedaBase, MonedaPago, TasaCambioI, PDF, FacturaCredito FROM VListadoCompras WHERE " & CadFecha & Cad & CadOrdenar, CNN)
                'End If
                Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.DGVListadoCompras.DataSource = DataT
                DGVListadoCompras.Columns("idCompra").HeaderText = "Cód."
                DGVListadoCompras.Columns("idCompra").ToolTipText = "Código."
                DGVListadoCompras.Columns("idCompra").Width = 60
                DGVListadoCompras.Columns("NFactura").HeaderText = "N°Fact."
                DGVListadoCompras.Columns("NFactura").Width = 70
                DGVListadoCompras.Columns("NFactura").ToolTipText = "Número de la Factura."


                DGVListadoCompras.Columns("FechaFactura").HeaderText = "F.F."
                DGVListadoCompras.Columns("FechaFactura").Width = 85
                DGVListadoCompras.Columns("FechaFactura").ToolTipText = "Fecha de la Factura."
                DGVListadoCompras.Columns("FechaFactura").DefaultCellStyle.Format = "dd/MM/yy"
                DGVListadoCompras.Columns("Fecha").HeaderText = "F.R."
                DGVListadoCompras.Columns("Fecha").Width = 85
                DGVListadoCompras.Columns("Fecha").ToolTipText = "Fecha de Registro de la Factura."
                DGVListadoCompras.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yy"
                DGVListadoCompras.Columns("TipoCompra").HeaderText = "Tipo"
                DGVListadoCompras.Columns("TipoCompra").ToolTipText = "Tipo de Compra."
                DGVListadoCompras.Columns("TipoCompra").Width = 60
                DGVListadoCompras.Columns("Prov").HeaderText = "Proveedor"
                DGVListadoCompras.Columns("Prov").Width = 150

                DGVListadoCompras.Columns("Total").HeaderText = "Inic. Bs."
                DGVListadoCompras.Columns("Total").ToolTipText = "Total Inicial en Bs."
                DGVListadoCompras.Columns("Total").Width = 100
                DGVListadoCompras.Columns("Total").DefaultCellStyle.Format = "##,##0.0000"

                DGVListadoCompras.Columns("TotalF").HeaderText = "Final Bs."
                DGVListadoCompras.Columns("TotalF").ToolTipText = "Total Final en Bs."
                DGVListadoCompras.Columns("TotalF").Width = 100
                DGVListadoCompras.Columns("TotalF").DefaultCellStyle.Format = "##,##0.0000"

                DGVListadoCompras.Columns("TotalD").HeaderText = "Inic. $"
                DGVListadoCompras.Columns("TotalD").ToolTipText = "Total Inicial en $."
                DGVListadoCompras.Columns("TotalD").Width = 100
                DGVListadoCompras.Columns("TotalD").DefaultCellStyle.Format = "##,##0.0000"

                DGVListadoCompras.Columns("TotalDF").HeaderText = "Final $"
                DGVListadoCompras.Columns("TotalDF").ToolTipText = "Total Final en $."
                DGVListadoCompras.Columns("TotalDF").Width = 100
                DGVListadoCompras.Columns("TotalDF").DefaultCellStyle.Format = "##,##0.0000"


                DGVListadoCompras.Columns("Abonado").HeaderText = "Abon. Bs."
                DGVListadoCompras.Columns("Abonado").ToolTipText = "Abonado en Bs."
                DGVListadoCompras.Columns("Abonado").Width = 100
                DGVListadoCompras.Columns("Abonado").DefaultCellStyle.Format = "##,##0.0000"
                DGVListadoCompras.Columns("AbonadoD").HeaderText = "Abon. $"
                DGVListadoCompras.Columns("AbonadoD").ToolTipText = "Abonado en $"
                DGVListadoCompras.Columns("AbonadoD").Width = 100
                DGVListadoCompras.Columns("AbonadoD").DefaultCellStyle.Format = "##,##0.0000"
                DGVListadoCompras.Columns("Resta").HeaderText = "Resta Bs."
                DGVListadoCompras.Columns("Resta").ToolTipText = "Resta en Bs."
                DGVListadoCompras.Columns("Resta").Width = 100
                DGVListadoCompras.Columns("Resta").DefaultCellStyle.Format = "##,##0.0000"
                DGVListadoCompras.Columns("RestaD").HeaderText = "Resta $"
                DGVListadoCompras.Columns("RestaD").ToolTipText = "Resta en $"
                DGVListadoCompras.Columns("RestaD").Width = 100
                DGVListadoCompras.Columns("RestaD").DefaultCellStyle.Format = "##,##0.0000"
                DGVListadoCompras.Columns("idProveedor").HeaderText = "idProveedor"
                DGVListadoCompras.Columns("idProveedor").Visible = False
                DGVListadoCompras.Columns("idComprador").HeaderText = "idComprador"
                DGVListadoCompras.Columns("FacturaCredito").HeaderText = "Créd"
                DGVListadoCompras.Columns("FacturaCredito").Width = 50
                DGVListadoCompras.Columns("FacturaCredito").ToolTipText = "Factura Crédito?"

                DGVListadoCompras.Columns("idComprador").Visible = False
                DGVListadoCompras.Columns("MonedaBase").Visible = False
                DGVListadoCompras.Columns("MonedaPago").Visible = False
                DGVListadoCompras.Columns("TasaCambioI").Visible = False
                ' DGVListadoCompras.Columns("idCompra").Visible = False
                DGVListadoCompras.Columns("Alias").Visible = False
                DGVListadoCompras.Columns("PDF").Visible = False

                DGVListadoCompras.Columns("idCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVListadoCompras.Columns("NFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVListadoCompras.Columns("FechaFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVListadoCompras.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVListadoCompras.Columns("Prov").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                DGVListadoCompras.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                DGVListadoCompras.Columns("TotalF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.Columns("TotalDF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                DGVListadoCompras.Columns("TipoCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                DGVListadoCompras.Columns("Abonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.Columns("Resta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.Columns("AbonadoD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.Columns("RestaD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVListadoCompras.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Dim Boton As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                Boton.Name = "Detalle"
                Me.DGVListadoCompras.Columns.Add(Boton)
                Me.DGVListadoCompras.Columns("Detalle").HeaderText = "DC"
                Me.DGVListadoCompras.Columns("Detalle").ToolTipText = "Detetalle de la Compra."
                Me.DGVListadoCompras.Columns("Detalle").Width = 50

                Dim Boton2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                Boton2.Name = "Actualizar"
                Me.DGVListadoCompras.Columns.Add(Boton2)
                Me.DGVListadoCompras.Columns("Actualizar").HeaderText = "AC"
                Me.DGVListadoCompras.Columns("Actualizar").ToolTipText = "Actualizar la Compra."
                Me.DGVListadoCompras.Columns("Actualizar").Width = 50

                Dim Boton3 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                Boton3.Name = "FormaPago"
                Me.DGVListadoCompras.Columns.Add(Boton3)
                Me.DGVListadoCompras.Columns("FormaPago").HeaderText = "FP"
                Me.DGVListadoCompras.Columns("FormaPago").ToolTipText = "Forma de Pago de la Compra."
                Me.DGVListadoCompras.Columns("FormaPago").Width = 50
                Dim Boton4 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                Boton4.Name = "Evidencia"
                Me.DGVListadoCompras.Columns.Add(Boton4)
                Me.DGVListadoCompras.Columns("Evidencia").HeaderText = "EC"
                Me.DGVListadoCompras.Columns("Evidencia").ToolTipText = "Evidencia de la Compra."
                Me.DGVListadoCompras.Columns("Evidencia").Width = 50

            End If
            Desconectar()
            AgregarAlias()
            CalcularMontosFinales()
            SumarColumnaTotal(Me.DGVListadoCompras)
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos del Listado de Compras. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    'Private Sub DarFormatoGril()
    '    For Ind = 0 To Me.GridCompra.RowCount - 1
    '        Me.GridCompra.Rows(Ind).Cells("Cantidad").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Cantidad").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("Costo").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Costo").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("CostoCal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("CostoCal").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("SubTotal").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("SubTotal").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("Descuento").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Descuento").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("Impuesto").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Impuesto").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("Total").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Total").Value), "##,##0.00")
    '        Me.GridCompra.Rows(Ind).Cells("Precio1").Value = Format(Convert.ToDouble(Me.GridCompra.Rows(Ind).Cells("Precio1").Value), "##,##0.00")
    '    Next
    'End Sub
    Private Sub DGVListadoCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoCompras.CellClick
        '  Dim HR As String = ""
        '  Dim PR As String = ""

    End Sub

    Private Sub BCuentasXCobrar_Click(sender As Object, e As EventArgs) Handles BCuentasXCobrar.Click
        '    FCuentasporPagar.ShowDialog()
    End Sub

    'Private Sub CBProveedorR_CheckedChanged(sender As Object, e As EventArgs)
    '    Me.CProveedorR.Enabled = Me.CBProveedorR.Checked
    'End Sub
    Private Sub BotonesActivos(Valor As Boolean)
        If (Valor) Then
            If (ActivarGuardar = False) Then
                Me.BGuardar.Enabled = False
                Me.BActualizar.Enabled = True
                Me.BEliminarCompra.Enabled = True
                Me.BPDF.Enabled = True
            Else
                Me.BGuardar.Enabled = True
                Me.BActualizar.Enabled = False
                Me.BEliminarCompra.Enabled = False
                Me.BPDF.Enabled = False
            End If
        Else
            Me.BGuardar.Enabled = Valor
            Me.BActualizar.Enabled = Valor
            Me.BEliminarCompra.Enabled = Valor
            Me.BPDF.Enabled = Valor
        End If


    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedTab.Name
            Case TabPage1.Name
                CodCompra = Convert.ToDecimal(Me.LNumDoc.Text)
                If (Me.TCodImprimir.Text = "") Then
                    ActivarGuardar = True
                    BotonesActivos(True)
                Else
                    BotonesActivos(True)
                End If
            Case TabPage2.Name
                Me.CTipoCompraL.Text = "Todas"
                BBuscar_Click(Nothing, Nothing)
                BotonesActivos(False)
        End Select
    End Sub
    Private Sub BEliminarCompra_Click(sender As Object, e As EventArgs) Handles BEliminarCompra.Click
        If (Me.TCodImprimir.Text <> "") Then
            TipoAutoriza = "Compra"
            QueAutorizo = "Eliminar"
            '    FAutorizar.ShowDialog()
            If (Autorizado) Then
                If (Conectar()) Then
                    Try
                        Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Dim Comando As New SqlCommand("Select idProducto, Stock, Cantidad,idCategoriaInt,Unidad,idGastoCompra FROM VDetalleCompra WHERE idCompra=" & Me.TCodImprimir.Text, CNN)
                        Dim DR = Comando.ExecuteReader()
                        Do While DR.Read()
                            If (DR("idGastoCompra") <> 0) Then
                                If (Conectar2()) Then
                                    Dim ComandoXX As New SqlCommand("DELETE FROM TGastos WHERE idGastos=" & DR("idGastoCompra"), CNN2)
                                    Dim DRx = ComandoXX.ExecuteReader()
                                    DRx.Close()
                                End If
                                Desconectar2()
                            End If
                        Loop
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TDetalleCompra WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TTotalizar WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TFormasPago WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TCuentasDistPescado WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TGastosComprasForaneas WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TCostosDescuentos WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Comando.CommandText = "DELETE FROM TCompras WHERE idCompra=" & Me.TCodImprimir.Text
                        DR = Comando.ExecuteReader()
                        DR.Close()
                        Desconectar()
                        InicializarFormas()
                        Me.BActualizar.Enabled = False
                        Me.BGuardar.Enabled = True
                    Catch ex As Exception
                        MsgBox("Error al Eliminar la Compra." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                        Cursor = System.Windows.Forms.Cursors.Default
                    End Try
                End If
                Cursor = System.Windows.Forms.Cursors.Default
            End If
        Else
            MessageBox.Show("Esta Compra No ha sido Guardada.  ", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click

        If (Me.FechaRegistro.Value.Date = Date.Now().Date) Or (UsuarioActivo = "Eirene Soto") Or (UsuarioActivo = "Iris Zambrano") Then
            If (Me.TCodImprimir.Text <> "") Then
                If MsgBox("Esta seguro que desea Actualizar La Compra: " & TCodImprimir.Text & " y todos sus detalles?", vbYesNo, "MarSoft: Actualizar Compra.") = vbYes Then
                    If (ActivarGuardar = True) Then
                        If (Me.CDeposito.Text <> "") Then
                            If (Me.TCodProveedor.Text <> "") Then
                                If (Me.CLocal.Text <> "") Then
                                    If (VefificarDatos() = True) Then
                                        TipoAutoriza = "Compra"
                                        '    QueAutorizo = "Actualizar"
                                        '    FAutorizar.ShowDialog()
                                        If (Autorizado) Then
                                            RespMensaje = "Negativos"
                                            If (Conectar()) Then
                                                Try
                                                    Cursor = System.Windows.Forms.Cursors.WaitCursor
                                                    Dim Comando As New SqlCommand("DELETE FROM TDetalleCompra WHERE idCompra=" & Me.TCodImprimir.Text, CNN)
                                                    Dim DR = Comando.ExecuteReader()
                                                    DR.Close()
                                                    Comando.CommandText = "DELETE FROM TFormasPago WHERE idCompra=" & Me.TCodImprimir.Text
                                                    DR = Comando.ExecuteReader()
                                                    DR.Close()
                                                    Desconectar()
                                                    Me.GridCompra.EndEdit()
                                                    ActualizarCompra()
                                                    GuardarDetalleCompra()
                                                    If (Me.FechaRegistro.Value.Date = Date.Now().Date) Then
                                                        ActualizarCostosRecetas()
                                                    End If
                                                    ActualizarTotalizar()
                                                    GuardarFormaPago()
                                                    InicializarFormas()
                                                    ' Me.TCodImprimir.Text = CodCompra
                                                Catch ex As Exception
                                                    MsgBox("Error al Actualizar la Compra." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                                                    Desconectar()
                                                    Cursor = System.Windows.Forms.Cursors.Default
                                                End Try
                                            End If
                                        End If
                                    End If
                                Else
                                    MsgBox("Debe Seleccionar el Local. ", MsgBoxStyle.Information, "MarSoft: Información.")
                                    Me.CLocal.Select()
                                End If
                            Else
                                MsgBox("Debe Seleccionar un Proveedor.", MsgBoxStyle.Information, "MarSoft: Información.")
                                Me.TCodProveedor.SelectAll()
                            End If
                        Else
                            MsgBox("Debe Seleccionar un Depósito", MsgBoxStyle.Information, "MarSoft: Información.")
                            Me.CDeposito.Select()
                        End If
                    Else
                        MsgBox("Debe Totalizar la Compra antes de Guardarla", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.BTotalizar.Select()
                    End If
                End If
                Cursor = System.Windows.Forms.Cursors.Default
            Else
                MessageBox.Show("Esta Compra No ha sido Guardada.  ", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Solo Se Pueden Actualizar las Compras del día de Hoy.", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        If MsgBox("Si Continúa se Perderan los Datos de La Compra: " & TCodImprimir.Text & " y todos sus detalles que no han sido Guardados?", vbYesNo, "MarSoft: Eliminar Compra.") = vbYes Then
            InicializarFormas()
            Me.BActualizar.Enabled = False
            Me.BEliminarCompra.Enabled = False
            Me.BPDF.Enabled = False
            Me.BGuardar.Enabled = True
            Me.TabControl1.SelectedIndex = 0
        End If
    End Sub
    Private Sub CTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CTipoCompra.SelectedIndexChanged
        If (Me.CTipoCompra.Text = "Con Gastos Asoc.") Then
            LGastos.Visible = True
            TGastos.Visible = True
            TGastosD.Visible = True
            Me.BGrilGastos.Visible = True
            Me.TGastos.Text = "Bs. " & Me.TGastos.Tag
            Me.TGastosD.Text = "$ " & Me.TGastosD.Tag
            Me.CBIncluirGastos.Visible = True
            Me.BCambio.Visible = True
        Else
            LGastos.Visible = False
            TGastos.Visible = False
            TGastosD.Visible = False
            Me.BGrilGastos.Visible = False
            Me.TGastos.Tag = "0"
            Me.TGastosD.Tag = "0"
            Me.CBIncluirGastos.Visible = False
            Me.BCambio.Visible = False
        End If
        BCambio_Click(Nothing, Nothing)
    End Sub
    Private Sub BCambio_Click(sender As Object, e As EventArgs) Handles BCambio.Click
        For i = 0 To Me.GridCompra.RowCount - 1
            CalcularCostoCalculado(i)
        Next
        Totalizar()
    End Sub

    'Private Sub BGrilGastos_Click(sender As Object, e As EventArgs) Handles BGrilGastos.Click
    '    Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    Try
    '        If (Conectar()) Then
    '            Dim Comando As New SqlCommand("Select * FROM TGastosComprasForaneas WHERE CAST(CONVERT(CHAR(8), Fecha, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT)", CNN)
    '            Comando.Parameters.AddWithValue("@desde", Me.Fecha.Value)
    '            Comando.Parameters.AddWithValue("@hasta", Me.Fecha.Value)
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            Me.GridExaminar.Rows.Clear()
    '            Do While DR.Read()
    '                Me.GridExaminar.Rows.Add(Me.GridExaminar.RowCount + 1, DR("Concepto"), Format(DR("Monto"), "##,##0.00"), DR("id"))
    '            Loop
    '            DR.Close()
    '            Desconectar()
    '            Me.TGastos.Tag = Format(SumarColumna(GridExaminar, 2), "##,##0.00")
    '            Me.GridExaminar.Rows.Add("", "TOTALES", Me.TGastos.Tag, "")
    '            Me.GridExaminar.Rows(Me.GridExaminar.RowCount - 1).Height = 30
    '            Me.GridExaminar.Rows(Me.GridExaminar.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Bold)
    '            Me.GridExaminar.Rows(Me.GridExaminar.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
    '            Me.PanelExaminar.Visible = True
    '            Me.GridExaminar.ClearSelection()
    '            Cursor = System.Windows.Forms.Cursors.Default
    '        End If
    '        Me.PanelExaminar.Visible = True
    '    Catch ex As Exception
    '        MessageBox.Show("ERROR al Mostrar los Datos de los Gastos... " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Desconectar()
    '        Cursor = System.Windows.Forms.Cursors.Default
    '    End Try
    'End Sub

    Private Sub BGrilGastos_Click(sender As Object, e As EventArgs) Handles BGrilGastos.Click
        '    FGastosAsocioados.ShowDialog()
        BCambio_Click(Nothing, Nothing)
    End Sub

    Private Sub CBCompraEnEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles CBCompraEnEfectivo.CheckedChanged
        If (CBCompraEnEfectivo.Checked) Then
            CalcularEfectivo(Me.FechaFactura.Value.Date, Me.TGastos.Tag)
            Me.MPEfectivo.Text = "% Efectivo: " & Format(PorcEfect, "##,##0.00") & "."
            Me.MPEfectivo.Visible = True
        Else
            Me.MPEfectivo.Visible = False
        End If
        BCambio_Click(Nothing, Nothing)
    End Sub
    Function ExisteProveedor() As Boolean
        Dim Valor As Boolean = False
        If Conectar() Then
            Try
                Dim Comando As New SqlCommand("SELECT  idProveedor FROM TProveedor Where idProveedor=@idProveedor", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProveedor", Me.TCodProveedor.Text))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Valor = True
                Else
                    Valor = False
                End If
                DR.Close()
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
        Return (Valor)
    End Function
    Private Sub MostrarProd()
        If Conectar() Then
            Try
                Dim Comando As New SqlCommand("SELECT  idProveedor,Alias, Nombre, Rif  FROM TProveedor Where idProveedor=@idProveedor", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProveedor", Me.TCodProveedor.Text))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Me.TCodProveedor.Text = Trim(DR("idProveedor").ToString)
                    Me.LProveedor2.Text = StrConv(Trim(DR("Nombre").ToString), VbStrConv.ProperCase)
                    Me.LAlias2.Text = StrConv(Trim(DR("Alias").ToString), VbStrConv.ProperCase) & "."
                    Me.TRIF.Text = Trim(DR("Rif").ToString)
                End If
                DR.Close()
                Desconectar()
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub TCodProveedor_TextChanged(sender As Object, e As EventArgs) Handles TCodProveedor.TextChanged
        If (ExisteProveedor()) Then
            MostrarProd()
            ExisteProv = True
            Me.TNumFactura.Focus()
        Else
            Me.LProveedor2.Text = ""
            Me.LAlias2.Text = ""
            ExisteProv = False
        End If
    End Sub
    'Private Sub MostrarProveedor()
    '    Try
    '        If Conectar() Then
    '            Dim Comando As New SqlCommand("SELECT  * FROM TProveedor WHERE idProveedor=" & CodProveedor, CNN)
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            Do While DR.Read()
    '                Me.TCodigo.Text = CodProveedor
    '                Me.TNombre.Text = DR("Nombre")
    '                Me.TNombre.Tag = DR("RIF")
    '            Loop
    '            DR.Close()
    '        End If
    '        Desconectar()
    '    Catch ex As Exception
    '        MsgBox("Error de Datos..." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '        Desconectar()
    '    End Try
    'End Sub
    Private Sub BProveedor_Click(sender As Object, e As EventArgs) Handles BProveedor.Click
        FBuscarProveedor.LTitulo.Tag = Me.TCodProveedor.Text
        FBuscarProveedor.ShowDialog()
        Me.TCodProveedor.Text = CodProveedor
    End Sub

    Private Sub BProveedores_Click(sender As Object, e As EventArgs) Handles BProveedores.Click
        FProveedores.ShowDialog()
    End Sub
    Private Sub BNuevoArt_Click(sender As Object, e As EventArgs) Handles BNuevoArt.Click
        VarForma = "NuevoArt"
        FProducto.ShowDialog()
    End Sub
    Private Sub EliminarGastoX(idGasto As String)
        If (idGasto <> "") Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("DELETE FROM TGastos WHERE idGastos=" & idGasto, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al Eliminar Datos del Gasto. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub BEliminarArt_Click(sender As Object, e As EventArgs) Handles BEliminarArt.Click
        If (Me.GridCompra.Rows.Count > 0) Then
            EliminarGastoX(Me.GridCompra.CurrentRow.Cells("Gasto").Value.ToString)
            Me.GridCompra.Rows.RemoveAt(Me.GridCompra.CurrentRow.Index)
            Totalizar()
        Else
            Me.LTotalD.Text = "0"
        End If
    End Sub
    Private Sub ValidarMonedaBase()
        Select Case MonedaBase
            Case "Bolívar"
                BMonedaBase.Image = Me.ImagenBs.Image
                MonedaBase = "Bolívar"
                BMonedaBase.Text = "Moneda Base: Bs."
                Me.GridCompra.Columns("Costo").Visible = True
                Me.GridCompra.Columns("CostoD").Visible = False
                Me.GridCompra.Columns("Total").Visible = True
                Me.GridCompra.Columns("TotalD").Visible = True
                Me.GridCompra.Columns("Costo").DefaultCellStyle.BackColor = Color.White
                Me.GridCompra.Columns("CostoD").DefaultCellStyle.BackColor = Color.Gainsboro
                Me.GridCompra.Columns("Costo").ReadOnly = False
                Me.GridCompra.Columns("CostoD").ReadOnly = True
            Case "Dolar"
                BMonedaBase.Image = Me.ImagenD.Image
                MonedaBase = "Dolar"
                BMonedaBase.Text = "Moneda Base: $"
                Me.GridCompra.Columns("Costo").Visible = False
                Me.GridCompra.Columns("CostoD").Visible = True
                Me.GridCompra.Columns("Total").Visible = False
                Me.GridCompra.Columns("TotalD").Visible = True
                Me.GridCompra.Columns("Costo").DefaultCellStyle.BackColor = Color.Gainsboro
                Me.GridCompra.Columns("CostoD").DefaultCellStyle.BackColor = Color.White
                Me.GridCompra.Columns("Costo").ReadOnly = True
                Me.GridCompra.Columns("CostoD").ReadOnly = False
        End Select
        Select Case MonedaPago
            Case "Bolívar"
                BMonedaPago.Image = Me.ImagenBs.Image
                MonedaPago = "Bolívar"
                BMonedaPago.Text = "Moneda Pago: Bs."
            Case "Dolar"
                BMonedaPago.Image = Me.ImagenD.Image
                MonedaPago = "Dolar"
                BMonedaPago.Text = "Moneda Pago: $"
        End Select
    End Sub
    Private Sub BMonedaBase_Click(sender As Object, e As EventArgs) Handles BMonedaBase.Click
        VarBuscar = "MonedaCompra"
        FBuscarOrden.LTitulo.Text = "Listado de Monedas."
        FBuscarOrden.LTitulo.Tag = Me.BMonedaBase.Tag
        FBuscarOrden.ShowDialog()
        ValidarMonedaBase()
        For I = 0 To Me.GridCompra.RowCount - 1
            Me.GridCompra.Rows(I).Cells("Costo").Value = VFormat(Convert.ToDecimal(Me.GridCompra.Rows(I).Cells("Costo").Value), 4)
            TotalizarLinea(I)
            CalcularCostoCalculado(I)
        Next
        Totalizar()
    End Sub
    Function ConvertirUnidad(Cantidad, idUnidad, idUnidadNew) As Decimal
        Dim CantProd As Decimal = 0
        If (idUnidad = idUnidadNew) Then
            CantProd = Cantidad
        Else
        End If
        Return (CantProd)
    End Function
    Private Sub BInfArt_Click(sender As Object, e As EventArgs) Handles BInfArt.Click
        VarBuscar = "CompraProd"
        FBuscarProducto.LTitulo.Text = "Listado de Productos Terminados."
        If (Me.GridCompra.RowCount > 0) Then
            FBuscarProducto.LTitulo.Tag = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
        Else
            FBuscarProducto.LTitulo.Tag = -1
        End If
        FBuscarProducto.ShowDialog()

        Me.BUnidAlt.Tag = "Unidad"
        Me.BUnidAlt.Text = "&Unidad Alt."
        Me.BUnidAlt.ToolTipText = "Unidad Alterna."
        If (Me.GridCompra.RowCount > 0) Then
            CalcularStock(Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Codigo").Value, Me.GridCompra.RowCount - 1)
            TotalizarLinea(Me.GridCompra.RowCount - 1)
            CalcularCostoCalculado(Me.GridCompra.RowCount - 1)
            If (Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Venta").Value = True) Then
                Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.Red
            Else
                Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.White
            End If
            ValidarMonedaBase()
            If (Me.GridCompra.RowCount > 0) Then
                Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Cantidad")
                Me.GridCompra.BeginEdit(True)
            End If
        End If
    End Sub
    Private Sub CambiarUnidadAlt(Cod As String, Indice As Integer)
        Dim Cap As Decimal = 1
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("SELECT * FROM VUnidades WHERE idProducto=@idProducto", CNN)
                Comando.Parameters.Add(New SqlParameter("@idproducto", Cod))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                While (DR.Read)
                    If (DR("idUnidadAlt") = 7) Then
                        MsgBox("Este Producto No Posee Unidad Alterna. ", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.GridCompra.Item("SelAlterno", Indice).Value = False
                    Else
                        If (Me.BUnidAlt.Tag = "Unidad") Then
                            If (Me.GridCompra.Item("Cantidad", Indice).Value.ToString = "") Then
                                Me.GridCompra.Item("Cantidad", Indice).Value = "1"
                            End If
                            Me.GridCompra.Item("Unidad", Indice).Value = DR("UnidadAlt").ToString
                            Me.GridCompra.Item("idUnidad", Indice).Value = DR("idUnidadAlt").ToString
                            '   Me.BUnidAlt.BackColor = Color.Gainsboro

                            If (DR("Unidad").ToString = TomarPalabra(DR("TipoFactorAlt").ToString)) Then
                                Me.GridCompra.Item("Costo", Indice).Value = VFormat(Me.GridCompra.Item("Costo", Indice).Value * DR("FactorAlt"), 4)
                                Me.GridCompra.Item("CostoD", Indice).Value = VFormat(Me.GridCompra.Item("CostoD", Indice).Value * DR("FactorAlt"), 4)
                                Me.GridCompra.Item("Stock", Indice).Value = VFormat(DR("FactorAlt") * Me.GridCompra.Item("Cantidad", Indice).Value, 2)
                                Me.GridCompra.Item("UnidadAlt", Indice).Value = "Alterna"
                                Me.GridCompra.Item("FactorAlt", Indice).Value = DR("FactorAlt")
                                Me.BUnidAlt.Tag = "Alterna"
                                Me.BUnidAlt.Text = "&Unidad" & " (" & VFormat(DR("FactorAlt"), 2) & ")"
                                Me.BUnidAlt.ToolTipText = "Unidad."
                                Me.GridCompra.Item("SelAlterno", Indice).Value = True
                                Me.BUnidAlt.BackColor = Color.Gainsboro
                            Else
                                Me.GridCompra.Item("Costo", Indice).Value = VFormat(Me.GridCompra.Item("Costo", Indice).Value / (DR("FactorAlt")), 4)
                                Me.GridCompra.Item("CostoD", Indice).Value = VFormat(Me.GridCompra.Item("CostoD", Indice).Value / (DR("FactorAlt")), 4)
                                Me.GridCompra.Item("Stock", Indice).Value = Me.GridCompra.Item("Cantidad", Indice).Value / DR("FactorAlt")
                                Me.GridCompra.Item("UnidadAlt", Indice).Value = "Alterna"
                                Me.GridCompra.Item("FactorAlt", Indice).Value = DR("FactorAlt")
                                Me.BUnidAlt.Tag = "Alterna"
                                Me.BUnidAlt.Text = "&Unidad" & " (" & VFormat(DR("FactorAlt"), 2) & ")"
                                Me.BUnidAlt.ToolTipText = "Unidad."
                                Me.GridCompra.Item("SelAlterno", Indice).Value = True
                                Me.BUnidAlt.BackColor = Color.Gainsboro
                            End If
                        Else
                            If (Me.GridCompra.Item("Cantidad", Indice).Value.ToString = "") Then
                                Me.GridCompra.Item("Cantidad", Indice).Value = "1"
                            End If
                            Me.GridCompra.Item("Unidad", Indice).Value = DR("Unidad").ToString
                            Me.GridCompra.Item("idUnidad", Indice).Value = DR("idUnidad").ToString
                            '    Me.BUnidAlt.BackColor = Color.White
                            If (DR("Unidad").ToString = TomarPalabra(DR("TipoFactorAlt").ToString)) Then
                                Me.GridCompra.Item("Costo", Indice).Value = VFormat((Me.GridCompra.Item("Costo", Indice).Value / DR("FactorAlt")), 4)
                                Me.GridCompra.Item("CostoD", Indice).Value = VFormat((Me.GridCompra.Item("CostoD", Indice).Value / DR("FactorAlt")), 4)
                            Else
                                Me.GridCompra.Item("Costo", Indice).Value = VFormat((Me.GridCompra.Item("Costo", Indice).Value * DR("FactorAlt")), 4)
                                Me.GridCompra.Item("CostoD", Indice).Value = VFormat((Me.GridCompra.Item("CostoD", Indice).Value * DR("FactorAlt")), 4)
                            End If
                            Me.GridCompra.Item("Stock", Indice).Value = Me.GridCompra.Item("Cantidad", Indice).Value
                            Me.BUnidAlt.Tag = "Unidad"
                            Me.BUnidAlt.Text = "&Unidad Alt."
                            Me.BUnidAlt.ToolTipText = "Unidad Alterna."
                            Me.GridCompra.Item("SelAlterno", Indice).Value = False
                            Me.BUnidAlt.BackColor = Color.White
                            'Me.GridCompra.Item("UnidadAlt", Indice).Value = "Unidad"
                            'Me.GridCompra.Item("FactorAlt", Indice).Value = 1
                        End If
                    End If
                End While
                DR.Close()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Cambiar la Unidad del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

    Private Sub CalcularStock(Cod As String, Indice As Integer)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("SELECT * FROM VUnidades WHERE idProducto=@idProducto", CNN)
                Comando.Parameters.Add(New SqlParameter("@idproducto", Cod))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                While (DR.Read)
                    If (Me.BUnidAlt.Tag = "Unidad") Then
                        If (Me.GridCompra.Item("Cantidad", Indice).Value = Nothing) Then
                            Me.GridCompra.Item("Cantidad", Indice).Value = "1"
                        End If
                        If (Me.GridCompra.Item("Cantidad", Indice).Value.ToString = "") Then
                            Me.GridCompra.Item("Cantidad", Indice).Value = "1"
                        End If

                        Me.GridCompra.Item("Stock", Indice).Value = Me.GridCompra.Item("Cantidad", Indice).Value
                    Else
                        If (DR("Unidad").ToString = TomarPalabra(DR("TipoFactorAlt").ToString)) Then
                            Me.GridCompra.Item("Stock", Indice).Value = DR("FactorAlt") * Me.GridCompra.Item("Cantidad", Indice).Value
                        Else
                            Me.GridCompra.Item("Stock", Indice).Value = Me.GridCompra.Item("Cantidad", Indice).Value / DR("FactorAlt")
                        End If
                    End If
                End While
                DR.Close()
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar el Stock del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub BUnidAlt_Click(sender As Object, e As EventArgs) Handles BUnidAlt.Click
        Dim DescuentoX As Decimal = 0
        If GridCompra.CurrentRow IsNot Nothing Then
            CambiarUnidadAlt(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value, Me.GridCompra.CurrentRow.Index)
            If (MonedaBase = "Bolívar") Then
                DescuentoX = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)) / 100
            Else
                DescuentoX = (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value)) / 100
            End If
            Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(DescuentoX * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
            TotalizarLinea(Me.GridCompra.CurrentRow.Index)
            CalcularCostoCalculado(Me.GridCompra.CurrentRow.Index)
            Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad")
            Me.GridCompra.BeginEdit(True)
        Else
            MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
            If (Me.GridCompra.RowCount > 0) Then
                Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
            End If
        End If
    End Sub

    Private Sub BPrecios_Click(sender As Object, e As EventArgs) Handles BPrecios.Click
        'If GridCompra.CurrentRow IsNot Nothing Then
        '    If (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value.ToString) <> 0) Then
        '        FPrecioNew.LCodigo.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
        '        FPrecioNew.LNombre.Text = StrConv(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Articulo").Value, VbStrConv.ProperCase)

        '        If (Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("VentaUnidAlt").Value) Then
        '            FPrecioNew.LCostoCalImp.Tag = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCal").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalImp.Text = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCal").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalDImp.Tag = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalD").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalDImp.Text = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalD").Value), "##,##0.00")
        '        Else
        '            FPrecioNew.LCostoCalImp.Tag = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalUnitario").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalImp.Text = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalUnitario").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalDImp.Tag = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalUnitarioD").Value), "##,##0.00")
        '            FPrecioNew.LCostoCalDImp.Text = Format(Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalUnitarioD").Value), "##,##0.00")
        '        End If
        '        FPrecioNew.TipoMoneda.Tag = MonedaBase
        '        VarBuscar = "Compra"
        '        ValTotal = IIf(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Precio1").Value.ToString = "", 0, Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Precio1").Value)
        '        FPrecioNew.ShowDialog()
        '    Else
        '        MsgBox("Debe Agregar el Costo del Producto para realizar el Calculo del Precio.", MsgBoxStyle.Information, "MarSoft: Información.")
        '    End If
        'Else
        '    MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
        '    If (Me.GridCompra.RowCount > 0) Then
        '        Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
        '    End If
        'End If
    End Sub
    Private Sub GridCompra_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridCompra.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)
        AddHandler validar.KeyPress, AddressOf validar_Keypress
        AddHandler validar.KeyUp, AddressOf TextBox_KeyUp
    End Sub
    Private Sub TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case Me.GridCompra.Columns(Me.GridCompra.CurrentCell.ColumnIndex).Name
            Case Is = "Costo", "CostoD", "Cantidad", "SubTotal"
                ValidarPuntoSeparacion(sender, True)
        End Select
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracter As Char = e.KeyChar
        Dim txt As TextBox = CType(sender, TextBox)
        If (Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Balanza").Value) Then
            Select Case Me.GridCompra.Columns(Me.GridCompra.CurrentCell.ColumnIndex).Name
                Case Is = "Costo", "Cantidad", "CostoD", "SubTotal"
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
        Else
            Select Case Me.GridCompra.Columns(Me.GridCompra.CurrentCell.ColumnIndex).Name
                Case Is = "Cantidad"
                    If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                Case Is = "Costo", "SubTotal"
                    If (caracter = ".") Then
                        caracter = ","
                        e.KeyChar = ","
                    End If
                    If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                Case Is = "CostoD"
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
        End If
    End Sub
    Private Sub BObservacion_Click(sender As Object, e As EventArgs) Handles BObservacion.Click
        If GridCompra.CurrentRow IsNot Nothing Then
            FComentario.LCodigo.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
            FComentario.LNombre.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Articulo").Value
            FComentario.TComentario.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("ObservacionLineaCompra").Value
            VarForma = "Compra"
            FComentario.ShowDialog()
        Else
            MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
            If (Me.GridCompra.RowCount > 0) Then
                Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
            End If
        End If
    End Sub

    Private Sub BMonedaPago_Click(sender As Object, e As EventArgs) Handles BMonedaPago.Click
        VarBuscar = "MonedaPagoCompra"
        FBuscarOrden.LTitulo.Text = "Listado de Monedas."
        FBuscarOrden.LTitulo.Tag = Me.BMonedaPago.Tag
        FBuscarOrden.ShowDialog()
        ValidarMonedaBase()
        For I = 0 To Me.GridCompra.RowCount - 1
            Me.GridCompra.Rows(I).Cells("Costo").Value = VFormat(Convert.ToDecimal(Me.GridCompra.Rows(I).Cells("Costo").Value), 4)
            Me.GridCompra.Rows(I).Cells("CostoD").Value = VFormat(Convert.ToDecimal(Me.GridCompra.Rows(I).Cells("CostoD").Value), 4)
            TotalizarLinea(I)
            CalcularCostoCalculado(I)
        Next
        Totalizar()
    End Sub

    Private Sub BAli_Click(sender As Object, e As EventArgs) Handles BAli.Click
        If GridCompra.CurrentRow IsNot Nothing Then
            VarBuscar = "AlicuotaCompra"
            FBuscarOrden.LTitulo.Tag = 0
            FBuscarOrden.ShowDialog()
            Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("Impuesto").Value = VFormat((Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("Costo").Value) / 100) * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentCell.RowIndex).Cells("ValorAlicuota").Value), 4)
            TotalizarLinea(Me.GridCompra.CurrentCell.RowIndex)
            CalcularCostoCalculado(Me.GridCompra.CurrentCell.RowIndex)
            Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).Cells("Alicuota")
        Else
            MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
            If (Me.GridCompra.RowCount > 0) Then
                Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
            End If
        End If
    End Sub
    Private Sub BCosto_Click(sender As Object, e As EventArgs) Handles BCosto.Click
        If GridCompra.CurrentRow IsNot Nothing Then
            Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value = IIf(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value = Nothing, 0, Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value)
            If (Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value.ToString) <> 0) Then
                'FCostosdescuentos.LCodigo.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Codigo").Value
                'FCostosdescuentos.LNombre.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Articulo").Value
                'FCostosdescuentos.TCostoBruto.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Costo").Value
                'FCostosdescuentos.TCostoBrutoD.Text = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoD").Value
                'FCostosdescuentos.TCostoBrutoGral.Text = SumarColumna(Me.GridCompra, 7)
                'FCostosdescuentos.TCostoBrutoDGral.Text = SumarColumna(Me.GridCompra, 8)
                'FCostosdescuentos.TGastosAsoc.Text = Me.TGastos.Tag
                'FCostosdescuentos.tGastosAsocD.Text = Format(Convert.ToDouble(Me.TGastos.Tag) / BsXDolar, "##,##0.00")
                'FechaXCompra = Me.FechaRegistro.Value.Date
                'FCostosdescuentos.ShowDialog()
                If (NoActualizar = False) Then
                    Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCal").Value = Format(NuevoCosto, "##,##0.00")
                    Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoAgregado").Value = Format(NuevoCosto, "##,##0.00")
                    Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoCalD").Value = Format(NuevoCostoD, "##,##0.00")
                    Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("CostoAgregadoD").Value = Format(NuevoCostoD, "##,##0.00")
                    If (MonedaBase = "Bolívar") Then
                        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(NuevoDescuento * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
                        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value = Format(NuevoPorcDesc, "##,##0.00")
                    Else
                        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Descuento").Value = Format(NuevoDescuentoD * Convert.ToDecimal(Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("Cantidad").Value), "##,##0.00")
                        Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("DescLinea").Value = Format(NuevoPorcDesc, "##,##0.00")
                    End If
                    TotalizarLinea(Me.GridCompra.CurrentCell.RowIndex)
                    CalcularCostoCalculado(Me.GridCompra.CurrentCell.RowIndex)
                End If
            Else
                MsgBox("Debe Agregar el Costo Bruto del Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
            If (Me.GridCompra.RowCount > 0) Then
                Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VarBuscar = "TipoDocCompra"
        FBuscarOrden.LTitulo.Text = "Tipo de Documento."
        FBuscarOrden.LTitulo.Tag = Me.CTipoDoc.Tag
        FBuscarOrden.ShowDialog()
    End Sub

    Private Sub BTipoDocumento_Click(sender As Object, e As EventArgs) Handles BTipoDocumento.Click
        '  FTipoDocumento.ShowDialog()
    End Sub

    Private Sub BMoneda_Click(sender As Object, e As EventArgs) Handles BMoneda.Click
        'FMonedas.TCodigo.Text = 9
        'FMonedas.ShowDialog()
        'Me.Proyectada.Text = CalcularDolar(Me.FechaFactura.Value, "0")
        Me.Proyectada.Text = Format(BsXDolar, "##,##0.00")
        Me.Paralelo.Text = Format(BsXDolarOficial, "##,##0.00")
        Me.BancoCentral.Text = Format(BsXDolarBC, "##,##0.00")
        Me.Efectivo.Text = Format(BsXDolarEfectivo, "##,##0.00")

        Me.Proyectada.Tag = Format(BsXDolar, "##,##0.00")
        Me.Paralelo.Tag = Format(BsXDolarOficial, "##,##0.00")
        Me.BancoCentral.Tag = Format(BsXDolarBC, "##,##0.00")
        Me.Efectivo.Tag = Format(BsXDolarEfectivo, "##,##0.00")
        ColorearTasaSeleccionada(TasaSeleccionada)
        BsXDolar = IIf(Me.TTasa.Text = "", 0, Me.TTasa.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VarForma = "Efectivo"
        '   FEfectivo.ShowDialog()
    End Sub

    'Private Sub BMoneda1_Click(sender As Object, e As EventArgs) Handles BMoneda1.Click
    '    FMonedas.TCodigo.Text = "9"
    '    FMonedas.ShowDialog()
    '    Me.Proyectada.Text = CalcularDolar(Me.FechaFactura.Value, "0")
    '    Me.Proyectada.Text = Format(BsXDolar, "##,##0.00")
    '    Me.Paralelo.Text = Format(BsXDolarOficial, "##,##0.00")
    '    Me.BancoCentral.Text = Format(BsXDolarBC, "##,##0.00")
    '    Me.Efectivo.Text = Format(BsXDolarEfectivo, "##,##0.00")

    '    Me.Proyectada.Tag = Format(BsXDolar, "##,##0.00")
    '    Me.Paralelo.Tag = Format(BsXDolarOficial, "##,##0.00")
    '    Me.BancoCentral.Tag = Format(BsXDolarBC, "##,##0.00")
    '    Me.Efectivo.Tag = Format(BsXDolarEfectivo, "##,##0.00")
    '    ColorearTasaSeleccionada(TasaSeleccionada)
    '    BsXDolar = IIf(Me.TTasa.Text = "", 0, Me.TTasa.Text)
    'End Sub

    Private Sub BGastos_Click(sender As Object, e As EventArgs) Handles BGastos.Click
        VarForma = "Gastos"
        '   FGastos.Show()
        VarForma = ""
        Me.TabControl1.SelectedIndex = 0
    End Sub

    Private Sub DGVListadoCompras_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DGVListadoCompras.CellStateChanged
        VarBuscar = 1
    End Sub
    'Function CambiarPuntoComa(valor As Decimal) As String
    '    Dim valorx As String = ""
    '    If (valor.ToString.IndexOf(".") <> -1) Then

    '    Else

    '    End If
    '    Return valor
    'End Function
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    'If Conectar2() Then
    '    '    Dim Comando2 As New SqlCommand("SELECT idCategoriaInt, sum(Stock) as SumaStock FROM TNewProducto where idCategoriaInt <> 1 and idCategoriaInt <> 2 GROUP by idCategoriaInt", CNN2)
    '    '    Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
    '    '    Do While DatosArt.Read()
    '    '        If (Conectar()) Then
    '    '            Dim x As String = Replace(DatosArt("SumaStock").ToString, ",", ".")
    '    '            Dim comando As New SqlCommand("UPdate TNewProducto SET Stock=" & x & " Where idCategoriaInt=" & DatosArt("idCategoriaInt"), CNN)
    '    '            comando.ExecuteReader()
    '    '            Desconectar()
    '    '        End If
    '    '    Loop
    '    '    DatosArt.Close()
    '    '    Desconectar2
    '    'End If
    'End Sub
    Private Sub BGasto_Click(sender As Object, e As EventArgs) Handles BGasto.Click
        'If GridCompra.CurrentRow IsNot Nothing Then
        '    If (Me.GridCompra.RowCount > 0) Then
        '        If (Me.TNumFactura.Text <> "") Then
        '            If (Me.TCodProveedor.Text <> "") Then
        '                MontoGasto = Me.GridCompra.CurrentRow.Cells("Total").Value
        '                MontoGastoD = Me.GridCompra.CurrentRow.Cells("TotalD").Value
        '                FGastos.TNombre.Text = "Compra: " & Me.GridCompra.CurrentRow.Cells("Articulo").Value & "."
        '                idGastoDesdeCompra = IIf(Me.GridCompra.CurrentRow.Cells("Gasto").Value.ToString = "", 0, Me.GridCompra.CurrentRow.Cells("Gasto").Value)
        '                FGastos.TNumFactura.Text = Me.TNumFactura.Text
        '                FGastos.BIrCompra.Text = CodCompra
        '                FGastos.TProveedor.Text = Me.LProveedor2.Text
        '                FGastos.TProveedor.Tag = Me.TCodProveedor.Text
        '                FGastos.TAlias.Text = Me.LAlias2.Text
        '                FechaXCompra = Me.FechaFactura.Value.Date
        '                VarForma = "GastoCompra"
        '                If FormularioAbierto(FGastos) Then
        '                    Me.Hide()
        '                    FGastos.ShowDialog()
        '                Else
        '                    FGastos.ShowDialog()
        '                End If
        '                Me.GridCompra.CurrentRow.Cells("Gasto").Value = IIf(idGastoDesdeCompra = 0, "", idGastoDesdeCompra)
        '                Me.GridCompra.CurrentRow.DefaultCellStyle.BackColor = IIf(idGastoDesdeCompra = 0, Color.White, Color.LightCoral)
        '            Else
        '                MsgBox("Debe Seleccionar un Proveedor.", MsgBoxStyle.Information, "MarSoft: Información.")
        '                Me.BProveedor.Focus()
        '            End If
        '        Else
        '            MsgBox("Debe Ingresar el Número de Factura para Agregar el Gasto.", MsgBoxStyle.Information, "MarSoft: Información.")
        '            Me.TNumFactura.Focus()
        '        End If
        '    Else
        '        MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
        '        If (Me.GridCompra.RowCount > 0) Then
        '            Me.GridCompra.CurrentCell = Me.GridCompra.Rows(Me.GridCompra.CurrentRow.Index).Cells("BProd")
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub DGVListadoCompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoCompras.CellContentClick
        If (Me.DGVListadoCompras.RowCount > 0) Then
            If (Me.DGVListadoCompras.Columns(e.ColumnIndex).Name = "Detalle") Then
                'FExaminarCuentas.LFecha1.Text = "Fecha de Compra: "
                'FExaminarCuentas.LFecha.Text = Me.DGVListadoCompras.CurrentRow.Cells("FechaFactura").Value
                'FExaminarCuentas.LCliente1.Text = "Proveedor: "
                'FExaminarCuentas.LCliente.Text = Me.DGVListadoCompras.CurrentRow.Cells("Prov").Value
                'FExaminarCuentas.LTotal.Text = Format(Convert.ToDecimal(Me.DGVListadoCompras.CurrentRow.Cells("Total").Value), "##,##0.0000")
                'FExaminarCuentas.LTotalD.Text = Format(Convert.ToDecimal(Me.DGVListadoCompras.CurrentRow.Cells("TotalD").Value), "##,##0.0000")
                'CodCompra = Me.DGVListadoCompras.Item("idCompra", e.RowIndex).Value
                'VarBuscar = "CuentasporPagar"
                'FExaminarCuentas.Show()
            End If

            If (Me.DGVListadoCompras.Columns(e.ColumnIndex).Name = "Actualizar") Then
                Try
                    If Conectar2() Then
                        Dim Comando2 As New SqlCommand("Select * FROM VDetalleCompra WHERE idCompra=@idCompra", CNN2)
                        Comando2.Parameters.AddWithValue("@idCompra", Me.DGVListadoCompras.Item("idCompra", e.RowIndex).Value)
                        Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
                        Me.GridCompra.Rows.Clear()
                        Do While DatosArt.Read()
                            Dim TipoFactorAlt As String
                            If DatosArt("TipoFactorAlt").ToString = "" Then
                                TipoFactorAlt = DatosArt("Unidad").ToString & " X"
                            Else
                                TipoFactorAlt = DatosArt("TipoFactorAlt").ToString
                            End If
                            Me.GridCompra.Rows.Add(Me.GridCompra.RowCount + 1, DatosArt("Codigo"), DatosArt("Producto"), DatosArt("Unidad"), DatosArt("idUnidad"), VFormat(DatosArt("Cantidad"), 3), VFormat(DatosArt("Stock"), 3), VFormat(DatosArt("Costo"), 4), VFormat(DatosArt("CostoD"), 4), VFormat(DatosArt("Descuento"), 4), VFormat(DatosArt("SubTotal"), 4), VFormat(DatosArt("Impuesto"), 4), DatosArt("NomAlicuota"), DatosArt("idAlicuota"), VFormat(DatosArt("Alicuota"), 4), VFormat(DatosArt("TotalD"), 4), VFormat(DatosArt("Total"), 4), DatosArt("Balanza"), VFormat(DatosArt("CostoCal"), 4), VFormat(DatosArt("CostoCalD"), 4), VFormat(DatosArt("Precio1"), 4), DatosArt("Observaciones"), DatosArt("Precio2"), DatosArt("Precio3"), DatosArt("Precio4"), DatosArt("PrecioE"), DatosArt("PrecioD1"), DatosArt("PrecioD2"), DatosArt("PrecioD3"), DatosArt("PrecioD4"), DatosArt("PrecioDE"), DatosArt("UnidadAlt"), DatosArt("FactorAlt"), DatosArt("CostoAgregado"), DatosArt("CostoAgregadoD"), VFormat(DatosArt("CostoUnitario"), 4), VFormat(DatosArt("CostoUnitarioD"), 4), DatosArt("idTipoProducto"), DatosArt("Empaquetado"), TipoFactorAlt, DatosArt("Venta"), DatosArt("SelAlterno"), DatosArt("CostoUnitario"), DatosArt("CostoUnitarioD"), DatosArt("idCategoriaInt"), VFormat(DatosArt("Capacidad"), 2), DatosArt("idGastoCompra"), DatosArt("idUnidadCapacidad"), DatosArt("UnidadCapacidad"), DatosArt("CalculoCap"), DatosArt("PorcDesc"), DatosArt("VentaUnidAlt"), DatosArt("PrecioAnt"), DatosArt("PrecioAntD"))
                            Dim VarGasto As Integer = 0
                            If (DatosArt("idGastoCompra").ToString = "") Then
                                VarGasto = 0
                            Else
                                VarGasto = DatosArt("idGastoCompra")
                            End If
                            Me.GridCompra.Rows(Me.GridCompra.RowCount - 1).DefaultCellStyle.BackColor = IIf(VarGasto = 0, Color.White, Color.LightCoral)
                            idGastoDesdeCompra = VarGasto
                            Me.BGasto.Text = "Gasto: " & idGastoDesdeCompra
                        Loop
                        DatosArt.Close()
                        Comando2.CommandText = "Select * FROM VCompras WHERE idCompra=@idCompra2"
                        Comando2.Parameters.AddWithValue("@idCompra2", Me.DGVListadoCompras.Item("idCompra", e.RowIndex).Value)
                        DatosArt = Comando2.ExecuteReader()
                        Do While DatosArt.Read()
                            MonedaBase = DatosArt("MonedaBase").ToString
                            MonedaPago = DatosArt("MonedaPago").ToString
                            Me.CDeposito.Text = DatosArt("Deposito").ToString
                            Me.TCodProveedor.Text = DatosArt("idProveedor").ToString
                            '  MostrarProd()
                            Me.FechaRegistro.Value = DatosArt("Fecha").ToString

                            Me.LSubTotalD.Text = Format(Convert.ToDouble(DatosArt("SubTotalD").ToString), "##,##0.0000")
                            Me.LDescuentoD.Text = Format(Convert.ToDouble(DatosArt("DescGralD").ToString), "##,##0.0000")
                            Me.LIVAD.Text = Format(Convert.ToDouble(DatosArt("IVAD").ToString), "##,##0.0000")
                            Me.LTotalD.Text = Format(Convert.ToDouble(DatosArt("TotalD").ToString), "##,##0.0000")

                            Me.LSubTotalBs.Text = Format(Convert.ToDouble(DatosArt("SubTotal").ToString), "##,##0.0000")
                            Me.LDescuento.Text = Format(Convert.ToDouble(DatosArt("DescGral").ToString), "##,##0.0000")
                            Me.LIVABs.Text = Format(Convert.ToDouble(DatosArt("IVA").ToString), "##,##0.0000")
                            Me.LTotalBs.Text = Format(Convert.ToDouble(DatosArt("Total").ToString), "##,##0.0000")

                            Me.CTipoCompra.Text = DatosArt("TipoCompra").ToString
                            Me.CComprador.Text = DatosArt("Comprador").ToString
                            Me.CBCompraEnEfectivo.Checked = DatosArt("CompraEnEfectivo").ToString
                            Me.TNumFactura.Text = DatosArt("NFactura").ToString
                            Me.TNumControl.Text = DatosArt("NControl").ToString
                            Me.FechaFactura.Value = DatosArt("FechaFactura").ToString
                            Me.TSerial.Text = DatosArt("SerialMaqFiscal").ToString
                            Me.CTipoDoc.Text = DatosArt("TipoDoc").ToString
                            Me.CBLibro.Checked = DatosArt("Libro").ToString
                            Me.TTasa.Text = DatosArt("TasaSel")
                            Me.TUsuario.Text = DatosArt("Usuario")
                            Me.CLocal.Text = DatosArt("Local")
                            CodPDF = DatosArt("PDF")
                            Me.LEvidencia.Tag = CodPDF
                            Me.LEvidencia.Text = "Factura: " & CodPDF
                            Me.CBIncluirGastos.Checked = DatosArt("IncluirGastos")
                            Me.CBFacturaCredito.Checked = DatosArt("FacturaCredito")
                        Loop

                        'AgregarAlias()
                        'CalcularMontosFinales()
                        'SumarColumnaTotal(Me.DGVListadoCompras)


                        DatosArt.Close()
                        Comando2.CommandText = "Select ISNULL(Sum(Monto),0) as Monto,ISNULL(Sum(MontoD),0) as MontoD FROM TGastosComprasForaneas WHERE idCompra=@idCompra3"
                        Comando2.Parameters.AddWithValue("@idCompra3", Me.DGVListadoCompras.Item(0, e.RowIndex).Value)
                        DatosArt = Comando2.ExecuteReader()
                        If (DatosArt.Read()) Then
                            ' If (MonedaBase = "Bolívar") Then
                            Me.TGastos.Tag = Format(DatosArt("Monto"), "##,##0.00")
                            Me.TGastosD.Tag = Format(DatosArt("MontoD"), "##,##0.00")
                            Me.TGastos.Text = "Bs. " & Format(DatosArt("Monto"), "##,##0.00")
                            Me.TGastosD.Text = "$ " & Format(DatosArt("MontoD"), "##,##0.00")
                            'Else
                            '    Me.TGastos.Tag = Format(DatosArt("Monto"), "##,##0.0000")
                            ' End If
                        Else
                            Me.TGastos.Tag = 0
                            Me.TGastosD.Tag = 0
                        End If
                        DatosArt.Close()
                    End If
                    Desconectar2()
                    Me.Proyectada.Text = CalcularDolar(Me.FechaFactura.Value, "0")
                    Me.Proyectada.Text = Format(BsXDolar, "##,##0.00")
                    Me.Paralelo.Text = Format(BsXDolarOficial, "##,##0.00")
                    Me.BancoCentral.Text = Format(BsXDolarBC, "##,##0.00")
                    Me.Efectivo.Text = Format(BsXDolarEfectivo, "##,##0.00")
                    Me.Proyectada.Tag = Format(BsXDolar, "##,##0.00")
                    Me.Paralelo.Tag = Format(BsXDolarOficial, "##,##0.00")
                    Me.BancoCentral.Tag = Format(BsXDolarBC, "##,##0.00")
                    Me.Efectivo.Tag = Format(BsXDolarEfectivo, "##,##0.00")
                    ColorearTasaSeleccionada("x")
                    BsXDolar = IIf(Me.TTasa.Text = "", 0, Me.TTasa.Text)
                    ActivarGuardar = False
                    'Me.BGuardar.Enabled = False
                    'Me.BActualizar.Enabled = True
                    'Me.BEliminarCompra.Enabled = True
                    'Me.BPDF.Enabled = True

                    Me.TCodImprimir.Text = Me.DGVListadoCompras.Item(0, e.RowIndex).Value
                    CodCompra = Convert.ToInt16(Me.DGVListadoCompras.Item(0, e.RowIndex).Value)
                    Me.LNumDoc.Text = RellenarCeros(CodCompra.ToString, 10)
                    idGastoDesdeCompra = 0
                    ValidarMonedaBase()
                    Me.TabControl1.SelectedIndex = 0
                Catch ex As Exception
                    MessageBox.Show("ERROR al conectar o recuperar los datos de los Detalles de la Compra. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar2()
                End Try
            End If

            If (Me.DGVListadoCompras.Columns(e.ColumnIndex).Name = "FormaPago") Then
                CodCompra = Convert.ToInt16(Me.DGVListadoCompras.Item("idCompra", e.RowIndex).Value)
                CodProveedor = Convert.ToInt16(Me.DGVListadoCompras.Item("idProveedor", e.RowIndex).Value)
                Proveedor = Me.DGVListadoCompras.Item("Prov", e.RowIndex).Value
                Num_Doc = RellenarCeros(CodCompra.ToString, 10)
                ValTotal = Convert.ToDecimal(Me.DGVListadoCompras.Item("Total", e.RowIndex).Value)
                ValTotalD = Convert.ToDecimal(Me.DGVListadoCompras.Item("TotalD", e.RowIndex).Value)
                TasaCambioInic = Convert.ToDecimal(Me.DGVListadoCompras.Item("TasaCambioI", e.RowIndex).Value)
                MonedaBase = Me.DGVListadoCompras.Item("MonedaBase", e.RowIndex).Value
                MonedaPago = Me.DGVListadoCompras.Item("MonedaPago", e.RowIndex).Value
                VarForma = "ListaCompra"
                FechaXCompra = Me.DGVListadoCompras.Item("Fecha", e.RowIndex).Value
                CodPDF = Me.DGVListadoCompras.Item("Evidencia", e.RowIndex).Value
                '      FFormaPago.ShowDialog()
                Me.CTipoCompraL.Text = "Todas"
                BBuscar_Click(Nothing, Nothing)
            End If
        End If
        If (Me.DGVListadoCompras.Columns(e.ColumnIndex).Name = "Evidencia") Then
            AuxVarForma = VarForma
            VarForma = "Factura"
            CodPDF = Me.DGVListadoCompras.Item("Evidencia", e.RowIndex).Value
            '    FComprovantes.ShowDialog()
            VarForma = AuxVarForma
            If (Autorizado) Then
                Me.BPDF.Tag = CodPDF
                Me.BPDF.Text = "   Factura: " & CodPDF & "   "
            Else
                Me.BPDF.Tag = 0
                Me.BPDF.Text = "     Factura:  0     "
            End If
        End If

    End Sub
    Private Sub ColorearTasaSeleccionada(Tasa As String)
        Me.Proyectada.BackColor = Color.Gainsboro
        Me.Proyectada.Font = New Font(Proyectada.Font, FontStyle.Regular)
        Me.Paralelo.BackColor = Color.Gainsboro
        Me.Paralelo.Font = New Font(Paralelo.Font, FontStyle.Regular)
        Me.BancoCentral.BackColor = Color.Gainsboro
        Me.BancoCentral.Font = New Font(BancoCentral.Font, FontStyle.Regular)
        Me.Efectivo.BackColor = Color.Gainsboro
        Me.Efectivo.Font = New Font(Efectivo.Font, FontStyle.Regular)

        Select Case Tasa
            Case "Proyectada"
                Me.Proyectada.BackColor = System.Drawing.Color.FromArgb(254, 255, 128)
                Me.Proyectada.Font = New Font(Proyectada.Font, FontStyle.Bold)
            Case "Paralelo"
                Me.Paralelo.BackColor = System.Drawing.Color.FromArgb(254, 255, 128)
                Me.Paralelo.Font = New Font(Paralelo.Font, FontStyle.Bold)
            Case "BancoCentral"
                Me.BancoCentral.BackColor = System.Drawing.Color.FromArgb(254, 255, 128)
                Me.BancoCentral.Font = New Font(BancoCentral.Font, FontStyle.Bold)
            Case "Efectivo"
                Me.Efectivo.BackColor = System.Drawing.Color.FromArgb(254, 255, 128)
                Me.Efectivo.Font = New Font(Efectivo.Font, FontStyle.Bold)
        End Select
    End Sub
    Private Sub CambioTasa()
        For i = 0 To Me.GridCompra.RowCount - 1
            If (Me.GridCompra.Rows(i).Cells("Costo").Value.ToString = "") Then
                Me.GridCompra.Rows(i).Cells("Costo").Value = "0"
            End If
            CalcularStock(Me.GridCompra.Rows(i).Cells("Codigo").Value, i)
            TotalizarLinea(i)
            CalcularCostoCalculado(i)
        Next
    End Sub
    Private Sub Proyectada_Click(sender As Object, e As EventArgs) Handles Proyectada.Click
        TasaSeleccionada = "Proyectada"
        BsXDolar = Me.Proyectada.Tag
        TTasa.Text = Me.Proyectada.Tag
        CambioTasa()
        ColorearTasaSeleccionada("Proyectada")
    End Sub

    Private Sub Oficial_Click(sender As Object, e As EventArgs) Handles Paralelo.Click
        TasaSeleccionada = "Paralelo"
        BsXDolar = Me.Paralelo.Tag
        TTasa.Text = Me.Paralelo.Tag
        CambioTasa()
        ColorearTasaSeleccionada("Paralelo")
    End Sub
    Private Sub BancoCentral_Click(sender As Object, e As EventArgs) Handles BancoCentral.Click
        TasaSeleccionada = "BancoCentral"
        BsXDolar = Me.BancoCentral.Tag
        TTasa.Text = Me.BancoCentral.Tag
        CambioTasa()
        ColorearTasaSeleccionada("BancoCentral")
    End Sub
    Private Sub Efectivo_Click(sender As Object, e As EventArgs) Handles Efectivo.Click
        TasaSeleccionada = "Efectivo"
        BsXDolar = Me.Efectivo.Tag
        TTasa.Text = Me.Efectivo.Tag
        CambioTasa()
        ColorearTasaSeleccionada("Efectivo")
    End Sub
    Private Sub TTasa_KeyDown(sender As Object, e As KeyEventArgs) Handles TTasa.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            BsXDolar = Convert.ToDecimal(IIf(Me.TTasa.Text = "", 0, Me.TTasa.Text))
            CambioTasa()
        End If
    End Sub
    Private Sub TTasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTasa.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumerico(TTasa, e.KeyChar, True)
    End Sub
    Private Sub TTasa_KeyUp(sender As Object, e As KeyEventArgs) Handles TTasa.KeyUp
        ValidarPuntoSeparacion(TTasa, True)
    End Sub
    Private Sub TTasa_LostFocus(sender As Object, e As EventArgs) Handles TTasa.LostFocus
        BsXDolar = Convert.ToDecimal(IIf(Me.TTasa.Text = "", 0, Me.TTasa.Text))
        CambioTasa()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles BRestaurarCompra.Click
        If (Me.TCodImprimir.Text <> "") Then
            '  If MsgBox("Si Continúa se Perderan los Datos de La Compra: " & TCodImprimir.Text & " y todos sus detalles que no han sido Guardados?", vbYesNo, "MarSoft: Eliminar Compra.") = vbYes Then
            RestaurarFormas()
            Me.BActualizar.Enabled = False
            Me.BEliminarCompra.Enabled = False
            Me.BGuardar.Enabled = True
            Me.TabControl1.SelectedIndex = 0
            'End If
        Else
            MessageBox.Show("Esta Compra No ha sido Guardada.  ", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BSiguiente_Click(sender As Object, e As EventArgs) Handles BSiguiente.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(1)
        BBuscar_Click(Nothing, Nothing)
    End Sub

    Private Sub BAnterior_Click(sender As Object, e As EventArgs) Handles BAnterior.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(-1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(-1)
        BBuscar_Click(Nothing, Nothing)
    End Sub
    Private Sub GridCompra_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCompra.CellContentDoubleClick
        VarForma = "Compra"
        FProducto.TCodigo.Text = Me.GridCompra.CurrentRow.Cells("Codigo").Value
        FProducto.ShowDialog()
    End Sub

    Private Sub BPDF_Click(sender As Object, e As EventArgs) Handles BPDF.Click
        'AuxVarForma = VarForma
        'VarForma = "Factura"
        'CodPDF = Me.BPDF.Tag
        'FComprovantes.ShowDialog()
        'VarForma = AuxVarForma
        'If (Autorizado) Then
        '    Me.BPDF.Tag = CodPDF
        '    Me.BPDF.Text = "   Factura: " & CodPDF & "   "
        'Else
        '    Me.BPDF.Tag = 0
        '    Me.BPDF.Text = "     Factura:  0     "
        'End If
    End Sub

    Private Sub BProveedorL_Click(sender As Object, e As EventArgs) Handles BProveedorL.Click
        VarBuscar = "ProveedorCompraL"
        FBuscarOrden.LTitulo.Text = "Listado Proveedores."
        FBuscarProveedor.LTitulo.Tag = Me.TProveedorL.Tag
        FBuscarProveedor.ShowDialog()
        Me.TProveedorL.Tag = CodProveedor
        Me.TProveedorL.Text = NombreProveedor
        Me.ChProveedor.Checked = True
        BBuscar_Click(Nothing, Nothing)
    End Sub

    Private Sub ChProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles ChProveedor.CheckedChanged
        If (Me.ChProveedor.Checked = False) Then
            Me.TProveedorL.Text = ""
            Me.TProveedorL.Tag = 0
        End If
    End Sub

    Private Sub GridCompra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCompra.CellContentClick

    End Sub

    Private Sub BFactura_Click(sender As Object, e As EventArgs) Handles BFactura.Click
        AuxVarForma = VarForma
        VarForma = "Factura"
        CodPDF = Me.LEvidencia.Tag
        '  FComprovantes.ShowDialog()
        VarForma = AuxVarForma
        If (Autorizado) Then
            Me.LEvidencia.Tag = CodPDF
            Me.LEvidencia.Text = "Evidencia: " & CodPDF
        Else
            Me.LEvidencia.Tag = 0
            Me.LEvidencia.Text = "Evidencia: 0"
        End If
    End Sub

   
End Class