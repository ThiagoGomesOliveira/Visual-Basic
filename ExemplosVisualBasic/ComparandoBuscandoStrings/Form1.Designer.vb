<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblString1 = New System.Windows.Forms.Label()
        Me.lblString2 = New System.Windows.Forms.Label()
        Me.lblString3 = New System.Windows.Forms.Label()
        Me.BtnIgual = New System.Windows.Forms.Button()
        Me.BtnCompareTo = New System.Windows.Forms.Button()
        Me.BtnIncio = New System.Windows.Forms.Button()
        Me.BtnFinal = New System.Windows.Forms.Button()
        Me.BtnIndexOf = New System.Windows.Forms.Button()
        Me.BtnIndice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblString1
        '
        Me.lblString1.AutoSize = True
        Me.lblString1.Location = New System.Drawing.Point(12, 47)
        Me.lblString1.Name = "lblString1"
        Me.lblString1.Size = New System.Drawing.Size(0, 13)
        Me.lblString1.TabIndex = 0
        '
        'lblString2
        '
        Me.lblString2.AutoSize = True
        Me.lblString2.Location = New System.Drawing.Point(12, 79)
        Me.lblString2.Name = "lblString2"
        Me.lblString2.Size = New System.Drawing.Size(0, 13)
        Me.lblString2.TabIndex = 1
        '
        'lblString3
        '
        Me.lblString3.AutoSize = True
        Me.lblString3.Location = New System.Drawing.Point(12, 108)
        Me.lblString3.Name = "lblString3"
        Me.lblString3.Size = New System.Drawing.Size(0, 13)
        Me.lblString3.TabIndex = 2
        '
        'BtnIgual
        '
        Me.BtnIgual.Location = New System.Drawing.Point(15, 170)
        Me.BtnIgual.Name = "BtnIgual"
        Me.BtnIgual.Size = New System.Drawing.Size(75, 23)
        Me.BtnIgual.TabIndex = 3
        Me.BtnIgual.Text = "="
        Me.BtnIgual.UseVisualStyleBackColor = True
        '
        'BtnCompareTo
        '
        Me.BtnCompareTo.Location = New System.Drawing.Point(112, 170)
        Me.BtnCompareTo.Name = "BtnCompareTo"
        Me.BtnCompareTo.Size = New System.Drawing.Size(75, 23)
        Me.BtnCompareTo.TabIndex = 4
        Me.BtnCompareTo.Text = "CompareTo"
        Me.BtnCompareTo.UseVisualStyleBackColor = True
        '
        'BtnIncio
        '
        Me.BtnIncio.Location = New System.Drawing.Point(15, 199)
        Me.BtnIncio.Name = "BtnIncio"
        Me.BtnIncio.Size = New System.Drawing.Size(75, 23)
        Me.BtnIncio.TabIndex = 5
        Me.BtnIncio.Text = "Inicio"
        Me.BtnIncio.UseVisualStyleBackColor = True
        '
        'BtnFinal
        '
        Me.BtnFinal.Location = New System.Drawing.Point(112, 199)
        Me.BtnFinal.Name = "BtnFinal"
        Me.BtnFinal.Size = New System.Drawing.Size(75, 23)
        Me.BtnFinal.TabIndex = 6
        Me.BtnFinal.Text = "Final"
        Me.BtnFinal.UseVisualStyleBackColor = True
        '
        'BtnIndexOf
        '
        Me.BtnIndexOf.Location = New System.Drawing.Point(15, 228)
        Me.BtnIndexOf.Name = "BtnIndexOf"
        Me.BtnIndexOf.Size = New System.Drawing.Size(75, 23)
        Me.BtnIndexOf.TabIndex = 7
        Me.BtnIndexOf.Text = "IndexOf"
        Me.BtnIndexOf.UseVisualStyleBackColor = True
        '
        'BtnIndice
        '
        Me.BtnIndice.Location = New System.Drawing.Point(112, 228)
        Me.BtnIndice.Name = "BtnIndice"
        Me.BtnIndice.Size = New System.Drawing.Size(75, 23)
        Me.BtnIndice.TabIndex = 8
        Me.BtnIndice.Text = "Indice"
        Me.BtnIndice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 261)
        Me.Controls.Add(Me.BtnIndice)
        Me.Controls.Add(Me.BtnIndexOf)
        Me.Controls.Add(Me.BtnFinal)
        Me.Controls.Add(Me.BtnIncio)
        Me.Controls.Add(Me.BtnCompareTo)
        Me.Controls.Add(Me.BtnIgual)
        Me.Controls.Add(Me.lblString3)
        Me.Controls.Add(Me.lblString2)
        Me.Controls.Add(Me.lblString1)
        Me.Name = "Form1"
        Me.Text = "String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblString1 As Label
    Friend WithEvents lblString2 As Label
    Friend WithEvents lblString3 As Label
    Friend WithEvents BtnIgual As Button
    Friend WithEvents BtnCompareTo As Button
    Friend WithEvents BtnIncio As Button
    Friend WithEvents BtnFinal As Button
    Friend WithEvents BtnIndexOf As Button
    Friend WithEvents BtnIndice As Button

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click

        Dim nome1 As String
        Dim nome2 As String

        nome1 = "Thiago Gomes Oliveira"
        nome2 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString2.Text = nome2

        If nome1 = nome2 Then
            lblString3.Text = "As Strings São Iguais"
        Else
            lblString3.Text = "As Strings São Diferentes"
        End If


    End Sub

    Private Sub BtnCompareTo_Click(sender As Object, e As EventArgs) Handles BtnCompareTo.Click
        Dim nome1 As String
        Dim nome2 As String

        nome1 = "Thiago Gomes Oliveira"
        nome2 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString2.Text = nome2

        lblString3.Text = nome1.CompareTo(nome2)
    End Sub

    Private Sub BtnIncio_Click(sender As Object, e As EventArgs) Handles BtnIncio.Click

        Dim nome1 As String
        nome1 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString3.Text = nome1.StartsWith("Thi")


    End Sub

    Private Sub BtnFinal_Click(sender As Object, e As EventArgs) Handles BtnFinal.Click
        Dim nome1 As String
        nome1 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString3.Text = nome1.EndsWith("ira")

    End Sub

    Private Sub BtnIndexOf_Click(sender As Object, e As EventArgs) Handles BtnIndexOf.Click
        Dim nome1 As String
        nome1 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString3.Text = nome1.IndexOf("Gom")
        'pegando o indice na string
    End Sub

    Private Sub BtnIndice_Click(sender As Object, e As EventArgs) Handles BtnIndice.Click
        Dim nome1 As String
        nome1 = "Thiago Gomes Oliveira"
        lblString1.Text = nome1
        lblString3.Text = nome1.Substring("6,7")
    End Sub
End Class
