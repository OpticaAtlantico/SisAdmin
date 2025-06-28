Imports System.Data.SqlClient
Public Class FInicializarNew
    Dim UltimaDir As String = "C:\"
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub TPP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPP2.KeyPress
        e.Handled = txtNumerico(Me.TPP2, e.KeyChar, False)
    End Sub
    Private Sub TPP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPP3.KeyPress
        e.Handled = txtNumerico(Me.TPP3, e.KeyChar, False)
    End Sub
    Private Sub TPPM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPPM.KeyPress
        e.Handled = txtNumerico(Me.TPPM, e.KeyChar, False)
    End Sub
    Private Sub TPEmp1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPEmp1.KeyPress
        e.Handled = txtNumerico(Me.TPEmp1, e.KeyChar, False)
    End Sub
    Private Sub TPEmp2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPEmp2.KeyPress
        e.Handled = txtNumerico(Me.TPEmp2, e.KeyChar, False)
    End Sub
    Private Sub TPEmp3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPEmp3.KeyPress
        e.Handled = txtNumerico(Me.TPEmp3, e.KeyChar, False)
    End Sub
    Private Sub GuardarCategoriasConDescuento()
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("Delete TCategoriaConDescuento", CNN)
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                For i = 0 To Me.Lista1.RowCount - 1
                    Comando.CommandText = "INSERT INTO TCategoriaConDescuento (id, Nombre) VALUES (" & Me.Lista1.Item(0, i).Value & ",'" & Me.Lista1.Item(1, i).Value & "')"
                    DR = Comando.ExecuteReader()
                    DR.Close()
                Next
                Desconectar()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos de las Categorias con Descuento. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (Conectar()) Then
            Try
                Dim Comando As New SqlCommand("UPDATE TGeneral SET PPrecio2=@PPrecio2, PPrecio3=@PPrecio3,PPrecio4=@PPrecio4,PPrecio5=@PPrecio5,PPrecioMayor=@PPrecioMayor, DireccionPDF=@DireccionPDF, PEmp1=@PEmp1, PEmp2=@PEmp2, PEmp3=@PEmp3, CantMesas=@CantMesas, CantBarras=@CantBarras", CNN)
                Comando.Parameters.Add(New SqlParameter("@PPrecio2", Convert.ToDecimal(Me.TPP2.Text)))
                Comando.Parameters.Add(New SqlParameter("@PPrecio3", Convert.ToDecimal(Me.TPP3.Text)))
                Comando.Parameters.Add(New SqlParameter("@PPrecio4", Convert.ToDecimal(Me.TPP4.Text)))
                Comando.Parameters.Add(New SqlParameter("@PPrecio5", Convert.ToDecimal(Me.TPP5.Text)))
                Comando.Parameters.Add(New SqlParameter("@PPrecioMayor", Convert.ToDecimal(Me.TPPM.Text)))
                Comando.Parameters.Add(New SqlParameter("@DireccionPDF", Me.TDireccion.Text))
                Comando.Parameters.Add(New SqlParameter("@PEmp1", Convert.ToDecimal(Me.TPEmp1.Text)))
                Comando.Parameters.Add(New SqlParameter("@PEmp2", Convert.ToDecimal(Me.TPEmp2.Text)))
                Comando.Parameters.Add(New SqlParameter("@PEmp3", Convert.ToDecimal(Me.TPEmp3.Text)))

                Comando.Parameters.Add(New SqlParameter("@CantMesas", Convert.ToDecimal(Me.TCantMesas.Text)))
                Comando.Parameters.Add(New SqlParameter("@CantBarras", Convert.ToDecimal(Me.TCantBarras.Text)))


                Comando.ExecuteReader()
                Desconectar()
                GuardarCategoriasConDescuento()
                LlenarVariables()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error al Guardar los Datos de las Variables. " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
                Desconectar()
            End Try
        End If
    End Sub

 

   
    Private Sub BBuscarDireccion_Click(sender As Object, e As EventArgs) Handles BBuscarDireccion.Click
        Me.Dialogo.Filter = "PDF Archivos|*.PDF"
        Me.Dialogo.FileName = ""
        Me.Dialogo.InitialDirectory = UltimaDir
        If (Me.Dialogo.ShowDialog = Windows.Forms.DialogResult.OK) Then
            UltimaDir = Me.Dialogo.FileName
            For i = Len(UltimaDir) To 1 Step -1
                Dim xx As String = Mid(UltimaDir, i, 1)
                If (Mid(UltimaDir, i, 1) = "\") Then
                    UltimaDir = Mid(UltimaDir, 1, i)
                    Exit For
                End If
            Next
            Me.TDireccion.Text = UltimaDir
        End If
    End Sub
    Private Sub Llenardatos()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("SELECT * FROM TGeneral", CNN)
                Dim DataReader As SqlDataReader = Comando.ExecuteReader()
                If (DataReader.Read()) Then                  
                    Me.TPP2.Text = DataReader("PPrecio2")
                    Me.TPP3.Text = DataReader("PPrecio3")
                    Me.TPP4.Text = DataReader("PPrecio4")
                    Me.TPP5.Text = DataReader("PPrecio5")
                    Me.TPPM.Text = DataReader("PPrecioMayor")
                    Me.TDireccion.Text = DataReader("DireccionPDF")
                    Me.TPEmp1.Text = Format(DataReader("PEmp1"), "##,##0")
                    Me.TPEmp2.Text = Format(DataReader("PEmp2"), "##,##0")
                    Me.TPEmp3.Text = Format(DataReader("PEmp3"), "##,##0")
                    Me.TCantMesas.Text = DataReader("CantMesas")
                    Me.TCantBarras.Text = DataReader("CantBarras")
                End If
                DataReader.Close()
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Cargar Datos de Variables " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Private Sub LlenarCategorias()
        If (Conectar()) Then
            Dim Comando As New SqlCommand("SELECT id, Nombre FROM TCategoriaConDescuento ORDER BY Nombre ASC", CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()
            Me.Lista1.Rows.Clear()
            Do While DR.Read()
                Me.Lista1.Rows.Add(DR("id"), DR("Nombre"))
            Loop
            DR.Close()
            Desconectar()
        End If
    End Sub
    Private Sub FInicializarNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenardatos()
        LlenarCategorias()
    End Sub   

   
End Class