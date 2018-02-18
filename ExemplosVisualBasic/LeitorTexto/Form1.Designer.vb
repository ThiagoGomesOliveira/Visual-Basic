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
        Me.txtTexto2 = New System.Windows.Forms.TextBox()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTexto2
        '
        Me.txtTexto2.Location = New System.Drawing.Point(1, 61)
        Me.txtTexto2.Multiline = True
        Me.txtTexto2.Name = "txtTexto2"
        Me.txtTexto2.Size = New System.Drawing.Size(436, 300)
        Me.txtTexto2.TabIndex = 0
        '
        'BtnLoad
        '
        Me.BtnLoad.Location = New System.Drawing.Point(12, 32)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoad.TabIndex = 1
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Procurar:"
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(217, 35)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(100, 20)
        Me.txtEntrada.TabIndex = 3
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(323, 32)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 340)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.txtTexto2)
        Me.Name = "Form1"
        Me.Text = "Leitor de Texto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto2 As TextBox
    Friend WithEvents BtnLoad As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents BtnBuscar As Button

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        'criar uma  variavel abra a caixa de dialogo
        Dim arqSelect As OpenFileDialog = New OpenFileDialog
        'abrindo caixa de dialogo
        Dim result As DialogResult = arqSelect.ShowDialog
        Dim nomeArq As String
        nomeArq = arqSelect.FileName
        'Criando uma variavel para ler o arquivo
        Dim stream As System.IO.StreamReader
        stream = New System.IO.StreamReader(nomeArq)
        'mostrar na txt entrada o arquivo selecionado
        txtTexto2.Text = stream.ReadToEnd

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim position As Integer
        Dim lenght As Integer
        Dim text As String
        Dim textfind As String

        'passando o texto para a variavel textfind
        textfind = txtEntrada.Text
        text = txtTexto2.Text
        position = text.IndexOf(textfind)
        lenght = textfind.Length

        If position > -1 Then
            txtTexto2.Select(position, lenght)
            txtTexto2.Focus()
        Else
            MessageBox.Show("Texto não encontrado")
        End If

    End Sub
End Class
