<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.exitBtn = New Guna.UI.WinForms.GunaCircleButton()
        Me.passInfo = New Guna.UI.WinForms.GunaLabel()
        Me.showPass = New Guna.UI.WinForms.GunaCheckBox()
        Me.loginBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.password = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.username = New Guna.UI.WinForms.GunaLineTextBox()
        Me.mainTxt = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.exitBtn)
        Me.GunaGradientPanel1.Controls.Add(Me.passInfo)
        Me.GunaGradientPanel1.Controls.Add(Me.showPass)
        Me.GunaGradientPanel1.Controls.Add(Me.loginBtn)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.password)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.username)
        Me.GunaGradientPanel1.Controls.Add(Me.mainTxt)
        Me.GunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.Maroon
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Maroon
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(420, 356)
        Me.GunaGradientPanel1.TabIndex = 0
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'exitBtn
        '
        Me.exitBtn.AnimationHoverSpeed = 0.07!
        Me.exitBtn.AnimationSpeed = 0.03!
        Me.exitBtn.BackColor = System.Drawing.Color.Transparent
        Me.exitBtn.BaseColor = System.Drawing.Color.Red
        Me.exitBtn.BorderColor = System.Drawing.Color.Black
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.exitBtn.FocusedColor = System.Drawing.Color.Empty
        Me.exitBtn.Font = New System.Drawing.Font("Sriracha", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.White
        Me.exitBtn.Image = Nothing
        Me.exitBtn.ImageSize = New System.Drawing.Size(52, 52)
        Me.exitBtn.Location = New System.Drawing.Point(378, 12)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.exitBtn.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.exitBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.exitBtn.OnHoverImage = Nothing
        Me.exitBtn.OnPressedColor = System.Drawing.Color.Black
        Me.exitBtn.Size = New System.Drawing.Size(30, 30)
        Me.exitBtn.TabIndex = 27
        Me.exitBtn.Text = "x"
        '
        'passInfo
        '
        Me.passInfo.AutoSize = True
        Me.passInfo.BackColor = System.Drawing.Color.Red
        Me.passInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.passInfo.ForeColor = System.Drawing.Color.White
        Me.passInfo.Location = New System.Drawing.Point(88, 243)
        Me.passInfo.Name = "passInfo"
        Me.passInfo.Size = New System.Drawing.Size(233, 13)
        Me.passInfo.TabIndex = 26
        Me.passInfo.Text = "Password must be at least 6 characters long"
        Me.passInfo.Visible = False
        '
        'showPass
        '
        Me.showPass.BackColor = System.Drawing.Color.Transparent
        Me.showPass.BaseColor = System.Drawing.Color.Transparent
        Me.showPass.CheckedOffColor = System.Drawing.Color.White
        Me.showPass.CheckedOnColor = System.Drawing.Color.Maroon
        Me.showPass.FillColor = System.Drawing.Color.WhiteSmoke
        Me.showPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.showPass.Location = New System.Drawing.Point(301, 212)
        Me.showPass.Name = "showPass"
        Me.showPass.Size = New System.Drawing.Size(57, 20)
        Me.showPass.TabIndex = 25
        Me.showPass.Text = "show"
        '
        'loginBtn
        '
        Me.loginBtn.AnimationHoverSpeed = 0.19!
        Me.loginBtn.AnimationSpeed = 0.2!
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BaseColor = System.Drawing.Color.Maroon
        Me.loginBtn.BorderColor = System.Drawing.Color.White
        Me.loginBtn.BorderSize = 1
        Me.loginBtn.CheckedBaseColor = System.Drawing.Color.Black
        Me.loginBtn.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.loginBtn.CheckedForeColor = System.Drawing.Color.White
        Me.loginBtn.CheckedImage = Nothing
        Me.loginBtn.CheckedLineColor = System.Drawing.Color.Transparent
        Me.loginBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.loginBtn.FocusedColor = System.Drawing.Color.Empty
        Me.loginBtn.Font = New System.Drawing.Font("Sriracha", 17.0!)
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Image = Nothing
        Me.loginBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.loginBtn.LineColor = System.Drawing.Color.Transparent
        Me.loginBtn.Location = New System.Drawing.Point(145, 280)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.OnHoverBaseColor = System.Drawing.Color.Brown
        Me.loginBtn.OnHoverBorderColor = System.Drawing.Color.Maroon
        Me.loginBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.loginBtn.OnHoverImage = Nothing
        Me.loginBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.loginBtn.OnPressedColor = System.Drawing.Color.Red
        Me.loginBtn.OnPressedDepth = 10
        Me.loginBtn.Radius = 8
        Me.loginBtn.Size = New System.Drawing.Size(118, 42)
        Me.loginBtn.TabIndex = 9
        Me.loginBtn.Text = "Login"
        Me.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(151, 172)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(93, 28)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "Password"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.FocusedLineColor = System.Drawing.Color.Maroon
        Me.password.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.password.LineColor = System.Drawing.Color.LightGray
        Me.password.LineSize = 4
        Me.password.Location = New System.Drawing.Point(107, 203)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.password.Size = New System.Drawing.Size(188, 37)
        Me.password.TabIndex = 7
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password.UseSystemPasswordChar = True
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(151, 101)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(99, 28)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Username"
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.White
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.FocusedLineColor = System.Drawing.Color.Maroon
        Me.username.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.username.LineColor = System.Drawing.Color.LightGray
        Me.username.LineSize = 4
        Me.username.Location = New System.Drawing.Point(107, 132)
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.Size = New System.Drawing.Size(188, 37)
        Me.username.TabIndex = 5
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mainTxt
        '
        Me.mainTxt.AutoSize = True
        Me.mainTxt.BackColor = System.Drawing.Color.Transparent
        Me.mainTxt.Font = New System.Drawing.Font("Sriracha", 30.0!)
        Me.mainTxt.ForeColor = System.Drawing.Color.DarkRed
        Me.mainTxt.Location = New System.Drawing.Point(79, 18)
        Me.mainTxt.Name = "mainTxt"
        Me.mainTxt.Size = New System.Drawing.Size(250, 71)
        Me.mainTxt.TabIndex = 4
        Me.mainTxt.Text = "USER LOGIN"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 356)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents password As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents username As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents mainTxt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents loginBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents passInfo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents showPass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents exitBtn As Guna.UI.WinForms.GunaCircleButton
End Class
