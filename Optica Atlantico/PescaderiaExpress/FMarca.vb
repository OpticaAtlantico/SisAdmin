Imports System.Data.SqlClient

Public Class FMarca
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Fila As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub ActivarControles(Act As Boolean)
        If (Act) Then
            Me.Editar.Enabled = True
            Me.Eliminar.Enabled = True
            Me.Guardar.Enabled = False
        Else
            Me.Editar.Enabled = False
            Me.Eliminar.Enabled = False
            Me.Guardar.Enabled = True
        End If
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim Clasi As String = ""
        If (Me.TCodigo.Text = "") Then
            If (Me.TNombre.Text <> "") Then
                If Conectar2() Then
                    Try
                        Dim Comando2 As New SqlCommand("Select id FROM TMarca WHERE Marca='" & Me.TNombre.Text & "'", CNN2)
                        Dim DatosCat As SqlDataReader = Comando2.ExecuteReader()
                        If (DatosCat.Read() = True) Then
                            MsgBox("Ya Existe una Marca con el Nombre: " & Me.TNombre.Text, MsgBoxStyle.Information, "MarSoft: Información.")
                        Else
                            If (Conectar()) Then
                                Dim Comando As New SqlCommand("INSERT INTO TMarca (Marca, Descripcion, Activo) VALUES(@Marca, @Descripcion, @Activo)", CNN)
                                Comando.Parameters.Add(New SqlParameter("@Marca", Trim(Me.TNombre.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Descripcion", Me.TDescripcion.Text))
                                Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                                Dim DR As SqlDataReader = Comando.ExecuteReader()
                                DR.Close()
                                Nuevo_Click(Nothing, Nothing)
                                MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                                Desconectar()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Error al Guardar los Datos de la Marca.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    End Try
                End If
                Desconectar2()
            Else
                MsgBox("El Nombre de la Marca No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            MsgBox("Esta Marca ya Existe, Pulse el botón Editar para Guardar Cambios o el botón Nuevo para crear un Nuevo Local.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MsgBox("Esta seguro que desea Eliminar esta Marca: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Marca.") = vbYes Then
            If (Conectar()) Then
                Try
                    Dim Comando As New SqlCommand("DELETE FROM TMarca WHERE id=" & Me.TCodigo.Text, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Nuevo_Click(Nothing, Nothing)
                    Desconectar()
                Catch ex As Exception
                    MsgBox("Error al Eliminar Datos de la Marca.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                End Try
            End If
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        If (Me.TCodigo.Text <> "") Then
            If (Me.TNombre.Text <> "") Then
                If (Conectar()) Then
                    Try
                        Dim Comando As New SqlCommand("UPDATE TMarca SET Marca=@Marca, Descripcion=@Descripcion, Activo=@Activo WHERE id=" & Me.TCodigo.Text, CNN)
                        Comando.Parameters.Add(New SqlParameter("@Marca", Trim(Me.TNombre.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Descripcion", Me.TDescripcion.Text))
                        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()
                        Desconectar()
                        MsgBox("Los Datos Fueron Editados con Exito!!!")
                    Catch ex As Exception
                        MsgBox("Error al Editar Datos de la Marca.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                    End Try

                End If
            Else
                MsgBox("El Nombre de la Marca No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If

        Else
            MsgBox("Esta Marca debe ser Guardado, antes de Editarse.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Me.TDescripcion.Text = ""
        Me.CBActivo.Checked = True
        ActivarControles(False)
        Me.TNombre.Focus()
    End Sub
    Private Sub FMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo_Click(Nothing, Nothing)
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        VarBuscar = "MarcasP"
        'FBuscarGenerico.LTitulo.Text = "Listado de Marcas."
        'FBuscarGenerico.LTitulo.Tag = Me.TCodigo.Text
        'FBuscarGenerico.ShowDialog()
        If (Me.TCodigo.Text <> "") Then
            ActivarControles(True)
        Else
            ActivarControles(False)
        End If
    End Sub
End Class