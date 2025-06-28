Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FBalanza
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim Disponible As Decimal = 0
    Dim BotonActivo As Integer = 0
    Dim Categoria As String = ""
    Dim idCategoria As Integer = 0
    Dim Venta As String = "Detal"
    Dim Despacho As String = "Local"
    Dim PorcMD As Decimal = 0
    Dim PorcCI As Decimal = 0
    Dim PorcVN As Decimal = 0
    Public Sub GuardarDetalleVenta(Codigo As String, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, PrecioD As Decimal, SubTotal As Decimal, SubTotalD As Decimal, Categoria As String, PesoReal As Decimal, Descontar As Boolean, VIVAV As Decimal, PorcIVAV As Decimal, PorcIVAVD As Decimal, Total As Decimal, TotalD As Decimal, Devolucion As Boolean, PosVenta As Boolean, DatosPosVenta As String)
        If (Conectar()) Then
            Dim tran As SqlTransaction = CNN.BeginTransaction
            Dim Comando As New SqlCommand("INSERT INTO TDetalleVenta(idVenta, idProducto,Cantidad,Unidad,TipoPrecio,Precio,PrecioD,PrecioProyD,SubTotal,SubTotalD,Total,TotalD,TotalProyD,Categoria,PesoReal,Costo2,Costo2D,PorcIVAV,PorcIVAVD, VIVAV, Devolucion, AlMayor, CodDev, DevActiva,TipoDesp,PosVenta,DatosPosVenta, Delivery, VendedorPropina, PropinaOk) VALUES(@idVenta, @idProducto,@Cantidad,@Unidad, @TipoPrecio,@Precio,@PrecioD,@PrecioProyD,@SubTotal,@SubTotalD,@Total,@TotalD,@TotalProyD,@Categoria,@PesoReal, @Costo2, @Costo2D,@PorcIVAV,@PorcIVAVD, @VIVAV, @Devolucion, @AlMayor, @CodDev, @DevActiva, @TipoDesp,@PosVenta,@DatosPosVenta, @Delivery, @VendedorPropina, @PropinaOk)  SELECT SCOPE_IDENTITY() AS idDetVenta", CNN)
            Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
            Comando.Parameters.Add(New SqlParameter("@idProducto", Codigo))
            Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
            Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
            Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
            Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
            Comando.Parameters.Add(New SqlParameter("@PrecioD", PrecioD))
            Comando.Parameters.Add(New SqlParameter("@SubTotal", SubTotal))
            Comando.Parameters.Add(New SqlParameter("@SubTotalD", SubTotalD))
            Comando.Parameters.Add(New SqlParameter("@Total", Total))
            Comando.Parameters.Add(New SqlParameter("@TotalD", TotalD))
            Comando.Parameters.Add(New SqlParameter("@PrecioProyD", Precio / BsXDolar))
            Comando.Parameters.Add(New SqlParameter("@TotalProyD", Total / BsXDolar))
            Comando.Parameters.Add(New SqlParameter("@Categoria", Categoria))
            Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
            Comando.Parameters.Add(New SqlParameter("@Costo2", CostoProd))
            Comando.Parameters.Add(New SqlParameter("@Costo2D", CostoDProd))
            Comando.Parameters.Add(New SqlParameter("@PorcIVAV", PorcIVAV)) ' Este se deberia llamar ValorIVAV
            Comando.Parameters.Add(New SqlParameter("@PorcIVAVD", PorcIVAVD)) ' Este se deberia llamar ValorIVAVD
            Comando.Parameters.Add(New SqlParameter("@VIVAV", VIVAV)) ' Este es el porcentaje del IVAV
            Comando.Parameters.Add(New SqlParameter("@Devolucion", Devolucion))
            If (Venta = "Mayor") Then
                Comando.Parameters.Add(New SqlParameter("@AlMayor", True))
            Else
                Comando.Parameters.Add(New SqlParameter("@AlMayor", False))
            End If
            Comando.Parameters.Add(New SqlParameter("@TipoDesp", Despacho))
            Comando.Parameters.Add(New SqlParameter("@CodDev", 0))
            Comando.Parameters.Add(New SqlParameter("@DevActiva", False))

            Comando.Parameters.Add(New SqlParameter("@PosVenta", PosVenta))
            Comando.Parameters.Add(New SqlParameter("@DatosPosVenta", DatosPosVenta))
            Comando.Parameters.Add(New SqlParameter("@Delivery", Deli))
            Comando.Parameters.Add(New SqlParameter("@VendedorPropina", VendedorPropina))
            Comando.Parameters.Add(New SqlParameter("@PropinaOk", 0))

            Comando.Transaction = tran
            Try
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    CodDetalleVenta = DR("idDetVenta")
                End If
                DR.Close()
                If (Descontar = True) Then ' Si no es Excepcion descuento del stock
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock, StockDiario=(SELECT StockDiario FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
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
                tran.Commit()
                Desconectar()
            Catch ex As Exception
                tran.Rollback()
                MsgBox("Error al Guardar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

    Private Sub ActualizarDetalleVenta(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, PrecioD As Decimal, SubTotal As Decimal, SubTotalD As Decimal, Total As Decimal, TotalD As Decimal, PesoReal As Decimal, Descontar As Boolean, CodR As Integer, PorcIVAV As Decimal, PorcIVAVD As Decimal, VIVAV As Decimal, PosVenta As Boolean, DatosPosVenta As String)
        If (Conectar()) Then
            Dim tran As SqlTransaction = CNN.BeginTransaction
            Dim Comando As New SqlCommand("UPDATE TDetalleVenta SET Cantidad=@Cantidad,Unidad=@Unidad,TipoPrecio=@TipoPrecio,Precio=@Precio,PrecioD=@PrecioD,SubTotal=@SubTotal,SubTotalD=@SubTotalD,PrecioProyD=@PrecioProyD,Total=@Total,TotalD=@TotalD,TotalProyD=@TotalProyD,PesoReal=@PesoReal, Costo2=@Costo2, Costo2D=@Costo2D,PorcIVAV=@PorcIVAV,PorcIVAVD=@PorcIVAVD, VIVAV=@VIVAV, AlMayor=@AlMayor, TipoDesp=@TipoDesp, PosVenta=@PosVenta, DatosPosVenta=@DatosPosVenta, Delivery=@Delivery, VendedorPropina=@VendedorPropina WHERE idDetVenta=" & CodR, CNN)
            Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
            Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
            Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
            Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
            Comando.Parameters.Add(New SqlParameter("@PrecioD", PrecioD))
            Comando.Parameters.Add(New SqlParameter("@SubTotal", SubTotal))
            Comando.Parameters.Add(New SqlParameter("@SubTotalD", SubTotalD))
            Comando.Parameters.Add(New SqlParameter("@PrecioProyD", Precio / BsXDolar))
            Comando.Parameters.Add(New SqlParameter("@TotalProyD", Total / BsXDolar))
            Comando.Parameters.Add(New SqlParameter("@Total", Total))
            Comando.Parameters.Add(New SqlParameter("@TotalD", TotalD))
            Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
            Comando.Parameters.Add(New SqlParameter("@Costo2", CostoProd))
            Comando.Parameters.Add(New SqlParameter("@Costo2D", CostoDProd))
            Comando.Parameters.Add(New SqlParameter("@PorcIVAV", PorcIVAV))
            Comando.Parameters.Add(New SqlParameter("@PorcIVAVD", PorcIVAVD))
            Comando.Parameters.Add(New SqlParameter("@VIVAV", VIVAV))
            '  Comando.Parameters.Add(New SqlParameter("@Devolucion", Devolucion))
            If (Venta = "Mayor") Then
                Comando.Parameters.Add(New SqlParameter("@AlMayor", True))
            Else
                Comando.Parameters.Add(New SqlParameter("@AlMayor", False))
            End If
            Comando.Parameters.Add(New SqlParameter("@TipoDesp", Despacho))

            Comando.Parameters.Add(New SqlParameter("@PosVenta", PosVenta))
            Comando.Parameters.Add(New SqlParameter("@DatosPosVenta", DatosPosVenta))
            Comando.Parameters.Add(New SqlParameter("@Delivery", Deli))
            Comando.Parameters.Add(New SqlParameter("@VendedorPropina", VendedorPropina))

            Comando.Transaction = tran
            Try
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                If (Descontar = True) Then
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock,StockDiario=(SELECT StockDiario FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
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
                tran.Commit()
                Desconectar()
            Catch ex As Exception
                tran.Rollback()
                MsgBox("Error al Actualizar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub


    Public Sub GuardarDetalleVentaFeria(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, Categoria As String, PesoReal As Decimal, Descontar As Boolean)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TDetVentaFerias(idVenta, idProducto,Cantidad,Unidad,TipoPrecio,Precio,Total,Categoria,PesoReal,TipoPago, Referencia, PorcRecargo, TRecargo, Efectivo, Tarjeta, Credito, TDolar, BsDolar, TotalV) VALUES(@idVenta, @idProducto,@Cantidad,@Unidad, @TipoPrecio,@Precio,@Total,@Categoria,@PesoReal, @TipoPago, @Referencia, @PorcRecargo, @TRecargo, @Efectivo, @Tarjeta, @Credito, @TDolar, @BsDolar, @TotalV)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idVenta", CodVenta))
                Comando.Parameters.Add(New SqlParameter("@idProducto", Codigo))
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@Categoria", Categoria))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
                Select Case TipoPrecio
                    Case Is = 1, 2, 3, 4
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", "Tarjeta"))
                    Case Is = 9
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                    Case Else
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", ""))
                End Select
                Comando.Parameters.Add(New SqlParameter("@Referencia", 0))
                Comando.Parameters.Add(New SqlParameter("@PorcRecargo", 0))
                Comando.Parameters.Add(New SqlParameter("@TRecargo", 0))
                Comando.Parameters.Add(New SqlParameter("@Efectivo", 0))
                Comando.Parameters.Add(New SqlParameter("@Tarjeta", 0))
                Comando.Parameters.Add(New SqlParameter("@Credito", 0))
                Comando.Parameters.Add(New SqlParameter("@BsDolar", 0))
                Comando.Parameters.Add(New SqlParameter("@TDolar", 0))
                Comando.Parameters.Add(New SqlParameter("@TotalV", 0))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Comando.CommandText = "SELECT TOP 1 idDetVenta FROM TDetalleVentaFerias ORDER BY idDetVenta DESC"
                DR = Comando.ExecuteReader()
                If (DR.Read) Then
                    CodDetalleVenta = DR(0)
                Else
                    CodDetalleVenta = 0
                End If
                DR.Close()
                If (Descontar = True) Then ' Si no es Excepcion descuento del stock
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock, StockDiario=(SELECT StockDiario FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
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
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Public Sub GuardarDetalleVentaPB(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, Categoria As String, PesoReal As Decimal, Descontar As Boolean)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TDetalleVenta(idProducto,Cantidad,Unidad,TipoPrecio,Precio,Total,Categoria,PesoReal) VALUES(@idProducto,@Cantidad,@Unidad, @TipoPrecio,@Precio,@Total,@Categoria,@PesoReal)", CNN)
                Comando.Parameters.Add(New SqlParameter("@idProducto", Codigo))
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@Categoria", Categoria))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Comando.CommandText = "SELECT TOP 1 idDetVenta FROM TDetalleVenta ORDER BY idDetVenta DESC"
                DR = Comando.ExecuteReader()
                If (DR.Read) Then
                    CodDetalleVenta = DR(0)
                Else
                    CodDetalleVenta = 0
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
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

 
    Private Sub ActualizarDetalleVentaFerias(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, PesoReal As Decimal, Descontar As Boolean, CodR As Integer)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TDetVentaFerias SET Cantidad=@Cantidad,Unidad=@Unidad,TipoPrecio=@TipoPrecio,Precio=@Precio,Total=@Total,PesoReal=@PesoReal, TipoPago=@TipoPago WHERE idDetVenta=" & CodR, CNN)
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
                Select Case TipoPrecio
                    Case Is = 1, 2, 3, 4
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", "Tarjeta"))
                    Case Is = 9
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                    Case Else
                        Comando.Parameters.Add(New SqlParameter("@TipoPago", ""))
                End Select
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                If (Descontar = True) Then
                    Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock,StockDiario=(SELECT StockDiario FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
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
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub ActualizarDetalleVentaPB(Codigo As Integer, Peso As Decimal, Unidad As String, TipoPrecio As Integer, Precio As Decimal, Total As Decimal, PesoReal As Decimal, Descontar As Boolean, CodR As Integer)
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TDetalleVenta SET Cantidad=@Cantidad,Unidad=@Unidad,TipoPrecio=@TipoPrecio,Precio=@Precio,Total=@Total,PesoReal=@PesoReal WHERE idDetVenta=" & CodR, CNN)
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Peso))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Unidad))
                Comando.Parameters.Add(New SqlParameter("@TipoPrecio", TipoPrecio))
                Comando.Parameters.Add(New SqlParameter("@Precio", Precio))
                Comando.Parameters.Add(New SqlParameter("@Total", Total))
                Comando.Parameters.Add(New SqlParameter("@PesoReal", PesoReal))
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
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Actualizar los Datos del Detalle de la Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

    'Private Sub DescontarIngredientes(Descontar As Boolean, Guardar As Boolean, CodR As Integer)
    '    Dim CantVender As Decimal = 0
    '    Dim J As Integer = 0
    '    If Conectar2() Then
    '        Dim Comando2 As New SqlCommand("Select idIngrediente, Ingrediente, Cantidad, Unidad FROM VIngredientes WHERE idProducto=" & Me.TPeso.Tag, CNN2)
    '        Dim DatosIng As SqlDataReader = Comando2.ExecuteReader()
    '        Do While DatosIng.Read()
    '            J = J + 1
    '            If Conectar() Then
    '                Dim Comando As New SqlCommand("Select Stock, Unidad FROM VNewProducto WHERE idProducto=" & DatosIng("idIngrediente"), CNN)
    '                Dim DatosProd As SqlDataReader = Comando.ExecuteReader()
    '                If (DatosProd.Read()) Then
    '                    If (DatosIng("Unidad") = DatosProd("Unidad")) Then
    '                        CantVender = PesoEquivalente(DatosIng("Cantidad"), DatosIng("Unidad"), DatosProd("Unidad"))
    '                    Else
    '                        CantVender = Me.TPeso.Text * PesoEquivalente(DatosIng("Cantidad"), DatosIng("Unidad"), DatosProd("Unidad"))
    '                    End If
    '                    DatosProd.Close()

    '                    If (Descontar = True) Then ' Si no es Excepcion descuento del stock
    '                        Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & DatosIng("idIngrediente") & ")-@Stock WHERE idProducto=" & DatosIng("idIngrediente")
    '                        Dim Desc As Decimal = 0
    '                        If (FactorFileteado > 0) Then
    '                            Desc = (FactorFileteado * CantVender) + CantVender
    '                        Else
    '                            Desc = CantVender
    '                        End If
    '                        Comando.Parameters.Add(New SqlParameter("@Stock", Desc))
    '                        DatosProd = Comando.ExecuteReader()
    '                    End If
    '                    DatosProd.Close()
    '                    Desconectar()








    '                    'Desconectar()
    '                    'If (Guardar = True) Then
    '                    '    GuardarDetalleVentaPB(DatosIng("idIngrediente"), CantVender, DatosIng("Unidad"), Me.BTipoPrecio.Tag, 0, 0, "Ingrediente", CantVender, Descontar)
    '                    '    FCajaNew.DGArticulos.Rows.Add(DatosIng("idIngrediente"), CantVender, "  " & Trim(DatosIng(1)), DatosIng("Unidad"), Me.BTipoPrecio.Tag, 0, 0, "Ingrediente", CantVender, CodDetalleVenta, 0, "Ingrediente")
    '                    '    FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Green
    '                    'Else
    '                    '    ActualizarDetalleVentaPB(DatosIng("idIngrediente"), CantVender, DatosIng("Unidad"), Convert.ToInt16(Me.BTipoPrecio.Tag), 0, 0, CantVender, True, CodR)
    '                    '    FCajaNew.DGArticulos.Item(1, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = CantVender
    '                    '    FCajaNew.DGArticulos.Item(3, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = DatosIng("Unidad")
    '                    '    FCajaNew.DGArticulos.Item(4, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = Me.BTipoPrecio.Tag
    '                    '    FCajaNew.DGArticulos.Item(5, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = 0
    '                    '    FCajaNew.DGArticulos.Item(6, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = 0
    '                    '    FCajaNew.DGArticulos.Item(8, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = CantVender
    '                    '    FCajaNew.DGArticulos.Item(10, FCajaNew.DGArticulos.CurrentRow.Index + J).Value = 0
    '                    'End If
    '                End If
    '            End If
    '        Loop
    '        DatosIng.Close()
    '        Desconectar2
    '    End If
    'End Sub
    'Private Sub DescontarIngredientesReserva(Descontar As Boolean, Guardar As Boolean, CodR As Integer)
    '    Dim CantVender As Decimal = 0
    '    Dim J As Integer = 0
    '    If Conectar2() Then
    '        Dim Comando2 As New SqlCommand("Select Codigo, Ingrediente, Cantidad, Unidad FROM TIngredientes WHERE idProducto=" & Me.TPeso.Tag, CNN2)
    '        Dim DatosIng As SqlDataReader = Comando2.ExecuteReader()
    '        Do While DatosIng.Read()
    '            J = J + 1
    '            If Conectar() Then
    '                Dim Comando As New SqlCommand("Select Stock, Unidad FROM TNewProducto WHERE idProducto=" & DatosIng(0), CNN)
    '                Dim DatosProd As SqlDataReader = Comando.ExecuteReader()
    '                If (DatosProd.Read()) Then
    '                    If (Me.CUnidad.Text = DatosProd(1)) Then
    '                        If (DatosIng(3) = DatosProd(1)) Then
    '                            CantVender = Me.TPeso.Text * DatosIng(2)
    '                        Else
    '                            CantVender = Me.TPeso.Text * PesoEquivalente(DatosIng(2), DatosIng(3), Me.CUnidad.Text)
    '                        End If
    '                    Else
    '                        If (DatosIng(3) = DatosProd(1)) Then
    '                            CantVender = PesoEquivalente(Me.TPeso.Text, Me.CUnidad.Text, DatosProd(1))
    '                        Else
    '                            CantVender = Me.TPeso.Text * PesoEquivalente(DatosIng(2), DatosIng(3), DatosProd(1))
    '                        End If
    '                    End If
    '                    DatosProd.Close()
    '                    Desconectar()
    '                    If (Guardar = True) Then
    '                        GuardarDetalleVentaPA(DatosIng(0), DatosIng(1), CantVender, DatosIng(3), Me.BTipoPrecio.Tag, 0, 0, "Ingrediente", CantVender, Descontar, DatosIng(0))
    '                        FPedido.DGListadoCompra.Rows.Add(DatosIng(0), "  " & Trim(DatosIng(1)), CantVender, DatosIng(3), Me.BTipoPrecio.Tag, 0, 0, "Ingrediente", CantVender, CodDetalleVenta)
    '                        FPedido.DGListadoCompra.Rows(FPedido.DGListadoCompra.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Green
    '                    Else
    '                        ActualizarDetalleVentaPA(DatosIng(0), CantVender, DatosIng(3), Convert.ToInt16(Me.BTipoPrecio.Tag), 0, 0, CantVender, True, CodR, DatosIng(0))
    '                        FPedido.DGListadoCompra.Item(2, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = CantVender
    '                        FPedido.DGListadoCompra.Item(3, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = DatosIng(3)
    '                        FPedido.DGListadoCompra.Item(4, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = Me.BTipoPrecio.Tag
    '                        FPedido.DGListadoCompra.Item(5, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = 0
    '                        FPedido.DGListadoCompra.Item(6, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = 0
    '                        FPedido.DGListadoCompra.Item(8, FPedido.DGListadoCompra.CurrentRow.Index + J).Value = CantVender
    '                    End If
    '                End If
    '            End If
    '        Loop
    '        DatosIng.Close()
    '        Desconectar2
    '    End If
    'End Sub

    Function ValidarStock() As Boolean
        Dim Valor As Boolean = False
        If (Convert.ToDecimal(Me.TStock.Text) > 0) Then
            Valor = True
        Else
            If (TipoProducto = "Terminados") Then
                If (idCategoria = 47) Then
                    Valor = True
                Else
                    Valor = False
                End If
            Else
                Valor = True
            End If
            Return (Valor)
        End If
    End Function
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Dim PrecioCero As Decimal = IIf(Me.TPrecio.Text = "", 0, Me.TPrecio.Text)
        Dim Cantidad As Decimal = IIf(Me.TPeso.Text = "", 0, Me.TPeso.Text)
        PrecioCero = PrecioCero * Cantidad
        If (PrecioCero <> 0) Then
            Me.TPeso.Text = IIf(Me.TPeso.Text = "", 0, Me.TPeso.Text)
            '   If ValidarStock() Then
            If (Mid(Me.TPeso.Text, Len(Me.TPeso.Text), 1) = ",") Then
                Me.TPeso.Text = Mid(Me.TPeso.Text, 1, Len(Me.TPeso.Text) - 1)
            End If
            '  Dim PesoReal As Decimal = CalcularPesoReal(TPeso.Tag, CUnidad.Text, TPeso.Text)
            Dim PesoReal As Decimal = Me.TPeso.Text
            PesoProd = Convert.ToDecimal(Me.TPeso.Text)
            Dim Tipo As String = ""
            If (CodProducto = "4716902") Then
                VendedorPropina = Me.CVendedor.SelectedValue
            Else
                VendedorPropina = 0
            End If
            'Select Case VarForma
            '    Case "FCajas", "FBalanza"
            '        If (Me.TEditarTotal.Text = "") Then
            '            GuardarDetalleVenta(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TPrecioD.Text), Convert.ToDecimal(Me.TSubTotal.Text), Convert.ToDecimal(Me.TSubTotalD.Text), CatActiva, Convert.ToDecimal(Me.TPeso.Text), True, VIVAV, Me.TIVA.Text, Me.TIVAD.Text, Me.TTotal.Text, Me.TTotalD.Text, False, Me.CBPosVenta.Checked, Me.TPosVenta.Text)
            '            FCajaNew.DGArticulos.Rows.Add(Me.TPeso.Tag, Tipo & Me.LArtEjemplo.Tag, TPeso.Text, Me.CUnidad.Text, Me.BTipoPrecio.Tag, TPrecio.Text, TPrecioD.Text, TSubTotal.Text, TSubTotalD.Text, VIVAV, Me.TIVA.Text, Me.TIVAD.Text, Me.TTotal.Text, Me.TTotalD.Text, CatActiva, PesoReal, CodDetalleVenta, False, Me.RBMayor.Checked, Despacho, 0, False, Me.CBPosVenta.Checked, Me.TPosVenta.Text)
            '            FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Black
            '            If (FCajaNew.DGArticulos.Item("AlMayor", FCajaNew.DGArticulos.RowCount - 1).Value = True) Then
            '                FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.RowCount - 1).DefaultCellStyle.BackColor = Color.MediumOrchid
            '            Else
            '                FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.RowCount - 1).DefaultCellStyle.BackColor = Color.White
            '            End If

            '        Else
            '            ActualizarDetalleVenta(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TPrecioD.Text), Convert.ToDecimal(Me.TSubTotal.Text), Convert.ToDecimal(Me.TSubTotalD.Text), Convert.ToDecimal(Me.TTotal.Text), Convert.ToDecimal(Me.TTotalD.Text), PesoReal, True, Convert.ToDecimal(Me.TCodDet.Text), Me.TIVA.Text, Me.TIVAD.Text, VIVAV, Me.CBPosVenta.Checked, Me.TPosVenta.Text)
            '            FCajaNew.DGArticulos.Item("Peso", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.TPeso.Text
            '            FCajaNew.DGArticulos.Item("Unidad", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.CUnidad.Text
            '            FCajaNew.DGArticulos.Item("T_P", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.BTipoPrecio.Tag
            '            FCajaNew.DGArticulos.Item("Precio", FCajaNew.DGArticulos.CurrentRow.Index).Value = TPrecio.Text
            '            FCajaNew.DGArticulos.Item("PrecioD", FCajaNew.DGArticulos.CurrentRow.Index).Value = TPrecioD.Text
            '            FCajaNew.DGArticulos.Item("SubTotal", FCajaNew.DGArticulos.CurrentRow.Index).Value = TSubTotal.Text
            '            FCajaNew.DGArticulos.Item("SubTotalD", FCajaNew.DGArticulos.CurrentRow.Index).Value = TSubTotalD.Text
            '            FCajaNew.DGArticulos.Item("PorcIva", FCajaNew.DGArticulos.CurrentRow.Index).Value = VIVAV
            '            FCajaNew.DGArticulos.Item("ValorIva", FCajaNew.DGArticulos.CurrentRow.Index).Value = TIVA.Text
            '            FCajaNew.DGArticulos.Item("ValorIvaD", FCajaNew.DGArticulos.CurrentRow.Index).Value = TIVAD.Text
            '            FCajaNew.DGArticulos.Item("Total", FCajaNew.DGArticulos.CurrentRow.Index).Value = TTotal.Text
            '            FCajaNew.DGArticulos.Item("Dolar", FCajaNew.DGArticulos.CurrentRow.Index).Value = TTotalD.Text
            '            FCajaNew.DGArticulos.Item("PesoReal", FCajaNew.DGArticulos.CurrentRow.Index).Value = PesoReal
            '            FCajaNew.DGArticulos.Item("AlMayor", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.RBMayor.Checked
            '            FCajaNew.DGArticulos.Item("Despacho", FCajaNew.DGArticulos.CurrentRow.Index).Value = Despacho
            '            FCajaNew.DGArticulos.Item("PosVenta", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.CBPosVenta.Checked
            '            FCajaNew.DGArticulos.Item("DPosVenta", FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.TPosVenta.Text


            '            If (Me.RBMayor.Checked = True) Then
            '                FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.CurrentRow.Index).DefaultCellStyle.BackColor = Color.MediumOrchid
            '            Else
            '                FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.CurrentRow.Index).DefaultCellStyle.BackColor = Color.White
            '            End If
            '        End If
            '        Me.TEditarTotal.Text = ""
            '        Me.Close()
            'End Select
            'Else
            '    MsgBox("Este Producto No Posee STOCK por Favor Verifique.", MsgBoxStyle.Information, "MarSoft: Información.")
            'End If
        Else
            MsgBox("Este Producto No Posee Precio por Favor Verifique.", MsgBoxStyle.Information, "MarSoft: Información.")
        End If
    End Sub
    Private Sub GuardarGastos(Codigo As Integer, PesoReal As Decimal)
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TGastos (CodProd,Nombre,Cantidad, Unidad, Costo, Total, GastoAsoc,ExcQuincAnt,NivRPG, TipoExcPresup, idFueraPresup, MontoExceso, Responsable) VALUES(@CodProd,@Nombre,@Cantidad, @Unidad,@Costo,@Total, @GastoAsoc,@ExcQuincAnt,@NivRPG, @TipoExcPresup, @idFueraPresup, @MontoExceso, @Responsable)", CNN)
                Comando.Parameters.Add(New SqlParameter("@CodProd", Codigo))
                Comando.Parameters.Add(New SqlParameter("@Nombre", Trim(Me.LArtEjemplo.Text)))
                Comando.Parameters.Add(New SqlParameter("@Cantidad", Convert.ToDecimal(Me.TPeso.Text)))
                Comando.Parameters.Add(New SqlParameter("@Unidad", Trim(Me.CUnidad.Text)))
                Comando.Parameters.Add(New SqlParameter("@Costo", Convert.ToDecimal(Me.TPrecio.Text)))
                Comando.Parameters.Add(New SqlParameter("@Total", Convert.ToDecimal(Me.TSubTotal.Text)))
                Comando.Parameters.Add(New SqlParameter("@GastoAsoc", 0))
                Comando.Parameters.Add(New SqlParameter("@ExcQuincAnt", 0))
                Comando.Parameters.Add(New SqlParameter("@NivRPG", 0))
                Comando.Parameters.Add(New SqlParameter("@idTipoExcPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Comando.CommandText = "UPDATE TNewProducto SET Stock=(SELECT Stock FROM TNewProducto WHERE idProducto=" & Codigo & ")-@Stock WHERE idProducto=" & Codigo
                Comando.Parameters.Add(New SqlParameter("@Stock", PesoReal))
                DR = Comando.ExecuteReader()
                Desconectar()
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al Insertar Datos del Gasto. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TPeso_KeyDown(sender As Object, e As KeyEventArgs) Handles TPeso.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            Me.BAceptar.Focus()
        End If
    End Sub

    'Private Sub TPeso_Click(sender As Object, e As EventArgs) Handles TPeso.Click
    '    'FTecladoNum.TTexto.Text = Me.TPeso.Text
    '    'FTecladoNum.ShowDialog()
    '    'If (ValRespuesta = True) Then
    '    '    Me.TPeso.Text = TextoEscrito
    '    '    Me.TPeso.SelectionStart = TPeso.Text.Length
    '    '    Me.TPeso.SelectionLength = TPeso.Text.Length
    '    '    Me.TPeso.Focus()
    '    'End If
    'End Sub

    Private Sub TPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPeso.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.BAceptar.Focus()
        End If
        If (UsaDecimal) Then
            If (e.KeyChar = ".") Then
                e.KeyChar = ","
            End If

            e.Handled = txtNumerico(TPeso, e.KeyChar, True)

        Else
            e.Handled = txtNumerico(TPeso, e.KeyChar, False)
        End If
    End Sub
    'Function CategoriaConDescuento() As Boolean
    '    Dim Valor As Boolean = False
    '    If Conectar() Then
    '        Dim Comando As New SqlCommand("SELECT id, Nombre FROM TCategoriaConDescuento WHERE id=@id", CNN)
    '        Comando.Parameters.Add(New SqlParameter("@id", idCategoria))
    '        Dim DR As SqlDataReader = Comando.ExecuteReader()
    '        If (DR.Read()) Then
    '            Valor = True
    '        End If
    '        DR.Close()
    '        Desconectar()
    '    End If
    '    Return (Valor)
    'End Function
    Function ProductoConDescuento() As Boolean
        Dim Valor As Boolean = False
        If Conectar() Then
            Dim Comando As New SqlCommand("SELECT PoseeDescuento, PorcMd, PorcCI, PorcVN FROM TNewProducto WHERE idProducto=@id", CNN)
            Comando.Parameters.Add(New SqlParameter("@id", CodProducto))
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            If (DR.Read()) Then
                If (DR("PoseeDescuento")) Then
                    Valor = True
                    PorcMD = DR("PorcMD")
                    PorcCI = DR("PorcCI")
                    PorcVN = DR("PorcVN")
                Else
                    Valor = False
                End If
            End If
            DR.Close()
            Desconectar()
        End If
        Return (Valor)
    End Function
    Private Sub LlenarVendedores()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1),LEN(Apellido))) as Nombre FROM TEmpleado WHERE Activo=1 ORDER BY Nombre ASC", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CVendedor.DataSource = DataT
                Me.CVendedor.DisplayMember = "Nombre"
                Me.CVendedor.ValueMember = "IdEmpleado"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Vendedores..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub BuscarSocio()
        If Conectar() Then
            Try
                Dim Comando As New SqlCommand("SELECT Socio FROM TEmpleado where idEmpleado=" & CodCliente, CNN)
                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                Do While DataReader.Read()
                    EsSocio = DataReader("Socio")
                Loop
                DataReader.Close()
                Desconectar()
            Catch ex As Exception
                MessageBox.Show("Error de Datos..." & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub FBalanza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Unid As String = ""
        Dim UnidIng As String = ""
        Dim CantIng As Decimal = 0
        CodProducto = Trim(Me.TPeso.Tag)
        Me.LCodigo.Text = RellenarCeros(Me.TPeso.Tag, 10)
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("SELECT Nombre FROM TUnidades", CNN)
                Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
                Me.CUnidad.Items.Clear()
                Do While DatosArt.Read()
                    Me.CUnidad.Items.Add(Trim(DatosArt(0)))
                Loop
                DatosArt.Close()
                Comando.CommandText = "SELECT Stock,Unidad,Capacidad,UnidadCapacidad, idTipoProducto, TipoProducto, Decimal,CostoCalUnid, CostoCalUnidD, Categoria, idCategoria, Nombre FROM VNewProducto WHERE idProducto=" & CodProducto
                DatosArt = Comando.ExecuteReader()
                If (DatosArt.Read() = True) Then                   
                    CostoProd = DatosArt("CostoCalUnid")
                    CostoDProd = DatosArt("CostoCalUnidD")
                    Me.TPrecio.Text = Format(CostoProd + (CostoProd * (10 / 100)), "##,##0.00")
                    Me.TPrecioD.Text = Format(CostoDProd + (CostoDProd * (10 / 100)), "##,##0.00")
                    Me.LArtEjemplo.Text = DatosArt("Nombre")
                    If (DatosArt("Stock") Is DBNull.Value) Then
                        Disponible = 0
                    Else                       
                        Disponible = DatosArt("Stock")
                        Unid = DatosArt("Unidad")
                        Me.TUnidadProd.Text = Unid
                        TipoProducto = DatosArt("TipoProducto")
                    End If
                    Categoria = DatosArt("Categoria")
                    idCategoria = DatosArt("idCategoria")
                    If (idCategoria = 47) Then
                        Deli = True
                        Disponible = 0
                    Else
                        Deli = False
                    End If
                    DatosArt.Close()
                    Comando.CommandText = "SELECT Factor FROM TArticulo WHERE idArticulo=" & ArtSeleccionado
                    DatosArt = Comando.ExecuteReader()
                    If (DatosArt.Read() = True) Then
                        If (DatosArt(0) Is DBNull.Value) Then
                            FactorFileteado = 0
                        Else
                            FactorFileteado = DatosArt(0)
                        End If
                    End If
                End If
                DatosArt.Close()
                Desconectar()
            End If
            BuscarSocio()
            If (TipoCliente) Then
                Me.BPrecio10.Visible = True
                Me.BPrecio11.Visible = True
                Me.BPrecio12.Visible = True
                If (ProductoConDescuento()) Then
                    If (EsSocio) Then
                        Me.BTipoPrecio.Visible = True
                        Me.LSinDescuento.Visible = False
                        Me.BTipoPrecio.Text = "Costo"
                        Me.BTipoPrecio.Tag = "5"
                        Me.BPrecio10.Visible = False
                        Me.BPrecio11.Visible = False
                        Me.BPrecio12.Visible = False
                        BotonActivo = 1
                    Else
                        Me.LSinDescuento.Visible = False
                        Me.BTipoPrecio.Text = "Precio 1"
                        Me.BTipoPrecio.Tag = "11"
                        BotonActivo = 3
                        Me.BTipoPrecio.Visible = True
                        Me.BPrecio10.Visible = True
                        Me.BPrecio11.Visible = True
                        Me.BPrecio12.Visible = True
                        Me.BTipoPrecio.BackColor = Color.White
                        Me.BPrecio10.BackColor = Color.White
                        Me.BPrecio12.BackColor = Color.White
                        'Me.BPrecio10.Text = "Costo + " & Format(PorcMD, "##,##0") & "%"
                        'Me.BPrecio11.Text = "Precio - " & Format(PorcVN, "##,##0") & "%"
                        'Me.BPrecio12.Text = "Precio - " & Format(PorcCI, "##,##0") & "%"
                        BPrecio11_Click(Nothing, Nothing)
                    End If
                Else

                    Me.BTipoPrecio.Text = "Precio 1"
                    Me.BTipoPrecio.Tag = "1"
                    Me.BTipoPrecio.Visible = False
                    Me.BPrecio10.Visible = False
                    Me.BPrecio11.Visible = False
                    Me.BPrecio12.Visible = False
                    Me.LSinDescuento.Visible = True
                    BotonActivo = 1


                End If
                Else
                    Me.LSinDescuento.Visible = False
                    Me.BTipoPrecio.Text = "Precio 1"
                    Me.BTipoPrecio.Tag = "1"
                    Me.BTipoPrecio.Visible = True
                    Me.BPrecio10.Visible = False
                    Me.BPrecio11.Visible = False
                    Me.BPrecio12.Visible = False
                    BotonActivo = 1
                End If
            If (CodProducto = "4716902") Then
                LlenarVendedores()
                Me.LVendedor.Visible = True
                Me.CVendedor.Visible = True
            Else
                Me.LVendedor.Visible = False
                Me.CVendedor.Visible = False
            End If

            Me.TStock.Text = VFormat(Disponible, 2)
            Me.BExcepcion.Enabled = False
            Me.BAceptar.Enabled = True
            If (Editar = "") Then
                Me.CUnidad.Text = Unid
                Me.RBDetal.Checked = True
                If (TodaVentaOnLine) Then
                    Me.RBOnline.Checked = True
                Else
                    Me.RBLocal.Checked = True
                End If
                If (TodaPosVenta) Then
                    Me.CBPosVenta.Checked = True
                Else
                    Me.CBPosVenta.Checked = False
                End If
                Me.TPosVenta.Text = ""
            Else
                Me.CUnidad.Text = Editar
                Editar = ""
            End If
            Me.TPeso.Select()
        Catch ex As Exception
            MessageBox.Show("Error al obtener Datos del Producto. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub

    'Private Sub Etiqueta_Click(sender As Object, e As EventArgs) Handles Etiqueta.Click
    '    If (Me.TPeso.Text <> "") Then
    '        Dim Forma As New FEsperarImpresion
    '        Forma.Show()
    '        Forma.Refresh()
    '        If Conectar() Then
    '            Try
    '                Adaptador = New SqlDataAdapter("SELECT * FROM TNewProducto WHERE idProducto=" & CodProducto, CNN)
    '                DataT = New DataTable
    '                Adaptador.Fill(DataT)
    '                If (Convert.ToDecimal(Me.TPeso.Text) = 0) Then
    '                    Dim Rpt As New CREtiquetaSola
    '                    Rpt.SetDataSource(DataT)
    '                    Dim impre_predeterminada As New PrinterSettings()
    '                    Rpt.PrintOptions.PrinterName = impre_predeterminada.PrinterName
    '                    Rpt.PrintToPrinter(1, False, 0, 0)
    '                Else
    '                    Dim Rpt As New CREtiquetaPrecio
    '                    Rpt.SetDataSource(DataT)
    '                    Dim Peso As Decimal = Convert.ToDecimal(Trim(Me.TPeso.Text))
    '                    Dim Precio As Decimal = Convert.ToDecimal(Trim(Me.TPrecio.Text))
    '                    Dim Total As Decimal = Convert.ToDecimal(Trim(Me.TSubTotal.Text))
    '                    Rpt.SetParameterValue("Peso", Peso)
    '                    Rpt.SetParameterValue("Precio", Precio)
    '                    Rpt.SetParameterValue("Total", Total)
    '                    Dim impre_predeterminada As New PrinterSettings()
    '                    Rpt.PrintOptions.PrinterName = impre_predeterminada.PrinterName
    '                    Rpt.PrintToPrinter(1, False, 0, 0)
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show("Error al Imprimir Reporte." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Desconectar()
    '            End Try
    '        End If
    '        Desconectar()
    '        Forma.Close()
    '    Else
    '        MsgBox("Debe Agregar el Peso.", MsgBoxStyle.Information, "MarSoft: Información.")
    '    End If
    'End Sub



    Private Sub TPeso_KeyUp(sender As Object, e As KeyEventArgs) Handles TPeso.KeyUp

    End Sub

    Private Sub TPeso_TextChanged(sender As Object, e As EventArgs) Handles TPeso.TextChanged
        ValidarComa(Me.TPeso)
        If (TPeso.Text <> "") Then
            Me.TPrecio.Text = Format(CalcularPrecio(Me.TPeso.Tag, Me.TPeso.Text, CatActiva, Me.BTipoPrecio.Tag, Me.CUnidad.Text), "##,##0.00")
            Me.TPrecioD.Text = Format(PrecioD, "##,##0.00")
            If (Me.TPrecio.Text = "") Then
                Me.TPrecio.Text = "0,00"
            End If

            Me.TSubTotal.Text = Format(Convert.ToDecimal(Me.TPeso.Text) * Convert.ToDecimal(Me.TPrecio.Text), "##,##0.00")
            Me.TSubTotalD.Text = Format(Convert.ToDecimal(Me.TPeso.Text) * Convert.ToDecimal(Me.TPrecioD.Text), "##,##0.00")

            Me.LIVA.Text = "IVA (" & VIVAV & "%):"
            Me.LIVAD.Text = "IVA $ (" & VIVAV & "%):"

            Me.TIVA.Text = Format(((Convert.ToDecimal(Me.TSubTotal.Text) * VIVAV) / 100), "##,##0.00")
            Me.TIVAD.Text = Format(((Convert.ToDecimal(Me.TSubTotalD.Text) * VIVAV) / 100), "##,##0.00")

            Me.TTotal.Text = Format(Convert.ToDecimal(Me.TSubTotal.Text) + Convert.ToDecimal(Me.TIVA.Text), "##,##0.00")
            ' Me.TTotalD.Text = Format(Convert.ToDecimal(Me.TSubTotalD.Text) + Convert.ToDecimal(Me.TIVAD.Text), "##,##0.00")
            Me.TTotalD.Text = Format(Convert.ToDecimal(Me.TTotal.Text) / BsXDolarBC, "##,##0.00")
            If (Me.TTotal.Text = "") Then
                Me.TTotal.Text = "0,00"
                Me.TTotalD.Text = "0,00"
            End If
        Else
            Me.TPrecio.Text = "0,00"
            Me.TPrecioD.Text = "0,00"
            Me.TSubTotal.Text = "0,00"
            Me.TSubTotalD.Text = "0,00"
            Me.TIVA.Text = "0,00"
            Me.TIVAD.Text = "0,00"
            Me.TTotal.Text = "0,00"
            Me.TTotalD.Text = "0,00"
        End If
    End Sub

    Private Sub CUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CUnidad.SelectedIndexChanged
        TPeso_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub BExcepcion_Click(sender As Object, e As EventArgs) Handles BExcepcion.Click
        'If (Me.TPeso.Text <> "") Then
        '    Dim PesoReal As Decimal = CalcularPesoReal(TPeso.Tag, CUnidad.Text, TPeso.Text)
        '    Dim Tipo As String = ""
        '    Select Case CatActiva
        '        Case "Sazonado"
        '            Tipo = "S_"
        '        Case "Relleno"
        '            Tipo = "R_"
        '        Case "Picado"
        '            Tipo = "P_"
        '        Case "Empacado"
        '            Tipo = "E_"
        '        Case "Traslado"
        '            Tipo = "T_"
        '        Case Else
        '            PesoProd = Convert.ToInt16(Me.TPeso.Text)
        '    End Select
        '    Select Case VarForma
        '        Case "FCajas"
        '            If (Me.TEditarTotal.Text = "") Then
        '                If (CatActiva = "Preparados") Then
        '                    GuardarDetalleVentaPB(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), "Excepcion", Convert.ToDecimal(Me.TPeso.Text), False)
        '                    FCajaNew.DGArticulos.Rows.Add(Me.TPeso.Tag, Me.LArtEjemplo.Text, TPeso.Text, Me.CUnidad.Text, Me.BTipoPrecio.Tag, TPrecio.Text, TSubTotal.Text, "Excepcion", PesoReal, CodDetalleVenta)
        '                    FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
        '                    'FCajaNew.LTotalArt.Text = FCajaNew.LTotalArt.Text + 1
        '                    FCajaNew.LTotalCancelar.Text = Format(Convert.ToDecimal(FCajaNew.LTotalCancelar.Text) + Convert.ToDecimal(TSubTotal.Text), "##,##0.00")
        '                    ' DescontarIngredientes(False, True, Convert.ToDecimal(Me.TCodDet.Text))
        '                Else
        '                    GuardarDetalleVentaPB(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), "Excepcion", PesoReal, False)
        '                    FCajaNew.DGArticulos.Rows.Add(Me.TPeso.Tag, Me.LArtEjemplo.Text, TPeso.Text, Me.CUnidad.Text, Me.BTipoPrecio.Tag, TPrecio.Text, TSubTotal.Text, "Excepcion", PesoReal, CodDetalleVenta)
        '                    FCajaNew.DGArticulos.Rows(FCajaNew.DGArticulos.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
        '                    ' FCajaNew.LTotalArt.Text = FCajaNew.LTotalArt.Text + 1
        '                    FCajaNew.LTotalCancelar.Text = Format(Convert.ToDecimal(FCajaNew.LTotalCancelar.Text) + Convert.ToDecimal(TSubTotal.Text), "##,##0.00")
        '                End If
        '            Else
        '                If (CatActiva = "Preparados") Then
        '                    ActualizarDetalleVentaPB(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), PesoReal, False, Convert.ToDecimal(Me.TCodDet.Text))
        '                    FCajaNew.DGArticulos.Item(2, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.TPeso.Text
        '                    FCajaNew.DGArticulos.Item(3, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.CUnidad.Text
        '                    FCajaNew.DGArticulos.Item(4, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.BTipoPrecio.Tag
        '                    FCajaNew.DGArticulos.Item(5, FCajaNew.DGArticulos.CurrentRow.Index).Value = TPrecio.Text
        '                    FCajaNew.DGArticulos.Item(6, FCajaNew.DGArticulos.CurrentRow.Index).Value = TSubTotal.Text
        '                    FCajaNew.DGArticulos.Item(8, FCajaNew.DGArticulos.CurrentRow.Index).Value = PesoReal
        '                    FCajaNew.LTotalCancelar.Text = Format((Convert.ToDecimal(FCajaNew.LTotalCancelar.Text) - Convert.ToDecimal(Me.TEditarTotal.Text)) + Convert.ToDecimal(TSubTotal.Text), "##,##0.00")
        '                    '  DescontarIngredientes(False, False, Convert.ToDecimal(Me.TCodDet.Text))
        '                Else
        '                    ActualizarDetalleVentaPB(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), PesoReal, False, Convert.ToDecimal(Me.TCodDet.Text))
        '                    FCajaNew.DGArticulos.Item(2, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.TPeso.Text
        '                    FCajaNew.DGArticulos.Item(3, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.CUnidad.Text
        '                    FCajaNew.DGArticulos.Item(4, FCajaNew.DGArticulos.CurrentRow.Index).Value = Me.BTipoPrecio.Tag
        '                    FCajaNew.DGArticulos.Item(5, FCajaNew.DGArticulos.CurrentRow.Index).Value = TPrecio.Text
        '                    FCajaNew.DGArticulos.Item(6, FCajaNew.DGArticulos.CurrentRow.Index).Value = TSubTotal.Text
        '                    FCajaNew.DGArticulos.Item(8, FCajaNew.DGArticulos.CurrentRow.Index).Value = PesoReal
        '                    FCajaNew.LTotalCancelar.Text = Format((Convert.ToDecimal(FCajaNew.LTotalCancelar.Text) - Convert.ToDecimal(Me.TEditarTotal.Text)) + Convert.ToDecimal(TSubTotal.Text), "##,##0.00")
        '                End If
        '            End If
        '            Me.TEditarTotal.Text = ""
        '            Me.Close()
        '        Case "FPedido"
        '            If (Me.TEditarTotal.Text = "") Then
        '                If (CatActiva = "Preparados") Then
        '                    GuardarDetalleVentaPA(Me.TPeso.Tag, Me.LArtEjemplo.Text, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), "Excepcion", Convert.ToDecimal(Me.TPeso.Text), False, CodPescado)
        '                    FPedido.DGListadoCompra.Rows.Add(Me.TPeso.Tag, Me.LArtEjemplo.Text, TPeso.Text, Me.CUnidad.Text, Me.BTipoPrecio.Tag, TPrecio.Text, TSubTotal.Text, "Excepcion", PesoReal, CodDetalleReserva, "", CodPescado)
        '                    FPedido.DGListadoCompra.Rows(FPedido.DGListadoCompra.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
        '                    '  DescontarIngredientesReserva(False, True, Convert.ToDecimal(Me.TCodDet.Text))
        '                Else
        '                    GuardarDetalleVentaPA(Me.TPeso.Tag, Me.LArtEjemplo.Text, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), "Excepcion", PesoReal, False, CodPescado)
        '                    FPedido.DGListadoCompra.Rows.Add(Me.TPeso.Tag, Me.LArtEjemplo.Text, TPeso.Text, Me.CUnidad.Text, Me.BTipoPrecio.Tag, TPrecio.Text, TSubTotal.Text, "Excepcion", PesoReal, CodDetalleReserva, "", CodPescado)
        '                    FPedido.DGListadoCompra.Rows(FPedido.DGListadoCompra.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
        '                End If
        '            Else
        '                If (CatActiva = "Preparados") Then
        '                    ActualizarDetalleVentaPA(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), PesoReal, False, Convert.ToDecimal(Me.TCodDet.Text), CodPescado)
        '                    FPedido.DGListadoCompra.Item(2, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TPeso.Text
        '                    FPedido.DGListadoCompra.Item(3, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.CUnidad.Text
        '                    FPedido.DGListadoCompra.Item(4, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.BTipoPrecio.Tag
        '                    FPedido.DGListadoCompra.Item(5, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TPrecio.Text
        '                    FPedido.DGListadoCompra.Item(6, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TSubTotal.Text
        '                    FPedido.DGListadoCompra.Item(8, FPedido.DGListadoCompra.CurrentRow.Index).Value = PesoReal
        '                    FPedido.DGListadoCompra.Item(10, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TStock.Text
        '                    FPedido.DGListadoCompra.Item(11, FPedido.DGListadoCompra.CurrentRow.Index).Value = CodPescado
        '                    '  DescontarIngredientesReserva(False, False, Convert.ToDecimal(Me.TCodDet.Text))
        '                Else
        '                    ActualizarDetalleVentaPA(Me.TPeso.Tag, Convert.ToDecimal(Me.TPeso.Text), Me.CUnidad.Text, Convert.ToInt16(Me.BTipoPrecio.Tag), Convert.ToDecimal(Me.TPrecio.Text), Convert.ToDecimal(Me.TSubTotal.Text), PesoReal, False, Convert.ToDecimal(Me.TCodDet.Text), CodPescado)
        '                    FPedido.DGListadoCompra.Item(2, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TPeso.Text
        '                    FPedido.DGListadoCompra.Item(3, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.CUnidad.Text
        '                    FPedido.DGListadoCompra.Item(4, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.BTipoPrecio.Tag
        '                    FPedido.DGListadoCompra.Item(5, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TPrecio.Text
        '                    FPedido.DGListadoCompra.Item(6, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TSubTotal.Text
        '                    FPedido.DGListadoCompra.Item(8, FPedido.DGListadoCompra.CurrentRow.Index).Value = PesoReal
        '                    FPedido.DGListadoCompra.Item(10, FPedido.DGListadoCompra.CurrentRow.Index).Value = Me.TStock.Text
        '                    FPedido.DGListadoCompra.Item(11, FPedido.DGListadoCompra.CurrentRow.Index).Value = CodPescado
        '                End If
        '            End If
        '            Me.TEditarTotal.Text = ""
        '            Me.Close()
        '    End Select
        'Else
        '    MsgBox("Debe Asignar un Peso.", MsgBoxStyle.Information, "MarSoft: Información.")
        '    Me.TPeso.Select()
        'End If
    End Sub

    Private Sub BAceptar_KeyDown(sender As Object, e As KeyEventArgs) Handles BAceptar.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            BAceptar_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub CambiarColorBoton(NBoton As Integer)
        Select Case BotonActivo
            Case 1
                Me.BTipoPrecio.BackColor = Color.White
            Case 2
                Me.BPrecio10.BackColor = Color.White
            Case 3
                Me.BPrecio11.BackColor = Color.White
            Case 4
                Me.BPrecio12.BackColor = Color.White
        End Select
        Select Case NBoton
            Case 1
                Me.BTipoPrecio.BackColor = Color.Turquoise
                BotonActivo = 1
            Case 2
                Me.BPrecio10.BackColor = Color.Turquoise
                BotonActivo = 2
            Case 3
                Me.BPrecio11.BackColor = Color.Turquoise
                BotonActivo = 3
            Case 4
                Me.BPrecio12.BackColor = Color.Turquoise
                BotonActivo = 4    
        End Select
    End Sub

    Private Sub BTipoPrecio_Click(sender As Object, e As EventArgs) Handles BTipoPrecio.Click
        'FEscogerPrecio.LProducto.Tag = Me.TPeso.Tag
        'VarForma = "FBalanza"
        'FEscogerPrecio.ShowDialog()
        'TPeso_TextChanged(Nothing, Nothing)
        'CambiarColorBoton(1)
    End Sub
  
    Private Sub BPrecio10_Click(sender As Object, e As EventArgs) Handles BPrecio10.Click
        Me.BTipoPrecio.Tag = "11"
        TPeso_TextChanged(Nothing, Nothing)
        CambiarColorBoton(2)
    End Sub

    Private Sub BPrecio11_Click(sender As Object, e As EventArgs) Handles BPrecio11.Click
        Me.BTipoPrecio.Tag = "12"
        TPeso_TextChanged(Nothing, Nothing)
        CambiarColorBoton(3)
    End Sub

    Private Sub BPrecio12_Click(sender As Object, e As EventArgs) Handles BPrecio12.Click
        Me.BTipoPrecio.Tag = "13"
        TPeso_TextChanged(Nothing, Nothing)
        CambiarColorBoton(4)
    End Sub

    Private Sub RBDetal_CheckedChanged(sender As Object, e As EventArgs) Handles RBDetal.CheckedChanged
        If (RBDetal.Checked) Then
            Venta = "Detal"
            Me.RBDetal.BackColor = Color.Turquoise
            Me.RBMayor.BackColor = Color.White
            Me.RBForanea.Visible = False
            If (RBLocal.Checked = False) And (RBOnline.Checked = False) Then
                Me.RBLocal.Checked = True
            End If
        Else
            Venta = "Mayor"
            Me.RBDetal.BackColor = Color.White
            Me.RBMayor.BackColor = Color.Turquoise
            Me.RBForanea.Visible = True
        End If
    End Sub
    Private Sub ColorearSeleccion(Seleccion As String)
        Select Case Seleccion
            Case "Local"
                Me.RBLocal.BackColor = Color.Turquoise
                Me.RBOnline.BackColor = Color.White
                Me.RBForanea.BackColor = Color.White
            Case "OnLine"
                Me.RBLocal.BackColor = Color.White
                Me.RBOnline.BackColor = Color.Turquoise
                Me.RBForanea.BackColor = Color.White
            Case "Foranea"
                Me.RBLocal.BackColor = Color.White
                Me.RBOnline.BackColor = Color.White
                Me.RBForanea.BackColor = Color.Turquoise
        End Select
        Despacho = Seleccion
    End Sub
    Private Sub RBLocal_CheckedChanged(sender As Object, e As EventArgs) Handles RBLocal.CheckedChanged
        If (RBLocal.Checked) Then
            ColorearSeleccion("Local")
        End If       
    End Sub

    Private Sub RBOnline_CheckedChanged(sender As Object, e As EventArgs) Handles RBOnline.CheckedChanged
        If (RBOnline.Checked) Then
            ColorearSeleccion("OnLine")
        End If
    End Sub

    Private Sub RBForanea_CheckedChanged(sender As Object, e As EventArgs) Handles RBForanea.CheckedChanged
        If (RBForanea.Checked) Then
            ColorearSeleccion("Foranea")
        End If
    End Sub

    Private Sub CBPosVenta_CheckedChanged(sender As Object, e As EventArgs) Handles CBPosVenta.CheckedChanged
        If (Me.CBPosVenta.Checked) Then
            Me.BPosVenta.Enabled = True
        Else
            Me.BPosVenta.Enabled = False
        End If
    End Sub

    Private Sub BPosVenta_Click(sender As Object, e As EventArgs) Handles BPosVenta.Click
        Me.BPosVenta.Tag = VarForma
        VarForma = "Pos-Venta"
        FComentarioSolo.TComentario.Text = Me.TPosVenta.Text
        FComentarioSolo.ShowDialog()
        VarForma = Me.BPosVenta.Tag
    End Sub

    Private Sub TPrecio_TextChanged(sender As Object, e As EventArgs) Handles TPrecio.TextChanged

    End Sub
End Class