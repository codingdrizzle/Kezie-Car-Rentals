Public Class Form3
    Private Sub menuDrop_Click(sender As Object, e As EventArgs) Handles menuDrop.Click
        collapsePanel.Visible = True
        menuDrop.Visible = False
    End Sub

    Private Sub menuClose_Click(sender As Object, e As EventArgs) Handles menuClose.Click
        collapsePanel.Visible = False
        menuDrop.Visible = True
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        collapsePanel.Visible = False
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to LogOut?", "Confirm LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub rentCar_Click(sender As Object, e As EventArgs) Handles rentCar.Click
        carGallery.Visible = True
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        carGallery.Visible = False
        collapsePanel.Visible = False
        homePanel.Visible = True
        menuDrop.Visible = True
        aboutPanel.Visible = False
        contactPanel.Visible = False
    End Sub
    Private Sub contactUsBtn_Click(sender As Object, e As EventArgs) Handles contactUsBtn.Click
        contactPanel.Visible = True
        carGallery.Visible = False
        collapsePanel.Visible = False
        homePanel.Visible = False
        menuDrop.Visible = True
        aboutPanel.Visible = False
    End Sub
    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        carGallery.Visible = False
        collapsePanel.Visible = False
        homePanel.Visible = False
        aboutPanel.Visible = True
        menuDrop.Visible = True
        contactPanel.Visible = False
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____12_
        status.Text = "4 seats | Family Portable"
        period.Text = "2 days"
        price.Text = "GH¢ 200.00"
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____7_
        status.Text = "4 seats | Air-Conditioned"
        period.Text = "4 days"
        price.Text = "GH¢ 150.00"
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____9_
        status.Text = "4 seats | Air-Conditioned"
        period.Text = "1 day"
        price.Text = "GH¢ 105.00"
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources.Cars__66_
        status.Text = "2 seats | Couples Comfort"
        period.Text = "1 day"
        price.Text = "GH¢ 180.00"
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources.Cars__59_
        status.Text = "2 seats | Two Persons"
        period.Text = "20 minutes"
        price.Text = "GH¢ 420.00"
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____13_
        status.Text = "4 seats | Family and Friends"
        period.Text = "3 days"
        price.Text = "GH¢ 350.00"
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____8_
        status.Text = "4 seats | Comfortable"
        period.Text = "1 day"
        price.Text = "GH¢ 250.00"
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____86_
        status.Text = "2 seats | Computerized"
        period.Text = "40 minutes"
        price.Text = "GH¢ 400.00"
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____11_
        status.Text = "4 seats"
        period.Text = "1 day"
        price.Text = "GH¢ 260.00"
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____6_
        status.Text = "2 seats | Portable and Relaxing"
        period.Text = "1 week"
        price.Text = "GH¢ 290.00"
    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources._CooL_GuY____a2zRG____91_
        status.Text = "4 seats"
        period.Text = "2 days"
        price.Text = "GH¢ 500.00"
    End Sub
    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        bookPanel.Visible = True
        bookPic.Image = My.Resources.Cars__21_
        status.Text = "2 seats"
        period.Text = "3 days"
        price.Text = "GH¢ 400.00"
    End Sub
    Private Sub cancelBtn_Click_1(sender As Object, e As EventArgs) Handles cancelBtn.Click
        bookPanel.Visible = False
    End Sub

    Private Sub submitBook_Click(sender As Object, e As EventArgs) Handles submitBook.Click
        collapsePanel.Visible = False
        bookPanel.Visible = False
        MessageBox.Show("Dear Customer, You will receive an Email very shortly when your car is made available. THANK YOU!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        GunaTextBox1.Text = ""
        GunaTextBox3.Text = ""
    End Sub
End Class