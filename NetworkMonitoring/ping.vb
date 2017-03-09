
Public Class frmPing
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtPing.Clear()
        txtTargetName.Clear()
        lstArpList.Clear()
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        Dim process As New Process()
        Dim FileName As String = "ping"
        Dim Arguments As String = txtTargetName.Text
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtPing.Text = output
        process.Close()
    End Sub

    Private Sub btnArpList_Click(sender As Object, e As EventArgs) Handles btnArpList.Click
        Dim iptable As New GetIpNetTable
        Dim array As ArrayList
        lstArpList.View = View.Details
        lstArpList.Columns.Add("Ip Address", 100, HorizontalAlignment.Left)
        lstArpList.Columns.Add("MAC Address", 100, HorizontalAlignment.Left)
        array = iptable.LoadTableEntries
        For i As Integer = 0 To array.Count - 1
            lstArpList.Items.Add(array.Item(i).Value).SubItems.Add(array.Item(i).Key)
        Next
    End Sub

End Class
