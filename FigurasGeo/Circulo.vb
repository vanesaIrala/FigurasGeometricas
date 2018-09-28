Public Class Circulo
    Inherits Figura

    'Campos
    Private _radio As UShort

    'Constructor
    Sub New()
        MyBase.New()
        _radio = 0
    End Sub

    'Constructor sobrecargado
    Sub New(nombre As String, radio As UShort)
        MyBase.New(nombre) 'llama al constru
        Me.Radio = radio
    End Sub

    'Propiedades
    Public Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    'Metodos
    Public Overrides Function CalcularArea() As Single
        Return 4
    End Function
End Class
