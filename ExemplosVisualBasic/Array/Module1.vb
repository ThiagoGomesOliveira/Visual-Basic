Module Module1

    Sub Main()

        Dim array As Integer()
        Dim nome As Char()
        nome = New Char(5) {}
        array = New Integer() {0, 1, 2, 3}

        Console.WriteLine(array(0))
        Console.WriteLine(array(1))
        Console.WriteLine(array(2))
        Console.WriteLine(array(3))
        Console.WriteLine()
        Console.WriteLine("-----------------------------------------------------")
        nome(0) = "T"
        nome(1) = "H"
        nome(2) = "I"
        nome(3) = "A"
        nome(4) = "G"
        nome(5) = "O"

        Console.WriteLine(nome(0))
        Console.WriteLine(nome(1))
        Console.WriteLine(nome(2))
        Console.WriteLine(nome(3))
        Console.WriteLine(nome(4))
        Console.WriteLine(nome(5))
        Console.ReadKey()

    End Sub

End Module
