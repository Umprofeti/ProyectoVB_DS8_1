Imports System.Reflection.Metadata
Imports System.Text.RegularExpressions ' Importaciones de expresiones regulares
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Class CalculoPlanilla
    Dim CalculoSalario As CalculoSalario = New CalculoSalario()
    Private Sub I_HT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_HT.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
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
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
    End Sub
    Private Sub I_SXH_TextChanged(sender As Object, e As EventArgs) Handles I_SXH.Leave
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
        End If
    End Sub
    Private Sub I_HE_TextChanged(sender As Object, e As EventArgs) Handles I_HE.TextChanged
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
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
    End Sub

    Private Sub I_D2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_D2.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
    End Sub

    Private Sub I_D3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_D3.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_TOMO.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
        If e.KeyChar = "." AndAlso TextBox1.Text.Contains(".") Then
            e.Handled = True ' Evitar agregar un segundo punto decimal
        End If

    End Sub

    Private Sub I_ASIENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles I_ASIENTO.KeyPress
        ' Verificar si la tecla presionada no es un caracter
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(Keys.Delete) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Evitar que el carácter se ingrese en el TextBox
        End If
        If e.KeyChar = "." AndAlso I_ASIENTO.Text.Contains(".") Then
            e.Handled = True ' Evitar agregar un segundo punto decimal
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
            I_APELLIDO_C.Enabled = True

        End If
    End Sub

    Private Sub RB_C_Si_CheckedChanged(sender As Object, e As EventArgs) Handles RB_C_Si.CheckedChanged
        If RB_C_Si.Checked Then
            I_APELLIDO_C.Enabled = True

        End If
    End Sub

    Private Sub CalculoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 7   ' El primer item en el indice es 0 '
        End If
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub I_APELLIDO_C_TextChanged(sender As Object, e As EventArgs) Handles I_APELLIDO_C.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub O_SN_TextChanged(sender As Object, e As EventArgs) Handles O_SN.TextChanged

    End Sub

    Private Sub I_ASIENTO_TextChanged(sender As Object, e As EventArgs) Handles I_ASIENTO.TextChanged

    End Sub

    Private Sub I_SS_TextChanged(sender As Object, e As EventArgs) Handles I_SS.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

End Class