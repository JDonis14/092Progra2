Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Quiere Salir?", vbQuestion + vbYesNo, "Saliendo") = vbYes) Then
            End
        End If
    End Sub

    Private Sub LIMPIARDATOSDEENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARDATOSDEENTRADAToolStripMenuItem.Click
        LIMPIAR1()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        LIMPIAR2()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (lista <= 7) Then
            Datos_del_estudiante(lista, 0) = Val(Textcarnet.Text)
            Datos_del_estudiante(lista, 1) = Textnombre.Text
            Datos_del_estudiante(lista, 2) = Comboidioma.Text
            Datos_del_estudiante(lista, 3) = DateValue(Textfecha.Text)
            Datos_del_estudiante(lista, 5) = Val(InputBox("Por favor ingrese horas a cursar"))
            Select Case (Comboidioma.SelectedIndex)
                Case 0 : Datos_del_estudiante(lista, 7) = Str(I_ingles * Datos_del_estudiante(lista, 5))
                Case 1 : Datos_del_estudiante(lista, 7) = Str(I_portugues * Datos_del_estudiante(lista, 5))
                Case 2 : Datos_del_estudiante(lista, 7) = Str(I_frances * Datos_del_estudiante(lista, 5))
            End Select
            If (Radioefectivo.Checked) Then
                Datos_del_estudiante(lista, 6) = "EFECTIVO"
                Datos_del_estudiante(lista, 8) = Str((Datos_del_estudiante(lista, 7) * Defectivo1))
            ElseIf (Radiocheque.Checked) Then
                Datos_del_estudiante(lista, 6) = "CHEQUE"
                Datos_del_estudiante(lista, 8) = Str((Datos_del_estudiante(lista, 7) * Dcheque1))
            End If
            If (Checkviernes.Checked Or Checksabado.Checked) Then
                If (Checkviernes.Checked) Then
                    Datos_del_estudiante(lista, 4) = "VIERNES"
                    Datos_del_estudiante(lista, 9) = ""
                ElseIf (Checksabado.Checked) Then
                    Datos_del_estudiante(lista, 4) = "SABADO"
                    Datos_del_estudiante(lista, 9) = ""
                End If
            End If
            If (Checkviernes.Checked) And (Checksabado.Checked) Then
                Datos_del_estudiante(lista, 9) = Str((Datos_del_estudiante(lista, 7) * Ddias2))
                Datos_del_estudiante(lista, 4) = "LOS DOS DIAS"
            End If
        Else
            MsgBox("NO SELECCIONO NINGUN TIPO DE DIA")
        End If
        Datos_del_estudiante(lista, 10) = Str(Val(Datos_del_estudiante(lista, 7)) - (Val(Datos_del_estudiante(lista, 8)) + Val(Datos_del_estudiante(lista, 9))))
        MOSTRAR_R()
        lista = lista + 1
        If (lista = 8) Then
            MsgBox("YA NO SE ACEPTAN MAS DATOS")
        End If

    End Sub
End Class
