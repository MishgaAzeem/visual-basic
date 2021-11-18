Module Module1

    Sub Main()
        Dim Str1 As String
        Dim MyChar, ThisChar, NextChar As Char
        Dim Count, Count2, Count3, Highest As Integer

        Str1 = ""
        MyChar = ""
        ThisChar = ""
        NextChar = ""
        Count = 0
        Count2 = 0
        Count3 = 0
        Highest = 0

        Console.Write("Enter String to be processed: ", Str1)
        Str1 = UCase(Console.ReadLine)

        For Count = 1 To Len(Str1)
            ThisChar = Mid(Str1, Count, 1)
            Count3 = 0
            For Count2 = 1 To Len(Str1)
                NextChar = Mid(Str1, Count2, 1)
                If ThisChar = NextChar Then
                    Count3 = Count3 + 1
                End If
            Next
            If Count3 > Highest Then
                Highest = Count3
                MyChar = ThisChar
            End If
        Next

        Console.WriteLine(MyChar & " " & "occured" & " " & Highest & " " & "number of times")

        Console.ReadKey()
    End Sub

End Module
