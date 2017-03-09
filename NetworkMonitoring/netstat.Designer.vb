<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetstat
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
        Me.mnuNetstat = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNetstat = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.txtNetstat = New System.Windows.Forms.TextBox()
        Me.btnB = New System.Windows.Forms.Button()
        Me.mnuNetstat.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuNetstat
        '
        Me.mnuNetstat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuNetstat.Location = New System.Drawing.Point(0, 0)
        Me.mnuNetstat.Name = "mnuNetstat"
        Me.mnuNetstat.Size = New System.Drawing.Size(812, 24)
        Me.mnuNetstat.TabIndex = 0
        Me.mnuNetstat.Text = "MenuStrip1"
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
        'btnNetstat
        '
        Me.btnNetstat.Location = New System.Drawing.Point(13, 28)
        Me.btnNetstat.Name = "btnNetstat"
        Me.btnNetstat.Size = New System.Drawing.Size(75, 23)
        Me.btnNetstat.TabIndex = 1
        Me.btnNetstat.Text = "netstat"
        Me.btnNetstat.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(155, 27)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 2
        Me.btnA.Text = "-a"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(297, 26)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(75, 23)
        Me.btnE.TabIndex = 3
        Me.btnE.Text = "-e"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(439, 28)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(75, 23)
        Me.btnF.TabIndex = 4
        Me.btnF.Text = "-f"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.Location = New System.Drawing.Point(581, 27)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(75, 23)
        Me.btnN.TabIndex = 5
        Me.btnN.Text = "-n"
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnO
        '
        Me.btnO.Location = New System.Drawing.Point(723, 26)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(75, 23)
        Me.btnO.TabIndex = 6
        Me.btnO.Text = "-o"
        Me.btnO.UseVisualStyleBackColor = True
        '
        'btnQ
        '
        Me.btnQ.Location = New System.Drawing.Point(13, 57)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(75, 23)
        Me.btnQ.TabIndex = 7
        Me.btnQ.Text = "-q"
        Me.btnQ.UseVisualStyleBackColor = True
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(297, 55)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(75, 23)
        Me.btnR.TabIndex = 8
        Me.btnR.Text = "-r"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(439, 55)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 9
        Me.btnT.Text = "-t"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnX
        '
        Me.btnX.Location = New System.Drawing.Point(581, 55)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(75, 23)
        Me.btnX.TabIndex = 10
        Me.btnX.Text = "-x"
        Me.btnX.UseVisualStyleBackColor = True
        '
        'btnY
        '
        Me.btnY.Location = New System.Drawing.Point(725, 55)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(75, 23)
        Me.btnY.TabIndex = 11
        Me.btnY.Text = "-y"
        Me.btnY.UseVisualStyleBackColor = True
        '
        'txtNetstat
        '
        Me.txtNetstat.Location = New System.Drawing.Point(13, 87)
        Me.txtNetstat.Multiline = True
        Me.txtNetstat.Name = "txtNetstat"
        Me.txtNetstat.ReadOnly = True
        Me.txtNetstat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNetstat.Size = New System.Drawing.Size(787, 454)
        Me.txtNetstat.TabIndex = 12
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(155, 54)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 23)
        Me.btnB.TabIndex = 13
        Me.btnB.Text = "-b"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'frmNetstat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 553)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.txtNetstat)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnNetstat)
        Me.Controls.Add(Me.mnuNetstat)
        Me.MainMenuStrip = Me.mnuNetstat
        Me.Name = "frmNetstat"
        Me.Text = "netstat"
        Me.mnuNetstat.ResumeLayout(False)
        Me.mnuNetstat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuNetstat As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents btnNetstat As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnY As Button
    Friend WithEvents txtNetstat As TextBox
    Friend WithEvents btnB As Button
End Class
