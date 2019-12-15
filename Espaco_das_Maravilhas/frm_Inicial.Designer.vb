<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Inicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Inicial))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.btnVenda = New System.Windows.Forms.Button()
        Me.dgvGeral = New System.Windows.Forms.DataGridView()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTATO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTULTCOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEstocar = New System.Windows.Forms.Button()
        Me.btnEsconder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.FormulárioToolStripMenuItem, Me.InformaçõesToolStripMenuItem, Me.ContatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(652, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProdutoToolStripMenuItem, Me.VendaToolStripMenuItem, Me.ToolStripMenuItem1, Me.FecharToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ClientesToolStripMenuItem.Text = "Cliente"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ProdutoToolStripMenuItem.Text = "Produto"
        '
        'VendaToolStripMenuItem
        '
        Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
        Me.VendaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.VendaToolStripMenuItem.Text = "Venda"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 6)
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'FormulárioToolStripMenuItem
        '
        Me.FormulárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendaToolStripMenuItem1, Me.ProdutosToolStripMenuItem, Me.VendasToolStripMenuItem})
        Me.FormulárioToolStripMenuItem.Name = "FormulárioToolStripMenuItem"
        Me.FormulárioToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FormulárioToolStripMenuItem.Text = "Formulário"
        '
        'VendaToolStripMenuItem1
        '
        Me.VendaToolStripMenuItem1.Name = "VendaToolStripMenuItem1"
        Me.VendaToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.VendaToolStripMenuItem1.Text = "Clientes"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'InformaçõesToolStripMenuItem
        '
        Me.InformaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendasToolStripMenuItem1})
        Me.InformaçõesToolStripMenuItem.Name = "InformaçõesToolStripMenuItem"
        Me.InformaçõesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.InformaçõesToolStripMenuItem.Text = "Informações"
        '
        'VendasToolStripMenuItem1
        '
        Me.VendasToolStripMenuItem1.Name = "VendasToolStripMenuItem1"
        Me.VendasToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.VendasToolStripMenuItem1.Text = "Vendas"
        '
        'ContatosToolStripMenuItem
        '
        Me.ContatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TwitterToolStripMenuItem, Me.FacebookToolStripMenuItem, Me.SkypeToolStripMenuItem, Me.EmailToolStripMenuItem})
        Me.ContatosToolStripMenuItem.Name = "ContatosToolStripMenuItem"
        Me.ContatosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ContatosToolStripMenuItem.Text = "Contatos"
        '
        'TwitterToolStripMenuItem
        '
        Me.TwitterToolStripMenuItem.Image = CType(resources.GetObject("TwitterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TwitterToolStripMenuItem.Name = "TwitterToolStripMenuItem"
        Me.TwitterToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.TwitterToolStripMenuItem.Text = "Twitter"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.Image = CType(resources.GetObject("FacebookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.FacebookToolStripMenuItem.Text = "Facebook"
        '
        'SkypeToolStripMenuItem
        '
        Me.SkypeToolStripMenuItem.Image = CType(resources.GetObject("SkypeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SkypeToolStripMenuItem.Name = "SkypeToolStripMenuItem"
        Me.SkypeToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SkypeToolStripMenuItem.Text = "Skype"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Image = CType(resources.GetObject("EmailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(12, 46)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(99, 60)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProduto
        '
        Me.btnProduto.Location = New System.Drawing.Point(117, 46)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(99, 60)
        Me.btnProduto.TabIndex = 3
        Me.btnProduto.Text = "Produto"
        Me.btnProduto.UseVisualStyleBackColor = True
        '
        'btnVenda
        '
        Me.btnVenda.Location = New System.Drawing.Point(222, 46)
        Me.btnVenda.Name = "btnVenda"
        Me.btnVenda.Size = New System.Drawing.Size(99, 60)
        Me.btnVenda.TabIndex = 4
        Me.btnVenda.Text = "Venda"
        Me.btnVenda.UseVisualStyleBackColor = True
        '
        'dgvGeral
        '
        Me.dgvGeral.AllowUserToAddRows = False
        Me.dgvGeral.AllowUserToDeleteRows = False
        Me.dgvGeral.AllowUserToResizeColumns = False
        Me.dgvGeral.AllowUserToResizeRows = False
        Me.dgvGeral.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvGeral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.CONTATO, Me.DTULTCOM})
        Me.dgvGeral.Location = New System.Drawing.Point(73, 214)
        Me.dgvGeral.MultiSelect = False
        Me.dgvGeral.Name = "dgvGeral"
        Me.dgvGeral.RowHeadersVisible = False
        Me.dgvGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGeral.Size = New System.Drawing.Size(510, 191)
        Me.dgvGeral.TabIndex = 8
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 280
        '
        'CONTATO
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CONTATO.DefaultCellStyle = DataGridViewCellStyle5
        Me.CONTATO.HeaderText = "Contato"
        Me.CONTATO.Name = "CONTATO"
        Me.CONTATO.ReadOnly = True
        Me.CONTATO.Width = 110
        '
        'DTULTCOM
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DTULTCOM.DefaultCellStyle = DataGridViewCellStyle6
        Me.DTULTCOM.HeaderText = "Dt.Últ.Compra"
        Me.DTULTCOM.Name = "DTULTCOM"
        Me.DTULTCOM.ReadOnly = True
        Me.DTULTCOM.Width = 90
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 60)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Prestações"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEstocar
        '
        Me.btnEstocar.Location = New System.Drawing.Point(327, 46)
        Me.btnEstocar.Name = "btnEstocar"
        Me.btnEstocar.Size = New System.Drawing.Size(99, 60)
        Me.btnEstocar.TabIndex = 5
        Me.btnEstocar.Text = "Estocar"
        Me.btnEstocar.UseVisualStyleBackColor = True
        '
        'btnEsconder
        '
        Me.btnEsconder.Location = New System.Drawing.Point(537, 46)
        Me.btnEsconder.Name = "btnEsconder"
        Me.btnEsconder.Size = New System.Drawing.Size(99, 60)
        Me.btnEsconder.TabIndex = 7
        Me.btnEsconder.Text = "Esconder"
        Me.btnEsconder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(196, 310)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frm_Inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 465)
        Me.Controls.Add(Me.btnEsconder)
        Me.Controls.Add(Me.btnEstocar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVenda)
        Me.Controls.Add(Me.btnProduto)
        Me.Controls.Add(Me.dgvGeral)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Inicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minha Loja"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormulárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnVenda As System.Windows.Forms.Button
    Friend WithEvents btnProduto As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents dgvGeral As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEstocar As System.Windows.Forms.Button
    Friend WithEvents InformaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTATO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTULTCOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEsconder As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TwitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
