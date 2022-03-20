Imports System.Math
Public Class Form1
    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (lista < 6) Then
            Empeño(lista, 0) = TextNOMBRE.Text
            Empeño(lista, 1) = Val(TextDIRECCION.Text)
            Empeño(lista, 2) = Val(InputBox("Ingrese su numero de CUI"))
            Empeño(lista, 5) = Val(Textcosto.Text)
            If (CheckTV.Checked) Then
                Empeño(lista, 3) = "TV"
            ElseIf (CheckTELEFONO.Checked) Then
                Empeño(lista, 3) = "TELEFONO"
            ElseIf (CheckLAPTOP.Checked) Then
                Empeño(lista, 3) = "LAPTOP"
            ElseIf (CheckREFRIGERADORA.Checked) Then
                Empeño(lista, 3) = "REFRIGERADORA"
            End If
            Select Case (ComboPLAZO.SelectedIndex)
                Case 0 : Empeño(lista, 4) = "CORTO"
                    Empeño(lista, 6) = Str((Empeño(lista, 5) + CTV))
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + CTelefono)
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + Claptop)
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + CRefrigeradora)
                    If (CheckTV.Checked) And (CheckREFRIGERADORA.Checked) Then
                        Empeño(lista, 7) = Str(Empeño(lista, 6) * 0.15)
                    End If
                    If (CheckTELEFONO.Checked) And (CheckLAPTOP.Checked) Then
                        Empeño(lista, 7) = Str(Empeño(lista, 6) * 0.05)
                    End If
                Case 1 : Empeño(lista, 4) = "LARGO"
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + LTV)
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + LTelefono)
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + Llaptop)
                    Empeño(lista, 6) = Str(Empeño(lista, 5) + Lrefrigeradora)
                    If (CheckTV.Checked) And (CheckREFRIGERADORA.Checked) Then
                        Empeño(lista, 7) = Str(Empeño(lista, 6) * 0.05)
                    End If
                    If (CheckTELEFONO.Checked) And (CheckLAPTOP.Checked) Then
                        Empeño(lista, 7) = Str(Empeño(lista, 6) * 0.1)
                    End If
            End Select
        End If
        Empeño(lista, 8) = Str(Val(Empeño(lista, 6))) - Str(Val(Empeño(lista, 7)))
        MOSTRAR()
        lista = lista + 1
        If (lista = 6) Then
            MsgBox("YA NO SE ACEPTAN MAS DATOS")
        End If

    End Sub

    Private Sub LIMPIARENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADAToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub LIMPIARLISTBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARLISTBOXToolStripMenuItem.Click
        Limpiar_listbox()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Limpiar_matriz()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Quiere Salir?", vbQuestion + vbYesNo, "PRESIONE EL BOTON DE SALIR") = vbYes) Then
            End
        End If
    End Sub
End Class
