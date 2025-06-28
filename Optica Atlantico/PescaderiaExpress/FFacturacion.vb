Imports System.Data.SqlClient
Public Class FFacturacion
    Dim Listo As Boolean = False
    Private DataT2 As DataTable
    Private Adaptador2 As SqlDataAdapter
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim idOrden As Integer = 0
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub BuscarAbonoCliente()
        If Conectar() Then
            Dim Comando As New SqlCommand("Select SUM(Monto) as Abonado FROM VFormaPago Where idOrden=" & CodOrden, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            If DR.Read() Then
                If (DR("Abonado").ToString = "") Then
                    AbonadoGnal = 0
                Else
                    AbonadoGnal = DR("Abonado")
                End If
            End If
            DR.Close()
        End If
        Desconectar()
    End Sub
    Private Sub BuscarTipoPago()
        If Conectar() Then
            Dim Comando As New SqlCommand("Select top 1 TipoPago FROM VFormaPago Where idOrden=" & CodOrden, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            Do While DR.Read()
                TipoPago = DR("TipoPago")
            Loop
            DR.Close()
        End If
        Desconectar()
    End Sub
    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        VarForma = "FACTURA"
        BuscarAbonoCliente()
        BuscarTipoPago()
        FReportes.ShowDialog()
    End Sub
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        Me.TNumOrden.Text = RellenarCeros(BuscarNumOrden(), 10)
        Me.TNombre.Text = ""
        Me.TCI.Text = ""
        Me.TCI.Tag = ""
        Me.TRIF.Text = ""
        Me.TDirecion.Text = ""
        Me.TTelefono.Text = ""
        Me.txt_Jornada.Text = ""
        Me.Fecha.Value = DateTime.Now()
        Me.TSubTotal.Text = "0,00"
        Me.Tdescuento.Text = "0,00"
        Me.TTotal.Text = "0,00"
        Me.TSubTotal.Tag = 0
        Me.Tdescuento.Tag = 0
        Me.TTotal.Tag = 0
        Me.BObservOrden.Tag = ""
        Me.CAsesor.Text = ""
        Me.COpto.Text = ""
        Me.CGerente.Text = ""
        Me.CMarketing.Text = ""
        DEsf = ""
        DCil = ""
        DEje = ""
        DAdd = ""
        IEsf = ""
        ICil = ""
        IEje = ""
        IAdd = ""
        H = ""
        V = ""
        D = ""
        P = ""
        Max = ""
        DP = ""
        Alt = ""
        ObservacionFormula = ""
        FormulaExterna = False
        DoctorExt = ""
        ActivarControles2(False)
        Me.Grid.Rows.Clear()
    End Sub
    Private Sub MostrarDetalleOrden()
        Me.Grid.Rows.Clear()
        Try
            If Conectar2() Then
                Dim Comando2 As New SqlCommand("SELECT * FROM VDetalleOrden WHERE idOrden=" & CodOrden, CNN2)
                Dim DR2 As SqlDataReader = Comando2.ExecuteReader()
                While DR2.Read()
                    Me.Grid.Rows.Add(DR2("Num"), DR2("idProducto"), DR2("Nombre"), VFormat(DR2("Stock"), 2), DR2("Cantidad"), VFormat(DR2("Precio"), 2), VFormat(DR2("Total"), 2), DR2("Observacion"))
                End While
                DR2.Close()
            End If
            Desconectar2()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de los Detalles de la Orden. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar2()
        End Try
    End Sub
    Private Sub MostrarFormulas()
        Try
            If Conectar2() Then
                Dim Comando2 As New SqlCommand("SELECT * FROM TFormula WHERE idOrden=" & CodOrden, CNN2)
                Dim DR2 As SqlDataReader = Comando2.ExecuteReader()
                If (DR2.Read()) Then
                    DEsf = DR2("DEsf")
                    DCil = DR2("DCil")
                    DEje = DR2("DEje")
                    DAdd = DR2("DAdd")
                    IEsf = DR2("IEsf")
                    ICil = DR2("ICil")
                    IEje = DR2("IEje")
                    IAdd = DR2("IAdd")
                    H = DR2("H")
                    V = DR2("V")
                    D = DR2("D")
                    P = DR2("P")
                    Max = DR2("Max")
                    DP = DR2("DP")
                    Alt = DR2("Alt")
                    ObservacionFormula = DR2("Observacion")
                    FormulaExterna = DR2("FormulaExt")
                    DoctorExt = DR2("DoctorExt")
                Else
                    DEsf = ""
                    DCil = ""
                    DEje = ""
                    DAdd = ""
                    IEsf = ""
                    ICil = ""
                    ICil = ""
                    IAdd = ""
                    H = ""
                    V = ""
                    D = ""
                    P = ""
                    Max = ""
                    DP = ""
                    Alt = ""
                    ObservacionFormula = ""
                    FormulaExterna = False
                    DoctorExt = ""
                End If
                DR2.Close()
            End If
            Desconectar2()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de la Orden. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar2()
        End Try
    End Sub

    Public Sub CargarDetalleOrden(idOrden As Integer)
        CodOrden = idOrden
        MostrarOrden()
    End Sub

    Private Sub MostrarOrden()
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT * FROM VOrden WHERE idOrden=" & CodOrden, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Me.Fecha.Value = DR("FechaOrden")
                    Me.TNumOrden.Text = RellenarCeros(CodOrden, 10)
                    Me.CNac.Text = DR("Nacionalidad")
                    Me.TCI.Tag = Trim(DR("idCliente").ToString)
                    Me.TCI.Text = Trim(DR("CI").ToString)
                    Me.CTipoRif.Text = DR("TipoRif")
                    Me.TRIF.Text = Trim(DR("RIF").ToString)
                    Me.TNombre.Text = Trim(DR("Cliente").ToString)
                    Me.TDirecion.Text = Trim(DR("Direccion").ToString)
                    Me.TTelefono.Text = Trim(DR("Telefono").ToString & " / " & DR("Celular").ToString)
                    Me.txt_Jornada.Text = Trim(DR("Jornada").ToString)
                    Me.CAsesor.Text = DR("Asesor")
                    Me.COpto.Text = DR("Opto")
                    Me.CGerente.Text = DR("Gerente")
                    Me.CMarketing.Text = DR("Marketing")
                    Me.Tdescuento.Text = DR("Descuento")
                    If Me.CMarketing.Text <> "" Then Me.txt_Jornada.Enabled = True Else Me.txt_Jornada.Enabled = False

                    Me.Tdescuento.Tag = VFormat(DR("Descuento").ToString, 2)
                    Me.Tdescuento.Text = "$ " & Me.Tdescuento.Tag
                    '      TotalGeneral()


                    MostrarDetalleOrden()
                    MostrarFormulas()
                    ActivarControles2(True)
                Else
                    Desconectar()
                    Nuevo_Click(Nothing, Nothing)
                    MsgBox("Esta «Orden» No Existe.", MsgBoxStyle.Information, "MarSoft: Información.")
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de la Orden. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        SubTotalizar()
        TotalGeneral()
    End Sub
    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        FBuscarOrden.ShowDialog()
        CargarDetalleOrden(CodOrden)
        'MostrarOrden()
    End Sub
    Private Sub EliminarDetalleOrden()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Delete  TDetalleOrden WHERE idOrden=@idOrden", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))              
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Desconectar()              
               ActivarGuardar = True
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Eliminar los Datos del Detalle de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
            Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub ActualizarFormula()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("UPDATE TFormula SET idOrden=@idOrden,  DEsf=@DEsf,  IEsf=@IEsf,  DCil=@DCil,  ICil=@ICil,  DEje=@DEje,  IEje=@IEje,  DAdd=@DAdd, IAdd=@IAdd,  H=@H,  V=@V,  D=@D,  P=@P,  Max=@Max,  DP=@DP,  Alt=@Alt,  Observacion=@Observacionx, FormulaExt=@FormulaExt, DoctorExt=@DoctorExt  WHERE idOrden=@idOrden", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                Comando.Parameters.Add(New SqlParameter("@DEsf", DEsf))
                Comando.Parameters.Add(New SqlParameter("@IEsf", IEsf))
                Comando.Parameters.Add(New SqlParameter("@DCil", DCil))
                Comando.Parameters.Add(New SqlParameter("@ICil", ICil))
                Comando.Parameters.Add(New SqlParameter("@DEje", DEje))
                Comando.Parameters.Add(New SqlParameter("@IEje", IEje))
                Comando.Parameters.Add(New SqlParameter("@DAdd", DAdd))
                Comando.Parameters.Add(New SqlParameter("@IAdd", IAdd))
                Comando.Parameters.Add(New SqlParameter("@H", H))
                Comando.Parameters.Add(New SqlParameter("@V", V))
                Comando.Parameters.Add(New SqlParameter("@D", D))
                Comando.Parameters.Add(New SqlParameter("@P", P))
                Comando.Parameters.Add(New SqlParameter("@Max", Max))
                Comando.Parameters.Add(New SqlParameter("@DP", DP))
                Comando.Parameters.Add(New SqlParameter("@Alt", Alt))
                Comando.Parameters.Add(New SqlParameter("@Observacionx", ObservacionFormula))
                Comando.Parameters.Add(New SqlParameter("@FormulaExt", FormulaExterna))
                Comando.Parameters.Add(New SqlParameter("@DoctorExt", DoctorExt))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                ActivarGuardar = True
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Actualizar los Datos de las Formulas.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
        End Try
    End Sub
    Private Sub ActulizarFacturacion()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Update TOrden SET FechaOrden=@Fecha, idCliente=@idCliente,  idAsesor=@idAsesor, idOpto=@idOpto, idGerente=@idGerente, idMarketing=@idMarketing, Observacion=@Observacion, SubTotal=@SubTotal, Descuento=@Descuento, Total=@Total, Jornada=@Jornada WHERE idOrden=@idOrden", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.Fecha.Value))
                Comando.Parameters.Add(New SqlParameter("@idCliente", Me.TCI.Tag))
                Comando.Parameters.Add(New SqlParameter("@idAsesor", Me.CAsesor.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idOpto", Me.COpto.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idGerente", Me.CGerente.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idMarketing", Me.CMarketing.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@Observacion", Me.BObservOrden.Tag))
                Comando.Parameters.Add(New SqlParameter("@SubTotal", Convert.ToDecimal(IIf(Me.TSubTotal.Text = "", 0, Me.TSubTotal.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Descuento", Convert.ToDecimal(IIf(Me.Tdescuento.Text = "", 0, Me.Tdescuento.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(IIf(Me.TTotal.Text = "", 0, Me.TTotal.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Jornada", Me.txt_Jornada.Text))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Desconectar()
                EliminarDetalleOrden()
                GuardarDetalleOrden()
                ActualizarFormula()
                If (ActivarGuardar = True) Then
                    MsgBox("Los Datos Fueron «Actualizados» con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                End If
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Guardar los Datos de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
            Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
   
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        If (Me.TCI.Text <> "") Then
            If (Me.CAsesor.Text <> "") Then
                If (Me.COpto.Text <> "") Then
                    If (Me.CGerente.Text <> "") Then
                        ActulizarFacturacion()
                        CargarDatos(ObtenerNombreOptica(1))
                    Else
                        MsgBox("Debe Seleccionar el Gerente o Sub-Gerente.", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.CGerente.Focus()
                    End If
                Else
                    MsgBox("Debe Seleccionar el Optometrista.", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.COpto.Focus()
                End If
            Else
                MsgBox("Debe Seleccionar el Asesor.", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.CAsesor.Focus()
            End If
        Else
            MsgBox("Debe Seleccionar un Cliente.", MsgBoxStyle.Information, "MarSoft: Información.")
            Me.TCI.Focus()
        End If
    End Sub
    Private Sub ActivarControles2(Act As Boolean)
        If (Act) Then
            Me.Actualizar.Enabled = True
            Me.Eliminar.Enabled = True
            Me.Guardar.Enabled = False
            Me.BFormaPago.Enabled = True
            Me.BFormulas.Enabled = True
        Else
            Me.Actualizar.Enabled = False
            Me.Eliminar.Enabled = False
            Me.Guardar.Enabled = True
            Me.BFormaPago.Enabled = False
            Me.BFormulas.Enabled = False
        End If
    End Sub
    Private Sub GuardarFacturacion()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TOrden (idOrden, FechaOrden, idCliente, idAsesor, idOpto, idGerente, idMarketing, Observacion, SubTotal, Descuento, Total, Jornada) VALUES(@idOrden, @FechaOrden, @idCliente, @idAsesor, @idOpto, @idGerente, @idMarketing, @Observacion, @SubTotal, @Descuento, @Total, @Jornada)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                Comando.Parameters.Add(New SqlParameter("@FechaOrden", Me.Fecha.Value))
                Comando.Parameters.Add(New SqlParameter("@idCliente", Convert.ToInt64(Me.TCI.Tag)))
                Comando.Parameters.Add(New SqlParameter("@idAsesor", Me.CAsesor.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idOpto", Me.COpto.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idGerente", Me.CGerente.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@idMarketing", Me.CMarketing.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@Observacion", Me.BObservOrden.Tag.ToString))
                Comando.Parameters.Add(New SqlParameter("@SubTotal", Convert.ToDecimal(IIf(Me.TSubTotal.Tag.ToString = "", 0, Me.TSubTotal.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Descuento", Convert.ToDecimal(IIf(Me.Tdescuento.Tag.ToString = "", 0, Me.Tdescuento.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(IIf(Me.TTotal.Tag.ToString = "", 0, Me.TTotal.Tag))))
                Comando.Parameters.Add(New SqlParameter("@Jornada", Me.txt_Jornada.Tag.ToString))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()

                DataT = New DataTable
                Adaptador = New SqlDataAdapter("Select * FROM TOrden", CNN)
                Adaptador.Fill(DataT)
                Dim Fila As DataRow = DataT.Rows(DataT.Rows.Count - 1)
                CodOrden = Trim(Fila("idOrden").ToString)
                Desconectar()
                GuardarDetalleOrden()
                GuardarFormula()
                If (ActivarGuardar = True) Then
                    ' Nuevo_Click(Nothing, Nothing)
                    MsgBox("Los Datos Fueron «Guardados» con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                End If
                ActivarControles2(True)
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Guardar los Datos de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
            Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Private Sub GuardarDetalleOrden()
        For i As Integer = 0 To Me.Grid.Rows.Count - 1
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("INSERT INTO TDetalleOrden (idOrden, Num, idProducto, Stock, Cantidad, Precio, Total, Observacion) VALUES(@idOrden, @Num, @idProducto, @Stock, @Cantidad, @Precio, @Total, @Observacion)", CNN)
                    Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                    Comando.Parameters.Add(New SqlParameter("@Num", Convert.ToDecimal(Me.Grid.Rows(i).Cells("Item").Value)))
                    Comando.Parameters.Add(New SqlParameter("@idProducto", Convert.ToDecimal(Me.Grid.Rows(i).Cells("Codigo").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Stock", Convert.ToDecimal(Me.Grid.Rows(i).Cells("Stock").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Cantidad", Convert.ToDecimal(Me.Grid.Rows(i).Cells("Cantidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Precio", Convert.ToDecimal(Me.Grid.Rows(i).Cells("PrecioUnidad").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(Me.Grid.Rows(i).Cells("Total").Value)))
                    Comando.Parameters.Add(New SqlParameter("@Observacion", Me.Grid.Rows(i).Cells("Observacion").Value))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    ActivarGuardar = True
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Detalle de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                ActivarGuardar = False
            End Try
        Next
    End Sub

    Private Sub GuardarFormula()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TFormula (idOrden, DEsf, IEsf, DCil, ICil, DEje, IEje, DAdd, IAdd, H, V, D, P, Max, DP, Alt, Observacion, FormulaExt, DoctorExt) VALUES(@idOrden, @DEsf, @IEsf, @DCil, @ICil, @DEje, @IEje, @DAdd, @IAdd, @H, @V, @D, @P, @Max, @DP, @Alt, @Observacion, @FormulaExt, @DoctorExt)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                Comando.Parameters.Add(New SqlParameter("@DEsf", DEsf))
                Comando.Parameters.Add(New SqlParameter("@IEsf", IEsf))
                Comando.Parameters.Add(New SqlParameter("@DCil", DCil))
                Comando.Parameters.Add(New SqlParameter("@ICil", ICil))
                Comando.Parameters.Add(New SqlParameter("@DEje", DEje))
                Comando.Parameters.Add(New SqlParameter("@IEje", IEje))
                Comando.Parameters.Add(New SqlParameter("@DAdd", DAdd))
                Comando.Parameters.Add(New SqlParameter("@IAdd", IAdd))
                Comando.Parameters.Add(New SqlParameter("@H", H))
                Comando.Parameters.Add(New SqlParameter("@V", V))
                Comando.Parameters.Add(New SqlParameter("@D", D))
                Comando.Parameters.Add(New SqlParameter("@P", P))
                Comando.Parameters.Add(New SqlParameter("@Max", Max))
                Comando.Parameters.Add(New SqlParameter("@DP", DP))
                Comando.Parameters.Add(New SqlParameter("@Alt", Alt))
                Comando.Parameters.Add(New SqlParameter("@Observacion", ObservacionFormula))
                Comando.Parameters.Add(New SqlParameter("@FormulaExt", FormulaExterna))
                Comando.Parameters.Add(New SqlParameter("@DoctorExt", DoctorExt))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                ActivarGuardar = True
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Guardar los Datos de las Formulas.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
        End Try
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        If (Me.TCI.Tag <> "0") Then
            If (Me.CAsesor.Text <> "") Then
                If (Me.COpto.Text <> "") Then
                    If (Me.CGerente.Text <> "") Then
                        If (Me.Grid.RowCount > 0) Then
                            '  If (DEsf <> "") Then
                            GuardarFacturacion()
                            CargarDatos(ObtenerNombreOptica(1))
                            '  Else
                            '    MsgBox("Debe Agregar la «Formula» a la Orden. ", MsgBoxStyle.Information, "MarSoft: Información.")
                            '     Me.CGerente.Focus()
                            ' End If
                        Else
                            MsgBox("Debe Agregar «Productos» a la Orden. ", MsgBoxStyle.Information, "MarSoft: Información.")
                        End If
                    Else
                        MsgBox("Debe Seleccionar el Gerente o Sub-Gerente.", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.CGerente.Focus()
                    End If
                Else
                    MsgBox("Debe Seleccionar el Optometrista.", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.COpto.Focus()
                End If
            Else
                MsgBox("Debe Seleccionar el Asesor.", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.CAsesor.Focus()
            End If
        Else
            MsgBox("Debe Seleccionar un Cliente.", MsgBoxStyle.Information, "MarSoft: Información.")
            Me.TCI.Focus()
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MsgBox("Esta seguro que desea Eliminar La Orden Número: " & Me.TNumOrden.Text & "?", vbYesNo, "MarSoft: Eliminar Orden.") = vbYes Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("Delete  TDetalleOrden WHERE idOrden=@idOrden", CNN)
                    Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                    Comando.CommandText = "Delete  TFormula WHERE idOrden=@idOrden1"
                    Comando.Parameters.Add(New SqlParameter("@idOrden1", CodOrden))
                    DR = Comando.ExecuteReader()
                    DR.Close()
                    Comando.CommandText = "Delete  TOrden WHERE idOrden=@idOrden2"
                    Comando.Parameters.Add(New SqlParameter("@idOrden2", CodOrden))
                    DR = Comando.ExecuteReader()
                    DR.Close()
                    CargarDatos(ObtenerNombreOptica(1))
                    Desconectar()
                    MsgBox("Los Datos Fueron «Eliminados» con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                    Nuevo_Click(Nothing, Nothing)
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Eliminar los Datos del Detalle de la Orden.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Cursor = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Sub

    Private Sub MostrarCI()
        If (Listo = False) Then
            Try
                If (Me.TCI.Text <> "") Then
                    If Conectar() Then
                        Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE Nacionalidad='" & Me.CNac.Text & "' AND CI='" & Me.TCI.Text & "'", CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        If (DR.Read()) Then
                            Listo = True
                            Me.TCI.Tag = Trim(DR("idCliente").ToString)
                            Me.CTipoRif.Text = DR("TipoRif")
                            Me.TRIF.Text = Trim(DR("RIF").ToString)
                            Me.TNombre.Text = Trim(DR("Nombre").ToString)
                            Listo = False
                            Me.TDirecion.Text = DR("Zona") & " / " & Trim(DR("Direccion").ToString)
                            Me.TTelefono.Text = Trim(DR("Telefono").ToString & " / " & DR("Celular").ToString)
                            VarForma = "Existe"
                        Else
                            Listo = True
                            Me.CNac.Text = "V"
                            Me.TCI.Tag = ""
                            Me.CTipoRif.Text = "J"
                            Me.TRIF.Text = ""
                            Me.TNombre.Text = ""
                            Listo = False
                            Me.TDirecion.Text = ""
                            Me.TTelefono.Text = ""
                            VarForma = "Nombre"
                            'MsgBox("Este «Cliente» No Existe.", MsgBoxStyle.Information, "MarSoft: Información.")
                        End If
                        DR.Close()
                    End If
                    Desconectar()
                    If (Me.TCI.Tag = "") Then
                        FClientes.ShowDialog()
                    End If
                Else
                    Listo = True
                    Me.CNac.Text = "V"
                    Me.TCI.Tag = ""
                    Me.CTipoRif.Text = "J"
                    Me.TRIF.Text = ""
                    Me.TNombre.Text = ""
                    Listo = False
                    Me.TDirecion.Text = ""
                    Me.TTelefono.Text = ""
                    VarForma = "CI"
                    FClientes.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al Conectar o Recuperar los Datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub

    Private Sub MostrarRif()
        If (Listo = False) Then
            Try
                If (Me.TRIF.Text <> "") Then
                    If Conectar() Then
                        Dim Comando As New SqlCommand("SELECT * FROM TClientes WHERE TipoRif='" & Me.CTipoRif.Text & "' AND RIF='" & Me.TRIF.Text & "'", CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        If (DR.Read()) Then
                            Listo = True
                            Me.TCI.Tag = Trim(DR("idCliente").ToString)
                            Me.CNac.Text = DR("Nacionalidad").ToString
                            Me.TCI.Text = Trim(DR("CI").ToString)
                            Me.TNombre.Text = Trim(DR("Nombre").ToString)
                            Listo = False
                            Me.TDirecion.Text = Trim(DR("Direccion").ToString)
                            Me.TTelefono.Text = Trim(DR("Telefono").ToString & " / " & DR("Celular").ToString)
                        Else
                            Listo = True
                            Me.CNac.Text = "V"
                            Me.TCI.Tag = ""
                            Me.CTipoRif.Text = "J"
                            Me.TRIF.Text = ""
                            Me.TNombre.Text = ""
                            Listo = False
                            Me.TDirecion.Text = ""
                            Me.TTelefono.Text = ""
                            MsgBox("Este «Cliente» No Existe.", MsgBoxStyle.Information, "MarSoft: Información.")
                        End If
                        DR.Close()
                    End If
                    Desconectar()
                End If
            Catch ex As Exception
                MessageBox.Show("ERROR al Conectar o Recuperar los Datos del Cliente: " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub TRIF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TRIF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            MostrarRif()
        Else
            e.Handled = txtNumerico(TRIF, e.KeyChar, False)
        End If
    End Sub

    Private Sub TCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            MostrarCI()
        Else
            e.Handled = txtNumerico(TCI, e.KeyChar, False)
        End If
    End Sub

    Private Sub TNumOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNumOrden.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CodOrden = Convert.ToDecimal(IIf(Me.TNumOrden.Text = "", 0, Me.TNumOrden.Text))
            MostrarOrden()
        Else
            e.Handled = txtNumerico(TNumOrden, e.KeyChar, False)
        End If
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        VarBuscar = "BuscarProducto"
        FBuscarProducto.LTitulo.Text = "Listado de Productos."
        If (Me.Grid.RowCount > 0) Then
            FBuscarProducto.LTitulo.Tag = Me.Grid.Rows(Me.Grid.CurrentRow.Index).Cells("Codigo").Value
        Else
            FBuscarProducto.LTitulo.Tag = -1
        End If
        FBuscarProducto.ShowDialog()
        For i = 0 To Me.Grid.RowCount - 1
            Me.Grid.Item("item", i).Value = i + 1
        Next
        SubTotalizar()
        TotalGeneral()
    End Sub

    Private Sub BCliente_Click(sender As Object, e As EventArgs) Handles BCliente.Click
        FClientes.ShowDialog()
    End Sub
    Function BuscarNumOrden() As Integer
        Dim NOrd As Integer = 0
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT top 1 idOrden+1 as NumOrden FROM TOrden Order By idOrden Desc", CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    CodOrden = DR("NumOrden")
                    NOrd = DR("NumOrden")
                Else
                    CodOrden = 1
                    NOrd = 1
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos del Num Orden. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return (NOrd)
    End Function
    Private Sub LlenarComboAsesor()
        If Conectar2() Then
            Try
                Adaptador2 = New SqlDataAdapter("SELECT   idEmpleado as id, Nombre  FROM VEmpleado WHERE Asesor=1 OR idEmpleado=1 ORDER BY Nombre ASC", CNN2)
                DataT2 = New DataTable
                Adaptador2.Fill(DataT2)
                Me.CAsesor.DataSource = DataT2
                Me.CAsesor.DisplayMember = "Nombre"
                Me.CAsesor.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Asesores..." & ControlChars.CrLf & ex.Message)
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub

    Private Sub LlenarComboOpto()
        If Conectar2() Then
            Try
                Adaptador2 = New SqlDataAdapter("SELECT   idEmpleado as id, Nombre  FROM VEmpleado WHERE Optometrista=1 OR idEmpleado=1 ORDER BY Nombre ASC", CNN2)
                DataT2 = New DataTable
                Adaptador2.Fill(DataT2)
                Me.COpto.DataSource = DataT2
                Me.COpto.DisplayMember = "Nombre"
                Me.COpto.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Optometristas..." & ControlChars.CrLf & ex.Message)
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub

    Private Sub LlenarComboGerente()
        If Conectar2() Then
            Try
                Adaptador2 = New SqlDataAdapter("SELECT  idEmpleado as id, Nombre  FROM VEmpleado WHERE Gerente=1 OR idEmpleado=1 ORDER BY Nombre ASC", CNN2)
                DataT2 = New DataTable
                Adaptador2.Fill(DataT2)
                Me.CGerente.DataSource = DataT2
                Me.CGerente.DisplayMember = "Nombre"
                Me.CGerente.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos del Gerente o Sub-Gerente..." & ControlChars.CrLf & ex.Message)
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub

    Private Sub LlenarComboMarketing()
        If Conectar2() Then
            Try
                Adaptador2 = New SqlDataAdapter("SELECT  idEmpleado as id, Nombre  FROM VEmpleado WHERE Marketing=1 OR idEmpleado=1 ORDER BY Nombre ASC", CNN2)
                DataT2 = New DataTable
                Adaptador2.Fill(DataT2)
                Me.CMarketing.DataSource = DataT2
                Me.CMarketing.DisplayMember = "Nombre"
                Me.CMarketing.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de Empleados de Marketing..." & ControlChars.CrLf & ex.Message)
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub
    Private Sub FFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TNumOrden.Text = RellenarCeros(BuscarNumOrden(), 10)
        Me.BObservOrden.Tag = ""
        Me.Tdescuento.Tag = 0
        Me.CNac.Text = "V"
        Me.CTipoRif.Text = "J"
        Me.Fecha.Value = DateTime.Now()
        If Me.CMarketing.Text <> "" Then Me.txt_Jornada.Enabled = True Else Me.txt_Jornada.Enabled = False
        LlenarComboAsesor()
        LlenarComboOpto()
        LlenarComboGerente()
        LlenarComboMarketing()
    End Sub
    Private Sub BEmpleado_Click(sender As Object, e As EventArgs) Handles BEmpleado.Click
        FEmpleados.ShowDialog()
        LlenarComboAsesor()
        LlenarComboOpto()
        LlenarComboGerente()
        LlenarComboMarketing()
    End Sub
    Private Sub BModuloProductos_Click(sender As Object, e As EventArgs) Handles BModuloProductos.Click
        If Me.Grid.CurrentRow IsNot Nothing Then
            FProducto.TCodigo.Text = Me.Grid.Rows(Me.Grid.CurrentRow.Index).Cells("Codigo").Value
            VarForma = "ModuloProd"
            FProducto.ShowDialog()
        Else
            VarForma = "Prod"
            FProducto.ShowDialog()
        End If
    End Sub
    Private Sub SubTotalizar()
        Dim SubT As Decimal = 0
        If Me.Grid.RowCount >= 1 Then
            For Each row As DataGridViewRow In Me.Grid.Rows
                If (row.Cells("Total").Value.ToString <> "") Then
                    SubT += Convert.ToDecimal(row.Cells("Total").Value)
                End If
            Next
            Me.TSubTotal.Tag = VFormat(SubT, 2)
            Me.TSubTotal.Text = "$ " & Me.TSubTotal.Tag
        End If
    End Sub

    Private Sub BEliminarProd_Click(sender As Object, e As EventArgs) Handles BEliminarProd.Click
        Me.Grid.Rows.RemoveAt(Me.Grid.CurrentRow.Index)
        SubTotalizar()
    End Sub

    Private Sub BObservacion_Click(sender As Object, e As EventArgs) Handles BObservacion.Click
        If Grid.CurrentRow IsNot Nothing Then
            FComentario.LCodigo.Text = Me.Grid.Rows(Me.Grid.CurrentRow.Index).Cells("Codigo").Value
            FComentario.LNombre.Text = Me.Grid.Rows(Me.Grid.CurrentRow.Index).Cells("Articulo").Value
            FComentario.TComentario.Text = Me.Grid.Rows(Me.Grid.CurrentRow.Index).Cells("Observacion").Value
            VarForma = "Facturacion"
            FComentario.ShowDialog()
        Else
            MsgBox("Debe Seleccionar el Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub

    Private Sub BFormulas_Click(sender As Object, e As EventArgs) Handles BFormulas.Click
        FFormulas.LCI.Text = Me.CNac.Text & "-" & ValidarCI(Me.TCI.Text)
        FFormulas.LCliente.Text = Me.TNombre.Text
        FFormulas.LNumOrden.Text = Me.TNumOrden.Text
        FFormulas.LFecha.Text = Me.Fecha.Value
        FFormulas.Grid.Rows.Clear()
        For I = 0 To Me.Grid.RowCount - 1
            FFormulas.Grid.Rows.Add(I + 1, Me.Grid.Item("Codigo", I).Value, Me.Grid.Item("Articulo", I).Value)
        Next
        FFormulas.ShowDialog()
        '    ActualizarFormula()
    End Sub

    Private Sub TotalGeneral()
        Me.TTotal.Tag = Convert.ToDecimal(Me.TSubTotal.Tag) - Convert.ToDecimal(Me.Tdescuento.Tag)
        Me.TTotal.Text = "$ " & VFormat(Me.TTotal.Tag, 2)
    End Sub

    Private Sub Tdescuento_GotFocus(sender As Object, e As EventArgs) Handles Tdescuento.GotFocus
        Me.Tdescuento.Text = Me.Tdescuento.Tag
        Me.Tdescuento.SelectionStart = Len(Tdescuento.Text)
        Me.Tdescuento.SelectAll()
    End Sub

    Private Sub Tdescuento_KeyDown(sender As Object, e As KeyEventArgs) Handles Tdescuento.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.Tdescuento.Tag = VFormat(Tdescuento.Text, 2)
            Me.Tdescuento.Text = "$ " & Me.Tdescuento.Tag
            TotalGeneral()
            Me.Grid.Focus()
        End If
    End Sub
    Private Sub Tdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tdescuento.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoPositivo(Tdescuento, e.KeyChar, True)
    End Sub

    Private Sub Grid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Grid.EditingControlShowing
        Select Case Me.Grid.Columns(Me.Grid.CurrentCell.ColumnIndex).Name
            Case Is = "Cantidad"
                Dim validar As TextBox = CType(e.Control, TextBox)
                AddHandler validar.KeyPress, AddressOf validar_Keypress
        End Select
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracter As Char = e.KeyChar
        Dim txt As TextBox = CType(sender, TextBox)
        Select Case Me.Grid.Columns(Me.Grid.CurrentCell.ColumnIndex).Name
            Case Is = "Cantidad"
                If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
        End Select
    End Sub
    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        If (Me.Grid.CurrentCell.ColumnIndex = 4) Then
            Me.Grid.CurrentRow.Cells("Total").Value = Convert.ToDecimal(Me.Grid.CurrentRow.Cells("Cantidad").Value) * Convert.ToDecimal(Me.Grid.CurrentRow.Cells("PrecioUnidad").Value)
            Me.Grid.CurrentRow.Cells("Total").Value = VFormat(Me.Grid.CurrentRow.Cells("Total").Value, 2)
            SubTotalizar()
            TotalGeneral()
        End If
    End Sub

    Private Sub BFormaPago_Click(sender As Object, e As EventArgs) Handles BFormaPago.Click
        If Grid.RowCount > 0 Then
            TotalGeneral()
            FFormaPago.LCI.Text = Me.CNac.Text & "-" & ValidarCI(Me.TCI.Text)
            FFormaPago.LCliente.Text = Me.TNombre.Text
            FFormaPago.LNumOrden.Text = Me.TNumOrden.Text
            FFormaPago.LFecha.Text = Me.Fecha.Value
            FFormaPago.GridFormaPago.Rows.Clear()
            FFormaPago.LTotalDF.Text = Format(Me.TTotal.Tag, "##,##0.00")
            FFormaPago.ShowDialog()
        Else
            MsgBox("Debe Agregar Productos a la Orden.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If

    End Sub

    Private Sub BObservOrden_Click(sender As Object, e As EventArgs) Handles BObservOrden.Click
        VarForma = "Facturacion"
        FComentarioSolo.TComentario.Text = Me.BObservOrden.Tag
        FComentarioSolo.ShowDialog()
    End Sub

    Private Sub CMarketing_Click(sender As Object, e As EventArgs) Handles CMarketing.Click
        Me.txt_Jornada.Enabled = True
    End Sub

    Private Sub TNumOrden_TextChanged(sender As Object, e As EventArgs) Handles TNumOrden.TextChanged

    End Sub
End Class