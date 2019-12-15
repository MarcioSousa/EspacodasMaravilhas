<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CadVendas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CadVendas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.CODPROD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPontos1 = New System.Windows.Forms.Button()
        Me.btnPontos2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblDataAtual = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt12X = New System.Windows.Forms.RadioButton()
        Me.rbt11X = New System.Windows.Forms.RadioButton()
        Me.rbt10X = New System.Windows.Forms.RadioButton()
        Me.rbt9X = New System.Windows.Forms.RadioButton()
        Me.rbt8X = New System.Windows.Forms.RadioButton()
        Me.rbt7X = New System.Windows.Forms.RadioButton()
        Me.rbt6X = New System.Windows.Forms.RadioButton()
        Me.rbt5X = New System.Windows.Forms.RadioButton()
        Me.rbt4X = New System.Windows.Forms.RadioButton()
        Me.rbt3X = New System.Windows.Forms.RadioButton()
        Me.rbt2X = New System.Windows.Forms.RadioButton()
        Me.rbtVista = New System.Windows.Forms.RadioButton()
        Me.lblQtdeParcela = New System.Windows.Forms.Label()
        Me.gbxEntrada = New System.Windows.Forms.GroupBox()
        Me.rbtSEntrada = New System.Windows.Forms.RadioButton()
        Me.rbtCEntrada = New System.Windows.Forms.RadioButton()
        Me.lblEscolha = New System.Windows.Forms.Label()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxEntrada.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(179, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Modelo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(9, 126)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 18)
        Me.Label26.TabIndex = 121
        Me.Label26.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(145, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Cliente"
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Enabled = False
        Me.txtNomeCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCli.ForeColor = System.Drawing.Color.Black
        Me.txtNomeCli.Location = New System.Drawing.Point(139, 41)
        Me.txtNomeCli.MaxLength = 40
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(352, 23)
        Me.txtNomeCli.TabIndex = 3
        Me.txtNomeCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodCli
        '
        Me.txtCodCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodCli.ForeColor = System.Drawing.Color.Black
        Me.txtCodCli.Location = New System.Drawing.Point(9, 41)
        Me.txtCodCli.MaxLength = 5
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(78, 23)
        Me.txtCodCli.TabIndex = 1
        Me.txtCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(145, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 18)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Produto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Código"
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.AllowUserToDeleteRows = False
        Me.dgvVendas.AllowUserToResizeColumns = False
        Me.dgvVendas.AllowUserToResizeRows = False
        Me.dgvVendas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPROD, Me.PRODUTO, Me.QTDE, Me.PRECO})
        Me.dgvVendas.Location = New System.Drawing.Point(9, 208)
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.RowHeadersVisible = False
        Me.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendas.Size = New System.Drawing.Size(414, 190)
        Me.dgvVendas.TabIndex = 130
        '
        'CODPROD
        '
        Me.CODPROD.HeaderText = "Cod"
        Me.CODPROD.Name = "CODPROD"
        Me.CODPROD.ReadOnly = True
        Me.CODPROD.Visible = False
        Me.CODPROD.Width = 40
        '
        'PRODUTO
        '
        Me.PRODUTO.HeaderText = "Produto"
        Me.PRODUTO.Name = "PRODUTO"
        Me.PRODUTO.ReadOnly = True
        Me.PRODUTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRODUTO.Width = 225
        '
        'QTDE
        '
        Me.QTDE.HeaderText = "Qtde"
        Me.QTDE.Name = "QTDE"
        Me.QTDE.ReadOnly = True
        Me.QTDE.Width = 40
        '
        'PRECO
        '
        Me.PRECO.HeaderText = "Valor Total"
        Me.PRECO.Name = "PRECO"
        Me.PRECO.ReadOnly = True
        Me.PRECO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRECO.Width = 120
        '
        'btnPontos1
        '
        Me.btnPontos1.AutoSize = True
        Me.btnPontos1.Location = New System.Drawing.Point(93, 41)
        Me.btnPontos1.Name = "btnPontos1"
        Me.btnPontos1.Size = New System.Drawing.Size(40, 23)
        Me.btnPontos1.TabIndex = 2
        Me.btnPontos1.Text = "..."
        Me.btnPontos1.UseVisualStyleBackColor = True
        '
        'btnPontos2
        '
        Me.btnPontos2.AutoSize = True
        Me.btnPontos2.Location = New System.Drawing.Point(343, 97)
        Me.btnPontos2.Name = "btnPontos2"
        Me.btnPontos2.Size = New System.Drawing.Size(40, 23)
        Me.btnPontos2.TabIndex = 6
        Me.btnPontos2.Text = "..."
        Me.btnPontos2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(384, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Qtde"
        '
        'txtQtde
        '
        Me.txtQtde.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtde.Location = New System.Drawing.Point(387, 147)
        Me.txtQtde.MaxLength = 4
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(59, 25)
        Me.txtQtde.TabIndex = 9
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(411, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Preço Unidade"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(404, 96)
        Me.TextBox3.MaxLength = 35
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 25)
        Me.TextBox3.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(234, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Total:"
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(429, 208)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(93, 43)
        Me.btnIncluir.TabIndex = 10
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(429, 257)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(93, 43)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(429, 306)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 43)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(429, 355)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(93, 43)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblTotal.Font = New System.Drawing.Font("Adobe Gothic Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(326, 409)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 24)
        Me.lblTotal.TabIndex = 143
        Me.lblTotal.Text = "R$ 0,00"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(287, 407)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(134, 29)
        Me.TextBox6.TabIndex = 144
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblPreco.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPreco.ForeColor = System.Drawing.Color.Black
        Me.lblPreco.Location = New System.Drawing.Point(444, 100)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(40, 20)
        Me.lblPreco.TabIndex = 145
        Me.lblPreco.Text = "0,00"
        '
        'lblDataAtual
        '
        Me.lblDataAtual.AutoSize = True
        Me.lblDataAtual.BackColor = System.Drawing.SystemColors.Control
        Me.lblDataAtual.Font = New System.Drawing.Font("Adobe Gothic Std B", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataAtual.ForeColor = System.Drawing.Color.White
        Me.lblDataAtual.Location = New System.Drawing.Point(8, 410)
        Me.lblDataAtual.Name = "lblDataAtual"
        Me.lblDataAtual.Size = New System.Drawing.Size(91, 19)
        Me.lblDataAtual.TabIndex = 146
        Me.lblDataAtual.Text = "16/11/1987"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(380, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Compra:"
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.BackColor = System.Drawing.SystemColors.Control
        Me.lblCompra.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.ForeColor = System.Drawing.Color.White
        Me.lblCompra.Location = New System.Drawing.Point(445, 9)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(16, 18)
        Me.lblCompra.TabIndex = 148
        Me.lblCompra.Text = "0"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(374, 5)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(141, 25)
        Me.TextBox7.TabIndex = 149
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(9, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 18)
        Me.Label12.TabIndex = 150
        Me.Label12.Text = "Tipo"
        '
        'cmbTipo
        '
        Me.cmbTipo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(9, 96)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(124, 24)
        Me.cmbTipo.TabIndex = 4
        '
        'cmbProduto
        '
        Me.cmbProduto.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(139, 96)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(198, 24)
        Me.cmbProduto.TabIndex = 5
        '
        'cmbMarca
        '
        Me.cmbMarca.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(9, 147)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(167, 24)
        Me.cmbMarca.TabIndex = 7
        '
        'cmbModelo
        '
        Me.cmbModelo.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(182, 147)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(201, 24)
        Me.cmbModelo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label6.Font = New System.Drawing.Font("Adobe Gothic Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(410, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 20)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "R$ "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt12X)
        Me.GroupBox1.Controls.Add(Me.rbt11X)
        Me.GroupBox1.Controls.Add(Me.rbt10X)
        Me.GroupBox1.Controls.Add(Me.rbt9X)
        Me.GroupBox1.Controls.Add(Me.rbt8X)
        Me.GroupBox1.Controls.Add(Me.rbt7X)
        Me.GroupBox1.Controls.Add(Me.rbt6X)
        Me.GroupBox1.Controls.Add(Me.rbt5X)
        Me.GroupBox1.Controls.Add(Me.rbt4X)
        Me.GroupBox1.Controls.Add(Me.rbt3X)
        Me.GroupBox1.Controls.Add(Me.rbt2X)
        Me.GroupBox1.Controls.Add(Me.rbtVista)
        Me.GroupBox1.Location = New System.Drawing.Point(548, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 219)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'rbt12X
        '
        Me.rbt12X.AutoSize = True
        Me.rbt12X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt12X.Location = New System.Drawing.Point(122, 178)
        Me.rbt12X.Name = "rbt12X"
        Me.rbt12X.Size = New System.Drawing.Size(55, 20)
        Me.rbt12X.TabIndex = 27
        Me.rbt12X.Text = "12 X"
        Me.rbt12X.UseVisualStyleBackColor = True
        '
        'rbt11X
        '
        Me.rbt11X.AutoSize = True
        Me.rbt11X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt11X.Location = New System.Drawing.Point(12, 178)
        Me.rbt11X.Name = "rbt11X"
        Me.rbt11X.Size = New System.Drawing.Size(55, 20)
        Me.rbt11X.TabIndex = 26
        Me.rbt11X.Text = "11 X"
        Me.rbt11X.UseVisualStyleBackColor = True
        '
        'rbt10X
        '
        Me.rbt10X.AutoSize = True
        Me.rbt10X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt10X.Location = New System.Drawing.Point(122, 147)
        Me.rbt10X.Name = "rbt10X"
        Me.rbt10X.Size = New System.Drawing.Size(55, 20)
        Me.rbt10X.TabIndex = 25
        Me.rbt10X.Text = "10 X"
        Me.rbt10X.UseVisualStyleBackColor = True
        '
        'rbt9X
        '
        Me.rbt9X.AutoSize = True
        Me.rbt9X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt9X.Location = New System.Drawing.Point(12, 147)
        Me.rbt9X.Name = "rbt9X"
        Me.rbt9X.Size = New System.Drawing.Size(47, 20)
        Me.rbt9X.TabIndex = 24
        Me.rbt9X.Text = "9 X"
        Me.rbt9X.UseVisualStyleBackColor = True
        '
        'rbt8X
        '
        Me.rbt8X.AutoSize = True
        Me.rbt8X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt8X.Location = New System.Drawing.Point(121, 116)
        Me.rbt8X.Name = "rbt8X"
        Me.rbt8X.Size = New System.Drawing.Size(47, 20)
        Me.rbt8X.TabIndex = 23
        Me.rbt8X.Text = "8 X"
        Me.rbt8X.UseVisualStyleBackColor = True
        '
        'rbt7X
        '
        Me.rbt7X.AutoSize = True
        Me.rbt7X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt7X.Location = New System.Drawing.Point(12, 116)
        Me.rbt7X.Name = "rbt7X"
        Me.rbt7X.Size = New System.Drawing.Size(47, 20)
        Me.rbt7X.TabIndex = 22
        Me.rbt7X.Text = "7 X"
        Me.rbt7X.UseVisualStyleBackColor = True
        '
        'rbt6X
        '
        Me.rbt6X.AutoSize = True
        Me.rbt6X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt6X.Location = New System.Drawing.Point(121, 85)
        Me.rbt6X.Name = "rbt6X"
        Me.rbt6X.Size = New System.Drawing.Size(47, 20)
        Me.rbt6X.TabIndex = 21
        Me.rbt6X.Text = "6 X"
        Me.rbt6X.UseVisualStyleBackColor = True
        '
        'rbt5X
        '
        Me.rbt5X.AutoSize = True
        Me.rbt5X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt5X.Location = New System.Drawing.Point(12, 85)
        Me.rbt5X.Name = "rbt5X"
        Me.rbt5X.Size = New System.Drawing.Size(47, 20)
        Me.rbt5X.TabIndex = 20
        Me.rbt5X.Text = "5 X"
        Me.rbt5X.UseVisualStyleBackColor = True
        '
        'rbt4X
        '
        Me.rbt4X.AutoSize = True
        Me.rbt4X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt4X.Location = New System.Drawing.Point(121, 53)
        Me.rbt4X.Name = "rbt4X"
        Me.rbt4X.Size = New System.Drawing.Size(47, 20)
        Me.rbt4X.TabIndex = 19
        Me.rbt4X.Text = "4 X"
        Me.rbt4X.UseVisualStyleBackColor = True
        '
        'rbt3X
        '
        Me.rbt3X.AutoSize = True
        Me.rbt3X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt3X.Location = New System.Drawing.Point(12, 54)
        Me.rbt3X.Name = "rbt3X"
        Me.rbt3X.Size = New System.Drawing.Size(47, 20)
        Me.rbt3X.TabIndex = 18
        Me.rbt3X.Text = "3 X"
        Me.rbt3X.UseVisualStyleBackColor = True
        '
        'rbt2X
        '
        Me.rbt2X.AutoSize = True
        Me.rbt2X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt2X.Location = New System.Drawing.Point(121, 23)
        Me.rbt2X.Name = "rbt2X"
        Me.rbt2X.Size = New System.Drawing.Size(47, 20)
        Me.rbt2X.TabIndex = 17
        Me.rbt2X.Text = "2 X"
        Me.rbt2X.UseVisualStyleBackColor = True
        '
        'rbtVista
        '
        Me.rbtVista.AutoSize = True
        Me.rbtVista.Checked = True
        Me.rbtVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtVista.Location = New System.Drawing.Point(12, 23)
        Me.rbtVista.Name = "rbtVista"
        Me.rbtVista.Size = New System.Drawing.Size(75, 20)
        Me.rbtVista.TabIndex = 16
        Me.rbtVista.TabStop = True
        Me.rbtVista.Text = "À Vista"
        Me.rbtVista.UseVisualStyleBackColor = True
        '
        'lblQtdeParcela
        '
        Me.lblQtdeParcela.AutoSize = True
        Me.lblQtdeParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblQtdeParcela.ForeColor = System.Drawing.Color.White
        Me.lblQtdeParcela.Location = New System.Drawing.Point(545, 377)
        Me.lblQtdeParcela.Name = "lblQtdeParcela"
        Me.lblQtdeParcela.Size = New System.Drawing.Size(0, 16)
        Me.lblQtdeParcela.TabIndex = 156
        '
        'gbxEntrada
        '
        Me.gbxEntrada.Controls.Add(Me.rbtSEntrada)
        Me.gbxEntrada.Controls.Add(Me.rbtCEntrada)
        Me.gbxEntrada.Location = New System.Drawing.Point(569, 50)
        Me.gbxEntrada.Name = "gbxEntrada"
        Me.gbxEntrada.Size = New System.Drawing.Size(165, 99)
        Me.gbxEntrada.TabIndex = 157
        Me.gbxEntrada.TabStop = False
        '
        'rbtSEntrada
        '
        Me.rbtSEntrada.AutoSize = True
        Me.rbtSEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSEntrada.Location = New System.Drawing.Point(32, 51)
        Me.rbtSEntrada.Name = "rbtSEntrada"
        Me.rbtSEntrada.Size = New System.Drawing.Size(115, 20)
        Me.rbtSEntrada.TabIndex = 15
        Me.rbtSEntrada.Text = "Sem Entrada"
        Me.rbtSEntrada.UseVisualStyleBackColor = True
        '
        'rbtCEntrada
        '
        Me.rbtCEntrada.AutoSize = True
        Me.rbtCEntrada.Checked = True
        Me.rbtCEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCEntrada.Location = New System.Drawing.Point(32, 17)
        Me.rbtCEntrada.Name = "rbtCEntrada"
        Me.rbtCEntrada.Size = New System.Drawing.Size(115, 20)
        Me.rbtCEntrada.TabIndex = 14
        Me.rbtCEntrada.TabStop = True
        Me.rbtCEntrada.Text = "Com Entrada"
        Me.rbtCEntrada.UseVisualStyleBackColor = True
        '
        'lblEscolha
        '
        Me.lblEscolha.AutoSize = True
        Me.lblEscolha.BackColor = System.Drawing.Color.Transparent
        Me.lblEscolha.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscolha.ForeColor = System.Drawing.Color.White
        Me.lblEscolha.Location = New System.Drawing.Point(614, 399)
        Me.lblEscolha.Name = "lblEscolha"
        Me.lblEscolha.Size = New System.Drawing.Size(0, 18)
        Me.lblEscolha.TabIndex = 158
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 457)
        Me.Controls.Add(Me.lblEscolha)
        Me.Controls.Add(Me.gbxEntrada)
        Me.Controls.Add(Me.lblQtdeParcela)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbProduto)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblDataAtual)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPontos2)
        Me.Controls.Add(Me.btnPontos1)
        Me.Controls.Add(Me.dgvVendas)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeCli)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastramento de Vendas"
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxEntrada.ResumeLayout(False)
        Me.gbxEntrada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvVendas As System.Windows.Forms.DataGridView
    Friend WithEvents btnPontos1 As System.Windows.Forms.Button
    Friend WithEvents btnPontos2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents lblDataAtual As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProduto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModelo As System.Windows.Forms.ComboBox
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt12X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt11X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt10X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt9X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt8X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt7X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt6X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt5X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt4X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt3X As System.Windows.Forms.RadioButton
    Friend WithEvents rbt2X As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVista As System.Windows.Forms.RadioButton
    Friend WithEvents lblQtdeParcela As System.Windows.Forms.Label
    Friend WithEvents gbxEntrada As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents lblEscolha As System.Windows.Forms.Label
    Friend WithEvents CODPROD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECO As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
End Class
