<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flisteProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(flisteProd))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixunitaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modif = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProduitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturationDataSet1 = New Picos_Billing.facturationDataSet1()
        Me.ProduitsTableAdapter = New Picos_Billing.facturationDataSet1TableAdapters.produitsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxQte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxPrix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxDesignation = New System.Windows.Forms.TextBox()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.btn_Actualiser = New System.Windows.Forms.Button()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label3.Location = New System.Drawing.Point(6, 7)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(169, 21)
        Label3.TabIndex = 7
        Label3.Text = "Produits - Picos  Billing"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 36)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(575, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 34)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(103, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px2
        Me.PictureBox1.Location = New System.Drawing.Point(77, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 19)
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
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 46)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "GESTION DES PRODUITS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumprodDataGridViewTextBoxColumn, Me.DesignationprodDataGridViewTextBoxColumn, Me.PrixunitaireDataGridViewTextBoxColumn, Me.QteprodDataGridViewTextBoxColumn, Me.modif})
        Me.DataGridView1.DataSource = Me.ProduitsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 150)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(664, 158)
        Me.DataGridView1.TabIndex = 10
        '
        'NumprodDataGridViewTextBoxColumn
        '
        Me.NumprodDataGridViewTextBoxColumn.DataPropertyName = "num_prod"
        Me.NumprodDataGridViewTextBoxColumn.HeaderText = "Num."
        Me.NumprodDataGridViewTextBoxColumn.Name = "NumprodDataGridViewTextBoxColumn"
        Me.NumprodDataGridViewTextBoxColumn.Width = 50
        '
        'DesignationprodDataGridViewTextBoxColumn
        '
        Me.DesignationprodDataGridViewTextBoxColumn.DataPropertyName = "designation_prod"
        Me.DesignationprodDataGridViewTextBoxColumn.HeaderText = "Désignation"
        Me.DesignationprodDataGridViewTextBoxColumn.Name = "DesignationprodDataGridViewTextBoxColumn"
        Me.DesignationprodDataGridViewTextBoxColumn.Width = 250
        '
        'PrixunitaireDataGridViewTextBoxColumn
        '
        Me.PrixunitaireDataGridViewTextBoxColumn.DataPropertyName = "prix_unitaire"
        Me.PrixunitaireDataGridViewTextBoxColumn.HeaderText = "Prix Unitaire"
        Me.PrixunitaireDataGridViewTextBoxColumn.Name = "PrixunitaireDataGridViewTextBoxColumn"
        Me.PrixunitaireDataGridViewTextBoxColumn.Width = 120
        '
        'QteprodDataGridViewTextBoxColumn
        '
        Me.QteprodDataGridViewTextBoxColumn.DataPropertyName = "qte_prod"
        Me.QteprodDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QteprodDataGridViewTextBoxColumn.Name = "QteprodDataGridViewTextBoxColumn"
        '
        'modif
        '
        Me.modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modif.HeaderText = "Opération"
        Me.modif.Name = "modif"
        Me.modif.Text = "Modifer"
        Me.modif.UseColumnTextForButtonValue = True
        '
        'ProduitsBindingSource
        '
        Me.ProduitsBindingSource.DataMember = "produits"
        Me.ProduitsBindingSource.DataSource = Me.FacturationDataSet1
        '
        'FacturationDataSet1
        '
        Me.FacturationDataSet1.DataSetName = "facturationDataSet1"
        Me.FacturationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduitsTableAdapter
        '
        Me.ProduitsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Quantité"
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxQte.ForeColor = System.Drawing.Color.White
        Me.boxQte.Location = New System.Drawing.Point(26, 407)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.Size = New System.Drawing.Size(281, 22)
        Me.boxQte.TabIndex = 31
        Me.boxQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(352, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Prix Unitaire"
        '
        'boxPrix
        '
        Me.boxPrix.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPrix.ForeColor = System.Drawing.Color.White
        Me.boxPrix.Location = New System.Drawing.Point(356, 347)
        Me.boxPrix.Name = "boxPrix"
        Me.boxPrix.Size = New System.Drawing.Size(281, 22)
        Me.boxPrix.TabIndex = 30
        Me.boxPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Désignation"
        '
        'boxDesignation
        '
        Me.boxDesignation.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxDesignation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxDesignation.ForeColor = System.Drawing.Color.White
        Me.boxDesignation.Location = New System.Drawing.Point(26, 348)
        Me.boxDesignation.Name = "boxDesignation"
        Me.boxDesignation.Size = New System.Drawing.Size(281, 22)
        Me.boxDesignation.TabIndex = 34
        Me.boxDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModifier
        '
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(356, 398)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(87, 31)
        Me.btnModifier.TabIndex = 36
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSuppr
        '
        Me.btnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppr.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnSuppr.ForeColor = System.Drawing.Color.White
        Me.btnSuppr.Location = New System.Drawing.Point(472, 398)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(87, 31)
        Me.btnSuppr.TabIndex = 37
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = True
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.White
        Me.boxSearch.Location = New System.Drawing.Point(290, 124)
        Me.boxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(298, 18)
        Me.boxSearch.TabIndex = 39
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(291, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Recherche"
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(565, 402)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(52, 22)
        Me.boxNum.TabIndex = 41
        Me.boxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxNum.Visible = False
        '
        'btn_Actualiser
        '
        Me.btn_Actualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btn_Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Actualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Actualiser.Image = Global.Picos_Billing.My.Resources.Resources.restart_15px
        Me.btn_Actualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Actualiser.Location = New System.Drawing.Point(591, 119)
        Me.btn_Actualiser.Name = "btn_Actualiser"
        Me.btn_Actualiser.Size = New System.Drawing.Size(97, 24)
        Me.btn_Actualiser.TabIndex = 38
        Me.btn_Actualiser.Text = "Actualiser"
        Me.btn_Actualiser.UseVisualStyleBackColor = True
        '
        'flisteProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(712, 454)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.btn_Actualiser)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxDesignation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxQte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxPrix)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "flisteProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "flisteProd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FacturationDataSet1 As Picos_Billing.facturationDataSet1
    Friend WithEvents ProduitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduitsTableAdapter As Picos_Billing.facturationDataSet1TableAdapters.produitsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxQte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxDesignation As System.Windows.Forms.TextBox
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents btn_Actualiser As System.Windows.Forms.Button
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents NumprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixunitaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QteprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modif As System.Windows.Forms.DataGridViewButtonColumn
End Class
