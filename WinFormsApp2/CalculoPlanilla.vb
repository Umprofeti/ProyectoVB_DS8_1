Imports System.Text.RegularExpressions ' Importaciones de expresiones regulares

Class CalculoPlanilla
    Dim CalculoSalario As CalculoSalario = New CalculoSalario()
    Private Sub I_HT_TextChanged(sender As Object, e As EventArgs) Handles I_HT.Leave
        Try
            CalculoSalario.PropHorasTrabajadas = Int(I_HT.Text)
        Catch ex As Exception
            MsgBox("Este campo no admite Caracteres alfabeticos")
        End Try
    End Sub

    Private Sub I_SXH_TextChanged(sender As Object, e As EventArgs) Handles I_SXH.Leave
        Try
            CalculoSalario.PropSalarioHora = Double.Parse(I_SXH.Text)
            I_SB.Text = CalculoSalario.calcularSalarioBruto()
        Catch ex As Exception
            MsgBox("Este campo no admite Caracteres alfabeticos")
        End Try
    End Sub

    Private Sub I_HE_TextChanged(sender As Object, e As EventArgs) Handles I_HE.TextChanged
        Try
            CalculoSalario.PropHorasExtras = Int(I_HE.Text)
            I_SB.Text = CalculoSalario.calcularSalarioBruto()
        Catch ex As Exception
            MsgBox("Este campo no admite Caracteres alfabeticos")
        End Try
    End Sub
End Class