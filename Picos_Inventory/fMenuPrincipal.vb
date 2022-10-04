Imports MySql.Data.MySqlClient
Public Class fMenuPrincipal
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Sub ArticlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        barreMenu.ForeColor = Color.White


    End Sub

    Private Sub FacturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NpuvelUtilisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nom As String = ""
        Dim num = Val(fConnexion.num_user)
        Try
            connexion.Open()
            Dim requete = "SELECT `login_user` FROM `utilisateurs` WHERE `num_user` = " & num
            Dim cmd As New MySqlCommand(requete, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "utilisateurs")
            nom = dataset.Tables("utilisateurs").Rows(0).Item("login_user").ToString
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        Me.Text = " Accueil - Picos Billing"
        lblDateHeure.Text = DateAndTime.Today
        'Me.ReportViewer1.RefreshReport()
        lblUser.Text = nom
    End Sub
    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        fChargement.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClients.Click
       rapClt.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNClients.Click
        fAjoutClient.ShowDialog()

    End Sub

    Private Sub btnNProduits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNProduits.Click
        fAjoutProduitvb.ShowDialog()

    End Sub

    Private Sub btnNCmds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNCmds.Click
        fAjoutCommande.ShowDialog()
    End Sub

    Private Sub btnNFacs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNFacs.Click
        fEntreeStock.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        ' MsgBox("Voulez vous quitter l'application?", MsgBoxStyle.OkCancel)
        '  If MsgBoxResult.Ok = MsgBoxResult.Ok Then
        'fChargement.Close()
        ' Else
        ' Me.Refresh()
        '  End If
        fChargement.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        fConnexion.Show()
        Me.Close()
    End Sub

    Private Sub btnProduits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduits.Click
        rapProduit.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem.Click
        fAjoutClient.ShowDialog()
    End Sub

    Private Sub ListeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeToolStripMenuItem.Click
        rapClt.ShowDialog()
    End Sub

    Private Sub NouveauToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem1.Click
        fAjoutProduitvb.ShowDialog()
    End Sub

    Private Sub ListeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeToolStripMenuItem1.Click
        rapProduit.ShowDialog()
    End Sub

    Private Sub EntréeEnStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntréeEnStockToolStripMenuItem.Click
        fEntreeStock.Show()
    End Sub

    Private Sub NouvelleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleToolStripMenuItem.Click
        fAjoutCommande.Show()
    End Sub

    Private Sub NouvelleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rapClt.Show()
    End Sub

    Private Sub DeconnexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeconnexionToolStripMenuItem.Click
        Me.Close()
        fConnexion.Show()
    End Sub

    Private Sub labelUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CommandesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rapCmd.Show()
    End Sub

    Private Sub DétailsCommandeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rapDet.Show()
    End Sub

    Private Sub btnCmds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCmds.Click
        flst_cmd.ShowDialog()
    End Sub

    Private Sub ListeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeToolStripMenuItem2.Click
        fListeCmd.Show()
        Me.Hide()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub HistoriqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        rapProduit.Show()
    End Sub

    Private Sub HIstoriqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HIstoriqueToolStripMenuItem1.Click
        historique_prod.ShowDialog()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnHisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHisto.Click
        historique_prod.ShowDialog()
    End Sub
End Class