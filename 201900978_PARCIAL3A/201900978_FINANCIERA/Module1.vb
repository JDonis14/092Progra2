Imports System.Math
Module Module1
    Public viaje As Byte = 0
    Public Id(7) As Integer
    Public No_dias(7) As Integer
    Public No_personas(7) As Integer
    Public Tviaje(7) As String
    Public Total(7) As String
    Public Const bajaverapaz = 255
    Public Const huehuetenango = 440
    Public Const peten = 1190
    Public J As Byte

    Sub Vectores_Limpiar()
        Form1.DataGridView1.Rows.Clear()
        viaje = 0
        For J = 0 To 6
            Id(J) = Nothing
            No_dias(J) = Nothing
            No_personas(J) = Nothing
            Tviaje(J) = Nothing
            Total(J) = Nothing
        Next J
    End Sub
    Function Tipo_Viaje() As Double
        Select Case (Form1.Comboviaje.SelectedIndex)
            Case 0
                Tviaje(viaje) = "Laguna Brava(Huehuetenango)"
                Tipo_Viaje = huehuetenango
            Case 1
                Tviaje(viaje) = "Mirador(Petén)"
                Tipo_Viaje = peten
            Case 2
                Tviaje(viaje) = "Biotopo del Quetzal(Baja Verapaz)"
                Tipo_Viaje = bajaverapaz
            Case Else
                MsgBox("No selecciono tipo de viaje")
                Form1.Comboviaje.Focus()
                Exit Function
        End Select
        Return Tipo_Viaje
    End Function



End Module
