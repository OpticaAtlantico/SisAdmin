Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class FProducto
    Private ExisteProducto As Boolean = False
    ''    Private DataTIng As DataTable
    'Private DataTardem As DataTable
    ''  Private AdaptadorIng As SqlDataAdapter
    'Private AdaptadorTardem As SqlDataAdapter
    'Private Bandera As Boolean = False
    'Private Valor As Double
    Dim aqui As Boolean = False
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Cat As String = ""
    Private SubCat As String = ""
    Private idCat As Integer = 0
    Private idSubCat As Integer = 0
    'Private AuxPrecio As Decimal = 0
    'Private AuxPrecioD As Decimal = 0


    'Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click

    'End Sub
    'Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
    '    Me.Dialogo.CheckFileExists = True
    '    Me.Dialogo.ShowReadOnly = False
    '    Me.Dialogo.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
    '    If Me.Dialogo.ShowDialog = DialogResult.OK Then
    '        Me.Imagen.BackgroundImage = Image.FromFile(Me.Dialogo.FileName)
    '    End If
    'End Sub
    'Private Sub BQuitar_Click(sender As Object, e As EventArgs) Handles BQuitar.Click
    '    Me.Imagen.BackgroundImage = Me.PBAuxImagen.BackgroundImage
    '    Me.Dialogo.FileName = My.Application.Info.DirectoryPath & "\Imagenes\SinImagen.JPG"
    'End Sub
    'Private Sub FInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.FechaC.Value = DateTime.Now()
    '    VieneNuevo = True
    '    Select Case VarForma

    '        Case "ListadoModPrecios", "FCajaNew", "Compra", "VentasDiarias", "InventarioNivelar"
    '            VieneNuevo = False
    '            If (ExisteProd(Me.TCodigo.Text)) Then
    '                MostrarProd()
    '                ExisteProducto = True
    '            Else
    '                If (VieneNuevo = False) Then
    '                    Nuevo_Click(Nothing, Nothing)
    '                    ExisteProducto = False
    '                End If
    '            End If
    '            Me.TNombre.Focus()
    '        Case Else                
    '            Me.Tab_Precio.Parent = Nothing
    '            Me.Tab_Proveedor.Parent = Me.TabPrincipal
    '            Me.Tab_Existencia.Parent = Me.TabPrincipal
    '            Me.Tab_Precio.Parent = Me.TabPrincipal
    '            Nuevo_Click(Nothing, Nothing)
    '    End Select
    'End Sub
    'Private Sub GuardarArticulo()
    '    Dim arrFilename() As String = Split(Text, "\")
    '    Array.Reverse(arrFilename)
    '    Dim ms As New MemoryStream
    '    Imagen.BackgroundImage.Save(ms, Imagen.BackgroundImage.RawFormat)
    '    Dim arrImage() As Byte = ms.GetBuffer
    '    If (Conectar()) Then
    '        Dim Comando As New SqlCommand("INSERT INTO TArticulo (Nombre, Categoria, Fecha, Activo, Imagen, ColorFuente, ColorCat,TFuente,IdProducto,NomProducto,Factor,TipoFuente,Seleccionado, Posicion) VALUES(@Nombre, @Categoria, @Fecha, @Activo, @Imagen, @ColorFuente, @ColorCat, @TFuente, @idProducto,@NomProducto,@Factor,@TipoFuente,@Seleccionado, @Posicion)", CNN)
    '        Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@Categoria", Trim(Me.CCategoria.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaC.Value))
    '        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
    '        Comando.Parameters.Add(New SqlParameter("@Imagen", arrImage))
    '        Comando.Parameters.Add(New SqlParameter("@ColorFuente", Me.LArtEjemplo.ForeColor.ToArgb))
    '        Comando.Parameters.Add(New SqlParameter("@ColorCat", Me.LArtEjemplo.BackColor.ToArgb))
    '        Comando.Parameters.Add(New SqlParameter("@TFuente", Me.LArtEjemplo.Font.Size.ToString))
    '        Comando.Parameters.Add(New SqlParameter("@idProducto", Trim(Me.TCodigo.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@NomProducto", Trim(Me.TNombre.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@Factor", 0))
    '        Comando.Parameters.Add(New SqlParameter("@TipoFuente", Me.LArtEjemplo.Font.Name))
    '        Comando.Parameters.Add(New SqlParameter("@Seleccionado", False))
    '        Comando.Parameters.Add(New SqlParameter("@Posicion", 10000))
    '        Dim DR As SqlDataReader = Comando.ExecuteReader()
    '        DR.Close()
    '        Cursor = System.Windows.Forms.Cursors.Default
    '    End If
    '    Desconectar()
    'End Sub
    'Private Sub ActualizarArticulo()
    '    If (Conectar()) Then
    '        Dim arrFilename() As String = Split(Text, "\")
    '        Array.Reverse(arrFilename)
    '        Dim ms As New MemoryStream
    '        Imagen.BackgroundImage.Save(ms, Imagen.BackgroundImage.RawFormat)
    '        Dim arrImage() As Byte = ms.GetBuffer

    '        Dim Comando As New SqlCommand("UPDATE TArticulo set Nombre=@Nombre, Categoria=@Categoria, Fecha=@Fecha, Activo=@Activo, Imagen=@Imagen, ColorFuente=@ColorFuente, ColorCat=@ColorCat,TFuente=@TFuente,idProducto=@idProducto,NomProducto=@NomProducto, TipoFuente=@TipoFuente WHERE idArticulo=" & Me.TCodigo.Text, CNN)
    '        Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@Categoria", Trim(Me.CCategoria.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaC.Value))
    '        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
    '        Comando.Parameters.Add(New SqlParameter("@Imagen", arrImage))
    '        Comando.Parameters.Add(New SqlParameter("@ColorFuente", Me.LArtEjemplo.ForeColor.ToArgb))
    '        Comando.Parameters.Add(New SqlParameter("@ColorCat", Me.LArtEjemplo.BackColor.ToArgb))
    '        Comando.Parameters.Add(New SqlParameter("@TFuente", Me.LArtEjemplo.Font.Size.ToString))
    '        Comando.Parameters.Add(New SqlParameter("@idProducto", Trim(Me.TCodigo.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@NomProducto", Trim(Me.TNombre.Text)))
    '        Comando.Parameters.Add(New SqlParameter("@TipoFuente", Me.LArtEjemplo.Font.Name))
    '        Dim DR As SqlDataReader = Comando.ExecuteReader()
    '        DR.Close()
    '        Desconectar()
    '    End If
    'End Sub

    ''Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
    ''If (Me.CBDesc.Checked = False) Then
    ''    If MsgBox(" El Producto: " & Me.TProducto.Text & ", Se Guardará «SIN Descuento», Desea Continuar? ", vbYesNo, "MarSoft: Información.") = vbYes Then
    ''    Else
    ''        Exit Sub
    ''    End If
    ''End If
    ''Cursor = System.Windows.Forms.Cursors.WaitCursor
    ''Dim TPEmp1X As Decimal = 0
    ''Dim TPEmp2X As Decimal = 0
    ''Dim TPEmp3X As Decimal = 0
    ''If (Me.TPEmp1.Text <> "") Then
    ''    TPEmp1X = Convert.ToDecimal(Me.TPEmp1.Text)
    ''End If
    ''If (Me.TPEmp2.Text <> "") Then
    ''    TPEmp2X = Convert.ToDecimal(Me.TPEmp2.Text)
    ''End If
    ''If (Me.TPEmp3.Text <> "") Then
    ''    TPEmp3X = Convert.ToDecimal(Me.TPEmp3.Text)
    ''End If

    ''Dim arrFilename() As String = Split(Text, "\")
    ''    Array.Reverse(arrFilename)
    ''Dim ms As New MemoryStream
    ''    Imagen.BackgroundImage.Save(ms, Imagen.BackgroundImage.RawFormat)
    ''Dim arrImage() As Byte = MS.GetBuffer
    ''If (Me.TTipoProducto.Tag = 1) Then
    ''    Me.TTipoReceta.Tag = 1
    ''End If
    ''If (Me.CBEmpaquetado.Checked) Then
    ''    ' CalcularCostosPreciosEmpaquetados()
    ' ''Else
    ''CostoEmp = 0
    ''CostoDEmp = 0
    ''Precio1Emp = 0
    ''Precio2Emp = 0
    ''Precio3Emp = 0
    ''PrecioEfectivoEmp = 0
    ''PrecioMEmp = 0
    ''PrecioD2Emp = 0
    ''PrecioD3Emp = 0
    ''PrecioEfectivoDEmp = 0
    ''PrecioDMEmp = 0
    ''   End If
    ''    If (IsNumeric(Me.TCodigo.Text)) Then
    ''        If (ExisteProducto = False) Then
    ''            If (Me.TCodigo.Text <> "") Then
    ''                If (Me.TNombre.Text <> "") Then
    ''                    CantArtActivo = CantArtActivo + 1
    ''                    '  If (ValidarEmpaquetado()) Then
    ''                    Try
    ''                        If (Conectar()) Then
    ''                            Dim Comando As New SqlCommand("INSERT INTO TNewProducto (idProducto,ImagenF,Nombre, NombreCorto,FechaCreacion, idTipoProducto, idCategoria, idSubCategoria,idCategoriaInt,idUnidad, idUnidadAlt, idMarca, Modelo, Garantia, idProdNacional, Observaciones, Activo, Venta,Decimal,Costo,Costo2,CostoD,Costo2D, PrecioEfectivo, Precio1, Precio2,  Precio3, Precio4,PrecioM,PrecioEfectivoD, PrecioD1, PrecioD2,  PrecioD3, PrecioD4,PrecioDM,Stock,TipoCosto,idIVAC,idIVAV, Capacidad, idUnidadCapacidad,StockDiario, Factor,FactorAlt,Empaquetado, idEmpaquetado,CantEmpaquetado,P1,Remate, PrecioRemate, PrecioRemateD, Mezcla, Pasapalo, CantMinMayor, idTipoReceta, CostoCalUnid, CostoCalUnidD,TipoCostoAlt,VentaUnidAlt, CalculoCap, BaseDolar, PoseeDescuento, PorcMD, PorcCI, PorcVN, CantidadXBandeja) VALUES(@Codigo,@ImagenF, @Nombre, @NombreCorto, @FechaCreacion,  @idTipoProducto, @idCategoria, @idSubCategoria,@idCategoriaInt, @idUnidad, @idUnidadAlt, @idMarca, @Modelo, @Garantia, @idProdNacional, @Observaciones, @Activo, @Venta, @Decimal, @Costo, @Costo2, @CostoD, @Costo2D, @PrecioEfectivo, @Precio1, @Precio2,  @Precio3, @Precio4,@PrecioM, @PrecioEfectivoD, @PrecioD1, @PrecioD2,  @PrecioD3, @PrecioD4,@PrecioDM, @Stock, @TipoCosto, @idIVAC, @idIVAV, @Capacidad, @idUnidadCapacidad, @StockDiario,@Factor,@FactorAlt,@Empaquetado, @idEmpaquetado, @CantEmpaquetado,@P1,@Remate, @PrecioRemate, @PrecioRemateD, @Mezcla, @Pasapalo, @CantMinMayor, @idTipoReceta,@CostoCalUnid,@CostoCalUnidD,@TipoCostoAlt, @VentaUnidAlt, @CalculoCap, @BaseDolar, @PoseeDescuento, @PorcMD, @PorcCI, @PorcVN, @CantXBandeja)", CNN)
    ''                            Comando.Parameters.Add(New SqlParameter("@Codigo", Me.TCodigo.Text))
    ''                            Comando.Parameters.Add(New SqlParameter("@ImagenF", arrImage))
    ''                            Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@FechaCreacion", Me.FechaC.Value))

    ''                            Comando.Parameters.Add(New SqlParameter("@Modelo", Trim(Me.TModelo.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@Garantia", Trim(Me.TGarantia.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idProdNacional", Me.CProdNac.Text))
    ''                            Comando.Parameters.Add(New SqlParameter("@Observaciones", Trim(Me.TDescripcion.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
    ''                            Comando.Parameters.Add(New SqlParameter("@idIVAC", Me.TIVAC.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@idIVAV", Me.TIVAV.Tag))


    ''                            Comando.Parameters.Add(New SqlParameter("@Costo", CostoEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Costo2", CostoEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@CostoD", CostoDEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Costo2D", CostoDEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Precio1", Precio1Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Precio2", Precio2Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Precio3", Precio3Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@Precio4", Precio4Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioEfectivo", PrecioEfectivoEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioD1", PrecioD1Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioD2", PrecioD2Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioD3", PrecioD3Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioD4", PrecioD4Emp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioM", PrecioMEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioDM", PrecioDMEmp))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioEfectivoD", PrecioEfectivoDEmp))

    ''                            Comando.Parameters.Add(New SqlParameter("@Stock", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@Factor", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@FactorAlt", 1))
    ''                            Comando.Parameters.Add(New SqlParameter("@TipoCosto", 1))
    ''                            Comando.Parameters.Add(New SqlParameter("@StockDiario", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@P1", True))
    ''                            Comando.Parameters.Add(New SqlParameter("@Remate", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioRemate", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@PrecioRemateD", 0))

    ''                            Comando.Parameters.Add(New SqlParameter("@CantMinMayor", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@CostoCalUnidD", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@CostoCalUnid", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@TipoCostoAlt", 0))
    ''                            Comando.Parameters.Add(New SqlParameter("@CalculoCap", CalcularConCapacidad))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcMD", TPEmp1X))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcCI", TPEmp2X))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcVN", TPEmp3X))
    ''                            Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''                            DR.Close()
    ''                            Cursor = System.Windows.Forms.Cursors.Default
    ''                            If (VarBuscar <> "NoMostrar") Then
    ''                                MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                            End If
    ''                            ExisteProducto = True
    ''                            Comando.CommandText = "INSERT INTO TCodigosAlternos (idProd, CodBarra) VALUES('" & Me.TCodigo.Text & "', '" & Me.TCodigo.Text & "')"
    ''                            DR = Comando.ExecuteReader()
    ''                            DR.Close()
    ''                        End If
    ''                        Desconectar()
    ''                        GuardarArticulo()
    ''                    Catch ex As Exception
    ''                        Cursor = System.Windows.Forms.Cursors.Default
    ''                        MsgBox("Error al Guardar los Datos del Productos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    ''                        Desconectar()
    ''                        Desconectar2()
    ''                    End Try
    ''                    'Else
    ''                    '    Cursor = System.Windows.Forms.Cursors.Default
    ''                    '    MsgBox("Debe Seleccionar el Producto a Empaquetar.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                    '    Me.TEmpaquetado.Focus()
    ''                    'End If
    ''                Else
    ''                    Cursor = System.Windows.Forms.Cursors.Default
    ''                    MsgBox("El Nombre del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                    Me.TNombre.Focus()
    ''                End If
    ''            Else
    ''                Cursor = System.Windows.Forms.Cursors.Default
    ''                MsgBox("El Código del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                Me.TCodigo.Focus()
    ''            End If
    ''        Else
    ''            If (Me.TCodigo.Text <> "") Then
    ''                If (Me.TNombre.Text <> "") Then
    ''                    Try
    ''                        If (Conectar()) Then
    ''                            Dim Comando As New SqlCommand("UPDATE TNewProducto set ImagenF=@ImagenF, Nombre=@Nombre, NombreCorto=@NombreCorto, FechaCreacion=@FechaCreacion, idTipoProducto=@idTipoProducto, idCategoria=@idCategoria, idSubCategoria=@idSubCategoria,idCategoriaInt=@idCategoriaInt, idUnidad=@idUnidad, idUnidadAlt=@idUnidadAlt, idMarca=@idMarca, Modelo=@Modelo, Garantia=@Garantia, idProdNacional=@idProdNacional, Observaciones=@Observaciones, Activo=@Activo, Venta=@Venta,Decimal=@Decimal,idIVAC=@idIVAC,idIVAV=@idIVAV, Capacidad=@Capacidad, idUnidadCapacidad=@idUnidadCapacidad, Empaquetado=@Empaquetado, idEmpaquetado=@idEmpaquetado, CantEmpaquetado=@CantEmpaquetado, Mezcla=@Mezcla, Pasapalo=@Pasapalo, idTipoReceta=@idTipoReceta, VentaUnidAlt=@VentaUnidAlt, CalculoCap=@CalculoCap, BaseDolar=@BaseDolar , PoseeDescuento=@PoseeDescuento, PorcMD=@PorcMD, PorcCI=@PorcCI, PorcVN=@PorcVN,CantidadXBandeja=@CantXBandeja WHERE idProducto=" & Me.TCodigo.Text, CNN)
    ''                            Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@ImagenF", arrImage))
    ''                            Comando.Parameters.Add(New SqlParameter("@NombreCorto", Trim(Me.TNombreCorto.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@FechaCreacion", Me.FechaC.Value))
    ''                            Comando.Parameters.Add(New SqlParameter("@idTipoProducto", Me.TTipoProducto.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@idCategoria", Trim(Me.TCategoria.Tag)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idSubCategoria", Trim(Me.TSubCategoria.Tag)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idCategoriaInt", Trim(Me.TCategoriaInt.Tag)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idUnidad", Me.TUnidad.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@idUnidadAlt", Me.TUnidadAlt.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@idMarca", Me.TMarca.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@Modelo", Trim(Me.TModelo.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@Garantia", Trim(Me.TGarantia.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idProdNacional", Me.TProducto.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@Observaciones", Trim(Me.TDescripcion.Text)))
    ''                            Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
    ''                            Comando.Parameters.Add(New SqlParameter("@Venta", Me.CBVenta.Checked.ToString))
    ''                            Comando.Parameters.Add(New SqlParameter("@Decimal", Me.CBBalanza.Checked.ToString))
    ''                            Comando.Parameters.Add(New SqlParameter("@idIVAC", Me.TIVAC.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@idIVAV", Me.TIVAV.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@Capacidad", Convert.ToDecimal(IIf(Me.TCantidadIng.Text = "", "1", Me.TCantidadIng.Text))))
    ''                            Comando.Parameters.Add(New SqlParameter("@idUnidadCapacidad", Me.TUnidadCap.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@Empaquetado", Me.CBEmpaquetado.Checked.ToString))
    ''                            Comando.Parameters.Add(New SqlParameter("@idEmpaquetado", IIf(Me.TEmpaquetado.Tag = "", "0", Me.TEmpaquetado.Tag)))
    ''                            Comando.Parameters.Add(New SqlParameter("@CantEmpaquetado", Convert.ToDecimal(IIf(Me.TCantEmp.Text = "", "0", Me.TCantEmp.Text))))
    ''                            Comando.Parameters.Add(New SqlParameter("@Mezcla", Convert.ToBoolean(Me.CBMezcla.Checked)))
    ''                            Comando.Parameters.Add(New SqlParameter("@Pasapalo", Convert.ToBoolean(Me.CBPasapalo.Checked)))
    ''                            Comando.Parameters.Add(New SqlParameter("@idTipoReceta", Me.TTipoReceta.Tag))
    ''                            Comando.Parameters.Add(New SqlParameter("@VentaUnidAlt", Me.CBVentaUnidAlt.Checked))
    ''                            CalcularConCapacidad = Me.CBCalculoCap.Checked
    ''                            Comando.Parameters.Add(New SqlParameter("@CalculoCap", CalcularConCapacidad))
    ''                            Comando.Parameters.Add(New SqlParameter("@BaseDolar", Me.CBBaseDolar.Checked))
    ''                            Comando.Parameters.Add(New SqlParameter("@PoseeDescuento", Me.CBDesc.Checked))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcMD", TPEmp1X))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcCI", TPEmp2X))
    ''                            Comando.Parameters.Add(New SqlParameter("@PorcVN", TPEmp3X))
    ''                            Comando.Parameters.Add(New SqlParameter("@CantXBandeja", Convert.ToInt32(Me.TCantXBandeja.Text)))

    ''                            Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''                            DR.Close()
    ''                            Desconectar()
    ''                            '  ActualizarArticulo()
    ''                            Cursor = System.Windows.Forms.Cursors.Default
    ''                            If (VarBuscar <> "NoMostrar") Then
    ''                                MsgBox("Los Datos Fueron Actualizados con Exito!!!")
    ''                            End If
    ''                            ValidarCategoriaInterna(Me.TCategoriaInt.Tag)
    ''                            ExisteProducto = True
    ''                        End If
    ''                    Catch ex As Exception
    ''                        Cursor = System.Windows.Forms.Cursors.Default
    ''                        MsgBox("Error al Editar Datos de Productos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    ''                        Desconectar()
    ''                    End Try
    ''                End If
    ''                'Else
    ''                '    Cursor = System.Windows.Forms.Cursors.Default
    ''                '    MsgBox("Debe Seleccionar el Producto a Empaquetar.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                '    Me.TEmpaquetado.Focus()
    ''                'End If
    ''            Else
    ''                Cursor = System.Windows.Forms.Cursors.Default
    ''                MsgBox("El Nombre del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''                Me.TNombre.Focus()
    ''            End If
    ''            '        Else
    ''            '            Cursor = System.Windows.Forms.Cursors.Default
    ''            '            MsgBox("El Código del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''            '            Me.TCodigo.Focus()
    ''            '        End If
    ''            'Else
    ''            '    Cursor = System.Windows.Forms.Cursors.Default
    ''            '    MsgBox("Error al Crear el Código del Producto, Por Favor Verifique Si Se Creo la Sub-Categoria del Producto.", MsgBoxStyle.Information, "MarSoft: Información.")
    ''            '    Me.TCodigo.Focus()
    ''            'End If
    ''End Sub
    'Function ValidarEliminar()
    '    Dim Respuesta As Boolean = True
    '    If (Conectar()) Then
    '        Try
    '            Dim Comando As New SqlCommand("Select idProducto  FROM TDetalleVenta WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            If (DR.Read) Then
    '                Respuesta = False
    '                Exit Try
    '            End If
    '            DR.Close()
    '            Comando.CommandText = "Select idProducto  FROM TDetalleCompra WHERE idProducto=" & Me.TCodigo.Text
    '            DR = Comando.ExecuteReader()
    '            If (DR.Read) Then
    '                Respuesta = False
    '            End If
    '            DR.Close()
    '        Catch ex As Exception
    '            MsgBox("Error al Eliminar Datos Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    '    Return (Respuesta)
    'End Function
    'Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
    '    If (ValidarEliminar()) Then
    '        If MsgBox("Esta seguro que desea Eliminar este Producto: " & Me.TCodigo.Text & "?", vbYesNo, "MarSoft: Eliminar Producto.") = vbYes Then
    '            If (Me.TCodigo.Text <> "") Then
    '                If (Conectar()) Then
    '                    Try
    '                        Dim Comando As New SqlCommand("DELETE FROM TRecetas WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                        Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                        DR.Close()
    '                        Comando.CommandText = "DELETE FROM TRecetaDatos WHERE idProducto=" & Me.TCodigo.Text
    '                        DR = Comando.ExecuteReader()
    '                        DR.Close()
    '                        Comando.CommandText = "DELETE FROM TNewProducto WHERE idProducto=" & Me.TCodigo.Text
    '                        DR = Comando.ExecuteReader()
    '                        DR.Close()
    '                        Comando.CommandText = "DELETE FROM TArticulo WHERE idProducto=" & Me.TCodigo.Text
    '                        DR = Comando.ExecuteReader()
    '                        DR.Close()
    '                        Nuevo_Click(Nothing, Nothing)
    '                        Me.TCodigo.Text = ""
    '                    Catch ex As Exception
    '                        MsgBox("Error al Eliminar Datos Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '                        Desconectar()
    '                    End Try
    '                End If
    '                Desconectar()
    '            End If
    '        End If
    '    Else
    '        MsgBox("Este Producto No Puede Ser Eliminado, se encuentra en Uso.  ", MsgBoxStyle.Information, "MarSoft: Información.")
    '    End If
    'End Sub

    'Private Sub Nuevo_Click(sender As Object, e As EventArgs)
    '    Me.TCodigo.Text = ""
    '    Me.TNombre.Text = ""

    '    Me.CMarca.Text = "_Ninguna"
    '    Me.CMarca.Tag = 63

    '    Me.TModelo.Text = ""

    '    Me.CCategoria.Text = "Viveres"
    '    Me.CCategoria.Tag = 8
    '    BuscarColorCategoria()

    '    Me.CSubCategoria.Text = "Viveres"
    '    Me.CSubCategoria.Tag = 100



    '    Me.TDescripcion.Text = ""
    '    Me.FechaC.Value = Date.Now
    '    Me.CBActivo.Checked = True

    '    Me.DGVProveedor.Rows.Clear()
    '    Me.TStock.Text = ""
    '    Me.TExistenciaMin.Text = ""
    '    Me.TExistenciaMax.Text = ""
    '    Me.TIVAC.Text = "0"
    '    Me.TIVAC.Tag = 8
    '    Me.TIVAV.Text = "0"
    '    Me.TIVAV.Tag = 8
    '    Me.Imagen.BackgroundImage = Me.PBAuxImagen.BackgroundImage
    '    Me.TabPrincipal.SelectedIndex = 0

    '    Me.LArtEjemplo.BackColor = Color.LightBlue
    '    Me.LArtEjemplo.ForeColor = Color.White
    '    Me.TCodigo.Focus()
    'End Sub
    'Private Sub BuscarPrecios()
    '    'CalcularDolar(DateTime.Now, 0)
    '    'If Conectar() Then
    '    '    Dim Comando As New SqlCommand("SELECT Costo, CostoD, CostoCalUnid, Costo2, CostoCalUnidD , Costo2D, Precio1, Precio2, Precio3,Precio4,PrecioEfectivo,PrecioD1, PrecioD2, PrecioD3,PrecioD4,PrecioEfectivoD, IVAC, IVAV, idIVAC, idIVAV, idTipoProducto, Venta, PrecioM, PrecioDM, PrecioRemate, PrecioRemateD, VentaUnidAlt, BaseDolar FROM VNewProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '    '    Dim DatosArt As SqlDataReader = Comando.ExecuteReader()

    '    '    Do While DatosArt.Read()
    '    '        Me.TCosto.Text = Format(DatosArt("CostoD") * BsXDolarBC, "##,##0.00")
    '    '        Me.TCostoD.Text = Format(DatosArt("CostoD"), "##,##0.00")

    '    '        Me.TIVAC.Text = DatosArt("IVAC").ToString
    '    '        Me.TIVAC.Tag = DatosArt("idIVAC")
    '    '        Me.TIVAV.Text = DatosArt("IVAV").ToString
    '    '        Me.TIVAV.Tag = DatosArt("idIVAV")
    '    '        Me.Precio1SinImp.Text = Format(DatosArt("Precio1"), "##,##0.00")

    '    '        Me.PrecioMSinImp.Text = Format(DatosArt("PrecioM"), "##,##0.00")
    '    '        Me.PrecioRemSinImp.Text = Format(DatosArt("PrecioRemate"), "##,##0.00")

    '    '        Me.Precio1D.Text = Format(DatosArt("PrecioD1"), "##,##0.00")

    '    '        Me.PrecioMD.Text = Format(DatosArt("PrecioDM"), "##,##0.00")
    '    '        Me.PrecioRemD.Text = Format(DatosArt("PrecioRemateD"), "##,##0.00")


    '    '        Me.TImpuestoC.Text = Format(ImpuestoC, "##,##0.00")
    '    '        Me.TImpuestoCD.Text = Format(ImpuestoCD, "##,##0.00")
    '    '        Me.TImpuestoV.Text = Format(Impuesto, "##,##0.00")
    '    '        Me.TImpuestoVD.Text = Format(ImpuestoD, "##,##0.00")


    '    '        Me.Precio1CI.Text = Format(DatosArt("Precio1") + Impuesto, "##,##0.00")
    '    '        Me.Precio2CI.Text = Format(DatosArt("Precio2") + Impuesto, "##,##0.00")
    '    '        Me.Precio3CI.Text = Format(DatosArt("Precio3") + Impuesto, "##,##0.00")
    '    '        Me.PrecioECI.Text = Format(DatosArt("PrecioEfectivo") + Impuesto, "##,##0.00")
    '    '        Me.PrecioMCI.Text = Format(DatosArt("PrecioM") + Impuesto, "##,##0.00")
    '    '        Me.PrecioRemCI.Text = Format(DatosArt("PrecioRemate") + Impuesto, "##,##0.00")


    '    '        Me.Precio1DCI.Text = Format(DatosArt("PrecioD1") + ImpuestoD, "##,##0.00")
    '    '        Me.Precio2DCI.Text = Format(DatosArt("PrecioD2") + ImpuestoD, "##,##0.00")
    '    '        Me.Precio3DCI.Text = Format(DatosArt("PrecioD3") + ImpuestoD, "##,##0.00")
    '    '        Me.PrecioEDCI.Text = Format(DatosArt("PrecioEfectivoD") + ImpuestoD, "##,##0.00")

    '    '        Me.PrecioMDCI.Text = Format(DatosArt("PrecioDM") + ImpuestoD, "##,##0.00")
    '    '        Me.PrecioRemDCI.Text = Format(DatosArt("PrecioRemateD") + ImpuestoD, "##,##0.00")


    '    '        Dim Utilidad As Double = 0
    '    '        Utilidad = Convert.ToDouble(Me.Precio1SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.Precio1SinImp.Text = 0) Then
    '    '            Me.Precio1UC.Text = "0,00"
    '    '            Me.Precio1UP.Text = "0,00"
    '    '        Else
    '    '            Me.Precio1UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.Precio1UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio1SinImp.Text), "##,##0.00")
    '    '        End If

    '    '        Utilidad = Convert.ToDouble(Me.Precio2SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.Precio2SinImp.Text = 0) Then
    '    '            Me.Precio2UC.Text = "0,00"
    '    '            Me.Precio2UP.Text = "0,00"
    '    '        Else
    '    '            Me.Precio2UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.Precio2UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio2SinImp.Text), "##,##0.00")
    '    '        End If

    '    '        Utilidad = Convert.ToDouble(Me.Precio3SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.Precio3SinImp.Text = 0) Then
    '    '            Me.Precio3UC.Text = "0,00"
    '    '            Me.Precio3UP.Text = "0,00"
    '    '        Else
    '    '            Me.Precio3UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.Precio3UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio3SinImp.Text), "##,##0.00")
    '    '        End If

    '    '        Utilidad = Convert.ToDouble(Me.PrecioESinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.PrecioESinImp.Text = 0) Then
    '    '            Me.PrecioEUC.Text = "0,00"
    '    '            Me.PrecioEUP.Text = "0,00"
    '    '        Else
    '    '            Me.PrecioEUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.PrecioEUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioESinImp.Text), "##,##0.00")
    '    '        End If


    '    '        Utilidad = Convert.ToDouble(Me.PrecioMSinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.PrecioMSinImp.Text = 0) Then
    '    '            Me.PrecioMUC.Text = "0,00"
    '    '            Me.PrecioMUP.Text = "0,00"
    '    '        Else
    '    '            Me.PrecioMUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.PrecioMUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioMSinImp.Text), "##,##0.00")
    '    '        End If

    '    '        Utilidad = Convert.ToDouble(Me.PrecioRemSinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    '    '        If (Me.PrecioRemSinImp.Text = 0) Then
    '    '            Me.PrecioRemUC.Text = "0,00"
    '    '            Me.PrecioRemUP.Text = "0,00"
    '    '        Else
    '    '            Me.PrecioRemUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    '    '            Me.PrecioRemUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioRemSinImp.Text), "##,##0.00")
    '    '        End If
    '    '        If (DatosArt("BaseDolar")) Then
    '    '            Me.Moneda.BackgroundImage = Me.ImagenD.Image
    '    '        Else
    '    '            Me.Moneda.BackgroundImage = Me.ImagenBs.Image
    '    '        End If
    '    '        Me.LP2.Text = PPrecio2 & "% "
    '    '        Me.LP3.Text = PPrecio3 & "% "
    '    '        Me.LPE.Text = PPrecioE & "% "
    '    '    Loop
    '    '    DatosArt.Close()
    '    '    Desconectar()
    '    'End If
    'End Sub
    ' '''''aqui cambio'''''''''''''''
    ''Private Function TotalCostoCompuesto() As Decimal
    ''    Dim TCostoIng As Decimal = 0
    ''    If (Conectar2()) Then
    ''        Dim Comando2 As New SqlCommand("SELECT * FROM VIngredientesRecetas WHERE idProducto=" & Me.TCodigo.Text, CNN2)
    ''        Dim DR As SqlDataReader = Comando2.ExecuteReader()
    ''        While DR.Read
    ''            Dim TipoFactorAlt As String
    ''            If DR("TipoFactorAlt").ToString = "" Then
    ''                TipoFactorAlt = DR("UnidadIng").ToString & " X"
    ''            Else
    ''                TipoFactorAlt = DR("TipoFactorAlt").ToString
    ''            End If
    ''            TCostoIng = TCostoIng + CalcularCostoCompuesto(DR("UnidadProd"), DR("CantidadIng"), DR("UnidadIng").ToString, DR("Capacidad"), DR("UnidadCapacidad"), DR("Costo2"), DR("UnidadAlt"), DR("FactorAlt"), TipoFactorAlt)
    ''        End While
    ''        DR.Close()
    ''        Desconectar2()
    ''    End If
    ''    Return (TCostoIng)
    ''End Function
    ''Private Sub BuscarPreciosCompuestos()
    ''    If Conectar() Then
    ''        Dim Comando As New SqlCommand("SELECT Costo, CostoD, Costo2, Costo2D, Precio1, Precio2, Precio3,Precio4,PrecioEfectivo,PrecioD1, PrecioD2, PrecioD3,PrecioD4,PrecioEfectivoD, IVAC, IVAV, idIVAC, idIVAV FROM VNewProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
    ''        Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
    ''        Do While DatosArt.Read()
    ''            Me.TCosto.Text = DatosArt("Costo")
    ''            Me.TCostoD.Text = DatosArt("CostoD")
    ''            Me.TCostoCal.Text = DatosArt("Costo") 'Format(TotalCostoCompuesto, "##,##0.00")
    ''            Me.TCostoCalD.Text = DatosArt("CostoD")

    ''            Me.TIVAC.Text = DatosArt("IVAC").ToString
    ''            Me.TIVAC.Tag = DatosArt("idIVAC")
    ''            Me.TIVAV.Text = DatosArt("IVAV").ToString
    ''            Me.TIVAV.Tag = DatosArt("idIVAV")
    ''            Me.Precio1SinImp.Text = Format(DatosArt("Precio1"), "##,##0.00")
    ''            Me.Precio2SinImp.Text = Format(DatosArt("Precio2"), "##,##0.00")
    ''            Me.Precio3SinImp.Text = Format(DatosArt("Precio3"), "##,##0.00")
    ''            Me.PrecioESinImp.Text = Format(DatosArt("PrecioEfectivo"), "##,##0.00")

    ''            Me.Precio1D.Text = Format(DatosArt("PrecioD1"), "##,##0.00")
    ''            Me.Precio2D.Text = Format(DatosArt("PrecioD2"), "##,##0.00")
    ''            Me.Precio3D.Text = Format(DatosArt("PrecioD3"), "##,##0.00")
    ''            Me.PrecioED.Text = Format(DatosArt("PrecioEfectivoD"), "##,##0.00")

    ''            Dim ImpuestoC As Decimal = (DatosArt("Costo2") / 100) * DatosArt("IvaC")
    ''            Dim ImpuestoCD As Decimal = (DatosArt("Costo2D") / 100) * DatosArt("IvaC")
    ''            Dim Impuesto As Decimal = (DatosArt("Costo2") / 100) * DatosArt("IvaV")
    ''            Dim ImpuestoD As Decimal = (DatosArt("Costo2D") / 100) * DatosArt("IvaV")
    ''            Me.TImpuestoC.Text = Format(ImpuestoC, "##,##0.00")
    ''            Me.TImpuestoCD.Text = Format(ImpuestoCD, "##,##0.00")
    ''            Me.TImpuestoV.Text = Format(Impuesto, "##,##0.00")
    ''            Me.TImpuestoVD.Text = Format(ImpuestoD, "##,##0.00")
    ''            Me.Precio1CI.Text = Format(DatosArt("Precio1") + Impuesto, "##,##0.00")
    ''            Me.Precio2CI.Text = Format(DatosArt("Precio2") + Impuesto, "##,##0.00")
    ''            Me.Precio3CI.Text = Format(DatosArt("Precio3") + Impuesto, "##,##0.00")
    ''            Me.PrecioECI.Text = Format(DatosArt("PrecioEfectivo") + Impuesto, "##,##0.00")
    ''            Me.Precio1DCI.Text = Format(DatosArt("PrecioD1") + ImpuestoD, "##,##0.00")
    ''            Me.Precio2DCI.Text = Format(DatosArt("PrecioD2") + ImpuestoD, "##,##0.00")
    ''            Me.Precio3DCI.Text = Format(DatosArt("PrecioD3") + ImpuestoD, "##,##0.00")
    ''            Me.PrecioEDCI.Text = Format(DatosArt("PrecioEfectivoD") + ImpuestoD, "##,##0.00")

    ''            Dim Utilidad As Double = 0
    ''            Utilidad = Convert.ToDouble(Me.Precio1SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.Precio1SinImp.Text = 0) Then
    ''                Me.Precio1UC.Text = ""
    ''                Me.Precio1UP.Text = ""
    ''            Else
    ''                Me.Precio1UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.Precio1UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio1CI.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.Precio2SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.Precio2SinImp.Text = 0) Then
    ''                Me.Precio2UC.Text = ""
    ''                Me.Precio2UP.Text = ""
    ''            Else
    ''                Me.Precio2UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.Precio2UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio2CI.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.Precio3SinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.Precio3SinImp.Text = 0) Then
    ''                Me.Precio3UC.Text = ""
    ''                Me.Precio3UP.Text = ""
    ''            Else
    ''                Me.Precio3UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.Precio3UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio3CI.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.PrecioESinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.PrecioESinImp.Text = 0) Then
    ''                Me.PrecioEUC.Text = ""
    ''                Me.PrecioEUP.Text = ""
    ''            Else
    ''                Me.PrecioEUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.PrecioEUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioECI.Text), "##,##0.00")
    ''            End If
    ''            Me.LP2.Text = PPrecio2 & "% "
    ''            Me.LP3.Text = PPrecio3 & "% "
    ''            Me.LPE.Text = PPrecioE & "% "
    ''        Loop
    ''        DatosArt.Close()
    ''        Desconectar()
    ''        ' Me.TCostoCalD.Text = Format(CalcularDolar(DateTime.Now, Me.TCostoCal.Text), "##,##0.00")
    ''    End If
    ''End Sub

    ''Private Sub BuscarSoloPrecios()

    ''    If Conectar() Then
    ''        Dim Comando As New SqlCommand("SELECT CostoCalUnid , Costo2, CostoCalUnidD , Costo2D, Precio1, Precio2, Precio3,Precio4,PrecioEfectivo,PrecioD1, PrecioD2, PrecioD3,PrecioD4,PrecioEfectivoD, IVAC, IVAV, idIVAC, idIVAV, CalculoCap, idTipoProducto, Venta, PrecioM, PrecioDM, PrecioRemate, PrecioRemateD,VentaUnidAlt FROM VNewProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
    ''        Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
    ''        Do While DatosArt.Read()
    ''            Me.Precio1SinImp.Text = Format(DatosArt("Precio1"), "##,##0.00")
    ''            Me.Precio2SinImp.Text = Format(DatosArt("Precio2"), "##,##0.00")
    ''            Me.Precio3SinImp.Text = Format(DatosArt("Precio3"), "##,##0.00")
    ''            Me.PrecioESinImp.Text = Format(DatosArt("PrecioEfectivo"), "##,##0.00")
    ''            Me.PrecioMSinImp.Text = Format(DatosArt("PrecioM"), "##,##0.00")
    ''            Me.PrecioRemSinImp.Text = Format(DatosArt("PrecioRemate"), "##,##0.00")


    ''            Me.Precio1D.Text = Format(DatosArt("PrecioD1"), "##,##0.00")
    ''            Me.Precio2D.Text = Format(DatosArt("PrecioD2"), "##,##0.00")
    ''            Me.Precio3D.Text = Format(DatosArt("PrecioD3"), "##,##0.00")
    ''            Me.PrecioED.Text = Format(DatosArt("PrecioEfectivoD"), "##,##0.00")
    ''            Me.PrecioMD.Text = Format(DatosArt("PrecioDM"), "##,##0.00")
    ''            Me.PrecioRemD.Text = Format(DatosArt("PrecioRemateD"), "##,##0.00")

    ''            Dim CostoXX As Decimal = 0
    ''            Dim CostoDXX As Decimal = 0

    ''            If (DatosArt("VentaUnidAlt")) Then
    ''                CostoXX = Format(DatosArt("Costo2D") * BsXDolarBC, "##,##0.00")
    ''                CostoDXX = Format(DatosArt("Costo2D"), "##,##0.00")
    ''            Else
    ''                CostoXX = Format(DatosArt("CostoCalUnidD") * BsXDolarBC, "##,##0.00")
    ''                CostoDXX = Format(DatosArt("CostoCalUnidD"), "##,##0.00")
    ''            End If

    ''            Dim ImpuestoC As Decimal = (CostoXX / 100) * DatosArt("IvaC")
    ''            Dim ImpuestoCD As Decimal = (CostoDXX / 100) * DatosArt("IvaC")
    ''            Dim Impuesto As Decimal = (CostoXX / 100) * DatosArt("IvaV")
    ''            Dim ImpuestoD As Decimal = (CostoDXX / 100) * DatosArt("IvaV")
    ''            Me.TImpuestoC.Text = Format(ImpuestoC, "##,##0.00")
    ''            Me.TImpuestoCD.Text = Format(ImpuestoCD, "##,##0.00")
    ''            Me.TImpuestoV.Text = Format(Impuesto, "##,##0.00")
    ''            Me.TImpuestoVD.Text = Format(ImpuestoD, "##,##0.00")

    ''            Me.Precio1CI.Text = Format(DatosArt("Precio1") + Impuesto, "##,##0.00")
    ''            Me.Precio2CI.Text = Format(DatosArt("Precio2") + Impuesto, "##,##0.00")
    ''            Me.Precio3CI.Text = Format(DatosArt("Precio3") + Impuesto, "##,##0.00")
    ''            Me.PrecioECI.Text = Format(DatosArt("PrecioEfectivo") + Impuesto, "##,##0.00")
    ''            Me.PrecioMCI.Text = Format(DatosArt("PrecioM") + ImpuestoD, "##,##0.00")
    ''            Me.PrecioRemCI.Text = Format(DatosArt("PrecioRemate") + ImpuestoD, "##,##0.00")

    ''            Me.Precio1DCI.Text = Format(DatosArt("PrecioD1") + ImpuestoD, "##,##0.00")
    ''            Me.Precio2DCI.Text = Format(DatosArt("PrecioD2") + ImpuestoD, "##,##0.00")
    ''            Me.Precio3DCI.Text = Format(DatosArt("PrecioD3") + ImpuestoD, "##,##0.00")
    ''            Me.PrecioEDCI.Text = Format(DatosArt("PrecioEfectivoD") + ImpuestoD, "##,##0.00")
    ''            Me.PrecioMDCI.Text = Format(DatosArt("PrecioDM") + ImpuestoD, "##,##0.00")
    ''            Me.PrecioRemDCI.Text = Format(DatosArt("PrecioRemateD") + ImpuestoD, "##,##0.00")

    ''            Dim Utilidad As Double = 0
    ''            Utilidad = Convert.ToDouble(Me.Precio1SinImp.Text) - CostoXX
    ''            If (Me.Precio1SinImp.Text = 0) Then
    ''                Me.Precio1UC.Text = "0,00"
    ''                Me.Precio1UP.Text = "0,00"
    ''            Else
    ''                Me.Precio1UC.Text = Format((Utilidad * 100) / CostoXX, "##,##0.00")
    ''                Me.Precio1UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio1SinImp.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.Precio2SinImp.Text) - CostoXX
    ''            If (Me.Precio2SinImp.Text = 0) Then
    ''                Me.Precio2UC.Text = "0,00"
    ''                Me.Precio2UP.Text = "0,00"
    ''            Else
    ''                Me.Precio2UC.Text = Format((Utilidad * 100) / CostoXX, "##,##0.00")
    ''                Me.Precio2UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio2SinImp.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.Precio3SinImp.Text) - CostoXX
    ''            If (Me.Precio3SinImp.Text = 0) Then
    ''                Me.Precio3UC.Text = "0,00"
    ''                Me.Precio3UP.Text = "0,00"
    ''            Else
    ''                Me.Precio3UC.Text = Format((Utilidad * 100) / CostoXX, "##,##0.00")
    ''                Me.Precio3UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio3SinImp.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.PrecioESinImp.Text) - CostoXX
    ''            If (Me.PrecioESinImp.Text = 0) Then
    ''                Me.PrecioEUC.Text = "0,00"
    ''                Me.PrecioEUP.Text = "0,00"
    ''            Else
    ''                Me.PrecioEUC.Text = Format((Utilidad * 100) / CostoXX, "##,##0.00")
    ''                Me.PrecioEUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioESinImp.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.PrecioMSinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.PrecioMSinImp.Text = 0) Then
    ''                Me.PrecioMUC.Text = "0,00"
    ''                Me.PrecioMUP.Text = "0,00"
    ''            Else
    ''                Me.PrecioMUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.PrecioMUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioMSinImp.Text), "##,##0.00")
    ''            End If

    ''            Utilidad = Convert.ToDouble(Me.PrecioRemSinImp.Text) - Convert.ToDouble(Me.TCostoCal.Text)
    ''            If (Me.PrecioRemSinImp.Text = 0) Then
    ''                Me.PrecioRemUC.Text = "0,00"
    ''                Me.PrecioRemUP.Text = "0,00"
    ''            Else
    ''                Me.PrecioRemUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCostoCal.Text), "##,##0.00")
    ''                Me.PrecioRemUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioRemSinImp.Text), "##,##0.00")
    ''            End If

    ''            Me.LP2.Text = PPrecio2 & "% "
    ''            Me.LP3.Text = PPrecio3 & "% "
    ''            Me.LPE.Text = PPrecioE & "% "
    ''        Loop
    ''        DatosArt.Close()
    ''        Desconectar()
    ''    End If
    ''End Sub
    ''Private Sub CalcularPorcCosto()
    ''    Dim TotalCostos As Decimal = 0
    ''    Dim Porc As Decimal = 0
    ''    TotalCostos = Format(SumarColumnaEscalado(DGIngrediente, 10), "##,##0.0000")
    ''    For i = 0 To DGIngrediente.RowCount - 1
    ''        If (TotalCostos = "0") Then
    ''            Me.DGIngrediente.Item("PorcCosto", i).Value = "0"
    ''        Else
    ''            If (TotalCostos = 0) Then
    ''                Porc = 0
    ''            Else
    ''                Porc = (Convert.ToDecimal(IIf(Me.DGIngrediente.Item("Costo1", i).Value.ToString = "", 0, Me.DGIngrediente.Item("Costo1", i).Value)) / TotalCostos) * 100
    ''            End If
    ''            Me.DGIngrediente.Item("PorcCosto", i).Value = Format(Porc, "##,##0.00")
    ''        End If
    ''    Next
    ''End Sub
    ''Private Sub CalcularPorcCosto()
    ''    For i = 0 To DGIngrediente.RowCount - 1
    ''        Me.DGIngrediente.Item("PorcCosto", i).Value = (Convert.ToDecimal(Me.DGIngrediente.Item("Costo1", i).Value) / Me.DGIngrediente.Item("Costo1", Me.DGIngrediente.RowCount - 1).Value) * 100
    ''        Me.DGIngrediente.Item("PorcCosto", i).Value = Format(Convert.ToDecimal(Me.DGIngrediente.Item("PorcCosto", i).Value), "##,##0.00")
    ''    Next
    ''End Sub
    ''Private Sub LlenarAdaptadorIngEmpaquetado(CantEmp As Decimal)
    ''    If (Me.TEmpaquetado.Tag.ToString <> "") Then
    ''        Try
    ''            If (Conectar()) Then
    ''                Dim Comando As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY Principal DESC) AS Num, Principal, idIngrediente,Ingrediente,idUnidad,Unidad, CantIngU,PorcIng, CostoUD, CostoU,id FROM VRecetaGuardada WHERE idProducto=" & Trim(Me.TEmpaquetado.Tag), CNN)
    ''                Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''                Me.DGIngrediente.Rows.Clear()
    ''                Do While DR.Read()
    ''                    Me.DGIngrediente.Rows.Add(DR("id"), DR("Num"), DR("Principal"), DR("idIngrediente"), DR("Ingrediente"), DR("CantIngU") * CantEmp, DR("idUnidad"), DR("Unidad"), DR("PorcIng"), Format(DR("CostoUD") * CantEmp, "##,##0.00"), Format(DR("CostoU") * CantEmp, "##,##0.00"), 0)
    ''                Loop
    ''                DR.Close()
    ''                Desconectar()
    ''            End If
    ''        Catch ex As Exception
    ''            MsgBox("Error al Mostrar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    ''            Desconectar()
    ''        End Try
    ''    End If
    ''    CostoEmp = SumarColumna(DGIngrediente, 10)
    ''    CostoDEmp = SumarColumna(DGIngrediente, 9)
    ''    CalcularPorcCosto()
    ''    Me.DGIngrediente.Sort(Me.DGIngrediente.Columns(11), System.ComponentModel.ListSortDirection.Descending)
    ''    Me.DGIngrediente.Rows.Add("", "", False, "", "                                        Totales:", Format(SumarColumna(DGIngrediente, 5), "##,##0.00"), "", "", "", Format(CostoDEmp, "##,##0.00"), Format(CostoEmp, "##,##0.00"), Format(SumarColumna(DGIngrediente, 11), "##,##0.00"))
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).DefaultCellStyle.BackColor = Color.PaleTurquoise
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).Height = 25
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
    ''End Sub

    'Private Sub DGIngrediente_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs)
    '    Dim Var As String = Nothing
    '    If (e.Column.Name = "PorcCosto") Then
    '        If (e.CellValue1 = Var) Then
    '            e.SortResult = -1
    '        ElseIf (e.CellValue2 = Var) Then
    '            e.SortResult = -1
    '        Else
    '            If Double.Parse(e.CellValue1) > Double.Parse(e.CellValue2) Then
    '                e.SortResult = 1
    '            ElseIf Double.Parse(e.CellValue1) < Double.Parse(e.CellValue2) Then
    '                e.SortResult = -1
    '            Else
    '                e.SortResult = 0
    '            End If
    '            e.Handled = True
    '            Exit Sub
    '        End If
    '        e.Handled = True
    '        Exit Sub
    '    End If
    'End Sub
    ''Private Sub LlenarAdaptadorIng()
    ''    If (Me.TCodigo.Text <> "") Then
    ''        Try
    ''            If (Conectar()) Then
    ''                Dim Comando As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY Principal DESC) AS Num, Principal, idIngrediente,Ingrediente,idUnidad,Unidad, CantIngU,PorcIng, CostoUD, CostoU,id FROM VRecetaGuardada WHERE idProducto=" & Trim(Me.TCodigo.Text), CNN)
    ''                Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''                Me.DGIngrediente.Rows.Clear()
    ''                Do While DR.Read()
    ''                    Me.DGIngrediente.Rows.Add(DR("id"), DR("Num"), DR("Principal"), DR("idIngrediente"), DR("Ingrediente"), DR("CantIngU"), DR("idUnidad"), DR("Unidad"), DR("PorcIng"), Format(DR("CostoUD"), "##,##0.0000"), Format(DR("CostoU"), "##,##0.0000"), 0)
    ''                Loop
    ''                DR.Close()
    ''                Desconectar()
    ''            End If
    ''        Catch ex As Exception
    ''            MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    ''            Desconectar()
    ''        End Try
    ''    End If
    ''    CostoEmp = SumarColumna(DGIngrediente, 10)
    ''    CostoDEmp = SumarColumna(DGIngrediente, 9)
    ''    CalcularPorcCosto()
    ''    Me.DGIngrediente.Sort(Me.DGIngrediente.Columns(11), System.ComponentModel.ListSortDirection.Descending)
    ''    Me.DGIngrediente.Rows.Add("", "", False, "", "                                        Totales:", Format(SumarColumna(DGIngrediente, 5), "##,##0.00"), "", "", "", Format(CostoDEmp, "##,##0.0000"), Format(CostoEmp, "##,##0.0000"), Format(SumarColumna(DGIngrediente, 11), "##,##0.00"))
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).DefaultCellStyle.BackColor = Color.PaleTurquoise
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).Height = 25
    ''    Me.DGIngrediente.Rows(Me.DGIngrediente.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
    ''End Sub
    'Private Sub TabPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPrincipal.SelectedIndexChanged
    '    If (Me.TCodigo.Text <> "") Then
    '        Dim Total As Decimal = 0
    '        Select Case TabPrincipal.SelectedTab.Name
    '            Case Tab_Proveedor.Name 'Proveedor
    '                If (Me.TCategoriaInt.Tag = 1) Then
    '                    If Conectar() Then
    '                        Me.DGVProveedor.Columns("Codigo").Visible = False
    '                        Me.DGVProveedor.Columns("Producto").Visible = False
    '                        Dim Comando As New SqlCommand("SELECT * FROM VProveedorProducto WHERE idProducto=" & Me.TCodigo.Text & " ORDER BY Fecha DESC", CNN)
    '                        Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
    '                        Me.DGVProveedor.Rows.Clear()
    '                        Do While DatosArt.Read()
    '                            Me.DGVProveedor.Rows.Add(DatosArt("NumDoc"), 0, "", DatosArt("Nombre"), Format(DatosArt("Fecha"), "dd/MM/yyyy"), DatosArt("Cantidad"), DatosArt("Unidad"), Format(DatosArt("CostoD"), "##,##0.00"), Format(DatosArt("Costo"), "##,##0.00"), Format(DatosArt("Costo2D"), "##,##0.00"), Format(DatosArt("Costo2"), "##,##0.00"), Format(DatosArt("TotalD"), "##,##0.00"), Format(DatosArt("Total"), "##,##0.00"))
    '                        Loop
    '                        DatosArt.Close()
    '                        Desconectar()
    '                    End If
    '                Else
    '                    If Conectar() Then
    '                        Me.DGVProveedor.Columns("Codigo").Visible = True
    '                        Me.DGVProveedor.Columns("Producto").Visible = True
    '                        Dim Comando As New SqlCommand("SELECT * FROM VProveedorProducto WHERE idcategoriaInt=" & Me.TCategoriaInt.Tag & " ORDER BY Fecha DESC", CNN)
    '                        Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
    '                        Me.DGVProveedor.Rows.Clear()
    '                        Do While DatosArt.Read()
    '                            Me.DGVProveedor.Rows.Add(DatosArt("NumDoc"), DatosArt("idProducto"), DatosArt("Producto"), DatosArt("Nombre"), Format(DatosArt("Fecha"), "dd/MM/yyyy"), DatosArt("Cantidad"), DatosArt("Unidad"), Format(DatosArt("CostoD"), "##,##0.00"), Format(DatosArt("Costo"), "##,##0.00"), Format(DatosArt("Costo2D"), "##,##0.00"), Format(DatosArt("Costo2"), "##,##0.00"), Format(DatosArt("TotalD"), "##,##0.00"), Format(DatosArt("Total"), "##,##0.00"))
    '                        Loop
    '                        DatosArt.Close()
    '                        Desconectar()
    '                    End If
    '                End If


    '            Case Tab_Existencia.Name 'Existencias
    '                If (Conectar()) Then
    '                    Dim Comando As New SqlCommand("SELECT ExistenciaMin, ExistenciaMax, Stock,Unidad,Capacidad,UnidadCapacidad, PoseeDescuento, PorcMD, PorcCI, POrcVN FROM VNewProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                    Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                    Do While DR.Read()
    '                        If (IsDBNull(DR("ExistenciaMin"))) Then
    '                            Me.TExistenciaMin.Text = ""
    '                        Else
    '                            Me.TExistenciaMin.Text = VFormat(DR("ExistenciaMin"), 2)
    '                        End If
    '                        If (IsDBNull(DR("ExistenciaMax"))) Then
    '                            Me.TExistenciaMax.Text = ""
    '                        Else
    '                            Me.TExistenciaMax.Text = VFormat(DR("ExistenciaMax"), 2)
    '                        End If
    '                        Me.TStock.Text = VFormat(Convert.ToDecimal(DR("Stock")), 2)
    '                        Me.LUnidad.Text = DR("Unidad")

    '                        Me.TStockCap.Text = VFormat(Convert.ToDecimal(DR("Stock")) * Convert.ToDecimal(DR("Capacidad")), 2)
    '                        Me.LUnidadCap.Text = DR("UnidadCapacidad")

    '                        Me.CBDesc.Checked = DR("PoseeDescuento")
    '                        Me.TPEmp1.Text = VFormat(DR("PorcMD"), 2)
    '                        Me.TPEmp2.Text = VFormat(DR("PorcCI"), 2)
    '                        Me.TPEmp3.Text = VFormat(DR("PorcVN"), 2)

    '                    Loop
    '                    DR.Close()
    '                    Desconectar()
    '                End If
    '                'If Conectar() Then
    '                '    Dim Comando As New SqlCommand("Select  Stock from TNewProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                '    Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
    '                '    Do While DatosArt.Read()
    '                '        Total += Convert.ToDecimal(DatosArt("Stock"))
    '                '    Loop
    '                '    Me.TExistenciaTotal.Text = VFormat(Convert.ToDecimal(DatosArt("Stock")), 2)
    '                '    DatosArt.Close()
    '                '    Desconectar()
    '                'End If
    '            Case Tab_Precio.Name 'Precios e Impuestos
    '                If (Me.TCodigo.Text <> "") Then
    '                    Me.TCostoCal.Text = "0"
    '                    Me.TCosto.Text = "0"
    '                    Me.TCostoCalD.Text = "0"
    '                    Me.TCostoD.Text = "0"

    '                    Me.TIVAC.Text = "0"
    '                    Me.TIVAC.Tag = 8
    '                    Me.TIVAV.Text = "0"
    '                    Me.TIVAV.Tag = 8
    '                    BuscarPrecios()

    '                Else
    '                    ' LimpiarPrecios()
    '                End If
    '            Case Tab_Ingrediente.Name 'Ingredientes
    '                If (Me.CBEmpaquetado.Checked = True) Then
    '                    MsgBox("Producto Empaquetado.   ", MsgBoxStyle.Information, "MarSoft: Informaciòn.")
    '                Else
    '                    LlenarAdaptadorIng()
    '                End If
    '        End Select
    '    End If
    'End Sub


    'Private Sub TExistenciaMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TExistenciaMin.KeyPress
    '    If (e.KeyChar = ".") Then
    '        e.KeyChar = ","
    '    End If
    '    e.Handled = txtNumerico(TExistenciaMin, e.KeyChar, False)
    'End Sub

    'Private Sub TExistenciaMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TExistenciaMax.KeyPress
    '    If (e.KeyChar = ".") Then
    '        e.KeyChar = ","
    '    End If
    '    e.Handled = txtNumerico(TExistenciaMax, e.KeyChar, False)
    'End Sub
    'Private Sub TCantidadIng_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = ".") Then
    '        e.KeyChar = ","
    '    End If
    '    e.Handled = txtNumerico(TCantidadIng, e.KeyChar, True)
    'End Sub

    'Function ExisteProd(Cod As String) As Boolean
    '    Dim Valor As Boolean = False
    '    If Conectar() Then
    '        Try
    '            Dim Comando As New SqlCommand("SELECT  idProducto FROM TNewProducto Where idProducto=@idProducto", CNN)
    '            Comando.Parameters.Add(New SqlParameter("@idProducto", Cod))
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            If (DR.Read()) Then
    '                Valor = True
    '            Else
    '                Valor = False
    '            End If
    '            DR.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    '    Return (Valor)
    'End Function
    'Private Sub MostrarProd()
    '    If Conectar() Then
    '        Try
    '            Dim Comando As New SqlCommand("SELECT  * FROM VNewProducto Where idProducto=@idProducto", CNN)
    '            Comando.Parameters.Add(New SqlParameter("@idProducto", Me.TCodigo.Text))
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            If (DR.Read()) Then
    '                Me.TCodigo.Text = Trim(DR("idProducto").ToString)
    '                Me.TNombre.Text = Trim(DR("Nombre").ToString)
    '                Me.TNombreCorto.Text = Trim(DR("NombreCorto").ToString)
    '                Me.FechaC.Value = DR("FechaCreacion").ToString
    '                Me.TTipoProducto.Tag = DR("idTipoProducto").ToString
    '                Me.TTipoProducto.Text = DR("TipoProducto").ToString
    '                NoEjecutar = True
    '                If (Me.TTipoProducto.Tag = 2) Then ' Si el Producto es Compuesto.
    '                    '   Me.Tab_Precio.Parent = Nothing
    '                    Me.Tab_Ingrediente.Parent = Me.TabPrincipal
    '                    '  Me.Tab_Proveedor.Parent = Nothing
    '                    ' Me.Tab_Existencia.Parent = Nothing
    '                    '    Me.Tab_Precio.Parent = Me.TabPrincipal
    '                Else
    '                    '   Me.Tab_Precio.Parent = Nothing
    '                    '  Me.Tab_Proveedor.Parent = Me.TabPrincipal
    '                    '  Me.Tab_Existencia.Parent = Me.TabPrincipal
    '                    ' Me.Tab_Precio.Parent = Me.TabPrincipal
    '                    Me.Tab_Ingrediente.Parent = Nothing
    '                End If
    '                NoEjecutar = False
    '                Me.TCategoria.Tag = DR("idCategoria").ToString
    '                NoActualizar = True
    '                Me.TCategoria.Text = DR("Categoria").ToString
    '                Me.TSubCategoria.Tag = DR("idSubCategoria").ToString
    '                Me.TSubCategoria.Text = DR("SubCategoria").ToString


    '                Me.TCategoriaInt.Tag = DR("idCategoriaInt").ToString
    '                Me.TCategoriaInt.Text = DR("CategoriaInt").ToString
    '                Me.TUnidadGeneral.Text = DR("UnidadCatInt").ToString
    '                Me.TUnidadGeneral.Tag = DR("idUnidadCatInt").ToString

    '                NoActualizar = False
    '                Me.TUnidad.Tag = DR("idUnidad").ToString
    '                Me.TUnidad.Text = DR("Unidad").ToString
    '                Me.TUnidadAlt.Tag = DR("idUnidadAlt").ToString
    '                Me.TUnidadAlt.Text = DR("UnidadAlt").ToString
    '                Me.TMarca.Tag = DR("idMarca").ToString
    '                Me.TMarca.Text = DR("Marca").ToString
    '                Me.TModelo.Text = Trim(DR("Modelo").ToString)
    '                Me.TGarantia.Text = Trim(DR("Garantia").ToString)
    '                Me.TProducto.Tag = DR("idProdNacional").ToString
    '                Me.TProducto.Text = DR("ProdNacional").ToString
    '                Me.TDescripcion.Text = Trim(DR("Descripcion").ToString)
    '                Me.CBActivo.Checked = DR("Activo").ToString
    '                Me.CBVenta.Checked = DR("Venta").ToString
    '                Me.CBBalanza.Checked = DR("Decimal").ToString
    '                Me.CBVentaUnidAlt.Checked = DR("VentaUnidAlt").ToString
    '                'Mostrar la Imagen del Producto
    '                Dim ms As New System.IO.MemoryStream()
    '                Dim imageBuffer() As Byte = CType(DR("ImagenF"), Byte())
    '                ms = New System.IO.MemoryStream(imageBuffer)
    '                Imagen.BackgroundImage = Nothing
    '                Imagen.BackgroundImage = (Image.FromStream(ms))
    '                Imagen.BackgroundImageLayout = ImageLayout.Stretch

    '                Me.TCantidadIng.Text = Format(DR("Capacidad"), "##,##0.00")
    '                Me.TUnidadCap.Tag = DR("idUnidadCapacidad").ToString
    '                Me.TUnidadCap.Text = DR("UnidadCapacidad").ToString
    '                Me.TEmpaquetado.Text = DR("ProdEmpaquetado").ToString
    '                Me.TEmpaquetado.Tag = Trim(DR("idProdEmpaquetado").ToString)
    '                Me.CBEmpaquetado.Checked = DR("Empaquetado").ToString
    '                Me.TCantEmp.Text = DR("CantEmpaquetado")
    '                Me.CBMezcla.Checked = DR("Mezcla")
    '                Me.CalculoCap.Checked = DR("CalculoCap")
    '                Me.CBCalculoCap.Checked = DR("CalculoCap")
    '                Me.CBPasapalo.Checked = DR("Pasapalo")
    '                Me.TTipoReceta.Text = DR("TipoReceta")
    '                Me.TTipoReceta.Tag = DR("idTipoReceta")
    '                Me.TTipoReceta.Tag = DR("idTipoReceta")
    '                Me.CBBaseDolar.Checked = DR("BaseDolar")
    '                Me.CBDesc.Checked = DR("PoseeDescuento")
    '                Me.TPEmp1.Text = DR("PorcMD")
    '                Me.TPEmp2.Text = DR("PorcCI")
    '                Me.TPEmp3.Text = DR("PorcVN")
    '                AuxPrecio = IIf(DR("Precio1").ToString = "", 0, DR("Precio1").ToString)
    '                AuxPrecioD = IIf(DR("PrecioD1").ToString = "", 0, DR("PrecioD1").ToString)
    '                Me.TCantXBandeja.Text = DR("CantidadXBandeja")
    '            End If
    '            DR.Close()
    '            Desconectar()
    '            BuscarPrecios()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    '    BuscarColorCategoria()
    'End Sub
    ''Private Sub MostrarArticulo()
    ''    If Conectar() Then
    ''        Try
    ''            Dim Comando As New SqlCommand("SELECT  * FROM TArticulo Where idProducto=@idProducto", CNN)
    ''            Comando.Parameters.Add(New SqlParameter("@idProducto", Me.TCodigo.Text))
    ''            Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''            If (DR.Read()) Then
    ''                Me.LArtEjemplo.ForeColor = Color.FromArgb(DR("ColorFuenteArt").ToString)
    ''                Me.LArtEjemplo.Font = New Font(DR("TipoFuente").ToString, DR("TFuente"), FontStyle.Regular) 'Tamaño de la letra
    ''                Me.LArtEjemplo.TextAlign = ContentAlignment.MiddleCenter
    ''            End If
    ''            DR.Close()
    ''            Desconectar()
    ''        Catch ex As Exception
    ''            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    ''            Desconectar()
    ''        End Try
    ''    End If
    ''    Desconectar()
    ''End Sub



    'Private Sub LlenarTardem()
    '    If Conectar() Then
    '        Try
    '            AdaptadorTardem = New SqlDataAdapter("SELECT  * FROM TTardem ORDER BY Nombre ASC", CNN)
    '            DataTardem = New DataTable
    '            AdaptadorTardem.Fill(DataTardem)
    '            Me.CTardem.DataSource = DataTardem
    '            Me.CTardem.DisplayMember = "Nombre"
    '            Me.CTardem.ValueMember = "Id"
    '        Catch ex As Exception
    '            MessageBox.Show("Error al Cargar Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub



    'Private Sub BuscarColorCategoria()
    '    If (Me.TCategoria.Text <> "") Then
    '        If Conectar() Then
    '            Try
    '                Dim Comando As New SqlCommand("SELECT  * FROM TCategoria WHERE Nombre='" & Me.TCategoria.Text & "'", CNN)
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                Do While DR.Read()
    '                    Me.LArtEjemplo.ForeColor = Color.FromArgb(DR("ColorFuenteArt").ToString)
    '                    Me.LArtEjemplo.BackColor = Color.FromArgb(DR("ColorCat").ToString)
    '                    Dim TF As Integer = DR("TFuente").ToString
    '                    Me.LArtEjemplo.Font = New Font("Microsoft Sans Serif", TF, FontStyle.Bold)
    '                    Me.BFuente.BackColor = Color.White
    '                Loop
    '            Catch ex As Exception
    '                MessageBox.Show("ERROR al Cambiar los Colores de la Categoria. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Desconectar()
    '            End Try
    '        End If
    '        Desconectar()
    '    End If
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
    '    VarBuscar = "Producto"
    '    FBuscarProducto.LTitulo.Text = "Listado de Productos."
    '    FBuscarProducto.LTitulo.Tag = Me.TCodigo.Text
    '    FBuscarProducto.ShowDialog()
    '    TabPrincipal_SelectedIndexChanged(Nothing, Nothing)
    '    VieneNuevo = False
    '    If (ExisteProd(Me.TCodigo.Text)) Then
    '        MostrarProd()
    '        ExisteProducto = True
    '    Else
    '        If (VieneNuevo = False) Then
    '            Nuevo_Click(Nothing, Nothing)
    '            ExisteProducto = False
    '        End If
    '    End If
    '    Me.TNombre.Focus()
    'End Sub
    'Private Sub BUnidAlt_Click(sender As Object, e As EventArgs)

    'End Sub
    'Function BuscarContadorProductos(Cat As Integer, Sub_Cat As Integer) As String
    '    Dim Valor As String = "01"
    '    Try
    '        If (Conectar()) Then
    '            Dim Comando As New SqlCommand("SELECT count(idProducto) as Contador  FROM TNewProducto WHERE  idCategoria=@idCategoria AND idSubCategoria=@idSubCategoria", CNN)

    '            'Dim Comando As New SqlCommand("SELECT TOP 1 * FROM TNewProducto WHERE  idCategoria=@idCategoria AND idSubCategoria=@idSubCategoria ORDER BY idProducto DESC", CNN)
    '            Comando.Parameters.Add(New SqlParameter("@idCategoria", Cat))
    '            Comando.Parameters.Add(New SqlParameter("@idSubCategoria", Sub_Cat))
    '            Dim DR As SqlDataReader = Comando.ExecuteReader()
    '            If (DR.Read) Then

    '                Valor = IIf(Len(DR("contador").ToString) = 1, "0" & (DR("contador").ToString + 1), (DR("contador").ToString + 1))
    '            End If
    '            DR.Close()
    '            Desconectar()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error de Datos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '        Desconectar()
    '    End Try
    '    Return (Valor)
    'End Function


    ''Function BuscarContadorProductos(Cat As Integer, Sub_Cat As Integer) As String
    ''    Dim Valor As String = "01"
    ''    Try
    ''        If (Conectar()) Then
    ''            Dim Comando As New SqlCommand("SELECT count(idProducto) as Contador  FROM TNewProducto WHERE  idCategoria=@idCategoria AND idSubCategoria=@idSubCategoria", CNN)
    ''            Comando.Parameters.Add(New SqlParameter("@idCategoria", Cat))
    ''            Comando.Parameters.Add(New SqlParameter("@idSubCategoria", Sub_Cat))
    ''            Dim DR As SqlDataReader = Comando.ExecuteReader()
    ''            If (DR.Read) Then
    ''                Valor = IIf(Len(DR("contador").ToString) = 1, "0" & (DR("contador").ToString + 1), (DR("contador").ToString + 1))
    ''            End If
    ''            DR.Close()
    ''            Desconectar()
    ''        End If
    ''    Catch ex As Exception
    ''        MsgBox("Error de Datos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    ''        Desconectar()
    ''    End Try
    ''    Return (Valor)
    ''End Function
    'Private Sub BuscarCod_Click(sender As Object, e As EventArgs) Handles BuscarCod.Click
    '    Dim AuxCod As String = ""
    '    Cat = Me.TCategoria.Text
    '    SubCat = Me.TSubCategoria.Text
    '    idCat = Me.TCategoria.Tag
    '    idSubCat = Me.TSubCategoria.Tag
    '    Nuevo_Click(Nothing, Nothing)
    '    Me.TCategoria.Text = Cat
    '    Me.TSubCategoria.Text = SubCat
    '    Me.TCategoria.Tag = idCat
    '    Me.TSubCategoria.Tag = idSubCat
    '    ExisteProducto = False
    '    'Cat = Me.TCategoria.Text
    '    'SubCat = Me.TSubCategoria.Text
    '    Dim NumProd As String = BuscarContadorProductos(Me.TCategoria.Tag, Me.TSubCategoria.Tag)
    '    AuxCod = IIf(Len(Me.TCategoria.Tag.ToString) = 1, "0" & Me.TCategoria.Tag.ToString, Me.TCategoria.Tag.ToString) & IIf(Len(Me.TSubCategoria.Tag.ToString) = 1, "0" & Me.TSubCategoria.Tag.ToString, Me.TSubCategoria.Tag.ToString) & NumProd
    '    While ExisteProd(AuxCod)
    '        NumProd = Convert.ToInt16(NumProd) + 1
    '        AuxCod = IIf(Len(Me.TCategoria.Tag.ToString) = 1, "0" & Me.TCategoria.Tag.ToString, Me.TCategoria.Tag.ToString) & IIf(Len(Me.TSubCategoria.Tag.ToString) = 1, "0" & Me.TSubCategoria.Tag.ToString, Me.TSubCategoria.Tag.ToString) & NumProd
    '    End While
    '    Me.TCodigo.Text = AuxCod
    '    'Me.TCategoria.Text = Cat
    '    'Me.TSubCategoria.Text = SubCat

    '    Me.TNombre.Select()
    '    VieneNuevo = True
    'End Sub
    'Private Sub BIVAC_Click(sender As Object, e As EventArgs) Handles BIVAC.Click
    '    If (ExisteProducto = True) Then
    '        VarBuscar = "AlicuotaProdC"
    '        FBuscarGenerico.LTitulo.Text = "Alicuota para la Compra."
    '        FBuscarGenerico.LTitulo.Tag = Me.TIVAC.Tag
    '        FBuscarGenerico.ShowDialog()
    '        Me.TImpuestoC.Text = Format((Convert.ToDecimal(Me.TCostoCal.Text) / 100) * Convert.ToDecimal(Me.TIVAC.Text), "##,##0.00")
    '        Me.TImpuestoCD.Text = Format(CalcularDolar(DateTime.Now, Me.TImpuestoC.Text), "##,##0.00")
    '        ActualizarIVACompras()
    '    Else
    '        MsgBox("Debe Guardar el Producto para Poder Modificarle la Alicuota.", MsgBoxStyle.Information, "MarSoft: Información.")
    '    End If
    'End Sub
    'Private Sub ActualizarIVAVentas()
    '    If (Me.TCodigo.Text <> "") Then
    '        Try
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("UPDATE TNewProducto set idIVAV=@idIVAV WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                Comando.Parameters.Add(New SqlParameter("@idIVAV", Convert.ToInt16(Me.TIVAV.Tag)))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                Desconectar()
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar el I.V.A. de Ventas.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    'End Sub
    'Private Sub ActualizarIVACompras()
    '    If (Me.TCodigo.Text <> "") Then
    '        Try
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("UPDATE TNewProducto set idIVAC=@idIVAC WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                Comando.Parameters.Add(New SqlParameter("@idIVAC", Convert.ToInt16(Me.TIVAC.Tag)))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                Desconectar()
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar el I.V.A. de Compras.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    'End Sub
    'Private Sub BIVAV_Click(sender As Object, e As EventArgs) Handles BIVAV.Click
    '    If (ExisteProducto = True) Then
    '        VarBuscar = "AlicuotaProdV"
    '        FBuscarGenerico.LTitulo.Text = "Alicuota para la Venta."
    '        FBuscarGenerico.LTitulo.Tag = Me.TIVAV.Tag
    '        FBuscarGenerico.ShowDialog()
    '        Me.TImpuestoV.Text = Format((Convert.ToDecimal(Me.TCostoCal.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
    '        Me.TImpuestoVD.Text = Format(CalcularDolar(DateTime.Now, Me.TImpuestoV.Text), "##,##0.00")
    '        Me.Precio1CI.Text = Format(Convert.ToDecimal(Me.Precio1SinImp.Text) + Convert.ToDecimal(Me.TImpuestoV.Text), "##,##0.00")
    '        Me.Precio2CI.Text = Format(Convert.ToDecimal(Me.Precio2SinImp.Text) + Convert.ToDecimal(Me.TImpuestoV.Text), "##,##0.00")
    '        Me.Precio3CI.Text = Format(Convert.ToDecimal(Me.Precio3SinImp.Text) + Convert.ToDecimal(Me.TImpuestoV.Text), "##,##0.00")
    '        Me.PrecioECI.Text = Format(Convert.ToDecimal(Me.PrecioESinImp.Text) + Convert.ToDecimal(Me.TImpuestoV.Text), "##,##0.00")

    '        Me.Precio1DCI.Text = Format(Convert.ToDecimal(Me.Precio1D.Text) + Convert.ToDecimal(Me.TImpuestoVD.Text), "##,##0.00")
    '        Me.Precio2DCI.Text = Format(Convert.ToDecimal(Me.Precio2D.Text) + Convert.ToDecimal(Me.TImpuestoVD.Text), "##,##0.00")
    '        Me.Precio3DCI.Text = Format(Convert.ToDecimal(Me.Precio3D.Text) + Convert.ToDecimal(Me.TImpuestoVD.Text), "##,##0.00")
    '        Me.PrecioEDCI.Text = Format(Convert.ToDecimal(Me.PrecioED.Text) + Convert.ToDecimal(Me.TImpuestoVD.Text), "##,##0.00")
    '        ActualizarIVAVentas()
    '    Else
    '        MsgBox("Debe Guardar el Producto para Poder Modificarle la Alicuota.", MsgBoxStyle.Information, "MarSoft: Información.")
    '    End If
    'End Sub
    'Private Sub EliminarIngredientes()
    '    If (Me.TCodigo.Text <> "") Then
    '        If (Conectar()) Then
    '            Try
    '                Dim Comando As New SqlCommand("DELETE FROM TIngredientes WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '            Catch ex As Exception
    '                MsgBox("Error al Eliminar los Ingredientes del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '                Desconectar()
    '            End Try
    '        End If
    '        Desconectar()
    '    End If
    'End Sub
    'Private Sub BTipoProducto_Click(sender As Object, e As EventArgs)
    '    VarBuscar = "TipoProducto"
    '    FBuscarGenerico.LTitulo.Text = "Tipo de Producto."
    '    FBuscarGenerico.LTitulo.Tag = Me.TTipoProducto.Tag
    '    FBuscarGenerico.ShowDialog()
    '    If (FBuscarGenerico.LTitulo.Tag = 2 And Me.TTipoProducto.Tag = 1) Then
    '        If MsgBox("Esta seguro que desea Modificar el Tipo del Producto: " & Me.TCodigo.Text & " de Compuesto a Terminado?, Se Eliminarán todos sus Ingredientes.", vbYesNo, "MarSoft: Eliminar Ingrediente.") = vbYes Then
    '            Me.TTipoProducto.Tag = 1
    '            Me.TTipoProducto.Text = "Terminados"
    '            Me.Tab_Precio.Parent = Nothing
    '            Me.Tab_Proveedor.Parent = Me.TabPrincipal
    '            Me.Tab_Existencia.Parent = Me.TabPrincipal
    '            Me.Tab_Precio.Parent = Me.TabPrincipal
    '            Me.Tab_Ingrediente.Parent = Nothing
    '            EliminarIngredientes()
    '            Me.TTipoReceta.Text = ""
    '            Me.TTipoReceta.Tag = 1
    '        Else
    '            Me.TTipoProducto.Tag = 2
    '            Me.TTipoProducto.Text = "Compuestos"
    '            Me.Tab_Precio.Parent = Nothing
    '            Me.Tab_Ingrediente.Parent = Me.TabPrincipal
    '            Me.Tab_Proveedor.Parent = Nothing
    '            Me.Tab_Existencia.Parent = Nothing
    '            Me.Tab_Precio.Parent = Me.TabPrincipal
    '            Me.TTipoReceta.Text = "Panaderia"
    '            Me.TTipoReceta.Tag = 2
    '        End If
    '    Else
    '        If (Me.TTipoProducto.Tag = 2) Then ' Si el Producto es Compuesto.
    '            Me.Tab_Precio.Parent = Nothing
    '            Me.Tab_Ingrediente.Parent = Me.TabPrincipal
    '            Me.Tab_Proveedor.Parent = Nothing
    '            Me.Tab_Existencia.Parent = Nothing
    '            Me.Tab_Precio.Parent = Me.TabPrincipal
    '            Me.TTipoReceta.Text = "Panaderia"
    '            Me.TTipoReceta.Tag = 2
    '        Else
    '            Me.TTipoProducto.Tag = 1
    '            Me.TTipoProducto.Text = "Terminados"
    '            Me.Tab_Precio.Parent = Nothing
    '            Me.Tab_Proveedor.Parent = Me.TabPrincipal
    '            Me.Tab_Existencia.Parent = Me.TabPrincipal
    '            Me.Tab_Precio.Parent = Me.TabPrincipal
    '            Me.Tab_Ingrediente.Parent = Nothing
    '        End If
    '    End If
    'End Sub


    'Private Sub BUnidad1_Click(sender As Object, e As EventArgs)
    '    VarBuscar = "Unidades"
    '    FBuscarGenerico.LTitulo.Text = "Listado de Unidades."
    '    FBuscarGenerico.LTitulo.Tag = Me.TUnidad.Tag
    '    FBuscarGenerico.ShowDialog()
    '    Me.TUnidadCap.Tag = Me.TUnidad.Tag
    '    Me.TUnidadCap.Text = Me.TUnidad.Text
    'End Sub


    'Private Sub InicializarSubCategorias()
    '    If Conectar() Then
    '        Try
    '            Dim Comando As New SqlCommand("SELECT  idSubCategoria, Nombre FROM TSubCategoria WHERE Categoria ='" & Me.TCategoria.Text & "'  ORDER BY Nombre ASC", CNN)
    '            Dim DataReader As SqlDataReader = Comando.ExecuteReader()
    '            If (DataReader.Read()) Then
    '                Me.TSubCategoria.Tag = DataReader("idSubCategoria")
    '                Me.TSubCategoria.Text = DataReader("Nombre")
    '            Else
    '                Me.TSubCategoria.Tag = -1
    '                Me.TSubCategoria.Text = "_Ninguna"
    '            End If
    '            DataReader.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar()
    '        End Try
    '    End If
    '    Desconectar()
    'End Sub
    'Private Sub TCategoria_TextChanged(sender As Object, e As EventArgs)
    '    If (NoActualizar = False) Then
    '        InicializarSubCategorias()
    '    End If
    'End Sub
    'Private Sub TNombre_LostFocus(sender As Object, e As EventArgs) Handles TNombre.LostFocus
    '    If (Me.TNombreCorto.Text = "") Then
    '        Me.TNombreCorto.Text = TNombre.Text
    '        Me.LArtEjemplo.Text = TNombre.Text
    '    End If
    '    If (Me.TNombre.Text = "") Then
    '        Me.LArtEjemplo.Text = "Nombre"
    '    End If
    'End Sub
    'Private Sub BFuente_Click(sender As Object, e As EventArgs)
    '    DialogoFuente.Font = LArtEjemplo.Font
    '    DialogoFuente.Color = BFuente.BackColor
    '    If (DialogoFuente.ShowDialog() = Windows.Forms.DialogResult.OK) Then
    '        BFuente.BackColor = DialogoFuente.Color
    '        LArtEjemplo.ForeColor = DialogoFuente.Color
    '        LArtEjemplo.Font = DialogoFuente.Font
    '    End If
    'End Sub
    'Private Sub TNombreCorto_TextChanged(sender As Object, e As EventArgs)
    '    Me.LArtEjemplo.Text = TNombreCorto.Text
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    VarBuscar = "UnidadCapacidadProd"
    '    FBuscarGenerico.LTitulo.Text = "Listado Unidades de Capacidad."
    '    FBuscarGenerico.LTitulo.Tag = Me.TUnidadCap.Tag
    '    FBuscarGenerico.ShowDialog()
    '    ValidarCategoriaInterna(Me.TCategoriaInt.Tag)
    'End Sub

    'Private Sub BEmpaquetado_Click(sender As Object, e As EventArgs)
    '    VarBuscar = "ProductoEmpaquetado"
    '    FBuscarGenerico.LTitulo.Text = "Listado Productos Compuestos."
    '    FBuscarGenerico.LTitulo.Tag = Me.TEmpaquetado.Tag
    '    FBuscarGenerico.ShowDialog()
    'End Sub
    'Private Sub TTipoProducto_TextChanged(sender As Object, e As EventArgs)
    '    If (Me.TTipoProducto.Text = "Compuestos") Then
    '        Me.CBEmpaquetado.Visible = True
    '        Me.CBMezcla.Visible = True
    '        Me.LTipoReceta.Visible = True
    '        Me.TTipoReceta.Visible = True
    '        Me.BTipoReceta.Visible = True
    '    Else
    '        Me.CBEmpaquetado.Visible = False
    '        Me.CBMezcla.Visible = False
    '        Me.LTipoReceta.Visible = False
    '        Me.TTipoReceta.Visible = False
    '        Me.BTipoReceta.Visible = False
    '    End If
    'End Sub
    'Private Sub CBEmpaquetado_CheckedChanged(sender As Object, e As EventArgs)
    '    Me.BEmpaquetar.Visible = Me.CBEmpaquetado.Checked
    '    Me.LEmp.Visible = Me.CBEmpaquetado.Checked
    '    'If (Me.CBEmpaquetado.Checked = False) Then
    '    '    'Me.TEmpaquetado.Text = ""
    '    '    'Me.TEmpaquetado.Tag = ""
    '    '    'Me.TEmpaquetado.BackColor = Color.Gainsboro
    '    '    'Me.BEmpaquetado.Enabled = False
    '    '    'Me.TCantEmp.Enabled = False
    '    '    'Me.TCantEmp.BackColor = Color.Gainsboro

    '    'Else
    '    '    'Me.TEmpaquetado.BackColor = Me.TNombre.BackColor
    '    '    'Me.TCantEmp.BackColor = Me.TNombre.BackColor
    '    '    'Me.TCantEmp.Enabled = True
    '    '    'Me.BEmpaquetado.Enabled = True
    '    '    BEmpaquetar.Enabled = False
    '    'End If
    'End Sub
    'Private Sub TCantEmp_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = ".") Then
    '        e.KeyChar = ","
    '    End If
    '    e.Handled = txtNumerico(TCantEmp, e.KeyChar, False)
    'End Sub

    'Private Sub ValidarCategoriaInterna(idCatInt As Integer)
    '    If (Me.TUnidadCap.Text <> Me.TUnidadGeneral.Text) Then
    '        If (Me.TUnidadGeneral.Tag <> "1") Then
    '            Me.TUnidadGeneral.BackColor = Color.Red
    '            Me.TUnidadCap.BackColor = Color.Red
    '        Else
    '            Me.TUnidadGeneral.BackColor = Color.Gainsboro
    '            Me.TUnidadCap.BackColor = Color.Gainsboro
    '        End If
    '    Else
    '        If (Me.TUnidadGeneral.Tag <> "1") Then
    '            If Conectar3() Then
    '                Try
    '                    Dim Comando3 As New SqlCommand("SELECT  COUNT (*) as Cant FROM VNewProducto WHERE idCategoriaInt=@IdCatInt and (idUnidadCapacidad <> idUnidadCatInt)", CNN3)
    '                    Comando3.Parameters.Add(New SqlParameter("@IdCatInt", idCatInt))
    '                    Dim DR3 As SqlDataReader = Comando3.ExecuteReader()
    '                    If (DR3.Read()) Then
    '                        If (DR3("Cant") > 0) Then
    '                            Me.TUnidadGeneral.BackColor = Color.Red
    '                            Me.TUnidadCap.BackColor = Color.Red
    '                        Else
    '                            Me.TUnidadGeneral.BackColor = Color.Gainsboro
    '                            Me.TUnidadCap.BackColor = Color.Gainsboro
    '                        End If
    '                    Else
    '                        Me.TUnidadGeneral.BackColor = Color.Gainsboro
    '                        Me.TUnidadCap.BackColor = Color.Gainsboro
    '                    End If
    '                    DR3.Close()
    '                    Desconectar3()
    '                Catch ex As Exception
    '                    MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '                    Desconectar3()
    '                End Try
    '            End If
    '        Else
    '            Me.TUnidadGeneral.BackColor = Color.Gainsboro
    '            Me.TUnidadCap.BackColor = Color.Gainsboro
    '        End If
    '    End If
    'End Sub



    'Private Sub TCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TCodigo.KeyDown
    '    If (e.KeyData = Keys.Enter) Then
    '        VieneNuevo = False
    '        If (ExisteProd(Me.TCodigo.Text)) Then
    '            BuscarColorCategoria()
    '            MostrarProd()
    '            ExisteProducto = True
    '        Else
    '            If (VieneNuevo = False) Then
    '                Nuevo_Click(Nothing, Nothing)
    '                ExisteProducto = False
    '            End If
    '        End If
    '        Me.TNombre.Focus()
    '    End If
    'End Sub

    'Function BuscarTasaporFecha(Fecha As DateTime) As Decimal
    '    Dim Valor As Decimal = 0
    '    If Conectar5() Then
    '        Try
    '            Dim Comando5 As New SqlCommand("Select  TasaBC FROM TTasaMonedas where Fecha<=@Fecha  order by Fecha Desc", CNN5)
    '            Comando5.Parameters.AddWithValue("@Fecha", Fecha.Date & " 23:59:59")
    '            '  Comando5.Parameters.AddWithValue("@Mes", Fecha.Month)
    '            '  Comando5.Parameters.AddWithValue("@Ano", Fecha.Year)
    '            Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
    '            If (DR5.Read()) Then
    '                Valor = IIf(IsDBNull(DR5("TasaBC")), 1, DR5("TasaBC"))
    '            End If
    '            DR5.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar5()
    '        End Try
    '    End If
    '    Desconectar5()
    '    Return (Valor)
    'End Function
    'Private Sub Guardo(id, Fecha)
    '    If Conectar5() Then
    '        Try
    '            Dim Comando5 As New SqlCommand("UPDATE TConsolidacionBancaria Set FechaGasto=@Fechax WHERE id=@idx", CNN5)
    '            Comando5.Parameters.Add(New SqlParameter("@idx", id))
    '            Comando5.Parameters.Add(New SqlParameter("@Fechax", Fecha))
    '            Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
    '            DR5.Close()
    '        Catch ex As Exception
    '            MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
    '            Desconectar5()
    '        End Try
    '    End If
    '    Desconectar5()
    'End Su



    'Private Sub BTipoReceta_Click(sender As Object, e As EventArgs)
    '    VarBuscar = "TipoReceta"
    '    FBuscarGenerico.LTitulo.Text = "Tipos de Recetas."
    '    FBuscarGenerico.LTitulo.Tag = Me.TTipoReceta.Tag
    '    FBuscarGenerico.ShowDialog()
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BActExistencia.Click
    '    If (Me.TCodigo.Text <> "") Then
    '        Try
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("UPDATE TNewProducto set ExistenciaMin=@ExistenciaMin, ExistenciaMax=@ExistenciaMax WHERE idProducto=" & Me.TCodigo.Text, CNN)
    '                Comando.Parameters.Add(New SqlParameter("@ExistenciaMin", Convert.ToInt16(Me.TExistenciaMin.Text)))
    '                Comando.Parameters.Add(New SqlParameter("@ExistenciaMax", Convert.ToInt16(Me.TExistenciaMax.Text)))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                MsgBox("La Existencia Mínima y Máxima Fueron Actualizadas con Exito!!!")
    '                Desconectar()
    '            End If
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar la Existencia Mínima y Máxima.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    Else
    '        MsgBox("Este Producto debe ser Guardado, antes de Actualizar la Existencia Mínima y Máxima.", MsgBoxStyle.Information, "MarSoft: Información.")
    '    End If
    'End Sub

    'Private Sub BActualizar_Click(sender As Object, e As EventArgs)

    'End Sub
    'Private Sub TCantXBandejaKeyPress(sender As Object, e As KeyPressEventArgs)
    '    e.Handled = txtNumerico(TCantXBandeja, e.KeyChar, False)
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub BuscarPrecios()
        If Conectar() Then
            Dim Comando As New SqlCommand("SELECT Costo, CostoD, Precio1, PrecioD1, IVAC, IVAV, idIVAC, idIVAV, PrecioM, PrecioDM, PrecioRemate, PrecioRemateD FROM VProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
            Dim DatosArt As SqlDataReader = Comando.ExecuteReader()

            Do While DatosArt.Read()
                '    Me.TCosto.Text = Format(DatosArt("CostoD") * BsXDolarBC, "##,##0.00")
                Me.TCostoD.Text = Format(DatosArt("CostoD"), "##,##0.00")

                Me.TIVAC.Text = Format(DatosArt("IVAC"), "##,##0.00")
                Me.TIVAC.Tag = DatosArt("idIVAC")
                Me.TIVAV.Text = Format(DatosArt("IVAV"), "##,##0.00")
                Me.TIVAV.Tag = DatosArt("idIVAV")
                '    Me.Precio1SinImp.Text = Format(DatosArt("Precio1"), "##,##0.00")
                '    Me.PrecioMSinImp.Text = Format(DatosArt("PrecioM"), "##,##0.00")
                '    Me.PrecioRemSinImp.Text = Format(DatosArt("PrecioRemate"), "##,##0.00")
                Me.Precio1D.Text = Format(DatosArt("PrecioD1"), "##,##0.00")
                Me.PrecioMD.Text = Format(DatosArt("PrecioDM"), "##,##0.00")
                Me.PrecioDescuento.Text = Format(DatosArt("PrecioRemateD"), "##,##0.00")

                Me.Precio1DCI.Text = Format(Convert.ToDecimal(Me.Precio1D.Text) + (Convert.ToDecimal(Me.Precio1D.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
                Me.PrecioMDCI.Text = Format(Convert.ToDecimal(Me.PrecioMD.Text) + (Convert.ToDecimal(Me.PrecioMD.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
                Me.PrecioDescuentoCI.Text = Format(Convert.ToDecimal(Me.PrecioDescuento.Text) + (Convert.ToDecimal(Me.PrecioDescuento.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")

                Dim ImpuestoC As Decimal = (Convert.ToDecimal(TCostoD.Text) / 100) * DatosArt("IvaC")
                Dim ImpuestoCD As Decimal = (Convert.ToDecimal(TCostoD.Text) / 100) * DatosArt("IvaC")
                Dim Impuesto As Decimal = (Convert.ToDecimal(TCostoD.Text) / 100) * DatosArt("IvaV")
                Dim ImpuestoD As Decimal = (Convert.ToDecimal(TCostoD.Text) / 100) * DatosArt("IvaV")

                '   Me.TImpuestoC.Text = Format(ImpuestoC, "##,##0.00")
                '   Me.TImpuestoCD.Text = Format(ImpuestoCD, "##,##0.00")
                '   Me.TImpuestoV.Text = Format(Impuesto, "##,##0.00")
                '   Me.TImpuestoVD.Text = Format(ImpuestoD, "##,##0.00")

                '    Me.Precio1CI.Text = Format(DatosArt("Precio1") + Impuesto, "##,##0.00")
                '   Me.PrecioMCI.Text = Format(DatosArt("PrecioM") + Impuesto, "##,##0.00")
                '   Me.PrecioRemCI.Text = Format(DatosArt("PrecioRemate") + Impuesto, "##,##0.00")
                'Me.Precio1DCI.Text = Format(DatosArt("PrecioD1") + ImpuestoD, "##,##0.00")
                'Me.PrecioMDCI.Text = Format(DatosArt("PrecioDM") + ImpuestoD, "##,##0.00")
                'Me.PrecioRemDCI.Text = Format(DatosArt("PrecioRemateD") + ImpuestoD, "##,##0.00")

                'Dim Utilidad As Double = 0
                'Utilidad = Convert.ToDouble(Me.Precio1SinImp.Text) - Convert.ToDouble(Me.TCosto.Text)
                'If (Me.Precio1SinImp.Text = 0) Then
                '    Me.Precio1UC.Text = "0,00"
                '    Me.Precio1UP.Text = "0,00"
                'Else
                '    Me.Precio1UC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCosto.Text), "##,##0.00")
                '    Me.Precio1UP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.Precio1SinImp.Text), "##,##0.00")
                'End If

                'Utilidad = Convert.ToDouble(Me.PrecioMSinImp.Text) - Convert.ToDouble(Me.TCosto.Text)
                'If (Me.PrecioMSinImp.Text = 0) Then
                '    Me.PrecioMUC.Text = "0,00"
                '    Me.PrecioMUP.Text = "0,00"
                'Else
                '    Me.PrecioMUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCosto.Text), "##,##0.00")
                '    Me.PrecioMUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioMSinImp.Text), "##,##0.00")
                'End If

                'Utilidad = Convert.ToDouble(Me.PrecioRemSinImp.Text) - Convert.ToDouble(Me.TCosto.Text)
                'If (Me.PrecioRemSinImp.Text = 0) Then
                '    Me.PrecioRemUC.Text = "0,00"
                '    Me.PrecioRemUP.Text = "0,00"
                'Else
                '    Me.PrecioRemUC.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.TCosto.Text), "##,##0.00")
                '    Me.PrecioRemUP.Text = Format((Utilidad * 100) / Convert.ToDouble(Me.PrecioRemSinImp.Text), "##,##0.00")
                'End If
            Loop
            DatosArt.Close()
            Desconectar()
        End If
    End Sub
    Private Sub TabPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPrincipal.SelectedIndexChanged
        If (Me.TCodigo.Text <> "") Then
            Dim Total As Decimal = 0
            Select Case TabPrincipal.SelectedTab.Name
                Case Tab_Proveedor.Name 'Proveedor
                    'If Conectar() Then
                    '    Me.DGVProveedor.Columns("Codigo").Visible = False
                    '    Me.DGVProveedor.Columns("Producto").Visible = False
                    '    Dim Comando As New SqlCommand("SELECT * FROM VProveedorProducto WHERE idProducto=" & Me.TCodigo.Text & " ORDER BY Fecha DESC", CNN)
                    '    Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
                    '    Me.DGVProveedor.Rows.Clear()
                    '    Do While DatosArt.Read()
                    '        Me.DGVProveedor.Rows.Add(DatosArt("NumDoc"), 0, "", DatosArt("Nombre"), Format(DatosArt("Fecha"), "dd/MM/yyyy"), DatosArt("Cantidad"), DatosArt("Unidad"), Format(DatosArt("CostoD"), "##,##0.00"), Format(DatosArt("Costo"), "##,##0.00"), Format(DatosArt("Costo2D"), "##,##0.00"), Format(DatosArt("Costo2"), "##,##0.00"), Format(DatosArt("TotalD"), "##,##0.00"), Format(DatosArt("Total"), "##,##0.00"))
                    '    Loop
                    '    DatosArt.Close()
                    '    Desconectar()
                    'End If                   
                Case Tab_Existencia.Name 'Existencias
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("SELECT ExistenciaMin, ExistenciaMax, Stock FROM TProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        Do While DR.Read()
                            If (IsDBNull(DR("ExistenciaMin"))) Then
                                Me.TExistenciaMin.Text = ""
                            Else
                                Me.TExistenciaMin.Text = VFormat(DR("ExistenciaMin"), 2)
                            End If
                            If (IsDBNull(DR("ExistenciaMax"))) Then
                                Me.TExistenciaMax.Text = ""
                            Else
                                Me.TExistenciaMax.Text = VFormat(DR("ExistenciaMax"), 2)
                            End If
                            Me.TStock.Text = VFormat(Convert.ToDecimal(DR("Stock")), 2)
                        Loop
                        DR.Close()
                        Desconectar()
                    End If
                Case Tab_Precio.Name 'Precios e Impuestos
                    If (Me.TCodigo.Text <> "") Then
                        '    Me.TCosto.Text = "0"
                        Me.TCostoD.Text = "0"

                        Me.TIVAC.Text = "0"
                        Me.TIVAC.Tag = 8
                        Me.TIVAV.Text = "0"
                        Me.TIVAV.Tag = 8
                        BuscarPrecios()
                    End If
            End Select
        End If
    End Sub

    Function ExisteProd(Cod As String) As Boolean
        Dim Valor As Boolean = False
        If Conectar() Then
            Try
                Dim Comando As New SqlCommand("SELECT  idProducto FROM TProducto Where idProducto=@idProducto", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProducto", Cod))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Valor = True
                Else
                    Valor = False
                End If
                DR.Close()
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
        Return (Valor)
    End Function
    Private Sub MostrarProd()
        If Conectar() Then
            Try
                Dim Comando As New SqlCommand("SELECT  * FROM VProducto Where idProducto=@idProducto", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProducto", Me.TCodigo.Text))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Me.TCodigo.Text = Trim(DR("idProducto").ToString)
                    Me.TNombre.Text = Trim(DR("Nombre").ToString)
                    Me.FechaC.Value = DR("FechaCreacion").ToString
                    Me.CCategoria.Tag = DR("idCategoria").ToString
                    NoActualizar = True
                    Me.CCategoria.Text = DR("Categoria").ToString
                    Me.CSubCategoria.Tag = DR("idSubCategoria").ToString
                    Me.CSubCategoria.Text = DR("SubCategoria").ToString
                    Me.TModelo.Text = Trim(DR("Modelo").ToString)
                    Me.TGarantia.Text = Trim(DR("Garantia").ToString)
                    Me.CProdNac.Text = DR("ProdNacional").ToString
                    Me.TObservacion.Text = Trim(DR("Observaciones").ToString)
                    Me.CBActivo.Checked = DR("Activo").ToString
                    NoActualizar = False
                    'Mostrar la Imagen del Producto
                    Dim ms As New System.IO.MemoryStream()
                    Dim imageBuffer() As Byte = CType(DR("ImagenF"), Byte())
                    ms = New System.IO.MemoryStream(imageBuffer)
                    Imagen.BackgroundImage = Nothing
                    Imagen.BackgroundImage = (Image.FromStream(ms))
                    Imagen.BackgroundImageLayout = ImageLayout.Stretch
                End If
                DR.Close()
                Desconectar()
                LlenarComboSubCategorias()
                '  BuscarPrecios()
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub BBuscarProd_Click(sender As Object, e As EventArgs) Handles BBuscarProd.Click
        VarBuscar = "Producto"
        FBuscarProducto.LTitulo.Text = "Listado de Productos."
        FBuscarProducto.LTitulo.Tag = Me.TCodigo.Text
        FBuscarProducto.ShowDialog()
        TabPrincipal_SelectedIndexChanged(Nothing, Nothing)
        VieneNuevo = False
        If (ExisteProd(Me.TCodigo.Text)) Then
            MostrarProd()
            ExisteProducto = True
        Else
            If (VieneNuevo = False) Then
                NuevoProd_Click(Nothing, Nothing)
                ExisteProducto = False
            End If
        End If
        Me.TNombre.Focus()
    End Sub
    Private Sub NuevoProd_Click(sender As Object, e As EventArgs) Handles NuevoProd.Click
        Me.TCodigo.Text = ""
        Me.TNombre.Text = ""
        Me.TModelo.Text = ""
        Me.CProdNac.Text = "Nacional"
        Me.TGarantia.Text = ""
        Me.TObservacion.Text = ""
        Me.FechaC.Value = Date.Now
        Me.CBActivo.Checked = True
        Me.DGVProveedor.Rows.Clear()
        Me.TStock.Text = ""
        Me.TExistenciaMin.Text = ""
        Me.TExistenciaMax.Text = ""
        Me.TIVAC.Text = "0"
        Me.TIVAC.Tag = 8
        Me.TIVAV.Text = "0"
        Me.TIVAV.Tag = 8
        Me.Imagen.BackgroundImage = Me.PBAuxImagen.BackgroundImage
        Me.TabPrincipal.SelectedIndex = 0
        Me.TCodigo.Focus()
        ExisteProducto = False
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        Imagen.BackgroundImage.Save(ms, Imagen.BackgroundImage.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        If (ExisteProducto = False) Then
            ' If (Me.TCodigo.Text <> "") Then
            If (Me.TNombre.Text <> "") Then
                CantArtActivo = CantArtActivo + 1
                '  If (ValidarEmpaquetado()) Then
                Try
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("INSERT INTO TProducto (ImagenF,Nombre,FechaCreacion, idCategoria, idSubCategoria, idMarca, Modelo, Garantia, ProdNacional, Observaciones, Activo,idIVAC,idIVAV, ExistenciaMin, ExistenciaMax, Precio1, PrecioD1, PrecioM,PrecioDM, PrecioRemate, PrecioRemateD, Costo, CostoD, Stock) VALUES(@ImagenF, @Nombre, @FechaCreacion, @idCategoria, @idSubCategoria, @idMarca, @Modelo, @Garantia, @ProdNacional, @Observaciones, @Activo, @idIVAC, @idIVAV, @ExistenciaMin, @ExistenciaMax, @Precio1, @PrecioD1, @PrecioM, @PrecioDM, @PrecioRemate, @PrecioRemateD, @Costo, @CostoD, @Stock)", CNN)
                        Comando.Parameters.Add(New SqlParameter("@ImagenF", arrImage))
                        Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
                        Comando.Parameters.Add(New SqlParameter("@FechaCreacion", Me.FechaC.Value))
                        Comando.Parameters.Add(New SqlParameter("@idCategoria", Trim(Me.CCategoria.SelectedValue)))
                        Comando.Parameters.Add(New SqlParameter("@idSubCategoria", Trim(Me.CSubCategoria.SelectedValue)))
                        Comando.Parameters.Add(New SqlParameter("@idMarca", Trim(Me.CMarca.SelectedValue)))
                        Comando.Parameters.Add(New SqlParameter("@Modelo", Trim(Me.TModelo.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Garantia", Trim(Me.TGarantia.Text)))
                        Comando.Parameters.Add(New SqlParameter("@ProdNacional", Trim(Me.CProdNac.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Observaciones", Trim(Me.TObservacion.Text)))
                        Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
                        Comando.Parameters.Add(New SqlParameter("@idIVAC", Me.TIVAC.Tag))
                        Comando.Parameters.Add(New SqlParameter("@idIVAV", Me.TIVAV.Tag))
                        Comando.Parameters.Add(New SqlParameter("@ExistenciaMin", Convert.ToInt64(IIf(Me.TExistenciaMin.Text = "", 0, Me.TExistenciaMin.Text))))
                        Comando.Parameters.Add(New SqlParameter("@ExistenciaMax", Convert.ToInt64(IIf(Me.TExistenciaMax.Text = "", 0, Me.TExistenciaMax.Text))))
                        Comando.Parameters.Add(New SqlParameter("@Precio1", 0))
                        Comando.Parameters.Add(New SqlParameter("@PrecioD1", Convert.ToDecimal(IIf(Me.Precio1D.Text = "", 0, Me.Precio1D.Text))))
                        Comando.Parameters.Add(New SqlParameter("@PrecioM", 0))
                        Comando.Parameters.Add(New SqlParameter("@PrecioDM", Convert.ToDecimal(IIf(Me.PrecioMD.Text = "", 0, Me.PrecioMD.Text))))
                        Comando.Parameters.Add(New SqlParameter("@PrecioRemate", 0))
                        Comando.Parameters.Add(New SqlParameter("@PrecioRemateD", Convert.ToDecimal(IIf(Me.PrecioDescuento.Text = "", 0, Me.PrecioDescuento.Text))))
                        Comando.Parameters.Add(New SqlParameter("@Costo", 0))
                        Comando.Parameters.Add(New SqlParameter("@CostoD", 0))
                        Comando.Parameters.Add(New SqlParameter("@Stock", 0))
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        DR.Close()
                        DataT = New DataTable
                        Adaptador = New SqlDataAdapter("Select * FROM TProducto", CNN)
                        Adaptador.Fill(DataT)
                        Dim Fila As DataRow = DataT.Rows(DataT.Rows.Count - 1)
                        Me.TCodigo.Text = Trim(Fila("idProducto"))
                        Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Los Datos Fueron Guardados con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                    Desconectar()
                Catch ex As Exception
                    Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("Error al Guardar los Datos del Productos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar()
                End Try
            Else
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("El Nombre del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.TNombre.Focus()
            End If
            'Else
            '    Cursor = System.Windows.Forms.Cursors.Default
            '    MsgBox("El Código del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
            '    Me.TCodigo.Focus()
            'End If
        Else
            If (Me.TCodigo.Text <> "") Then
                If (Me.TNombre.Text <> "") Then
                    Try
                        If (Conectar()) Then
                            Dim Comando As New SqlCommand("UPDATE TProducto set ImagenF=@ImagenF, Nombre=@Nombre, FechaCreacion=@FechaCreacion, idCategoria=@idCategoria, idSubCategoria=@idSubCategoria, idMarca=@idMarca, Modelo=@Modelo, Garantia=@Garantia, ProdNacional=@ProdNacional, Observaciones=@Observaciones, Activo=@Activo, idIVAC=@idIVAC,idIVAV=@idIVAV, ExistenciaMin=@ExistenciaMin, ExistenciaMax=@ExistenciaMax, Precio1=@Precio1, PrecioD1=@PrecioD1,PrecioM=@PrecioM, PrecioDM=@PrecioDM, PrecioRemate=@PrecioRemate, PrecioRemateD=@PrecioRemateD WHERE idProducto=" & Me.TCodigo.Text, CNN)
                            Comando.Parameters.Add(New SqlParameter("@Codigo", Me.TCodigo.Text))
                            Comando.Parameters.Add(New SqlParameter("@ImagenF", arrImage))
                            Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.TNombre.Text)))
                            Comando.Parameters.Add(New SqlParameter("@FechaCreacion", Me.FechaC.Value))
                            Comando.Parameters.Add(New SqlParameter("@idCategoria", Trim(Me.CCategoria.SelectedValue)))
                            Comando.Parameters.Add(New SqlParameter("@idSubCategoria", Trim(Me.CSubCategoria.SelectedValue)))
                            Comando.Parameters.Add(New SqlParameter("@idMarca", Trim(Me.CMarca.SelectedValue)))
                            Comando.Parameters.Add(New SqlParameter("@Modelo", Trim(Me.TModelo.Text)))
                            Comando.Parameters.Add(New SqlParameter("@Garantia", Trim(Me.TGarantia.Text)))
                            Comando.Parameters.Add(New SqlParameter("@ProdNacional", Trim(Me.CProdNac.Text)))
                            Comando.Parameters.Add(New SqlParameter("@Observaciones", Trim(Me.TObservacion.Text)))
                            Comando.Parameters.Add(New SqlParameter("@Activo", Me.CBActivo.Checked.ToString))
                            Comando.Parameters.Add(New SqlParameter("@idIVAC", Me.TIVAC.Tag))
                            Comando.Parameters.Add(New SqlParameter("@idIVAV", Me.TIVAV.Tag))
                            Comando.Parameters.Add(New SqlParameter("@ExistenciaMin", Convert.ToInt64(IIf(Me.TExistenciaMin.Text = "", 0, Me.TExistenciaMin.Text))))
                            Comando.Parameters.Add(New SqlParameter("@ExistenciaMax", Convert.ToInt64(IIf(Me.TExistenciaMax.Text = "", 0, Me.TExistenciaMax.Text))))
                            Comando.Parameters.Add(New SqlParameter("@Precio1", 0))
                            Comando.Parameters.Add(New SqlParameter("@PrecioD1", Convert.ToDecimal(IIf(Me.Precio1D.Text = "", 0, Me.Precio1D.Text))))
                            Comando.Parameters.Add(New SqlParameter("@PrecioM", 0))
                            Comando.Parameters.Add(New SqlParameter("@PrecioDM", Convert.ToDecimal(IIf(Me.PrecioMD.Text = "", 0, Me.PrecioMD.Text))))
                            Comando.Parameters.Add(New SqlParameter("@PrecioRemate", 0))
                            Comando.Parameters.Add(New SqlParameter("@PrecioRemateD", Convert.ToDecimal(IIf(Me.PrecioDescuento.Text = "", 0, Me.PrecioDescuento.Text))))
                            Dim DR As SqlDataReader = Comando.ExecuteReader()
                            DR.Close()
                            Desconectar()
                            Cursor = System.Windows.Forms.Cursors.Default
                            MsgBox("Los Datos Fueron Actualizados con Exito!!!")
                            Me.TabPrincipal.SelectedIndex = 0
                            ExisteProducto = True
                        End If
                    Catch ex As Exception
                        Cursor = System.Windows.Forms.Cursors.Default
                        MsgBox("Error al Editar Datos de Productos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                        Desconectar()
                    End Try
                Else
                    Cursor = System.Windows.Forms.Cursors.Default
                    MsgBox("El Nombre del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TNombre.Focus()
                End If
            Else
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("El Código del Producto No puede ser Vacio.", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.TCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        If MsgBox("Esta seguro que desea Eliminar este Producto: " & Me.TCodigo.Text & " / " & Me.TNombre.Text & "?", vbYesNo, "MarSoft: Eliminar Producto.") = vbYes Then
            If (Me.TCodigo.Text <> "") Then
                Select Case Me.TCodigo.Text
                    Case Is < 4
                        MsgBox("Esta Categoria Pertenece al Sistema «NO Puede Ser Eliminada».  ", MsgBoxStyle.Information, "MarSoft: Información.")
                    Case Else
                        If (Conectar()) Then
                            Try
                                Dim Comando As New SqlCommand("DELETE FROM TProducto WHERE idProducto=" & Me.TCodigo.Text, CNN)
                                Dim DR As SqlDataReader = Comando.ExecuteReader()
                                DR.Close()
                                NuevoProd_Click(Nothing, Nothing)
                                Me.TCodigo.Text = ""
                            Catch ex As Exception
                                MsgBox("Error al Eliminar Datos Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                                Desconectar()
                            End Try
                        End If
                        Desconectar()
                End Select
              
            End If
        End If
    End Sub

    Private Sub LlenarComboCategorias()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT  * FROM TCategoria ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                aqui = True
                Me.CCategoria.DataSource = DataT
                Me.CCategoria.DisplayMember = "Nombre"
                Me.CCategoria.ValueMember = "Id"
                aqui = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de las Categorias..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub LlenarComboSubCategorias()
        If aqui = False Then
            If Conectar() Then
                Try
                    Adaptador = New SqlDataAdapter("SELECT  * FROM TSubCategoria WHERE idCategoria =" & Me.CCategoria.SelectedValue & "  ORDER BY Nombre ASC", CNN)
                    DataT = New DataTable
                    Adaptador.Fill(DataT)
                    Me.CSubCategoria.DataSource = DataT
                    Me.CSubCategoria.DisplayMember = "Nombre"
                    Me.CSubCategoria.ValueMember = "Id"
                Catch ex As Exception
                    MessageBox.Show("Error al Cargar Datos de las SubCategorias..." & ControlChars.CrLf & ex.Message)
                    Desconectar()
                End Try
            End If
            Desconectar()
        End If
    End Sub
    Private Sub LlenarComboMarca()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT  * FROM TMarca ORDER BY Marca ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                aqui = True
                Me.CMarca.DataSource = DataT
                Me.CMarca.DisplayMember = "Nombre"
                Me.CMarca.ValueMember = "Id"
                aqui = False
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de las Marcas..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub BCategorias_Click_1(sender As Object, e As EventArgs) Handles BCategorias.Click
        FCategoria.ShowDialog()
        LlenarComboCategorias()
    End Sub
    Private Sub BSubCategorias_Click(sender As Object, e As EventArgs) Handles BSubCategorias.Click
        FSubCategoria.ShowDialog()
        LlenarComboSubCategorias()
    End Sub

    Private Sub FProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboCategorias()
        LlenarComboSubCategorias()
        LlenarComboMarca()
        Select Case VarForma         
            Case "ModuloProd"
                VieneNuevo = False
                If (ExisteProd(Me.TCodigo.Text)) Then
                    MostrarProd()
                    ExisteProducto = True
                Else
                    If (VieneNuevo = False) Then
                        NuevoProd_Click(Nothing, Nothing)
                        ExisteProducto = False
                    End If
                End If
                Me.TNombre.Focus()
            Case Else             
                NuevoProd_Click(Nothing, Nothing)
        End Select
        Me.TNombre.Focus()
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub CCategoria_TextChanged(sender As Object, e As EventArgs) Handles CCategoria.TextChanged
        If (NoActualizar = False) Then
            LlenarComboSubCategorias()
        End If
    End Sub

    Private Sub BMarcas_Click(sender As Object, e As EventArgs) Handles BMarcas.Click
        FMarca.ShowDialog()
        LlenarComboMarca()
    End Sub
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Me.Dialogo.CheckFileExists = True
        Me.Dialogo.ShowReadOnly = False
        Me.Dialogo.Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
        If Me.Dialogo.ShowDialog = DialogResult.OK Then
            Me.Imagen.BackgroundImage = Image.FromFile(Me.Dialogo.FileName)
        End If
    End Sub
    Private Sub BQuitar_Click(sender As Object, e As EventArgs) Handles BQuitar.Click
        Me.Imagen.BackgroundImage = Me.PBAuxImagen.BackgroundImage
        Me.Dialogo.FileName = My.Application.Info.DirectoryPath & "\Imagenes\SinImagen.JPG"
    End Sub
    Private Sub TExistenciaMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TExistenciaMin.KeyPress
        e.Handled = txtNumerico(TExistenciaMin, e.KeyChar, False)
    End Sub

    Private Sub TExistenciaMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TExistenciaMax.KeyPress     
        e.Handled = txtNumerico(TExistenciaMax, e.KeyChar, False)
    End Sub
    Private Sub BIVAC_Click(sender As Object, e As EventArgs) Handles BIVAC.Click
        VarBuscar = "AlicuotaProdC"
        FBuscarGenericoxx.LTitulo.Text = "Alicuota para la Compra."
        FBuscarGenericoxx.LTitulo.Tag = Me.TIVAC.Tag
        FBuscarGenericoxx.ShowDialog()
    End Sub
    Private Sub BIVAV_Click(sender As Object, e As EventArgs) Handles BIVAV.Click
        VarBuscar = "AlicuotaProdV"
        FBuscarGenericoxx.LTitulo.Text = "Alicuota para la Venta."
        FBuscarGenericoxx.LTitulo.Tag = Me.TIVAV.Tag
        FBuscarGenericoxx.ShowDialog()
        Me.Precio1DCI.Text = Format(Convert.ToDecimal(Me.Precio1D.Text) + (Convert.ToDecimal(Me.Precio1D.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
        Me.PrecioMDCI.Text = Format(Convert.ToDecimal(Me.PrecioMD.Text) + (Convert.ToDecimal(Me.PrecioMD.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
        Me.PrecioDescuentoCI.Text = Format(Convert.ToDecimal(Me.PrecioDescuento.Text) + (Convert.ToDecimal(Me.PrecioDescuento.Text) / 100) * Convert.ToDecimal(Me.TIVAV.Text), "##,##0.00")
    End Sub

    Private Sub Tab_General_Click(sender As Object, e As EventArgs) Handles Tab_General.Click

    End Sub

    Private Sub TIVAC_TextChanged(sender As Object, e As EventArgs) Handles TIVAC.TextChanged

    End Sub
End Class