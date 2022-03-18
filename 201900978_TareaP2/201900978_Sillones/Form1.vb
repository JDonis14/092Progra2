Imports System.Math
Public Class Form1
    Private Sub LIMPIARGRIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARGRIDToolStripMenuItem.Click
        DataCliente.Rows.Clear()
        TextNo.Focus()

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (Indice < 8) Then
            Numero_Ventas(Indice) = Val(TextNo.Text)
            Cantidad(Indice) = Val(TextCantidad.Text)
        End If
        If (RadioSofa.Checked) Or (RadioIndividual.Checked) Or (RadioDoble.Checked) Then
            Tipo_Sillon()
        Else
            MsgBox("Seleccioné un tipo de sillón")
            Exit Sub
        End If


        Select Case (ComboTipotela.SelectedIndex)
            Case 0 : Ttela(Indice) = "CUERO"
                Material(Indice) = Round((Y(Indice) * Mcuero), 2)
            Case 1 : Ttela(Indice) = "CUERINA"
                Material(Indice) = Round((Y(Indice) * Mcuerina), 2)
            Case Else
                MsgBox("Seleccione un tipo de material ")
                Exit Sub
        End Select
        PCosto(Indice) = Round(MO(Indice) + (Material(Indice) * Cantidad(Indice)), 2)
        PVenta(Indice) = Round((PCosto(Indice) * 0.65) + PCosto(Indice), 2)
        RESULTADOS()
        Indice = Indice + 1
        If (Indice = 8) Then
            MsgBox("Ya no se pueden agregar mas datos, vectores llenos")

        End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem1.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub
End Class
