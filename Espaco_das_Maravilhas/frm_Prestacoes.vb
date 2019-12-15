
Public Class frm_Prestacoes

    Private Sub btnPontos1_Click(sender As System.Object, e As System.EventArgs) Handles btnPontos1.Click
        Me.Enabled = False
        frm_CadVendas.VendaPrestac = "Prestacoes"
        frm_ListaClientes.Show()
    End Sub

    Private Sub txtCodCli_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodCli.TextChanged
        carrega_nome()
        carrega_grid()
    End Sub

    Private Sub carrega_grid()
        dgvPrestacoes.Rows.Clear()
        txtCalculo.Text = ""
        btnConclusao.Enabled = False

        If txtCodCli.Text <> "" Then
            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "SELECT C.nome_cli, P.dt_venc_parc, P.cod_par, P.valor_parc, P.pagam_parc FROM Parcelamento P INNER JOIN Clientes C ON P.cod_cli = C.cod_cli WHERE C.cod_cli = " & txtCodCli.Text
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As MySqlDataReader
            'leitor = comando.ExecuteReader

            'Do While leitor.Read()
            '    dgvPrestacoes.Rows.Add(leitor("cod_par"), String.Format(leitor("dt_venc_parc")), String.Format("{0:c}", leitor("valor_parc")), leitor("pagam_parc"))
            'Loop

            'con.Close()
        End If



    End Sub

    Private Sub carrega_nome()
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

    Private Sub frm_Prestacoes_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub dgvPrestacoes_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvPrestacoes.SelectionChanged
        Dim linha As Integer = dgvPrestacoes.CurrentRow.Index
        Dim conclusao As String = dgvPrestacoes.Rows(linha).Cells(3).Value
        Dim vdata As Date = dgvPrestacoes.Rows(linha).Cells(1).Value
        Dim vInicio As Date = vdata.AddDays(5)
        Dim vJuros As String

        vJuros = vInicio.Subtract(Today.Date).Days

        If vJuros < -330 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 120%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -300 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 110%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -270 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 100%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -240 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 90%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -210 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 80%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -180 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 70%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -150 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 60%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -120 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 50%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -90 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 40%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -60 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 30%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros < -30 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 20%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        ElseIf vJuros <= -1 Then
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = String.Format("{0:c}", ((dgvPrestacoes.Rows(linha).Cells(2).Value * 10%) / 100) + dgvPrestacoes.Rows(linha).Cells(2).Value)
                btnConclusao.Enabled = True
            End If
        Else
            If conclusao = "sim" Then
                txtCalculo.Text = "Pagamento Efetuado"
                btnConclusao.Enabled = False
            Else
                txtCalculo.Text = dgvPrestacoes.Rows(linha).Cells(2).Value
                btnConclusao.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnConclusao_Click(sender As System.Object, e As System.EventArgs) Handles btnConclusao.Click
        Dim linha As Integer = dgvPrestacoes.CurrentRow.Index
        Dim vCodigo As Integer = dgvPrestacoes.Rows(linha).Cells(0).Value


        If MessageBox.Show("Deseja concluir a compra de: " & txtNomeCli.Text & " com o vencimento de " & dgvPrestacoes.Rows(linha).Cells(1).Value & "??", "Concluindo Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            'Dim con As New MySqlConnection
            'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

            'con.Open()
            'Dim comando As New MySqlCommand
            'comando.CommandText = "UPDATE Parcelamento SET pagam_parc = 'sim' WHERE cod_par = " & vCodigo
            'comando.CommandType = CommandType.Text
            'comando.Connection = con

            'Dim leitor As String
            'leitor = comando.ExecuteNonQuery

            'con.Close()
            MessageBox.Show("Gravamento efetuado com sucesso!!", "Dr. Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information)
            carrega_grid()
        End If

    End Sub

    Private Sub txtCodCli_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCli.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class