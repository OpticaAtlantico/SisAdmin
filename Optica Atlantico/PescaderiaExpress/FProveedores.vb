Imports System.Data.SqlClient

Public Class FProveedores
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Fila As Integer
    Private DataTP As DataTable
    Private AdaptadorP As SqlDataAdapter
    Private FilaP As Integer
    Private DProv As DataTable
    Private AProv As SqlDataAdapter
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
    'Private Sub TNombre_Click(sender As Object, e As EventArgs) Handles TNombre.Click
    '    'FTecladoI.ShowDialog()
    '    'Me.TNombre.Text = TextoEscrito
    '    'Me.TNombre.SelectionStart = TNombre.Text.Length
    '    'Me.TNombre.SelectionLength = TNombre.Text.Length
    'End Sub

    'Private Sub LlenarBancos()
    '    Try
    '        If Conectar() Then
    '            Dim Comando As New SqlCommand("SELECT  Nombre FROM TBancos ORDER BY Nombre", CNN)
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            Me.CBanco.Items.Clear()
    '            Do While DR.Read()
    '                Me.CBanco.Items.Add(Trim(DR(0)))
    '            Loop
    '            If (Me.CBanco.Items.Count > 0) Then
    '                Me.CBanco.SelectedIndex = 0
    '            End If
    '            DR.Close()
    '            Me.CTipo.SelectedIndex = 0
    '        End If
    '        Desconectar()
    '    Catch ex As Exception
    '        MsgBox("Error de Datos..." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '        Desconectar()
    '    End Try
    'End Sub
    Private Sub FInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Conectar() Then
        '    Try
        '        Adaptador = New SqlDataAdapter("Select * FROM TProveedor", CNN)
        '        DataT = New DataTable
        '        Adaptador.Fill(DataT)
        '        If DataT.Rows.Count > 0 Then
        '            ActivarControles(True)
        '            Nuevo_Click(Nothing, Nothing)
        '        Else
        '            Fila = -1
        '            ActivarControles(False)
        '            Nuevo_Click(Nothing, Nothing)
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
        '        Desconectar()
        '    End Try
        'End If

        Nuevo_Click(Nothing, Nothing)
        Me.Fecha.Value = DateTime.Now()
        Desconectar()
        VarForma = "GeneralProveedores"
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Me.TCodigo.Text = "") Then
            If (Me.TNombre.Text <> "") Then
                If Conectar2() Then
                    Try
                        Dim Comando2 As New SqlCommand("SELECT idProveedor FROM TProveedor WHERE Nombre='" & Me.TNombre.Text & "'", CNN2)
                        Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
                        If (DatosArt.Read() = True) Then
                            MsgBox("Ya Existe un Proveedor con este Nombre: " & Me.TNombre.Text, MsgBoxStyle.Information, "MarSoft: Información.")
                            Me.TNombre.Focus()
                        Else
                            If (Conectar()) Then
                                Dim Comando As New SqlCommand("INSERT INTO TProveedor (Nombre, Rif, Descripcion, Direccion, Telefono, Celular, Correo, SitioWeb, Fecha, Alias, EfecExtAjeno,AlqPuntoExt, Porc,PorcRetorno, Activo, Foraneo, Transporte, Otros, ContactoProv) VALUES(@Nombre, @Rif, @Descripcion, @Direccion, @Telefono, @Celular, @Correo, @SitioWeb, @Fecha, @Alias, @EfecExtAjeno,@AlqPuntoExt, @Porc,@PorcRetorno, @Activo, @Foraneo, @Transporte,@Otros, @ContactoProv)", CNN)
                                Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Rif", Trim(Me.TRif.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Descripcion", Trim(Me.TDescripcion.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                                Comando.Parameters.Add(New SqlParameter("@Telefono", Trim(Me.TTelefono.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Celular", Trim(Me.TCelular.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Correo", Trim(Me.TCorreo.Text)))
                                Comando.Parameters.Add(New SqlParameter("@SitioWeb", Trim(Me.TSitioWeb.Text)))
                                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.Fecha.Value))
                                If (Me.TAlias.Text = "") Then
                                    Me.TAlias.Text = Me.TNombre.Text
                                End If
                                Comando.Parameters.Add(New SqlParameter("@Alias", Me.TAlias.Text))
                                Comando.Parameters.Add(New SqlParameter("@EfecExtAjeno", Me.CBEfecExtAjeno.Checked))
                                Comando.Parameters.Add(New SqlParameter("@AlqPuntoExt", Me.CHAlqPuntoExt.Checked))
                                Comando.Parameters.Add(New SqlParameter("@Porc", Convert.ToDecimal(IIf(Me.TPPago.Text = "", 0, Me.TPPago.Text))))
                                Comando.Parameters.Add(New SqlParameter("@PorcRetorno", Convert.ToDecimal(IIf(Me.TPorcAlqExt.Text = "", 0, Me.TPorcAlqExt.Text))))
                                Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                                Comando.Parameters.Add(New SqlParameter("@Foraneo", Me.CBForaneo.Checked))
                                Comando.Parameters.Add(New SqlParameter("@Transporte", Me.CBTransporte.Checked))
                                Comando.Parameters.Add(New SqlParameter("@Otros", Me.CBOtros.Checked))
                                Comando.Parameters.Add(New SqlParameter("@ContactoProv", Trim(Me.TContacto.Text)))
                                Dim DR As SqlDataReader = Comando.ExecuteReader()
                                DR.Close()
                                Nuevo_Click(Nothing, Nothing)
                                MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                            End If
                            Desconectar()
                        End If
                        DatosArt.Close()
                        Desconectar2()
                    Catch ex As Exception
                        MsgBox("Error al Guardar los Datos del Proveedor..  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                        Desconectar2()
                    End Try
                End If
            Else
                MsgBox("El Nombre del Proveedor No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            MsgBox("Este Proveedor ya Existe, Pulse el botón Editar para Guardar Cambios o el botón Nuevo para crear un Nuevo Proveedor.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        If (Me.TCodigo.Text <> "") Then
            If (Me.TNombre.Text <> "") Then
                Try
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("UPDATE TProveedor set  Nombre=@Nombre, Rif=@Rif, Descripcion=@Descripcion, Direccion=@Direccion, Telefono=@Telefono, Celular=@Celular, Correo=@Correo, SitioWeb=@SitioWeb,Fecha=@Fecha,Alias=@Alias, EfecExtAjeno=@EfecExtAjeno,AlqPuntoExt=@AlqPuntoExt, Porc=@Porc,PorcRetorno=@PorcRetorno, Activo=@Activo, Foraneo=@Foraneo, Transporte=@Transporte, Otros=@Otros, ContactoProv=@ContactoProv WHERE idProveedor=" & Me.TCodigo.Text, CNN)
                        Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Rif", Trim(Me.TRif.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Descripcion", Trim(Me.TDescripcion.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Direccion", Me.TDireccion.Text))
                        Comando.Parameters.Add(New SqlParameter("@Telefono", Trim(Me.TTelefono.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Celular", Trim(Me.TCelular.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Correo", Trim(Me.TCorreo.Text)))
                        Comando.Parameters.Add(New SqlParameter("@SitioWeb", Trim(Me.TSitioWeb.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Fecha", Me.Fecha.Value))
                        Comando.Parameters.Add(New SqlParameter("@Alias", Me.TAlias.Text))
                        Comando.Parameters.Add(New SqlParameter("@EfecExtAjeno", Me.CBEfecExtAjeno.Checked))
                        Comando.Parameters.Add(New SqlParameter("@AlqPuntoExt", Me.CHAlqPuntoExt.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Porc", Convert.ToDecimal(IIf(Me.TPPago.Text = "", 0, Me.TPPago.Text))))
                        Comando.Parameters.Add(New SqlParameter("@PorcRetorno", Convert.ToDecimal(IIf(Me.TPorcAlqExt.Text = "", 0, Me.TPorcAlqExt.Text))))
                        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Foraneo", Me.CBForaneo.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Transporte", Me.CBTransporte.Checked))
                        Comando.Parameters.Add(New SqlParameter("@Otros", Me.CBOtros.Checked))
                        Comando.Parameters.Add(New SqlParameter("@ContactoProv", Trim(Me.TContacto.Text)))
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()
                        'DataT = New DataTable
                        'Adaptador.Fill(DataT)
                        'MostrarDatos(Fila)
                        'Desconectar()
                        MsgBox("Los Datos Fueron Editados con Exito!!!")
                        Desconectar()
                    End If
                Catch ex As Exception
                    MsgBox("Error al Editar Datos de Proveedor.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            Else
                MsgBox("El Nombre del Proveedor No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
        Else
            MsgBox("Este Proveedor debe ser Guardado antes de Editarse.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MsgBox("Esta seguro que desea Eliminar este Proveedor: " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Proveedor.") = vbYes Then
            If (Conectar()) Then
                Try
                    Dim Comando As New SqlCommand("DELETE FROM TProveedor WHERE idProveedor=" & Me.TCodigo.Text, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Nuevo_Click(Nothing, Nothing)
                    Desconectar()
                Catch ex As Exception
                    MsgBox("Error al Eliminar Datos Proveedor.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            End If
        End If
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Me.TAlias.Text = ""
        Me.TRif.Text = ""
        Me.TDescripcion.Text = ""
        Me.TDireccion.Text = ""
        Me.TTelefono.Text = ""
        Me.TCelular.Text = ""
        Me.TCorreo.Text = ""
        Me.TSitioWeb.Text = ""
        Me.CBEfecExtAjeno.Checked = False
        Me.CHAlqPuntoExt.Checked = False
        Me.TPPago.Text = ""
        Me.TPorcAlqExt.Text = ""
        Me.TContacto.Text = ""
        Me.CBForaneo.Checked = False
        Me.Fecha.Value = Date.Now
        Me.TNombre.Focus()
        Me.CBActivo.Checked = True
        ActivarControles(False)
    End Sub

    Private Sub MostrarDatos(ByVal f As Integer)
        Dim uf As Integer = DataT.Rows.Count - 1
        If f < 0 OrElse uf < 0 Then Exit Sub
        Dim dr As DataRow = DataT.Rows(f)
        Me.TCodigo.Text = Trim(dr("idProveedor").ToString)
        Me.TNombre.Text = Trim(dr("Nombre").ToString)
        Me.TRif.Text = Trim(dr("Rif").ToString)
        Me.TDescripcion.Text = Trim(dr("Descripcion").ToString)
        Me.TDireccion.Text = Trim(dr("Direccion").ToString)
        Me.TTelefono.Text = Trim(dr("Telefono").ToString)
        Me.TCelular.Text = Trim(dr("Celular").ToString)
        Me.TCorreo.Text = Trim(dr("Correo").ToString)
        Me.TSitioWeb.Text = Trim(dr("SitioWeb").ToString)
        Me.Fecha.Value = dr("Fecha").ToString
        Me.TAlias.Text = Trim(dr("Alias").ToString)
        Me.CBEfecExtAjeno.Checked = dr("EfecExtAjeno").ToString
        Me.CHAlqPuntoExt.Checked = dr("AlqPuntoExt").ToString
        Me.TPPago.Text = dr("Porc").ToString
        Me.TPorcAlqExt.Text = dr("PorcRetorno").ToString
        Me.CBActivo.Checked = dr("Activo").ToString
        Me.CBForaneo.Checked = dr("Foraneo").ToString
        Me.CBTransporte.Checked = dr("Transporte").ToString
        Me.CBOtros.Checked = dr("Otros").ToString
        Me.TContacto.Text = dr("ContactoProv").ToString
        Me.Editar.Enabled = True
    End Sub
    Private Sub Primero_Click(sender As Object, e As EventArgs)
        Fila = 0
        MostrarDatos(Fila)
        Me.TNombre.SelectionStart = 0
        Me.TNombre.SelectionLength = Me.TNombre.Text.Length
    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs)
        Fila = Fila - 1
        If Fila < 0 Then Fila = 0
        MostrarDatos(Fila)
        Me.TNombre.SelectionStart = 0
        Me.TNombre.SelectionLength = Me.TNombre.Text.Length
    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs)
        Dim uf As Integer = DataT.Rows.Count - 1
        Fila = Fila + 1
        If Fila > uf Then Fila = uf
        MostrarDatos(Fila)
        Me.TNombre.SelectionStart = 0
        Me.TNombre.SelectionLength = Me.TNombre.Text.Length
    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs)
        Fila = DataT.Rows.Count - 1
        MostrarDatos(Fila)
        Me.TNombre.SelectionStart = 0
        Me.TNombre.SelectionLength = Me.TNombre.Text.Length
    End Sub
    Private Sub MostrarProveedor()
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT  * FROM TProveedor WHERE idProveedor=" & CodProveedor, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.TCodigo.Text = DR("idProveedor")
                    Me.TAlias.Text = DR("Alias")
                    Me.TNombre.Text = DR("Nombre")
                    Me.TRif.Text = DR("Rif")
                    Me.TDescripcion.Text = DR("Descripcion")
                    Me.TDireccion.Text = DR("Direccion")
                    Me.TTelefono.Text = DR("Telefono")
                    Me.TCelular.Text = DR("Celular")
                    Me.TCorreo.Text = DR("Correo")
                    Me.TSitioWeb.Text = DR("SitioWeb")
                    Me.Fecha.Value = DR("Fecha")
                    Me.CBEfecExtAjeno.Checked = DR("EfecExtAjeno")
                    Me.TPPago.Text = DR("Porc")
                    Me.TPorcAlqExt.Text = DR("PorcRetorno")
                    Me.CBForaneo.Checked = DR("Foraneo")
                    Me.CBTransporte.Checked = DR("Transporte")
                    Me.CBOtros.Checked = DR("Otros")
                    Me.TContacto.Text = DR("ContactoProv")
                Loop  
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error de Datos..." & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try
           
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        '  VarBuscar = "Proveedor"
        ' FBuscarGenerico.LTitulo.Text = "Listado Proveedores."
        FBuscarProveedor.LTitulo.Tag = Me.TCodigo.Text
        FBuscarProveedor.ShowDialog()
        MostrarProveedor()
        If (Me.TCodigo.Text <> "") Then
            ActivarControles(True)
        End If
    End Sub

   
    Private Sub MostrarBancos()
        If (Me.TCodigo.Text <> "") Then
            Me.GridBancos.Columns.Clear()
            Try
                If Conectar() Then
                    AProv = New SqlDataAdapter("Select * FROM TBancos WHERE CodAsignar=" & Me.TCodigo.Text & " ORDER BY Nombre ASC", CNN)
                    DProv = New DataTable
                    AProv.Fill(DProv)
                    Me.GridBancos.DataSource = DProv
                    Me.GridBancos.Columns(0).HeaderText = "Código"
                    Me.GridBancos.Columns(0).Width = 80
                    Me.GridBancos.Columns(1).HeaderText = "Banco"
                    Me.GridBancos.Columns(1).Width = 150
                    Me.GridBancos.Columns(2).HeaderText = "Tipo Cta."
                    Me.GridBancos.Columns(2).Width = 150
                    Me.GridBancos.Columns(3).HeaderText = "Número Cuenta"
                    Me.GridBancos.Columns(3).Width = 250
                    Me.GridBancos.Columns(4).HeaderText = "Titular"
                    Me.GridBancos.Columns(4).Width = 150
                    Me.GridBancos.Columns(5).HeaderText = "C.I."
                    Me.GridBancos.Columns(5).Width = 100
                    Me.GridBancos.Columns(6).Visible = False
                    Me.GridBancos.Columns(7).Visible = False
                    Me.GridBancos.Columns(8).HeaderText = "Fecha"
                    Me.GridBancos.Columns(8).Width = 150
                    Me.GridBancos.Columns(9).HeaderText = "Activo?"
                    Me.GridBancos.Columns(9).Width = 80
                    Me.GridBancos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If
                Desconectar()
            Catch ex As Exception
                MessageBox.Show("ERROR Conectar o Recuperar los Datos de los Bancos." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        Else
            MessageBox.Show("Debe Seleccionar el Proveedor. ", "Marsoft: Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub MostrarListado()
        Try
            If Conectar() Then
                Adaptador = New SqlDataAdapter("Select idProveedor, Rif,Alias, Nombre,Telefono, Celular, Correo, Descripcion, Direccion,  EfecExtAjeno,Porc,AlqPuntoExt,PorcRetorno, Foraneo,Transporte, Otros, Fecha FROM TProveedor WHERE Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.GridProveedores.DataSource = DataT
                GridProveedores.Columns("idProveedor").HeaderText = "Cód."
                GridProveedores.Columns("idProveedor").Width = 50
                GridProveedores.Columns("idProveedor").ToolTipText = "Código."
                GridProveedores.Columns("Rif").HeaderText = "R.I.F."
                GridProveedores.Columns("Rif").Width = 120
                GridProveedores.Columns("Alias").HeaderText = "Alias"
                GridProveedores.Columns("Alias").ToolTipText = "Alias del Proveedor."
                GridProveedores.Columns("Alias").Width = 150
                GridProveedores.Columns("Nombre").HeaderText = "Nombre"
                GridProveedores.Columns("Nombre").ToolTipText = "Nombre del Proveedor."
                GridProveedores.Columns("Nombre").Width = 200
                GridProveedores.Columns("Descripcion").HeaderText = "Descrip."
                GridProveedores.Columns("Descripcion").ToolTipText = "Descripción Detallada del Proveedor."
                GridProveedores.Columns("Direccion").HeaderText = "Direcc."
                GridProveedores.Columns("Direccion").ToolTipText = "Dirección."
                GridProveedores.Columns("Telefono").HeaderText = "Teléfono"
                GridProveedores.Columns("Celular").HeaderText = "Celular"
                GridProveedores.Columns("Correo").HeaderText = "Correo"
                GridProveedores.Columns("Fecha").HeaderText = "Fecha"
                GridProveedores.Columns("Fecha").ToolTipText = "Fecha de Creación del Proveedor."
                GridProveedores.Columns("Fecha").Width = 120
                GridProveedores.Columns("EfecExtAjeno").HeaderText = "E.E.A."
                GridProveedores.Columns("EfecExtAjeno").ToolTipText = "Efectivo Externo Ajeno."
                GridProveedores.Columns("EfecExtAjeno").Width = 80
                GridProveedores.Columns("AlqPuntoExt").HeaderText = "A.P.E."
                GridProveedores.Columns("AlqPuntoExt").ToolTipText = "Alquiler Punto Externo."
                GridProveedores.Columns("AlqPuntoExt").Width = 80
                GridProveedores.Columns("Porc").HeaderText = "%E.E.A."
                GridProveedores.Columns("Porc").ToolTipText = "% Pago de Efectivo Externo Ajeno."
                GridProveedores.Columns("PorcRetorno").HeaderText = "%A.P.E."
                GridProveedores.Columns("PorcRetorno").ToolTipText = "% Cobro de Alquiler de Punto Externo."
                GridProveedores.Columns("Foraneo").HeaderText = "Foran."
                GridProveedores.Columns("Foraneo").ToolTipText = "Proveedor Foraneo."
                GridProveedores.Columns("Foraneo").Width = 60
                GridProveedores.Columns("Transporte").HeaderText = "Transp."
                GridProveedores.Columns("Transporte").ToolTipText = "Transporte."
                GridProveedores.Columns("Transporte").Width = 60
                GridProveedores.Columns("Otros").HeaderText = "<>Pes"
                GridProveedores.Columns("Otros").ToolTipText = "Proveedor <> Pescado."
                GridProveedores.Columns("Otros").Width = 60
                GridProveedores.Columns("idProveedor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                GridProveedores.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                GridProveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Private Sub TabProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabProveedores.SelectedIndexChanged
        Select Case TabProveedores.SelectedTab.Name
            Case Me.TapGeneral.Name
                VarForma = "GeneralProveedores"
            Case Me.TapBancos.Name
                VarForma = "BancoProveedores"
                MostrarBancos()
            Case Me.TapListados.Name
                VarForma = "ListadoProveedores"
                MostrarListado()
        End Select
    End Sub

    Private Sub TPPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPPago.KeyPress
        e.Handled = txtNumerico(TPPago, e.KeyChar, True)
    End Sub


    Private Sub TPorcAlqExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPorcAlqExt.KeyPress
        e.Handled = txtNumerico(TPPago, e.KeyChar, True)
    End Sub

    Private Sub TCodigo_TextChanged(sender As Object, e As EventArgs) Handles TCodigo.TextChanged

    End Sub

   

    Private Sub TNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TNombre_LostFocus(Nothing, Nothing)
        End Select
    End Sub

    Private Sub TNombre_LostFocus(sender As Object, e As EventArgs) Handles TNombre.LostFocus
        If (Me.TAlias.Text = "") Then
            Me.TAlias.Text = Me.TNombre.Text
            Me.TAlias.SelectAll()
            Me.TAlias.Focus()
        Else
            Me.TAlias.SelectAll()
            Me.TAlias.Focus()
        End If
    End Sub

    Private Sub TNombre_TextChanged(sender As Object, e As EventArgs) Handles TNombre.TextChanged

    End Sub

    Private Sub DataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProveedores.CellContentClick

    End Sub

  
    Private Sub TPorcAlqExt_TextChanged(sender As Object, e As EventArgs) Handles TPorcAlqExt.TextChanged

    End Sub
End Class