Module Module1

    Sub Main()
        Dim Str1, Str2, Str3, Str4, Str5, Str6, Str7, Str8 As String

        Str1 = ""
        Str2 = ""
        Str3 = ""
        Str4 = ""
        Str5 = ""
        Str6 = ""
        Str7 = ""
        Str8 = ""

        Console.Write("Enter the first string: ")
        Str1 = Console.ReadLine
        Console.Write("Enter the second string: ")
        Str2 = Console.ReadLine
        Str3 = Left(Str1, 2)
        Str4 = Left(Str2, 2)
        Str5 = Mid(Str1, 3, Len(Str1))
        Str6 = Mid(Str2, 3, Len(Str2))
        Str7 = Str4 + Str5
        Str8 = Str3 + Str6

        Console.Write("The processed string is " + Str7 + " " + Str8)

        Console.ReadKey()
    End Sub

End Module
