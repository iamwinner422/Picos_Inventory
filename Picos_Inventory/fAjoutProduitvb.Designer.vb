<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAjoutProduitvb
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAjoutProduitvb))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.boxDesignation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxPrix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxQte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Facprod = New Picos_Billing.facprod()
        Me.ProduitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduitsTableAdapter = New Picos_Billing.facprodTableAdapters.produitsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixunitaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteprodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facprod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label7.Size = New System.Drawing.Size(68, 21)
        Label7.TabIndex = 8
        Label7.Text = "Produits"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 27)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(284, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(492, 26)
        Me.Panel3.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(471, 6)
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
        Me.PictureBox1.Location = New System.Drawing.Point(448, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 45)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PRODUITS"
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.White
        Me.btnEffacer.Image = Global.Picos_Billing.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(90, 313)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(101, 30)
        Me.btnEffacer.TabIndex = 22
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.White
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAjouter.Image = Global.Picos_Billing.My.Resources.Resources.ok_17px
        Me.btnAjouter.Location = New System.Drawing.Point(197, 312)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(96, 31)
        Me.btnAjouter.TabIndex = 21
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'boxDesignation
        '
        Me.boxDesignation.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxDesignation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxDesignation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxDesignation.ForeColor = System.Drawing.Color.White
        Me.boxDesignation.Location = New System.Drawing.Point(12, 152)
        Me.boxDesignation.Name = "boxDesignation"
        Me.boxDesignation.Size = New System.Drawing.Size(281, 22)
        Me.boxDesignation.TabIndex = 17
        Me.boxDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Désignation"
        '
        'boxPrix
        '
        Me.boxPrix.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPrix.ForeColor = System.Drawing.Color.White
        Me.boxPrix.Location = New System.Drawing.Point(12, 210)
        Me.boxPrix.Name = "boxPrix"
        Me.boxPrix.Size = New System.Drawing.Size(281, 22)
        Me.boxPrix.TabIndex = 19
        Me.boxPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Prix Unitaire"
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxQte.ForeColor = System.Drawing.Color.White
        Me.boxQte.Location = New System.Drawing.Point(12, 264)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.Size = New System.Drawing.Size(281, 22)
        Me.boxQte.TabIndex = 20
        Me.boxQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Quantité"
        '
        'Facprod
        '
        Me.Facprod.DataSetName = "facprod"
        Me.Facprod.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProduitsBindingSource
        '
        Me.ProduitsBindingSource.DataMember = "produits"
        Me.ProduitsBindingSource.DataSource = Me.Facprod
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumprodDataGridViewTextBoxColumn, Me.DesignationprodDataGridViewTextBoxColumn, Me.PrixunitaireDataGridViewTextBoxColumn, Me.QteprodDataGridViewTextBoxColumn, Me.Action})
        Me.DataGridView1.DataSource = Me.ProduitsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(304, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(468, 361)
        Me.DataGridView1.TabIndex = 28
        '
        'NumprodDataGridViewTextBoxColumn
        '
        Me.NumprodDataGridViewTextBoxColumn.DataPropertyName = "num_prod"
        Me.NumprodDataGridViewTextBoxColumn.HeaderText = "num_prod"
        Me.NumprodDataGridViewTextBoxColumn.Name = "NumprodDataGridViewTextBoxColumn"
        Me.NumprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumprodDataGridViewTextBoxColumn.Visible = False
        '
        'DesignationprodDataGridViewTextBoxColumn
        '
        Me.DesignationprodDataGridViewTextBoxColumn.DataPropertyName = "designation_prod"
        Me.DesignationprodDataGridViewTextBoxColumn.HeaderText = "Désignation"
        Me.DesignationprodDataGridViewTextBoxColumn.Name = "DesignationprodDataGridViewTextBoxColumn"
        Me.DesignationprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationprodDataGridViewTextBoxColumn.Width = 155
        '
        'PrixunitaireDataGridViewTextBoxColumn
        '
        Me.PrixunitaireDataGridViewTextBoxColumn.DataPropertyName = "prix_unitaire"
        Me.PrixunitaireDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixunitaireDataGridViewTextBoxColumn.Name = "PrixunitaireDataGridViewTextBoxColumn"
        Me.PrixunitaireDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrixunitaireDataGridViewTextBoxColumn.Width = 85
        '
        'QteprodDataGridViewTextBoxColumn
        '
        Me.QteprodDataGridViewTextBoxColumn.DataPropertyName = "qte_prod"
        Me.QteprodDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QteprodDataGridViewTextBoxColumn.Name = "QteprodDataGridViewTextBoxColumn"
        Me.QteprodDataGridViewTextBoxColumn.ReadOnly = True
        Me.QteprodDataGridViewTextBoxColumn.Width = 85
        '
        'Action
        '
        Me.Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "Modifier"
        Me.Action.UseColumnTextForButtonValue = True
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(19, 321)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(52, 22)
        Me.boxNum.TabIndex = 42
        Me.boxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxNum.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(475, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Recherche"
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.White
        Me.boxSearch.Location = New System.Drawing.Point(474, 105)
        Me.boxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(298, 18)
        Me.boxSearch.TabIndex = 43
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fAjoutProduitvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 490)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxQte)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxPrix)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxDesignation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fAjoutProduitvb"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fAjoutProduitvb"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facprod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents boxDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxPrix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxQte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Facprod As Picos_Billing.facprod
    Friend WithEvents ProduitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduitsTableAdapter As Picos_Billing.facprodTableAdapters.produitsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NumprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesignationprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrixunitaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QteprodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Action As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
End Class
