<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CadClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CadClientes))
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.cbxUf = New System.Windows.Forms.ComboBox()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.txtNumer = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mtbCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDataNasc = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.mtbTelRes = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpar
        '
        Me.btnLimpar.AutoSize = True
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(112, 340)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(86, 31)
        Me.btnLimpar.TabIndex = 19
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Location = New System.Drawing.Point(20, 340)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(86, 31)
        Me.btnFechar.TabIndex = 20
        Me.btnFechar.Text = "Cancelar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCompl)
        Me.GroupBox3.Controls.Add(Me.cbxUf)
        Me.GroupBox3.Controls.Add(Me.txtRua)
        Me.GroupBox3.Controls.Add(Me.txtNumer)
        Me.GroupBox3.Controls.Add(Me.txtCidade)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtBairro)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.mtbCep)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(20, 134)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(671, 125)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rua/Aven."
        '
        'txtCompl
        '
        Me.txtCompl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompl.Location = New System.Drawing.Point(92, 81)
        Me.txtCompl.MaxLength = 15
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(145, 24)
        Me.txtCompl.TabIndex = 13
        '
        'cbxUf
        '
        Me.cbxUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUf.FormattingEnabled = True
        Me.cbxUf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbxUf.Location = New System.Drawing.Point(588, 50)
        Me.cbxUf.MaxLength = 2
        Me.cbxUf.Name = "cbxUf"
        Me.cbxUf.Size = New System.Drawing.Size(46, 26)
        Me.cbxUf.TabIndex = 12
        Me.cbxUf.Text = "SP"
        '
        'txtRua
        '
        Me.txtRua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.Location = New System.Drawing.Point(92, 19)
        Me.txtRua.MaxLength = 40
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(340, 24)
        Me.txtRua.TabIndex = 8
        '
        'txtNumer
        '
        Me.txtNumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumer.Location = New System.Drawing.Point(469, 19)
        Me.txtNumer.MaxLength = 20
        Me.txtNumer.Name = "txtNumer"
        Me.txtNumer.Size = New System.Drawing.Size(165, 24)
        Me.txtNumer.TabIndex = 9
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(376, 50)
        Me.txtCidade.MaxLength = 25
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(172, 24)
        Me.txtCidade.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(9, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 18)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Bairro"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(243, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 18)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "CEP"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(438, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 18)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "N°"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(92, 50)
        Me.txtBairro.MaxLength = 35
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(218, 24)
        Me.txtBairro.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(9, 84)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 18)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Compl."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(316, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Cidade"
        '
        'mtbCep
        '
        Me.mtbCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCep.Location = New System.Drawing.Point(288, 80)
        Me.mtbCep.Mask = "00000-999"
        Me.mtbCep.Name = "mtbCep"
        Me.mtbCep.Size = New System.Drawing.Size(103, 24)
        Me.mtbCep.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(554, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 18)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "UF"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'txtCodCli
        '
        Me.txtCodCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCli.Enabled = False
        Me.txtCodCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodCli.ForeColor = System.Drawing.Color.Black
        Me.txtCodCli.Location = New System.Drawing.Point(61, 33)
        Me.txtCodCli.MaxLength = 5
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(48, 23)
        Me.txtCodCli.TabIndex = 1
        Me.txtCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(112, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Nome do Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRG)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtCPF)
        Me.GroupBox2.Controls.Add(Me.dtpDataNasc)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(18, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 61)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados Pessoais"
        '
        'txtRG
        '
        Me.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtRG.Location = New System.Drawing.Point(300, 20)
        Me.txtRG.MaxLength = 14
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(116, 24)
        Me.txtRG.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(454, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 18)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "CPF"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(268, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 18)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "RG"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(40, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 18)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Data Nasc."
        '
        'txtCPF
        '
        Me.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtCPF.Location = New System.Drawing.Point(493, 20)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(116, 24)
        Me.txtCPF.TabIndex = 6
        '
        'dtpDataNasc
        '
        Me.dtpDataNasc.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dtpDataNasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNasc.Location = New System.Drawing.Point(128, 19)
        Me.dtpDataNasc.Name = "dtpDataNasc"
        Me.dtpDataNasc.Size = New System.Drawing.Size(118, 24)
        Me.dtpDataNasc.TabIndex = 4
        Me.dtpDataNasc.Value = New Date(2014, 1, 1, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.mtbTelCel)
        Me.GroupBox1.Controls.Add(Me.mtbTelRes)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(20, 265)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 58)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contatos/Telefones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(14, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Residêncial"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(231, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Celular"
        '
        'mtbTelCel
        '
        Me.mtbTelCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtbTelCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.mtbTelCel.Location = New System.Drawing.Point(291, 19)
        Me.mtbTelCel.Mask = "(99)0 0000-0000"
        Me.mtbTelCel.Name = "mtbTelCel"
        Me.mtbTelCel.Size = New System.Drawing.Size(114, 24)
        Me.mtbTelCel.TabIndex = 17
        '
        'mtbTelRes
        '
        Me.mtbTelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtbTelRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.mtbTelRes.Location = New System.Drawing.Point(104, 19)
        Me.mtbTelRes.Mask = "(99) 0000-0000"
        Me.mtbTelRes.Name = "mtbTelRes"
        Me.mtbTelRes.Size = New System.Drawing.Size(106, 24)
        Me.mtbTelRes.TabIndex = 16
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(115, 33)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(399, 23)
        Me.txtNome.TabIndex = 2
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(58, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 18)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Código"
        '
        'btnSalvar
        '
        Me.btnSalvar.AutoSize = True
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Location = New System.Drawing.Point(605, 340)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(86, 31)
        Me.btnSalvar.TabIndex = 18
        Me.btnSalvar.Text = "Concluir"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.Black
        Me.lblData.Location = New System.Drawing.Point(556, 33)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(65, 18)
        Me.lblData.TabIndex = 96
        Me.lblData.Text = "Dia Hoje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(556, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Data:"
        '
        'frm_CadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 383)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastramento de Clientes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompl As System.Windows.Forms.TextBox
    Friend WithEvents cbxUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents txtNumer As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mtbCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpDataNasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mtbTelCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbTelRes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
