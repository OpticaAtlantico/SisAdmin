Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class FEmpleados
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private DataT2 As DataTable
    Private Adaptador2 As SqlDataAdapter
    Private DataT3 As DataTable
    Private Adaptador3 As SqlDataAdapter
    Private DEmpleado As DataTable
    Private AEmpleado As SqlDataAdapter
    Private Fila As Integer
    Public Listo As Boolean = False
    Dim aqui As Boolean = False
    Private Sub ActivarControles2(Act As Boolean)
        If (Me.TCodigo.Text <> "") Then
            Me.Editar.Enabled = True
            Me.Guardar.Enabled = False
            Me.Eliminar.Enabled = True
            Me.Imprimir.Enabled = True
        Else
            Me.Editar.Enabled = False
            Me.Guardar.Enabled = True
            Me.Eliminar.Enabled = False
            Me.Imprimir.Enabled = False
        End If
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub MostrarDatos(ByVal f As Integer)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim uf As Integer = DataT.Rows.Count - 1
        If f < 0 OrElse uf < 0 Then Exit Sub
        Dim dr As DataRow = DataT.Rows(f)
        Me.TCodigo.Text = Trim(dr("idEmpleado").ToString)
        Me.TNombre.Text = Trim(dr("Nombre").ToString)
        Me.LEmpleado.Text = Me.TNombre.Text
        If (Trim(dr("Zona").ToString) = "Pto Ordaz") Then
            Me.PtoOrdaz.Checked = True
            Me.Zona.Tag = "Pto Ordaz"
        Else
            Me.SanFelix.Checked = True
            Me.Zona.Tag = "Pto Ordaz"
        End If
        Me.TDireccion.Text = Trim(dr("Direccion").ToString)
        Me.CNacionalidad.Text = Trim(dr("Nacionalidad").ToString)
        Listo = True
        Me.TCI.Text = dr("CI").ToString
        Listo = False
        Me.CCargo.Text = Trim(dr("Cargo").ToString)
        Me.TTelefono.Text = Trim(dr("Telefono").ToString)
        Me.TCelular.Text = Trim(dr("Celular").ToString)
        Me.TCorreo.Text = Trim(dr("Correo").ToString)
        Me.FechaIng.Value = dr("Fecha").ToString
        Me.CBActivo.Checked = dr("Activo").ToString
        Me.CCargo.Text = dr("Cargo").ToString
     
    
        Me.TContacto.Text = dr("Contacto").ToString
        Me.TTelfContacto.Text = dr("TelfContacto").ToString

        Me.FechaNac.Value = dr("FechaNac").ToString
        Me.TEdad.Text = dr("Edad").ToString
        Me.CEstadoCivil.Text = dr("EstadoCivil").ToString
        Me.THijos.Text = dr("Hijos").ToString
        Me.TParentesco.Text = dr("Parentesco").ToString
        ActivarControles2(True)
        Me.TCI.Focus()
      
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        FBuscarEmpleado.CBActivo.Checked = False
        FBuscarEmpleado.ShowDialog()
        Listo = False
        MostrarEmpleadoCodigo()

        If (Me.TCodigo.Text <> "") Then
            ActivarControles2(True)
        End If
    End Sub
    Private Sub LlenarComboCargos()
        If aqui = False Then
            If Conectar2() Then
                Try
                    Adaptador2 = New SqlDataAdapter("SELECT  * FROM TCargosEmpleados ORDER BY Cargo ASC", CNN2)
                    DataT2 = New DataTable
                    Adaptador2.Fill(DataT2)
                    Me.CCargo.DataSource = DataT2
                    Me.CCargo.DisplayMember = "Cargo"
                    Me.CCargo.ValueMember = "Id"
                Catch ex As Exception
                    MessageBox.Show("Error al Cargar Datos de los Cargos..." & ControlChars.CrLf & ex.Message)
                    Desconectar2()
                End Try
            End If
        End If
        Desconectar2()
    End Sub
    Private Sub FEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboCargos()
        Nuevo_Click(Nothing, Nothing)
        Me.FechaIng.Value = DateTime.Now()
        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
    End Sub
    Function ExisteCedula(CI As String) As Boolean
        Dim Valor As Boolean = False
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select CI FROM TEmpleado WHERE CI=@CI AND idEmpleado<>@idEmpleado", CNN)
                Comando.Parameters.Add(New SqlParameter("@CI", CI))
                Comando.Parameters.Add(New SqlParameter("@idEmpleado", Trim(Me.TCodigo.Text)))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Valor = True
                Else
                    Valor = False
                End If
                DR.Close()
                Desconectar()
            End If
        Catch ex As Exception
            Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Error al Verificar C.I. del Empleado.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try
        Return (Valor)
    End Function
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        Foto.BackgroundImage.Save(ms, Foto.BackgroundImage.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        If (ExisteCedula(Trim(Me.TCI.Text)) = False) Then
            If (Me.TNombre.Text <> "") Then
                Try
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("INSERT INTO TEmpleado (Nacionalidad, CI, Nombre,Zona, Direccion,idCargo, Telefono, Celular, Correo,  Fecha, Activo, GrupoSanguineo, Contacto, TelfContacto, FechaNac, Edad, EstadoCivil, Hijos, Parentesco, Foto, Asesor, Optometrista, Gerente, Marketing) VALUES(@Nacionalidad, @CI, @Nombre ,@Zona, @Direccion,@idCargo, @Telefono, @Celular, @Correo, @Fecha, @Activo, @GrupoSanguineo, @Contacto, @TelfContacto, @FechaNac, @Edad, @EstadoCivil, @Hijos, @Parentesco, @Foto, @Asesor, @Optometrista, @Gerente, @Marketing)", CNN)
                        Comando.Parameters.Add(New SqlParameter("@Nombre", StrConv(Trim(Me.TNombre.Text), VbStrConv.ProperCase)))
                        Comando.Parameters.Add(New SqlParameter("@Zona", Me.Zona.Tag))
                        Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                        Comando.Parameters.Add(New SqlParameter("@Nacionalidad", Me.CNacionalidad.Text))
                        Comando.Parameters.Add(New SqlParameter("@CI", Me.TCI.Text))
                        Comando.Parameters.Add(New SqlParameter("@idCargo", Me.CCargo.SelectedValue))
                        Comando.Parameters.Add(New SqlParameter("@Cargo", Me.CCargo.Text))
                        Comando.Parameters.Add(New SqlParameter("@Telefono", Me.TTelefono.Text))
                        Comando.Parameters.Add(New SqlParameter("@Celular", Me.TCelular.Text))
                        Comando.Parameters.Add(New SqlParameter("@Correo", Me.TCorreo.Text))
                        Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaIng.Value))
                        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                        Comando.Parameters.Add(New SqlParameter("@GrupoSanguineo", Me.TGrupoS.Text))
                        Comando.Parameters.Add(New SqlParameter("@Contacto", Me.TContacto.Text))
                        Comando.Parameters.Add(New SqlParameter("@TelfContacto", Me.TTelfContacto.Text))
                        Comando.Parameters.Add(New SqlParameter("@Foto", arrImage))
                        Comando.Parameters.Add(New SqlParameter("@FechaNac", Me.FechaNac.Value.Date))
                        Comando.Parameters.Add(New SqlParameter("@Edad", Me.TEdad.Text))
                        Comando.Parameters.Add(New SqlParameter("@EstadoCivil", Me.CEstadoCivil.Text))
                        Comando.Parameters.Add(New SqlParameter("@Hijos", Me.THijos.Text))
                        Comando.Parameters.Add(New SqlParameter("@Parentesco", Me.TParentesco.Text))

                        Comando.Parameters.Add(New SqlParameter("@Asesor", Me.CBAsesor.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Optometrista", Me.CBOpto.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Gerente", Me.CBGerente.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Marketing", Me.CBMarketing.Checked))


                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()
                        ActivarControles2(False)
                        Desconectar()                      
                        Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                        Nuevo_Click(Nothing, Nothing)
                    End If
                Catch ex As Exception
                    Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al Guardar los Datos del Empleado.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            Else
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("El Nombre del Empleado No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("Esta Cédula de Identidad Ya Existe.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (Me.TCodigo.Text <> "54") Then
            If MsgBox("Esta seguro que desea Eliminar este Empleado: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Empleado.") = vbYes Then
                If (Conectar()) Then
                    Try
                        Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Dim Comando As New SqlCommand("DELETE FROM TEmpleado WHERE idEmpleado=" & Me.TCodigo.Text, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()


                        If (System.IO.File.Exists(Direccion & "FotoEmpleados\" & Trim(Me.TCI.Text) & ".jpg")) Then
                            System.IO.File.Delete(Direccion & "FotoEmpleados\" & Trim(Me.TCI.Text) & ".jpg")
                        End If

                        Nuevo_Click(Nothing, Nothing)
                        ActivarControles2(False)
                        Desconectar()
                    Catch ex As Exception
                        MsgBox("Error al Eliminar Datos del Empleado.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                        Cursor = System.Windows.Forms.Cursors.Default
                    End Try
                End If
            End If
        Else
            MsgBox("Este Empleado No debe ser Eliminado.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Dim Cedula As String = ""
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        Foto.BackgroundImage.Save(ms, Foto.BackgroundImage.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        If (Me.TCodigo.Text <> "54") Then
            Dim Clasi As String = ""
            'If (ExisteCedula(Trim(Me.TCI.Text)) = False) Then
            If (Me.TCodigo.Text <> "") Then
                If (Me.TNombre.Text <> "") Then
                    If (Conectar()) Then
                        Try
                            Dim Comando As New SqlCommand("UPDATE TEmpleado SET Nacionalidad=@Nacionalidad, CI=@CI, Nombre=@Nombre, Zona=@Zona, Direccion=@Direccion, idCargo=@idCargo, Telefono=@Telefono, Celular=@Celular, Correo=@Correo, Fecha=@Fecha, Activo=@Activo, GrupoSanguineo=@GrupoSanguineo, Contacto=@Contacto, TelfContacto=@TelfContacto, FechaNac=@FechaNac, Edad=@Edad, EstadoCivil=@EstadoCivil, Hijos=@Hijos, Parentesco=@Parentesco, Foto=@Foto, Asesor=@Asesor, Optometrista=@Optometrista, Gerente=@Gerente, Marketing=@Marketing WHERE idEmpleado=" & Me.TCodigo.Text, CNN)
                            Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
                            Comando.Parameters.Add(New SqlParameter("@Zona", Me.Zona.Tag))
                            Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                            Comando.Parameters.Add(New SqlParameter("@Nacionalidad", Me.CNacionalidad.Text))
                            Comando.Parameters.Add(New SqlParameter("@CI", Me.TCI.Text))
                            Comando.Parameters.Add(New SqlParameter("@idCargo", Me.CCargo.SelectedValue))
                            Comando.Parameters.Add(New SqlParameter("@Telefono", Me.TTelefono.Text))
                            Comando.Parameters.Add(New SqlParameter("@Celular", Me.TCelular.Text))
                            Comando.Parameters.Add(New SqlParameter("@Correo", Me.TCorreo.Text))
                            Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaIng.Value))
                            Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                            Comando.Parameters.Add(New SqlParameter("@GrupoSanguineo", Me.TGrupoS.Text))
                            Comando.Parameters.Add(New SqlParameter("@Contacto", Me.TContacto.Text))
                            Comando.Parameters.Add(New SqlParameter("@TelfContacto", Me.TTelfContacto.Text))
                            Comando.Parameters.Add(New SqlParameter("@FechaNac", Me.FechaNac.Value.Date))
                            Comando.Parameters.Add(New SqlParameter("@Edad", Me.TEdad.Text))
                            Comando.Parameters.Add(New SqlParameter("@EstadoCivil", Me.CEstadoCivil.Text))
                            Comando.Parameters.Add(New SqlParameter("@Hijos", Me.THijos.Text))
                            Comando.Parameters.Add(New SqlParameter("@Parentesco", Me.TParentesco.Text))
                            Comando.Parameters.Add(New SqlParameter("@Foto", arrImage))
                            Comando.Parameters.Add(New SqlParameter("@Asesor", Me.CBAsesor.Checked))
                            Comando.Parameters.Add(New SqlParameter("@Optometrista", Me.CBOpto.Checked))
                            Comando.Parameters.Add(New SqlParameter("@Gerente", Me.CBGerente.Checked))
                            Comando.Parameters.Add(New SqlParameter("@Marketing", Me.CBMarketing.Checked))
                            Dim DR As SqlDataReader = Comando.ExecuteReader()
                            DR.Close()
                            Cedula = Me.TCI.Text
                            Desconectar()
                            MsgBox("Los Datos Fueron Actualizados con Exito!!!")
                        Catch ex As Exception
                            MsgBox("Error al Editar Datos de Empleados.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                            Cursor = System.Windows.Forms.Cursors.Default
                        End Try
                    End If
                Else
                    MsgBox("El Nombre del Empleado No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
                End If
            Else
                MsgBox("Este Empleado debe ser Guardado, antes de Editarse.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
            'Else
            '    Cursor = System.Windows.Forms.Cursors.Default
            '    MsgBox("Esta Cédula de Identidad Ya Existe.", MsgBoxStyle.Information, "MarSoft: Información.")
            'End If
        Else
            MsgBox("Este Empleado No debe Ser Modificdo.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Me.LEmpleado.Text = "Seleccione el Empleado"
        Me.PtoOrdaz.Checked = True
        Me.Zona.Tag = "Pto Ordaz"
        Me.TDireccion.Text = ""
        Me.CNacionalidad.Text = "V"
        Me.TCI.Text = ""
        Me.TTelefono.Text = ""
        Me.TCelular.Text = ""
        Me.TCorreo.Text = ""   
        Me.FechaIng.Value = Date.Now
        Me.CBActivo.Checked = True
        ActivarControles2(False)
        Me.TGrupoS.Text = ""
        Me.TContacto.Text = ""
        Me.TTelfContacto.Text = ""
        Me.FechaNac.Value = Date.Now
        Me.TEdad.Text = ""
        Me.CEstadoCivil.Text = ""
        Me.THijos.Text = ""
        Me.TParentesco.Text = ""
        Me.CBAsesor.Checked = False
        Me.CBOpto.Checked = False
        Me.CBGerente.Checked = False
        Me.CBMarketing.Checked = False
        Me.Foto.BackgroundImage = Me.FotoNew.BackgroundImage
        TabControl1.SelectedIndex = 0      
        Me.TCI.Focus()
    End Sub
    Private Sub TCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            MostrarEmpleado()
        Else
            e.Handled = txtNumerico(TCI, e.KeyChar, False)
        End If
    End Sub
    Private Sub PtoOrdaz_CheckedChanged(sender As Object, e As EventArgs) Handles PtoOrdaz.CheckedChanged
        If (Me.PtoOrdaz.Checked = True) Then
            Me.Zona.Tag = "Pto Ordaz"
        Else
            Me.Zona.Tag = "San Felix"
        End If
    End Sub
    Private Sub SanFelix_CheckedChanged(sender As Object, e As EventArgs) Handles SanFelix.CheckedChanged
        If (Me.PtoOrdaz.Checked = True) Then
            Me.Zona.Tag = "Pto Ordaz"
        Else
            Me.Zona.Tag = "San Felix"
        End If
    End Sub
    Private Sub TTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefono.KeyPress
        e.Handled = txtNumerico(TTelefono, e.KeyChar, False)
        If e.KeyChar <> Convert.ToChar(8) Then
            TTelefono.Text = ValidarTelefono(TTelefono.Text)
        End If
        TTelefono.SelectionStart = Len(TTelefono.Text)
    End Sub
    Private Sub TCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCelular.KeyPress
        e.Handled = txtNumerico(TCelular, e.KeyChar, False)
        If e.KeyChar <> Convert.ToChar(8) Then
            TCelular.Text = ValidarTelefono(TCelular.Text)
        End If
        TCelular.SelectionStart = Len(TCelular.Text)
    End Sub
    Private Sub MostrarEmpleadoCodigo()
        If (Listo = False) Then
            Try
                If Conectar() Then
                    Dim Comando As New SqlCommand("SELECT * FROM VEmpleado WHERE idEmpleado=" & CodEmpleado, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    If (DR.Read()) Then
                        Me.LEmpleado.Text = Me.TNombre.Text
                        Me.TCodigo.Text = DR("idEmpleado").ToString
                        Me.TNombre.Text = DR("Nombre").ToString
                        If (Trim(DR("Zona").ToString) = "Pto Ordaz") Then
                            Me.PtoOrdaz.Checked = True
                            Me.Zona.Tag = "Pto Ordaz"
                        Else
                            Me.SanFelix.Checked = True
                            Me.Zona.Tag = "Pto Ordaz"
                        End If
                        Me.TDireccion.Text = DR("Direccion").ToString
                        Me.CNacionalidad.Text = DR("Nacionalidad").ToString
                        Listo = True
                        Me.TCI.Text = DR("CI").ToString
                        Listo = False
                        Me.CCargo.Text = DR("Cargo").ToString
                        Me.TTelefono.Text = DR("Telefono").ToString
                        Me.TCelular.Text = DR("Celular").ToString
                        Me.TCorreo.Text = DR("Correo").ToString
                        Me.FechaIng.Value = DR("Fecha").ToString
                        Me.CBActivo.Checked = DR("Activo")
                        Me.TGrupoS.Text = DR("GrupoSanguineo").ToString
                        Me.TContacto.Text = DR("Contacto").ToString
                        Me.TTelfContacto.Text = DR("TelfContacto").ToString
                        Me.FechaNac.Value = DR("FechaNac").ToString
                        Me.TEdad.Text = DR("Edad").ToString
                        Me.CEstadoCivil.Text = DR("EstadoCivil").ToString
                        Me.THijos.Text = DR("Hijos").ToString
                        Me.TParentesco.Text = DR("Parentesco").ToString
                        Me.CBAsesor.Checked = DR("Asesor")
                        Me.CBOpto.Checked = DR("Optometrista")
                        Me.CBGerente.Checked = DR("Gerente")
                        Me.CBMarketing.Checked = DR("Marketing")
                        Dim ms As New System.IO.MemoryStream()
                        Dim imageBuffer() As Byte = CType(DR("Foto"), Byte())
                        ms = New System.IO.MemoryStream(imageBuffer)
                        Foto.BackgroundImage = Nothing
                        Foto.BackgroundImage = (Image.FromStream(ms))
                        Foto.BackgroundImageLayout = ImageLayout.Stretch
                        ActivarControles2(True)
                        Me.TCI.Focus()
                    Else
                        Me.TCodigo.Text = ""
                        Me.TNombre.Text = ""
                        Me.LEmpleado.Text = "Seleccione el Empleado"
                        Me.PtoOrdaz.Checked = True
                        Me.Zona.Tag = "Pto Ordaz"
                        Me.TDireccion.Text = ""
                        Me.TTelefono.Text = ""
                        Me.TCelular.Text = ""
                        Me.TCorreo.Text = ""
                        Me.FechaIng.Value = Date.Now
                        Me.CBActivo.Checked = True
                        Me.TGrupoS.Text = ""
                        Me.TContacto.Text = ""
                        Me.TTelfContacto.Text = ""
                        Me.Dialogo.FileName = "SinImagen"
                        Me.CBAsesor.Checked = False
                        Me.CBOpto.Checked = False
                        Me.CBGerente.Checked = False
                        Me.CBMarketing.Checked = False
                        ActivarControles2(False)
                        Me.TCI.Focus()
                    End If
                    DR.Close()
                    Desconectar()
                End If

            Catch ex As Exception
                MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub MostrarEmpleado()
        If (Listo = False) Then
            Try
                If (Me.TCI.Text <> "") Then
                    If Conectar() Then
                        Dim Comando As New SqlCommand("SELECT * FROM VEmpleado WHERE CI=" & Me.TCI.Text, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        If (DR.Read()) Then
                            Me.LEmpleado.Text = Me.TNombre.Text
                            Me.TCodigo.Text = DR("idEmpleado").ToString
                            Me.TNombre.Text = DR("Nombre").ToString
                            If (Trim(DR("Zona").ToString) = "Pto Ordaz") Then
                                Me.PtoOrdaz.Checked = True
                                Me.Zona.Tag = "Pto Ordaz"
                            Else
                                Me.SanFelix.Checked = True
                                Me.Zona.Tag = "Pto Ordaz"
                            End If
                            Me.TDireccion.Text = DR("Direccion").ToString
                            Me.CNacionalidad.Text = DR("Nacionalidad").ToString
                            Listo = True
                            Me.TCI.Text = DR("CI").ToString
                            Listo = False
                            Me.CCargo.Text = DR("Cargo").ToString
                            Me.TTelefono.Text = DR("Telefono").ToString
                            Me.TCelular.Text = DR("Celular").ToString
                            Me.TCorreo.Text = DR("Correo").ToString
                            Me.FechaIng.Value = DR("Fecha").ToString
                            Me.CBActivo.Checked = DR("Activo")
                            Me.TGrupoS.Text = DR("GrupoSanguineo").ToString
                            Me.TContacto.Text = DR("Contacto").ToString
                            Me.TTelfContacto.Text = DR("TelfContacto").ToString
                            Me.FechaNac.Value = DR("FechaNac").ToString
                            Me.TEdad.Text = DR("Edad").ToString
                            Me.CEstadoCivil.Text = DR("EstadoCivil").ToString
                            Me.THijos.Text = DR("Hijos").ToString
                            Me.TParentesco.Text = DR("Parentesco").ToString
                            Dim ms As New System.IO.MemoryStream()
                            Dim imageBuffer() As Byte = CType(DR("Foto"), Byte())
                            ms = New System.IO.MemoryStream(imageBuffer)
                            Foto.BackgroundImage = Nothing
                            Foto.BackgroundImage = (Image.FromStream(ms))
                            Foto.BackgroundImageLayout = ImageLayout.Stretch
                            ActivarControles2(True)
                            Me.TCI.Focus()
                        Else
                            Me.TCodigo.Text = ""
                            Me.TNombre.Text = ""
                            Me.LEmpleado.Text = "Seleccione el Empleado"
                            Me.PtoOrdaz.Checked = True
                            Me.Zona.Tag = "Pto Ordaz"
                            Me.TDireccion.Text = ""
                            Me.TTelefono.Text = ""
                            Me.TCelular.Text = ""
                            Me.TCorreo.Text = ""
                            Me.FechaIng.Value = Date.Now
                            Me.CBActivo.Checked = True
                            Me.TGrupoS.Text = ""
                            Me.TContacto.Text = ""
                            Me.TTelfContacto.Text = ""
                            Me.Dialogo.FileName = "SinImagen"
                            ActivarControles2(False)
                            Me.TCI.Focus()
                        End If
                        DR.Close()
                        Desconectar()
                    End If
                Else
                    Nuevo_Click(Nothing, Nothing)
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Me.Dialogo.CheckFileExists = True
        Me.Dialogo.ShowReadOnly = False
        Me.Dialogo.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
        If Me.Dialogo.ShowDialog = DialogResult.OK Then
            Me.Foto.BackgroundImage = Image.FromFile(Me.Dialogo.FileName)
        End If
    End Sub

    Private Sub BQuitar_Click(sender As Object, e As EventArgs) Handles BQuitar.Click
        Me.Foto.BackgroundImage = Me.FotoNew.BackgroundImage
    End Sub
    Private Sub FechaNac_LostFocus(sender As Object, e As EventArgs) Handles FechaNac.LostFocus
        Me.TEdad.Text = DateDiff(DateInterval.Year, Me.FechaNac.Value, DateTime.Now.Date)
    End Sub
    Private Sub BCargaos_Click(sender As Object, e As EventArgs) Handles BCargaos.Click
        FCargoEmpleados.ShowDialog()
        LlenarComboCargos()
    End Sub
End Class