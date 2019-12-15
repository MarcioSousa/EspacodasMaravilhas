
Public Class frm_Estocar

    Private Sub carrega_campos()

        dgvProdutos.Rows.Clear()

        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT P.tipo_prod, P.nome_prod, P.marca_prod, P.modelo_prod, P.preco_com_prod, P.preco_ven_prod, E.cod_est, E.saida_est, E.total_est FROM Estoque E INNER JOIN Produtos P ON E.cod_prod = P.cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_est"), CDec(leitor("total_est") - CDec(leitor("saida_est"))), leitor("tipo_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_com_prod")), String.Format("{0:c}", leitor("preco_ven_prod")))
        'Loop

        'con.Close()

    End Sub

    Private Sub frm_Estocar_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub frm_Estocar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_campos()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "Adicionar Estoque" Then
            txtEstoque.Enabled = True
            dgvProdutos.Enabled = False
            btnAdd.Text = "Concluir Estoque"
            txtEstoque.Focus()
        Else
            alterar_tabela()
            btnAdd.Text = "Adicionar Estoque"
            txtEstoque.Text = ""
            txtEstoque.Enabled = False
            dgvProdutos.Enabled = True
        End If

    End Sub

    Private Sub alterar_tabela()
        Dim ind As Integer = dgvProdutos.CurrentRow.Index
        Dim valor As Integer = dgvProdutos.Rows(ind).Cells(0).Value


        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        ''comando.CommandText = "SELECT * FROM Estoque WHERE cod_est = " & valor
        'comando.CommandText = "UPDATE Estoque SET total_est = total_est + " & txtEstoque.Text & " WHERE cod_est = " & valor
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As String
        'leitor = comando.ExecuteNonQuery

        'con.Close()

        carrega_campos()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        dgvProdutos.Enabled = True
        btnAdd.Text = "Adicionar Estoque"
        txtEstoque.Enabled = False
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class