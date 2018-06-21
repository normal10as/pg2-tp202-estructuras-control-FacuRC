Module _2_10
	'2.10. For y Do Loop. Crear un módulo para resolver el siguiente problema: con dos valores
	'numéricos enteros cualquiera, el primero menor al segundo, calcular cuantos números múltiplos
	'de cinco hay entre ellos e informar. Repetir esta solución en el mismo módulo con las diferentes
	'alternativas las estructuras de repetición “do while … loop”, “do until … loop”, “do … loop
	'while”, “do … loop until y “for”
	Sub main()
		Dim valor1, valor2, contador As Int16
		Console.Write("Ingrese un valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese un valor mayor al primero: ")
		valor2 = Console.ReadLine

		'>>>>>>>>>>>> DO WHILE LOOP <<<<<<<<<<<<<<<

		'Do While valor1 < valor2
		'	If valor1 Mod 5 = 0 Then
		'		contador += 1
		'	End If
		'	valor1 = valor1 + 1
		'Loop


		' >>>>>>>>>>>> DO LOOP WHILE  <<<<<<<<<<<<<<<

		'Do
		'	If valor1 Mod 5 = 0 Then
		'		contador = contador + 1
		'	End If
		'	valor1 = valor1 + 1
		'Loop While valor1 < valor2


		' >>>>>>>>>>>> DO UNTIL LOOP   <<<<<<<<<<<<<<<

		'Do Until valor1 >= valor2
		'	If valor1 Mod 5 = 0 Then
		'		contador = contador + 1
		'	End If
		'	valor1 = valor1 + 1
		'Loop




		' >>>>>>>>>>>> DO  LOOP UNTIL  <<<<<<<<<<<<<<<


		'Do
		'	If valor1 Mod 5 = 0 Then
		'		contador = contador + 1
		'	End If
		'	valor1 = valor1 + 1
		'Loop Until valor1 >= valor2



		' >>>>>>>>>>>>    FOR  <<<<<<<<<<<<<<<

		'For x = valor1 To valor2

		'	If valor1 Mod 5 = 0 Then
		'		contador = contador + 1
		'	End If
		'	valor1 = valor1 + 1

		'Next


		Console.WriteLine("La cantidad de multiplos de 5 que hay es igual a: " & contador)
		Console.ReadKey()
	End Sub
End Module