Module _2_3
    Sub main()
        '2.3 Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
        'posición de ingreso, por ejemplo, dado los siguientes valores:  3,7,12,5,9 informar: “El tercer
        'número es el mayor valor
        Dim a, b, c, d, e As Byte
        Console.WriteLine("Ingrese un numero a : ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese otro numero b : ")
        b = Console.ReadLine
        Console.WriteLine("Ingrese otro numero c : ")
        c = Console.ReadLine
        Console.WriteLine("Ingrese otro numero d : ")
        d = Console.ReadLine
        Console.WriteLine("Ingrese otro numero e : ")
        e = Console.ReadLine

        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El mayor es el primer numero")
        ElseIf b > a And b > c And b > d And b > e Then
            Console.WriteLine("El mayor es el segundo numero")
        ElseIf c > b And c > a And c > d And c > e Then
            Console.WriteLine("El mayor es el tercer numero")
        ElseIf d > b And d > c And d > a And d > e Then
            Console.WriteLine("El mayor es el cuarto numero")
        ElseIf e > b And e > c And e > d And e > a Then
            Console.WriteLine("El mayor es el quinto numero")
        End If
        Console.ReadKey()

    End Sub

End Module
