
Imports System.Data.SqlClient
Public Class FDetalleCompra

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
    Private Sub FDetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LProveedor.Text = Proveedor & "."
        Try
            If Conectar() Then
                Dim Comando As New SqlCommand("Select * FROM VDetalleCompra WHERE idCompra=" & CodCompra, CNN)
                Dim DatosArt As SqlDataReader = Comando.ExecuteReader()
                Me.DGVDetalle.Rows.Clear()
                Do While DatosArt.Read()
                    Me.DGVDetalle.Rows.Add(DatosArt("Codigo").ToString, DatosArt("Producto").ToString, Format(DatosArt("Cantidad"), "##,##0.00"), Format(DatosArt("CostoCalD"), "##,##0.0000"), Format(DatosArt("CostoCal"), "##,##0.0000"), Format(DatosArt("PrecioD1"), "##,##0.0000"), Format(DatosArt("Precio1"), "##,##0.0000"), Format(DatosArt("TotalD"), "##,##0.0000"), Format(DatosArt("Total"), "##,##0.0000"), DatosArt("Observaciones").ToString)
                Loop
                DatosArt.Close()
                Desconectar()
            End If
            Me.LTotalD.Text = Format(SumarColumna(Me.DGVDetalle, 7), "##,##0.0000")
            Me.LTotalBs.Text = Format(SumarColumna(Me.DGVDetalle, 8), "##,##0.0000")
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de los Detalles de la Compra. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
End Class