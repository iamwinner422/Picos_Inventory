Imports MySql.Data.MySqlClient
Public Class fAjoutCommande
    Dim nom As String
    Dim prenoms As String
    Dim designation As String
    Dim quantite As Integer
    Dim prix As Long
    Dim qteCmdee As Integer
    Dim total_cmd As Long
    Public num_com As Integer
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Function dateSsHeure(ByVal dateJ As Date) As Date
        Dim dateStr As String = dateJ.ToString
        Dim tabStr() As String
        tabStr = Split(dateStr, ":")
        dateSsHeure = tabStr(0) & "/" & tabStr(1) & "/" & tabStr(2)
    End Function
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub numClt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numClt.TextChanged

    End Sub

    Private Sub fAjoutCommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'FacturationDataSet2.details_temp'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Details_tempTableAdapter.Fill(Me.FacturationDataSet2.details_temp)
        'TODO: cette ligne de code charge les données dans la table 'InfosProduits.produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ProduitsTableAdapter.Fill(Me.InfosProduits.produits)
        'TODO: cette ligne de code charge les données dans la table 'InfosClients.clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientsTableAdapter.Fill(Me.InfosClients.clients)
        'Dim num = numClt.SelectedValue.ToString
        Try
            connexion.Open()
            Dim laRequte As String = "SELECT `num_clt`, `nom_clt`, `prenoms_clt` FROM `clients`"
            Dim laCmd As New MySqlCommand(laRequte, connexion)
            laCmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(laCmd)
            Dim mondataset As New DataSet
            adaptateur.Fill(mondataset, "clients")
            prenoms = mondataset.Tables("clients").Rows(0).Item("prenoms_clt").ToString
            numClt.DataSource = mondataset.Tables("clients")
            numClt.DisplayMember = mondataset.Tables("clients").Columns(1).ToString
            numClt.ValueMember = mondataset.Tables("clients").Columns(0).ToString
            laCmd.Dispose()
            lblPrenoms.Text = prenoms
            Dim leSql As String = "SELECT * FROM `details_temp`"
            Dim laCom As New MySqlCommand(leSql, connexion)
            Dim vraie = laCom.ExecuteNonQuery
            If vraie Then
                Dim ladaptateur As New MySqlDataAdapter(laCom)
                Dim leDataSet As New DataSet
                ladaptateur.Fill(leDataSet, "details_temp")
                DataGridView1.DataSource = leDataSet.Tables("details_temp")
                laCom.Dispose()


                Dim laRequette As String
                laRequette = "SELECT `num_prod`, `designation_prod`, `prix_unitaire`, `qte_prod` FROM `produits`"
                Dim lCmd As New MySqlCommand(laRequette, connexion)
                lCmd.ExecuteNonQuery()
                Dim ldataset As New DataSet
                Dim laadaptateur As New MySqlDataAdapter(lCmd)
                laadaptateur.Fill(ldataset, "produits")

                quantite = ldataset.Tables("produits").Rows(0).Item("qte_prod").ToString()
                prix = ldataset.Tables("produits").Rows(0).Item("prix_unitaire").ToString()
                CodeArticle.DataSource = ldataset.Tables("produits")
                CodeArticle.DisplayMember = ldataset.Tables("produits").Columns(1).ToString
                CodeArticle.ValueMember = ldataset.Tables("produits").Columns(0).ToString
                laCmd.Dispose()
                lblQte.Text = quantite
                lblPrix.Text = prix
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()

    End Sub

    Private Sub numClt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numClt.SelectedIndexChanged

    End Sub

    Private Sub boxNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub numClt_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numClt.SelectedValueChanged

    End Sub

    Private Sub numClt_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numClt.SelectionChangeCommitted
        Dim num = numClt.SelectedValue.ToString
        Try
            connexion.Open()
            Dim laRequete As String = "SELECT `nom_clt`, `prenoms_clt` FROM `clients` WHERE `num_clt` = " & num
            Dim laCmd As New MySqlCommand(laRequete, connexion)
            laCmd.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(laCmd)
            Dim mondataset As New DataSet
            adaptateur.Fill(mondataset, "clients")
            nom = mondataset.Tables("clients").Rows(0).Item("nom_clt").ToString
            prenoms = mondataset.Tables("clients").Rows(0).Item("prenoms_clt").ToString
            laCmd.Dispose()
            lblPrenoms.Text = prenoms
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub CodeArticle_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeArticle.SelectionChangeCommitted
        Dim num_prod = CodeArticle.SelectedValue.ToString
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "SELECT `designation_prod`, `qte_prod`, `prix_unitaire` FROM `produits` WHERE `num_prod` = " & num_prod
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim resultat = laCmd.ExecuteNonQuery
            Dim mondataset As New DataSet
            Dim adaptateur As New MySqlDataAdapter(laCmd)
            adaptateur.Fill(mondataset, "produits")
            designation = mondataset.Tables("produits").Rows(0).Item("designation_prod").ToString()
            quantite = mondataset.Tables("produits").Rows(0).Item("qte_prod").ToString()
            prix = mondataset.Tables("produits").Rows(0).Item("prix_unitaire").ToString()
            laCmd.Dispose()
            lblQte.Text = quantite
            lblPrix.Text = prix
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        numClt.Enabled = True
        Dim num_clt = numClt.SelectedValue.ToString
        Dim jour = Now.Day.ToString
        Dim mois = Now.Month.ToString
        Dim annee = Now.Year.ToString
        Dim dateJ As String = jour & "/" & mois & "/" & annee


        Try
            connexion.Open()
            Dim laRequete As String = "INSERT INTO `commandes`(num_clt, date_cmd, montant_cmd) VALUES('" & num_clt & "','" & dateJ & "', " & total_cmd & ")"
            Dim laCmd As New MySqlCommand(laRequete, connexion)
            laCmd.ExecuteNonQuery()
            laCmd.Dispose()
            Dim rSelect As String = "SELECT MAX(num_cmd) AS `dernier_num` FROM `commandes`"
            Dim com As New MySqlCommand(rSelect, connexion)
            com.ExecuteNonQuery()
            Dim adaptateur As New MySqlDataAdapter(com)
            Dim mondataset As New DataSet
            adaptateur.Fill(mondataset, "commandes")
            num_com = mondataset.Tables("commandes").Rows(0).Item("dernier_num").ToString
            com.Dispose()
            'selection de tout les enregistrements dans la table details_temp
            rSelect = "SELECT * FROM `details_temp`"
            Dim theCmd As New MySqlCommand(rSelect, connexion)
            theCmd.ExecuteNonQuery()
            Dim adapter As New MySqlDataAdapter(theCmd)
            Dim theDataset As New DataSet
            adapter.Fill(theDataset, "details_temp")
            theCmd.Dispose()
            'obtention du nombre de lignes
            Dim nbLignes = CInt(theDataset.Tables("details_temp").Rows.Count.ToString)
            Dim i As Integer
            Dim rInsert As String = ""
            Dim vrai As Integer
            'insertion avec la boucle
            For i = 0 To nbLignes - 1
                Dim num_prod = theDataset.Tables("details_temp").Rows(i).Item("num_prod").ToString
                Dim qteCmdee As Integer = CInt(theDataset.Tables("details_temp").Rows(i).Item("qte_prod").ToString)
                rInsert = "INSERT INTO `details_cmd`(num_cmd, num_prod, qte_cmdee) VALUES('" & num_com & "', '" & num_prod & "', '" & qteCmdee & "')"
                Dim commande As New MySqlCommand(rInsert, connexion)
                vrai = commande.ExecuteNonQuery()
            Next
            If vrai Then
                MsgBox("La commande a été ajoutée avec succès!", MsgBoxStyle.Information)
                facc1.ShowDialog()
            Else
                MsgBox("Erreur!", MsgBoxStyle.Critical)
            End If


            'theCmd.ExecuteNonQuery()

            ''SUPPRESSION DES ELEMENTS DANS LA TABLE TEMPORAIRE
            'Dim Delete As String = "DELETE FROM `details_temp`"
            'Dim cmd As New MySqlCommand(Delete, connexion)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            ''RAFRAICHISSEMENT DE LA TABLE TEMPORAIRE
            'Dim leSql As String = "SELECT * FROM `details_temp`"
            'Dim laCom As New MySqlCommand(leSql, connexion)
            'Dim vraie = laCom.ExecuteNonQuery
            'If vraie Then
            '    Dim ladaptateur As New MySqlDataAdapter(laCom)
            '    Dim leDataSet As New DataSet
            '    ladaptateur.Fill(leDataSet, "details_temp")
            '    DataGridView1.DataSource = leDataSet.Tables("details_temp")
            '    laCom.Dispose()
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        total_cmd = 0
        lblTotal.Text = total_cmd.ToString
    End Sub

    Private Sub btnAjout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjout.Click
        'total = 0
        Dim num_prod = CodeArticle.SelectedValue.ToString
        Dim num_clt = numClt.SelectedValue.ToString
        numClt.Enabled = False
        If (boxQteCmdee.Text = "") Then
            MsgBox("Erreur!Veuillez saisir la quantité à commander.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(boxQteCmdee.Text) Then
            MsgBox("Erreur!La quantité saisie n'est pas numérique.", MsgBoxStyle.Critical)
        ElseIf (CInt(boxQteCmdee.Text) < 1) Then
            MsgBox("Erreur!La quantité à commander doit être superieure à 0.", MsgBoxStyle.Critical)
        ElseIf (CInt(boxQteCmdee.Text) > CInt(lblQte.Text)) Then
            MsgBox("Erreur!La quantité à commander ne doit pas être superieure à la quantité en stock.", MsgBoxStyle.Critical)
        ElseIf (CInt(lblQte.Text = 0)) Then
            MsgBox("Erreur!La quantité en stock est nulle", MsgBoxStyle.Critical)
        Else
            qteCmdee = Val(boxQteCmdee.Text)
            Dim total = Val(qteCmdee * prix)
            total_cmd = total_cmd + total
            lblTotal.Text = total_cmd.ToString
            boxQteCmdee.Text = ""
            Try
                connexion.Open()
                Dim laRequete As String = "UPDATE `produits` SET `qte_prod` = `qte_prod` - '" & qteCmdee & "' WHERE `num_prod`= " & num_prod
                Dim laCmd As New MySqlCommand(laRequete, connexion)
                laCmd.ExecuteNonQuery()
                laCmd.Dispose()
                Dim requette As String = "SELECT `qte_prod` FROM `produits` WHERE `num_prod` = " & num_prod
                Dim Cmd As New MySqlCommand(requette, connexion)
                Cmd.ExecuteNonQuery()
                Dim mondataset As New DataSet
                Dim adaptateur As New MySqlDataAdapter(Cmd)
                adaptateur.Fill(mondataset, "produits")
                quantite = mondataset.Tables("produits").Rows(0).Item("qte_prod").ToString()
                lblQte.Text = quantite
                Cmd.Dispose()
                'Ajout des infos dans la table temporaire
                Dim desi = CodeArticle.Text
                requette = "INSERT INTO `details_temp` VALUES(" & num_prod & ", '" & desi & "', " & qteCmdee & ", " & prix & ", " & total & ")"
                Dim com As New MySqlCommand(requette, connexion)
                com.ExecuteNonQuery()
                com.Dispose()
                'rafraichisement du datagird view
                Dim leSql As String = "SELECT * FROM `details_temp`"
                Dim laCom As New MySqlCommand(leSql, connexion)
                Dim vraie = laCom.ExecuteNonQuery
                If vraie Then
                    Dim ladaptateur As New MySqlDataAdapter(laCom)
                    Dim leDataSet As New DataSet
                    ladaptateur.Fill(leDataSet, "details_temp")
                    DataGridView1.DataSource = leDataSet.Tables("details_temp")
                    laCom.Dispose()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            connexion.Close()
           
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub CodeArticle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeArticle.SelectedIndexChanged

    End Sub
End Class