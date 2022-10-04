Public Class rapProduit

    Private Sub rapProduit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'infosProduits.produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.produitsTableAdapter.Fill(Me.infosProduits.produits)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class