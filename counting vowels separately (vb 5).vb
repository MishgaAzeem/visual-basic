Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char
        Dim x, ACount, ECount, ICount, OCount, UCount As Integer

        Str1 = ""
        Char1 = ""
        x = 0
        ACount = 0
        ECount = 0
        ICount = 0
        OCount = 0
        UCount = 0

        Console.Write("Enter string to be processed: ")
        Str1 = UCase(Console.ReadLine)

        For x = 1 To Len(Str1)
            Char1 = Mid(Str1, x, 1)
            Select Case (Char1)
                Case "A" : ACount = ACount + 1
                Case "E" : ECount = ECount + 1
                Case "I" : ICount = ICount + 1
                Case "O" : OCount = OCount + 1
                Case "U" : UCount = UCount + 1
            End Select
        Next


        Console.WriteLine("The number of A's in this string are: " & ACount)
        Console.WriteLine("The number of E's in this string are: " & ECount)
        Console.WriteLine("The number of I's in this string are: " & ICount)
        Console.WriteLine("The number of O's in this string are: " & OCount)
        Console.WriteLine("The number of U's in this string are: " & UCount)

        Console.ReadKey()
    End Sub

End Module
