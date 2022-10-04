Public Class fChargement

    Private Sub fChargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value = ProgressBar1.Maximum Then

            fConnexion.Show()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
End Class
