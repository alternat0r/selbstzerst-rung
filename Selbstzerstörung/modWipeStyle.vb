Imports System.IO
Imports System.Runtime.InteropServices

Module modWipeStyle
    Private Const GENERIC_ALL As Int32 = &H10000000
    Private Const FILE_SHARE_NONE As Int32 = &H0
    Private Const FILE_BEGIN = 0

    Public Declare Unicode Function CreateFileW Lib "kernel32" Alias "CreateFileW" (ByVal lpFileName As IntPtr, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As IntPtr, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As UInteger, ByVal hTemplateFile As IntPtr) As IntPtr
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hFile As Long) As Long
    Private Declare Function FlushFileBuffers Lib "kernel32" (ByVal hFile As Long) As Long

    Private Declare Function SetFilePointerEx(hFile As IntPtr, liDistanceToMove As Long, <OptionalAttribute> <OutAttribute> lpNewFilePointer As IntPtr, dwMoveMethod As UInteger) As Boolean


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

    Public Function using_random(obj As String)

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


    Private Function using_overwrite_once(filename As String)
        If System.IO.File.Exists(filename) = True Then
            Dim objWriter As New System.IO.StreamWriter(filename, False)
            objWriter.WriteLine(rnd_number(100, 10000))
            objWriter.Close()
        End If
    End Function

    Private Function using_overwrite_30(filename As String)
        For a As Integer = 0 To 29
            If System.IO.File.Exists(filename) = True Then
                Dim objWriter As New System.IO.StreamWriter(filename, False)
                objWriter.WriteLine(rnd_number(100, 10000))
                objWriter.Close()
            End If
        Next
        Return Nothing
    End Function

    Private Function using_heavy_wipe(filename As String)
        For a As Integer = 0 To 100
            If System.IO.File.Exists(filename) = True Then
                Dim objWriter As New System.IO.StreamWriter(filename, False)
                objWriter.WriteLine(RandomString(rnd_number(100000, 100000000)))
                objWriter.Close()
            End If
        Next
        Return Nothing
    End Function

End Module
