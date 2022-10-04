Imports MySql.Data.MySqlClient
Public Class fEntreeStock
    Public designation As String
    Public prix As String
    Public quantite As String
    Dim connexion As New MySqlConnection("server=localhost;User Id=root;database=facturation")
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub fEntreeStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Entreestock.produits'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ProduitsTableAdapter.Fill(Me.Entreestock.produits)
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "SELECT `num_prod`, `designation_prod`, `qte_prod` FROM `produits`"
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim resultat = laCmd.ExecuteNonQuery
            Dim mondataset As New DataSet
            Dim adaptateur As New MySqlDataAdapter(laCmd)
            adaptateur.Fill(mondataset, "produits")
            quantite = mondataset.Tables("produits").Rows(0).Item("qte_prod").ToString()
            lblQte.Text = quantite
            CodeArticle.DataSource = mondataset.Tables("produits")
            CodeArticle.DisplayMember = mondataset.Tables("produits").Columns(1).ToString
            CodeArticle.ValueMember = mondataset.Tables("produits").Columns(0).ToString
            laCmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

        connexion.Close()
    End Sub
   Private Sub CodeArticle_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeArticle.SelectionChangeCommitted
        Dim num = CodeArticle.SelectedValue.ToString
        Try
            connexion.Open()
            Dim laRequette As String
            laRequette = "SELECT `designation_prod`, `qte_prod` FROM `produits` WHERE `num_prod` = " & num
            Dim laCmd As New MySqlCommand(laRequette, connexion)
            Dim resultat = laCmd.ExecuteNonQuery
            Dim mondataset As New DataSet
            Dim adaptateur As New MySqlDataAdapter(laCmd)
            adaptateur.Fill(mondataset, "produits")
            designation = mondataset.Tables("produits").Rows(0).Item("designation_prod").ToString()
            quantite = mondataset.Tables("produits").Rows(0).Item("qte_prod").ToString()
            laCmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
        connexion.Close()
        lblQte.Text = quantite
    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        Dim num = CodeArticle.SelectedValue.ToString
        If boxNQte.Text = "" Then
            MsgBox("Erreur!Veuillez saisir la quantité entrante!", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(boxNQte.Text) Then
            MsgBox("Erreur!La quantité saisie n'est pas numérique!", MsgBoxStyle.Critical)
        ElseIf boxNQte.Text < 1 Then
            MsgBox("Erreur!Veuillez saisir une quantité supérieure à 0!", MsgBoxStyle.Critical)
        Else
            Dim qte_ent = Val(boxNQte.Text)
            Dim dateJ As String = Today.Day.ToString & "/" & Today.Month.ToString & "/" & Today.Year.ToString 'DATE DU JOUR
            Try
                connexion.Open()
                Dim larequete As String = "UPDATE `produits` SET `qte_prod` = `qte_prod` + '" & qte_ent & "' WHERE `num_prod` = " & num
                Dim laCmd As New MySqlCommand(larequete, connexion)
                Dim vraie = laCmd.ExecuteNonQuery()
                If vraie Then
                    Dim requete As String = "SELECT `qte_prod` FROM `produits` WHERE `num_prod` = " & num
                    Dim cmd As New MySqlCommand(requete, connexion)
                    cmd.ExecuteNonQuery()
                    Dim adapateur As New MySqlDataAdapter(cmd)
                    Dim mondataset As New DataSet
                    adapateur.Fill(mondataset, "produits")
                    quantite = mondataset.Tables("produits").Rows(0).Item("qte_prod").ToString
                    lblNQte.Text = quantite
                    lblQte.Text = quantite
                    'INSERTION DANS LA TABLE HITORIQUE
                    Dim desi = CodeArticle.Text
                    Dim reqInsert = "INSERT INTO `histo_prod` VALUES(null,'" & desi & "', '" & qte_ent & "', '" & dateJ & "', '" & quantite & "')"
                    Dim com As New MySqlCommand(reqInsert, connexion)
                    com.ExecuteNonQuery()
                    MsgBox("L'entrée en stock du produit " + designation + " a été éffectuée avec succès avec une quantité égale à " + quantite + ".", MsgBoxStyle.Information)
                    cmd.Dispose()
                    laCmd.Dispose()
                    lblNQte.Text = ""
                    boxNQte.Text = ""

                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
        End If
        connexion.Close()
    End Sub

    Private Sub CodeArticle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeArticle.SelectedIndexChanged

    End Sub
End Class