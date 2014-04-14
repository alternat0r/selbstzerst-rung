Imports System.IO

Module modWipeStyle
    Public Function using_sdelete()
        If File.Exists(Application.ExecutablePath & "\sdelete.exe") = True Then
            Shell(Application.ExecutablePath & "\sdelete.exe", AppWinStyle.Hide)
        Else
            MsgBox(frmMain.szTitle & " do not found Sysinternal sdelete file. Please download it from www.sysinternals.com.", MsgBoxStyle.Exclamation)
            Exit Function
        End If
        Return Nothing
    End Function
End Module
