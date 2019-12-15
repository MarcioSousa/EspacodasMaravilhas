
Public Class frm_ListaVendas

    Private Sub frm_ListaVendas_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub btnPontos1_Click(sender As System.Object, e As System.EventArgs) Handles btnPontos1.Click
        Me.Enabled = False
        frm_CadVendas.VendaPrestac = "ListaVendas"
        frm_ListaClientes.Show()
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
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

    Private Sub txtCodCli_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCli.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub


End Class