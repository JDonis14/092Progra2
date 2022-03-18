Imports System.Math
Module Module1
    Public Indice As Byte = 0
    Public Numero_Ventas(8) As Integer
    Public Cantidad(8) As Integer
    Public Tsillon(8) As String
    Public Ttela(8) As String
    Public PCosto(8) As Double
    Public PVenta(8) As Double
    Public MO(8) As Double
    Public Material(8) As Double
    Public Y(8) As Double
    Public Const MOsofa = 250.99
    Public Const MOindividual = 150.99
    Public Const MOdoble = 200.99
    Public Const Ysofa = 8
    Public Const Yindividual = 3.5
    Public Const Ydoble = 6
    Public Const Mcuero = 75
    Public Const Mcuerina = 45.99

    Sub Tipo_Sillon()
        If (Form1.RadioSofa.Checked) Then
            Tsillon(Indice) = "Sofa"
            Y(Indice) = Ysofa
            MO(Indice) = Round((Cantidad(Indice) * MOsofa), 2)
        ElseIf (Form1.Radioindividual.Checked) Then
            Tsillon(Indice) = "Individual"
            Y(Indice) = Yindividual
            MO(Indice) = Round((Cantidad(Indice) * MOindividual), 2)
        ElseIf (Form1.RadioDoble.Checked) Then
            Tsillon(Indice) = "Doble"
            Y(Indice) = Ydoble
            MO(Indice) = Round((Cantidad(Indice) * MOdoble), 2)

        End If
    End Sub
    Sub Salir()
        If (MsgBox("¿QUIERE SALIR?", vbQuestion + vbYesNo, "PRESIONO BOTON SALIR") = vbYes) Then
            End
        End If
    End Sub
    Sub RESULTADOS()
        Form1.DataCliente.Rows.Add(Str(Numero_Ventas(Indice)), Str(Cantidad(Indice)), Tsillon(Indice), Ttela(Indice), Str(PCosto(Indice)), Str(PVenta(Indice)))
    End Sub
    Sub LIMPIAR_VECTORES()
        Dim j As Byte
        For j = 0 To 7
            Numero_Ventas(j) = Nothing
            Cantidad(j) = Nothing
            Tsillon(j) = Nothing
            Ttela(j) = Nothing
            PCosto(j) = Nothing
            PVenta(j) = Nothing
        Next j
        Indice = 0
    End Sub
    Sub Limpiar_entradas()
        Form1.TextNo.Clear()
        Form1.TextCantidad.Clear()
        Form1.RadioSofa.Checked = 0
        Form1.RadioIndividual.Checked = 0
        Form1.RadioDoble.Checked = 0
        Form1.ComboTipotela.SelectedIndex = -1
    End Sub
End Module
