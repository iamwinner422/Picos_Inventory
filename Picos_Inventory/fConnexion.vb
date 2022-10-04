Imports MySql.Data.MySqlClient
Public Class fConnexion
    Public num_user As String
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
    Function Verification(ByRef lenom As String, ByRef lemot As String) As Boolean

        If lenom = "" And lemot = "" Then
            MsgBox("Erreur!Veuillez saisir le nom d'utilisateur et le mot de passe", MsgBoxStyle.Critical)
            Return False
        ElseIf lenom <> "" And lemot = "" Then
            MsgBox("Erreur!Veuillez saisir le mot de passe", MsgBoxStyle.Critical)
            Return False
        ElseIf lenom = "" And lemot <> "" Then
            MsgBox("Erreur!Veuillez saisir le nom d'utilisateur", MsgBoxStyle.Critical)
            Return False
            'ElseIf lenom <> "Admin" And lemot <> "@dmin" Then
            '   MsgBox("Erreur!le nom d'utilisateur et le mot de passe sont incorrects", MsgBoxStyle.Critical)
            '  Return False
            'ElseIf (lemot = "Admin" And lenom <> "@dmin") Or (lenom = "Admin" And lemot <> "@dmin") Then
            '   MsgBox("Erreur!le nom d'utilisateur ou le mot de passe est incorrect", MsgBoxStyle.Critical)
            '  Return False
        Else
            Return True
        End If
    End Function

    Private Sub fConnexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFermer.Click
        fChargement.Close()

    End Sub

    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        boxPassword.Text = ""
        boxUser.Text = ""
    End Sub

    Private Sub btnConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnexion.Click
        If Verification(boxUser.Text, boxPassword.Text) Then
            Dim login As String = boxUser.Text
            Dim password As String = boxPassword.Text

            Try
                connexion.Open()
                Dim requete As String = "SELECT * FROM `utilisateurs` WHERE `login_user` = '" & ChangeCaratere(login, CaractereType.Guillemet) & "' AND `pass_user` = '" & ChangeCaratere(password, CaractereType.Guillemet) & "'"
                Dim cmd As New MySqlCommand(requete, connexion)
                cmd.ExecuteNonQuery()
                Dim adaptateur As New MySqlDataAdapter(cmd)
                Dim dataset As New DataSet
                adaptateur.Fill(dataset, "utilisateurs")
                If dataset.Tables("utilisateurs").Rows.Count > 0 Then
                    login = dataset.Tables("utilisateurs").Rows(0).Item("login_user").ToString
                    password = dataset.Tables("utilisateurs").Rows(0).Item("pass_user").ToString
                    num_user = dataset.Tables("utilisateurs").Rows(0).Item("num_user").ToString
                    If login = "Admin" And password = "@dmin" Then
                        boxPassword.Text = ""
                        boxUser.Text = ""
                        fUtilisateur.Show()
                        Me.Hide()
                    Else
                        boxPassword.Text = ""
                        boxUser.Text = ""
                        fMenuPrincipal.Show()
                        Me.Hide()
                    End If
                Else
                    MsgBox("Erreur!Nom d'utilisateur ou mot de passe incorrect.", MsgBoxStyle.Critical)
                    boxPassword.Text = ""
                    boxUser.Text = ""
                End If
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If
    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class