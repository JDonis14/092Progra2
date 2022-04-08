Imports System.Math
Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listparcial.SelectedIndexChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Textlociones.TextChanged

    End Sub

    Private Sub MOSTRARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARESTADISTICASToolStripMenuItem.Click
        Dim J As Byte
        Dim Tlociones As Double = 0
        Dim Aplastico As Byte = 0
        Dim Tdocumentos As Byte = 0
        Dim Tropa As Byte = 0

        For J = 0 To 9
            If (Tpaquete(J) <> Nothing) Then
                If (Tpaquete(J) = "Lociones") Then
                    Tlociones = Tlociones + Valor(J)
                End If
                If (Tpaquete(J) = "Artículo de Plástico") Then
                    Aplastico = Aplastico + 1
                End If
                If (Tpaquete(J) = "Documentos") Then
                    Tdocumentos = Tdocumentos + Valor(J)

                End If
                If (Tpaquete(J) = "Ropa") Then
                    Tropa = Tropa + 1
                End If
            Else
                Exit For
            End If
        Next J
        Textlociones.Text = Str(Round(Tlociones, 2))
        Textplastico.Text = Str(Round(Aplastico, 2))
        Textdocumentos.Text = Str(Round(Tdocumentos, 2))
        Textropa.Text = Str(Round(Tropa, 2))

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_Entradas()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub MOSTRARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARVECTORESToolStripMenuItem.Click
        Mostrar_Vectores()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If (lista <= 9) Then
            Nombre(lista) = Textnombre.Text
            Valor(lista) = Val(Textvalor.Text)
            Peso(lista) = Val(InputBox("Ingrese el Peso"))
            Tpaquete(lista) = Combotipopaquete.Text
            Tenvio(lista) = Combotipoenvio.Text

            If (Peso(lista) > 0 And Peso(lista) <= 5) Then
                Select Case (Combotipopaquete.SelectedIndex)
                    Case 0
                        Impuesto(lista) = Peso(lista) * Pdocumentos
                    Case 1
                        Impuesto(lista) = Peso(lista) * Propa
                    Case 2
                        Impuesto(lista) = Peso(lista) * Ppedecedero
                    Case 3
                        Impuesto(lista) = Peso(lista) * Pplasticos
                    Case 4
                        Impuesto(lista) = Peso(lista) * Lociones
                End Select
            Else
                Impuesto(lista) = Peso(lista) * 0
            End If


            Parcial(lista) = Valor(lista) + Impuesto(lista)

            Select Case (Combotipoenvio.SelectedIndex)
                Case 0
                    Total(lista) = Ecamion + Parcial(lista)
                Case 1
                    Total(lista) = EMoto + Parcial(lista)
                Case -1
                    MsgBox("Debe seleccionar tipo de envio")
                    Exit Sub
            End Select


            lista = lista + 1
        End If
        If (lista = 10) Then
            MsgBox("Vectores Llenos")
        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿QUIERE SALIR?", vbQuestion + vbYesNo, "PRESIONO BOTON SALIR") = vbYes) Then
            End
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
