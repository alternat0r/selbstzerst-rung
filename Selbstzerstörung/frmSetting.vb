Public Class frmSetting

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbWipeStyle.SelectedIndex = My.Settings.sWipeStyle
        txtKey.Text = My.Settings.sKey
        
        If My.Settings.sShowKey = "1" Then
            chkShowKey.Checked = True
        Else
            chkShowKey.Checked = False
        End If

        If My.Settings.sKeyForSetting = "1" Then
            chkKeyForSetting.Checked = True
        Else
            chkKeyForSetting.Checked = False
        End If

        If My.Settings.sEncryptConfig = "1" Then
            chkEncryptConf.Checked = True
        Else
            chkEncryptConf.Checked = False
        End If

        If My.Settings.sSelfDestroy = "1" Then
            chkSelfDestroy.Checked = True
        Else
            chkSelfDestroy.Checked = False
        End If

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


        lvSoftware.Items.Add("TrueCrypt")
        lvSoftware.Items.Add("Microsoft Visual Studio")
        lvSoftware.Items.Add("VMware Workstation")
        lvSoftware.Items.Add("VMware Player")
        lvSoftware.Items.Add("Quassel")
        lvSoftware.Items.Add("VPNC Front End")
        lvSoftware.Items.Add("Wamp Server")
        lvSoftware.Items.Add("µTorrent")
        lvSoftware.Items.Add("Mozilla Thunderbird")
        lvSoftware.Items.Add("Mozilla Firefox")
        lvSoftware.Items.Add("Google Chrome")
        lvSoftware.Items.Add("Steam")
        lvSoftware.Items.Add("Battle.net")
        lvSoftware.Items.Add("Minecraft")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        My.Settings.sWipeStyle = cmbWipeStyle.SelectedIndex
        My.Settings.sKey = txtKey.Text
        My.Settings.sShowKey = chkShowKey.CheckState
        My.Settings.sKeyForSetting = chkKeyForSetting.CheckState
        My.Settings.sEncryptConfig = chkEncryptConf.CheckState
        My.Settings.sSelfDestroy = chkSelfDestroy.CheckState

        MsgBox("Settings saved.", MsgBoxStyle.Information, frmMain.szTitle)
    End Sub

    Private Sub chkShowKey_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowKey.CheckedChanged
        If chkShowKey.CheckState = CheckState.Checked Then
            txtKey.PasswordChar = ""
        Else
            txtKey.PasswordChar = "*"
        End If
    End Sub

    Private Sub lvSoftware_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvSoftware.ItemChecked
        'MsgBox(e.Item.Index)

    End Sub

    Private Sub lvSoftware_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSoftware.SelectedIndexChanged

    End Sub

    Private Sub TickSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TickSelectedItemToolStripMenuItem.Click
        lvSoftware.Items(lvSoftware.FocusedItem.Index).Checked = True
    End Sub

    Private Sub UntickSelectedItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UntickSelectedItemToolStripMenuItem.Click
        lvSoftware.Items(lvSoftware.FocusedItem.Index).Checked = False
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim i As Integer

        For i = 0 To lvSoftware.Items.Count - 1
            lvSoftware.Items(i).Checked = True
        Next
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        Dim i As Integer

        For i = 0 To lvSoftware.Items.Count - 1
            lvSoftware.Items(i).Checked = False
        Next
    End Sub

    Private Sub ctxSoftwareName_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxSoftwareName.Opening

    End Sub
End Class