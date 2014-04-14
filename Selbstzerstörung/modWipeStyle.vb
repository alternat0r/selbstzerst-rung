Imports System.IO

Module modWipeStyle
    Public Function using_sdelete()
        If File.Exists(Application.ExecutablePath & "\sdelete.exe") = True Then
            Shell(Application.ExecutablePath & "\sdelete.exe", AppWinStyle.Hide)
        Else
            MsgBox(frmMain.szTitle & " do not found Sysinternal sdelete file. Please download it from www.sysinternals.com.", MsgBoxStyle.Exclamation)
            Return Nothing
            Exit Function
        End If
        Return Nothing
    End Function

    Public Function using_zero(obj As String)

        Dim di As New DirectoryInfo(obj)
        ' Get a reference to each file in that directory. 
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names and sizes of the files. 
        Dim f As FileInfo

        For Each f In fiArr
            If f.Length = 0 Then
                f.Delete()
            End If
        Next
        Return Nothing
    End Function
End Module
