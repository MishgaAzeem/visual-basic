Module Module1

    Sub Main()
        Dim Str1, Str2 As String

        Str1 = ""
        Str2 = ""

        Console.Write("Enter the string to be processed: ")
        Str1 = Console.ReadLine
        If Len(Str1) >= 3 Then
            Str2 = Right(Str1, 3)
            If Str2 = "ing" Then
                Console.Write("New String: " + " " + Str1 + "ly")
            Else : Console.Write("New String:" + " " + Str1 + "ing")
            End If
        Else : Console.Write("Unchanged String: " & Str1)
        End If

        Console.ReadKey()

    End Sub

End Module
