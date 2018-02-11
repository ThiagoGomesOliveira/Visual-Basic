Module Module1

    Sub Main()
        Dim pontos As Integer
        Console.WriteLine("Entre com a pontuação ")

        pontos = Console.ReadLine()

        If pontos >= 9 Then
            Console.WriteLine("Você foi aprovado com  A")
            Console.ReadKey()
        ElseIf pontos >= 7 Then
            Console.WriteLine("Você foi aprovado com  B")
            Console.ReadKey()
        ElseIf pontos >= 5 Then
            Console.WriteLine("Você foi aprovado com  C")
            Console.ReadKey()
        ElseIf pontos >= 3 Then
            Console.WriteLine("Você foi aprovado com  D")
            Console.ReadKey()
        ElseIf pontos < 3 Then
            Console.WriteLine("Você foi Reprovado")
            Console.ReadKey()
        End If


    End Sub

End Module
