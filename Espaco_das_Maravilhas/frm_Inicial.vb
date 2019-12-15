
Public Class frm_Inicial

    Public Sub lendo_banco_dados_clientes()
        Dim contador As Integer = 1
        Dim passou As Boolean = False

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "SELECT cod_cli FROM Clientes ORDER BY cod_cli"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As SqlServerCe.SqlCeDataReader
        leitor = comando.ExecuteReader

        Do While leitor.Read
            If Not leitor("cod_cli") = contador Then
                passou = True
                Exit Do
            End If
            contador += 1
            passou = True
        Loop

        If passou = False Then
            frm_CadClientes.txtCodCli.Text = 1
        Else
            frm_CadClientes.txtCodCli.Text = contador
        End If

        con.Close()

    End Sub
    Public Sub lendo_banco_dados_produtos()
        Dim contador As Integer = 1
        Dim passou As Boolean = False

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "SELECT cod_prod FROM Produtos ORDER BY cod_prod"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As SqlServerCe.SqlCeDataReader
        leitor = comando.ExecuteReader

        Do While leitor.Read
            If Not leitor("cod_prod") = contador Then
                passou = True
                Exit Do
            End If
            contador += 1
            passou = True
        Loop

        If passou = False Then
            frm_CadProdutos.txtCodProd.Text = 1
        Else
            frm_CadProdutos.txtCodProd.Text = contador
        End If

        con.Close()
    End Sub
    Public Sub lendo_banco_dados_vendas()
        Dim contador As Integer = 1
        Dim passou As Boolean = False

        'Dim con As New SqlServerCe.SqlCeConnection
        'con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        'con.Open()
        'Dim comando As New SqlServerCe.SqlCeCommand
        'comando.CommandText = "SELECT cod_com FROM Compras ORDER BY cod_com"
        'comando.CommandType = CommandType.Text
        'Dim leitor As SqlServerCe.SqlCeDataReader

        'Do While leitor.Read
        '    If Not leitor("cod_com") = contador Then
        '        passou = True
        '        Exit Do
        '    End If
        '    contador += 1
        '    passou = True
        'Loop

        'If passou = False Then
        '    frm_CadVendas.lblCompra.Text = 1
        'Else
        '    frm_CadVendas.lblCompra.Text = contador
        'End If

        'con.Close()



        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT cod_com FROM Compras ORDER BY cod_com"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    If Not leitor("cod_com") = contador Then
        '        passou = True
        '        Exit Do
        '    End If
        '    contador += 1
        '    passou = True
        'Loop

        'If passou = False Then
        '    frm_CadVendas.lblCompra.Text = 1
        'Else
        '    frm_CadVendas.lblCompra.Text = contador
        'End If

        'con.Close()
    End Sub

    Private Sub btnNCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        Me.Enabled = False
        frm_Clientes.Show()
    End Sub
    Private Sub btnNProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduto.Click
        lendo_banco_dados_produtos()

        frm_CadProdutos.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnNVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenda.Click
        lendo_banco_dados_vendas()

        frm_CadVendas.Show()
        frm_CadVendas.btnExcluir.Enabled = False
        frm_CadVendas.btnConfirmar.Enabled = False
        Me.Enabled = False
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        lendo_banco_dados_clientes()

        Me.Enabled = False
        frm_CadClientes.Show()
    End Sub
    Private Sub ProdutoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        lendo_banco_dados_produtos()

        Me.Enabled = False
        frm_CadProdutos.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click
        frm_Produtos.Show()
        Me.Enabled = False
    End Sub
    Private Sub VendaToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles VendaToolStripMenuItem1.Click
        frm_Clientes.Show()
        Me.Enabled = False
    End Sub

    Private Sub FecharToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FecharToolStripMenuItem.Click
        If MessageBox.Show("Deseja encerrar e fechar todo o programa?", "Aviso de encerramento", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub VendaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Me.Enabled = False
        frm_Clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_Prestacoes.Show()
        Me.Enabled = False
        frm_Prestacoes.btnConclusao.Enabled = False
    End Sub

    Private Sub btnEstocar_Click(sender As System.Object, e As System.EventArgs) Handles btnEstocar.Click
        frm_Estocar.Show()
        Me.Enabled = False
    End Sub

    Private Sub VendaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VendaToolStripMenuItem.Click
        lendo_banco_dados_vendas()

        frm_CadVendas.Show()
        frm_CadVendas.btnExcluir.Enabled = False
        frm_CadVendas.btnConfirmar.Enabled = False
        Me.Enabled = False
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VendasToolStripMenuItem.Click
        frm_ListaVendas.Show()
        Me.Enabled = False
    End Sub

    Private Sub VendasToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles VendasToolStripMenuItem1.Click
        frm_InformVendas.Show()
        Me.Enabled = False
    End Sub

    Private Sub frm_Inicial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT A.nome_cli, A.tel_cel_cli, C.dt_com FROM Compras C INNER JOIN Clientes A ON C.cod_cli = A.cod_cli"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader
        'Do While leitor.Read()
        '    dgvGeral.Rows.Add(leitor("nome_cli"), leitor("tel_cel_cli"), String.Format(leitor("dt_com")))
        'Loop


        'con.Close()
    End Sub

    Private Sub btnEsconder_Click(sender As System.Object, e As System.EventArgs) Handles btnEsconder.Click
        If dgvGeral.Visible = False Then
            dgvGeral.Visible = True
            btnEsconder.Text = "Esconder"
        Else
            dgvGeral.Visible = False
            btnEsconder.Text = "Mostrar"
        End If
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TwitterToolStripMenuItem.Click
        MessageBox.Show("Para entrar em contato através do Twitter, entre em contato pelo @MarcioItu.", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacebookToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/cadfacil")
    End Sub

    Private Sub SkypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SkypeToolStripMenuItem.Click
        MessageBox.Show("Para entrar em contato através do Skype, só procurar por marciosousaitu.", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub EmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        MessageBox.Show("Entre em contato através do email: marciofrapeso@hotmail.com", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class