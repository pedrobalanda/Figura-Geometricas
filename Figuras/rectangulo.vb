Public Class rectangulo
    Inherits Figura

    Public _base As UShort
    Public _altura As UShort

    Public Sub New(Nombre As String, Base As UShort, altura As UShort)
        MyBase.Nombre = Nombre
        Me.Altura = 0
        Me.Base = 0
    End Sub

    Private Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property

    Private Property Altura As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property

    Public Overrides Function calcularArea() As Single

        Return (Base * Altura)
    End Function
End Class
