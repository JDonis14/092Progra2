Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click


        If (Cliente.Text = "") Then
            MsgBox("No ingreso al cliente, intete de nuevo")
            Cliente.Focus()
        End If

        If (Compra.Checked) Or (Venta.Checked) Then
            If (Compra.Checked) Then
                If (IsNumeric(QuetzalesC.Text) And Val(QuetzalesC.Text) > 0) Then
                    CompraQ = Val(QuetzalesC.Text)
                Else
                    MsgBox("Ingresó datos erroneo")
                    QuetzalesC.Focus()
                    Exit Sub

                End If
            Else
                CompraQ = 0
            End If
        End If
        If (Venta.Checked) Then
            If (IsNumeric(QuetzalesV.Text) Or (QuetzalesV.Text) > 0) Then
                VentaQ = Val(QuetzalesV.Text)
            Else
                MsgBox("Ingresó datos erroneos")
                QuetzalesV.Focus()
                Exit Sub
            End If
        Else
            VentaQ = 0

        End If

        If (Compra.Checked) Then
            If (Compra.Checked) And (DolarC.Checked) Then
                Dolar = CompraQ / PDolar
                ComC = Dolar * ComiC
                TotalCo = ComC + Dolar
            ElseIf (Compra.Checked) And (EurosC.Checked) Then
                Euro = CompraQ / PEuro
                ComC = Euro * ComiC
                TotalCo = Euro + ComC
            ElseIf (Compra.Checked) And (PesosC.Checked) Then
                Peso = CompraQ / PPesos
                ComC = Peso * ComiC
                TotalCo = Peso + ComiC
            ElseIf (Compra.Checked) And (ColonC.Checked) Then
                Colón = CompraQ / PColón
                ComC = Colón + ComiC
                TotalCo = Colón + ComiC
            Else
                MsgBox("ERROR, No selecciono ninguna moneda")
                Exit Sub
            End If
        End If

        If (Venta.Checked) Then

            If (Venta.Checked) And (DolarV.Checked) Then
                Dolar = VentaQ / PDolar
                ComV = Dolar * ComiV
                TotalVe = Dolar + ComV
            ElseIf (Venta.Checked) And (PesosV.Checked) Then
                Peso = VentaQ / PPesos
                ComV = Peso * ComiV
                TotalVe = Peso + ComV
            ElseIf (Venta.Checked) And (EuroV.Checked) Then
                Euro = VentaQ / PEuro
                ComV = Euro * ComiV
                TotalVe = Euro + ComV
            ElseIf (Venta.Checked) And (ColonV.Checked) Then
                Colón = VentaQ / PColón
                ComV = Colón * ComiV
                TotalVe = Colón + ComV
            Else MsgBox("ERROR, No selecciono ninguna moneda")
                Exit Sub
            End If
        End If
        TotalF = TotalCo + TotalVe
        Me.Hide()
        FormR.Show()

    End Sub

    Private Sub Compra_CheckedChanged(sender As Object, e As EventArgs) Handles Compra.CheckedChanged
        If (Compra.Checked) Then
            GrupoC.Visible = True
            QuetzalesC.Focus()
        Else
            GrupoC.Visible = False
        End If
    End Sub

    Private Sub Venta_CheckedChanged(sender As Object, e As EventArgs) Handles Venta.CheckedChanged
        If (Venta.Checked) Then
            GrupoV.Visible = True
            QuetzalesV.Focus()
        Else
            GrupoV.Visible = False


        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Limpiar_1()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        If (MsgBox("¿Quieres Salir?", vbQuestion + vbYesNo, "Saliendo") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class
