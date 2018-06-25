Module _2_9
	'2.9. Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros,
	'centímetros, yardas, pies y pulgadas:
	' Presentar un menú y preguntar que unidad de medida desea convertir, el valor a convertir y
	'después mostrar las equivalencias.
	' Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
	'pulgada = 2.54 cm, 1 metro = 100 cm.
	' Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
	'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.
	Sub main()
		Dim centimetros, metros, pulgadas, yardas, pies, valor As Decimal
		Dim UnidadMedida1, UnidadMedida2 As String

		centimetros = 1
		metros = centimetros * 100
		pulgadas = centimetros * 2.54
		pies = pulgadas * 12
		yardas = pies * 3

		Console.Write("Ingrese unidad de medida a convertir: ")
		UnidadMedida1 = Console.ReadLine

		Console.Write("Ingrese el valor a convertir ")
		valor = Console.ReadLine


		If UnidadMedida1 = "centimetros" Then
			centimetros = valor
			metros = valor / 100
			yardas = valor / pies / 3
			pies = valor / pulgadas / 12
			pulgadas = valor / 2.54

		ElseIf UnidadMedida1 = "metros" Then
			centimetros = valor * 100
			yardas = valor / yardas * metros
			pies = valor / pies * metros
			pulgadas = valor / pulgadas * metros
			metros = valor
		ElseIf UnidadMedida1 = "pulgadas" Then
			centimetros = valor / centimetros * pulgadas
			metros = valor / metros * pulgadas
			yardas = valor / yardas * pulgadas
			pies = valor / pies * pulgadas
			pulgadas = valor
		ElseIf UnidadMedida1 = "yardas" Then
			centimetros = valor / centimetros * yardas
			metros = valor / metros * yardas
			pies = valor / pies * yardas
			pulgadas = valor / pulgadas * yardas
			yardas = valor
		ElseIf UnidadMedida1 = "pies" Then
			centimetros = valor / centimetros * pies
			metros = valor / metros * pies
			pulgadas = valor / pulgadas * pies
			yardas = valor / yardas * pies
			pies = valor
		End If
		Console.WriteLine(vbCrLf)
		Console.WriteLine("La Unidad de medida que eligio es, " & UnidadMedida1 & " y todas las conversiones posible del caso a continuacion . ")
		Console.WriteLine(vbCrLf)
		Console.WriteLine(valor & " " & UnidadMedida1 & " =  {0} centimetros. ", centimetros)
		Console.WriteLine(valor & " " & UnidadMedida1 & " =  {0} metros. ", metros)
		Console.WriteLine(valor & " " & UnidadMedida1 & " =  {0} pies. ", pies)
		Console.WriteLine(valor & " " & UnidadMedida1 & " =  {0} yardas. ", yardas)
		Console.WriteLine(valor & " " & UnidadMedida1 & " =  {0} pulgadas ", pulgadas)
		Console.ReadKey()

	End Sub
End Module