Imports System.IO

Public Class frmWipeSelect

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvObject_DragDrop(sender As Object, e As DragEventArgs) Handles lvObject.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each pth In files
            'Dim lvi As New ListViewItem
            'lvi.SubItems.Add("w")
            'lvObject.Items.Add(Path.GetFileName(pth))
            'lvObject.Items(0).SubItems.Add(pth)

            Dim str(2) As String
            Dim itm As ListViewItem
            str(0) = Path.GetFileName(pth)
            str(1) = pth
            itm = New ListViewItem(str)
            lvObject.Items.Insert(0, itm)
        Next
    End Sub

    Private Sub lvObject_DragEnter(sender As Object, e As DragEventArgs) Handles lvObject.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class