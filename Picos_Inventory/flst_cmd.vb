Public Class flst_cmd

    Private Sub flst_cmd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'lstcmd.DataTable1'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.DataTable1TableAdapter.Fill(Me.lstcmd.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class