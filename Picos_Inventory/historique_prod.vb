Public Class historique_prod

    Private Sub historique_prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'histo_prod.histo_prod'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.histo_prodTableAdapter.Fill(Me.histo_prod._histo_prod)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class