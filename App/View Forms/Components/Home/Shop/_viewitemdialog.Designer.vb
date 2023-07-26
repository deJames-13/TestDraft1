<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _viewitemdialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_viewitemdialog))
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.viewBox = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.viewContents = New System.Windows.Forms.Panel()
        Me.leftSection = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.tags_specification = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.labelQuantity_wrapper = New System.Windows.Forms.Panel()
        Me.stock_quantity = New System.Windows.Forms.Label()
        Me.labelPrice_wrapper = New System.Windows.Forms.Panel()
        Me.price = New System.Windows.Forms.Label()
        Me.labelName_wrapper = New System.Windows.Forms.Panel()
        Me.item_name = New System.Windows.Forms.Label()
        Me.lineVertical1 = New System.Windows.Forms.Panel()
        Me.rightSection = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.quantity = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.addQuant = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.subQuant = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOrderNow = New System.Windows.Forms.Button()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.imageBox = New System.Windows.Forms.Panel()
        Me.itemImage = New System.Windows.Forms.PictureBox()
        Me.windowTitle = New System.Windows.Forms.Label()
        Me.windowWrapper.SuspendLayout()
        Me.viewBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.viewContents.SuspendLayout()
        Me.leftSection.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.labelQuantity_wrapper.SuspendLayout()
        Me.labelPrice_wrapper.SuspendLayout()
        Me.labelName_wrapper.SuspendLayout()
        Me.rightSection.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.imageBox.SuspendLayout()
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.viewBox)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Size = New System.Drawing.Size(600, 400)
        Me.windowWrapper.TabIndex = 6
        '
        'viewBox
        '
        Me.viewBox.BackColor = System.Drawing.Color.Transparent
        Me.viewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewBox.Controls.Add(Me.Panel2)
        Me.viewBox.Controls.Add(Me.viewContents)
        Me.viewBox.Controls.Add(Me.windowTitle)
        Me.viewBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewBox.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.viewBox.Location = New System.Drawing.Point(0, 0)
        Me.viewBox.Margin = New System.Windows.Forms.Padding(5)
        Me.viewBox.Name = "viewBox"
        Me.viewBox.Padding = New System.Windows.Forms.Padding(5)
        Me.viewBox.Size = New System.Drawing.Size(600, 400)
        Me.viewBox.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Location = New System.Drawing.Point(568, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(30, 30)
        Me.Panel2.TabIndex = 52
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnClose.Location = New System.Drawing.Point(5, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'viewContents
        '
        Me.viewContents.BackColor = System.Drawing.Color.Transparent
        Me.viewContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewContents.Controls.Add(Me.leftSection)
        Me.viewContents.Controls.Add(Me.lineVertical1)
        Me.viewContents.Controls.Add(Me.rightSection)
        Me.viewContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.viewContents.Location = New System.Drawing.Point(5, 35)
        Me.viewContents.Margin = New System.Windows.Forms.Padding(5)
        Me.viewContents.Name = "viewContents"
        Me.viewContents.Padding = New System.Windows.Forms.Padding(5)
        Me.viewContents.Size = New System.Drawing.Size(588, 358)
        Me.viewContents.TabIndex = 4
        '
        'leftSection
        '
        Me.leftSection.Controls.Add(Me.Panel18)
        Me.leftSection.Controls.Add(Me.Panel24)
        Me.leftSection.Controls.Add(Me.labelQuantity_wrapper)
        Me.leftSection.Controls.Add(Me.labelPrice_wrapper)
        Me.leftSection.Controls.Add(Me.labelName_wrapper)
        Me.leftSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leftSection.Location = New System.Drawing.Point(217, 5)
        Me.leftSection.Name = "leftSection"
        Me.leftSection.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.leftSection.Size = New System.Drawing.Size(364, 346)
        Me.leftSection.TabIndex = 29
        '
        'Panel18
        '
        Me.Panel18.AutoSize = True
        Me.Panel18.BackColor = System.Drawing.Color.Transparent
        Me.Panel18.Controls.Add(Me.btnAddToCart)
        Me.Panel18.Location = New System.Drawing.Point(229, 302)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel18.Size = New System.Drawing.Size(130, 39)
        Me.Panel18.TabIndex = 50
        '
        'btnAddToCart
        '
        Me.btnAddToCart.AutoSize = True
        Me.btnAddToCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnAddToCart.Location = New System.Drawing.Point(5, 5)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(120, 29)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.tags_specification)
        Me.Panel24.Controls.Add(Me.Label17)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(15, 138)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Padding = New System.Windows.Forms.Padding(5, 23, 5, 5)
        Me.Panel24.Size = New System.Drawing.Size(344, 136)
        Me.Panel24.TabIndex = 49
        '
        'tags_specification
        '
        Me.tags_specification.BackColor = System.Drawing.Color.GhostWhite
        Me.tags_specification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tags_specification.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tags_specification.Enabled = False
        Me.tags_specification.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tags_specification.Location = New System.Drawing.Point(5, 47)
        Me.tags_specification.Multiline = True
        Me.tags_specification.Name = "tags_specification"
        Me.tags_specification.Size = New System.Drawing.Size(334, 84)
        Me.tags_specification.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Lexend Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New System.Windows.Forms.Padding(0, 5, 25, 0)
        Me.Label17.Size = New System.Drawing.Size(97, 24)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Description"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelQuantity_wrapper
        '
        Me.labelQuantity_wrapper.AutoSize = True
        Me.labelQuantity_wrapper.Controls.Add(Me.stock_quantity)
        Me.labelQuantity_wrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelQuantity_wrapper.Location = New System.Drawing.Point(15, 99)
        Me.labelQuantity_wrapper.Margin = New System.Windows.Forms.Padding(5)
        Me.labelQuantity_wrapper.Name = "labelQuantity_wrapper"
        Me.labelQuantity_wrapper.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.labelQuantity_wrapper.Size = New System.Drawing.Size(344, 39)
        Me.labelQuantity_wrapper.TabIndex = 36
        '
        'stock_quantity
        '
        Me.stock_quantity.AutoSize = True
        Me.stock_quantity.Dock = System.Windows.Forms.DockStyle.Top
        Me.stock_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stock_quantity.Font = New System.Drawing.Font("Lexend Light", 9.0!)
        Me.stock_quantity.Location = New System.Drawing.Point(5, 10)
        Me.stock_quantity.Name = "stock_quantity"
        Me.stock_quantity.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.stock_quantity.Size = New System.Drawing.Size(103, 24)
        Me.stock_quantity.TabIndex = 0
        Me.stock_quantity.Text = "Stock Available: "
        Me.stock_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelPrice_wrapper
        '
        Me.labelPrice_wrapper.AutoSize = True
        Me.labelPrice_wrapper.Controls.Add(Me.price)
        Me.labelPrice_wrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelPrice_wrapper.Location = New System.Drawing.Point(15, 54)
        Me.labelPrice_wrapper.Margin = New System.Windows.Forms.Padding(5)
        Me.labelPrice_wrapper.Name = "labelPrice_wrapper"
        Me.labelPrice_wrapper.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.labelPrice_wrapper.Size = New System.Drawing.Size(344, 45)
        Me.labelPrice_wrapper.TabIndex = 35
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Dock = System.Windows.Forms.DockStyle.Top
        Me.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.price.Font = New System.Drawing.Font("Lexend Medium", 12.0!)
        Me.price.Location = New System.Drawing.Point(5, 10)
        Me.price.Name = "price"
        Me.price.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.price.Size = New System.Drawing.Size(100, 30)
        Me.price.TabIndex = 0
        Me.price.Text = "Item Price"
        Me.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelName_wrapper
        '
        Me.labelName_wrapper.AutoScroll = True
        Me.labelName_wrapper.AutoSize = True
        Me.labelName_wrapper.Controls.Add(Me.item_name)
        Me.labelName_wrapper.Dock = System.Windows.Forms.DockStyle.Top
        Me.labelName_wrapper.Location = New System.Drawing.Point(15, 5)
        Me.labelName_wrapper.Margin = New System.Windows.Forms.Padding(5)
        Me.labelName_wrapper.Name = "labelName_wrapper"
        Me.labelName_wrapper.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.labelName_wrapper.Size = New System.Drawing.Size(344, 49)
        Me.labelName_wrapper.TabIndex = 34
        '
        'item_name
        '
        Me.item_name.AutoSize = True
        Me.item_name.Dock = System.Windows.Forms.DockStyle.Top
        Me.item_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.item_name.Font = New System.Drawing.Font("Lexend Medium", 13.0!)
        Me.item_name.Location = New System.Drawing.Point(5, 10)
        Me.item_name.Name = "item_name"
        Me.item_name.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.item_name.Size = New System.Drawing.Size(121, 34)
        Me.item_name.TabIndex = 0
        Me.item_name.Text = "Item Name"
        Me.item_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lineVertical1
        '
        Me.lineVertical1.BackColor = System.Drawing.Color.DimGray
        Me.lineVertical1.Dock = System.Windows.Forms.DockStyle.Left
        Me.lineVertical1.Location = New System.Drawing.Point(215, 5)
        Me.lineVertical1.Margin = New System.Windows.Forms.Padding(5)
        Me.lineVertical1.Name = "lineVertical1"
        Me.lineVertical1.Size = New System.Drawing.Size(2, 346)
        Me.lineVertical1.TabIndex = 28
        '
        'rightSection
        '
        Me.rightSection.Controls.Add(Me.Panel3)
        Me.rightSection.Controls.Add(Me.Panel1)
        Me.rightSection.Controls.Add(Me.Panel25)
        Me.rightSection.Controls.Add(Me.imageBox)
        Me.rightSection.Dock = System.Windows.Forms.DockStyle.Left
        Me.rightSection.Location = New System.Drawing.Point(5, 5)
        Me.rightSection.Margin = New System.Windows.Forms.Padding(0)
        Me.rightSection.Name = "rightSection"
        Me.rightSection.Padding = New System.Windows.Forms.Padding(5, 5, 15, 5)
        Me.rightSection.Size = New System.Drawing.Size(210, 346)
        Me.rightSection.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 207)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 20, 5, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.Panel3.Size = New System.Drawing.Size(190, 60)
        Me.Panel3.TabIndex = 53
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.quantity)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(45, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel6.Size = New System.Drawing.Size(100, 40)
        Me.Panel6.TabIndex = 25
        '
        'quantity
        '
        Me.quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quantity.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(3, 3)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(94, 34)
        Me.quantity.TabIndex = 0
        Me.quantity.Text = "1"
        Me.quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.addQuant)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(145, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(40, 40)
        Me.Panel5.TabIndex = 1
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.subQuant)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(5, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(40, 40)
        Me.Panel4.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnOrderNow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(5, 302)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(190, 39)
        Me.Panel1.TabIndex = 52
        '
        'btnOrderNow
        '
        Me.btnOrderNow.AutoSize = True
        Me.btnOrderNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOrderNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderNow.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.btnOrderNow.Location = New System.Drawing.Point(5, 5)
        Me.btnOrderNow.Name = "btnOrderNow"
        Me.btnOrderNow.Size = New System.Drawing.Size(180, 29)
        Me.btnOrderNow.TabIndex = 1
        Me.btnOrderNow.Text = "Order Now"
        Me.btnOrderNow.UseVisualStyleBackColor = True
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.DimGray
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(5, 205)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(190, 2)
        Me.Panel25.TabIndex = 54
        '
        'imageBox
        '
        Me.imageBox.BackColor = System.Drawing.Color.Transparent
        Me.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox.Controls.Add(Me.itemImage)
        Me.imageBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.imageBox.Location = New System.Drawing.Point(5, 5)
        Me.imageBox.Margin = New System.Windows.Forms.Padding(5)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Padding = New System.Windows.Forms.Padding(5)
        Me.imageBox.Size = New System.Drawing.Size(190, 200)
        Me.imageBox.TabIndex = 28
        '
        'itemImage
        '
        Me.itemImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemImage.Location = New System.Drawing.Point(5, 5)
        Me.itemImage.Name = "itemImage"
        Me.itemImage.Size = New System.Drawing.Size(178, 188)
        Me.itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.itemImage.TabIndex = 0
        Me.itemImage.TabStop = False
        '
        'windowTitle
        '
        Me.windowTitle.AutoSize = True
        Me.windowTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.windowTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.windowTitle.Font = New System.Drawing.Font("Lexend SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowTitle.Location = New System.Drawing.Point(5, 5)
        Me.windowTitle.Name = "windowTitle"
        Me.windowTitle.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.windowTitle.Size = New System.Drawing.Size(133, 30)
        Me.windowTitle.TabIndex = 3
        Me.windowTitle.Text = "Item Code: 01"
        Me.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_viewitemdialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "_viewitemdialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Item"
        Me.windowWrapper.ResumeLayout(False)
        Me.viewBox.ResumeLayout(False)
        Me.viewBox.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.viewContents.ResumeLayout(False)
        Me.leftSection.ResumeLayout(False)
        Me.leftSection.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.labelQuantity_wrapper.ResumeLayout(False)
        Me.labelQuantity_wrapper.PerformLayout()
        Me.labelPrice_wrapper.ResumeLayout(False)
        Me.labelPrice_wrapper.PerformLayout()
        Me.labelName_wrapper.ResumeLayout(False)
        Me.labelName_wrapper.PerformLayout()
        Me.rightSection.ResumeLayout(False)
        Me.rightSection.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.imageBox.ResumeLayout(False)
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents viewBox As Panel
    Friend WithEvents viewContents As Panel
    Friend WithEvents leftSection As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Panel24 As Panel
    Friend WithEvents tags_specification As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents labelQuantity_wrapper As Panel
    Friend WithEvents stock_quantity As Label
    Friend WithEvents labelPrice_wrapper As Panel
    Friend WithEvents price As Label
    Friend WithEvents labelName_wrapper As Panel
    Friend WithEvents lineVertical1 As Panel
    Friend WithEvents rightSection As Panel
    Friend WithEvents imageBox As Panel
    Friend WithEvents itemImage As PictureBox
    Friend WithEvents windowTitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOrderNow As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents quantity As Label
    Friend WithEvents addQuant As Button
    Friend WithEvents subQuant As Button
    Friend WithEvents Panel25 As Panel
    Friend WithEvents item_name As Label
End Class
