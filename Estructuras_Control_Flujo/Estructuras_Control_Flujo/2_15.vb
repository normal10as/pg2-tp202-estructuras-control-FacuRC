Module _2_15
	'	2.15. Dado el siguiente planteo: se deposita un capital a un plazo de n meses, con una tasa de
	'interés de 36% anual (es una constante), capitalizable cada mes, es decir, se suman los intereses
	'ganados al capital. Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y
	'luego imprima el siguiente reporte
	'Donde:
	'MES: es el número de mes.
	'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
	'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2, deberá
	'tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
	'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor que
	'gana en el mes correspondiente.
	'SALDO: es el el capital sumado el interés.
	'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.
	Sub main()
		Dim Capital, totalInteres, interes As Decimal
		Dim InteresMensual As Decimal = 0.03
		Dim mes As Byte

		Console.Write("Ingrese capital Inicial: ")
		Capital = Console.ReadLine

		Console.Write("Ingrese cantidad de meses: ")
		mes = Console.ReadLine

		Console.WriteLine(vbCrLf & "{0, 4} {1, 15} {2, 15} {3, 15}", "Mes", "Capital", "Interes", "Saldo")

		For n = 1 To mes
			interes = Capital * InteresMensual
			totalInteres += interes
			Console.WriteLine("{0, 4} {1, 15} {2, 15} {3, 15}", Math.Round(n, 2), Math.Round(Capital, 2), Math.Round(interes, 2), Math.Round(Capital + interes, 2))
			Capital += interes
		Next

		Console.WriteLine(vbCrLf & "TOTAL INTERES GANADO:" & Math.Round(totalInteres, 2))

		Console.ReadKey()




	End Sub
End Module
