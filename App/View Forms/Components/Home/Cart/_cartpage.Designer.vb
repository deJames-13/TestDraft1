<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _cartpage
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
        Me.cartWrapper = New System.Windows.Forms.Panel()
        Me.cartSummary = New System.Windows.Forms.Panel()
        Me.order_summary = New System.Windows.Forms.Panel()
        Me.totalCost = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.cartContainer = New System.Windows.Forms.Panel()
        Me.cartBox = New System.Windows.Forms.Panel()
        Me.itemContainer = New System.Windows.Forms.Panel()
        Me.cartBoxTop = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titleIcon = New System.Windows.Forms.PictureBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.cartWrapper.SuspendLayout()
        Me.cartSummary.SuspendLayout()
        Me.order_summary.SuspendLayout()
        Me.totalCost.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.cartContainer.SuspendLayout()
        Me.cartBox.SuspendLayout()
        Me.cartBoxTop.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.Controls.Add(Me.cartWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(20)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 0
        '
        'cartWrapper
        '
        Me.cartWrapper.Controls.Add(Me.cartSummary)
        Me.cartWrapper.Controls.Add(Me.cartContainer)
        Me.cartWrapper.Controls.Add(Me.Panel7)
        Me.cartWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartWrapper.Location = New System.Drawing.Point(20, 20)
        Me.cartWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.cartWrapper.Name = "cartWrapper"
        Me.cartWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.cartWrapper.Size = New System.Drawing.Size(944, 621)
        Me.cartWrapper.TabIndex = 5
        '
        'cartSummary
        '
        Me.cartSummary.Controls.Add(Me.order_summary)
        Me.cartSummary.Controls.Add(Me.Panel1)
        Me.cartSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartSummary.Location = New System.Drawing.Point(605, 76)
        Me.cartSummary.Name = "cartSummary"
        Me.cartSummary.Padding = New System.Windows.Forms.Padding(10)
        Me.cartSummary.Size = New System.Drawing.Size(334, 540)
        Me.cartSummary.TabIndex = 25
        '
        'order_summary
        '
        Me.order_summary.AutoScroll = True
        Me.order_summary.BackColor = System.Drawing.Color.GhostWhite
        Me.order_summary.Controls.Add(Me.totalCost)
        Me.order_summary.Controls.Add(Me.Panel3)
        Me.order_summary.Controls.Add(Me.Panel2)
        Me.order_summary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.order_summary.Location = New System.Drawing.Point(10, 10)
        Me.order_summary.Name = "order_summary"
        Me.order_summary.Padding = New System.Windows.Forms.Padding(5)
        Me.order_summary.Size = New System.Drawing.Size(314, 463)
        Me.order_summary.TabIndex = 16
        '
        'totalCost
        '
        Me.totalCost.AutoSize = True
        Me.totalCost.Controls.Add(Me.txtTotal)
        Me.totalCost.Controls.Add(Me.Label9)
        Me.totalCost.Dock = System.Windows.Forms.DockStyle.Top
        Me.totalCost.Location = New System.Drawing.Point(5, 49)
        Me.totalCost.Margin = New System.Windows.Forms.Padding(5)
        Me.totalCost.Name = "totalCost"
        Me.totalCost.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.totalCost.Size = New System.Drawing.Size(304, 50)
        Me.totalCost.TabIndex = 30
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(76, 23)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(225, 24)
        Me.txtTotal.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Lexend Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.Label9.Size = New System.Drawing.Size(73, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Cost"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 46)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 3)
        Me.Panel3.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(304, 41)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label2.Size = New System.Drawing.Size(192, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Order Summary"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.btnCheckOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Lexend", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(10, 473)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(314, 57)
        Me.Panel1.TabIndex = 15
        '
        'btnCheckOut
        '
        Me.btnCheckOut.AutoSize = True
        Me.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Location = New System.Drawing.Point(5, 5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(304, 47)
        Me.btnCheckOut.TabIndex = 1
        Me.btnCheckOut.Text = "CHECK OUT"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'cartContainer
        '
        Me.cartContainer.Controls.Add(Me.cartBox)
        Me.cartContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.cartContainer.Location = New System.Drawing.Point(5, 76)
        Me.cartContainer.Name = "cartContainer"
        Me.cartContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.cartContainer.Size = New System.Drawing.Size(600, 540)
        Me.cartContainer.TabIndex = 24
        '
        'cartBox
        '
        Me.cartBox.BackColor = System.Drawing.Color.GhostWhite
        Me.cartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cartBox.Controls.Add(Me.itemContainer)
        Me.cartBox.Controls.Add(Me.cartBoxTop)
        Me.cartBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cartBox.Location = New System.Drawing.Point(10, 10)
        Me.cartBox.Margin = New System.Windows.Forms.Padding(5)
        Me.cartBox.Name = "cartBox"
        Me.cartBox.Padding = New System.Windows.Forms.Padding(5)
        Me.cartBox.Size = New System.Drawing.Size(580, 530)
        Me.cartBox.TabIndex = 7
        '
        'itemContainer
        '
        Me.itemContainer.AutoScroll = True
        Me.itemContainer.BackColor = System.Drawing.Color.White
        Me.itemContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemContainer.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.itemContainer.Location = New System.Drawing.Point(5, 55)
        Me.itemContainer.Margin = New System.Windows.Forms.Padding(5)
        Me.itemContainer.Name = "itemContainer"
        Me.itemContainer.Padding = New System.Windows.Forms.Padding(10, 10, 0, 5)
        Me.itemContainer.Size = New System.Drawing.Size(568, 468)
        Me.itemContainer.TabIndex = 33
        '
        'cartBoxTop
        '
        Me.cartBoxTop.Controls.Add(Me.Panel11)
        Me.cartBoxTop.Controls.Add(Me.Label7)
        Me.cartBoxTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.cartBoxTop.Location = New System.Drawing.Point(5, 5)
        Me.cartBoxTop.Name = "cartBoxTop"
        Me.cartBoxTop.Size = New System.Drawing.Size(568, 50)
        Me.cartBoxTop.TabIndex = 32
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnEdit)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(526, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(42, 50)
        Me.Panel11.TabIndex = 13
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_edit_20
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Red
        Me.btnEdit.Location = New System.Drawing.Point(5, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(32, 40)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label7.Size = New System.Drawing.Size(192, 50)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Products"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Label1.Size = New System.Drawing.Size(207, 58)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Your Cart"
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
        '_cartpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "_cartpage"
        Me.Text = "_cartpage"
        Me.windowWrapper.ResumeLayout(False)
        Me.cartWrapper.ResumeLayout(False)
        Me.cartSummary.ResumeLayout(False)
        Me.cartSummary.PerformLayout()
        Me.order_summary.ResumeLayout(False)
        Me.order_summary.PerformLayout()
        Me.totalCost.ResumeLayout(False)
        Me.totalCost.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cartContainer.ResumeLayout(False)
        Me.cartBox.ResumeLayout(False)
        Me.cartBoxTop.ResumeLayout(False)
        Me.cartBoxTop.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.titleIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents cartWrapper As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents titleIcon As PictureBox
    Friend WithEvents cartContainer As Panel
    Friend WithEvents cartSummary As Panel
    Friend WithEvents cartBox As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents itemContainer As Panel
    Friend WithEvents cartBoxTop As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents order_summary As Panel
    Friend WithEvents totalCost As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCheckOut As Button
End Class
