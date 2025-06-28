Imports System.Data.SqlClient

Public Class FBuscarEmpleado
    Dim CadSQL As String = ""
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim aqui As Boolean = False

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub BuscarCadSQL()
        CadSQL = ""
        If (Me.TCodigo.Text <> "") Then
            CadSQL = CadSQL & " WHERE idEmpleado=" & TCodigo.Text
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
            If (Me.TApellido.Text <> "") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND Apellido LIKE '%" & TApellido.Text & "%'"
                Else
                    CadSQL = CadSQL & " WHERE Apellido LIKE '%" & TApellido.Text & "%'"
                End If
            End If
            If (Me.TTipo.Text <> " ") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND Fecha" & Me.TTipo.Text & "'" & Me.FechaIng.Value & "'"
                Else
                    CadSQL = CadSQL & " WHERE Fecha" & Me.TTipo.Text & "'" & Me.FechaIng.Value & "'"
                End If
            End If

           
            If (Me.CCargo.Text <> "") Then
                If (CadSQL <> "") Then
                    CadSQL = CadSQL & " AND idGerencia=" & Me.CCargo.SelectedValue
                Else
                    CadSQL = CadSQL & " WHERE idGerencia=" & Me.CCargo.SelectedValue
                End If
            End If
           
                If (Me.CBActivo.Checked) Then
                    If (CadSQL <> "") Then
                        CadSQL = CadSQL & " AND Activo=1"
                    Else
                        CadSQL = CadSQL & " WHERE Activo=1"
                    End If
                End If
            If (CadSQL <> "") Then
                CadSQL = CadSQL & " AND idEmpleado <> 54"
            Else
                CadSQL = CadSQL & " WHERE idEmpleado <> 54"
            End If
        End If
    End Sub

    Private Sub BuscarDatos()
        Dim CadBase = "Select ROW_NUMBER() OVER(ORDER BY Nombre ASC) AS Num, Foto, idEmpleado,Nacionalidad, CI, ' ' as CI2, Nombre , Cargo, Telefono, Celular, Fecha FROM VEmpleado"
        BuscarCadSQL()
        CadSQL = CadBase & CadSQL & " ORDER BY Nombre"

        Adaptador = New SqlDataAdapter(CadSQL, CNN)
        DataT = New DataTable
        Adaptador.Fill(DataT)
        Me.GridEmpleados.DataSource = DataT
        Me.GridEmpleados.Columns("Foto").Width = 80
        Me.GridEmpleados.Columns("idEmpleado").HeaderText = "Código"
        Me.GridEmpleados.Columns("idEmpleado").Width = 80
        Me.GridEmpleados.Columns("Nacionalidad").HeaderText = "Nac."
        Me.GridEmpleados.Columns("Nacionalidad").Width = 40
        Me.GridEmpleados.Columns("CI2").HeaderText = "C.I."
        Me.GridEmpleados.Columns("CI2").Width = 110
        Me.GridEmpleados.Columns("Nombre").HeaderText = "Nombre"
        Me.GridEmpleados.Columns("Nombre").Width = 300     
        Me.GridEmpleados.Columns("Telefono").HeaderText = "Teléfono"
        Me.GridEmpleados.Columns("Telefono").Width = 150
        Me.GridEmpleados.Columns("Celular").HeaderText = "Celular"
        Me.GridEmpleados.Columns("Celular").Width = 150
        Me.GridEmpleados.Columns("Cargo").HeaderText = "Cargo"
        Me.GridEmpleados.Columns("Cargo").Width = 150
        Me.GridEmpleados.Columns("Fecha").HeaderText = "Fecha"
        Me.GridEmpleados.Columns("Fecha").Width = 150
        Me.GridEmpleados.Columns("CI").Visible = False
        Me.GridEmpleados.Columns("idEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.GridEmpleados.Columns("Nacionalidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("CI2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("Telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("Celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.GridEmpleados.Columns("Cargo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.GridEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        CType(GridEmpleados.Columns("Foto"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
        For i = 0 To Me.GridEmpleados.RowCount - 1
            Me.GridEmpleados.Item("CI2", i).Value = ColocarPuntosCI(Me.GridEmpleados.Item("CI", i).Value.ToString)
        Next
    End Sub

    Private Sub ResaltarSeleccionado()
        For i = 0 To GridEmpleados.RowCount - 1
            If (Me.GridEmpleados.Rows(i).Cells(0).Value.ToString = Me.LTitulo.Tag) Then
                Me.GridEmpleados.CurrentCell = Me.GridEmpleados.Rows(i).Cells(0)
            End If
        Next
    End Sub
    Private Sub InicializarForma()
        Me.TCodigo.Text = ""
        Me.TCedula.Text = ""
        Me.TNombre.Text = ""
        Me.TApellido.Text = ""
        Me.TTipo.Text = " "
        Me.FechaIng.Value = DateTime.Now()
        Me.CBActivo.Checked = True
        Me.CCargo.Text = ""
    End Sub
   

    Private Sub LlenarComboCargos()
        If aqui = False Then
            If Conectar2() Then
                Try
                    Adaptador = New SqlDataAdapter("SELECT  * FROM TCargosEmpleados WHERE  ORDER BY Cargo ASC", CNN2)
                    DataT = New DataTable
                    Adaptador.Fill(DataT)
                    Me.CCargo.DataSource = DataT
                    Me.CCargo.DisplayMember = "Cargo"
                    Me.CCargo.ValueMember = "Id"
                Catch ex As Exception
                    MessageBox.Show("Error al Cargar Datos de los Cargos..." & ControlChars.CrLf & ex.Message)
                    Desconectar2()
                End Try
            End If
            Desconectar2()
        End If
    End Sub
    Private Sub FBuscarClienteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aqui = True
        LlenarComboCargos()
        aqui = False
        InicializarForma()
        BuscarDatos()
        ResaltarSeleccionado()
        Me.TNombre.Focus()
    End Sub
    Private Sub BEmpleados_Click(sender As Object, e As EventArgs) Handles BEmpleados.Click, BEmpleados.Click
        BuscarDatos()
    End Sub
    Private Sub Selecionar_Click(sender As Object, e As EventArgs) Handles Selecionar.Click
        GridEmpleados_CellContentDoubleClick(Nothing, Nothing)
    End Sub
    Private Sub GridEmpleados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridEmpleados.CellContentDoubleClick
        If GridEmpleados.CurrentRow IsNot Nothing Then
            CodEmpleado = Trim(GridEmpleados.Rows(GridEmpleados.CurrentRow.Index).Cells("idEmpleado").Value)
            Me.Close()
        End If
    End Sub

    Private Sub FInventarioNivelar_KeyDown(sender As Object, e As KeyEventArgs) Handles GridEmpleados.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                GridEmpleados_CellContentDoubleClick(Nothing, Nothing)
            Case Keys.Escape
                Me.TCedula.SelectionStart = 0
                Me.TCedula.SelectionLength = Me.TCedula.Text.Length
                Me.TCedula.Focus()
        End Select
    End Sub
    Private Sub TCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCedula.KeyPress
        e.Handled = txtNumerico(TCedula, e.KeyChar, False)
    End Sub
    Private Sub TCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress
        e.Handled = txtNumerico(TCodigo, e.KeyChar, False)
    End Sub
  
 Private Sub TCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TCodigo.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatos()
        End Select
    End Sub
    Private Sub TCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles TCedula.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatos()
        End Select
    End Sub

    Private Sub Tnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatos()
        End Select
    End Sub
    Private Sub TApellido_KeyDown(sender As Object, e As KeyEventArgs) Handles TApellido.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                BuscarDatos()
        End Select
    End Sub
End Class