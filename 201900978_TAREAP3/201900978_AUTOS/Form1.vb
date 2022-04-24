Imports System.Math
Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (renta <= 6) Then
            no_placa(renta) = Val(Textplaca.Text)
            KilometroI(renta) = Val(TextKI.Text)
            KilometroF(renta) = Val(TextKF.Text)
            Kilometraje(renta) = KilometroF(renta) - KilometroI(renta)
            base(renta) = Cobro_Base()

            If (Kilometraje(renta) > 0 And Kilometraje(renta) <= 50) Then
                cobro(renta) = Str(Round((Kilometraje(renta) * 3), 2))
            ElseIf (Kilometraje(renta) > 50 And Kilometraje(renta) <= 70) Then
                cobro(renta) = Str(Round((Kilometraje(renta) * 4), 2))
            ElseIf (Kilometraje(renta) > 70) Then
                cobro(renta) = Str(Round((Kilometraje(renta) * 5), 2))
            Else
                MsgBox("Ingreso mal el kilometraje")
                TextKI.Focus()
            End If
            Total(renta) = Round(cobro(renta) + base(renta), 2)
            renta = renta + 1

        End If

        If (renta = 7) Then
            MsgBox("Espacio Lleno")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextNo.TextChanged

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Vectores_Limpiar()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For J = 0 To 6
            If (no_placa(J) <> Nothing) Then
                DataGridView1.Rows.Add(Str(no_placa(J)), Tauto(J), Str(base(J)), Str(KilometroI(J)), Str(KilometroF(J)), Str(Total(J)))
            Else
                Exit For
            End If
        Next J

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        J = 0
        While (J <= 6) And Not (existe)
            If (no_placa(J) = Val(TextNo.Text)) Then
                existe = True
            Else
                J = J + 1
            End If
        End While
        If (existe) Then
            MsgBox("La Placa Se Encontró exitosamente")
            Textplaca.Text = Str(no_placa(J))
            TextKI.Text = Str(KilometroI(J))
            TextKF.Text = Str(KilometroF(J))
            Comboauto.Text = Tauto(J)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(no_placa(J)), Tauto(J), Str(base(J)), Str(KilometroI(J)), Str(KilometroF(J)), Str(Total(J)))
            renta = J
        Else
            MsgBox("Placa no encontrada")
            TextNo.Focus()
        End If



    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        no_placa(renta) = Val(Textplaca.Text)
        KilometroI(renta) = Val(TextKI.Text)
        KilometroF(renta) = Val(TextKF.Text)
        Kilometraje(renta) = KilometroF(renta) - KilometroI(renta)
        base(renta) = Cobro_Base()

        If (Kilometraje(renta) > 0 And Kilometraje(renta) <= 50) Then
            cobro(renta) = Str(Round((Kilometraje(renta) * 3), 2))
        ElseIf (Kilometraje(renta) > 50 And Kilometraje(renta) <= 70) Then
            cobro(renta) = Str(Round((Kilometraje(renta) * 4), 2))
        ElseIf (Kilometraje(renta) > 70) Then
            cobro(renta) = Str(Round((Kilometraje(renta) * 5), 2))
        Else
            MsgBox("Ingreso mal el kilometraje")
            TextKI.Focus()
        End If
        Total(renta) = Round(cobro(renta) + base(renta), 2)
        MsgBox("Registro actualizado correctamente en los vectores")
        renta = 7
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        no_placa(renta) = Nothing
        KilometroI(renta) = Nothing
        KilometroF(renta) = Nothing
        Tauto(renta) = Nothing
        base(renta) = Nothing
        cobro(renta) = Nothing
        Total(renta) = Nothing
        Kilometraje(renta) = Nothing
        For J = renta To 5
            no_placa(J) = no_placa(J + 1)
            KilometroI(J) = KilometroI(J + 1)
            KilometroF(J) = KilometroF(J + 1)
            Tauto(J) = Tauto(J + 1)
            base(J) = base(J + 1)
            cobro(J) = cobro(J + 1)
            Total(J) = Total(J + 1)
            Kilometraje(J) = Kilometraje(J + 1)
        Next J
        MsgBox("Se Elimino Registro Exitosamente")
        no_placa(J) = Nothing
        KilometroI(J) = Nothing
        KilometroF(J) = Nothing
        Tauto(J) = Nothing
        base(J) = Nothing
        cobro(J) = Nothing
        Total(J) = Nothing
        Kilometraje(J) = Nothing
        renta = J
        Textplaca.Clear()
        TextKI.Clear()
        TextKF.Clear()
        Comboauto.SelectedIndex = -1
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Presiono Salir") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
