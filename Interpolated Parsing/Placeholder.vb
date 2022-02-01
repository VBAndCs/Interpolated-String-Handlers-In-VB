' To configure or remove Option's included in result, go to Options/Advanced Options...
Option Compare Text
Option Explicit On
Option Infer Off
Option Strict On

Public Class Placeholder(Of T)
    Private _value As T

    Public Property Value As T
        Get
            Return _value
        End Get

        Set(Value As T)
            Found = True
            _value = Value
        End Set
    End Property

    Public Found As Boolean = False

    Public Overrides Function ToString() As String
        If Found Then
            Return value?.ToString()
        End If

        Return "Not Found"
    End Function
End Class

