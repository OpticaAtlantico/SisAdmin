Imports System.Data.SqlClient
Public Class FCargoEmpleados
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim Aqui As Boolean = False
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.Editar.Enabled = False
        Me.Eliminar.Enabled = False
        Me.Guardar.Enabled = True
        Me.TCargo.Text = ""
        Me.TCargo.Tag = ""
        Me.TCargo.Focus()
    End Sub
    Private Sub FCargoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load 
        MostrarCargos()    
        Nuevo_Click(Nothing, Nothing)
    End Sub
    Private Sub MostrarCargos()
        If Aqui = False Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("SELECT  * FROM TCargosEmpleados ORDER BY Cargo ASC", CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    Me.GridCargo.Rows.Clear()
                    Do While DR.Read()
                        Me.GridCargo.Rows.Add(Me.GridCargo.RowCount + 1, DR("id"), DR("Cargo"))
                    Loop
                    DR.Close()
                    Desconectar()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al Mostrar los Datos de los Cargos de los Empleados. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Me.TCargo.Text <> "") Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("INSERT INTO TCargosEmpleados (Cargo) VALUES (@Cargo)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Cargo", Me.TCargo.Text))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarCargos()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Guardar los Datos de los Cargos de los Empleados. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        If (Me.TCargo.Text <> "") Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCargosEmpleados SET Cargo=@Cargo WHERE id=" & Me.TCargo.Tag, CNN)
                    Comando.Parameters.Add(New SqlParameter("@Cargo", Me.TCargo.Text))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarCargos()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Actualizar los Datos de los Cargos de los Empleados " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
        Else
            MsgBox("Debe Seleccionar el Cargo a Actualizar.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (Me.TCargo.Text <> "") Then
            If MsgBox("Esta seguro que desea Eliminar el Cargo: " & Me.TCargo.Text & "?", vbYesNo, "MarSoft: Eliminar Cargo.") = vbYes Then
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                If (Conectar()) Then
                    Try
                        Dim Comando As New SqlCommand("DELETE FROM TCargosEmpleados WHERE id=" & Me.TCargo.Tag, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()
                        Desconectar()
                        MostrarCargos()
                        Nuevo_Click(Nothing, Nothing)
                        Cursor = System.Windows.Forms.Cursors.Default
                    Catch ex As Exception
                        Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Error al Eliminar el Cargo.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                    End Try
                End If
            End If
        Else
            MsgBox("Debe Seleccionar la Cargo a Eliminar.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub
    Private Sub GridCargo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCargo.CellDoubleClick
        Me.TCargo.Text = Me.GridCargo.CurrentRow.Cells("Cargo").Value
        Me.TCargo.Tag = Me.GridCargo.CurrentRow.Cells("id").Value
        Me.Guardar.Enabled = False
        Me.Editar.Enabled = True
        Me.Eliminar.Enabled = True
    End Sub
End Class