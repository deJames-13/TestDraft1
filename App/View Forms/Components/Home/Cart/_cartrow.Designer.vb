<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _cartrow
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
        Me.rowItem = New System.Windows.Forms.Panel()
        Me.itemBoxLeft = New System.Windows.Forms.Panel()
        Me.infoWrapper = New System.Windows.Forms.Panel()
        Me.infoBox = New System.Windows.Forms.Panel()
        Me.price = New System.Windows.Forms.Label()
        Me.item_name = New System.Windows.Forms.Label()
        Me.quantityPanel = New System.Windows.Forms.Panel()
        Me.quantWrapper = New System.Windows.Forms.Panel()
        Me.quantity = New System.Windows.Forms.Label()
        Me.addQuantWrapper = New System.Windows.Forms.Panel()
        Me.addQuant = New System.Windows.Forms.Button()
        Me.subQuantWrapper = New System.Windows.Forms.Panel()
        Me.subQuant = New System.Windows.Forms.Button()
        Me.itemImage = New System.Windows.Forms.PictureBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.itemBoxRight = New System.Windows.Forms.Panel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.rowItem.SuspendLayout()
        Me.itemBoxLeft.SuspendLayout()
        Me.infoWrapper.SuspendLayout()
        Me.infoBox.SuspendLayout()
        Me.quantityPanel.SuspendLayout()
        Me.quantWrapper.SuspendLayout()
        Me.addQuantWrapper.SuspendLayout()
        Me.subQuantWrapper.SuspendLayout()
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemBoxRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'rowItem
        '
        Me.rowItem.Controls.Add(Me.itemBoxLeft)
        Me.rowItem.Controls.Add(Me.itemBoxRight)
        Me.rowItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rowItem.Location = New System.Drawing.Point(0, 0)
        Me.rowItem.Name = "rowItem"
        Me.rowItem.Padding = New System.Windows.Forms.Padding(5)
        Me.rowItem.Size = New System.Drawing.Size(556, 100)
        Me.rowItem.TabIndex = 6
        '
        'itemBoxLeft
        '
        Me.itemBoxLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.itemBoxLeft.Controls.Add(Me.infoWrapper)
        Me.itemBoxLeft.Controls.Add(Me.itemImage)
        Me.itemBoxLeft.Controls.Add(Me.Panel25)
        Me.itemBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemBoxLeft.Location = New System.Drawing.Point(5, 5)
        Me.itemBoxLeft.Margin = New System.Windows.Forms.Padding(5)
        Me.itemBoxLeft.Name = "itemBoxLeft"
        Me.itemBoxLeft.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.itemBoxLeft.Size = New System.Drawing.Size(496, 90)
        Me.itemBoxLeft.TabIndex = 36
        '
        'infoWrapper
        '
        Me.infoWrapper.Controls.Add(Me.infoBox)
        Me.infoWrapper.Controls.Add(Me.quantityPanel)
        Me.infoWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoWrapper.Location = New System.Drawing.Point(100, 20)
        Me.infoWrapper.Name = "infoWrapper"
        Me.infoWrapper.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.infoWrapper.Size = New System.Drawing.Size(394, 65)
        Me.infoWrapper.TabIndex = 35
        '
        'infoBox
        '
        Me.infoBox.Controls.Add(Me.price)
        Me.infoBox.Controls.Add(Me.item_name)
        Me.infoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoBox.Location = New System.Drawing.Point(10, 5)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(221, 60)
        Me.infoBox.TabIndex = 57
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Dock = System.Windows.Forms.DockStyle.Top
        Me.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.price.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(0, 30)
        Me.price.Name = "price"
        Me.price.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.price.Size = New System.Drawing.Size(47, 24)
        Me.price.TabIndex = 10
        Me.price.Text = "9999"
        Me.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'item_name
        '
        Me.item_name.AutoSize = True
        Me.item_name.Dock = System.Windows.Forms.DockStyle.Top
        Me.item_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.item_name.Font = New System.Drawing.Font("Lexend", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_name.Location = New System.Drawing.Point(0, 0)
        Me.item_name.Name = "item_name"
        Me.item_name.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.item_name.Size = New System.Drawing.Size(114, 30)
        Me.item_name.TabIndex = 9
        Me.item_name.Text = "Item Name"
        Me.item_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'quantityPanel
        '
        Me.quantityPanel.BackColor = System.Drawing.Color.Transparent
        Me.quantityPanel.Controls.Add(Me.quantWrapper)
        Me.quantityPanel.Controls.Add(Me.addQuantWrapper)
        Me.quantityPanel.Controls.Add(Me.subQuantWrapper)
        Me.quantityPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.quantityPanel.Location = New System.Drawing.Point(231, 5)
        Me.quantityPanel.Margin = New System.Windows.Forms.Padding(5, 20, 5, 20)
        Me.quantityPanel.Name = "quantityPanel"
        Me.quantityPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.quantityPanel.Size = New System.Drawing.Size(163, 60)
        Me.quantityPanel.TabIndex = 56
        '
        'quantWrapper
        '
        Me.quantWrapper.Controls.Add(Me.quantity)
        Me.quantWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quantWrapper.Location = New System.Drawing.Point(45, 10)
        Me.quantWrapper.Margin = New System.Windows.Forms.Padding(10)
        Me.quantWrapper.Name = "quantWrapper"
        Me.quantWrapper.Padding = New System.Windows.Forms.Padding(3)
        Me.quantWrapper.Size = New System.Drawing.Size(73, 40)
        Me.quantWrapper.TabIndex = 25
        '
        'quantity
        '
        Me.quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quantity.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(3, 3)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(67, 34)
        Me.quantity.TabIndex = 0
        Me.quantity.Text = "1"
        Me.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addQuantWrapper
        '
        Me.addQuantWrapper.Controls.Add(Me.addQuant)
        Me.addQuantWrapper.Dock = System.Windows.Forms.DockStyle.Right
        Me.addQuantWrapper.Location = New System.Drawing.Point(118, 10)
        Me.addQuantWrapper.Name = "addQuantWrapper"
        Me.addQuantWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.addQuantWrapper.Size = New System.Drawing.Size(40, 40)
        Me.addQuantWrapper.TabIndex = 1
        '
        'addQuant
        '
        Me.addQuant.AutoSize = True
        Me.addQuant.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_add_new_96
        Me.addQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addQuant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.addQuant.FlatAppearance.BorderSize = 0
        Me.addQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addQuant.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.addQuant.Location = New System.Drawing.Point(5, 5)
        Me.addQuant.Name = "addQuant"
        Me.addQuant.Size = New System.Drawing.Size(30, 30)
        Me.addQuant.TabIndex = 2
        Me.addQuant.UseVisualStyleBackColor = True
        '
        'subQuantWrapper
        '
        Me.subQuantWrapper.Controls.Add(Me.subQuant)
        Me.subQuantWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.subQuantWrapper.Location = New System.Drawing.Point(5, 10)
        Me.subQuantWrapper.Name = "subQuantWrapper"
        Me.subQuantWrapper.Padding = New System.Windows.Forms.Padding(5)
        Me.subQuantWrapper.Size = New System.Drawing.Size(40, 40)
        Me.subQuantWrapper.TabIndex = 0
        '
        'subQuant
        '
        Me.subQuant.AutoSize = True
        Me.subQuant.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_indeterminate_checkbox_96
        Me.subQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.subQuant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.subQuant.FlatAppearance.BorderSize = 0
        Me.subQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subQuant.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.subQuant.Location = New System.Drawing.Point(5, 5)
        Me.subQuant.Name = "subQuant"
        Me.subQuant.Size = New System.Drawing.Size(30, 30)
        Me.subQuant.TabIndex = 2
        Me.subQuant.UseVisualStyleBackColor = True
        '
        'itemImage
        '
        Me.itemImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.itemImage.Image = Global.TestDraft1.My.Resources.Resources.icons8_no_image_30
        Me.itemImage.Location = New System.Drawing.Point(0, 20)
        Me.itemImage.Name = "itemImage"
        Me.itemImage.Size = New System.Drawing.Size(100, 65)
        Me.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.itemImage.TabIndex = 34
        Me.itemImage.TabStop = False
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.DimGray
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(0, 85)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(494, 3)
        Me.Panel25.TabIndex = 27
        '
        'itemBoxRight
        '
        Me.itemBoxRight.AutoSize = True
        Me.itemBoxRight.BackColor = System.Drawing.Color.Transparent
        Me.itemBoxRight.Controls.Add(Me.btnSelect)
        Me.itemBoxRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.itemBoxRight.Location = New System.Drawing.Point(501, 5)
        Me.itemBoxRight.Margin = New System.Windows.Forms.Padding(5)
        Me.itemBoxRight.Name = "itemBoxRight"
        Me.itemBoxRight.Padding = New System.Windows.Forms.Padding(5, 35, 5, 10)
        Me.itemBoxRight.Size = New System.Drawing.Size(50, 90)
        Me.itemBoxRight.TabIndex = 35
        '
        'btnSelect
        '
        Me.btnSelect.AutoSize = True
        Me.btnSelect.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_unchecked_checkbox_30
        Me.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ForeColor = System.Drawing.Color.Black
        Me.btnSelect.Location = New System.Drawing.Point(5, 35)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(40, 45)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        '_cartrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 100)
        Me.ControlBox = False
        Me.Controls.Add(Me.rowItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_cartrow"
        Me.Text = "_cartrow"
        Me.rowItem.ResumeLayout(False)
        Me.rowItem.PerformLayout()
        Me.itemBoxLeft.ResumeLayout(False)
        Me.infoWrapper.ResumeLayout(False)
        Me.infoBox.ResumeLayout(False)
        Me.infoBox.PerformLayout()
        Me.quantityPanel.ResumeLayout(False)
        Me.quantWrapper.ResumeLayout(False)
        Me.addQuantWrapper.ResumeLayout(False)
        Me.addQuantWrapper.PerformLayout()
        Me.subQuantWrapper.ResumeLayout(False)
        Me.subQuantWrapper.PerformLayout()
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemBoxRight.ResumeLayout(False)
        Me.itemBoxRight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rowItem As Panel
    Friend WithEvents itemBoxLeft As Panel
    Friend WithEvents infoWrapper As Panel
    Friend WithEvents quantityPanel As Panel
    Friend WithEvents quantWrapper As Panel
    Friend WithEvents quantity As Label
    Friend WithEvents addQuantWrapper As Panel
    Friend WithEvents addQuant As Button
    Friend WithEvents subQuantWrapper As Panel
    Friend WithEvents subQuant As Button
    Friend WithEvents itemImage As PictureBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents itemBoxRight As Panel
    Friend WithEvents btnSelect As Button
    Friend WithEvents infoBox As Panel
    Friend WithEvents price As Label
    Friend WithEvents item_name As Label
End Class
