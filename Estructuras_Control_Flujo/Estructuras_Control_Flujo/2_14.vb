Module _2_14
	'Se ingresan repetitivamente dos valores relativos a un producto en venta: cantidad y
	'precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es
	'entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. Informar por
	'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
	'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
	'cero, informar el total de pesos descontados y el total a cobrar.
	Sub main()
		Dim cantidad, PrecioUnitario, subtotal, MontoDescontado As Decimal
		Dim descuento As Byte
		cantidad = 1
		Do While cantidad > 0
			Console.Write("Ingrese cantidad:")
			cantidad = Console.ReadLine
			cantidad += cantidad
			Console.Write("Ingrese Precio Unitario: ")
			PrecioUnitario = Console.ReadLine
			PrecioUnitario += PrecioUnitario
		Loop

		If cantidad >= 10 And cantidad <= 50 Then
			descuento = 5
		ElseIf cantidad > 50 And cantidad <= 250 Then
			descuento = 10
		ElseIf cantidad > 250 Then
			descuento = 20
		Else
			descuento = 0
		End If

		subtotal = cantidad * PrecioUnitario
		MontoDescontado = subtotal * descuento / 100

		Console.WriteLine("Subtotal:" & subtotal)
		Console.WriteLine("Porcentaje Descontado: " & descuento & "%")
		Console.WriteLine("Total de pesos Descontados: " & MontoDescontado)
		Console.WriteLine("Total a cobrar: " & subtotal - MontoDescontado)

		Console.ReadKey()

	End Sub
End Module
