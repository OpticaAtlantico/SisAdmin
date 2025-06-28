Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class ExportarTablaExcel
    Public Function ArchivoEstaAbierto(ByVal rutaArchivo As String) As Boolean
        Try
            Using fs As New FileStream(rutaArchivo, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            End Using
            Return False ' El archivo no está abierto
        Catch ex As IOException
            Return True ' El archivo está abierto
        End Try
    End Function
    '-------------------------------------------------------------------------------------------
    Sub ExportarHojaEstilizada(libro As Excel.Workbook, dt As DataTable, nombreHoja As String)
        Dim hoja As Excel.Worksheet = CType(libro.Sheets.Add(), Excel.Worksheet)
        hoja.Name = nombreHoja

        ' Escribir encabezados
        For i = 0 To dt.Columns.Count - 1
            hoja.Cells(1, i + 1) = dt.Columns(i).ColumnName
            hoja.Cells(1, i + 1).Font.Bold = True
            hoja.Cells(1, i + 1).Interior.Color = RGB(30, 60, 90)
            hoja.Cells(1, i + 1).Font.Color = RGB(255, 255, 255)
        Next

        ' Escribir datos
        For i = 0 To dt.Rows.Count - 1
            For j = 0 To dt.Columns.Count - 1
                hoja.Cells(i + 2, j + 1) = dt.Rows(i)(j)
            Next
        Next

        ' Rango de la tabla
        Dim totalFilas As Integer = dt.Rows.Count + 1
        Dim totalColumnas As Integer = dt.Columns.Count
        Dim rango As Excel.Range = hoja.Range("A1", hoja.Cells(totalFilas, totalColumnas))

        Dim tabla As Excel.ListObject = hoja.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, rango, , Excel.XlYesNoGuess.xlYes)
        tabla.Name = "tbl" & nombreHoja
        tabla.TableStyle = "TableStyleMedium13"
        tabla.ShowTotals = True

        ' Aplicar formato y totales a columnas numéricas, excepto "Cantidad" y idOrden
        For Each col In dt.Columns
            If col.DataType = GetType(Integer) OrElse col.DataType = GetType(Decimal) OrElse col.DataType = GetType(Double) Then
                Dim idx = dt.Columns.IndexOf(col) + 1
                If Not col.ColumnName.ToLower().Contains("idorden") Then
                    If Not col.ColumnName.ToLower().Contains("cantidad") Then
                        hoja.Columns(idx).NumberFormat = "$#,##0.00"
                    Else
                        hoja.Columns(idx).NumberFormat = "#,##0.00"
                    End If
                    tabla.ListColumns(idx).TotalsCalculation = Excel.XlTotalsCalculation.xlTotalsCalculationSum
                End If
                If col.ColumnName.ToLower().Contains("fecha") Then
                    hoja.Columns(idx).NumberFormat = "dd/mm/yyyy"
                End If
            End If
            If col.DataType = GetType(Date) Then
                Dim idx = dt.Columns.IndexOf(col) + 1
                If col.ColumnName.ToLower().Contains("fecha") Then
                    hoja.Columns(idx).NumberFormat = "dd/mm/yyyy"
                End If
            End If
        Next
        hoja.Columns.AutoFit()

        ' Ocultar columnas específicas si existen
        Dim columnasAOcultar As String() = {"Prod_idOrden", "Prod_FechaPago"}

        For Each nombreCol In columnasAOcultar
            Dim idx As Integer = -1
            For i = 1 To dt.Columns.Count
                If hoja.Cells(1, i).Value.ToString() = nombreCol Then
                    idx = i
                    Exit For
                End If
            Next
            If idx > 0 Then hoja.Columns(idx).Hidden = True
        Next

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------

    Function UnirPagosYProductos(dtPagos As DataTable, dtProductos As DataTable) As DataTable
        Dim dtFinal As New DataTable()

        ' Clonar estructura de dtPagos
        For Each col As DataColumn In dtPagos.Columns
            dtFinal.Columns.Add(col.ColumnName, col.DataType)
        Next

        ' Agregar columnas de productos (con prefijo)
        For Each col As DataColumn In dtProductos.Columns
            Dim prefijada As String = "Prod_" & col.ColumnName
            If Not dtFinal.Columns.Contains(prefijada) Then
                dtFinal.Columns.Add(prefijada, col.DataType)
            End If
        Next

        ' Unir y vaciar productos repetidos.
        Dim ordenesProcesadas As New HashSet(Of String)

        For Each rowPago As DataRow In dtPagos.Rows
            Dim idOrden = rowPago("idOrden").ToString()
            Dim productosRelacionados = dtProductos.Select("idOrden = '" & idOrden & "'")
            Dim productosIncluidos = False

            If productosRelacionados.Length > 0 AndAlso Not ordenesProcesadas.Contains(idOrden) Then
                Dim rowProd = productosRelacionados(0) ' Solo el primero
                Dim nuevaFila = dtFinal.NewRow()

                For Each col As DataColumn In dtPagos.Columns
                    nuevaFila(col.ColumnName) = rowPago(col.ColumnName)
                Next

                For Each col As DataColumn In dtProductos.Columns
                    nuevaFila("Prod_" & col.ColumnName) = rowProd(col.ColumnName)
                Next

                dtFinal.Rows.Add(nuevaFila)
                ordenesProcesadas.Add(idOrden)
            Else
                ' Otras filas: sin producto
                Dim nuevaFila = dtFinal.NewRow()
                For Each col As DataColumn In dtPagos.Columns
                    nuevaFila(col.ColumnName) = rowPago(col.ColumnName)
                Next

                For Each col As DataColumn In dtProductos.Columns
                    nuevaFila("Prod_" & col.ColumnName) = DBNull.Value
                Next

                dtFinal.Rows.Add(nuevaFila)
            End If
        Next

        Return dtFinal
    End Function

    Sub ExportarReportePagosYProductos(dtPagos As DataTable, dtProductos As DataTable, NombreOptica As String, reporteProgreso As Action(Of Integer))
        Dim xlApp As New Excel.Application
        Dim xlLibro As Excel.Workbook = xlApp.Workbooks.Add()
        xlApp.DisplayAlerts = False

        ' Unir datos en una sola tabla
        Dim dtUnificado As DataTable = UnirPagosYProductos(dtPagos, dtProductos)
        ExportarHojaEstilizada(xlLibro, dtUnificado, "Ventas_Productos")

        ' Guardar archivo
        Dim nombreArchivo As String = NombreOptica & "_" & Date.Now.ToString("yyyy-MM-dd_HHmm") & ".xlsx"
        Dim rutaFinal As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, nombreArchivo)

        If File.Exists(rutaFinal) AndAlso ArchivoEstaAbierto(rutaFinal) Then
            MessageBox.Show("El archivo ya está abierto. Por favor, ciérrelo antes de guardar.", "Archivo Abierto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        xlLibro.SaveAs(rutaFinal)
        xlApp.Visible = True
    End Sub
End Class




