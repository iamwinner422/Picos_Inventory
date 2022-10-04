<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rapComd
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.details_tempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.details_temp = New Picos_Billing.details_temp()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.details_tempTableAdapter = New Picos_Billing.details_tempTableAdapters.details_tempTableAdapter()
        CType(Me.details_tempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.details_temp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'details_tempBindingSource
        '
        Me.details_tempBindingSource.DataMember = "details_temp"
        Me.details_tempBindingSource.DataSource = Me.details_temp
        '
        'details_temp
        '
        Me.details_temp.DataSetName = "details_temp"
        Me.details_temp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.details_tempBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Picos_Billing.fac.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(648, 408)
        Me.ReportViewer1.TabIndex = 4
        '
        'details_tempTableAdapter
        '
        Me.details_tempTableAdapter.ClearBeforeFill = True
        '
        'rapComd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(655, 498)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rapComd"
        Me.Text = "rapComd"
        CType(Me.details_tempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.details_temp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents details_tempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents details_temp As Picos_Billing.details_temp
    Friend WithEvents details_tempTableAdapter As Picos_Billing.details_tempTableAdapters.details_tempTableAdapter
End Class
