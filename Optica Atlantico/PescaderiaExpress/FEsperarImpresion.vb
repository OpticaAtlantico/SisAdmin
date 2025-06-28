
Public Class FEsperarImpresion
    Private Sub FEsperarImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case VarForma
            Case "Imprimir"
                Me.ImagenBase.BackgroundImage = Me.ImagenImprimir.BackgroundImage
                Me.Titulo.Text = "Imprimiendo, Por Favor Espere..."
            Case "Calcular"
                Me.ImagenBase.BackgroundImage = Me.ImagenCalcular.BackgroundImage
                Me.Titulo.Text = "Calculando, Por Favor Espere..."
            Case "Guardar"
                Me.ImagenBase.BackgroundImage = Me.ImagenGuardar.BackgroundImage
                Me.Titulo.Text = "Guardando Documento Pendiente..."
            Case "CalcularMonedaBase"
                Me.ImagenBase.BackgroundImage = Me.ImagenCalcularPrecios.BackgroundImage
                Me.Titulo.Text = "Actualizando P.V.P., Por Favor Espere..."
            Case Else
                Me.ImagenBase.BackgroundImage = Me.ImagenImprimir.BackgroundImage
                Me.Titulo.Text = "Imprimiendo, Por Favor Espere..."
        End Select
      
    End Sub
End Class