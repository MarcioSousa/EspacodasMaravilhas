<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListaVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ListaVendas))
        Me.btnPontos1 = New System.Windows.Forms.Button()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.dgvListaVendas = New System.Windows.Forms.DataGridView()
        Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATACOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dgvListaVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPontos1
        '
        Me.btnPontos1.AutoSize = True
        Me.btnPontos1.Location = New System.Drawing.Point(96, 35)
        Me.btnPontos1.Name = "btnPontos1"
        Me.btnPontos1.Size = New System.Drawing.Size(40, 23)
        Me.btnPontos1.TabIndex = 2
        Me.btnPontos1.Text = "..."
        Me.btnPontos1.UseVisualStyleBackColor = True
        '
        'txtCodCli
        '
        Me.txtCodCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtCodCli.ForeColor = System.Drawing.Color.Black
        Me.txtCodCli.Location = New System.Drawing.Point(12, 35)
        Me.txtCodCli.MaxLength = 5
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(78, 23)
        Me.txtCodCli.TabIndex = 1
        Me.txtCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(148, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Cliente"
        '
        'txtNomeCli
        '
        Me.txtNomeCli.Enabled = False
        Me.txtNomeCli.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeCli.ForeColor = System.Drawing.Color.Black
        Me.txtNomeCli.Location = New System.Drawing.Point(142, 35)
        Me.txtNomeCli.MaxLength = 40
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(352, 23)
        Me.txtNomeCli.TabIndex = 3
        Me.txtNomeCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvListaVendas
        '
        Me.dgvListaVendas.AllowUserToAddRows = False
        Me.dgvListaVendas.AllowUserToDeleteRows = False
        Me.dgvListaVendas.AllowUserToResizeColumns = False
        Me.dgvListaVendas.AllowUserToResizeRows = False
        Me.dgvListaVendas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvListaVendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTO, Me.QTDE, Me.VALOR, Me.DATACOM})
        Me.dgvListaVendas.Location = New System.Drawing.Point(12, 77)
        Me.dgvListaVendas.MultiSelect = False
        Me.dgvListaVendas.Name = "dgvListaVendas"
        Me.dgvListaVendas.RowHeadersVisible = False
        Me.dgvListaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaVendas.Size = New System.Drawing.Size(482, 344)
        Me.dgvListaVendas.TabIndex = 4
        '
        'PRODUTO
        '
        Me.PRODUTO.HeaderText = "Produto"
        Me.PRODUTO.MaxInputLength = 30
        Me.PRODUTO.Name = "PRODUTO"
        Me.PRODUTO.ReadOnly = True
        Me.PRODUTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRODUTO.Width = 190
        '
        'QTDE
        '
        Me.QTDE.HeaderText = "Qtde"
        Me.QTDE.MaxInputLength = 3
        Me.QTDE.Name = "QTDE"
        Me.QTDE.ReadOnly = True
        Me.QTDE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.QTDE.Width = 40
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "Valor"
        Me.VALOR.MaxInputLength = 15
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        Me.VALOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DATACOM
        '
        Me.DATACOM.HeaderText = "Data Compra"
        Me.DATACOM.MaxInputLength = 10
        Me.DATACOM.Name = "DATACOM"
        Me.DATACOM.ReadOnly = True
        Me.DATACOM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DATACOM.Width = 120
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(419, 427)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 5
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frm_ListaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 462)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.dgvListaVendas)
        Me.Controls.Add(Me.btnPontos1)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ListaVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Vendas"
        CType(Me.dgvListaVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPontos1 As System.Windows.Forms.Button
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvListaVendas As System.Windows.Forms.DataGridView
    Friend WithEvents PRODUTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATACOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
