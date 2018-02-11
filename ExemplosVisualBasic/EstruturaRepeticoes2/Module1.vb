Module Module1

    Sub Main()
        Dim count As Integer
        Dim count2 As Integer

        For count = 1 To 10
            Console.WriteLine(count)
        Next


        For count = 1 To 10 Step 2
            Console.WriteLine(count)
        Next


        For count = 10 To 1 Step -1
            Console.WriteLine(count)
        Next

        Console.WriteLine("-------------Tabuada-------------")
        For count = 1 To 10 Step 1
            For count2 = 1 To 10 Step 1
                Console.WriteLine(count & " X " & count2 & " : " & count * count2)
                If count2 = 10 Then
                    Console.WriteLine()

                End If
            Next

        Next
        Console.ReadKey()

    End Sub



End Module
