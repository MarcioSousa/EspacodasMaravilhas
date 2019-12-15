
Public Class frm_ListaClientes

    Private Sub frm_ListaClientes_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_CadVendas.Enabled = True
        frm_Prestacoes.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        frm_CadVendas.Enabled = True
        Me.Close()
    End Sub

    Private Sub frm_ListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregando_grid()
    End Sub

    Private Sub carregando_grid()
        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes order by cod_cli"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvCliente.Rows.Add(leitor("cod_cli"), leitor("nome_cli"))
        'Loop

        'con.Close()

    End Sub

    Private Sub btnSelecionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecionar.Click
        Dim linha As Integer = dgvCliente.CurrentRow.Index
        Dim valor As Integer = dgvCliente.Rows(linha).Cells(0).Value

        If frm_CadVendas.VendaPrestac = "Vendas" Then


            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes WHERE cod_cli = " & valor
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'leitor.Read()

            'frm_CadVendas.txtCodCli.Text = leitor("cod_cli")
            'frm_CadVendas.txtNomeCli.Text = leitor("nome_cli")

            'con.Close()
            'frm_CadVendas.Enabled = True
            'Me.Close()
        ElseIf frm_CadVendas.VendaPrestac = "ListaVendas" Then
            frm_ListaVendas.dgvListaVendas.Rows.Clear()

            'Dim con As New MySqlConnection
            'Dim comando As New MySqlCommand
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"
            'Dim leitor As MySqlDataReader

            'con.Open()

            'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes WHERE cod_cli = " & valor
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'leitor = comando.ExecuteReader
            'leitor.Read()

            'frm_ListaVendas.txtCodCli.Text = leitor("cod_cli")
            'frm_ListaVendas.txtNomeCli.Text = leitor("nome_cli")

            'con.Close()

            'con.Open()

            'comando.CommandText = "SELECT P.nome_prod, S.Qtde_prod, S.valor_prod, C.dt_com FROM (Produtos P INNER JOIN Saida_Prod S ON S.cod_prod = P.cod_prod) INNER JOIN Compras C ON C.cod_ven_prod = S.cod_ven_prod WHERE S.cod_cli = " & frm_ListaVendas.txtCodCli.Text
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'leitor = comando.ExecuteReader
            'Do While leitor.Read()
            '    frm_ListaVendas.dgvListaVendas.Rows.Add(leitor("nome_prod"), leitor("Qtde_prod"), String.Format("{0:c}", leitor("valor_prod")), String.Format(leitor("dt_com")))
            'Loop

            'con.Close()


            'frm_ListaVendas.Enabled = True
            'Me.Close()

        Else
            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes WHERE cod_cli = " & valor
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'leitor.Read()

            'frm_Prestacoes.txtCodCli.Text = leitor("cod_cli")
            'frm_Prestacoes.txtNomeCli.Text = leitor("nome_cli")

            'con.Close()
            'frm_Prestacoes.Enabled = True
            'Me.Close()
        End If


    End Sub

    Private Sub txtCodCli_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodCli.TextChanged
        dgvCliente.Rows.Clear()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes WHERE nome_cli like '%" & txtCodCli.Text.Trim.ToUpper & "%'"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvCliente.Rows.Add(leitor("cod_cli"), leitor("nome_cli"))
        'Loop

        'con.Close()
    End Sub

End Class