Imports MySql.Data.MySqlClient
Public Class Form2
    Dim SQLconnection As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If username.Text.Length = 0 Or password.Text.Length = 0 Then
            loginBtn.Enabled = False
        Else
            loginBtn.Enabled = True
        End If

        If password.Text.Length = 0 Then
            showPass.Visible = False
        Else
            showPass.Visible = True
        End If
        If password.Text.Length = password.MaxLength Then
            passInfo.Text = "Password length must not exceed 12 characters!"
            MessageBox.Show("Password has reached it maximum length.", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If showPass.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If password.Text.Length < 6 Then
            passInfo.Visible = True
            MessageBox.Show("Password length is too short", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            passInfo.Visible = False
            SQLconnection = New MySqlConnection
            SQLconnection.ConnectionString = "server=localhost;userid=root;password=root; database=CAR_RENTAL"
            Dim reader As MySqlDataReader

            Try
                SQLconnection.Open()

                Dim queryStatement As String

                queryStatement = "select * from CAR_RENTAL.users where Username = '" & username.Text & "' And Password_ = '" & password.Text & "'"

                COMMAND = New MySqlCommand(queryStatement, SQLconnection)

                reader = COMMAND.ExecuteReader

                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    Dim dialog As DialogResult
                    dialog = MessageBox.Show("Loggin Successful", "User Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If dialog = DialogResult.OK Then
                        Me.Hide()
                        Form3.ShowDialog()
                    End If
                ElseIf count > 1 Then
                    MessageBox.Show("Username or Password already used")
                    username.Text = ""
                    password.Text = ""
                Else
                    MessageBox.Show("Username or Password is incorrect !!!" & ControlChars.NewLine & "Try AGAIN!")
                    password.Text = Nothing
                End If

                SQLconnection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                SQLconnection.Dispose()
            End Try
            username.Text = ""
            password.Text = ""
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to exit from your login page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Me.Close()
        Else
        End If
    End Sub
End Class