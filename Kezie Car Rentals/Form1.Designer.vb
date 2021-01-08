<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.progress = New Guna.UI.WinForms.GunaProgressBar()
        Me.progressTxt = New Guna.UI.WinForms.GunaLabel()
        Me.mainTxt = New Guna.UI.WinForms.GunaLabel()
        Me.loginBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(352, 461)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'progress
        '
        Me.progress.BorderColor = System.Drawing.Color.Black
        Me.progress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.progress.IdleColor = System.Drawing.Color.Black
        Me.progress.Location = New System.Drawing.Point(0, 197)
        Me.progress.Name = "progress"
        Me.progress.ProgressMaxColor = System.Drawing.Color.Red
        Me.progress.ProgressMinColor = System.Drawing.Color.Maroon
        Me.progress.Size = New System.Drawing.Size(352, 25)
        Me.progress.TabIndex = 1
        '
        'progressTxt
        '
        Me.progressTxt.AutoSize = True
        Me.progressTxt.BackColor = System.Drawing.Color.Black
        Me.progressTxt.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.progressTxt.ForeColor = System.Drawing.Color.White
        Me.progressTxt.Location = New System.Drawing.Point(152, 169)
        Me.progressTxt.Name = "progressTxt"
        Me.progressTxt.Size = New System.Drawing.Size(58, 25)
        Me.progressTxt.TabIndex = 2
        Me.progressTxt.Text = "100%"
        '
        'mainTxt
        '
        Me.mainTxt.AutoSize = True
        Me.mainTxt.BackColor = System.Drawing.Color.Black
        Me.mainTxt.Font = New System.Drawing.Font("Sriracha", 24.0!)
        Me.mainTxt.ForeColor = System.Drawing.Color.Brown
        Me.mainTxt.Location = New System.Drawing.Point(-5, 1)
        Me.mainTxt.Name = "mainTxt"
        Me.mainTxt.Size = New System.Drawing.Size(354, 57)
        Me.mainTxt.TabIndex = 3
        Me.mainTxt.Text = "LAUREL  CAR  RENTALS"
        '
        'loginBtn
        '
        Me.loginBtn.AnimationHoverSpeed = 0.19!
        Me.loginBtn.AnimationSpeed = 0.2!
        Me.loginBtn.BackColor = System.Drawing.Color.Transparent
        Me.loginBtn.BaseColor = System.Drawing.Color.Black
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
        Me.loginBtn.Location = New System.Drawing.Point(79, 132)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.loginBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.loginBtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.loginBtn.OnHoverImage = Nothing
        Me.loginBtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.loginBtn.OnPressedColor = System.Drawing.Color.Transparent
        Me.loginBtn.Radius = 8
        Me.loginBtn.Size = New System.Drawing.Size(208, 42)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Click to Login"
        Me.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.loginBtn.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 461)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.mainTxt)
        Me.Controls.Add(Me.progressTxt)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents progress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents progressTxt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents mainTxt As Guna.UI.WinForms.GunaLabel
    Friend WithEvents loginBtn As Guna.UI.WinForms.GunaAdvenceButton
End Class
