<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fListeCmd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fListeCmd))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumcmdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecmdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontantcmdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.details = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CommandesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Cmds = New Picos_Billing.cmds()
        Me.FacturationD = New Picos_Billing.facturationD()
        Me.FacturationDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.CommandesTableAdapter = New Picos_Billing.cmdsTableAdapters.commandesTableAdapter()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxQte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxPrix = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxDesignation = New System.Windows.Forms.TextBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblDesi = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.lblQte = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Cmds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label3.Location = New System.Drawing.Point(5, 6)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(260, 21)
        Label3.TabIndex = 7
        Label3.Text = "Liste des commandes - Picos  Billing"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 35)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(528, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 30)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(119, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px2
        Me.PictureBox1.Location = New System.Drawing.Point(92, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "GESTION DES COMMANDES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumcmdDataGridViewTextBoxColumn, Me.NumcltDataGridViewTextBoxColumn, Me.DatecmdDataGridViewTextBoxColumn, Me.MontantcmdDataGridViewTextBoxColumn, Me.details})
        Me.DataGridView1.DataSource = Me.CommandesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(46, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(574, 173)
        Me.DataGridView1.TabIndex = 11
        '
        'NumcmdDataGridViewTextBoxColumn
        '
        Me.NumcmdDataGridViewTextBoxColumn.DataPropertyName = "num_cmd"
        Me.NumcmdDataGridViewTextBoxColumn.HeaderText = "Numéro"
        Me.NumcmdDataGridViewTextBoxColumn.Name = "NumcmdDataGridViewTextBoxColumn"
        Me.NumcmdDataGridViewTextBoxColumn.Width = 70
        '
        'NumcltDataGridViewTextBoxColumn
        '
        Me.NumcltDataGridViewTextBoxColumn.DataPropertyName = "num_clt"
        Me.NumcltDataGridViewTextBoxColumn.HeaderText = "Numéro du client"
        Me.NumcltDataGridViewTextBoxColumn.Name = "NumcltDataGridViewTextBoxColumn"
        Me.NumcltDataGridViewTextBoxColumn.Width = 130
        '
        'DatecmdDataGridViewTextBoxColumn
        '
        Me.DatecmdDataGridViewTextBoxColumn.DataPropertyName = "date_cmd"
        Me.DatecmdDataGridViewTextBoxColumn.HeaderText = "Date "
        Me.DatecmdDataGridViewTextBoxColumn.Name = "DatecmdDataGridViewTextBoxColumn"
        Me.DatecmdDataGridViewTextBoxColumn.Width = 110
        '
        'MontantcmdDataGridViewTextBoxColumn
        '
        Me.MontantcmdDataGridViewTextBoxColumn.DataPropertyName = "montant_cmd"
        Me.MontantcmdDataGridViewTextBoxColumn.HeaderText = "Montant "
        Me.MontantcmdDataGridViewTextBoxColumn.Name = "MontantcmdDataGridViewTextBoxColumn"
        Me.MontantcmdDataGridViewTextBoxColumn.Width = 120
        '
        'details
        '
        Me.details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.details.HeaderText = "Détails"
        Me.details.Name = "details"
        Me.details.Text = "Détails"
        Me.details.UseColumnTextForButtonValue = True
        '
        'CommandesBindingSource
        '
        'Me.CommandesBindingSource.DataMember = "commandes"
        'Me.CommandesBindingSource.DataSource = Me.Cmds
        '
        'Cmds
        '
        'Me.Cmds.DataSetName = "cmds"
        'Me.Cmds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturationD
        '
        Me.FacturationD.DataSetName = "facturationD"
        Me.FacturationD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturationDBindingSource
        '
        Me.FacturationDBindingSource.DataSource = Me.FacturationD
        Me.FacturationDBindingSource.Position = 0
        '
        'CommandesTableAdapter
        '
        'Me.CommandesTableAdapter.ClearBeforeFill = True
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(568, 98)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(52, 22)
        Me.boxNum.TabIndex = 48
        Me.boxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxNum.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Nom et Prénoms"
        '
        'boxUser
        '
        Me.boxUser.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxUser.Enabled = False
        Me.boxUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxUser.ForeColor = System.Drawing.Color.White
        Me.boxUser.Location = New System.Drawing.Point(45, 348)
        Me.boxUser.Name = "boxUser"
        Me.boxUser.Size = New System.Drawing.Size(575, 22)
        Me.boxUser.TabIndex = 46
        Me.boxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Quantités commandées"
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQte.Enabled = False
        Me.boxQte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxQte.ForeColor = System.Drawing.Color.White
        Me.boxQte.Location = New System.Drawing.Point(45, 450)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.Size = New System.Drawing.Size(575, 22)
        Me.boxQte.TabIndex = 43
        Me.boxQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 481)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Prix Unitaires"
        '
        'boxPrix
        '
        Me.boxPrix.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrix.Enabled = False
        Me.boxPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPrix.ForeColor = System.Drawing.Color.White
        Me.boxPrix.Location = New System.Drawing.Point(45, 501)
        Me.boxPrix.Name = "boxPrix"
        Me.boxPrix.Size = New System.Drawing.Size(575, 22)
        Me.boxPrix.TabIndex = 42
        Me.boxPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Désignations"
        '
        'boxDesignation
        '
        Me.boxDesignation.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxDesignation.Enabled = False
        Me.boxDesignation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxDesignation.ForeColor = System.Drawing.Color.White
        Me.boxDesignation.Location = New System.Drawing.Point(45, 399)
        Me.boxDesignation.Name = "boxDesignation"
        Me.boxDesignation.Size = New System.Drawing.Size(575, 22)
        Me.boxDesignation.TabIndex = 49
        Me.boxDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblClient.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblClient.ForeColor = System.Drawing.Color.White
        Me.lblClient.Location = New System.Drawing.Point(48, 348)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(113, 19)
        Me.lblClient.TabIndex = 52
        Me.lblClient.Text = "Nom et Prénoms"
        '
        'lblDesi
        '
        Me.lblDesi.AutoSize = True
        Me.lblDesi.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblDesi.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblDesi.ForeColor = System.Drawing.Color.White
        Me.lblDesi.Location = New System.Drawing.Point(48, 399)
        Me.lblDesi.Name = "lblDesi"
        Me.lblDesi.Size = New System.Drawing.Size(82, 19)
        Me.lblDesi.TabIndex = 53
        Me.lblDesi.Text = "Désignation"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPrix.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblPrix.ForeColor = System.Drawing.Color.White
        Me.lblPrix.Location = New System.Drawing.Point(48, 503)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(83, 19)
        Me.lblPrix.TabIndex = 54
        Me.lblPrix.Text = "Prix Unitaire"
        '
        'lblQte
        '
        Me.lblQte.AutoSize = True
        Me.lblQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblQte.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblQte.ForeColor = System.Drawing.Color.White
        Me.lblQte.Location = New System.Drawing.Point(48, 450)
        Me.lblQte.Name = "lblQte"
        Me.lblQte.Size = New System.Drawing.Size(63, 19)
        Me.lblQte.TabIndex = 55
        Me.lblQte.Text = "Quantité"
        '
        'fListeCmd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(673, 550)
        Me.Controls.Add(Me.lblQte)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.lblDesi)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxDesignation)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxQte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxPrix)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fListeCmd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des commandes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Cmds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FacturationD As Picos_Billing.facturationD
    Friend WithEvents FacturationDBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents Cmds As Picos_Billing.cmds
    Friend WithEvents CommandesBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents CommandesTableAdapter As Picos_Billing.cmdsTableAdapters.commandesTableAdapter
    Friend WithEvents NumcmdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatecmdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontantcmdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents details As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxQte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents boxDesignation As System.Windows.Forms.TextBox
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblDesi As System.Windows.Forms.Label
    Friend WithEvents lblPrix As System.Windows.Forms.Label
    Friend WithEvents lblQte As System.Windows.Forms.Label
End Class
