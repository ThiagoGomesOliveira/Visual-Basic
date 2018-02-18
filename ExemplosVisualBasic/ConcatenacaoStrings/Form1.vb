Public Class Form1
    Private Sub BtnTamanho_Click(sender As Object, e As EventArgs) Handles BtnTamanho.Click
        Dim nome As String
        nome = "Thiago Gomes Oliveira"
        lblString.Text = nome
        lblResultado.Text = nome.Length

    End Sub

    Private Sub BtnCaracter_Click(sender As Object, e As EventArgs) Handles BtnCaracter.Click

        Dim nome As String
        nome = "Thiago Gomes Oliveira"
        lblString.Text = nome
        lblResultado.Text = nome.Chars(4)


    End Sub

    Private Sub BtnConcatenar_Click(sender As Object, e As EventArgs) Handles BtnConcatenar.Click
        Dim nome As String
        Dim profissao As String
        nome = "Thiago Gomes Oliveira"
        profissao = "Programador"
        lblString.Text = nome
        lblResultado.Text = nome + " " + profissao
    End Sub

    Private Sub BtnJuntar_Click(sender As Object, e As EventArgs) Handles BtnJuntar.Click
        Dim nome As String
        nome = "Thiago Gomes Oliveira"
        lblString.Text = nome
        lblResultado.Text = nome.Replace("Gomes", "G")
    End Sub

    Private Sub BtnMaisc_Click(sender As Object, e As EventArgs) Handles BtnMaisc.Click
        Dim nome As String
        nome = "Thiago Gomes Oliveira"
        lblString.Text = nome
        lblResultado.Text = nome.ToUpper
    End Sub

    Private Sub BtnMinusc_Click(sender As Object, e As EventArgs) Handles BtnMinusc.Click
        Dim nome As String
        nome = "Thiago Gomes Oliveira"
        lblString.Text = nome
        lblResultado.Text = nome.ToLower
    End Sub

End Class
