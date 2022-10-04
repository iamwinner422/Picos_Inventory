Imports MySql.Data.MySqlClient
Public Class fListeCmd
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Sub fListeCmd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Cmds.commandes'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        'Me.CommandesTableAdapter.Fill(Me.Cmds.commandes)
        lblClient.Visible = False
        lblDesi.Visible = False
        lblPrix.Visible = False
        lblQte.Visible = False
    End Sub

    Private Sub boxQte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxQte.TextChanged

    End Sub

    Private Sub boxDesignation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxDesignation.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lblDesi.Text = ""
        lblPrix.Text = ""
        lblQte.Text = ""
        lblClient.Visible = True
        lblDesi.Visible = True
        lblPrix.Visible = True
        lblQte.Visible = True
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneSelectionnee As DataGridViewRow
        ligneSelectionnee = DataGridView1.Rows(numLigne)
        boxNum.Text = ligneSelectionnee.Cells(1).Value.ToString
        Dim num_com = ligneSelectionnee.Cells(0).Value.ToString
        Dim num_clt = boxNum.Text
        Dim nom As String
        Dim prenoms As String

        Try
            connexion.Open()
            Dim rSelect1 = "SELECT `nom_clt`, `prenoms_clt` FROM `clients` WHERE `num_clt` = " & num_clt
            Dim cmd1 As New MySqlCommand(rSelect1, connexion)
            cmd1.ExecuteNonQuery()
            Dim adaptateur1 As New MySqlDataAdapter(cmd1)
            Dim dataset1 As New DataSet
            adaptateur1.Fill(dataset1, "clients")
            nom = dataset1.Tables("clients").Rows(0).Item("nom_clt").ToString
            prenoms = dataset1.Tables("clients").Rows(0).Item("prenoms_clt").ToString
            lblClient.Text = nom & " " & prenoms
            cmd1.Dispose()
            'on va recuperer le nom de ligne correspondant à la commande
            Dim rNbLigne As String = "SELECT COUNT(*) AS `nbLignes` FROM `details_cmd` WHERE num_cmd = " & num_com
            Dim nCmd As New MySqlCommand(rNbLigne, connexion)
            nCmd.ExecuteNonQuery()
            Dim nAdaptateur As New MySqlDataAdapter(nCmd)
            Dim nDataset As New DataSet
            nAdaptateur.Fill(nDataset, "details_cmd")
            Dim nbLignes = nDataset.Tables("details_cmd").Rows(0).Item("nbLignes").ToString
            For i = 0 To nbLignes - 1
                Dim rSelect2 = "SELECT `designation_prod`, `prix_unitaire`, `qte_cmdee` FROM produits P, details_cmd D WHERE P.num_prod = D.num_prod AND D.num_cmd = " & num_com
                Dim cmd2 As New MySqlCommand(rSelect2, connexion)
                cmd1.ExecuteNonQuery()
                Dim adaptateur2 As New MySqlDataAdapter(cmd2)
                Dim dataset2 As New DataSet
                Dim dataset3 As New DataSet
                Dim adaptateur3 As New MySqlDataAdapter(cmd2)
                adaptateur2.Fill(dataset2, "produits")
                Dim designation = dataset2.Tables("produits").Rows(i).Item("designation_prod").ToString
                Dim prix = dataset2.Tables("produits").Rows(i).Item("prix_unitaire").ToString
                adaptateur3.Fill(dataset3, "details_cmd")
                Dim qte = dataset3.Tables("details_cmd").Rows(i).Item("qte_cmdee").ToString
                lblQte.Text = lblQte.Text & "-" & qte
                lblDesi.Text = lblDesi.Text & "-" & designation
                lblPrix.Text = lblPrix.Text & "-" & prix
                cmd2.Dispose()
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fMenuPrincipal.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class