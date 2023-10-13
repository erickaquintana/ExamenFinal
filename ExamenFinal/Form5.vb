Public Class Form5
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim a, b, resultado As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a * b
        TextBox3.Text = resultado
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class