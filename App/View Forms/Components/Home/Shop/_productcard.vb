

Imports System.IO
Imports System.Reflection

Public Class ProductCard

    ' ###################################################################################
    ' CONTROL COMPONENTS
    ' ###################################################################################
    Public itemWrapper As Panel
    Private WithEvents itemBox As New Panel
    Private WithEvents btnWrapper As New Panel
    Private WithEvents quantPanel As New Panel
    Private WithEvents addToCart As New Button
    Private WithEvents infoPanel As New Panel
    Private WithEvents itemStock As New Label
    Private WithEvents itemName As New Label
    Private WithEvents itemPrice As New Label
    Private WithEvents imgBox As New PictureBox
    Private WithEvents Panel2 As New Panel
    Private resources As System.ComponentModel.ComponentResourceManager
    Private index As Integer
    Private new_panel As Panel
    Private parent As Control
    Private baseForm As Form
    Private baseAssembly As Assembly
    ' ###################################################################################

    ' ###################################################################################
    ' PROPERTY VARIABLES
    ' ###################################################################################
    Private item As DataRow
    Private item_name As String
    Private item_price As Integer
    Private item_stock As Integer
    Private item_description As String
    ' constructor
    Public Sub New(ByRef parent As Control, i As Integer)
        Me.index = i
        Me.parent = parent
        Me.baseForm = parent.FindForm()
        Me.baseAssembly = parent.GetType.Assembly
        resources = New ComponentModel.ComponentResourceManager(_components1.GetType)
    End Sub


    Public Sub SetProperties(source As DataRow)
        If source Is Nothing Then
            Return
        End If
        item = source
        item_name = source("item_name").ToString
        item_stock = Val(source("stock_quantity"))
        item_description = IIf(Not IsDBNull(source("description")), source("description"), "No description")

        itemName.Text = item_name.Substring(0, IIf(item_name.Length > 10, 10, item_name.Length)) & "..."
        item_price = Val(source("price"))
        itemPrice.Text = $"₱{item_price}"
        itemStock.Text = $"Available: {item_stock}"

        Try
            imgBox.BackgroundImage = Image.FromFile(source("image_dir"))
            imgBox.BackgroundImageLayout = ImageLayout.Zoom
        Catch ex As Exception

        End Try
    End Sub

    Public Sub MakeCard()
        new_panel = New Panel
        new_panel = CreateCard()
        parent.Controls.Add(new_panel)
        parent.Controls.SetChildIndex(new_panel, parent.Controls.Count)
    End Sub

    Private Sub itemBox_Click(sender As Object, e As EventArgs) Handles infoPanel.Click, itemName.Click, addToCart.Click, itemPrice.Click, itemStock.Click, imgBox.Click

        Dim v As New _viewitemdialog
        v.item = item
        v.ShowDialog()


    End Sub

    Private Sub hoverenter(sender As Object, e As EventArgs) Handles itemBox.MouseEnter, infoPanel.MouseEnter, itemName.MouseEnter, addToCart.MouseEnter, itemPrice.MouseEnter, itemStock.MouseEnter, imgBox.MouseEnter, quantPanel.MouseEnter
        itemBox.ForeColor = Color.SteelBlue
        itemBox.BackColor = Color.FromArgb(240, 240, 240)
        'itemBox.BorderStyle = BorderStyle.None
        'imgBox.BorderStyle = BorderStyle.None
        imgBox.BackColor = Color.White
        Panel2.BackColor = Color.SteelBlue
        Panel2.size = New Size(200, 3)
    End Sub

    Private Sub hoverleave(sender As Object, e As EventArgs) Handles itemBox.MouseLeave, infoPanel.MouseLeave, itemName.MouseLeave, addToCart.MouseLeave, itemPrice.MouseLeave, itemStock.MouseLeave, imgBox.MouseLeave, quantPanel.MouseLeave
        itemBox.ForeColor = Color.Black
        'itemBox.BorderStyle = BorderStyle.FixedSingle
        'imgBox.BorderStyle = BorderStyle.FixedSingle
        itemBox.BackColor = Color.Transparent
        Panel2.BackColor = Color.DimGray
        Panel2.size = New Size(200, 1)

    End Sub


    '###############################################################################################
    ' PRODUCT CARD CONTROL
    '###############################################################################################

    Private Function CreateCard() As Panel
        itemWrapper = New Panel
        '
        'itemWrapper
        '
        '
        'itemWrapper
        '
        itemWrapper.Location = New System.Drawing.Point(45, 11)
        itemWrapper.Margin = New System.Windows.Forms.Padding(0)
        itemWrapper.Padding = New System.Windows.Forms.Padding(35, 35, 0, 0)
        itemWrapper.Size = New System.Drawing.Size(235, 235)
        itemWrapper.TabIndex = 1

        '
        'itemBox
        '
        itemBox.BackColor = System.Drawing.Color.Transparent
        itemBox.BorderStyle = BorderStyle.FixedSingle

        itemBox.Dock = System.Windows.Forms.DockStyle.Fill
        itemBox.Location = New System.Drawing.Point(0, 0)
        itemBox.Margin = New System.Windows.Forms.Padding(0)
        itemBox.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        itemBox.Size = New System.Drawing.Size(200, 200)
        itemBox.TabIndex = 2


        '
        'imgBox
        '
        imgBox.BorderStyle = BorderStyle.FixedSingle

        imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        imgBox.Dock = System.Windows.Forms.DockStyle.Top
        imgBox.Location = New System.Drawing.Point(10, 15)
        imgBox.Size = New System.Drawing.Size(180, 100)
        imgBox.TabIndex = 3
        imgBox.TabStop = False


        '
        'infoPanel
        '
        infoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        infoPanel.Location = New System.Drawing.Point(10, 115)
        infoPanel.Padding = New System.Windows.Forms.Padding(2, 5, 2, 2)
        infoPanel.Size = New System.Drawing.Size(180, 70)
        infoPanel.TabIndex = 4

        '
        'itemLoc
        '
        itemStock.AutoSize = True
        itemStock.BackColor = System.Drawing.Color.Transparent
        itemStock.Dock = System.Windows.Forms.DockStyle.Bottom
        itemStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemStock.Font = New System.Drawing.Font("Lexend", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemStock.Location = New System.Drawing.Point(2, 55)
        itemStock.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        itemStock.Size = New System.Drawing.Size(92, 13)
        itemStock.TabIndex = 4
        itemStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'itemName
        '
        itemName.AutoSize = True
        itemName.BackColor = System.Drawing.Color.Transparent
        itemName.Dock = System.Windows.Forms.DockStyle.Top
        itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemName.Font = New System.Drawing.Font("Lexend", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemName.Location = New System.Drawing.Point(2, 30)
        itemName.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        itemName.Size = New System.Drawing.Size(62, 14)
        itemName.TabIndex = 3
        itemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'itemPrice
        '
        itemPrice.AutoSize = True
        itemPrice.BackColor = System.Drawing.Color.Transparent
        itemPrice.Dock = System.Windows.Forms.DockStyle.Top
        itemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        itemPrice.Font = New System.Drawing.Font("Lexend Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        itemPrice.Location = New System.Drawing.Point(2, 5)
        itemPrice.Size = New System.Drawing.Size(58, 25)
        itemPrice.TabIndex = 2
        itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft

        '
        'btnWrapper
        '
        btnWrapper.Dock = System.Windows.Forms.DockStyle.Right
        btnWrapper.Location = New System.Drawing.Point(130, 115)
        btnWrapper.Size = New System.Drawing.Size(60, 70)
        btnWrapper.TabIndex = 5


        '
        'quantPanel
        '
        quantPanel.Dock = System.Windows.Forms.DockStyle.Fill
        quantPanel.Location = New System.Drawing.Point(0, 0)
        quantPanel.Padding = New System.Windows.Forms.Padding(1, 22, 1, 3)
        quantPanel.Size = New System.Drawing.Size(60, 40)
        quantPanel.TabIndex = 3


        '
        'addToCart
        '
        addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        addToCart.Dock = System.Windows.Forms.DockStyle.Bottom

        'addToCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))

        addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        addToCart.Location = New System.Drawing.Point(0, 40)
        addToCart.Size = New System.Drawing.Size(60, 30)
        addToCart.TabIndex = 2
        addToCart.UseVisualStyleBackColor = True

        '
        'Panel2
        '
        Panel2.BackColor = System.Drawing.Color.DimGray
        Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Panel2.Location = New System.Drawing.Point(35, 232)
        Panel2.Margin = New System.Windows.Forms.Padding(5)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(200, 3)
        Panel2.TabIndex = 28


        '
        ' Names
        ' 
        itemWrapper.Name = "itemWrapper_" & index
        itemBox.Name = "itemBox_" & index
        imgBox.Name = "imgBox_" & index
        infoPanel.Name = "infoPanel_" & index
        itemPrice.Name = "itemPrice_" & index
        itemName.Name = "itemName_" & index
        itemStock.Name = "itemLoc_" & index
        btnWrapper.Name = "btnWrapper_" & index
        addToCart.Name = "addToCart_" & index
        quantPanel.Name = "quantPanel_" & index

        '
        ' Images
        '

        imgBox.BackgroundImage = CType(resources.GetObject("imgBox.BackgroundImage"), System.Drawing.Image)
        addToCart.BackgroundImage = CType(resources.GetObject("addToCart.BackgroundImage"), System.Drawing.Image)



        imgBox.Image = Nothing


        '
        ' Labels
        ' 
        itemName.Text = "Product_" & index
        itemPrice.Text = "$999"
        itemStock.Text = "Available: "

        '
        ' Child Control
        '
        Panel2.Size = New Size(200, 1)
        itemWrapper.Controls.Add(Panel2)
        itemWrapper.Controls.Add(itemBox)

        itemBox.Controls.Add(btnWrapper)
        itemBox.Controls.Add(infoPanel)
        itemBox.Controls.Add(imgBox)

        infoPanel.Controls.Add(itemStock)
        infoPanel.Controls.Add(itemName)
        infoPanel.Controls.Add(itemPrice)

        btnWrapper.Controls.Add(quantPanel)
        btnWrapper.Controls.Add(addToCart)


        ' HANDLERS



        Return itemWrapper
    End Function

End Class
