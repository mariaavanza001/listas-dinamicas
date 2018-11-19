Public Class Form1

    Private l As New lista()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text As String = TextBox1.Text
        Dim edad As Integer = Val(TextBox2.Text)
        l.insertar(Text, edad)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        l.mostrar()
    End Sub
End Class
