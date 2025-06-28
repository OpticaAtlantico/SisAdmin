Imports System.Data.SqlClient
Public Class FControlCajaDesglose
    Private Sub MostrarOtros(Tipo As String)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Grid.Visible = False
        Me.GridVentas.Visible = True
        Dim EfectivoFD As Decimal = 0
        Dim I As Integer = 0
        Me.GridVentas.Rows.Clear()
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("SELECT  idVenta, Fecha, SUM(Monto) as Total, Nombre as FormaPago, TipoPago FROM VResumenVentaDia  WHERE  idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta and Nombre='Otras' GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero", CodCajero))
            Comando2.CommandTimeout = 150
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("Total").ToString = "", 0, DR("Total"))
                If (EfectivoFD > 0) Then
                    I = I + 1
                    Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("Total"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Dim Total1 As Decimal = SumarColumna(Me.GridVentas, 3)
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select  idVenta, Fecha, SUM(MontoV) as Total, Nombre as FormaPago,TipoPago FROM VResumenDiaVarios  WHERE Nombre='Varios' and idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1 and TipoPago<>'Efectivo' and TipoPago<>'Tarjeta' and TipoPago<>'Pago Móvil' and TipoPago<>'Transferencia' and TipoPago<>'Crédito' GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde1", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta1", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja1", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero1", CodCajero))
            Comando2.CommandTimeout = 80
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("Total").ToString = "", 0, DR("Total"))
                If (EfectivoFD > 0) Then
                    If (InStr(DR("TipoPago").ToString, "Dolar") = 0) Then
                        I = I + 1
                        Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("Total"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                    End If
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Me.GridVentas.Sort(CodVentax, System.ComponentModel.ListSortDirection.Ascending)
        Dim Totalt As Decimal = SumarColumna(Me.GridVentas, 3)
        Me.GridVentas.Columns(3).HeaderText = "Venta Bs."
        Me.GridVentas.Rows.Add("", "", "     Total " & Tipo, VFormat(Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total Varios ", VFormat(Totalt - Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total General ", VFormat(Totalt, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        GridVentas.FirstDisplayedScrollingRowIndex = GridVentas.RowCount - 1
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub MostrarDolar(Tipo As String)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Grid.Visible = False
        Me.GridVentas.Visible = True
        Dim EfectivoFD As Decimal = 0
        Dim I As Integer = 0
        Me.GridVentas.Rows.Clear()
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("SELECT  idVenta, Fecha, SUM(MontoD) as TotalD, Nombre as FormaPago, TipoPago FROM VResumenVentaDia  WHERE  idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta and Nombre='" & Tipo & "' GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero", CodCajero))
            Comando2.CommandTimeout = 150
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
                If (EfectivoFD > 0) Then
                    I = I + 1
                    Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("TotalD"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Dim Total1 As Decimal = SumarColumna(Me.GridVentas, 3)
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select  idVenta, Fecha, SUM(MontoDV) as TotalD, Nombre as FormaPago,TipoPago FROM VResumenDiaVarios  WHERE Nombre='Varios' and idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1 and TipoPago like'%Dolar%'  GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde1", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta1", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja1", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero1", CodCajero))
            Comando2.CommandTimeout = 80
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
                If (EfectivoFD > 0) Then
                    I = I + 1
                    Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("TotalD"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Me.GridVentas.Sort(CodVentax, System.ComponentModel.ListSortDirection.Ascending)
        Dim Totalt As Decimal = SumarColumna(Me.GridVentas, 3)
        Me.GridVentas.Columns(3).HeaderText = "Venta $"
        Me.GridVentas.Rows.Add("", "", "     Total " & Tipo, VFormat(Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total Varios ", VFormat(Totalt - Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total General ", VFormat(Totalt, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        GridVentas.FirstDisplayedScrollingRowIndex = GridVentas.RowCount - 1
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub MostrarDolarCompleto(Tipo As String)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Grid.Visible = True
        Me.GridVentas.Visible = False
        Dim EfectivoFD As Decimal = 0
        Dim I As Integer = 0
        Me.Grid.Rows.Clear()
        ' Dim i As Integer = 1
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY Fecha) AS Nº, TotalD, FormaPago  FROM VEfectivoEntrante WHERE idCaja=@idCaja AND Fecha>=@Desde AND Fecha<=@Hasta AND FormaPago='Dolar'", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
            Comando2.CommandTimeout = 80
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
                If (EfectivoFD > 0) Then
                    Me.Grid.Rows.Add(DR("Nº"), Format(DR("TotalD"), "##,##0.0000"), DR("FormaPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select ROW_NUMBER() OVER(ORDER BY Fecha) AS Nº,TotalD, FormaPago FROM VEfectivoEntrante WHERE  idCaja=@idCaja AND FormaPago='Varios' AND Fecha>=@Desde AND Fecha<=@Hasta AND TipoPago Like '%Dolar%'", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
            Comando2.CommandTimeout = 80
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
                If (EfectivoFD > 0) Then
                    Me.Grid.Rows.Add(DR("Nº"), Format(DR("TotalD"), "##,##0.0000"), DR("FormaPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Dim Totalt As Decimal = SumarColumna(Me.Grid, 1)
        Me.Grid.Rows.Add("     Total ", Format(Totalt, "##,##0.0000"), "")
        Me.Grid.Rows(Me.Grid.RowCount - 1).Height = 25
        Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Grid.FirstDisplayedScrollingRowIndex = Grid.RowCount - 1
        Cursor = System.Windows.Forms.Cursors.Default





























        'If (Conectar2()) Then
        '    Dim Comando2 As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY Fecha) AS Nº, CI,Cliente, TotalD, FormaPago FROM VEfectivoEntranteCliente WHERE FormaPago='Dolar' AND Fecha>=@Desde AND Fecha<=@Hasta", CNN2)
        '    Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
        '    Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
        '    Dim DR As SqlDataReader = Comando2.ExecuteReader()
        '    Do While DR.Read()
        '        EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
        '        If (EfectivoFD > 0) Then
        '            Me.Grid.Rows.Add(DR("Nº"), DR("CI"), DR("Cliente"), Format(DR("TotalD"), "##,##0.00"), DR("FormaPago"))
        '        End If
        '    Loop
        '    DR.Close()
        'End If
        'Desconectar2()
        'If (Conectar2()) Then
        '    Dim Comando2 As New SqlCommand("Select  ROW_NUMBER() OVER(ORDER BY Fecha) AS Nº, CI,Cliente, TotalD, FormaPago FROM VEfectivoEntranteCliente WHERE FormaPago='Varios' AND Fecha>=@Desde AND Fecha<=@Hasta AND TipoPago Like '%Dolar%'", CNN2)
        '    Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
        '    Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
        '    Dim DR As SqlDataReader = Comando2.ExecuteReader()
        '    Do While DR.Read()
        '        EfectivoFD = IIf(DR("TotalD").ToString = "", 0, DR("TotalD"))
        '        If (EfectivoFD > 0) Then
        '            Me.Grid.Rows.Add(DR("Nº"), DR("CI"), DR("Cliente"), Format(DR("TotalD"), "##,##0.00"), DR("FormaPago"))
        '        End If
        '    Loop
        '    DR.Close()
        'End If
        'Desconectar2()
        'Dim Totalt As Decimal = SumarColumna(Me.Grid, 3)
        'Me.Grid.Rows.Add("", "", "     Total ", VFormat(Totalt, 4), "")
        'Me.Grid.Rows(Me.Grid.RowCount - 1).Height = 25
        'Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        'Me.Grid.Rows(Me.Grid.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        'Grid.FirstDisplayedScrollingRowIndex = Grid.RowCount - 1
        'Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Mostrar(Tipo As String)
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Grid.Visible = False
        Me.GridVentas.Visible = True
        Dim EfectivoFD As Decimal = 0
        Dim I As Integer = 0

        Me.GridVentas.Rows.Clear()
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("SELECT  idVenta, Fecha, SUM(Monto) as Total, Nombre as FormaPago,TipoPago FROM VResumenVentaDia  WHERE  idCaja=@idCaja AND idCajero=@idCajero AND Fecha>=@Desde AND Fecha<=@Hasta and Nombre='" & Tipo & "' GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero", CodCajero))
            Comando2.CommandTimeout = 150
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("Total").ToString = "", 0, DR("Total"))
                If (EfectivoFD > 0) Then
                    I = I + 1
                    Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("Total"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Dim Total1 As Decimal = SumarColumna(Me.GridVentas, 3)
        If (Conectar2()) Then
            Dim Comando2 As New SqlCommand("Select  idVenta, Fecha, SUM(MontoV) as Total, Nombre as FormaPago, TipoPago FROM VResumenDiaVarios  WHERE Nombre='Varios' and idCaja=@idCaja1 AND idCajero=@idCajero1 AND Fecha>=@Desde1 AND Fecha<=@Hasta1 and TipoPago='" & Tipo & "' GROUP By idVenta,Fecha, Nombre, TipoPago", CNN2)
            Comando2.Parameters.Add(New SqlParameter("@Desde1", Me.Fecha.Value))
            Comando2.Parameters.Add(New SqlParameter("@Hasta1", Me.FechaCierre.Value))
            Comando2.Parameters.Add(New SqlParameter("@idCaja1", CodCajaActiva))
            Comando2.Parameters.Add(New SqlParameter("@idCajero1", CodCajero))
            Comando2.CommandTimeout = 80
            Dim DR As SqlDataReader = Comando2.ExecuteReader()
            Do While DR.Read()
                EfectivoFD = IIf(DR("Total").ToString = "", 0, DR("Total"))
                If (EfectivoFD > 0) Then
                    I = I + 1
                    Me.GridVentas.Rows.Add(I, DR("idVenta"), DR("Fecha"), Format(DR("Total"), "##,##0.0000"), DR("FormaPago"), DR("TipoPago"))
                End If
            Loop
            DR.Close()
        End If
        Desconectar2()
        Me.GridVentas.Sort(CodVentax, System.ComponentModel.ListSortDirection.Ascending)
        Dim Totalt As Decimal = SumarColumna(Me.GridVentas, 3)
        Me.GridVentas.Columns(3).HeaderText = "Venta Bs."
        Me.GridVentas.Rows.Add("", "", "     Total " & Tipo, VFormat(Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total Varios ", VFormat(Totalt - Total1, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        Me.GridVentas.Rows.Add("", "", "     Total General ", VFormat(Totalt, 4), "")
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).Height = 25
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
        Me.GridVentas.Rows(Me.GridVentas.RowCount - 1).DefaultCellStyle.BackColor = Color.Tomato
        GridVentas.FirstDisplayedScrollingRowIndex = GridVentas.RowCount - 1
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FControlCajaDesglose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case VarBuscar
            Case "Efectivo $ Completo"
                Me.LTitulo.Text = "*- Desglose Ventas de Efectivo en Dolares ($) Entrantes -*"
                MostrarDolarCompleto("Dolar")
            Case "Divisas $"
                Me.LTitulo.Text = "*- Desglose Ventas de Efectivo en Dolares ($) -*"
                MostrarDolar("Dolar")
            Case "Efectivo Bs."
                Me.LTitulo.Text = "*- Desglose Ventas de Efectivo en Bolívares (Bs.) -*"
                Mostrar("Efectivo")
            Case "Tarjetas"
                Me.LTitulo.Text = "*- Desglose Ventas en Tarjetas -*"
                Mostrar("Tarjeta")
            Case "Bio-Pago"
                Me.LTitulo.Text = "*- Desglose Ventas en Bio-Pago -*"
                Mostrar("Bio-Pago")
            Case "Transferencias"
                Me.LTitulo.Text = "*- Desglose Ventas en Transferencias -*"
                Mostrar("Transferencia")
            Case "Pago Móvil"
                Me.LTitulo.Text = "*- Desglose Ventas en Pago Móvil -*"
                Mostrar("Pago Móvil")
            Case "Crédito"
                Me.LTitulo.Text = "*- Desglose Ventas en Créditos -*"
                Mostrar("Crédito")
            Case "Otros"
                Me.LTitulo.Text = "*- Desglose Ventas Pagos Otros -*"
                MostrarOtros("Otras")
        End Select
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BEfectivo_Click(sender As Object, e As EventArgs) Handles BEfectivo.Click
        Me.LTitulo.Text = "*- Desglose Ventas de Efectivo en Bolívares (Bs.) -*"
        Mostrar("Efectivo")
    End Sub

    Private Sub BDolar_Click(sender As Object, e As EventArgs) Handles BDolar.Click
        Me.LTitulo.Text = "*- Desglose Ventas de Efectivo en Dolares ($) -*"
        MostrarDolar("Dolar")    
    End Sub

    Private Sub BTarjeta_Click(sender As Object, e As EventArgs) Handles BTarjeta.Click  
        Me.LTitulo.Text = "*- Desglose Ventas en Tarjetas -*"
        Mostrar("Tarjeta")    
    End Sub
    Private Sub BBioPago_Click(sender As Object, e As EventArgs) Handles BBioPago.Click
        Me.LTitulo.Text = "*- Desglose Ventas en Bio-Pago -*"
        Mostrar("Bio-Pago")
    End Sub
    Private Sub BTransferencia_Click(sender As Object, e As EventArgs) Handles BTransferencia.Click
        Me.LTitulo.Text = "*- Desglose Ventas en Transferencias -*"
        Mostrar("Transferencia")      
    End Sub

    Private Sub BPagoMovil_Click(sender As Object, e As EventArgs) Handles BPagoMovil.Click
        Me.LTitulo.Text = "*- Desglose Ventas en Pago Móvil -*"
        Mostrar("Pago Móvil")   
    End Sub

    Private Sub BOtros_Click(sender As Object, e As EventArgs) Handles BOtros.Click
        Me.LTitulo.Text = "*- Desglose Ventas Pagos Otros -*"
        MostrarOtros("Otras")
    End Sub

    Private Sub BCreditos_Click(sender As Object, e As EventArgs) Handles BCreditos.Click
        Me.LTitulo.Text = "*- Desglose Ventas en Créditos -*"
        Mostrar("Crédito")
    End Sub

    Private Sub GridVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridVentas.CellContentClick
        Dim Cedula As String = ""
        Dim ClienteX As String = ""
        Select Case e.ColumnIndex
            Case 6
                DesdeX = Me.Fecha.Value
                HastaX = Me.FechaCierre.Value
                CodVenta = Me.GridVentas.Item(1, e.RowIndex).Value
        End Select
    End Sub
End Class