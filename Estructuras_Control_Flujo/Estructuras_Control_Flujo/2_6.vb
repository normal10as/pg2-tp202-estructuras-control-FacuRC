Module _2_6
    '2.6. Resolver el problema 2.4 con CASE
    Sub main()
        Dim precio As Single

        Console.Write("Ingrese Precio: ")
        precio = Console.ReadLine
        Dim descuento, subtotal, Montodescontado, cantidad As Integer
		Console.Write("Ingrese cantidad: ")
		cantidad = Console.ReadLine

		Select Case cantidad
			Case 10 To 50
				descuento = 5
				subtotal = cantidad * precio
				Montodescontado = subtotal * descuento / 100
			Case 51 To 250
				descuento = 10
				subtotal = cantidad * precio
				Montodescontado = subtotal * descuento / 100
			Case > 250
				descuento = 20
				subtotal = cantidad * precio
				Montodescontado = subtotal * descuento / 100
			Case Else
				descuento = 0
				subtotal = precio * cantidad
				Montodescontado = subtotal * descuento / 100
		End Select
		Console.WriteLine("El subtotal es: " & subtotal)
		Console.WriteLine("El porcentaje Descontado es: " & descuento & "%")
		Console.WriteLine("El monto descontado es: " & Montodescontado)
		Console.WriteLine("el total es:" & subtotal - Montodescontado)
		Console.ReadKey()



    End Sub


End Module
