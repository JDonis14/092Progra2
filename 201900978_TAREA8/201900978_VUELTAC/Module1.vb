Imports System.Math
Module Module1
    Public Ciclista As Byte = 0
    Public No_etapa(12) As Integer
    Public Equipo(12) As String
    Public Recorrido(12) As Double
    Public Tiempo(12) As Integer
    Public Nacionalidad(12) As String
    Public Penalizacion(12) As Integer
    Public Total(12) As Integer
    Public Const Penalizacion1 = 30
    Public Const Penalizacion2 = 40
    Public Const Penalizacion3 = 50
    Public Const Reduccion1 = 15
    Public Const Reduccion2 = 10
    Public J As Byte

    Sub Limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()
        Form1.Text45.Clear()
        Form1.Textcycling.Clear()
        Form1.Textextranjero.Clear()
        Form1.Textnacional.Clear()
        Form1.Textmovistar.Clear()
        Form1.Textteam.Clear()
        Form1.Textsky.Clear()
        Form1.Textno.Clear()
        Ciclista = 0
        For J = 0 To 11

            No_etapa(J) = Nothing
            Equipo(J) = Nothing
            Recorrido(J) = Nothing
            Tiempo(J) = Nothing
            Nacionalidad(J) = Nothing
            Penalizacion(J) = Nothing
            Total(J) = Nothing
        Next J
    End Sub
    Sub limpiar_Entradas()
        Form1.Comboequipo.SelectedIndex = -1
        Form1.Combonacionalidad.SelectedIndex = -1
        Form1.Textetapa.Clear()
        Form1.Textrecorrido.Clear()
        Form1.Texttiempo.Clear()
        Form1.Textno.Clear()
    End Sub
    Sub Tiempo_agregado()
        If (Tiempo(Ciclista) > 120) Then
            Penalizacion(Ciclista) = Penalizacion1
            Total(Ciclista) = Tiempo(Ciclista) + Penalizacion(Ciclista)
        ElseIf (Tiempo(Ciclista) > 140) Then
            Penalizacion(Ciclista) = Penalizacion2
            Total(Ciclista) = Tiempo(Ciclista) + Penalizacion(Ciclista)
        ElseIf (Tiempo(Ciclista) > 160) Then
            Penalizacion(Ciclista) = Penalizacion3
            Total(Ciclista) = Tiempo(Ciclista) + Penalizacion(Ciclista)
        ElseIf (Tiempo(Ciclista) < 85 And Equipo(Ciclista) = "Movistar") Then
            Penalizacion(Ciclista) = Reduccion1
            Total(Ciclista) = Tiempo(Ciclista) - Penalizacion(Ciclista)
        ElseIf (Tiempo(Ciclista) < 85 And Equipo(Ciclista) = "Pro Team") Then
            Penalizacion(Ciclista) = Reduccion2
            Total(Ciclista) = Tiempo(Ciclista) - Penalizacion(Ciclista)
        Else
            Penalizacion(Ciclista) = 0
            Total(Ciclista) = Tiempo(Ciclista) - Penalizacion(Ciclista)
        End If
    End Sub

End Module
