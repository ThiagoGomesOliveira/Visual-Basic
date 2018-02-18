Public Class Form1
    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        TxtResultado.Text = CStr(CalcDivisao(CInt(TxtNum1.Text), CInt(TxtNum2.Text)))
    End Sub

    Private Sub BtnMultiplicacao_Click(sender As Object, e As EventArgs) Handles BtnMultiplicacao.Click
        TxtResultado.Text = CStr(CalcMultiplicao(CInt(TxtNum1.Text), CInt(TxtNum2.Text)))
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        TxtResultado.Text = CStr(CalcSoma(CInt(TxtNum1.Text), CInt(TxtNum2.Text)))
    End Sub

    Private Sub BtnSubtracao_Click(sender As Object, e As EventArgs) Handles BtnSubtracao.Click
        TxtResultado.Text = CStr(CalcSubtracao(CInt(TxtNum1.Text), CInt(TxtNum2.Text)))
    End Sub
    'funcao de calculo de divisao
    Function CalcDivisao(ByVal TxtNum1 As Integer, TxtNum2 As Integer) As Decimal
        Dim resultado As Decimal
        resultado = TxtNum1 / TxtNum2
        Return resultado
    End Function

    'funcao de calculo de Multiplicação
    Function CalcMultiplicao(ByVal TxtNum1 As Integer, TxtNum2 As Integer) As Integer
        Dim resultado As Integer
        resultado = TxtNum1 * TxtNum2
        Return resultado
    End Function

    'funcao de calculo de Soma
    Function CalcSoma(ByVal TxtNum1 As Integer, TxtNum2 As Integer) As Integer
        Dim resultado As Integer
        resultado = TxtNum1 + TxtNum2
        Return resultado
    End Function

    'funcao de calculo de Subtração
    Function CalcSubtracao(ByVal TxtNum1 As Integer, TxtNum2 As Integer) As Integer
        Dim resultado As Integer
        resultado = TxtNum1 - TxtNum2
        Return resultado
    End Function

End Class
