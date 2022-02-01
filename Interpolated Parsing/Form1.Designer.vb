Imports System.Windows.Forms

Partial Class Form1
    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing
    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(170, 103)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(140, 46)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Parse"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.Location = New System.Drawing.Point(13, 23)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(522, 47)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "My Name: Andrew; Age: 31 years; City: Cairo"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 177)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(357, 39)
        Me.txtName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(104, 241)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(357, 39)
        Me.txtAge.TabIndex = 3
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 180)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 35)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(23, 244)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 35)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Age"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(104, 303)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(357, 39)
        Me.txtCity.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(23, 306)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 35)
        Me.label3.TabIndex = 4
        Me.label3.Text = "City"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 353)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private WithEvents button1 As Button
    Private txtInput As TextBox
    Private txtName As TextBox
    Private txtAge As TextBox
    Private label1 As Label
    Private label2 As Label
    Private txtCity As TextBox
    Private label3 As Label
End Class
