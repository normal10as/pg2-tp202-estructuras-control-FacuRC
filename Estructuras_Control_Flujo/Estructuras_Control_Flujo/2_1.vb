Module _2_1
    Sub Main()
        '2.1.Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
        'la relación entre ambos: mayor, menor o igual.
        Dim a, b As Byte
        Console.WriteLine("Ingrese un numero a : ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese otro numero b : ")
        b = Console.ReadLine

        If a > b Then
            Console.WriteLine("El mayor es a")
        ElseIf a = b Then
            Console.WriteLine("Son iguales")
        Else
            Console.WriteLine("El mayor es b")

        End If

        Console.ReadKey()

    End Sub
End Module
