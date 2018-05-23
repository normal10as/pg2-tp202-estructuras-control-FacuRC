Module _2_5
    Enum Meses As Byte
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiembre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub main()
		'2.5. CASE. Crear un programa con una enumeración para los meses del año. Ingresar un valor
		'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
		'correspondiente.
		Dim Mes As Byte
		Console.WriteLine("Ingrese un mes segun su numero: ")
        Mes = Console.ReadLine
        Console.WriteLine("El mes que se desea buscar es el numero: " & Mes)

        Select Case Mes
            Case Meses.Enero
                Console.WriteLine("El mes numero 1 es: Enero")
            Case Meses.Febrero
				Console.WriteLine("El mes numero 2 es: Febrero")
			Case Meses.Marzo
                Console.WriteLine("El mes numero 3 es: Marzo")
            Case Meses.Abril
                Console.WriteLine("El mes numero 4 es: Abril")
            Case Meses.Mayo
                Console.WriteLine("El mes numero 5 es: Mayo")
            Case Meses.Junio
                Console.WriteLine("El mes numero 6 es: Junio")
            Case Meses.Julio
                Console.WriteLine("El mes numero 7 es: Julio")
            Case Meses.Agosto
                Console.WriteLine("El mes numero 8 es: Agosto")
            Case Meses.Septiembre
                Console.WriteLine("El mes numero 9 es: Septiembre")
            Case Meses.Octubre
                Console.WriteLine("El mes numero 10 es: Octubre")
            Case Meses.Noviembre
                Console.WriteLine("El mes numero 11 es: Noviembre")
            Case Meses.Diciembre
				Console.WriteLine("El mes numero 12 es: Diciembre")
			Case Else
		End Select
        Console.ReadKey()
    End Sub
End Module
