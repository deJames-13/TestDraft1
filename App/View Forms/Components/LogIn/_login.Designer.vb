<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_login))
        Me.loginTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.togglePass = New System.Windows.Forms.Button()
        Me.panel10 = New System.Windows.Forms.Panel()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnForgotPass = New System.Windows.Forms.LinkLabel()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginTitle
        '
        Me.loginTitle.AutoSize = True
        Me.loginTitle.BackColor = System.Drawing.Color.Transparent
        Me.loginTitle.Font = New System.Drawing.Font("Poppins SemiBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginTitle.Location = New System.Drawing.Point(57, 97)
        Me.loginTitle.Name = "loginTitle"
        Me.loginTitle.Size = New System.Drawing.Size(137, 65)
        Me.loginTitle.TabIndex = 0
        Me.loginTitle.Text = "Log In"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(119, 189)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(200, 50)
        Me.Panel4.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtUsername)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 15)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Panel9.Size = New System.Drawing.Size(200, 30)
        Me.Panel9.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUsername.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtUsername.Location = New System.Drawing.Point(5, 5)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(190, 20)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "developer"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 47)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 3)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(69, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 50)
        Me.Panel2.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel12.BackgroundImage = CType(resources.GetObject("Panel12.BackgroundImage"), System.Drawing.Image)
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(50, 47)
        Me.Panel12.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 3)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lexend", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(64, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lexend", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel15)
        Me.Panel1.Controls.Add(Me.panel10)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(119, 274)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(200, 50)
        Me.Panel1.TabIndex = 8
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel15.Controls.Add(Me.togglePass)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(170, 15)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel15.Size = New System.Drawing.Size(30, 32)
        Me.Panel15.TabIndex = 14
        '
        'togglePass
        '
        Me.togglePass.AutoSize = True
        Me.togglePass.BackColor = System.Drawing.Color.Transparent
        Me.togglePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.togglePass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.togglePass.FlatAppearance.BorderSize = 0
        Me.togglePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.togglePass.ForeColor = System.Drawing.Color.Black
        Me.togglePass.Image = Global.TestDraft1.My.Resources.Resources.icons8_closed_eye_20
        Me.togglePass.Location = New System.Drawing.Point(3, 3)
        Me.togglePass.Name = "togglePass"
        Me.togglePass.Size = New System.Drawing.Size(24, 26)
        Me.togglePass.TabIndex = 14
        Me.togglePass.UseVisualStyleBackColor = False
        '
        'panel10
        '
        Me.panel10.Controls.Add(Me.txtPass)
        Me.panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel10.Location = New System.Drawing.Point(0, 15)
        Me.panel10.Margin = New System.Windows.Forms.Padding(10)
        Me.panel10.Name = "panel10"
        Me.panel10.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.panel10.Size = New System.Drawing.Size(170, 32)
        Me.panel10.TabIndex = 12
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPass.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtPass.Location = New System.Drawing.Point(5, 5)
        Me.txtPass.MaxLength = 16
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(160, 20)
        Me.txtPass.TabIndex = 3
        Me.txtPass.Text = "pass6969"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 47)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 3)
        Me.Panel6.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel14)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(69, 274)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(50, 50)
        Me.Panel7.TabIndex = 7
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel14.BackgroundImage = CType(resources.GetObject("Panel14.BackgroundImage"), System.Drawing.Image)
        Me.Panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(50, 47)
        Me.Panel14.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 47)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(50, 3)
        Me.Panel8.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Transparent
        Me.Panel13.Controls.Add(Me.btnLogin)
        Me.Panel13.Location = New System.Drawing.Point(69, 344)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel13.Size = New System.Drawing.Size(100, 50)
        Me.Panel13.TabIndex = 10
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Lexend", 10.0!)
        Me.btnLogin.Location = New System.Drawing.Point(5, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(90, 40)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnSignUp)
        Me.Panel11.Location = New System.Drawing.Point(219, 344)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(100, 50)
        Me.Panel11.TabIndex = 11
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnSignUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Lexend", 10.0!)
        Me.btnSignUp.Location = New System.Drawing.Point(5, 5)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(90, 40)
        Me.btnSignUp.TabIndex = 0
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnForgotPass
        '
        Me.btnForgotPass.ActiveLinkColor = System.Drawing.Color.MediumPurple
        Me.btnForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.btnForgotPass.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnForgotPass.Font = New System.Drawing.Font("Lexend", 10.0!)
        Me.btnForgotPass.LinkColor = System.Drawing.Color.LightSeaGreen
        Me.btnForgotPass.Location = New System.Drawing.Point(74, 404)
        Me.btnForgotPass.Name = "btnForgotPass"
        Me.btnForgotPass.Size = New System.Drawing.Size(240, 23)
        Me.btnForgotPass.TabIndex = 13
        Me.btnForgotPass.TabStop = True
        Me.btnForgotPass.Text = "Forgot Password?"
        Me.btnForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnForgotPass.Visible = False
        '
        '_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.btnForgotPass)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.loginTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In Page"
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.panel10.ResumeLayout(False)
        Me.panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents panel10 As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnForgotPass As LinkLabel
    Friend WithEvents togglePass As Button
End Class
