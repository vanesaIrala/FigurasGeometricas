Imports FigurasGeo
Module TrianguloTest
    Sub Main()
        Dim triangulo1 As New Triangulo
        triangulo1.Nombre = "Triangulo1"
        triangulo1.Base = 30
        triangulo1.Altura = 50
        Console.WriteLine("El Nombre: " & triangulo1.Nombre)
        Console.WriteLine("La Base ingresada es: " & triangulo1.Base)
        Console.WriteLine("La Altura ingresada es: " & triangulo1.Altura)
        Console.WriteLine("El Area del Triangulo es: " & triangulo1.CalcularArea())
        Console.WriteLine()

        'Constructor sobrecargado
        Dim triangulo2 As New Triangulo("Triangulo2", 4, 6)
        Console.WriteLine("El Nombre igresado es: " & triangulo2.Nombre)
        Console.WriteLine("La Base ingresada es: " & triangulo2.Base)
        Console.WriteLine("La Altura ingresada es: " & triangulo2.Altura)
        Console.WriteLine("El Area del Triangulo es: " & triangulo2.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub



End Module
