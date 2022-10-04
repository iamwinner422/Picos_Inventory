Public Class rapClt

    Private Sub rapClt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'facturationDataSet.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.clientsTableAdapter.Fill(Me.facturationDataSet.clients)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class