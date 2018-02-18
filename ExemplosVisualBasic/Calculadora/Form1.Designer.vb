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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDivisao = New System.Windows.Forms.Button()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.BtnSubtracao = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMultiplicacao = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'btnDivisao
        '
        Me.btnDivisao.Location = New System.Drawing.Point(122, 45)
        Me.btnDivisao.Name = "btnDivisao"
        Me.btnDivisao.Size = New System.Drawing.Size(44, 23)
        Me.btnDivisao.TabIndex = 1
        Me.btnDivisao.Text = "/"
        Me.btnDivisao.UseVisualStyleBackColor = True
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(25, 47)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(73, 20)
        Me.TxtNum1.TabIndex = 2
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(25, 96)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(73, 20)
        Me.TxtNum2.TabIndex = 5
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(122, 94)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(44, 23)
        Me.btnSoma.TabIndex = 4
        Me.btnSoma.Text = "+"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2"
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(25, 148)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(73, 20)
        Me.TxtResultado.TabIndex = 8
        '
        'BtnSubtracao
        '
        Me.BtnSubtracao.Location = New System.Drawing.Point(179, 96)
        Me.BtnSubtracao.Name = "BtnSubtracao"
        Me.BtnSubtracao.Size = New System.Drawing.Size(44, 23)
        Me.BtnSubtracao.TabIndex = 7
        Me.BtnSubtracao.Text = "-"
        Me.BtnSubtracao.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'BtnMultiplicacao
        '
        Me.BtnMultiplicacao.Location = New System.Drawing.Point(179, 44)
        Me.BtnMultiplicacao.Name = "BtnMultiplicacao"
        Me.BtnMultiplicacao.Size = New System.Drawing.Size(44, 23)
        Me.BtnMultiplicacao.TabIndex = 9
        Me.BtnMultiplicacao.Text = "*"
        Me.BtnMultiplicacao.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 186)
        Me.Controls.Add(Me.BtnMultiplicacao)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.BtnSubtracao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.btnDivisao)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDivisao As Button
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents btnSoma As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents BtnSubtracao As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnMultiplicacao As Button
End Class
