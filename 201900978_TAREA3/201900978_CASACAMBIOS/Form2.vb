Public Class FormR
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs)
        Resultado_Total()
    End Sub

    Private Sub Regresar_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        Form1.Show()


    End Sub

    Private Sub Salir2_Click(sender As Object, e As EventArgs) Handles Salir2.Click
        Me.Close()
    End Sub



End Class