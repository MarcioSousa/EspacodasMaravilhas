
Public Class frm_CadProdutos
    Dim passou As Boolean = False

    Private Sub limpa_campos()
        txtNome.Text = ""
        cbxTipo.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtCompra.Text = ""
        txtVenda.Text = ""
        txtNome.Focus()
    End Sub

    Private Sub frm_CadProdutos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        frm_Inicial.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnLimpar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpar.Click
        limpa_campos()
    End Sub

    Private Sub verificacao_campos()
        If txtNome.Text.Trim = "" Then
            MessageBox.Show("Campo Nome do Produto está vazio, digite o nome do Prodtudo!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            passou = True
        ElseIf txtCompra.Text.Trim = "" Then
            MessageBox.Show("Campo Compra está vazio, digite o valor de Compra do Produto!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCompra.Focus()
            passou = True
        ElseIf txtVenda.Text.Trim = "" Then
            MessageBox.Show("Campo Venda está vazio, digite o valor de Venda do Produto!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtVenda.Focus()
            passou = True
        ElseIf cbxTipo.Text = "" Then
            MessageBox.Show("Campo Tipo vazio, escolha o Tipo!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtVenda.Focus()
            passou = True
        ElseIf cbxTipo.Text <> "Roupas" And cbxTipo.Text <> "Acessórios" And cbxTipo.Text <> "Lingerie" And cbxTipo.Text <> "Semi-Jóias" And cbxTipo.Text <> "Perfumes" And cbxTipo.Text <> "Cosméticos" And cbxTipo.Text <> "Outros" Then
            MessageBox.Show("Campo Tipo inválido, escolha uma das opções no campo Tipo!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbxTipo.Focus()
            passou = True
        End If

    End Sub

    Private Sub gravando_banco_dados()
        Dim compra As Decimal
        Dim venda As Decimal

        compra = Val(txtCompra.Text.Replace(",", ".")).ToString("f2")
        venda = Val(txtVenda.Text.Replace(",", ".")).ToString("f2")

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"


        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "INSERT INTO Produtos VALUES(" & txtCodProd.Text & ",'" & cbxTipo.Text & "','" & txtNome.Text.Trim.ToUpper & "','" & txtMarca.Text.Trim.ToUpper & "','" & txtModelo.Text.Trim.ToUpper & "','" & compra & "','" & venda & "')"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As String

        leitor = comando.ExecuteNonQuery

        con.Close()

    End Sub

    Private Sub criando_estoque()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"


        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "INSERT INTO Estoque (cod_prod,saida_est,total_est) VALUES(" & txtCodProd.Text & ",0,0)"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As String

        'leitor = comando.ExecuteNonQuery

        'con.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        verificacao_campos()

        If passou = False Then
            gravando_banco_dados()
            criando_estoque()
            frm_Inicial.Enabled = True
            Me.Close()
        End If

        passou = False
    End Sub

    Private Sub txtCompra_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompra.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            If e.KeyChar <> "," Then
                e.Handled = True
                Exit Sub
            Else
                e.Handled = False
                Exit Sub
            End If
        End If


        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVenda_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtVenda.KeyPress
        If Char.IsPunctuation(e.KeyChar) Then
            If e.KeyChar <> "," Then
                e.Handled = True
                Exit Sub
            Else
                e.Handled = False
                Exit Sub
            End If
        End If


        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_CadProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class