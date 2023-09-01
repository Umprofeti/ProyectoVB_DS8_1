Imports System.Text.RegularExpressions ' Importaciones de expresiones regulares

Class CalculoPlanilla
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CalculoSalario = New CalculoSalario(I_SXH.Text, I_HT.Text)
        I_SB.Text = CalculoSalario.calcularSalarioBruto()
        I_SS.Text = CalculoSalario.calcularSS()
        I_SE.Text = CalculoSalario.calcularSE()
    End Sub
End Class