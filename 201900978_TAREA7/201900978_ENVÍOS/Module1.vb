Imports System.Math
Module Module1
    Public lista As Byte = 0
    Public Nombre(10) As String
    Public Valor(10) As Double
    Public Peso(10) As Double
    Public Tpaquete(10) As String
    Public Tenvio(10) As String
    Public Impuesto(10) As Double
    Public Parcial(10) As Double
    Public Total(10) As Double
    Public Const Pdocumentos = 0.015
    Public Const Propa = 0.06
    Public Const Ppedecedero = 0.055
    Public Const Pplasticos = 0.045
    Public Const Ecamion = 50
    Public Const EMoto = 15
    Public Const Lociones = 0.02

    Sub Limpiar_Entradas()
        Form1.Textnombre.Clear()
        Form1.Textvalor.Clear()
        Form1.Combotipopaquete.SelectedIndex = -1
        Form1.Combotipoenvio.SelectedIndex = -1
        Form1.Textnombre.Focus()

    End Sub
    Sub Limpiar_Vectores()
        Dim x As Byte
        For x = 0 To 9
            Nombre(x) = Nothing
            Valor(x) = Nothing
            Peso(x) = Nothing
            Tpaquete(x) = Nothing
            Tenvio(x) = Nothing
            Impuesto(x) = Nothing
            Parcial(x) = Nothing
            Total(x) = Nothing
        Next (x)
        Form1.Listenvio.Items.Clear()
        Form1.Listimpuesto.Items.Clear()
        Form1.Listnombre.Items.Clear()
        Form1.Listpaquete.Items.Clear()
        Form1.Listparcial.Items.Clear()
        Form1.Listpeso.Items.Clear()
        Form1.Listtotal.Items.Clear()
        Form1.Listvalor.Items.Clear()
        Form1.Textlociones.Clear()
        Form1.Textplastico.Clear()
        Form1.Textdocumentos.Clear()
        Form1.Textropa.Clear()
    End Sub
    Sub Mostrar_Vectores()
        Dim Y As Byte = 0
        For Y = 0 To 9
            If Total(Y) <> Nothing Then
                Form1.Listnombre.Items.Add(Nombre(Y))
                Form1.Listvalor.Items.Add(Str(Round(Valor(Y), 2)))
                Form1.Listpeso.Items.Add(Str(Round(Peso(Y), 2)))
                Form1.Listpaquete.Items.Add(Tpaquete(Y))
                Form1.Listenvio.Items.Add(Tenvio(Y))
                Form1.Listimpuesto.Items.Add(Str(Round(Impuesto(Y), 2)))
                Form1.Listparcial.Items.Add(Str(Round(Parcial(Y), 2)))
                Form1.Listtotal.Items.Add(Str(Round(Total(Y), 2)))
            Else
                Exit For
            End If

        Next Y
    End Sub
End Module
