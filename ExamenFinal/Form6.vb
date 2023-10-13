Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, resultado As Double
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a / b
        TextBox3.Text = resultado
        If TextBox1.Text = 0 Then
            TextBox3.Text = "Error"
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = "Error"
        End If
    End Sub
End Class