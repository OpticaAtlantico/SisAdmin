Imports System.Data.SqlClient
Public Class FControlCaja
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Dim Bandera As Boolean = False

    Private DataT4 As DataTable
    Private Adaptador4 As SqlDataAdapter
    Private Fila4 As Integer

    Private SaldoAntCajaChica As Decimal = 0
    Private SaldoAntCajaChicaD As Decimal = 0
    Dim EfectivoEntrante As Decimal = 0
    Dim DivisaEntrante As Decimal = 0
    Dim TarjetaEntrante As Decimal = 0
    Dim BioPagoEntrante As Decimal = 0
    Dim TransferenciaEntrante As Decimal = 0
    Dim PagoMovilEntrante As Decimal = 0

    Dim EfectivoAux As Decimal = 0
    Dim EfectivoDAux As Decimal = 0
    Private Sub LlenarComboResponsableDif()
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("SELECT idEmpleado, LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido))) as Nombre FROM TEmpleado WHERE Activo=1 ORDER BY Nombre", CNN)
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.CResponsableDif.DataSource = DataT
                Me.CResponsableDif.DisplayMember = "Nombre"
                Me.CResponsableDif.ValueMember = "IdEmpleado"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos del Responsable de la Diferencia de Caja... " & ControlChars.CrLf & ex.Message)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub InicializarVariables()
        SaldoAntCajaChica = 0
        SaldoAntCajaChicaD = 0
        EfectivoEntrante = 0
        DivisaEntrante = 0
        TarjetaEntrante = 0
        BioPagoEntrante = 0
        TransferenciaEntrante = 0
        PagoMovilEntrante = 0
    End Sub
    Private Sub LlenarDatos()
        InicializarVariables()
        'Apertura''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT Monto FROM TAperturaCaja WHERE Moneda ='Efectivo en Bs.' AND idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Apertura", 0).Value = Format(DR("Monto"), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar los Datos de la Apertura de Caja en Bs. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT Monto FROM TAperturaCaja WHERE Moneda ='Efectivo en $' AND idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("AperturaD", 1).Value = Format(DR("Monto"), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar los Datos de la Apertura de Caja en $. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        'Ventas......................................................................................................
        '   Try
        ' LimpiarTexboxVarios(Me)
        If (Conectar()) Then
            Dim Comando As New SqlCommand("SELECT Nombre, SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM VResumenVentaDia  WHERE   Nombre<>'Varios' and idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta GROUP BY Nombre", CNN)
            Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
            Comando.Parameters.AddWithValue("@idCajero", CodCajero)
            Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
            Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
            Comando.CommandTimeout = 150
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            Do While DR.Read()
                Select Case DR("Nombre").ToString
                    Case Is = "Efectivo"
                        Me.Grid.Item("Ventas", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 0).Value) + DR("Monto"), "##,##0.00")
                    Case Is = "Dolar"
                        Me.Grid.Item("VentasD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("VentasD", 1).Value) + DR("MontoD"), "##,##0.00")
                    Case Is = "Tarjeta"
                        If (DR("Monto") > 0) Then
                            Me.Grid.Item("Ventas", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 2).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Bio-Pago"
                        Me.Grid.Item("Ventas", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 3).Value) + DR("Monto"), "##,##0.00")
                    Case Is = "Transferencia"
                        Me.Grid.Item("Ventas", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 4).Value) + DR("Monto"), "##,##0.00")
                    Case Is = "Pago Móvil"
                        Me.Grid.Item("Ventas", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 5).Value) + DR("Monto"), "##,##0.00")
                    Case Is = "Crédito"
                        Me.Grid.Item("Ventas", 6).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 6).Value) + DR("Monto"), "##,##0.00")
                    Case Is = "Otras"
                        Me.Grid.Item("Ventas", 7).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 7).Value) + DR("Monto"), "##,##0.00")
                End Select
            Loop
            DR.Close()
        End If
        Desconectar()

        'Ventas con Tipo Pago Varios ......................................................................................................
        If (Conectar()) Then
            Dim Comando As New SqlCommand("SELECT TipoPago, SUM(MontoV) AS Monto, SUM(MontoDV) AS MontoD FROM VResumenDiaVarios  WHERE  Nombre='Varios' and idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta GROUP BY TipoPago", CNN)
            Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
            Comando.Parameters.AddWithValue("@idCajero", CodCajero)
            Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
            Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
            Comando.CommandTimeout = 100
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            Do While DR.Read()
                Select Case DR("TipoPago").ToString
                    Case Is = "Efectivo"
                        If (DR("Monto").ToString = "") Then
                        Else
                            Me.Grid.Item("Ventas", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 0).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Tarjeta"
                        If (DR("Monto") > 0) Then
                            Me.Grid.Item("Ventas", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 2).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Bio-Pago"
                        If (DR("Monto") > 0) Then
                            Me.Grid.Item("Ventas", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 3).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Transferencia"
                        If (DR("Monto") > 0) Then
                            Me.Grid.Item("Ventas", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 4).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Pago Móvil"
                        If (DR("Monto") > 0) Then
                            Me.Grid.Item("Ventas", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 5).Value) + DR("Monto"), "##,##0.00")
                        End If
                    Case Is = "Crédito"
                        Me.Grid.Item("Ventas", 6).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 6).Value) + DR("Monto"), "##,##0.00")
                    Case Else
                        If (InStr(DR("TipoPago").ToString, "Dolar") <> 0) Then
                            If (DR("MontoD").ToString = "") Then
                            Else
                                Me.Grid.Item("VentasD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("VentasD", 1).Value) + DR("MontoD"), "##,##0.00")
                            End If
                        Else
                            Me.Grid.Item("Ventas", 7).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 7).Value) + DR("Monto"), "##,##0.00")
                        End If
                End Select
            Loop
            DR.Close()
        End If
        Desconectar()

        'SUMAR ENTRADA DE EFCTIVO Y DOLARES
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT  SUM(MontoD) AS MontoD, SUM(Monto) AS Monto, TipoPago FROM VEfecDivEntrante  WHERE  DevolucionporDatos=0 AND  MontoD>0 AND idCaja=@idCajaD AND idCajero=@idCajeroD AND Fecha>=@DesdeD AND Fecha<=@HastaD GROUP BY TipoPago", CNN)
                Comando.Parameters.AddWithValue("@idCajaD", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajeroD", CodCajero)
                Comando.Parameters.AddWithValue("@DesdeD", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@HastaD", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Select Case DR("TipoPago").ToString
                        Case Is = "Dolar"
                            If (DR("MontoD").ToString <> "") Then
                                DivisaEntrante = Format(DR("MontoD"), "##,##0.00")
                            Else
                                DivisaEntrante = 0
                            End If
                        Case Is = "Efectivo"
                            If (DR("Monto").ToString <> "") Then
                                EfectivoEntrante = Format(DR("Monto"), "##,##0.00")
                            Else
                                EfectivoEntrante = 0
                            End If
                        Case Is = "Tarjeta"
                            If (DR("Monto").ToString <> "") Then
                                TarjetaEntrante = Format(DR("Monto"), "##,##0.00")
                            Else
                                TarjetaEntrante = 0
                            End If
                        Case Is = "Bio-Pago"
                            If (DR("Monto").ToString <> "") Then
                                BioPagoEntrante = Format(DR("Monto"), "##,##0.00")
                            Else
                                BioPagoEntrante = 0
                            End If
                        Case Is = "Transferencia"
                            If (DR("Monto").ToString <> "") Then
                                TransferenciaEntrante = Format(DR("Monto"), "##,##0.00")
                            Else
                                TransferenciaEntrante = 0
                            End If
                        Case Is = "Pago Móvil"
                            If (DR("Monto").ToString <> "") Then
                                PagoMovilEntrante = Format(DR("Monto"), "##,##0.00")
                            Else
                                PagoMovilEntrante = 0
                            End If
                    End Select
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Recuperar El Tipo Pago Entrante a Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        'INGRESOS:  CtasXCobrar, Otros Ingresos y Ingresos por Compra Ventas de Efectivo
        Try
            'Ingresos de Cuentas x Cobrar
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT MontoR, MontoRD, Moneda, Tipo FROM TFormaPagoCliente  WHERE FechaR>=@Desde AND FechaR<=@Hasta and Proviene=@Proviene AND Tipo <> 'Descuento'", CNN)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Comando.Parameters.AddWithValue("@Proviene", CajaActiva)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    If (DR("Moneda") = "Bs.") Then
                        Select Case DR("Tipo")
                            Case "Efectivo"
                                Me.Grid.Item("Ingresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value) + DR("MontoR"), "##,##0.00")
                            Case "Tarjeta"
                                Me.Grid.Item("Ingresos", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 2).Value) + DR("MontoR"), "##,##0.00")
                            Case "Bio-Pago"
                                Me.Grid.Item("Ingresos", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 3).Value) + DR("MontoR"), "##,##0.00")
                            Case "Transferencia"
                                Me.Grid.Item("Ingresos", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 4).Value) + DR("MontoR"), "##,##0.00")
                            Case "Pago Móvil"
                                Me.Grid.Item("Ingresos", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 5).Value) + DR("MontoR"), "##,##0.00")
                        End Select
                    Else
                        Select Case DR("Tipo")
                            Case "Efectivo" ' Efectivo Dolar...
                                Me.Grid.Item("IngresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value) + DR("MontoRD"), "##,##0.00")
                        End Select
                    End If
                Loop
                DR.Close()
                'Ingresos por  Otros Ingresos
                Comando.CommandText = "SELECT MontoD, Monto, Moneda, TipoPago  FROM TOtrosIngresos  WHERE idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1 and Proviene=@Proviene1"
                Comando.Parameters.AddWithValue("@idCaja1", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero1", CodCajero)
                Comando.Parameters.AddWithValue("@Desde1", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta1", Me.FechaCierre.Value)
                Comando.Parameters.AddWithValue("@Proviene1", CajaActiva)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    If (DR("Moneda") = "Bs.") Then
                        Select Case DR("TipoPago")
                            Case "Efectivo"
                                Me.Grid.Item("Ingresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value) + DR("Monto"), "##,##0.00")
                            Case "Tarjeta"
                                Me.Grid.Item("Ingresos", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 2).Value) + DR("Monto"), "##,##0.00")
                            Case "Pago Móvil"
                                Me.Grid.Item("Ingresos", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 5).Value) + DR("Monto"), "##,##0.00")
                        End Select
                    Else
                        Select Case DR("TipoPago")
                            Case "Efectivo" ' Efectivo Dolar
                                Me.Grid.Item("IngresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value) + DR("MontoD"), "##,##0.00")
                        End Select
                    End If
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar los Datos de las Cuentas por Cobrar o Otros Ingresos. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        ' Compra/Ventas Efectivo'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo  WHERE TipoEnt='Efectivo Bs.' AND idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Ingresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo  WHERE TipoEnt='Divisas ($)' AND idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1"
                Comando.Parameters.AddWithValue("@idCaja1", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero1", CodCajero)
                Comando.Parameters.AddWithValue("@Desde1", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta1", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("IngresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo   WHERE TipoEnt='Tarjeta' AND idCaja=@idCaja2 AND idCajero=@idCajero2 AND Fecha>=@Desde2 AND Fecha<=@Hasta2"
                Comando.Parameters.AddWithValue("@idCaja2", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero2", CodCajero)
                Comando.Parameters.AddWithValue("@Desde2", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta2", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Ingresos", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 2).Value) + +IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo   WHERE TipoEnt='Bio-Pago' AND idCaja=@idCaja3 AND idCajero=@idCajero3 AND Fecha>=@Desde3 AND Fecha<=@Hasta3"
                Comando.Parameters.AddWithValue("@idCaja3", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero3", CodCajero)
                Comando.Parameters.AddWithValue("@Desde3", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta3", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Ingresos", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 3).Value) + +IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo  WHERE TipoEnt='Transferencia' AND idCaja=@idCaja5 AND idCajero=@idCajero5 AND Fecha>=@Desde5 AND Fecha<=@Hasta5"
                Comando.Parameters.AddWithValue("@idCaja5", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero5", CodCajero)
                Comando.Parameters.AddWithValue("@Desde5", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta5", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Ingresos", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 4).Value) + +IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
                Comando.CommandText = "SELECT SUM(MontoEnt) as Monto FROM TCompraVentaEfectivo  WHERE TipoEnt='Pago Móvil' AND idCaja=@idCaja4 AND idCajero=@idCajero4 AND Fecha>=@Desde4 AND Fecha<=@Hasta4"
                Comando.Parameters.AddWithValue("@idCaja4", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero4", CodCajero)
                Comando.Parameters.AddWithValue("@Desde4", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta4", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Ingresos", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 5).Value) + +IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar los Ingresos de Compra/Ventas de Efectivo. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        'EGRESOS:   Gastos, Fondo Anticipo,  Egresos por Compra Ventas de Efectivo, Egresos por Vueltos, Imposibilidad Vuelto y CtasXPagar a Clientes
        ' Egresos por Gastos
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT  SUM(Costo) AS Monto, SUM(CostoD) AS MontoD FROM TGastos WHERE Descontar=1 AND Moneda='Bs.' and Fecha>=@Desde AND Fecha<=@Hasta AND Origen='" & CajaActiva & "'", CNN)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 0).Value = Format(IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar Egresos por Gastos de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(Costo) AS Monto, SUM(CostoD) AS MontoD FROM TGastos WHERE Descontar=1 And Moneda='$' and Fecha>=@Desde AND Fecha<=@Hasta AND Origen='" & CajaActiva & "'", CNN)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("EgresosD", 1).Value = Format(IIf(DR("MontoD").ToString = "", 0, DR("MontoD")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar Egresos por Gastos de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        'Egresos por Fondo Anticipo
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM TFondoAnticipoTrans WHERE Moneda='Bs.' AND TipoPago='Efectivo' and Fecha>=@Desde AND Fecha<=@Hasta AND Proviene='" & CajaActiva & "'", CNN)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar Egresos por Fondo Anticipo de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM TFondoAnticipoTrans WHERE Moneda='$' AND TipoPago='Efectivo' and Fecha>=@Desde AND Fecha<=@Hasta AND Proviene='" & CajaActiva & "'", CNN)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("EgresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value) + IIf(DR("MontoD").ToString = "", 0, DR("MontoD")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar Egresos por Fondo Anticipo de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        'Egresos por Compra/Ventas de Efectivo
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Efectivo Bs.' AND idCaja=@idCaja6 AND idCajero=@idCajero6 AND Fecha>=@Desde6 AND Fecha<=@Hasta6", CNN)
                Comando.Parameters.AddWithValue("@idCaja6", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero6", CodCajero)
                Comando.Parameters.AddWithValue("@Desde6", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta6", Me.FechaCierre.Value)
                Dim DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
                Comando.CommandText = "SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Divisas ($)' AND idCaja=@idCaja7 AND idCajero=@idCajero7 AND Fecha>=@Desde7 AND Fecha<=@Hasta7"
                Comando.Parameters.AddWithValue("@idCaja7", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero7", CodCajero)
                Comando.Parameters.AddWithValue("@Desde7", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta7", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("EgresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Tarjeta' AND idCaja=@idCaja8 AND idCajero=@idCajero8 AND Fecha>=@Desde8 AND Fecha<=@Hasta8"
                Comando.Parameters.AddWithValue("@idCaja8", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero8", CodCajero)
                Comando.Parameters.AddWithValue("@Desde8", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta8", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 2).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Bio-Pago' AND idCaja=@idCaja9 AND idCajero=@idCajero9 AND Fecha>=@Desde9 AND Fecha<=@Hasta9"
                Comando.Parameters.AddWithValue("@idCaja9", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero9", CodCajero)
                Comando.Parameters.AddWithValue("@Desde9", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta9", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 3).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Transferencia' AND idCaja=@idCaja11 AND idCajero=@idCajero11 AND Fecha>=@Desde11 AND Fecha<=@Hasta11"
                Comando.Parameters.AddWithValue("@idCaja11", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero11", CodCajero)
                Comando.Parameters.AddWithValue("@Desde11", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta11", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 4).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT SUM(MontoSal) as Monto FROM TCompraVentaEfectivo   WHERE TipoSal='Pago Móvil' AND idCaja=@idCaja10 AND idCajero=@idCajero10 AND Fecha>=@Desde10 AND Fecha<=@Hasta10"
                Comando.Parameters.AddWithValue("@idCaja10", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero10", CodCajero)
                Comando.Parameters.AddWithValue("@Desde10", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta10", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 5).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar Los Egresos por Compra/Ventas de Efectivo. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try

        '   Egresos por Vueltos Bs, Dolares, Pago Móvil y Transferencias      
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT  SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM VCambioControlCaja  WHERE idTipoCambio=1 and idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("Egresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                Loop
                DR.Close()

                Comando.CommandText = "SELECT  SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM VCambioControlCaja  WHERE idTipoCambio=2 and idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1"
                Comando.Parameters.AddWithValue("@idCaja1", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero1", CodCajero)
                Comando.Parameters.AddWithValue("@Desde1", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta1", Me.FechaCierre.Value)
                DR = Comando.ExecuteReader()
                Do While DR.Read()
                    Me.Grid.Item("EgresosD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value) + IIf(DR("MontoD").ToString = "", 0, DR("MontoD")), "##,##0.00")
                Loop

                DR.Close()
                'Comando.CommandText = "SELECT  SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM VCambioControlCaja  WHERE idTipoCambio=6 and idCaja=@idCaja2 AND idCajero=@idCajero2 AND Fecha>=@Desde2 AND Fecha<=@Hasta2"
                'Comando.Parameters.AddWithValue("@idCaja2", CodCajaActiva)
                'Comando.Parameters.AddWithValue("@idCajero2", CodCajero)
                'Comando.Parameters.AddWithValue("@Desde2", Me.FechaApertura.Value)
                'Comando.Parameters.AddWithValue("@Hasta2", Me.FechaCierre.Value)
                'DR = Comando.ExecuteReader()
                'Do While DR.Read()
                '    Me.Grid.Item("Egresos", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 5).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                'Loop

                'DR.Close()
                'Comando.CommandText = "SELECT  SUM(Monto) AS Monto, SUM(MontoD) AS MontoD FROM VCambioControlCaja  WHERE idTipoCambio=4 and idCaja=@idCaja3 AND idCajero=@idCajero3 AND Fecha>=@Desde3 AND Fecha<=@Hasta3"
                'Comando.Parameters.AddWithValue("@idCaja3", CodCajaActiva)
                'Comando.Parameters.AddWithValue("@idCajero3", CodCajero)
                'Comando.Parameters.AddWithValue("@Desde3", Me.FechaApertura.Value)
                'Comando.Parameters.AddWithValue("@Hasta3", Me.FechaCierre.Value)
                'DR = Comando.ExecuteReader()
                'Do While DR.Read()
                '    Me.Grid.Item("Egresos", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 4).Value) + IIf(DR("Monto").ToString = "", 0, DR("Monto")), "##,##0.00")
                'Loop
                'DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar los Egresos por Vueltos. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        ' Ingreso o Egreso por Imposibilidad de Vuelto''''''''''''''''''''
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(ValorDifMoneda) as DifMoneda FROM VVentasDifMoneda  WHERE TipoPago='Efectivo' AND DifMoneda=1 AND idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Comando.Parameters.AddWithValue("@Desde", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@Hasta", Me.FechaCierre.Value)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                Do While DR.Read()
                    If (DR("DifMoneda").ToString <> "") Then
                        If (DR("DifMoneda") > 0) Then
                            Me.Grid.Item("Ingresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value) + IIf(DR("DifMoneda").ToString = "", 0, DR("DifMoneda")), "##,##0.00")
                        Else
                            Me.Grid.Item("Egresos", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value) + IIf(DR("DifMoneda").ToString = "", 0, DR("DifMoneda")), "##,##0.00")
                        End If
                    End If
                Loop
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar la Imposibilidad de Vuelto de la Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Me.Grid.ClearSelection()
    End Sub
    Private Sub LlenarDatosGuardados()
        Try
            If (Conectar4()) Then
                Dim Comando4 As New SqlCommand("SELECT * FROM TCierreCaja WHERE idCierre=@idCierre", CNN4)
                Comando4.Parameters.AddWithValue("@idCierre", CodApertura)
                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                Do While DR4.Read()
                    Me.FechaCierre.Value = DR4("FechaCierre")
                    'Apertura
                    Me.Grid.Item("Apertura", 0).Value = Format(DR4("Apertura"), "##,##0.00")
                    Me.Grid.Item("AperturaD", 0).Value = Format(DR4("AperturaD"), "##,##0.00")
                    Me.Grid.Item("AperturaD", 1).Value = Format(DR4("AperturaD1"), "##,##0.00")
                    Me.Grid.Item("Apertura", 1).Value = Format(DR4("Apertura1"), "##,##0.00")

                    'Ventas 
                    Me.Grid.Item("VentasD", 0).Value = Format(DR4("VentasD"), "##,##0.00")
                    Me.Grid.Item("Ventas", 0).Value = Format(DR4("Ventas"), "##,##0.00")
                    Me.Grid.Item("VentasD", 1).Value = Format(DR4("VentasD1"), "##,##0.00")
                    Me.Grid.Item("Ventas", 1).Value = Format(DR4("Ventas1"), "##,##0.00")
                    Me.Grid.Item("VentasD", 2).Value = Format(DR4("VentasD2"), "##,##0.00")
                    Me.Grid.Item("Ventas", 2).Value = Format(DR4("Ventas2"), "##,##0.00")
                    Me.Grid.Item("VentasD", 3).Value = Format(DR4("VentasD3"), "##,##0.00")
                    Me.Grid.Item("Ventas", 3).Value = Format(DR4("Ventas3"), "##,##0.00")
                    Me.Grid.Item("VentasD", 4).Value = Format(DR4("VentasD4"), "##,##0.00")
                    Me.Grid.Item("Ventas", 4).Value = Format(DR4("Ventas4"), "##,##0.00")
                    Me.Grid.Item("VentasD", 5).Value = Format(DR4("VentasD5"), "##,##0.00")
                    Me.Grid.Item("Ventas", 5).Value = Format(DR4("Ventas5"), "##,##0.00")
                    Me.Grid.Item("VentasD", 6).Value = Format(DR4("VentasD6"), "##,##0.00")
                    Me.Grid.Item("Ventas", 6).Value = Format(DR4("Ventas6"), "##,##0.00")
                    Me.Grid.Item("VentasD", 7).Value = Format(DR4("VentasD7"), "##,##0.00")
                    Me.Grid.Item("Ventas", 7).Value = Format(DR4("Ventas7"), "##,##0.00")
                 
                    'INGRESOS
                    Me.Grid.Item("IngresosD", 0).Value = Format(DR4("IngresosD"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 0).Value = Format(DR4("Ingresos"), "##,##0.00")
                    Me.Grid.Item("IngresosD", 1).Value = Format(DR4("IngresosD1"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 1).Value = Format(DR4("Ingresos1"), "##,##0.00")
                    Me.Grid.Item("IngresosD", 2).Value = Format(DR4("IngresosD2"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 2).Value = Format(DR4("Ingresos2"), "##,##0.00")
                    Me.Grid.Item("IngresosD", 3).Value = Format(DR4("IngresosD3"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 3).Value = Format(DR4("Ingresos3"), "##,##0.00")
                    Me.Grid.Item("IngresosD", 4).Value = Format(DR4("IngresosD4"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 4).Value = Format(DR4("Ingresos4"), "##,##0.00")
                    Me.Grid.Item("IngresosD", 5).Value = Format(DR4("IngresosD5"), "##,##0.00")
                    Me.Grid.Item("Ingresos", 5).Value = Format(DR4("Ingresos5"), "##,##0.00")

                    'EGRESOS
                    Me.Grid.Item("EgresosD", 0).Value = Format(DR4("EgresosD"), "##,##0.00")
                    Me.Grid.Item("Egresos", 0).Value = Format(DR4("Egresos"), "##,##0.00")
                    Me.Grid.Item("EgresosD", 1).Value = Format(DR4("EgresosD1"), "##,##0.00")
                    Me.Grid.Item("Egresos", 1).Value = Format(DR4("Egresos1"), "##,##0.00")
                    Me.Grid.Item("EgresosD", 2).Value = Format(DR4("EgresosD2"), "##,##0.00")
                    Me.Grid.Item("Egresos", 2).Value = Format(DR4("Egresos2"), "##,##0.00")
                    Me.Grid.Item("EgresosD", 3).Value = Format(DR4("EgresosD3"), "##,##0.00")
                    Me.Grid.Item("Egresos", 3).Value = Format(DR4("Egresos3"), "##,##0.00")
                    Me.Grid.Item("EgresosD", 4).Value = Format(DR4("EgresosD4"), "##,##0.00")
                    Me.Grid.Item("Egresos", 4).Value = Format(DR4("Egresos4"), "##,##0.00")
                    Me.Grid.Item("EgresosD", 5).Value = Format(DR4("EgresosD5"), "##,##0.00")
                    Me.Grid.Item("Egresos", 5).Value = Format(DR4("Egresos5"), "##,##0.00")

                    'REAL
                    Me.Grid.Item("RealD", 0).Value = Format(DR4("RealD"), "##,##0.00")
                    Me.Grid.Item("Real", 0).Value = Format(DR4("Real"), "##,##0.00")
                    Me.Grid.Item("RealD", 1).Value = Format(DR4("RealD1"), "##,##0.00")
                    Me.Grid.Item("Real", 1).Value = Format(DR4("Real1"), "##,##0.00")
                    Me.Grid.Item("RealD", 2).Value = Format(DR4("RealD2"), "##,##0.00")
                    Me.Grid.Item("Real", 2).Value = Format(DR4("Real2"), "##,##0.00")
                    Me.Grid.Item("RealD", 3).Value = Format(DR4("RealD3"), "##,##0.00")
                    Me.Grid.Item("Real", 3).Value = Format(DR4("Real3"), "##,##0.00")

                    'ENTRANTES
                    EfectivoEntrante = Format(DR4("EfectivoEnt"), "##,##0.00")
                    DivisaEntrante = Format(DR4("DivisaEnt"), "##,##0.00")
                    TarjetaEntrante = Format(DR4("TarjetaEnt"), "##,##0.00")
                    BioPagoEntrante = Format(DR4("BioPagoEnt"), "##,##0.00")
                    TransferenciaEntrante = Format(DR4("TransferenciaEnt"), "##,##0.00")
                    PagoMovilEntrante = Format(DR4("PagoMovilEnt"), "##,##0.00")

                    Me.CResponsableDif.SelectedValue = DR4("idResponsable")
                    Me.TComentario.Text = DR4("Comentario")
                    Me.CUsuario.Text = DR4("Usuario")
                Loop
                DR4.Close()
            End If
            Desconectar4()
        Catch ex As Exception
            MessageBox.Show("ERROR al Restaurar los Datos del Cierre de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar4()
        End Try
        Me.Grid.ClearSelection()
    End Sub
    'Private Sub LlenarGrill()
    '    Me.Grid.Rows.Clear()
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(0), "Efectivo Bs.", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(9), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(1), "Efectivo $", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(2), "Tarjetas", "", "", 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(9), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(3), "Bio-Pago", "", "", 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(9), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(4), "Transferencias", "", "", 0, 0, "", "", Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(5), "Pago Móvil", "", "", 0, 0, "", "", Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(6), "Crédito", "", "", 0, 0, "", "", Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(7), "Otros", "", "", 0, 0, "", "", Me.ICuentas32.Images(10), 0, 0, "", "", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows.Add(Me.ICuentas32.Images(8), "Totales", 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Me.ICuentas32.Images(10), 0, 0)
    '    Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.BackColor = Color.LightSteelBlue
    '    Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
    '    For i = 0 To Me.Grid.ColumnCount - 1
    '        For j = 0 To Me.Grid.RowCount - 1
    '            Me.Grid.Item(i, j).ReadOnly = True
    '        Next
    '    Next
    '    Me.Grid.Item(17, 1).ReadOnly = False
    '    Me.Grid.Item(18, 0).ReadOnly = False
    'End Sub

    Private Sub LlenarGrill()
        Me.Grid.Rows.Clear()
        Me.Grid.Rows.Add(Me.ICuentas32.Images(0), "Efectivo Bs.", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(1), "Divisas $", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(2), "Tarjetas", "", "", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(11), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(3), "Bio-Pago", "", "", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(11), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(4), "Transferencias", "", "", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(5), "Pago Móvil", "", "", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(6), "Crédito", "", "", "0,00", "0,00", "", "", "", "", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(7), "Otros", "", "", "0,00", "0,00", "", "", "", "", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(10), "0,00", "0,00")
        Me.Grid.Rows.Add(Me.ICuentas32.Images(8), "Totales", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", "0,00", Me.ICuentas32.Images(12), "0,00", "0,00")
        'Desactivarlos para Escritura
        For i = 0 To Me.Grid.ColumnCount - 1
            For j = 0 To Me.Grid.RowCount - 1
                Me.Grid.Item(i, j).ReadOnly = True
                If (i > 1) And (j < 8) And (i <> 14) Then
                    Me.Grid.Item(i, j).Style.BackColor = Color.FromArgb(255, 255, 220) 'color Amarillo
                End If
                Me.Grid.Item(i, j).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
                If (i = 1) Then
                    Me.Grid.Item(i, j).Style.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                End If
                If (j = 8) Then
                    Me.Grid.Item(i, j).Style.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                End If
                'If (i > 12) And (i <> 14) Then
                '    If (j > 1) Then
                '        Me.Grid.Item(i, j).Value = "0,00"
                '    End If
                'End If
            Next
        Next
        Me.Grid.Rows(8).DefaultCellStyle.BackColor = Color.LightSteelBlue
        'Activar Columnas Reales para Escritura
        Me.Grid.Item("RealD", 1).ReadOnly = False
        Me.Grid.Item("Real", 0).ReadOnly = False

        'Inicializar Colores Aperturas
        Me.Grid.Item("Apertura", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("AperturaD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("AperturaD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Apertura", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris

        Me.Grid.Item("AperturaD", 2).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 2).Style.BackColor = Color.Gray
        Me.Grid.Item("AperturaD", 3).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 3).Style.BackColor = Color.Gray
        Me.Grid.Item("AperturaD", 4).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 4).Style.BackColor = Color.Gray
        Me.Grid.Item("AperturaD", 5).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 5).Style.BackColor = Color.Gray
        Me.Grid.Item("AperturaD", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("AperturaD", 7).Style.BackColor = Color.Gray
        Me.Grid.Item("Apertura", 7).Style.BackColor = Color.Gray

        'Inicializar Colores Ventas
        Me.Grid.Item("Ventas", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("VentasD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Ventas", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 6).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 6).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ventas", 7).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("VentasD", 7).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris

        ' Inicializar Colores Ingresos
        Me.Grid.Item("Ingresos", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("IngresosD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ingresos", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("IngresosD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Ingresos", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("IngresosD", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ingresos", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("IngresosD", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ingresos", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("IngresosD", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Ingresos", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("IngresosD", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("IngresosD", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("Ingresos", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("IngresosD", 7).Style.BackColor = Color.Gray
        Me.Grid.Item("Ingresos", 7).Style.BackColor = Color.Gray

        ' Inicializar Colores Egresos
        Me.Grid.Item("Egresos", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("EgresosD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Egresos", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("EgresosD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Egresos", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("EgresosD", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Egresos", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("EgresosD", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Egresos", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("EgresosD", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Egresos", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("EgresosD", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("EgresosD", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("Egresos", 6).Style.BackColor = Color.Gray
        Me.Grid.Item("EgresosD", 7).Style.BackColor = Color.Gray
        Me.Grid.Item("Egresos", 7).Style.BackColor = Color.Gray

        ' Inicializar Colores Totales
        Me.Grid.Item("Total2", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("TotalD2", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Total2", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 6).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 6).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Total2", 7).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("TotalD2", 7).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris

        ' Inicializar Colores Real
        Me.Grid.Item("Real", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("RealD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Real", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 6).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 6).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Real", 7).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("RealD", 7).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris

        ' Inicializar Colores Diferencia
        Me.Grid.Item("Diferencia", 0).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 0).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 1).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("DiferenciaD", 1).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("Diferencia", 2).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 2).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 3).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 3).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 4).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 4).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 5).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 5).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 6).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 6).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris
        Me.Grid.Item("Diferencia", 7).Style.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
        Me.Grid.Item("DiferenciaD", 7).Style.BackColor = Color.FromArgb(224, 224, 224) ' color Gris

        'Inicializar Grilll Columna Real Bolivares, Dolares,tarjetas, BioPago.
        Me.Grid.Item("RealD", 0).Value = Format(0, "##,##0.00")
        Me.Grid.Item("Real", 0).Value = Format(0, "##,##0.00")
        Me.Grid.Item("RealD", 1).Value = Format(0, "##,##0.00")
        Me.Grid.Item("Real", 1).Value = Format(0, "##,##0.00")
        Me.Grid.Item("RealD", 2).Value = Format(0, "##,##0.00")
        Me.Grid.Item("Real", 2).Value = Format(0, "##,##0.00")
        Me.Grid.Item("RealD", 3).Value = Format(0, "##,##0.00")
        Me.Grid.Item("Real", 3).Value = Format(0, "##,##0.00")

        'Inicializar TexBox      
        Me.TComentario.Text = ""
        Me.CUsuario.Text = ""
        Me.TContraseña.Text = ""
        Me.CResponsableDif.Text = ""
        Me.Grid.Item("Boton", 2).ToolTipText = "Pulse para Descargar Lotes."
        Me.Grid.Item("Boton", 3).ToolTipText = "Pulse para Descargar Bio-Pagos."
    End Sub
    Function BuscarFechaInicio() As DateTime
        Dim Fecha As DateTime
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT idApertura, Fecha FROM TAperturaCaja WHERE idCaja=@idCaja AND idCajero=@idCajero ORDER BY Fecha DESC", CNN)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Comando.Parameters.AddWithValue("@idCajero", CodCajero)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Fecha = DR("Fecha")
                    CodApertura = DR("idApertura")
                Else
                    Fecha = "01/01/1900 00:00:00"
                    CodApertura = -1
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Mostrar la Fecha de la Apertura de Caja. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
        Return (Fecha)
    End Function

    Private Sub MostrarCajero()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Select idCajero FROM TAperturaCaja WHERE idCaja=@idCaja ORDER BY Fecha DESC", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read) Then
                    Me.ToolTip1.SetToolTip(Me.LCajero, "Cód. Cajero: " & DR("idCajero"))
                    'Me.LCajero.Text = "(" & DR("idCajero") & ") Cajero: "
                    CodCajero = DR("idCajero")
                End If
                DR.Close()
                Comando.CommandText = "Select LEFT(Nombre, ISNULL(NULLIF (CHARINDEX(' ', Nombre) - 1, - 1), LEN(Nombre))) + ' ' + LEFT(Apellido, ISNULL(NULLIF (CHARINDEX(' ', Apellido) - 1, - 1), LEN(Apellido)))  as  Cajero FROM TEmpleado WHERE idEmpleado=@idCajero"
                Comando.Parameters.Add(New SqlParameter("@idCajero", CodCajero))
                DR = Comando.ExecuteReader()
                If (DR.Read) Then
                    Me.TCajero.Text = DR("Cajero")
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox("Error al Mostrar Datos del Cajero.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub FControlCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FechaDia = DateAndTime.Now
        CalcularDolar(DateTime.Now, "0")
        Me.Tasa.Text = Format(BsXDolarBC, "##,##0.00")
        LlenarGrill()
        Select Case VarFormaControlCaja
            Case "ExaminarCierre"
                Me.BRecalcular.Enabled = True
                Me.CUsuario.Text = ""
                Me.TContraseña.Text = ""
                Bandera = False
                LlenarComboResponsableDif()
                LlenarDatosGuardados()
                Me.FechaCierre.Enabled = False
            Case "InicializarCajas"
                Me.BRecalcular.Enabled = False
                MostrarCajero()
                Bandera = True
                Me.ToolTip1.SetToolTip(Me.LCaja, "Cód. Caja: " & CodCajaActiva)
                '  Me.LCaja.Text = "(" & CodCajaActiva & ") Caja: "
                Me.TCaja.Text = CajaActiva
                Me.TCaja.Tag = CodCajaActiva
                Me.FechaApertura.Value = BuscarFechaInicio()
                Me.FechaCierre.Value = DateAndTime.Now
                LlenarComboResponsableDif()
                LlenarDatos()
                Me.CUsuario.Text = ""
                Me.TContraseña.Text = ""
                Bandera = False
                Me.FechaCierre.Enabled = True
            Case Else
                Me.BRecalcular.Enabled = True
                Bandera = True
                Me.ToolTip1.SetToolTip(Me.LCaja, "Cód. Caja: " & CodCajaActiva)

                '  Me.LCaja.Text = "(" & CodCajaActiva & ") Caja: "
                Me.TCaja.Text = CajaActiva
                Me.TCaja.Tag = CodCajaActiva
                MostrarCajero()
                Me.FechaApertura.Value = BuscarFechaInicio()
                Me.FechaCierre.Value = DateAndTime.Now
                LlenarComboResponsableDif()
                LlenarDatos()
                Me.CUsuario.Text = ""
                Me.TContraseña.Text = ""
                Bandera = False
                Me.FechaCierre.Enabled = True
        End Select
        TotalizarCuentaReal()
        LIDApertura.Text = CodApertura
        Me.Grid.ClearSelection()
        Me.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ValidarPermiso()
        If Conectar() Then
            Try
                Dim contra As String = Contrasena(CUsuario.Text)
                If (contra = TContraseña.Text) Then
                    If (ConsultarTipoUsuario(CUsuario.Text) = 1) Then
                        TienePermiso = True
                    Else
                        MsgBox("El Usuario: " & Me.CUsuario.Text & "  No posee Permiso para Realizar esta Acción.", MsgBoxStyle.Information, "MarSoft: Error de Datos.")
                        TienePermiso = False
                    End If
                Else
                    MsgBox("Contraseña Invalida.", MsgBoxStyle.Critical)
                    TienePermiso = False
                    Me.TContraseña.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub EliminarDesglose(CodDesglose As Integer, Moneda As String, Tipo As String)
        If (Conectar2()) Then
            Try
                Dim Comando2 As New SqlCommand("Delete TDesgloseEfectivo WHERE id=@id and Tipo='Cierre'", CNN2)
                Comando2.Parameters.Add(New SqlParameter("@id", CodDesglose))
                Dim DR2 As SqlDataReader = Comando2.ExecuteReader()
                DR2.Close()
            Catch ex As Exception
                MsgBox("Error al Eliminar los Datos.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub
    Private Sub ActualizarCajaChica()
        If (CajaChicaActiva = "Caja Chica 1") Then
            ' If (Convert.ToDecimal(Me.Grid.Item(18, 0).Value) > 0) Then
            If (ExisteCierreCajaChicaBs()) Then
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCajaChica set MontoD=@MontoD,Monto=@Monto, Relacionado=@Relacionado,Resta=@Resta,RelacionadoD=@RelacionadoD,RestaD=@RestaD, TotalGeneral=@TotalGeneral,TotalGeneralD=@TotalGeneralD WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='Bs.'", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                    Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value)))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                End If
                Desconectar()
            Else
                GuardarCajaChicaBs()
            End If
            ' End If
            '  If (Convert.ToDecimal(Me.Grid.Item(17, 1).Value) > 0) Then
            If (ExisteCierreCajaChicaDolar()) Then
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCajaChica set MontoD=@MontoD,Monto=@Monto, Relacionado=@Relacionado,Resta=@Resta,RelacionadoD=@RelacionadoD,RestaD=@RestaD, TotalGeneral=@TotalGeneral,TotalGeneralD=@TotalGeneralD WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='$'", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                    Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value)))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                End If
                Desconectar()
            Else
                GuardarCajaChicaDolar()
            End If
            ' End If
        Else
            ' If (Convert.ToDecimal(Me.Grid.Item(18, 0).Value) > 0) Then
            If (ExisteCierreCajaChicaBs()) Then
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCajaChica2 set MontoD=@MontoD,Monto=@Monto, Relacionado=@Relacionado,Resta=@Resta,RelacionadoD=@RelacionadoD,RestaD=@RestaD, TotalGeneral=@TotalGeneral,TotalGeneralD=@TotalGeneralD WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='Bs.'", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                    Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value)))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value)))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                End If
                Desconectar()
            Else
                GuardarCajaChicaBs()
            End If
            ' End If
            '  If (Convert.ToDecimal(Me.Grid.Item(17, 1).Value) > 0) Then
            If (ExisteCierreCajaChicaDolar()) Then
                If (Conectar()) Then
                    Dim Comando As New SqlCommand("UPDATE TCajaChica2 set MontoD=@MontoD,Monto=@Monto, Relacionado=@Relacionado,Resta=@Resta,RelacionadoD=@RelacionadoD,RestaD=@RestaD, TotalGeneral=@TotalGeneral,TotalGeneralD=@TotalGeneralD WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='$'", CNN)
                    Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                    Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value)))
                    Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value)))
                    Dim DR As SqlDataReader = Comando.ExecuteReader()
                    DR.Close()
                End If
                Desconectar()
            Else
                GuardarCajaChicaDolar()
            End If
            '  End If
        End If
    End Sub

    Public Sub ActualizarNuevoSaldo(FechaHoy As Date, idAgregado As Integer)
        Dim EgresoD As Decimal = 0
        Dim Egreso As Decimal = 0
        Dim IngresoD As Decimal = 0
        Dim Ingreso As Decimal = 0
        Try
            If (Conectar4()) Then
                Dim Comando4 As New SqlCommand("Select idCajaChica, TotalGeneral, TotalGeneralD FROM VCajaChica WHERE Fecha<@Fecha ORDER BY Fecha DESC", CNN4)
                Comando4.Parameters.AddWithValue("@Fecha", FechaHoy.Date)
                Dim DR4 As SqlDataReader = Comando4.ExecuteReader()
                If (DR4.Read()) Then
                    SaldoAntCajaChica = Format(DR4("TotalGeneral"), "##,##0.00")
                    SaldoAntCajaChicaD = Format(DR4("TotalGeneralD"), "##,##0.00")
                Else
                    SaldoAntCajaChica = 0
                    SaldoAntCajaChicaD = 0
                End If
                DR4.Close()
                Comando4.CommandText = "SELECT SUM(Monto) as Egreso FROM VCajaChica WHERE Moneda='Bs.'  AND Fecha=@Fecha1 AND Descontar=1"
                Comando4.Parameters.AddWithValue("@Fecha1", FechaHoy.Date)
                DR4 = Comando4.ExecuteReader()
                If (DR4.Read()) Then
                    Egreso = IIf(DR4("Egreso").ToString = "", 0, DR4("Egreso"))
                Else
                    Egreso = 0
                End If
                DR4.Close()
                Comando4.CommandText = "SELECT SUM(MontoD) as EgresoD FROM VCajaChica WHERE Moneda='$'  AND Fecha=@Fecha2 AND Descontar=1"
                Comando4.Parameters.AddWithValue("@Fecha2", FechaHoy.Date)
                DR4 = Comando4.ExecuteReader()
                If (DR4.Read()) Then
                    EgresoD = IIf(DR4("EgresoD").ToString = "", 0, DR4("EgresoD"))
                Else
                    EgresoD = 0
                End If
                DR4.Close()
                Comando4.CommandText = "SELECT SUM(Monto) as Ingreso FROM VCajaChica WHERE Moneda='Bs.'  AND Fecha=@Fecha3 AND Descontar=0"
                Comando4.Parameters.AddWithValue("@Fecha3", FechaHoy.Date)
                DR4 = Comando4.ExecuteReader()
                If (DR4.Read()) Then
                    Ingreso = IIf(DR4("Ingreso").ToString = "", 0, DR4("Ingreso"))
                Else
                    Ingreso = 0
                End If
                DR4.Close()
                Comando4.CommandText = "SELECT SUM(MontoD) as IngresoD FROM VCajaChica WHERE Moneda='$'  AND Fecha=@Fecha4 AND Descontar=0"
                Comando4.Parameters.AddWithValue("@Fecha4", FechaHoy.Date)
                DR4 = Comando4.ExecuteReader()
                If (DR4.Read()) Then
                    IngresoD = IIf(DR4("IngresoD").ToString = "", 0, DR4("IngresoD"))
                Else
                    IngresoD = 0
                End If
                DR4.Close()
                Comando4.CommandText = "Update TCajaChica set TotalGeneralD=@TotalGeneralD,TotalGeneral=@TotalGeneral WHERE idCajaChica =" & idAgregado
                Comando4.Parameters.Add(New SqlParameter("@TotalGeneral", (SaldoAntCajaChica + Ingreso) - Egreso))
                Comando4.Parameters.Add(New SqlParameter("@TotalGeneralD", (SaldoAntCajaChicaD + IngresoD) - EgresoD))
                DR4 = Comando4.ExecuteReader()
                DR4.Close()
            End If
            Desconectar4()
        Catch ex As Exception
            MessageBox.Show("ERROR al Buscar Saldo Anterior de Caja Chica. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar4()
        End Try
    End Sub

    Private Sub GuardarCajaChicaBs()
        If (CajaChicaActiva = "Caja Chica 1") Then
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TCajaChica (Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen, Tasa, NFactura, idCompra) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen, @Tasa, @NFactura,@idCompraFactura)", CNN)
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Moneda", "Bs."))
                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Tasa", BsXDolarBC)) 'Convert.ToDecimal(Me.Grid.Rows(I).Cells("Tasa").Value)))
                Comando.Parameters.Add(New SqlParameter("@NFactura", ""))
                Comando.Parameters.Add(New SqlParameter("@idCompraFactura", 0))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                DataT4 = New DataTable
                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
                Adaptador4.Fill(DataT4)
                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
            End If
            Desconectar()
            ActualizarNuevoSaldo(Me.FechaApertura.Value, IdCajaChicaAux)
        Else
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TCajaChica2(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen)", CNN)
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Moneda", "Bs."))
                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 0).Value)))
                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))

                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                DataT4 = New DataTable
                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
                Adaptador4.Fill(DataT4)
                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
            End If
            Desconectar()
            ActualizarNuevoSaldo(Me.FechaApertura.Value, IdCajaChicaAux)
        End If
    End Sub
    Private Sub GuardarCajaChicaDolar()
        If (CajaChicaActiva = "Caja Chica 1") Then
            '  If (Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) > 0) Then
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TCajaChica(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen, Tasa, NFactura, idCompra) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen, @Tasa, @NFactura,@idCompraFactura)", CNN)
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Moneda", "$"))
                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Tasa", BsXDolarBC)) 'Convert.ToDecimal(Me.Grid.Rows(I).Cells("Tasa").Value)))
                Comando.Parameters.Add(New SqlParameter("@NFactura", ""))
                Comando.Parameters.Add(New SqlParameter("@idCompraFactura", 0))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                DataT4 = New DataTable
                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
                Adaptador4.Fill(DataT4)
                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
            End If
            Desconectar()
            ActualizarNuevoSaldo(Me.FechaApertura.Value, IdCajaChicaAux)
            '  End If
        Else
            '   If (Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) > 0) Then
            If (Conectar()) Then
                Dim Comando As New SqlCommand("INSERT INTO TCajaChica2(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen)", CNN)
                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                Comando.Parameters.Add(New SqlParameter("@Moneda", "$"))
                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))

                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value)))
                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                DataT4 = New DataTable
                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
                Adaptador4.Fill(DataT4)
                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
            End If
            Desconectar()
            ActualizarNuevoSaldo(Me.FechaApertura.Value, IdCajaChicaAux)
            ' End If
        End If
    End Sub


    'Private Sub GuardarCajaChicaBs()
    '    If (CajaChicaActiva = "Caja Chica 1") Then
    '        If (Convert.ToDecimal(Me.Grid.Item(18, 0).Value) > 0) Then
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("INSERT INTO TCajaChica(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen, Tasa, NFactura, idCompra) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen, @Tasa, @NFactura,@idCompraFactura)", CNN)
    '                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
    '                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Moneda", "Bs."))
    '                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
    '                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
    '                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
    '                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
    '                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
    '                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
    '                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
    '                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
    '                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
    '                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
    '                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Tasa", BsXDolarBC)) 'Convert.ToDecimal(Me.Grid.Rows(I).Cells("Tasa").Value)))
    '                Comando.Parameters.Add(New SqlParameter("@NFactura", ""))
    '                Comando.Parameters.Add(New SqlParameter("@idCompraFactura", 0))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                DataT4 = New DataTable
    '                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
    '                Adaptador4.Fill(DataT4)
    '                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
    '                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
    '            End If
    '            Desconectar()
    '            ActualizarNuevoSaldo(Me.Fecha.Value, IdCajaChicaAux)
    '        End If

    '        If (Convert.ToDecimal(Me.Grid.Item(17, 1).Value) > 0) Then
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("INSERT INTO TCajaChica(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen, Tasa, NFactura, idCompra) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen, @Tasa, @NFactura,@idCompraFactura)", CNN)
    '                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
    '                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Moneda", "$"))
    '                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
    '                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
    '                Comando.Parameters.Add(New SqlParameter("@Comentario", "Enviado desde " & CajaActiva & "."))
    '                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
    '                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
    '                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
    '                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
    '                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
    '                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
    '                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
    '                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Tasa", BsXDolarBC)) 'Convert.ToDecimal(Me.Grid.Rows(I).Cells("Tasa").Value)))
    '                Comando.Parameters.Add(New SqlParameter("@NFactura", ""))
    '                Comando.Parameters.Add(New SqlParameter("@idCompraFactura", 0))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                DataT4 = New DataTable
    '                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
    '                Adaptador4.Fill(DataT4)
    '                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
    '                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
    '            End If
    '            Desconectar()
    '            ActualizarNuevoSaldo(Me.Fecha.Value, IdCajaChicaAux)
    '        End If
    '    Else
    '        If (Convert.ToDecimal(Me.Grid.Item(18, 0).Value) > 0) Then
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("INSERT INTO TCajaChica2(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen)", CNN)
    '                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
    '                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Moneda", "Bs."))
    '                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
    '                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
    '                Comando.Parameters.Add(New SqlParameter("@Comentario", ""))
    '                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item(17, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item(18, 0).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
    '                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
    '                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
    '                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
    '                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
    '                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
    '                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
    '                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))

    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                DataT4 = New DataTable
    '                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
    '                Adaptador4.Fill(DataT4)
    '                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
    '                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
    '            End If
    '            Desconectar()
    '            ActualizarNuevoSaldo(Me.Fecha.Value, IdCajaChicaAux)
    '        End If

    '        If (Convert.ToDecimal(Me.Grid.Item(17, 1).Value) > 0) Then
    '            If (Conectar()) Then
    '                Dim Comando As New SqlCommand("INSERT INTO TCajaChica2(Fecha,FechaAplicacion,idCategoria, idSubCategoria,idEmpleado,GastoExt,Proveedor, Proviene,Moneda, TipoPago, MontoD,Monto, idEntrega, idRecibe,Comentario, Relacionado,Resta,RelacionadoD,RestaD, TotalGeneral,TotalGeneralD, Descontar,idGastos, idTipoExc, idFueraPresup, MontoExceso, ComentExcPresup, Responsable, idUnion,Origen) VALUES(@Fecha,@FechaAplicacion,@idCategoria,@idSubCategoria,@idEmpleado,@GastoExt,@Proveedor,@Proviene,@Moneda,@TipoPago,@MontoD,@Monto,@idEntrega,@idRecibe,@Comentario,@Relacionado,@Resta,@RelacionadoD,@RestaD,@TotalGeneral,@TotalGeneralD,@Descontar,@idGastos,@idTipoExc,@idFueraPresup,@MontoExceso,@ComentExcPresup,@Responsable,0,@Origen)", CNN)
    '                Comando.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
    '                Comando.Parameters.Add(New SqlParameter("@idCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
    '                Comando.Parameters.Add(New SqlParameter("@idEmpleado", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@GastoExt", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Proveedor", -1))
    '                Comando.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
    '                Comando.Parameters.Add(New SqlParameter("@Moneda", "$"))
    '                Comando.Parameters.Add(New SqlParameter("@TipoPago", "Efectivo"))
    '                Comando.Parameters.Add(New SqlParameter("@MontoD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Monto", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@idEntrega", CodCajero))
    '                Comando.Parameters.Add(New SqlParameter("@idRecibe", CodEmpleado))
    '                Comando.Parameters.Add(New SqlParameter("@Comentario", ""))
    '                Comando.Parameters.Add(New SqlParameter("@RestaD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Resta", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@RelacionadoD", 0))
    '                Comando.Parameters.Add(New SqlParameter("@Relacionado", 0))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneralD", Convert.ToDecimal(Me.Grid.Item(17, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@TotalGeneral", Convert.ToDecimal(Me.Grid.Item(18, 1).Value)))
    '                Comando.Parameters.Add(New SqlParameter("@Descontar", False))
    '                Comando.Parameters.Add(New SqlParameter("@idGastos", -1))
    '                Comando.Parameters.Add(New SqlParameter("@idTipoExc", 1))
    '                Comando.Parameters.Add(New SqlParameter("@idFueraPresup", 1))
    '                Comando.Parameters.Add(New SqlParameter("@MontoExceso", 0))
    '                Comando.Parameters.Add(New SqlParameter("@ComentExcPresup", ""))
    '                Comando.Parameters.Add(New SqlParameter("@Responsable", 54))
    '                Comando.Parameters.Add(New SqlParameter("@Origen", CajaActiva))
    '                Dim DR As SqlDataReader = Comando.ExecuteReader()
    '                DR.Close()
    '                DataT4 = New DataTable
    '                Adaptador4 = New SqlDataAdapter("Select * FROM TCajaChica", CNN)
    '                Adaptador4.Fill(DataT4)
    '                Dim Fila4 As DataRow = DataT4.Rows(DataT4.Rows.Count - 1)
    '                IdCajaChicaAux = Trim(Fila4("idCajaChica"))
    '            End If
    '            Desconectar()
    '            ActualizarNuevoSaldo(Me.Fecha.Value, IdCajaChicaAux)
    '        End If
    '    End If
    'End Sub

    Private Sub GuardarCierreCaja()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("INSERT INTO TCierreCaja (idCierre, FechaInicio, FechaCierre, idCaja, idCajero, Usuario, idResponsable, Comentario, AperturaD, Apertura, AperturaD1, Apertura1, VentasD, Ventas, VentasD1, Ventas1, VentasD2, Ventas2, VentasD3, Ventas3, VentasD4, Ventas4, VentasD5, Ventas5, VentasD6, Ventas6, VentasD7, Ventas7, IngresosD, Ingresos, IngresosD1, Ingresos1, IngresosD2, Ingresos2, IngresosD3, Ingresos3, IngresosD4, Ingresos4, IngresosD5, Ingresos5, EgresosD, Egresos, EgresosD1, Egresos1, EgresosD2, Egresos2, EgresosD3, Egresos3, EgresosD4, Egresos4, EgresosD5, Egresos5, RealD, Real, RealD1, Real1, RealD2, Real2, RealD3, Real3, TTotalD, TTotal, TRealD, TReal, TDiferenciaD, TDiferencia, EfectivoEnt, DivisaEnt, TarjetaEnt, BioPagoEnt, TransferenciaEnt, PagoMovilEnt) VALUES (@idCierre, @FechaInicio, @FechaCierre, @idCaja, @idCajero, @Usuario, @idResponsable, @Comentario, @AperturaD, @Apertura, @AperturaD1, @Apertura1, @VentasD, @Ventas, @VentasD1, @Ventas1, @VentasD2, @Ventas2, @VentasD3, @Ventas3, @VentasD4, @Ventas4, @VentasD5, @Ventas5, @VentasD6, @Ventas6, @VentasD7, @Ventas7, @IngresosD, @Ingresos, @IngresosD1, @Ingresos1, @IngresosD2, @Ingresos2, @IngresosD3, @Ingresos3, @IngresosD4, @Ingresos4, @IngresosD5, @Ingresos5, @EgresosD, @Egresos, @EgresosD1, @Egresos1, @EgresosD2, @Egresos2, @EgresosD3, @Egresos3, @EgresosD4, @Egresos4, @EgresosD5, @Egresos5, @RealD, @Real, @RealD1, @Real1, @RealD2, @Real2, @RealD3, @Real3, @TTotalD, @TTotal, @TRealD, @TReal, @TDiferenciaD, @TDiferencia, @EfectivoEnt, @DivisaEnt, @TarjetaEnt, @BioPagoEnt, @TransferenciaEnt, @PagoMovilEnt) ", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCierre", CodApertura))
                Comando.Parameters.Add(New SqlParameter("@FechaInicio", Me.FechaApertura.Value))
                Comando.Parameters.Add(New SqlParameter("@FechaCierre", Me.FechaCierre.Value))
                Comando.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
                Comando.Parameters.Add(New SqlParameter("@idCajero", CodCajero))
                Comando.Parameters.Add(New SqlParameter("@Usuario", CUsuario.Text))
                Comando.Parameters.Add(New SqlParameter("@idResponsable", Me.CResponsableDif.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@Comentario", Me.TComentario.Text))

                'APERTURA
                Comando.Parameters.Add(New SqlParameter("@AperturaD", Convert.ToDecimal(IIf(Me.Grid.Item("AperturaD", 0).Value.ToString = "", 0, Me.Grid.Item("AperturaD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Apertura", Convert.ToDecimal(IIf(Me.Grid.Item("Apertura", 0).Value.ToString = "", 0, Me.Grid.Item("Apertura", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@AperturaD1", Convert.ToDecimal(IIf(Me.Grid.Item("AperturaD", 1).Value.ToString = "", 0, Me.Grid.Item("AperturaD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Apertura1", Convert.ToDecimal(IIf(Me.Grid.Item("Apertura", 1).Value.ToString = "", 0, Me.Grid.Item("Apertura", 1).Value))))

                'VentasS
                Comando.Parameters.Add(New SqlParameter("@VentasD", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 0).Value.ToString = "", 0, Me.Grid.Item("VentasD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 0).Value.ToString = "", 0, Me.Grid.Item("Ventas", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD1", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 1).Value.ToString = "", 0, Me.Grid.Item("VentasD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas1", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 1).Value.ToString = "", 0, Me.Grid.Item("Ventas", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD2", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 2).Value.ToString = "", 0, Me.Grid.Item("VentasD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas2", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 2).Value.ToString = "", 0, Me.Grid.Item("Ventas", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD3", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 3).Value.ToString = "", 0, Me.Grid.Item("VentasD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas3", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 3).Value.ToString = "", 0, Me.Grid.Item("Ventas", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD4", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 4).Value.ToString = "", 0, Me.Grid.Item("VentasD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas4", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 4).Value.ToString = "", 0, Me.Grid.Item("Ventas", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD5", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 5).Value.ToString = "", 0, Me.Grid.Item("VentasD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas5", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 5).Value.ToString = "", 0, Me.Grid.Item("Ventas", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD6", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 6).Value.ToString = "", 0, Me.Grid.Item("VentasD", 6).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas6", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 6).Value.ToString = "", 0, Me.Grid.Item("Ventas", 6).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD7", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 7).Value.ToString = "", 0, Me.Grid.Item("VentasD", 7).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas7", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 7).Value.ToString = "", 0, Me.Grid.Item("Ventas", 7).Value))))

                'INGRESOS
                Comando.Parameters.Add(New SqlParameter("@IngresosD", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 0).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 0).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD1", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 1).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos1", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 1).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD2", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 2).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos2", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 2).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD3", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 3).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos3", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 3).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD4", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 4).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos4", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 4).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD5", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 5).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos5", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 5).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 5).Value))))

                'EGRESOS
                Comando.Parameters.Add(New SqlParameter("@EgresosD", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 0).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 0).Value.ToString = "", 0, Me.Grid.Item("Egresos", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD1", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 1).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos1", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 1).Value.ToString = "", 0, Me.Grid.Item("Egresos", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD2", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 2).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos2", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 2).Value.ToString = "", 0, Me.Grid.Item("Egresos", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD3", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 3).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos3", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 3).Value.ToString = "", 0, Me.Grid.Item("Egresos", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD4", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 4).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos4", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 4).Value.ToString = "", 0, Me.Grid.Item("Egresos", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD5", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 5).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos5", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 5).Value.ToString = "", 0, Me.Grid.Item("Egresos", 5).Value))))

                'REAL
                Comando.Parameters.Add(New SqlParameter("@RealD", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 0).Value.ToString = "", 0, Me.Grid.Item("RealD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 0).Value.ToString = "", 0, Me.Grid.Item("Real", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD1", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 1).Value.ToString = "", 0, Me.Grid.Item("RealD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real1", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 1).Value.ToString = "", 0, Me.Grid.Item("Real", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD2", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 2).Value.ToString = "", 0, Me.Grid.Item("RealD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real2", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 2).Value.ToString = "", 0, Me.Grid.Item("Real", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD3", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 3).Value.ToString = "", 0, Me.Grid.Item("RealD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real3", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 3).Value.ToString = "", 0, Me.Grid.Item("Real", 3).Value))))

                'TOTALES
                Comando.Parameters.Add(New SqlParameter("@TTotalD", Convert.ToDecimal(IIf(Me.Grid.Item("TotalD2", 8).Value.ToString = "", 8, Me.Grid.Item("TotalD2", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TTotal", Convert.ToDecimal(IIf(Me.Grid.Item("Total2", 8).Value.ToString = "", 8, Me.Grid.Item("Total2", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TRealD", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 8).Value.ToString = "", 8, Me.Grid.Item("RealD", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TReal", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 8).Value.ToString = "", 8, Me.Grid.Item("Real", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TDiferenciaD", Convert.ToDecimal(IIf(Me.Grid.Item("DiferenciaD", 8).Value.ToString = "", 8, Me.Grid.Item("DiferenciaD", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TDiferencia", Convert.ToDecimal(IIf(Me.Grid.Item("Diferencia", 8).Value.ToString = "", 8, Me.Grid.Item("Diferencia", 8).Value))))

                'ENTRANTES
                Comando.Parameters.Add(New SqlParameter("@EfectivoEnt", EfectivoEntrante))                
                Comando.Parameters.Add(New SqlParameter("@DivisaEnt", DivisaEntrante))
                Comando.Parameters.Add(New SqlParameter("@TarjetaEnt", TarjetaEntrante))
                Comando.Parameters.Add(New SqlParameter("@BioPagoEnt", BioPagoEntrante))
                Comando.Parameters.Add(New SqlParameter("@TransferenciaEnt", TransferenciaEntrante))
                Comando.Parameters.Add(New SqlParameter("@PagoMovilent", PagoMovilEntrante))


                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                Comando.CommandText = "UPDATE TCajas SET Estado=0, CodCajero=0 WHERE id=" & CodCajaActiva
                DR = Comando.ExecuteReader
                DR.Close()
                Desconectar()
                Me.Close()
                GuardarCajaChicaBs()
                GuardarCajaChicaDolar()
                ' FCajaNew.Close()
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Guardar los Datos del Cierre Caja.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
    End Sub

    Private Sub ActualizarCierreCaja()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TCierreCaja SET idResponsable=@idResponsable, Comentario=@Comentario, AperturaD=@AperturaD, Apertura=@Apertura, AperturaD1=@AperturaD1, Apertura1=@Apertura1, VentasD=@VentasD, Ventas=@Ventas, VentasD1=@VentasD1, Ventas1=@Ventas1, VentasD2=@VentasD2, Ventas2=@Ventas2, VentasD3=@VentasD3, Ventas3=@Ventas3, VentasD4=@VentasD4, Ventas4=@Ventas4, VentasD5=@VentasD5, Ventas5=@Ventas5, VentasD6=@VentasD6, Ventas6=@Ventas6, VentasD7=@VentasD7, Ventas7=@Ventas7, IngresosD=@IngresosD, Ingresos=@Ingresos, IngresosD1=@IngresosD1, Ingresos1=@Ingresos1, IngresosD2=@IngresosD2, Ingresos2=@Ingresos2, IngresosD3=@IngresosD3, Ingresos3=@Ingresos3, IngresosD4=@IngresosD4, Ingresos4=@Ingresos4, IngresosD5=@IngresosD5, Ingresos5=@Ingresos5, EgresosD=@EgresosD, Egresos=@Egresos, EgresosD1=@EgresosD1, Egresos1=@Egresos1, EgresosD2=@EgresosD2, Egresos2=@Egresos2, EgresosD3=@EgresosD3, Egresos3=@Egresos3, EgresosD4=@EgresosD4, Egresos4=@Egresos4, EgresosD5=@EgresosD5, Egresos5=@Egresos5, RealD=@RealD, Real=@Real, RealD1=@RealD1, Real1=@Real1, RealD2=@RealD2, Real2=@Real2, RealD3=@RealD3, Real3=@Real3, TTotalD=@TTotalD, TTotal=@TTotal, TRealD=@TRealD, TReal=@TReal, TDiferenciaD=@TDiferenciaD, TDiferencia=@TDiferencia, EfectivoEnt=@EfectivoEnt, DivisaEnt=@DivisaEnt, TarjetaEnt=@TarjetaEnt, BioPagoEnt=@BioPagoEnt, TransferenciaEnt=@TransferenciaEnt, PagoMovilEnt=@PagoMovilEnt WHERE idCierre=@idCierre", CNN)
                Comando.Parameters.Add(New SqlParameter("@idCierre", CodApertura))
                Comando.Parameters.Add(New SqlParameter("@idResponsable", Me.CResponsableDif.SelectedValue))
                Comando.Parameters.Add(New SqlParameter("@Comentario", Me.TComentario.Text))

                'APERTURA
                Comando.Parameters.Add(New SqlParameter("@AperturaD", Convert.ToDecimal(IIf(Me.Grid.Item("AperturaD", 0).Value.ToString = "", 0, Me.Grid.Item("AperturaD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Apertura", Convert.ToDecimal(IIf(Me.Grid.Item("Apertura", 0).Value.ToString = "", 0, Me.Grid.Item("Apertura", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@AperturaD1", Convert.ToDecimal(IIf(Me.Grid.Item("AperturaD", 1).Value.ToString = "", 0, Me.Grid.Item("AperturaD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Apertura1", Convert.ToDecimal(IIf(Me.Grid.Item("Apertura", 1).Value.ToString = "", 0, Me.Grid.Item("Apertura", 1).Value))))

                'Ventas
                Comando.Parameters.Add(New SqlParameter("@VentasD", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 0).Value.ToString = "", 0, Me.Grid.Item("VentasD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 0).Value.ToString = "", 0, Me.Grid.Item("Ventas", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD1", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 1).Value.ToString = "", 0, Me.Grid.Item("VentasD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas1", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 1).Value.ToString = "", 0, Me.Grid.Item("Ventas", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD2", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 2).Value.ToString = "", 0, Me.Grid.Item("VentasD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas2", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 2).Value.ToString = "", 0, Me.Grid.Item("Ventas", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD3", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 3).Value.ToString = "", 0, Me.Grid.Item("VentasD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas3", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 3).Value.ToString = "", 0, Me.Grid.Item("Ventas", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD4", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 4).Value.ToString = "", 0, Me.Grid.Item("VentasD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas4", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 4).Value.ToString = "", 0, Me.Grid.Item("Ventas", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD5", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 5).Value.ToString = "", 0, Me.Grid.Item("VentasD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas5", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 5).Value.ToString = "", 0, Me.Grid.Item("Ventas", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD6", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 6).Value.ToString = "", 0, Me.Grid.Item("VentasD", 6).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas6", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 6).Value.ToString = "", 0, Me.Grid.Item("Ventas", 6).Value))))
                Comando.Parameters.Add(New SqlParameter("@VentasD7", Convert.ToDecimal(IIf(Me.Grid.Item("VentasD", 7).Value.ToString = "", 0, Me.Grid.Item("VentasD", 7).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ventas7", Convert.ToDecimal(IIf(Me.Grid.Item("Ventas", 7).Value.ToString = "", 0, Me.Grid.Item("Ventas", 7).Value))))

                'INGRESOS
                Comando.Parameters.Add(New SqlParameter("@IngresosD", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 0).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 0).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD1", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 1).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos1", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 1).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD2", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 2).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos2", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 2).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD3", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 3).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos3", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 3).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD4", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 4).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos4", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 4).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@IngresosD5", Convert.ToDecimal(IIf(Me.Grid.Item("IngresosD", 5).Value.ToString = "", 0, Me.Grid.Item("IngresosD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Ingresos5", Convert.ToDecimal(IIf(Me.Grid.Item("Ingresos", 5).Value.ToString = "", 0, Me.Grid.Item("Ingresos", 5).Value))))

                'EGRESOS
                Comando.Parameters.Add(New SqlParameter("@EgresosD", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 0).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 0).Value.ToString = "", 0, Me.Grid.Item("Egresos", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD1", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 1).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos1", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 1).Value.ToString = "", 0, Me.Grid.Item("Egresos", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD2", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 2).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos2", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 2).Value.ToString = "", 0, Me.Grid.Item("Egresos", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD3", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 3).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos3", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 3).Value.ToString = "", 0, Me.Grid.Item("Egresos", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD4", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 4).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos4", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 4).Value.ToString = "", 0, Me.Grid.Item("Egresos", 4).Value))))
                Comando.Parameters.Add(New SqlParameter("@EgresosD5", Convert.ToDecimal(IIf(Me.Grid.Item("EgresosD", 5).Value.ToString = "", 0, Me.Grid.Item("EgresosD", 5).Value))))
                Comando.Parameters.Add(New SqlParameter("@Egresos5", Convert.ToDecimal(IIf(Me.Grid.Item("Egresos", 5).Value.ToString = "", 0, Me.Grid.Item("Egresos", 5).Value))))

                'REAL
                Comando.Parameters.Add(New SqlParameter("@RealD", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 0).Value.ToString = "", 0, Me.Grid.Item("RealD", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 0).Value.ToString = "", 0, Me.Grid.Item("Real", 0).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD1", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 1).Value.ToString = "", 0, Me.Grid.Item("RealD", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real1", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 1).Value.ToString = "", 0, Me.Grid.Item("Real", 1).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD2", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 2).Value.ToString = "", 0, Me.Grid.Item("RealD", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real2", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 2).Value.ToString = "", 0, Me.Grid.Item("Real", 2).Value))))
                Comando.Parameters.Add(New SqlParameter("@RealD3", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 3).Value.ToString = "", 0, Me.Grid.Item("RealD", 3).Value))))
                Comando.Parameters.Add(New SqlParameter("@Real3", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 3).Value.ToString = "", 0, Me.Grid.Item("Real", 3).Value))))

                'TOTALES
                Comando.Parameters.Add(New SqlParameter("@TTotalD", Convert.ToDecimal(IIf(Me.Grid.Item("TotalD2", 8).Value.ToString = "", 8, Me.Grid.Item("TotalD2", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TTotal", Convert.ToDecimal(IIf(Me.Grid.Item("Total2", 8).Value.ToString = "", 8, Me.Grid.Item("Total2", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TRealD", Convert.ToDecimal(IIf(Me.Grid.Item("RealD", 8).Value.ToString = "", 8, Me.Grid.Item("RealD", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TReal", Convert.ToDecimal(IIf(Me.Grid.Item("Real", 8).Value.ToString = "", 8, Me.Grid.Item("Real", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TDiferenciaD", Convert.ToDecimal(IIf(Me.Grid.Item("DiferenciaD", 8).Value.ToString = "", 8, Me.Grid.Item("DiferenciaD", 8).Value))))
                Comando.Parameters.Add(New SqlParameter("@TDiferencia", Convert.ToDecimal(IIf(Me.Grid.Item("Diferencia", 8).Value.ToString = "", 8, Me.Grid.Item("Diferencia", 8).Value))))

                'ENTRANTES
                Comando.Parameters.Add(New SqlParameter("@EfectivoEnt", EfectivoEntrante))
                Comando.Parameters.Add(New SqlParameter("@DivisaEnt", DivisaEntrante))
                Comando.Parameters.Add(New SqlParameter("@TarjetaEnt", TarjetaEntrante))
                Comando.Parameters.Add(New SqlParameter("@BioPagoEnt", BioPagoEntrante))
                Comando.Parameters.Add(New SqlParameter("@TransferenciaEnt", TransferenciaEntrante))
                Comando.Parameters.Add(New SqlParameter("@PagoMovilent", PagoMovilEntrante))

                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
            Catch ex As Exception
                Cursor = System.Windows.Forms.Cursors.Default
                MsgBox("Error al Guardar los Datos del Cierre Caja.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
        Desconectar()
        ActualizarCajaChica()
    End Sub
    Function ExisteCierre() As Boolean
        Dim Valor As Boolean = False
        If (Conectar5()) Then
            Try
                Dim Comando5 As New SqlCommand("SELECT * FROM TCierreCaja WHERE idCierre=@idCierre", CNN5)
                Comando5.Parameters.Add(New SqlParameter("@idCierre", CodApertura))
                Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                If (DR5.Read) Then
                    Valor = True
                End If
                DR5.Close()
            Catch ex As Exception
                MsgBox("Error de Datos... " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar5()
            End Try
        End If
        Desconectar5()
        Return (Valor)
    End Function
    Function ExisteCierreCajaChicaBs() As Boolean
        Dim Valor As Boolean = False
        If (CajaChicaActiva = "Caja Chica 1") Then
            If (Conectar5()) Then
                Try
                    Dim Comando5 As New SqlCommand("SELECT * FROM TCajaChica WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='Bs.'", CNN5)
                    Comando5.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                    If (DR5.Read) Then
                        Valor = True
                    End If
                    DR5.Close()
                Catch ex As Exception
                    MsgBox("Error de Datos... " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar5()
                End Try
            End If
            Desconectar5()
        Else
            If (Conectar5()) Then
                Try
                    Dim Comando5 As New SqlCommand("SELECT * FROM TCajaChica2 WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='Bs.'", CNN5)
                    Comando5.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                    If (DR5.Read) Then
                        Valor = True
                    End If
                    DR5.Close()
                Catch ex As Exception
                    MsgBox("Error de Datos... " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar5()
                End Try
            End If
            Desconectar5()
        End If
        Return (Valor)
    End Function

    Function ExisteCierreCajaChicaDolar() As Boolean
        Dim Valor As Boolean = False
        If (CajaChicaActiva = "Caja Chica 1") Then
            If (Conectar5()) Then
                Try
                    Dim Comando5 As New SqlCommand("SELECT * FROM TCajaChica WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='$'", CNN5)
                    Comando5.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                    If (DR5.Read) Then
                        Valor = True
                    End If
                    DR5.Close()
                Catch ex As Exception
                    MsgBox("Error de Datos... " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar5()
                End Try
            End If
            Desconectar5()
        Else
            If (Conectar5()) Then
                Try
                    Dim Comando5 As New SqlCommand("SELECT * FROM TCajaChica2 WHERE Fecha=@Fecha AND FechaAplicacion=@FechaAplicacion AND  idCategoria=8 and idSubCategoria=8 and Proviene=@Proviene and Moneda='$'", CNN5)
                    Comando5.Parameters.Add(New SqlParameter("@Fecha", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@FechaAplicacion", Me.FechaCierre.Value))
                    Comando5.Parameters.Add(New SqlParameter("@idCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@idSubCategoria", 8))
                    Comando5.Parameters.Add(New SqlParameter("@Proviene", CajaActiva))
                    Dim DR5 As SqlDataReader = Comando5.ExecuteReader()
                    If (DR5.Read) Then
                        Valor = True
                    End If
                    DR5.Close()
                Catch ex As Exception
                    MsgBox("Error de Datos... " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                    Desconectar5()
                End Try
            End If
            Desconectar5()
        End If
        Return (Valor)
    End Function

    'Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
    '    ValidarPermiso()
    '    If (TienePermiso) Then
    '        If (Me.CResponsableDif.Text <> " ") Then
    '            If (ExisteCierre() = True) Then
    '                ActivarGuardar = False
    '                FCierreCajaCajaChica.LSaldoD.Text = Me.Grid.Item("RealD", 1).Value
    '                FCierreCajaCajaChica.LSaldo.Text = Me.Grid.Item("Real", 0).Value
    '                FCierreCajaCajaChica.LEfectivo.Text = IIf(Me.Grid.Item("Ventas", 0).Value > 0, Me.Grid.Item("Ventas", 0).Value, 0)
    '                FCierreCajaCajaChica.LEfectivoD.Text = IIf(Me.Grid.Item("VentasD", 1).Value > 0, Me.Grid.Item("VentasD", 1).Value, 0)
    '                FCierreCajaCajaChica.LTarjetas.Text = IIf(Me.Grid.Item("Ventas", 2).Value > 0, Me.Grid.Item("Ventas", 2).Value, 0)
    '                FCierreCajaCajaChica.LBioPago.Text = IIf(Me.Grid.Item("Ventas", 3).Value > 0, Me.Grid.Item("Ventas", 3).Value, 0)
    '                FCierreCajaCajaChica.LTransferencias.Text = IIf(Me.Grid.Item("Ventas", 4).Value > 0, Me.Grid.Item("Ventas", 4).Value, 0)
    '                FCierreCajaCajaChica.LPagoMovil.Text = IIf(Me.Grid.Item("Ventas", 5).Value > 0, Me.Grid.Item("Ventas", 5).Value, 0)
    '                FCierreCajaCajaChica.LCreditos.Text = IIf(Me.Grid.Item("Ventas", 6).Value > 0, Me.Grid.Item("Ventas", 6).Value, 0)
    '                FCierreCajaCajaChica.LOtros.Text = IIf(Me.Grid.Item("Ventas", 7).Value > 0, Me.Grid.Item("Ventas", 7).Value, 0)
    '                FCierreCajaCajaChica.LTotal.Text = Me.LTotal.Text
    '                FCierreCajaCajaChica.LTotalD.Text = Me.LTotalD.Text
    '                FCierreCajaCajaChica.TCajero.Text = Me.TCajero.Text
    '                FCierreCajaCajaChica.Apertura.Value = Me.FechaApertura.Value
    '                FCierreCajaCajaChica.Cierre.Value = Me.FechaCierre.Value
    '                FCierreCajaCajaChica.ShowDialog()
    '                If (ActivarGuardar) Then
    '                    ActualizarCierreCaja()
    '                End If
    '            Else
    '                ActivarGuardar = False
    '                FCierreCajaCajaChica.LSaldoD.Text = Me.Grid.Item("RealD", 1).Value
    '                FCierreCajaCajaChica.LSaldo.Text = Me.Grid.Item("Real", 0).Value
    '                FCierreCajaCajaChica.LTarjetas.Text = IIf(Me.Grid.Item("Ventas", 2).Value > 0, Me.Grid.Item("Ventas", 2).Value, 0)
    '                FCierreCajaCajaChica.LBioPago.Text = IIf(Me.Grid.Item("Ventas", 3).Value > 0, Me.Grid.Item("Ventas", 3).Value, 0)
    '                FCierreCajaCajaChica.LTransferencias.Text = IIf(Me.Grid.Item("Ventas", 4).Value > 0, Me.Grid.Item("Ventas", 4).Value, 0)
    '                FCierreCajaCajaChica.LPagoMovil.Text = IIf(Me.Grid.Item("Ventas", 5).Value > 0, Me.Grid.Item("Ventas", 5).Value, 0)
    '                FCierreCajaCajaChica.LCreditos.Text = IIf(Me.Grid.Item("Ventas", 6).Value > 0, Me.Grid.Item("Ventas", 6).Value, 0)
    '                FCierreCajaCajaChica.LOtros.Text = IIf(Me.Grid.Item("Ventas", 7).Value > 0, Me.Grid.Item("Ventas", 7).Value, 0)
    '                FCierreCajaCajaChica.LTotal.Text = Me.LTotal.Text
    '                FCierreCajaCajaChica.LTotalD.Text = Me.LTotalD.Text
    '                FCierreCajaCajaChica.LEfectivoD.Text = IIf(Me.Grid.Item("VentasD", 1).Value > 0, Me.Grid.Item("VentasD", 1).Value, 0)
    '                FCierreCajaCajaChica.LEfectivo.Text = IIf(Me.Grid.Item("Ventas", 0).Value > 0, Me.Grid.Item("Ventas", 0).Value, 0)
    '                FCierreCajaCajaChica.TCajero.Text = Me.TCajero.Text
    '                FCierreCajaCajaChica.Apertura.Value = Me.FechaApertura.Value
    '                FCierreCajaCajaChica.Cierre.Value = Me.FechaCierre.Value
    '                FCierreCajaCajaChica.ShowDialog()
    '                If (ActivarGuardar) Then
    '                    GuardarCierreCaja()
    '                End If
    '            End If
    '        Else
    '            Cursor = System.Windows.Forms.Cursors.Default
    '            MsgBox("Debe Seleccionar el Responsable de Diferencia de Caja.", MsgBoxStyle.Information, "MarSoft: Información.")
    '            Me.CResponsableDif.Focus()
    '        End If
    '    End If
    'End Sub
    Private Sub TotalizarCuentaReal()
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        'SUMAR TOTAL........................................................................
        Me.Grid.Item("Total2", 0).Value = Format((Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value) + EfectivoEntrante + Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value)) - Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value), "##,##0.00")
        Me.Grid.Item("TotalD2", 1).Value = Format((Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value) + DivisaEntrante + Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value)) - Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value), "##,##0.00")
        Me.Grid.Item("Total2", 2).Value = Format((TarjetaEntrante + Convert.ToDecimal(Me.Grid.Item("Ingresos", 2).Value)) - Convert.ToDecimal(Me.Grid.Item("Egresos", 2).Value), "##,##0.00")
        Me.Grid.Item("Total2", 3).Value = Format((BioPagoEntrante + Convert.ToDecimal(Me.Grid.Item("Ingresos", 3).Value)) - Convert.ToDecimal(Me.Grid.Item("Egresos", 3).Value), "##,##0.00")
        Me.Grid.Item("Total2", 4).Value = Format((TransferenciaEntrante + Convert.ToDecimal(Me.Grid.Item("Ingresos", 4).Value)) - Convert.ToDecimal(Me.Grid.Item("Egresos", 4).Value), "##,##0.00")
        Me.Grid.Item("Total2", 5).Value = Format((PagoMovilEntrante + Convert.ToDecimal(Me.Grid.Item("Ingresos", 5).Value)) - Convert.ToDecimal(Me.Grid.Item("Egresos", 5).Value), "##,##0.00")
        Me.Grid.Item("Total2", 6).Value = Convert.ToDecimal(Me.Grid.Item("Ventas", 6).Value)
        Me.Grid.Item("Total2", 7).Value = Convert.ToDecimal(Me.Grid.Item("Ventas", 7).Value)
        Me.TEntranteD.Text = VFormat(DivisaEntrante, 2)
        Me.TEntranteBs.Text = VFormat(EfectivoEntrante, 2)

        'IGUALAR REALES
        Me.Grid.Item("Real", 4).Value = Me.Grid.Item("Total2", 4).Value
        Me.Grid.Item("Real", 5).Value = Me.Grid.Item("Total2", 5).Value
        Me.Grid.Item("Real", 6).Value = Me.Grid.Item("Total2", 6).Value
        Me.Grid.Item("Real", 7).Value = Me.Grid.Item("Total2", 7).Value

        'CALCULAR DIFERENCIA........................................................................
        Me.Grid.Item("DiferenciaD", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 0).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 1).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 2).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 2).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 3).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 3).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 4).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 4).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 5).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 5).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 6).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 6).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 6).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 7).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 7).Value) - Convert.ToDecimal(Me.Grid.Item("TotalD2", 7).Value), "##,##0.00")

        Me.Grid.Item("Diferencia", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 0).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 1).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 2).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 2).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 2).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 3).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 3).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 3).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 4).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 4).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 4).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 5).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 5).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 5).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 6).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 6).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 6).Value), "##,##0.00")
        Me.Grid.Item("Diferencia", 7).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 7).Value) - Convert.ToDecimal(Me.Grid.Item("Total2", 7).Value), "##,##0.00")

        'Calcular Reflejos '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Apertura
        Me.Grid.Item("AperturaD", 0).Value = Format(Me.Grid.Item("Apertura", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Apertura", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item(2, 1).Value), "##,##0.00")

        'Ventas
        Me.Grid.Item("VentasD", 0).Value = Format(Me.Grid.Item("Ventas", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Ventas", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("VentasD", 1).Value), "##,##0.00")
        Me.Grid.Item("VentasD", 2).Value = Format(Me.Grid.Item("Ventas", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("VentasD", 3).Value = Format(Me.Grid.Item("Ventas", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("VentasD", 4).Value = Format(Me.Grid.Item("Ventas", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("VentasD", 5).Value = Format(Me.Grid.Item("Ventas", 5).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("VentasD", 6).Value = Format(Me.Grid.Item("Ventas", 6).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("VentasD", 7).Value = Format(Me.Grid.Item("Ventas", 7).Value / BsXDolarBC, "##,##0.00")

        'Ingresos
        Me.Grid.Item("IngresosD", 0).Value = Format(Me.Grid.Item("Ingresos", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Ingresos", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value), "##,##0.00")
        Me.Grid.Item("IngresosD", 2).Value = Format(Me.Grid.Item("Ingresos", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("IngresosD", 3).Value = Format(Me.Grid.Item("Ingresos", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("IngresosD", 4).Value = Format(Me.Grid.Item("Ingresos", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("IngresosD", 5).Value = Format(Me.Grid.Item("Ingresos", 5).Value / BsXDolarBC, "##,##0.00")

        'Egresos
        Me.Grid.Item("EgresosD", 0).Value = Format(Me.Grid.Item("Egresos", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Egresos", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value), "##,##0.00")
        Me.Grid.Item("EgresosD", 2).Value = Format(Me.Grid.Item("Egresos", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("EgresosD", 3).Value = Format(Me.Grid.Item("Egresos", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("EgresosD", 4).Value = Format(Me.Grid.Item("Egresos", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("EgresosD", 5).Value = Format(Me.Grid.Item("Egresos", 5).Value / BsXDolarBC, "##,##0.00")

        'Total
        Me.Grid.Item("TotalD2", 0).Value = Format(Me.Grid.Item("Total2", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Total2", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("TotalD2", 1).Value), "##,##0.00")
        Me.Grid.Item("TotalD2", 2).Value = Format(Me.Grid.Item("Total2", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("TotalD2", 3).Value = Format(Me.Grid.Item("Total2", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("TotalD2", 4).Value = Format(Me.Grid.Item("Total2", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("TotalD2", 5).Value = Format(Me.Grid.Item("Total2", 5).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("TotalD2", 6).Value = Format(Me.Grid.Item("Total2", 6).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("TotalD2", 7).Value = Format(Me.Grid.Item("Total2", 7).Value / BsXDolarBC, "##,##0.00")

        'Real
        '    Me.Grid.Item("RealD", 0).Value = Format(Me.Grid.Item("Real", 0).Value / BsXDolarBC, "##,##0.00")
        '   Me.Grid.Item("Real", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value), "##,##0.00")
        Me.Grid.Item("RealD", 2).Value = Format(Me.Grid.Item("Real", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 3).Value = Format(Me.Grid.Item("Real", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 4).Value = Format(Me.Grid.Item("Real", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 5).Value = Format(Me.Grid.Item("Real", 5).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 6).Value = Format(Me.Grid.Item("Real", 6).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 7).Value = Format(Me.Grid.Item("Real", 7).Value / BsXDolarBC, "##,##0.00")

        'Diferencias
        Me.Grid.Item("DiferenciaD", 0).Value = Format(Me.Grid.Item("Diferencia", 0).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("Diferencia", 1).Value = Format(BsXDolarBC * Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 1).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 2).Value = Format(Me.Grid.Item("Diferencia", 2).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("DiferenciaD", 3).Value = Format(Me.Grid.Item("Diferencia", 3).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("DiferenciaD", 4).Value = Format(Me.Grid.Item("Diferencia", 4).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("DiferenciaD", 5).Value = Format(Me.Grid.Item("Diferencia", 5).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("DiferenciaD", 6).Value = Format(Me.Grid.Item("Diferencia", 6).Value / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("DiferenciaD", 7).Value = Format(Me.Grid.Item("Diferencia", 7).Value / BsXDolarBC, "##,##0.00")

        'SUMAR LINEA DE TOTALES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.Grid.Item("Apertura", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Apertura", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Apertura", 1).Value), "##,##0.00")
        Me.Grid.Item("AperturaD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("AperturaD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("AperturaD", 1).Value), "##,##0.00")

        Me.Grid.Item("Ventas", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 5).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 6).Value) + Convert.ToDecimal(Me.Grid.Item("Ventas", 7).Value), "##,##0.00")
        Me.Grid.Item("VentasD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("VentasD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 1).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 2).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 3).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 4).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 5).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 6).Value) + Convert.ToDecimal(Me.Grid.Item("VentasD", 7).Value), "##,##0.00")

        Me.Grid.Item("Ingresos", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Ingresos", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Ingresos", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Ingresos", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Ingresos", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Ingresos", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Ingresos", 5).Value), "##,##0.00")
        Me.Grid.Item("IngresosD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("IngresosD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("IngresosD", 1).Value) + Convert.ToDecimal(Me.Grid.Item("IngresosD", 2).Value) + Convert.ToDecimal(Me.Grid.Item("IngresosD", 3).Value) + Convert.ToDecimal(Me.Grid.Item("IngresosD", 4).Value) + Convert.ToDecimal(Me.Grid.Item("IngresosD", 5).Value), "##,##0.00")

        Me.Grid.Item("Egresos", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Egresos", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Egresos", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Egresos", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Egresos", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Egresos", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Egresos", 5).Value), "##,##0.00")
        Me.Grid.Item("EgresosD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("EgresosD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("EgresosD", 1).Value) + Convert.ToDecimal(Me.Grid.Item("EgresosD", 2).Value) + Convert.ToDecimal(Me.Grid.Item("EgresosD", 3).Value) + Convert.ToDecimal(Me.Grid.Item("EgresosD", 4).Value) + Convert.ToDecimal(Me.Grid.Item("EgresosD", 5).Value), "##,##0.00")

        Me.Grid.Item("Total2", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Total2", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 5).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 6).Value) + Convert.ToDecimal(Me.Grid.Item("Total2", 7).Value), "##,##0.00")
        Me.Grid.Item("TotalD2", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("TotalD2", 0).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 1).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 2).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 3).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 4).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 5).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 6).Value) + Convert.ToDecimal(Me.Grid.Item("TotalD2", 7).Value))

        Me.Grid.Item("Real", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 5).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 6).Value) + Convert.ToDecimal(Me.Grid.Item("Real", 7).Value), "##,##0.00")
        Me.Grid.Item("RealD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 2).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 3).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 4).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 5).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 6).Value) + Convert.ToDecimal(Me.Grid.Item("RealD", 7).Value), "##,##0.00")

        Me.Grid.Item("Diferencia", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("Diferencia", 0).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 1).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 2).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 3).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 4).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 5).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 6).Value) + Convert.ToDecimal(Me.Grid.Item("Diferencia", 7).Value), "##,##0.00")
        Me.Grid.Item("DiferenciaD", 8).Value = Format(Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 0).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 1).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 2).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 3).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 4).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 5).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 6).Value) + Convert.ToDecimal(Me.Grid.Item("DiferenciaD", 7).Value), "##,##0.00")

        Me.LTotalD.Text = Format(Convert.ToDecimal(Me.Grid.Item("VentasD", 8).Value), "##,##0.00")
        Me.LTotal.Text = Format(Convert.ToDecimal(Me.Grid.Item("Ventas", 8).Value), "##,##0.00")
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub Fecha_ValueChanged(sender As Object, e As EventArgs)
        LlenarDatos()
    End Sub
    Private Sub BCajero_Click(sender As Object, e As EventArgs)
        VarBuscar = "CajeroCierreCaja"
        FBuscarOrden.LTitulo.Text = "Listado de Cajeros."
        FBuscarOrden.LTitulo.Tag = 0
        FBuscarOrden.ShowDialog()
    End Sub

    'Private Sub BEstacion_Click(sender As Object, e As EVentargs) Handles BEstacion.Click
    '    VarBuscar = "NombresCajas"
    '    FBuscarGenerico.LTitulo.Text = "Listado de Estaciones."
    '    FBuscarGenerico.LTitulo.Tag = 0
    '    FBuscarGenerico.ShowDialog()
    '    If CajaAbierta(Me.TCaja.Tag) Then
    '        LlenarDatos()
    '    Else
    '        MessageBox.Show("La Caja: " & Me.TCaja.Text & " No ha sido Aperturada. ", "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.TCaja.Text = CajaActiva
    '        Me.TCaja.Tag = CodCajaActiva
    '    End If
    'End Sub
    Private Sub MostrarLotes(Mensaje As Boolean)
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(Monto) as Lotes FROM TLotes  WHERE Tipo<>'Bio-Pago Parcial' and Tipo<>'Bio-Pago Total' and Fecha>= @DesdeL AND Fecha<=@HastaL AND idCaja=@idCaja", CNN)
                Comando.Parameters.AddWithValue("@DesdeL", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@HastaL", Me.FechaCierre.Value)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Me.Grid.Item("Real", 2).Value = Format(IIf(DR("Lotes").ToString = "", 0, DR("Lotes")), "##,##0.00")
                    DR.Close()
                    Desconectar()
                    Me.Grid.Item("RealD", 2).Value = Format(CalcularDolar(DateTime.Now, Me.Grid.Item("Real", 2).Value.ToString), "##,##0.00")
                    If (Mensaje) Then
                        MsgBox("Los Datos de Lotes fueron Agregados con Exito!!.  ", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                Else
                    Me.Grid.Item("Real", 2).Value = Format(0, "##,##0.00")
                    Me.Grid.Item("RealD", 2).Value = Format(0, "##,##0.00")
                    If (Mensaje) Then
                        MsgBox("Los Datos de Lotes aun No han sido Agregados.  ", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Mostrar los Datos de los Lotes.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try
    End Sub

    Private Sub MostrarBioPago(Mensaje As Boolean)
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT SUM(Monto) as Lotes FROM TLotes  WHERE Tipo='Bio-Pago Parcial' and Fecha>= @DesdeL AND Fecha<=@HastaL AND idCaja=@idCaja", CNN)
                Comando.Parameters.AddWithValue("@DesdeL", Me.FechaApertura.Value)
                Comando.Parameters.AddWithValue("@HastaL", Me.FechaCierre.Value)
                Comando.Parameters.AddWithValue("@idCaja", CodCajaActiva)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    Me.Grid.Item("Real", 3).Value = Format(IIf(DR("Lotes").ToString = "", 0, DR("Lotes")), "##,##0.00")
                    DR.Close()
                    Desconectar()
                    Me.Grid.Item("RealD", 3).Value = Format(CalcularDolar(DateTime.Now, Me.Grid.Item("Real", 3).Value.ToString), "##,##0.00")
                    If (Mensaje) Then
                        MsgBox("Los Datos de Bio-Pagos fueron Agregados con Exito!!.  ", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                Else
                    Me.Grid.Item("Real", 3).Value = Format(0, "##,##0.00")
                    Me.Grid.Item("RealD", 3).Value = Format(0, "##,##0.00")
                    If (Mensaje) Then
                        MsgBox("Los Datos de Bio-Pagos aun No han sido Agregados.  ", MsgBoxStyle.Information, "MarSoft: Información.")
                    End If
                End If
                DR.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Mostrar los Datos de los Lotes.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
        End Try
    End Sub
    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellClick
        '    Me.Label6.Text = Me.Grid.CurrentCell.ColumnIndex & " " & Me.Grid.CurrentCell.RowIndex
        Select Case Me.Grid.Columns(Me.Grid.CurrentCell.ColumnIndex).Name
            Case Is = "Boton"
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 2
                        MostrarLotes(True)
                        TotalizarCuentaReal()
                    Case 3
                        MostrarBioPago(True)
                        TotalizarCuentaReal()
                    Case Else
                End Select
            Case Is = "Items"
                Cursor = System.Windows.Forms.Cursors.WaitCursor
                VarBuscar = Me.Grid.CurrentRow.Cells("Items").Value
                FControlCajaDesglose.Fecha.Value = Me.FechaApertura.Value
                FControlCajaDesglose.FechaCierre.Value = Me.FechaCierre.Value
                FControlCajaDesglose.ShowDialog()
                Cursor = System.Windows.Forms.Cursors.Default
            Case Else

        End Select
        Select Case Me.Grid.CurrentCell.ColumnIndex
            Case 2
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 3
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 4
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 5
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1
                        Me.Grid.ClearSelection()
                End Select
            Case 6
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 7
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 8
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 9
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 10
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 11
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1
                        Me.Grid.ClearSelection()
                End Select
            Case 12
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1, 2, 3, 4, 5, 6, 7
                        Me.Grid.ClearSelection()
                End Select
            Case 13
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1
                        Me.Grid.ClearSelection()
                End Select
            Case 15
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 0, 2, 3, 4, 5, 6
                        Me.Grid.ClearSelection()
                End Select
            Case 16
                Select Case Me.Grid.CurrentCell.RowIndex
                    Case 1
                        Me.Grid.ClearSelection()
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        VarBuscar = "ControlCaja"
        FBuscarOrden.LTitulo.Text = "Listado Cajas."
        FBuscarOrden.LTitulo.Tag = 0
        FBuscarOrden.ShowDialog()
        Me.TContraseña.Select()
    End Sub
    Private Sub BIngresos_Click(sender As Object, e As EventArgs) Handles BIngresos.Click
        '   VarBuscar = "Ingresos"
        '   FMostrarOtrosIngresos.ShowDialog()
    End Sub
    Private Sub BEgresos_Click(sender As Object, e As EventArgs) Handles BEgresos.Click
        VarBuscar = "Egresos"
        '    FMostrarOtrosIngresos.ShowDialog()
    End Sub

    Private Sub BMostrarCierresCajas_Click(sender As Object, e As EventArgs) Handles BMostrarCierresCajas.Click

        Me.Label14.Tag = VarForma
        VarForma = "CierreCajas"
        'FBuscarCierreCajas.LTitulo.Text = "Listado de Aperturas y Cierres Cajas."
        'FBuscarCierreCajas.LTitulo.Tag = BMostrarCierresCajas.Tag
        'FBuscarCierreCajas.ShowDialog()
        'VarForma = Me.Label14.Tag
        VarFormaControlCaja = "ExaminarCierre"
        FControlCaja_Load(Nothing, Nothing)
        LIDApertura.Text = CodApertura
    End Sub
    Private Sub TContraseña_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            Me.TComentario.Focus()
        End If
    End Sub
    Private Sub TComentario_KeyDown(sender As Object, e As KeyEventArgs) Handles TComentario.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            Me.CResponsableDif.Focus()
        End If
    End Sub
    Private Sub CResponsableDif_KeyDown(sender As Object, e As KeyEventArgs) Handles CResponsableDif.KeyDown
        If e.KeyCode = 13 Then
            e.SuppressKeyPress = True
            Me.BAceptar.Focus()
        End If
    End Sub
    Private Sub BRecalcular_Click(sender As Object, e As EventArgs) Handles BRecalcular.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        EfectivoAux = Me.Grid.Item("Real", 0).Value
        EfectivoDAux = Me.Grid.Item("RealD", 1).Value
        Select Case VarFormaControlCaja
            Case "ExaminarCierre"
                Me.FechaCierre.Enabled = False
            Case "InicializarCajas"
                Me.FechaApertura.Value = BuscarFechaInicio()
                Me.FechaCierre.Value = DateAndTime.Now
                Me.FechaCierre.Enabled = True
            Case Else
                Me.FechaApertura.Value = BuscarFechaInicio()
                Me.FechaCierre.Value = DateAndTime.Now
                Me.FechaCierre.Enabled = True
        End Select
        Bandera = True
        Me.TCaja.Text = CajaActiva
        LlenarGrill()
        LlenarDatos()
        Me.CUsuario.Text = ""
        Me.TContraseña.Text = ""
        Bandera = False
        MostrarLotes(False)
        MostrarBioPago(False)
        Me.Grid.Item("Real", 0).Value = Format(EfectivoAux, "##,##0.00")
        Me.Grid.Item("RealD", 0).Value = Format(Convert.ToDecimal(Me.Grid.Item("Real", 0).Value) / BsXDolarBC, "##,##0.00")
        Me.Grid.Item("RealD", 1).Value = Format(EfectivoDAux, "##,##0.00")
        Me.Grid.Item("Real", 1).Value = Format(Convert.ToDecimal(Me.Grid.Item("RealD", 1).Value) * BsXDolarBC, "##,##0.00")



        '  Me.Grid.Item("Real", 1).Value = Format(CalcularDolar(DateTime.Now, Me.Grid.Item("RealD", 1).Value), "##,##0.00")
        TotalizarCuentaReal()
        LIDApertura.Text = CodApertura
        Me.Grid.ClearSelection()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub BUsuario_Click(sender As Object, e As EventArgs) Handles BUsuario.Click
        VarBuscar = "UsuarioCierreCaja"
        FBuscarOrden.LTitulo.Text = "Listado Usuarios."
        FBuscarOrden.LTitulo.Tag = 0
        FBuscarOrden.ShowDialog()
        Me.TContraseña.Select()
    End Sub

    Public Sub BuscarCaja()
        Dim Caja As String = "Sin Caja"
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("SELECT Nombre FROM TCajas WHERE  id=@id ", CNN)
                Comando.Parameters.Add(New SqlParameter("@id", CodCajaActiva))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                If (DR.Read()) Then
                    CajaActiva = DR("Nombre")
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
    'Private Sub BCierreActual_Click(sender As Object, e As EVentargs) Handles BCierreActual.Click
    '    VarForma = "Cajas"
    '    CajaActiva = Me.TCaja.Text
    '    CodCajaActiva = Me.TCaja.Tag
    '    BuscarCaja()
    '    MostrarCajero()
    '    Me.Fecha.Value = BuscarFechaInicio()
    '    Me.FechaCierre.Value = DateAndTime.Now
    '    FControlCaja_Load(Nothing, Nothing)
    '    LIDApertura.Text = CodApertura
    'End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        VarBuscar = "Efectivo $ Completo"
        FControlCajaDesglose.Fecha.Value = Me.FechaApertura.Value
        FControlCajaDesglose.FechaCierre.Value = Me.FechaCierre.Value
        FControlCajaDesglose.ShowDialog()
    End Sub
    Private Sub TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ValidarPuntoSeparacion(sender, True)
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim caracter As Char = e.KeyChar
        Dim txt As TextBox = CType(sender, TextBox)
        If (caracter = ".") Then
            caracter = ","
            e.KeyChar = ","
        End If
        If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or ((caracter = ",") And (txt.Text.Contains(",") = False)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellEndEdit
        Select Case Me.Grid.Columns(Me.Grid.CurrentCell.ColumnIndex).Name
            Case Is = "RealD"
                If Me.Grid.CurrentRow.Cells("RealD").Value = Nothing Then
                    Me.Grid.CurrentRow.Cells("RealD").Value = 0
                End If
                If (Me.Grid.CurrentRow.Cells("RealD").Value.ToString <> "") Then
                    Me.Grid.CurrentRow.Cells("RealD").Value = Format(Convert.ToDecimal(Me.Grid.CurrentRow.Cells("RealD").Value), "##,##0.00")
                    Me.Grid.CurrentRow.Cells("Real").Value = Format(Convert.ToDecimal(Me.Grid.CurrentRow.Cells("RealD").Value) * BsXDolarBC, "##,##0.00")
                End If
            Case Is = "Real"
                If Me.Grid.CurrentRow.Cells("Real").Value = Nothing Then
                    Me.Grid.CurrentRow.Cells("Real").Value = 0
                End If
                If (Me.Grid.CurrentRow.Cells("Real").Value.ToString <> "") Then
                    Me.Grid.CurrentRow.Cells("Real").Value = Format(Convert.ToDecimal(Me.Grid.CurrentRow.Cells("Real").Value), "##,##0.00")
                    Me.Grid.CurrentRow.Cells("RealD").Value = Format(CalcularDolar(DateTime.Now, Me.Grid.CurrentRow.Cells("Real").Value), "##,##0.00")
                    Me.Grid.CurrentCell = Me.Grid.Rows(2).Cells("RealD")
                    Me.Grid.BeginEdit(True)
                End If
        End Select
        TotalizarCuentaReal()
    End Sub
    Private Sub Grid_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Grid.EditingControlShowing
        If (Me.Grid.CurrentCell.ColumnIndex = 12 Or Me.Grid.CurrentCell.ColumnIndex = 13) And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyUp, AddressOf TextBox_KeyUp
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub
    Private Sub BLotes_Click(sender As Object, e As EventArgs) Handles BLotes.Click
        VarBuscar = "ControlCaja"
        CajaActiva = Me.TCaja.Text
        CodCajaActiva = Me.TCaja.Tag
        '   FLotes.ShowDialog()
        CajaActiva = Me.TCaja.Text
        CodCajaActiva = Me.TCaja.Tag
        If (ExisteCierre() = False) Then
            Me.FechaCierre.Value = DateAndTime.Now
        End If
        MostrarLotes(False)
        MostrarBioPago(False)
        TotalizarCuentaReal()
    End Sub

    Private Sub BIngreso_Click(sender As Object, e As EventArgs) Handles BIngreso.Click

        'FOtrosIngresos.LCaja.Text = Me.TCaja.Text
        'FOtrosIngresos.LCaja.Tag = Me.TCaja.Tag
        'FOtrosIngresos.LCajero.Text = Me.TCajero.Text
        'FOtrosIngresos.LCajero.Tag = Me.TCajero.Tag

        'FOtrosIngresos.CCajero.Text = Me.TCajero.Text
        'FOtrosIngresos.ShowDialog()
        'CajaActiva = Me.TCaja.Text
        'CodCajaActiva = Me.TCaja.Tag
        'If (ExisteCierre() = False) Then
        '    Me.FechaCierre.Value = DateAndTime.Now
        'End If
        'If MsgBox("Desea Re-Calcular el Cierre de Caja? ", vbYesNo, "MarSoft: Re-Calcular.") = vbYes Then
        '    BRecalcular_Click(Nothing, Nothing)
        'End If
    End Sub

    Private Sub BGastos_Click(sender As Object, e As EventArgs) Handles BGastos.Click
        VarForma = "Cajas"
        '     FGastos.ShowDialog()
        CajaActiva = Me.TCaja.Text
        CodCajaActiva = Me.TCaja.Tag
        If (ExisteCierre() = False) Then
            Me.FechaCierre.Value = DateAndTime.Now
        End If
        If MsgBox("Desea Re-Calcular el Cierre de Caja? ", vbYesNo, "MarSoft: Re-Calcular.") = vbYes Then
            BRecalcular_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub BCompraVentas_Click(sender As Object, e As EventArgs) Handles BCompraVenta.Click
        'FCompraVentaEfectivo.LCaja.Text = Me.TCaja.Text
        'FCompraVentaEfectivo.LCaja.Tag = Me.TCaja.Tag
        'FCompraVentaEfectivo.LCajero.Text = Me.TCajero.Text
        'FCompraVentaEfectivo.LCajero.Tag = Me.TCajero.Tag
        'FCompraVentaEfectivo.ShowDialog()
        'If MsgBox("Desea Re-Calcular el Cierre de Caja? ", vbYesNo, "MarSoft: Re-Calcular.") = vbYes Then
        '    BRecalcular_Click(Nothing, Nothing)
        'End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        VarForma = "ObservacionControlCaja"
        FComentarioSolo.TComentario.Text = Me.TComentario.Text
        FComentarioSolo.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class