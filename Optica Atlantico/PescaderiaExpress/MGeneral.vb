Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Font
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Module MGeneral
    Public CodOrden As Integer = 0
    Public DEsf As String = ""
    Public DCil As String = ""
    Public DEje As String = ""
    Public DAdd As String = ""
    Public IEsf As String = ""
    Public ICil As String = ""
    Public IEje As String = ""
    Public IAdd As String = ""
    Public H As String = ""
    Public V As String = ""
    Public D As String = ""
    Public P As String = ""
    Public Max As String = ""
    Public DP As String = ""
    Public Alt As String = ""
    Public ObservacionFormula As String = ""
    Public AbonadoGnal As Decimal = 0
    Public TipoPago As String = ""
    Public FormulaExterna As Boolean = False
    Public DoctorExt As String = ""

    ' Aqui hacia arriba..................................................................
    Public GridAux As DataGridView
    Public TipoSistema As String = "NoTickeraNoFiscal" 'Tickera   'Fiscal ' NoTickeraNoFiscal
    Public PosicionCat As Integer = 0
    Public PosicionArt As Integer = 0
    Public CatActiva As String = ""
    Public CantCatActiva As Integer = 0
    Public CantArtActivo As Integer = 0
    ' Public TextoEscrito As String = ""
    Public VarBuscar As String = ""
    Public VarForma As String = ""
    Public VarFormaControlCaja As String = ""
    Public ContLinea As Integer = 0
    Public AuxCambio As Boolean = True 'Esta variable controla que en las formas de pago se agregue una nueva linea con el monto a pagar cuando entra por primera vez .
    Public ActivarGuardar As Boolean = False
    Public ActivarEditar As Boolean = False
    Public CodCompra As Integer = 0
    Public CodCompraGastos As Integer = 0
    Public LocalActivo As String = "La Bodega"
    Public CodLocalActivo As Integer = 1
    Public NFacturaX As String = ""

    ' Public Cont
    Public CodVenta As Integer = 0
    Public CodVentaMesa As Integer = 0
    Public CodFactura As Integer = 0

    'Public CodVenta As Integer = 0

    Public CodProducto As String = ""
    Public UsuarioActivo As String = ""
    Public TipoUsuario As Integer = 0
    Public ValRespuesta As Boolean = False
    Public CodReserva As Integer = 0
    Public CodCliente As Integer = 0
    Public TipoPlanta As String = 0
    Public CICliente As String = ""
    Public CodDetalleVenta As Integer = 0
    Public CodDetalleReserva As Integer = 0
    Public Editar As String = ""
    Public Excepcion As Boolean = False
    Public CodProveedor As Integer = 0
    Public NombreProveedor As String = ""
    Public CostoProd As Decimal = 0
    Public CostoDProd As Decimal = 0
    Public CodPescado As String = ""
    Public PesoProd As Integer = 0
    Public PrecioProd As Decimal = 0
    Public Cliente As String = ""
    Public ValTotal As Decimal = 0
    Public ValTotalD As Decimal = 0
    Public Proveedor As String = ""
    Public CodEmpleado As Integer = 0
    Public Empleado As String = ""
    Public TasaCambioInic As Decimal = 0

    Public BuscarEmpleado As Boolean = False
    Public DiasAtraso As Integer = 0
    Public FechaCompromisoPago As DateTime
    Public FechaXCompra As Date

    'Variables cambio de Articulo
    Public DesdeG As Date
    Public HastaG As Date
    Public NumSem As Integer = 0
    Public RutaDestino = ""
    Public RutaOrigen = ""
    Public CodPDF As Integer = 0
    Public CodFormaPago As Integer = 0
    Public FactorFileteado As Decimal = 0
    Public ArtSeleccionado As Integer = 0
    Public TipoGrafica As String = ""
    Public ConsultaImprimir As String = ""
    'Variables Inicializar 
    Public VarXBs As Decimal = 0
    Public Rojo As Decimal = 0
    Public Naranja1 As Decimal = 0
    Public Naranja2 As Decimal = 0
    Public Amarillo1 As Decimal = 0
    Public Amarillo2 As Decimal = 0
    Public Verde1 As Decimal = 0
    Public Verde2 As Decimal = 0
    Public Morado As Decimal = 0
    Public PPrecio1 As Decimal = 0
    Public PPrecio2 As Decimal = 0
    Public PPrecio3 As Decimal = 0
    Public PPrecio4 As Decimal = 0
    Public PPrecio5 As Decimal = 0
    Public PPrecioE As Decimal = 0
    Public PPrecioM As Decimal = 0
    Public PEmp1 As Decimal = 0
    Public PEmp2 As Decimal = 0
    Public PEmp3 As Decimal = 0
    Public CantMesas As Integer = 0
    Public CantBarras As Integer = 0


    Public Direccion As String = ""
    Public BsFlete As Decimal = 0
    Public idEspRef As Integer = 0
    Public CostoRef As Decimal = 0
    Public RecargoRef As Decimal = 0
    Public ComisionBanco As Decimal = 0
    '   Public PorcPrecio4 As Decimal = 0
    'Variables Guardar los datos de Totalizar antes de Guardar la Compra.
    Public Num_Doc As String = ""
    Public TotalBruto_ As Decimal = 0
    Public Descuento_ As Decimal = 0
    Public Flete_ As Decimal = 0
    Public IVA_ As Decimal = 0
    Public TotalNeto_ As Decimal = 0
    Public TotalCancelado_ As Decimal = 0
    Public Saldo_ As Decimal = 0
    Public TotalBrutoD_ As Decimal = 0
    Public DescuentoD_ As Decimal = 0
    Public FleteD_ As Decimal = 0
    Public IVAD_ As Decimal = 0
    Public TotalNetoD_ As Decimal = 0
    '   Public Tasa_ As Decimal = 0
    Public TotalCanceladoD_ As Decimal = 0
    Public SaldoD_ As Decimal = 0
    Public FechaEmision_ As Date
    Public FechaVencimiento_ As Date
    Public HoraEntrada As DateTime
    Public HoraSalida As DateTime
    Public ASobreTiempoU As Boolean = False
    Public SobreTiempoU As Integer
    Public ComentarioU As String = ""
    Public idAutoriza As Integer = -1
    Public NoEjecutar As Boolean = False
    Public idGastoX As Integer = 0
    Public idGastoDesdeCompra As Integer = 0
    Public IdCajaChicaAux As Integer = 0


    'varios
    Public FechaDC As Date
    Public ProveedorDC As String = ""
    Public TotalDC As Decimal = 0
    Public VienePrecio As Boolean = False
    Public SQLImprimir As String = ""
    Public Validado As Boolean = False
    Public IDY As Integer = 0
    Public Hoja As Integer = 0
    Public Hoja2 As Integer = 0
    Public Linea As Integer = 0
    Public TipoPagoGeneral As String = ""
    Public ContRecarga As Integer = 0
    Public idTipoExc As Integer = 1
    Public idFueraPresup As Integer = 1
    Public ComentExcPresup As String = ""
    Public MontoExceso As Decimal = 0
    Public ResponsableExcPresup As Integer = 54
    Public PorcEfect As Decimal = 0
    Public MontoEfect As Decimal = 0
    Public EsSocio As Boolean = False
    Public DiaCredAlMayor As Integer = 0
    Public VentaEspecial As Boolean = False
    Public BsXDolar As Decimal = 0
    Public BsXDolarOficial As Decimal = 0
    Public BsXDolarEfectivo As Decimal = 0
    Public BsXDolarBC As Decimal = 0

    Public BsXDolarAP As Decimal = 0
    Public BsXDolarOficialAP As Decimal = 0
    Public BsXDolarEfectivoAP As Decimal = 0
    Public BsXDolarBCAP As Decimal = 0

    Public TotalX As Decimal = 0
    Public GastoAsociado As Boolean = False
    Public MontoEnDolarBalance As Decimal = 0
    Public TipoCliente As Boolean = False ' False Cliente, True Empleado
    Public CodCajero As Integer = 0
    '   Public CodCajero As Integer = 0

    Public CodCajeroApertura As Integer = 0
    Public CodCajaActivaApertura As Integer = 0





    'Variables MarSoft
    Public idMesaActiva As Integer = 0
    Public MonedaPred As String = ""
    Public ProductoActivo As String = ""
    Public FechaDia As Date
    Public CajaActiva As String = ""
    Public CodCajaActiva As Integer = 0




    Public TienePermiso As Boolean = False

    Public PrecioD As Decimal = 0
    Public CodVentaAux As Integer = 0
    Public TipoVenta As String = ""
    Public AgregarProductoDirecto As Boolean = False
    Public MonedaBase As String = "Bolívar"
    Public MonedaPago As String = "Bolívar"
    Public Categoria = ""
    Public NoActualizar As Boolean = False
    Public TipoProducto As String = "Terminados"
    Public VieneNuevo As Boolean = False
    Public NuevoCosto As Decimal = 0
    Public NuevoCostoD As Decimal = 0
    Public NuevoPorcDesc As Decimal = 0
    Public NuevoDescuento As Decimal = 0
    Public NuevoDescuentoD As Decimal = 0
    Public NuevoDescuentoGral As Decimal = 0
    Public NuevoDescuentoDGral As Decimal = 0
    Public NuevoPorcGral As Decimal = 0
    Public GuardarVenta As Boolean = False
    Public Indice As Integer = 0
    Public UsaDecimal As Boolean = False
    Public Proviene As String = ""
    Public CodApertura As Integer = -1
    Public Continuar As Boolean = False
    Public CedulaCliente As Integer = 0
    Public TipoRIFCliente As String = ""
    Public RIFCliente As String = ""
    Public NomEmpresa As String = ""
    Public NombreCliente As String = ""
    Public CategoriasSeleccionadas As String = ""
    Public CajasSeleccionadas As String = ""
    Public CajasSeleccionadasX As String = ""
    Public ImprimirRif As Boolean = False

    Public Autorizado As Boolean = False


    Public CostoEmp As Decimal = 0
    Public CostoDEmp As Decimal = 0

    Public Precio1Emp As Decimal = 0
    Public Precio2Emp As Decimal = 0
    Public Precio3Emp As Decimal = 0
    Public Precio4Emp As Decimal = 0
    Public PrecioMEmp As Decimal = 0

    Public PrecioEfectivoEmp As Decimal = 0
    Public PrecioD1Emp As Decimal = 0
    Public PrecioD2Emp As Decimal = 0
    Public PrecioD3Emp As Decimal = 0
    Public PrecioD4Emp As Decimal = 0
    Public PrecioEfectivoDEmp As Decimal = 0
    Public PrecioDMEmp As Decimal = 0


    Public StockUnidadProd As Decimal = 0
    Public StockUnidadCap As Decimal = 0
    Public StockUnidadAlt As Decimal = 0
    Public StockUnidadCatInt As Decimal = 0

    Public DifMoneda As Boolean = False
    Public ValorDifMoneda As Decimal = 0
    Public idCat As Integer = 0
    Public idSubCat As Integer = 0
    Public Salir As Boolean = False

    Public MontoGasto As Decimal = 0
    Public MontoGastoD As Decimal = 0

    Public TasaSeleccionada As String = "BancoCentral"
    Public CajaChicaActiva As String = ""
    Public CalcularConCapacidad As Boolean = False

    Public Contador As Integer = 0
    Public Inicio As Integer = 1
    Public Limite As Integer = 48
    Public TotalProd As Integer = 0
    Public Estado As String = ""

    Public MontoFAD As Decimal = 0
    Public MontoFA As Decimal = 0
    Public CodCompraFA As Integer = 0
    Public CodCategoria As Integer = 0

    Public RequiereEmpleado As Boolean = False

    Public DesdeX As DateTime
    Public HastaX As DateTime
    ''''''''''''''''''''''''''''''''''''''''''''
    Public TotalVenta As Decimal = 0
    Public TotalVentaD As Decimal = 0
    Public TotalIVAV As Decimal = 0
    Public TotalIVAVD As Decimal = 0
    '''''''''''''''''''''''calculo Costos'''''''
    Public NX_CostoD As Decimal = 0
    Public NX_Costo As Decimal = 0
    Public NX_PorcCosto As Decimal = 0
    Public NX_Costo2D As Decimal = 0
    Public NX_Costo2 As Decimal = 0
    Public NX_Capacidad As Decimal = 0
    Public NX_UnidadCapacidad As String = ""
    Public NX_idUnidadCapacidad As Integer = 0
    Public NX_idUnidadAlterna As Integer = 0
    Public NX_UnidadAlterna As String = ""
    Public NX_FactorAterno As String = ""
    Public NX_TipoFactorAlterno As String = ""
    Public NX_UnidadProducto As String = ""
    Public Nx_CostoCalD As Decimal = 0
    Public NX_CalculoCap As Boolean = False

    Public ConcatenarProdVendidos As String = ""
    Public DescuentoRem As Decimal = 0
    Public idRelacionarFactura As Integer = 0
    Public ErrorTrans As Boolean = False
    Public VIVAV As Decimal = 0
    Public PorcIVAV As Decimal = 0
    'Variables para Mensajes
    Public Mensaje As String = ""
    Public MensajeTitulo As String = ""
    Public TipoMensaje As Integer = 0
    Public TipoColorFondo As Color
    Public TamañoLetra = 16
    Public RespMensaje As String = ""
    Public ListadoMostrar As String = ""


    Public ListaLocal As String = ""
    Public ListaLocalOnLine As String = ""
    Public ListaCajas As String = ""
    Public ListaCajero As String = ""
    Public Listacategorias As String = ""
    Public ListaTipoPago As String = ""
    Public ListaClientes As String = ""
    Public ListaEmpleados As String = ""
    Public ListaProductos As String = ""
    Public ListaEstado As String = ""
    Public ListaDepartamento As String = ""

    Public ListaLocalX As String = ""
    Public ListaCajasX As String = ""
    Public ListaCajeroX As String = ""
    Public ListacategoriasX As String = ""
    Public ListaTipoPagoX As String = ""
    Public ListaClientesX As String = ""
    Public ListaEmpleadosX As String = ""
    Public ListaProductosX As String = ""
    Public ListaEstadoX As String = ""

    Public ListaDepartamentoX As String = ""

    Public Cancelada As Boolean = False
    Public CodCancelado As Integer = 0
    Public NumComanda As Integer = 0
    Public CodMesa As Integer = 0
    Public MesaSeleccionada As Integer = 0
    Public Mesero As String = ""
    Public CodMesero As Integer = 0
    Public HoraApertura As String = ""
    Public FechaApertura As DateTime
    Public EstadoMesas As String = "Inactiva"
    Public EstadoVentaAux As String = "Espera"
    Public TodaVentaOnLine As Boolean = False
    Public TodaPosVenta As Boolean = False
    Public CodFacturaImprimir As Integer = 0
    Public DevolucionFiscal As Boolean = False
    Public Deli As Boolean = False
    Public VendedorPropina As Integer = 0
    Public CadSQLActiva As String = 0
    Public CodRecepcion As Integer = 0
    Public TipoMonedaX As String = ""
    Public CompraIngresada As Boolean = False
    Public DepartActivo As String = ""
    Public CodDepartActivo As Integer = 0
    Public Observacionrecepcion = ""
    Public ProvieneCambio As String = ""
    Public StockenCero As Boolean = False
    Public MayorqueStock As Boolean = False

    Public TipoAutoriza As String = ""
    Public QueAutorizo As String = ""
    Public DevolucionporDatos As Boolean = False

    'Public Sub DesactivarBotonesMensaje()
    '    FMensaje.BAceptar.Visible = False
    '    FMensaje.LAceptar.Visible = False
    '    FMensaje.BSalir.Visible = False
    '    FMensaje.LSalir.Visible = False
    '    FMensaje.BGuardar.Visible = False
    '    FMensaje.LGuardar.Visible = False
    '    FMensaje.BNo.Visible = False
    '    FMensaje.LNo.Visible = False
    '    FMensaje.BSi.Visible = False
    '    FMensaje.LSi.Visible = False
    '    FMensaje.BNoInv.Visible = False
    '    FMensaje.LNoInv.Visible = False
    '    FMensaje.BCancelar.Visible = False
    '    FMensaje.LCancelar.Visible = False
    'End Sub
    Public Sub DesactivarCategoria(ByVal ofrm As Control, Activado As Boolean)
        For Each oControl As Control In ofrm.Controls
            oControl.Visible = Activado
        Next
    End Sub

    'Public Sub MostrarCategoriaCajaNew(Activo As Integer, Panel As TableLayoutPanel, Etiqueta As Button)
    '    Select Case Activo
    '        Case 1
    '            FCajaNew.Cat01.BackColor = Panel.BackColor
    '            FCajaNew.Cat01.Tag = Panel.Tag
    '            FCajaNew.BCat01.Tag = Etiqueta.Tag
    '            FCajaNew.BCat01.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat01.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat01.Text = Etiqueta.Text
    '            FCajaNew.BCat01.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat01.Font = Etiqueta.Font
    '            FCajaNew.BCat01.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat01.Visible = True
    '        Case 2
    '            FCajaNew.Cat02.BackColor = Panel.BackColor
    '            FCajaNew.Cat02.Tag = Panel.Tag
    '            FCajaNew.BCat02.Tag = Etiqueta.Tag
    '            FCajaNew.BCat02.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat02.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat02.Text = Etiqueta.Text
    '            FCajaNew.BCat02.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat02.Font = Etiqueta.Font
    '            FCajaNew.BCat02.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat02.Visible = True
    '        Case 3
    '            FCajaNew.Cat03.BackColor = Panel.BackColor
    '            FCajaNew.Cat03.Tag = Panel.Tag
    '            FCajaNew.BCat03.Tag = Etiqueta.Tag
    '            FCajaNew.BCat03.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat03.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat03.Text = Etiqueta.Text
    '            FCajaNew.BCat03.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat03.Font = Etiqueta.Font
    '            FCajaNew.BCat03.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat03.Visible = True
    '        Case 4
    '            FCajaNew.Cat04.BackColor = Panel.BackColor
    '            FCajaNew.Cat04.Tag = Panel.Tag
    '            FCajaNew.BCat04.Tag = Etiqueta.Tag
    '            FCajaNew.BCat04.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat04.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat04.Text = Etiqueta.Text
    '            FCajaNew.BCat04.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat04.Font = Etiqueta.Font
    '            FCajaNew.BCat04.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat04.Visible = True
    '        Case 5
    '            FCajaNew.Cat05.BackColor = Panel.BackColor
    '            FCajaNew.Cat05.Tag = Panel.Tag
    '            FCajaNew.BCat05.Tag = Etiqueta.Tag
    '            FCajaNew.BCat05.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat05.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat05.Text = Etiqueta.Text
    '            FCajaNew.BCat05.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat05.Font = Etiqueta.Font
    '            FCajaNew.BCat05.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat05.Visible = True
    '        Case 6
    '            FCajaNew.Cat06.BackColor = Panel.BackColor
    '            FCajaNew.Cat06.Tag = Panel.Tag
    '            FCajaNew.BCat06.Tag = Etiqueta.Tag
    '            FCajaNew.BCat06.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat06.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat06.Text = Etiqueta.Text
    '            FCajaNew.BCat06.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat06.Font = Etiqueta.Font
    '            FCajaNew.BCat06.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat06.Visible = True
    '        Case 7
    '            FCajaNew.Cat07.BackColor = Panel.BackColor
    '            FCajaNew.Cat07.Tag = Panel.Tag
    '            FCajaNew.BCat07.Tag = Etiqueta.Tag
    '            FCajaNew.BCat07.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat07.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat07.Text = Etiqueta.Text
    '            FCajaNew.BCat07.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat07.Font = Etiqueta.Font
    '            FCajaNew.BCat07.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat07.Visible = True
    '        Case 8
    '            FCajaNew.Cat08.BackColor = Panel.BackColor
    '            FCajaNew.Cat08.Tag = Panel.Tag
    '            FCajaNew.BCat08.Tag = Etiqueta.Tag
    '            FCajaNew.BCat08.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat08.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat08.Text = Etiqueta.Text
    '            FCajaNew.BCat08.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat08.Font = Etiqueta.Font
    '            FCajaNew.BCat08.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat08.Visible = True
    '        Case 9
    '            FCajaNew.Cat09.BackColor = Panel.BackColor
    '            FCajaNew.Cat09.Tag = Panel.Tag
    '            FCajaNew.BCat09.Tag = Etiqueta.Tag
    '            FCajaNew.BCat09.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat09.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat09.Text = Etiqueta.Text
    '            FCajaNew.BCat09.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat09.Font = Etiqueta.Font
    '            FCajaNew.BCat09.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat09.Visible = True
    '        Case 10
    '            FCajaNew.Cat10.BackColor = Panel.BackColor
    '            FCajaNew.Cat10.Tag = Panel.Tag
    '            FCajaNew.BCat10.Tag = Etiqueta.Tag
    '            FCajaNew.BCat10.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat10.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat10.Text = Etiqueta.Text
    '            FCajaNew.BCat10.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat10.Font = Etiqueta.Font
    '            FCajaNew.BCat10.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat10.Visible = True
    '        Case 11
    '            FCajaNew.Cat11.BackColor = Panel.BackColor
    '            FCajaNew.Cat11.Tag = Panel.Tag
    '            FCajaNew.BCat11.Tag = Etiqueta.Tag
    '            FCajaNew.BCat11.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat11.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat11.Text = Etiqueta.Text
    '            FCajaNew.BCat11.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat11.Font = Etiqueta.Font
    '            FCajaNew.BCat11.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat11.Visible = True
    '        Case 12
    '            FCajaNew.Cat12.BackColor = Panel.BackColor
    '            FCajaNew.Cat12.Tag = Panel.Tag
    '            FCajaNew.BCat12.Tag = Etiqueta.Tag
    '            FCajaNew.BCat12.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat12.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat12.Text = Etiqueta.Text
    '            FCajaNew.BCat12.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat12.Font = Etiqueta.Font
    '            FCajaNew.BCat12.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat12.Visible = True
    '        Case 13
    '            FCajaNew.Cat13.BackColor = Panel.BackColor
    '            FCajaNew.Cat13.Tag = Panel.Tag
    '            FCajaNew.BCat13.Tag = Etiqueta.Tag
    '            FCajaNew.BCat13.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat13.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat13.Text = Etiqueta.Text
    '            FCajaNew.BCat13.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat13.Font = Etiqueta.Font
    '            FCajaNew.BCat13.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat13.Visible = True
    '        Case 14
    '            FCajaNew.Cat14.BackColor = Panel.BackColor
    '            FCajaNew.Cat14.Tag = Panel.Tag
    '            FCajaNew.BCat14.Tag = Etiqueta.Tag
    '            FCajaNew.BCat14.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat14.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat14.Text = Etiqueta.Text
    '            FCajaNew.BCat14.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat14.Font = Etiqueta.Font
    '            FCajaNew.BCat14.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat14.Visible = True
    '        Case 15
    '            FCajaNew.Cat15.BackColor = Panel.BackColor
    '            FCajaNew.Cat15.Tag = Panel.Tag
    '            FCajaNew.BCat15.Tag = Etiqueta.Tag
    '            FCajaNew.BCat15.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat15.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat15.Text = Etiqueta.Text
    '            FCajaNew.BCat15.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat15.Font = Etiqueta.Font
    '            FCajaNew.BCat15.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat15.Visible = True
    '        Case 16
    '            FCajaNew.Cat16.BackColor = Panel.BackColor
    '            FCajaNew.Cat16.Tag = Panel.Tag
    '            FCajaNew.BCat16.Tag = Etiqueta.Tag
    '            FCajaNew.BCat16.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat16.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat16.Text = Etiqueta.Text
    '            FCajaNew.BCat16.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat16.Font = Etiqueta.Font
    '            FCajaNew.BCat16.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat16.Visible = True
    '        Case 17
    '            FCajaNew.Cat17.BackColor = Panel.BackColor
    '            FCajaNew.Cat17.Tag = Panel.Tag
    '            FCajaNew.BCat17.Tag = Etiqueta.Tag
    '            FCajaNew.BCat17.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat17.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat17.Text = Etiqueta.Text
    '            FCajaNew.BCat17.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat17.Font = Etiqueta.Font
    '            FCajaNew.BCat17.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat17.Visible = True
    '        Case 18
    '            FCajaNew.Cat18.BackColor = Panel.BackColor
    '            FCajaNew.Cat18.Tag = Panel.Tag
    '            FCajaNew.BCat18.Tag = Etiqueta.Tag
    '            FCajaNew.BCat18.ForeColor = Etiqueta.ForeColor
    '            FCajaNew.BCat18.BackgroundImage = Etiqueta.BackgroundImage
    '            FCajaNew.BCat18.Text = Etiqueta.Text
    '            FCajaNew.BCat18.BackColor = Etiqueta.BackColor
    '            FCajaNew.BCat18.Font = Etiqueta.Font
    '            FCajaNew.BCat18.TextAlign = ContentAlignment.MiddleCenter
    '            FCajaNew.Cat18.Visible = True
    '    End Select
    'End Sub
    'Public Sub MostrarCategoria(Activo As Integer, Panel As TableLayoutPanel, Etiqueta As Button)
    '    Select Case Activo
    '        Case 1
    '            FFerias.Cat01.BackColor = Panel.BackColor
    '            FFerias.Cat01.Tag = Panel.Tag
    '            FFerias.BCat01.Tag = Etiqueta.Tag
    '            FFerias.BCat01.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat01.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat01.Text = Etiqueta.Text
    '            FFerias.BCat01.BackColor = Etiqueta.BackColor
    '            FFerias.BCat01.Font = Etiqueta.Font
    '            FFerias.BCat01.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat01.Visible = True
    '        Case 2
    '            FFerias.Cat02.BackColor = Panel.BackColor
    '            FFerias.Cat02.Tag = Panel.Tag
    '            FFerias.BCat02.Tag = Etiqueta.Tag
    '            FFerias.BCat02.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat02.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat02.Text = Etiqueta.Text
    '            FFerias.BCat02.BackColor = Etiqueta.BackColor
    '            FFerias.BCat02.Font = Etiqueta.Font
    '            FFerias.BCat02.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat02.Visible = True
    '        Case 3
    '            FFerias.Cat03.BackColor = Panel.BackColor
    '            FFerias.Cat03.Tag = Panel.Tag
    '            FFerias.BCat03.Tag = Etiqueta.Tag
    '            FFerias.BCat03.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat03.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat03.Text = Etiqueta.Text
    '            FFerias.BCat03.BackColor = Etiqueta.BackColor
    '            FFerias.BCat03.Font = Etiqueta.Font
    '            FFerias.BCat03.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat03.Visible = True
    '        Case 4
    '            FFerias.Cat04.BackColor = Panel.BackColor
    '            FFerias.Cat04.Tag = Panel.Tag
    '            FFerias.BCat04.Tag = Etiqueta.Tag
    '            FFerias.BCat04.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat04.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat04.Text = Etiqueta.Text
    '            FFerias.BCat04.BackColor = Etiqueta.BackColor
    '            FFerias.BCat04.Font = Etiqueta.Font
    '            FFerias.BCat04.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat04.Visible = True
    '        Case 5
    '            FFerias.Cat05.BackColor = Panel.BackColor
    '            FFerias.Cat05.Tag = Panel.Tag
    '            FFerias.BCat05.Tag = Etiqueta.Tag
    '            FFerias.BCat05.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat05.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat05.Text = Etiqueta.Text
    '            FFerias.BCat05.BackColor = Etiqueta.BackColor
    '            FFerias.BCat05.Font = Etiqueta.Font
    '            FFerias.BCat05.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat05.Visible = True
    '        Case 6
    '            FFerias.Cat06.BackColor = Panel.BackColor
    '            FFerias.Cat06.Tag = Panel.Tag
    '            FFerias.BCat06.Tag = Etiqueta.Tag
    '            FFerias.BCat06.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat06.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat06.Text = Etiqueta.Text
    '            FFerias.BCat06.BackColor = Etiqueta.BackColor
    '            FFerias.BCat06.Font = Etiqueta.Font
    '            FFerias.BCat06.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat06.Visible = True
    '        Case 7
    '            FFerias.Cat07.BackColor = Panel.BackColor
    '            FFerias.Cat07.Tag = Panel.Tag
    '            FFerias.BCat07.Tag = Etiqueta.Tag
    '            FFerias.BCat07.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat07.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat07.Text = Etiqueta.Text
    '            FFerias.BCat07.BackColor = Etiqueta.BackColor
    '            FFerias.BCat07.Font = Etiqueta.Font
    '            FFerias.BCat07.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat07.Visible = True
    '        Case 8
    '            FFerias.Cat08.BackColor = Panel.BackColor
    '            FFerias.Cat08.Tag = Panel.Tag
    '            FFerias.BCat08.Tag = Etiqueta.Tag
    '            FFerias.BCat08.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat08.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat08.Text = Etiqueta.Text
    '            FFerias.BCat08.BackColor = Etiqueta.BackColor
    '            FFerias.BCat08.Font = Etiqueta.Font
    '            FFerias.BCat08.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat08.Visible = True
    '        Case 9
    '            FFerias.Cat09.BackColor = Panel.BackColor
    '            FFerias.Cat09.Tag = Panel.Tag
    '            FFerias.BCat09.Tag = Etiqueta.Tag
    '            FFerias.BCat09.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat09.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat09.Text = Etiqueta.Text
    '            FFerias.BCat09.BackColor = Etiqueta.BackColor
    '            FFerias.BCat09.Font = Etiqueta.Font
    '            FFerias.BCat09.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat09.Visible = True
    '        Case 10
    '            FFerias.Cat10.BackColor = Panel.BackColor
    '            FFerias.Cat10.Tag = Panel.Tag
    '            FFerias.BCat10.Tag = Etiqueta.Tag
    '            FFerias.BCat10.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat10.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat10.Text = Etiqueta.Text
    '            FFerias.BCat10.BackColor = Etiqueta.BackColor
    '            FFerias.BCat10.Font = Etiqueta.Font
    '            FFerias.BCat10.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat10.Visible = True
    '        Case 11
    '            FFerias.Cat11.BackColor = Panel.BackColor
    '            FFerias.Cat11.Tag = Panel.Tag
    '            FFerias.BCat11.Tag = Etiqueta.Tag
    '            FFerias.BCat11.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat11.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat11.Text = Etiqueta.Text
    '            FFerias.BCat11.BackColor = Etiqueta.BackColor
    '            FFerias.BCat11.Font = Etiqueta.Font
    '            FFerias.BCat11.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat11.Visible = True
    '        Case 12
    '            FFerias.Cat12.BackColor = Panel.BackColor
    '            FFerias.Cat12.Tag = Panel.Tag
    '            FFerias.BCat12.Tag = Etiqueta.Tag
    '            FFerias.BCat12.ForeColor = Etiqueta.ForeColor
    '            FFerias.BCat12.BackgroundImage = Etiqueta.BackgroundImage
    '            FFerias.BCat12.Text = Etiqueta.Text
    '            FFerias.BCat12.BackColor = Etiqueta.BackColor
    '            FFerias.BCat12.Font = Etiqueta.Font
    '            FFerias.BCat12.TextAlign = ContentAlignment.MiddleCenter
    '            FFerias.Cat12.Visible = True
    '    End Select
    'End Sub
    Public Sub MostrarArticuloCaja(ByVal ofrm As Control, Imagen As PictureBox, Etiqueta As Label)
        For Each oControl As Control In ofrm.Controls
            Dim Act As Integer = Int(Mid(oControl.Name, (Len(oControl.Name) - 2) + 1, Len(oControl.Name)))
            If (Act = CantArtActivo) Then
                If TypeOf oControl Is PictureBox Then
                    oControl.BackgroundImage = Imagen.BackgroundImage
                    oControl.Tag = Imagen.Tag
                    oControl.Visible = True
                End If
                If TypeOf oControl Is Label Then
                    oControl.BackColor = Etiqueta.BackColor
                    oControl.ForeColor = Etiqueta.ForeColor
                    oControl.Font = Etiqueta.Font
                    oControl.Text = Etiqueta.Text
                    oControl.Tag = Etiqueta.Tag
                    oControl.Visible = True
                End If
            End If
        Next
    End Sub

    Public Sub MostrarArticulo(ByVal ofrm As Control, Imagen As PictureBox, Etiqueta As Label, Stock As String)
        For Each oControl As Control In ofrm.Controls
            Dim Act As Integer = Int(Mid(oControl.Name, (Len(oControl.Name) - 2) + 1, Len(oControl.Name)))
            If (Act = CantArtActivo) Then
                If TypeOf oControl Is PictureBox Then
                    oControl.BackgroundImage = Imagen.BackgroundImage
                    oControl.Tag = Imagen.Tag
                    oControl.Visible = True
                End If
                If TypeOf oControl Is Label Then
                    If (Mid(oControl.Name, 1, 6) <> "LStock") Then
                        oControl.BackColor = Etiqueta.BackColor
                        oControl.ForeColor = Etiqueta.ForeColor
                        oControl.Font = Etiqueta.Font
                        oControl.Text = Etiqueta.Text
                        oControl.Tag = Etiqueta.Tag
                        oControl.Visible = True
                    Else
                        oControl.Text = Stock
                        oControl.Visible = True
                    End If

                End If
            End If
        Next
    End Sub

    Public Sub DesactivarArticulo(ByVal ofrm As Control, Activado As Boolean)
        ofrm.Visible = False
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is PictureBox Or TypeOf oControl Is Label Then
                oControl.Visible = Activado
            End If
        Next
        ofrm.Visible = True
    End Sub

    Public Sub ValidarPuntoSeparacion(ByVal Texto As Object, ByVal Decimales As Boolean)
        Dim CadDec As String = ""
        Dim CadEntera As String = ""
        If (Texto.Text <> String.Empty) Then
            Dim importe As Decimal
            Decimal.TryParse(Texto.Text, importe)
            If (Decimales) Then
                If (Texto.Text.IndexOf(",") <> -1) Then
                    CadDec = Mid(Texto.Text, Texto.Text.IndexOf(",") + 1)
                    CadEntera = Mid(Texto.text, 1, Texto.Text.IndexOf(","))
                    Texto.Text = String.Format("{0:N0}", CadEntera)
                    Texto.text = Texto.text & CadDec
                Else
                    Texto.Text = String.Format("{0:N0}", importe)
                End If
            Else
                Texto.Text = String.Format("{0:N0}", importe)
            End If
            Texto.SelectionStart = Texto.TextLength
        End If
    End Sub
    Public Function txtNumerico(ByVal txtControl As Object, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "," Then
            If caracter = "," Then
                If (decimales = True) Then
                    If txtControl.Text.IndexOf(",") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Public Function txtNumericoNegativoPositivo(ByVal txtControl As Object, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "," Or caracter = "-" Or caracter = "+" Then
            If caracter = "," Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(",") <> -1 Then Return True
                Else : Return True
                End If
            End If
            If caracter = "-" Then
                If (txtControl.Text.IndexOf("-") <> -1) Or (txtControl.Text.IndexOf("+") <> -1) Then
                    Return True
                Else
                    Return False
                End If
            End If
            If caracter = "+" Then
                If (txtControl.Text.IndexOf("-") <> -1) Or (txtControl.Text.IndexOf("+") <> -1) Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function
    Public Function txtNumericoNegativo(ByVal txtControl As Object, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "," Or caracter = "-" Then
            If caracter = "," Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(",") <> -1 Then Return True
                Else : Return True
                End If
            End If
            If caracter = "-" Then
                If txtControl.Text.IndexOf("-") <> -1 Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Public Function txtNumericoPositivo(ByVal txtControl As Object, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "," Or caracter = "+" Then
            If caracter = "," Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(",") <> -1 Then Return True
                Else : Return True
                End If
            End If
            If caracter = "+" Then
                If txtControl.Text.IndexOf("+") <> -1 Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function
    Public Function txtNumericoCombo(ByVal txtControl As ComboBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "," Then
            If caracter = "," Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(",") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Public Function RellenarCeros(Cad As String, Max As Integer)
        Dim Cadena As String
        If (Len(Cad) < Max) Then
            Cadena = Cad.PadLeft(Max - Len(Cad), "0")
        Else
            Cadena = Cad
        End If
        Return (Cadena)
    End Function
    Function CalcularIVA(Valor As Decimal, iva As Integer) As Decimal
        Return (Format((Valor * iva) / 100, "##,##0.00"))
    End Function
    Public Function SumarColumna(Grid As DataGridView, Columna As Int16) As Decimal
        Dim Total As Decimal = 0
        If Grid.RowCount >= 1 Then
            For Each row As DataGridViewRow In Grid.Rows
                If (row.Cells(Columna).Value.ToString <> "") Then
                    Total += Convert.ToDecimal(row.Cells(Columna).Value)
                End If
            Next
        Else
            Total = 0
        End If
        Return (Total)
    End Function
    Public Function SumarColumnaEscalado(Grid As DataGridView, Columna As Int16) As Decimal
        Dim Total As Decimal = 0
        If Grid.RowCount >= 1 Then
            For Each row As DataGridViewRow In Grid.Rows
                If (row.Cells("Ingrediente").Value.ToString <> "") Then
                    If (row.Cells(Columna).Value.ToString <> "") Then
                        Total += Convert.ToDecimal(row.Cells(Columna).Value)
                    End If
                End If
            Next
        Else
            Total = "0"
        End If
        Return (Total)
    End Function

    Public Function CalcularCostoX(ByVal Costo As Decimal, ByVal Unidad As String, ByVal UnidadIng As String, ByVal CantIng As Decimal, Categoria As String) As Decimal
        Dim CostoIng As Decimal = 0
        If (Categoria = "Preparados") Then
            CantIng = PesoEquivalente1(CantIng, UnidadIng, Unidad)
            If (CantIng > 1) Then
                CostoIng = CantIng * (Costo / CantIng)
            Else
                CostoIng = Costo * CantIng
            End If
        Else
            If (CantIng > 1) Then
                CostoIng = CantIng * (Costo / CantIng)
            Else
                CostoIng = Costo * CantIng
            End If
        End If
        Return (CostoIng)
    End Function
    Public Function CalcularPrecio(Codigo As Integer, Peso As Decimal, Categoria As String, TipoPrecio As Integer, UnidadProd As String) As Decimal
        Dim Costo As Decimal = 0
        Dim Utilidad As Decimal = 0
        Dim Precio As Decimal = 0
        CalcularDolar(FechaDia, 1)
        If Conectar() Then
            Dim Comando As New SqlCommand("Select Costo2, Costo2D, Precio1, Precio2, Precio3, Precio4, PrecioEfectivo,PrecioM, PrecioD1, PrecioD2, PrecioD3, PrecioD4, PrecioEfectivoD,PrecioDM,IVAV,BaseDolar FROM VNewProducto WHERE idProducto=" & Codigo, CNN)
            Dim DatosProd As SqlDataReader = Comando.ExecuteReader()
            If (DatosProd.Read()) Then
                Select Case TipoPrecio
                    Case 9
                        Precio = DatosProd("PrecioEfectivo")
                        PrecioD = DatosProd("PrecioEfectivoD")
                    Case 1
                        Precio = DatosProd("Precio1")
                        PrecioD = DatosProd("PrecioD1")
                    Case 2
                        Precio = DatosProd("Precio2")
                        PrecioD = DatosProd("PrecioD2")

                    Case 3
                        Precio = DatosProd("Precio3")
                        PrecioD = DatosProd("PrecioD3")
                    Case 4
                        Precio = Format((DatosProd("Costo2") + (DatosProd("Costo2") * (PPrecio4 / 100))), "##,##0.00")
                        PrecioD = Format((DatosProd("Costo2D") + (DatosProd("Costo2D") * (PPrecio4 / 100))), "##,##0.00")
                    Case 5
                        Precio = DatosProd("Costo2")
                        PrecioD = DatosProd("Costo2D")
                    Case 6
                        Precio = (DatosProd("Costo2") / 2)
                        PrecioD = (DatosProd("Costo2D") / 2)
                    Case 7, 8
                        Precio = 0
                        PrecioD = 0
                    Case 10
                        Precio = DatosProd("PrecioM")
                        PrecioD = DatosProd("PrecioDM")
                    Case 11
                        Precio = Format(CostoProd + (CostoProd * (PEmp1 / 100)), "##,##0.0000")
                        PrecioD = Format(CostoDProd + (CostoDProd * (PEmp1 / 100)), "##,##0.0000")
                    Case 12
                        Precio = Format(DatosProd("Precio1") - (DatosProd("Precio1") * (PEmp3 / 100)), "##,##0.0000")
                        PrecioD = Format(DatosProd("PrecioD1") - (DatosProd("PrecioD1") * (PEmp3 / 100)), "##,##0.0000")
                    Case 13
                        Precio = Format(DatosProd("Precio1") - (DatosProd("Precio1") * (PEmp2 / 100)), "##,##0.0000")
                        PrecioD = Format(DatosProd("PrecioD1") - (DatosProd("PrecioD1") * (PEmp2 / 100)), "##,##0.0000")
                End Select
            End If
            VIVAV = DatosProd("IVAV")

            If (DatosProd("BaseDolar")) Then
                FBalanza.MonedaBase.Image = FBalanza.ImagenD.Image
                Precio = PrecioD * BsXDolarBC
                FBalanza.TPrecioD.Font = New System.Drawing.Font(FBalanza.TPrecioD.Font, FontStyle.Bold)
                FBalanza.TSubTotalD.Font = New System.Drawing.Font(FBalanza.TSubTotalD.Font, FontStyle.Bold)
                FBalanza.TIVAD.Font = New System.Drawing.Font(FBalanza.TIVAD.Font, FontStyle.Bold)

                FBalanza.TPrecio.Font = New System.Drawing.Font(FBalanza.TPrecio.Font, FontStyle.Regular)
                FBalanza.TSubTotal.Font = New System.Drawing.Font(FBalanza.TSubTotal.Font, FontStyle.Regular)
                FBalanza.TIVA.Font = New System.Drawing.Font(FBalanza.TIVA.Font, FontStyle.Regular)
            Else
                FBalanza.MonedaBase.Image = FBalanza.ImagenBs.Image
                PrecioD = Precio / BsXDolarBC
                FBalanza.TPrecioD.Font = New System.Drawing.Font(FBalanza.TPrecioD.Font, FontStyle.Regular)
                FBalanza.TSubTotalD.Font = New System.Drawing.Font(FBalanza.TSubTotalD.Font, FontStyle.Regular)
                FBalanza.TIVAD.Font = New System.Drawing.Font(FBalanza.TIVAD.Font, FontStyle.Regular)

                FBalanza.TPrecio.Font = New System.Drawing.Font(FBalanza.TPrecio.Font, FontStyle.Bold)
                FBalanza.TSubTotal.Font = New System.Drawing.Font(FBalanza.TSubTotal.Font, FontStyle.Bold)
                FBalanza.TIVA.Font = New System.Drawing.Font(FBalanza.TIVA.Font, FontStyle.Bold)

            End If
            DatosProd.Close()
        End If
        Desconectar()
        Return (Precio)
    End Function


    Public Function DatosCompletos(Grid As DataGridView, Fila As Integer) As Boolean
        Dim Completo As Boolean = True
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells(Fila).Value.ToString = "") Then
                Completo = False
            End If
        Next
        Return (Completo)
    End Function
    Public Function DatosCompletosDestino(Grid As DataGridView, Fila As Integer) As Boolean
        Dim Completo As Boolean = True
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells(Fila).Value.ToString = "") And (Grid.Rows(i).Cells(6).Value = "Efectivo" Or Grid.Rows(i).Cells(6).Value = "Tarjeta") Then
                Completo = False
            End If
        Next
        Return (Completo)
    End Function
    Public Function DatosCompletosBancos(Grid As DataGridView, Fila As Integer) As Boolean
        Dim Completo As Boolean = True
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells(Fila).Value.ToString = "") And (Grid.Rows(i).Cells(6).Value = "Transferencia" Or Grid.Rows(i).Cells(6).Value = "Tarjeta" Or Grid.Rows(i).Cells(6).Value = "Pago Móvil") Then
                Completo = False
            End If
        Next
        Return (Completo)
    End Function
    Public Function DatosCompletosMayorCero(Grid As DataGridView, Fila As Integer) As Boolean
        Dim Completo As Boolean = True
        StockenCero = False
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells(Fila).Value.ToString = "") Then
                Completo = False
                Exit For
            Else
                If (Convert.ToDecimal(Grid.Rows(i).Cells(Fila).Value) = 0) Then
                    Completo = False
                    Exit For
                End If
            End If
        Next
        Return (Completo)
    End Function

    Public Function DatosCompletosMayorCeroStock(Grid As DataGridView, Fila As Integer, FilaStock As Integer) As Boolean
        Dim Completo As Boolean = True
        StockenCero = False
        MayorqueStock = False
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells(Fila).Value.ToString = "") Then
                Completo = False
                Exit For
            Else
                If (Convert.ToDecimal(Grid.Rows(i).Cells(Fila).Value) = 0) Then
                    Completo = False
                    Exit For
                End If
            End If
            If (Convert.ToDecimal(Grid.Rows(i).Cells(FilaStock).Value) < 1) Then
                Completo = False
                StockenCero = True
                Exit For
            End If

            If (Convert.ToDecimal(Grid.Rows(i).Cells(Fila).Value) > Convert.ToDecimal(Grid.Rows(i).Cells(FilaStock).Value)) Then
                Completo = False
                MayorqueStock = True
                Exit For
            End If

        Next
        Return (Completo)
    End Function
    Public Function DatosPreciosCompletosMayorCero(Grid As DataGridView, Fila As Integer) As Boolean
        Dim Completo As Boolean = True
        For i As Integer = 0 To Grid.Rows.Count - 1
            If (Grid.Rows(i).Cells("Venta").Value = True) Then
                If (Grid.Rows(i).Cells(Fila).Value.ToString = "") Then
                    Completo = False
                    Exit For
                Else
                    If (Convert.ToDecimal(Grid.Rows(i).Cells(Fila).Value) = 0) Then
                        Completo = False
                        Exit For
                    End If
                End If
            End If
        Next
        Return (Completo)
    End Function
    Public Function CalcularPesoReal(Codigo As Integer, UnidadVender As String, Peso As Decimal) As Decimal
        Dim CantVender As Decimal = 0
        Dim IngCompleto As Boolean = False
        Select Case CatActiva
            Case "Preparados"
                If Conectar2() Then
                    Dim Comando2 As New SqlCommand("Select Codigo, Ingrediente, Cantidad, Unidad FROM TIngredientes WHERE idProducto=" & Codigo, CNN2)
                    Dim DatosIng As SqlDataReader = Comando2.ExecuteReader()
                    Do While DatosIng.Read()
                        If Conectar() Then
                            Dim Comando As New SqlCommand("Select Stock, Unidad FROM TNewProducto WHERE idProducto=" & DatosIng(0), CNN)
                            Dim DatosProd As SqlDataReader = Comando.ExecuteReader()
                            Do While DatosProd.Read()
                                If (UnidadVender = DatosProd(1)) Then
                                    If (DatosIng(3) = DatosProd(1)) Then
                                        CantVender = Peso * DatosIng(2)
                                    Else
                                        CantVender = Peso * PesoEquivalente1(DatosIng(2), DatosIng(3), UnidadVender)
                                    End If
                                Else
                                    If (DatosIng(3) = DatosProd(1)) Then
                                        CantVender = PesoEquivalente1(Peso, UnidadVender, DatosProd(1))
                                    Else
                                        CantVender = Peso * PesoEquivalente1(DatosIng(2), DatosIng(3), DatosProd(1))
                                    End If
                                End If
                                Dim Stock As Decimal = Convert.ToDecimal(DatosProd(0))
                                Dim CantIng As Decimal = Convert.ToDecimal(DatosIng(2))
                                If (Convert.ToDecimal(DatosProd(0) < CantVender)) Then
                                    IngCompleto = True
                                End If
                            Loop
                            DatosProd.Close()
                        End If
                        Desconectar()
                    Loop
                    If (IngCompleto = True) Then
                        CantVender = Peso
                    Else
                        CantVender = 0
                    End If
                    DatosIng.Close()
                    Desconectar2()
                End If
            Case Else
                If Conectar() Then
                    Try
                        Dim Comando As New SqlCommand("SELECT Stock, Unidad FROM VNewProducto WHERE idProducto=" & Codigo, CNN)
                        Dim DatosProd As SqlDataReader = Comando.ExecuteReader()
                        If (DatosProd.Read() = True) Then
                            If (DatosProd(0) Is DBNull.Value) Then
                                CantVender = 0
                            Else
                                CantVender = PesoEquivalente1(Peso, UnidadVender, DatosProd(1))
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error de Datos al Calcular Cantidad Disponible. " & ControlChars.CrLf & ex.Message)
                        Desconectar()
                    End Try
                End If
                Desconectar()
        End Select
        Return CantVender
    End Function
    Public Sub GuardarDetalleVentaPA(Codigo As Integer, Nombre As String, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, Categoria As String, PesoReal As Decimal, Descontar As Boolean, Relacion As Integer)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TDetReserva(idProducto,Producto,Cantidad,Unidad,TipoPrecio,Precio,Total,Categoria,PesoReal, Relacion) VALUES(@idProducto,@Producto,@Cantidad,@Unidad, @TipoPrecio,@Precio,@Total,@Categoria,@PesoReal,@Relacion)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProducto", Codigo))
                Comando.Parameters.Add(New SqlParameter("@Producto", Nombre))
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@Categoria", Categoria))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
                Comando.Parameters.Add(New SqlParameter("@Relacion", Relacion))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Comando.CommandText = "SELECT TOP 1 idDetReserva FROM TDetReserva ORDER BY idDetReserva DESC"
                DR = Comando.ExecuteReader()
                If (DR.Read) Then
                    CodDetalleReserva = DR(0)
                Else
                    CodDetalleReserva = 0
                End If
                DR.Close()
                If (Descontar = True) Then ' Si no es Excepcion descuento del stock
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
                    Dim Desc As Decimal = 0
                    If (FactorFileteado > 0) Then
                        Desc = (FactorFileteado * PesoReal) + PesoReal
                    Else
                        Desc = PesoReal
                    End If
                    Comando.Parameters.Add(New SqlParameter("@Stock", Desc))
                    DR = Comando.ExecuteReader()
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Detalle de la Reserva.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Public Sub ActualizarDetalleVentaPA(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, PesoReal As Decimal, Descontar As Boolean, CodDet As Integer, Relacion As Integer)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TDetReserva SET Cantidad=@Cantidad,Unidad=@Unidad,TipoPrecio=@TipoPrecio,Precio=@Precio,Total=@Total,PesoReal=@PesoReal,Relacion=@Relacion WHERE idDetReserva=" & CodDet, CNN)
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
                Comando.Parameters.Add(New SqlParameter("@Relacion", Relacion))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                If (Descontar = True) Then
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
                    Dim Desc As Decimal = 0
                    If (FactorFileteado > 0) Then
                        Desc = (FactorFileteado * PesoReal) + PesoReal
                    Else
                        Desc = PesoReal
                    End If
                    Comando.Parameters.Add(New SqlParameter("@Stock", Desc))
                    DR = Comando.ExecuteReader()
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Actualizar los Datos del Detalle de la Reserva.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Public Function ValidarTelefono(Cad As String) As String
        If (Len(Cad) = 4) Then
            Cad = Cad + "-"
        End If
        If (Len(Cad) = 8) Or (Len(Cad) = 11) Then
            Cad = Cad + "."
        End If
        Return Cad
    End Function

    Public Function ValidarCI(Cad As String) As String
        If (Len(Cad) = 2) Or (Len(Cad) = 6) Then
            Cad = Cad + "."
        End If
        Return Cad
    End Function
    Public Function ColocarPuntosCI(Cad As String) As String
        Dim Cadena As String = ""
        If (Cad <> "") Then
            Select Case Len(Cad)
                Case 7
                    Cadena = Mid(Cad, 1, 1) & "." & Mid(Cad, 2, 3) & "." & Mid(Cad, 5, 3)
                Case 8
                    Cadena = Mid(Cad, 1, 2) & "." & Mid(Cad, 3, 3) & "." & Mid(Cad, 6, 3)
            End Select
        End If
        Return Cadena
    End Function
    Public Sub LimpiarTexboxVarios(ofrm As Form)
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is TextBox Then
                Select Case oControl.Tag
                    Case 1
                        oControl.Text = "0,00"
                    Case 2
                        oControl.Text = "0,00"
                    Case 3
                        oControl.Text = ""
                End Select
            End If
        Next
    End Sub
    Public Sub LimpiarTexbox(ofrm As Form)
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is TextBox Then
                oControl.Text = "0,00"
            End If
        Next
    End Sub
    Public Sub LimpiarTexboxVacio(ofrm As Form)
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is TextBox Then
                oControl.Text = ""
            End If
        Next
    End Sub

    ' Inicializa las Variables que necesitan valores al iniciar el sistema..................................
    Public Sub LlenarVariables()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT * FROM TGeneral", CNN)
                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                If (DataReader.Read()) Then
                    'VarXBs = DataReader("XBs")
                    'Rojo = DataReader("Rojo")
                    'Naranja1 = DataReader("Naranja1")
                    'Naranja2 = DataReader("Naranja2")
                    'Amarillo1 = DataReader("Amarillo1")
                    'Amarillo2 = DataReader("Amarillo2")
                    'Verde1 = DataReader("Verde1")
                    'Verde2 = DataReader("Verde2")
                    'Morado = DataReader("Morado")
                    PPrecio1 = DataReader("PPrecio1")
                    PPrecio2 = DataReader("PPrecio2")
                    PPrecio3 = DataReader("PPrecio3")
                    PPrecio4 = DataReader("PPrecio4")
                    PPrecio5 = DataReader("PPrecio5")
                    PPrecioE = DataReader("PPrecioE")
                    PPrecioM = DataReader("PPrecioMayor")
                    Direccion = DataReader("DireccionPDF")
                    PEmp1 = DataReader("PEmp1")
                    PEmp2 = DataReader("PEmp2")
                    PEmp3 = DataReader("PEmp3")
                    CantMesas = DataReader("CantMesas")
                    CantBarras = DataReader("CantBarras")

                    'BsFlete = DataReader("BsFlete")
                    ' PorcPrecio4 = DataReader("PorcPrecio4")
                    'idEspRef = DataReader("idEspecieSalado")
                    'CostoRef = DataReader("CostoRef")
                    'RecargoRef = DataReader("PorcRef")
                    'ComisionBanco = DataReader("ComisionBanco")
                    'DiaCredAlMayor = DataReader("DiaCredAlMayor")
                End If
                DataReader.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Cargar Datos de Variables " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Function MonedaPredeterminada() As String
        Dim Valor As String = ""
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT Simbolo FROM TMonedas WHERE Pred=1", CNN)
                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                If (DataReader.Read()) Then
                    Valor = DataReader("Simbolo")
                End If
                DataReader.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Cargar Moneda Predeterminada. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return Valor
    End Function

    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function HayExceso(idCat As Integer, idSubCat As Integer, TRestaSC As String, TCosto As String) As Boolean
        Dim Valor As Boolean = False
        If (TCosto <> "") Then
            If (Convert.ToDecimal(TRestaSC) < 0) Then
                MontoExceso = TCosto
                Valor = True
            Else
                If (TCosto <> "") Then
                    MontoExceso = Convert.ToDecimal(TRestaSC) - Convert.ToDecimal(TCosto)
                    If (MontoExceso < 0) Then
                        MontoExceso = MontoExceso * -1
                        Valor = True
                    Else
                        Valor = False
                        MontoExceso = 0
                    End If
                Else
                    Valor = False
                    MontoExceso = 0
                End If
            End If
        Else
            Valor = False
            MontoExceso = 0
        End If
        If (Conectar()) Then
            Dim Comando As New SqlCommand("SELECT GG FROM TCategoriaGastos WHERE id =@idCategoria", CNN)
            Comando.Parameters.Add(New SqlParameter("@idCategoria", idCat))
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            Do While DR.Read()
                If (DR("GG") = True) Then
                Else
                    Valor = False
                    MontoExceso = 0
                End If
            Loop
            DR.Close()
        End If
        Desconectar()
        Select Case idCat
            Case 6 ' Personal
                Select Case idSubCat
                    Case 7 ' Sueldos
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 35, 20 ' InteresXEfectivo y PagosExtraOrdinarios
                Valor = False
                MontoExceso = 0
            Case 1 ' Fondo Anticipo
                Select Case idSubCat
                    Case 1 ' Fondo Anticipo
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 2 ' Efectivo Sobrante
                Select Case idSubCat
                    Case 2 ' Efectivo Sobrante
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 3 'Caja Chica 1
                Select Case idSubCat
                    Case 3 'Caja Chica 1
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 4 'Caja Chica 2
                Select Case idSubCat
                    Case 4 'Caja Chica 2
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 29 ' ComprasForaneas
                Select Case idSubCat
                    Case 97, 194 ' ComprasForaneas y Por Clasificar
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 38 'Socios
                Select Case idSubCat
                    Case 116 'RPG
                        Valor = False
                        MontoExceso = 0
                End Select
            Case 40 'Efectivo para Cajas
                Select Case idSubCat
                    Case 120, 121 ' PE1 y PE2
                        Valor = False
                        MontoExceso = 0
                End Select
        End Select
        Return (Valor)
    End Function
    Function CalcularDolarOficial(Fecha As Date, Total1 As String) As Decimal
        Dim Valor As Decimal = 0
        Dim Total As Decimal = 0
        If (Total1 = "") Then
            Total = 0
        Else
            Total = Convert.ToDecimal(Total1)
        End If
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select Tasa, Tasa2, Tasa3, TasaBC FROM VMonedas WHERE Simbolo='$'", CNN)
                Comando.Parameters.AddWithValue("@Fecha", Fecha)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If DR.Read() Then
                    BsXDolar = DR("Tasa")
                    BsXDolarOficial = DR("Tasa2")
                    BsXDolarBC = DR("TasaBC")
                    BsXDolarEfectivo = DR("Tasa3")
                    Valor = Total / BsXDolarOficial
                Else
                    BsXDolarOficial = 1
                    Valor = Total / BsXDolarOficial
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Calcular el Valor del Bolívar X Dolar. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return Valor
    End Function
    Function CalcularDolar(Fecha As Date, Total1 As String) As Decimal
        Dim Valor As Decimal = 0
        Dim Total As Decimal = 0
        If (Total1 = "") Then
            Total = 0
        Else
            Total = Convert.ToDecimal(Total1)
        End If
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select Tasa, Tasa2, Tasa3, TasaBC FROM VMonedas WHERE Simbolo='$'", CNN)
                Comando.Parameters.AddWithValue("@Fecha", Fecha)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If DR.Read() Then
                    BsXDolar = DR("Tasa")
                    BsXDolarOficial = DR("Tasa2")
                    BsXDolarBC = DR("TasaBC")
                    BsXDolarEfectivo = DR("Tasa3")
                    Valor = Total / BsXDolar
                Else
                    BsXDolar = 1
                    Valor = Total / BsXDolar
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Calcular el Valor del Bolívar X Dolar. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return Valor
    End Function

    Function CalcularDolarEfectivo(Fecha As Date, Total1 As String) As Decimal
        Dim Valor As Decimal = 0
        Dim Total As Decimal = 0
        If (Total1 = "") Then
            Total = 0
        Else
            Total = Convert.ToDecimal(Total1)
        End If
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select Tasa3 FROM VMonedas WHERE Simbolo='$'", CNN)
                Comando.Parameters.AddWithValue("@Fecha", Fecha)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If DR.Read() Then
                    BsXDolarEfectivo = DR("Tasa3")
                    Valor = Total / BsXDolarEfectivo
                Else
                    BsXDolarEfectivo = 1
                    Valor = Total / BsXDolarEfectivo
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Calcular el Valor del Bolívar X Dolar. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return Valor
    End Function

    Public Sub CalcularEfectivo(Fecha As Date, Total As String)
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select Monto FROM TEfectivo WHERE Fecha=@Fecha", CNN)
                Comando.Parameters.AddWithValue("@Fecha", Fecha)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If DR.Read() Then
                    If (Total <> "") Then
                        PorcEfect = DR("Monto")
                        MontoEfect = Convert.ToDecimal(Total) + (Convert.ToDecimal(Total) * DR("Monto")) / 100
                    Else
                        PorcEfect = 0
                        MontoEfect = 0
                    End If
                    DR.Close()
                Else
                    If (Total <> "") Then
                        DR.Close()
                        Comando.CommandText = "SELECT TOP (1) PERCENT Monto FROM TEfectivo WHERE (Fecha <@Fecha2) ORDER BY Fecha DESC"
                        Comando.Parameters.AddWithValue("@Fecha2", Fecha)
                        DR = Comando.ExecuteReader()
                        If DR.Read() Then
                            PorcEfect = DR("Monto")
                            MontoEfect = Convert.ToDecimal(Total) + (Convert.ToDecimal(Total) * DR("Monto")) / 100
                        Else
                            PorcEfect = 0
                            MontoEfect = 0
                        End If
                    Else
                        PorcEfect = 0
                        MontoEfect = 0
                    End If
                    DR.Close()
                End If
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Calcular el Valor del Porcentaje de Efectivo. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Function ColumnaVacia(Grid As DataGridView, Col As Integer) As Boolean
        Dim Valor As Boolean = False
        For i = 0 To Grid.RowCount - 1
            If (Grid.Item(Col, i).Value.ToString = "") Then
                Valor = True
                Exit For
            End If
        Next
        Return (Valor)
    End Function
    Function BuscarNombreEmpleado() As String
        Dim Cad As String = ""
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as Nombre FROM TEmpleado WHERE idEmpleado=" & CodEmpleado, CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If DR.Read() Then
                    Cad = DR("Nombre").ToString
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR de Datos de Empleados. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return (Cad)
    End Function
    Public Sub BuscarCajaEstacion()
        Dim Caja As String = "Sin Caja"
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("SELECT Nombre, id FROM TCajas WHERE Estacion=@Estacion", CNN)
                Comando.Parameters.Add(New SqlParameter("@Estacion", System.Environment.MachineName))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    CajaActiva = DR("Nombre")
                    CodCajaActiva = DR("id")
                Else
                    CajaActiva = "Sin Caja"
                    CodCajaActiva = 0
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error de Datos...  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Function CajaAbierta(CodCaja As Integer) As Boolean
        Dim Valor As Boolean = False
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("SELECT Estado FROM TCajas WHERE id=@idCaja", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCaja", CodCaja))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Valor = DR("Estado")
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error de Datos...  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
        Return (Valor)
    End Function
    'Function VFormat(Numero As Decimal, Tipo As String) As String
    '    Dim Valor As String = ""
    '    If (Tipo = "Moneda: $") Then
    '        Valor = Format(Numero, "##,##0.0000")
    '    Else
    '        Valor = Format(Numero, "##,##0.0000")
    '    End If
    '    Return (Valor)
    'End Function
    'Function Formato(Numero As Decimal) As String
    '    Return (Format(Numero, "##,##0.0000"))
    'End Function
    'Function Formato2Dig(Numero As Decimal) As String
    '    Return (Format(Numero, "##,##0.00"))
    'End Function
    Public Function PesoEquivalente1(Peso As Decimal, Unidad As String, UnidadReal As String) As Decimal
        Dim CantEquivalente As Decimal
        Select Case Unidad
            Case "Unidad", "Caja", UnidadReal
                CantEquivalente = Peso
            Case Else
                Select Case Unidad
                    Case "Kilogramos", "Litros"
                        If (UnidadReal = "Gramos") Or (UnidadReal = "Mililitros") Then
                            CantEquivalente = (Peso * 1000)
                        End If
                    Case "Gramos", "Mililitros"
                        If (UnidadReal = "Kilogramos") Or (UnidadReal = "Litros") Then
                            CantEquivalente = (Peso / 1000)
                        End If
                    Case Else
                        CantEquivalente = 0
                End Select
        End Select
        Return (CantEquivalente)
    End Function
    Public Function PesoEquivalente(CantidadIng As Decimal, UnidadIng As String, UnidadInic As String, Capacidad As Decimal, UnidadCapacidad As String, CostoIng As Decimal) As Decimal
        Dim CantEquivalente As Decimal = 0
        If (UnidadIng = UnidadCapacidad) Then
            If (UnidadInic = UnidadCapacidad) Then
                CantEquivalente = CantidadIng * Capacidad
            Else
                CantEquivalente = CantidadIng / Capacidad
            End If
        Else
            Select Case UnidadCapacidad
                Case "Kilogramos", "Litros"
                    If (UnidadIng = "Gramos") Or (UnidadIng = "Mililitros") Then
                        CantEquivalente = (CantidadIng / 1000)
                        If (UnidadInic = UnidadCapacidad) Then
                            CantEquivalente = CantEquivalente
                        Else
                            CantEquivalente = CantEquivalente / Capacidad
                        End If
                    End If
                Case "Gramos", "Mililitros"
                    If (UnidadIng = "Kilogramos") Or (UnidadIng = "Litros") Then
                        CantEquivalente = (CantidadIng * 1000)
                        If (UnidadInic = UnidadCapacidad) Then
                            CantEquivalente = CantEquivalente
                        Else
                            CantEquivalente = CantEquivalente * Capacidad
                        End If
                    End If
                Case Else
                    CantEquivalente = "0"
            End Select
        End If
        Return (CantEquivalente)
    End Function
    '''''aqui cambio'''''''''''''''
    'Public Function CalcularCostoCompuestoXX(UnidadProd As String, CantidadIng As Decimal, UnidadIng As String, Capacidad As Decimal, UnidadCapacidad As String, CostoIng As Decimal, UnidadAlt As String, FactorAlt As Decimal, TipoFactorAlt As String) As Decimal
    '    Dim TotalCosto As Decimal = 0
    '    Dim CantTotal As Decimal = 0
    '    Dim CantAux As Decimal = 0
    '    Dim NuevaUnidadAlterna As String = ""
    '    If (UnidadAlt = "_Ninguno") Then
    '        CantAux = ConversionBase(UnidadCapacidad, UnidadIng, CantidadIng, Capacidad, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadProd, UnidadCapacidad, CantAux, Capacidad, TipoFactorAlt)
    '    Else
    '        NuevaUnidadAlterna = TomarPalabra(TipoFactorAlt)
    '        CantAux = ConversionBase(NuevaUnidadAlterna, UnidadIng, CantidadIng, FactorAlt, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadCapacidad, NuevaUnidadAlterna, CantAux, FactorAlt, TipoFactorAlt)
    '    End If
    '    TotalCosto = CostoIng / CantTotal
    '    Return (TotalCosto)
    'End Function

    '''''aqui cambio'''''''''''''''
    'Public Function CalcularCostoCompuesto(UnidadProd As String, CantidadIng As Decimal, UnidadIng As String, Capacidad As Decimal, UnidadCapacidad As String, CostoIng As Decimal, UnidadAlt As String, FactorAlt As Decimal, TipoFactorAlt As String) As Decimal
    '    Dim TotalCosto As Decimal = 0
    '    Dim CantTotal As Decimal = 0
    '    Dim CantAux As Decimal = 0
    '    Dim NuevaUnidadAlterna As String = ""
    '    If (UnidadAlt = "_Ninguno") Then
    '        CantAux = ConversionBase(UnidadCapacidad, UnidadIng, CantidadIng, Capacidad, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadProd, UnidadCapacidad, CantAux, Capacidad, TipoFactorAlt)
    '    Else
    '        NuevaUnidadAlterna = TomarPalabra(TipoFactorAlt)
    '        CantAux = ConversionBase(NuevaUnidadAlterna, UnidadIng, CantidadIng, FactorAlt, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadCapacidad, NuevaUnidadAlterna, CantAux, FactorAlt, TipoFactorAlt)
    '    End If
    '    TotalCosto = CostoIng * CantTotal
    '    Return (TotalCosto)
    'End Function

    Public Function CalcularCantidadCompuestoFinal(CantidadIng As Decimal, idUnidadIng As Integer, Capacidad As Decimal, idUnidadCapacidad As Integer) As Decimal
        Dim CantTotal As Decimal = 0
        CantTotal = ConversionBaseFinal(CantidadIng, idUnidadCapacidad, Capacidad, idUnidadCapacidad)
        Return (CantTotal)
    End Function
    '''''aqui cambio'''''''''''''''

    Public Function CalcularCantidadCompuesto(UnidadProd As String, CantidadIng As Decimal, UnidadIng As String, Capacidad As Decimal, UnidadCapacidad As String, CostoIng As Decimal, UnidadAlt As String, FactorAlt As Decimal, TipoFactorAlt As String) As Decimal
        Dim CantTotal As Decimal = 0
        Dim CantAux As Decimal = 0
        Dim NuevaUnidadAlterna As String = ""
        If (UnidadAlt = "_Ninguno") Then
            CantAux = ConversionBase(UnidadCapacidad, UnidadIng, CantidadIng, Capacidad, TipoFactorAlt)
            CantTotal = ConversionBase(UnidadProd, UnidadCapacidad, CantAux, Capacidad, TipoFactorAlt)
        Else
            NuevaUnidadAlterna = TomarPalabra(TipoFactorAlt)
            CantAux = ConversionBase(NuevaUnidadAlterna, UnidadIng, CantidadIng, FactorAlt, TipoFactorAlt)
            CantTotal = ConversionBase(UnidadCapacidad, NuevaUnidadAlterna, CantAux, FactorAlt, TipoFactorAlt)
        End If
        Return (CantTotal)
    End Function

    '''''aqui cambio'''''''''''''''
    'Public Function CalcularCostoCompuestoCompra(UnidadProd As String, CantidadIng As Decimal, UnidadIng As String, Capacidad As Decimal, UnidadCapacidad As String, CostoIng As Decimal, UnidadAlt As String, FactorAlt As Decimal, TipoFactorAlt As String) As Decimal
    '    Dim TotalCosto As Decimal = 0
    '    Dim CantTotal As Decimal = 0
    '    Dim CantAux As Decimal = 0
    '    Dim NuevaUnidadAlterna As String = ""
    '    If (UnidadAlt = "_Ninguno") Then
    '        CantAux = ConversionBase(UnidadCapacidad, UnidadIng, CantidadIng, Capacidad, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadProd, UnidadCapacidad, CantAux, Capacidad, TipoFactorAlt)
    '    Else
    '        NuevaUnidadAlterna = TomarPalabra(TipoFactorAlt)
    '        CantAux = ConversionBase(NuevaUnidadAlterna, UnidadIng, CantidadIng, FactorAlt, TipoFactorAlt)
    '        CantTotal = ConversionBase(UnidadCapacidad, NuevaUnidadAlterna, CantAux, FactorAlt, TipoFactorAlt)
    '    End If
    '    TotalCosto = CostoIng * CantTotal
    '    Return (TotalCosto)
    'End Function
    Public Function TomarPalabra(Frase As String) As String
        Dim i As Integer = 0
        Dim caracter As String = ""
        Dim Palabra As String = ""
        If (Frase <> "") Then
            While caracter <> " "
                i = i + 1
                caracter = Mid(Frase, i, 1)
                Palabra = Palabra + caracter

            End While
            Palabra = Mid(Palabra, 1, Len(Palabra) - 1)
        End If
        Return (Palabra)

    End Function

    Function ConversionBaseFinal(CantIng As Decimal, idUnidIng As Integer, Capacidad As Decimal, idUnidCapacidad As Integer)
        Dim CantTotal As Decimal = 0
        Select Case idUnidIng
            Case 24 'Mililitro
                Select Case idUnidCapacidad
                    Case 24 'Mililitro
                        CantTotal = CantIng
                    Case 4 'Gramos
                        CantTotal = CantIng / 1000
                    Case 3 ' Kilogramos
                        CantTotal = CantIng / 1000000
                    Case 25 'Toneladas
                        CantTotal = CantIng / 1000000000
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case 4 ' Gramos
                Select Case idUnidCapacidad
                    Case 24 'Mililitro
                        CantTotal = CantIng * 1000
                    Case 4 'Gramos
                        CantTotal = CantIng
                    Case 3 ' Kilogramos
                        CantTotal = CantIng / 1000
                    Case 25 'Toneladas
                        CantTotal = CantIng / 1000000
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case 3
                Select Case idUnidCapacidad
                    Case 24 'Mililitro
                        CantTotal = CantIng * 1000000
                    Case 4 'Gramos
                        CantTotal = CantIng * 1000
                    Case 3 ' Kilogramos
                        CantTotal = CantIng
                    Case 25 'Toneladas
                        CantTotal = CantIng / 1000
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case 25
                Select Case idUnidCapacidad
                    Case 24 'Mililitro
                        CantTotal = CantIng * 1000000000
                    Case 4 'Gramos
                        CantTotal = CantIng * 1000000
                    Case 3 ' Kilogramos
                        CantTotal = CantIng * 1000
                    Case 25 'Toneladas
                        CantTotal = CantIng
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case 6 'Litro
                Select Case idUnidCapacidad
                    Case 6 'Litro
                        CantTotal = CantIng
                    Case 10 'Mililitro
                        CantTotal = CantIng * 1000
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case 10 'Mililitro
                Select Case idUnidCapacidad
                    Case 10 'Mililitro
                        CantTotal = CantIng
                    Case 6 'Litro
                        CantTotal = CantIng / 1000
                    Case Else
                        CantTotal = CantIng / Capacidad
                End Select
            Case Else
                If (idUnidIng = idUnidCapacidad) Then
                    CantTotal = CantIng
                Else
                    CantTotal = CantIng / Capacidad
                End If

        End Select
        Return (CantTotal)
    End Function
    Function ConversionBase(UnidadBase As String, Unidad As String, Cantidad As Decimal, Capacidad As Decimal, TipoFactorAlt As String) As Decimal
        Dim CantTotal As Decimal = 0
        If (UnidadBase = Unidad) Then
            CantTotal = Cantidad
        Else
            Select Case Unidad
                Case "Kilogramos", "Litros"
                    Select Case UnidadBase
                        Case "Gramos", "Mililitros"
                            CantTotal = Cantidad * 1000
                        Case Else
                            CantTotal = Cantidad / Capacidad
                    End Select
                Case "Gramos", "Mililitros"
                    Select Case UnidadBase
                        Case "Kilogramos", "Litros"
                            CantTotal = Cantidad / 1000
                        Case Else
                            CantTotal = Cantidad / Capacidad
                    End Select
                Case Else
                    If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                        If (UnidadBase = "Cartón") Then
                            CantTotal = Cantidad / Capacidad
                        Else
                            CantTotal = Cantidad
                        End If
                    Else
                        CantTotal = Cantidad / Capacidad
                    End If
            End Select
        End If
        Return (CantTotal)
    End Function

    '''''aqui cambio'''''''''''''''
    'Public Sub ActualizarCostoProductoCompuesto(Cod As String, Grid As Object)
    '    Dim TotalCosto As Decimal = 0
    '    Dim CantTotal As Decimal = 0
    '    Dim CantAux As Decimal = 0
    '    Dim NuevaUnidadAlterna As String = ""
    '    If Conectar2() Then
    '        Dim Comando2 As New SqlCommand("Select UnidadProd, UnidadIng, CantidadIng, UnidadAlt, FactorAlt,TipoFactorAlt,Empaquetado, CantEmpaquetado, CostoU FROM VIngredientesRecetas WHERE idProducto=" & Cod, CNN2)
    '        Dim DatosIng As SqlDataReader = Comando2.ExecuteReader()
    '        Do While DatosIng.Read()
    '            Dim TipoFactorAlt As String
    '            If (DatosIng("TipoFactorAlt").ToString = "") Then
    '                TipoFactorAlt = DatosIng("UnidadIng").ToString & " X"
    '            Else
    '                TipoFactorAlt = DatosIng("TipoFactorAlt").ToString
    '            End If
    '            If (DatosIng("UnidadAlt").ToString = "_Ninguno") Then
    '                CantTotal = ConversionBase(DatosIng("UnidadProd"), DatosIng("UnidadIng"), DatosIng("CantidadIng"), 1, TipoFactorAlt)
    '            Else
    '                NuevaUnidadAlterna = TomarPalabra(DatosIng("TipoFactorAlt"))
    '                CantAux = ConversionBase(NuevaUnidadAlterna, DatosIng("UnidadIng"), DatosIng("CantidadIng"), DatosIng("FactorAlt"), TipoFactorAlt)
    '                CantTotal = ConversionBase(DatosIng("UnidadProd"), NuevaUnidadAlterna, CantAux, DatosIng("FactorAlt"), TipoFactorAlt)
    '                If (DatosIng("Empaquetado")) Then
    '                    CantTotal = CantTotal * DatosIng("CantEmpaquetado")
    '                End If
    '            End If
    '            TotalCosto = TotalCosto + (DatosIng("Costou") * CantTotal)
    '        Loop
    '        DatosIng.Close()
    '        Grid.Rows(Grid.RowCount - 1).Cells("Costo").Value = TotalCosto
    '        Grid.Rows(Grid.RowCount - 1).Cells("CostoD").Value = CalcularDolar(DateTime.Now, TotalCosto.ToString)
    '    End If
    '    Desconectar2()
    'End Sub
    'Function ConversionBaseTerminados(UnidadBase As String, Unidad As String, Cantidad As Decimal, Capacidad As Decimal) As Decimal
    '    Dim CantTotal As Decimal = 0
    '    If (UnidadBase = Unidad) Then
    '        CantTotal = Cantidad
    '    Else
    '        Select Case Unidad
    '            Case "Kilogramos", "Litros"
    '                Select Case UnidadBase
    '                    Case "Gramos", "Mililitros"
    '                        CantTotal = Cantidad * 1000
    '                    Case Else
    '                        CantTotal = Cantidad / Capacidad
    '                End Select
    '            Case "Gramos", "Mililitros"
    '                Select Case UnidadBase
    '                    Case "Kilogramos", "Litros"
    '                        CantTotal = Cantidad / 1000
    '                    Case Else
    '                        CantTotal = Cantidad / Capacidad
    '                End Select
    '            Case Else
    '                CantTotal = 0
    '                'If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
    '                '    CantTotal = Cantidad / Capacidad
    '                'Else
    '                '    CantTotal = Cantidad * Capacidad
    '                'End If
    '        End Select
    '    End If
    '    Return (CantTotal)
    'End Function

    Function VFormat(Valor As String, CantDec As Integer) As String
        Dim X As Decimal = 0
        X = IIf(Valor = "", 0, Valor)
        If (X Mod 1) <> 0 Then
            Select Case CantDec
                Case 1
                    Return (Format(X, "##,##0.0"))
                    Exit Function
                Case 2
                    Return (Format(X, "##,##0.00"))
                    Exit Function
                Case 3
                    Return (Format(X, "##,##0.000"))
                    Exit Function
                Case 4
                    Return (Format(X, "##,##0.0000"))
                    Exit Function
            End Select
        Else
            X = Valor
        End If
        Return (Format(X, "##,##0."))
    End Function

    Public Sub CalcularIgualdadUnidades(CodProd As String, BUnidAlt As String, Cant As Decimal)
        'Buscar Capacidad del Producto y Capacidad Alterna
        If (Conectar4()) Then
            Dim Comando As New SqlCommand("Select Capacidad, FactorAlt, idUnidadAlt, UnidadCatInt,UnidadCapacidad,idCategoriaInt FROM VNewProducto WHERE idProducto=" & CodProd, CNN4)
            Dim DR = Comando.ExecuteReader()
            If DR.Read() Then
                If (BUnidAlt = "Unidad") Then
                    StockUnidadProd = Cant
                    StockUnidadCap = StockUnidadProd * DR("Capacidad")
                    If (DR("idUnidadAlt") = 7) Then
                        StockUnidadAlt = 0
                    Else
                        StockUnidadAlt = StockUnidadCap / DR("FactorAlt")
                    End If
                    If (DR("idCategoriaInt") = 1) Then
                        StockUnidadCatInt = 0
                    Else
                        StockUnidadCatInt = ConversionBase(DR("UnidadCatInt"), DR("UnidadCapacidad"), StockUnidadCap, DR("Capacidad"), DR("UnidadCapacidad") + " X ")
                    End If
                Else
                    StockUnidadAlt = Cant
                    StockUnidadProd = StockUnidadAlt * DR("FactorAlt")
                    StockUnidadCap = StockUnidadProd * DR("Capacidad")
                    If (DR("idCategoriaInt") = 1) Then
                        StockUnidadCatInt = 0
                    Else
                        StockUnidadCatInt = ConversionBase(DR("UnidadCatInt"), DR("UnidadCapacidad"), StockUnidadCap, DR("Capacidad"), DR("UnidadCatInt") + " X ")
                    End If
                End If
                DR.Close()
            End If
        End If
        Desconectar4()
    End Sub
    Public Sub ValidarComa(Texto As TextBox)
        If (Texto.Text = ",") Then
            Texto.Text = "0,"
            Texto.SelectionStart = Texto.TextLength
        End If
    End Sub
    Function PrimerDiaMes(Fecha As Date) As Date
        Return (DateSerial(Year(Fecha), Month(Fecha), 1))
    End Function
    Function UltimoDiaMes(Fecha As Date) As Date
        Return (DateSerial(Year(Fecha), Month(Fecha) + 1, 0))
    End Function
    Function PrimeraLetraDelDia(Fecha As Date) As String
        Dim NDia As String = ""
        If (Fecha.ToString("dddd") = "miércoles") Then
            NDia = "X"
        Else
            NDia = UCase(Mid(Fecha.ToString("dddd"), 1, 1))
        End If
        Return (NDia)
    End Function
    Public Function FormularioAbierto(_form As Form, applicatio As Application) As Boolean
        For Each f As Form In applicatio.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return False
    End Function
    Function MostrarEmpleado(idSubCategoria As Integer) As Boolean
        If (Conectar()) Then
            Dim Comando As New SqlCommand("SELECT Empleado FROM TSubCategoriaGastos WHERE id=" & idSubCategoria, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            If DR.Read() Then
                If (DR("Empleado") = True) Then
                    RequiereEmpleado = True
                Else
                    RequiereEmpleado = False
                End If
            End If
            DR.Close()
        End If
        Desconectar()
        Return (RequiereEmpleado)
    End Function


    '''''''''''''''''''Calculo de Costos'''''''''''''''''''''''''


    'aqui'''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub CalcularCostosX(CodigoProd As String, DGIngrediente As DataGridView)
        '  CalcularDolar(DateTime.Now, 0)
        If (CodigoProd <> "") Then
            Try
                For i = 0 To DGIngrediente.RowCount - 2
                    If (Conectar()) Then
                        Dim Comando As New SqlCommand("Select idUnidad,Unidad, CostoCalUnidD, Capacidad,idUnidadCapacidad,UnidadCapacidad, idCategoriaInt, Costo2D FROM VNewProducto WHERE idProducto=" & DGIngrediente.Item("idIngrediente", i).Value, CNN)
                        Dim DR As SqlDataReader = Comando.ExecuteReader()
                        If (DR.Read() = True) Then
                            If (DR("idCategoriaInt") = 1) Then
                                NX_UnidadProducto = DR("Unidad")
                                NX_Costo2D = DR("CostoCalUnidD")
                                NX_Costo2 = NX_Costo2D * BsXDolarBC ' Se Convierte el Valor de Dolar a Bs. con la Tasa Actual del Banco central
                                NX_Capacidad = DR("Capacidad")
                                NX_idUnidadCapacidad = DR("idUnidadCapacidad")
                                NX_UnidadCapacidad = DR("UnidadCapacidad")
                                Nx_CostoCalD = DR("Costo2D")
                            Else
                                BuscarCostoCategoriaInternaX(DR("idCategoriaInt"))
                            End If
                            DGIngrediente.Item("UnidadProd", i).Value = NX_UnidadProducto
                            DGIngrediente.Item("Costo2D", i).Value = Format(NX_Costo2D, "##,##0.0000")
                            DGIngrediente.Item("Costo2", i).Value = Format(NX_Costo2, "##,##0.0000")
                            DGIngrediente.Item("PorcCosto", i).Value = 0
                            If (NX_Capacidad Mod 1) = 0 Then
                                DGIngrediente.Item("Capacidad", i).Value = Format(NX_Capacidad, "##,##0")
                            Else
                                DGIngrediente.Item("Capacidad", i).Value = Format(NX_Capacidad, "##,##0.00")
                            End If
                            DGIngrediente.Item("idUnidadCapacidad", i).Value = NX_idUnidadCapacidad
                            DGIngrediente.Item("UnidadCapacidad", i).Value = NX_UnidadCapacidad
                            DGIngrediente.Item("CostoCalD", i).Value = Nx_CostoCalD
                        End If
                        DR.Close()
                    End If
                    Desconectar3()
                Next
                NuevoCostoCalculadoUnidadComp(DGIngrediente)
                NuevoCostoD = SumarColumna(DGIngrediente, 19)
                NuevoCosto = NuevoCosto * BsXDolarBC
                If (NuevoCostoD <> 0) Then
                    If (Conectar4()) Then
                        Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2 WHERE idProducto=" & CodigoProd, CNN4)
                        Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
                        Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
                        Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
                        Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
                        Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                        DR4.Close()
                    End If
                    Desconectar4()
                End If
            Catch ex As Exception
                MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                Desconectar4()
            End Try
        End If
    End Sub
    Public Sub LlenarPanX(CodigoProd As String, DGIngrediente As DataGridView)
        If (CodigoProd <> "") Then
            Try
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY CostoED DESC) AS Num, Principal, Externo,Excluir, idIngrediente,Ingrediente,idUnidad,Unidad, CantIng,PorcIng, id,CantIngE,CostoED,CostoE,PorcCostoE,CantIngU,CostoUD,CostoU,idCategoriaInt, PorcIngTotal, idTipoProducto FROM VRecetaGuardada WHERE idProducto=" & CodigoProd, CNN)
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DGIngrediente.Rows.Clear()
                    Do While DR.Read()
                        DGIngrediente.Rows.Add(DR("id"), DR("Num"), DR("Principal"), DR("Externo"), DR("Excluir"), DR("idIngrediente"), DR("Ingrediente"), DR("idUnidad"), DR("Unidad"), Format(DR("CantIng"), "##,##0.00"), Format(DR("PorcIng"), "##,##0.00"), Format(DR("PorcIngTotal"), "##,##0.00"), DR("idCategoriaInt"), DR("CantIngE").ToString, DR("CostoED").ToString, DR("CostoE").ToString, DR("PorcCostoE"), DR("CantIngU").ToString, DR("CostoUD").ToString, DR("CostoU").ToString, "", "", "", "", "", "", "", "", "", "", "", DR("idTipoProducto"))
                    Loop
                    DR.Close()
                End If
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Public Sub LlenarPanCompuestoX(Codigo As Integer, DGIngrediente2 As DataGridView)
        Try
            If (Conectar4()) Then
                Dim Comando4 As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY CostoED DESC) AS Num, Principal, Externo,Excluir, idIngrediente,Ingrediente,idUnidad,Unidad, CantIng,PorcIng, id,CantIngE,CostoED,CostoE,PorcCostoE,CantIngU,CostoUD,CostoU,idCategoriaInt, PorcIngTotal,IdTipoProducto FROM VRecetaGuardada WHERE idProducto=" & Codigo, CNN4)
                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                DGIngrediente2.Rows.Clear()
                Do While DR4.Read()
                    DGIngrediente2.Rows.Add(DR4("id"), DR4("Num"), DR4("Principal"), DR4("Externo"), DR4("Excluir"), DR4("idIngrediente"), DR4("Ingrediente"), DR4("idUnidad"), DR4("Unidad"), Format(DR4("CantIng"), "##,##0.00"), Format(DR4("PorcIng"), "##,##0.00"), Format(DR4("PorcIngTotal"), "##,##0.00"), DR4("idCategoriaInt"), DR4("CantIngE").ToString, DR4("CostoED").ToString, DR4("CostoE").ToString, DR4("PorcCostoE"), DR4("CantIngU").ToString, DR4("CostoUD").ToString, DR4("CostoU").ToString, DR4("idTipoProducto"))
                Loop
                DR4.Close()
            End If
            Desconectar4()
        Catch ex As Exception
            MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar4()
        End Try
    End Sub

    Public Function CalcularCostoCompuestoFinal(CantidadIng As Decimal, idUnidadIng As Integer, Capacidad As Decimal, idUnidadCapacidad As Integer, CostoIng As Decimal) As Decimal
        Dim TotalCosto As Decimal = 0
        Dim CantTotal As Decimal = 0
        CantTotal = ConversionBaseFinal(CantidadIng, idUnidadIng, Capacidad, idUnidadCapacidad)
        TotalCosto = (CostoIng * CantTotal) ' / Capacidad
        Return (TotalCosto)
    End Function

    Public Function CalcularCantidadCompuestoFinal(CantidadIng As Decimal, idUnidadIng As Integer, Capacidad As Decimal, idUnidadCapacidad As Integer, CostoIng As Decimal) As Decimal
        Dim CantTotal As Decimal = 0
        CantTotal = ConversionBaseFinal(CantidadIng, idUnidadIng, Capacidad, idUnidadCapacidad)
        Return (CantTotal)
    End Function
    Private Sub NuevoCostoCalculadoUnidadComp(DGIngredienteComp As DataGridView)
        Dim CostoX As Decimal = 0
        Dim CostoDX As Decimal = 0
        For i = 0 To DGIngredienteComp.RowCount - 2
            CostoDX = CalcularCostoCompuestoFinal(DGIngredienteComp.Item("CantIngUnidad", i).Value, DGIngredienteComp.Item("idUnidad", i).Value, DGIngredienteComp.Item("Capacidad", i).Value, DGIngredienteComp.Item("idUnidadCapacidad", i).Value, DGIngredienteComp.Item("Costo2D", i).Value)
            CalcularDolar(DateTime.Now, 0)
            CostoX = CostoDX * BsXDolar
            DGIngredienteComp.Item("CostoU", i).Value = Format(CostoX, "##,##0.0000")
            DGIngredienteComp.Item("CostoDU", i).Value = Format(CostoDX, "##,##0.0000")
        Next
    End Sub
    Private Sub BuscarCostoCategoriaInternaX(idCatInt As Integer)
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select * FROM VProductoCosto WHERE idCategoriaInt=" & idCatInt & " ORDER BY Fecha DESC, Costo2D DESC", CNN2)
            Dim DR2 As SqlDataReader = Comando2.ExecuteReader()
            If (DR2.Read() = True) Then
                NX_UnidadProducto = DR2("UnidadProd")
                NX_Costo2D = DR2("CostoCalUnidD")
                NX_Costo2 = NX_Costo2D * BsXDolar
                Nx_CostoCalD = DR2("Costo2D")
                NX_Capacidad = DR2("Capacidad").ToString
                NX_idUnidadCapacidad = DR2("idUnidadCapacidad")
                NX_UnidadCapacidad = DR2("UnidadCapacidad")
            Else
                NX_UnidadProducto = ""
                NX_Costo2D = 0
                NX_Costo2 = 0
                NX_Capacidad = 1
                NX_idUnidadCapacidad = 0
                NX_UnidadCapacidad = ""
            End If
            DR2.Close()
        End If
        Desconectar2()
    End Sub

    'Public Sub ActualizarCostoProductoCompuestoX(Codigo As String, DGIngrediente2 As DataGridView)
    '    LlenarPanCompuestoX(Codigo, DGIngrediente2)
    '    Try
    '        For i = 0 To DGIngrediente2.RowCount - 1
    '            If (Conectar3()) Then
    '                Dim Comando3 As New SqlCommand("Select idUnidad,Unidad, CostoCalUnidD, Capacidad,idUnidadCapacidad,UnidadCapacidad, idCategoriaInt, Costo2D FROM VNewProducto WHERE idProducto=" & DGIngrediente2.Item("idIngrediente", i).Value, CNN3)
    '                Dim DR3 As SqlDataReader = Comando3.ExecuteReader()
    '                If (DR3.Read() = True) Then
    '                    If (DR3("idCategoriaInt") = 1) Then
    '                        NX_UnidadProducto = DR3("Unidad")
    '                        NX_Costo2D = DR3("CostoCalUnidD")
    '                        NX_Costo2 = NX_Costo2D * BsXDolarBC ' Se Convierte el Valor de Dolar a Bs. con la Tasa Actual del Banco central
    '                        NX_Capacidad = DR3("Capacidad")
    '                        NX_idUnidadCapacidad = DR3("idUnidadCapacidad")
    '                        NX_UnidadCapacidad = DR3("UnidadCapacidad")
    '                        Nx_CostoCalD = DR3("Costo2D")
    '                    Else
    '                        BuscarCostoCategoriaInternaX(DR3("idCategoriaInt"))
    '                    End If
    '                    '  DGIngrediente2.Item("UnidadProd2", i).Value = NX_UnidadProducto
    '                    DGIngrediente2.Item("Costo2D2", i).Value = Format(NX_Costo2D, "##,##0.0000")
    '                    DGIngrediente2.Item("Costo22", i).Value = Format(NX_Costo2, "##,##0.0000")
    '                    DGIngrediente2.Item("PorcCosto2", i).Value = 0
    '                    If (NX_Capacidad Mod 1) = 0 Then
    '                        DGIngrediente2.Item("Capacidad2", i).Value = Format(NX_Capacidad, "##,##0")
    '                    Else
    '                        DGIngrediente2.Item("Capacidad2", i).Value = Format(NX_Capacidad, "##,##0.00")
    '                    End If
    '                    DGIngrediente2.Item("idUnidadCapacidad2", i).Value = NX_idUnidadCapacidad
    '                    DGIngrediente2.Item("UnidadCapacidad2", i).Value = NX_UnidadCapacidad
    '                    ' DGIngrediente2.Item("CostoCalD2", i).Value = Nx_CostoCalD
    '                End If
    '                DR3.Close()
    '            End If
    '            Desconectar3()
    '        Next
    '        NuevoCostoCalculadoUnidadComp(DGIngrediente2)
    '        NuevoCosto = SumarColumna(DGIngrediente2, 19)
    '        CalcularDolar(DateTime.Now, "0")
    '        NuevoCostoD = NuevoCosto * BsXDolarBC
    '        If (NuevoCostoD <> 0) Then
    '            If (Conectar4()) Then
    '                Dim Comando4 As New SqlCommand("UPDATE TNewProducto set CostoD=@CostoD,Costo=@Costo, Costo2D=@Costo2D,Costo2=@Costo2 WHERE idProducto=" & Codigo, CNN4)
    '                Comando4.Parameters.Add(New SqlParameter("@CostoD", NuevoCostoD))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo", NuevoCosto))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo2D", NuevoCostoD))
    '                Comando4.Parameters.Add(New SqlParameter("@Costo2", NuevoCosto))
    '                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
    '                DR4.Close()
    '            End If
    '            Desconectar4()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error al Actualizar Costos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '        Desconectar3()
    '        Desconectar4()
    '    End Try
    'End Sub
    'Public Sub VefiricarCostos(CodigoProd As String, DGIngrediente2 As DataGridView)
    '    If (CodigoProd <> "") Then
    '        Try
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("Select  idIngrediente,idTipoProducto FROM VRecetaGuardada WHERE idProducto=" & CodigoProd, CNN)
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                Do While DR.Read()
    '                    If (DR("idTipoProducto") = 2) Then
    '                        ActualizarCostoProductoCompuestoX(DR("idIngrediente"), DGIngrediente2)
    '                    End If
    '                Loop
    '                DR.Close()
    '            End If
    '            Desconectar()
    '        Catch ex As Exception
    '            MsgBox("Error al Actualizar Datos del Producto.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
    '            Desconectar()
    '        End Try
    '    End If
    'End Sub



    Public Sub CrearDocFiscal(CodVenta As Integer)
        Dim ruta As String = "C:\FACTURAS\"
        Dim CodImpFactura As String = ""
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select CodImpFactura FROM TCajas WHERE id=@idCaja", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    CodImpFactura = DR("CodImpFactura")
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Datos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            End Try
        End If
        Desconectar()
        Dim archivo As String = "MarSoft" & CodImpFactura
        Dim Fecha As DateTime
        Dim Caja As String = ""
        Dim Cajero1 As String = ""
        Dim idCliente As String = ""
        Dim Cliente As String = ""
        Dim RIF As String = ""
        Dim Direccion1 As String = ""
        Dim Direccion2 As String = ""
        Dim Telefono As String = ""
        Dim LenLinea As Integer = 0
        Dim Descripcion As String = ""
        Dim Codigo As String = ""
        Dim Cantidad As String = ""
        Dim IVA As String = ""
        Dim PrecioUnitario As String = ""
        Dim SubTotal As String = ""
        Dim Descuento As String = ""
        Dim TotalPagar As String = ""
        Dim Efectivo As Decimal = 0
        Dim Dolar As Decimal = 0
        Dim Tarjeta As Decimal = 0
        Dim Transferencia As Decimal = 0
        Dim PagoMovil As Decimal = 0
        Dim Credito As Decimal = 0
        Dim BioPago As Decimal = 0
        Dim Otras As Decimal = 0

        Dim TEfectivo As String = ""
        Dim TDolar As String = ""
        Dim TTarjeta As String = ""
        Dim TTransferencia As String = ""
        Dim TPagoMovil As String = ""
        Dim TCredito As String = ""
        Dim TBioPago As String = ""
        Dim TOtras As String = ""
        Dim fs As FileStream
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select * FROM VFacturaFiscal WHERE idVenta=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    Fecha = DR("Fecha")

                    If (ImprimirRif) Then
                        Cliente = DR("NomEmpresa")
                        RIF = DR("TipoRif") & DR("RIF")
                    Else
                        Cliente = DR("Cliente")
                        RIF = DR("Nacionalidad") & DR("CICliente")
                    End If

                    If (Len(DR("Direccion").ToString) > 30) Then
                        Direccion1 = Mid(DR("Direccion"), 1, 30)
                        Direccion2 = Mid(DR("Direccion"), 31, Len(DR("Direccion").ToString))
                    Else
                        Direccion1 = DR("Direccion")
                        Direccion2 = ""
                    End If
                    Telefono = DR("Celular")
                    SubTotal = Format(DR("SubTotal"), "##,##0.00")
                    Descuento = Format(0, "##,##0.00")
                    TotalPagar = Format(DR("Total"), "##,##0.00")
                    Caja = DR("idCaja").ToString
                    Cajero1 = DR("idCajero").ToString
                    idCliente = DR("idCliente").ToString
                End If

                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Accesar Datos de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            End Try
        End If
        Desconectar()
        Try
            If File.Exists(ruta) Then
                fs = File.Create(ruta & archivo)
                fs.Close()
            Else
                Directory.CreateDirectory(ruta)
                fs = File.Create(ruta & archivo)
                fs.Close()
            End If
            Dim escribir As New StreamWriter(ruta & archivo, True)
            escribir.WriteLine("FACTURA:        " + RellenarCeros(CodVenta.ToString, 10) + " 	                     " + "LA BODEGA")
            escribir.WriteLine("FECHA:          " + Fecha)
            escribir.WriteLine("CLIENTE:        " + Cliente)
            escribir.WriteLine("RIF:            " + RIF)
            escribir.WriteLine("DIRECCIÓN1:     " + Direccion1)
            escribir.WriteLine("DIRECCIÓN2:     " + Trim(Direccion2))
            escribir.WriteLine("TELÉFONO:	    " + Trim(Telefono))
            escribir.WriteLine("DESCRIPCION                                                 CODIGO.................... CANT.....   IVA..   PRECIO UNIT..........")
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select * FROM VDetalleVenta WHERE idVenta=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    'Descripcion
                    LenLinea = Len(DR("Articulo"))
                    If (LenLinea > 58) Then
                        Descripcion = Mid(DR("Articulo"), 1, 58)
                    Else
                        Descripcion = DR("Articulo")
                    End If
                    LenLinea = Len(Descripcion)
                    If (LenLinea < 58) Then
                        Descripcion = Descripcion + New String(" "c, 60 - LenLinea)
                    End If
                    'Codigo
                    LenLinea = Len(DR("idProducto").ToString)
                    If (LenLinea < 27) Then
                        Codigo = DR("idProducto").ToString + New String(" "c, 27 - LenLinea)
                    Else
                        Codigo = DR("idProducto").ToString
                    End If
                    'Cantidad
                    Dim x As String = VFormat(DR("Cantidad"), 3)
                    LenLinea = Len(Format(DR("Cantidad"), "##,##0.000"))
                    If (LenLinea < 12) Then
                        Cantidad = Format(DR("Cantidad"), "##,##0.000") + New String(" "c, 12 - LenLinea)
                    End If
                    'IVA
                    LenLinea = Len(Format(DR("VIVAV"), "##,##0.00"))
                    If (LenLinea < 8) Then
                        IVA = Format(DR("VIVAV"), "##,##0.00") + New String(" "c, 8 - LenLinea)
                    End If
                    'PRECIO UNITARIO
                    LenLinea = Len(Format(DR("Precio"), "##,##0.00"))
                    If (LenLinea < 21) Then
                        PrecioUnitario = Format(DR("Precio"), "##,##0.00") + New String(" "c, 21 - LenLinea)
                    End If
                    escribir.WriteLine(Descripcion + Codigo + Cantidad + IVA + PrecioUnitario)
                Loop
            End If
            Desconectar()
            If (LenLinea < 32) Then
                SubTotal = SubTotal + New String(" "c, 32 - LenLinea)
            End If
            escribir.WriteLine("SUB-TOTAL              " + SubTotal)
            escribir.WriteLine("DESCUENTO              " + Descuento + "%")
            escribir.WriteLine("TOTAL A PAGAR          " + TotalPagar)
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select * FROM TDetalleFormaPago WHERE idDetalle=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Select Case DR("Nombre")
                        Case "Efectivo"
                            Efectivo = Efectivo + DR("Monto")
                        Case "Dolar"
                            Dolar = Dolar + DR("MontoD")
                        Case "Tarjeta"
                            Tarjeta = Tarjeta + DR("Monto")
                        Case "Transferencia"
                            Transferencia = Transferencia + DR("Monto")
                        Case "Pago Móvil"
                            PagoMovil = PagoMovil + DR("Monto")
                        Case "Crédito"
                            Credito = Credito + DR("Monto")
                        Case "Bio-Pago"
                            BioPago = BioPago + DR("Monto")
                        Case "Otras"
                            Otras = Otras + DR("Monto")
                        Case "Varios"
                            Select Case DR("TipoPago")
                                Case "Efectivo"
                                    Efectivo = Efectivo + DR("Monto")
                                Case "Tarjeta"
                                    Tarjeta = Tarjeta + DR("Monto")
                                Case "Transferencia"
                                    Transferencia = Transferencia + DR("Monto")
                                Case "Pago Móvil"
                                    PagoMovil = PagoMovil + DR("Monto")
                                Case "Crédito"
                                    Credito = Credito + DR("Monto")
                                Case "Bio-Pago"
                                    BioPago = BioPago + DR("Monto")
                                Case Else
                                    If (Mid(DR("TipoPago").ToString, 1, 5) = "Dolar") Then
                                        Dolar = Dolar + DR("MontoD")
                                    Else
                                        Otras = Otras + DR("Monto")
                                    End If
                            End Select
                        Case Else
                    End Select
                Loop
                LenLinea = Len("EFECTIVO: " + Format(Efectivo, "##,##0.00"))
                If (LenLinea < 32) Then
                    TEfectivo = "EFECTIVO: " + New String(" "c, 32 - LenLinea) + Format(Efectivo, "##,##0.00")
                Else
                    TEfectivo = "EFECTIVO: " + Format(Efectivo, "##,##0.00")
                End If
                escribir.WriteLine(TEfectivo)
                LenLinea = Len("BIO-PAGO: " + Format(BioPago, "##,##0.00"))
                If (LenLinea < 32) Then
                    TBioPago = "BIO-PAGO: " + New String(" "c, 32 - LenLinea) + Format(BioPago, "##,##0.00")
                Else
                    TBioPago = "BIO-PAGO: " + Format(BioPago, "##,##0.00")
                End If
                escribir.WriteLine(TBioPago)
                LenLinea = Len("TARJ/DEBITO: " + Format(Tarjeta, "##,##0.00"))
                If (LenLinea < 32) Then
                    TTarjeta = "TARJ/DEBITO: " + New String(" "c, 32 - LenLinea) + Format(Tarjeta, "##,##0.00")
                Else
                    TTarjeta = "TARJ/DEBITO: " + Format(Tarjeta, "##,##0.00")
                End If
                escribir.WriteLine(TTarjeta)
                escribir.WriteLine("TARJ/CREDITO:               0,00")
                LenLinea = Len("TRANSF EN BS.: " + Format(Transferencia, "##,##0.00"))
                If (LenLinea < 32) Then
                    TTransferencia = "TRANSF EN BS.: " + New String(" "c, 32 - LenLinea) + Format(Transferencia, "##,##0.00")
                Else
                    TTransferencia = "TRANSF EN BS.: " + Format(Transferencia, "##,##0.00")
                End If
                escribir.WriteLine(TTransferencia)
                escribir.WriteLine("TRANSF EN USD:              0,00")
                escribir.WriteLine("TRANSF EN EURO:             0,00")
                LenLinea = Len("EFECT USD: " + Format(Dolar, "##,##0.00"))
                If (LenLinea < 32) Then
                    TDolar = "EFECT USD: " + New String(" "c, 32 - LenLinea) + Format(Dolar, "##,##0.00")
                Else
                    TDolar = "EFECT USD: " + Format(Dolar, "##,##0.00")
                End If
                escribir.WriteLine(TDolar)
                escribir.WriteLine("EFECT EURO:                 0,00")
                LenLinea = Len("PAGO MOVIL: " + Format(PagoMovil, "##,##0.00"))
                If (LenLinea < 32) Then
                    TPagoMovil = "PAGO MOVIL: " + New String(" "c, 32 - LenLinea) + Format(PagoMovil, "##,##0.00")
                Else
                    TPagoMovil = "PAGO MOVIL: " + Format(PagoMovil, "##,##0.00")
                End If
                escribir.WriteLine(TPagoMovil)

                LenLinea = Len("CREDITO: " + Format(Credito, "##,##0.00"))
                If (LenLinea < 32) Then
                    TCredito = "CREDITO: " + New String(" "c, 32 - LenLinea) + Format(Credito, "##,##0.00")
                Else
                    TCredito = "CREDITO: " + Format(Credito, "##,##0.00")
                End If
                escribir.WriteLine(TCredito)
                escribir.WriteLine("NOTA 1: ID Cliente:" + idCliente)
                escribir.WriteLine("NOTA 2: Utilice su ID para mayor Comodidad.")
                escribir.WriteLine("NOTA 3: GRACIAS POR SU COMPRA")
                escribir.WriteLine("NOTA 4: CAJA: " + Caja + " / CAJERO: " + Cajero1)
            End If
            Desconectar()
            escribir.Close()
        Catch ex As Exception
            MsgBox("Se presento un Problema al crear el Archivo Fiscal: " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Información.")
        End Try
    End Sub
    Public Sub CrearDocFiscalDev(CodVenta As Integer)
        Dim ruta As String = "C:\FACTURAS\"
        '  Dim ruta As String = "C:\Yelitza\"
        Dim CodImpFactura As String = ""
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select CodImpFactura FROM TCajas WHERE id=@idCaja", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    CodImpFactura = DR("CodImpFactura")
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Datos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            End Try
        End If
        Desconectar()
        Dim archivo As String = "MarSoft" & CodImpFactura
        Dim Fecha As DateTime
        Dim Caja As String = ""
        Dim Cajero1 As String = ""
        Dim idCliente As String = ""
        Dim Cliente As String = ""
        Dim RIF As String = ""
        Dim Direccion1 As String = ""
        Dim Direccion2 As String = ""
        Dim Telefono As String = ""
        Dim LenLinea As Integer = 0
        Dim Descripcion As String = ""
        Dim Codigo As String = ""
        Dim Cantidad As String = ""
        Dim IVA As String = ""
        Dim PrecioUnitario As String = ""
        Dim SubTotalDev As Decimal = 0
        Dim TotalDev As Decimal = 0
        Dim SubTotal As String = ""
        Dim Descuento As String = ""
        Dim TotalPagar As String = ""
        Dim Efectivo As Decimal = 0
        Dim Dolar As Decimal = 0
        Dim Tarjeta As Decimal = 0
        Dim Transferencia As Decimal = 0
        Dim PagoMovil As Decimal = 0
        Dim Credito As Decimal = 0
        Dim BioPago As Decimal = 0
        Dim Otras As Decimal = 0

        Dim TEfectivo As String = ""
        Dim TDolar As String = ""
        Dim TTarjeta As String = ""
        Dim TTransferencia As String = ""
        Dim TPagoMovil As String = ""
        Dim TCredito As String = ""
        Dim TBioPago As String = ""
        Dim TOtras As String = ""
        Dim fs As FileStream
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select * FROM VFacturaFiscal WHERE idVenta=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    Fecha = DR("Fecha")

                    Cliente = DR("Cliente")
                    If (ImprimirRif) Then
                        Cliente = DR("NomEmpresa")
                        RIF = DR("TipoRif") & DR("RIF")
                    Else
                        Cliente = DR("Cliente")
                        RIF = DR("Nacionalidad") & DR("CICliente")
                    End If
                    If (Len(DR("Direccion").ToString) > 30) Then
                        Direccion1 = Mid(DR("Direccion"), 1, 30)
                        Direccion2 = Mid(DR("Direccion"), 31, Len(DR("Direccion").ToString))
                    Else
                        Direccion1 = DR("Direccion")
                        Direccion2 = ""
                    End If
                    Telefono = DR("Celular")
                    SubTotal = Format(DR("SubTotal"), "##,##0.00")
                    Descuento = Format(0, "##,##0.00")
                    TotalPagar = Format(DR("Total"), "##,##0.00")
                    Caja = DR("idCaja").ToString
                    Cajero1 = DR("idCajero").ToString
                    idCliente = DR("idCliente").ToString
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Accesar Datos de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            End Try
        End If
        Desconectar()
        Try
            If File.Exists(ruta) Then
                fs = File.Create(ruta & archivo)
                fs.Close()
            Else
                Directory.CreateDirectory(ruta)
                fs = File.Create(ruta & archivo)
                fs.Close()
            End If
            Dim escribir As New StreamWriter(ruta & archivo, True)
            escribir.WriteLine("DEVOLUCION:     " + RellenarCeros(CodVenta.ToString, 10) + " 	                     " + "LA BODEGA")
            escribir.WriteLine("FECHA:          " + Fecha)
            escribir.WriteLine("CLIENTE:        " + Cliente)
            escribir.WriteLine("RIF:            " + RIF)
            escribir.WriteLine("DIRECCIÓN1:     " + Direccion1)
            escribir.WriteLine("DIRECCIÓN2:     " + Trim(Direccion2))
            escribir.WriteLine("TELÉFONO:	    " + Trim(Telefono))
            escribir.WriteLine("DESCRIPCION                                                 CODIGO.................... CANT.....   IVA..   PRECIO UNIT..........")
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select * FROM VDetalleVenta WHERE CodDev<>0 AND idVenta=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    If (DR("Devolucion") = False) Then
                        'Descripcion
                        LenLinea = Len(DR("Articulo"))
                        If (LenLinea > 58) Then
                            Descripcion = Mid(DR("Articulo"), 1, 58)
                        Else
                            Descripcion = DR("Articulo")
                        End If
                        LenLinea = Len(Descripcion)
                        If (LenLinea < 58) Then
                            Descripcion = Descripcion + New String(" "c, 60 - LenLinea)
                        End If
                        'Codigo
                        LenLinea = Len(DR("idProducto").ToString)
                        If (LenLinea < 27) Then
                            Codigo = DR("idProducto").ToString + New String(" "c, 27 - LenLinea)
                        Else
                            Codigo = DR("idProducto").ToString
                        End If
                        'Cantidad
                        Dim x As String = VFormat(DR("Cantidad"), 3)

                        LenLinea = Len(Format(DR("Cantidad"), "##,##0.000"))
                        If (LenLinea < 12) Then
                            Cantidad = Format(DR("Cantidad"), "##,##0.000") + New String(" "c, 12 - LenLinea)
                        End If
                        'IVA
                        LenLinea = Len(Format(DR("VIVAV"), "##,##0.00"))
                        If (LenLinea < 8) Then
                            IVA = Format(DR("VIVAV"), "##,##0.00") + New String(" "c, 8 - LenLinea)
                        End If
                        'PRECIO UNITARIO
                        LenLinea = Len(Format(DR("Precio"), "##,##0.00"))
                        If (LenLinea < 21) Then
                            PrecioUnitario = Format(DR("Precio"), "##,##0.00") + New String(" "c, 21 - LenLinea)
                        End If
                        SubTotalDev = SubTotalDev + Format(DR("Precio") * DR("Cantidad"), "##,##0.00")
                        TotalDev = TotalDev + Format(DR("Precio") * DR("Cantidad"), "##,##0.00")
                        escribir.WriteLine(Descripcion + Codigo + Cantidad + IVA + PrecioUnitario)
                    End If
                Loop
            End If
            Desconectar()
            If (LenLinea < 32) Then
                SubTotal = SubTotal + New String(" "c, 32 - LenLinea)
            End If
            SubTotal = Format(SubTotalDev, "##,##0.00")
            TotalPagar = Format(TotalDev, "##,##0.00")
            escribir.WriteLine("SUB-TOTAL              " + SubTotal)
            escribir.WriteLine("DESCUENTO              " + Descuento + "%")
            escribir.WriteLine("TOTAL A PAGAR          " + TotalPagar)
            If (Conectar()) Then
                Dim Comando As New SqlCommand("Select * FROM TDetalleFormaPago WHERE idDetalle=@idVenta", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Select Case DR("Nombre")
                        Case "Efectivo"
                            Efectivo = Efectivo + DR("Monto")
                        Case "Dolar"
                            Dolar = Dolar + DR("MontoD")
                        Case "Tarjeta"
                            Tarjeta = Tarjeta + DR("Monto")
                        Case "Transferencia"
                            Transferencia = Transferencia + DR("Monto")
                        Case "Pago Móvil"
                            PagoMovil = PagoMovil + DR("Monto")
                        Case "Crédito"
                            Credito = Credito + DR("Monto")
                        Case "Bio-Pago"
                            BioPago = BioPago + DR("Monto")
                        Case "Otras"
                            Otras = Otras + DR("Monto")
                        Case "Varios"
                            Select Case DR("TipoPago")
                                Case "Efectivo"
                                    Efectivo = Efectivo + DR("Monto")
                                Case "Tarjeta"
                                    Tarjeta = Tarjeta + DR("Monto")
                                Case "Transferencia"
                                    Transferencia = Transferencia + DR("Monto")
                                Case "Pago Móvil"
                                    PagoMovil = PagoMovil + DR("Monto")
                                Case "Crédito"
                                    Credito = Credito + DR("Monto")
                                Case "Bio-Pago"
                                    BioPago = BioPago + DR("Monto")
                                Case Else
                                    If (Mid(DR("TipoPago").ToString, 1, 5) = "Dolar") Then
                                        Dolar = Dolar + DR("MontoD")
                                    Else
                                        Otras = Otras + DR("Monto")
                                    End If
                            End Select
                        Case Else
                    End Select
                Loop
                LenLinea = Len("EFECTIVO: " + Format(Efectivo, "##,##0.00"))
                If (LenLinea < 32) Then
                    TEfectivo = "EFECTIVO: " + New String(" "c, 32 - LenLinea) + Format(Efectivo, "##,##0.00")
                Else
                    TEfectivo = "EFECTIVO: " + Format(Efectivo, "##,##0.00")
                End If
                escribir.WriteLine(TEfectivo)
                LenLinea = Len("BIO-PAGO: " + Format(BioPago, "##,##0.00"))
                If (LenLinea < 32) Then
                    TBioPago = "BIO-PAGO: " + New String(" "c, 32 - LenLinea) + Format(BioPago, "##,##0.00")
                Else
                    TBioPago = "BIO-PAGO: " + Format(BioPago, "##,##0.00")
                End If
                escribir.WriteLine(TBioPago)
                LenLinea = Len("TARJ/DEBITO: " + Format(Tarjeta, "##,##0.00"))
                If (LenLinea < 32) Then
                    TTarjeta = "TARJ/DEBITO: " + New String(" "c, 32 - LenLinea) + Format(Tarjeta, "##,##0.00")
                Else
                    TTarjeta = "TARJ/DEBITO: " + Format(Tarjeta, "##,##0.00")
                End If
                escribir.WriteLine(TTarjeta)
                escribir.WriteLine("TARJ/CREDITO:               0,00")
                LenLinea = Len("TRANSF EN BS.: " + Format(Transferencia, "##,##0.00"))
                If (LenLinea < 32) Then
                    TTransferencia = "TRANSF EN BS.: " + New String(" "c, 32 - LenLinea) + Format(Transferencia, "##,##0.00")
                Else
                    TTransferencia = "TRANSF EN BS.: " + Format(Transferencia, "##,##0.00")
                End If
                escribir.WriteLine(TTransferencia)
                escribir.WriteLine("TRANSF EN USD:              0,00")
                escribir.WriteLine("TRANSF EN EURO:             0,00")
                LenLinea = Len("EFECT USD: " + Format(Dolar, "##,##0.00"))
                If (LenLinea < 32) Then
                    TDolar = "EFECT USD: " + New String(" "c, 32 - LenLinea) + Format(Dolar, "##,##0.00")
                Else
                    TDolar = "EFECT USD: " + Format(Dolar, "##,##0.00")
                End If
                escribir.WriteLine(TDolar)
                escribir.WriteLine("EFECT EURO:                 0,00")
                LenLinea = Len("PAGO MOVIL: " + Format(PagoMovil, "##,##0.00"))
                If (LenLinea < 32) Then
                    TPagoMovil = "PAGO MOVIL: " + New String(" "c, 32 - LenLinea) + Format(PagoMovil, "##,##0.00")
                Else
                    TPagoMovil = "PAGO MOVIL: " + Format(PagoMovil, "##,##0.00")
                End If
                escribir.WriteLine(TPagoMovil)
                LenLinea = Len("CREDITO: " + Format(Credito, "##,##0.00"))
                If (LenLinea < 32) Then
                    TCredito = "CREDITO: " + New String(" "c, 32 - LenLinea) + Format(Credito, "##,##0.00")
                Else
                    TCredito = "CREDITO: " + Format(Credito, "##,##0.00")
                End If
                escribir.WriteLine(TCredito)
                escribir.WriteLine("NOTA 1: ID Cliente:" + idCliente)
                escribir.WriteLine("NOTA 2: Utilice su ID para mayor Comodidad.")
                escribir.WriteLine("NOTA 3: GRACIAS POR SU COMPRA")
                escribir.WriteLine("NOTA 4: CAJA: " + Caja + " / CAJERO: " + Cajero1)
                escribir.WriteLine("FACTURAAFECTADA:  " + CodFactura.ToString)
            End If
            Desconectar()
            escribir.Close()
        Catch ex As Exception
            MsgBox("Se presento un Problema al crear el Archivo Fiscal: " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Información.")
        End Try
    End Sub

    Function MoverTreintaUno(Fecha As Date) As Integer
        If (Fecha.Day = 31) Then
            Return (30)
        Else
            Return (Fecha.Day)
        End If
    End Function
    Function LetraDeNumero(Num As Integer) As String
        Dim Letra As String
        Select Case Num
            Case 1
                Letra = "a"
            Case 2
                Letra = "b"
            Case 3
                Letra = "c"
            Case 4
                Letra = "d"
            Case 5
                Letra = "e"
            Case 6
                Letra = "f"
            Case 7
                Letra = "g"
            Case 8
                Letra = "h"
            Case 9
                Letra = "i"
            Case 10
                Letra = "j"
            Case 11
                Letra = "k"
            Case 12
                Letra = "l"
            Case 13
                Letra = "m"
            Case 14
                Letra = "n"
            Case 15
                Letra = "o"
            Case 16
                Letra = "p"
            Case 17
                Letra = "q"
            Case 18
                Letra = "r"
            Case 19
                Letra = "s"
            Case 20
                Letra = "t"
            Case 21
                Letra = "u"
            Case 22
                Letra = "v"
            Case 23
                Letra = "x"
            Case 24
                Letra = "y"
            Case 25
                Letra = "z"




            Case 26
                Letra = "aa"
            Case 27
                Letra = "ab"
            Case 28
                Letra = "ac"
            Case 29
                Letra = "ad"
            Case 30
                Letra = "ae"
            Case 31
                Letra = "af"
            Case 32
                Letra = "ag"
            Case 33
                Letra = "ah"
            Case 34
                Letra = "ai"
            Case 35
                Letra = "aj"
            Case 36
                Letra = "ak"
            Case 37
                Letra = "al"
            Case 38
                Letra = "am"
            Case 39
                Letra = "an"
            Case 40
                Letra = "ao"
            Case 41
                Letra = "ap"
            Case 42
                Letra = "aq"
            Case 43
                Letra = "ar"
            Case 44
                Letra = "as"
            Case 45
                Letra = "at"
            Case 46
                Letra = "au"
            Case 47
                Letra = "av"
            Case 48
                Letra = "ax"
            Case 49
                Letra = "ay"
            Case 50
                Letra = "az"
        End Select
        Return (Letra)
    End Function
    Function GridExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim ExLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim ExHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try





            'ExHoja.Name =
            'ExHoja.Rows(4).Insert()
            'ExHoja.Cells.Item(2, 2) = "Fecha: " & DateTime.Now.Date & "  Hora: " & FormatDateTime(DateTime.Now, DateFormat.ShortTime)
            'ExHoja.Range("a2: i2").Merge()
            'ExHoja.Range("a2: i2").HorizontalAlignment = 1
            'ExHoja.Cells.Item(3, 3) = "Analisis de Nombres de la Aseguradora: " & Aseg & ", Poliza: " & Poli & " del Mes: " & Mes
            'ExHoja.Range("a1: i2").Font.Bold = 1
            'ExHoja.Range("a3: i3").Font.Size = 18
            'ExHoja.Range("a3: i3").HorizontalAlignment = 3
            'ExHoja.Range("a3").RowHeight = 30
            'ExHoja.Range("a3: i3").Merge()
            'ExHoja.Range("a4").RowHeight = 10

            'ExHoja.Cells.Item(5, 1) = "Nº"
            'ExHoja.Cells.Item(5, 2) = "Doc. Princ."
            'ExHoja.Cells.Item(5, 3) = "Num. Aseg."
            'ExHoja.Cells.Item(5, 4) = "Asegurado"
            'ExHoja.Cells.Item(5, 5) = "Nombre en Aseguradora"
            'ExHoja.Cells.Item(5, 6) = "D.A."
            'ExHoja.Cells.Item(5, 7) = "Nombre en Interseg"
            'ExHoja.Cells.Item(5, 8) = "Nombre en Descuento"
            'ExHoja.Cells.Item(5, 9) = "D.D."

            'Dim x As Integer = NRow + 5
            'ExHoja.Range("a5: i" & x).Borders.LineStyle = 1

            'ExHoja.Range("a5: i5").Font.Bold = 1
            'ExHoja.Range("a5: i5").Interior.Color = Color.PaleTurquoise
            'ExHoja.Range("a5: i5").HorizontalAlignment = 3
            '' ExHoja.Range("a5: i5").Borders.Weight = Excel.XlBorderWeight.xlMedium
            'ExHoja.Range("a5").RowHeight = 18

            'ExHoja.Range("a6").Select()
            'exApp.ActiveWindow.FreezePanes = True
            'exApp.ActiveWindow.DisplayGridlines = False
            'For Fila As Integer = 0 To NRow - 1
            '    For Col As Integer = 0 To NCol - 1
            '        ExHoja.Cells.Item(Fila + 6, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
            '        If (miDataGridView.Rows(Fila).Cells(Col).Style.BackColor = Color.Red) Then
            '            ExHoja.Cells.Item(Fila + 6, Col + 1).interior.color = miDataGridView.Rows(Fila).Cells(Col).Style.BackColor
            '        End If
            '    Next
            'Next
            'ExHoja.Columns.AutoFit()
            'ExHoja.Columns.Item(1).horizontalalignment = 3
            'ExHoja.Columns.Item(5).horizontalalignment = 3
            'ExHoja.Columns.Item(6).horizontalalignment = 3
            'ExHoja.Columns.Item(7).horizontalalignment = 3
            'ExHoja.Columns.Item(8).horizontalalignment = 3
            'ExHoja.Columns.Item(9).horizontalalignment = 3
            'ExHoja.Columns(1).Insert()
            'ExHoja.Range("a1").ColumnWidth = 2

            'ExHoja.PageSetup.PrintTitleRows = "$1:$5"
            'ExHoja.PageSetup.PrintTitleColumns = ""

            ExLibro = exApp.Workbooks.Add
            ExHoja = ExLibro.Worksheets.Add()

            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount
            Dim ColAct As Integer = 0
            For i As Integer = 1 To NCol
                '   If (miDataGridView.Columns(i - 1).HeaderText <> "ImagenF") And (miDataGridView.Columns(i - 1).HeaderText <> "Foto") And (miDataGridView.Columns(i - 1).HeaderText <> "Actualizar") Then
                'If (miDataGridView.Columns(i - 1).Visible = True) Then
                ExHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).HeaderText
                ColAct = ColAct + 1
                '   End If
                '   End If
            Next

            '      ExHoja.Range("a0: i" & NCol).Merge()





            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If (miDataGridView.Columns(Col).HeaderText <> "ImagenF") And (miDataGridView.Columns(Col).HeaderText <> "Foto") And (miDataGridView.Columns(Col).HeaderText <> "Actualizar") Then
                        If (miDataGridView.Columns(Col).Visible = True) Then
                            ExHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                        End If
                    End If
                Next
            Next

            Dim x As String = LetraDeNumero(ColAct - 1)
            exApp.ActiveWindow.DisplayGridlines = False
            ExHoja.Range("a1: " & x & "1").Borders.LineStyle = 1
            ExHoja.Range("a1: " & x & "1").Font.Bold = 1
            ExHoja.Range("a1: " & x & "1").RowHeight = 20
            ExHoja.Range("a1: " & x & "1").Interior.Color = Color.PaleTurquoise
            ExHoja.Range("a1: " & x & "1").Font.Size = 16
            ExHoja.Range("a1: " & x & NRow + 1).HorizontalAlignment = 3
            ExHoja.Range("a1: " & x & NRow + 1).Borders.Weight = Excel.XlBorderWeight.xlThin
            ExHoja.Columns.AutoFit()
            ExHoja.Range("a2").Select()
            exApp.ActiveWindow.FreezePanes = True





            'ExHoja.Rows.Item(1).font.bold = 1
            'ExHoja.Rows.Item(1).Interior.ColorIndex = 6
            'ExHoja.Rows.Item(1).horizontalalignment = 3
            'ExHoja.Columns.AutoFit()
            'ExHoja.Columns.HorizontalAlignment = 2


            'ExHoja.Columns.AutoFit()
            'ExHoja.Columns.Item(1).horizontalalignment = 3
            'ExHoja.Columns.Item(5).horizontalalignment = 3
            'ExHoja.Columns.Item(6).horizontalalignment = 3
            'ExHoja.Columns.Item(7).horizontalalignment = 3
            'ExHoja.Columns.Item(8).horizontalalignment = 3
            'ExHoja.Columns.Item(9).horizontalalignment = 3
            'ExHoja.Columns(1).Insert()
            'ExHoja.Range("a1").ColumnWidth = 2

            'ExHoja.PageSetup.PrintTitleRows = "$1:$5"
            'ExHoja.PageSetup.PrintTitleColumns = ""


            exApp.Application.Visible = True
            ExHoja = Nothing
            ExLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox("Error de Datos al Exportar a Excel. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Información.")
            Return (False)
        End Try
        Return (True)
    End Function
    Function EquivalenciaUnidad(idIngrediente As String, CantIng As Decimal, UnidadIng As String) As Decimal
        Dim UnidadBase As String = ""
        Dim UnidadProd As String = ""
        Dim UnidadCap As String = ""
        Dim Cantidad As Decimal = 0
        Dim Capacidad As Decimal = 0
        Dim TipoFactorAlt As String = ""
        Dim CantTotal As Decimal = 0
        Dim UnidadX As String = ""

        If Conectar4() Then
            Dim Comando4 As New SqlCommand("Select * FROM VNewProducto WHERE idProducto=" & idIngrediente, CNN4)
            Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
            Do While DR4.Read()
                UnidadProd = DR4("Unidad")
                UnidadCap = DR4("UnidadCapacidad")
                Capacidad = DR4("Capacidad")
                TipoFactorAlt = DR4("TipoFactorAlt").ToString
            Loop
            DR4.Close()
        End If
        Desconectar4()

        UnidadBase = UnidadCap
        UnidadX = UnidadIng
        Cantidad = CantIng

        If (UnidadX = UnidadProd) Then
            Return (Format(Cantidad, "##,##0.00"))
            Exit Function
        Else
            If (UnidadX = UnidadCap) Then
                Select Case UnidadCap
                    Case "Kilogramos", "Litros"
                        Select Case UnidadProd
                            Case "Gramos", "Mililitros"
                                CantTotal = Format(Cantidad * 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End Select
                    Case "Gramos", "Mililitros"
                        Select Case UnidadProd
                            Case "Kilogramos", "Litros"
                                CantTotal = Format(Cantidad / 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End Select
                    Case Else
                        If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                            If (UnidadBase = "Cartón") Then
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                            Else
                                CantTotal = Format(Cantidad, "##,##0.00")
                            End If
                        Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End If
                End Select
                Return (Format(CantTotal, "##,##0.00"))
                Exit Function
            Else
                Select Case UnidadX
                    Case "Kilogramos", "Litros"
                        Select Case UnidadBase
                            Case "Gramos", "Mililitros"
                                CantTotal = Format(Cantidad * 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End Select
                    Case "Gramos", "Mililitros"
                        Select Case UnidadBase
                            Case "Kilogramos", "Litros"
                                CantTotal = Format(Cantidad / 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End Select
                    Case Else
                        If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                            If (UnidadBase = "Cartón") Then
                                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                            Else
                                CantTotal = Format(Cantidad, "##,##0.00")
                            End If
                        Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        End If
                End Select

                Select Case UnidadCap
                    Case "Kilogramos", "Litros"
                        Select Case UnidadProd
                            Case "Gramos", "Mililitros"
                                CantTotal = Format(CantTotal * 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(CantTotal / Capacidad, "##,##0.00")
                        End Select
                    Case "Gramos", "Mililitros"
                        Select Case UnidadProd
                            Case "Kilogramos", "Litros"
                                CantTotal = Format(CantTotal / 1000, "##,##0.00")
                            Case Else
                                CantTotal = Format(CantTotal / Capacidad, "##,##0.00")
                        End Select
                    Case Else
                        If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                            If (UnidadBase = "Cartón") Then
                                CantTotal = Format(CantTotal / Capacidad, "##,##0.00")
                            Else
                                CantTotal = Format(CantTotal, "##,##0.00")
                            End If
                        Else
                            CantTotal = Format(CantTotal / Capacidad, "##,##0.00")
                        End If
                End Select
                Return (Format(CantTotal, "##,##0.00"))
                Exit Function
            End If
        End If






        '    Select Case UnidadX
        '        Case "Kilogramos", "Litros"
        '            Select Case UnidadBase
        '                Case "Gramos", "Mililitros"
        '                    CantTotal = Format(Cantidad * 1000, "##,##0.00")
        '                Case Else
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End Select
        '        Case "Gramos", "Mililitros"
        '            Select Case UnidadBase
        '                Case "Kilogramos", "Litros"
        '                    CantTotal = Format(Cantidad / 1000, "##,##0.00")
        '                Case Else
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End Select
        '        Case Else
        '            If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
        '                If (UnidadBase = "Cartón") Then
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '                Else
        '                    CantTotal = Format(Cantidad, "##,##0.00")
        '                End If
        '            Else
        '                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End If
        '    End Select
        'End If

        'UnidadBase = UnidadProd
        'UnidadX = UnidadCap
        'Cantidad = CantTotal

        'If (UnidadBase = UnidadX) Then
        '    CantTotal = Format(Cantidad, "##,##0.00")
        'Else
        '    Select Case UnidadX
        '        Case "Kilogramos", "Litros"
        '            Select Case UnidadBase
        '                Case "Gramos", "Mililitros"
        '                    CantTotal = Format(Cantidad * 1000, "##,##0.00")
        '                Case Else
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End Select
        '        Case "Gramos", "Mililitros"
        '            Select Case UnidadBase
        '                Case "Kilogramos", "Litros"
        '                    CantTotal = Format(Cantidad / 1000, "##,##0.00")
        '                Case Else
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End Select
        '        Case Else
        '            If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
        '                If (UnidadBase = "Cartón") Then
        '                    CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '                Else
        '                    CantTotal = Format(Cantidad, "##,##0.00")
        '                End If
        '            Else
        '                CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
        '            End If
        '    End Select
        'End If
        'Return (CantTotal)
    End Function
    Function CambioUnidad(idIngrediente As String, CantIng As Decimal, UnidadIng As String) As Decimal
        Dim UnidadBase As String = ""
        Dim UnidadProd As String = ""
        Dim UnidadCap As String = ""
        Dim Cantidad As Decimal
        Dim Capacidad As Decimal
        Dim TipoFactorAlt As String
        Dim CantTotal As Decimal = 0
        Dim UnidadX As String = ""

        If Conectar4() Then
            Dim Comando4 As New SqlCommand("Select * FROM VNewProducto WHERE idProducto=" & idIngrediente, CNN4)
            Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
            Do While DR4.Read()
                UnidadProd = DR4("Unidad")
                UnidadCap = DR4("UnidadCapacidad")
                Capacidad = DR4("Capacidad")
                TipoFactorAlt = DR4("TipoFactorAlt").ToString
            Loop
            DR4.Close()
        End If
        Desconectar4()

        UnidadBase = UnidadCap
        UnidadX = UnidadIng
        Cantidad = CantIng

        If (UnidadBase = UnidadX) Then
            CantTotal = Format(Cantidad, "##,##0.00")
        Else
            Select Case UnidadX
                Case "Kilogramos", "Litros"
                    Select Case UnidadBase
                        Case "Gramos", "Mililitros"
                            CantTotal = Format(Cantidad * 1000, "##,##0.00")
                        Case Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End Select
                Case "Gramos", "Mililitros"
                    Select Case UnidadBase
                        Case "Kilogramos", "Litros"
                            CantTotal = Format(Cantidad / 1000, "##,##0.00")
                        Case Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End Select
                Case Else
                    If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                        If (UnidadBase = "Cartón") Then
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        Else
                            CantTotal = Format(Cantidad, "##,##0.00")
                        End If
                    Else
                        CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End If
            End Select
        End If

        UnidadBase = UnidadProd
        UnidadX = UnidadCap
        Cantidad = CantTotal

        If (UnidadBase = UnidadX) Then
            CantTotal = Format(Cantidad, "##,##0.00")
        Else
            Select Case UnidadX
                Case "Kilogramos", "Litros"
                    Select Case UnidadBase
                        Case "Gramos", "Mililitros"
                            CantTotal = Format(Cantidad * 1000, "##,##0.00")
                        Case Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End Select
                Case "Gramos", "Mililitros"
                    Select Case UnidadBase
                        Case "Kilogramos", "Litros"
                            CantTotal = Format(Cantidad / 1000, "##,##0.00")
                        Case Else
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End Select
                Case Else
                    If (UnidadBase = TomarPalabra(TipoFactorAlt)) Then
                        If (UnidadBase = "Cartón") Then
                            CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                        Else
                            CantTotal = Format(Cantidad, "##,##0.00")
                        End If
                    Else
                        CantTotal = Format(Cantidad / Capacidad, "##,##0.00")
                    End If
            End Select
        End If
        Return (CantTotal)
    End Function

    Function ExisteStock(idProductoX As String, idDepartamento As Integer) As Boolean
        Dim Valor As Boolean = False
        If (Conectar4()) Then
            Try
                Dim Comando4 As New SqlCommand("SELECT Stock FROM TStockporDepartamento WHERE idProducto=@idProductoX AND idDepartamento=@idDepartamento", CNN4)
                Comando4.Parameters.Add(New SqlParameter("@idProductoX", idProductoX))
                Comando4.Parameters.Add(New SqlParameter("@idDepartamento", idDepartamento))
                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                If (DR4.Read) Then
                    Valor = True
                Else
                    Valor = False
                End If
                DR4.Close()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Detalle de los Ingredientes de la Producción.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar4()
            End Try
        End If
        Desconectar4()
        Return (Valor)
    End Function

    Public Sub TransferirInsumoProducto(idIngrediente As String, CantidadIng As Decimal, UnidadIng As String, idDeptoTransf As Integer, idDeptorecibe As Integer, idCI As Integer)
        '    Dim CantIngFinal As Decimal = 1
        'CantIngFinal = CambioUnidad(idIngrediente, CantidadIng, UnidadIng)

        If (Conectar5()) Then
            '   Dim tranx As SqlTransaction = CNN5.BeginTransaction
            Dim Comando5 As New SqlCommand("UPDATE TStockporDepartamento SET Stock=stock WHERE idProducto=@idProductoy AND idDepartamento=@idDepartamentoy", CNN5)
            Comando5.Parameters.Add(New SqlParameter("@idDepartamentoy", idDeptoTransf))
            Comando5.Parameters.Add(New SqlParameter("@idProductoy", idIngrediente))
            '     Comando5.Transaction = tranx
            Try
                Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                DR5.Close()

                If (ExisteStock(idIngrediente, idDeptoTransf) = False) Then
                    Comando5.CommandText = "INSERT INTO TStockporDepartamento (idProducto, idProviene, idDepartamento, Stock, idCategoriaInterna)values (@idProducto1, -1, @idDepartamento1, @Stock1, @idCategoriaInterna1)"
                    Comando5.Parameters.Add(New SqlParameter("@idProducto1", idIngrediente))
                    Comando5.Parameters.Add(New SqlParameter("@idDepartamento1", idDeptoTransf))
                    Comando5.Parameters.Add(New SqlParameter("@Stock1", 0))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoriaInterna1", idCI))
                    '  Comando5.Transaction = tranx
                    DR5 = Comando5.ExecuteReader()
                    DR5.Close()
                End If

                Comando5.CommandText = "UPDATE TStockporDepartamento SET Stock=(SELECT Stock FROM TStockporDepartamento WHERE idProducto=@idProducto2 and idDepartamento=@idDepartamento2)-@Stock2 WHERE idProducto=@idProducto2 AND idDepartamento=@idDepartamento2"
                Comando5.Parameters.Add(New SqlParameter("@Stock2", CantidadIng))
                Comando5.Parameters.Add(New SqlParameter("@idDepartamento2", idDeptoTransf))
                Comando5.Parameters.Add(New SqlParameter("@idProducto2", idIngrediente))
                DR5 = Comando5.ExecuteReader()
                DR5.Close()

                If (ExisteStock(idIngrediente, idDeptorecibe) = False) Then
                    Comando5.CommandText = "INSERT INTO TStockporDepartamento (idProducto, idProviene, idDepartamento, Stock, idCategoriaInterna)values (@idProducto3, -1, @idDepartamento3, @Stock3, @idCategoriaInterna3)"
                    Comando5.Parameters.Add(New SqlParameter("@idProducto3", idIngrediente))
                    Comando5.Parameters.Add(New SqlParameter("@idDepartamento3", idDeptorecibe))
                    Comando5.Parameters.Add(New SqlParameter("@Stock3", 0))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoriaInterna3", idCI))
                    DR5 = Comando5.ExecuteReader()
                    DR5.Close()
                End If

                Comando5.CommandText = "UPDATE TStockporDepartamento SET Stock=(SELECT Stock FROM TStockporDepartamento WHERE idProducto=@idProductoXX and idDepartamento=@idDepartamentoXX)+@StockXX WHERE idProducto=@idProductoXX AND idDepartamento=@idDepartamentoXX"
                Comando5.Parameters.Add(New SqlParameter("@StockXX", CantidadIng))
                Comando5.Parameters.Add(New SqlParameter("@idDepartamentoXX", idDeptorecibe))
                Comando5.Parameters.Add(New SqlParameter("@idProductoXX", idIngrediente))
                DR5 = Comando5.ExecuteReader()
                DR5.Close()
                '   tranx.Commit()
            Catch ex As Exception
                '    tranx.Rollback()
                MsgBox("Error al Transferir los Detalle de los Ingredientes de la Producción.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar5()
                ErrorTrans = True
            End Try
        End If

        Desconectar5()

    End Sub


End Module

