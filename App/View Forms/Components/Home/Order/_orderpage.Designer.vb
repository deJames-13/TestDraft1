<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _orderpage
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
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.orderWrapper = New System.Windows.Forms.Panel()
        Me.cartContainer = New System.Windows.Forms.Panel()
        Me.cartBox = New System.Windows.Forms.Panel()
        Me.order_itemContainer = New System.Windows.Forms.Panel()
        Me.cartBoxTop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShipping = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancelled = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelivered = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnEditOrders = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.orderWrapper.SuspendLayout()
        Me.cartContainer.SuspendLayout()
        Me.cartBox.SuspendLayout()
        Me.cartBoxTop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.orderWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(20)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 6
        '
        'orderWrapper
        '
        Me.orderWrapper.Controls.Add(Me.cartContainer)
        Me.orderWrapper.Controls.Add(Me.Panel7)
        Me.orderWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.orderWrapper.Location = New System.Drawing.Point(20, 20)
        Me.orderWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.orderWrapper.Name = "orderWrapper"
        Me.orderWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.orderWrapper.Size = New System.Drawing.Size(944, 621)
        Me.orderWrapper.TabIndex = 6
        '
        'cartContainer
        '
        Me.cartContainer.Controls.Add(Me.cartBox)
        Me.cartContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartContainer.Location = New System.Drawing.Point(5, 76)
        Me.cartContainer.Name = "cartContainer"
        Me.cartContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.cartContainer.Size = New System.Drawing.Size(934, 540)
        Me.cartContainer.TabIndex = 25
        '
        'cartBox
        '
        Me.cartBox.BackColor = System.Drawing.Color.GhostWhite
        Me.cartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cartBox.Controls.Add(Me.order_itemContainer)
        Me.cartBox.Controls.Add(Me.cartBoxTop)
        Me.cartBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartBox.Location = New System.Drawing.Point(10, 10)
        Me.cartBox.Margin = New System.Windows.Forms.Padding(5)
        Me.cartBox.Name = "cartBox"
        Me.cartBox.Padding = New System.Windows.Forms.Padding(5)
        Me.cartBox.Size = New System.Drawing.Size(914, 530)
        Me.cartBox.TabIndex = 7
        '
        'order_itemContainer
        '
        Me.order_itemContainer.AutoScroll = True
        Me.order_itemContainer.BackColor = System.Drawing.Color.White
        Me.order_itemContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_itemContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.order_itemContainer.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.order_itemContainer.Location = New System.Drawing.Point(5, 55)
        Me.order_itemContainer.Margin = New System.Windows.Forms.Padding(5)
        Me.order_itemContainer.Name = "order_itemContainer"
        Me.order_itemContainer.Padding = New System.Windows.Forms.Padding(10, 10, 0, 5)
        Me.order_itemContainer.Size = New System.Drawing.Size(902, 468)
        Me.order_itemContainer.TabIndex = 36
        '
        'cartBoxTop
        '
        Me.cartBoxTop.Controls.Add(Me.Panel1)
        Me.cartBoxTop.Controls.Add(Me.Panel3)
        Me.cartBoxTop.Controls.Add(Me.Panel4)
        Me.cartBoxTop.Controls.Add(Me.Label7)
        Me.cartBoxTop.Controls.Add(Me.Panel2)
        Me.cartBoxTop.Controls.Add(Me.Panel11)
        Me.cartBoxTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.cartBoxTop.Location = New System.Drawing.Point(5, 5)
        Me.cartBoxTop.Name = "cartBoxTop"
        Me.cartBoxTop.Padding = New System.Windows.Forms.Padding(3)
        Me.cartBoxTop.Size = New System.Drawing.Size(902, 50)
        Me.cartBoxTop.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnPending)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(365, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Panel1.Size = New System.Drawing.Size(132, 44)
        Me.Panel1.TabIndex = 15
        '
        'btnPending
        '
        Me.btnPending.AutoSize = True
        Me.btnPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPending.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnPending.FlatAppearance.BorderSize = 0
        Me.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPending.Font = New System.Drawing.Font("Lexend SemiBold", 8.25!)
        Me.btnPending.ForeColor = System.Drawing.Color.Black
        Me.btnPending.Location = New System.Drawing.Point(15, 5)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(102, 34)
        Me.btnPending.TabIndex = 1
        Me.btnPending.Text = "Pending"
        Me.btnPending.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnShipping)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(497, 3)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Panel3.Size = New System.Drawing.Size(118, 44)
        Me.Panel3.TabIndex = 16
        '
        'btnShipping
        '
        Me.btnShipping.AutoSize = True
        Me.btnShipping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnShipping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnShipping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnShipping.FlatAppearance.BorderSize = 0
        Me.btnShipping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShipping.Font = New System.Drawing.Font("Lexend SemiBold", 8.25!)
        Me.btnShipping.ForeColor = System.Drawing.Color.Black
        Me.btnShipping.Location = New System.Drawing.Point(15, 5)
        Me.btnShipping.Name = "btnShipping"
        Me.btnShipping.Size = New System.Drawing.Size(88, 34)
        Me.btnShipping.TabIndex = 1
        Me.btnShipping.Text = "Shipping"
        Me.btnShipping.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.btnCancelled)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(615, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Panel4.Size = New System.Drawing.Size(141, 44)
        Me.Panel4.TabIndex = 14
        '
        'btnCancelled
        '
        Me.btnCancelled.AutoSize = True
        Me.btnCancelled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCancelled.FlatAppearance.BorderSize = 0
        Me.btnCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelled.Font = New System.Drawing.Font("Lexend SemiBold", 8.25!)
        Me.btnCancelled.ForeColor = System.Drawing.Color.Black
        Me.btnCancelled.Location = New System.Drawing.Point(15, 5)
        Me.btnCancelled.Name = "btnCancelled"
        Me.btnCancelled.Size = New System.Drawing.Size(111, 34)
        Me.btnCancelled.TabIndex = 1
        Me.btnCancelled.Text = "Cancelled"
        Me.btnCancelled.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.GhostWhite
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label7.Size = New System.Drawing.Size(192, 44)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Placed Items"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnDelivered)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(756, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.Panel2.Size = New System.Drawing.Size(99, 44)
        Me.Panel2.TabIndex = 17
        '
        'btnDelivered
        '
        Me.btnDelivered.AutoSize = True
        Me.btnDelivered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelivered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelivered.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDelivered.FlatAppearance.BorderSize = 0
        Me.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelivered.Font = New System.Drawing.Font("Lexend SemiBold", 8.25!)
        Me.btnDelivered.ForeColor = System.Drawing.Color.Black
        Me.btnDelivered.Location = New System.Drawing.Point(15, 5)
        Me.btnDelivered.Name = "btnDelivered"
        Me.btnDelivered.Size = New System.Drawing.Size(69, 34)
        Me.btnDelivered.TabIndex = 1
        Me.btnDelivered.Text = "Delivered"
        Me.btnDelivered.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnEditOrders)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(855, 3)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(44, 44)
        Me.Panel11.TabIndex = 13
        '
        'btnEditOrders
        '
        Me.btnEditOrders.AutoSize = True
        Me.btnEditOrders.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_edit_20
        Me.btnEditOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEditOrders.FlatAppearance.BorderSize = 0
        Me.btnEditOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditOrders.ForeColor = System.Drawing.Color.LightCoral
        Me.btnEditOrders.Location = New System.Drawing.Point(5, 5)
        Me.btnEditOrders.Name = "btnEditOrders"
        Me.btnEditOrders.Size = New System.Drawing.Size(34, 34)
        Me.btnEditOrders.TabIndex = 1
        Me.btnEditOrders.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.titleIcon)
        Me.Panel7.Controls.Add(Me.Panel21)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(5, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel7.Size = New System.Drawing.Size(934, 71)
        Me.Panel7.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Lexend", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 58)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Your Orders"
        '
        'titleIcon
        '
        Me.titleIcon.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_cart_64
        Me.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.titleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.titleIcon.Location = New System.Drawing.Point(2, 2)
        Me.titleIcon.Name = "titleIcon"
        Me.titleIcon.Size = New System.Drawing.Size(70, 64)
        Me.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.titleIcon.TabIndex = 24
        Me.titleIcon.TabStop = False
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(2, 66)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(930, 3)
        Me.Panel21.TabIndex = 1
        '
        '_orderpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_orderpage"
        Me.Text = "_orderpage"
        Me.windowWrapper.ResumeLayout(False)
        Me.orderWrapper.ResumeLayout(False)
        Me.cartContainer.ResumeLayout(False)
        Me.cartBox.ResumeLayout(False)
        Me.cartBoxTop.ResumeLayout(False)
        Me.cartBoxTop.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents orderWrapper As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents titleIcon As PictureBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents cartContainer As Panel
    Friend WithEvents cartBox As Panel
    Friend WithEvents cartBoxTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPending As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnShipping As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCancelled As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelivered As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnEditOrders As Button
    Friend WithEvents order_itemContainer As Panel
End Class
