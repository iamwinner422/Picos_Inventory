<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNUser
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
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fNUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.boxPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boxLogin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.boxPassAd = New System.Windows.Forms.TextBox()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Label7.Location = New System.Drawing.Point(4, 5)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(133, 21)
        Label7.TabIndex = 7
        Label7.Text = "Nouvel utilisateur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 19.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "AJOUT D'UN UTILISATEUR"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 30)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(250, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 26)
        Me.Panel3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Mot de passe"
        '
        'boxPass
        '
        Me.boxPass.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPass.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPass.ForeColor = System.Drawing.Color.White
        Me.boxPass.Location = New System.Drawing.Point(41, 208)
        Me.boxPass.Name = "boxPass"
        Me.boxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.boxPass.Size = New System.Drawing.Size(281, 22)
        Me.boxPass.TabIndex = 20
        Me.boxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nom d'utilisateur"
        '
        'boxLogin
        '
        Me.boxLogin.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxLogin.ForeColor = System.Drawing.Color.White
        Me.boxLogin.Location = New System.Drawing.Point(41, 144)
        Me.boxLogin.Name = "boxLogin"
        Me.boxLogin.Size = New System.Drawing.Size(281, 22)
        Me.boxLogin.TabIndex = 18
        Me.boxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mot de passe Admin"
        '
        'boxPassAd
        '
        Me.boxPassAd.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.boxPassAd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.boxPassAd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.boxPassAd.ForeColor = System.Drawing.Color.White
        Me.boxPassAd.Location = New System.Drawing.Point(42, 272)
        Me.boxPassAd.Name = "boxPassAd"
        Me.boxPassAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.boxPassAd.Size = New System.Drawing.Size(281, 22)
        Me.boxPassAd.TabIndex = 22
        Me.boxPassAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.boxPassAd.UseSystemPasswordChar = True
        '
        'btnEffacer
        '
        Me.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEffacer.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnEffacer.ForeColor = System.Drawing.Color.White
        Me.btnEffacer.Image = Global.Picos_Billing.My.Resources.Resources.cancel_17px
        Me.btnEffacer.Location = New System.Drawing.Point(158, 313)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(77, 30)
        Me.btnEffacer.TabIndex = 25
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.White
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAjouter.Image = Global.Picos_Billing.My.Resources.Resources.ok_17px
        Me.btnAjouter.Location = New System.Drawing.Point(241, 312)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(81, 31)
        Me.btnAjouter.TabIndex = 24
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Picos_Billing.My.Resources.Resources.filled_circle_filled_50px
        Me.PictureBox2.Location = New System.Drawing.Point(87, 6)
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
        Me.PictureBox1.Location = New System.Drawing.Point(64, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'fNUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(364, 383)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxPassAd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.boxPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.boxLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fNUser"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouvel utilisateur"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents boxPass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents boxPassAd As System.Windows.Forms.TextBox
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
End Class
