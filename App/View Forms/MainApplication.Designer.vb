<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApplication))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bannerWelcome = New System.Windows.Forms.Panel()
        Me.bannerRole = New System.Windows.Forms.Panel()
        Me.S = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.roleWrapper = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.bannerWelcome.SuspendLayout()
        Me.bannerRole.SuspendLayout()
        Me.roleWrapper.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lexend Medium", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(944, 92)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME USER!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bannerWelcome
        '
        Me.bannerWelcome.Controls.Add(Me.Label1)
        Me.bannerWelcome.Location = New System.Drawing.Point(16, 250)
        Me.bannerWelcome.Margin = New System.Windows.Forms.Padding(10)
        Me.bannerWelcome.Name = "bannerWelcome"
        Me.bannerWelcome.Padding = New System.Windows.Forms.Padding(3)
        Me.bannerWelcome.Size = New System.Drawing.Size(950, 98)
        Me.bannerWelcome.TabIndex = 26
        '
        'bannerRole
        '
        Me.bannerRole.Controls.Add(Me.S)
        Me.bannerRole.Location = New System.Drawing.Point(16, 323)
        Me.bannerRole.Margin = New System.Windows.Forms.Padding(10)
        Me.bannerRole.Name = "bannerRole"
        Me.bannerRole.Padding = New System.Windows.Forms.Padding(3)
        Me.bannerRole.Size = New System.Drawing.Size(950, 34)
        Me.bannerRole.TabIndex = 27
        '
        'S
        '
        Me.S.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S.Font = New System.Drawing.Font("Lexend Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.S.Location = New System.Drawing.Point(3, 3)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(944, 28)
        Me.S.TabIndex = 0
        Me.S.Text = "Please choose your role:"
        Me.S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(-15, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(984, 217)
        Me.Panel1.TabIndex = 28
        '
        'roleWrapper
        '
        Me.roleWrapper.AutoSize = True
        Me.roleWrapper.Controls.Add(Me.Label8)
        Me.roleWrapper.Controls.Add(Me.Panel2)
        Me.roleWrapper.Controls.Add(Me.Panel11)
        Me.roleWrapper.Location = New System.Drawing.Point(214, 374)
        Me.roleWrapper.Name = "roleWrapper"
        Me.roleWrapper.Size = New System.Drawing.Size(555, 210)
        Me.roleWrapper.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Lexend Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 210)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "OR"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(345, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(210, 210)
        Me.Panel2.TabIndex = 16
        '
        'btnCustomer
        '
        Me.btnCustomer.AutoSize = True
        Me.btnCustomer.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Lexend SemiBold", 10.0!)
        Me.btnCustomer.Image = Global.TestDraft1.My.Resources.Resources.icons8_customer_100
        Me.btnCustomer.Location = New System.Drawing.Point(5, 5)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(200, 200)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "CUSTOMER"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnAdmin)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(210, 210)
        Me.Panel11.TabIndex = 15
        '
        'btnAdmin
        '
        Me.btnAdmin.AutoSize = True
        Me.btnAdmin.BackColor = System.Drawing.Color.GhostWhite
        Me.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Lexend SemiBold", 10.0!)
        Me.btnAdmin.Image = Global.TestDraft1.My.Resources.Resources.icons8_administrator_100
        Me.btnAdmin.Location = New System.Drawing.Point(5, 5)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(200, 200)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "ADMINISTRATOR"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'MainApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 617)
        Me.Controls.Add(Me.roleWrapper)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bannerRole)
        Me.Controls.Add(Me.bannerWelcome)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome!"
        Me.bannerWelcome.ResumeLayout(False)
        Me.bannerRole.ResumeLayout(False)
        Me.roleWrapper.ResumeLayout(False)
        Me.roleWrapper.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents bannerWelcome As Panel
    Friend WithEvents bannerRole As Panel
    Friend WithEvents S As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents roleWrapper As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnAdmin As Button
End Class
