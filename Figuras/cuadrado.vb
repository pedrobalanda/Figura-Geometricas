Public Class cuadrado
    Inherits Figura

    Public _lado As UShort


    Public Sub New(Nombre As String, lado As UShort)
        MyBase.Nombre = Nombre
        Me.Lado = 0
    End Sub

    Private Property Lado As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = value
        End Set
    End Property


    Public Overrides Function calcularArea() As Single
        Dim area As Single
        area = (Lado * Lado)
        Return area
    End Function
End Class
