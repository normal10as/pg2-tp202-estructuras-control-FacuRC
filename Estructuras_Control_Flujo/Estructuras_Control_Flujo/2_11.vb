Module _2_11
	'Utilizando la estructura de repetición más adecuada para un programa que se ingresen
	'valores enteros hasta que se ingrese cero (descartar negativos). Luego informar cuantos
	'pares y cuantos impares. Si todos son pares o todos son impares informa esta situación
	'particular en lugar de la consigna anterior.

	Sub principal()

		Dim contpares As UInt16 = 0
		Dim contimpares As UInt16 = 0
		Dim valor1 As Integer
		Dim valor2 As Integer
		Do
			Console.WriteLine("Ingrese un valor:")
			valor1 = Console.ReadLine
			If valor1 Mod 2 = 0 Then
				contpares += 1
			Else
				contimpares += 1
			End If

			Console.WriteLine("Ingrese otro valor:")
			valor2 = Console.ReadLine
			If valor2 Mod 2 = 0 Then
				contpares += 1
			Else
				contimpares += 1
			End If


		Loop Until (valor1 = 0 And valor2 = 0)

		Console.WriteLine()

		If contpares = 0 Then
			Console.WriteLine("Todos los numeros ingresados ​​son Impares")
		ElseIf contimpares = 0 Then
			Console.WriteLine("Todos los numeros ingresados ​​son Pares")
		Else
			Console.WriteLine("cantidad de numeros Pares ingresados:" & contpares)
			Console.WriteLine("Cantidad de numeros Impares Ingresados:" & contimpares)
		End If
		Console.WriteLine("")

		Console.ReadKey()

	End Sub
End Module