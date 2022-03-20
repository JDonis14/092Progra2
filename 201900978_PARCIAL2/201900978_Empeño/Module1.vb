Imports System.Math
Module Module1
    Public Empeño(6, 9) As String
    Public lista As Byte = 0
    Public Const CTV = 250
    Public Const CTelefono = 550
    Public Const Claptop = 770
    Public Const CRefrigeradora = 1000
    Public Const LTV = 300
    Public Const LTelefono = 600
    Public Const Llaptop = 800
    Public Const Lrefrigeradora = 1200
    Sub Limpiar_entradas()
        Form1.TextNOMBRE.Clear()
        Form1.TextDIRECCION.Clear()
        Form1.Textcosto.Clear()
        Form1.CheckTV.Checked = 0
        Form1.CheckTELEFONO.Checked = 0
        Form1.CheckREFRIGERADORA.Checked = 0
        Form1.CheckLAPTOP.Checked = 0
        Form1.ComboPLAZO.Text = ""
    End Sub

    Sub Limpiar_listbox()
        Form1.ListTOTAL.Items.Clear()
        Form1.ListnNOMBRE.Items.Clear()
        Form1.ListDIRECCION.Items.Clear()
        Form1.ListDESCUENTO.Items.Clear()
        Form1.ListCUI.Items.Clear()
        Form1.ListCOBRO.Items.Clear()
        Form1.ListAPARATO.Items.Clear()
        Form1.ListCOSTO.Items.Clear()
        Form1.ListPLAZO.Items.Clear()
    End Sub
    Sub Limpiar_matriz()
        lista = 0
        Form1.ListTOTAL.Items.Clear()
        Form1.ListnNOMBRE.Items.Clear()
        Form1.ListDIRECCION.Items.Clear()
        Form1.ListDESCUENTO.Items.Clear()
        Form1.ListCUI.Items.Clear()
        Form1.ListCOBRO.Items.Clear()
        Form1.ListAPARATO.Items.Clear()
        Form1.ListCOSTO.Items.Clear()
        Form1.ListPLAZO.Items.Clear()
    End Sub

    Sub MOSTRAR()
        Form1.ListnNOMBRE.Items.Add(Empeño(lista, 0))
        Form1.ListDIRECCION.Items.Add(Empeño(lista, 1))
        Form1.ListCUI.Items.Add(Empeño(lista, 2))
        Form1.ListAPARATO.Items.Add(Empeño(lista, 3))
        Form1.ListPLAZO.Items.Add(Empeño(lista, 4))
        Form1.ListCOSTO.Items.Add(Empeño(lista, 5))
        Form1.ListCOBRO.Items.Add(Empeño(lista, 6))
        Form1.ListDESCUENTO.Items.Add(Empeño(lista, 7))
        Form1.ListTOTAL.Items.Add(Empeño(lista, 8))




    End Sub
End Module
