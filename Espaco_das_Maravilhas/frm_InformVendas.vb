
Public Class frm_InformVendas

    Private Sub carrega_campos()

        'Dim con As New MySqlConnection
        'con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='lojaroupas'"

        'con.Open()
        'Dim comando As New MySqlCommand
        'comando.CommandText = "SELECT C.nome_cli, A.dt_com, S.valor_prod FROM (Clientes C INNER JOIN Saida_Prod S ON C.cod_cli = S.cod_cli) INNER JOIN Compras A ON S.cod_ven_prod = A.cod_ven_prod ORDER BY A.dt_com"
        'comando.CommandType = CommandType.Text
        'comando.Connection = con

        'Dim leitor As MySqlDataReader
        'leitor = comando.ExecuteReader

        'Do While leitor.Read
        '    dgvInformCompras.Rows.Add(leitor("nome_cli"), String.Format(leitor("dt_com")), String.Format("{0:c}", leitor("valor_prod")))
        'Loop

        'con.Close()

    End Sub

    Private Sub frm_InformVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_campos()
    End Sub

    Private Sub frm_InformVendas_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Inicial.Enabled = True
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class