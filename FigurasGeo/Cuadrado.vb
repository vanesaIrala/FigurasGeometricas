Public Class Cuadrado
    Inherits Figura

    'Campos
    Private _lado As UShort

    'Constructor
    Sub New()
        MyBase.New()
        _lado = 0
    End Sub

    'Constructor sobrecargado
    Sub New(nombre As String, lado As UShort)
        MyBase.New(nombre) 'llama al constru
        Me.Lado = lado
    End Sub

    'Propiedades
    Public Property Lado As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = value
        End Set
    End Property

    'Metodos
    Public Overrides Function CalcularArea() As Single
        Return 3
    End Function
End Class
