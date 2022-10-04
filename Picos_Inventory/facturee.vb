Imports MySql.Data.MySqlClient
Public Class facturee
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Sub facturee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'facture.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.facture.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub facturee_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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