Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Web.UI.WebControls

Public Class FReporteSemanal
    Private WithEvents bgWorker As New BackgroundWorker()
    Private WithEvents bgWorker1 As New BackgroundWorker()
    Private rutaArchivo As String
    Private dtDatos As New DataTable()
    Private dtTipoPago As New DataTable()
    Private dtConcepto As New DataTable()
    Private dtTotales As New DataTable()
    Private dtProductos As New DataTable()
    Private exportador As New ExportarTablaExcel()
    Private ToolTips As New ToolTip()
    Private SelectChange As Boolean = False
    Private NumOptica As Integer
    Private nombreOptica As String = String.Empty
    Dim idOrden As Integer = 0
    Public Property BackgroundWorker1 As Object

    'Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
    '    Dim dt As DataTable = DirectCast(dgv_Datos.DataSource, DataTable)
    '    If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '        Dim report As New ReporteSemanal()
    '        report.SetDataSource(dt)
    '        Dim viewer As New ReportViewer(report)
    '        viewer.ShowDialog()
    '    Else
    '        MessageBox.Show("No hay datos para imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Public Sub EnviarPorEmail()
        Dim correo As New MailMessage
        Dim smtp As New SmtpClient("smtp.gmail.com", 587)
        Dim openFiledialog As New OpenFileDialog()

        'Configurar SMTP
        smtp.Port = 587
        smtp.Credentials = New System.Net.NetworkCredential("wiflores2008@gmail.com", "@Gmail.com@..")
        smtp.EnableSsl = True

        'Seleccionar el archivo
        If openFiledialog.ShowDialog() = DialogResult.OK Then
            Dim archivo As String = openFiledialog.FileName
            Dim nombreArchivo As String = IO.Path.GetFileName(archivo)
            'Configurar correo
            correo.From = New MailAddress("wiflores2008@gmail.com")
            correo.To.Add("wiflores2008@gmail.com")
            correo.Subject = "Reporte Semanal"
            correo.Body = "Adjunto el reporte semanal."
            correo.Attachments.Add(New Attachment(archivo))

            'Enviar el correo
            Try
                smtp.Send(correo)
                MessageBox.Show("Correo enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No se seleccionó ningún archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        dtDatos = Nothing
        Me.Close()
    End Sub

    Private Sub FReporteSemanal_Load(sender As Object, e As EventArgs) Handles Me.Load
        NumOptica = ObtenerNombreOptica(1)
        CargarDatos(NumOptica)
        CargarFechas()
        LimpiarDatagrid()
        bgWorker.WorkerReportsProgress = True
        bgWorker.WorkerSupportsCancellation = False
        bgWorker1.WorkerReportsProgress = True
        bgWorker1.WorkerSupportsCancellation = False
    End Sub

    Sub LimpiarDatagrid()
        With Me
            If .dgv_Datos.DataSource IsNot Nothing Then .dgv_Datos.DataSource = Nothing
            If .dgv_Conceptos.DataSource IsNot Nothing Then .dgv_Conceptos.DataSource = Nothing
            If .dgv_TipoPagos.DataSource IsNot Nothing Then .dgv_TipoPagos.DataSource = Nothing
            If .dgv_Totales.DataSource IsNot Nothing Then .dgv_Totales.DataSource = Nothing
        End With
    End Sub
    Sub DesSeleccionarDatagridView()
        With Me
            .dgv_Datos.ClearSelection() : .dgv_Datos.CurrentCell = Nothing
            .dgv_Conceptos.ClearSelection() : .dgv_Conceptos.CurrentCell = Nothing
            .dgv_TipoPagos.ClearSelection() : .dgv_TipoPagos.CurrentCell = Nothing
            .dgv_Totales.ClearSelection() : .dgv_Totales.CurrentCell = Nothing
        End With
    End Sub
    Public Function SumaCeldasSeleccionadas() As Decimal
        Dim Suma As Decimal = 0
        With Me.dgv_Datos
            For Each fila As DataGridViewCell In .SelectedCells
                If fila.Value IsNot Nothing AndAlso IsNumeric(fila.Value) Then
                    Suma += Convert.ToDecimal(fila.Value)
                End If
            Next
        End With
        Return Suma.ToString()
    End Function

    Public Function CantidadSeleccionada() As Long
        Dim resultado As Long = 0
        Dim Contador As Long = 0
        With Me.dgv_Datos
            For Each filas As DataGridViewCell In .SelectedCells
                Contador += 1
            Next
            resultado = Contador
        End With
        Return resultado.ToString()
    End Function

    Sub AgregarFilaTotales()
        Dim filaTotales As New DataGridViewRow()
        filaTotales.CreateCells(Me.dgv_Datos)
        With Me.dgv_Datos
            If .Rows.Count >= 1 Then
                For i As Integer = 0 To .ColumnCount - 1
                    If .Columns(i).ValueType Is GetType(Decimal) OrElse .Columns(i).ValueType Is GetType(Integer) Then
                        Dim suma As Decimal = 0
                        For Each fila As DataGridViewRow In .Rows
                            If Not fila.IsNewRow Then
                                If Not IsDBNull(fila.Cells(i).Value) Then
                                    suma += Convert.ToDecimal(fila.Cells(i).Value)
                                End If
                            End If
                        Next
                        filaTotales.Cells(i).Value = suma
                    Else
                        filaTotales.Cells(i).Value = "Total"
                    End If
                Next
            End If
        End With
    End Sub

    Sub BorrarCeldasDuplicadas()
        Dim valoresVistos As New HashSet(Of String)() 'HashSet Almacena valores unicos para detectar duplicados 
        With Me.dgv_Datos
            Try
                For Each fila As DataGridViewRow In .Rows
                    If Not fila.IsNewRow Then 'Verificamos que la fila no sea la ultima vacia (IsNewRow)
                        Dim valorCelda As String = fila.Cells("idOrden").Value.ToString()
                        If valoresVistos.Contains(valorCelda) Then
                            fila.Cells("SubTotal").Value = 0
                            fila.Cells("Descuento").Value = 0
                            fila.Cells("Total").Value = 0
                        Else
                            valoresVistos.Add(valorCelda)
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End With
    End Sub

    Sub CargarEncabezadoGridView()

        With Me.dgv_Datos
            .Columns(0).HeaderText = "Fecha de Venta" : .Columns(0).Width = 110 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).HeaderText = "#Orden" : .Columns(1).Width = 60 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "Sub Total" : .Columns(2).Width = 90 : .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).HeaderText = "Descuento" : .Columns(3).Width = 90 : .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).HeaderText = "Total" : .Columns(4).Width = 90 : .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).HeaderText = "Porcentaje" : .Columns(5).Width = 90 : .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(6).HeaderText = "Fecha Pago" : .Columns(6).Width = 110 : .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(7).HeaderText = "Total Pagado" : .Columns(7).Width = 110 : .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(8).HeaderText = "Anticipo" : .Columns(8).Width = 90 : .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(9).HeaderText = "Tipo Pago" : .Columns(9).Width = 120 : .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(10).HeaderText = "Apartado" : .Columns(10).Width = 90 : .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).HeaderText = "Concepto" : .Columns(11).Width = 80 : .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Me.dgv_TipoPagos

            .Columns(0).HeaderText = "Tipo de Pago" : .Columns(0).Width = 180
            .Columns(1).HeaderText = "Cantidad" : .Columns(1).Width = 80 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "Monto" : .Columns(2).Width = 100 : .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        With Me.dgv_Conceptos

            .Columns(0).HeaderText = "Concepto" : .Columns(0).Width = 180
            .Columns(1).HeaderText = "Cantidad" : .Columns(1).Width = 80 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "Monto" : .Columns(2).Width = 100 : .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        With Me.dgv_Totales

            .Columns(0).HeaderText = "Concepto" : .Columns(0).Width = 180
            .Columns(1).HeaderText = "Cantidad" : .Columns(1).Width = 80 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "Monto" : .Columns(2).Width = 100 : .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

    End Sub

    Sub CargarFechas()
        With Me
            .dtp_FechaInicial.Text = "01/01/2025"
            .dtp_FechaFinal.Text = Date.Now()
        End With
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        CargarFechas()
        With Me
            .dgv_Datos.DataSource = Nothing
            .dgv_Conceptos.DataSource = Nothing
            .dgv_TipoPagos.DataSource = Nothing
            .dgv_Totales.DataSource = Nothing
        End With
    End Sub

    Sub CargarDataGritView()
        Dim worker As New BackgroundWorker()

        If Me.dtp_FechaInicial.Value > Me.dtp_FechaFinal.Value Then
            If ProgressBar1.InvokeRequired Then
                ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
            Else
                ProgressBar1.Visible = False
            End If
            MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With Me
                Me.Invoke(Sub() .dtp_FechaInicial.Text = "01/01/2025")
                Me.Invoke(Sub() .dtp_FechaFinal.Text = Date.Now())
            End With
            Me.Invoke(Sub() Me.dtp_FechaInicial.Focus())
            Exit Sub
        Else
            AddHandler worker.DoWork,
                    Sub()
                        Invoke(Sub()
                                   ' Cargar datos aquí
                                   Select Case NumOptica
                                       Case 0
                                           dtDatos = BuscarDatos("PReporte_Semanal0")
                                           dtTipoPago = BuscarDatos("PReporte_TipoPagos0")
                                           dtTotales = BuscarDatos("PReporte_ConceptoTotalVentasMejorado0")
                                       Case 1
                                           dtDatos = BuscarDatos("PReporte_Semanal1")
                                           dtTipoPago = BuscarDatos("PReporte_TipoPagos1")
                                           dtTotales = BuscarDatos("PReporte_ConceptoTotalVentasMejorado1")
                                   End Select
                                   dtConcepto = BuscarDatos("PReporte_Concepto")
                                   dtProductos = BuscarDatos("PReporte_Productos")
                                   Try
                                       If dtDatos.Rows.Count = 0 Then
                                           MessageBox.Show("No hay datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                       Else
                                           SelectChange = True
                                           Me.dgv_Datos.DataSource = dtDatos
                                           Me.lbl_Registros.Text = dtDatos.Rows.Count.ToString()
                                           Me.dgv_TipoPagos.DataSource = dtTipoPago
                                           Me.dgv_Conceptos.DataSource = dtConcepto
                                           Me.dgv_Totales.DataSource = dtTotales
                                           CargarEncabezadoGridView()
                                           BorrarCeldasDuplicadas()
                                           'AgregarFilaTotales()
                                           DesSeleccionarDatagridView()
                                       End If
                                   Catch ex As Exception
                                       MsgBox(ex.Message)
                                   End Try

                               End Sub
                        )
                    End Sub
            worker.RunWorkerAsync()
        End If
    End Sub

    Public Function BuscarDatos(reporte As String) As DataTable
        Try
            If Conectar() Then
                Dim fechaIni As DateTime = Me.dtp_FechaInicial.Text
                Dim fechaFin As DateTime = Me.dtp_FechaFinal.Text
                Using cmd As New SqlCommand(reporte, CNN)
                    cmd.CommandType = CommandType.StoredProcedure
                    'cmd.Connection = CNN
                    cmd.Parameters.AddWithValue("@FechaIni", FormatDateTime(fechaIni, DateFormat.ShortDate) & " " & fechaIni.ToString("00:00:00"))
                    cmd.Parameters.AddWithValue("@FechaFin", FormatDateTime(fechaFin, DateFormat.ShortDate) & " " & fechaFin.ToString("23:59:00"))
                    If cmd.ExecuteNonQuery Then
                        Dim da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        Desconectar()
                        Return dt
                    Else
                        Desconectar()
                        Return Nothing
                    End If
                End Using
                Desconectar()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
        bgWorker1.RunWorkerAsync()
    End Sub

    Private Sub bgWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker1.DoWork
        CargarDataGritView()
    End Sub

    Private Sub bgWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker1.RunWorkerCompleted
        ProgressBar1.Visible = False
    End Sub

    Private Sub btn_DesSeleccionar_Click(sender As Object, e As EventArgs) Handles btn_DesSeleccionar.Click
        DesSeleccionarDatagridView()
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo Excel|*.xlsx"
        saveFileDialog.Title = "Guardar archivo como"
        saveFileDialog.FileName = NomOptica.ToString()

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            rutaArchivo = saveFileDialog.FileName
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
            bgWorker.RunWorkerAsync()
        End If
        'ExportarAExcel(Me.dgv_Datos, Me.ProgressBar1)
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgWorker.DoWork
        'exportador.ExportarVentasExcel(dtDatos, rutaArchivo, AddressOf ReportarProgreso)
        exportador.ExportarReportePagosYProductos(dtDatos, dtProductos, NomOptica, AddressOf ReportarProgreso)
    End Sub

    Private Sub ReportarProgreso(progreso As Integer)
        bgWorker.ReportProgress(progreso)
    End Sub

    Private Sub gbworker_progressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgWorker.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        ProgressBar1.Visible = False
        MessageBox.Show("Exportación completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgv_Datos_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_Datos.SelectionChanged
        With Me
            If SelectChange = True Then
                .lbl_SumaSelect.Text = SumaCeldasSeleccionadas()
                .lbl_CantidadSeleccionada.Text = CantidadSeleccionada()
            End If
        End With
    End Sub

    Private Sub dgv_Datos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Datos.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            idOrden = Convert.ToInt64(Me.dgv_Datos.CurrentRow.Cells("idOrden").Value)
            Dim frm As New FFacturacion()
            frm.Show()
            frm.CargarDetalleOrden(idOrden)
        End If
    End Sub

End Class