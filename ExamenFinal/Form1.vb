Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Waldir Castillo" And TextBox2.Text = "WCM" Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("¡Clave incorrecta!  Intente De nuevo por favor")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
