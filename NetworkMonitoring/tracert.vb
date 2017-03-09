Public Class frmTracert
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtTracert.Clear()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnTracert_Click(sender As Object, e As EventArgs) Handles btnTracert.Click
        Dim process As New Process()
        Dim FileName As String = "tracert"
        Dim Arguments As String = txtIp.Text
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtTracert.Text = output
        process.Close()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim process As New Process()
        Dim FileName As String = "tracert"
        Dim Arguments As String = "-d " & txtIp.Text
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtTracert.Text = output
        process.Close()
    End Sub
End Class