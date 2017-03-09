Imports System.ComponentModel

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIPConfig.Click
        My.Forms.frmIpconfig.Show()
    End Sub

    Private Sub btnArp_Click(sender As Object, e As EventArgs) Handles btnArp.Click
        My.Forms.frmArp.Show()
    End Sub

    Private Sub btnGetMac_Click(sender As Object, e As EventArgs) Handles btnGetMac.Click
        My.Forms.frmGetmac.Show()
    End Sub

    Private Sub btnNetstat_Click(sender As Object, e As EventArgs) Handles btnNetstat.Click
        My.Forms.frmNetstat.Show()
    End Sub

    Private Sub btnTracert_Click(sender As Object, e As EventArgs) Handles btnTracert.Click
        My.Forms.frmTracert.Show()
    End Sub

    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        My.Forms.frmPing.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        My.Forms.frmAbout.Show()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        My.Forms.frmHelp.Show()
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                nfiNetworkMonitoring.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub nfiNetworkMonitoring_DoubleClick(sender As Object, e As EventArgs) Handles nfiNetworkMonitoring.DoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            nfiNetworkMonitoring.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
