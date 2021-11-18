Module Module1

    Sub Main()
        Dim Str1 As String
        Dim ThisChar, Char1 As Char
        Dim Count, CharCount, AlphaCount, DigitCount, SpCount As Integer

        Str1 = ""
        ThisChar = ""
        Char1 = ""
        CharCount = 0
        AlphaCount = 0
        DigitCount = 0
        SpCount = 0

        Console.Write("Enter String to be processed : ")
        Str1 = UCase(Console.ReadLine)
        Console.Write("Enter character to be searched: ", Char1)
        Char1 = UCase(Console.ReadLine)

        For Count = 1 To Len(Str1)
            CharCount = CharCount + 1
            Char1 = Mid(Str1, Count, 1)
            Char1 = UCase(Char1)
            If Char1 >= "A" And Char1 <= "Z" Then
                AlphaCount = AlphaCount + 1
            ElseIf Char1 >= "0" And Char1 <= "9" Then
                DigitCount = DigitCount + 1
            Else : SpCount = SpCount + 1
            End If
        Next

        Console.WriteLine("Amount of times the character occured: " & CharCount)
        Console.WriteLine("alphabet count: " & AlphaCount)
        Console.WriteLine("digit count: " & DigitCount)
        Console.WriteLine("other character count: " & SpCount)

        Console.ReadKey()
    End Sub

End Module
