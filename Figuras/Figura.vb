﻿Public Class Figura
    Private _nombre As String

    Sub New()
        Me.Nombre = ""
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overridable Function calcularArea() As Single
        Return 0
    End Function

End Class
