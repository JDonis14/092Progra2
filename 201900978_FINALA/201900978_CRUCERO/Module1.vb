Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public No_Nit(6) As Integer
    Public Nombre(6) As String
    Public NO_personas(6) As Integer
    Public Cabina(6) As String
    Public Clase(6) As String
    Public PrecioI(6) As Double
    Public PrecioT(6) As Double
    Public Const Sencilla1 = 400
    Public Const Sencilla2 = 375
    Public Const Doble1 = 700
    Public Const Doble2 = 600
    Public Const Compartida1 = 350
    Public Const Compartida2 = 300
    Public J As Byte

    Sub Limpiar_entradas()
        Form1.TextNIT.Clear()
        Form1.TextNOMBRE.Clear()
        Form1.TextPERSONAS.Clear()
        Form1.ComboCABINA.SelectedIndex = -1
        Form1.ComboCLASE.SelectedIndex = -1

        Form1.TextNIT.Focus()
    End Sub

    Sub Limpiar_Vectores()
        Form1.DataGridView1.Rows.Clear()
        Form1.TextNIT.Clear()
        Form1.TextNOMBRE.Clear()
        Form1.TextPERSONAS.Clear()
        Form1.TextCONSULTA.Clear()
        numero = 0
        For J = 0 To 5

            No_Nit(J) = Nothing
            Nombre(J) = Nothing
            NO_personas(J) = Nothing
            Cabina(J) = Nothing
            Clase(J) = Nothing
            PrecioI(J) = Nothing
            PrecioT(J) = Nothing
        Next J

    End Sub
    Sub mostrar()
        Form1.DataGridView1.Rows.Clear()
        For J = 0 To 5
            If (No_Nit(J) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(No_Nit(J)), Nombre(J), Str(NO_personas(J)), Cabina(J), Clase(J), Str(PrecioI(J)), Str(PrecioT(J)))
            Else
                Exit For

            End If
        Next J
    End Sub
End Module
