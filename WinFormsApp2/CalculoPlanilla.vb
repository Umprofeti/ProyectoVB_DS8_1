﻿Imports System.Linq.Expressions
Imports System.Reflection.Metadata
Imports System.Text.RegularExpressions ' Importaciones de expresiones regulares
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1
Imports ProyectoDS8_1.CalculoSalario
Imports ProyectoDS8_1.ConexionBD
Class CalculoPlanilla
    Dim CalculoSalario As CalculoSalario = New CalculoSalario()
    Private Sub I_HT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_HT.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox

        ElseIf e.KeyChar = "." Then
            e.Handled = True ' Evitar agregar punto decimal
        End If
    End Sub
    Private Sub I_HT_TextChanged(sender As Object, e As EventArgs) Handles I_HT.Leave
        If I_HT.Text.Equals("") Then
            CalculoSalario.PropHorasTrabajadas = 0
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
        Else
            CalculoSalario.PropHorasTrabajadas = Int(I_HT.Text)
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
        End If
    End Sub
    Private Sub I_SXH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_SXH.KeyPress
        ' Verifica si la tecla presionada no es un dígito, Backspace o Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If

        ' Verifica si ya hay un punto decimal en el texto
        If e.KeyChar = "." AndAlso I_SXH.Text.Contains(".") Then
            e.Handled = True ' Evita agregar un segundo punto decimal
        End If

        ' Verifica si el carácter es un punto decimal y ya hay números antes
        If e.KeyChar = "." AndAlso Not String.IsNullOrWhiteSpace(I_SXH.Text) AndAlso Not I_SXH.Text.EndsWith(".") Then
        ElseIf e.KeyChar = "." Then
            e.Handled = True ' Evita agregar un punto decimal al principio
        End If

        ' Limita a dos números después del punto decimal
        If I_SXH.Text.Contains(".") Then
            Dim decimalPart As String = I_SXH.Text.Substring(I_SXH.Text.IndexOf(".") + 1)
            If decimalPart.Length >= 2 AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
                e.Handled = True ' Si ya hay dos números después del punto decimal, ignora la entrada adicional
            End If
        End If
    End Sub

    Private Sub I_SXH_TextChanged(sender As Object, e As EventArgs) Handles I_SXH.Leave
        If String.IsNullOrWhiteSpace(I_SXH.Text) Then
            I_SXH.Text = "0.00"
        Else
            ' Restablece el color del texto al color predeterminado (negro)'
            I_SXH.ForeColor = Color.Black
        End If
        If I_SXH.Text.Equals("") Then
            CalculoSalario.PropSalarioHora = 0
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        Else
            CalculoSalario.PropSalarioHora = Double.Parse(I_SXH.Text)
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        End If
    End Sub
    Private Sub I_HE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_HE.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        ElseIf e.KeyChar = "." Then
            e.Handled = True ' Evitar punto decimal
        End If
    End Sub
    Private Sub I_HE_TextChanged(sender As Object, e As EventArgs) Handles I_HE.TextChanged, I_HE.Leave
        ' Verificar si el texto está vacio
        If I_HE.Text.Equals("") Then
            O_HE.Text = CalculoSalario.CalcularHorasExtras(0)
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        Else
            ' De lo contrario seguir con la operacion
            O_HE.Text = CalculoSalario.CalcularHorasExtras(Integer.Parse(I_HE.Text))
            I_SB.Text = CalculoSalario.CalcularSalarioBruto()
            I_SS.Text = CalculoSalario.CalcularSS()
            I_SE.Text = CalculoSalario.CalcularSE()
            I_ISR.Text = CalculoSalario.CalcularIR()
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        End If
    End Sub

    Private Sub I_D1_TextChanged(sender As Object, e As EventArgs) Handles I_D1.TextChanged
        If I_D1.Text.Equals("") Then
            CalculoSalario.PropDeduccion1 = 0
            O_D1.Text = CalculoSalario.PropDeduccion1
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        Else
            CalculoSalario.PropDeduccion1 = I_D1.Text
            O_D1.Text = CalculoSalario.PropDeduccion1
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        End If
    End Sub

    Private Sub I_D2_TextChanged(sender As Object, e As EventArgs) Handles I_D2.TextChanged
        If I_D2.Text.Equals("") Then
            CalculoSalario.PropDeduccion2 = 0
            O_D2.Text = CalculoSalario.PropDeduccion2
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        Else
            CalculoSalario.PropDeduccion2 = I_D2.Text
            O_D2.Text = CalculoSalario.PropDeduccion2
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        End If
    End Sub

    Private Sub I_D3_TextChanged(sender As Object, e As EventArgs) Handles I_D3.TextChanged
        If I_D3.Text.Equals("") Then
            CalculoSalario.PropDeduccion3 = 0
            O_D3.Text = CalculoSalario.PropDeduccion3
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        Else
            CalculoSalario.PropDeduccion3 = I_D3.Text
            O_D3.Text = CalculoSalario.PropDeduccion3
            O_SN.Text = CalculoSalario.CalcularSalarioNeto()
        End If
    End Sub

    Private Sub I_D1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_D1.KeyPress
        ' Verifica si la tecla presionada no es un dígito, Backspace o Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evita que el carácter se ingrese en el TextBox
        End If

        ' Verifica si ya hay un punto decimal en el texto
        If e.KeyChar = "." AndAlso I_D1.Text.Contains(".") Then
            e.Handled = True ' Evita agregar un segundo punto decimal
        End If

        ' Verifica si el carácter es un punto decimal y ya hay números antes
        If e.KeyChar = "." AndAlso Not String.IsNullOrWhiteSpace(I_D1.Text) AndAlso Not I_D1.Text.EndsWith(".") Then
            ' Permite la entrada del punto decimal
        ElseIf e.KeyChar = "." Then
            e.Handled = True ' Evita agregar un punto decimal al principio
        End If

        ' Limitar a dos números después del punto decimal
        If I_D1.Text.Contains(".") Then
            Dim decimalPart As String = I_D1.Text.Substring(I_D1.Text.IndexOf(".") + 1)
            If decimalPart.Length >= 2 AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
                e.Handled = True ' Si ya hay dos números después del punto decimal, ignora la entrada adicional
            End If
        End If
    End Sub

    Private Sub I_D2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_D2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso I_D2.Text.Contains(".") Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso Not String.IsNullOrWhiteSpace(I_D2.Text) AndAlso Not I_D2.Text.EndsWith(".") Then
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If

        If I_D2.Text.Contains(".") Then
            Dim decimalPart As String = I_D2.Text.Substring(I_D2.Text.IndexOf(".") + 1)
            If decimalPart.Length >= 2 AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub I_D3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_D3.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso I_D3.Text.Contains(".") Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso Not String.IsNullOrWhiteSpace(I_D3.Text) AndAlso Not I_D3.Text.EndsWith(".") Then
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If

        If I_D3.Text.Contains(".") Then
            Dim decimalPart As String = I_D3.Text.Substring(I_D3.Text.IndexOf(".") + 1)
            If decimalPart.Length >= 2 AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub I_SXH_Enter(sender As Object, e As EventArgs) Handles I_SXH.Enter
        If I_SXH.Text = "0.00" Then
            I_SXH.Clear()
        End If
        ' Cambia el color del texto a gris'
        I_SXH.ForeColor = Color.Gray
    End Sub

    Private Sub I_SXH_Leave(sender As Object, e As EventArgs)

    End Sub
    Private Sub I_D1_Enter(sender As Object, e As EventArgs) Handles I_D1.Enter
        If I_D1.Text = "0.00" Then
            I_D1.Clear()
        End If
        ' Cambia el color del texto a gris'
        I_D1.ForeColor = Color.Gray
    End Sub

    Private Sub I_D1_Leave(sender As Object, e As EventArgs) Handles I_D1.Leave
        If String.IsNullOrWhiteSpace(I_D1.Text) Then
            I_D1.Text = "0.00"
        Else
            ' Restablece el color del texto al color predeterminado (negro)'
            I_D1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub I_D2_Enter(sender As Object, e As EventArgs) Handles I_D2.Enter
        If I_D2.Text = "0.00" Then
            I_D2.Clear()
        End If
        ' Cambia el color del texto a gris'
        I_D2.ForeColor = Color.Gray
    End Sub
    Private Sub I_D2_Leave(sender As Object, e As EventArgs) Handles I_D2.Leave
        If String.IsNullOrWhiteSpace(I_D2.Text) Then
            I_D2.Text = "0.00"
        Else
            ' Restablece el color del texto al color predeterminado (negro)'
            I_D2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub I_D3_Enter(sender As Object, e As EventArgs) Handles I_D3.Enter
        If I_D3.Text = "0.00" Then
            I_D3.Clear()
        End If

        ' Cambia el color del texto a gris'
        I_D3.ForeColor = Color.Gray
    End Sub
    Private Sub I_D3_Leave(sender As Object, e As EventArgs) Handles I_D3.Leave
        If String.IsNullOrWhiteSpace(I_D3.Text) Then
            I_D3.Text = "0.00"
        Else
            ' Restablece el color del texto al color predeterminado (negro)'
            I_D3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_TOMO.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
        If e.KeyChar = "." AndAlso TextBox1.Text.Contains(".") Then
            e.Handled = True ' Evitar agregar punto decimal
        End If

    End Sub

    Private Sub I_ASIENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_ASIENTO.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
        If e.KeyChar = "." Then
            e.Handled = True ' Evitar agregar punto decimal
        End If

    End Sub

    Private Sub I_NOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_NOMBRE.KeyPress
        ' Verificar si la tecla presionada no es un numero
        ValidarCaracter(sender, e)
    End Sub

    Private Function ValidarCaracter(sender, e) As Handle
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) AndAlso e.KeyChar <> (".") Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
        If e.KeyChar = "." Then
            e.Handled = True ' Evitar agregar un segundo punto decimal
        End If
    End Function

    Private Sub I_APELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_APELLIDO.KeyPress
        ValidarCaracter(sender, e)
    End Sub

    Private Sub I_NOMBRE2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_NOMBRE2.KeyPress
        ValidarCaracter(sender, e)
    End Sub

    Private Sub I_APELLIDO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_APELLIDO2.KeyPress
        ValidarCaracter(sender, e)
    End Sub

    Private Sub I_APELLIDO_C_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_APELLIDO_C.KeyPress
        ValidarCaracter(sender, e)
    End Sub

    Private Sub RB_C_No_CheckedChanged(sender As Object, e As EventArgs) Handles RB_C_No.CheckedChanged
        If RB_C_No.Checked Then
            I_APELLIDO_C.Enabled = False
            I_APELLIDO_C.Clear()
        End If
    End Sub

    Private Sub RB_C_Si_CheckedChanged(sender As Object, e As EventArgs) Handles RB_C_Si.CheckedChanged
        If RB_C_Si.Checked Then
            I_APELLIDO_C.Enabled = True
        End If
    End Sub

    Private Sub CalculoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If I_PREF.Items.Count > 0 Then
            I_PREF.SelectedIndex = 7   ' El primer item en el indice es 0 '
        End If
        If Estado_C_CB.Items.Count > 0 Then
            Estado_C_CB.SelectedIndex = 2   ' El primer item en el indice es 0 '
        End If
        If Mixta_CB.Items.Count > 0 Then
            Mixta_CB.SelectedIndex = 0 ' El primer item en el indice es 0 '
        End If
        M_D.Checked = True
        I_APELLIDO_C.Enabled = False
        Estado_C_CB.Enabled = True ' Habilita el ComboBox de estado civil
        Mixta_CB.Enabled = False
        RB_C_Si.Enabled = True
        RB_C_No.Enabled = True
    End Sub

    Private Sub G_F_CheckedChanged(sender As Object, e As EventArgs) Handles G_F.CheckedChanged
        If G_F.Checked Then
            Estado_C_CB.Enabled = True
            If RB_C_No.Checked Then
                I_APELLIDO_C.Enabled = False
                I_APELLIDO_C.Clear()
            End If
            RB_C_Si.Enabled = True
            RB_C_No.Enabled = True
        End If
    End Sub

    Private Sub G_M_CheckedChanged(sender As Object, e As EventArgs) Handles G_M.CheckedChanged
        If G_M.Checked Then
            Estado_C_CB.Enabled = True
            RB_C_Si.Enabled = False
            RB_C_No.Enabled = False
            I_APELLIDO_C.Enabled = False
            I_APELLIDO_C.Clear()
        End If
    End Sub

    Private Sub M_D_CheckedChanged(sender As Object, e As EventArgs) Handles M_D.CheckedChanged
        If M_D.Checked Then
            Mixta_CB.Enabled = False
        End If
    End Sub

    Private Sub M_N_CheckedChanged(sender As Object, e As EventArgs) Handles M_N.CheckedChanged
        If M_N.Checked Then
            Mixta_CB.Enabled = False
        End If
    End Sub

    Private Sub M_M_CheckedChanged(sender As Object, e As EventArgs) Handles M_M.CheckedChanged
        If M_M.Checked Then
            Mixta_CB.Enabled = True
        End If
    End Sub

    Private Sub mixta_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mixta_CB.SelectedIndexChanged
        ' Obtiene la opción seleccionada en el ComboBox
        Dim opcionSeleccionada As String = Mixta_CB.SelectedItem.ToString()

        ' Verifica la opción seleccionada y llama a la función correspondiente
        Dim cantidadHoras As Integer
        Dim resultado As Double
        Dim calculo As New CalculoSalario()
        Select Case opcionSeleccionada
            Case "Horas Extra Mixta: Diurna - Nocturna"
                resultado = calculo.CalcularHE_Nocturnas(cantidadHoras)
            Case "Horas Extra Mixta: Nocturna - Diurna"
                resultado = calculo.CalcularHE_M_DN(cantidadHoras)
            Case "Fiesta Nacional o Duelo Nacional"
                resultado = calculo.CalcularHE_M_ND(cantidadHoras)
            Case "Mixta Fiesta Nacional o Duelo Nacional"
                resultado = calculo.CalcularHE_M_FN(cantidadHoras)
            Case "Mixta Hora Domingo"
                resultado = calculo.CalcularHE_M_HD(cantidadHoras)
            Case "Mixta Diurna con exceso de 3 Horas diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_D_E_3_O_9S(cantidadHoras)
            Case "Mixta Horas Extra Nocturna con exceso de 3 Horas diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_N_E_3_O_9S(cantidadHoras)
            Case "Horas Extra Mixta: Diurna - Nocturna con exceso de 3 Horas diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_DN_E_3_O_9S(cantidadHoras)
            Case "Horas Extra Mixta: Nocturna - Diurna con exceso de 3 Horas diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_ND_E_3_O_9S(cantidadHoras)
            Case "Horas Extra Fiesta Nacional ó Duelo Nacional Diurna"
                resultado = calculo.CalcularHE_M_FND(cantidadHoras)
            Case "Horas Extra Fiesta Nacional ó Duelo Nacional Nocturna"
                resultado = calculo.CalcularHE_M_FNN(cantidadHoras)
            Case "Horas Extra Fiesta Nacional o Duelo Nacional - Mixto: Diurna - Nocturna"
                resultado = calculo.CalcularHE_M_FNDN(cantidadHoras)
            Case "Horas Extra Fiesta Nacional o Duelo Nacional - Mixto Nocturna - Diurna"
                resultado = calculo.CalcularHE_M_FNND(cantidadHoras)
            Case "Horas Extra Fiesta Nacional Diurno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_FND_E_3_9S(cantidadHoras)
            Case "Horas Extra Fiesta Nacional Nocturno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_FNN_E_3_9S(cantidadHoras)
            Case "Horas Extra Fiesta Nacional Mixto: Diurno-Nocturno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_FNDN_E_3_9S(cantidadHoras)
            Case "Horas Extra Fiesta Nacional Mixto: Nocturno-Diurno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_FNND_E_3_9S(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Diurno"
                resultado = calculo.CalcularHE_M_DD(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Nocturno"
                resultado = calculo.CalcularHE_M_D_N(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Mixto: Diurno-Nocturno"
                resultado = calculo.CalcularHE_M_D_DN(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Mixto: Nocturno-Diurna"
                resultado = calculo.CalcularHE_M_D_ND(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Diurno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_D_D_E_3_9S(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Nocturno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_D_N_E_3_9S(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Mixto: Diurno-Nocturno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_D_DN_E_3_9S(cantidadHoras)
            Case "Horas Extra Domingo ó Descanso Semanal Mixto: Nocturno-Diurno con exceso de 3 Horas Diarias ó 9 Semanales"
                resultado = calculo.CalcularHE_M_D_ND_E_3_9S(cantidadHoras)
        End Select
        calculo.PropHorasExtras = resultado
    End Sub

    Private Sub rgt_btn_Click(sender As Object, e As EventArgs) Handles rgt_btn.Click
        ' Declara las variables para almacenar los valores de los controles
        Dim pref, tomo, asi, ced, nom1, nom2, ape1, ape2, est_c, ap_c, genero, u_a_c As String
        Dim htrab, sxh, s_soc, s_edu, imp_r, h_extra, desc1, desc2, desc3 As String

        ' Asigna los valores de los controles a las variables
        pref = I_PREF.Text
        tomo = I_TOMO.Text
        asi = I_ASIENTO.Text
        nom1 = I_NOMBRE.Text
        nom2 = I_NOMBRE2.Text
        ape1 = I_APELLIDO.Text
        ape2 = I_APELLIDO2.Text
        ap_c = I_APELLIDO_C.Text

        ' Horas, salario, seguros, etc.
        htrab = I_HT.Text
        sxh = I_SXH.Text
        s_soc = I_SS.Text
        s_edu = I_SE.Text
        imp_r = I_ISR.Text
        h_extra = O_HE.Text

        ' Descuentos
        desc1 = O_D1.Text
        desc2 = O_D2.Text
        desc3 = O_D3.Text

        ' Maneja la selección del estado civil
        If Estado_C_CB.SelectedIndex <> -1 Then
            ' Agrega 1 al índice para que coincida con tus valores numéricos (1-Soltero, 2-Casado, 3-Viudo, 4-Divorciado)
            est_c = (Estado_C_CB.SelectedIndex + 1).ToString()
        Else
            ' Maneja el caso en que no se haya seleccionado ningún estado civil
            MessageBox.Show("Selecciona una opción de estado civil.", "Advertencia")
            Return
        End If

        ' Maneja la selección del género
        If G_M.Checked Then
            genero = "M"
        ElseIf G_F.Checked Then
            genero = "F"
        Else
            ' Maneja el caso en que ningún RadioButton está seleccionado
            MessageBox.Show("Selecciona una opción de género.", "Advertencia")
            Return
        End If

        ' Maneja la selección del uso del apellido casada
        If G_F.Checked Then ' Verifica si el género es femenino
            If RB_C_Si.Checked Then
                u_a_c = "1" ' Sí usar apellido casada
            ElseIf RB_C_No.Checked Then
                u_a_c = "2" ' No usar apellido casada
            Else
                ' Maneja el caso en que ningún RadioButton está seleccionado
                MessageBox.Show("Selecciona una opción para el uso del apellido casada.", "Advertencia")
                Return
            End If
        Else
            ' Si el género es masculino, establece el valor predeterminado para "No usar apellido casada"
            u_a_c = "2"
            ' Desmarca el RadioButton de "No usar apellido casada" si está seleccionado
            RB_C_No.Checked = False
        End If

        ' Construye la cédula utilizando la lógica que proporcionaste en I_ASIENTO_LostFocus
        ced = pref + "-" + tomo + "-" + asi

        ' Construye la consulta SQL INSERT
        Dim consulta As String = "INSERT INTO generales (prefijo, tomo, asiento, cedula, nombre1, nombre2, apellido1, apellido2, estado_civil, apellido_casada, genero, usa_apellido_casada, htrabajadas, shora, hextra1, seguro_social, seguro_educativo, impuesto_renta, descuento1, descuento2, descuento3) 
    VALUES (@Pref, @Tomo, @Asiento, @Cedula, @Nombre1, @Nombre2, @Apellido1, @Apellido2, @estado_civil, @apellido_casada, @genero, @usa_apellido_casada, @htrabajadas, @shora, @hextra1, @seguro_social, @seguro_educativo, @impuesto_renta, @descuento1, @descuento2, @descuento3)"

        Try
            Using conn As MySqlConnection = ConexionBD.ObtenerConexion()
                ConexionBD.AbrirConexion()

                Dim command As New MySqlCommand(consulta, conn)

                ' Asigna valores a los parámetros
                command.Parameters.AddWithValue("@Pref", pref)
                command.Parameters.AddWithValue("@Tomo", tomo)
                command.Parameters.AddWithValue("@Asiento", asi)
                command.Parameters.AddWithValue("@Cedula", ced)
                command.Parameters.AddWithValue("@Nombre1", nom1)
                command.Parameters.AddWithValue("@Nombre2", nom2)
                command.Parameters.AddWithValue("@Apellido1", ape1)
                command.Parameters.AddWithValue("@Apellido2", ape2)
                command.Parameters.AddWithValue("@estado_civil", est_c)
                command.Parameters.AddWithValue("@apellido_casada", ap_c)
                command.Parameters.AddWithValue("@genero", genero)
                command.Parameters.AddWithValue("@usa_apellido_casada", u_a_c)
                command.Parameters.AddWithValue("@htrabajadas", htrab)
                command.Parameters.AddWithValue("@shora", sxh)
                command.Parameters.AddWithValue("@hextra1", h_extra)
                command.Parameters.AddWithValue("@seguro_social", s_soc)
                command.Parameters.AddWithValue("@seguro_educativo", s_edu)
                command.Parameters.AddWithValue("@impuesto_renta", imp_r)
                command.Parameters.AddWithValue("@descuento1", desc1)
                command.Parameters.AddWithValue("@descuento2", desc2)
                command.Parameters.AddWithValue("@descuento3", desc3)

                ' Ejecuta la consulta
                command.ExecuteNonQuery()

                MessageBox.Show("Registros insertados correctamente.", "Éxito!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el registros: " & ex.Message, "Error")
        End Try
    End Sub
End Class

'To do'
'-mandar un msgbox para panejar excepciones e indicar si al informacion se envio x
'-quiere una clase que maneje la conexion a la base de datos x
'-quiero que la informacion se envie usando el form' x