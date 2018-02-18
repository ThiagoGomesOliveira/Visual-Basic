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
        Me.lblString = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.BtnTamanho = New System.Windows.Forms.Button()
        Me.BtnCaracter = New System.Windows.Forms.Button()
        Me.BtnConcatenar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblString
        '
        Me.lblString.AutoSize = True
        Me.lblString.Location = New System.Drawing.Point(102, 27)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(0, 13)
        Me.lblString.TabIndex = 0
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(64, 74)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblResultado.TabIndex = 1
        '
        'BtnTamanho
        '
        Me.BtnTamanho.Location = New System.Drawing.Point(12, 114)
        Me.BtnTamanho.Name = "BtnTamanho"
        Me.BtnTamanho.Size = New System.Drawing.Size(75, 23)
        Me.BtnTamanho.TabIndex = 2
        Me.BtnTamanho.Text = "Tamanho"
        Me.BtnTamanho.UseVisualStyleBackColor = True
        '
        'BtnCaracter
        '
        Me.BtnCaracter.Location = New System.Drawing.Point(105, 114)
        Me.BtnCaracter.Name = "BtnCaracter"
        Me.BtnCaracter.Size = New System.Drawing.Size(75, 23)
        Me.BtnCaracter.TabIndex = 3
        Me.BtnCaracter.Text = "Caracter"
        Me.BtnCaracter.UseVisualStyleBackColor = True
        '
        'BtnConcatenar
        '
        Me.BtnConcatenar.Location = New System.Drawing.Point(197, 114)
        Me.BtnConcatenar.Name = "BtnConcatenar"
        Me.BtnConcatenar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConcatenar.TabIndex = 4
        Me.BtnConcatenar.Text = "Concatenar"
        Me.BtnConcatenar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnConcatenar)
        Me.Controls.Add(Me.BtnCaracter)
        Me.Controls.Add(Me.BtnTamanho)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblString)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblString As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents BtnTamanho As Button
    Friend WithEvents BtnCaracter As Button
    Friend WithEvents BtnConcatenar As Button
End Class
