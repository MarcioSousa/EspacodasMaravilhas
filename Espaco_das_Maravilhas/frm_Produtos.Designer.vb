<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Produtos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Produtos))
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELOLINHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOVEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPesquisa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblProCad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoupasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LingerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemijoiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfumesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosméticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutrosToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.OutrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.PRODUTOS, Me.MARCA, Me.MODELOLINHA, Me.PRECOVEN})
        Me.dgvProdutos.Location = New System.Drawing.Point(23, 72)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProdutos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(714, 208)
        Me.dgvProdutos.TabIndex = 14
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "Codigo"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Visible = False
        '
        'PRODUTOS
        '
        Me.PRODUTOS.HeaderText = "Produtos"
        Me.PRODUTOS.Name = "PRODUTOS"
        Me.PRODUTOS.ReadOnly = True
        Me.PRODUTOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRODUTOS.Width = 200
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "Marca"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MARCA.Width = 160
        '
        'MODELOLINHA
        '
        Me.MODELOLINHA.HeaderText = "Modelo/Linha"
        Me.MODELOLINHA.Name = "MODELOLINHA"
        Me.MODELOLINHA.ReadOnly = True
        Me.MODELOLINHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MODELOLINHA.Width = 250
        '
        'PRECOVEN
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PRECOVEN.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRECOVEN.HeaderText = "Venda"
        Me.PRECOVEN.Name = "PRECOVEN"
        Me.PRECOVEN.ReadOnly = True
        Me.PRECOVEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRECOVEN.Width = 90
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtPesquisa.ForeColor = System.Drawing.Color.Black
        Me.txtPesquisa.Location = New System.Drawing.Point(522, 31)
        Me.txtPesquisa.MaxLength = 40
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(215, 23)
        Me.txtPesquisa.TabIndex = 15
        Me.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(397, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 18)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Procurar Produtos"
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(347, 390)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(266, 390)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(185, 390)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(104, 390)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(23, 390)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(428, 390)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        Me.btnConfirmar.Visible = False
        '
        'lblProCad
        '
        Me.lblProCad.AutoSize = True
        Me.lblProCad.BackColor = System.Drawing.Color.Transparent
        Me.lblProCad.Font = New System.Drawing.Font("Humnst777 Cn BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProCad.ForeColor = System.Drawing.Color.Black
        Me.lblProCad.Location = New System.Drawing.Point(687, 392)
        Me.lblProCad.Name = "lblProCad"
        Me.lblProCad.Size = New System.Drawing.Size(0, 19)
        Me.lblProCad.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(534, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Produtos Cadastrados:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.Transparent
        Me.lblModelo.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(445, 285)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(55, 18)
        Me.lblModelo.TabIndex = 129
        Me.lblModelo.Text = "Modelo"
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(448, 304)
        Me.txtModelo.MaxLength = 35
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(289, 25)
        Me.txtModelo.TabIndex = 10
        Me.txtModelo.Text = "Yonim"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(297, 283)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(47, 18)
        Me.lblMarca.TabIndex = 127
        Me.lblMarca.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(300, 304)
        Me.txtMarca.MaxLength = 35
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(142, 25)
        Me.txtMarca.TabIndex = 9
        Me.txtMarca.Text = "Jongueteristo"
        '
        'txtCodProd
        '
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodProd.ForeColor = System.Drawing.Color.Black
        Me.txtCodProd.Location = New System.Drawing.Point(24, 306)
        Me.txtCodProd.MaxLength = 5
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(48, 23)
        Me.txtCodProd.TabIndex = 7
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(78, 285)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(119, 18)
        Me.lblNome.TabIndex = 125
        Me.lblNome.Text = "Nome do Produto"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(77, 306)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(217, 23)
        Me.txtNome.TabIndex = 8
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.Color.White
        Me.lblCod.Location = New System.Drawing.Point(20, 285)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(52, 18)
        Me.lblCod.TabIndex = 126
        Me.lblCod.Text = "Código"
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.BackColor = System.Drawing.Color.Transparent
        Me.lblPreco.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.ForeColor = System.Drawing.Color.White
        Me.lblPreco.Location = New System.Drawing.Point(521, 338)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(71, 18)
        Me.lblPreco.TabIndex = 133
        Me.lblPreco.Text = "Venda: R$"
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompra.Location = New System.Drawing.Point(334, 335)
        Me.txtCompra.MaxLength = 35
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(88, 25)
        Me.txtCompra.TabIndex = 12
        Me.txtCompra.Visible = False
        '
        'txtPreco
        '
        Me.txtPreco.Enabled = False
        Me.txtPreco.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreco.Location = New System.Drawing.Point(593, 335)
        Me.txtPreco.MaxLength = 35
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(88, 25)
        Me.txtPreco.TabIndex = 13
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblCompra.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.ForeColor = System.Drawing.Color.White
        Me.lblCompra.Location = New System.Drawing.Point(250, 338)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(82, 18)
        Me.lblCompra.TabIndex = 131
        Me.lblCompra.Text = "Compra: R$"
        Me.lblCompra.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 135
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoupasToolStripMenuItem, Me.LingerieToolStripMenuItem, Me.SemijoiasToolStripMenuItem, Me.PerfumesToolStripMenuItem, Me.CosméticosToolStripMenuItem, Me.OutrosToolStripMenuItem, Me.OutrosToolStripMenuItem1, Me.TodosToolStripMenuItem})
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.TiposToolStripMenuItem.Text = "Tipos"
        '
        'RoupasToolStripMenuItem
        '
        Me.RoupasToolStripMenuItem.Name = "RoupasToolStripMenuItem"
        Me.RoupasToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RoupasToolStripMenuItem.Text = "Roupas"
        '
        'LingerieToolStripMenuItem
        '
        Me.LingerieToolStripMenuItem.Name = "LingerieToolStripMenuItem"
        Me.LingerieToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LingerieToolStripMenuItem.Text = "Lingerie"
        '
        'SemijoiasToolStripMenuItem
        '
        Me.SemijoiasToolStripMenuItem.Name = "SemijoiasToolStripMenuItem"
        Me.SemijoiasToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SemijoiasToolStripMenuItem.Text = "Semi-joias"
        '
        'PerfumesToolStripMenuItem
        '
        Me.PerfumesToolStripMenuItem.Name = "PerfumesToolStripMenuItem"
        Me.PerfumesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PerfumesToolStripMenuItem.Text = "Perfumes"
        '
        'CosméticosToolStripMenuItem
        '
        Me.CosméticosToolStripMenuItem.Name = "CosméticosToolStripMenuItem"
        Me.CosméticosToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CosméticosToolStripMenuItem.Text = "Cosméticos"
        '
        'OutrosToolStripMenuItem
        '
        Me.OutrosToolStripMenuItem.Name = "OutrosToolStripMenuItem"
        Me.OutrosToolStripMenuItem.Size = New System.Drawing.Size(133, 6)
        '
        'OutrosToolStripMenuItem1
        '
        Me.OutrosToolStripMenuItem1.Name = "OutrosToolStripMenuItem1"
        Me.OutrosToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.OutrosToolStripMenuItem1.Text = "Outros"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Tipo"
        '
        'cbxTipo
        '
        Me.cbxTipo.Enabled = False
        Me.cbxTipo.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!)
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Roupas", "Acessórios", "Lingerie", "Semi-Jóias", "Perfumes", "Cosméticos", "Outros"})
        Me.cbxTipo.Location = New System.Drawing.Point(61, 338)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(140, 26)
        Me.cbxTipo.TabIndex = 11
        '
        'frm_Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 436)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblProCad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents txtPesquisa As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents lblProCad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents txtCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELOLINHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECOVEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoupasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LingerieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemijoiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfumesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CosméticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutrosToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OutrosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
