Imports MySql.Data.MySqlClient
Public Class fUtilisateur
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Public Enum CaractereType
        Guillemet
        RetourChariot
    End Enum

    Public Function ChangeCaratere(ByVal Valeur As Object, ByVal Caractere As CaractereType) As String

        Select Case Caractere
            Case CaractereType.Guillemet
                ChangeCaratere = Replace(Valeur, "'", "''")
            Case CaractereType.RetourChariot
                ChangeCaratere = Replace(Valeur, vbCrLf, "; ")
            Case Else
                ChangeCaratere = ""
        End Select
    End Function

    Private Sub fUtilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Users.utilisateurs'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.UtilisateursTableAdapter.Fill(Me.Users.utilisateurs)
        'TODO: cette ligne de code charge les données dans la table 'Utilisateurs.utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fChargement.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneSelectionnee As DataGridViewRow
        ligneSelectionnee = DataGridView1.Rows(numLigne)
        boxNum.Text = ligneSelectionnee.Cells(0).Value.ToString
        boxUser.Text = ligneSelectionnee.Cells(1).Value.ToString
        boxPassword.Text = ligneSelectionnee.Cells(2).Value.ToString
    End Sub

    Private Sub UtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilisateursToolStripMenuItem.Click
        fNUser.ShowDialog()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        Dim login As String = "Admin"
        Dim passAd As String
        Dim num = Val(boxNum.Text)
        Dim nLogin As String = boxUser.Text
        Dim nPass As String = boxPassword.Text
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT `pass_user` FROM `utilisateurs` WHERE `login_user`= '" & ChangeCaratere(login, CaractereType.Guillemet) & "'"
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "utilisateurs")
            passAd = dataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
            If boxPassword.Text = "" Or boxPassword.Text = "" Or boxPassAdmin.Text = "" Then
                MsgBox("Erreur!Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
            ElseIf boxPassAdmin.Text <> passAd Then
                MsgBox("Erreur!Le mot de passe Admin est incorrect.", MsgBoxStyle.Critical)
            Else
                Dim requete As String = "UPDATE `utilisateurs` SET `login_user`='" & ChangeCaratere(nLogin, CaractereType.Guillemet) & "', `pass_user` = '" & ChangeCaratere(nPass, CaractereType.Guillemet) & "' WHERE `num_user` = " & num
                Dim laCmd As New MySqlCommand(requete, connexion)
                Dim vraie1 = laCmd.ExecuteNonQuery()
                If vraie1 Then
                    MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                    boxUser.Text = ""
                    boxPassword.Text = ""
                    boxPassAdmin.Text = ""
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If

                laCmd.Dispose()
                Dim leSql As String = "SELECT * FROM `utilisateurs`"
                Dim laCom As New MySqlCommand(leSql, connexion)
                Dim vraie = laCom.ExecuteNonQuery
                If vraie Then
                    Dim ladaptateur As New MySqlDataAdapter(laCom)
                    Dim leDataSet As New DataSet
                    ladaptateur.Fill(leDataSet, "utilisateurs")
                    DataGridView1.DataSource = leDataSet.Tables("utilisateurs")
                    laCom.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnSuppr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppr.Click
        Dim login As String = "Admin"
        Dim passAd As String
        Dim num = boxNum.Text
        Try
            connexion.Open()
            Dim rSelect As String = "SELECT `pass_user` FROM `utilisateurs` WHERE `login_user`= '" & ChangeCaratere(login, CaractereType.Guillemet) & "'"
            Dim cmd As New MySqlCommand(rSelect, connexion)
            cmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(cmd)
            Dim dataset As New DataSet
            adaptateur.Fill(dataset, "utilisateurs")
            passAd = dataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
            If boxPassAdmin.Text <> passAd Then
                MsgBox("Erreur!Le mot de passe Admin est incorrect.", MsgBoxStyle.Critical)
            Else
                Dim delete As String = "DELETE FROM `utilisateurs` WHERE `num_user` = " & num
                Dim laCmd As New MySqlCommand(delete, connexion)
                laCmd.ExecuteNonQuery()
                laCmd.Dispose()
                Dim leSql As String = "SELECT * FROM `utilisateurs`"
                Dim laCom As New MySqlCommand(leSql, connexion)
                Dim vraie = laCom.ExecuteNonQuery
                If vraie Then
                    Dim ladaptateur As New MySqlDataAdapter(laCom)
                    Dim leDataSet As New DataSet
                    ladaptateur.Fill(leDataSet, "utilisateurs")
                    DataGridView1.DataSource = leDataSet.Tables("utilisateurs")
                    laCom.Dispose()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        fMenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DeconnexionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeconnexionToolStripMenuItem.Click
        Me.Close()
        fConnexion.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        fChargement.Close()
        Me.Close()
    End Sub

    Private Sub btn_Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualiser.Click
        Try
            connexion.Open()
            Dim requete As String = "SELECT * FROM `utilisateurs`"
            Dim laCmd As New MySqlCommand(requete, connexion)
            Dim vraie = laCmd.ExecuteNonQuery
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim MonDataSet As New DataSet
                adaptateur.Fill(MonDataSet, "utilisateurs")
                DataGridView1.DataSource = MonDataSet.Tables("utilisateurs")
                laCmd.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub boxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Click
        Label7.Visible = False
    End Sub

    Private Sub boxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Leave
        Label7.Visible = True
    End Sub

    Private Sub boxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.TextChanged
        Dim recherche As String = boxSearch.Text
        Try
            connexion.Open()
            Dim laRequette = "SELECT * FROM `utilisateurs` WHERE(`login_user` LIKE '%" & recherche & "%');"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery()
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim dataSet As New DataSet
                adaptateur.Fill(dataSet, "utilisateurs")
                DataGridView1.DataSource = dataSet.Tables("utilisateurs")
                laCmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class