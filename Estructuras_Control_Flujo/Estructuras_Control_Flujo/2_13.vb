Module _2_13
	'2.13. Obtener los números primos menores a mil. En matemáticas, un número primo es un
	'número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.
	Sub main()
		Dim divisor As UShort
		Dim primo As Integer

		For x = 1 To 1000
			divisor = 1
			primo = 0
			Do
				If x Mod divisor = 0 Then
					primo += 1
				End If
				divisor += 1
			Loop While divisor <= x
			If primo = 2 Then
				Console.Write(" " & x)
			End If
		Next

		Console.ReadKey()
	End Sub
End Module
