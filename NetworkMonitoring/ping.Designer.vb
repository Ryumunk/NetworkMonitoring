<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPing
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
        Me.mnuPing = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.txtTargetName = New System.Windows.Forms.TextBox()
        Me.lblTargetName = New System.Windows.Forms.Label()
        Me.txtPing = New System.Windows.Forms.TextBox()
        Me.btnArpList = New System.Windows.Forms.Button()
        Me.lstArpList = New System.Windows.Forms.ListView()
        Me.mnuPing.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPing
        '
        Me.mnuPing.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuPing.Location = New System.Drawing.Point(0, 0)
        Me.mnuPing.Name = "mnuPing"
        Me.mnuPing.Size = New System.Drawing.Size(710, 24)
        Me.mnuPing.TabIndex = 0
        Me.mnuPing.Text = "MenuStrip1"
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
        'btnPing
        '
        Me.btnPing.Location = New System.Drawing.Point(13, 28)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(75, 23)
        Me.btnPing.TabIndex = 1
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'txtTargetName
        '
        Me.txtTargetName.Location = New System.Drawing.Point(251, 30)
        Me.txtTargetName.Name = "txtTargetName"
        Me.txtTargetName.Size = New System.Drawing.Size(179, 20)
        Me.txtTargetName.TabIndex = 2
        '
        'lblTargetName
        '
        Me.lblTargetName.AutoSize = True
        Me.lblTargetName.Location = New System.Drawing.Point(164, 33)
        Me.lblTargetName.Name = "lblTargetName"
        Me.lblTargetName.Size = New System.Drawing.Size(72, 13)
        Me.lblTargetName.TabIndex = 3
        Me.lblTargetName.Text = "Target Name:"
        '
        'txtPing
        '
        Me.txtPing.Location = New System.Drawing.Point(12, 145)
        Me.txtPing.Multiline = True
        Me.txtPing.Name = "txtPing"
        Me.txtPing.ReadOnly = True
        Me.txtPing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPing.Size = New System.Drawing.Size(417, 358)
        Me.txtPing.TabIndex = 4
        '
        'btnArpList
        '
        Me.btnArpList.Location = New System.Drawing.Point(446, 28)
        Me.btnArpList.Name = "btnArpList"
        Me.btnArpList.Size = New System.Drawing.Size(75, 23)
        Me.btnArpList.TabIndex = 5
        Me.btnArpList.Text = "Arp list"
        Me.btnArpList.UseVisualStyleBackColor = True
        '
        'lstArpList
        '
        Me.lstArpList.Location = New System.Drawing.Point(446, 145)
        Me.lstArpList.Name = "lstArpList"
        Me.lstArpList.Size = New System.Drawing.Size(252, 358)
        Me.lstArpList.TabIndex = 6
        Me.lstArpList.UseCompatibleStateImageBehavior = False
        '
        'frmPing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 515)
        Me.Controls.Add(Me.lstArpList)
        Me.Controls.Add(Me.btnArpList)
        Me.Controls.Add(Me.txtPing)
        Me.Controls.Add(Me.lblTargetName)
        Me.Controls.Add(Me.txtTargetName)
        Me.Controls.Add(Me.btnPing)
        Me.Controls.Add(Me.mnuPing)
        Me.MainMenuStrip = Me.mnuPing
        Me.Name = "frmPing"
        Me.Text = "ping"
        Me.mnuPing.ResumeLayout(False)
        Me.mnuPing.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPing As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnPing As Button
    Friend WithEvents txtTargetName As TextBox
    Friend WithEvents lblTargetName As Label
    Friend WithEvents txtPing As TextBox
    Friend WithEvents btnArpList As Button
    Friend WithEvents lstArpList As ListView
End Class
