Public Class frmWipeSelect

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvObject_DragDrop(sender As Object, e As DragEventArgs) Handles lvObject.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            MsgBox(path)
        Next
    End Sub

    Private Sub lvObject_DragEnter(sender As Object, e As DragEventArgs) Handles lvObject.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

End Class