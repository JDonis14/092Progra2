Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Groupdatos.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles Groupservicios.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Menubotones.ItemClicked

    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listhabitacion.SelectedIndexChanged

    End Sub

    Private Sub LimpiarDatosDeEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarDatosDeEntradaToolStripMenuItem.Click
        Limpiar_entradas()

    End Sub

    Private Sub LimpiarListboxvectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListboxvectoresToolStripMenuItem.Click
        Limpiar_vectores()
    End Sub

    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        If (MsgBox("¿QUIERE SALIR?", vbQuestion + vbYesNo, "SALIENDO") = vbYes) Then
            End
        Else
            Limpiar_entradas()
            Limpiar_vectores()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (lista <= 5) Then
            Paciente(lista) = TextNombre.Text
            NIT(lista) = Val(TextNit.Text)
            DHospitalizados(lista) = Val(TextDiashospitalizados.Text)
            Desc()
            Total(lista) = Total_todo()
            Resultados()
            lista = lista + 1
        End If

        If (lista = 6) Then
            MsgBox("Llego a su maximo")
        End If
    End Sub

    Private Sub CALCULOSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
