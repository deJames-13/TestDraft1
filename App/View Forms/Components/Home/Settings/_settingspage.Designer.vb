<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _settingspage
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
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.windowWrapper.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowWrapper
        '
        Me.windowWrapper.Controls.Add(Me.btnLogOut)
        Me.windowWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowWrapper.Location = New System.Drawing.Point(0, 0)
        Me.windowWrapper.Name = "windowWrapper"
        Me.windowWrapper.Size = New System.Drawing.Size(984, 661)
        Me.windowWrapper.TabIndex = 2
        '
        'btnLogOut
        '
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Lexend ExtraBold", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(0, 0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(984, 661)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "LOG OUT"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        '_settingspage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.windowWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "_settingspage"
        Me.Text = "_settingspage"
        Me.windowWrapper.ResumeLayout(False)
        Me.windowWrapper.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents windowWrapper As Panel
    Friend WithEvents btnLogOut As Button
End Class
