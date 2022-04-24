Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Vectores_Limpiar()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (viaje <= 6) Then
            Id(viaje) = Val(Textidentifiacion.Text)
            No_dias(viaje) = Val(Textdias.Text)
            No_personas(viaje) = Val(Textpersonas.Text)
            Tviaje(viaje) = Tipo_Viaje()
            Total(viaje) = Round(Tviaje(viaje) * No_dias(viaje) * No_personas(viaje), 2)
            viaje = viaje + 1
            Textidentifiacion.Clear()
            Textdias.Clear()
            Textpersonas.Clear()
            Comboviaje.Text = ""
        End If

        If (viaje = 7) Then
            MsgBox("Espacio Lleno")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For J = 0 To 6
            If (Id(J) <> Nothing) Then
                DataGridView1.Rows.Add(Str(Id(J)), Str(No_dias(J)), Str(No_personas(J)), Tviaje(J), Str(Total(J)))
            Else
                Exit For
            End If
        Next J
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        Dim existe As Boolean = False
        J = 0
        While (J <= 6) And Not (existe)
            If (Id(J) = Val(TextNo.Text)) Then
                existe = True
            Else
                J = J + 1
            End If
        End While
        If (existe) Then
            MsgBox("La Identificación se encontró exitosamente")
            Textidentifiacion.Text = Str(Id(J))
            Textdias.Text = Str(No_dias(J))
            Textpersonas.Text = Str(No_personas(J))
            Comboviaje.Text = Tviaje(J)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(Id(J)), Str(No_dias(J)), Str(No_personas(J)), Tviaje(J), Str(Total(J)))
            viaje = J
        Else
            MsgBox("Identificación no encontrada")
            TextNo.Focus()
        End If

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Id(viaje) = Nothing
        No_dias(viaje) = Nothing
        No_personas(viaje) = Nothing
        Tviaje(viaje) = Nothing
        Total(viaje) = Nothing

        For J = viaje To 5
            Id(viaje) = Id(J + 1)
            No_dias(viaje) = No_dias(J + 1)
            No_personas(viaje) = No_personas(J + 1)
            Tviaje(viaje) = Tviaje(J + 1)
            Total(viaje) = Total(J + 1)
        Next J
        MsgBox("Se Elimino Registro Exitosamente")
        Id(J) = Nothing
        No_dias(J) = Nothing
        No_personas(J) = Nothing
        Tviaje(J) = Nothing
        Total(J) = Nothing
        viaje = J
        Textidentifiacion.Clear()
        Textdias.Clear()
        Textpersonas.Clear()
        Comboviaje.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Presiono Salir") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
