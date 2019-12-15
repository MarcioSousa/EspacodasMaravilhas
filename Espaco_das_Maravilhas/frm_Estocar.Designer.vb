<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Estocar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Estocar))
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.EST, Me.TIPO, Me.NOME, Me.MARCA, Me.MODELO, Me.PRECOC, Me.PRECOV})
        Me.dgvProdutos.Location = New System.Drawing.Point(12, 12)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(770, 301)
        Me.dgvProdutos.TabIndex = 0
        '
        'COD
        '
        Me.COD.HeaderText = "C"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        Me.COD.Visible = False
        Me.COD.Width = 30
        '
        'EST
        '
        Me.EST.HeaderText = "Est"
        Me.EST.Name = "EST"
        Me.EST.ReadOnly = True
        Me.EST.Width = 40
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "Tipo"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'NOME
        '
        Me.NOME.HeaderText = "Nome"
        Me.NOME.Name = "NOME"
        Me.NOME.ReadOnly = True
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "Marca"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        '
        'MODELO
        '
        Me.MODELO.HeaderText = "Modelo"
        Me.MODELO.Name = "MODELO"
        Me.MODELO.ReadOnly = True
        Me.MODELO.Width = 200
        '
        'PRECOC
        '
        Me.PRECOC.HeaderText = "Preçoc(c)"
        Me.PRECOC.Name = "PRECOC"
        Me.PRECOC.ReadOnly = True
        '
        'PRECOV
        '
        Me.PRECOV.HeaderText = "Preço (v)"
        Me.PRECOV.Name = "PRECOV"
        Me.PRECOV.ReadOnly = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Location = New System.Drawing.Point(65, 317)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(103, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Adicionar Estoque"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Location = New System.Drawing.Point(12, 319)
        Me.txtEstoque.MaxLength = 3
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(47, 20)
        Me.txtEstoque.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.Location = New System.Drawing.Point(65, 346)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.Location = New System.Drawing.Point(705, 319)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(77, 23)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frm_Estocar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 382)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Estocar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estocar"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtEstoque As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents COD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODELO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECOV As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
