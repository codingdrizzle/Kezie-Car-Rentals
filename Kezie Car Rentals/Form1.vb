Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Progress.Value += 1
        progressTxt.Text = progress.Value & "%"

        If progress.Value = 100 Then
            progress.Visible = False
            progressTxt.Visible = False
            loginBtn.Visible = True
            Timer1.Dispose()
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub
End Class
