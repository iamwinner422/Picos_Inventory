Imports MySql.Data.MySqlClient
Public Class fListeClient

    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private compteur As Integer
    Function Verification(ByRef nom As String, ByRef prenoms As String, ByRef adr As String, ByRef num As String) As Boolean
        If nom = "" And prenoms = "" And adr = "" And num = "" Then
            MsgBox("Erreur! Veuillez remplir tous les champs", MsgBoxStyle.Critical)
            Return False
        ElseIf nom = "" Or prenoms = "" Or adr = "" Or num = "" Then
            MsgBox("Erreur! Certains champs n'ont pas été remplis. Veuillez saisir les toutes les informations", MsgBoxStyle.Critical)
            Return False
        ElseIf num.Length > 8 Then
            MsgBox("Erreur! Le numéro de téléphone ne doit pas dépasser 8 caractères", MsgBoxStyle.Critical)
            Return False
        ElseIf num.Length < 8 Then
            MsgBox("Erreur! Le nombre de caractères du numéro de téléphone ne doit pas être inférieur à 8 ", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(num) Then
            MsgBox("Erreur! Le numéro de téléphone saisi n'est pas numérique", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub fListeClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'FacturationDataSet.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientsTableAdapter.Fill(Me.FacturationDataSet.clients)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneSelectionnee As DataGridViewRow
        ligneSelectionnee = DataGridView1.Rows(numLigne)
        boxNum.Text = ligneSelectionnee.Cells(0).Value.ToString
        boxNom.Text = ligneSelectionnee.Cells(1).Value.ToString
        boxPrenoms.Text = ligneSelectionnee.Cells(2).Value.ToString
        boxNumTel.Text = ligneSelectionnee.Cells(3).Value.ToString
        boxAdresse.Text = ligneSelectionnee.Cells(4).Value.ToString

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fMenuPrincipal.Show()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        If Verification(boxNom.Text, boxPrenoms.Text, boxAdresse.Text, boxNumTel.Text) Then
            Dim nom = boxNom.Text
            Dim prenoms = boxPrenoms.Text
            Dim adresse = boxAdresse.Text
            Dim numero = boxNumTel.Text
            Dim num = Val(boxNum.Text)

            Try
                connexion.Open()
                Dim laRequette As String
                laRequette = "UPDATE `clients` SET `nom_clt` = '" & nom & "', `prenoms_clt` = '" & prenoms & "', `num_tel` = '" & numero & "', `adr_clt` = '" & adresse & "' WHERE `num_clt` = '" & num & "'"
                Dim laCmd As New MySqlCommand(laRequette, connexion)
                Dim vraie = laCmd.ExecuteNonQuery
                If (vraie) Then
                    MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                    boxAdresse.Text = ""
                    boxNom.Text = ""
                    boxPrenoms.Text = ""
                    boxNumTel.Text = ""
                    laCmd.Dispose()
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
        End If

    End Sub


    Private Sub btnSuppr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppr.Click
        Dim num = Val(boxNum.Text)
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "DELETE FROM `clients` WHERE `num_clt` = " & num
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery
            If (vraie) Then
                MsgBox("L'enrégistrement a été bien supprimer!", MsgBoxStyle.Information)
                boxAdresse.Text = ""
                boxNom.Text = ""
                boxPrenoms.Text = ""
                boxNumTel.Text = ""
                laCmd.Dispose()
            Else
                MsgBox("Erreur!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub boxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.TextChanged
        Dim recherche = boxSearch.Text
        Try
            connexion.Open()
            Dim laRequette = "SELECT * FROM `clients` WHERE(`nom_clt` LIKE '%" & recherche & "%' OR `prenoms_clt` LIKE '%" & recherche & "%' OR `num_tel` LIKE '%" & recherche & "%' OR `adr_clt` LIKE '%" & recherche & "%' );"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery()
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim dataSet As New DataSet
                adaptateur.Fill(dataSet, "clients")
                DataGridView1.DataSource = dataSet.Tables("clients")
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

    Private Sub btn_Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualiser.Click
        Try
            connexion.Open()
            Dim requete As String = "SELECT * FROM `clients`"
            Dim laCmd As New MySqlCommand(requete, connexion)
            Dim vraie = laCmd.ExecuteNonQuery
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim MonDataSet As New DataSet
                adaptateur.Fill(MonDataSet, "clients")
                DataGridView1.DataSource = MonDataSet.Tables("clients")
                laCmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub boxNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxNum.TextChanged

    End Sub
End Class