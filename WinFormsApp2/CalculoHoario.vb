Public Class CalculoHoario
    Private Const SeguroEducativo As Double = 1.25
    Private Const SeguroSocial As Double = 9.75

    Private horasTrabajadas As Integer
    Private salarioHora As Double

    Public Sub New(sH As Double, hT As Integer)
        Me.salarioHora = sH
        Me.horasTrabajadas = hT
    End Sub

    Public Function calcularSalarioBruto() As Double
        Dim resultado As Double

        resultado = horasTrabajadas * salarioHora
        Return resultado
    End Function

    Public Function calcularSE() As Double
        Dim resultado As Double
        resultado = calcularSalarioBruto() * SeguroEducativo
        Return resultado
    End Function

    Public Function calcularSS() As Double
        Dim resultado As Double
        resultado = calcularSalarioBruto() * SeguroSocial
        Return resultado
    End Function

    Public Function calcularIR() As Double
        Dim IR1 = 11000
        Dim IR12 = 50000
        Dim resultado As Double




    End Function
End Class
