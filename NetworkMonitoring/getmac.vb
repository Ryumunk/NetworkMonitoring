Public Class frmGetmac
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtGetmac.Clear()
    End Sub

    Private Sub btnGetmac_Click(sender As Object, e As EventArgs) Handles btnGetmac.Click
        Dim process As New Process()
        Dim FileName As String = "getmac"
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
        txtGetmac.Text = output
        process.Close()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        Dim process As New Process()
        Dim FileName As String = "getmac"
        Dim Arguments As String = "/v"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtGetmac.Text = output
        process.Close()
    End Sub

    Private Sub btnNh_Click(sender As Object, e As EventArgs) Handles btnNh.Click
        Dim process As New Process()
        Dim FileName As String = "getmac"
        Dim Arguments As String = "/nh"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtGetmac.Text = output
        process.Close()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub
End Class