Public Class frmIpconfig
    Private Sub btnIpconfig_Click(sender As Object, e As EventArgs) Handles btnIpconfig.Click
        Dim process As New Process()
        Dim FileName As String = "ipconfig"
        Dim Arguments As String = ""
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtIpconfig.Text = output
        process.Close()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Dim process As New Process()
        Dim FileName As String = "ipconfig"
        Dim Arguments As String = "/all"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtIpconfig.Text = output
        process.Close()
    End Sub

    Private Sub btnRelease_Click(sender As Object, e As EventArgs) Handles btnRelease.Click
        Dim process As New Process()
        Dim FileName As String = "ipconfig"
        Dim Arguments As String = "/release"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtIpconfig.Text = output
        process.Close()
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        Dim process As New Process()
        Dim FileName As String = "ipconfig"
        Dim Arguments As String = "/renew"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtIpconfig.Text = output
        process.Close()
    End Sub

    Private Sub btnAllCompartments_Click(sender As Object, e As EventArgs) Handles btnAllCompartments.Click
        Dim process As New Process()
        Dim FileName As String = "ipconfig"
        Dim Arguments As String = "/allcompartments"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtIpconfig.Text = output
        process.Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtIpconfig.Clear()
    End Sub
End Class