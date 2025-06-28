Imports System.Data.SqlClient
Public Class FReportesRango
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter

    Private Sub FReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Desde.Value = DateTime.Now()
        Me.Hasta.Value = DateTime.Now()
    End Sub
    Private Sub BAnterior_Click(sender As Object, e As EventArgs) Handles BAnterior.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(-1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(-1)
        BListado_Click(Nothing, Nothing)
    End Sub

    Private Sub BSiguiente_Click(sender As Object, e As EventArgs) Handles BSiguiente.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(1)
        BListado_Click(Nothing, Nothing)
    End Sub

    Private Sub BListado_Click(sender As Object, e As EventArgs) Handles BListado.Click
        If Conectar() Then
            Try
                Adaptador = New SqlDataAdapter("Select * FROM VVentasxEmpleado WHERE CAST(CONVERT(CHAR(8), FechaPago, 112) AS INT) BETWEEN CAST(CONVERT(CHAR(8), @Desde, 112) AS INT) AND CAST(CONVERT(CHAR(8), @Hasta, 112) AS INT)", CNN)
                Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                DataT = New DataTable
                Adaptador.Fill(DataT)              
                Dim Rpt As New CRVentasXEmpleado
                Rpt.SetDataSource(DataT)
                Rpt.SetParameterValue("Desde", Me.Desde.Value)
                Rpt.SetParameterValue("Hasta", Me.Hasta.Value)
                Me.CrystalReportViewer1.ReportSource = Rpt
            Catch ex As Exception
                MessageBox.Show("Error al Imprimir Reporte." & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Desconectar()
    End Sub
End Class