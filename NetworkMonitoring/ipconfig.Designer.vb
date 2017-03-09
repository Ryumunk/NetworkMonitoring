<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIpconfig
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
        Me.btnIpconfig = New System.Windows.Forms.Button()
        Me.txtIpconfig = New System.Windows.Forms.TextBox()
        Me.mnuIpconfig = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnRelease = New System.Windows.Forms.Button()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.btnAllCompartments = New System.Windows.Forms.Button()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIpconfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIpconfig
        '
        Me.btnIpconfig.Location = New System.Drawing.Point(12, 40)
        Me.btnIpconfig.Name = "btnIpconfig"
        Me.btnIpconfig.Size = New System.Drawing.Size(105, 23)
        Me.btnIpconfig.TabIndex = 0
        Me.btnIpconfig.Text = "Ipconfig"
        Me.btnIpconfig.UseVisualStyleBackColor = True
        '
        'txtIpconfig
        '
        Me.txtIpconfig.Location = New System.Drawing.Point(12, 69)
        Me.txtIpconfig.Multiline = True
        Me.txtIpconfig.Name = "txtIpconfig"
        Me.txtIpconfig.ReadOnly = True
        Me.txtIpconfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIpconfig.Size = New System.Drawing.Size(549, 454)
        Me.txtIpconfig.TabIndex = 1
        '
        'mnuIpconfig
        '
        Me.mnuIpconfig.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuIpconfig.Location = New System.Drawing.Point(0, 0)
        Me.mnuIpconfig.Name = "mnuIpconfig"
        Me.mnuIpconfig.Size = New System.Drawing.Size(580, 24)
        Me.mnuIpconfig.TabIndex = 2
        Me.mnuIpconfig.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(123, 40)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(105, 23)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "/all"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnRelease
        '
        Me.btnRelease.Location = New System.Drawing.Point(234, 40)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(105, 23)
        Me.btnRelease.TabIndex = 4
        Me.btnRelease.Text = "/release"
        Me.btnRelease.UseVisualStyleBackColor = True
        '
        'btnRenew
        '
        Me.btnRenew.Location = New System.Drawing.Point(345, 40)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(105, 23)
        Me.btnRenew.TabIndex = 5
        Me.btnRenew.Text = "/renew"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'btnAllCompartments
        '
        Me.btnAllCompartments.Location = New System.Drawing.Point(456, 40)
        Me.btnAllCompartments.Name = "btnAllCompartments"
        Me.btnAllCompartments.Size = New System.Drawing.Size(105, 23)
        Me.btnAllCompartments.TabIndex = 6
        Me.btnAllCompartments.Text = "/allcompartments"
        Me.btnAllCompartments.UseVisualStyleBackColor = True
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear.Text = "Clear"
        '
        'frmIpconfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 538)
        Me.Controls.Add(Me.btnAllCompartments)
        Me.Controls.Add(Me.btnRenew)
        Me.Controls.Add(Me.btnRelease)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.txtIpconfig)
        Me.Controls.Add(Me.btnIpconfig)
        Me.Controls.Add(Me.mnuIpconfig)
        Me.MainMenuStrip = Me.mnuIpconfig
        Me.Name = "frmIpconfig"
        Me.Text = "ipconfig"
        Me.mnuIpconfig.ResumeLayout(False)
        Me.mnuIpconfig.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIpconfig As Button
    Friend WithEvents txtIpconfig As TextBox
    Friend WithEvents mnuIpconfig As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnAll As Button
    Friend WithEvents btnRelease As Button
    Friend WithEvents btnRenew As Button
    Friend WithEvents btnAllCompartments As Button
    Friend WithEvents mnuClear As ToolStripMenuItem
End Class
