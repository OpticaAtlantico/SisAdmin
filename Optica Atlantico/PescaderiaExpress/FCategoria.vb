Imports System.Data.SqlClient
Public Class FCategoria
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TNombre.Text = ""
        Me.TNombre.Tag = ""
        Me.TNombre.Focus()
        Me.Guardar.Enabled = True
        Me.Editar.Enabled = False
    End Sub
    Private Sub FCategoriaTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo_Click(Nothing, Nothing)
        MostrarCategorias()
    End Sub
    Private Sub MostrarCategorias()
        Select Case VarForma
            Case "Prod", "ModuloProd"
                Me.Text = "MarSoft: Categorias de Tareas."
                Try
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("SELECT  * FROM TCategoria ORDER BY Nombre ASC", CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        Me.GridCategoria.Rows.Clear()
                        Dim I As Int16 = 1
                        Do While DR.Read()
                            Me.GridCategoria.Rows.Add(I, DR("id"), DR("Nombre"))
                            I = I + 1
                        Loop
                        DR.Close()
                        Desconectar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR al Mostrar los Datos de Categoria. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Desconectar()
                End Try

        End Select
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Me.TNombre.Text <> "") Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("INSERT INTO TCategoria (Nombre) VALUES (@Nombre)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Nombre", Me.TNombre.Text))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarCategorias()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Guardar los Datos de las Categorias. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
            Cursor = System.Windows.Forms.Cursors.Default
        Else
            MsgBox("El Nombre de la Categoria No debe Ser Vacio...", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
            Me.TNombre.Focus()
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        If (Me.TNombre.Text <> "") Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCategoria SET Nombre=@Nombre WHERE id=" & Me.TNombre.Tag, CNN)
                    Comando.Parameters.Add(New SqlParameter("@Nombre", Me.TNombre.Text))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarCategorias()
                    Nuevo_Click(Nothing, Nothing)
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Actualizar los Datos de las Categorias. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
            Cursor = System.Windows.Forms.Cursors.Default
        Else
            MsgBox("Debe Seleccionar la Categoria a Actualizar.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (Me.TNombre.Tag = 1) Then
            MsgBox("La Categoria: " & Me.TNombre.Text & " No Puede Ser Eliminada, Pertenece al Sistema.", MsgBoxStyle.Information, "MarSoft: Información.")
        Else
            If (Me.TNombre.Text <> "") Then
                If MsgBox("Esta seguro que desea Eliminar la Categoria: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Categoria.") = vbYes Then
                    Cursor = System.Windows.Forms.Cursors.WaitCursor
                    If (Conectar()) Then
                        Try
                            Dim Comando As New SqlCommand("DELETE FROM TCategoria WHERE id=" & Me.TNombre.Tag, CNN)
                            Dim DR As SqlDataReader = Comando.ExecuteReader()
                            DR.Close()
                        Catch ex As Exception
                            Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Error al Eliminar la Categoria.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                        End Try
                    End If
                    Desconectar()
                    MostrarCategorias()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Else
                MsgBox("Debe Seleccionar la Categoria a Eliminar.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        End If
    End Sub

    Private Sub GridCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCategoria.CellClick
        Me.TNombre.Text = Me.GridCategoria.CurrentRow.Cells(2).Value
        Me.TNombre.Tag = Me.GridCategoria.CurrentRow.Cells(1).Value
        Me.Guardar.Enabled = False
        Me.Editar.Enabled = True
    End Sub
End Class