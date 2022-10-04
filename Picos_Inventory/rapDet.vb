Public Class rapDet

    Private Sub rapDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'facturationD.details_cmd'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.details_cmdTableAdapter.Fill(Me.facturationD.details_cmd)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class