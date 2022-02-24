Imports System.Math
Module Module1
    Public Nombre_Mensajero As String, Total_Final As Double, SeguroV As Double, SeguroA As Double
    Public Const Norte = 150
    Public Const Sur = 200
    Public Const Oriente = 175
    Public Const Occidente = 225
    Public Const SeguroVe = 0.03
    Public Const SeguroAc = 0.05
    Public Const Sueldo = 3800

    Sub Limpiar()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.RadioButton5.Checked = 0
        Form1.RadioButton6.Checked = 0
        Form1.GroupBox4.Visible = False
        Form1.TextBox1.Focus()


    End Sub
    Sub Resultado()
        Form1.TextBox2.Text = Str(Round(SeguroV, 2))
        Form1.TextBox3.Text = Str(Round(SeguroA, 2))
        Form1.TextBox4.Text = Str(Round(Total_Final, 2))
    End Sub

End Module
