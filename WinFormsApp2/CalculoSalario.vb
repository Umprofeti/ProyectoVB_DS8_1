Public Class CalculoSalario
    Private Const SeguroEducativo As Double = 1.25
    Private Const SeguroSocial As Double = 9.75

    Private horasTrabajadas As Integer
    Private salarioHora As Double

    Public Property _horasTrabajadas() As Integer
        Get
            Return horasTrabajadas
        End Get
        Set(value As Integer)
            horasTrabajadas = value
        End Set
    End Property

    Public Property _salarioHora() As Double
        Get
            Return salarioHora
        End Get
        Set(value As Double)
            salarioHora = value
        End Set
    End Property

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
        Dim IR1_1 = 11000
        Dim IR1_2 = 50000
        Dim salarioAnual = calcularSalarioBruto() * 12
        Dim resultado As Double
        Dim exedente As Double

        If salarioAnual > IR1_1 And salarioAnual < IR1_2 Then
            exedente = salarioAnual - IR1_1
            Return resultado = (exedente * 0.15) / 12
        End If
        If salarioAnual > IR1_2 Then
            exedente = salarioAnual - IR1_2
            Return resultado = (exedente * 0.25) / 12
        End If
        Return 0
    End Function

    Public Function CalcularDeducciones(Deduccion As Double) As Double
        Dim resultado As Double
        Return resultado = calcularSalarioBruto() - Deduccion
    End Function

    Public Function calcularHorasExtras(cantHoras As Integer) As Double
        Dim resultado As Double
        Return resultado = cantHoras * ((salarioHora * 0.25) + salarioHora)
    End Function
End Class
