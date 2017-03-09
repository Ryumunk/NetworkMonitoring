<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetmac
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
        Me.mnuGetmac = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGetmac = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnNh = New System.Windows.Forms.Button()
        Me.txtGetmac = New System.Windows.Forms.TextBox()
        Me.mnuGetmac.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuGetmac
        '
        Me.mnuGetmac.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuGetmac.Location = New System.Drawing.Point(0, 0)
        Me.mnuGetmac.Name = "mnuGetmac"
        Me.mnuGetmac.Size = New System.Drawing.Size(614, 24)
        Me.mnuGetmac.TabIndex = 0
        Me.mnuGetmac.Text = "MenuStrip1"
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
        Me.mnuClear.Size = New System.Drawing.Size(103, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuClose.Text = "Close"
        '
        'btnGetmac
        '
        Me.btnGetmac.Location = New System.Drawing.Point(13, 28)
        Me.btnGetmac.Name = "btnGetmac"
        Me.btnGetmac.Size = New System.Drawing.Size(75, 23)
        Me.btnGetmac.TabIndex = 1
        Me.btnGetmac.Text = "getmac"
        Me.btnGetmac.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(114, 27)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(75, 23)
        Me.btnV.TabIndex = 2
        Me.btnV.Text = "/v"
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnNh
        '
        Me.btnNh.Location = New System.Drawing.Point(217, 27)
        Me.btnNh.Name = "btnNh"
        Me.btnNh.Size = New System.Drawing.Size(75, 23)
        Me.btnNh.TabIndex = 3
        Me.btnNh.Text = "/nh"
        Me.btnNh.UseVisualStyleBackColor = True
        '
        'txtGetmac
        '
        Me.txtGetmac.Location = New System.Drawing.Point(13, 58)
        Me.txtGetmac.Multiline = True
        Me.txtGetmac.Name = "txtGetmac"
        Me.txtGetmac.ReadOnly = True
        Me.txtGetmac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGetmac.Size = New System.Drawing.Size(589, 456)
        Me.txtGetmac.TabIndex = 4
        '
        'frmGetmac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 526)
        Me.Controls.Add(Me.txtGetmac)
        Me.Controls.Add(Me.btnNh)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnGetmac)
        Me.Controls.Add(Me.mnuGetmac)
        Me.MainMenuStrip = Me.mnuGetmac
        Me.Name = "frmGetmac"
        Me.Text = "getmac"
        Me.mnuGetmac.ResumeLayout(False)
        Me.mnuGetmac.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuGetmac As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnGetmac As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnNh As Button
    Friend WithEvents txtGetmac As TextBox
End Class
