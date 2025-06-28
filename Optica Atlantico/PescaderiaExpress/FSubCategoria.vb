Imports System.Data.SqlClient
Public Class FSubCategoria
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TNombre.Text = ""
        Me.TNombre.Tag = ""
        Me.TNombre.Focus()
        Me.Guardar.Enabled = True
        Me.Editar.Enabled = False
        If (Me.CCategoria1.Text = "") Then
            MostrarSubCategorias()
        Else
            MostrarSubCategoriasSeleccionadas()
        End If
    End Sub
    Private Sub LlenarComboCategorias()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT  * FROM TCategoria ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CCategoria1.DataSource = DataT
                Me.CCategoria1.DisplayMember = "Nombre"
                Me.CCategoria1.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de las Categorias..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub FCategoriaTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo_Click(Nothing, Nothing)
        LlenarComboCategorias()
        MostrarSubCategorias()
    End Sub
    Private Sub MostrarSubCategorias()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT  * FROM VSubCategoria ORDER BY  Categoria, SubCategoria ASC", CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Me.GridCategoria.Rows.Clear()
                Do While DR.Read()
                    Me.GridCategoria.Rows.Add(Me.GridCategoria.RowCount + 1, DR("idCategoria"), DR("Categoria"), DR("idSubCategoria"), DR("SubCategoria"))
                Loop
                DR.Close()
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrarlos Datos de Sub-Categoria. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    Private Sub MostrarSubCategoriasSeleccionadas()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT  * FROM VSubCategoria where idCategoria=@idCategoria ORDER BY  Categoria, SubCategoria ASC", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCategoria", IIf(Me.CCategoria1.Text = "", 1, Me.CCategoria1.SelectedValue)))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Me.GridCategoria.Rows.Clear()
                Do While DR.Read()
                    Me.GridCategoria.Rows.Add(Me.GridCategoria.RowCount + 1, DR("idCategoria"), DR("Categoria"), DR("idSubCategoria"), DR("SubCategoria"))
                Loop
                DR.Close()
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrarlos Datos de Sub-Categoria. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (Me.TNombre.Text <> "") Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("INSERT INTO TSubCategoria (Nombre, idCategoria) VALUES (@Nombre, @idCategoria)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Nombre", Me.TNombre.Text))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", Me.CCategoria1.SelectedValue))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarSubCategoriasSeleccionadas()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Guardar los Datos de las Sub-Categorias. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        Else
            Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("El Nombre de la Sub-Categoria No debe Ser Vacio...", MsgBoxStyle.Information, "MarSoft: Información.")
            Me.TNombre.Focus()
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        If (Me.TNombre.Text <> "") Then
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TSubCategoriaGastos SET Nombre=@Nombre,idCategoria=@idCategoria WHERE id=" & Me.TNombre.Tag, CNN)
                    Comando.Parameters.Add(New SqlParameter("@Nombre", Me.TNombre.Text))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", Me.CCategoria1.SelectedValue))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Desconectar()
                    MostrarSubCategoriasSeleccionadas()
                    Nuevo_Click(Nothing, Nothing)
                    Cursor = System.Windows.Forms.Cursors.Default
                End If
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Actualizar los Datos de las Categorias. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
        Else
            MsgBox("Debe Seleccionar la Sub-Categoria a Actualizar.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (Me.TNombre.Tag = 1) Then
            MsgBox("La Sub-Categoria: " & Me.TNombre.Text & " No Puede Ser Eliminada, Pertenece al Sistema.", MsgBoxStyle.Information, "MarSoft: Información.")
        Else

            If (Me.TNombre.Text <> "") Then
                If MsgBox("Esta seguro que desea Eliminar la Sub-Categoria: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Sub-Categoria.") = vbYes Then
                    Cursor = System.Windows.Forms.Cursors.WaitCursor
                    If (Conectar()) Then
                        Try
                            Dim Comando As New SqlCommand("DELETE FROM TSubCategoria WHERE id=" & Me.TNombre.Tag, CNN)
                            Dim DR As SqlDataReader = Comando.ExecuteReader()
                            DR.Close()
                            Desconectar()
                            MostrarSubCategorias()
                            Nuevo_Click(Nothing, Nothing)
                            Cursor = System.Windows.Forms.Cursors.Default
                        Catch ex As Exception
                            Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Error al Eliminar las Sub-Categorias.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                        End Try
                    End If
                End If
            Else
                MsgBox("Debe Seleccionar la Sub-Categoria a Eliminar.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        End If
    End Sub
    Private Sub GridCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCategoria.CellClick
        Me.TNombre.Text = Me.GridCategoria.CurrentRow.Cells("SubCategoria").Value
        Me.TNombre.Tag = Me.GridCategoria.CurrentRow.Cells("idSubCategoria").Value
        Me.CCategoria1.Text = Me.GridCategoria.CurrentRow.Cells("Categoria").Value
        Me.Guardar.Enabled = False
        Me.Editar.Enabled = True
    End Sub
    Private Sub CCategoria1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CCategoria1.SelectedIndexChanged
        If (Me.CCategoria1.Text = "") Then
            MostrarSubCategorias()
        Else
            MostrarSubCategoriasSeleccionadas()
        End If
    End Sub

    Private Sub GridCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCategoria.CellContentClick

    End Sub
End Class