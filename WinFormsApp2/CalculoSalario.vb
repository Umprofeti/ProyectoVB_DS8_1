Public Class CalculoSalario
    Private Const SeguroEducativo As Double = 0.0125
    Private Const SeguroSocial As Double = 0.0975
    Private horasExtras As Double
    Private horasExtras2 As Double
    Private horasExtras3 As Double


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
    Public Property PropHorasExtras2() As Double
        Get
            Return horasExtras2
        End Get
        Set(value As Double)
            horasExtras2 = value
        End Set
    End Property
    Public Property PropHorasExtras3() As Double
        Get
            Return horasExtras2
        End Get
        Set(value As Double)
            horasExtras3 = value
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
        resultado = (horasTrabajadas * salarioHora) + (horasExtras + horasExtras2 + horasExtras3)
        Return Math.Round(resultado, 2)
    End Function


    Public Function CalcularSE() As Double
        Dim resultado As Double
        resultado = CalcularSalarioBruto() * SeguroEducativo
        Return Math.Round(resultado, 2)
    End Function

    Public Function CalcularSS() As Double
        Dim resultado As Double
        resultado = CalcularSalarioBruto() * SeguroSocial
        Return Math.Round(resultado, 2)
    End Function

    Public Function CalcularIR() As Double
        Dim IR1_1 = 11000
        Dim IR1_2 = 50000
        Dim salarioAnual = (CalcularSalarioBruto() * 12) + (horasExtras + horasExtras2 + horasExtras3)
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

    'Horas Extra Mixta: Diurna - Nocturna
    Public Function CalcularHE_Nocturnas(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * ((salarioHora * 0.5) + salarioHora), 2)
        Return resultado
    End Function

    'Horas Extra Mixta: Nocturna - Diurna
    Public Function CalcularHE_M_DN(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * ((salarioHora * 0.5) + salarioHora), 2)
        Return resultado
    End Function

    'Fiesta Nacional o Duelo Nacional
    Public Function CalcularHE_M_ND(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * 1.75), 2)
        Return resultado
    End Function

    ' Mixta Fiesta Nacional o Duelo Nacional
    Public Function CalcularHE_M_FN(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * 2.5), 2)
        Return resultado
    End Function

    ' Mixta Hora Domingo
    Public Function CalcularHE_M_HD(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * 1.5), 2)
        Return resultado
    End Function

    ' Mixta Diurna con exceso de 3 Horas diarias ó 9 Semanales
    Public Function CalcularHE_M_D_E_3_O_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.25 * 1.75)), 2)
        Return resultado
    End Function
    ' Mixta Horas Extra Nocturna con exceso de 3 Horas diarias ó 9 Semanales
    Public Function CalcularHE_M_N_E_3_O_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Mixta: Diurna - Nocturna con exceso de 3 Horas diarias ó 9 Semanales
    Public Function CalcularHE_M_DN_E_3_O_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Mixta: Nocturna - Diurna con exceso de 3 Horas diarias ó 9 Semanales
    Public Function CalcularHE_M_ND_E_3_O_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.75 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional ó Duelo Nacional Diurna
    Public Function CalcularHE_M_FND(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.25)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional ó Duelo Nacional Nocturna
    Public Function CalcularHE_M_FNN(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.5)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional ó Duelo Nacional - Mixto: Diurna - Nocturna
    Public Function CalcularHE_M_FNDN(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.5)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional ó Duelo Nacional - Mixto Nocturna - Diurna
    Public Function CalcularHE_M_FNND(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional Diurno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_FND_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.25 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional Nocturno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_FNN_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.55 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional Mixto: Diurno-Nocturno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_FNDN_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Fiesta Nacional Mixto: Nocturno-Diurno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_FNND_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (2.5 * 1.75 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Diurno
    Public Function CalcularHE_M_DD(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.25)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Nocturno
    Public Function CalcularHE_M_D_N(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.5)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Mixto: Diurno-Nocturno
    Public Function CalcularHE_M_D_DN(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.5)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Mixto: Nocturno-Diurno
    Public Function CalcularHE_M_D_ND(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Diurno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_D_D_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.25 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Nocturno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_D_N_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Mixto: Diurno-Nocturno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_D_DN_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.5 * 1.75)), 2)
        Return resultado
    End Function
    'Horas Extra Domingo ó Descanso Semanal Mixto: Nocturno-Diurno con exceso de 3 Horas Diarias ó 9 Semanales
    Public Function CalcularHE_M_D_ND_E_3_9S(cantHoras As Integer) As Double
        Dim resultado As Double
        resultado = Math.Round(cantHoras * (salarioHora * (1.5 * 1.75 * 1.75)), 2)
        Return resultado
    End Function

    Public Function HE_2(mHora As Double)
        PropHorasExtras2 = mHora
    End Function
    Public Function HE_3(mHora As Double)
        PropHorasExtras3 = mHora
    End Function
End Class
