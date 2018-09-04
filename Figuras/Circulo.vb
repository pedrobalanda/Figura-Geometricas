Public Class Circulo
    Inherits Figura

    Public _radio As UShort


    Public Sub New(Nombre As String, Radio As UShort)
        MyBase.Nombre = Nombre
        Me.Radio = 0
    End Sub

    Private Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    Public Overrides Function calcularArea() As Single

        Return (Math.PI * Radio) * (Math.PI * Radio)

    End Function
End Class
