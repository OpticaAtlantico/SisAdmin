Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class FBuscarGenerico
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private CadSQL As String = ""
    Private Band As Integer = 0

    Private Sub SombrearProductoCompuesto()
        'For i = 0 To Me.GridBuscar.RowCount - 1
        '    If (Me.GridBuscar.Item(1, i).Value = "Compuestos") Then
        '        Me.GridBuscar.Rows(i).DefaultCellStyle.ForeColor = Color.Tomato
        '    End If
        'Next
    End Sub

    Private Sub ColorearDevolucion()
        For i = 0 To Me.GridBuscar.RowCount - 1
            If (Me.GridBuscar.Item("Estado", i).Value = "Devolucion") Then
                Me.GridBuscar.Rows(i).DefaultCellStyle.BackColor = Color.LightCoral
            End If
        Next
        Me.GridBuscar.ClearSelection()
        Me.GridBuscar.Refresh()
    End Sub
    Private Sub MostrarDatosBusqueda()
         Me.GridBuscar.DataSource =Nothing 
        Try
            If Conectar() Then
                Select Case VarBuscar
                    Case "CierreCajas", "VentasDiarias"
                        Dim CadBase = "Select * FROM VControlCaja"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idCierre LIKE '%" & TCodigo.Text & "%' ORDER BY FechaInicio DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Cajero LIKE '%" & TNombre.Text & "%' ORDER BY FechaInicio DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Cajero LIKE '%" & TNombre.Text & "%' ORDER BY FechaInicio DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY FechaInicio DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idCierre").HeaderText = "Código"
                        GridBuscar.Columns("idCierre").Width = 70
                        GridBuscar.Columns("idCaja").HeaderText = "Cód."
                        GridBuscar.Columns("idCaja").Width = 60
                        GridBuscar.Columns("Caja").HeaderText = "Caja"
                        GridBuscar.Columns("Caja").Width = 170
                        GridBuscar.Columns("idCajero").HeaderText = "Cod."
                        GridBuscar.Columns("idCajero").Width = 60
                        GridBuscar.Columns("Cajero").HeaderText = "Cajero"
                        GridBuscar.Columns("Cajero").Width = 240
                        GridBuscar.Columns("FechaInicio").HeaderText = "Inicio"
                        GridBuscar.Columns("FechaInicio").Width = 150
                        GridBuscar.Columns("FechaCierre").HeaderText = "Cierre"
                        GridBuscar.Columns("FechaCierre").Width = 150

                        GridBuscar.Columns("TeoricoGral").HeaderText = "Teor.Bs."
                        GridBuscar.Columns("TeoricoGral").Width = 100
                        GridBuscar.Columns("TeoricoGral").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("TeoricoGralD").HeaderText = "Teor. $"
                        GridBuscar.Columns("TeoricoGralD").Width = 100
                        GridBuscar.Columns("TeoricoGralD").DefaultCellStyle.Format = "##,##0.00"


                        GridBuscar.Columns("RealGral").HeaderText = "Real Bs."
                        GridBuscar.Columns("RealGral").Width = 110
                        GridBuscar.Columns("RealGral").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("RealGralD").HeaderText = "Real $"
                        GridBuscar.Columns("RealGralD").Width = 100
                        GridBuscar.Columns("RealGralD").DefaultCellStyle.Format = "##,##0.00"

                        GridBuscar.Columns("DiferenciaGralD").HeaderText = "Dif. Bs."
                        GridBuscar.Columns("DiferenciaGralD").Width = 100
                        GridBuscar.Columns("DiferenciaGralD").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("DiferenciaGral").HeaderText = "Dif. $"
                        GridBuscar.Columns("DiferenciaGral").Width = 100
                        GridBuscar.Columns("DiferenciaGral").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("idCaja").Visible = False
                        GridBuscar.Columns("idCajero").Visible = False

                        GridBuscar.Columns("idCierre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Caja").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cajero").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("FechaInicio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("FechaCierre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TeoricoGral").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TeoricoGralD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("RealGral").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("RealGralD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("DiferenciaGral").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("DiferenciaGralD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "NombreCompetencia"
                        Dim CadBase = "Select id, Nombre FROM TCompetencia"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Nombre de Competencia"
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case "Unidad"
                        Dim CadBase = "Select *  FROM TUnidades"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        Me.GridBuscar.Columns(0).HeaderText = "Código"
                        Me.GridBuscar.Columns(1).HeaderText = "Unidad"
                        Me.GridBuscar.Columns(1).Width = 200
                        Me.GridBuscar.Columns(2).HeaderText = "Descripción"
                        Me.GridBuscar.Columns(2).Width = 300
                        Me.GridBuscar.Columns(3).HeaderText = "Activo"
                        Me.GridBuscar.Columns(3).Width = 80
                        Me.GridBuscar.Columns(4).Visible = False
                        Me.GridBuscar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "SubCategoria"
                        Dim CadBase = "Select idCategoria, Categoria, idSubCategoria,Nombre, Comentario  FROM TSubCategoria"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idCategoria LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        Me.GridBuscar.Columns("idCategoria").HeaderText = "Cód. Cat."
                        Me.GridBuscar.Columns("idCategoria").Width = 150
                        Me.GridBuscar.Columns("Categoria").HeaderText = "Categoria"
                        Me.GridBuscar.Columns("Categoria").Width = 300
                        Me.GridBuscar.Columns("idSubCategoria").HeaderText = "Cód. Sub-Cat."
                        Me.GridBuscar.Columns("idSubCategoria").Width = 150
                        Me.GridBuscar.Columns("Nombre").HeaderText = "Sub-Categoria"
                        Me.GridBuscar.Columns("Nombre").Width = 300
                        Me.GridBuscar.Columns("Comentario").HeaderText = "Comentario"
                        Me.GridBuscar.Columns("Comentario").Width = 300
                        Me.GridBuscar.Columns("idCategoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("Categoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns("idSubCategoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns("Comentario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Categoria"
                        Dim CadBase = "Select idCategoria,Nombre,Comentario,Mostrar,ColorCat,ColorFondo,ColorFuente,TFuente,TipoFuente, TipoFuenteArt, TFuenteArt, ColorFuenteArt  FROM TCategoria"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idCategoria LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        Me.GridBuscar.Columns("idCategoria").HeaderText = "Código"
                        Me.GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        Me.GridBuscar.Columns("Nombre").Width = 350
                        Me.GridBuscar.Columns("Comentario").HeaderText = "Comentario"
                        Me.GridBuscar.Columns("comentario").Width = 300

                        Me.GridBuscar.Columns("Mostrar").HeaderText = "Mostrar"
                        Me.GridBuscar.Columns(4).Visible = False
                        Me.GridBuscar.Columns(5).Visible = False
                        Me.GridBuscar.Columns(6).Visible = False
                        Me.GridBuscar.Columns(7).Visible = False
                        Me.GridBuscar.Columns(8).Visible = False
                        Me.GridBuscar.Columns(9).Visible = False
                        Me.GridBuscar.Columns(10).Visible = False
                        Me.GridBuscar.Columns(11).Visible = False
                        Me.GridBuscar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Articulo"
                        Dim CadBase = "Select * FROM TArticulo"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idArticulo LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        Me.GridBuscar.Columns("idArticulo").HeaderText = "Código"
                        Me.GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        Me.GridBuscar.Columns("Nombre").Width = 250
                        Me.GridBuscar.Columns("Categoria").HeaderText = "Categoria"
                        Me.GridBuscar.Columns("Fecha").HeaderText = "Fecha"
                        Me.GridBuscar.Columns("Activo").HeaderText = "Activo?"
                        Me.GridBuscar.Columns("Venta").HeaderText = "Venta?"
                        Me.GridBuscar.Columns(1).Visible = False
                        Me.GridBuscar.Columns(6).Visible = False
                        Me.GridBuscar.Columns(7).Visible = False
                        Me.GridBuscar.Columns(8).Visible = False
                        Me.GridBuscar.Columns(9).Visible = False
                        Me.GridBuscar.Columns(10).Visible = False
                        Me.GridBuscar.Columns(13).Visible = False
                        Me.GridBuscar.Columns("idProducto").HeaderText = "Cod Prod."
                        Me.GridBuscar.Columns("idProducto").Width = 130
                        Me.GridBuscar.Columns("NomProducto").HeaderText = "Producto"
                        Me.GridBuscar.Columns("NomProducto").Width = 250
                        Me.GridBuscar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case "CrearUsuario"
                        Dim CadBase = "Select Usuario, TipoUsuario, NombreTipoUsuario, Fecha, Activo FROM VUsuario"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Usuario LIKE '%" & TCodigo.Text & "%' ORDER BY Usuario ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Usuario LIKE '%" & TNombre.Text & "%' ORDER BY Usuario ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Usuario LIKE '%" & TNombre.Text & "%' ORDER BY Usuario ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Usuario Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Usuario").HeaderText = "Usuario"
                        GridBuscar.Columns("Usuario").Width = 250
                        GridBuscar.Columns("TipoUsuario").HeaderText = "Cód."
                        GridBuscar.Columns("NombreTipoUsuario").HeaderText = "Tipo Usuario"
                        GridBuscar.Columns("NombreTipoUsuario").Width = 150
                        GridBuscar.Columns("Fecha").HeaderText = "Fecha Creación"
                        GridBuscar.Columns("Fecha").Width = 200
                        GridBuscar.Columns("Activo").HeaderText = "Activo"

                        GridBuscar.Columns("Usuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("TipoUsuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("NOmbreTipoUsuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case "Patrocinador"
                        Dim CadBase = "Select idEmpleado,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Celular  FROM TEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Patrocinador=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Patrocinador=1 AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Patrocinador=1 AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Patrocinador=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código."
                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 300
                        GridBuscar.Columns("CI").HeaderText = "C.I."
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Celular").Width = 150
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "TipoCambio", "TipoCambio2"
                        Dim CadBase = "Select id, Nombre, Moneda + ' (' + Simbolo + ')' as Moneda, idMoneda, AfectaCaja FROM VTipoCambio"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Tipo Cambio"
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("Moneda").HeaderText = "Moneda"
                        GridBuscar.Columns("Moneda").Width = 150
                        GridBuscar.Columns("AfectaCaja").HeaderText = "Afecta Caja?"
                        GridBuscar.Columns("Moneda").Width = 150
                        GridBuscar.Columns("idMoneda").Visible = False
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Moneda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "ProductoNacional"
                        Dim CadBase = "Select id, Nombre, Descripcion, Activo FROM TTipoProd"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Tipo Prod."
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("Descripcion").HeaderText = "Descripción"
                        GridBuscar.Columns("Descripcion").Width = 300
                        GridBuscar.Columns("Activo").HeaderText = "Activo"
                        GridBuscar.Columns("Activo").Width = 60
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CategoriasInt"
                        Dim CadBase = "Select  id, Nombre, idUnidad,Unidad  FROM VCategoriasInternas"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Categoria"
                        GridBuscar.Columns("Nombre").Width = 350
                        GridBuscar.Columns("Unidad").HeaderText = "Unidad"
                        GridBuscar.Columns("Unidad").Width = 150
                        GridBuscar.Columns("idUnidad").Visible = False
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Unidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Categorias", "CategoriasInv", "CategoriasNiv", "CategoriasNivST"
                        Dim CadBase = "Select idCategoria as id, Nombre, Mostrar as Activo FROM TCategoria"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Categoria"
                        GridBuscar.Columns("Nombre").Width = 350
                        GridBuscar.Columns("Activo").HeaderText = "Activo"
                        GridBuscar.Columns("Activo").Width = 80
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "SubCategorias", "SubCategoriasInv", "SubCategoriasNiv", "SubCategoriasNivST"
                        Dim CadBase = "Select idSubCategoria as id, Nombre FROM TSubCategoria"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Categoria='" & Categoria & "' AND id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Categoria='" & Categoria & "' AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Categoria='" & Categoria & "' AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE Categoria='" & Categoria & "' ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Sub-Categoria"
                        GridBuscar.Columns("Nombre").Width = 350
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Marcas", "MarcasP"
                        Dim CadBase = "Select id, Marca, Descripcion, Activo FROM TMarcas"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Marca ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Marca LIKE '%" & TNombre.Text & "%' ORDER BY Marca ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Marca LIKE '%" & TNombre.Text & "%' ORDER BY Marca ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Marca Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Marca").HeaderText = "Marca"
                        GridBuscar.Columns("Marca").Width = 230
                        GridBuscar.Columns("Descripcion").HeaderText = "Descripción"
                        GridBuscar.Columns("Descripcion").Width = 230
                        GridBuscar.Columns("Activo").HeaderText = "Activo"
                        GridBuscar.Columns("Activo").Width = 60
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Marca").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("Activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "TipoDocCompra", "TipoDoc"
                        Dim CadBase = "Select id, Nombre FROM TTipoDocumento"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Tipo Documento"
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "TipoProducto", "TipoProductoInv", "TipoProductoNiv", "TipoProductoNivST"
                        Dim CadBase = "Select id, Nombre FROM TTipoProducto"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Tipo Producto"
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "TipoReceta"
                        Dim CadBase = "Select id, Nombre FROM TTipoReceta"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Nombre <> '' And id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre DESC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre <> '' And Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre <> '' And Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre DESC"
                            Else
                                CadSQL = CadSQL & " WHERE Nombre <> '' ORDER BY Nombre DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("id").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Tipo Producto"
                        GridBuscar.Columns("Nombre").Width = 250
                        GridBuscar.Columns("id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "BuscarIngrediente", "BuscarIngredienteReceta", "BuscarIngredienteRecetaOtro"
                        Dim CadBase = "Select idProducto, TipoProducto, Nombre as Producto, idUnidadCapacidad,idCategoriaInt,UnidadCapacidad,idCategoria, Mezcla FROM VListaProductosJuntos"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE TipoProducto='Terminados' AND idProducto LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE TipoProducto='Terminados' AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE TipoProducto='Terminados' AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE TipoProducto='Terminados' ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT

                        GridBuscar.Columns("idProducto").HeaderText = "Código"
                        GridBuscar.Columns("idProducto").Width = 150

                        GridBuscar.Columns("Producto").HeaderText = "Producto"
                        GridBuscar.Columns("Producto").Width = 500

                        GridBuscar.Columns("idUnidadCapacidad").Visible = False
                        GridBuscar.Columns("UnidadCapacidad").Visible = False

                        GridBuscar.Columns("TipoProducto").Visible = False
                        GridBuscar.Columns("idCategoriaInt").Visible = False
                        GridBuscar.Columns("idCategoria").Visible = False
                        GridBuscar.Columns("Mezcla").Visible = False


                        GridBuscar.Columns("idProducto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Producto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



                    Case "AlicuotaCompra", "AlicuotaProdC", "AlicuotaProdV", "AlicuotaCompraInterna"
                        Dim CadBase = "Select id, Nombre, Alicuota FROM TAlicuota"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns(0).HeaderText = "Código."
                        GridBuscar.Columns(0).Width = 100
                        GridBuscar.Columns(1).HeaderText = "Nombre"
                        GridBuscar.Columns(1).Width = 100
                        GridBuscar.Columns(2).HeaderText = "Alicuota"
                        GridBuscar.Columns(2).Width = 100

                        GridBuscar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "NombresCajas", "OperacionesCajas", "AperturaCajas", "AperturaCajasInicio", "ExaminarEstacion", "ConfigurarCajasEst"
                        Dim CadBase = "Select id, Nombre, Estacion, Estado, idLocal FROM TCajas"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns(0).HeaderText = "Código."
                        GridBuscar.Columns(0).Width = 100
                        GridBuscar.Columns(1).HeaderText = "Caja"
                        GridBuscar.Columns(1).Width = 250
                        GridBuscar.Columns(2).HeaderText = "Estación"
                        GridBuscar.Columns(2).Width = 250
                        GridBuscar.Columns(3).HeaderText = "Aperturada"
                        GridBuscar.Columns(3).Width = 100
                        GridBuscar.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "ImprimirFactura"
                        Dim CadBase = "Select  idVenta, Fecha, Total, Cliente,Caja FROM VVentasR Where idCliente=" & CodCliente & " ORDER BY Fecha DESC"
                        CadSQL = CadBase
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idVenta").HeaderText = "Documento"
                        GridBuscar.Columns("idVenta").Width = 120
                        GridBuscar.Columns("Fecha").HeaderText = "Fecha"
                        GridBuscar.Columns("Fecha").Width = 160
                        GridBuscar.Columns("Total").HeaderText = "Total"
                        GridBuscar.Columns("Total").Width = 170
                        GridBuscar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("Cliente").HeaderText = "Cliente"
                        GridBuscar.Columns("Cliente").Width = 200
                        GridBuscar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Caja").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'Case "BuscarVenta"
                        '    'CAST(CONVERT(CHAR(8), Fecha, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT)
                        '    Dim CadBase = "Select  TOP 100 idVenta, Local, Caja, Fecha,TipoCliente, Cliente,TotalD, Total, Estado  FROM VListadoVentasDevCopia"
                        '    CadSQL = CadBase
                        '    If (Me.TCodigo.Text <> "") Then
                        '        CadSQL = CadBase & " Where " & "Total=@Total "
                        '        If (Me.TNombre.Text <> "") Then
                        '            CadSQL = CadSQL & " AND Estado <> 'Activo' AND Cliente LIKE '%" & TNombre.Text & "%' Order By idventa Desc"
                        '        Else
                        '            CadSQL = CadSQL & " Order By idventa Desc"
                        '        End If
                        '    Else
                        '        If (Me.TNombre.Text <> "") Then
                        '            CadSQL = CadBase & " Where  Estado <> 'Activo' AND Cliente LIKE '%" & TNombre.Text & "%' Order By idventa Desc"
                        '        Else
                        '            CadSQL = CadSQL & " Where Estado <> 'Activo' Order By idventa Desc"
                        '        End If
                        '    End If
                        '    '   CadSQL = CadSQL & " Order By idventa Desc"
                        '    Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        '    'Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        '    'Adaptador.SelectCommand.Parameters("@Desde").Value = DesdeX
                        '    'Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        '    'Adaptador.SelectCommand.Parameters("@Hasta").Value = HastaX
                        '    Adaptador.SelectCommand.Parameters.Add("@Total", SqlDbType.Decimal)
                        '    Adaptador.SelectCommand.Parameters("@Total").Value = Convert.ToDecimal(IIf(Me.TCodigo.Text = "", 0, Me.TCodigo.Text))
                        '    DataT = New DataTable
                        '    Adaptador.Fill(DataT)
                        '    Me.GridBuscar.DataSource = DataT
                        '    GridBuscar.Columns("idVenta").HeaderText = "Código"
                        '    GridBuscar.Columns("idVenta").Width = 100
                        '    GridBuscar.Columns("Local").HeaderText = "Local"
                        '    GridBuscar.Columns("Local").Width = 100
                        '    GridBuscar.Columns("Caja").HeaderText = "Caja"
                        '    GridBuscar.Columns("Caja").Width = 180
                        '    GridBuscar.Columns("Fecha").HeaderText = "Fecha"
                        '    GridBuscar.Columns("Fecha").Width = 200
                        '    GridBuscar.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt"
                        '    GridBuscar.Columns("TotalD").HeaderText = "Total $"
                        '    GridBuscar.Columns("TotalD").Width = 170
                        '    GridBuscar.Columns("TotalD").DefaultCellStyle.Format = "##,##0.00"
                        '    GridBuscar.Columns("Total").HeaderText = "Total Bs."
                        '    GridBuscar.Columns("Total").Width = 170
                        '    GridBuscar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
                        '    GridBuscar.Columns("TipoCliente").HeaderText = "T. Cliente"
                        '    GridBuscar.Columns("TipoCliente").Width = 110
                        '    GridBuscar.Columns("Cliente").HeaderText = "Cliente"
                        '    GridBuscar.Columns("Cliente").Width = 200
                        '    GridBuscar.Columns("Estado").Visible = False

                        '    GridBuscar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("Caja").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("TipoCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    GridBuscar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        '    GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        '    ColorearDevolucion()
                        '    GridBuscar.Refresh()




                    Case "DocumentoCopia", "DocumentoDevolucion"
                        Dim CadBase = "Select  idVenta, Fecha,TipoCliente, Cliente,TotalD, Total, Estado  FROM VListadoVentasDevCopia Where CAST(CONVERT(CHAR(8), Fecha, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @hasta, 112) AS INT)"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " AND idCaja=" & CodCajaActiva & " AND Total=@Total "
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " AND idCaja=" & CodCajaActiva & " AND Estado <> 'Activo' AND Cliente LIKE '%" & TNombre.Text & "%' ORDER BY Fecha DESC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Fecha DESC"
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " AND idCaja=" & CodCajaActiva & " AND Estado <> 'Activo' AND Cliente LIKE '%" & TNombre.Text & "%' ORDER BY Fecha DESC"
                            Else
                                CadSQL = CadSQL & " AND idCaja=" & CodCajaActiva & " AND Estado <> 'Activo' ORDER BY Fecha DESC"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Desde").Value = DesdeX
                        Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                        Adaptador.SelectCommand.Parameters("@Hasta").Value = HastaX
                        Adaptador.SelectCommand.Parameters.Add("@Total", SqlDbType.Decimal)
                        Adaptador.SelectCommand.Parameters("@Total").Value = Convert.ToDecimal(IIf(Me.TCodigo.Text = "", 0, Me.TCodigo.Text))
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idVenta").HeaderText = "Código"
                        GridBuscar.Columns("idVenta").Width = 100
                        GridBuscar.Columns("Fecha").HeaderText = "Fecha"
                        GridBuscar.Columns("Fecha").Width = 200
                        GridBuscar.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt"
                        GridBuscar.Columns("TotalD").HeaderText = "Total $"
                        GridBuscar.Columns("TotalD").Width = 170
                        GridBuscar.Columns("TotalD").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("Total").HeaderText = "Total Bs."
                        GridBuscar.Columns("Total").Width = 170
                        GridBuscar.Columns("Total").DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.Columns("TipoCliente").HeaderText = "Tipo Cliente"
                        GridBuscar.Columns("TipoCliente").Width = 150
                        GridBuscar.Columns("Cliente").HeaderText = "Cliente"
                        GridBuscar.Columns("Cliente").Width = 200
                        GridBuscar.Columns("Estado").Visible = False

                        GridBuscar.Columns("idVenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TotalD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TipoCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ColorearDevolucion()
                        GridBuscar.Refresh()
                 
                    Case "UsuarioInicioCaja", "UsuarioCierreCaja", "ExaminarUsuario", "Autorizar", "AutorizarComentario", "UsuarioDepart"
                        Dim CadBase = "Select Usuario FROM TUsuario"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Usuario LIKE '%" & TCodigo.Text & "%' ORDER BY Usuario ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Usuario LIKE '%" & TNombre.Text & "%' ORDER BY Usuario ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Usuario LIKE '%" & TNombre.Text & "%' ORDER BY Usuario ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Usuario Asc"
                            End If
                        End If

                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Usuario").HeaderText = "Usuario"
                        GridBuscar.Columns("Usuario").Width = 250
                        GridBuscar.Columns("Usuario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CtasBancariasEmpleadosFA"
                        Dim CadBase = "Select  NumCta, TipoCta, idBanco, Banco, Titular  FROM VCtasBancarias WHERE TipoAsignado='Empleados'"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE NumCta LIKE '%" & TCodigo.Text & "%' ORDER BY Banco ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY BANCO Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("NumCta").HeaderText = "Número de Cuenta"
                        GridBuscar.Columns("NumCta").Width = 230
                        GridBuscar.Columns("TipoCta").HeaderText = "Tipo Cta."
                        GridBuscar.Columns("TipoCta").Width = 130
                        GridBuscar.Columns("Banco").HeaderText = "Cód."
                        GridBuscar.Columns("Banco").Width = 50
                        GridBuscar.Columns("Banco").HeaderText = "Banco"
                        GridBuscar.Columns("Banco").Width = 150
                        GridBuscar.Columns("Titular").HeaderText = "Titular"
                        GridBuscar.Columns("Titular").Width = 150
                        GridBuscar.Columns("NumCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TipoCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("idBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Titular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CtasBancariasDatosClientes"
                        Dim CadBase = "Select  NumCta, TipoCta, idBanco, Banco, Titular  FROM VCtasBancarias WHERE idAsignado=" & CodCliente
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE NumCta LIKE '%" & TCodigo.Text & "%' ORDER BY Banco ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY BANCO Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("NumCta").HeaderText = "Número de Cuenta"
                        GridBuscar.Columns("NumCta").Width = 230
                        GridBuscar.Columns("TipoCta").HeaderText = "Tipo Cta."
                        GridBuscar.Columns("TipoCta").Width = 130
                        GridBuscar.Columns("Banco").HeaderText = "Cód."
                        GridBuscar.Columns("Banco").Width = 50
                        GridBuscar.Columns("Banco").HeaderText = "Banco"
                        GridBuscar.Columns("Banco").Width = 150
                        GridBuscar.Columns("Titular").HeaderText = "Titular"
                        GridBuscar.Columns("Titular").Width = 150
                        GridBuscar.Columns("NumCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TipoCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("idBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Titular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CtasBancariasDatos", "CtasBancariasDatosPM", "CtasBancariasDatosFA"
                        Dim CadBase = "Select  NumCta, TipoCta, idBanco, Banco, Titular  FROM VCtasBancarias WHERE Banco<>'' and TipoAsignado='Empresa Directo'"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE NumCta LIKE '%" & TCodigo.Text & "%' ORDER BY Banco ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Banco LIKE '%" & TNombre.Text & "%' ORDER BY Banco ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY BANCO Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("NumCta").HeaderText = "Número de Cuenta"
                        GridBuscar.Columns("NumCta").Width = 230
                        GridBuscar.Columns("TipoCta").HeaderText = "Tipo Cta."
                        GridBuscar.Columns("TipoCta").Width = 130
                        GridBuscar.Columns("Banco").HeaderText = "Cód."
                        GridBuscar.Columns("Banco").Width = 50
                        GridBuscar.Columns("Banco").HeaderText = "Banco"
                        GridBuscar.Columns("Banco").Width = 150
                        GridBuscar.Columns("Titular").HeaderText = "Titular"
                        GridBuscar.Columns("Titular").Width = 150
                        GridBuscar.Columns("NumCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TipoCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("idBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Titular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CtasBancarias", "ValidarMontoCtasBancarias"
                        Dim CadBase = "Select  NumCta, TipoCta, idBanco, Banco, Titular,TipoAsignado  FROM VCtasBancarias"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE NumCta LIKE '%" & TCodigo.Text & "%'  and TipoAsignado='Empresa Directo' ORDER BY Banco ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Banco LIKE '%" & TNombre.Text & "%' and TipoAsignado='Empresa Directo' ORDER BY Banco ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Banco LIKE '%" & TNombre.Text & "%' and TipoAsignado='Empresa Directo' ORDER BY Banco ASC"
                            Else
                                CadSQL = CadSQL & " WHERE TipoAsignado='Empresa Directo' ORDER BY BANCO Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("NumCta").HeaderText = "Número de Cuenta"
                        GridBuscar.Columns("NumCta").Width = 200
                        GridBuscar.Columns("TipoCta").HeaderText = "Tipo Cta."
                        GridBuscar.Columns("TipoCta").Width = 120
                        GridBuscar.Columns("idBanco").HeaderText = "Cód. Banco"
                        GridBuscar.Columns("idBanco").Width = 150
                        GridBuscar.Columns("Banco").HeaderText = "Banco"
                        GridBuscar.Columns("Banco").Width = 180
                        GridBuscar.Columns("Titular").HeaderText = "Titular"
                        GridBuscar.Columns("Titular").Width = 180
                        GridBuscar.Columns("TipoAsignado").HeaderText = "Tipo"
                        GridBuscar.Columns("TipoAsignado").Width = 150
                        GridBuscar.Columns("NumCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("TipoCta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("idBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Banco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Titular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Bancos", "BancosCtasBancarias", "BancoClientePM", "BancoEmpleadoPM"
                        Dim CadBase = "Select  idBanco, Nombre  FROM TBancosNew"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idBanco LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idBanco").HeaderText = "Código"
                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("idBanco").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "Moneda", "MonedaFormaPago", "MonedaCompra", "MonedaPagoCompra", "MonedaTipoCambio", "MonedaPagoCliente", "MonedaPagoGastosAsociados", "MonedaCliente"
                        Dim CadBase = "Select  id, Nombre, Simbolo, Tasa  FROM VMonedas"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE id LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns(0).HeaderText = "Código"
                        GridBuscar.Columns(1).HeaderText = "Nombre"
                        GridBuscar.Columns(1).Width = 200
                        GridBuscar.Columns(2).HeaderText = "Simbolo"
                        GridBuscar.Columns(3).HeaderText = "Tasa"
                        GridBuscar.Columns(3).DefaultCellStyle.Format = "##,##0.00"
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "CajeroInicioCaja", "ExaminarCajero"
                        Dim CadBase = "Select idEmpleado,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular  FROM TEmpleado where UsuarioCaja=1"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código."
                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "C.I."
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "EmpleadoRegistraProd"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Activo=1 AND RegistraProd=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Activo=1 AND RegistraProd=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Activo=1 AND RegistraProd=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Activo=1 AND RegistraProd=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "EmpleadoInvSalida", "EmpleadoRegistro"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Activo=1 AND Registra=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Activo=1 AND Registra=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Activo=1 AND Registra=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Activo=1 AND Registra=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "EmpleadoEntrega"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Entrega=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Entrega=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Entrega=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Entrega=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case "EmpleadoElaboroProd", "Transfiere", "Recibe"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Activo=1 AND ElaboraProd=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Activo=1 AND ElaboraProd=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Activo=1 AND  ElaboraProd=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Activo=1 AND  ElaboraProd=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case "EmpleadoRecibe"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE Activo=1 AND Recibe=1 AND idEmpleado LIKE '%" & TCodigo.Text & "%' ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE  Activo=1 AND Recibe=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE  Activo=1 AND  Recibe=1 AND  Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " WHERE  Activo=1 AND  Recibe=1 ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case "QuienID", "Quien", "Empleados", "EmpleadoFactura", "Vendedor", "EmpleadosCtasBancarias", "EmpresaCtasBancariasIndirecto", "EmpleadoVerifico"
                        Dim CadBase = "Select  idEmpleado,Local,CI, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre, Cargo, Telefono, Celular, Activo FROM VEmpleado"
                        CadSQL = CadBase
                        If (Me.TCodigo.Text <> "") Then
                            CadSQL = CadBase & " WHERE idEmpleado =" & TCodigo.Text & " ORDER BY Nombre ASC"
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                            End If
                        Else
                            If (Me.TNombre.Text <> "") Then
                                CadSQL = CadBase & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                            Else
                                CadSQL = CadSQL & " ORDER BY Nombre Asc"
                            End If
                        End If
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        GridBuscar.Columns("Local").HeaderText = "Local"
                        GridBuscar.Columns("Local").Width = 120
                        GridBuscar.Columns("idEmpleado").HeaderText = "Código"
                        GridBuscar.Columns("idEmpleado").Width = 80

                        GridBuscar.Columns("Nombre").HeaderText = "Nombre"
                        GridBuscar.Columns("Nombre").Width = 200
                        GridBuscar.Columns("CI").HeaderText = "Cédula"
                        Me.GridBuscar.Columns("CI").DefaultCellStyle.Format = "##,##"
                        GridBuscar.Columns("CI").Width = 110
                        GridBuscar.Columns("Cargo").HeaderText = "Cargo"
                        GridBuscar.Columns("Telefono").HeaderText = "Teléfono"
                        GridBuscar.Columns("Telefono").Width = 170
                        GridBuscar.Columns("Celular").HeaderText = "Celular"
                        GridBuscar.Columns("Celular").Width = 170
                        GridBuscar.Columns("Cargo").Width = 170
                        GridBuscar.Columns("Activo").Width = 70

                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("Local").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
                        GridBuscar.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        GridBuscar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                  
                    Case Else
                        Me.GridBuscar.DataSource = Nothing
                End Select
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Private Sub ResaltarSeleccionado()
        Select Case VarBuscar
            Case "CtasBancarias"
                Me.LTitulo.Tag = IIf(Me.LTitulo.Tag = Nothing, "", Me.LTitulo.Tag)
                '  Me.LTitulo.Tag = IIf(Me.LTitulo.Tag.ToString = 0, "", Me.LTitulo.Tag)
                For i = 0 To GridBuscar.RowCount - 1
                    If (Me.GridBuscar.Rows(i).Cells(0).Value = Me.LTitulo.Tag) Then
                        Me.GridBuscar.CurrentCell = Me.GridBuscar.Rows(i).Cells(0)
                    End If
                Next
            Case "CrearUsuario", "CtasBancariasDatosFA"

            Case "Producto", "CompraProdInterno", "BuscarInsumoTransf"
                For i = 0 To GridBuscar.RowCount - 1
                    If (Me.GridBuscar.Rows(i).Cells("idProducto").Value.ToString = Me.LTitulo.Tag) Then
                        Me.GridBuscar.CurrentCell = Me.GridBuscar.Rows(i).Cells("idProducto")
                    End If
                Next
            Case "UsuarioCierreCaja", "Autorizar", "ValidarMontoCtasBancarias", "AutorizarComentario"
            Case Else
                Me.LTitulo.Tag = IIf(Me.LTitulo.Tag = Nothing, 0, Me.LTitulo.Tag)
                Me.LTitulo.Tag = IIf(Me.LTitulo.Tag.ToString = "", 0, Me.LTitulo.Tag)
                For i = 0 To GridBuscar.RowCount - 1
                    If (Me.GridBuscar.Rows(i).Cells(0).Value = Me.LTitulo.Tag) Then
                        Me.GridBuscar.CurrentCell = Me.GridBuscar.Rows(i).Cells(0)
                    End If
                Next
        End Select
    End Sub
    Private Sub FBuscarGenerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Select Case VarBuscar
            Case "DocumentoEspera", "DocumentoCopia", "DocumentoDevolucion", "BuscarVenta"
                Me.LCodigo.Text = "Total Bs.: "
                Me.LNombre.Text = "Cliente: "
            Case Else
                Me.LCodigo.Text = "Código: "
                Me.LNombre.Text = "Nombre: "
        End Select
        MostrarDatosBusqueda()
        ResaltarSeleccionado()
        Me.TNombre.Select()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        NoActualizar = True
        Me.Close()
    End Sub
    Private Sub GridBuscar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBuscar.CellContentDoubleClick
        NoActualizar = False
        Select Case VarBuscar
          
            Case "CierreCajas"
                CajaActiva = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Caja").Value)
                CodCajaActiva = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCaja").Value
                CodCajero = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCajero").Value
                CodApertura = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCierre").Value
                FControlCaja.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Caja").Value)
                FControlCaja.TCaja.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCaja").Value)
                FControlCaja.TCajero.Text = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Cajero").Value
                FControlCaja.FechaApertura.Value = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("FechaInicio").Value
                FControlCaja.FechaCierre.Value = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("FechaCierre").Value
                Me.Close()
           
            Case "ProductoNacional"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TProducto.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TProducto.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "CategoriasInt"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TCategoriaInt.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TCategoriaInt.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    FProducto.TUnidadGeneral.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Unidad").Value)
                    FProducto.TUnidadGeneral.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idUnidad").Value)
                    Me.Close()
                End If
            Case "Categorias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Categoria = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "CategoriasInv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString) = "") Then
                        '  FInventario.LCategoria.Tag = 0
                        '  FInventario.LCategoria.Text = "Todo"
                        Categoria = ""
                    Else
                        '   FInventario.LCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                        '    FInventario.LCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                        Categoria = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                    End If
                    Me.Close()
                End If
            Case "CategoriasNivST"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString) = "") Then
                        '    FInventarioNivelar1.LCategoriaST.Tag = 0
                        '   FInventarioNivelar1.LCategoriaST.Text = "Todo"
                        Categoria = ""
                    Else
                        '     FInventarioNivelar1.LCategoriaST.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                        '     FInventarioNivelar1.LCategoriaST.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                        Categoria = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                    End If
                    Me.Close()
                End If
            Case "CategoriasNiv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString) = "") Then
                        '   FInventarioNivelar1.LCategoria.Tag = 0
                        '   FInventarioNivelar1.LCategoria.Text = "Todo"
                        Categoria = ""
                    Else
                        '   FInventarioNivelar1.LCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                        '   FInventarioNivelar1.LCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                        Categoria = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value.ToString)
                    End If
                    Me.Close()
                End If
            Case "SubCategorias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TSubCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TSubCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "SubCategoriasInv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    ' FInventario.LSubCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '  FInventario.LSubCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "SubCategoriasNivST"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FInventarioNivelar1.LSubCategoriaST.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '   FInventarioNivelar1.LSubCategoriaST.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "SubCategoriasNiv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FInventarioNivelar1.LSubCategoria.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '  FInventarioNivelar1.LSubCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
                'Case "UnidadIngEscala"
                '    If GridBuscar.CurrentRow IsNot Nothing Then
                '        FEscalarRecetas.TUnidadIng.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                '        FEscalarRecetas.TUnidadIng.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '        Me.Close()
                '    End If
            Case "UnidadIngReceta"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '    FRecetaCrear.TUnidadIng.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '   FRecetaCrear.TUnidadIng.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '    Me.Close()
                End If
                'Case "UnidadIngReceta2"
                '    If GridBuscar.CurrentRow IsNot Nothing Then
                '        FRecetaCrear.TUnidadIng2.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                '        FRecetaCrear.TUnidadIng2.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '        Me.Close()
                '    End If
                'Case "UnidadIng"
                '    If GridBuscar.CurrentRow IsNot Nothing Then
                '        FProducto.TUnidadIng.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                '        FProducto.TUnidadIng.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '        Me.Close()
                '    End If
            Case "Unidad"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FUnidades.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '  FUnidades.TNombre.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '  FUnidades.TDescripcion.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Descripcion").Value)
                    '   FUnidades.CBActivo.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Activo").Value)
                    Me.Close()
                End If
            Case "UnidadInterna"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FCategoriaInterna.TUnidad.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '  FCategoriaInterna.TUnidad.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "Unidades"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TUnidad.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TUnidad.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "UnidadCapacidadProd"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TUnidadCap.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TUnidadCap.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "MarcasP"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    'FMarca.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    'FMarca.TNombre.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Marca").Value)
                    'FMarca.TDescripcion.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Descripcion").Value.ToString)
                    'FMarca.CBActivo.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Activo").Value)
                    Me.Close()
                End If
            Case "Marcas"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TMarca.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TMarca.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Marca").Value)
                    Me.Close()
                End If
            Case "TipoProducto"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TTipoProducto.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TTipoProducto.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "TipoProductoInv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    ' If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) = "") Then
                    '    FInventario.LTipoProducto.Tag = 0
                    '    FInventario.LTipoProducto.Text = "Todo"
                    'Else
                    '    FInventario.LTipoProducto.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '    FInventario.LTipoProducto.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    'End If
                    Me.Close()
                End If
            Case "TipoProductoNivST"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) = "") Then
                        '       FInventarioNivelar1.LTipoProductoST.Tag = 0
                        '         FInventarioNivelar1.LTipoProductoST.Text = "Todo"
                    Else
                        '          FInventarioNivelar1.LTipoProductoST.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                        '          FInventarioNivelar1.LTipoProductoST.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    End If
                    Me.Close()
                End If
            Case "TipoProductoNiv"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If (Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) = "") Then
                        '   FInventarioNivelar1.LTipoProducto.Tag = 0
                        '   FInventarioNivelar1.LTipoProducto.Text = "Todo"
                    Else
                        '    FInventarioNivelar1.LTipoProducto.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                        '     FInventarioNivelar1.LTipoProducto.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    End If
                    Me.Close()
                End If
            Case "TipoReceta"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TTipoReceta.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FProducto.TTipoReceta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "TipoCambio"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FTipoCambio.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '   FTipoCambio.TNombre.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '   FTipoCambio.TMoneda.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Moneda").Value)
                    ' '   FTipoCambio.TMoneda.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idMoneda").Value)
                    '    FTipoCambio.CBAfectaCaja.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("AfectaCaja").Value)
                    Me.Close()
                End If
            Case "TipoCambio2"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    ' FCambio.GridCambio.Rows.Add("...", Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) + " " + Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Moneda").Value), 0, 0, "...", "...")
                    NoActualizar = False
                    Me.Close()
                End If
            Case "TipoDoc"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    ' FTipoDocumento.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    ' FTipoDocumento.TNombre.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "TipoDocCompra"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FCompra.CTipoDoc.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FCompra.CTipoDoc.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "AlicuotaCompra"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FCompra.GridCompra.Rows(FCompra.GridCompra.CurrentCell.RowIndex).Cells("Alicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    FCompra.GridCompra.Rows(FCompra.GridCompra.CurrentCell.RowIndex).Cells("ValorAlicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Alicuota").Value)
                    FCompra.GridCompra.Rows(FCompra.GridCompra.CurrentCell.RowIndex).Cells("idAlicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "AlicuotaCompraInterna"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '    FInventarioProduccion.GridCompra.Rows(FInventarioProduccion.GridCompra.CurrentCell.RowIndex).Cells("Alicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '  FInventarioProduccion.GridCompra.Rows(FInventarioProduccion.GridCompra.CurrentCell.RowIndex).Cells("ValorAlicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Alicuota").Value)
                    '   FInventarioProduccion.GridCompra.Rows(FInventarioProduccion.GridCompra.CurrentCell.RowIndex).Cells("idAlicuota").Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "AlicuotaProdC"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TIVAC.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Alicuota").Value)
                    FProducto.TIVAC.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "AlicuotaProdV"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TIVAV.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Alicuota").Value)
                    FProducto.TIVAV.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "MonedaTipoCambio"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FTipoCambio.TMoneda.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '   FTipoCambio.TMoneda.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) & "  (" & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Simbolo").Value) & ")"
                    Me.Close()
                End If
            Case "MonedaCliente"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    MonedaBase = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "MonedaCompra"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FCompra.BMonedaBase.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FCompra.BMonedaBase.Text = "Moneda Base: " & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Simbolo").Value)
                    MonedaBase = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "MonedaPagoCliente"
                'If GridBuscar.CurrentRow IsNot Nothing Then
                '    FFormaPagoCliente.BMonedaPago.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                '    FFormaPagoCliente.BMonedaPago.Text = "Moneda Pago: " & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Simbolo").Value)
                '    MonedaPago = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '    Me.Close()
                'End If
           
            Case "MonedaPagoCompra"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FCompra.BMonedaPago.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    FCompra.BMonedaPago.Text = "Moneda Pago: " & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Simbolo").Value)
                    MonedaPago = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "AperturaCajasInicio"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FOperacionesCajas.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '   FOperacionesCajas.TCaja.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "ExaminarEstacion"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '    FExaminarCierreCaja.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '    FExaminarCierreCaja.TCaja.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "ConfigurarCajasEst"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '    FConfigurarCajas.TEstacion.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Estacion").Value)
                    Me.Close()
                End If
            Case "AperturaCajas"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '     FAperturaCaja.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '     FAperturaCaja.TCaja.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    '  CodLocalActivo = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idLocal").Value
                    Me.Close()
                End If
            Case "NombresCajas"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FControlCaja.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    FControlCaja.TCaja.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("id").Value)
                    Me.Close()
                End If
            Case "ImprimirFactura"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FImprimirFacturaCL.TNFactura.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idVenta").Value)
                    '  FImprimirFacturaCL.TCaja.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Caja").Value)
                    '   FImprimirFacturaCL.FechaFactura.Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Fecha").Value)
                    CodVenta = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idVenta").Value)
                    NoActualizar = False
                    Me.Close()
                End If
            Case "DocumentoEspera", "DocumentoCopia", "DocumentoDevolucion", "BuscarVenta"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    CodVenta = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idVenta").Value)
                    Me.Close()
                End If
            Case "BusquedaCaja"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FCajaNew.TBusqueda.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value)
                    Me.Close()
                End If
            Case "ExaminarCajero"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    CodCajero = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '     FExaminarCierreCaja.TCajero.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '    FExaminarCierreCaja.TCajero.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "Quien"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    CodCajero = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '''      FInventarioNivelar1.TQuien.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '   FInventarioNivelar1.TQuien.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "QuienID"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    ' CodCajero = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '  FInventarioNivelar1.TQuienID.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '   FInventarioNivelar1.TQuienID.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "CajeroInicioCaja"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    CodCajeroApertura = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '   FAperturaCaja.TCajero.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '   FAperturaCaja.TCajero.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
            Case "UsuarioCierreCaja"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FControlCaja.CUsuario.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Usuario").Value)
                    Me.Close()
                End If
            Case "AutorizarComentario"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FAutorizarComentario.CUsuario.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Usuario").Value)
                    Me.Close()
                End If
            Case "Autorizar"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FAutorizar.CUsuario.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Usuario").Value)
                    Me.Close()
                End If
            Case "UsuarioInicioCaja"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FAperturaCaja.CUsuario.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Usuario").Value)
                    Me.Close()
                End If
            Case "ValidarMontoCtasBancarias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FCancelarFactura.TNumCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    '  FCancelarFactura.TNumCta.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    Me.Close()
                End If
            Case "ClientesCtasBancarias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '  FCtasBancarias.TCodAsignar.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCliente").Value)
                    ' FCtasBancarias.TNombreAsignado.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '  FCtasBancarias.TTitular.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '  FCtasBancarias.TCI.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CI").Value)
                    '  FCtasBancarias.TTelefono.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Celular").Value)
                    Me.Close()
                End If
            Case "EmpleadosCtasBancarias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FCtasBancarias.TCodAsignar.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '  FCtasBancarias.TNombreAsignado.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '  FCtasBancarias.TTitular.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    '   FCtasBancarias.TCI.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CI").Value)
                    '   FCtasBancarias.TTelefono.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Celular").Value)
                    Me.Close()
                End If
            Case "ProveedoresCtasBancarias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    'FCtasBancarias.TCodAsignar.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProveedor").Value)
                    'FCtasBancarias.TNombreAsignado.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    'FCtasBancarias.TTitular.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    'FCtasBancarias.TCI.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("RIF").Value)
                    'FCtasBancarias.TTelefono.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Celular").Value)
                    Me.Close()
                End If
          
            Case "CtasBancarias"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '   FCtasBancarias.TNumCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    Me.Close()
                End If
            Case "CtasBancariasDatos"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    '    FDatosCambio.TNumCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    '   FDatosCambio.TTipoCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCta").Value)
                    ''     FDatosCambio.TCodBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idBanco").Value)
                    '     FDatosCambio.TBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Banco").Value)
                    Me.Close()
                End If
            Case "CtasBancariasDatosPM"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    'FDatosCambioPM.TNumCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    'FDatosCambioPM.TTipoCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCta").Value)
                    'FDatosCambioPM.TCodBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idBanco").Value)
                    'FDatosCambioPM.TBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Banco").Value)
                    Me.Close()
                End If
            Case "CtasBancariasDatosClientes"
                'If GridBuscar.CurrentRow IsNot Nothing Then
                '    FDatosCambio.TNumCtaCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                '    FDatosCambio.TTipoCtaCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCta").Value)
                '    FDatosCambio.TCodBancoCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idBanco").Value)
                '    FDatosCambio.TBancoCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Banco").Value)
                Me.Close()
                'End If
            Case "CtasBancariasEmpleadosFA"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    'FNuevoFondoAnticipo.TNumCtaCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    'FNuevoFondoAnticipo.TTipoCtaCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCta").Value)
                    'FNuevoFondoAnticipo.TCodBancoCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idBanco").Value)
                    'FNuevoFondoAnticipo.TBancoCliente.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Banco").Value)
                    Me.Close()
                End If
            Case "CtasBancariasDatosFA"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    'FNuevoFondoAnticipo.TNumCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NumCta").Value)
                    'FNuevoFondoAnticipo.TTipoCta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCta").Value)
                    'FNuevoFondoAnticipo.TCodBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idBanco").Value)
                    'FNuevoFondoAnticipo.TBanco.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Banco").Value)
                    Me.Close()
                End If
           
         
            Case "ProductoEmpaquetado"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TEmpaquetado.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value)
                    FProducto.TEmpaquetado.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Precio1Emp = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Precio1").Value)
                    PrecioD1Emp = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PrecioD1").Value)
                    Me.Close()
                End If
            Case "ProductoEscalado"
                'If GridBuscar.CurrentRow IsNot Nothing Then
                '    FRecetaEscalado.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value)
                '    FRecetaEscalado.LNombreProd.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '    FRecetaEscalado.LNombreProd.BackColor = Color.FromArgb(Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("ColorCat").Value))
                '    Select Case Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoReceta").Value.ToString)
                '        Case "Panaderia"
                '            FRecetaEscalado.RBPan.Checked = True
                '        Case Else
                '            FRecetaEscalado.RBOtro.Checked = True
                '    End Select
                '    FRecetaEscalado.TPrecio.Text = Format(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Precio1").Value, "##,##0.00")
                '    FRecetaEscalado.TPrecioD.Text = Format(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PrecioD1").Value, "##,##0.00")
                '    If Conectar4() Then
                '        Dim Comando4 As New SqlCommand("Select ImagenF FROM TNewProducto WHERE idProducto=@idProducto", CNN4)
                '        Comando4.Parameters.AddWithValue("@idProducto", Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value))
                '        Dim DR As SqlDataReader = Comando4.ExecuteReader()
                '        Do While DR.Read()
                '            Dim ms As New System.IO.MemoryStream()
                '            Dim imageBuffer() As Byte = CType(DR("ImagenF"), Byte())
                '            ms = New System.IO.MemoryStream(imageBuffer)
                '            FEscalar.Imagen.BackgroundImage = Nothing
                '            FEscalar.Imagen.BackgroundImage = (Image.FromStream(ms))
                '            FEscalar.Imagen.BackgroundImageLayout = ImageLayout.Stretch
                '        Loop
                '        DR.Close()
                '        Desconectar4()
                '    End If
                '    Me.Close()

                'End If

           
            Case "ProductoReceta"
                ' If GridBuscar.CurrentRow IsNot Nothing Then
                '    FRecetas.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value)
                '    FRecetas.LNombreProd.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                '    'Mostrar la Imagen del Producto
                '    Dim ms As New System.IO.MemoryStream()
                '    Dim imageBuffer() As Byte = CType(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("ImagenF").Value, Byte())
                '    ms = New System.IO.MemoryStream(imageBuffer)
                '    FRecetas.Imagen.BackgroundImage = Nothing
                '    FRecetas.Imagen.BackgroundImage = (Image.FromStream(ms))
                '    FRecetas.Imagen.BackgroundImageLayout = ImageLayout.Stretch

                '    FRecetas.LNombreProd.BackColor = Color.FromArgb(Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("ColorCat").Value))
                '    FRecetas.TidTipiReceta.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCategoria").Value.ToString)

                '    'Select Case Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoReceta").Value.ToString)
                '    '    Case "Panaderia"
                '    '        FRecetas.RBPan.Checked = True
                '    '    Case Else
                '    '        FRecetas.RBOtro.Checked = True
                '    'End Select
                '    FRecetas.CBEmpaquetado.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Empaquetado").Value)
                '    FRecetas.TEmpaquetado.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProdEmpaquetado").Value.ToString)
                '    FRecetas.TEmpaquetado.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("ProdEmpaquetado").Value.ToString)
                '    FRecetas.TCantEmp.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CantEmpaquetado").Value.ToString)
                '    FRecetas.LCategoria.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Categoria").Value.ToString)
                '    FRecetas.LCategoria.BackColor = Color.FromArgb(Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("ColorCat").Value))
                '    FRecetas.LSubCat.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("SubCategoria").Value.ToString)

                '    FEscalar.TPrecio.Text = Format(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Precio1").Value, "##,##0.00")
                '    FEscalar.TPrecioD.Text = Format(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PrecioD1").Value, "##,##0.00")

                '    Me.Close()
                'End If
            Case "Producto"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProducto.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value)
                    Me.Close()
                End If
            Case "CompraProd"
                Dim CostoXX As Decimal = 0
                Dim CostoDXX As Decimal = 0
                Dim TipoFactorAlt As String = ""
                If GridBuscar.CurrentRow IsNot Nothing Then
                    If GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoFactorAlt").Value.ToString = "" Then
                        TipoFactorAlt = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Unidad").Value & " X"
                    Else
                        TipoFactorAlt = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoFactorAlt").Value
                    End If
                    If (GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("TipoCostoAlt").Value) Then
                        CostoXX = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Costo").Value / GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("FactorAlt").Value
                        CostoDXX = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoD").Value / GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("FactorAlt").Value
                    Else
                        CostoXX = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Costo").Value
                        CostoDXX = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoD").Value
                    End If
                    FCompra.GridCompra.Rows.Add(FCompra.GridCompra.RowCount + 1, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Unidad").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idUnidad").Value), 1, 1, CostoXX, CostoDXX, 0, CostoDXX, (CostoDXX / 100) * GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("IVAC").Value, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("NIVAC").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idIVAC").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("IVAC").Value), CostoDXX, CostoXX, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Decimal").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Costo2").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Costo2D").Value), "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("UnidadAlt").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("FactorAlt").Value), 0, 0, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoCalUnid").Value, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoCalUnidD").Value, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idTipoProducto").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Empaquetado").Value), TipoFactorAlt, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Venta").Value, False, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoCalUnid").Value, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CostoCalUnidD").Value, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idCategoriaInt").Value), VFormat(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Capacidad").Value, 2), 0, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idUnidadCapacidad").Value, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("UnidadCapacidad").Value, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CalculoCap").Value, 0, GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("VentaUnidAlt").Value)
                    Me.Close()
                End If
         
            Case "ProveedorCompraL"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FCompra.TProveedorL.Tag = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProveedor").Value)
                    FCompra.TProveedorL.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    Me.Close()
                End If
           
          

            Case "Vendedor"
                If VarForma = "FCajas" Then
                   
                Else
                    'If GridBuscar.CurrentRow IsNot Nothing Then
                    '    CodCajero = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idEmpleado").Value)
                    '    FInicializarFeria.LVendedor.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Apellido").Value)
                    '    FCajaNew.LVendedor.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value) & " " & Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Apellido").Value)
                    '    Me.Close()
                    'End If
                End If
          
            Case "Empleados"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FEmpleados.Listo = True
                    FEmpleados.TCI.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("CI").Value)
                    FEmpleados.Listo = False
                    FEmpleados.TCI_TextChanged(Nothing, Nothing)
                    Me.Close()
                End If
         
         
            Case "Proveedor"
                If GridBuscar.CurrentRow IsNot Nothing Then
                    FProveedores.TCodigo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProveedor").Value)
                    FProveedores.TNombre.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value)
                    FProveedores.TRif.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Rif").Value)
                    FProducto.TDescripcion.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Descripcion").Value)
                    FProveedores.TDireccion.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Direccion").Value)
                    FProveedores.TTelefono.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Telefono").Value)
                    FProveedores.TCelular.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Celular").Value)
                    FProveedores.TCorreo.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Correo").Value)
                    FProveedores.TSitioWeb.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("SitioWeb").Value)
                    FProveedores.Fecha.Value = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Fecha").Value)
                    FProveedores.CBEfecExtAjeno.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("EfecExtAjeno").Value)
                    FProveedores.CHAlqPuntoExt.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("AlqPuntoExt").Value)
                    FProveedores.TPPago.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Porc").Value)
                    FProveedores.TPorcAlqExt.Text = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PorcRetorno").Value)
                    FProveedores.CBForaneo.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Foraneo").Value)
                    FProveedores.CBTransporte.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Transporte").Value)
                    FProveedores.CBOtros.Checked = Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Otros").Value)
                    Me.Close()
                End If
           
        End Select
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        GridBuscar_CellContentDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub TCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TCodigo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                MostrarDatosBusqueda()
        End Select
    End Sub
    Private Sub Tnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                MostrarDatosBusqueda()
                Me.GridBuscar.Select()
        End Select
    End Sub

    Private Sub TCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress
        Select Case VarBuscar
            Case "DocumentoEspera", "DocumentoCopia", "DocumentoDevolucion"
                If (e.KeyChar = ".") Then
                    e.KeyChar = ","
                End If
                e.Handled = txtNumerico(TCodigo, e.KeyChar, True)
            Case Else
        End Select      
    End Sub

   
    Private Sub GridBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles GridBuscar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                GridBuscar_CellContentDoubleClick(Nothing, Nothing)
        End Select
    End Sub
    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        MostrarDatosBusqueda()
    End Sub
  
  

End Class