<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label3 As System.Windows.Forms.Label
        Dim labelNew As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMenuPrincipal))
        Me.barreMenu = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntréeEnStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommandesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDateHeure = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.HIstoriqueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHisto = New System.Windows.Forms.Button()
        Me.btnProduits = New System.Windows.Forms.Button()
        Me.btnCmds = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNFacs = New System.Windows.Forms.Button()
        Me.btnNCmds = New System.Windows.Forms.Button()
        Me.btnNProduits = New System.Windows.Forms.Button()
        Me.btnNClients = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label3 = New System.Windows.Forms.Label()
        labelNew = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.barreMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label3.Location = New System.Drawing.Point(4, 5)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(160, 21)
        Label3.TabIndex = 7
        Label3.Text = "Accueil - Picos  Billing"
        '
        'labelNew
        '
        labelNew.AutoSize = True
        labelNew.BackColor = System.Drawing.Color.Transparent
        labelNew.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        labelNew.ForeColor = System.Drawing.Color.White
        labelNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        labelNew.Location = New System.Drawing.Point(71, 190)
        labelNew.Name = "labelNew"
        labelNew.Size = New System.Drawing.Size(124, 37)
        labelNew.TabIndex = 7
        labelNew.Text = "Nouveau"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label2.Location = New System.Drawing.Point(307, 190)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 37)
        Label2.TabIndex = 16
        Label2.Text = "Liste"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label4.Location = New System.Drawing.Point(456, 326)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(50, 20)
        Label4.TabIndex = 17
        Label4.Text = "Clients"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label5.Location = New System.Drawing.Point(438, 502)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(87, 20)
        Label5.TabIndex = 18
        Label5.Text = "Commandes"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.Transparent
        Label8.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.White
        Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label8.Location = New System.Drawing.Point(718, 328)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(59, 20)
        Label8.TabIndex = 19
        Label8.Text = "Produits"
        '
        'barreMenu
        '
        Me.barreMenu.BackColor = System.Drawing.Color.Transparent
        Me.barreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.ProduitsToolStripMenuItem, Me.CommandesToolStripMenuItem})
        Me.barreMenu.Location = New System.Drawing.Point(0, 30)
        Me.barreMenu.Name = "barreMenu"
        Me.barreMenu.Size = New System.Drawing.Size(902, 27)
        Me.barreMenu.TabIndex = 1
        Me.barreMenu.Text = "Menu"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeconnexionToolStripMenuItem, Me.AProposToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'DeconnexionToolStripMenuItem
        '
        Me.DeconnexionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DeconnexionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeconnexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem"
        Me.DeconnexionToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.DeconnexionToolStripMenuItem.Text = "&Deconnexion"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AProposToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AProposToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.AProposToolStripMenuItem.Text = "&A propos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(157, 24)
        Me.ToolStripMenuItem2.Text = "&Quitter"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.ListeToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(62, 23)
        Me.ClientsToolStripMenuItem.Text = "&Clients"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.NouveauToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ListeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ListeToolStripMenuItem.Text = "&Liste"
        '
        'ProduitsToolStripMenuItem
        '
        Me.ProduitsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ProduitsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem1, Me.ListeToolStripMenuItem1, Me.EntréeEnStockToolStripMenuItem, Me.HIstoriqueToolStripMenuItem1})
        Me.ProduitsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ProduitsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ProduitsToolStripMenuItem.Name = "ProduitsToolStripMenuItem"
        Me.ProduitsToolStripMenuItem.Size = New System.Drawing.Size(72, 23)
        Me.ProduitsToolStripMenuItem.Text = "&Produits"
        '
        'NouveauToolStripMenuItem1
        '
        Me.NouveauToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.NouveauToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.NouveauToolStripMenuItem1.Name = "NouveauToolStripMenuItem1"
        Me.NouveauToolStripMenuItem1.Size = New System.Drawing.Size(197, 24)
        Me.NouveauToolStripMenuItem1.Text = "&Nouveau"
        '
        'ListeToolStripMenuItem1
        '
        Me.ListeToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ListeToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ListeToolStripMenuItem1.Name = "ListeToolStripMenuItem1"
        Me.ListeToolStripMenuItem1.Size = New System.Drawing.Size(197, 24)
        Me.ListeToolStripMenuItem1.Text = "&Liste"
        '
        'EntréeEnStockToolStripMenuItem
        '
        Me.EntréeEnStockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.EntréeEnStockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.EntréeEnStockToolStripMenuItem.Name = "EntréeEnStockToolStripMenuItem"
        Me.EntréeEnStockToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.EntréeEnStockToolStripMenuItem.Text = "&Entrée en stock"
        '
        'CommandesToolStripMenuItem
        '
        Me.CommandesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CommandesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleToolStripMenuItem, Me.ListeToolStripMenuItem2})
        Me.CommandesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CommandesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.CommandesToolStripMenuItem.Name = "CommandesToolStripMenuItem"
        Me.CommandesToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.CommandesToolStripMenuItem.Text = "&Commandes"
        '
        'NouvelleToolStripMenuItem
        '
        Me.NouvelleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.NouvelleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.NouvelleToolStripMenuItem.Name = "NouvelleToolStripMenuItem"
        Me.NouvelleToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.NouvelleToolStripMenuItem.Text = "&Nouvelle"
        '
        'ListeToolStripMenuItem2
        '
        Me.ListeToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ListeToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ListeToolStripMenuItem2.Name = "ListeToolStripMenuItem2"
        Me.ListeToolStripMenuItem2.Size = New System.Drawing.Size(152, 24)
        Me.ListeToolStripMenuItem2.Text = "&Liste"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 30)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(631, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 26)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PICOS BILLING"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(279, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 320)
        Me.Panel3.TabIndex = 4
        '
        'lblDateHeure
        '
        Me.lblDateHeure.AutoSize = True
        Me.lblDateHeure.BackColor = System.Drawing.Color.Transparent
        Me.lblDateHeure.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
        Me.lblDateHeure.ForeColor = System.Drawing.Color.White
        Me.lblDateHeure.Location = New System.Drawing.Point(839, 38)
        Me.lblDateHeure.Name = "lblDateHeure"
        Me.lblDateHeure.Size = New System.Drawing.Size(51, 13)
        Me.lblDateHeure.TabIndex = 21
        Me.lblDateHeure.Text = "00/00/00"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(299, 36)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(122, 19)
        Me.lblUser.TabIndex = 22
        Me.lblUser.Text = "Utilisateur connecté"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HIstoriqueToolStripMenuItem1
        '
        Me.HIstoriqueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.HIstoriqueToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.HIstoriqueToolStripMenuItem1.Name = "HIstoriqueToolStripMenuItem1"
        Me.HIstoriqueToolStripMenuItem1.Size = New System.Drawing.Size(197, 24)
        Me.HIstoriqueToolStripMenuItem1.Text = "&Historique du stock"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.White
        Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label6.Location = New System.Drawing.Point(691, 502)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(128, 20)
        Label6.TabIndex = 24
        Label6.Text = "Historique du stock"
        AddHandler Label6.Click, AddressOf Me.Label6_Click
        '
        'btnHisto
        '
        Me.btnHisto.BackColor = System.Drawing.Color.Transparent
        Me.btnHisto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnHisto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnHisto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnHisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHisto.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHisto.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHisto.Image = Global.Picos_Billing.My.Resources.Resources.order_history_125px
        Me.btnHisto.Location = New System.Drawing.Point(685, 374)
        Me.btnHisto.Name = "btnHisto"
        Me.btnHisto.Size = New System.Drawing.Size(125, 125)
        Me.btnHisto.TabIndex = 23
        Me.btnHisto.UseVisualStyleBackColor = False
        '
        'btnProduits
        '
        Me.btnProduits.BackColor = System.Drawing.Color.Transparent
        Me.btnProduits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnProduits.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnProduits.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduits.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduits.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnProduits.Image = Global.Picos_Billing.My.Resources.Resources.product_125px
        Me.btnProduits.Location = New System.Drawing.Point(685, 200)
        Me.btnProduits.Name = "btnProduits"
        Me.btnProduits.Size = New System.Drawing.Size(125, 125)
        Me.btnProduits.TabIndex = 13
        Me.btnProduits.UseVisualStyleBackColor = False
        '
        'btnCmds
        '
        Me.btnCmds.BackColor = System.Drawing.Color.Transparent
        Me.btnCmds.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCmds.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnCmds.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCmds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCmds.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCmds.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCmds.Image = Global.Picos_Billing.My.Resources.Resources.purchase_order_125px
        Me.btnCmds.Location = New System.Drawing.Point(419, 374)
        Me.btnCmds.Name = "btnCmds"
        Me.btnCmds.Size = New System.Drawing.Size(125, 125)
        Me.btnCmds.TabIndex = 14
        Me.btnCmds.UseVisualStyleBackColor = False
        '
        'btnClients
        '
        Me.btnClients.BackColor = System.Drawing.Color.Transparent
        Me.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClients.Image = Global.Picos_Billing.My.Resources.Resources.commercial_development_management_125px
        Me.btnClients.Location = New System.Drawing.Point(419, 200)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(125, 125)
        Me.btnClients.TabIndex = 12
        Me.btnClients.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Picos_Billing.My.Resources.Resources.logout_rounded_15px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(784, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Deconnexion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnNFacs
        '
        Me.btnNFacs.BackColor = System.Drawing.Color.Transparent
        Me.btnNFacs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNFacs.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNFacs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNFacs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNFacs.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnNFacs.ForeColor = System.Drawing.Color.White
        Me.btnNFacs.Image = Global.Picos_Billing.My.Resources.Resources.check_20px
        Me.btnNFacs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNFacs.Location = New System.Drawing.Point(98, 385)
        Me.btnNFacs.Name = "btnNFacs"
        Me.btnNFacs.Size = New System.Drawing.Size(180, 39)
        Me.btnNFacs.TabIndex = 10
        Me.btnNFacs.Text = "Entrée en stock"
        Me.btnNFacs.UseVisualStyleBackColor = False
        '
        'btnNCmds
        '
        Me.btnNCmds.BackColor = System.Drawing.Color.Transparent
        Me.btnNCmds.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNCmds.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNCmds.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNCmds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNCmds.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnNCmds.ForeColor = System.Drawing.Color.White
        Me.btnNCmds.Image = Global.Picos_Billing.My.Resources.Resources.purchase_order_20px
        Me.btnNCmds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNCmds.Location = New System.Drawing.Point(98, 340)
        Me.btnNCmds.Name = "btnNCmds"
        Me.btnNCmds.Size = New System.Drawing.Size(180, 39)
        Me.btnNCmds.TabIndex = 9
        Me.btnNCmds.Text = " Commandes"
        Me.btnNCmds.UseVisualStyleBackColor = False
        '
        'btnNProduits
        '
        Me.btnNProduits.BackColor = System.Drawing.Color.Transparent
        Me.btnNProduits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNProduits.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNProduits.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNProduits.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnNProduits.ForeColor = System.Drawing.Color.White
        Me.btnNProduits.Image = Global.Picos_Billing.My.Resources.Resources.product_20px
        Me.btnNProduits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNProduits.Location = New System.Drawing.Point(98, 295)
        Me.btnNProduits.Name = "btnNProduits"
        Me.btnNProduits.Size = New System.Drawing.Size(180, 39)
        Me.btnNProduits.TabIndex = 8
        Me.btnNProduits.Text = "Produits"
        Me.btnNProduits.UseVisualStyleBackColor = False
        '
        'btnNClients
        '
        Me.btnNClients.BackColor = System.Drawing.Color.Transparent
        Me.btnNClients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnNClients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNClients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNClients.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.btnNClients.ForeColor = System.Drawing.Color.White
        Me.btnNClients.Image = Global.Picos_Billing.My.Resources.Resources.commercial_development_management_20px
        Me.btnNClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNClients.Location = New System.Drawing.Point(98, 250)
        Me.btnNClients.Name = "btnNClients"
        Me.btnNClients.Size = New System.Drawing.Size(180, 39)
        Me.btnNClients.TabIndex = 6
        Me.btnNClients.Text = "Clients"
        Me.btnNClients.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(246, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px2
        Me.PictureBox1.Location = New System.Drawing.Point(223, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'fMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 629)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.btnHisto)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblDateHeure)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.btnProduits)
        Me.Controls.Add(Me.btnCmds)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNFacs)
        Me.Controls.Add(Me.btnNCmds)
        Me.Controls.Add(Me.btnNProduits)
        Me.Controls.Add(labelNew)
        Me.Controls.Add(Me.btnNClients)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barreMenu)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.barreMenu.ResumeLayout(False)
        Me.barreMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProduitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommandesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnNClients As System.Windows.Forms.Button
    Friend WithEvents btnNProduits As System.Windows.Forms.Button
    Friend WithEvents btnNCmds As System.Windows.Forms.Button
    Friend WithEvents btnNFacs As System.Windows.Forms.Button
    Friend WithEvents ListeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClients As System.Windows.Forms.Button
    Friend WithEvents btnCmds As System.Windows.Forms.Button
    Friend WithEvents btnProduits As System.Windows.Forms.Button
    Friend WithEvents lblDateHeure As System.Windows.Forms.Label
    Friend WithEvents ClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntréeEnStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents HIstoriqueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHisto As System.Windows.Forms.Button
End Class
