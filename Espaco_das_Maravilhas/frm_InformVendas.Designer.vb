<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InformVendas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_InformVendas))
        Me.dgvInformCompras = New System.Windows.Forms.DataGridView()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATACOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORCOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dgvInformCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInformCompras
        '
        Me.dgvInformCompras.AllowUserToAddRows = False
        Me.dgvInformCompras.AllowUserToDeleteRows = False
        Me.dgvInformCompras.AllowUserToResizeColumns = False
        Me.dgvInformCompras.AllowUserToResizeRows = False
        Me.dgvInformCompras.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvInformCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInformCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInformCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.DATACOMPRA, Me.VALORCOMPRA})
        Me.dgvInformCompras.Location = New System.Drawing.Point(12, 12)
        Me.dgvInformCompras.MultiSelect = False
        Me.dgvInformCompras.Name = "dgvInformCompras"
        Me.dgvInformCompras.RowHeadersVisible = False
        Me.dgvInformCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInformCompras.Size = New System.Drawing.Size(492, 390)
        Me.dgvInformCompras.TabIndex = 0
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 270
        '
        'DATACOMPRA
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DATACOMPRA.DefaultCellStyle = DataGridViewCellStyle1
        Me.DATACOMPRA.HeaderText = "Data Compra"
        Me.DATACOMPRA.Name = "DATACOMPRA"
        Me.DATACOMPRA.ReadOnly = True
        '
        'VALORCOMPRA
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VALORCOMPRA.DefaultCellStyle = DataGridViewCellStyle2
        Me.VALORCOMPRA.HeaderText = "Valor Compra"
        Me.VALORCOMPRA.Name = "VALORCOMPRA"
        Me.VALORCOMPRA.ReadOnly = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(429, 414)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frm_InformVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 449)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.dgvInformCompras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_InformVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informação de Vendas"
        CType(Me.dgvInformCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvInformCompras As System.Windows.Forms.DataGridView
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATACOMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALORCOMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
