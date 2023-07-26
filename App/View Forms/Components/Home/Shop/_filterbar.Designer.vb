<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _filterbar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.search_bar = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnSetOrder = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmb_filters = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmb_brand = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.windowWrapper.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.search_bar.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.Panel1)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.search_bar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 25, 20, 25)
        Me.Panel1.Size = New System.Drawing.Size(984, 96)
        Me.Panel1.TabIndex = 31
        '
        'Panel12
        '
        Me.Panel12.AutoSize = True
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.btnFilter)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(20, 25)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel12.Size = New System.Drawing.Size(155, 46)
        Me.Panel12.TabIndex = 35
        '
        'btnFilter
        '
        Me.btnFilter.AutoSize = True
        Me.btnFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.Location = New System.Drawing.Point(5, 5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(145, 36)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Find your preference."
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'search_bar
        '
        Me.search_bar.Controls.Add(Me.Panel11)
        Me.search_bar.Controls.Add(Me.Panel8)
        Me.search_bar.Controls.Add(Me.Panel7)
        Me.search_bar.Controls.Add(Me.Panel6)
        Me.search_bar.Dock = System.Windows.Forms.DockStyle.Right
        Me.search_bar.Location = New System.Drawing.Point(175, 25)
        Me.search_bar.Name = "search_bar"
        Me.search_bar.Size = New System.Drawing.Size(789, 46)
        Me.search_bar.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnSetOrder)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(153, 0)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(10, 10, 0, 10)
        Me.Panel11.Size = New System.Drawing.Size(36, 46)
        Me.Panel11.TabIndex = 34
        '
        'btnSetOrder
        '
        Me.btnSetOrder.AutoSize = True
        Me.btnSetOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSetOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSetOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSetOrder.FlatAppearance.BorderSize = 0
        Me.btnSetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetOrder.Image = Global.TestDraft1.My.Resources.Resources.icons8_descending_sorting_15
        Me.btnSetOrder.Location = New System.Drawing.Point(10, 10)
        Me.btnSetOrder.Name = "btnSetOrder"
        Me.btnSetOrder.Size = New System.Drawing.Size(26, 26)
        Me.btnSetOrder.TabIndex = 1
        Me.btnSetOrder.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.cmb_filters)
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(189, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 10, 5, 5)
        Me.Panel8.Size = New System.Drawing.Size(200, 46)
        Me.Panel8.TabIndex = 33
        '
        'cmb_filters
        '
        Me.cmb_filters.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_filters.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmb_filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_filters.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.cmb_filters.FormattingEnabled = True
        Me.cmb_filters.ItemHeight = 17
        Me.cmb_filters.Location = New System.Drawing.Point(56, 10)
        Me.cmb_filters.Name = "cmb_filters"
        Me.cmb_filters.Size = New System.Drawing.Size(139, 25)
        Me.cmb_filters.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Lexend Light", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(0, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sort By"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.cmb_category)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(389, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Panel7.Size = New System.Drawing.Size(200, 46)
        Me.Panel7.TabIndex = 32
        '
        'cmb_category
        '
        Me.cmb_category.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_category.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_category.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.ItemHeight = 17
        Me.cmb_category.Location = New System.Drawing.Point(71, 10)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_category.Size = New System.Drawing.Size(124, 25)
        Me.cmb_category.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lexend Light", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmb_brand)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(589, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5, 10, 5, 5)
        Me.Panel6.Size = New System.Drawing.Size(200, 46)
        Me.Panel6.TabIndex = 31
        '
        'cmb_brand
        '
        Me.cmb_brand.BackColor = System.Drawing.Color.GhostWhite
        Me.cmb_brand.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_brand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_brand.Font = New System.Drawing.Font("Lexend", 8.25!)
        Me.cmb_brand.FormattingEnabled = True
        Me.cmb_brand.ItemHeight = 17
        Me.cmb_brand.Location = New System.Drawing.Point(54, 10)
        Me.cmb_brand.Name = "cmb_brand"
        Me.cmb_brand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmb_brand.Size = New System.Drawing.Size(141, 25)
        Me.cmb_brand.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lexend Light", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 10, 0)
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Brand"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_filterbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_filterbar"
        Me.Text = "_filterbar"
        Me.windowWrapper.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.search_bar.ResumeLayout(False)
        Me.search_bar.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents search_bar As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmb_brand As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cmb_filters As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmb_category As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnFilter As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnSetOrder As Button
End Class
