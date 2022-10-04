<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fListeClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fListeClient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturationDataSet = New Picos_Billing.facturationDataSet()
        Me.ClientsTableAdapter = New Picos_Billing.facturationDataSetTableAdapters.clientsTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxAdresse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxNumTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxPrenoms = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxNom = New System.Windows.Forms.TextBox()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSuppr = New System.Windows.Forms.Button()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.btn_Actualiser = New System.Windows.Forms.Button()
        Me.NumcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomscltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdrcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modif = New System.Windows.Forms.DataGridViewButtonColumn()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label3.Size = New System.Drawing.Size(158, 21)
        Label3.TabIndex = 7
        Label3.Text = "Clients - Picos  Billing"
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
        Me.Panel1.Size = New System.Drawing.Size(935, 34)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(736, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 30)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(170, 7)
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
        Me.PictureBox1.Location = New System.Drawing.Point(143, 7)
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
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "GESTION DES CLIENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumcltDataGridViewTextBoxColumn, Me.NomcltDataGridViewTextBoxColumn, Me.PrenomscltDataGridViewTextBoxColumn, Me.NumtelDataGridViewTextBoxColumn, Me.AdrcltDataGridViewTextBoxColumn, Me.modif})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 134)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(916, 279)
        Me.DataGridView1.TabIndex = 9
        '
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.FacturationDataSet
        '
        'FacturationDataSet
        '
        Me.FacturationDataSet.DataSetName = "facturationDataSet"
        Me.FacturationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(404, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Adresse"
        '
        'boxAdresse
        '
        Me.boxAdresse.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxAdresse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxAdresse.ForeColor = System.Drawing.Color.White
        Me.boxAdresse.Location = New System.Drawing.Point(404, 521)
        Me.boxAdresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxAdresse.Name = "boxAdresse"
        Me.boxAdresse.Size = New System.Drawing.Size(328, 22)
        Me.boxAdresse.TabIndex = 19
        Me.boxAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Numéro de téléphone"
        '
        'boxNumTel
        '
        Me.boxNumTel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNumTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNumTel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNumTel.ForeColor = System.Drawing.Color.White
        Me.boxNumTel.Location = New System.Drawing.Point(25, 521)
        Me.boxNumTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxNumTel.Name = "boxNumTel"
        Me.boxNumTel.Size = New System.Drawing.Size(328, 22)
        Me.boxNumTel.TabIndex = 17
        Me.boxNumTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(404, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Prénoms"
        '
        'boxPrenoms
        '
        Me.boxPrenoms.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrenoms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrenoms.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPrenoms.ForeColor = System.Drawing.Color.White
        Me.boxPrenoms.Location = New System.Drawing.Point(404, 454)
        Me.boxPrenoms.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxPrenoms.Name = "boxPrenoms"
        Me.boxPrenoms.Size = New System.Drawing.Size(328, 22)
        Me.boxPrenoms.TabIndex = 15
        Me.boxPrenoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nom"
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNom.ForeColor = System.Drawing.Color.White
        Me.boxNom.Location = New System.Drawing.Point(25, 454)
        Me.boxNom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(328, 22)
        Me.boxNom.TabIndex = 13
        Me.boxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModifier
        '
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(25, 565)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(131, 38)
        Me.btnModifier.TabIndex = 21
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSuppr
        '
        Me.btnSuppr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppr.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnSuppr.ForeColor = System.Drawing.Color.White
        Me.btnSuppr.Location = New System.Drawing.Point(185, 565)
        Me.btnSuppr.Name = "btnSuppr"
        Me.btnSuppr.Size = New System.Drawing.Size(131, 38)
        Me.btnSuppr.TabIndex = 22
        Me.btnSuppr.Text = "Supprimer"
        Me.btnSuppr.UseVisualStyleBackColor = True
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.White
        Me.boxSearch.Location = New System.Drawing.Point(473, 107)
        Me.boxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(328, 18)
        Me.boxSearch.TabIndex = 23
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(476, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Recherche"
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(748, 454)
        Me.boxNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(31, 22)
        Me.boxNum.TabIndex = 25
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
        Me.btn_Actualiser.Location = New System.Drawing.Point(809, 103)
        Me.btn_Actualiser.Name = "btn_Actualiser"
        Me.btn_Actualiser.Size = New System.Drawing.Size(111, 24)
        Me.btn_Actualiser.TabIndex = 39
        Me.btn_Actualiser.Text = "Actualiser"
        Me.btn_Actualiser.UseVisualStyleBackColor = True
        '
        'NumcltDataGridViewTextBoxColumn
        '
        Me.NumcltDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NumcltDataGridViewTextBoxColumn.DataPropertyName = "num_clt"
        Me.NumcltDataGridViewTextBoxColumn.HeaderText = "Num."
        Me.NumcltDataGridViewTextBoxColumn.Name = "NumcltDataGridViewTextBoxColumn"
        Me.NumcltDataGridViewTextBoxColumn.Visible = False
        Me.NumcltDataGridViewTextBoxColumn.Width = 61
        '
        'NomcltDataGridViewTextBoxColumn
        '
        Me.NomcltDataGridViewTextBoxColumn.DataPropertyName = "nom_clt"
        Me.NomcltDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomcltDataGridViewTextBoxColumn.Name = "NomcltDataGridViewTextBoxColumn"
        Me.NomcltDataGridViewTextBoxColumn.Width = 170
        '
        'PrenomscltDataGridViewTextBoxColumn
        '
        Me.PrenomscltDataGridViewTextBoxColumn.DataPropertyName = "prenoms_clt"
        Me.PrenomscltDataGridViewTextBoxColumn.HeaderText = "Prénoms"
        Me.PrenomscltDataGridViewTextBoxColumn.Name = "PrenomscltDataGridViewTextBoxColumn"
        Me.PrenomscltDataGridViewTextBoxColumn.Width = 210
        '
        'NumtelDataGridViewTextBoxColumn
        '
        Me.NumtelDataGridViewTextBoxColumn.DataPropertyName = "num_tel"
        Me.NumtelDataGridViewTextBoxColumn.HeaderText = "Numéro de téléphone"
        Me.NumtelDataGridViewTextBoxColumn.Name = "NumtelDataGridViewTextBoxColumn"
        Me.NumtelDataGridViewTextBoxColumn.Width = 123
        '
        'AdrcltDataGridViewTextBoxColumn
        '
        Me.AdrcltDataGridViewTextBoxColumn.DataPropertyName = "adr_clt"
        Me.AdrcltDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.AdrcltDataGridViewTextBoxColumn.Name = "AdrcltDataGridViewTextBoxColumn"
        Me.AdrcltDataGridViewTextBoxColumn.Width = 270
        '
        'modif
        '
        Me.modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modif.HeaderText = "Opération"
        Me.modif.Name = "modif"
        Me.modif.Text = "Modifier"
        Me.modif.UseColumnTextForButtonValue = True
        '
        'fListeClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(935, 618)
        Me.Controls.Add(Me.btn_Actualiser)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.btnSuppr)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxAdresse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxNumTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxPrenoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxNom)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fListeClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clients"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FacturationDataSet As Picos_Billing.facturationDataSet
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As Picos_Billing.facturationDataSetTableAdapters.clientsTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents boxAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxNumTel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxPrenoms As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxNom As System.Windows.Forms.TextBox
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnSuppr As System.Windows.Forms.Button
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents btn_Actualiser As System.Windows.Forms.Button
    Friend WithEvents NumcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomscltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumtelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdrcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modif As System.Windows.Forms.DataGridViewButtonColumn
End Class
