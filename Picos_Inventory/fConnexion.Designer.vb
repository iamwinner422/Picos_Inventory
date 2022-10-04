<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConnexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fConnexion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.boxPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnFermer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnConnexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONNEXION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'boxUser
        '
        Me.boxUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.boxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxUser.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxUser.ForeColor = System.Drawing.Color.White
        Me.boxUser.Location = New System.Drawing.Point(42, 143)
        Me.boxUser.Name = "boxUser"
        Me.boxUser.Size = New System.Drawing.Size(260, 18)
        Me.boxUser.TabIndex = 1
        Me.boxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(38, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(41, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 1)
        Me.Panel2.TabIndex = 0
        '
        'boxPassword
        '
        Me.boxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.boxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPassword.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxPassword.ForeColor = System.Drawing.Color.White
        Me.boxPassword.Location = New System.Drawing.Point(41, 229)
        Me.boxPassword.Name = "boxPassword"
        Me.boxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.boxPassword.Size = New System.Drawing.Size(260, 18)
        Me.boxPassword.TabIndex = 4
        Me.boxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPassword.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(41, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 1)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(38, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mot de passe"
        '
        'btnFermer
        '
        Me.btnFermer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFermer.Font = New System.Drawing.Font("Segoe UI Light", 7.75!)
        Me.btnFermer.Location = New System.Drawing.Point(249, 330)
        Me.btnFermer.Name = "btnFermer"
        Me.btnFermer.Size = New System.Drawing.Size(53, 23)
        Me.btnFermer.TabIndex = 9
        Me.btnFermer.Text = "Fermer"
        Me.btnFermer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 6.25!)
        Me.Label4.Location = New System.Drawing.Point(136, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "© Picos Studio®"
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnEffacer.Image = Global.Picos_Billing.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(97, 266)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(91, 37)
        Me.btnEffacer.TabIndex = 8
        Me.btnEffacer.Text = " Effacer"
        Me.btnEffacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnConnexion
        '
        Me.btnConnexion.BackColor = System.Drawing.Color.White
        Me.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnexion.Font = New System.Drawing.Font("Segoe UI Light", 9.25!)
        Me.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnConnexion.Image = Global.Picos_Billing.My.Resources.Resources.login_17px
        Me.btnConnexion.Location = New System.Drawing.Point(194, 266)
        Me.btnConnexion.Name = "btnConnexion"
        Me.btnConnexion.Size = New System.Drawing.Size(108, 38)
        Me.btnConnexion.TabIndex = 7
        Me.btnConnexion.Text = "Se connecter"
        Me.btnConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnConnexion.UseVisualStyleBackColor = False
        '
        'fConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 387)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFermer)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnConnexion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.boxPassword)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxUser)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fConnexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents boxUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents boxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConnexion As System.Windows.Forms.Button
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnFermer As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
