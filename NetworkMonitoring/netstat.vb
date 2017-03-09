Public Class frmNetstat

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtNetstat.Clear()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnNetstat_Click(sender As Object, e As EventArgs) Handles btnNetstat.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
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
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-a"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-e"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-f"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-n"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-o"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-q"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-r"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-t"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-x"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-y"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim process As New Process()
        Dim FileName As String = "netstat"
        Dim Arguments As String = "-b"
        Dim WorkingDirectory As String = "../"

        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.StartInfo.Verb = "runas"
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtNetstat.Text = output
        process.Close()
    End Sub
End Class