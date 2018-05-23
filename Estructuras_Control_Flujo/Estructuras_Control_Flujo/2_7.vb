Module _2_7
    Sub main()
		Dim angulo As Int16
		Console.Write("Ingrese grados del angulo: ")
        angulo = Console.ReadLine

        Select Case angulo
            Case < 90
                Console.WriteLine("Es Agudo")
            Case = 90
                Console.WriteLine("Es recto")
			Case 91 To 179
				Console.WriteLine("Es Obtuso")
            Case = 180
                Console.WriteLine("Es Llano")
			Case 181 To 360
				Console.WriteLine("Es Concavo")
            Case Else
                Console.WriteLine("Error, valor incorrecto")


        End Select
        Console.ReadKey()

    End Sub
End Module
