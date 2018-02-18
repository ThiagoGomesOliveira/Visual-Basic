Module Module1

    Sub Main()
        Dim num As Integer
        Dim resultado As Integer


        Console.WriteLine("Entre com um número")
        num = Console.ReadLine()
        resultado = Calc(num)
        Console.WriteLine()
        Console.WriteLine("Soma do número com ele mesmo é {0}", resultado)
        Console.WriteLine()
        Console.WriteLine("número Informado {0}", num)
        Console.ReadKey()

    End Sub

    Function Calc(ByVal num As Integer) As Integer
        'Funcao que soma o número que é passado por parametro por ele mesmo e retorna a soma
        num = num + num
        Return num
    End Function

End Module
