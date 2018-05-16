Module _2_4
    '2.4.Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).
    Sub main()
        Dim cantidad, precio, subtotal, descuento, MontoDescontado As Decimal
        Console.WriteLine("Ingrese el precio unitario: ")
        precio = Console.ReadLine
        Console.WriteLine("Ingrese cantidad")
        cantidad = Console.ReadLine

        If cantidad >= 10 And cantidad <= 50 Then
            descuento = 5
            subtotal = cantidad * precio
            MontoDescontado = subtotal * descuento / 100
            Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & MontoDescontado & " EL total es: " & subtotal - MontoDescontado)
        End If
        If cantidad >= 51 And cantidad <= 250 Then
            descuento = 10
            subtotal = cantidad * precio
            MontoDescontado = subtotal * descuento / 100
            Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & MontoDescontado & " EL total es: " & subtotal - MontoDescontado)
        End If
        If cantidad >= 251 Then
            descuento = 20
            subtotal = cantidad * precio
            MontoDescontado = subtotal * descuento / 100
            Console.WriteLine("Subtotal: " & subtotal & "Porcentaje descontado: " & descuento & " % " & " Monto Descontado: " & MontoDescontado & " EL total es: " & subtotal - MontoDescontado)
        End If
        Console.ReadKey()
    End Sub
End Module
