Imports System.Math

Module Module1
    Public Calgodon As Double, Cseda As Double, Clona As Double, PrecioCalgodon As Double, PrecioCSeda As Double, PrecioClona As Double
    Public PrecioValgodon As Double, PrecioVseda As Double, PrecioVlona As Double, PrecioTotal As Double
    Public Const ManoS = 65.5
    Public Const ManoM = 85.99
    Public Const ManoL = 99.99
    Public Const algodon = 15
    Public Const seda = 23.99
    Public Const Lona = 30.99
    Public Const YardaS = 2
    Public Const YardaM = 2.5
    Public Const YardaL = 3

    Sub Limpiar()
        Form1.RadSmall.Checked = 0
        Form1.RadMedium.Checked = 0
        Form1.RadLarge.Checked = 0
        Form1.CheckAlgodon.Checked = False
        Form1.CheckSeda.Checked = False
        Form1.CheckLona.Checked = False
        Form1.TextAlgodon.Clear()
        Form1.TextSeda.Clear()
        Form1.TextLona.Clear()
        Form1.TextalgodonC.Clear()
        Form1.TextSedaC.Clear()
        Form1.TextLonaC.Clear()
        Form1.TextalgodonV.Clear()
        Form1.TextSedaV.Clear()
        Form1.TextLonaV.Clear()
        Form1.TextTOTAL.Clear()
        Form1.GroupCosto.Visible = False
        Form1.GroupVenta.Visible = False
        Form1.TextTOTAL.Visible = False
        Form1.LabelTOTAL.Visible = False
        PrecioCalgodon = 0
        PrecioCSeda = 0
        PrecioClona = 0
        PrecioValgodon = 0
        PrecioVseda = 0
        PrecioClona = 0
        PrecioTotal = 0



    End Sub

    Sub Resultado()
        Form1.TextalgodonC.Text = Str(Round(PrecioCalgodon, 2))
        Form1.TextLonaC.Text = Str(Round(PrecioClona, 2))
        Form1.TextSedaC.Text = Str(Round(PrecioCSeda, 2))
        Form1.TextalgodonV.Text = Str(Round(PrecioValgodon, 2))
        Form1.TextSedaV.Text = Str(Round(PrecioVseda, 2))
        Form1.TextLonaV.Text = Str(Round(PrecioVlona, 2))
        Form1.TextTOTAL.Text = Str(Round(PrecioTotal, 2))
    End Sub


End Module
