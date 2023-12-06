<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ajout_RDV
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.code = New System.Windows.Forms.Label()
        Me.txt_code2 = New System.Windows.Forms.TextBox()
        Me.btn_AjoutRDV = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_heure = New System.Windows.Forms.TextBox()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(44, 244)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "date"
        '
        'code
        '
        Me.code.AutoSize = True
        Me.code.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.Location = New System.Drawing.Point(43, 161)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(55, 25)
        Me.code.TabIndex = 1
        Me.code.Text = "code"
        '
        'txt_code2
        '
        Me.txt_code2.Location = New System.Drawing.Point(133, 152)
        Me.txt_code2.Multiline = True
        Me.txt_code2.Name = "txt_code2"
        Me.txt_code2.Size = New System.Drawing.Size(308, 34)
        Me.txt_code2.TabIndex = 3
        '
        'btn_AjoutRDV
        '
        Me.btn_AjoutRDV.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AjoutRDV.Location = New System.Drawing.Point(178, 363)
        Me.btn_AjoutRDV.Name = "btn_AjoutRDV"
        Me.btn_AjoutRDV.Size = New System.Drawing.Size(191, 51)
        Me.btn_AjoutRDV.TabIndex = 4
        Me.btn_AjoutRDV.Text = "Ajouter"
        Me.btn_AjoutRDV.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "heure"
        '
        'txt_heure
        '
        Me.txt_heure.Location = New System.Drawing.Point(133, 318)
        Me.txt_heure.Multiline = True
        Me.txt_heure.Name = "txt_heure"
        Me.txt_heure.Size = New System.Drawing.Size(305, 35)
        Me.txt_heure.TabIndex = 7
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(133, 247)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(308, 22)
        Me.date1.TabIndex = 8
        '
        'Ajout_RDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.projet_hopitale.My.Resources.Resources.Design__Giro__Celebração_Imagens_de_fundo_gratuitas__Boneco_Figura_Cartoon_Art_Background_Foto_PNG_e_vetores_de_fundo1
        Me.ClientSize = New System.Drawing.Size(652, 553)
        Me.Controls.Add(Me.date1)
        Me.Controls.Add(Me.txt_heure)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_AjoutRDV)
        Me.Controls.Add(Me.txt_code2)
        Me.Controls.Add(Me.code)
        Me.Controls.Add(Me.label1)
        Me.Name = "Ajout_RDV"
        Me.Text = "Ajout_RDV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents code As Label
    Friend WithEvents txt_code2 As TextBox
    Friend WithEvents btn_AjoutRDV As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_heure As TextBox
    Friend WithEvents date1 As DateTimePicker
End Class
