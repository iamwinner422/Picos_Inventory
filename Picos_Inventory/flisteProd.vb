Imports MySql.Data.MySqlClient
Public Class flisteProd
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Function Verification(ByRef des As String, ByRef prix As String, ByRef qte As String) As Boolean
        If des = "" And prix = "" And qte = "" Then
            MsgBox("Erreur! Veuillez saisir tous les informations", MsgBoxStyle.Critical)
            Return False
        ElseIf des = "" Or prix = "" Or qte = "" Then
            MsgBox("Erreur! Toutes les informations n'ont pas été saisies", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(prix) Then
            MsgBox("Erreur! Le prix saisi n'est pas numérique", MsgBoxStyle.Critical)
            Return False
        ElseIf Not IsNumeric(qte) Then
            MsgBox("Erreur! La quantité saisie n'est pas numérique", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub flisteProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'FacturationDataSet1.produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ProduitsTableAdapter.Fill(Me.FacturationDataSet1.produits)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        fMenuPrincipal.Show()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click

        If Verification(boxDesignation.Text, boxPrix.Text, boxQte.Text) Then

            Dim designation As String = boxDesignation.Text
            Dim prix As Double = Val(boxPrix.Text)
            Dim quantite As Integer = Val(boxQte.Text)
            Dim num = Val(boxNum.Text)
            Try
                connexion.Open()
                Dim laRequette As String
                laRequette = "UPDATE `produits` SET `designation_prod` = '" & designation & "', `prix_unitaire` = '" & prix & "', `qte_prod` = '" & quantite & "' WHERE `num_prod` = '" & num & "'"
                Dim laCmd As New MySqlCommand(laRequette, connexion)
                Dim vraie = laCmd.ExecuteNonQuery
                If (vraie) Then
                    MsgBox("La modification a été éffectuée avec succès!", MsgBoxStyle.Information)
                    boxDesignation.Text = ""
                    boxPrix.Text = ""
                    boxQte.Text = ""
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim numLigne As Integer
        numLigne = e.RowIndex
        Dim ligneSelectionnee As DataGridViewRow
        ligneSelectionnee = DataGridView1.Rows(numLigne)
        boxNum.Text = ligneSelectionnee.Cells(0).Value.ToString
        boxDesignation.Text = ligneSelectionnee.Cells(1).Value.ToString
        boxPrix.Text = ligneSelectionnee.Cells(2).Value.ToString
        boxQte.Text = ligneSelectionnee.Cells(3).Value.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Actualiser.Click
        Try
            connexion.Open()
            Dim requete As String = "SELECT * FROM `produits`"
            Dim laCmd As New MySqlCommand(requete, connexion)
            Dim vraie = laCmd.ExecuteNonQuery
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim MonDataSet As New DataSet
                adaptateur.Fill(MonDataSet, "produits")
                DataGridView1.DataSource = MonDataSet.Tables("produits")
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
            Dim laRequette = "SELECT * FROM `produits` WHERE(`designation_prod` LIKE '%" & recherche & "%' OR `prix_unitaire` LIKE '%" & recherche & "%' OR `qte_prod` LIKE '%" & recherche & "%');"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery()
            If vraie Then
                Dim adaptateur As New MySqlDataAdapter(laCmd)
                Dim dataSet As New DataSet
                adaptateur.Fill(dataSet, "produits")
                DataGridView1.DataSource = dataSet.Tables("produits")
                laCmd.Dispose()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub btnSuppr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppr.Click
        Dim num = Val(boxNum.Text)
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "DELETE FROM `produits` WHERE `num_prod` = '" & num & "'"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim vraie = laCmd.ExecuteNonQuery
            If (vraie) Then
                MsgBox("L'enrégistrement a été bien supprimer!", MsgBoxStyle.Information)
                boxDesignation.Text = ""
                boxPrix.Text = ""
                boxQte.Text = ""
                laCmd.Dispose()

            Else
                MsgBox("Erreur!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class