Module _2_12
	'2.12. Utilizando la estructura de repetición más adecuada elaborar Los números de Fibonacci
	'constituyen una secuencia que empieza con 0 y 1; el número que sigue a éstos se calcula
	'sumando los dos anteriores y así sucesivamente. Utilizando la estructura de repetición más
	'adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia.
	Sub main()
		Dim num1 As Int16 = 0
		Dim num2 As Int16 = 1

		For x = 1 To 10
			num1 += num2
			Console.WriteLine(num1)
			num2 += num1
			Console.WriteLine(num2)
		Next

		Console.ReadKey()
	End Sub
End Module
