Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then
            If (RadioButton1.Checked) And (RadioButton5.Checked) Then
                SeguroV = Sueldo * SeguroVe

            ElseIf (RadioButton1.Checked) And (RadioButton6.Checked) Then
                SeguroA = Sueldo * SeguroA
                Total_Final = SeguroA + Norte
            End If
        End If

        If (RadioButton2.Checked) Then
            If (RadioButton2.Checked) And (RadioButton5.Checked) Then
                SeguroV = Sueldo * SeguroVe
                Total_Final = SeguroV + Sur
            ElseIf (RadioButton2.Checked) And (RadioButton6.Checked) Then
                SeguroA = Sueldo * SeguroA
                Total_Final = SeguroV + Sur
            End If
        End If

        If (RadioButton3.Checked) Then
            If (RadioButton2.Checked) And (RadioButton5.Checked) Then
                SeguroV = Sueldo * SeguroVe
                Total_Final = SeguroV + Oriente
            ElseIf (RadioButton3.Checked) And (RadioButton6.Checked) Then
                SeguroA = Sueldo * SeguroA
                Total_Final = SeguroV + Oriente
            End If
        End If

        If (RadioButton4.Checked) Then
            If (RadioButton2.Checked) And (RadioButton5.Checked) Then
                SeguroV = Sueldo * SeguroVe
                Total_Final = SeguroV + Occidente
            ElseIf (RadioButton4.Checked) And (RadioButton6.Checked) Then
                SeguroA = Sueldo * SeguroA
                Total_Final = SeguroV + Occidente
            End If
        End If
        Total_Final = SeguroV + Norte
        Resultado()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿Quieres Salir?", vbQuestion + vbYesNo, "Saliendo") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
