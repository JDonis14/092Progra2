Imports System.Math
Public Class Form1
    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        Limpiar_vectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_Entradas()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        For J = 0 To 11
            If (No_etapa(J) <> Nothing) Then
                DataGridView1.Rows.Add(Str(No_etapa(J)), Equipo(J), Str(Recorrido(J)), Nacionalidad(J), Str(Tiempo(J)), Str(Total(J)))
            Else
                Exit For

            End If
        Next J
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Quieres salir?", vbQuestion + vbYesNo, "Presiono Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (Ciclista <= 11) Then
            Nacionalidad(Ciclista) = Combonacionalidad.Text
            Equipo(Ciclista) = Comboequipo.Text
            No_etapa(Ciclista) = Val(Textetapa.Text)
            Recorrido(Ciclista) = Val(Textrecorrido.Text)
            Tiempo(Ciclista) = Val(Texttiempo.Text)

            Tiempo_agregado()

            Ciclista = Ciclista + 1

        End If
        If (Ciclista = 12) Then
            MsgBox("Vectores Llenos")
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        Nacionalidad(Ciclista) = Combonacionalidad.Text
        Equipo(Ciclista) = Comboequipo.Text
        No_etapa(Ciclista) = Val(Textetapa.Text)
        Recorrido(Ciclista) = Val(Textrecorrido.Text)
        Tiempo(Ciclista) = Val(Texttiempo.Text)

        Tiempo_agregado()
        MsgBox("El registro se actualizo")
        Ciclista = J

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        J = 0
        While (J <= 11) And Not (existe)
            If (No_etapa(J) = Val(Textno.Text)) Then
                existe = True
            Else
                J = J + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado ")
            Textetapa.Text = Str(No_etapa(J))
            Textrecorrido.Text = Str(Recorrido(J))
            Texttiempo.Text = Str(Tiempo(J))
            Comboequipo.Text = Equipo(J)
            Combonacionalidad.Text = Nacionalidad(J)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(No_etapa(J)), Equipo(J), Str(Recorrido(J)), Nacionalidad(J), Str(Tiempo(J)), Str(Total(J)))
            Ciclista = J
        Else
            MsgBox("No encontrada la etapa")
            Textno.Focus()
        End If

    End Sub

    Private Sub ORDENARASCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARASCENDENTEToolStripMenuItem.Click
        Dim a As Byte
        Dim b As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As Integer
        Dim temp6 As Integer
        Dim temp7 As Integer
        For a = 0 To 10
            For b = a + 1 To 11
                If (No_etapa(b) <> Nothing) Then
                    If (No_etapa(a) > No_etapa(b)) Then
                        temp1 = No_etapa(a)
                        No_etapa(a) = No_etapa(b)
                        No_etapa(b) = temp1
                        temp2 = Equipo(a)
                        Equipo(a) = Equipo(b)
                        Equipo(b) = temp2
                        temp3 = Recorrido(a)
                        Recorrido(a) = Recorrido(b)
                        Recorrido(b) = temp3
                        temp4 = Nacionalidad(a)
                        Nacionalidad(a) = Nacionalidad(b)
                        Nacionalidad(b) = temp4
                        temp5 = Tiempo(a)
                        Tiempo(a) = Tiempo(b)
                        Tiempo(b) = temp5
                        temp6 = Penalizacion(a)
                        Penalizacion(a) = Penalizacion(b)
                        Penalizacion(b) = temp6
                        temp7 = Total(a)
                        Total(a) = Total(b)
                        Total(b) = temp7
                    End If
                End If
            Next b
        Next a
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click
        Dim i As Byte
        Dim estadis As Byte = 0
        Dim km1 As Double = 0
        Dim km2 As Double = 0
        Dim km3 As Double = 0
        Dim km4 As Double = 0
        Dim total1 As Integer = 0
        Dim total2 As Integer = 0
        For j = 0 To 11
            If (Recorrido(i) <> Nothing) Then
                If (Recorrido(i) > 45 And Nacionalidad(i) = "Nacional") Then
                    estadis = estadis + 1
                End If
                If (Equipo(i) = "Sky") Then
                    km1 = km1 + Recorrido(i)
                End If
                If (Equipo(i) = "Movistar") Then
                    km2 = km2 + Recorrido(i)
                End If
                If (Equipo(i) = "Pro Cycling") Then
                    km3 = km3 + Recorrido(i)
                End If
                If (Equipo(i) = "Pro Team") Then
                    km4 = km4 + Recorrido(i)
                End If
                If (Nacionalidad(J) = "Nacional") Then
                    total1 = total1 + Total(i)
                End If
                If (Nacionalidad(i) = "Extranjero") Then
                    total2 = total2 + Total(i)
                End If
            Else
                Exit For
            End If
        Next i
        If (total1 > 60) Then
            Dim hora As Integer = 60
            Dim conversion_hora As Integer
            Dim conversion_min As Integer
            conversion_hora = total1 / hora
            conversion_min = total1 - conversion_hora * hora
            Textnacional.Text = conversion_hora.ToString + " horas " + conversion_min.ToString + " min."
        Else
            Textnacional.Text = Str(total1) + " min."
        End If
        If (total2 > 60) Then
            Dim hora As Integer = 60
            Dim conversion_hora As Integer
            Dim conversion_min As Integer
            conversion_hora = total2 / hora
            conversion_min = total2 - conversion_hora * hora
            Textextranjero.Text = conversion_hora.ToString + " horas " + conversion_min.ToString + " min."
        Else
            Textextranjero.Text = Str(total2) + " min."
        End If
        Text45.Text = Str(estadis)
        Textsky.Text = Str(Round(km1, 2))
        Textmovistar.Text = Str(Round(km2, 2))
        Textcycling.Text = Str(Round(km3, 2))
        Textteam.Text = Str(Round(km4, 2))

    End Sub
End Class
