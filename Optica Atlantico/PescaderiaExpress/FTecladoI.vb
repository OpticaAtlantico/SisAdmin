Public Class FTecladoI

    Private Sub BMayus_Click(sender As Object, e As EventArgs) Handles BMayus.Click
        If (BMayus.ForeColor = Color.Navy) Then
            BMayus.ForeColor = Color.Lime
            BQ.Text = UCase(BQ.Text)
            BW.Text = UCase(BW.Text)
            BE.Text = UCase(BE.Text)
            BR.Text = UCase(BR.Text)
            BT.Text = UCase(BT.Text)
            BY.Text = UCase(BY.Text)
            BU.Text = UCase(BU.Text)
            BI.Text = UCase(BI.Text)
            BO.Text = UCase(BO.Text)
            BP.Text = UCase(BP.Text)
            BA.Text = UCase(BA.Text)
            BS.Text = UCase(BS.Text)
            BD.Text = UCase(BD.Text)
            BF.Text = UCase(BF.Text)
            BG.Text = UCase(BG.Text)
            BH.Text = UCase(BH.Text)
            BJ.Text = UCase(BJ.Text)
            BK.Text = UCase(BK.Text)
            BL.Text = UCase(BL.Text)
            Bñ.Text = UCase(Bñ.Text)
            BZ.Text = UCase(BZ.Text)
            BX.Text = UCase(BX.Text)
            BC.Text = UCase(BC.Text)
            BV.Text = UCase(BV.Text)
            BV.Text = UCase(BV.Text)
            BN.Text = UCase(BN.Text)
            BM.Text = UCase(BM.Text)
        Else
            BMayus.ForeColor = Color.Navy
            BQ.Text = LCase(BQ.Text)
            BW.Text = LCase(BW.Text)
            BE.Text = LCase(BE.Text)
            BR.Text = LCase(BR.Text)
            BT.Text = LCase(BT.Text)
            BY.Text = LCase(BY.Text)
            BU.Text = LCase(BU.Text)
            BI.Text = LCase(BI.Text)
            BO.Text = LCase(BO.Text)
            BP.Text = LCase(BP.Text)
            BA.Text = LCase(BA.Text)
            BS.Text = LCase(BS.Text)
            BD.Text = LCase(BD.Text)
            BF.Text = LCase(BF.Text)
            BG.Text = LCase(BG.Text)
            BH.Text = LCase(BH.Text)
            BJ.Text = LCase(BJ.Text)
            BK.Text = LCase(BK.Text)
            BL.Text = LCase(BL.Text)
            BÑ.Text = LCase(BÑ.Text)
            BZ.Text = LCase(BZ.Text)
            BX.Text = LCase(BX.Text)
            BC.Text = LCase(BC.Text)
            BV.Text = LCase(BV.Text)
            BV.Text = LCase(BV.Text)
            BN.Text = LCase(BN.Text)
            BM.Text = LCase(BM.Text)
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        TTexto.Text = ""
    End Sub

    Private Sub BComer_Click(sender As Object, e As EventArgs) Handles BComer.Click
        If (TTexto.Text <> "") Then
            TTexto.Text = Mid(TTexto.Text, 1, (Len(TTexto.Text) - 1))
        End If
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        TextoEscrito = TTexto.Text
        Me.Close()
    End Sub

    Private Sub BMenor_Click(sender As Object, e As EventArgs) Handles BMenor.Click
        TTexto.Text = TTexto.Text + "<"
    End Sub
    Private Sub BMayor_Click(sender As Object, e As EventArgs) Handles BMayor.Click
        TTexto.Text = TTexto.Text + ">"
    End Sub

    Private Sub BComillas_Click(sender As Object, e As EventArgs) Handles BComillas.Click
        TTexto.Text = TTexto.Text + Chr(34)
    End Sub

    Private Sub BNumeral_Click(sender As Object, e As EventArgs) Handles BNumeral.Click
        TTexto.Text = TTexto.Text + "#"
    End Sub

    Private Sub BDolar_Click(sender As Object, e As EventArgs) Handles BDolar.Click
        TTexto.Text = TTexto.Text + "$"
    End Sub

    Private Sub BPorcentaje_Click(sender As Object, e As EventArgs) Handles BPorcentaje.Click
        TTexto.Text = TTexto.Text + "%"
    End Sub

    Private Sub BSim_Click(sender As Object, e As EventArgs) Handles BSim.Click
        TTexto.Text = TTexto.Text + "&"
    End Sub

    Private Sub BParentA_Click(sender As Object, e As EventArgs) Handles BParentA.Click
        TTexto.Text = TTexto.Text + "("
    End Sub

    Private Sub BParentC_Click(sender As Object, e As EventArgs) Handles BParentC.Click
        TTexto.Text = TTexto.Text + ")"
    End Sub

    Private Sub BLlaveA_Click(sender As Object, e As EventArgs) Handles BLlaveA.Click
        TTexto.Text = TTexto.Text + "{"
    End Sub

    Private Sub BLlaveC_Click(sender As Object, e As EventArgs) Handles BLlaveC.Click
        TTexto.Text = TTexto.Text + "}"
    End Sub

    Private Sub BQ_Click(sender As Object, e As EventArgs) Handles BQ.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "q"
        Else
            TTexto.Text = TTexto.Text + "Q"
        End If
    End Sub

    Private Sub BW_Click(sender As Object, e As EventArgs) Handles BW.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "w"
        Else
            TTexto.Text = TTexto.Text + "W"
        End If
    End Sub

    Private Sub BE_Click(sender As Object, e As EventArgs) Handles BE.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "e"
        Else
            TTexto.Text = TTexto.Text + "E"
        End If
    End Sub

    Private Sub BR_Click(sender As Object, e As EventArgs) Handles BR.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "r"
        Else
            TTexto.Text = TTexto.Text + "R"
        End If
    End Sub

    Private Sub BT_Click(sender As Object, e As EventArgs) Handles BT.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "t"
        Else
            TTexto.Text = TTexto.Text + "T"
        End If
    End Sub

    Private Sub BY_Click(sender As Object, e As EventArgs) Handles BY.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "y"
        Else
            TTexto.Text = TTexto.Text + "Y"
        End If
    End Sub

    Private Sub BU_Click(sender As Object, e As EventArgs) Handles BU.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "u"
        Else
            TTexto.Text = TTexto.Text + "U"
        End If
    End Sub

    Private Sub BI_Click(sender As Object, e As EventArgs) Handles BI.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "i"
        Else
            TTexto.Text = TTexto.Text + "I"
        End If
    End Sub

    Private Sub BO_Click(sender As Object, e As EventArgs) Handles BO.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "o"
        Else
            TTexto.Text = TTexto.Text + "O"
        End If
    End Sub

    Private Sub BP_Click(sender As Object, e As EventArgs) Handles BP.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "p"
        Else
            TTexto.Text = TTexto.Text + "P"
        End If
    End Sub

    Private Sub BExclamacion_Click(sender As Object, e As EventArgs) Handles BExclamacion.Click
        TTexto.Text = TTexto.Text + "!"
    End Sub

    Private Sub BA_Click(sender As Object, e As EventArgs) Handles BA.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "a"
        Else
            TTexto.Text = TTexto.Text + "A"
        End If
    End Sub

    Private Sub BS_Click(sender As Object, e As EventArgs) Handles BS.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "s"
        Else
            TTexto.Text = TTexto.Text + "S"
        End If
    End Sub

    Private Sub BD_Click(sender As Object, e As EventArgs) Handles BD.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "d"
        Else
            TTexto.Text = TTexto.Text + "D"
        End If
    End Sub

    Private Sub BF_Click(sender As Object, e As EventArgs) Handles BF.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "f"
        Else
            TTexto.Text = TTexto.Text + "F"
        End If
    End Sub

    Private Sub BG_Click(sender As Object, e As EventArgs) Handles BG.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "g"
        Else
            TTexto.Text = TTexto.Text + "G"
        End If
    End Sub

    Private Sub BH_Click(sender As Object, e As EventArgs) Handles BH.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "h"
        Else
            TTexto.Text = TTexto.Text + "H"
        End If
    End Sub

    Private Sub BJ_Click(sender As Object, e As EventArgs) Handles BJ.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "j"
        Else
            TTexto.Text = TTexto.Text + "J"
        End If
    End Sub

    Private Sub BK_Click(sender As Object, e As EventArgs) Handles BK.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "k"
        Else
            TTexto.Text = TTexto.Text + "K"
        End If
    End Sub

    Private Sub BL_Click(sender As Object, e As EventArgs) Handles BL.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "l"
        Else
            TTexto.Text = TTexto.Text + "L"
        End If
    End Sub

    Private Sub BÑ_Click(sender As Object, e As EventArgs) Handles BÑ.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "ñ"
        Else
            TTexto.Text = TTexto.Text + "Ñ"
        End If
    End Sub

    Private Sub BInterrogante_Click(sender As Object, e As EventArgs) Handles BInterrogante.Click
        TTexto.Text = TTexto.Text + "?"
    End Sub

    Private Sub BZ_Click(sender As Object, e As EventArgs) Handles BZ.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "z"
        Else
            TTexto.Text = TTexto.Text + "Z"
        End If
    End Sub

    Private Sub BX_Click(sender As Object, e As EventArgs) Handles BX.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "x"
        Else
            TTexto.Text = TTexto.Text + "X"
        End If
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "c"
        Else
            TTexto.Text = TTexto.Text + "C"
        End If
    End Sub

    Private Sub BV_Click(sender As Object, e As EventArgs) Handles BV.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "v"
        Else
            TTexto.Text = TTexto.Text + "V"
        End If
    End Sub

    Private Sub BB_Click(sender As Object, e As EventArgs) Handles BV.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "b"
        Else
            TTexto.Text = TTexto.Text + "B"
        End If
    End Sub

    Private Sub BN_Click(sender As Object, e As EventArgs) Handles BN.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "n"
        Else
            TTexto.Text = TTexto.Text + "N"
        End If
    End Sub

    Private Sub BM_Click(sender As Object, e As EventArgs) Handles BM.Click
        If (BMayus.ForeColor = Color.Navy) Then
            TTexto.Text = TTexto.Text + "m"
        Else
            TTexto.Text = TTexto.Text + "M"
        End If
    End Sub

    Private Sub BPuntoComa_Click(sender As Object, e As EventArgs) Handles BPuntoComa.Click
        TTexto.Text = TTexto.Text + ";"
    End Sub

    Private Sub BComa_Click(sender As Object, e As EventArgs) Handles BComa.Click
        TTexto.Text = TTexto.Text + ","
    End Sub

    Private Sub BDosPuntos_Click(sender As Object, e As EventArgs) Handles BDosPuntos.Click
        TTexto.Text = TTexto.Text + ":"
    End Sub

    Private Sub BAcento_Click(sender As Object, e As EventArgs) Handles BAcento.Click
        TTexto.Text = TTexto.Text + "´"
    End Sub

    Private Sub BNum_Click(sender As Object, e As EventArgs) Handles BNum.Click
        TTexto.Text = TTexto.Text + "°"
    End Sub

    Private Sub BEspacio_Click(sender As Object, e As EventArgs) Handles BEspacio.Click
        TTexto.Text = TTexto.Text + " "
    End Sub

    Private Sub BArroba_Click(sender As Object, e As EventArgs) Handles BArroba.Click
        TTexto.Text = TTexto.Text + "@"
    End Sub

    Private Sub BPiso_Click(sender As Object, e As EventArgs) Handles BPiso.Click
        TTexto.Text = TTexto.Text + "_"
    End Sub

    Private Sub BDiv_Click(sender As Object, e As EventArgs) Handles BDiv.Click
        TTexto.Text = TTexto.Text + "/"
    End Sub

    Private Sub BMult_Click(sender As Object, e As EventArgs) Handles BMult.Click
        TTexto.Text = TTexto.Text + "*"
    End Sub

    Private Sub BSuma_Click(sender As Object, e As EventArgs) Handles BSuma.Click
        TTexto.Text = TTexto.Text + "+"
    End Sub

    Private Sub BResta_Click(sender As Object, e As EventArgs) Handles BResta.Click
        TTexto.Text = TTexto.Text + "-"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        TTexto.Text = TTexto.Text + "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        TTexto.Text = TTexto.Text + "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        TTexto.Text = TTexto.Text + "9"
    End Sub

    Private Sub BIgual_Click(sender As Object, e As EventArgs) Handles BIgual.Click
        TTexto.Text = TTexto.Text + "="
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        TTexto.Text = TTexto.Text + "4"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        TTexto.Text = TTexto.Text + "5"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        TTexto.Text = TTexto.Text + "6"
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        TTexto.Text = TTexto.Text + "1"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        TTexto.Text = TTexto.Text + "2"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        TTexto.Text = TTexto.Text + "3"
    End Sub

    Private Sub BPunto_Click(sender As Object, e As EventArgs) Handles BPunto.Click
        TTexto.Text = TTexto.Text + "."
    End Sub

    Private Sub BCero_Click(sender As Object, e As EventArgs) Handles BCero.Click
        TTexto.Text = TTexto.Text + "0"
    End Sub
End Class