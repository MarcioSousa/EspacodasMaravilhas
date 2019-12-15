<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Prestacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Prestacoes))
        Me.btnPontos1 = New System.Windows.Forms.Button()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomeCli = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.dgvPrestacoes = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENCIMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCLUSAO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCalculo = New System.Windows.Forms.TextBox()
        Me.btnConclusao = New System.Windows.Forms.Button()
        CType(Me.dgvPrestacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPontos1
        '
        Me.btnPontos1.AutoSize = True
        Me.btnPontos1.Location = New System.Drawing.Point(96, 30)
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
        Me.txtCodCli.Location = New System.Drawing.Point(12, 30)
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
        Me.Label8.Location = New System.Drawing.Point(12, 9)
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
        Me.Label1.Location = New System.Drawing.Point(148, 9)
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
        Me.txtNomeCli.Location = New System.Drawing.Point(142, 30)
        Me.txtNomeCli.MaxLength = 40
        Me.txtNomeCli.Name = "txtNomeCli"
        Me.txtNomeCli.Size = New System.Drawing.Size(190, 23)
        Me.txtNomeCli.TabIndex = 3
        Me.txtNomeCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(257, 342)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'dgvPrestacoes
        '
        Me.dgvPrestacoes.AllowUserToAddRows = False
        Me.dgvPrestacoes.AllowUserToDeleteRows = False
        Me.dgvPrestacoes.AllowUserToResizeColumns = False
        Me.dgvPrestacoes.AllowUserToResizeRows = False
        Me.dgvPrestacoes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPrestacoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrestacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestacoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.VENCIMENTO, Me.VALOR, Me.CONCLUSAO})
        Me.dgvPrestacoes.Location = New System.Drawing.Point(12, 87)
        Me.dgvPrestacoes.MultiSelect = False
        Me.dgvPrestacoes.Name = "dgvPrestacoes"
        Me.dgvPrestacoes.RowHeadersVisible = False
        Me.dgvPrestacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestacoes.Size = New System.Drawing.Size(186, 278)
        Me.dgvPrestacoes.TabIndex = 6
        '
        'COD
        '
        Me.COD.HeaderText = "Cod"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        Me.COD.Visible = False
        Me.COD.Width = 30
        '
        'VENCIMENTO
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.VENCIMENTO.DefaultCellStyle = DataGridViewCellStyle1
        Me.VENCIMENTO.HeaderText = "Vencimento"
        Me.VENCIMENTO.MaxInputLength = 10
        Me.VENCIMENTO.Name = "VENCIMENTO"
        Me.VENCIMENTO.ReadOnly = True
        Me.VENCIMENTO.Width = 70
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "Valor"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        Me.VALOR.Width = 80
        '
        'CONCLUSAO
        '
        Me.CONCLUSAO.HeaderText = "Con"
        Me.CONCLUSAO.Name = "CONCLUSAO"
        Me.CONCLUSAO.ReadOnly = True
        Me.CONCLUSAO.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(211, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Cálculo de Juros 2% AM"
        '
        'txtCalculo
        '
        Me.txtCalculo.Enabled = False
        Me.txtCalculo.Location = New System.Drawing.Point(214, 134)
        Me.txtCalculo.Name = "txtCalculo"
        Me.txtCalculo.Size = New System.Drawing.Size(118, 20)
        Me.txtCalculo.TabIndex = 4
        Me.txtCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConclusao
        '
        Me.btnConclusao.AutoSize = True
        Me.btnConclusao.Location = New System.Drawing.Point(214, 160)
        Me.btnConclusao.Name = "btnConclusao"
        Me.btnConclusao.Size = New System.Drawing.Size(118, 23)
        Me.btnConclusao.TabIndex = 5
        Me.btnConclusao.Text = "Concluir Pagamento"
        Me.btnConclusao.UseVisualStyleBackColor = True
        '
        'frm_Prestacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 377)
        Me.Controls.Add(Me.btnConclusao)
        Me.Controls.Add(Me.txtCalculo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvPrestacoes)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnPontos1)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeCli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Prestacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestações"
        CType(Me.dgvPrestacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPontos1 As System.Windows.Forms.Button
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCli As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents dgvPrestacoes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCalculo As System.Windows.Forms.TextBox
    Friend WithEvents btnConclusao As System.Windows.Forms.Button
    Friend WithEvents COD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENCIMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONCLUSAO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
