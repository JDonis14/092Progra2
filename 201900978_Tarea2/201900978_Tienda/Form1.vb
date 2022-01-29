Imports System.Math
Public Class Form1
    Dim Libras_de_Arroz As Integer, Libras_de_Frijol As Integer, Libras_de_Azúcar As Integer, Cliente As String, Pago_a_realizar As Double, IVA As Double, Pago_Parcial As Double, Descuento As Double, Pago_Total As Double
    Const ivaa = 12 / 100
    Const desc = 0.025
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()

        GroupBox2.Visible = False

        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GroupBox2.Visible = True


        Libras_de_Arroz = TextBox1.Text
        Libras_de_Frijol = TextBox2.Text
        Libras_de_Azúcar = TextBox3.Text
        Cliente = TextBox4.Text


        Pago_a_realizar = Round((Libras_de_Arroz * 2) + (Libras_de_Frijol * 1.75) + (Libras_de_Azúcar * 2.5), 2)
        IVA = Round((Pago_a_realizar * ivaa), 2)
        Pago_Parcial = Round((Pago_a_realizar + IVA), 2)
        Descuento = Round((Pago_Parcial * desc), 2)
        Pago_Total = Round((Pago_Parcial - Descuento), 2)

        TextBox5.Text = Str(Pago_a_realizar)
        TextBox6.Text = Str(IVA)
        TextBox7.Text = Str(Pago_Parcial)
        TextBox8.Text = Str(Descuento)
        TextBox9.Text = Str(Pago_Total)








    End Sub



End Class
