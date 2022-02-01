Imports System.Runtime.CompilerServices
Imports System.Text

Public Module ParsingExtensions
    <Extension()>
    Public Function TryParse(input As String, s As FormattableString) As Boolean
        Dim handler As New TryParseHandler(0, 0, input)
        Dim x = s.Format
        Dim start = 0
        For i = 0 To s.ArgumentCount - 1
            Dim arg = String.Concat("{", i.ToString(), "}")
            Dim pos = x.IndexOf(arg, start)
            If handler.AppendLiteral(x.Substring(start, pos - start)) Then
                If Not handler.AppendFormatted(s.GetArgument(i)) Then
                    Return False
                End If
            End If
            start = pos + arg.Length
        Next

        If start < x.Length Then handler.AppendLiteral(x.Substring(start))

        Return handler.Result
    End Function

End Module

Public Module JoinerExtensions
        <Extension()>
        Public Function CrLf(input As String) As Joiner
            Dim j As New Joiner
            Return j.add(input).add(vbCrLf)
        End Function

        <Extension()>
        Public Function add(input As String, s As String) As Joiner
            Dim j As New Joiner
            Return j.add(input).add(s)
        End Function

        <Extension()>
        Public Function add(Of T)(input As String, obj As T, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
            Dim j As New Joiner
            Return j.add(input).add(obj, alignment, format)
        End Function

        <Extension()>
        Public Function add(Of T)(input As String, str As String, obj As T, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
            Dim j As New Joiner
            Return j.add(input).add(str).add(obj, alignment, format)
        End Function

        <Extension()>
        Public Function str(input As String, s As String) As Joiner
            Dim j As New Joiner
            Return j.add(input).add(s)
        End Function

        <Extension()>
        Public Function arg(Of T)(input As String, obj As T, Optional alignment As Integer = 0, Optional forma As String = "") As Joiner
            Dim j As New Joiner
            Return j.add(input).add(obj, alignment, forma)
        End Function


    End Module


    Public Class Joiner
    Dim sb As New StringBuilder
    Dim handler As New StringBuilder.AppendInterpolatedStringHandler(100, 5, sb)

    Public Function add(s As String) As Joiner
        sb.Append(s)
        Return Me
    End Function

    Public Function add(Of T)(obj As T, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
        handler.AppendFormatted(obj, alignment, format)
        Return Me
    End Function

    Public Function add(Of T)(str As String, obj As T, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
        sb.Append(str)
        handler.AppendFormatted(obj, alignment, format)
        Return Me
    End Function

    Public Function str(s As String) As Joiner
        sb.Append(s)
        Return Me
    End Function

    Public Function arg(Of T)(obj As T, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
        handler.AppendFormatted(obj, alignment, format)
        Return Me
    End Function

    Public Function CrLf() As Joiner
        sb.Append(vbCrLf)
        Return Me
    End Function

    Default Public ReadOnly Property adding(s As String) As Joiner
        Get
            sb.Append(s)
            Return Me
        End Get
    End Property

    Default Public ReadOnly Property adding(obj As Object, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
        Get
            handler.AppendFormatted(obj, alignment, format)
            Return Me
        End Get
    End Property

    Default Public ReadOnly Property adding(str As String, obj As Object, Optional alignment As Integer = 0, Optional format As String = "") As Joiner
        Get
            sb.Append(str)
            handler.AppendFormatted(obj, alignment, format)
            Return Me
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return sb.ToString()
    End Function

    Public Shared Widening Operator CType(j As Joiner) As String
        Return j.ToString()
    End Operator
End Class

