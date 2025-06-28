Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class FBuscarGenericoxx
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private CadSQL As String = ""
    Private Band As Integer = 0
    Private Sub MostrarDatosBusqueda()
        Me.GridBuscar.DataSource = Nothing
        Try
            If Conectar() Then
                Select Case VarBuscar
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
        Me.LTitulo.Tag = IIf(Me.LTitulo.Tag = Nothing, 0, Me.LTitulo.Tag)
        Me.LTitulo.Tag = IIf(Me.LTitulo.Tag.ToString = "", 0, Me.LTitulo.Tag)
        For i = 0 To GridBuscar.RowCount - 1
            If (Me.GridBuscar.Rows(i).Cells(0).Value = Me.LTitulo.Tag) Then
                Me.GridBuscar.CurrentCell = Me.GridBuscar.Rows(i).Cells(0)
            End If
        Next
    End Sub
    Private Sub FBuscarGenerico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
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
    Private Sub GridBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles GridBuscar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                GridBuscar_CellContentDoubleClick(Nothing, Nothing)
        End Select
    End Sub
    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        MostrarDatosBusqueda()
    End Sub
    'Private Sub BExportar_Click(sender As Object, e As EventArgs) Handles BExportar.Click
    '    Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    Dim Forma As New FEsperarImpresion
    '    Forma.ExportarExcel.Visible = True
    '    Forma.Show()
    '    Forma.Refresh()
    '    Call GridExcel(GridBuscar)
    '    Forma.Close()
    '    Cursor = System.Windows.Forms.Cursors.Default
    'End Sub
End Class