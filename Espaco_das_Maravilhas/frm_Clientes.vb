
Public Class frm_Clientes
    Dim exclusao As Boolean = False
    Public vNovo As Boolean = False

    Public Sub carrega_form()
        Dim vazio As Boolean = True

        dgvCliente.Rows.Clear()
        Dim cont As Integer = 0

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "SELECT cod_cli, nome_cli, telres_cli, telcel_cli FROM Clientes ORDER BY cod_cli"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As SqlServerCe.SqlCeDataReader
        leitor = comando.ExecuteReader
        Do While leitor.Read
            dgvCliente.Rows.Add(leitor("cod_cli"), leitor("nome_cli"), leitor("telres_cli"), leitor("telcel_cli"))
            cont += 1
            vazio = False
        Loop

        If vazio = True Then
            btnExcluir.Visible = False
            btnEditar.Visible = False
            btnConfirmar.Visible = False
            btnCancelar.Visible = False
        Else
            btnExcluir.Visible = True
            btnEditar.Visible = True
        End If

        con.Close()
        tssCliCad.Text = cont
    End Sub

    Private Sub alteracao_cadastro()

        'Dim con As New SqlServerCe.SqlCeConnection
        'con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        'con.Open()

        'Dim comando As New SqlServerCe.SqlCeCommand
        'comando.CommandText = "UPDATE Clientes SET nome_cli = '" & txtNome.Text.Trim.ToUpper & "', data_nasc_cli = '" & dtpDataNasc.Text & "',cpf_cli = '" & txtCPF.Text & "', rg_cli = '" & txtRG.Text & "', rua_cli = '" & txtRua.Text.Trim.ToUpper & "', numero_cli = '" & txtNumer.Text.Trim.ToUpper & "', bairro_cli = '" & txtBairro.Text.Trim.ToUpper & "', cidade_cli = '" & txtCidade.Text.Trim.ToUpper & "', estado_cli = '" & cbxUf.Text.Trim.ToUpper & "',cep_cli = '" & mtbCep.Text & "',complemento_cli = '" & txtCompl.Text.Trim.ToUpper & "', tel_res_cli = '" & mtbTelRes.Text & "',tel_cel_cli = '" & mtbTelCel.Text & "' WHERE cod_cli = " & txtCodCli.Text


        'con.Close()
        '''''''''''''''''''''''''''''''''''''''''

        '    Dim con As New MySqlConnection
        '    con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        '    con.Open()
        '    Dim comando As New MySqlCommand
        '    comando.CommandText = "UPDATE Clientes SET nome_cli = '" & txtNome.Text.Trim.ToUpper & "', data_nasc_cli = '" & dtpDataNasc.Text & "',cpf_cli = '" & txtCPF.Text & "', rg_cli = '" & txtRG.Text & "', rua_cli = '" & txtRua.Text.Trim.ToUpper & "', numero_cli = '" & txtNumer.Text.Trim.ToUpper & "', bairro_cli = '" & txtBairro.Text.Trim.ToUpper & "', cidade_cli = '" & txtCidade.Text.Trim.ToUpper & "', estado_cli = '" & cbxUf.Text.Trim.ToUpper & "',cep_cli = '" & mtbCep.Text & "',complemento_cli = '" & txtCompl.Text.Trim.ToUpper & "', tel_res_cli = '" & mtbTelRes.Text & "',tel_cel_cli = '" & mtbTelCel.Text & "' WHERE cod_cli = " & txtCodCli.Text
        '    comando.CommandType = CommandType.Text
        '    comando.Connection = con

        '    Dim leitor As String
        '    leitor = comando.ExecuteNonQuery

        '    con.Close()

    End Sub

    Private Sub carrega_campos()
        If exclusao = False Then
            Dim linha As Integer = dgvCliente.CurrentRow.Index
            Dim valor As Integer = dgvCliente.Rows(linha).Cells(0).Value

            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT * FROM Clientes WHERE cod_cli = " & valor
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader
            'leitor.Read()

            'txtCodCli.Text = leitor("cod_cli")
            'txtNome.Text = leitor("nome_cli")
            'dtpDataNasc.Text = leitor("data_nasc_cli")
            'txtRG.Text = leitor("rg_cli")
            'txtCPF.Text = leitor("cpf_cli")
            'mtbTelRes.Text = leitor("tel_res_cli")
            'mtbTelCel.Text = leitor("tel_cel_cli")
            'txtRua.Text = leitor("rua_cli")
            'txtNumer.Text = leitor("numero_cli")
            'txtBairro.Text = leitor("bairro_cli")
            'txtCidade.Text = leitor("cidade_cli")
            'cbxUf.Text = leitor("estado_cli")
            'txtCompl.Text = leitor("complemento_cli")
            'mtbCep.Text = leitor("cep_cli")

            'con.Close()
        End If

        exclusao = False

    End Sub

    Private Sub abre_campos()
        btnNovo.Enabled = False
        btnExcluir.Enabled = False
        btnEditar.Enabled = False
        btnConfirmar.Visible = True
        btnCancelar.Visible = True
        btnFechar.Visible = False
        dgvCliente.Enabled = False
        txtPesquisa.Enabled = False
    End Sub

    Private Sub fecha_campos()
        btnNovo.Enabled = True
        btnExcluir.Enabled = True
        btnEditar.Enabled = True
        btnConfirmar.Visible = False
        btnCancelar.Visible = False
        btnFechar.Visible = True
        dgvCliente.Enabled = True
        txtPesquisa.Enabled = True
        txtPesquisa.Text = ""
    End Sub

    Private Sub frm_Clientes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub frm_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_form()
    End Sub

    Private Sub dgvCliente_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCliente.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        vNovo = True
        frm_CadClientes.Show()
        txtPesquisa.Text = ""
        Me.Enabled = False
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        vNovo = False
        frm_CadClientes.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        fecha_campos()
        carrega_form()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        frm_Inicial.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        alteracao_cadastro()

        fecha_campos()
        carrega_form()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim linha As Integer = dgvCliente.CurrentRow.Index
        Dim valor As Integer = dgvCliente.Rows(linha).Cells(0).Value
        Dim vNome As String = dgvCliente.Rows(linha).Cells(1).Value

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "DELETE FROM Clientes WHERE cod_cli = " & valor
        comando.CommandType = CommandType.Text
        comando.Connection = con

        If MessageBox.Show("Deseja excluir " & vNome & " de seu sistema?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Dim leitor As String
            leitor = comando.ExecuteNonQuery
            exclusao = True
            txtPesquisa.Text = ""
            MessageBox.Show(vNome & " foi deletado de seu sistema com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        con.Close()

        If exclusao = True Then
            carrega_form()
            exclusao = False
        End If

    End Sub

    Private Sub txtPesquisa_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPesquisa.TextChanged
        dgvCliente.Rows.Clear()

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "SELECT cod_cli, nome_cli, telres_cli, telcel_cli FROM Clientes WHERE nome_cli like '%" & txtPesquisa.Text.Trim.ToUpper & "%'"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As SqlServerCe.SqlCeDataReader
        leitor = comando.ExecuteReader

        Do While leitor.Read
            dgvCliente.Rows.Add(leitor("cod_cli"), leitor("nome_cli"), leitor("telres_cli"), leitor("telcel_cli"))
        Loop
        con.Close()

    End Sub

End Class