<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class afficherrdv
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
        Me.rdv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_annulerRDV = New System.Windows.Forms.Button()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.rdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdv
        '
        Me.rdv.AccessibleName = ""
        Me.rdv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.rdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rdv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.rdv.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdv.Location = New System.Drawing.Point(22, 70)
        Me.rdv.Name = "rdv"
        Me.rdv.RowHeadersWidth = 51
        Me.rdv.RowTemplate.Height = 24
        Me.rdv.Size = New System.Drawing.Size(658, 237)
        Me.rdv.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "code"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "date "
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'btn_annulerRDV
        '
        Me.btn_annulerRDV.BackColor = System.Drawing.Color.Pink
        Me.btn_annulerRDV.Location = New System.Drawing.Point(343, 313)
        Me.btn_annulerRDV.Name = "btn_annulerRDV"
        Me.btn_annulerRDV.Size = New System.Drawing.Size(103, 45)
        Me.btn_annulerRDV.TabIndex = 1
        Me.btn_annulerRDV.Text = "Supprimer"
        Me.btn_annulerRDV.UseVisualStyleBackColor = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "heure"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'afficherrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_annulerRDV)
        Me.Controls.Add(Me.rdv)
        Me.Name = "afficherrdv"
        Me.Text = "afficherrdv"
        CType(Me.rdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_annulerRDV As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
