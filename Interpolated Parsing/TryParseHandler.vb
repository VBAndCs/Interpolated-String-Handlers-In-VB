' To configure or remove Option's included in result, go to Options/Advanced Options...
Option Compare Text
Option Explicit On
Option Infer Off
Option Strict On

Imports System.Runtime.CompilerServices
<InterpolatedStringHandler>
Public Class TryParseHandler
    Private input As String
    Private strLength As Integer
    Private index As Integer = 0
    Public Result As Boolean = True

    Public Sub New(literalLength As Integer, formattedCount As Integer, input As String)
        Me.input = input
        strLength = input.Length
    End Sub
    Private Function Failed() As Boolean
        Result = False
        Return False
    End Function
    Public Function AppendLiteral(literal As String) As Boolean
        literal = literal.Trim()
        Dim i As Integer = input.IndexOf(literal, index)
        If i < 0 Then
            Return Failed()
        End If

        index = i + literal.Length
        Return True
    End Function

    Public Function AppendFormatted(placeholder1 As Placeholder(Of String)) As Boolean
        If index >= strLength Then
            placeholder1.Value = ""
        Else
            Dim start As Integer = index
            While index < strLength AndAlso (Char.IsLetterOrDigit(input(index)) OrElse input(index) = "_"c OrElse input(index) = " "c)
                index += 1
            End While

            placeholder1.Value = input.Substring(start, index - start).Trim()
        End If

        Return True
    End Function
    Public Function AppendFormatted(placeholder1 As Placeholder(Of Integer)) As Boolean
        Dim start As Integer = index
        While start < strLength AndAlso input(start) = " "c
            start += 1
        End While

        If start >= strLength Then
            Return Failed()
        End If

        index = start + 1
        While index < strLength AndAlso Char.IsDigit(input(index))
            index += 1
        End While

        If index - start = 0 Then
            Return Failed()
        End If

        placeholder1.Value = Convert.ToInt32(input.Substring(start, index - start))
        Return True
    End Function

End Class
