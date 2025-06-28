Imports System.Data.SqlClient
Imports System.Data
Public Class FBuscarOrden
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private DataT2 As DataTable
    Private Adaptador2 As SqlDataAdapter
    Private CadSQL As String = ""
    Private Sub MostrarDatosBusqueda()
        Me.Grid.DataSource = Nothing
        CadSQL = ""
        Try
            If Conectar() Then
                Dim CadBase = "Select idOrden, FechaOrden, Nacionalidad, CI, Cliente, idAsesor, Asesor, SubTotal, Descuento, Total FROM VOrden"
                If (Me.TNumOrden.Text <> "") Then
                    CadSQL = " Where idOrden=" & Convert.ToInt64(Me.TNumOrden.Text)
                Else
                    If (Me.TCI.Text <> "") Then
                        CadSQL = " where  Nacionalidad='" & Me.CNac.Text & "' AND CI=" & Convert.ToInt64(Me.TCI.Text)
                    Else
                        If (Me.TNombre.Text <> "") Then
                            CadSQL = " Where Cliente Like '%" & Me.TNombre.Text & "%'"
                        Else
                            If (Me.TRIF.Text <> "") Then
                                CadSQL = " where TipoRIF='" & Me.CTipoRif.Text & "' AND RIF='" & Me.TRIF.Text & "'"
                            Else
                                If (Me.CAsesor.Text <> "") Then
                                    CadSQL = " Where idAsesor=" & Convert.ToInt64(Me.CAsesor.SelectedValue)
                                End If
                            End If
                        End If                       
                    End If
                    If (CadSQL <> "") Then
                        CadSQL = CadSQL & " AND FechaOrden>=@Desde AND FechaOrden<=@Hasta "
                    Else
                        CadSQL = " WHERE  FechaOrden>=@Desde AND FechaOrden<=@Hasta "
                    End If
                End If

                CadSQL = CadBase & CadSQL
                Adaptador = New SqlDataAdapter(CadSQL, CNN)
                Adaptador.SelectCommand.Parameters.Add("@Desde", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Desde").Value = Me.Desde.Value
                Adaptador.SelectCommand.Parameters.Add("@Hasta", SqlDbType.DateTime)
                Adaptador.SelectCommand.Parameters("@Hasta").Value = Me.Hasta.Value
                DataT = New DataTable
                Adaptador.Fill(DataT)
                Me.Grid.DataSource = DataT
                Grid.Columns("idOrden").HeaderText = "N°"
                Grid.Columns("idOrden").Width = 60
                Grid.Columns("FechaOrden").HeaderText = "Fecha"
                Grid.Columns("FechaOrden").Width = 180
                Grid.Columns("Nacionalidad").HeaderText = "Nac"
                Grid.Columns("Nacionalidad").Width = 60
                Grid.Columns("CI").HeaderText = "CI"
                Grid.Columns("CI").Width = 90                         
                Grid.Columns("Cliente").HeaderText = "Cliente"
                Grid.Columns("Cliente").Width = 250
                Grid.Columns("Asesor").HeaderText = "Asesor"
                Grid.Columns("Asesor").Width = 250
              
                Grid.Columns("idOrden").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Grid.Columns("FechaOrden").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Grid.Columns("Nacionalidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Grid.Columns("CI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter            
                Grid.Columns("Cliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Grid.Columns("Asesor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Else
                Me.Grid.DataSource = Nothing
            End If
            Desconectar()
        Catch ex As Exception
            MessageBox.Show("ERROR al Conectar o Recuperar los Datos de la Orden. " & vbCrLf & ex.Message, "Marsoft: Error de Datos.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Desconectar()
        End Try
    End Sub
    Private Sub ResaltarSeleccionado() 'se queda
        Me.LTitulo.Tag = IIf(Me.LTitulo.Tag = Nothing, 0, Me.LTitulo.Tag)
        Me.LTitulo.Tag = IIf(Me.LTitulo.Tag.ToString = "", 0, Me.LTitulo.Tag)
        For i = 0 To Grid.RowCount - 1
            If (Me.Grid.Rows(i).Cells(0).Value = Me.LTitulo.Tag) Then
                Me.Grid.CurrentCell = Me.Grid.Rows(i).Cells(0)
            End If
        Next
    End Sub
    Private Sub LlenarComboAsesor()
        If Conectar2() Then
            Try
                Adaptador2 = New SqlDataAdapter("SELECT   idEmpleado as id, Nombre  FROM VEmpleado WHERE idCargo=1 OR idEmpleado=1 ORDER BY Nombre ASC", CNN2)
                DataT2 = New DataTable
                Adaptador2.Fill(DataT2)
                Me.CAsesor.DataSource = DataT2
                Me.CAsesor.DisplayMember = "Nombre"
                Me.CAsesor.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al Cargar Datos de los Asesores..." & ControlChars.CrLf & ex.Message)
                Desconectar2()
            End Try
        End If
        Desconectar2()
    End Sub
    Private Sub FBuscarOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TNumOrden.Text = ""
        Me.TNombre.Text = ""
        Me.TCI.Text = ""
        Me.TRIF.Text = ""
        Me.CNac.Text = "V"
        Me.CTipoRif.Text = "J"
        Me.Desde.Value = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, 0, 0, 0, 0)
        Me.Hasta.Value = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, 23, 59, 59, 59)
        MostrarDatosBusqueda()
        ResaltarSeleccionado()
        LlenarComboAsesor()
        Me.TCI.Select()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        NoActualizar = True
        Me.Close()
    End Sub
    Private Sub Grid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentDoubleClick
        NoActualizar = False
        CodOrden = Convert.ToInt64(Me.Grid.CurrentRow.Cells("idOrden").Value)
        Me.Close()
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        Grid_CellContentDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub Tnombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TNombre.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                MostrarDatosBusqueda()
                Me.Grid.Select()
        End Select
    End Sub

    Private Sub Grid_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Grid_CellContentDoubleClick(Nothing, Nothing)
        End Select
    End Sub
    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        MostrarDatosBusqueda()
    End Sub
    Private Sub BAnterior_Click(sender As Object, e As EventArgs) Handles BAnterior.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(-1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(-1)
    End Sub

    Private Sub BSiguiente_Click(sender As Object, e As EventArgs) Handles BSiguiente.Click
        Me.Desde.Value = Me.Desde.Value.AddDays(1)
        Me.Hasta.Value = Me.Hasta.Value.AddDays(1)
    End Sub

    Private Sub TNumOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNumOrden.KeyPress
        e.Handled = txtNumerico(TNumOrden, e.KeyChar, False)
    End Sub
    Private Sub TCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TCI.KeyPress
        e.Handled = txtNumerico(TCI, e.KeyChar, False)
    End Sub
    Private Sub TRIF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TRIF.KeyPress
        e.Handled = txtNumerico(TRIF, e.KeyChar, False)
    End Sub
    Private Sub BExportar_Click(sender As Object, e As EventArgs) Handles BExportar.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim Forma As New FEsperarImpresion
        Forma.ExportarExcel.Visible = True
        Forma.Show()
        Forma.Refresh()
        Call GridExcel(Grid)
        Forma.Close()
        Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub TCI_TextChanged(sender As Object, e As EventArgs) Handles TCI.TextChanged

    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class