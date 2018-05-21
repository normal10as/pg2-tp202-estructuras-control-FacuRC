Module _2_6
    '2.6. Resolver el problema 2.4 con CASE
    Sub main()
        Dim precio As Single

        Console.WriteLine("Ingrese Precio: ")
        precio = Console.ReadLine
        Dim descuento, subtotal, Montodescontado, cantidad As Integer
        Console.WriteLine("Ingrese cantidad: ")
        cantidad = Console.ReadLine

        Select Case cantidad
            Case >= 10 And cantidad <= 50
                descuento = 5
                subtotal = cantidad * precio
                Montodescontado = subtotal * descuento / 100
                Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & Montodescontado & " EL total es: " & subtotal - Montodescontado)
            Case >= 51 And cantidad <= 250
                descuento = 10
                subtotal = cantidad * precio
                Montodescontado = subtotal * descuento / 100
                Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & Montodescontado & " EL total es: " & subtotal - Montodescontado)
            Case > 250
                descuento = 20
                subtotal = cantidad * precio
                Montodescontado = subtotal * descuento / 100
                Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & Montodescontado & " EL total es: " & subtotal - Montodescontado)
            Case Else
                descuento = 0
                subtotal = precio
                Montodescontado = subtotal * descuento / 100
                Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & Montodescontado & " EL total es: " & subtotal - Montodescontado)
        End Select
        Console.ReadKey()



    End Sub


End Module
