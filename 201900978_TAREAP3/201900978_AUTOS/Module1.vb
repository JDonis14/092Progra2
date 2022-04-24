Imports System.Math
Module Module1
    Public renta As Byte = 0
    Public no_placa(7) As Integer
    Public KilometroI(7) As Double
    Public KilometroF(7) As Double
    Public Tauto(7) As String
    Public base(7) As Double
    Public cobro(7) As Double
    Public Total(7) As Double
    Public Kilometraje(7) As Double
    Public Const T1 = 500
    Public Const T2 = 400
    Public Const T3 = 300
    Public Const T4 = 200
    Public J As Byte

    Function Cobro_Base() As Double
        Select Case (Form1.Comboauto.SelectedIndex)
            Case 0
                Tauto(renta) = "TIPO 1"
                Cobro_Base = T1
            Case 1
                Tauto(renta) = "TIPO 2"
                Cobro_Base = T2
            Case 2
                Tauto(renta) = "TIPO 3"
                Cobro_Base = T3
            Case 0
                Tauto(renta) = "TIPO 4"
                Cobro_Base = T4
            Case Else
                MsgBox("No selecciono tipo automovil")
                Form1.Comboauto.Focus()
                Exit Function
        End Select
        Return Cobro_Base
    End Function

    Sub Vectores_Limpiar()
        Form1.DataGridView1.Rows.Clear()
        renta = 0
        For J = 0 To 6
            no_placa(J) = Nothing
            KilometroI(J) = Nothing
            KilometroF(J) = Nothing
            Tauto(J) = Nothing
            base(J) = Nothing
            cobro(J) = Nothing
            Total(J) = Nothing
            Kilometraje(J) = Nothing
        Next J
    End Sub



End Module
