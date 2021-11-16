Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, ThisChar As Char
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        ThisChar = ""
        Count = 0

        Console.Write("Enter String to process: ")
        Str1 = UCase(Console.ReadLine)
        Console.Write("Enter character to be replaced: ", Char1)
        Char1 = UCase(Console.ReadLine)
        Console.Write("Enter new character: ", Char2)
        Char2 = UCase(Console.ReadLine)

        For Count = 1 To Len(Str1)
            ThisChar = Mid(Str1, Count, 1)
            If ThisChar = Char1 Then 
                ThisChar = Char2
            End If
            Str2 = Str2 & ThisChar
        Next

        Console.WriteLine("This is the new string: " & Str2)

        Console.ReadKey()
    End Sub

End Module
