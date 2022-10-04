<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAjoutCommande
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAjoutCommande))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrenoms = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxPrenoms = New System.Windows.Forms.TextBox()
        Me.numClt = New System.Windows.Forms.ComboBox()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfosClients = New Picos_Billing.infosClients()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.boxTotalCmd = New System.Windows.Forms.TextBox()
        Me.btnAjout = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boxQteCmdee = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.lblQte = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxPU = New System.Windows.Forms.TextBox()
        Me.boxQte = New System.Windows.Forms.TextBox()
        Me.CodeArticle = New System.Windows.Forms.ComboBox()
        Me.ProduitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfosProduits = New Picos_Billing.infosProduits()
        Me.ClientsTableAdapter = New Picos_Billing.infosClientsTableAdapters.clientsTableAdapter()
        Me.ProduitsTableAdapter = New Picos_Billing.infosProduitsTableAdapters.produitsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixunitaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailstempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturationDataSet2 = New Picos_Billing.facturationDataSet2()
        Me.Details_tempTableAdapter = New Picos_Billing.facturationDataSet2TableAdapters.details_tempTableAdapter()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfosClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfosProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailstempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label7.Location = New System.Drawing.Point(3, 3)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(154, 21)
        Label7.TabIndex = 8
        Label7.Text = "Nouvelle commande"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 27)
        Me.Panel1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(284, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(453, 26)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(169, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "AJOUT D'UNE COMMANDE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrenoms)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.boxPrenoms)
        Me.GroupBox1.Controls.Add(Me.numClt)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(41, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 88)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations sur le client"
        '
        'lblPrenoms
        '
        Me.lblPrenoms.AutoSize = True
        Me.lblPrenoms.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPrenoms.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblPrenoms.ForeColor = System.Drawing.Color.White
        Me.lblPrenoms.Location = New System.Drawing.Point(343, 41)
        Me.lblPrenoms.Name = "lblPrenoms"
        Me.lblPrenoms.Size = New System.Drawing.Size(71, 19)
        Me.lblPrenoms.TabIndex = 23
        Me.lblPrenoms.Text = "Prénom(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(336, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Prénom(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nom"
        '
        'boxPrenoms
        '
        Me.boxPrenoms.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrenoms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrenoms.Enabled = False
        Me.boxPrenoms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxPrenoms.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxPrenoms.Location = New System.Drawing.Point(340, 40)
        Me.boxPrenoms.Name = "boxPrenoms"
        Me.boxPrenoms.Size = New System.Drawing.Size(293, 22)
        Me.boxPrenoms.TabIndex = 2
        '
        'numClt
        '
        Me.numClt.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.numClt.DataSource = Me.ClientsBindingSource
        Me.numClt.DisplayMember = "num_clt"
        Me.numClt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.numClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.numClt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.numClt.FormattingEnabled = True
        Me.numClt.Location = New System.Drawing.Point(18, 37)
        Me.numClt.Name = "numClt"
        Me.numClt.Size = New System.Drawing.Size(302, 25)
        Me.numClt.TabIndex = 0
        Me.numClt.ValueMember = "num_clt"
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.InfosClients
        '
        'InfosClients
        '
        Me.InfosClients.DataSetName = "infosClients"
        Me.InfosClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.boxTotalCmd)
        Me.GroupBox2.Controls.Add(Me.btnAjout)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.boxQteCmdee)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(41, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 195)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informations sur la commande"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(463, 151)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(17, 19)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(456, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Total de la commande"
        '
        'boxTotalCmd
        '
        Me.boxTotalCmd.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxTotalCmd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxTotalCmd.Enabled = False
        Me.boxTotalCmd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxTotalCmd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxTotalCmd.Location = New System.Drawing.Point(460, 151)
        Me.boxTotalCmd.Name = "boxTotalCmd"
        Me.boxTotalCmd.Size = New System.Drawing.Size(147, 22)
        Me.boxTotalCmd.TabIndex = 22
        '
        'btnAjout
        '
        Me.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjout.Location = New System.Drawing.Point(233, 139)
        Me.btnAjout.Name = "btnAjout"
        Me.btnAjout.Size = New System.Drawing.Size(166, 37)
        Me.btnAjout.TabIndex = 21
        Me.btnAjout.Text = "Ajouter à la commande"
        Me.btnAjout.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(32, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Quatité commande"
        '
        'boxQteCmdee
        '
        Me.boxQteCmdee.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQteCmdee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQteCmdee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxQteCmdee.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxQteCmdee.Location = New System.Drawing.Point(34, 151)
        Me.boxQteCmdee.Name = "boxQteCmdee"
        Me.boxQteCmdee.Size = New System.Drawing.Size(124, 22)
        Me.boxQteCmdee.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPrix)
        Me.GroupBox3.Controls.Add(Me.lblQte)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.boxPU)
        Me.GroupBox3.Controls.Add(Me.boxQte)
        Me.GroupBox3.Controls.Add(Me.CodeArticle)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(18, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 101)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ajout du produit"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPrix.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblPrix.ForeColor = System.Drawing.Color.White
        Me.lblPrix.Location = New System.Drawing.Point(481, 49)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(31, 19)
        Me.lblPrix.TabIndex = 25
        Me.lblPrix.Text = "Prix"
        '
        'lblQte
        '
        Me.lblQte.AutoSize = True
        Me.lblQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblQte.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblQte.ForeColor = System.Drawing.Color.White
        Me.lblQte.Location = New System.Drawing.Point(365, 49)
        Me.lblQte.Name = "lblQte"
        Me.lblQte.Size = New System.Drawing.Size(63, 19)
        Me.lblQte.TabIndex = 23
        Me.lblQte.Text = "Quantité"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(474, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Prix Unitaire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(358, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantité"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Numéro"
        '
        'boxPU
        '
        Me.boxPU.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPU.Enabled = False
        Me.boxPU.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxPU.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxPU.Location = New System.Drawing.Point(478, 49)
        Me.boxPU.Name = "boxPU"
        Me.boxPU.Size = New System.Drawing.Size(111, 22)
        Me.boxPU.TabIndex = 3
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQte.Enabled = False
        Me.boxQte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxQte.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxQte.Location = New System.Drawing.Point(362, 49)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.Size = New System.Drawing.Size(99, 22)
        Me.boxQte.TabIndex = 2
        '
        'CodeArticle
        '
        Me.CodeArticle.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CodeArticle.DataSource = Me.ProduitsBindingSource
        Me.CodeArticle.DisplayMember = "num_prod"
        Me.CodeArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodeArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CodeArticle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CodeArticle.FormattingEnabled = True
        Me.CodeArticle.Location = New System.Drawing.Point(18, 49)
        Me.CodeArticle.Name = "CodeArticle"
        Me.CodeArticle.Size = New System.Drawing.Size(322, 25)
        Me.CodeArticle.TabIndex = 0
        Me.CodeArticle.ValueMember = "num_prod"
        '
        'ProduitsBindingSource
        '
        Me.ProduitsBindingSource.DataMember = "produits"
        Me.ProduitsBindingSource.DataSource = Me.InfosProduits
        '
        'InfosProduits
        '
        Me.InfosProduits.DataSetName = "infosProduits"
        Me.InfosProduits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'ProduitsTableAdapter
        '
        Me.ProduitsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumprodDataGridViewTextBoxColumn, Me.DesignationprodDataGridViewTextBoxColumn, Me.QteprodDataGridViewTextBoxColumn, Me.PrixunitaireDataGridViewTextBoxColumn, Me.PrixtotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetailstempBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 384)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(658, 143)
        Me.DataGridView1.TabIndex = 23
        '
        'NumprodDataGridViewTextBoxColumn
        '
        Me.NumprodDataGridViewTextBoxColumn.DataPropertyName = "num_prod"
        Me.NumprodDataGridViewTextBoxColumn.HeaderText = "Num. Produit"
        Me.NumprodDataGridViewTextBoxColumn.Name = "NumprodDataGridViewTextBoxColumn"
        Me.NumprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumprodDataGridViewTextBoxColumn.Width = 75
        '
        'DesignationprodDataGridViewTextBoxColumn
        '
        Me.DesignationprodDataGridViewTextBoxColumn.DataPropertyName = "designation_prod"
        Me.DesignationprodDataGridViewTextBoxColumn.HeaderText = "Désignation"
        Me.DesignationprodDataGridViewTextBoxColumn.Name = "DesignationprodDataGridViewTextBoxColumn"
        Me.DesignationprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationprodDataGridViewTextBoxColumn.Width = 260
        '
        'QteprodDataGridViewTextBoxColumn
        '
        Me.QteprodDataGridViewTextBoxColumn.DataPropertyName = "qte_prod"
        Me.QteprodDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QteprodDataGridViewTextBoxColumn.Name = "QteprodDataGridViewTextBoxColumn"
        Me.QteprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.QteprodDataGridViewTextBoxColumn.Width = 60
        '
        'PrixunitaireDataGridViewTextBoxColumn
        '
        Me.PrixunitaireDataGridViewTextBoxColumn.DataPropertyName = "prix_unitaire"
        Me.PrixunitaireDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixunitaireDataGridViewTextBoxColumn.Name = "PrixunitaireDataGridViewTextBoxColumn"
        Me.PrixunitaireDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrixtotalDataGridViewTextBoxColumn
        '
        Me.PrixtotalDataGridViewTextBoxColumn.DataPropertyName = "prix_total"
        Me.PrixtotalDataGridViewTextBoxColumn.HeaderText = "Prix total"
        Me.PrixtotalDataGridViewTextBoxColumn.Name = "PrixtotalDataGridViewTextBoxColumn"
        Me.PrixtotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrixtotalDataGridViewTextBoxColumn.Width = 120
        '
        'DetailstempBindingSource
        '
        Me.DetailstempBindingSource.DataMember = "details_temp"
        Me.DetailstempBindingSource.DataSource = Me.FacturationDataSet2
        '
        'FacturationDataSet2
        '
        Me.FacturationDataSet2.DataSetName = "facturationDataSet2"
        Me.FacturationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Details_tempTableAdapter
        '
        Me.Details_tempTableAdapter.ClearBeforeFill = True
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.White
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnValider.Image = Global.Picos_Billing.My.Resources.Resources.ok_17px
        Me.btnValider.Location = New System.Drawing.Point(544, 533)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(155, 37)
        Me.btnValider.TabIndex = 22
        Me.btnValider.Text = "Valider la commande"
        Me.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(432, 6)
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
        Me.PictureBox1.Location = New System.Drawing.Point(409, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'fAjoutCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 576)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fAjoutCommande"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouvelle commande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfosClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfosProduits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailstempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents boxPrenoms As System.Windows.Forms.TextBox
    Friend WithEvents numClt As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents boxQte As System.Windows.Forms.TextBox
    Friend WithEvents CodeArticle As System.Windows.Forms.ComboBox
    Friend WithEvents boxQteCmdee As System.Windows.Forms.TextBox
    Friend WithEvents boxPU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAjout As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents boxTotalCmd As System.Windows.Forms.TextBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents InfosClients As Picos_Billing.infosClients
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As Picos_Billing.infosClientsTableAdapters.clientsTableAdapter
    Friend WithEvents lblPrenoms As System.Windows.Forms.Label
    Friend WithEvents lblQte As System.Windows.Forms.Label
    Friend WithEvents lblPrix As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents InfosProduits As Picos_Billing.infosProduits
    Friend WithEvents ProduitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduitsTableAdapter As Picos_Billing.infosProduitsTableAdapters.produitsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FacturationDataSet2 As Picos_Billing.facturationDataSet2
    Friend WithEvents DetailstempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Details_tempTableAdapter As Picos_Billing.facturationDataSet2TableAdapters.details_tempTableAdapter
    Friend WithEvents NumprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QteprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixunitaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents FacturationDataSet As Picos_Billing.facturationDataSet
    'Friend WithEvents ClientBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents ClientTableAdapter As Picos_Billing.facturationDataSetTableAdapters.clientTableAdapter
End Class
