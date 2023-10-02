<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculoPlanilla
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CalculoPlanilla))
        Label3 = New Label()
        I_ASIENTO = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        I_HT = New TextBox()
        I_D1 = New TextBox()
        I_SXH = New TextBox()
        I_HE = New TextBox()
        I_D3 = New TextBox()
        I_D2 = New TextBox()
        Label18 = New Label()
        Panel = New Panel()
        Label28 = New Label()
        Label27 = New Label()
        RB_C_No = New RadioButton()
        RB_C_Si = New RadioButton()
        I_APELLIDO_C = New TextBox()
        Label8 = New Label()
        Label4 = New Label()
        I_APELLIDO2 = New TextBox()
        I_APELLIDO = New TextBox()
        I_NOMBRE2 = New TextBox()
        I_NOMBRE = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Nombre = New Label()
        I_TOMO = New TextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Label24 = New Label()
        O_D3 = New TextBox()
        O_D2 = New TextBox()
        Label23 = New Label()
        Label22 = New Label()
        O_D1 = New TextBox()
        O_HE = New TextBox()
        Label21 = New Label()
        O_SN = New TextBox()
        Label20 = New Label()
        I_ISR = New TextBox()
        Label19 = New Label()
        I_SE = New TextBox()
        Label16 = New Label()
        I_SS = New TextBox()
        Label15 = New Label()
        I_SB = New TextBox()
        Label17 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(259, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 16)
        Label3.TabIndex = 14
        Label3.Text = "Asiento"
        ' 
        ' I_ASIENTO
        ' 
        I_ASIENTO.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_ASIENTO.Location = New Point(259, 36)
        I_ASIENTO.MaxLength = 5
        I_ASIENTO.Name = "I_ASIENTO"
        I_ASIENTO.Size = New Size(72, 22)
        I_ASIENTO.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(495, 110)
        Label9.Name = "Label9"
        Label9.Size = New Size(128, 16)
        Label9.TabIndex = 10
        Label9.Text = "Horas trabajadas"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(495, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 16)
        Label10.TabIndex = 11
        Label10.Text = "Salario x Hora"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ButtonFace
        Label11.Location = New Point(495, 166)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 16)
        Label11.TabIndex = 21
        Label11.Text = "Horas Extra"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = SystemColors.ButtonFace
        Label12.Location = New Point(735, 138)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 16)
        Label12.TabIndex = 22
        Label12.Text = "Descuento 2"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ButtonFace
        Label13.Location = New Point(735, 166)
        Label13.Name = "Label13"
        Label13.Size = New Size(93, 16)
        Label13.TabIndex = 23
        Label13.Text = "Descuento 3"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = SystemColors.ButtonFace
        Label14.Location = New Point(735, 110)
        Label14.Name = "Label14"
        Label14.Size = New Size(93, 16)
        Label14.TabIndex = 24
        Label14.Text = "Descuento 1"
        ' 
        ' I_HT
        ' 
        I_HT.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_HT.Location = New Point(630, 105)
        I_HT.Name = "I_HT"
        I_HT.RightToLeft = RightToLeft.Yes
        I_HT.Size = New Size(100, 22)
        I_HT.TabIndex = 0
        ' 
        ' I_D1
        ' 
        I_D1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_D1.ForeColor = Color.Gray
        I_D1.Location = New Point(837, 105)
        I_D1.Name = "I_D1"
        I_D1.RightToLeft = RightToLeft.Yes
        I_D1.Size = New Size(100, 22)
        I_D1.TabIndex = 3
        I_D1.Text = "0.00"
        ' 
        ' I_SXH
        ' 
        I_SXH.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_SXH.ForeColor = Color.Gray
        I_SXH.Location = New Point(630, 135)
        I_SXH.Name = "I_SXH"
        I_SXH.RightToLeft = RightToLeft.Yes
        I_SXH.Size = New Size(100, 22)
        I_SXH.TabIndex = 1
        I_SXH.Text = "0.00"
        ' 
        ' I_HE
        ' 
        I_HE.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_HE.Location = New Point(630, 164)
        I_HE.Name = "I_HE"
        I_HE.RightToLeft = RightToLeft.Yes
        I_HE.Size = New Size(100, 22)
        I_HE.TabIndex = 2
        ' 
        ' I_D3
        ' 
        I_D3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_D3.ForeColor = Color.Gray
        I_D3.Location = New Point(837, 164)
        I_D3.Name = "I_D3"
        I_D3.RightToLeft = RightToLeft.Yes
        I_D3.Size = New Size(100, 22)
        I_D3.TabIndex = 6
        I_D3.Text = "0.00"
        ' 
        ' I_D2
        ' 
        I_D2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_D2.ForeColor = Color.Gray
        I_D2.Location = New Point(837, 135)
        I_D2.Name = "I_D2"
        I_D2.RightToLeft = RightToLeft.Yes
        I_D2.Size = New Size(100, 22)
        I_D2.TabIndex = 5
        I_D2.Text = "0.00"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.ForeColor = SystemColors.ControlLightLight
        Label18.Location = New Point(495, 210)
        Label18.Name = "Label18"
        Label18.Size = New Size(103, 25)
        Label18.TabIndex = 6
        Label18.Text = "Calculos"
        ' 
        ' Panel
        ' 
        Panel.BackColor = Color.FromArgb(CByte(79), CByte(78), CByte(93))
        Panel.Controls.Add(Label28)
        Panel.Controls.Add(Label27)
        Panel.Controls.Add(RB_C_No)
        Panel.Controls.Add(RB_C_Si)
        Panel.Controls.Add(I_APELLIDO_C)
        Panel.Controls.Add(Label8)
        Panel.Controls.Add(Label4)
        Panel.Controls.Add(I_APELLIDO2)
        Panel.Controls.Add(I_APELLIDO)
        Panel.Controls.Add(I_NOMBRE2)
        Panel.Controls.Add(I_NOMBRE)
        Panel.Controls.Add(Label7)
        Panel.Controls.Add(Label6)
        Panel.Controls.Add(Label5)
        Panel.Controls.Add(Nombre)
        Panel.Controls.Add(I_TOMO)
        Panel.Controls.Add(ComboBox1)
        Panel.Controls.Add(Label2)
        Panel.Controls.Add(Label1)
        Panel.Controls.Add(Label3)
        Panel.Controls.Add(I_ASIENTO)
        Panel.ForeColor = Color.Black
        Panel.Location = New Point(19, 100)
        Panel.Name = "Panel"
        Panel.RightToLeft = RightToLeft.No
        Panel.Size = New Size(459, 274)
        Panel.TabIndex = 0
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.ForeColor = SystemColors.ControlLightLight
        Label28.Location = New Point(220, 28)
        Label28.Name = "Label28"
        Label28.Size = New Size(24, 32)
        Label28.TabIndex = 32
        Label28.Text = "-"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label27.ForeColor = SystemColors.ControlLightLight
        Label27.Location = New Point(85, 28)
        Label27.Name = "Label27"
        Label27.Size = New Size(24, 32)
        Label27.TabIndex = 31
        Label27.Text = "-"
        ' 
        ' RB_C_No
        ' 
        RB_C_No.AutoSize = True
        RB_C_No.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        RB_C_No.ForeColor = SystemColors.ControlLightLight
        RB_C_No.Location = New Point(70, 219)
        RB_C_No.Name = "RB_C_No"
        RB_C_No.Size = New Size(45, 20)
        RB_C_No.TabIndex = 30
        RB_C_No.TabStop = True
        RB_C_No.Text = "No"
        RB_C_No.UseVisualStyleBackColor = True
        ' 
        ' RB_C_Si
        ' 
        RB_C_Si.AutoSize = True
        RB_C_Si.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        RB_C_Si.ForeColor = SystemColors.ControlLightLight
        RB_C_Si.Location = New Point(70, 195)
        RB_C_Si.Name = "RB_C_Si"
        RB_C_Si.Size = New Size(39, 20)
        RB_C_Si.TabIndex = 29
        RB_C_Si.TabStop = True
        RB_C_Si.Text = "Si"
        RB_C_Si.UseVisualStyleBackColor = True
        ' 
        ' I_APELLIDO_C
        ' 
        I_APELLIDO_C.Enabled = False
        I_APELLIDO_C.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_APELLIDO_C.Location = New Point(223, 202)
        I_APELLIDO_C.Name = "I_APELLIDO_C"
        I_APELLIDO_C.Size = New Size(147, 22)
        I_APELLIDO_C.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(223, 176)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 16)
        Label8.TabIndex = 7
        Label8.Text = "Apellido casada"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(67, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 16)
        Label4.TabIndex = 5
        Label4.Text = "Usa Apellido Casada"
        ' 
        ' I_APELLIDO2
        ' 
        I_APELLIDO2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_APELLIDO2.Location = New Point(223, 131)
        I_APELLIDO2.MaxLength = 15
        I_APELLIDO2.Name = "I_APELLIDO2"
        I_APELLIDO2.Size = New Size(132, 22)
        I_APELLIDO2.TabIndex = 7
        ' 
        ' I_APELLIDO
        ' 
        I_APELLIDO.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_APELLIDO.Location = New Point(223, 88)
        I_APELLIDO.MaxLength = 15
        I_APELLIDO.Name = "I_APELLIDO"
        I_APELLIDO.Size = New Size(132, 22)
        I_APELLIDO.TabIndex = 5
        ' 
        ' I_NOMBRE2
        ' 
        I_NOMBRE2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_NOMBRE2.Location = New Point(67, 131)
        I_NOMBRE2.MaxLength = 15
        I_NOMBRE2.Name = "I_NOMBRE2"
        I_NOMBRE2.Size = New Size(132, 22)
        I_NOMBRE2.TabIndex = 6
        ' 
        ' I_NOMBRE
        ' 
        I_NOMBRE.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_NOMBRE.Location = New Point(67, 88)
        I_NOMBRE.MaxLength = 15
        I_NOMBRE.Name = "I_NOMBRE"
        I_NOMBRE.Size = New Size(132, 22)
        I_NOMBRE.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(220, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 16)
        Label7.TabIndex = 3
        Label7.Text = "Apellido 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(223, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 16)
        Label6.TabIndex = 1
        Label6.Text = "Apellido "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(67, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 16)
        Label5.TabIndex = 18
        Label5.Text = "Nombre 2"
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Nombre.ForeColor = SystemColors.ControlLightLight
        Nombre.Location = New Point(67, 70)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(62, 16)
        Nombre.TabIndex = 16
        Nombre.Text = "Nombre"
        ' 
        ' I_TOMO
        ' 
        I_TOMO.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_TOMO.Location = New Point(124, 36)
        I_TOMO.MaxLength = 4
        I_TOMO.Name = "I_TOMO"
        I_TOMO.Size = New Size(74, 22)
        I_TOMO.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 16
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "E", "PE"})
        ComboBox1.Location = New Point(7, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(52, 24)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(121, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 16)
        Label2.TabIndex = 12
        Label2.Text = "Tomo"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(7, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 16)
        Label1.TabIndex = 10
        Label1.Text = "Prefijo"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(79), CByte(78), CByte(93))
        Panel1.Controls.Add(Label24)
        Panel1.Controls.Add(O_D3)
        Panel1.Controls.Add(O_D2)
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(Label22)
        Panel1.Controls.Add(O_D1)
        Panel1.Controls.Add(O_HE)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(O_SN)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(I_ISR)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(I_SE)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(I_SS)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(I_SB)
        Panel1.Controls.Add(Label17)
        Panel1.Location = New Point(499, 238)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 136)
        Panel1.TabIndex = 7
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.ForeColor = SystemColors.ControlLightLight
        Label24.Location = New Point(230, 98)
        Label24.Name = "Label24"
        Label24.Size = New Size(26, 16)
        Label24.TabIndex = 63
        Label24.Text = "D3"
        ' 
        ' O_D3
        ' 
        O_D3.Enabled = False
        O_D3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        O_D3.Location = New Point(264, 98)
        O_D3.Name = "O_D3"
        O_D3.RightToLeft = RightToLeft.Yes
        O_D3.Size = New Size(57, 22)
        O_D3.TabIndex = 62
        ' 
        ' O_D2
        ' 
        O_D2.Enabled = False
        O_D2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        O_D2.Location = New Point(264, 71)
        O_D2.Name = "O_D2"
        O_D2.RightToLeft = RightToLeft.Yes
        O_D2.Size = New Size(57, 22)
        O_D2.TabIndex = 61
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.ForeColor = SystemColors.ControlLightLight
        Label23.Location = New Point(230, 67)
        Label23.Name = "Label23"
        Label23.Size = New Size(26, 16)
        Label23.TabIndex = 60
        Label23.Text = "D2"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.ForeColor = SystemColors.ControlLightLight
        Label22.Location = New Point(230, 46)
        Label22.Name = "Label22"
        Label22.Size = New Size(26, 16)
        Label22.TabIndex = 59
        Label22.Text = "D1"
        ' 
        ' O_D1
        ' 
        O_D1.Enabled = False
        O_D1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        O_D1.Location = New Point(264, 43)
        O_D1.Name = "O_D1"
        O_D1.RightToLeft = RightToLeft.Yes
        O_D1.Size = New Size(57, 22)
        O_D1.TabIndex = 58
        ' 
        ' O_HE
        ' 
        O_HE.Enabled = False
        O_HE.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        O_HE.Location = New Point(264, 16)
        O_HE.Name = "O_HE"
        O_HE.RightToLeft = RightToLeft.Yes
        O_HE.Size = New Size(57, 22)
        O_HE.TabIndex = 57
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.ForeColor = SystemColors.ControlLightLight
        Label21.Location = New Point(170, 16)
        Label21.Name = "Label21"
        Label21.Size = New Size(88, 16)
        Label21.TabIndex = 56
        Label21.Text = "Horas Extra"
        ' 
        ' O_SN
        ' 
        O_SN.Enabled = False
        O_SN.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        O_SN.Location = New Point(427, 16)
        O_SN.Name = "O_SN"
        O_SN.RightToLeft = RightToLeft.Yes
        O_SN.Size = New Size(57, 22)
        O_SN.TabIndex = 55
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.ForeColor = SystemColors.ControlLightLight
        Label20.Location = New Point(327, 16)
        Label20.Name = "Label20"
        Label20.Size = New Size(94, 16)
        Label20.TabIndex = 54
        Label20.Text = "Salario Neto"
        ' 
        ' I_ISR
        ' 
        I_ISR.Enabled = False
        I_ISR.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_ISR.Location = New Point(105, 70)
        I_ISR.Name = "I_ISR"
        I_ISR.RightToLeft = RightToLeft.Yes
        I_ISR.Size = New Size(51, 22)
        I_ISR.TabIndex = 52
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = SystemColors.ControlLightLight
        Label19.Location = New Point(3, 71)
        Label19.Name = "Label19"
        Label19.Size = New Size(40, 16)
        Label19.TabIndex = 51
        Label19.Text = "I.S.R"
        ' 
        ' I_SE
        ' 
        I_SE.Enabled = False
        I_SE.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_SE.Location = New Point(106, 98)
        I_SE.Name = "I_SE"
        I_SE.RightToLeft = RightToLeft.Yes
        I_SE.Size = New Size(51, 22)
        I_SE.TabIndex = 50
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.ForeColor = SystemColors.ControlLightLight
        Label16.Location = New Point(3, 98)
        Label16.Name = "Label16"
        Label16.Size = New Size(70, 16)
        Label16.TabIndex = 49
        Label16.Text = "Seg. Edu"
        ' 
        ' I_SS
        ' 
        I_SS.Enabled = False
        I_SS.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_SS.Location = New Point(106, 41)
        I_SS.Name = "I_SS"
        I_SS.RightToLeft = RightToLeft.Yes
        I_SS.Size = New Size(51, 22)
        I_SS.TabIndex = 48
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.ForeColor = SystemColors.ControlLightLight
        Label15.Location = New Point(3, 42)
        Label15.Name = "Label15"
        Label15.Size = New Size(87, 16)
        Label15.TabIndex = 47
        Label15.Text = "Seg. Social"
        ' 
        ' I_SB
        ' 
        I_SB.Enabled = False
        I_SB.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        I_SB.Location = New Point(105, 13)
        I_SB.Name = "I_SB"
        I_SB.RightToLeft = RightToLeft.Yes
        I_SB.Size = New Size(52, 22)
        I_SB.TabIndex = 46
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = SystemColors.ControlLightLight
        Label17.Location = New Point(3, 16)
        Label17.Name = "Label17"
        Label17.Size = New Size(97, 16)
        Label17.TabIndex = 45
        Label17.Text = "Salario Bruto"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.Transparent
        Label25.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label25.ForeColor = SystemColors.ControlLightLight
        Label25.Location = New Point(31, 60)
        Label25.Name = "Label25"
        Label25.Size = New Size(374, 25)
        Label25.TabIndex = 26
        Label25.Text = "Informacion General del Empleado"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label26.ForeColor = SystemColors.ControlLightLight
        Label26.Location = New Point(500, 62)
        Label26.Name = "Label26"
        Label26.Size = New Size(224, 25)
        Label26.TabIndex = 27
        Label26.Text = "Horas y Descuentos"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.DimGray
        TextBox1.Location = New Point(19, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(292, 20)
        TextBox1.TabIndex = 28
        TextBox1.Text = "Busqueda de Emploado...."
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(317, 10)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 22)
        Button1.TabIndex = 29
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(604, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 22)
        Button2.TabIndex = 30
        Button2.Text = "Mensual"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(700, 214)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 22)
        Button3.TabIndex = 31
        Button3.Text = "Anual"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(902, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 87)
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(239), CByte(63), CByte(83))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label25)
        Panel3.Controls.Add(Label26)
        Panel3.Location = New Point(-5, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1037, 87)
        Panel3.TabIndex = 26
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(239), CByte(63), CByte(83))
        Panel2.Location = New Point(-5, 380)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1034, 26)
        Panel2.TabIndex = 32
        ' 
        ' CalculoPlanilla
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(65), CByte(64), CByte(89))
        ClientSize = New Size(1026, 406)
        Controls.Add(Panel2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(Panel)
        Controls.Add(Label18)
        Controls.Add(I_D2)
        Controls.Add(I_D3)
        Controls.Add(I_HE)
        Controls.Add(I_SXH)
        Controls.Add(I_D1)
        Controls.Add(I_HT)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "CalculoPlanilla"
        StartPosition = FormStartPosition.CenterScreen
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents I_ASIENTO As TextBox

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents I_D1 As TextBox
    Friend WithEvents I_SXH As TextBox
    Friend WithEvents I_HE As TextBox
    Friend WithEvents I_D3 As TextBox
    Friend WithEvents I_D2 As TextBox

    Friend WithEvents Label18 As Label

    Friend WithEvents Panel As Panel
    Friend WithEvents I_APELLIDO2 As TextBox
    Friend WithEvents I_APELLIDO As TextBox
    Friend WithEvents I_NOMBRE2 As TextBox
    Friend WithEvents I_NOMBRE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents I_TOMO As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents I_APELLIDO_C As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents I_ISR As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents I_SE As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents I_SS As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents I_SB As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents O_SN As TextBox
    Friend WithEvents Label20 As Label
    Friend Protected WithEvents I_HT As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents O_D1 As TextBox
    Friend WithEvents O_HE As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents O_D3 As TextBox
    Friend WithEvents O_D2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents RB_C_Si As RadioButton
    Friend WithEvents RB_C_No As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
End Class
