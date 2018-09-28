Imports FigurasGeo
Module FiguraTest

    Sub Main()

        Dim figura1 As New figura
        figura1.Nombre = "Triangulo"
        Console.WriteLine("El Nombre: " & figura1.Nombre)
        Console.WriteLine("El Area de la Figura es: " & figura1.CalcularArea())
        Console.WriteLine()

        'Constructor sobrecargado
        Dim figura2 As New Figura("Cuadrado")
        Console.WriteLine("El Nombre: " & figura2.Nombre)
        Console.WriteLine("El Area de la Figura es: " & figura1.CalcularArea())
        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module
