<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAjoutClient
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fAjoutClient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.boxNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxPrenoms = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxNumTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boxAdresse = New System.Windows.Forms.TextBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomscltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdrcltDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ClientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturationDataSet3 = New Picos_Billing.facturationDataSet3()
        Me.ClientsTableAdapter = New Picos_Billing.facturationDataSet3TableAdapters.clientsTableAdapter()
        Me.boxNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.boxSearch = New System.Windows.Forms.TextBox()
        Label3 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturationDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Label3.Size = New System.Drawing.Size(224, 21)
        Label3.TabIndex = 7
        Label3.Text = "Ajout d'un client - Picos  Billing"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label7.Location = New System.Drawing.Point(4, 5)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(61, 21)
        Label7.TabIndex = 7
        Label7.Text = "Clients "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 30)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(942, 30)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(250, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(686, 26)
        Me.Panel3.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(665, 6)
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
        Me.PictureBox1.Location = New System.Drawing.Point(642, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'boxNom
        '
        Me.boxNom.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNom.ForeColor = System.Drawing.Color.White
        Me.boxNom.Location = New System.Drawing.Point(22, 157)
        Me.boxNom.Name = "boxNom"
        Me.boxNom.Size = New System.Drawing.Size(281, 22)
        Me.boxNom.TabIndex = 4
        Me.boxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prénoms"
        '
        'boxPrenoms
        '
        Me.boxPrenoms.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPrenoms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPrenoms.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPrenoms.ForeColor = System.Drawing.Color.White
        Me.boxPrenoms.Location = New System.Drawing.Point(22, 218)
        Me.boxPrenoms.Name = "boxPrenoms"
        Me.boxPrenoms.Size = New System.Drawing.Size(281, 22)
        Me.boxPrenoms.TabIndex = 7
        Me.boxPrenoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Numéro de téléphone"
        '
        'boxNumTel
        '
        Me.boxNumTel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNumTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNumTel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNumTel.ForeColor = System.Drawing.Color.White
        Me.boxNumTel.Location = New System.Drawing.Point(22, 279)
        Me.boxNumTel.MaxLength = 8
        Me.boxNumTel.Name = "boxNumTel"
        Me.boxNumTel.Size = New System.Drawing.Size(281, 22)
        Me.boxNumTel.TabIndex = 9
        Me.boxNumTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Adresse"
        '
        'boxAdresse
        '
        Me.boxAdresse.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxAdresse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxAdresse.ForeColor = System.Drawing.Color.White
        Me.boxAdresse.Location = New System.Drawing.Point(22, 340)
        Me.boxAdresse.Name = "boxAdresse"
        Me.boxAdresse.Size = New System.Drawing.Size(281, 22)
        Me.boxAdresse.TabIndex = 11
        Me.boxAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.White
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAjouter.Image = Global.Picos_Billing.My.Resources.Resources.ok_17px
        Me.btnAjouter.Location = New System.Drawing.Point(206, 382)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(97, 31)
        Me.btnAjouter.TabIndex = 13
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.White
        Me.btnEffacer.Image = Global.Picos_Billing.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(97, 382)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(103, 30)
        Me.btnEffacer.TabIndex = 14
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 45)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CLIENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumcltDataGridViewTextBoxColumn, Me.NomcltDataGridViewTextBoxColumn, Me.PrenomscltDataGridViewTextBoxColumn, Me.NumtelDataGridViewTextBoxColumn, Me.AdrcltDataGridViewTextBoxColumn, Me.Action})
        Me.DataGridView1.DataSource = Me.ClientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(326, 134)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(592, 425)
        Me.DataGridView1.TabIndex = 16
        '
        'NumcltDataGridViewTextBoxColumn
        '
        Me.NumcltDataGridViewTextBoxColumn.DataPropertyName = "num_clt"
        Me.NumcltDataGridViewTextBoxColumn.HeaderText = "num_clt"
        Me.NumcltDataGridViewTextBoxColumn.Name = "NumcltDataGridViewTextBoxColumn"
        Me.NumcltDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumcltDataGridViewTextBoxColumn.Visible = False
        '
        'NomcltDataGridViewTextBoxColumn
        '
        Me.NomcltDataGridViewTextBoxColumn.DataPropertyName = "nom_clt"
        Me.NomcltDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomcltDataGridViewTextBoxColumn.Name = "NomcltDataGridViewTextBoxColumn"
        Me.NomcltDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrenomscltDataGridViewTextBoxColumn
        '
        Me.PrenomscltDataGridViewTextBoxColumn.DataPropertyName = "prenoms_clt"
        Me.PrenomscltDataGridViewTextBoxColumn.HeaderText = "Prénoms"
        Me.PrenomscltDataGridViewTextBoxColumn.Name = "PrenomscltDataGridViewTextBoxColumn"
        Me.PrenomscltDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrenomscltDataGridViewTextBoxColumn.Width = 200
        '
        'NumtelDataGridViewTextBoxColumn
        '
        Me.NumtelDataGridViewTextBoxColumn.DataPropertyName = "num_tel"
        Me.NumtelDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.NumtelDataGridViewTextBoxColumn.Name = "NumtelDataGridViewTextBoxColumn"
        Me.NumtelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdrcltDataGridViewTextBoxColumn
        '
        Me.AdrcltDataGridViewTextBoxColumn.DataPropertyName = "adr_clt"
        Me.AdrcltDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.AdrcltDataGridViewTextBoxColumn.Name = "AdrcltDataGridViewTextBoxColumn"
        Me.AdrcltDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdrcltDataGridViewTextBoxColumn.Width = 160
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
        'ClientsBindingSource
        '
        Me.ClientsBindingSource.DataMember = "clients"
        Me.ClientsBindingSource.DataSource = Me.FacturationDataSet3
        '
        'FacturationDataSet3
        '
        Me.FacturationDataSet3.DataSetName = "facturationDataSet3"
        Me.FacturationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'boxNum
        '
        Me.boxNum.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxNum.ForeColor = System.Drawing.Color.White
        Me.boxNum.Location = New System.Drawing.Point(33, 386)
        Me.boxNum.Name = "boxNum"
        Me.boxNum.Size = New System.Drawing.Size(52, 22)
        Me.boxNum.TabIndex = 17
        Me.boxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxNum.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Italic)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Location = New System.Drawing.Point(593, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Recherche"
        '
        'boxSearch
        '
        Me.boxSearch.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxSearch.ForeColor = System.Drawing.Color.White
        Me.boxSearch.Location = New System.Drawing.Point(590, 111)
        Me.boxSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.boxSearch.Name = "boxSearch"
        Me.boxSearch.Size = New System.Drawing.Size(328, 18)
        Me.boxSearch.TabIndex = 25
        Me.boxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fAjoutClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 572)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.boxSearch)
        Me.Controls.Add(Me.boxNum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.boxAdresse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxNumTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxPrenoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxNom)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fAjoutClient"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturationDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents boxNom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxPrenoms As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents boxNumTel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents boxAdresse As System.Windows.Forms.TextBox
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FacturationDataSet3 As Picos_Billing.facturationDataSet3
    Friend WithEvents ClientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As Picos_Billing.facturationDataSet3TableAdapters.clientsTableAdapter
    Friend WithEvents boxNum As System.Windows.Forms.TextBox
    Friend WithEvents NumcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomscltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumtelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdrcltDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Action As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents boxSearch As System.Windows.Forms.TextBox
End Class
