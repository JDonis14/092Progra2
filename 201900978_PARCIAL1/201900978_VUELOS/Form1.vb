Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Buttoncalcular_Click(sender As Object, e As EventArgs) Handles Buttoncalcular.Click
        If (Radioavioneta.Checked) Then

        ElseIf (Radiojet.Checked) Then

        ElseIf (Radiohelicoptero.Checked) Then

        Else
            MsgBox("no seleccionó ninguna tipo de aeronave")
            Exit Sub
        End If

        If (Checkcosta.Checked) Or (Checkizabal.Checked) Or (Checkpeten.Checked) Then
            If (Checkcosta.Checked) Then
                If (IsNumeric(Textcosta.Text) And (Val(Textcosta.Text) > 0)) Then
                    CostaS = Val(Textcosta.Text)
                Else MsgBox("Ingresó datos erroneos")
                    Textcosta.Focus()
                    Exit Sub
                End If
            Else
                CostaS = 0
            End If
        End If

        If (Checkizabal.Checked) Then
            If (IsNumeric(Textizabal.Text) And (Val(Textizabal.Text) > 0)) Then
                Iza = Val(Textizabal.Text)
            Else MsgBox("Ingresó datos erroneos")
                Textizabal.Focus()
                Exit Sub
            End If
        Else
            Iza = 0
        End If

        If (Checkpeten.Checked) Then
            If (IsNumeric(Textpeten.Text) And (Val(Textpeten.Text) > 0)) Then
                Peten = Val(Textpeten.Text)
            Else MsgBox("Ingresó datos erroneos")
                Textpeten.Focus()
                Exit Sub
            End If
        Else
            Peten = 0
        End If

        If (Radioavioneta.Checked) Then
            If (Radioavioneta.Checked) And (Checkcosta.Checked) Then
                AvioCosta = AC * CostaS
            ElseIf (Radioavioneta.Checked) And (Checkizabal.Checked) Then
                AvioIza = AI * Iza
            ElseIf (Radioavioneta.Checked) And (Checkpeten.Checked) Then
                AvioPeten = AP * Peten
            End If


        End If

        If (Radiojet.Checked) Then
            If (Radiojet.Checked) And (Checkcosta.Checked) Then
                JetCosta = JC * CostaS
            ElseIf (Radiojet.Checked) And (Checkizabal.Checked) Then
                JetIza = JI * Iza
            ElseIf (Radiojet.Checked) And (Checkpeten.Checked) Then
                JetPeten = JP * Peten
            End If


        End If

        If (Radiohelicoptero.Checked) Then
            If (Radiohelicoptero.Checked) And (Checkcosta.Checked) Then
                HeliCosta = HC * CostaS
            ElseIf (Radiohelicoptero.Checked) And (Checkizabal.Checked) Then
                HeliIza = HI * Iza
            ElseIf (Radiohelicoptero.Checked) And (Checkpeten.Checked) Then
                HeliPeten = HP * Peten
            End If

        End If

        subtotal = AvioCosta + AvioIza + AvioPeten + JetCosta + JetIza + JetPeten + HeliPeten + HeliCosta + HeliIza
        caldescuento()
        TOTALVUELOS()
        Resultado()

    End Sub

    Private Sub Buttonlimpiar_Click(sender As Object, e As EventArgs) Handles Buttonlimpiar.Click
        LIMPIAR()

    End Sub

    Private Sub Buttonsalir_Click(sender As Object, e As EventArgs) Handles Buttonsalir.Click
        If (MsgBox("¿Quieres Salir?", vbQuestion + vbYesNo, "Saliendo") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
