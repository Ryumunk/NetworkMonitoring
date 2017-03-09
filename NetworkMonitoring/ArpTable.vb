Public Class frmArp
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim process As New Process()
        Dim FileName As String = "arp"
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
        txtArp.Text = output

        lstArpList.View = View.Details
        lstArpList.Columns.Add("Ip Address", 115, HorizontalAlignment.Left)
        lstArpList.Columns.Add("MAC Address", 115, HorizontalAlignment.Left)
        lstArpList.Columns.Add("Type", 115, HorizontalAlignment.Left)

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("..\ArpTable.txt", False)
        file.WriteLine(txtArp.Text)
        file.Close()
        process.Close()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        Dim process As New Process()
        Dim FileName As String = "arp"
        Dim Arguments As String = "-g"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtArp.Text = output
        process.Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtArp.Clear()
        lstArpList.Clear()
    End Sub

    Private Sub btnNsLookup_Click(sender As Object, e As EventArgs) Handles btnNsLookup.Click
        Dim process As New Process()
        Dim FileName As String = "nslookup"
        Dim Arguments As String = txtHostname.Text
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtArp.Text = output
        process.Close()
    End Sub

    Private Sub btnHostname_Click(sender As Object, e As EventArgs) Handles btnHostname.Click
        Dim process As New Process()
        Dim FileName As String = "hostname"
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
        txtArp.Text = output
        process.Close()
    End Sub

    Private Sub btnRefreshArp_Click(sender As Object, e As EventArgs) Handles btnRefreshArp.Click
        Dim process As New Process()
        Dim FileName As String = "netsh"
        Dim Arguments As String = "interface ip delete arpcache"
        Dim WorkingDirectory As String = "../"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = WorkingDirectory
        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        txtArp.Text = output
        process.Close()
    End Sub

    Private Sub btnArpTable_Click(sender As Object, e As EventArgs) Handles btnArpTable.Click
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("..\ArpTable.txt")

            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {vbTab}
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    lstArpList.Items.AddRange(currentRow.Select(Function(x) New ListViewItem(x)).ToArray)
                Catch ex As Exception
                    MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                End Try
            End While
        End Using

    End Sub
End Class