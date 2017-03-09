<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTracert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuTracert = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTracert = New System.Windows.Forms.TextBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.btnTracert = New System.Windows.Forms.Button()
        Me.lblTargetHost = New System.Windows.Forms.Label()
        Me.btnD = New System.Windows.Forms.Button()
        Me.mnuTracert.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTracert
        '
        Me.mnuTracert.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuTracert.Location = New System.Drawing.Point(0, 0)
        Me.mnuTracert.Name = "mnuTracert"
        Me.mnuTracert.Size = New System.Drawing.Size(755, 24)
        Me.mnuTracert.TabIndex = 0
        Me.mnuTracert.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'txtTracert
        '
        Me.txtTracert.Location = New System.Drawing.Point(12, 124)
        Me.txtTracert.Multiline = True
        Me.txtTracert.Name = "txtTracert"
        Me.txtTracert.ReadOnly = True
        Me.txtTracert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTracert.Size = New System.Drawing.Size(731, 367)
        Me.txtTracert.TabIndex = 2
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(91, 98)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(220, 20)
        Me.txtIp.TabIndex = 1
        '
        'btnTracert
        '
        Me.btnTracert.Location = New System.Drawing.Point(12, 40)
        Me.btnTracert.Name = "btnTracert"
        Me.btnTracert.Size = New System.Drawing.Size(75, 23)
        Me.btnTracert.TabIndex = 3
        Me.btnTracert.Text = "tracert"
        Me.btnTracert.UseVisualStyleBackColor = True
        '
        'lblTargetHost
        '
        Me.lblTargetHost.AutoSize = True
        Me.lblTargetHost.Location = New System.Drawing.Point(13, 104)
        Me.lblTargetHost.Name = "lblTargetHost"
        Me.lblTargetHost.Size = New System.Drawing.Size(66, 13)
        Me.lblTargetHost.TabIndex = 4
        Me.lblTargetHost.Text = "Target Host:"
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(94, 39)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(75, 23)
        Me.btnD.TabIndex = 5
        Me.btnD.Text = "-d"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'frmTracert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 503)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.lblTargetHost)
        Me.Controls.Add(Me.btnTracert)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtTracert)
        Me.Controls.Add(Me.mnuTracert)
        Me.MainMenuStrip = Me.mnuTracert
        Me.Name = "frmTracert"
        Me.Text = "tracert"
        Me.mnuTracert.ResumeLayout(False)
        Me.mnuTracert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTracert As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents txtTracert As TextBox
    Friend WithEvents txtIp As TextBox
    Friend WithEvents btnTracert As Button
    Friend WithEvents lblTargetHost As Label
    Friend WithEvents btnD As Button
End Class
