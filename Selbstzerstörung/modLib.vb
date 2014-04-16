Module modLib

    Public Function rnd_number(x As Integer, y As Integer) As String
        Dim rn As New Random
        Return rn.Next(x, y)
    End Function


End Module
