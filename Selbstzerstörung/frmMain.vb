﻿Public Class frmMain

    Dim i As Integer

    Public Const szTitle As String = "Selbstzerstorung"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.sLicense = "0" Then
            frmEula.ShowDialog()
        End If

        ' to do:
        '   - add command line support

        ' ||Requirement||
        ' must be running with administrator priv.

        ' ||THINGS TO DESTROY||
        ' terminate gdrive process
        ' delete mydocument
        ' delete gdrive folder
        ' delete other than C:\ drive
        ' clear history, cache, temp, download folder
        ' delete important software
        ' --truecrypt
        ' --visual studio
        ' --vmware / virtualbox
        ' --quassel
        ' --vpn software
        ' --web server
        ' --torrent
        ' all deleting process must be wipe with 0 byte / random
        ' remove possible pirate software
        ' self-destroy appsz

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        frmSetting.ShowDialog()
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        End
    End Sub

    Private Sub menuSettings_Click(sender As Object, e As EventArgs) Handles menuSettings.Click
        frmSetting.ShowDialog()
    End Sub

    Private Sub menuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click

    End Sub

    Private Sub menuAbout2_Click(sender As Object, e As EventArgs) Handles menuAbout2.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        menuCheckin_Click(sender, e)
    End Sub

    Private Sub menuCheckin_Click(sender As Object, e As EventArgs) Handles menuCheckin.Click
        If txtKey.Text = My.Settings.sKey Then
            i = 0
            tmrCheckin.Start()
            sbStatus.Text = "Check-in"
            MsgBox("Checked-in", MsgBoxStyle.Information, szTitle)
        Else
            sbStatus.Text = "False"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtKey.Text = ""
        txtKey.Focus()
    End Sub

    Private Sub btnTips_Click(sender As Object, e As EventArgs) Handles btnTips.Click
        MsgBox("This Window will be popup everytime you logon, resume from hibernate or unlock your Windows." & vbCrLf & vbCrLf & "WARNING! If you are NOT checked in within " & frmSetting.txtTimeCheckin.Text & " hours, all your data will be lost.", MsgBoxStyle.Information, szTitle)
    End Sub

    Private Sub PrivacyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivacyToolStripMenuItem.Click
        If MsgBox("This will open up web browser to read our User Privacy statement. Do you want to continue?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("http://www.data0.net")
        End If
    End Sub

    Private Sub btnWipeSelect_Click(sender As Object, e As EventArgs) Handles btnWipeSelect.Click
        frmWipeSelect.ShowDialog()
    End Sub

    Private Sub WipeSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WipeSelectToolStripMenuItem.Click
        btnWipeSelect_Click(sender, e)
    End Sub

    Private Sub tmrCheckin_Tick(sender As Object, e As EventArgs) Handles tmrCheckin.Tick

        i = i + 1
        Dim ts As TimeSpan = TimeSpan.FromSeconds(i)
        Dim mydate As DateTime = New DateTime(ts.Ticks)
        stCheckin.Text = "Last checked-in: " & mydate.ToString(("HH:mm:ss")) & " ago"
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        tmrCheckin.Stop()
        i = 0
    End Sub
End Class
