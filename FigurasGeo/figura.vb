Public Class Figura
    'Campos
    Private _nombre As String

    'Constructor
    Sub New()
        _nombre = ""
    End Sub

    'Constructor sobrecargado
    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    'Propiedades
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'Metodos
    Public Overridable Function CalcularArea() As Single
        Return 0
    End Function

End Class
