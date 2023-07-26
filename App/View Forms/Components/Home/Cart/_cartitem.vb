Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Cart

    Public WithEvents rowItem As Panel
    Public WithEvents btnSelect As New Button
    Private WithEvents itemBoxRight As New Panel
    Private WithEvents itemBoxLeft As New Panel
    Private WithEvents infoWrapper As New Panel
    Private WithEvents quantityPanel As New Panel
    Private WithEvents quantWrapper As New Panel
    Private WithEvents quantity As New Label
    Private WithEvents addQuantWrapper As New Panel
    Private WithEvents addQuant As New Button
    Private WithEvents subQuantWrapper As New Panel
    Private WithEvents subQuant As New Button
    Private WithEvents infoBox As New Panel
    Private WithEvents price As New Label
    Private WithEvents item_name As New Label
    Private WithEvents itemImage As New PictureBox
    Private WithEvents bottomLine As New Panel

    Private lb_container As Panel
    Private lb_cost As New Label
    Private lb_quantity As New Label
    Private lb_item_id As New Label

    Private id As Integer = 0
    Private new_item As Panel
    Private index As string
    Private parent As New Control
    Private cart_item As DataRow

    Public Sub New(ByRef parent As Control, i As Integer, source As DataRow)
        If source Is Nothing Then Return

        If source.Table.Columns.Contains("order_id") Then
            index = $"order_{source("order_id")}"
            id = source("order_id")
        ElseIf source.Table.Columns.Contains("cart_id") Then
            index = $"cart_{source("cart_id")}"
            id = source("cart_id")
        End If

        Me.parent = parent
        cart_item = source
    End Sub

    '###########################################################################
    ' CART CONTROLS
    '###########################################################################
    Public Sub SetProperties()

        item_name.Text = cart_item("item_name")
        price.Text = cart_item("price")
        quantity.Text = cart_item("quantity")

        Try
            itemImage.Image = Image.FromFile(cart_item("image_dir"))
        Catch ex As Exception

        End Try
        itemImage.SizeMode = ImageLayout.Zoom

    End Sub

    Public Sub MakeCartItem()
        new_item = New Panel
        new_item = CartItem()
        parent.Controls.Add(new_item)
        parent.Controls.SetChildIndex(new_item, parent.Controls.Count)
    End Sub

    Public Sub SetOrderProperties()
        item_name.Text = $"Item:     {cart_item("item_name")} x{cart_item("quantity")}"
        price.Text = $"Price:     {cart_item("price")}    Total Cost: {cart_item("cost")}    "
        price.Text &= $"Shipping Type:     {cart_item("shipping_type")}    Fee: {cart_item("shipping_fee")}"



        btnSelect.Hide()
        quantityPanel.Enabled = False
        quantityPanel.Hide()
    End Sub

    '###########################################################################
    ' CART AND ORDER CONTROLLER
    '###########################################################################
    Private Sub btnSelect_Clicked(sender As Object, e As EventArgs)
        Dim p As Control = sender.parent.parent
        Dim item As Dictionary(Of String, Object) = DataRowToDictionary(cart_item)
        item("id") = id
        item("quantity") = quantity.Text


        Select Case btnSelect.ForeColor

            Case Color.LightCoral

                cartButtons.Remove(rowItem.Name)

                MakeTransactions(item, "delete_order")

                p.Dispose()

            Case Color.Yellow

                cartButtons.Remove(rowItem.Name)

                MakeTransactions(item, "delete_cart")

                p.Dispose()

                RemoveItemSummary()

            Case Color.Black

                btnSelect.BackgroundImage = My.Resources.icons8_checked_checkbox_30
                btnSelect.ForeColor = Color.Red
                MakeItemSummary(_cartpage.order_summary)
                SetCost(1)

                MakeTransactions(item, "insert_order")


            Case Color.Red

                SetCost(0)

                btnSelect.BackgroundImage = My.Resources.icons8_unchecked_checkbox_30
                btnSelect.ForeColor = Color.Black
                RemoveItemSummary()

                transactionQuery.Remove(id)
        End Select

    End Sub

    Private Sub cartQuantity(sender As Object, e As EventArgs)
        Dim btn As Button = sender

        Dim quantity As Label = btn.Parent.Parent.Controls(0).Controls(0)

        Select Case btn.Name
            Case "addQuant_" & index
                quantity.Text += 1


            Case "subQuant_" & index
                If quantity.Text > 1 Then
                    quantity.Text -= 1
                End If
        End Select

    End Sub



    '###########################################################################
    ' CART ITEM SUMMARY
    '###########################################################################

    Private Sub SetCost(op As Boolean)
        Try
            Dim summary As Panel = summaries(lb_container.Name)
            Dim cost As Decimal = summary.Controls("lb_cost_" & index).Text.Replace("Cost: ₱", "")
            Dim total_cost As TextBox = summary.Parent.Controls("totalCost").Controls("txtTotal")

            If op Then
                total_cost.Text = Val(total_cost.Text) + cost
            Else
                total_cost.Text = Val(total_cost.Text) - cost
            End If
        Catch nune As Exception

        End Try

    End Sub


    Public Sub RemoveItemSummary()
        Try
            Dim parent As Control = summaries("lb_container_" & index).Parent
            If parent Is Nothing Then Return
            parent.Controls.Remove(summaries("lb_container_" & index))
        Catch ex As KeyNotFoundException

        End Try
    End Sub


    Public Sub MakeItemSummary(parent As Control)

        new_item = New Panel
        new_item = ItemSummary()

        parent.Controls.Add(new_item)
        parent.Controls.SetChildIndex(new_item, 0)

        Me.lb_item_id.Text = "Item ID: " & cart_item("product_id")
        Me.lb_quantity.Text = "Quantity: " & cart_item("quantity")
        Me.lb_cost.Text = "Cost: ₱" & cart_item("cost_per_item")

        Me.lb_container.Name = "lb_container_" & index
        Me.lb_cost.Name = "lb_cost_" & index
        Me.lb_quantity.Name = "lb_quantity_" & index
        Me.lb_item_id.Name = "lb_item_id_" & index

        summaries(lb_container.Name) = lb_container
    End Sub


    '###########################################################################
    ' CONTROLS
    '###########################################################################

    Public Function ItemSummary() As Panel
        lb_container = New Panel
        '
        'lb_container
        '
        Me.lb_container.Dock = System.Windows.Forms.DockStyle.Top
        Me.lb_container.Location = New System.Drawing.Point(0, 0)
        Me.lb_container.Margin = New System.Windows.Forms.Padding(5)
        Me.lb_container.Padding = New System.Windows.Forms.Padding(3, 23, 3, 3)
        Me.lb_container.Size = New System.Drawing.Size(304, 61)
        Me.lb_container.TabIndex = 32
        '
        'lb_cost
        '
        Me.lb_cost.Dock = System.Windows.Forms.DockStyle.Right
        Me.lb_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_cost.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_cost.Location = New System.Drawing.Point(201, 23)
        Me.lb_cost.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_cost.Size = New System.Drawing.Size(100, 35)
        Me.lb_cost.TabIndex = 2
        Me.lb_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_quantity
        '
        Me.lb_quantity.Dock = System.Windows.Forms.DockStyle.Left
        Me.lb_quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_quantity.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_quantity.Location = New System.Drawing.Point(98, 23)
        Me.lb_quantity.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_quantity.Size = New System.Drawing.Size(100, 35)
        Me.lb_quantity.TabIndex = 1
        Me.lb_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_item_id
        '
        Me.lb_item_id.Dock = System.Windows.Forms.DockStyle.Left
        Me.lb_item_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lb_item_id.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.lb_item_id.Location = New System.Drawing.Point(3, 23)
        Me.lb_item_id.Padding = New System.Windows.Forms.Padding(0, 5, 5, 0)
        Me.lb_item_id.Size = New System.Drawing.Size(95, 35)
        Me.lb_item_id.TabIndex = 0
        Me.lb_item_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft



        Me.lb_item_id.Text = "Item ID: "
        Me.lb_quantity.Text = "Quantity: "
        Me.lb_cost.Text = "Cost:"
        Me.lb_container.Name = "lb_container"
        Me.lb_cost.Name = "lb_cost"
        Me.lb_quantity.Name = "lb_quantity"
        Me.lb_item_id.Name = "lb_item_id"

        Me.lb_container.Controls.Add(Me.lb_cost)
        Me.lb_container.Controls.Add(Me.lb_quantity)
        Me.lb_container.Controls.Add(Me.lb_item_id)

        Return lb_container

    End Function


    Public Function CartItem() As Panel
        rowItem = New Panel
        '
        'rowItem
        '
        rowItem.Dock = System.Windows.Forms.DockStyle.Top
        rowItem.Location = New System.Drawing.Point(0, 0)
        rowItem.Padding = New System.Windows.Forms.Padding(5)
        rowItem.Size = New System.Drawing.Size(556, 100)
        rowItem.TabIndex = 8
        '
        'itemBoxRight
        '
        itemBoxRight.AutoSize = False
        itemBoxRight.BackColor = System.Drawing.Color.Transparent
        itemBoxRight.Dock = System.Windows.Forms.DockStyle.Right
        itemBoxRight.Location = New System.Drawing.Point(501, 5)
        itemBoxRight.Margin = New System.Windows.Forms.Padding(5)
        itemBoxRight.Padding = New System.Windows.Forms.Padding(5, 35, 5, 10)
        itemBoxRight.Size = New System.Drawing.Size(50, 90)
        itemBoxRight.TabIndex = 33
        '
        'btnSelect
        '
        btnSelect.AutoSize = True
        btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        btnSelect.Dock = System.Windows.Forms.DockStyle.Fill
        btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        btnSelect.FlatAppearance.BorderSize = 0
        btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSelect.ForeColor = System.Drawing.Color.Black
        btnSelect.Location = New System.Drawing.Point(5, 35)
        btnSelect.Size = New System.Drawing.Size(40, 45)
        btnSelect.TabIndex = 1
        btnSelect.UseVisualStyleBackColor = True
        '
        'itemBoxLeft
        '
        itemBoxLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        itemBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill
        itemBoxLeft.Location = New System.Drawing.Point(5, 5)
        itemBoxLeft.Margin = New System.Windows.Forms.Padding(5)
        itemBoxLeft.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        itemBoxLeft.Size = New System.Drawing.Size(475, 90)
        itemBoxLeft.TabIndex = 32
        '
        'infoWrapper
        '
        infoWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        infoWrapper.Location = New System.Drawing.Point(100, 20)
        infoWrapper.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        infoWrapper.Size = New System.Drawing.Size(373, 65)
        infoWrapper.TabIndex = 35
        '
        'quantityPanel
        '
        quantityPanel.BackColor = System.Drawing.Color.Transparent
        quantityPanel.Dock = System.Windows.Forms.DockStyle.Right
        quantityPanel.Location = New System.Drawing.Point(210, 5)
        quantityPanel.Margin = New System.Windows.Forms.Padding(5, 20, 5, 20)
        quantityPanel.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        quantityPanel.Size = New System.Drawing.Size(163, 60)
        quantityPanel.TabIndex = 54
        '
        'quantWrapper
        '
        quantWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        quantWrapper.Location = New System.Drawing.Point(45, 10)
        quantWrapper.Margin = New System.Windows.Forms.Padding(10)
        quantWrapper.Padding = New System.Windows.Forms.Padding(3)
        quantWrapper.Size = New System.Drawing.Size(73, 40)
        quantWrapper.TabIndex = 25
        '
        'quantity
        '
        quantity.Dock = System.Windows.Forms.DockStyle.Fill
        quantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        quantity.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        quantity.Location = New System.Drawing.Point(3, 3)
        quantity.Size = New System.Drawing.Size(67, 34)
        quantity.TabIndex = 0
        quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addQuantWrapper
        '
        addQuantWrapper.Dock = System.Windows.Forms.DockStyle.Right
        addQuantWrapper.Location = New System.Drawing.Point(118, 10)
        addQuantWrapper.Padding = New System.Windows.Forms.Padding(5)
        addQuantWrapper.Size = New System.Drawing.Size(40, 40)
        addQuantWrapper.TabIndex = 1
        '
        'addQuant
        '
        addQuant.AutoSize = True
        addQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        addQuant.Dock = System.Windows.Forms.DockStyle.Fill
        addQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        addQuant.FlatAppearance.BorderSize = 0
        addQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addQuant.Font = New System.Drawing.Font("Lexend", 8.25!)
        addQuant.Location = New System.Drawing.Point(5, 5)
        addQuant.Size = New System.Drawing.Size(30, 30)
        addQuant.TabIndex = 2
        addQuant.UseVisualStyleBackColor = True
        '
        'subQuantWrapper
        '
        subQuantWrapper.Dock = System.Windows.Forms.DockStyle.Left
        subQuantWrapper.Location = New System.Drawing.Point(5, 10)
        subQuantWrapper.Padding = New System.Windows.Forms.Padding(5)
        subQuantWrapper.Size = New System.Drawing.Size(40, 40)
        subQuantWrapper.TabIndex = 0
        '
        'subQuant
        '
        subQuant.AutoSize = True
        subQuant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        subQuant.Dock = System.Windows.Forms.DockStyle.Fill
        subQuant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        subQuant.FlatAppearance.BorderSize = 0
        subQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        subQuant.Font = New System.Drawing.Font("Lexend", 8.25!)
        subQuant.Location = New System.Drawing.Point(5, 5)
        subQuant.Size = New System.Drawing.Size(30, 30)
        subQuant.TabIndex = 2
        subQuant.UseVisualStyleBackColor = True
        '
        'infoBox
        '
        infoBox.Dock = System.Windows.Forms.DockStyle.Fill
        infoBox.Location = New System.Drawing.Point(10, 5)
        infoBox.Size = New System.Drawing.Size(200, 60)
        infoBox.TabIndex = 0
        '
        'price
        '
        price.AutoSize = True
        price.Dock = System.Windows.Forms.DockStyle.Top
        price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        price.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        price.Location = New System.Drawing.Point(0, 30)
        price.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        price.Size = New System.Drawing.Size(47, 24)
        price.TabIndex = 10
        price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'item_name
        '
        item_name.AutoSize = True
        item_name.Dock = System.Windows.Forms.DockStyle.Top
        item_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        item_name.Font = New System.Drawing.Font("Lexend", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        item_name.Location = New System.Drawing.Point(0, 0)
        item_name.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        item_name.Size = New System.Drawing.Size(114, 30)
        item_name.TabIndex = 9
        item_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemImage
        '
        itemImage.Dock = System.Windows.Forms.DockStyle.Left
        itemImage.Location = New System.Drawing.Point(0, 20)
        itemImage.Size = New System.Drawing.Size(100, 65)
        itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        itemImage.TabIndex = 34
        itemImage.TabStop = False
        '
        'bottomLine
        '
        bottomLine.BackColor = System.Drawing.Color.DimGray
        bottomLine.Dock = System.Windows.Forms.DockStyle.Bottom
        bottomLine.Location = New System.Drawing.Point(0, 85)
        bottomLine.Margin = New System.Windows.Forms.Padding(5)
        bottomLine.Size = New System.Drawing.Size(473, 3)
        bottomLine.TabIndex = 27


        'infoBox.BorderStyle = BorderStyle.FixedSingle
        'quantityPanel.BorderStyle = BorderStyle.FixedSingle


        '
        ' NAMES
        ' 
        bottomLine.Name = "bottomLine_" & index
        subQuant.Name = "subQuant_" & index
        infoBox.Name = "infoBox_" & index
        addQuantWrapper.Name = "addQuantWrapper_" & index
        quantWrapper.Name = "quantWrapper_" & index
        quantityPanel.Name = "quantityPanel_" & index
        infoWrapper.Name = "infoWrapper_" & index
        itemBoxLeft.Name = "itemBoxLeft_" & index
        itemBoxRight.Name = "itemBoxRight_" & index
        rowItem.Name = "rowItem_" & index

        item_name.Name = "item_name_" & index
        price.Name = "price_" & index
        quantity.Name = "quantity_" & index

        itemImage.Name = "itemImage_" & index
        btnSelect.Name = "btnSelect_" & index
        addQuant.Name = "addQuant_" & index
        subQuantWrapper.Name = "subQuantWrapper_" & index
        '
        ' TEXTS
        '

        item_name.Text = "Item Name " & index
        price.Text = "9999 "
        quantity.Text = "1 "

        '
        ' Images
        '

        btnSelect.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_unchecked_checkbox_30
        addQuant.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_add_new_96
        subQuant.BackgroundImage = Global.TestDraft1.My.Resources.Resources.icons8_indeterminate_checkbox_96
        itemImage.Image = Global.TestDraft1.My.Resources.Resources.icons8_no_image_30
        itemImage.SizeMode = PictureBoxSizeMode.Zoom

        infoBox.Controls.Add(price)
        infoBox.Controls.Add(item_name)
        subQuantWrapper.Controls.Add(subQuant)
        addQuantWrapper.Controls.Add(addQuant)
        quantWrapper.Controls.Add(quantity)
        quantityPanel.Controls.Add(quantWrapper)
        quantityPanel.Controls.Add(addQuantWrapper)
        quantityPanel.Controls.Add(subQuantWrapper)
        infoWrapper.Controls.Add(quantityPanel)
        infoWrapper.Controls.Add(infoBox)
        itemBoxLeft.Controls.Add(infoWrapper)
        itemBoxLeft.Controls.Add(itemImage)
        itemBoxLeft.Controls.Add(bottomLine)
        itemBoxRight.Controls.Add(btnSelect)
        rowItem.Controls.Add(itemBoxLeft)
        rowItem.Controls.Add(itemBoxRight)


        cartButtons.Add(rowItem.Name, {btnSelect, addQuant, subQuant})



        '
        ' HANDLERS
        '
        AddHandler addQuant.Click, AddressOf cartQuantity
        AddHandler subQuant.Click, AddressOf cartQuantity
        AddHandler btnSelect.Click, AddressOf btnSelect_Clicked
        AddHandler itemImage.Click, AddressOf OnOrderEdit
        AddHandler item_name.Click, AddressOf OnOrderEdit



        Return rowItem
    End Function





    '###############################################################################################
    ' EVENTS
    '###############################################################################################

    Private Sub OnOrderEdit(sender As Object, e As EventArgs)
        Dim page As String = currentPage.Controls(0).Name
        If Not page = "orderWrapper" Then Return

        Dim o As New _ordering_dialog
        o.order = New Ordering(current_user, cart_item, cart_item("quantity"))

        Select Case cart_item("shipping_type")
            Case "Standard"
                o.rbt_standard.PerformClick()
            Case "Priority"
                o.rbt_priority.PerformClick()
            Case "Express"
                o.rbt_express.PerformClick()
        End Select

        o.btnConfirm.Text = "Save Order"
        o.btnConfirm.BackColor = Color.PaleGreen

        switchPanel(o.windowWrapper, currentPage)


    End Sub


    Private Sub hoverenter(sender As Object, e As EventArgs) Handles itemBoxLeft.MouseEnter, infoWrapper.MouseEnter, item_name.MouseEnter, itemImage.MouseEnter
        itemBoxLeft.ForeColor = Color.SteelBlue
        itemBoxLeft.BackColor = Color.FromArgb(240, 240, 240)
        itemImage.BackColor = Color.White
        bottomLine.BackColor = Color.SteelBlue
        bottomLine.Size = New Size(200, 3)
    End Sub

    Private Sub hoverleave(sender As Object, e As EventArgs) Handles itemBoxLeft.MouseLeave, infoWrapper.MouseLeave, item_name.MouseLeave, itemImage.MouseLeave
        itemBoxLeft.ForeColor = Color.Black
        itemBoxLeft.BackColor = Color.Transparent
        bottomLine.BackColor = Color.DimGray
        bottomLine.Size = New Size(200, 1)

    End Sub


End Class
