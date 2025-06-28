Imports System.Data.SqlClient

Public Class FBuscar
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private CadSQL As String = ""
    Private Band As Integer = 0

    Private Sub MostrarDatosBusqueda()
        Try
            If Conectar() Then
                Select Case VarBuscar
                    Case "Departamento"
                        CadSQL = "Select idDepartamento,Nombre,Descripcion,Activo,Clasificacion  FROM TLocales"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idDepartamento=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else

                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Descripción"
                        DataGrid.Columns(3).HeaderText = "Activo?"
                        DataGrid.Columns(4).HeaderText = "Clasificación"
                    Case "Deposito"
                        CadSQL = "Select idDeposito,Nombre,Descripcion,Activo,Responsable  FROM TDeposito"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idDeposito=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Descripción"
                        DataGrid.Columns(3).HeaderText = "Activo?"
                        DataGrid.Columns(4).HeaderText = "Responsable"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Articulo"
                        CadSQL = "Select * FROM TArticulo"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idArticulo=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Categoria"
                        DataGrid.Columns(3).HeaderText = "Fecha"
                        DataGrid.Columns(4).HeaderText = "Activo?"
                        DataGrid.Columns(5).HeaderText = "Venta?"
                        DataGrid.Columns(6).Visible = False
                        DataGrid.Columns(7).Visible = False
                        DataGrid.Columns(8).Visible = False
                        DataGrid.Columns(9).Visible = False
                        DataGrid.Columns(10).HeaderText = "Cod Prod."
                        DataGrid.Columns(11).HeaderText = "Producto"
                        DataGrid.Columns(12).HeaderText = "Factor"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CompraProd"
                        CadSQL = "Select idProducto, Nombre, Local, Deposito, Categoria,SubCategoria, FechaCreacion, Descripcion,Garantia, Capacidad, Unidad, Iva, Excento,Stock, Costo, Utilidad1, Utilidad2, Utilidad3, ExistenciaMin, ExistenciaMax,CantidadIng,UnidadIng,Activo,Venta,Imagen,Precio1,Precio2,Precio3, VerGasto , PrecioM1, PrecioM2, PrecioM3,Bagre,idTipoProducto FROM TNewProducto"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idProducto=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0) & " AND Activo=1 ORDER BY Nombre ASC"
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' AND Activo=1 ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Sin Gastos Asoc."
                        DataGrid.Columns(2).Visible = False
                        DataGrid.Columns(3).HeaderText = "Depósito"
                        DataGrid.Columns(3).Visible = False
                        DataGrid.Columns(4).HeaderText = "Categoria"
                        DataGrid.Columns(4).Width = 150
                        DataGrid.Columns(5).HeaderText = "Sub Categoria"
                        DataGrid.Columns(5).Width = 150
                        DataGrid.Columns(6).HeaderText = "F.Creación"
                        DataGrid.Columns(7).HeaderText = "Descripción"
                        DataGrid.Columns(7).Visible = False
                        DataGrid.Columns(8).HeaderText = "Garantia"
                        DataGrid.Columns(8).Visible = False
                        DataGrid.Columns(9).HeaderText = "Capacidad"
                        DataGrid.Columns(9).Visible = False
                        DataGrid.Columns(10).HeaderText = "Unidad"
                        DataGrid.Columns(10).Visible = False
                        DataGrid.Columns(11).Visible = False
                        DataGrid.Columns(12).Visible = False
                        DataGrid.Columns(13).HeaderText = "Stock"
                        DataGrid.Columns(14).HeaderText = "Costo"
                        DataGrid.Columns(25).HeaderText = "Precio 1"
                        DataGrid.Columns(15).Visible = False
                        DataGrid.Columns(26).HeaderText = "Precio 2"
                        DataGrid.Columns(16).Visible = False
                        DataGrid.Columns(27).HeaderText = "Precio 3"
                        DataGrid.Columns(17).Visible = False
                        DataGrid.Columns(18).HeaderText = "Mínimo"
                        DataGrid.Columns(18).Visible = False
                        DataGrid.Columns(19).HeaderText = "Máximo"
                        DataGrid.Columns(19).Visible = False
                        DataGrid.Columns(20).HeaderText = "Cantidad Ing."
                        DataGrid.Columns(20).Visible = False
                        DataGrid.Columns(21).HeaderText = "Unididad Ing."
                        DataGrid.Columns(21).Visible = False
                        DataGrid.Columns(22).HeaderText = "Activo?"
                        DataGrid.Columns(23).HeaderText = "Venta?"
                        DataGrid.Columns(24).Visible = False
                        DataGrid.Columns(32).Visible = False
                        DataGrid.Columns("idProducto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Producto", "AsignarProducto", "FEtiquetas", "FEtiquetasSP", "ProductoFactura"
                        CadSQL = "Select idProducto, Nombre,Categoria,SubCategoria, FechaCreacion, Descripcion,Garantia, Capacidad, Unidad, Iva, Excento,Stock, Costo, Utilidad1, Utilidad2, Utilidad3, ExistenciaMin, ExistenciaMax,CantidadIng,UnidadIng,Activo,Venta,Imagen,Precio1,Precio2,Precio3, VerGasto , PrecioM1, PrecioM2, PrecioM3,Bagre FROM TNewProducto"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idProducto=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0) & " ORDER BY Nombre ASC"
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Sin Gastos Asoc."
                        DataGrid.Columns(2).Visible = False
                        DataGrid.Columns(3).HeaderText = "Depósito"
                        DataGrid.Columns(3).Visible = False
                        DataGrid.Columns(4).HeaderText = "Categoria"
                        DataGrid.Columns(4).Width = 150
                        DataGrid.Columns(5).HeaderText = "Sub Categoria"
                        DataGrid.Columns(5).Width = 150
                        DataGrid.Columns(6).HeaderText = "F.Creación"
                        DataGrid.Columns(7).HeaderText = "Descripción"
                        DataGrid.Columns(7).Visible = False
                        DataGrid.Columns(8).HeaderText = "Garantia"
                        DataGrid.Columns(8).Visible = False
                        DataGrid.Columns(9).HeaderText = "Capacidad"
                        DataGrid.Columns(9).Visible = False
                        DataGrid.Columns(10).HeaderText = "Unidad"
                        DataGrid.Columns(10).Visible = False
                        DataGrid.Columns(11).HeaderText = "IVA"
                        DataGrid.Columns(11).Visible = False
                        DataGrid.Columns(12).HeaderText = "Excento"
                        DataGrid.Columns(12).Visible = False
                        DataGrid.Columns(13).HeaderText = "Stock"
                        DataGrid.Columns(14).HeaderText = "Costo"
                        DataGrid.Columns(25).HeaderText = "Precio 1"
                        DataGrid.Columns(15).Visible = False
                        DataGrid.Columns(26).HeaderText = "Precio 2"
                        DataGrid.Columns(16).Visible = False
                        DataGrid.Columns(27).HeaderText = "Precio 3"
                        DataGrid.Columns(17).Visible = False
                        DataGrid.Columns(18).HeaderText = "Mínimo"
                        DataGrid.Columns(18).Visible = False
                        DataGrid.Columns(19).HeaderText = "Máximo"
                        DataGrid.Columns(19).Visible = False
                        DataGrid.Columns(20).HeaderText = "Cantidad Ing."
                        DataGrid.Columns(20).Visible = False
                        DataGrid.Columns(21).HeaderText = "Unididad Ing."
                        DataGrid.Columns(21).Visible = False
                        DataGrid.Columns(22).HeaderText = "Activo?"
                        DataGrid.Columns(23).HeaderText = "Venta?"
                        DataGrid.Columns(24).HeaderText = "Imagen"
                        DataGrid.Columns(24).Visible = False
                        DataGrid.Columns(28).HeaderText = "Gasto"
                        DataGrid.Columns(32).HeaderText = "Bagre"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "VentaAlMayor"
                        CadSQL = "Select idProducto, Nombre, Departamento, Deposito, Categoria,SubCategoria, FechaCreacion, Descripcion,Garantia, Capacidad, Unidad, Iva, Excento,Stock, Costo, Utilidad1, Utilidad2, Utilidad3, ExistenciaMin, ExistenciaMax,CantidadIng,UnidadIng,Activo,Venta,Imagen,Precio1,Precio2,Precio3, VerGasto , PrecioM1, PrecioM2, PrecioM3,Bagre FROM TNewProducto"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Activo=1 AND idProducto=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0) & " ORDER BY Nombre ASC"
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Activo=1 AND Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Depart."
                        DataGrid.Columns(2).Visible = False
                        DataGrid.Columns(3).HeaderText = "Depósito"
                        DataGrid.Columns(3).Visible = False
                        DataGrid.Columns(4).HeaderText = "Categoria"
                        DataGrid.Columns(4).Width = 150
                        DataGrid.Columns(5).HeaderText = "Sub Categoria"
                        DataGrid.Columns(5).Width = 150
                        DataGrid.Columns(6).HeaderText = "F.Creación"
                        DataGrid.Columns(7).HeaderText = "Descripción"
                        DataGrid.Columns(7).Visible = False
                        DataGrid.Columns(8).HeaderText = "Garantia"
                        DataGrid.Columns(8).Visible = False
                        DataGrid.Columns(9).HeaderText = "Capacidad"
                        DataGrid.Columns(9).Visible = False
                        DataGrid.Columns(10).HeaderText = "Unidad"
                        DataGrid.Columns(10).Visible = False
                        DataGrid.Columns(11).HeaderText = "IVA"
                        DataGrid.Columns(11).Visible = False
                        DataGrid.Columns(12).HeaderText = "Excento"
                        DataGrid.Columns(12).Visible = False
                        DataGrid.Columns(13).HeaderText = "Stock"
                        DataGrid.Columns(14).HeaderText = "Costo"
                        DataGrid.Columns(25).HeaderText = "Precio 1"
                        DataGrid.Columns(15).Visible = False
                        DataGrid.Columns(26).HeaderText = "Precio 2"
                        DataGrid.Columns(16).Visible = False
                        DataGrid.Columns(27).HeaderText = "Precio 3"
                        DataGrid.Columns(17).Visible = False
                        DataGrid.Columns(18).HeaderText = "Mínimo"
                        DataGrid.Columns(18).Visible = False
                        DataGrid.Columns(19).HeaderText = "Máximo"
                        DataGrid.Columns(19).Visible = False
                        DataGrid.Columns(20).HeaderText = "Cantidad Ing."
                        DataGrid.Columns(20).Visible = False
                        DataGrid.Columns(21).HeaderText = "Unididad Ing."
                        DataGrid.Columns(21).Visible = False
                        DataGrid.Columns(22).HeaderText = "Activo?"
                        DataGrid.Columns(23).HeaderText = "Venta?"
                        DataGrid.Columns(24).HeaderText = "Imagen"
                        DataGrid.Columns(24).Visible = False
                        DataGrid.Columns(28).HeaderText = "Gasto"
                        DataGrid.Columns(32).HeaderText = "Bagre"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Categoria"
                        CadSQL = "Select idCategoria,Nombre,ColorCat,ColorFondo,ColorFuente,TFuente,Imagen,Comentario  FROM TCategoria"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idCategoria=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Color Cat."
                        DataGrid.Columns(3).HeaderText = "Color Fondo"
                        DataGrid.Columns(4).HeaderText = "Color Fuente"
                        DataGrid.Columns(5).HeaderText = "Tamaño Fuente"
                        DataGrid.Columns(6).HeaderText = "Nombre Imagen"
                        DataGrid.Columns(7).HeaderText = "Comentario"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "SubCategoria"
                        CadSQL = "Select idSubCategoria,Nombre,Categoria, Comentario  FROM TSubCategoria"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idSubCategoria=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "Categoria"
                        DataGrid.Columns(3).HeaderText = "Comentario"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Clientes", "ClienteCaja", "ClientePedidos", "ClienteReservaGnral", "ClienteCobrar", "ClientesBancos", "ClienteFactura"
                        CadSQL = "Select idCliente,Nombre,CI,Nacionalidad, Descripcion, Zona,Direccion, RIF, Empresa, DEmpresa, Telefono, Celular, Correo, PagWeb, Fecha, Activo, Excento  FROM TClientes"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idCliente=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns("idCliente").HeaderText = "Código"
                        DataGrid.Columns("Nombre").HeaderText = "Nombre"
                        DataGrid.Columns("Nombre").Width = 250
                        DataGrid.Columns("CI").HeaderText = "C.I."
                        DataGrid.Columns("Nacionalidad").HeaderText = "Nac."

                        DataGrid.Columns("RIF").HeaderText = "R.I.F."
                        DataGrid.Columns(8).HeaderText = "Es Empresa?"
                        DataGrid.Columns(9).HeaderText = "Nombre Emp."

                        DataGrid.Columns(4).HeaderText = "Descripción"
                        DataGrid.Columns(5).HeaderText = "Zona"
                        DataGrid.Columns(6).HeaderText = "Dirección"

                        DataGrid.Columns(10).HeaderText = "Teléfono"
                        DataGrid.Columns(11).HeaderText = "Celular"
                        DataGrid.Columns(12).HeaderText = "Correo"
                        DataGrid.Columns(13).HeaderText = "Pag. Web"
                        DataGrid.Columns(14).HeaderText = "Fecha Creación"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Empleados", "EmpleadoFactura", "Vendedor"
                        CadSQL = "Select *  FROM TEmpleado"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idEmpleado=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns("idEmpleado").HeaderText = "Cód."
                        DataGrid.Columns("Nombre").HeaderText = "Nombre"
                        DataGrid.Columns("Nombre").Width = 250
                        DataGrid.Columns("CI").HeaderText = "C.I."
                        DataGrid.Columns("Nacionalidad").HeaderText = "Nac."
                        DataGrid.Columns("Zona").HeaderText = "Zona"
                        DataGrid.Columns("Direccion").HeaderText = "Dirección"
                        DataGrid.Columns("idCargo").HeaderText = "idCargo"
                        DataGrid.Columns("Cargo").HeaderText = "Cargo"
                        DataGrid.Columns("Telefono").HeaderText = "Teléfono"
                        DataGrid.Columns("Celular").HeaderText = "Celular"
                        DataGrid.Columns("Correo").HeaderText = "Correo"
                        DataGrid.Columns("Activo").HeaderText = "Activo"
                        DataGrid.Columns("Sueldo1").HeaderText = "Sueldo1"
                        DataGrid.Columns("Sueldo2").HeaderText = "Sueldo2"
                        DataGrid.Columns("Sueldo3").HeaderText = "Sueldo3"
                        DataGrid.Columns("ActivarHora").HeaderText = "Act. Hora"
                        DataGrid.Columns("HoraEntrada").HeaderText = "H. Ent."
                        DataGrid.Columns("HoraSalida").HeaderText = "H. Sal."
                        DataGrid.Columns("CBPagoUnico").HeaderText = "Pago Unico?"
                        DataGrid.Columns("PagoUnico").HeaderText = "Pago Unico"
                        DataGrid.Columns("CompraAlMayor").HeaderText = "Compra?"
                        DataGrid.Columns("VendeAlMayor").HeaderText = "Vende?"
                        DataGrid.Columns("RecibeDinero").HeaderText = "Rec. Dinero?"
                        DataGrid.Columns("Fecha").HeaderText = "Fecha Creación"
                        DataGrid.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Proveedor", "ProveedoresBancos", "ProveedorFactura"
                        CadSQL = "Select idProveedor, Nombre, Rif, Descripcion, Direccion, Telefono, Celular, Correo, SitioWeb, Fecha, EfecExtAjeno,AlqPuntoExt,Porc,PorcRetorno, Foraneo,Transporte, Otros FROM TProveedor"

                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idProveedor=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Cód."
                        DataGrid.Columns(0).Width = 70
                        DataGrid.Columns(1).HeaderText = "Nombre"
                        DataGrid.Columns(1).Width = 250
                        DataGrid.Columns(2).HeaderText = "R.I.F."
                        DataGrid.Columns(3).HeaderText = "Descripción"
                        DataGrid.Columns(4).HeaderText = "Dirección"
                        DataGrid.Columns(5).HeaderText = "Teléfono"
                        DataGrid.Columns(6).HeaderText = "Celular"
                        DataGrid.Columns(7).HeaderText = "Correo"
                        DataGrid.Columns(8).HeaderText = "Sitio Web"
                        DataGrid.Columns(9).HeaderText = "Fecha Creación"
                        DataGrid.Columns(10).HeaderText = "Efec. Ext. Ajeno"
                        DataGrid.Columns(11).HeaderText = "Alq. Punto Ext."
                        DataGrid.Columns(12).HeaderText = "% Punto"
                        DataGrid.Columns(13).HeaderText = "% Punto R"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "BuscarIngrediente"
                            CadSQL = "Select * FROM VProductoCosto"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Código=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Producto LIKE '" & TBusqueda.Text & "%' ORDER BY Producto ASC"
                        End If
                            Adaptador = New SqlDataAdapter(CadSQL, CNN)
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DataGrid.DataSource = DataT
                        ''DataGrid.Columns(0).HeaderText = "Código"
                        ''DataGrid.Columns(1).HeaderText = "Producto"
                        ''DataGrid.Columns(2).HeaderText = "Costo"
                        ''DataGrid.Columns(3).HeaderText = "Unidad"
                        ''DataGrid.Columns(4).HeaderText = "Capacidad"
                        ''DataGrid.Columns(5).HeaderText = "Fecha"
                        ''DataGrid.Columns(6).HeaderText = "% Util. 1"
                        ''DataGrid.Columns(7).HeaderText = "% Util. 2"
                        ''DataGrid.Columns(8).HeaderText = "% Util. 3"
                        'DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Reserva"
                            CadSQL = "Select * FROM TReserva" ' aqui debo especificar omo voy a agrupar las reservas si por dia o otra categoria.....
                            If (Band = 0) Then
                                If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idReserva=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                                End If
                            Else
                            CadSQL = CadSQL & " WHERE FechaCreacion LIKE '" & TBusqueda.Text & "%' ORDER BY FechaCreacion ASC"
                        End If
                            Adaptador = New SqlDataAdapter(CadSQL, CNN)
                            DataT = New DataTable
                            Adaptador.Fill(DataT)
                            Me.DataGrid.DataSource = DataT
                    Case "CrearUsuario"
                        CadSQL = "Select Usuario, TipoUsuario, Fecha, Activo FROM TUsuario ORDER BY Usuario ASC"
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Usuario"
                        DataGrid.Columns(0).Width = 250
                        DataGrid.Columns(1).HeaderText = "Tipo Usuario"
                        DataGrid.Columns(2).HeaderText = "Fecha"
                        DataGrid.Columns(3).HeaderText = "Activo"
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Gastos"
                        CadSQL = "Select idGastos,Local,Fecha,Gasto,Categoria, SubCategoria, Empleado, Total,Descripcion, GastoExt, Cantidad,Unidad,Costo,Planta, Descontar, idEmpleado, IdCategoria, IdSubCategoria  FROM VListaGastos"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idGastos=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0)
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Gasto LIKE '" & TBusqueda.Text & "%' ORDER BY Gasto ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns("idGastos").HeaderText = "Cód."
                        DataGrid.Columns("idGastos").Width = 60
                        DataGrid.Columns("Fecha").HeaderText = "Fecha"
                        DataGrid.Columns("Fecha").Width = 100
                        DataGrid.Columns("Sin Gastos Asoc.").HeaderText = "Sin Gastos Asoc."
                        DataGrid.Columns("Sin Gastos Asoc.").Width = 60
                        DataGrid.Columns("Gasto").HeaderText = "Gasto"
                        DataGrid.Columns("Gasto").Width = 250
                        DataGrid.Columns("Categoria").HeaderText = "Categoria"
                        DataGrid.Columns("Categoria").Width = 200
                        DataGrid.Columns("SubCategoria").HeaderText = "Sub-Categoria"
                        DataGrid.Columns("SubCategoria").Width = 200
                        DataGrid.Columns("Empleado").HeaderText = "Empleado"
                        DataGrid.Columns("Empleado").Width = 200
                        DataGrid.Columns("Total").HeaderText = "Total"
                        DataGrid.Columns("Total").Width = 150
                        DataGrid.Columns("Descripcion").HeaderText = "Comentario"
                        DataGrid.Columns("Descripcion").Width = 250
                        DataGrid.Columns("GastoExt").HeaderText = "G. E."
                        DataGrid.Columns("GastoExt").Width = 80
                        DataGrid.Columns("IdGastos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Sin Gastos Asoc.").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Gasto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Categoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("SubCategoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Empleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.Columns("GastoExt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns("Cantidad").Visible = False
                        DataGrid.Columns("Unidad").Visible = False
                        DataGrid.Columns("Costo").Visible = False
                        DataGrid.Columns("Planta").Visible = False
                        DataGrid.Columns("Descontar").Visible = False
                        DataGrid.Columns("idEmpleado").Visible = False
                        DataGrid.Columns("idCategoria").Visible = False
                        DataGrid.Columns("idSubCategoria").Visible = False
                    Case "Banco"
                        CadSQL = "Select * FROM TBancos"
                        If (Band = 0) Then
                            If (TBusqueda.Text <> "") Then
                                CadSQL = CadSQL & " WHERE idBanco=" & IIf(IsNumeric(TBusqueda.Text), TBusqueda.Text, 0) & " ORDER BY Nombre ASC"
                            End If
                        Else
                            CadSQL = CadSQL & " WHERE Nombre LIKE '" & TBusqueda.Text & "%' ORDER BY Nombre ASC"
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "FPDF"
                        CadSQL = "Select* FROM TPDF ORDER BY idPDF ASC"
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.DataGrid.DataSource = DataT
                        DataGrid.Columns(0).HeaderText = "Código"
                        DataGrid.Columns(0).Width = 100
                        DataGrid.Columns(1).HeaderText = "Ubicación de PDF"
                        DataGrid.Columns(1).Width = 1100
                        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End Select
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Private Sub CódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoToolStripMenuItem.Click
        LBusqueda.Text = "Código:"
        Band = 0
        MostrarDatosBusqueda()
    End Sub

    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        LBusqueda.Text = "Nombre:"
        Band = 1
        MostrarDatosBusqueda()
    End Sub

    Private Sub Buscar_ButtonClick(sender As Object, e As EventArgs) Handles Buscar.ButtonClick
        MostrarDatosBusqueda()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub FBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGrid.DataSource = Nothing
        LBusqueda.Text = "Nombre:"
        Band = 1
        MostrarDatosBusqueda()
        Me.ActiveControl = Me.TBusqueda
        Me.TBusqueda.SelectAll()
    End Sub
    'Private Sub MostrarCliente(CodCliente As Integer)
    '    Try
    '        If (Conectar()) Then
    '            Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE idCliente=" & CodCliente, CNN)
    '            Dim DataReader As SqlDataReader = Comando.ExecuteReader()
    '            If (DataReader.Read()) Then
    '                FDatosPedidos.TCodigo.Text = Trim(DataReader("idCliente").ToString)
    '                FDatosPedidos.TNombre.Text = Trim(DataReader("Nombre").ToString)
    '                FDatosPedidos.TCI.Text = DataReader("CI").ToString
    '                FDatosPedidos.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
    '                If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
    '                    FDatosPedidos.PtoOrdaz.Checked = True
    '                    FDatosPedidos.Zona.Tag = "Pto Ordaz"
    '                Else
    '                    FDatosPedidos.SanFelix.Checked = True
    '                    FDatosPedidos.Zona.Tag = "San Félix"
    '                End If
    '                FDatosPedidos.TDireccion.Text = Trim(DataReader("Direccion").ToString)
    '                FDatosPedidos.TTelefono.Text = Trim(DataReader("Telefono").ToString)
    '                FDatosPedidos.TCelular.Text = Trim(DataReader("Celular").ToString)

    '            Else
    '                FDatosPedidos.TCodigo.Text = ""
    '                FDatosPedidos.TNombre.Text = ""
    '                FDatosPedidos.CNacionalidad.Text = "V"
    '                FDatosPedidos.PtoOrdaz.Checked = True
    '                FDatosPedidos.Zona.Tag = "Pto Ordaz"
    '                FDatosPedidos.TDireccion.Text = ""
    '                FDatosPedidos.TTelefono.Text = ""
    '                FDatosPedidos.TCelular.Text = ""
    '            End If
    '            DataReader.Close()
    '        End If
    '        Desconectar()
    '    Catch ex As Exception
    '        MessageBox.Show("ERROR al Mostrar los Datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Desconectar()
    '    End Try

    'End Sub
    'Private Sub MostrarDatosReserva(CodReserva As Integer)
    '    Dim TipoExcepcion As String = ""
    '    Try
    '        If (Conectar()) Then
    '            Dim Comando As New SqlCommand("Select * FROM TDetReserva WHERE idReserva=" & CodReserva, CNN)
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            FDatosPedidos.DGListaPedido.Rows.Clear()
    '            Do While DR.Read()
    '                If (Trim(DR(7) = "Excepcion")) Then
    '                    TipoExcepcion = "Si"
    '                Else
    '                    TipoExcepcion = "No"
    '                End If
    '                FDatosPedidos.DGListaPedido.Rows.Add(DR(2), DR(3), DR(4), DR(9), DR(8), DR(5), DR(6), DR(7), DR(10), DR(0))
    '            Loop
    '            DR.Close()
    '            Desconectar()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("ERROR al Mostrar los datos de la Reserva: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Desconectar()
    '    End Try

    'End Sub

    Private Sub DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        Select Case VarBuscar
            Case "Producto"
                'If DataGrid.CurrentRow IsNot Nothing Then
                '    FProducto.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idProducto").Value)
                '    FProducto.CLocal.SelectedIndex = FProducto.CLocal.Items.IndexOf(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Sin Gastos Asoc.").Value))
                '    FProducto.CDeposito.SelectedIndex = FProducto.CDeposito.Items.IndexOf(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Deposito").Value))
                '    FProducto.CCategoria.SelectedIndex = FProducto.CCategoria.Items.IndexOf(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Categoria").Value))
                '    FProducto.CSubCategoria.SelectedIndex = FProducto.CSubCategoria.Items.IndexOf(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("SubCategoria").Value))
                '    FProducto.FechaC.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("FechaCreacion").Value)
                '    FProducto.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '    FProducto.TDescripcion.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Descripcion").Value)
                '    FProducto.TGarantia.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Garantia").Value)
                '    FProducto.TCapacidad.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Capacidad").Value)
                '    FProducto.TUnidad.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Unidad").Value)
                '    FProducto.TCantidadIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("CantidadIng").Value)
                '    FProducto.CUnidadIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("UnidadIng").Value)
                '    FProducto.CBActivo.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Activo").Value)
                '    FProducto.CBVenta.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Venta").Value)
                '    FProducto.CBGasto.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("VerGasto").Value)
                '    FProducto.CBBagre.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Bagre").Value)
                '    If (Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Imagen").Value) = "") Then
                '        FProducto.Imagen.BackgroundImage = Nothing
                '        FProducto.Dialogo.FileName = "SinImagen"
                '    Else
                '        FProducto.Imagen.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Imagen").Value))
                '    End If
                '    Me.Close()
                'End If
                'Case "AsignarProducto"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FArticulo.TArtAsignado.Text = Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("idProducto").Value)
                '        FArticulo.TNombreProd.Text = Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '        FArticulo.TNombre.Text = Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '        If (Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Imagen").Value) = "") Then
                '            FArticulo.BArtEjemplo.BackgroundImage = Nothing
                '            FArticulo.Dialogo.FileName = "SinImagen"
                '        Else
                '            FArticulo.BArtEjemplo.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("Imagen").Value))
                '            FArticulo.Dialogo.FileName = My.Application.Info.DirectoryPath & "\Imagenes\" & Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("Imagen").Value)
                '        End If
                '        FArticulo.CCategoria.Text = Trim(Me.DataGrid.Rows(Me.DataGrid.CurrentRow.Index).Cells("Categoria").Value)
                '        Me.Close()
                '    End If
                'Case "CompraProd"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FCompra.GridCompra.Rows.Add(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value), Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value), "", Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value), "0", "0", "0", "0", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Alterna", "0", Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idTipoProducto").Value))
                '        FCompra.GridCompra.Rows(FCompra.GridCompra.RowCount - 1).Cells("Precio1").Style.BackColor = Color.Red
                '        Me.Close()
                '    End If
                'Case "ClienteCaja"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        CodCliente = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FCajaNew.LCliente.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        Me.Close()
                '    End If
                'Case "Clientes"
                '    If VarForma = "FFerias" Then
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            CodCliente = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idCliente").Value)
                '            FFerias.LCliente.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '            TipoCliente = False
                '            Me.Close()
                '        End If
                '    Else
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            '   FClientes.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '            '   FClientes.TCodigo_TextChanged(Nothing, Nothing)
                '            Me.Close()
                '        End If
                '    End If
                'Case "Vendedor"
                '    If VarForma = "FFerias" Then
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            CodCajero = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idEmpleado").Value)
                '            FFerias.LVendedor.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Apellido").Value)
                '            Me.Close()
                '        End If
                '    Else
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            CodCajero = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idEmpleado").Value)
                '            FInicializarFeria.LVendedor.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Apellido").Value)
                '            FFerias.LVendedor.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Apellido").Value)
                '            Me.Close()
                '        End If
                '    End If

                'Case "Empleados"
                '    If VarForma = "FFerias" Then
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            CodCliente = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idEmpleado").Value)
                '            FFerias.LCliente.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Apellido").Value)
                '            TipoCliente = True
                '            Me.Close()
                '        End If
                '    Else
                '        If DataGrid.CurrentRow IsNot Nothing Then
                '            FEmpleados.TCI.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("CI").Value)
                '            FEmpleados.TCI_TextChanged(Nothing, Nothing)
                '            Me.Close()
                '        End If
                '    End If
                'Case "ClientePedidos"
                '    FDatosPedidos.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '    Me.Close()
                '    'Case "BuscarIngrediente"
                '    '    If DataGrid.CurrentRow IsNot Nothing Then
                '    '        FProducto.TCodIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '    '        FProducto.TIngrediente.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '    '        FProducto.TCostoIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(5).Value)
                '    '        ' FProducto.TUnidIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value)
                '    '        '  FProducto.CUnidad.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value)
                '    '        FProducto.TCapacidadIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value)
                '    '        FProducto.TCantIng.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(9).Value)
                '    '        Me.Close()
                '    '    End If
                'Case "Reserva"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FDatosPedidos.TCodReserva.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FDatosPedidos.DTPFechaLlegada.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FDatosPedidos.DTPHoraLlegada.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FDatosPedidos.CPrioridad.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        If (Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(6).Value) = "Pto Ordaz") Then
                '            FDatosPedidos.PtoOrdaz2.Checked = True
                '        Else
                '            FDatosPedidos.SanFelix2.Checked = True
                '        End If
                '        FDatosPedidos.TDireccion2.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(7).Value)
                '        FDatosPedidos.TTelefono2.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(8).Value)
                '        FDatosPedidos.TCelular2.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(9).Value)
                '        FDatosPedidos.CPrioridad.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        FDatosPedidos.CTipo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(32).Value)
                '        FDatosPedidos.CTipo.Tag = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(34).Value)
                '        FDatosPedidos.TRecargo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(37).Value)
                '        FDatosPedidos.TObservaciones.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(33).Value)
                '        MostrarDatosReserva(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value))
                '        MostrarCliente(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value))
                '        Me.Close()
                '    End If
                'Case "ClienteReservaGnral"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FCajaNew.LCliente.Tag = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FCajaNew.LCliente.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        Me.Close()
                '    End If
                'Case "ClienteCobrar"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        CodCliente = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FCuentasporCobrar.RBCliente.Text = "Cliente: " & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        FCuentasporCobrar.RBCliente.Checked = True
                '        Me.Close()
                '    End If
                'Case "CrearUsuario"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FCrearUsuarios.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FCrearUsuarios.CTipoUsuario.SelectedValue = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FCrearUsuarios.Fecha.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value)
                '        FCrearUsuarios.Activo.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        FCrearUsuarios.TContrasena.Text = ""
                '        FCrearUsuarios.TRepContrasena.Text = ""
                '        Me.Close()
                '    End If
                'Case "Categoria"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FCategoria.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FCategoria.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FCategoria.BColorCat.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value))
                '        FCategoria.EjemploCat.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value))
                '        FCategoria.BColorFondo.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value))
                '        FCategoria.BEjemploCat.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value))
                '        FCategoria.BColorFuente.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value))
                '        FCategoria.BEjemploCat.ForeColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value))
                '        Dim TF As Integer = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(5).Value)
                '        FCategoria.BFuente.Font = New Font("Microsoft Sans Serif", TF, FontStyle.Bold)
                '        FCategoria.BEjemploCat.Font = New Font("Microsoft Sans Serif", TF, FontStyle.Bold)
                '        FCategoria.Editar.Enabled = True
                '        Me.Close()
                '    End If
                'Case "SubCategoria"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FSubCategoria.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FSubCategoria.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FSubCategoria.TComentario.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value)
                '        FSubCategoria.Editar.Enabled = True
                '        Me.Close()
                '    End If
                'Case "FEtiquetas"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FEtiquetas.Grid.Rows.Add(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value, Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value), "", DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value, 1, DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(25).Value, "0,00", "", DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(14).Value, DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(25).Value, DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(26).Value, DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(27).Value)
                '        FEtiquetas.Grid.CurrentCell = FEtiquetas.Grid.Rows(FEtiquetas.Grid.RowCount - 1).Cells(2)
                '        Me.Close()
                '    End If
                'Case "FEtiquetasSP"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FEtiquetas.Grid.Rows.Add(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value, Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value), "0", DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value, 1, "0,00", "0,00")
                '        FEtiquetas.Grid.CurrentCell = FEtiquetas.Grid.Rows(FEtiquetas.Grid.RowCount - 1).Cells(2)
                '        Me.Close()
                '    End If
                'Case "Gastos"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FGastos.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idGastos").Value)
                '        FGastos.FechaC.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Fecha").Value)
                '        FGastos.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Gasto").Value)
                '        FGastos.CCategoria.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Categoria").Value)
                '        FGastos.CSubCategoria.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("SubCategoria").Value)
                '        FGastos.TCantidad.Text = DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Cantidad").Value
                '        FGastos.CUnidad.Text = FGastos.CUnidad.Items.IndexOf(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Unidad").Value))
                '        FGastos.TCosto.Text = DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Costo").Value
                '        FGastos.TDescripcion.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Descripcion").Value)
                '        If (DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idCategoria").Value = 6) And ((DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idSubCategoria").Value = 7) Or (DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idSubCategoria").Value = 9) Or (DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idSubCategoria").Value = 94)) Then
                '            FGastos.CEmpleado.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Empleado").Value)
                '            FGastos.LEmpleado.Visible = True
                '            FGastos.CEmpleado.Visible = True
                '            FGastos.BEmpleados.Visible = True
                '        Else
                '            FGastos.LEmpleado.Visible = False
                '            FGastos.CEmpleado.Visible = False
                '            FGastos.BEmpleados.Visible = False
                '        End If
                '        Me.Close()
                '    End If
                'Case "Bancos"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FBancos.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FBancos.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FBancos.CTipoCta.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value)
                '        FBancos.TNCta.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        FBancos.TTitular.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value)
                '        FBancos.TCI.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(5).Value)
                '        FBancos.CAsignar.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(6).Value)
                '        FBancos.TCodAsignar.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(7).Value)
                '        FBancos.Fecha.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(8).Value)
                '        FProducto.CBActivo.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(9).Value)
                '        Me.Close()
                '    End If
                'Case "Proveedor"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FProveedores.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FProveedores.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FProveedores.TRif.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(2).Value)
                '        FProducto.TDescripcion.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(3).Value)
                '        FProveedores.TDireccion.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value)
                '        FProveedores.TTelefono.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(5).Value)
                '        FProveedores.TCelular.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(6).Value)
                '        FProveedores.TCorreo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(7).Value)
                '        FProveedores.TSitioWeb.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(8).Value)
                '        FProveedores.Fecha.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(9).Value)
                '        FProveedores.CBEfecExtAjeno.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(10).Value)
                '        FProveedores.CHAlqPuntoExt.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(11).Value)
                '        FProveedores.TPPago.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(12).Value)
                '        FProveedores.TPorcAlqExt.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(13).Value)
                '        FProveedores.CBForaneo.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Foraneo").Value)
                '        FProveedores.CBTransporte.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Transporte").Value)
                '        FProveedores.CBOtros.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Otros").Value)
                '        Me.Close()
                '    End If
                'Case "ProveedoresBancos"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FBancos.TCodAsignar.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        Me.Close()
                '    End If
                'Case "ClientesBancos"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FBancos.TCodAsignar.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        Me.Close()
                '    End If
                'Case "FPDF"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FPDF.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        RutaDestino = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(1).Value)
                '        FPDF.Dialogo.FileName = RutaDestino
                '        '  FPDF.VerPDF.LoadFile(RutaDestino)
                '        Me.Close()
                '    End If
                'Case "Articulo"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FArticulo.TArtAsignado.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idProducto").Value)
                '        FArticulo.TNombreProd.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("NomProducto").Value)
                '        FArticulo.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idArticulo").Value)
                '        FArticulo.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '        FArticulo.CCategoria.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Categoria").Value)
                '        FArticulo.Fecha.Value = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Fecha").Value)
                '        FArticulo.CBActivo.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Activo").Value)
                '        FArticulo.CBVenta.Checked = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Venta").Value)
                '        FArticulo.BArtEjemplo.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Imagen").Value))
                '        FArticulo.Dialogo.FileName = My.Application.Info.DirectoryPath & "\Imagenes\" & Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Imagen").Value)
                '        FArticulo.LArtEjemplo.ForeColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("ColorFuente").Value))
                '        FArticulo.LArtEjemplo.BackColor = Color.FromArgb(Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("ColorCat").Value))
                '        Dim TF As Integer = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("TFuente").Value)
                '        FArticulo.LArtEjemplo.Font = New Font("Microsoft Sans Serif", TF, FontStyle.Bold)
                '        FArticulo.TFactor.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Factor").Value)
                '        Me.Close()
                '    End If
                'Case "ClienteFactura", "ProveedorFactura", "EmpleadoFactura"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FImprimirFacturaCL.TCodigo.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(0).Value)
                '        FImprimirFacturaCL.TNombre.Text = Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value)
                '        Me.Close()
                '    End If
                'Case "ProductoFactura"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FImprimirFacturaCL.GridFactura.Rows.Add("", Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value), "1", Format(Convert.ToDecimal(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Precio1").Value), "##,##0.00"), Format(Convert.ToDecimal(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Precio1").Value), "##,##0.00"), DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idProducto").Value)
                '        Me.Close()
                '    End If
                'Case "VentaAlMayor"
                '    If DataGrid.CurrentRow IsNot Nothing Then
                '        FVentaAlMayor.GridCompra.Rows.Add(FVentaAlMayor.GridCompra.RowCount + 1, Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("Nombre").Value), "", Format(Convert.ToDecimal(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("PrecioM1").Value), "##,##0.00"), "Efectivo", "", "", "False", "", Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells("idProducto").Value), "", Trim(DataGrid.Rows(DataGrid.CurrentRow.Index).Cells(4).Value))
                '        Me.Close()
                '    End If
        End Select
    End Sub

    Private Sub TBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles TBusqueda.KeyDown
        If e.KeyCode = 13 Then
            If (Me.DataGrid.RowCount = 1) And (Me.TBusqueda.Text <> "") Then
                DataGrid_CellDoubleClick(Nothing, Nothing)
            Else
                If (Me.TBusqueda.Text <> "") Then
                    Me.ActiveControl = Me.DataGrid
                End If
            End If
        End If
    End Sub

    Private Sub TBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles TBusqueda.KeyUp
        MostrarDatosBusqueda()
    End Sub

    Private Sub DataGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGrid.KeyDown
        If e.KeyCode = 13 Then
            If (Me.DataGrid.RowCount > 0) And (Me.TBusqueda.Text <> "") Then
                DataGrid_CellDoubleClick(Nothing, Nothing)
            End If
        End If
    End Sub
   
    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub TBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBusqueda.TextChanged

    End Sub
End Class