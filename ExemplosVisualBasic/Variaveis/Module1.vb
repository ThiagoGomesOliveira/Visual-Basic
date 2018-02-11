Module Module1

    Sub Main()
        Dim num1, num2 As Integer
        Dim soma, subt, mult, div, modl, exp As Integer
        Dim dec As Decimal

        Console.WriteLine("Digite o primeiro valor :  ")
        num1 = Console.ReadLine()
        Console.WriteLine("Digite o segundo valor: ")
        num2 = Console.ReadLine()

        soma = num1 + num2
        subt = num1 - num2
        mult = num1 * num2
        div = num1 \ num2
        modl = num1 Mod num2
        exp = num1 ^ num2
        dec = num1 / num2

        Console.WriteLine("O primeiro número + o segundo número é {0}", soma)
        Console.WriteLine("O primeiro número - o segundo número é {0}", subt)
        Console.WriteLine("O primeiro número * o segundo número é {0}", mult)
        Console.WriteLine("O primeiro número \ o segundo número é {0}", div)
        Console.WriteLine("O primeiro número MOD o segundo número é {0}", modl)
        Console.WriteLine("O primeiro número ^ o segundo número é {0}", exp)
        Console.WriteLine("O primeiro número / o segundo número é {0}", dec)
        Console.ReadKey()



    End Sub

End Module
