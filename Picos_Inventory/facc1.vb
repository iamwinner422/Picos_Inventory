Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class facc1
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Sub facc1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generationRapport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub generationRapport()
        Dim dataTable As New DataTable
        Dim con As String = "server=localhost;User Id=root;database=facturation"
        Dim connexion As New MySqlConnection(con)

        Try
            connexion.Open()
            Dim adaptateur As New MySqlDataAdapter("SELECT DISTINCT nom_clt, prenoms_clt, num_tel, adr_clt, designation_prod, qte_cmdee, prix_unitaire, (qte_cmdee * prix_unitaire) AS prix_total FROM commandes D, clients C, produits P, details_cmd S WHERE D.num_cmd = S.num_cmd AND C.num_clt = D.num_clt AND P.num_prod = S.num_prod AND D.num_cmd = " & fAjoutCommande.num_com, connexion)
            adaptateur.Fill(dataTable)
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Dim rpt As New ReportDataSource("DataSet1", dataTable)
            Me.ReportViewer1.LocalReport.DataSources.Add(rpt)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub facc1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            connexion.Open()
            'SUPPRESSION DES ELEMENTS DANS LA TABLE TEMPORAIRE
            Dim Delete As String = "DELETE FROM `details_temp`"
            Dim cmd As New MySqlCommand(Delete, connexion)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'RAFRAICHISSEMENT DE LA TABLE TEMPORAIRE
            Dim leSql As String = "SELECT * FROM `details_temp`"
            Dim laCom As New MySqlCommand(leSql, connexion)
            Dim vraie = laCom.ExecuteNonQuery
            If vraie Then
                Dim ladaptateur As New MySqlDataAdapter(laCom)
                Dim leDataSet As New DataSet
                ladaptateur.Fill(leDataSet, "details_temp")
                fAjoutCommande.DataGridView1.DataSource = leDataSet.Tables("details_temp")
                laCom.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub
End Class