<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _shoppage
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
        Me.itemsWrapper = New System.Windows.Forms.Panel()
        Me.itemsContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.search_bar = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.windowWrapper.SuspendLayout()
        Me.itemsWrapper.SuspendLayout()
        Me.topPanel.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.search_bar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.BackColor = System.Drawing.Color.Transparent
        Me.windowWrapper.Controls.Add(Me.itemsWrapper)
        Me.windowWrapper.Controls.Add(Me.Panel13)
        Me.windowWrapper.Controls.Add(Me.topPanel)
        Me.windowWrapper.Controls.Add(Me.Panel25)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Padding = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 8
        '
        'itemsWrapper
        '
        Me.itemsWrapper.AutoScroll = True
        Me.itemsWrapper.Controls.Add(Me.itemsContainer)
        Me.itemsWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsWrapper.Location = New System.Drawing.Point(0, 150)
        Me.itemsWrapper.Name = "itemsWrapper"
        Me.itemsWrapper.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.itemsWrapper.Size = New System.Drawing.Size(984, 511)
        Me.itemsWrapper.TabIndex = 29
        '
        'itemsContainer
        '
        Me.itemsContainer.AutoScroll = True
        Me.itemsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsContainer.Location = New System.Drawing.Point(0, 0)
        Me.itemsContainer.Name = "itemsContainer"
        Me.itemsContainer.Size = New System.Drawing.Size(984, 496)
        Me.itemsContainer.TabIndex = 0
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightGray
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 148)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(984, 2)
        Me.Panel13.TabIndex = 28
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.GhostWhite
        Me.topPanel.Controls.Add(Me.Panel11)
        Me.topPanel.Controls.Add(Me.search_bar)
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 52)
        Me.topPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Padding = New System.Windows.Forms.Padding(20, 25, 20, 25)
        Me.topPanel.Size = New System.Drawing.Size(984, 96)
        Me.topPanel.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.btnFilter)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(20, 25)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(155, 46)
        Me.Panel11.TabIndex = 22
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
        Me.btnFilter.Text = "Shop Filters"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'search_bar
        '
        Me.search_bar.Controls.Add(Me.Panel4)
        Me.search_bar.Controls.Add(Me.Panel2)
        Me.search_bar.Dock = System.Windows.Forms.DockStyle.Right
        Me.search_bar.Location = New System.Drawing.Point(176, 25)
        Me.search_bar.Name = "search_bar"
        Me.search_bar.Size = New System.Drawing.Size(788, 46)
        Me.search_bar.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(266, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel4.Size = New System.Drawing.Size(439, 46)
        Me.Panel4.TabIndex = 18
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtSearch)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 10)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.Panel9.Size = New System.Drawing.Size(439, 30)
        Me.Panel9.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.GhostWhite
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(5, 5)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(429, 20)
        Me.txtSearch.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 43)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 3)
        Me.Panel5.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(705, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(25, 5, 5, 5)
        Me.Panel2.Size = New System.Drawing.Size(83, 46)
        Me.Panel2.TabIndex = 19
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(25, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(53, 36)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.LightGray
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 50)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(984, 2)
        Me.Panel25.TabIndex = 27
        '
        '_shoppage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_shoppage"
        Me.Text = "_shoppage"
        Me.windowWrapper.ResumeLayout(False)
        Me.itemsWrapper.ResumeLayout(False)
        Me.topPanel.ResumeLayout(False)
        Me.topPanel.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.search_bar.ResumeLayout(False)
        Me.search_bar.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents itemsWrapper As Panel
    Friend WithEvents itemsContainer As FlowLayoutPanel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents search_bar As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnFilter As Button
End Class
