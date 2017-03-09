<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnIPConfig = New System.Windows.Forms.Button()
        Me.btnArp = New System.Windows.Forms.Button()
        Me.btnGetMac = New System.Windows.Forms.Button()
        Me.btnNetstat = New System.Windows.Forms.Button()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.btnTracert = New System.Windows.Forms.Button()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfiNetworkMonitoring = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIPConfig
        '
        Me.btnIPConfig.Location = New System.Drawing.Point(13, 64)
        Me.btnIPConfig.Name = "btnIPConfig"
        Me.btnIPConfig.Size = New System.Drawing.Size(89, 58)
        Me.btnIPConfig.TabIndex = 0
        Me.btnIPConfig.Text = "Ipconfig"
        Me.btnIPConfig.UseVisualStyleBackColor = True
        '
        'btnArp
        '
        Me.btnArp.Location = New System.Drawing.Point(12, 128)
        Me.btnArp.Name = "btnArp"
        Me.btnArp.Size = New System.Drawing.Size(89, 58)
        Me.btnArp.TabIndex = 2
        Me.btnArp.Text = "Arp"
        Me.btnArp.UseVisualStyleBackColor = True
        '
        'btnGetMac
        '
        Me.btnGetMac.Location = New System.Drawing.Point(108, 64)
        Me.btnGetMac.Name = "btnGetMac"
        Me.btnGetMac.Size = New System.Drawing.Size(89, 58)
        Me.btnGetMac.TabIndex = 3
        Me.btnGetMac.Text = "Getmac"
        Me.btnGetMac.UseVisualStyleBackColor = True
        '
        'btnNetstat
        '
        Me.btnNetstat.Location = New System.Drawing.Point(13, 192)
        Me.btnNetstat.Name = "btnNetstat"
        Me.btnNetstat.Size = New System.Drawing.Size(89, 58)
        Me.btnNetstat.TabIndex = 4
        Me.btnNetstat.Text = "Netstat"
        Me.btnNetstat.UseVisualStyleBackColor = True
        '
        'btnPing
        '
        Me.btnPing.Location = New System.Drawing.Point(108, 128)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(89, 58)
        Me.btnPing.TabIndex = 5
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'btnTracert
        '
        Me.btnTracert.Location = New System.Drawing.Point(108, 192)
        Me.btnTracert.Name = "btnTracert"
        Me.btnTracert.Size = New System.Drawing.Size(89, 58)
        Me.btnTracert.TabIndex = 6
        Me.btnTracert.Text = "Tracert"
        Me.btnTracert.UseVisualStyleBackColor = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAbout, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(276, 24)
        Me.mnuMain.TabIndex = 7
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'nfiNetworkMonitoring
        '
        Me.nfiNetworkMonitoring.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.nfiNetworkMonitoring.Icon = CType(resources.GetObject("nfiNetworkMonitoring.Icon"), System.Drawing.Icon)
        Me.nfiNetworkMonitoring.Text = "Network Monitoring"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 262)
        Me.Controls.Add(Me.btnTracert)
        Me.Controls.Add(Me.btnPing)
        Me.Controls.Add(Me.btnNetstat)
        Me.Controls.Add(Me.btnGetMac)
        Me.Controls.Add(Me.btnArp)
        Me.Controls.Add(Me.btnIPConfig)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Network Monitoring"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIPConfig As Button
    Friend WithEvents btnArp As Button
    Friend WithEvents btnGetMac As Button
    Friend WithEvents btnNetstat As Button
    Friend WithEvents btnPing As Button
    Friend WithEvents btnTracert As Button
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Private WithEvents nfiNetworkMonitoring As NotifyIcon
End Class
