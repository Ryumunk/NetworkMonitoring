<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArp
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
        Me.mnuArp = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.txtArp = New System.Windows.Forms.TextBox()
        Me.btnNsLookup = New System.Windows.Forms.Button()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.lblIpaddress = New System.Windows.Forms.Label()
        Me.btnHostname = New System.Windows.Forms.Button()
        Me.lstArpList = New System.Windows.Forms.ListView()
        Me.btnRefreshArp = New System.Windows.Forms.Button()
        Me.btnArpTable = New System.Windows.Forms.Button()
        Me.mnuArp.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuArp
        '
        Me.mnuArp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuArp.Location = New System.Drawing.Point(0, 0)
        Me.mnuArp.Name = "mnuArp"
        Me.mnuArp.Size = New System.Drawing.Size(700, 24)
        Me.mnuArp.TabIndex = 0
        Me.mnuArp.Text = "MenuStrip1"
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
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(13, 28)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "arp -a"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(94, 28)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(75, 23)
        Me.btnG.TabIndex = 2
        Me.btnG.Text = "arp -g"
        Me.btnG.UseVisualStyleBackColor = True
        '
        'txtArp
        '
        Me.txtArp.Location = New System.Drawing.Point(13, 86)
        Me.txtArp.Multiline = True
        Me.txtArp.Name = "txtArp"
        Me.txtArp.ReadOnly = True
        Me.txtArp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArp.Size = New System.Drawing.Size(354, 438)
        Me.txtArp.TabIndex = 3
        '
        'btnNsLookup
        '
        Me.btnNsLookup.Location = New System.Drawing.Point(13, 57)
        Me.btnNsLookup.Name = "btnNsLookup"
        Me.btnNsLookup.Size = New System.Drawing.Size(75, 23)
        Me.btnNsLookup.TabIndex = 4
        Me.btnNsLookup.Text = "Nslookup"
        Me.btnNsLookup.UseVisualStyleBackColor = True
        '
        'txtHostname
        '
        Me.txtHostname.Location = New System.Drawing.Point(373, 29)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(190, 20)
        Me.txtHostname.TabIndex = 5
        '
        'lblIpaddress
        '
        Me.lblIpaddress.AutoSize = True
        Me.lblIpaddress.Location = New System.Drawing.Point(307, 32)
        Me.lblIpaddress.Name = "lblIpaddress"
        Me.lblIpaddress.Size = New System.Drawing.Size(60, 13)
        Me.lblIpaddress.TabIndex = 6
        Me.lblIpaddress.Text = "Ip Address:"
        '
        'btnHostname
        '
        Me.btnHostname.Location = New System.Drawing.Point(94, 57)
        Me.btnHostname.Name = "btnHostname"
        Me.btnHostname.Size = New System.Drawing.Size(75, 23)
        Me.btnHostname.TabIndex = 7
        Me.btnHostname.Text = "Hostname"
        Me.btnHostname.UseVisualStyleBackColor = True
        '
        'lstArpList
        '
        Me.lstArpList.Location = New System.Drawing.Point(374, 86)
        Me.lstArpList.Name = "lstArpList"
        Me.lstArpList.Size = New System.Drawing.Size(314, 438)
        Me.lstArpList.TabIndex = 8
        Me.lstArpList.UseCompatibleStateImageBehavior = False
        '
        'btnRefreshArp
        '
        Me.btnRefreshArp.Location = New System.Drawing.Point(175, 29)
        Me.btnRefreshArp.Name = "btnRefreshArp"
        Me.btnRefreshArp.Size = New System.Drawing.Size(104, 23)
        Me.btnRefreshArp.TabIndex = 9
        Me.btnRefreshArp.Text = "Refresh Arp Table"
        Me.btnRefreshArp.UseVisualStyleBackColor = True
        '
        'btnArpTable
        '
        Me.btnArpTable.Location = New System.Drawing.Point(176, 57)
        Me.btnArpTable.Name = "btnArpTable"
        Me.btnArpTable.Size = New System.Drawing.Size(103, 23)
        Me.btnArpTable.TabIndex = 10
        Me.btnArpTable.Text = "Arp Table"
        Me.btnArpTable.UseVisualStyleBackColor = True
        '
        'frmArp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 536)
        Me.Controls.Add(Me.btnArpTable)
        Me.Controls.Add(Me.btnRefreshArp)
        Me.Controls.Add(Me.lstArpList)
        Me.Controls.Add(Me.btnHostname)
        Me.Controls.Add(Me.lblIpaddress)
        Me.Controls.Add(Me.txtHostname)
        Me.Controls.Add(Me.btnNsLookup)
        Me.Controls.Add(Me.txtArp)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.mnuArp)
        Me.MainMenuStrip = Me.mnuArp
        Me.Name = "frmArp"
        Me.Text = "arp"
        Me.mnuArp.ResumeLayout(False)
        Me.mnuArp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuArp As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnA As Button
    Friend WithEvents btnG As Button
    Friend WithEvents txtArp As TextBox
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents btnNsLookup As Button
    Friend WithEvents txtHostname As TextBox
    Friend WithEvents lblIpaddress As Label
    Friend WithEvents btnHostname As Button
    Friend WithEvents lstArpList As ListView
    Friend WithEvents btnRefreshArp As Button
    Friend WithEvents btnArpTable As Button
End Class
