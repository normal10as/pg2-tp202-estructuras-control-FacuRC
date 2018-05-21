Module _2_7
    Sub main()
        Dim angulo As Byte
        Console.WriteLine("Ingrese grados del angulo")
        angulo = Console.ReadLine
        Select Case angulo
            Case < 90
                Console.WriteLine("Es Agudo")
            Case = 90
                Console.WriteLine("Es recto")
            Case > 90 And angulo < 180
                Console.WriteLine("Es Obtuso")
            Case = 180
                Console.WriteLine("Es Llano")
            Case > 180 And angulo < 36
                Console.WriteLine("Es Concavo")
            Case Else
                Console.WriteLine("Error, valor incorrecto")


        End Select
        Console.ReadKey()

    End Sub
End Module
