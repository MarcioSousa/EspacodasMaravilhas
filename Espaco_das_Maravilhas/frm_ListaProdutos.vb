
Public Class frm_ListaProdutos
    Dim vCodigo As Integer
    Public vpassou As Boolean = False

    Private Sub carrega_grid()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("tipo_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), "R$ " & String.Format("{0:f2}", leitor("preco_ven_prod")))
        'Loop

        'con.Close()

    End Sub

    Private Sub frm_ListaProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        frm_CadVendas.Enabled = True
        Me.Close()
    End Sub

    Private Sub frm_ListaProdutos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_CadVendas.Enabled = True
    End Sub

    Private Sub btnSelecionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecionar.Click
        Dim linha As Integer = dgvProdutos.CurrentRow.Index
        Dim valor As Integer = dgvProdutos.Rows(linha).Cells(0).Value
        vpassou = True

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE cod_prod = " & valor
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'leitor.Read()
        'frm_CadVendas.cmbTipo.Text = leitor("tipo_prod")
        'frm_CadVendas.cmbProduto.Text = leitor("nome_prod")
        'frm_CadVendas.cmbMarca.Text = leitor("marca_prod")
        'frm_CadVendas.cmbModelo.Text = leitor("modelo_prod")

        'frm_CadVendas.lblPreco.Text = String.Format("{0:f2}", leitor("preco_ven_prod"))

        'con.Close()
        frm_CadVendas.Enabled = True
        Me.Close()

        frm_CadVendas.txtQtde.Focus()
    End Sub


    Private Sub txtCodProd_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodProd.TextChanged
        dgvProdutos.Rows.Clear()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE nome_prod like '%" & txtCodProd.Text.Trim.ToUpper & "%'"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("tipo_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        'Loop

        'con.Close()
    End Sub
End Class