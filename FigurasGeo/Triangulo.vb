Public Class Triangulo
    Inherits Figura

    'Campos
    Private _base As UShort
    Private _altura As UShort

    'Constructor
    Sub New()
        MyBase.New()
        _base = 0
        _altura = 0
    End Sub

    'Constructor sobrecargado
    Sub New(nombre As String, base As UShort, altura As UShort)
        MyBase.New(nombre) 'llama al constru
        Me.Base = base
        Me.Altura = altura
    End Sub

    'Propiedades
    Public Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property

    Public Property Altura As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property

    'Metodos
    Public Overrides Function CalcularArea() As Single
        Return 1
    End Function

End Class
