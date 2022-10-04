Imports MySql.Data.MySqlClient
Public Class fNUser
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
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        Dim login As String = "Admin"
        Dim passAd As String
        If boxLogin.Text = "" Or boxPass.Text = "" Or boxPassAd.Text = "" Then
            MsgBox("Erreur!Veuillez remplir tous les champs.", MsgBoxStyle.Critical)
        Else
            Try
                connexion.Open()
                Dim rSelect As String = "SELECT `pass_user` FROM `utilisateurs` WHERE `login_user`= '" & ChangeCaratere(login, CaractereType.Guillemet) & "'"
                Dim cmd As New MySqlCommand(rSelect, connexion)
                cmd.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmd)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "utilisateurs")
                passAd = dataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
                If boxPassAd.Text <> passAd Then
                    MsgBox("Erreur!Le mot de passe Admin est incorrect.", MsgBoxStyle.Critical)
                Else
                    Dim login_user As String = boxLogin.Text
                    Dim pass_user As String = boxPass.Text
                    Dim requete As String = "SELECT * FROM `utilisateurs` WHERE `login_user` = '" & login_user & "'"
                    Dim laCmd As New MySqlCommand(requete, connexion)
                    cmd.ExecuteNonQuery()
                    Dim adaptateur1 As New MySqlDataAdapter(laCmd)
                    Dim dataset1 As New DataSet
                    laCmd.Dispose()
                    adaptateur1.Fill(dataset1, "produits")
                    If dataset.Tables("produits").Rows.Count <= 0 Then
                        Dim rInsert As String = "INSERT INTO `utilisateurs`(login_user, pass_user) VALUES('" & login_user & "', '" & pass_user & "')"
                        Dim laCom As New MySqlCommand(rInsert, connexion)
                        Dim vraie = laCom.ExecuteNonQuery

                        If (vraie) Then
                            MsgBox("Utilisateur ajouté avec succès!", MsgBoxStyle.Information)
                            boxLogin.Text = ""
                            boxPass.Text = ""
                            laCom.Dispose()

                        Else
                            MsgBox("Erreur!", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("L'utilisateur existe déjà!", MsgBoxStyle.Critical)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxLogin.Text = ""
        boxPass.Text = ""
        boxPassAd.Text = ""
    End Sub
End Class