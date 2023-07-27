<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_home))
        Me.mainWindowPanel = New System.Windows.Forms.Panel()
        Me.leftSection = New System.Windows.Forms.Panel()
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.navPanel = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.mainWindowPanel.SuspendLayout()
        Me.leftSection.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.sidePanel.SuspendLayout()
        Me.navPanel.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.bottomPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainWindowPanel
        '
        Me.mainWindowPanel.BackColor = System.Drawing.Color.White
        Me.mainWindowPanel.Controls.Add(Me.leftSection)
        Me.mainWindowPanel.Controls.Add(Me.Panel1)
        Me.mainWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainWindowPanel.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainWindowPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainWindowPanel.Name = "mainWindowPanel"
        Me.mainWindowPanel.Size = New System.Drawing.Size(1184, 661)
        Me.mainWindowPanel.TabIndex = 0
        '
        'leftSection
        '
        Me.leftSection.Controls.Add(Me.windowWrapper)
        Me.leftSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leftSection.Location = New System.Drawing.Point(200, 0)
        Me.leftSection.Name = "leftSection"
        Me.leftSection.Size = New System.Drawing.Size(984, 661)
        Me.leftSection.TabIndex = 1
        '
        'windowWrapper
        '
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.sidePanel)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 661)
        Me.Panel1.TabIndex = 0
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.GhostWhite
        Me.sidePanel.Controls.Add(Me.navPanel)
        Me.sidePanel.Controls.Add(Me.bottomPanel)
        Me.sidePanel.Controls.Add(Me.logoPanel)
        Me.sidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.sidePanel.Size = New System.Drawing.Size(198, 661)
        Me.sidePanel.TabIndex = 32
        '
        'navPanel
        '
        Me.navPanel.BackColor = System.Drawing.Color.Transparent
        Me.navPanel.Controls.Add(Me.Panel12)
        Me.navPanel.Controls.Add(Me.Panel10)
        Me.navPanel.Controls.Add(Me.Panel2)
        Me.navPanel.Controls.Add(Me.Panel8)
        Me.navPanel.Controls.Add(Me.Panel6)
        Me.navPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navPanel.Location = New System.Drawing.Point(0, 150)
        Me.navPanel.Name = "navPanel"
        Me.navPanel.Size = New System.Drawing.Size(198, 411)
        Me.navPanel.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnSettings)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 316)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(5, 35, 5, 5)
        Me.Panel12.Size = New System.Drawing.Size(198, 95)
        Me.Panel12.TabIndex = 17
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnProfile)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 240)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(5, 20, 5, 5)
        Me.Panel10.Size = New System.Drawing.Size(198, 80)
        Me.Panel10.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnOrders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 160)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 20, 5, 5)
        Me.Panel2.Size = New System.Drawing.Size(198, 80)
        Me.Panel2.TabIndex = 18
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnCart)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 80)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5, 20, 5, 5)
        Me.Panel8.Size = New System.Drawing.Size(198, 80)
        Me.Panel8.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.btnShop)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5, 20, 5, 5)
        Me.Panel6.Size = New System.Drawing.Size(198, 80)
        Me.Panel6.TabIndex = 14
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.Color.Azure
        Me.bottomPanel.Controls.Add(Me.Label2)
        Me.bottomPanel.Controls.Add(Me.Label8)
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 561)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.bottomPanel.Size = New System.Drawing.Size(198, 100)
        Me.bottomPanel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(5, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 60)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "about us." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(198, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 661)
        Me.Panel3.TabIndex = 31
        '
        'btnSettings
        '
        Me.btnSettings.AutoSize = True
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.TestDraft1.My.Resources.Resources.settingsBtn
        Me.btnSettings.Location = New System.Drawing.Point(5, 35)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(188, 55)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "`"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.AutoSize = True
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.Location = New System.Drawing.Point(5, 20)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(188, 55)
        Me.btnProfile.TabIndex = 2
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.AutoSize = True
        Me.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.Image = Global.TestDraft1.My.Resources.Resources.ordersBtn
        Me.btnOrders.Location = New System.Drawing.Point(5, 20)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(188, 55)
        Me.btnOrders.TabIndex = 2
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnCart
        '
        Me.btnCart.AutoSize = True
        Me.btnCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCart.FlatAppearance.BorderSize = 0
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCart.Image = CType(resources.GetObject("btnCart.Image"), System.Drawing.Image)
        Me.btnCart.Location = New System.Drawing.Point(5, 20)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(188, 55)
        Me.btnCart.TabIndex = 2
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnShop
        '
        Me.btnShop.AutoSize = True
        Me.btnShop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnShop.FlatAppearance.BorderSize = 0
        Me.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShop.Image = CType(resources.GetObject("btnShop.Image"), System.Drawing.Image)
        Me.btnShop.Location = New System.Drawing.Point(5, 20)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(188, 55)
        Me.btnShop.TabIndex = 2
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'logoPanel
        '
        Me.logoPanel.BackColor = System.Drawing.Color.White
        Me.logoPanel.BackgroundImage = Global.TestDraft1.My.Resources.Resources.logo198x100
        Me.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 50)
        Me.logoPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.logoPanel.Size = New System.Drawing.Size(198, 100)
        Me.logoPanel.TabIndex = 2
        '
        '_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.mainWindowPanel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.mainWindowPanel.ResumeLayout(False)
        Me.leftSection.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.sidePanel.ResumeLayout(False)
        Me.navPanel.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.bottomPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainWindowPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents sidePanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents navPanel As Panel
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnShop As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnCart As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents leftSection As Panel
    Friend WithEvents windowWrapper As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOrders As Button
End Class
