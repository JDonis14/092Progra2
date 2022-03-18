Imports System.Math
Module Module1
    Public indice As Byte = 0
    Public nombre(7) As String
    Public salario(7) As Double
    Public no_articulos(7) As Integer
    Public Tarticulo(7) As String
    Public Comision(7) As Double
    Public Bono(7) As Double
    Public sueldo_final(7) As Double
    Public P_a_vender(7) As Double
    Public Const Tablet = 375
    Public Const Drone = 560
    Public Const Celular = 1450
    Public Const Televisor = 3250

    Sub Limpiar_Vectores()
        Form1.ListNOMBRE.Items.Clear()
        Form1.ListSALARIO.Items.Clear()
        Form1.ListNO.Items.Clear()
        Form1.ListTIPO.Items.Clear()
        Form1.ListCOMISION.Items.Clear()
        Form1.ListBONO.Items.Clear()
        Form1.ListSUELDO.Items.Clear()
        Form1.TextEMPLEADO.Focus()
    End Sub
    Sub limpiar_entradas()
        Form1.TextEMPLEADO.Clear()
        Form1.TextNO.Clear()
        Form1.TextSALARIO.Clear()
        Form1.RadioTABLET.Checked = 0
        Form1.RadioCELULAR.Checked = 0
        Form1.RadioTELEVISOR.Checked = 0
        Form1.RadioDRONE.Checked = 0
        Form1.TextEMPLEADO.Focus()
    End Sub

    Sub Resultados()
        Form1.ListNOMBRE.Items.Add(nombre(indice))
        Form1.ListSALARIO.Items.Add(Str(salario(indice)))
        Form1.ListNO.Items.Add(Str(no_articulos(indice)))
        Form1.ListTIPO.Items.Add((Tarticulo(indice)))
        Form1.ListCOMISION.Items.Add(Str(Comision(indice)))
        Form1.ListBONO.Items.Add(Str(Bono(indice)))
        Form1.ListSUELDO.Items.Add(Str(sueldo_final(indice)))


    End Sub
End Module
