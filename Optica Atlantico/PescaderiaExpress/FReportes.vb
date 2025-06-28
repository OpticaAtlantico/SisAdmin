Imports System.Data.SqlClient
Public Class FReportes
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter

    Private Sub FReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case VarForma
            Case "VentasXEmpleado"

            Case "FACTURA"
                If Conectar() Then
                    Try
                        Adaptador = New SqlDataAdapter("Select * FROM VOrdenEmpresa WHERE idOrden=" & CodOrden, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Dim Rpt As New CRFactura
                        Rpt.SetDataSource(DataT)
                        Rpt.SetParameterValue("idOrdenX", CodOrden)
                        Rpt.SetParameterValue("Abonado", AbonadoGnal)
                        Rpt.SetParameterValue("TipoPago", TipoPago)
                        Me.CrystalReportViewer1.ReportSource = Rpt
                    Catch ex As Exception
                        MessageBox.Show("Error al Imprimir Reporte." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                Desconectar()
            Case "Formula"
                If Conectar() Then
                    Try
                        Adaptador = New SqlDataAdapter("Select * FROM VOrdenEmpresa WHERE idOrden=" & CodOrden, CNN)
                        DataT = New DataTable
                        Adaptador.Fill(DataT)
                        Dim Rpt As New CRFormula
                        Rpt.SetDataSource(DataT)
                        Rpt.SetParameterValue("idOrdenX", CodOrden)
                        Rpt.SetParameterValue("Abonado", AbonadoGnal)
                        Me.CrystalReportViewer1.ReportSource = Rpt
                    Catch ex As Exception
                        MessageBox.Show("Error al Imprimir Reporte." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                Desconectar()
        End Select
    End Sub


End Class