
Imports System.Data.SqlClient
Public Class FBuscarProveedor
    Dim CadSQL As String = ""
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub BuscarDatosProveedores()
        Dim CadBase = "Select idProveedor, Rif, Alias, Nombre, Telefono, Celular FROM TProveedor"
        CadSQL = CadBase
        If (Me.TRif.Text <> "") Then
            If (Me.TAlias.Text <> "") Then
                If (Me.TNombre.Text <> "") Then
                    CadSQL = CadSQL & " WHERE Rif=" & TRif.Text & " AND Alias LIKE '%" & TAlias.Text & "%'" & " AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                Else
                    CadSQL = CadSQL & " WHERE Rif='" & TRif.Text & "' AND Alias LIKE '%" & TAlias.Text & "%'" & " ORDER BY Nombre ASC"
                End If
            Else
                If (Me.TNombre.Text <> "") Then
                    CadSQL = CadSQL & " WHERE Rif='" & TRif.Text & "' AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                Else
                    CadSQL = CadSQL & " WHERE Rif='" & TRif.Text & "' ORDER BY Nombre ASC"
                End If
            End If
        Else
            If (Me.TAlias.Text <> "") Then
                If (Me.TNombre.Text <> "") Then
                    CadSQL = CadSQL & " WHERE Alias LIKE '%" & TAlias.Text & "%'" & " AND Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                Else
                    CadSQL = CadSQL & " WHERE Alias LIKE '%" & TAlias.Text & "%'" & " ORDER BY Nombre ASC"
                End If
            Else
                If (Me.TNombre.Text <> "") Then
                    CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%' ORDER BY Nombre ASC"
                Else
                    CadSQL = CadSQL & " ORDER BY Nombre Asc"
                End If
            End If
        End If
        Adaptador = New SqlDataAdapter(CadSQL, CNN)
        DataT = New DataTable
        Adaptador.Fill(DataT)
        Me.FInventarioNivelar.DataSource = DataT
        FInventarioNivelar.Columns("idProveedor").HeaderText = "Código"
        FInventarioNivelar.Columns("Rif").HeaderText = "R.I.F."
        FInventarioNivelar.Columns("Rif").Width = 120
        FInventarioNivelar.Columns("Alias").HeaderText = "Alias"
        FInventarioNivelar.Columns("Alias").Width = 250
        FInventarioNivelar.Columns("Nombre").HeaderText = "Nombre"
        FInventarioNivelar.Columns("Nombre").Width = 250
        FInventarioNivelar.Columns("Telefono").HeaderText = "Teléfono"
        FInventarioNivelar.Columns("Celular").HeaderText = "Celular"
        FInventarioNivelar.Columns("idProveedor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        FInventarioNivelar.Columns("Rif").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        FInventarioNivelar.Columns("Alias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        FInventarioNivelar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        FInventarioNivelar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        FInventarioNivelar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        FInventarioNivelar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub ResaltarSeleccionado()
        For i = 0 To FInventarioNivelar.RowCount - 1
            If (Me.FInventarioNivelar.Rows(i).Cells(0).Value.ToString = Me.LTitulo.Tag) Then
                Me.FInventarioNivelar.CurrentCell = Me.FInventarioNivelar.Rows(i).Cells(0)
            End If
        Next
    End Sub
    Private Sub FBuscarClienteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TRif.Text = ""
        Me.TNombre.Text = ""
        Me.TAlias.Text = ""
        BuscarDatosProveedores()
        ResaltarSeleccionado()
        Me.TAlias.Focus()
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        BuscarDatosProveedores()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        FInventarioNivelar_CellContentDoubleClick(Nothing, Nothing)
    End Sub
    Private Sub FInventarioNivelar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles FInventarioNivelar.CellContentDoubleClick
        If FInventarioNivelar.CurrentRow IsNot Nothing Then
            CodProveedor = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("idProveedor").Value)
            '  RifProveedor = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("Rif").Value)
            '  AliasProveedor = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("Aias").Value)
            NombreProveedor = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("Nombre").Value)
            Me.Close()
        End If
    End Sub

    Private Sub FInventarioNivelar_KeyDown(sender As Object, e As KeyEventArgs) Handles FInventarioNivelar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                FInventarioNivelar_CellContentDoubleClick(Nothing, Nothing)
        End Select
    End Sub

    Private Sub TRif_KeyDown(sender As Object, e As KeyEventArgs) Handles TRif.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosProveedores()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub
    Private Sub TAlias_KeyDown(sender As Object, e As KeyEventArgs) Handles TAlias.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosProveedores()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub
    Private Sub Tnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosProveedores()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub
  
End Class