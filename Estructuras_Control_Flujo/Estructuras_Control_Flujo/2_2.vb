Module _2_2
    Sub main()
        '2.2.ingresar tres valores y mostrar el menor.

        Dim a, b, c As Byte
        Console.WriteLine("Ingrese un numero a : ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese otro numero b : ")
        b = Console.ReadLine
        Console.WriteLine("Ingrese otro numero c : ")
        c = Console.ReadLine

        If a < b And a < c Then
            Console.WriteLine("El menor es a:")
        ElseIf b < a And b < c Then
            Console.WriteLine("El menor es b:")
        Else
            Console.WriteLine("El menor es c")
        End If

        Console.ReadKey()

    End Sub
End Module
