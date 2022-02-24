Imports System.Math
Module Module1
    Public CostaS As Double, Iza As Double, Peten As Double, AvioCosta As Double, AvioIza As Double, AvioPeten As Double
    Public JetCosta As Double, JetIza As Double, JetPeten As Double, HeliCosta As Double, HeliIza As Double, HeliPeten As Double
    Public subtotal As Double, Descuento_1 As Double, Descuento_2 As Double, TOTAL As Double
    Public Const AC = 150
    Public Const AI = 175.99
    Public Const AP = 250.99
    Public Const JC = 250.99
    Public Const JI = 325.99
    Public Const JP = 450.99
    Public Const HC = 125.99
    Public Const HI = 175.99
    Public Const HP = 275.99

    Function TOTALVUELOS() As Double
        TOTALVUELOS = subtotal - Descuento_1 - Descuento_2
        Return TOTALVUELOS
    End Function

    Sub LIMPIAR()
        Form1.Radioavioneta.Checked = 0
        Form1.Radiojet.Checked = 0
        Form1.Radiohelicoptero.Checked = 0
        Form1.Checkcosta.Checked = 0
        Form1.Checkizabal.Checked = 0
        Form1.Checkpeten.Checked = 0
        Form1.Textcosta.Clear()
        Form1.Textizabal.Clear()
        Form1.Textpeten.Clear()
        Form1.TextBoxAC.Clear()
        Form1.TextBoxAI.Clear()
        Form1.TextBoxAP.Clear()
        Form1.TextBoxDes1.Clear()
        Form1.TextBoxDes2.Clear()
        Form1.TextBoxHC.Clear()
        Form1.TextBoxHI.Clear()
        Form1.TextBoxHP.Clear()
        Form1.TextBoxJI.Clear()
        Form1.TextBoxJP.Clear()
        Form1.TextBoxJS.Clear()
        Form1.TextBoxSubT.Clear()
        Form1.Textboxtotal.Clear()


    End Sub

    Function caldescuento() As Double
        If (Form1.Checkpeten.Checked) And (Form1.Checkizabal.Checked) And (Form1.Radiojet.Checked) Then
            caldescuento = subtotal * 0.02
        ElseIf (Form1.Checkpeten.Checked) And (Form1.Checkizabal.Checked) And (Form1.Checkcosta.Checked) And (Form1.Radioavioneta.Checked) Then
            caldescuento = subtotal * 0.1
        Else
            caldescuento = 0
        End If
        Return caldescuento
    End Function

    Sub Resultado()
        Form1.Textcosta.Text = Str(Round(CostaS, 2))
        Form1.Textizabal.Text = Str(Round(Iza, 2))
        Form1.Textpeten.Text = Str(Round(Peten, 2))
        Form1.TextBoxAC.Text = Str(Round(AvioCosta, 2))
        Form1.TextBoxAI.Text = Str(Round(AvioIza, 2))
        Form1.TextBoxAP.Text = Str(Round(AvioPeten, 2))
        Form1.TextBoxHC.Text = Str(Round(HeliCosta, 2))
        Form1.TextBoxHI.Text = Str(Round(HeliIza, 2))
        Form1.TextBoxJS.Text = Str(Round(JetCosta, 2))
        Form1.TextBoxJI.Text = Str(Round(JetIza, 2))
        Form1.TextBoxJP.Text = Str(Round(JetPeten, 2))
        Form1.TextBoxDes1.Text = Str(Round(Descuento_1, 2))
        Form1.TextBoxDes2.Text = Str(Round(Descuento_2, 2))
        Form1.TextBoxSubT.Text = Str(Round(subtotal, 2))
        Form1.Textboxtotal.Text = Str(Round(TOTAL, 2))

    End Sub
End Module
