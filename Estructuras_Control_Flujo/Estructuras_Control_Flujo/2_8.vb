Module _2_8
    '2.8. Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    ' El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    ' En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
    'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
    Enum Meses As Byte
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub main()
        Dim Mes As Meses
        Dim x, año As Int16

        Console.WriteLine("Ingrese un mes: ")
        Mes = Console.ReadLine
        Console.WriteLine("Ingrese un año: ")
        año = Console.ReadLine

        Select Case Mes
            Case Meses.Enero
                Console.WriteLine(Mes.ToString & " La cantidad de dias de enero es: 31")
			Case Meses.Febrero

				x = System.DateTime.DaysInMonth(año, Meses.Febrero)
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Marzo
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Abril
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Mayo
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Junio
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Julio
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Agosto
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Septiembre
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Octubre
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Noviembre
                Console.WriteLine("La cantidad de dias de enero es: " & x)
            Case Meses.Diciembre
                Console.WriteLine("La cantidad de dias de enero es: " & x)
        End Select


        Console.ReadKey()


    End Sub

End Module
