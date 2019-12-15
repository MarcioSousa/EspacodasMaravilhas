<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ListaProdutos))
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELOLINHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodProd
        '
        Me.txtCodProd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodProd.ForeColor = System.Drawing.Color.Black
        Me.txtCodProd.Location = New System.Drawing.Point(397, 12)
        Me.txtCodProd.MaxLength = 20
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(297, 23)
        Me.txtCodProd.TabIndex = 3
        Me.txtCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(272, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 18)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Procurar Produtos"
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(619, 430)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionar.TabIndex = 1
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 430)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        Me.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.TIPO, Me.PRODUTOS, Me.MARCA, Me.MODELOLINHA, Me.PRECO})
        Me.dgvProdutos.Location = New System.Drawing.Point(12, 47)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(682, 375)
        Me.dgvProdutos.TabIndex = 4
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "Cod"
        Me.CODIGO.MaxInputLength = 8
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Visible = False
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'PRODUTOS
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PRODUTOS.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRODUTOS.HeaderText = "Produtos"
        Me.PRODUTOS.Name = "PRODUTOS"
        Me.PRODUTOS.ReadOnly = True
        Me.PRODUTOS.Width = 130
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "Marca"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MARCA.Width = 120
        '
        'MODELOLINHA
        '
        Me.MODELOLINHA.HeaderText = "Modelo/Linha"
        Me.MODELOLINHA.Name = "MODELOLINHA"
        Me.MODELOLINHA.ReadOnly = True
        Me.MODELOLINHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MODELOLINHA.Width = 200
        '
        'PRECO
        '
        Me.PRECO.HeaderText = "Preço"
        Me.PRECO.Name = "PRECO"
        Me.PRECO.ReadOnly = True
        Me.PRECO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frm_ListaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 465)
        Me.Controls.Add(Me.txtCodProd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dgvProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ListaProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Produtos"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELOLINHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
