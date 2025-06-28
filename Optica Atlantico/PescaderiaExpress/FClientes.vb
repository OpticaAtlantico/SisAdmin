Imports System.Data.SqlClient
Imports System.Security.Policy

Public Class FClientes
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Fila As Integer
    Private DProv As DataTable
    Private AProv As SqlDataAdapter
    Dim Listo As Boolean = False
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If (CodCliente.ToString <> "") Then
            FFacturacion.TCI.Tag = CodCliente
            FFacturacion.TCI.Text = Me.TCI.Text
            FFacturacion.TRIF.Text = Me.TRIF.Text
            FFacturacion.TNombre.Text = Me.TNombre.Text
            FFacturacion.TDirecion.Text = IIf(Me.PtoOrdaz.Checked, "Pto. Ordaz", "San Félix") & " / " & Me.TDireccion.Text
            FFacturacion.TTelefono.Text = Me.TTelefono.Text & " / " & Me.TCelular.Text
        End If
        Me.Close()
    End Sub

    'Private Sub ActivarControles(Act As Boolean)
    '    Me.Primero.Enabled = Act
    '    Me.Anterior.Enabled = Act
    '    Me.Siguiente.Enabled = Act
    '    Me.Ultimo.Enabled = Act
    '    Me.Buscar.Enabled = Act
    'End Sub
    Private Sub ActivarControles2(Act As Boolean)
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

    Private Sub FClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Nuevo_Click(Nothing, Nothing)
            If Conectar() Then
                Adaptador = New SqlDataAdapter("Select * FROM TClientes", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                If DataT.Rows.Count > 0 Then
                    Nuevo_Click(Nothing, Nothing)
                    ActivarControles2(False)
                Else
                    Fila = -1
                    Nuevo_Click(Nothing, Nothing)
                End If
                Desconectar()
            End If
            Me.Fecha.Value = DateTime.Now()
            Select Case VarForma
                Case "Nombre"
                    Me.TCI.Text = FFacturacion.TCI.Text
                    Me.TNombre.Focus()               
                Case Else
                    Me.TCI.Focus()
            End Select
            Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos:" & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
            Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (Me.TNombre.Text <> "") Then
            If (CBEmpresa.Checked) Then
                If (Me.TEmpresa.Text = "") Then
                    MsgBox("Debe Ingresar el Nombre de la Empresa. ", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TEmpresa.Focus()
                    Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
                If (Me.TRIF.Text = "") Then
                    MsgBox("Debe Ingresar el R.I.F de la Empresa. ", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TRIF.Focus()
                    Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If
            If (Len(Me.TCI.Text) < 7) Then
                MsgBox("Cédula de identidad Incorrecta, por Favor Verifique. ", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.TCI.Focus()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            Else
                If (Mid(Me.TCI.Text, 1, 1) = "0") Then
                    MsgBox("Cédula de identidad Incorrecta, por Favor Verifique. ", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TCI.Focus()
                    Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If
            If (Mid(Me.TCI.Text, 1, 1) = "0") Then
                MsgBox("Cédula de identidad Incorrecta, por Favor Verifique. ", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.TCI.Focus()
                Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("INSERT INTO TClientes (Nombre, Descripcion,Zona, Direccion,Nacionalidad, CI, TipoRif, RIF, Empresa, DEmpresa, Telefono, Celular, Correo, PagWeb, Fecha, Activo, Excento, Usuario) VALUES(@Nombre, @Descripcion, @Zona, @Direccion, @Nacionalidad, @CI, @TipoRif, @RIF, @Empresa, @DEmpresa, @Telefono, @Celular, @Correo, @PagWeb, @Fecha, @Activo, @Excento, @Usuario)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Nombre", StrConv(Trim(Me.TNombre.Text), VbStrConv.ProperCase))) 'Trim(Me.TNombre.Text)))
                    Comando.Parameters.Add(New SqlParameter("@Descripcion", Me.TDescripcion.Text))
                    Comando.Parameters.Add(New SqlParameter("@Zona", Me.Zona.Tag))
                    Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                    Comando.Parameters.Add(New SqlParameter("@Nacionalidad", Me.CNacionalidad.Text))
                    Comando.Parameters.Add(New SqlParameter("@CI", Me.TCI.Text))
                    Comando.Parameters.Add(New SqlParameter("@TipoRif", Me.CTipoRif.Text))
                    Comando.Parameters.Add(New SqlParameter("@RIF", Me.TRIF.Text))
                    Comando.Parameters.Add(New SqlParameter("@Empresa", Me.CBEmpresa.Checked))
                    Comando.Parameters.Add(New SqlParameter("@DEmpresa", Me.TEmpresa.Text))
                    Comando.Parameters.Add(New SqlParameter("@Telefono", Me.TTelefono.Text))
                    Comando.Parameters.Add(New SqlParameter("@Celular", Me.TCelular.Text))
                    Comando.Parameters.Add(New SqlParameter("@Correo", Me.TCorreo.Text))
                    Comando.Parameters.Add(New SqlParameter("@PagWeb", Me.TPagWeb.Text))
                    Comando.Parameters.Add(New SqlParameter("@Fecha", Me.Fecha.Value))
                    Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))                    
                    Comando.Parameters.Add(New SqlParameter("@Excento", Me.CBExcento.Checked))                    
                    Comando.Parameters.Add(New SqlParameter("@Usuario", UsuarioActivo))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    ActivarControles2(False)
                    DataT = New DataTable
                    Adaptador.Fill(DataT)
                    Dim Fila As DataRow = DataT.Rows(DataT.Rows.Count - 1)
                    CodCliente = Trim(Fila("idCliente").ToString)
                    CedulaCliente = Trim(Fila("CI").ToString)
                    Desconectar()
                    MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                    Salir_Click(Nothing, Nothing)
                End If
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Cliente.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
        Else
            MsgBox("El Nombre del Cliente No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            Desconectar()
            Cursor = System.Windows.Forms.Cursors.Default
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Function ValidarEliminar()
        Dim Respuesta As Boolean = True
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select idCliente  FROM TVentas WHERE idCliente=" & Me.TCodigo.Text, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    Respuesta = False
                    Exit Try
                End If
                DR.Close()
                Comando.CommandText = "Select idCliente  FROM TCuentasXCobrar WHERE idCliente=" & Me.TCodigo.Text
                DR = Comando.ExecuteReader()
                If (DR.Read) Then
                    Respuesta = False
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Eliminar Clientes.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
        Return (Respuesta)
    End Function

    Function ClientesValidosAEliminar() As Boolean
        Dim Valor As Boolean = False
        Select Case Me.TCodigo.Text
            Case "1", "4458", "4762", "4763", "4764", "4765", "4767", "4766", "4455"
                Valor = False
            Case Else
                Valor = True
        End Select
        Return (Valor)
    End Function
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If (ClientesValidosAEliminar()) Then
            If MsgBox("Esta seguro que desea Eliminar el Cliente: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Cliente.") = vbYes Then
                If (Conectar()) Then
                    Try
                        Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Dim Comando As New SqlCommand("DELETE FROM TClientes WHERE idCliente=" & Me.TCodigo.Text, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()                       
                        Desconectar()
                        Nuevo_Click(Nothing, Nothing)
                    Catch ex As Exception
                        MsgBox("Este Cliente tiene Registros de Ventas o Pagos que No deben borrarse si desea que no aparesca en Listas solo Desactive la casilla " & Chr(34) & "ACTIVO" & Chr(34) & ".", MsgBoxStyle.Information, "MarSoft: Información.")
                        Desconectar()
                        Cursor = System.Windows.Forms.Cursors.Default
                    End Try
                End If
            End If
            Cursor = System.Windows.Forms.Cursors.Default
        Else
            MsgBox("Este Cliente Pertenece a Sistemas,  No Puede Ser Eliminado.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        If (Me.TCodigo.Text <> "1") Then
            Dim Clasi As String = ""
            If (Me.TCodigo.Text <> "") Then
                If (Me.TNombre.Text <> "") Then
                    If (Conectar()) Then
                        Try
                            Dim Comando As New SqlCommand("UPDATE TClientes SET Nombre=@Nombre,Zona=@Zona, Descripcion=@Descripcion, Direccion=@Direccion,Nacionalidad=@Nacionalidad, CI=@CI, TipoRif=@TipoRif, RIF=@RIF, Empresa=@Empresa, DEmpresa=@DEmpresa, Telefono=@Telefono, Celular=@Celular, Correo=@Correo, PagWeb=@PagWeb, Fecha=@Fecha, Activo=@Activo, Excento=@Excento WHERE idCliente=" & Me.TCodigo.Text, CNN)
                            Comando.Parameters.Add(New SqlParameter("@Nombre", StrConv(Trim(Me.TNombre.Text), VbStrConv.ProperCase))) ' Trim(Me.TNombre.Text)))
                            Comando.Parameters.Add(New SqlParameter("@Descripcion", Me.TDescripcion.Text))
                            Comando.Parameters.Add(New SqlParameter("@Zona", Me.Zona.Tag))
                            Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                            Comando.Parameters.Add(New SqlParameter("@Nacionalidad", Me.CNacionalidad.Text))
                            Comando.Parameters.Add(New SqlParameter("@CI", Me.TCI.Text))
                            Comando.Parameters.Add(New SqlParameter("@TipoRif", Me.CTipoRif.Text))
                            Comando.Parameters.Add(New SqlParameter("@RIF", Me.TRIF.Text))
                            Comando.Parameters.Add(New SqlParameter("@Empresa", Me.CBEmpresa.Checked))
                            Comando.Parameters.Add(New SqlParameter("@DEmpresa", Me.TEmpresa.Text))
                            Comando.Parameters.Add(New SqlParameter("@Telefono", Me.TTelefono.Text))
                            Comando.Parameters.Add(New SqlParameter("@Celular", Me.TCelular.Text))
                            Comando.Parameters.Add(New SqlParameter("@Correo", Me.TCorreo.Text))
                            Comando.Parameters.Add(New SqlParameter("@PagWeb", Me.TPagWeb.Text))
                            Comando.Parameters.Add(New SqlParameter("@Fecha", Me.Fecha.Value))
                            Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                            Comando.Parameters.Add(New SqlParameter("@Excento", Me.CBExcento.Checked))
                            Dim DR As SqlDataReader = Comando.ExecuteReader()
                            CodCliente = Me.TCodigo.Text
                            CedulaCliente = Me.TCI.Text
                            DR.Close()
                            Desconectar()
                            MsgBox("Los Datos Fueron Actualizados con Exito!!!")
                            Salir_Click(Nothing, Nothing)
                        Catch ex As Exception
                            MsgBox("Error al Editar Datos de Clientes.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                            Desconectar()
                            Cursor = System.Windows.Forms.Cursors.Default
                        End Try
                    End If
                Else
                    MsgBox("El Nombre del Cliente No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
                End If
            Else
                MsgBox("Este Cliente debe ser Guardado, antes de Editarse.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            MsgBox("Este Cliente No debe ser Modificado.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Me.TDescripcion.Text = ""
        Me.PtoOrdaz.Checked = True
        Me.Zona.Tag = "Pto Ordaz"
        Me.TDireccion.Text = ""
        Me.CNacionalidad.Text = "V"
        Me.TCI.Text = ""
        Me.CTipoRif.Text = "J"
        Me.TRIF.Text = ""
        Me.CBEmpresa.Checked = False
        Me.TEmpresa.Text = ""
        Me.TTelefono.Text = ""
        Me.TCelular.Text = ""
        Me.TCorreo.Text = ""
        Me.TPagWeb.Text = ""
        Me.Fecha.Value = Date.Now
        Me.TDescripcion.Text = ""
        Me.CBActivo.Checked = True
        Me.CBExcento.Checked = False      
        ActivarControles2(False)
        Me.TCodigo.Focus()
    End Sub

    Private Sub MostrarDatos(ByVal f As Integer)
        Dim uf As Integer = DataT.Rows.Count - 1
        If f < 0 OrElse uf < 0 Then Exit Sub
        Dim dr As DataRow = DataT.Rows(f)
        Me.TCodigo.Text = Trim(dr("idCliente").ToString)
        Me.TNombre.Text = Trim(dr("Nombre").ToString)
        Me.TDescripcion.Text = Trim(dr("Descripcion").ToString)
        If (Trim(dr("Zona").ToString) = "Pto Ordaz") Then
            Me.PtoOrdaz.Checked = True
            Me.Zona.Tag = "Pto Ordaz"
        Else
            Me.SanFelix.Checked = True
            Me.Zona.Tag = "Pto Ordaz"
        End If
        Me.TDireccion.Text = Trim(dr("Direccion").ToString)
        Me.CNacionalidad.Text = Trim(dr("Nacionalidad").ToString)
        Me.TCI.Text = dr("CI").ToString
        Me.TRIF.Text = Trim(dr("RIF").ToString)
        Me.CBEmpresa.Checked = dr("Empresa").ToString
        Me.TEmpresa.Text = Trim(dr("DEmpresa").ToString)
        Me.TTelefono.Text = Trim(dr("Telefono").ToString)
        Me.TCelular.Text = Trim(dr("Celular").ToString)
        Me.TCorreo.Text = Trim(dr("Correo").ToString)
        Me.TPagWeb.Text = Trim(dr("PagWeb").ToString)
        Me.Fecha.Value = dr("Fecha").ToString
        Me.CBActivo.Checked = dr("Activo").ToString
        Me.CBExcento.Checked = dr("Excento").ToString
     
        ActivarControles2(True)
    End Sub



    'Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click
    '    Fila = 0
    '    MostrarDatos(Fila)
    '    Me.TCodigo.SelectionStart = 0
    '    Me.TCodigo.SelectionLength = Me.TCodigo.Text.Length
    'End Sub

    'Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles Anterior.Click
    '    Fila = Fila - 1
    '    If Fila < 0 Then Fila = 0
    '    MostrarDatos(Fila)
    '    Me.TCodigo.SelectionStart = 0
    '    Me.TCodigo.SelectionLength = Me.TCodigo.Text.Length
    'End Sub

    'Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
    '    Dim uf As Integer = DataT.Rows.Count - 1
    '    Fila = Fila + 1
    '    If Fila > uf Then Fila = uf
    '    MostrarDatos(Fila)
    '    Me.TCodigo.SelectionStart = 0
    '    Me.TCodigo.SelectionLength = Me.TCodigo.Text.Length
    'End Sub

    'Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles Ultimo.Click
    '    Fila = DataT.Rows.Count - 1
    '    MostrarDatos(Fila)
    '    Me.TCodigo.SelectionStart = 0
    '    Me.TCodigo.SelectionLength = Me.TCodigo.Text.Length
    'End Sub

    'Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
    '    VarBuscar = "Clientes"
    '    FBuscargenerico.ShowDialog()
    'End Sub

    'Public Sub TCI_LostFocus(sender As Object, e As EventArgs) Handles TCI.LostFocus
    '    Try
    '        If (Me.TCI.Text <> "") Then
    '            If Conectar() Then
    '                Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE CI=" & Me.TCI.Text, CNN)
    '                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
    '                Do While DataReader.Read()
    '                    Me.TCodigo.Text = Trim(DataReader("idCliente").ToString)
    '                    Me.TNombre.Text = Trim(DataReader("Nombre").ToString)
    '                    Me.TDescripcion.Text = Trim(DataReader("Descripcion").ToString)
    '                    If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
    '                        Me.PtoOrdaz.Checked = True
    '                        Me.Zona.Tag = "Pto Ordaz"
    '                    Else
    '                        Me.SanFelix.Checked = True
    '                        Me.Zona.Tag = "Pto Ordaz"
    '                    End If
    '                    Me.TDireccion.Text = Trim(DataReader("Direccion").ToString)
    '                    Me.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
    '                    Me.TCI.Text = DataReader("CI").ToString
    '                    Me.TRIF.Text = Trim(DataReader("RIF").ToString)
    '                    Me.CBEmpresa.Checked = DataReader("Empresa").ToString
    '                    Me.TEmpresa.Text = Trim(DataReader("DEmpresa").ToString)
    '                    Me.TTelefono.Text = Trim(DataReader("Telefono").ToString)
    '                    Me.TCelular.Text = Trim(DataReader("Celular").ToString)
    '                    Me.TCorreo.Text = Trim(DataReader("Correo").ToString)
    '                    Me.TPagWeb.Text = Trim(DataReader("PagWeb").ToString)
    '                    Me.Fecha.Value = DataReader("Fecha").ToString
    '                    Me.CBActivo.Checked = DataReader("Activo").ToString
    '                    Me.CBExcento.Checked = DataReader("Excento").ToString
    '                    ActivarControles2(True)
    '                Loop
    '                DataReader.Close()
    '                Desconectar()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub TCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TNombre.Focus()
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
  

    Private Sub TCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCodigo.KeyPress
        e.Handled = txtNumerico(TCodigo, e.KeyChar, False)
    End Sub
    'Public Sub TCodigo_TextChanged(sender As Object, e As EventArgs) Handles TCodigo.TextChanged
    '    If (Listo = False) Then
    '        Try
    '            If (Me.TCodigo.Text <> "") Then
    '                If Conectar() Then
    '                    Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE idCliente=" & Me.TCodigo.Text, CNN)
    '                    Dim DataReader As SqlDataReader = Comando.ExecuteReader()
    '                    If (DataReader.Read()) Then
    '                        Me.TCodigo.Text = Trim(DataReader("idCliente").ToString)
    '                        Me.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
    '                        Listo = True
    '                        Me.TCI.Text = DataReader("CI").ToString
    '                        Me.TNombre.Text = Trim(DataReader("Nombre").ToString)
    '                        Listo = False
    '                        Me.TRIF.Text = Trim(DataReader("RIF").ToString)
    '                        Me.CBEmpresa.Checked = DataReader("Empresa").ToString
    '                        Me.TEmpresa.Text = Trim(DataReader("DEmpresa").ToString)
    '                        Me.CBActivo.Checked = DataReader("Activo").ToString
    '                        Me.CBExcento.Checked = DataReader("Excento").ToString
    '                        Me.TDescripcion.Text = Trim(DataReader("Descripcion").ToString)
    '                        If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
    '                            Me.PtoOrdaz.Checked = True
    '                            Me.Zona.Tag = "Pto Ordaz"
    '                        Else
    '                            Me.SanFelix.Checked = True
    '                            Me.Zona.Tag = "Pto Ordaz"
    '                        End If
    '                        Me.TDireccion.Text = Trim(DataReader("Direccion").ToString)
    '                        Me.TTelefono.Text = Trim(DataReader("Telefono").ToString)
    '                        Me.TCelular.Text = Trim(DataReader("Celular").ToString)
    '                        Me.TCorreo.Text = Trim(DataReader("Correo").ToString)
    '                        Me.TPagWeb.Text = Trim(DataReader("PagWeb").ToString)
    '                        Me.Fecha.Value = DataReader("Fecha").ToString
    '                        Me.CBAlqCC.Checked = DataReader("AqlCC").ToString
    '                        Me.CBAlqPunto.Checked = DataReader("AqlPunto").ToString
    '                        Me.TPPuntoAP.Text = DataReader("PPuntoAP").ToString
    '                        Me.CBVentaAlMayor.Checked = DataReader("VentaAlMayor").ToString
    '                        Me.CBListaNegra.Checked = DataReader("ListaNegra").ToString
    '                        Me.TComentarioListaNegra.Text = Trim(DataReader("ComentarioListaNegra").ToString)
    '                        ActivarControles2(True)
    '                    Else
    '                        Nuevo_Click(Nothing, Nothing)
    '                    End If
    '                    DataReader.Close()
    '                    Desconectar()
    '                End If
    '            Else
    '                Nuevo_Click(Nothing, Nothing)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    'End Sub

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
   

    Private Sub MostrarBancos()
        'If (Me.TCodigo.Text <> "") Then
        '    Me.GridClientes.Columns.Clear()
        '    Try
        '        If Conectar() Then
        '            AProv = New SqlDataAdapter("Select NumCta, TipoCta,Banco, Activo FROM VCtasBancarias WHERE idAsignado=" & Me.TCodigo.Text & " ORDER BY Banco ASC", CNN)
        '            DProv = New DataTable
        '            AProv.Fill(DProv)
        '            Me.GridClientes.DataSource = DProv
        '            Me.GridClientes.Columns("NumCta").HeaderText = "Número Cuenta"
        '            Me.GridClientes.Columns("NumCta").Width = 250
        '            Me.GridClientes.Columns("TipoCta").HeaderText = "Tipo Cta."
        '            Me.GridClientes.Columns("TipoCta").Width = 150
        '            Me.GridClientes.Columns("Banco").HeaderText = "Banco"
        '            Me.GridClientes.Columns("Banco").Width = 150
        '            Me.GridClientes.Columns("Activo").HeaderText = "Activo?"
        '            Me.GridClientes.Columns("Activo").Width = 80
        '            Me.GridClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '        End If
        '        Desconectar()
        '    Catch ex As Exception
        '        MessageBox.Show("ERROR Conectar o Recuperar los Datos de los Bancos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Desconectar()
        '    End Try
        'Else
        '    MessageBox.Show("Debe Seleccionar el Cliente. ", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    'Private Sub TapClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TapClientes.SelectedIndexChanged
    '    Select Case Me.TapClientes.SelectedTab.Name
    '        Case Me.TabBancos.Name
    '            MostrarBancos()
    '    End Select
    'End Sub


    Public Sub TCI_TextChanged(sender As Object, e As EventArgs) Handles TCI.TextChanged
        If (Listo = False) Then
            Try
                If (Me.TCI.Text <> "") Then
                    If Conectar() Then
                        '  Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE Nombre='" & Me.TNombre.Text & "' AND CI='" & Me.TCI.Text & "'", CNN)
                        Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE CI='" & Me.TCI.Text & "'", CNN)

                        Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                        If (DataReader.Read()) Then
                            Listo = True
                            Me.TCodigo.Text = Trim(DataReader("idCliente").ToString)
                            Me.TNombre.Text = Trim(DataReader("Nombre").ToString)
                            Listo = False
                            Me.TDescripcion.Text = Trim(DataReader("Descripcion").ToString)
                            If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
                                Me.PtoOrdaz.Checked = True
                                Me.Zona.Tag = "Pto Ordaz"
                            Else
                                Me.SanFelix.Checked = True
                                Me.Zona.Tag = "Pto Ordaz"
                            End If
                            Me.TDireccion.Text = Trim(DataReader("Direccion").ToString)
                            Me.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
                            '  Me.TCI.Text = DataReader("CI").ToString
                            Me.TRIF.Text = Trim(DataReader("RIF").ToString)
                            Me.CBEmpresa.Checked = DataReader("Empresa").ToString
                            Me.TEmpresa.Text = Trim(DataReader("DEmpresa").ToString)
                            Me.TTelefono.Text = Trim(DataReader("Telefono").ToString)
                            Me.TCelular.Text = Trim(DataReader("Celular").ToString)
                            Me.TCorreo.Text = Trim(DataReader("Correo").ToString)
                            Me.TPagWeb.Text = Trim(DataReader("PagWeb").ToString)
                            Me.Fecha.Value = DataReader("Fecha").ToString
                            Me.CBActivo.Checked = DataReader("Activo").ToString
                            Me.CBExcento.Checked = DataReader("Excento").ToString
                            
                            MonedaBase = DataReader("MonedaBase").ToString
                            ActivarControles2(True)
                        Else
                            Listo = True
                            Me.TCodigo.Text = ""
                            Me.TNombre.Text = ""
                            Me.TDescripcion.Text = ""
                            Me.PtoOrdaz.Checked = True
                            Me.Zona.Tag = "Pto Ordaz"
                            Me.TDireccion.Text = ""
                            Me.TRIF.Text = ""
                            Me.CBEmpresa.Checked = False
                            Me.TEmpresa.Text = ""
                            Me.TTelefono.Text = ""
                            Me.TCelular.Text = ""
                            Me.TCorreo.Text = ""
                            Me.TPagWeb.Text = ""
                            Me.Fecha.Value = Date.Now
                            Me.TDescripcion.Text = ""
                            Me.CBActivo.Checked = True
                            Me.CBExcento.Checked = False
                          
                            Listo = False
                            ActivarControles2(False)
                        End If
                        DataReader.Close()
                        Desconectar()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    'Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged
    '    If (Listo = False) Then
    '        Try
    '            If (Me.TNombre.Text <> "") Then
    '                If Conectar() Then
    '                    Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE Nombre='" & Me.TNombre.Text & "'", CNN)
    '                    Dim DataReader As SqlDataReader = Comando.ExecuteReader()
    '                    If (DataReader.Read()) Then
    '                        Listo = True
    '                        Me.TCI.Text = DataReader("CI").ToString
    '                        Me.TCodigo.Text = Trim(DataReader("idCliente").ToString)
    '                        Listo = False
    '                        Me.TDescripcion.Text = Trim(DataReader("Descripcion").ToString)
    '                        If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
    '                            Me.PtoOrdaz.Checked = True
    '                            Me.Zona.Tag = "Pto Ordaz"
    '                        Else
    '                            Me.SanFelix.Checked = True
    '                            Me.Zona.Tag = "Pto Ordaz"
    '                        End If
    '                        Me.TDireccion.Text = Trim(DataReader("Direccion").ToString)
    '                        Me.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
    '                        Me.TRIF.Text = Trim(DataReader("RIF").ToString)
    '                        Me.CBEmpresa.Checked = DataReader("Empresa").ToString
    '                        Me.TEmpresa.Text = Trim(DataReader("DEmpresa").ToString)
    '                        Me.TTelefono.Text = Trim(DataReader("Telefono").ToString)
    '                        Me.TCelular.Text = Trim(DataReader("Celular").ToString)
    '                        Me.TCorreo.Text = Trim(DataReader("Correo").ToString)
    '                        Me.TPagWeb.Text = Trim(DataReader("PagWeb").ToString)
    '                        Me.Fecha.Value = DataReader("Fecha").ToString
    '                        Me.CBActivo.Checked = DataReader("Activo").ToString
    '                        Me.CBExcento.Checked = DataReader("Excento").ToString
    '                        Me.CBAlqPunto.Checked = DataReader("AqlPunto").ToString
    '                        Me.TPPuntoAP.Text = DataReader("PPuntoAP").ToString
    '                        ActivarControles2(True)
    '                    Else
    '                        Listo = True
    '                        Me.TCodigo.Text = ""
    '                        Me.TDescripcion.Text = ""
    '                        Me.PtoOrdaz.Checked = True
    '                        Me.Zona.Tag = "Pto Ordaz"
    '                        Me.TDireccion.Text = ""
    '                        Me.TCI.Text = ""
    '                        Me.TRIF.Text = ""
    '                        Me.CBEmpresa.Checked = False
    '                        Me.TEmpresa.Text = ""
    '                        Me.TTelefono.Text = ""
    '                        Me.TCelular.Text = ""
    '                        Me.TCorreo.Text = ""
    '                        Me.TPagWeb.Text = ""
    '                        Me.Fecha.Value = Date.Now
    '                        Me.TDescripcion.Text = ""
    '                        Me.CBActivo.Checked = True
    '                        Me.CBExcento.Checked = False
    '                        Me.CBAlqCC.Checked = False
    '                        Me.CBAlqPunto.Checked = False
    '                        Me.TPPuntoAP.Text = ""
    '                        Listo = False
    '                    End If
    '                    DataReader.Close()
    '                    Desconectar()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    'End Sub

  
    Private Sub MostrarClienteporCodigo()
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE idCliente='" & CodCliente & "'", CNN)
                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                If (DataReader.Read()) Then
                    Listo = True
                    Me.TCodigo.Text = Trim(DataReader("idCliente").ToString)
                    Me.TCI.Text = Trim(DataReader("CI").ToString)
                    Me.TNombre.Text = Trim(DataReader("Nombre").ToString)
                    Listo = False
                    Me.TDescripcion.Text = Trim(DataReader("Descripcion").ToString)
                    If (Trim(DataReader("Zona").ToString) = "Pto Ordaz") Then
                        Me.PtoOrdaz.Checked = True
                        Me.Zona.Tag = "Pto Ordaz"
                    Else
                        Me.SanFelix.Checked = True
                        Me.Zona.Tag = "Pto Ordaz"
                    End If
                    Me.TDireccion.Text = Trim(DataReader("Direccion").ToString)
                    Me.CNacionalidad.Text = Trim(DataReader("Nacionalidad").ToString)
                    '  Me.TCI.Text = DataReader("CI").ToString
                    Me.CTipoRif.Text = Trim(DataReader("TipoRIF").ToString)
                    Me.TRIF.Text = Trim(DataReader("RIF").ToString)
                    Me.CBEmpresa.Checked = DataReader("Empresa").ToString
                    Me.TEmpresa.Text = Trim(DataReader("DEmpresa").ToString)
                    Me.TTelefono.Text = Trim(DataReader("Telefono").ToString)
                    Me.TCelular.Text = Trim(DataReader("Celular").ToString)
                    Me.TCorreo.Text = Trim(DataReader("Correo").ToString)
                    Me.TPagWeb.Text = Trim(DataReader("PagWeb").ToString)
                    Me.Fecha.Value = DataReader("Fecha").ToString
                    Me.CBActivo.Checked = DataReader("Activo").ToString
                    Me.CBExcento.Checked = DataReader("Excento").ToString
                  
                    MonedaBase = DataReader("MonedaBase").ToString
                    ActivarControles2(True)
                Else
                    Listo = True
                    Me.TCodigo.Text = ""
                    Me.TNombre.Text = ""
                    Me.TDescripcion.Text = ""
                    Me.PtoOrdaz.Checked = True
                    Me.Zona.Tag = "Pto Ordaz"
                    Me.TDireccion.Text = ""
                    Me.CTipoRif.Text = "J"
                    Me.TRIF.Text = ""
                    Me.CBEmpresa.Checked = False
                    Me.TEmpresa.Text = ""
                    Me.TTelefono.Text = ""
                    Me.TCelular.Text = ""
                    Me.TCorreo.Text = ""
                    Me.TPagWeb.Text = ""
                    Me.Fecha.Value = Date.Now
                    Me.TDescripcion.Text = ""
                    Me.CBActivo.Checked = True
                    Me.CBExcento.Checked = False
                   
                    Listo = False
                    ActivarControles2(False)
                End If
                DataReader.Close()
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    Private Sub MostrarCliente()
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT  * FROM TCliente WHERE idCliente=" & CodCliente, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    'Me.TCodigo.Text = DR("idProveedor")
                    'Me.TAlias.Text = DR("Alias")
                    'Me.TNombre.Text = DR("Nombre")
                    'Me.TRIF.Text = DR("Rif")
                    'Me.TDescripcion.Text = DR("Descripcion")
                    'Me.TDireccion.Text = DR("Direccion")
                    'Me.TTelefono.Text = DR("Telefono")
                    'Me.TCelular.Text = DR("Celular")
                    'Me.TCorreo.Text = DR("Correo")
                    'Me.TSitioWeb.Text = DR("SitioWeb")
                    'Me.Fecha.Value = DR("Fecha")
                    'Me.CBEfecExtAjeno.Checked = DR("EfecExtAjeno")
                    'Me.TPPago.Text = DR("Porc")
                    'Me.TPorcAlqExt.Text = DR("PorcRetorno")
                    'Me.CBForaneo.Checked = DR("Foraneo")
                    'Me.CBTransporte.Checked = DR("Transporte")
                    'Me.CBOtros.Checked = DR("Otros")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error de Datos..." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try

    End Sub

    Private Sub BBuscar_Click(sender As Object, e As EventArgs) Handles BBuscar.Click
        VarBuscar = "Clientes"
        FBuscarOrden.LTitulo.Text = "Listado Clientes."
        FBuscarClienteEmpleado.LTitulo.Tag = Me.TCodigo.Text
        FBuscarClienteEmpleado.ShowDialog()
        MostrarClienteporCodigo()
    End Sub

    Private Sub DGVProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        If e.KeyCode = 13 Then
            If (VarForma = "FCaja") Or (VarForma = "FCancelarFactura") Then
                If (Me.TNombre.Text <> "") Then
                    If (Me.TCodigo.Text = "") Then
                        Guardar_Click(Nothing, Nothing)
                    Else
                        Editar_Click(Nothing, Nothing)
                    End If
                    '   BAceptar_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub
    Private Sub TRIF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TRIF.KeyPress
        e.Handled = txtNumerico(TRIF, e.KeyChar, False)
    End Sub

    Private Sub BMonedaBase_Click(sender As Object, e As EventArgs)
        VarBuscar = "MonedaCliente"
        FBuscarOrden.LTitulo.Text = "Listado de Monedas."
        FBuscarOrden.LTitulo.Tag = 0
        FBuscarOrden.ShowDialog()
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress

        If Not (Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar)) Then
            If Not (Char.IsSeparator(e.KeyChar)) Then
                e.Handled = True
            End If
        End If
    End Sub
   
End Class