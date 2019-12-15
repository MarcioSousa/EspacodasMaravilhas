
Public Class frm_CadVendas
    Dim passou As Boolean = False
    Dim vTotal As Decimal
    Dim Cod_produto As Integer
    Public cEscolha As String
    Public VendaPrestac As String

    Private Sub verificando_campos()

        If txtNomeCli.Text = "" Then
            MessageBox.Show("Código de Cliente inválido, digite o Código do cliente!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            txtCodCli.Text = ""
            txtCodCli.Focus()
        ElseIf cmbTipo.Text = "" Then
            MessageBox.Show("Escolha o Tipo do Produto na qual o cliente está adquirindo!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            cmbTipo.Text = ""
            cmbTipo.Focus()
        ElseIf cmbProduto.Text = "" Then
            MessageBox.Show("Digite o Nome do produto no campo acima!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            cmbProduto.Text = ""
            cmbProduto.Focus()
        ElseIf cmbMarca.Text = "" Then
            MessageBox.Show("Digite a marca desse produto!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            cmbMarca.Text = ""
            cmbMarca.Focus()
        ElseIf cmbModelo.Text = "" Then
            MessageBox.Show("Digite o Modelo do produto!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            cmbModelo.Text = ""
            cmbModelo.Focus()
        ElseIf txtQtde.Text = "" Then
            MessageBox.Show("Digite a quantidade de produto vendido!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            txtQtde.Focus()
        ElseIf lblPreco.Text = "" Then
            MessageBox.Show("Produto não cadastrado, campos inválidos, escolha nos campos o produto que o cliente deseja comprar", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            passou = True
            limpa_campos()
        End If

    End Sub

    Private Sub limpa_campos()
        cmbTipo.Text = ""
        cmbProduto.Items.Clear()
        cmbProduto.Text = ""
        cmbMarca.Items.Clear()
        cmbMarca.Text = ""
        cmbModelo.Items.Clear()
        cmbModelo.Text = ""

        btnPontos1.Enabled = False

        txtQtde.Text = ""
        lblPreco.Text = "0,00"
        txtCodCli.Enabled = False

    End Sub

    Private Sub carrega_tipo()
        cmbTipo.Enabled = True

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT tipo_prod FROM Produtos"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader
        'Do While leitor.Read
        '    cmbTipo.Items.Add(leitor("tipo_prod"))
        'Loop

        'con.Close()

    End Sub

    Private Sub verificando_banco_dados()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = '" & cmbTipo.Text & "' AND nome_prod = '" & cmbProduto.Text & "' AND marca_prod = '" & cmbMarca.Text & "' AND modelo_prod = '" & cmbModelo.Text & "' AND preco_ven_prod = " & lblPreco.Text.Replace(",", ".")
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'If Not leitor.Read Then
        '    MessageBox.Show("Erro de campos, seleção inexistente, digite novamente nos campos acima!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    passou = True
        '    limpa_campos()
        '    cmbTipo.Focus()
        'Else
        '    Cod_produto = leitor("cod_prod")
        'End If

        'con.Close()

    End Sub

    Private Sub jogando_no_grid()
        vTotal = lblTotal.Text + (CDec(lblPreco.Text) * txtQtde.Text)
        lblTotal.Text = String.Format("{0:c}", vTotal)

        dgvVendas.Rows.Add(Cod_produto, cmbProduto.Text, txtQtde.Text, String.Format("{0:c}", CDec(lblPreco.Text.Replace(".", ",")) * txtQtde.Text))
        cmbTipo.Text = ""
        cmbProduto.Items.Clear()
        cmbProduto.Text = ""
        cmbMarca.Items.Clear()
        cmbMarca.Text = ""
        cmbModelo.Items.Clear()
        cmbModelo.Text = ""

        btnPontos1.Enabled = False

        txtQtde.Text = ""
        lblPreco.Text = "0,00"
        txtCodCli.Enabled = False
    End Sub

    Private Sub gravando_banco_dados()
        Dim vdata As Date = Now
        Dim vCompras As Integer = dgvVendas.Rows.Count
        Dim vVendaProd As Integer = 1
        Dim vPassou As Boolean = False

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"
        'Dim comando As New MySqlCommand

        ''============================================
        ''=================== ESTOQUE ================
        ''============================================

        'con.Open()

        'comando.CommandText = "SELECT cod_ven_prod FROM Saida_Prod ORDER BY cod_ven_prod"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim vCriaCodigo As MySqlDataReader
        'vCriaCodigo = comando.ExecuteReader

        'Do While vCriaCodigo.Read
        '    If vCriaCodigo("cod_ven_prod") = vVendaProd Then
        '        vVendaProd += 1
        '    End If
        'Loop
        'con.Close()


        'For t = 0 To vCompras - 1
        '    con.Open()

        '    comando.CommandText = "INSERT INTO Saida_Prod(cod_cli, cod_prod, cod_ven_prod, valor_prod, Qtde_prod) VALUES (" & txtCodCli.Text & " , " & dgvVendas.Rows(t).Cells(0).Value & "," & vVendaProd & "," & CDec(dgvVendas.Rows(t).Cells(3).Value).ToString.Replace(",", ".") & "," & dgvVendas.Rows(t).Cells(2).Value & ")"
        '    comando.CommandType = CommandType.Text
        '    comando.Connection = con

        '    Dim leitor As String
        '    leitor = comando.ExecuteNonQuery

        '    con.Close()

        '    con.Open()

        '    comando.CommandText = "UPDATE Estoque SET saida_est = saida_est + " & dgvVendas.Rows(t).Cells(2).Value & " WHERE cod_prod = " & dgvVendas.Rows(t).Cells(0).Value
        '    comando.CommandType = CommandType.Text
        '    comando.Connection = con

        '    Dim retirada As String
        '    retirada = comando.ExecuteNonQuery

        '    con.Close()
        'Next


        ''============================================
        ''=================== COMPRA =================
        ''============================================

        'con.Open()
        'comando.CommandText = "INSERT INTO Compras (cod_cli, cod_ven_prod, dt_com) VALUES (" & txtCodCli.Text & "," & vVendaProd & ",'" & lblDataAtual.Text & "')"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim inserir As String
        'inserir = comando.ExecuteNonQuery

        'con.Close()

        'If rbtVista.Checked = False Then
        '    Dim int As Integer = dgvVendas.Rows.Count
        '    If rbt2X.Checked = True Then
        '        For t = 0 To 1
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 2).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 2).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If

        '        Next
        '    ElseIf rbt3X.Checked = True Then
        '        For t = 0 To 2
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 3).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 3).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt4X.Checked = True Then
        '        For t = 0 To 3
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 4).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 4).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt5X.Checked = True Then
        '        For t = 0 To 4
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 5).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 5).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt6X.Checked = True Then
        '        For t = 0 To 5
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 6).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 6).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt7X.Checked = True Then
        '        For t = 0 To 6
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 7).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 7).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt8X.Checked = True Then
        '        For t = 0 To 7
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 8).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '            Else
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 8).ToString.Replace(",", ".") & ",'sim')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        '                Dim leitor As String

        '                vdata = vdata.AddMonths(1)
        '                leitor = comando.ExecuteNonQuery
        '                con.Close()
        '                rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt9X.Checked = True Then
        '        For t = 0 To 8
        '            If rbtSEntrada.Checked = True Then
        '                vdata = vdata.AddMonths(1)
        '                con.Open()
        '                comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 9).ToString.Replace(",", ".") & ",'não')"
        '                comando.CommandType = CommandType.Text
        '                comando.Connection = con
        'Dim leitor As String

        'leitor = comando.ExecuteNonQuery
        'con.Close()
        '            Else
        'con.Open()
        'comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 9).ToString.Replace(",", ".") & ",'sim')"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con
        'Dim leitor As String

        'vdata = vdata.AddMonths(1)
        'leitor = comando.ExecuteNonQuery
        'con.Close()
        'rbtSEntrada.Checked = True
        '            End If
        '        Next
        '    ElseIf rbt10X.Checked = True Then
        'For t = 0 To 9
        '    If rbtSEntrada.Checked = True Then
        '        vdata = vdata.AddMonths(1)
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 10).ToString.Replace(",", ".") & ",'não')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '    Else
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 10).ToString.Replace(",", ".") & ",'sim')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        vdata = vdata.AddMonths(1)
        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '        rbtSEntrada.Checked = True
        '    End If
        'Next
        '    ElseIf rbt11X.Checked = True Then
        'For t = 0 To 10
        '    If rbtSEntrada.Checked = True Then
        '        vdata = vdata.AddMonths(1)
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 11).ToString.Replace(",", ".") & ",'não')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '    Else
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 11).ToString.Replace(",", ".") & ",'sim')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        vdata = vdata.AddMonths(1)
        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '        rbtSEntrada.Checked = True
        '    End If
        'Next
        '    ElseIf rbt12X.Checked = True Then
        'For t = 0 To 11
        '    If rbtSEntrada.Checked = True Then
        '        vdata = vdata.AddMonths(1)
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 12).ToString.Replace(",", ".") & ",'não')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '    Else
        '        con.Open()
        '        comando.CommandText = "INSERT INTO Parcelamento (cod_cli, dt_venc_parc, valor_parc, pagam_parc) VALUES (" & txtCodCli.Text & ",'" & String.Format(vdata.Date) & "'," & CDec(lblTotal.Text / 12).ToString.Replace(",", ".") & ",'sim')"
        '        comando.CommandType = CommandType.Text
        '        comando.Connection = con
        '        Dim leitor As String

        '        vdata = vdata.AddMonths(1)
        '        leitor = comando.ExecuteNonQuery
        '        con.Close()
        '        rbtSEntrada.Checked = True
        '    End If
        'Next
        '    End If
        'End If
        'Me.Close()
        frm_Inicial.Enabled = True

    End Sub

    Private Sub frm_CadVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDataAtual.Text = Date.Today.Date
        carrega_tipo()
        lblEscolha.Text = "À Vista"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnPontos1.Click
        Me.Enabled = False
        VendaPrestac = "Vendas"
        frm_ListaClientes.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnPontos2.Click
        Me.Enabled = False
        frm_ListaProdutos.Show()
    End Sub

    Private Sub txtCodCli_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodCli.TextChanged
        If Not txtCodCli.Text = "" Then
            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT cod_cli, nome_cli FROM Clientes WHERE cod_cli = " & txtCodCli.Text
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'leitor.Read()

            'Try
            '    txtNomeCli.Text = leitor("nome_cli")
            'Catch ex As Exception
            '    txtNomeCli.Text = ""
            'End Try

            'con.Close()
        Else
            txtNomeCli.Text = ""
        End If

    End Sub

    Private Sub btnIncluir_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluir.Click
        gbxEntrada.Visible = False
        lblQtdeParcela.Text = ""
        rbtVista.Checked = True

        verificando_campos()

        If passou = False Then
            verificando_banco_dados()
        End If

        If passou = False Then
            jogando_no_grid()
            btnExcluir.Enabled = True
            btnConfirmar.Enabled = True
        End If

        passou = False

    End Sub

    Private Sub txtQtde_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCli.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If frm_ListaProdutos.vpassou = False Then
            cmbProduto.Items.Clear()
            cmbMarca.Items.Clear()
            cmbModelo.Items.Clear()
            txtQtde.Text = ""
            lblPreco.Text = ""
            cmbProduto.Text = ""
            cmbMarca.Text = ""
            cmbModelo.Text = ""

            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT tipo_prod, nome_prod FROM Produtos WHERE tipo_prod = '" & cmbTipo.Text & "'"
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'Do While leitor.Read
            '    cmbProduto.Items.Add(leitor("nome_prod"))
            'Loop

            'con.Close()
        End If
        frm_ListaProdutos.vpassou = False


    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProduto.SelectedIndexChanged
        If frm_ListaProdutos.vpassou = False Then
            cmbMarca.Items.Clear()
            cmbModelo.Items.Clear()
            lblPreco.Text = ""
            cmbMarca.Text = ""
            cmbModelo.Text = ""
            txtQtde.Text = ""

            '    Dim con As New MySqlConnection
            '    con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            '    con.Open()
            '    Dim comando As New MySqlCommand
            '    comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = '" & cmbTipo.Text & "' and nome_prod = '" & cmbProduto.Text & "'"
            '    comando.CommandType = CommandType.Text
            '    comando.Connection = con

            '    Dim leitor As MySqlDataReader
            '    leitor = comando.ExecuteReader
            '    Do While leitor.Read
            '        cmbMarca.Items.Add(leitor("marca_prod"))
            '    Loop

            '    con.Close()
        End If
        frm_ListaProdutos.vpassou = False
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMarca.SelectedIndexChanged
        If frm_ListaProdutos.vpassou = False Then
            cmbModelo.Items.Clear()
            lblPreco.Text = ""
            cmbModelo.Text = ""
            txtQtde.Text = ""

            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = '" & cmbTipo.Text & "' and nome_prod = '" & cmbProduto.Text & "' and marca_prod = '" & cmbMarca.Text & "'"
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'Do While leitor.Read
            '    cmbModelo.Items.Add(leitor("modelo_prod"))
            'Loop

            'con.Close()
        End If
        frm_ListaProdutos.vpassou = False
    End Sub

    Private Sub cmbModelo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbModelo.SelectedIndexChanged
        If frm_ListaProdutos.vpassou = False Then
            lblPreco.Text = ""
            txtQtde.Text = ""

            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT * FROM Produtos WHERE tipo_prod = '" & cmbTipo.Text & "' and nome_prod = '" & cmbProduto.Text & "' and marca_prod = '" & cmbMarca.Text & "' and modelo_prod = '" & cmbModelo.Text & "'"
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'leitor.Read()

            'lblPreco.Text = String.Format("{0:c}", leitor("preco_ven_prod"))

            'con.Close()
            frm_ListaProdutos.vpassou = False
        End If

    End Sub

    Private Sub frm_CadVendas_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        Dim cadastros As Integer = dgvVendas.Rows.Count
        Dim linha As Integer = dgvVendas.CurrentRow.Index

        If cadastros = 1 Then
            btnExcluir.Enabled = False
            btnConfirmar.Enabled = False
            btnPontos1.Enabled = True
            txtCodCli.Enabled = True
        End If

        vTotal = vTotal - dgvVendas.Rows(linha).Cells(2).Value
        lblTotal.Text = String.Format("{0:c}", vTotal)

        dgvVendas.Rows.RemoveAt(linha)

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub rbt2X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt2X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "2 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 2)
        lblEscolha.Text = "Parcelado"

    End Sub

    Private Sub rbtVista_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtVista.CheckedChanged
        rbtCEntrada.Checked = False
        rbtSEntrada.Checked = False
        gbxEntrada.Visible = False
        lblQtdeParcela.Text = ""
        lblEscolha.Text = "À Vista"
    End Sub

    Private Sub rbtCEntrada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCEntrada.CheckedChanged
        If rbt2X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 1 Parcela de " & String.Format("{0:c}", lblTotal.Text / 2)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt3X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 2 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 3)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt4X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 3 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 4)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt5X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 4 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 5)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt6X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 5 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 6)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt7X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 6 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 7)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt8X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 7 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 8)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt9X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 8 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 9)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt10X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 9 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 10)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt11X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 10 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 11)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt12X.Checked = True Then
            lblQtdeParcela.Text = "Ent. + 11 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 12)
            lblEscolha.Text = "Parcelado"
        End If

    End Sub

    Private Sub rbt3X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt3X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "3 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 3)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt4X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt4X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "4 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 4)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt5X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt5X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "5 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 5)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt6X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt6X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "6 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 6)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt7X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt7X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "7 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 7)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt8X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt8X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "8 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 8)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt9X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt9X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "9 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 9)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt10X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt10X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "10 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 10)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt11X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt11X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "11 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 11)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbt12X_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt12X.CheckedChanged
        gbxEntrada.Visible = True
        rbtSEntrada.Checked = True

        lblQtdeParcela.Text = "12 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 12)
        lblEscolha.Text = "Parcelado"
    End Sub

    Private Sub rbtSEntrada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSEntrada.CheckedChanged
        If rbt2X.Checked = True Then
            lblQtdeParcela.Text = "2 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 2)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt3X.Checked = True Then
            lblQtdeParcela.Text = "3 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 3)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt4X.Checked = True Then
            lblQtdeParcela.Text = "4 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 4)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt5X.Checked = True Then
            lblQtdeParcela.Text = "5 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 5)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt6X.Checked = True Then
            lblQtdeParcela.Text = "6 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 6)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt7X.Checked = True Then
            lblQtdeParcela.Text = "7 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 7)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt8X.Checked = True Then
            lblQtdeParcela.Text = "8 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 8)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt9X.Checked = True Then
            lblQtdeParcela.Text = "9 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 9)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt10X.Checked = True Then
            lblQtdeParcela.Text = "10 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 10)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt11X.Checked = True Then
            lblQtdeParcela.Text = "11 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 11)
            lblEscolha.Text = "Parcelado"
        ElseIf rbt12X.Checked = True Then
            lblQtdeParcela.Text = "12 Parcelas de " & String.Format("{0:c}", lblTotal.Text / 12)
            lblEscolha.Text = "Parcelado"
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        gravando_banco_Dados()
    End Sub

End Class