Public Class frmEula

    Private Sub frmEula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLicense.Text = ""

    End Sub

    Private Sub btnAgree_Click(sender As Object, e As EventArgs) Handles btnAgree.Click
        My.Settings.sLicense = "1"
        Me.Close()
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        My.Settings.sLicense = "0"
        End
    End Sub
End Class