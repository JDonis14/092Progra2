Imports System.Math
Module Module1
    Public Nombre_Cliente As String, CompraQ As Double, VentaQ As Double, ComC As Double, ComV As Double, TotalF As Double
    Public Dolar As Double, Peso As Double, Euro As Double, Colón As Double, Quetzal As Double
    Public TotalCo As Double, TotalVe As Double
    Public Const PDolar = 7.69
    Public Const PPesos = 0.38
    Public Const PEuro = 8.79
    Public Const PColón = 0.012
    Public Const ComiC = 0.025
    Public Const ComiV = 0.03

    Sub Limpiar_1()
        Form1.Cliente.Clear()
        Form1.QuetzalesC.Clear()
        Form1.QuetzalesV.Clear()
        Form1.DolarC.Checked = 0
        Form1.PesosC.Checked = 0
        Form1.EurosC.Checked = 0
        Form1.ColonC.Checked = 0
        Form1.DolarV.Checked = 0
        Form1.PesosV.Checked = 0
        Form1.EuroV.Checked = 0
        Form1.ColonV.Checked = 0
        Form1.GrupoC.Visible = False
        Form1.GrupoV.Visible = False
        Form1.Compra.Checked = 0
        Form1.Venta.Checked = 0
        ComC = 0
        ComV = 0
        TotalCo = 0
        TotalVe = 0
        TotalF = 0
        Form1.Cliente.Focus()

    End Sub
    Sub Resultado_total()
        FormR.ComisiónC.Text = Str(Round(ComC, 2))
        FormR.ComisiónV.Text = Str(Round(ComV, 2))
        FormR.TotalCompra.Text = Str(Round(TotalCo, 2))
        FormR.TotalVenta.Text = Str(Round(TotalVe, 2))
        FormR.Total.Text = Str(Round(TotalF, 2))

    End Sub

    Sub Limpiar_2()
        ComC = 0
        ComV = 0
        TotalCo = 0
        TotalVe = 0
        TotalF = 0
    End Sub


End Module
