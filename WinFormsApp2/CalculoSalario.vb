Public Class CalculoSalario
    Private Const SeguroEducativo As Double = 0.0125
    Private Const SeguroSocial As Double = 0.0975
    Private horasExtras As Double

    Private horasTrabajadas As Integer
    Private salarioHora As Double

    ' Deducciones 
    Private Deduccion1 As Double
    Private Deduccion2 As Double
    Private Deduccion3 As Double

    Public Property PropDeduccion1() As Double
        Get
            Return Deduccion1
        End Get
        Set(value As Double)
            Deduccion1 = value
        End Set
    End Property

    Public Property PropDeduccion2() As Double
        Get
            Return Deduccion2
        End Get
        Set(value As Double)
            Deduccion2 = value
        End Set
    End Property

    Public Property PropDeduccion3() As Double
        Get
            Return Deduccion3
        End Get
        Set(value As Double)
            Deduccion3 = value
        End Set
    End Property

    Public Property PropHorasExtras() As Double
        Get
            Return horasExtras
        End Get
        Set(value As Double)
            horasExtras = value
        End Set
    End Property

    Public Property PropHorasTrabajadas() As Integer
        Get
            Return horasTrabajadas
        End Get
        Set(value As Integer)
            horasTrabajadas = value
        End Set
    End Property

    Public Property PropSalarioHora() As Double
        Get
            Return salarioHora
        End Get
        Set(value As Double)
            salarioHora = value
        End Set
    End Property

    Public Sub New()
        Me.salarioHora = 0
        Me.horasTrabajadas = 0
        Me.horasExtras = 0
    End Sub

    Public Function CalcularSalarioBruto() As Double
        Dim resultado As Double
        resultado = (horasTrabajadas * salarioHora) + horasExtras
        Return Math.Round(resultado, 2)
    End Function

    Public Function CalcularSE() As Double
        Dim resultado As Double
        resultado = CalcularSalarioBruto() * SeguroEducativo
        Return Math.Round(resultado)
    End Function

    Public Function CalcularSS() As Double
        Dim resultado As Double
        resultado = CalcularSalarioBruto() * SeguroSocial
        Return Math.Round(resultado)
    End Function

    Public Function CalcularIR() As Double
        Dim IR1_1 = 11000
        Dim IR1_2 = 50000
        Dim salarioAnual = (CalcularSalarioBruto() * 12) + horasExtras
        Dim resultado As Double
        Dim exedente As Double

        If salarioAnual >= IR1_1 And salarioAnual < IR1_2 Then
            exedente = salarioAnual - IR1_1
            resultado = (exedente * 0.15) / 12
        End If
        If salarioAnual >= IR1_2 Then
            exedente = salarioAnual - IR1_2
            resultado = (exedente * 0.25) / 12
        End If
        Return Math.Round(resultado, 2)
    End Function

    Public Function CalcularDeducciones(Deduccion As Double) As Double
        Dim resultado As Double
        Return resultado = calcularSalarioBruto() - Deduccion
    End Function

    Public Function CalcularHorasExtras(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * ((salarioHora * 0.25) + salarioHora), 2)
        PropHorasExtras = resultado
        Return resultado
    End Function

    Public Function CalcularSalarioNeto() As Double
        Dim resultado As Double
        Dim deducciones As Double
        deducciones = CalcularIR() + CalcularSE() + CalcularSS() + Deduccion1 + Deduccion2 + Deduccion3
        resultado = Math.Round((CalcularSalarioBruto() - deducciones), 2)
        Return resultado
    End Function
End Class
