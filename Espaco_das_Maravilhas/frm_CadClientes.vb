
Public Class frm_CadClientes
    Dim passou As Boolean = False

    Private Sub limpa_campos()
        txtNome.Text = ""
        dtpDataNasc.Text = Now
        txtRG.Text = ""
        txtCPF.Text = ""
        txtRua.Text = ""
        txtNumer.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cbxUf.Text = "SP"
        txtCompl.Text = ""
        mtbCep.Text = ""
        mtbTelRes.Text = ""
        mtbTelCel.Text = ""
        txtNome.Focus()
    End Sub

    Private Sub frm_CadClientes_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Clientes.Enabled = True
        frm_Clientes.dgvCliente.Rows.Clear()
        frm_Clientes.carrega_form()
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
            MessageBox.Show("Campo Nome do Cliente está vazio, digite o nome do Cliente!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNome.Focus()
            passou = True
        End If
    End Sub

    Private Sub gravando_banco_dados()

        Dim con As New SqlServerCe.SqlCeConnection
        con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

        con.Open()
        Dim comando As New SqlServerCe.SqlCeCommand
        comando.CommandText = "INSERT INTO Clientes VALUES('" & txtNome.Text.Trim.ToUpper & "','" & dtpDataNasc.Value & "','" & txtCPF.Text & "','" & txtRG.Text & "','" & txtRua.Text.Trim.ToUpper & "','" & txtNumer.Text.Trim.ToUpper & "','" & txtBairro.Text.Trim.ToUpper & "','" & txtCidade.Text.Trim.ToUpper & "','" & cbxUf.Text.Trim.ToUpper & "','" & mtbCep.Text & "','" & txtCompl.Text.Trim.ToUpper & "','" & mtbTelRes.Text & "','" & mtbTelCel.Text & "'," & txtCodCli.Text & ")"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        Dim leitor As String
        leitor = comando.ExecuteNonQuery
        con.Close()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        verificacao_campos()

        If passou = False Then
            gravando_banco_dados()
            frm_Inicial.Enabled = True
            Me.Close()
        End If

        passou = False

    End Sub

    Private Sub frm_CadClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If frm_Clientes.vNovo = True Then
            'Novo Cliente
            Dim passou As Boolean = False
            Dim vcont As Integer = 1
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
                passou = True
                If leitor("cod_cli") <> vcont Then
                    txtCodCli.Text = vcont
                    Exit Do
                End If
                vcont += 1
            Loop

            If passou = False Then
                txtCodCli.Text = 1
            Else
                txtCodCli.Text = vcont
            End If

            con.Close()

        Else
            'Editar Cliente

            Dim linha As Integer = frm_Clientes.dgvCliente.CurrentRow.Index
            Dim valor As Integer = frm_Clientes.dgvCliente.Rows(linha).Cells(0).Value

            Dim con As New SqlServerCe.SqlCeConnection
            con.ConnectionString = "Data Source=|DataDirectory|\LojaRoupas.sdf"

            con.Open()
            Dim comando As New SqlServerCe.SqlCeCommand
            comando.CommandText = "SELECT nome_cli, datacad_cli, cpf_cli, rg_cli, rua_cli, num_cli, bairro_cli, cidade_cli, estado_cli, cep_cli, complemento_cli, telres_cli, telcel_cli FROM Clientes WHERE cod_cli = " & valor
            comando.CommandType = CommandType.Text
            comando.Connection = con
            Dim leitor As SqlServerCe.SqlCeDataReader
            leitor = comando.ExecuteReader

            leitor.Read()
            txtNome.Text = leitor("nome_cli")
            dtpDataNasc.Text = leitor("datacad_cli")
            txtRG.Text = leitor("rg_cli")
            txtCPF.Text = leitor("cpf_cli")
            txtRua.Text = leitor("rua_cli")
            txtNumer.Text = leitor("num_cli")
            txtBairro.Text = leitor("bairro_cli")
            txtCidade.Text = leitor("cidade_cli")
            cbxUf.Text = leitor("estado_cli")
            txtCompl.Text = leitor("complemento_cli")
            mtbCep.Text = leitor("cep_cli")
            mtbTelRes.Text = leitor("telres_cli")
            mtbTelCel.Text = leitor("telcel_cli")

            con.Close()

        End If

    End Sub

End Class