Imports FigurasGeo
Module CirculoTest
    Sub Main()
        Dim circulo1 As New Circulo()
        circulo1.Nombre = "Circulo1"
        circulo1.Radio = 3
        Console.WriteLine("El Nombre: " & circulo1.Nombre)
        Console.WriteLine("El Radio ingresado es: " & circulo1.Radio)
        Console.WriteLine("El Area del Circulo es: " & circulo1.CalcularArea())
        Console.WriteLine()

        'Constructor sobrecargado
        Dim circulo2 As New Circulo("Circulo2", 4)
        Console.WriteLine("El Nombre : " & circulo2.Nombre)
        Console.WriteLine("El Radio ingresado es: " & circulo2.Radio)
        Console.WriteLine("El Area del Circulo es: " & circulo2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module
