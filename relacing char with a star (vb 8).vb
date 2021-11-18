Module Module1

    Sub Main()
        Dim StrS, Str2 As String
        Dim ThisChar, FirstChar As Char
        Dim Count As Integer

        StrS = ""
        Str2 = ""
        ThisChar = ""
        FirstChar = ""
        Count = 0

        Console.Write("Enter the string to be processed: ")
        StrS = Console.ReadLine
        FirstChar = Left(StrS, 1)
        Str2 = Str2 & FirstChar

        For Count = 2 To Len(StrS)
            ThisChar = Mid(StrS, Count, 1)
            If ThisChar = FirstChar Then
                Str2 = Str2 & "*"
            Else : Str2 = Str2 & ThisChar
            End If
        Next
        Console.Write("New string: " & Str2)

        Console.ReadKey()
    End Sub

End Module
