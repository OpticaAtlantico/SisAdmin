Imports System.Data.SqlClient
Module MConexion
    Public CNN, CNN2, CNN3, CNN4, CNN5 As New SqlConnection
    Public Enunciado As SqlCommand
    Public Respuesta As SqlDataReader

    Public Function Conectar() As Boolean
        Dim Valor As Boolean = False
        Try
            If CNN.State = ConnectionState.Closed Then
                CNN.ConnectionString = "Server=.\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                ' CNN.ConnectionString = "Server=SERVI\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                CNN.Open()
                If CNN.State = ConnectionState.Open Then
                    Valor = True
                End If
            End If
        Catch excep As SqlClient.SqlException
            MessageBox.Show("Error al conectar con Datos" & ControlChars.CrLf & excep.Message & ControlChars.CrLf & excep.Server)
        End Try
        Return Valor
    End Function
    Public Function Conectar2() As Boolean
        Dim Valor As Boolean = False
        Try
            If CNN2.State = ConnectionState.Closed Then
                CNN2.ConnectionString = "Server=.\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                ' CNN2.ConnectionString = "Server=SERVI\SQLEXPRESS; database=BDOptica2; integrated security=yes"

                CNN2.Open()
                If CNN2.State = ConnectionState.Open Then
                    Valor = True
                End If
            End If
        Catch excep As SqlClient.SqlException
            MessageBox.Show("Error al conectar con Datos" & ControlChars.CrLf & excep.Message & ControlChars.CrLf & excep.Server)
        End Try
        Return Valor
    End Function

    Public Function Conectar3() As Boolean
        Dim Valor As Boolean = False
        Try
            If CNN3.State = ConnectionState.Closed Then
                CNN3.ConnectionString = "Server=.\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                ' CNN3.ConnectionString = "Server=SERVI\SQLEXPRESS; database=BDOptica2; integrated security=yes"

                CNN3.Open()
                If CNN3.State = ConnectionState.Open Then
                    Valor = True
                End If
            End If
        Catch excep As SqlClient.SqlException
            MessageBox.Show("Error al conectar con Datos" & ControlChars.CrLf & excep.Message & ControlChars.CrLf & excep.Server)
        End Try
        Return Valor
    End Function

    Public Function Conectar4() As Boolean
        Dim Valor As Boolean = False
        Try
            If CNN4.State = ConnectionState.Closed Then
                CNN4.ConnectionString = "Server=.\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                ' CNN4.ConnectionString = "Server=SERVI\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                CNN4.Open()
                If CNN4.State = ConnectionState.Open Then
                    Valor = True
                End If
            End If
        Catch excep As SqlClient.SqlException
            MessageBox.Show("Error al conectar con Datos" & ControlChars.CrLf & excep.Message & ControlChars.CrLf & excep.Server)
        End Try
        Return Valor
    End Function

    Public Function Conectar5() As Boolean
        Dim Valor As Boolean = False
        Try
            If CNN5.State = ConnectionState.Closed Then
                CNN5.ConnectionString = "Server=.\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                'CNN5.ConnectionString = "Server=SERVI\SQLEXPRESS; database=BDOptica2; integrated security=yes"
                CNN5.Open()
                If CNN5.State = ConnectionState.Open Then
                    Valor = True
                End If
            End If
        Catch excep As SqlClient.SqlException
            MessageBox.Show("Error al conectar con Datos" & ControlChars.CrLf & excep.Message & ControlChars.CrLf & excep.Server)
        End Try
        Return Valor
    End Function
    Public Sub Desconectar()
        If CNN.State = ConnectionState.Open Then
            CNN.Close()
        End If
    End Sub
    Public Sub Desconectar2()
        If CNN2.State = ConnectionState.Open Then
            CNN2.Close()
        End If
    End Sub
    Public Sub Desconectar3()
        If CNN3.State = ConnectionState.Open Then
            CNN3.Close()
        End If
    End Sub
    Public Sub Desconectar4()
        If CNN4.State = ConnectionState.Open Then
            CNN4.Close()
        End If
    End Sub
    Public Sub Desconectar5()
        If CNN5.State = ConnectionState.Open Then
            CNN5.Close()
        End If
    End Sub

    'Public Sub VistaInicialCajaNew(CategoriaSel As String)
    '    DesactivarCategoria(FCajaNew.PanelCat, False)
    '    If Conectar() Then
    '        Dim Comando As New SqlCommand("SELECT idCategoria, Nombre, ColorFuente, ColorFondo, ColorCat, TFuente,TipoFuente FROM TCategoria WHERE Mostrar='TRUE' ORDER By Nombre DESC", CNN)
    '        Try
    '            Dim DatosCat As SqlDataReader = Comando.ExecuteReader()
    '            CantCatActiva = 0
    '            Do While DatosCat.Read()
    '                CantCatActiva = CantCatActiva + 1
    '                FCajaNew.BAuxCat.Tag = DatosCat("idCategoria")
    '                FCajaNew.BAuxCat.Text = Trim(DatosCat("Nombre"))
    '                FCajaNew.BAuxCat.ForeColor = Color.FromArgb(DatosCat("ColorFuente"))
    '                FCajaNew.BAuxCat.BackColor = Color.FromArgb(DatosCat("ColorFondo"))
    '                FCajaNew.AuxCat.BackColor = Color.FromArgb(DatosCat("ColorCat"))
    '                FCajaNew.BAuxCat.Font = New Font(DatosCat("TipoFuente").ToString, DatosCat("TFuente"), FontStyle.Bold)
    '                MostrarCategoriaCajaNew(CantCatActiva, FCajaNew.AuxCat, FCajaNew.BAuxCat)
    '            Loop
    '            DatosCat.Close()
    '            Desconectar()
    '            If Conectar2() Then
    '                If (CategoriaSel = "Inicio") Then
    '                    CategoriaSel = FCajaNew.BCat01.Text
    '                    FCajaNew.BCat01.BackColor = Color.LightYellow
    '                End If
    '                Dim Comando2 As New SqlCommand("SELECT idArticulo, Nombre, ColorFuenteArt, ColorCat, TFuente, idProducto,Costo, Decimal, TipoFuente,Imagen FROM VNewArticulosProductos WHERE Categoria='" & Trim(CategoriaSel) & "' AND Venta=1 AND Activo=1 ORDER BY Nombre ASC", CNN2)
    '                Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
    '                CantArtActivo = 0
    '                Do While DatosArt.Read()
    '                    '  If (DatosArt("Costo") > 0) Then
    '                    CantArtActivo = CantArtActivo + 1
    '                    FCajaNew.LAuxArt.Tag = DatosArt("idProducto")
    '                    FCajaNew.LAuxArt.Text = Trim(DatosArt("Nombre"))
    '                    FCajaNew.LAuxArt.ForeColor = Color.FromArgb(DatosArt("ColorFuenteArt"))
    '                    FCajaNew.LAuxArt.BackColor = Color.FromArgb(DatosArt("ColorCat"))
    '                    Dim ms As New System.IO.MemoryStream()
    '                    Dim imageBuffer() As Byte = CType(DatosArt("Imagen"), Byte())
    '                    ms = New System.IO.MemoryStream(imageBuffer)
    '                    FCajaNew.BAuxArt.BackgroundImage = Nothing
    '                    FCajaNew.BAuxArt.BackgroundImage = (Image.FromStream(ms))
    '                    FCajaNew.LAuxArt.Font = New Font(DatosArt("TipoFuente").ToString, DatosArt("TFuente"), FontStyle.Bold)
    '                    FCajaNew.LAuxArt.TextAlign = ContentAlignment.MiddleCenter
    '                    FCajaNew.BAuxArt.Tag = DatosArt("idArticulo")
    '                    MostrarArticuloCaja(FCajaNew.PanelArt, FCajaNew.BAuxArt, FCajaNew.LAuxArt)
    '                    '  End If                  
    '                Loop
    '                CatActiva = Trim(CategoriaSel)
    '                DatosArt.Close()
    '            End If
    '            Desconectar2()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '            Desconectar2()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub
    'Public Sub VistaInicial(CategoriaSel As String)
    '    DesactivarCategoria(FFerias.PanelCat, False)
    '    If Conectar() Then
    '        Dim Comando As New SqlCommand("SELECT idCategoria, Nombre, ColorFuente, ColorFondo, ColorCat, TFuente, Comentario FROM TCategoria WHERE Mostrar='TRUE'", CNN)
    '        Try
    '            Dim DatosCat As SqlDataReader = Comando.ExecuteReader()
    '            CantCatActiva = 0
    '            Do While DatosCat.Read()
    '                CantCatActiva = CantCatActiva + 1
    '                FFerias.BAuxCat.Tag = DatosCat("idCategoria")
    '                FFerias.BAuxCat.Text = Trim(DatosCat("Nombre"))
    '                FFerias.BAuxCat.ForeColor = Color.FromArgb(DatosCat("ColorFuente"))
    '                FFerias.BAuxCat.BackColor = Color.FromArgb(DatosCat("ColorFondo"))
    '                FFerias.AuxCat.BackColor = Color.FromArgb(DatosCat("ColorCat"))
    '                FFerias.BAuxCat.Font = New Font("Microsoft Sans Serif", DatosCat("TFuente"), FontStyle.Bold)
    '                FFerias.AuxCat.Tag = Trim(DatosCat("Comentario"))
    '                MostrarCategoria(CantCatActiva, FFerias.AuxCat, FFerias.BAuxCat)
    '            Loop
    '            DatosCat.Close()
    '            If Conectar2() Then
    '                If (CategoriaSel = "Inicio") Then
    '                    CategoriaSel = FFerias.BCat01.Text
    '                End If
    '                If (CategoriaSel = "Relleno") Then
    '                    CategoriaSel = "Sazonado"
    '                End If
    '                Dim Comando2 As New SqlCommand("SELECT idArticulo, Nombre, ColorFuente, ColorCat, Imagen, TFuente, idProducto,Costo, StockDiario FROM VNewArticulosProductos WHERE Categoria='" & Trim(CategoriaSel) & "' AND Venta=1 AND Activo=1 ORDER BY Nombre ASC", CNN2)
    '                Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
    '                CantArtActivo = 0
    '                Do While DatosArt.Read()
    '                    Select Case CategoriaSel
    '                        Case "Picado", "Traslado"
    '                            CantArtActivo = CantArtActivo + 1
    '                            FFerias.LAuxArt.Tag = DatosArt("idProducto")
    '                            FFerias.LAuxArt.Text = Trim(DatosArt("Nombre"))
    '                            ' FFerias.LAuxStock.Text = Trim(DatosArt("StockDiario"))
    '                            FFerias.LAuxArt.ForeColor = Color.FromArgb(DatosArt("ColorFuente"))
    '                            FFerias.LAuxArt.BackColor = Color.FromArgb(DatosArt("ColorCat"))
    '                            Dim ms As New System.IO.MemoryStream()
    '                            Dim imageBuffer() As Byte = CType(DatosArt("Imagen"), Byte())
    '                            ms = New System.IO.MemoryStream(imageBuffer)
    '                            FFerias.BAuxArt.BackgroundImage = Nothing
    '                            FFerias.BAuxArt.BackgroundImage = (Image.FromStream(ms))
    '                            ' FFerias.BAuxArt.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & DatosArt("Imagen"))
    '                            FFerias.LAuxArt.Font = New Font("Microsoft Sans Serif", DatosArt("TFuente"), FontStyle.Bold)
    '                            FFerias.LAuxArt.TextAlign = ContentAlignment.MiddleCenter
    '                            FFerias.BAuxArt.Tag = DatosArt("idArticulo")
    '                            MostrarArticulo(FFerias.PanelArt, FFerias.BAuxArt, FFerias.LAuxArt, FFerias.LAuxStock.Text)
    '                        Case Else
    '                            If (DatosArt("Costo") > 0) Then
    '                                CantArtActivo = CantArtActivo + 1
    '                                FFerias.LAuxArt.Tag = DatosArt("idProducto")
    '                                FFerias.LAuxArt.Text = Trim(DatosArt("Nombre"))
    '                                'FFerias.LAuxStock.Text = Trim(DatosArt("StockDiario"))
    '                                FFerias.LAuxArt.ForeColor = Color.FromArgb(DatosArt("ColorFuente"))
    '                                FFerias.LAuxArt.BackColor = Color.FromArgb(DatosArt("ColorCat"))
    '                                Dim ms As New System.IO.MemoryStream()
    '                                Dim imageBuffer() As Byte = CType(DatosArt("Imagen"), Byte())
    '                                ms = New System.IO.MemoryStream(imageBuffer)
    '                                FFerias.BAuxArt.BackgroundImage = Nothing
    '                                FFerias.BAuxArt.BackgroundImage = (Image.FromStream(ms))
    '                                '  FFerias.BAuxArt.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\Imagenes\" & DatosArt("Imagen"))
    '                                FFerias.LAuxArt.Font = New Font("Microsoft Sans Serif", DatosArt("TFuente"), FontStyle.Bold)
    '                                FFerias.LAuxArt.TextAlign = ContentAlignment.MiddleCenter
    '                                FFerias.BAuxArt.Tag = DatosArt("idArticulo")
    '                                MostrarArticulo(FFerias.PanelArt, FFerias.BAuxArt, FFerias.LAuxArt, FFerias.LAuxStock.Text)
    '                            End If
    '                    End Select
    '                Loop
    '                CatActiva = Trim(CategoriaSel)
    '                DatosArt.Close()
    '                Desconectar2()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '            Desconectar2()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub
    Public Sub CantProdPorCat(Categoria As String)
        TotalProd = 0
        Categoria = " Categoria='" & Categoria & "' AND "
        If Conectar2() Then
            Dim Comando2 As New SqlCommand("SELECT Count(*) as Cantidad FROM VNewArticulosProductos WHERE " & Categoria & " Venta=1 AND Activo=1 GROUP BY Categoria", CNN2)
            Dim DatosArt As SqlDataReader = Comando2.ExecuteReader()
            Do While DatosArt.Read()
                TotalProd = DatosArt("Cantidad")
            Loop
            DatosArt.Close()
        End If
        Desconectar2()
    End Sub


    Function UsuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim Resultado As Boolean = False
        Try
            Enunciado = New SqlCommand("SELECT * FROM TUsuario where USUARIO='" & nombreUsuario & "'", CNN)
            Respuesta = Enunciado.ExecuteReader
            If Respuesta.Read Then
                Resultado = True
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function Contrasena(ByVal nombreUsuario As String) As String
        Dim Resultado As String = ""
        Try
            Enunciado = New SqlCommand("SELECT Contrasena FROM TUsuario where Usuario='" & nombreUsuario & "'", CNN)
            Respuesta = Enunciado.ExecuteReader
            If Respuesta.Read Then
                Resultado = Respuesta.Item("Contrasena")
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim Resultado As Integer
        Try
            Enunciado = New SqlCommand("Select TipoUsuario from TUsuario where Usuario='" & nombreUsuario & "'", CNN)
            Respuesta = Enunciado.ExecuteReader

            If Respuesta.Read Then
                Resultado = Convert.ToDecimal(Respuesta.Item("TipoUsuario"))
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return Resultado
    End Function
End Module
