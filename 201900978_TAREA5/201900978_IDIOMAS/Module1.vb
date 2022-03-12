Imports System.Math
Module Module1
    Public Datos_del_estudiante(7, 10) As String
    Public lista As Byte = 0
    Public Const I_ingles = 150
    Public Const I_portugues = 80
    Public Const I_frances = 125
    Public Const Defectivo1 = 0.02
    Public Const Dcheque1 = 0.015
    Public Const Ddias2 = 0.05

    Sub LIMPIAR1()
        Form1.Comboidioma.Text = ""
        Form1.Radiocheque.Checked = 0
        Form1.Radioefectivo.Checked = 0
        Form1.Checkviernes.Checked = 0
        Form1.Checksabado.Checked = 0
        Form1.Textcarnet.Clear()
        Form1.Textnombre.Clear()
        Form1.Textfecha.Clear()
        Form1.Textcarnet.Focus()
    End Sub

    Sub LIMPIAR2()
        lista = 0
        Form1.Datacompleta.Rows.Clear()
        Form1.Textcarnet.Focus()
    End Sub
    Sub MOSTRAR_R()
        Form1.Datacompleta.Rows.Add(Datos_del_estudiante(lista, 0), Datos_del_estudiante(lista, 1), Datos_del_estudiante(lista, 2), Datos_del_estudiante(lista, 3), Datos_del_estudiante(lista, 4), Datos_del_estudiante(lista, 5), Datos_del_estudiante(lista, 6), Datos_del_estudiante(lista, 7), Datos_del_estudiante(lista, 8), Datos_del_estudiante(lista, 9), Datos_del_estudiante(lista, 10))
    End Sub
End Module
