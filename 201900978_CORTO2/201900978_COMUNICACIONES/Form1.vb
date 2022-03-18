Imports System.Math
Public Class Form1
    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        nombre(indice) = TextEMPLEADO.Text
        salario(indice) = Val(TextSALARIO.Text)
        no_articulos(indice) = Val(TextNO.Text)
        Comision(indice) = Round((salario(indice) * 0.055), 2)
        If (RadioTABLET.Checked) Then
            Tarticulo(indice) = "Tablet"
            P_a_vender(indice) = Round((Tablet) * no_articulos(indice), 2)
        ElseIf (RadioDRONE.Checked) Then
            Tarticulo(indice) = "Drone"
            P_a_vender(indice) = Round((Drone) * no_articulos(indice), 2)
        ElseIf (RadioCELULAR.Checked) Then
            Tarticulo(indice) = "Celular"
            P_a_vender(indice) = Round((Celular) * no_articulos(indice), 2)
        ElseIf (RadioTELEVISOR.Checked) Then
            Tarticulo(indice) = "Televisor"
            P_a_vender(indice) = Round((Televisor) * no_articulos(indice), 2)
        End If
        If (salario(indice) > 1 And salario(indice) <= 2000) Then
            Bono(indice) = Round((salario(indice) * 0.03), 2)
        ElseIf (salario(indice) > 2001 And salario(indice) <= 5000) Then
            Bono(indice) = Round((salario(indice) * 0.04), 2)
        ElseIf (salario(indice) > 5001) Then
            Bono(indice) = Round((salario(indice) * 0.05), 2)
        End If
        sueldo_final(indice) = Round((salario(indice) + Bono(indice) + Comision(indice)), 2)
        Resultados()
        indice = indice + 1
        If (indice = 7) Then
            MsgBox("List BOX  LLENA")
        End If
    End Sub


    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_Vectores()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿QUIERE SALIR?", vbQuestion + vbYesNo, "PRESIONO BOTON SALIR") = vbYes) Then
            End
        End If
    End Sub
End Class
