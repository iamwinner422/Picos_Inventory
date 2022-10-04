<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fUtilisateur
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
        Me.components = New System.ComponentModel.Container()
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fUtilisateur))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumuserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginuserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassuserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modifier = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UtilisateursBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Users = New Picos_Billing.users()
        Me.UtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Utilisateurs = New Picos_Billing.utilisateurs()
        Me.UtilisateurTableAdapter = New Picos_Billing.utilisateursTableAdapters.utilisateurTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UtilisateursTableAdapter = New Picos_Billing.usersTableAdapters.utilisateursTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxPassAdmin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxPassword = New System.Windows.Forms.TextBox()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.barreMenu = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Actualiser = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Utilisateurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barreMenu.SuspendLayout()
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
        Label3.Location = New System.Drawing.Point(3, 6)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(189, 21)
        Label3.TabIndex = 7
        Label3.Text = "Utilisateurs - Picos  Billing"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 33)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(456, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(101, 31)
        Me.Panel2.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumuserDataGridViewTextBoxColumn, Me.LoginuserDataGridViewTextBoxColumn, Me.PassuserDataGridViewTextBoxColumn, Me.modifier})
        Me.DataGridView1.DataSource = Me.UtilisateursBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(483, 212)
        Me.DataGridView1.TabIndex = 5
        '
        'NumuserDataGridViewTextBoxColumn
        '
        Me.NumuserDataGridViewTextBoxColumn.DataPropertyName = "num_user"
        Me.NumuserDataGridViewTextBoxColumn.Frozen = True
        Me.NumuserDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumuserDataGridViewTextBoxColumn.Name = "NumuserDataGridViewTextBoxColumn"
        '
        'LoginuserDataGridViewTextBoxColumn
        '
        Me.LoginuserDataGridViewTextBoxColumn.DataPropertyName = "login_user"
        Me.LoginuserDataGridViewTextBoxColumn.Frozen = True
        Me.LoginuserDataGridViewTextBoxColumn.HeaderText = "Nom d'utilisateur"
        Me.LoginuserDataGridViewTextBoxColumn.Name = "LoginuserDataGridViewTextBoxColumn"
        Me.LoginuserDataGridViewTextBoxColumn.Width = 220
        '
        'PassuserDataGridViewTextBoxColumn
        '
        Me.PassuserDataGridViewTextBoxColumn.DataPropertyName = "pass_user"
        Me.PassuserDataGridViewTextBoxColumn.HeaderText = "Mot de passe"
        Me.PassuserDataGridViewTextBoxColumn.Name = "PassuserDataGridViewTextBoxColumn"
        Me.PassuserDataGridViewTextBoxColumn.Visible = False
        Me.PassuserDataGridViewTextBoxColumn.Width = 180
        '
        'modifier
        '
        Me.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier.HeaderText = "Modifier"
        Me.modifier.Name = "modifier"
        Me.modifier.Text = "Modifier"
        Me.modifier.UseColumnTextForButtonValue = True
        Me.modifier.Width = 120
        '
        'UtilisateursBindingSource
        '
        Me.UtilisateursBindingSource.DataMember = "utilisateurs"
        Me.UtilisateursBindingSource.DataSource = Me.Users
        '
        'Users
        '
        Me.Users.DataSetName = "users"
        Me.Users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilisateurBindingSource
        '
        Me.UtilisateurBindingSource.DataMember = "utilisateur"
        Me.UtilisateurBindingSource.DataSource = Me.Utilisateurs
        '
        'Utilisateurs
        '
        Me.Utilisateurs.DataSetName = "utilisateurs"
        Me.Utilisateurs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilisateurTableAdapter
        '
        Me.UtilisateurTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "GESTION DES UTILISATEURS"
        '
        'UtilisateursTableAdapter
        '
        Me.UtilisateursTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(27, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Nom d'utilisateur"
        '
        'boxUser
        '
        Me.boxUser.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxUser.ForeColor = System.Drawing.Color.White
        Me.boxUser.Location = New System.Drawing.Point(31, 387)
        Me.boxUser.Name = "boxUser"
        Me.boxUser.Size = New System.Drawing.Size(235, 22)
        Me.boxUser.TabIndex = 40
        Me.boxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Mot de passe Admin"
        '
        'boxPassAdmin
        '
        Me.boxPassAdmin.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPassAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPassAdmin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPassAdmin.ForeColor = System.Drawing.Color.White
        Me.boxPassAdmin.Location = New System.Drawing.Point(31, 445)
        Me.boxPassAdmin.Name = "boxPassAdmin"
        Me.boxPassAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.boxPassAdmin.Size = New System.Drawing.Size(235, 22)
        Me.boxPassAdmin.TabIndex = 37
        Me.boxPassAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPassAdmin.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(279, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Mot de passe"
        '
        'boxPassword
        '
        Me.boxPassword.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPassword.ForeColor = System.Drawing.Color.White
        Me.boxPassword.Location = New System.Drawing.Point(283, 387)
        Me.boxPassword.Name = "boxPassword"
        Me.boxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.boxPassword.Size = New System.Drawing.Size(235, 22)
        Me.boxPassword.TabIndex = 36
        Me.boxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPassword.UseSystemPasswordChar = True
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(466, 413)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(52, 22)
        Me.boxNum.TabIndex = 42
        Me.boxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxNum.Visible = False
        '
        'btnSuppr
        '
        Me.btnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppr.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnSuppr.ForeColor = System.Drawing.Color.White
        Me.btnSuppr.Image = Global.Picos_Billing.My.Resources.Resources.cancel_17px
        Me.btnSuppr.Location = New System.Drawing.Point(376, 437)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(99, 30)
        Me.btnSuppr.TabIndex = 44
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSuppr.UseVisualStyleBackColor = True
        '
        'barreMenu
        '
        Me.barreMenu.BackColor = System.Drawing.Color.Transparent
        Me.barreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.barreMenu.Location = New System.Drawing.Point(0, 33)
        Me.barreMenu.Name = "barreMenu"
        Me.barreMenu.Size = New System.Drawing.Size(558, 27)
        Me.barreMenu.TabIndex = 45
        Me.barreMenu.Text = "Menu"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UtilisateursToolStripMenuItem, Me.DeconnexionToolStripMenuItem, Me.AProposToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.FichierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FichierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(60, 23)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(187, 24)
        Me.ToolStripMenuItem1.Text = "&Ouvrir le Menu"
        '
        'UtilisateursToolStripMenuItem
        '
        Me.UtilisateursToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.UtilisateursToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UtilisateursToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.UtilisateursToolStripMenuItem.Name = "UtilisateursToolStripMenuItem"
        Me.UtilisateursToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.UtilisateursToolStripMenuItem.Text = "&Nouvel Utilisateur"
        '
        'DeconnexionToolStripMenuItem
        '
        Me.DeconnexionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DeconnexionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeconnexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem"
        Me.DeconnexionToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.DeconnexionToolStripMenuItem.Text = "&Deconnexion"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AProposToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AProposToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.AProposToolStripMenuItem.Text = "&A propos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 24)
        Me.ToolStripMenuItem2.Text = "&Quitter"
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.White
        Me.boxSearch.Location = New System.Drawing.Point(103, 130)
        Me.boxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(298, 18)
        Me.boxSearch.TabIndex = 47
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(106, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Recherche"
        '
        'btn_Actualiser
        '
        Me.btn_Actualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Actualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Actualiser.Image = Global.Picos_Billing.My.Resources.Resources.restart_15px
        Me.btn_Actualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualiser.Location = New System.Drawing.Point(407, 124)
        Me.btn_Actualiser.Name = "btn_Actualiser"
        Me.btn_Actualiser.Size = New System.Drawing.Size(111, 24)
        Me.btn_Actualiser.TabIndex = 46
        Me.btn_Actualiser.Text = "Actualiser"
        Me.btn_Actualiser.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.Color.White
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnModifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnModifier.Image = Global.Picos_Billing.My.Resources.Resources.edit_account_17px1
        Me.btnModifier.Location = New System.Drawing.Point(283, 436)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(87, 31)
        Me.btnModifier.TabIndex = 43
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(70, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px2
        Me.PictureBox1.Location = New System.Drawing.Point(45, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'fUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 479)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.btn_Actualiser)
        Me.Controls.Add(Me.barreMenu)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxPassAdmin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fUtilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utilisateurs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateursBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Utilisateurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barreMenu.ResumeLayout(False)
        Me.barreMenu.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Utilisateurs As Picos_Billing.utilisateurs
    Friend WithEvents UtilisateurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilisateurTableAdapter As Picos_Billing.utilisateursTableAdapters.utilisateurTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Users As Picos_Billing.users
    Friend WithEvents UtilisateursBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilisateursTableAdapter As Picos_Billing.usersTableAdapters.utilisateursTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxPassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxPassword As System.Windows.Forms.TextBox
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents barreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Actualiser As System.Windows.Forms.Button
    Friend WithEvents NumuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoginuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modifier As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
