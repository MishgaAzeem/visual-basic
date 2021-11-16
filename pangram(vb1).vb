Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Alpha(25) As Char
        Dim ThisAlph As Char
        Dim AlphaPos As Integer
        Dim isPangram = True

        Str1 = ""
        Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        ThisAlph = ""
        AlphaPos = 0

        Console.Write("Enter the string: ")
        Str1 = UCase(Console.ReadLine)

        For Index = 1 To Len(Alpha)
            ThisAlph = Mid(Alpha, Index, 1)
            AlphaPos = InStr(Str1, ThisAlph)
            If AlphaPos = 0 Then
                isPangram = False
                Exit For
            End If
        Next

        If isPangram = True Then
            Console.WriteLine("This string has all the alphabets.")
        Else
            Console.WriteLine("This string does not have all the alphabets.")
        End If

        Console.ReadKey()
    End Sub

End Module
