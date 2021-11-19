Module Module1

    Sub Main()
        Dim Count As Integer

        Count = 0

        Console.Write("Enter the number of donuts: ")
        Count = Console.ReadLine
        If Count < 10 And Count > 0 Then
            Console.Write("There are " & Count & " donuts")
        Else : Console.Write("There are many donuts")
        End If

        Console.ReadKey()

    End Sub

End Module
