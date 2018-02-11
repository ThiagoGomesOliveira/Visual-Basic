Module Module1

    Sub Main()
        Dim pontos As Integer
        Console.WriteLine("Entre com a pontuação ")

        pontos = Console.ReadLine()
        Select Case (pontos)
            Case 90 To 100
                Console.WriteLine("Você foi aprovado com A")
                Console.ReadKey()
            Case 70 To 89
                Console.WriteLine("Você foi aprovado com B")
                Console.ReadKey()
            Case 50 To 69
                Console.WriteLine("Você foi aprovado com C")
                Console.ReadKey()
            Case 0 To 49
                Console.WriteLine("Você foi Reprovado")
                Console.ReadKey()
        End Select

    End Sub

End Module
