Option Compare Text
Option Explicit On
Option Infer Off
Option Strict On
' To configure or remove Option's included in result, go to Options/Advanced Options...
Imports System.Windows.Forms

Namespace Interpolated_Parsing
    Friend Module Program
        ''' <summary>
        '''  The main entry point for the application.
        ''' </summary>
        <STAThread>
        Public Sub Main()
            ' To customize application configuration such as set high DPI settings or default font,
            ' see https://aka.ms/applicationconfiguration.
            Application.Run(New Form1)
        End Sub
    End Module
End Namespace
