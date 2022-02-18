Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click

        If (CheckAlgodon.Checked) Or (CheckSeda.Checked) Or (CheckLona.Checked) Then
            If (CheckAlgodon.Checked) Then
                If (IsNumeric(TextAlgodon.Text) And (Val(TextAlgodon.Text) > 0)) Then
                    Calgodon = Val(TextAlgodon.Text)
                Else MsgBox("Ingresó datos erroneos")
                    TextAlgodon.Focus()
                    Exit Sub
                End If
            Else
                Calgodon = 0
            End If
        End If

        If (CheckSeda.Checked) Then
            If (IsNumeric(TextSeda.Text) And (Val(TextSeda.Text) > 0)) Then
                Cseda = Val(TextSeda.Text)
            Else MsgBox("Ingresó datos erroneos")
                TextSeda.Focus()
                Exit Sub
            End If
        Else
            Cseda = 0
        End If

        If (CheckLona.Checked) Then
            If (IsNumeric(TextLona.Text) And (Val(TextLona.Text) > 0)) Then
                Clona = Val(TextLona.Text)
            Else MsgBox("Ingresó datos erroneos")
                TextLona.Focus()
                Exit Sub
            End If
        Else
            Clona = 0
        End If

        If (RadSmall.Checked) Then
            If (RadSmall.Checked) And (CheckAlgodon.Checked) Then
                PrecioCalgodon = (YardaS * algodon * Calgodon) + (ManoS * Calgodon)
                PrecioValgodon = PrecioCalgodon + (PrecioCalgodon * 0.65)
            ElseIf (RadSmall.Checked) And (CheckSeda.Checked) Then
                PrecioCSeda = (YardaS * seda * Cseda) + (ManoS * Cseda)
                PrecioVseda = PrecioCSeda + (PrecioCSeda * 0.65)

            ElseIf (RadSmall.Checked) And (CheckLona.Checked) Then
                PrecioClona = (YardaS * Lona * Clona) + (ManoS * Clona)
                PrecioVlona = PrecioClona + (PrecioClona * 0.65)
            Else
            MsgBox("ERROR, No selecciono material")
            Exit Sub
        End If
        End If


        If (RadMedium.Checked) Then
            If (RadMedium.Checked) And (CheckAlgodon.Checked) Then
                PrecioCalgodon = (YardaM * algodon * Calgodon) + (ManoM * Calgodon)
                PrecioValgodon = PrecioCalgodon + (PrecioCalgodon * 0.65)

            ElseIf (RadMedium.Checked) And (CheckSeda.Checked) Then
                PrecioCSeda = (YardaM * seda * Cseda) + (ManoM * Cseda)
                PrecioVseda = PrecioCSeda + (PrecioCSeda * 0.65)
            ElseIf (RadMedium.Checked) And (CheckLona.Checked) Then
                PrecioClona = (YardaM * Lona * Clona) + (ManoM * Clona)
                PrecioVlona = PrecioClona + (PrecioClona * 0.65)
            Else
                MsgBox("ERROR, No selecciono material")
                Exit Sub
            End If
        End If

        If (RadLarge.Checked) Then

            If (RadLarge.Checked) And (CheckAlgodon.Checked) Then
                PrecioCalgodon = (YardaL * algodon * Calgodon) + (ManoL * Calgodon)
                PrecioValgodon = PrecioCalgodon + (PrecioCalgodon * 0.65)
            ElseIf (RadLarge.Checked) And (CheckSeda.Checked) Then
                PrecioCSeda = (YardaL * seda * Cseda) + (ManoL * Cseda)
                PrecioVseda = PrecioCSeda + (PrecioCSeda * 0.65)

            ElseIf (RadLarge.Checked) And (CheckLona.Checked) Then
                PrecioClona = (YardaL * Lona * Clona) + (ManoL * Clona)
                PrecioVlona = PrecioClona + (PrecioClona * 0.65)

            Else
                MsgBox("ERROR, No selecciono material")
                Exit Sub
            End If
        End If
        PrecioTotal = PrecioValgodon + PrecioVseda + PrecioVlona
        GroupCosto.Visible = True
        GroupVenta.Visible = True
        TextTOTAL.Visible = True
        LabelTOTAL.Visible = True
        Resultado()


    End Sub



    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()

    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If (MsgBox("¿Quieres Salir?", vbQuestion + vbYesNo, "Saliendo") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
