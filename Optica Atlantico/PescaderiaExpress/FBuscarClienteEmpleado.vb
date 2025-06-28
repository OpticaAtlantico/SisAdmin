Imports System.Data.SqlClient

Public Class FBuscarClienteEmpleado
    Dim CadSQL As String = ""
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub BuscarCadSQL()
        CadSQL = ""
        If (Me.TCodigo.Text <> "") Then
            CadSQL = CadSQL & " WHERE idCliente=" & TCodigo.Text
        Else
            If (Me.TCedula.Text <> "") Then
                CadSQL = CadSQL & " WHERE CI=" & TCedula.Text
            End If
            If (Me.TNombre.Text <> "") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND Nombre LIKE '%" & TNombre.Text & "%'"
                Else
                    CadSQL = CadSQL & " WHERE Nombre LIKE '%" & TNombre.Text & "%'"
                End If
            End If
            If (Me.TRif.Text <> "") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND TipoRIF='" & Me.CTipoRif.Text & "' AND RIF='" & Me.TRif.Text & "'"
                Else
                    CadSQL = CadSQL & " WHERE TipoRIF='" & Me.CTipoRif.Text & "' AND RIF='" & Me.TRif.Text & "'"
                End If
            End If
            If (Me.TEmpresa.Text <> "") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND DEmpresa LIKE '%" & Me.TEmpresa.Text & "%'"
                Else
                    CadSQL = CadSQL & " WHERE DEmpresa LIKE '%" & Me.TEmpresa.Text & "%'"
                End If
            End If
        End If       
    End Sub

    Private Sub BuscarDatosClientes()
        Dim CadBase = "Select idCliente, Fecha, Nacionalidad , CI , TipoRif , RIF, Nombre, DEmpresa, Telefono, Celular FROM TClientes"
        BuscarCadSQL()
        CadSQL = CadBase & CadSQL & " ORDER BY Nombre"

        Adaptador = New SqlDataAdapter(CadSQL, CNN)
        DataT = New DataTable
        Adaptador.Fill(DataT)
        Me.FInventarioNivelar.DataSource = DataT
        Me.FInventarioNivelar.Columns("idCliente").HeaderText = "Código"
        Me.FInventarioNivelar.Columns("idCliente").Width = 80
        Me.FInventarioNivelar.Columns("Nacionalidad").HeaderText = "Nac."
        Me.FInventarioNivelar.Columns("Nacionalidad").Width = 40
        Me.FInventarioNivelar.Columns("CI").HeaderText = "C.I."
        Me.FInventarioNivelar.Columns("CI").Width = 110
        Me.FInventarioNivelar.Columns("TipoRIF").HeaderText = "Tipo"
        Me.FInventarioNivelar.Columns("TipoRIF").Width = 40
        Me.FInventarioNivelar.Columns("RIF").HeaderText = "R.I.F."
        Me.FInventarioNivelar.Columns("RIF").Width = 110
        Me.FInventarioNivelar.Columns("Nombre").HeaderText = "Nombre"
        Me.FInventarioNivelar.Columns("Nombre").Width = 300
        Me.FInventarioNivelar.Columns("DEmpresa").HeaderText = "Empresa"
        Me.FInventarioNivelar.Columns("DEmpresa").Width = 400
        Me.FInventarioNivelar.Columns("Telefono").HeaderText = "Teléfono"
        Me.FInventarioNivelar.Columns("Telefono").Width = 150
        Me.FInventarioNivelar.Columns("Celular").HeaderText = "Celular"
        Me.FInventarioNivelar.Columns("Celular").Width = 150

        Me.FInventarioNivelar.Columns("idCliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.FInventarioNivelar.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.FInventarioNivelar.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.FInventarioNivelar.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.FInventarioNivelar.Columns("RIF").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.FInventarioNivelar.Columns("DEmpresa").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.FInventarioNivelar.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.FInventarioNivelar.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.FInventarioNivelar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub ResaltarSeleccionado()       
        For i = 0 To FInventarioNivelar.RowCount - 1
            If (Me.FInventarioNivelar.Rows(i).Cells(0).Value.ToString = Me.LTitulo.Tag) Then
                Me.FInventarioNivelar.CurrentCell = Me.FInventarioNivelar.Rows(i).Cells(0)
            End If
        Next
    End Sub
    Private Sub InicializarForma()
        Me.TCodigo.Text = ""
        Me.TCedula.Text = ""
        Me.TNombre.Text = ""
        Me.TRif.Text = ""
        Me.TEmpresa.Text = ""
        Me.CTipoRif.Text = "J"
    End Sub
    Private Sub FBuscarClienteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarForma()
        Select Case VarBuscar
            Case "EmpleadoInvSalida"
                '  BuscarDatosEmpleado()
            Case Else
                BuscarDatosClientes()
        End Select
        ResaltarSeleccionado()
        Me.TCedula.Focus()
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        BuscarDatosClientes()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        FInventarioNivelar_CellContentDoubleClick(Nothing, Nothing)
    End Sub
    Private Sub FInventarioNivelar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles FInventarioNivelar.CellContentDoubleClick
        If FInventarioNivelar.CurrentRow IsNot Nothing Then
            CodCliente = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("idCliente").Value)
            CedulaCliente = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("CI").Value)
            TipoRIFCliente = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("TipoRIF").Value)
            RIFCliente = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("RIF").Value)
            NombreCliente = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("Nombre").Value)
            NomEmpresa = Trim(FInventarioNivelar.Rows(FInventarioNivelar.CurrentRow.Index).Cells("DEmpresa").Value)
            Me.Close()
        End If
    End Sub

    Private Sub FInventarioNivelar_KeyDown(sender As Object, e As KeyEventArgs) Handles FInventarioNivelar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                FInventarioNivelar_CellContentDoubleClick(Nothing, Nothing)
            Case Keys.Escape
                Me.TCedula.SelectionStart = 0
                Me.TCedula.SelectionLength = Me.TCedula.Text.Length
                Me.TCedula.Focus()
        End Select
    End Sub

    Private Sub TCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles TCedula.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosClientes()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub
    Private Sub Tnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosClientes()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub

    Private Sub TCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCedula.KeyPress
        e.Handled = txtNumerico(TCedula, e.KeyChar, False)
    End Sub
    Private Sub TRif_KeyDown(sender As Object, e As KeyEventArgs) Handles TRif.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosClientes()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub

    Private Sub TRif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TRif.KeyPress
        e.Handled = txtNumerico(TRif, e.KeyChar, False)
    End Sub

    Private Sub TEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles TEmpresa.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatosClientes()
                Me.FInventarioNivelar.Select()
        End Select
    End Sub
    'Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
    '    PRINTDGV.PRINT_DATAGRIDVIEW(FInventarioNivelar)
    'End Sub
    Private Sub TCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress
        e.Handled = txtNumerico(TCodigo, e.KeyChar, False)
    End Sub

    Private Sub TCodigo_TextChanged(sender As Object, e As EventArgs) Handles TCodigo.TextChanged

    End Sub
End Class