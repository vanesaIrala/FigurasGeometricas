Imports FigurasGeo
Module RectanguloTest
    Sub Main()
        Dim rectangulo1 As New Rectangulo
        rectangulo1.Nombre = "Rectangulo1"
        rectangulo1.Base = 3
        rectangulo1.Altura = 5
        Console.WriteLine("El Nombre: " & rectangulo1.Nombre)
        Console.WriteLine("La Base ingresada es: " & rectangulo1.Base)
        Console.WriteLine("La Altura ingresada es: " & rectangulo1.Altura)
        Console.WriteLine("El Area del Rectangulo es: " & rectangulo1.CalcularArea())
        Console.WriteLine()


        'Constructor sobrecargado
        Dim rectangulo2 As New Rectangulo("Rectangulo2", 6)
        Console.WriteLine("El Nombre: " & rectangulo2.Nombre)
        Console.WriteLine("La Altura ingresada es: " & rectangulo2.Altura)
        Console.WriteLine("El Area del Rectangulo es: " & rectangulo2.CalcularArea())
        Console.WriteLine()


        Console.ReadKey()
    End Sub

End Module
