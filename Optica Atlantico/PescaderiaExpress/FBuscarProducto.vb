
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class FBuscarProducto
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private CadSQL As String = ""
    Private CadSQL2 As String = ""
    Private Band As Integer = 0
    Dim aqui As Boolean = False
    Private Sub MostrarDatosBusqueda()
        Me.GridBuscar.DataSource = Nothing
        Dim Contador As Integer = 1
        CadSQL = ""
        Dim Cad1 As String = ""
        Dim Cad2 As String = ""
        Dim Cad3 As String = ""
        Dim Cad4 As String = ""
        Dim Cad5 As String = ""
        Try
            If Conectar() Then
                Select Case VarBuscar
 
                    Case "BuscarProducto", "Producto"
                        CadSQL = "Select  ROW_NUMBER() OVER(ORDER BY Nombre ASC) AS Num, idProducto, Categoria, SubCategoria, Nombre, Stock, PrecioD1,Precio1, Activo, idCategoria, idSubCategoria,Observaciones FROM VProducto"
                        If (Me.TCodigo.Text <> "") Then
                            Cad1 = " Where idProducto='" & Me.TCodigo.Text & "'"
                        Else
                            Cad1 = ""
                            If (Me.TNombre.Text <> "") Then
                                If (Cad1 = "") Then
                                    Cad1 = " Where Nombre LIKE '%" & Me.TNombre.Text & "%'"
                                Else
                                    Cad1 = Cad1 & " And Nombre LIKE '%" & Me.TNombre.Text & "%'"
                                End If
                            End If
                            If (Me.CCategoria.Text <> "") Then
                                If (Cad1 = "") Then
                                    Cad1 = " where idCategoria=" & Me.CCategoria.SelectedValue
                                Else
                                    Cad1 = Cad1 & " And idCategoria=" & Me.CCategoria.SelectedValue
                                End If
                            End If
                            If (Me.CSubCategoria.Text <> "") Then
                                If (Cad1 = "") Then
                                    Cad1 = " where idSubCategoria=" & Me.CSubCategoria.SelectedValue
                                Else
                                    Cad1 = Cad1 & " And idSubCategoria=" & Me.CSubCategoria.SelectedValue
                                End If
                            End If
                            If (Cad1 = "") Then
                                Cad1 = Cad1 & " WHERE Activo=" & IIf(Me.CBActivo.Checked, 1, 0)
                            Else
                                Cad1 = Cad1 & " AND Activo=" & IIf(Me.CBActivo.Checked, 1, 0)
                            End If
                        End If

                        CadSQL = CadSQL + " " + Cad1
                        Adaptador = New SqlDataAdapter(CadSQL, CNN)

                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Me.GridBuscar.DataSource = DataT
                        Me.GridBuscar.Columns("Num").HeaderText = "Nº"
                        Me.GridBuscar.Columns("Num").Width = 60
                        Me.GridBuscar.Columns("idProducto").HeaderText = "Código"
                        Me.GridBuscar.Columns("idProducto").Width = 100
                        Me.GridBuscar.Columns("Categoria").HeaderText = "Categoria"
                        Me.GridBuscar.Columns("Categoria").Width = 120
                        Me.GridBuscar.Columns("SubCategoria").HeaderText = "SubCategoria"
                        Me.GridBuscar.Columns("SubCategoria").Width = 130
                        Me.GridBuscar.Columns("Nombre").HeaderText = "Producto"
                        Me.GridBuscar.Columns("Nombre").Width = 350
                        Me.GridBuscar.Columns("Precio1").HeaderText = "PVP Bs."
                        Me.GridBuscar.Columns("Precio1").DefaultCellStyle.Format = "##,##0.00"
                        Me.GridBuscar.Columns("Precio1").Width = 120
                        Me.GridBuscar.Columns("PrecioD1").HeaderText = "PVP $"
                        Me.GridBuscar.Columns("PrecioD1").DefaultCellStyle.Format = "##,##0.00"
                        Me.GridBuscar.Columns("PrecioD1").Width = 120
                        Me.GridBuscar.Columns("Activo").HeaderText = "Activo?"
                        Me.GridBuscar.Columns("Activo").Width = 80

                        Me.GridBuscar.Columns("idCategoria").Visible = False
                        Me.GridBuscar.Columns("idSubCategoria").Visible = False
                        Me.GridBuscar.Columns("Observaciones").Visible = False

                        Me.GridBuscar.Columns("Num").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("idProducto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Me.GridBuscar.Columns("Categoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("SubCategoria").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("Precio1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("PrecioD1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Me.GridBuscar.Columns("Activo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                        Me.GridBuscar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case Else
                        Me.GridBuscar.DataSource = Nothing
                End Select
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Me.TNombre.Select()
    End Sub
    Private Sub ResaltarSeleccionado()
        For i = 0 To GridBuscar.RowCount - 1
            If (Me.GridBuscar.Rows(i).Cells("idProducto").Value.ToString = Me.LTitulo.Tag) Then
                Me.GridBuscar.CurrentCell = Me.GridBuscar.Rows(i).Cells("idProducto")
            End If
        Next
    End Sub
    Private Sub FBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        LlenarComboCategorias()
        LlenarComboSubCategorias()
        MostrarDatosBusqueda()
        ResaltarSeleccionado()
        Me.TNombre.Select()      
    End Sub

    Private Sub LlenarComboCategorias()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT  * FROM TCategoria ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                aqui = True
                Me.CCategoria.DataSource = DataT
                Me.CCategoria.DisplayMember = "Nombre"
                Me.CCategoria.ValueMember = "Id"
                aqui = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de las Categorias..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarComboSubCategorias()
        If aqui = False Then
            If Conectar() Then
                Try
                    Adaptador = New SqlDataAdapter("SELECT  * FROM TSubCategoria WHERE idCategoria ='" & Me.CCategoria.SelectedValue & "' OR idCategoria=1 ORDER BY Nombre ASC", CNN)
                    DataT = New DataTable
                    Adaptador.Fill(DataT)
                    Me.CSubCategoria.DataSource = DataT
                    Me.CSubCategoria.DisplayMember = "Nombre"
                    Me.CSubCategoria.ValueMember = "Id"
                Catch ex As Exception
                    MessageBox.Show("Error al Cargar Datos de las SubCategorias..." & ControlChars.CrLf & ex.Message)
                    Desconectar()
                End Try
            End If
            Desconectar()
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        NoActualizar = True
        Me.Close()
    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        MostrarDatosBusqueda()
    End Sub
    Private Sub GridBuscar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBuscar.CellContentDoubleClick
        NoActualizar = False
        Select Case VarBuscar
            Case "Producto"
                FProducto.TCodigo.Text = GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value
            Case "BuscarProducto"
                FFacturacion.Grid.Rows.Add(FCompra.GridCompra.RowCount + 1, Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("idProducto").Value), Trim(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Nombre").Value), VFormat(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("Stock").Value, 2), 1, VFormat(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PrecioD1").Value, 2), VFormat(GridBuscar.Rows(GridBuscar.CurrentRow.Index).Cells("PrecioD1").Value, 2), "")
        End Select
        Me.Close()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
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
    Private Sub GridBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles GridBuscar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                GridBuscar_CellContentDoubleClick(Nothing, Nothing)
        End Select
    End Sub
    Private Sub CCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CCategoria.SelectedIndexChanged
        LlenarComboSubCategorias()
    End Sub
    Private Sub BExportar_Click(sender As Object, e As EventArgs) Handles BExportar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim Forma As New FEsperarImpresion
        Forma.ExportarExcel.Visible = True
        Forma.Show()
        Forma.Refresh()
        Call GridExcel(GridBuscar)
        Forma.Close()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class