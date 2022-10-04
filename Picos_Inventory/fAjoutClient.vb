Imports MySql.Data.MySqlClient
Public Class fAjoutClient
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
    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub boxSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Click
        Label8.Visible = False
    End Sub

    Private Sub boxSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxSearch.Leave
        Label8.Visible = True
    End Sub
    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click
        If btnEffacer.Text = "Effacer" Then
            boxAdresse.Text = ""
            boxNom.Text = ""
            boxPrenoms.Text = ""
            boxNumTel.Text = ""
        Else
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

                    Dim requete1 As String = "SELECT * FROM `clients`"
                    Dim lCmd As New MySqlCommand(requete1, connexion)
                    Dim vraie1 = lCmd.ExecuteNonQuery
                    If vraie1 Then
                        Dim adaptateur1 As New MySqlDataAdapter(lCmd)
                        Dim MonDataSet As New DataSet
                        adaptateur1.Fill(MonDataSet, "clients")
                        DataGridView1.DataSource = MonDataSet.Tables("clients")
                        lCmd.Dispose()
                        btnAjouter.Text = "Ajouter"
                        btnEffacer.Text = "Effacer"
                    End If
                Else
                    MsgBox("Erreur!", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()

        End If

    End Sub

    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        If btnAjouter.Text = "Ajouter" Then
            If Verification(boxNom.Text, boxPrenoms.Text, boxAdresse.Text, boxNumTel.Text) And Not IsNumeric(boxNom.Text) And Not IsNumeric(boxPrenoms.Text) Then
                Dim nom = boxNom.Text
                Dim prenoms = boxPrenoms.Text
                Dim adresse = boxAdresse.Text
                Dim numero = boxNumTel.Text
                Try
                    connexion.Open()
                    Dim requete As String = "SELECT * FROM `clients` WHERE `nom_clt` = '" & ChangeCaratere(nom, CaractereType.Guillemet) & "' AND `prenoms_clt` = '" & ChangeCaratere(prenoms, CaractereType.Guillemet) & "' AND `num_tel` = '" & numero & "'"
                    Dim cmd As New MySqlCommand(requete, connexion)
                    cmd.ExecuteNonQuery()
                    Dim adaptateur As New MySqlDataAdapter(cmd)
                    Dim dataset As New DataSet
                    cmd.Dispose()
                    adaptateur.Fill(dataset, "clients")
                    If dataset.Tables("clients").Rows.Count <= 0 Then
                        Dim laRequette As String
                        laRequette = "INSERT INTO `clients`(nom_clt, prenoms_clt, num_tel, adr_clt) VALUES('" & ChangeCaratere(nom, CaractereType.Guillemet) & "', '" & ChangeCaratere(prenoms, CaractereType.Guillemet) & "', '" & numero & "', '" & adresse & "')"
                        Dim laCmd As New MySqlCommand(laRequette, connexion)
                        Dim vraie = laCmd.ExecuteNonQuery

                        If (vraie) Then
                            MsgBox("Client ajouté avec succès!", MsgBoxStyle.Information)
                            boxAdresse.Text = ""
                            boxNom.Text = ""
                            boxPrenoms.Text = ""
                            boxNumTel.Text = ""
                            laCmd.Dispose()
                            'RAFRAICHISSEMENT DU DATAGRID VIEW
                            Dim requete1 As String = "SELECT * FROM `clients`"
                            Dim lCmd As New MySqlCommand(requete1, connexion)
                            Dim vraie1 = lCmd.ExecuteNonQuery
                            If vraie1 Then
                                Dim adaptateur1 As New MySqlDataAdapter(lCmd)
                                Dim MonDataSet As New DataSet
                                adaptateur1.Fill(MonDataSet, "clients")
                                DataGridView1.DataSource = MonDataSet.Tables("clients")
                                lCmd.Dispose()
                            End If
                        Else
                            MsgBox("Erreur!", MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox("Le client existe déjà!", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                connexion.Close()
            End If
        Else
            If Verification(boxNom.Text, boxPrenoms.Text, boxAdresse.Text, boxNumTel.Text) And Not IsNumeric(boxNom.Text) And Not IsNumeric(boxPrenoms.Text) Then
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
                        'RAFRICHISSEMENT DU DATAGRID VIEW
                        Dim requete1 As String = "SELECT * FROM `clients`"
                        Dim lCmd As New MySqlCommand(requete1, connexion)
                        Dim vraie1 = lCmd.ExecuteNonQuery
                        If vraie1 Then
                            Dim adaptateur1 As New MySqlDataAdapter(lCmd)
                            Dim MonDataSet As New DataSet
                            adaptateur1.Fill(MonDataSet, "clients")
                            DataGridView1.DataSource = MonDataSet.Tables("clients")
                            lCmd.Dispose()
                            btnAjouter.Text = "Ajouter"
                            btnEffacer.Text = "Effacer"
                        End If
                    Else
                        MsgBox("Erreur!", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
                connexion.Close()
            End If
        End If
    End Sub

    Private Sub fAjoutClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'FacturationDataSet3.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientsTableAdapter.Fill(Me.FacturationDataSet3.clients)

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
        btnAjouter.Text = "Modifier"
        btnEffacer.Text = "Supprimer"
    End Sub

    Private Sub DataGridView1_CellContextMenuStripNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles DataGridView1.CellContextMenuStripNeeded

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
End Class