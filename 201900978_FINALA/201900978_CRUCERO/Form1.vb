Imports System.Math
Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Boton Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub


    Private Sub VECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VECTORESToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub DATOSENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSENTRADAToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If (numero <= 5) Then
            No_Nit(numero) = Val(TextNIT.Text)
            Nombre(numero) = TextNOMBRE.Text
            NO_personas(numero) = Val(TextPERSONAS.Text)
            Cabina(numero) = ComboCABINA.Text
            Clase(numero) = ComboCLASE.Text


            Select Case (ComboCABINA.SelectedIndex)
                Case 0
                    Cabina(numero) = "Sencilla"
                Case 1
                    Cabina(numero) = "Doble"
                Case 2
                    Cabina(numero) = "Compartida"
                Case Else
                    MsgBox("Error no selecciono ninguna cabina")

            End Select

            Select Case (ComboCLASE.SelectedIndex)
                Case 0
                    Clase(numero) = "Primera Clase"

                Case 1
                    Clase(numero) = "Segunda Clase"
                Case Else
                    MsgBox("Error no selecciono ninguna Clase")
            End Select

            If (Cabina(numero) = "Sencilla" And Clase(numero) = "Primera clase") Then
                PrecioI(numero) = Sencilla1
            ElseIf (Cabina(numero) = "Sencilla" And Clase(numero) = "Segunda clase") Then
                PrecioI(numero) = Sencilla2
            ElseIf (Cabina(numero) = "Doble" And Clase(numero) = "Primera clase") Then
                PrecioI(numero) = Doble1
            ElseIf (Cabina(numero) = "Doble" And Clase(numero) = "Segunda clase") Then
                PrecioI(numero) = Doble2
            ElseIf (Cabina(numero) = "Compartida" And Clase(numero) = "Primera clase") Then
                PrecioI(numero) = Compartida1
            ElseIf (Cabina(numero) = "Compartida" And Clase(numero) = "Segunda clase") Then
                PrecioI(numero) = Compartida2
            End If

            PrecioT(numero) = Round((PrecioI(numero) * NO_personas(numero)), 2)



            numero = numero + 1

        End If
        If (numero = 6) Then
            MsgBox("Vectores Llenos")
        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        J = 0
        While (J <= 5) And Not (existe)
            If (No_Nit(J) = Val(TextCONSULTA.Text)) Then
                existe = True
            Else
                J = J + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            TextNIT.Text = Str(No_Nit(J))
            TextNOMBRE.Text = (Nombre(J))
            TextPERSONAS.Text = Str(NO_personas(J))
            ComboCABINA.Text = Cabina(J)
            ComboCLASE.Text = Clase(J)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(No_Nit(J)), Nombre(J), Str(NO_personas(J)), Cabina(J), Clase(J), Str(PrecioI(J)), Str(PrecioT(J)))
            numero = J
        Else
            MsgBox("Nit no encontrada")
            TextCONSULTA.Focus()
        End If
    End Sub
End Class
