Imports System.Data.SqlClient
Public Class FComentarioSolo
    Private Sub FComentario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MarSoft: Observación."
        Me.LObservacion.Text = "OBSERVACIÓN"
        Select Case VarForma

            Case "ConsolidacionBancaria1", "ConsolidacionBancaria2"
                Me.TComentario.ReadOnly = True
                Me.BAceptar.Focus()
            Case "FormaPagoEmpleados"
                Me.Text = "MarSoft: Observación de Forma de Pago del Empleado."
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "FormaPagoCliente"
                Me.Text = "MarSoft: Observación de Forma de Pago del Cliente."
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "Recepcion"
                Me.Text = "MarSoft: Observación de Mercancia con Problemas."
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "ObservacionInvSalidaGral"
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "Gastos", "InventarioLinea", "FormaMostrarOtrosIngresos", "FondoAnticipo", "ComentarioMesas"
                Me.TComentario.ReadOnly = True
                Me.BAceptar.Focus()
            Case "Recetas"
                Me.Text = "MarSoft: Preparación."
                Me.LObservacion.Text = "PREPARACIÓN"
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "ComentarioCtasporPagar"
                Me.TComentario.ReadOnly = True
            Case "Pos-Venta"
                Me.Text = "MarSoft: Datos de Post-Venta."
                Me.LObservacion.Text = "Observación del Producto: " & FComentario.Tag & "."
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "Pos-Venta2"
                Me.Text = "MarSoft: Datos de Post-Venta."
                Me.LObservacion.Text = "Observación del Producto: " & FComentario.Tag & "."
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case "ObsPosVenta", "DetalleFormaPago"
                Me.TComentario.ReadOnly = True
                Me.BAceptar.Focus()
            Case "ComentarioBuscarCierreCaja"
                Me.Text = "MarSoft: Observación General del Cierre Caja."
                Me.LObservacion.Text = "Observación General del Cierre Caja:"
                Me.TComentario.ReadOnly = True
                Me.BAceptar.Focus()
            Case "ObservacionControlCaja"
                Me.Text = "MarSoft: Observación General del Cierre Caja."
                Me.LObservacion.Text = "Observación General del Cierre Caja:"
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
            Case Else
                Me.TComentario.ReadOnly = False
                Me.TComentario.Focus()
        End Select
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
    Private Sub GuardarObservacionProducto()
        If (Conectar()) Then
            Dim tran As SqlTransaction = CNN.BeginTransaction
            Dim Comando As New SqlCommand("UPDATE TDetalleVenta SET DatosPosVenta=@DatosPosVenta where idDetVenta=" & CodDetalleVenta, CNN)
            Comando.Parameters.Add(New SqlParameter("@DatosPosVenta", Me.TComentario.Text))
            Comando.Transaction = tran
            Try
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                tran.Commit()
                Me.Close()
            Catch ex As Exception
                tran.Rollback()
                MsgBox("Error al Guardar los Datos de la Post-Venta.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
                ErrorTrans = True
            End Try
        End If
        Desconectar()
    End Sub
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Select Case VarForma
            Case "ControlRecepcion"
                Observacionrecepcion = Me.TComentario.Text
            Case "Facturacion"
                FFacturacion.BObservOrden.Tag = Me.TComentario.Text          
            Case "ObservacionControlCaja"
                FControlCaja.TComentario.Text = Me.TComentario.Text
        End Select
        Me.Close()
    End Sub
End Class