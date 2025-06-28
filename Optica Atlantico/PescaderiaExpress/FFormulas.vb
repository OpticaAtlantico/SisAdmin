Imports System.Data.SqlClient
Public Class FFormulas
    Private DataT As DataTable
    Private Adaptador As SqlDataAdapter
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub
    Private Sub DEsf_KeyDown(sender As Object, e As KeyEventArgs) Handles TDEsf.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TDCil.Focus()
        End If
    End Sub
    Private Sub DCil_KeyDown(sender As Object, e As KeyEventArgs) Handles TDCil.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TDEje.Focus()
        End If
    End Sub
    Private Sub TDEje_KeyDown(sender As Object, e As KeyEventArgs) Handles TDEje.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TDAdd.Focus()
        End If
    End Sub
    Private Sub DAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles TDAdd.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TIEsf.Focus()
        End If
    End Sub
    Private Sub IEsf_KeyDown(sender As Object, e As KeyEventArgs) Handles TIEsf.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TICil.Focus()
        End If
    End Sub
    Private Sub ICil_KeyDown(sender As Object, e As KeyEventArgs) Handles TICil.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TIEje.Focus()
        End If
    End Sub
    Private Sub IEfE_KeyDown(sender As Object, e As KeyEventArgs) Handles TIEje.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TIAdd.Focus()
        End If
    End Sub
    Private Sub IAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles TIAdd.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TH.Focus()
        End If
    End Sub
    Private Sub TH_KeyDown(sender As Object, e As KeyEventArgs) Handles TH.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TV.Focus()
        End If
    End Sub
    Private Sub V_KeyDown(sender As Object, e As KeyEventArgs) Handles TV.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TD.Focus()
        End If
    End Sub
    Private Sub D_KeyDown(sender As Object, e As KeyEventArgs) Handles TD.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TP.Focus()
        End If
    End Sub
    Private Sub P_KeyDown(sender As Object, e As KeyEventArgs) Handles TP.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TDP.Focus()
        End If
    End Sub
    'Private Sub max_KeyDown(sender As Object, e As KeyEventArgs) Handles TMax.KeyDown
    '    If (e.KeyData = Keys.Enter) Then
    '        Me.TDP.Focus()
    '    End If
    'End Sub
    Private Sub Dp_KeyDown(sender As Object, e As KeyEventArgs) Handles TDP.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TAlt.Focus()
        End If
    End Sub
    Private Sub TAlt_KeyDown(sender As Object, e As KeyEventArgs) Handles TAlt.KeyDown
        If (e.KeyData = Keys.Enter) Then
            Me.TObservacion.Focus()
        End If
    End Sub
    Private Sub DEsf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDEsf.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoNegativoPositivo(TDEsf, e.KeyChar, True)
    End Sub
    Private Sub DCil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDCil.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoNegativo(TDCil, e.KeyChar, True)
    End Sub
    Private Sub DEje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDEje.KeyPress
        e.Handled = txtNumerico(TDEje, e.KeyChar, False)
    End Sub

    Private Sub DAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDAdd.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoPositivo(TDAdd, e.KeyChar, True)
    End Sub
    Private Sub IEsf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TIEsf.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoNegativoPositivo(TIEsf, e.KeyChar, True)
    End Sub
    Private Sub ICil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TICil.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoNegativo(TICil, e.KeyChar, True)
    End Sub
    Private Sub IEje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TIEje.KeyPress, TDEje.KeyPress
        e.Handled = txtNumerico(TIEje, e.KeyChar, False)
    End Sub

    Private Sub IAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TIAdd.KeyPress
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
        e.Handled = txtNumericoPositivo(TIAdd, e.KeyChar, True)
    End Sub



    Private Sub H_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TH.KeyPress
        e.Handled = txtNumerico(TH, e.KeyChar, False)
    End Sub

    Private Sub V_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TV.KeyPress
        e.Handled = txtNumerico(TV, e.KeyChar, False)
    End Sub

    Private Sub D_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TD.KeyPress
        e.Handled = txtNumerico(TD, e.KeyChar, False)
    End Sub

    Private Sub P_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TP.KeyPress
        e.Handled = txtNumerico(TP, e.KeyChar, False)
    End Sub

    Private Sub MAX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TMax.KeyPress
        e.Handled = txtNumerico(TMax, e.KeyChar, False)
    End Sub

    Private Sub DP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDP.KeyPress
        e.Handled = txtNumerico(TDP, e.KeyChar, False)
    End Sub

    Private Sub Alt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TAlt.KeyPress
        e.Handled = txtNumerico(TAlt, e.KeyChar, False)
    End Sub
    Private Sub ActualizarFormula()
        Try
            If (Conectar()) Then
                Dim Comando As New SqlCommand("UPDATE TFormula SET idOrden=@idOrden,  DEsf=@DEsf,  IEsf=@IEsf,  DCil=@DCil,  ICil=@ICil,  DEje=@DEje,  IEje=@IEje,  DAdd=@DAdd, IAdd=@IAdd,  H=@H,  V=@V,  D=@D,  P=@P,  Max=@Max,  DP=@DP,  Alt=@Alt,  Observacion=@Observacionx, FormulaExt=@FormulaExt, DoctorExt=@DoctorExt  WHERE idOrden=@idOrden", CNN)
                Comando.Parameters.Add(New SqlParameter("@idOrden", CodOrden))
                Comando.Parameters.Add(New SqlParameter("@DEsf", DEsf))
                Comando.Parameters.Add(New SqlParameter("@IEsf", IEsf))
                Comando.Parameters.Add(New SqlParameter("@DCil", DCil))
                Comando.Parameters.Add(New SqlParameter("@ICil", ICil))
                Comando.Parameters.Add(New SqlParameter("@DEje", DEje))
                Comando.Parameters.Add(New SqlParameter("@IEje", IEje))
                Comando.Parameters.Add(New SqlParameter("@DAdd", DAdd))
                Comando.Parameters.Add(New SqlParameter("@IAdd", IAdd))
                Comando.Parameters.Add(New SqlParameter("@H", H))
                Comando.Parameters.Add(New SqlParameter("@V", V))
                Comando.Parameters.Add(New SqlParameter("@D", D))
                Comando.Parameters.Add(New SqlParameter("@P", P))
                Comando.Parameters.Add(New SqlParameter("@Max", Max))
                Comando.Parameters.Add(New SqlParameter("@DP", DP))
                Comando.Parameters.Add(New SqlParameter("@Alt", Alt))
                Comando.Parameters.Add(New SqlParameter("@Observacionx", ObservacionFormula))
                Comando.Parameters.Add(New SqlParameter("@FormulaExt", FormulaExterna))
                Comando.Parameters.Add(New SqlParameter("@DoctorExt", DoctorExt))
                Dim DR As SqlDataReader = Comando.ExecuteReader()
                DR.Close()
                ActivarGuardar = True
                MsgBox("Los Datos Fueron «Guardados» con Exito!!!", MsgBoxStyle.Information, "MarSoft: Información.")
            End If
            Desconectar()
        Catch ex As Exception
            MsgBox("Error al Actualizar los Datos de las Formulas.  " & ex.Message, MsgBoxStyle.Critical, "MarSoft: Error de Datos.")
            Desconectar()
            ActivarGuardar = False
        End Try
    End Sub
    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Dim ADD As Boolean = IIf(Me.TDAdd.Text = "", False, True)
        If (ADD = False) Then
            ADD = IIf(Me.TIAdd.Text = "", False, True)
        End If
        If (Me.TDP.Text <> "") Then
            If ((ADD = False) And (Me.TAlt.Text <> "")) Or ((ADD = True) And (Me.TAlt.Text <> "")) Or ((ADD = False) And (Me.TAlt.Text = "")) Then
                If ((Me.TDCil.Text <> "") And (Me.TDEje.Text <> "")) Or (Me.TDCil.Text = "") Then
                    If ((Me.TICil.Text <> "") And (Me.TIEje.Text <> "")) Or (Me.TICil.Text = "") Then
                        DEsf = Me.TDEsf.Text
                        DCil = Me.TDCil.Text
                        DEje = IIf(Me.TDCil.Text = "", "", Me.TDEje.Text)
                        DAdd = Me.TDAdd.Text
                        IEsf = Me.TIEsf.Text
                        ICil = Me.TICil.Text
                        IEje = IIf(Me.TICil.Text = "", "", Me.TIEje.Text)
                        IAdd = Me.TIAdd.Text
                        H = Me.TH.Text
                        V = Me.TV.Text
                        D = Me.TD.Text
                        P = Me.TP.Text
                        Max = Me.TMax.Text
                        DP = Me.TDP.Text
                        Alt = Me.TAlt.Text
                        ObservacionFormula = Me.TObservacion.Text
                        FormulaExterna = Me.CHFormulaExterna.Checked
                        DoctorExt = IIf(FormulaExterna, Me.TDoctoExterno.Text, "")
                        ActualizarFormula()
                    Else
                        MsgBox("Debe Ingresar «EJE O:I». ", MsgBoxStyle.Information, "MarSoft: Información.")
                        Me.TIEje.Focus()
                    End If
                Else
                    MsgBox("Debe Ingresar «EJE O:D». ", MsgBoxStyle.Information, "MarSoft: Información.")
                    Me.TDEje.Focus()
                End If
            Else
                MsgBox("Debe Ingresar «ALT». ", MsgBoxStyle.Information, "MarSoft: Información.")
                Me.TAlt.Focus()
            End If
        Else

            MsgBox("Debe Ingresar «DP». ", MsgBoxStyle.Information, "MarSoft: Información.")
            Me.TDP.Focus()
        End If
    End Sub

    Private Sub FFormulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TDEsf.Text = DEsf
        Me.TDCil.Text = DCil
        Me.TDEje.Text = DEje
        Me.TDAdd.Text = DAdd
        Me.TIEsf.Text = IEsf
        Me.TICil.Text = ICil
        Me.TIEje.Text = IEje
        Me.TIAdd.Text = IAdd
        Me.TH.Text = H
        Me.TV.Text = V
        Me.TD.Text = D
        Me.TP.Text = P
        Me.TMax.Text = Max
        Me.TDP.Text = DP
        Me.TAlt.Text = Alt
        Me.TObservacion.Text = ObservacionFormula
        Me.CHFormulaExterna.Checked = FormulaExterna
        Me.TDoctoExterno.Text = DoctorExt
        Me.TDEsf.Focus()
    End Sub
    Private Sub BuscarAbonoCliente()
        If Conectar() Then
            Dim Comando As New SqlCommand("Select SUM(Monto) as Abonado FROM VFormaPago Where idOrden=" & CodOrden, CNN)
            Dim DR As SqlDataReader = Comando.ExecuteReader()           
            If DR.Read() Then
                If (DR("Abonado").ToString = "") Then
                    AbonadoGnal = 0
                Else
                    AbonadoGnal = DR("Abonado")
                End If
            End If
            DR.Close()
        End If
        Desconectar()
    End Sub
    Private Sub BImprimir_Click(sender As Object, e As EventArgs) Handles BImprimir.Click
        VarForma = "Formula"
        BuscarAbonoCliente()
        FReportes.ShowDialog()
    End Sub
    Private Sub TH_TextChanged(sender As Object, e As EventArgs) Handles TH.TextChanged
        Me.TMax.Text = Convert.ToDecimal(IIf(Me.TH.Text = "", 0, Me.TH.Text)) + Convert.ToDecimal(IIf(Me.TP.Text = "", 0, Me.TP.Text))
        Me.TMax.Text = IIf(Me.TMax.Text = 0, "", Me.TMax.Text)
    End Sub
    Private Sub TP_TextChanged(sender As Object, e As EventArgs) Handles TP.TextChanged
        Me.TMax.Text = Convert.ToDecimal(IIf(Me.TH.Text = "", 0, Me.TH.Text)) + Convert.ToDecimal(IIf(Me.TP.Text = "", 0, Me.TP.Text))
        Me.TMax.Text = IIf(Me.TMax.Text = 0, "", Me.TMax.Text)
    End Sub
End Class