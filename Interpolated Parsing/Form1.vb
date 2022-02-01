Imports System.Windows.Forms

Partial Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Dim name As New Placeholder(Of String)()
        Dim age As New Placeholder(Of Integer)()
        Dim city As New Placeholder(Of String)()

        txtInput.Text.TryParse($"Name: {name} Age: {age} City: {city}.")
        txtName.Text = name.ToString()
        txtAge.Text = age.ToString()
        txtCity.Text = city.ToString()
    End Sub
End Class
