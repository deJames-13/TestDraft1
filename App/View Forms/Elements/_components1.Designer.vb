<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _components1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_components1))
        Me.windowWrapper = New System.Windows.Forms.Panel()
        Me.lb_container = New System.Windows.Forms.Panel()
        Me.lb_cost = New System.Windows.Forms.Label()
        Me.lb_quantity = New System.Windows.Forms.Label()
        Me.lb_item_id = New System.Windows.Forms.Label()
        Me.rowItem = New System.Windows.Forms.Panel()
        Me.itemBoxLeft = New System.Windows.Forms.Panel()
        Me.infoWrapper = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.infoBox = New System.Windows.Forms.Panel()
        Me.price = New System.Windows.Forms.Label()
        Me.item_name = New System.Windows.Forms.Label()
        Me.quantityPanel = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.quantity = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.addQuantWrapper = New System.Windows.Forms.Button()
        Me.subQuantWrapper = New System.Windows.Forms.Panel()
        Me.subQuant = New System.Windows.Forms.Button()
        Me.itemImage = New System.Windows.Forms.PictureBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.itemBoxRight = New System.Windows.Forms.Panel()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.itemWrapper = New System.Windows.Forms.Panel()
        Me.itemBox = New System.Windows.Forms.Panel()
        Me.btnWrapper = New System.Windows.Forms.Panel()
        Me.quantPanel = New System.Windows.Forms.Panel()
        Me.itemQuant = New System.Windows.Forms.Label()
        Me.btnAddQuant = New System.Windows.Forms.Button()
        Me.btnSubQuant = New System.Windows.Forms.Button()
        Me.addToCart = New System.Windows.Forms.Button()
        Me.infoPanel = New System.Windows.Forms.Panel()
        Me.itemLoc = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.Label()
        Me.itemPrice = New System.Windows.Forms.Label()
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.lb_container.SuspendLayout()
        Me.rowItem.SuspendLayout()
        Me.itemBoxLeft.SuspendLayout()
        Me.infoWrapper.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.infoBox.SuspendLayout()
        Me.quantityPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.subQuantWrapper.SuspendLayout()
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.itemBoxRight.SuspendLayout()
        Me.itemWrapper.SuspendLayout()
        Me.itemBox.SuspendLayout()
        Me.btnWrapper.SuspendLayout()
        Me.quantPanel.SuspendLayout()
        Me.infoPanel.SuspendLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.lb_container)
        Me.windowWrapper.Controls.Add(Me.rowItem)
        Me.windowWrapper.Controls.Add(Me.itemWrapper)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 6
        '
        'lb_container
        '
        Me.lb_container.Controls.Add(Me.lb_cost)
        Me.lb_container.Controls.Add(Me.lb_quantity)
        Me.lb_container.Controls.Add(Me.lb_item_id)
        Me.lb_container.Location = New System.Drawing.Point(635, 55)
        Me.lb_container.Margin = New System.Windows.Forms.Padding(5)
        Me.lb_container.Name = "lb_container"
        Me.lb_container.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.lb_container.Size = New System.Drawing.Size(304, 61)
        Me.lb_container.TabIndex = 33
        '
        'lb_cost
        '
        Me.lb_cost.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_cost.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_cost.Location = New System.Drawing.Point(201, 23)
        Me.lb_cost.Name = "lb_cost"
        Me.lb_cost.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_cost.Size = New System.Drawing.Size(100, 35)
        Me.lb_cost.TabIndex = 2
        Me.lb_cost.Tag = ""
        Me.lb_cost.Text = "Cost:"
        Me.lb_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_quantity
        '
        Me.lb_quantity.Dock = System.Windows.Forms.DockStyle.Left
        Me.lb_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_quantity.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_quantity.Location = New System.Drawing.Point(98, 23)
        Me.lb_quantity.Name = "lb_quantity"
        Me.lb_quantity.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_quantity.Size = New System.Drawing.Size(100, 35)
        Me.lb_quantity.TabIndex = 1
        Me.lb_quantity.Tag = ""
        Me.lb_quantity.Text = "Quantity: "
        Me.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_item_id
        '
        Me.lb_item_id.Dock = System.Windows.Forms.DockStyle.Left
        Me.lb_item_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_item_id.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_item_id.Location = New System.Drawing.Point(3, 23)
        Me.lb_item_id.Name = "lb_item_id"
        Me.lb_item_id.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_item_id.Size = New System.Drawing.Size(95, 35)
        Me.lb_item_id.TabIndex = 0
        Me.lb_item_id.Text = "Item ID: "
        Me.lb_item_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rowItem
        '
        Me.rowItem.Controls.Add(Me.itemBoxLeft)
        Me.rowItem.Controls.Add(Me.itemBoxRight)
        Me.rowItem.Location = New System.Drawing.Point(9, 265)
        Me.rowItem.Name = "rowItem"
        Me.rowItem.Padding = New System.Windows.Forms.Padding(5)
        Me.rowItem.Size = New System.Drawing.Size(556, 100)
        Me.rowItem.TabIndex = 5
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
        Me.infoWrapper.Controls.Add(Me.Panel5)
        Me.infoWrapper.Controls.Add(Me.quantityPanel)
        Me.infoWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoWrapper.Location = New System.Drawing.Point(100, 20)
        Me.infoWrapper.Name = "infoWrapper"
        Me.infoWrapper.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.infoWrapper.Size = New System.Drawing.Size(394, 65)
        Me.infoWrapper.TabIndex = 35
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.infoBox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(10, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.Panel5.Size = New System.Drawing.Size(221, 60)
        Me.Panel5.TabIndex = 57
        '
        'infoBox
        '
        Me.infoBox.Controls.Add(Me.price)
        Me.infoBox.Controls.Add(Me.item_name)
        Me.infoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoBox.Location = New System.Drawing.Point(10, 5)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(211, 55)
        Me.infoBox.TabIndex = 56
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
        Me.quantityPanel.Controls.Add(Me.Panel6)
        Me.quantityPanel.Controls.Add(Me.Panel8)
        Me.quantityPanel.Controls.Add(Me.subQuantWrapper)
        Me.quantityPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.quantityPanel.Location = New System.Drawing.Point(231, 5)
        Me.quantityPanel.Margin = New System.Windows.Forms.Padding(5, 20, 5, 20)
        Me.quantityPanel.Name = "quantityPanel"
        Me.quantityPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        Me.quantityPanel.Size = New System.Drawing.Size(163, 60)
        Me.quantityPanel.TabIndex = 56
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.quantity)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(45, 10)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel6.Size = New System.Drawing.Size(73, 40)
        Me.Panel6.TabIndex = 25
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
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.addQuantWrapper)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(118, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(40, 40)
        Me.Panel8.TabIndex = 1
        '
        'addQuantWrapper
        '
        Me.addQuantWrapper.AutoSize = True
        Me.addQuantWrapper.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_add_new_96
        Me.addQuantWrapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addQuantWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addQuantWrapper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.addQuantWrapper.FlatAppearance.BorderSize = 0
        Me.addQuantWrapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addQuantWrapper.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.addQuantWrapper.Location = New System.Drawing.Point(5, 5)
        Me.addQuantWrapper.Name = "addQuantWrapper"
        Me.addQuantWrapper.Size = New System.Drawing.Size(30, 30)
        Me.addQuantWrapper.TabIndex = 2
        Me.addQuantWrapper.UseVisualStyleBackColor = True
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
        'itemWrapper
        '
        Me.itemWrapper.Controls.Add(Me.itemBox)
        Me.itemWrapper.Controls.Add(Me.Panel2)
        Me.itemWrapper.Location = New System.Drawing.Point(9, 9)
        Me.itemWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.itemWrapper.Name = "itemWrapper"
        Me.itemWrapper.Padding = New System.Windows.Forms.Padding(35, 35, 0, 0)
        Me.itemWrapper.Size = New System.Drawing.Size(235, 235)
        Me.itemWrapper.TabIndex = 3
        '
        'itemBox
        '
        Me.itemBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.itemBox.Controls.Add(Me.btnWrapper)
        Me.itemBox.Controls.Add(Me.infoPanel)
        Me.itemBox.Controls.Add(Me.imgBox)
        Me.itemBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemBox.Location = New System.Drawing.Point(35, 35)
        Me.itemBox.Margin = New System.Windows.Forms.Padding(0)
        Me.itemBox.Name = "itemBox"
        Me.itemBox.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.itemBox.Size = New System.Drawing.Size(200, 197)
        Me.itemBox.TabIndex = 29
        '
        'btnWrapper
        '
        Me.btnWrapper.Controls.Add(Me.quantPanel)
        Me.btnWrapper.Controls.Add(Me.addToCart)
        Me.btnWrapper.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnWrapper.Location = New System.Drawing.Point(130, 115)
        Me.btnWrapper.Name = "btnWrapper"
        Me.btnWrapper.Size = New System.Drawing.Size(60, 67)
        Me.btnWrapper.TabIndex = 5
        '
        'quantPanel
        '
        Me.quantPanel.Controls.Add(Me.itemQuant)
        Me.quantPanel.Controls.Add(Me.btnAddQuant)
        Me.quantPanel.Controls.Add(Me.btnSubQuant)
        Me.quantPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quantPanel.Location = New System.Drawing.Point(0, 0)
        Me.quantPanel.Name = "quantPanel"
        Me.quantPanel.Padding = New System.Windows.Forms.Padding(1, 22, 1, 3)
        Me.quantPanel.Size = New System.Drawing.Size(60, 37)
        Me.quantPanel.TabIndex = 3
        '
        'itemQuant
        '
        Me.itemQuant.BackColor = System.Drawing.Color.Transparent
        Me.itemQuant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemQuant.Font = New System.Drawing.Font("Lexend Medium", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemQuant.Location = New System.Drawing.Point(11, 22)
        Me.itemQuant.Name = "itemQuant"
        Me.itemQuant.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemQuant.Size = New System.Drawing.Size(38, 12)
        Me.itemQuant.TabIndex = 6
        Me.itemQuant.Text = "1"
        Me.itemQuant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddQuant
        '
        Me.btnAddQuant.BackColor = System.Drawing.Color.Transparent
        Me.btnAddQuant.BackgroundImage = CType(resources.GetObject("btnAddQuant.BackgroundImage"), System.Drawing.Image)
        Me.btnAddQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddQuant.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddQuant.FlatAppearance.BorderSize = 0
        Me.btnAddQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuant.Location = New System.Drawing.Point(49, 22)
        Me.btnAddQuant.Name = "btnAddQuant"
        Me.btnAddQuant.Size = New System.Drawing.Size(10, 12)
        Me.btnAddQuant.TabIndex = 5
        Me.btnAddQuant.UseVisualStyleBackColor = False
        '
        'btnSubQuant
        '
        Me.btnSubQuant.BackColor = System.Drawing.Color.Transparent
        Me.btnSubQuant.BackgroundImage = CType(resources.GetObject("btnSubQuant.BackgroundImage"), System.Drawing.Image)
        Me.btnSubQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSubQuant.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSubQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSubQuant.FlatAppearance.BorderSize = 0
        Me.btnSubQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubQuant.Location = New System.Drawing.Point(1, 22)
        Me.btnSubQuant.Name = "btnSubQuant"
        Me.btnSubQuant.Size = New System.Drawing.Size(10, 12)
        Me.btnSubQuant.TabIndex = 4
        Me.btnSubQuant.UseVisualStyleBackColor = False
        '
        'addToCart
        '
        Me.addToCart.BackgroundImage = CType(resources.GetObject("addToCart.BackgroundImage"), System.Drawing.Image)
        Me.addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.addToCart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.addToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addToCart.Location = New System.Drawing.Point(0, 37)
        Me.addToCart.Name = "addToCart"
        Me.addToCart.Size = New System.Drawing.Size(60, 30)
        Me.addToCart.TabIndex = 2
        Me.addToCart.UseVisualStyleBackColor = True
        '
        'infoPanel
        '
        Me.infoPanel.Controls.Add(Me.itemLoc)
        Me.infoPanel.Controls.Add(Me.itemName)
        Me.infoPanel.Controls.Add(Me.itemPrice)
        Me.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infoPanel.Location = New System.Drawing.Point(10, 115)
        Me.infoPanel.Name = "infoPanel"
        Me.infoPanel.Padding = New System.Windows.Forms.Padding(2, 5, 2, 2)
        Me.infoPanel.Size = New System.Drawing.Size(180, 67)
        Me.infoPanel.TabIndex = 4
        '
        'itemLoc
        '
        Me.itemLoc.AutoSize = True
        Me.itemLoc.BackColor = System.Drawing.Color.Transparent
        Me.itemLoc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.itemLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemLoc.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemLoc.Location = New System.Drawing.Point(2, 52)
        Me.itemLoc.Name = "itemLoc"
        Me.itemLoc.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemLoc.Size = New System.Drawing.Size(92, 13)
        Me.itemLoc.TabIndex = 4
        Me.itemLoc.Text = "Alabama, USA"
        Me.itemLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemName
        '
        Me.itemName.AutoSize = True
        Me.itemName.BackColor = System.Drawing.Color.Transparent
        Me.itemName.Dock = System.Windows.Forms.DockStyle.Top
        Me.itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemName.Location = New System.Drawing.Point(2, 30)
        Me.itemName.Name = "itemName"
        Me.itemName.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.itemName.Size = New System.Drawing.Size(62, 14)
        Me.itemName.TabIndex = 3
        Me.itemName.Text = "Earpods"
        Me.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemPrice
        '
        Me.itemPrice.AutoSize = True
        Me.itemPrice.BackColor = System.Drawing.Color.Transparent
        Me.itemPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.itemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemPrice.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPrice.Location = New System.Drawing.Point(2, 5)
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.Size = New System.Drawing.Size(58, 25)
        Me.itemPrice.TabIndex = 2
        Me.itemPrice.Text = "$6969"
        Me.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgBox
        '
        Me.imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.imgBox.Location = New System.Drawing.Point(10, 15)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(180, 100)
        Me.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBox.TabIndex = 3
        Me.imgBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(35, 232)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 3)
        Me.Panel2.TabIndex = 28
        '
        '_components1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_components1"
        Me.Text = "_components1"
        Me.windowWrapper.ResumeLayout(False)
        Me.lb_container.ResumeLayout(False)
        Me.rowItem.ResumeLayout(False)
        Me.rowItem.PerformLayout()
        Me.itemBoxLeft.ResumeLayout(False)
        Me.infoWrapper.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.infoBox.ResumeLayout(False)
        Me.infoBox.PerformLayout()
        Me.quantityPanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.subQuantWrapper.ResumeLayout(False)
        Me.subQuantWrapper.PerformLayout()
        CType(Me.itemImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.itemBoxRight.ResumeLayout(False)
        Me.itemBoxRight.PerformLayout()
        Me.itemWrapper.ResumeLayout(False)
        Me.itemBox.ResumeLayout(False)
        Me.btnWrapper.ResumeLayout(False)
        Me.quantPanel.ResumeLayout(False)
        Me.infoPanel.ResumeLayout(False)
        Me.infoPanel.PerformLayout()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents itemWrapper As Panel
    Friend WithEvents rowItem As Panel
    Friend WithEvents itemBox As Panel
    Friend WithEvents btnWrapper As Panel
    Friend WithEvents quantPanel As Panel
    Friend WithEvents itemQuant As Label
    Friend WithEvents btnAddQuant As Button
    Friend WithEvents btnSubQuant As Button
    Friend WithEvents addToCart As Button
    Friend WithEvents infoPanel As Panel
    Friend WithEvents itemLoc As Label
    Friend WithEvents itemName As Label
    Friend WithEvents itemPrice As Label
    Friend WithEvents imgBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents itemBoxRight As Panel
    Friend WithEvents btnSelect As Button
    Friend WithEvents itemBoxLeft As Panel
    Friend WithEvents infoWrapper As Panel
    Friend WithEvents itemImage As PictureBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents infoBox As Panel
    Friend WithEvents price As Label
    Friend WithEvents item_name As Label
    Friend WithEvents quantityPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents quantity As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents addQuantWrapper As Button
    Friend WithEvents subQuantWrapper As Panel
    Friend WithEvents subQuant As Button
    Friend WithEvents lb_container As Panel
    Friend WithEvents lb_cost As Label
    Friend WithEvents lb_quantity As Label
    Friend WithEvents lb_item_id As Label
End Class
