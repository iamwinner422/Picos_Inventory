<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEntreeStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fEntreeStock))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblQte = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CodeArticle = New System.Windows.Forms.ComboBox()
        Me.ProduitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Entreestock = New Picos_Billing.entreestock()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblNQte = New System.Windows.Forms.Label()
        Me.lblNewQte = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxResult = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxNQte = New System.Windows.Forms.TextBox()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.ProduitsTableAdapter = New Picos_Billing.entreestockTableAdapters.produitsTableAdapter()
        Me.boxQte = New System.Windows.Forms.TextBox()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entreestock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label7.Location = New System.Drawing.Point(4, 5)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(115, 21)
        Label7.TabIndex = 7
        Label7.Text = "Entrée en stock"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 30)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(250, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(298, 26)
        Me.Panel3.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(277, 6)
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
        Me.PictureBox1.Location = New System.Drawing.Point(254, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblQte)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.boxQte)
        Me.GroupBox1.Controls.Add(Me.CodeArticle)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 104)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etat du stock"
        '
        'lblQte
        '
        Me.lblQte.AutoSize = True
        Me.lblQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblQte.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblQte.ForeColor = System.Drawing.Color.White
        Me.lblQte.Location = New System.Drawing.Point(361, 49)
        Me.lblQte.Name = "lblQte"
        Me.lblQte.Size = New System.Drawing.Size(63, 19)
        Me.lblQte.TabIndex = 29
        Me.lblQte.Text = "Quantité"
        Me.lblQte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(349, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Quantité actuelle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Produit"
        '
        'CodeArticle
        '
        Me.CodeArticle.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CodeArticle.DataSource = Me.ProduitsBindingSource
        Me.CodeArticle.DisplayMember = "num_prod"
        Me.CodeArticle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodeArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CodeArticle.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CodeArticle.FormattingEnabled = True
        Me.CodeArticle.Location = New System.Drawing.Point(33, 45)
        Me.CodeArticle.Name = "CodeArticle"
        Me.CodeArticle.Size = New System.Drawing.Size(310, 25)
        Me.CodeArticle.TabIndex = 22
        Me.CodeArticle.ValueMember = "num_prod"
        '
        'ProduitsBindingSource
        '
        Me.ProduitsBindingSource.DataMember = "produits"
        Me.ProduitsBindingSource.DataSource = Me.Entreestock
        '
        'Entreestock
        '
        Me.Entreestock.DataSetName = "entreestock"
        Me.Entreestock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(139, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ENTREE EN STOCK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblNQte)
        Me.GroupBox2.Controls.Add(Me.lblNewQte)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.boxResult)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.boxNQte)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(23, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 132)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entrée en stock"
        '
        'lblNQte
        '
        Me.lblNQte.AutoSize = True
        Me.lblNQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblNQte.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblNQte.ForeColor = System.Drawing.Color.White
        Me.lblNQte.Location = New System.Drawing.Point(205, 84)
        Me.lblNQte.Name = "lblNQte"
        Me.lblNQte.Size = New System.Drawing.Size(17, 19)
        Me.lblNQte.TabIndex = 30
        Me.lblNQte.Text = "0"
        Me.lblNQte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewQte
        '
        Me.lblNewQte.AutoSize = True
        Me.lblNewQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lblNewQte.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblNewQte.ForeColor = System.Drawing.Color.White
        Me.lblNewQte.Location = New System.Drawing.Point(473, 82)
        Me.lblNewQte.Name = "lblNewQte"
        Me.lblNewQte.Size = New System.Drawing.Size(0, 19)
        Me.lblNewQte.TabIndex = 29
        Me.lblNewQte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nouvelle quantié en stock:"
        '
        'boxResult
        '
        Me.boxResult.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxResult.Enabled = False
        Me.boxResult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxResult.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxResult.Location = New System.Drawing.Point(202, 82)
        Me.boxResult.Name = "boxResult"
        Me.boxResult.Size = New System.Drawing.Size(274, 22)
        Me.boxResult.TabIndex = 26
        Me.boxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Quantié entrante:"
        '
        'boxNQte
        '
        Me.boxNQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxNQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxNQte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxNQte.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxNQte.Location = New System.Drawing.Point(202, 32)
        Me.boxNQte.Name = "boxNQte"
        Me.boxNQte.Size = New System.Drawing.Size(274, 22)
        Me.boxNQte.TabIndex = 23
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.White
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnValider.Image = Global.Picos_Billing.My.Resources.Resources.ok_17px
        Me.btnValider.Location = New System.Drawing.Point(406, 389)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(125, 37)
        Me.btnValider.TabIndex = 23
        Me.btnValider.Text = "Valider l'entrée"
        Me.btnValider.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'ProduitsTableAdapter
        '
        Me.ProduitsTableAdapter.ClearBeforeFill = True
        '
        'boxQte
        '
        Me.boxQte.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxQte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxQte.Enabled = False
        Me.boxQte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxQte.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.boxQte.Location = New System.Drawing.Point(360, 48)
        Me.boxQte.Name = "boxQte"
        Me.boxQte.Size = New System.Drawing.Size(116, 22)
        Me.boxQte.TabIndex = 24
        '
        'fEntreeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(554, 438)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fEntreeStock"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrée en stock"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProduitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entreestock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CodeArticle As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxResult As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxNQte As System.Windows.Forms.TextBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents Entreestock As Picos_Billing.entreestock
    Friend WithEvents ProduitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduitsTableAdapter As Picos_Billing.entreestockTableAdapters.produitsTableAdapter
    Friend WithEvents lblQte As System.Windows.Forms.Label
    Friend WithEvents lblNewQte As System.Windows.Forms.Label
    Friend WithEvents lblNQte As System.Windows.Forms.Label
    Friend WithEvents boxQte As System.Windows.Forms.TextBox
End Class
