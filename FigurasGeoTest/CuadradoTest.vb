Imports FigurasGeo
Module CuadradoTest
    Sub Main()
        Dim cuadrado1 As New Cuadrado
        cuadrado1.Nombre = "Cuadrado1"
        cuadrado1.Lado = 3
        Console.WriteLine("El Nombre: " & cuadrado1.Nombre)
        Console.WriteLine("El Lado ingresado es: " & cuadrado1.Lado)
        Console.WriteLine("El Area del Cuadrado es: " & cuadrado1.CalcularArea())
        Console.WriteLine()

        'Constructor sobrecargado
        Dim cuadrado2 As New Cuadrado("Cuadrado2", 4)
        Console.WriteLine("El Nombre: " & cuadrado2.Nombre)
        Console.WriteLine("El Lado ingresado es: " & cuadrado2.Lado)
        Console.WriteLine("El Area del Cuadrado es: " & cuadrado2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module
