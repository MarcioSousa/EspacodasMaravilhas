
Public Class frm_Produtos
    Dim exclusao As Boolean = False

    Private Sub carrega_form()
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

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
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub alteracao_cadastro()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "UPDATE Produtos SET nome_prod = '" & txtNome.Text.Trim.ToUpper & "', tipo_prod = '" & cbxTipo.Text & "', marca_prod = '" & txtMarca.Text.Trim.ToUpper & "', modelo_prod = '" & txtModelo.Text.Trim.ToUpper & "', preco_com_prod = '" & txtCompra.Text & "', preco_ven_prod = '" & txtPreco.Text & "' WHERE cod_prod = " & txtCodProd.Text
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As String
        'leitor = comando.ExecuteNonQuery

        'con.Close()

    End Sub

    Private Sub carrega_campos()
        If exclusao = False Then
            Dim linha As Integer = dgvProdutos.CurrentRow.Index
            Dim valor As Integer = dgvProdutos.Rows(linha).Cells(0).Value

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

            'cbxTipo.Text = leitor("tipo_prod")
            'txtCodProd.Text = leitor("cod_prod")
            'txtNome.Text = leitor("nome_prod")
            'txtMarca.Text = leitor("marca_prod")
            'txtModelo.Text = leitor("modelo_prod")
            'txtCompra.Text = String.Format("{0:f2}", leitor("preco_com_prod"))
            'txtPreco.Text = String.Format("{0:f2}", leitor("preco_ven_prod"))

            'con.Close()
        End If

        exclusao = False

    End Sub

    Private Sub abre_campos()
        txtNome.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtCompra.Enabled = True
        txtPreco.Enabled = True
        cbxTipo.Enabled = True

        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        btnEditar.Enabled = False

        btnConfirmar.Visible = True
        btnCancelar.Visible = True

        lblCompra.Visible = True
        txtCompra.Visible = True

        btnFechar.Visible = False
        dgvProdutos.Enabled = False
        txtPesquisa.Enabled = False

        txtNome.Focus()
    End Sub

    Private Sub fecha_campos()
        txtNome.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtCompra.Enabled = False
        txtPreco.Enabled = False
        cbxTipo.Enabled = False

        btnNovo.Enabled = True
        btnExcluir.Enabled = True
        btnEditar.Enabled = True
        btnConfirmar.Visible = False
        btnCancelar.Visible = False
        btnFechar.Visible = True
        dgvProdutos.Enabled = True
        txtPesquisa.Enabled = True
        lblCompra.Visible = False
        txtCompra.Visible = False
        txtPesquisa.Text = ""
    End Sub

    Private Sub limpa_campos()
        txtCodProd.Text = ""
        cbxTipo.Text = ""
        txtNome.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtCompra.Text = ""
        txtPreco.Text = ""
    End Sub

    Private Sub frm_Produtos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub frm_Produtos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_form()
    End Sub

    Private Sub dgvProdutos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvProdutos.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        frm_CadProdutos.Show()
        Me.Close()
        frm_Inicial.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        abre_campos()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        fecha_campos()
        carrega_form()
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        frm_Inicial.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        alteracao_cadastro()

        fecha_campos()
        carrega_form()
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "DELETE FROM Produtos WHERE cod_prod = " & txtCodProd.Text
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'If MessageBox.Show("Deseja excluir " & txtNome.Text & " de seu sistema?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        '    Dim leitor As String
        '    leitor = comando.ExecuteNonQuery
        '    exclusao = True
        '    txtPesquisa.Text = ""
        '    MessageBox.Show(txtNome.Text & " foi deletado de seu sistema com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        'con.Close()

        'If exclusao = True Then
        '    carrega_form()
        '    exclusao = False
        'End If
    End Sub

    Private Sub txtPesquisa_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPesquisa.TextChanged
        dgvProdutos.Rows.Clear()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE nome_prod like '%" & txtPesquisa.Text.Trim.ToUpper & "%'"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        'Loop

        'con.Close()
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

    Private Sub txtPreco_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreco.KeyPress
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

    Private Sub RoupasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RoupasToolStripMenuItem.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Roupas' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub LingerieToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LingerieToolStripMenuItem.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Lingerie' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub SemijoiasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SemijoiasToolStripMenuItem.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Semi-Jóias' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub PerfumesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PerfumesToolStripMenuItem.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Perfumes' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub CosméticosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CosméticosToolStripMenuItem.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Cosméticos' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub OutrosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OutrosToolStripMenuItem1.Click
        Dim vazio As Boolean = True

        dgvProdutos.Rows.Clear()
        Dim cont As Integer = 0

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = 'Outros' ORDER BY cod_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvProdutos.Rows.Add(leitor("cod_prod"), leitor("nome_prod"), leitor("marca_prod"), leitor("modelo_prod"), String.Format("{0:c}", leitor("preco_ven_prod")))
        '    cont += 1
        '    vazio = False
        'Loop

        'If vazio = True Then
        '    btnExcluir.Visible = False
        '    btnEditar.Visible = False
        '    limpa_campos()
        'Else
        '    btnExcluir.Visible = True
        '    btnEditar.Visible = True
        'End If

        'lblProCad.Text = cont

        'con.Close()
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TodosToolStripMenuItem.Click
        carrega_form()
    End Sub

End Class