Module Module1

    Sub Main()
        Dim StrS, Str2, ThisChar As String
        Dim Count As Integer

        StrS = ""
        Str2 = ""
        ThisChar = ""
        Count = 0

        Console.Write("Enter String to be processed: ")
        StrS = Console.ReadLine
        ThisChar = Left(StrS, 2)
        Str2 = Str2 & ThisChar
        ThisChar = Right(StrS, 2)
        Str2 = Str2 & ThisChar

        If Len(StrS) <= 2 Then
            Console.Write("String not changed: " & StrS)
        Else : Console.Write("New String: " & Str2)
        End If

        Console.ReadKey()
    End Sub

End Module
