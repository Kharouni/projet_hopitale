<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RendevouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        Me.ContextMenuStrip2.Text = "pation"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PationToolStripMenuItem, Me.RendevouToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PationToolStripMenuItem
        '
        Me.PationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.AficherToolStripMenuItem})
        Me.PationToolStripMenuItem.Name = "PationToolStripMenuItem"
        Me.PationToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.PationToolStripMenuItem.Text = "patient"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.AjouterToolStripMenuItem.Text = "ajouter"
        '
        'AficherToolStripMenuItem
        '
        Me.AficherToolStripMenuItem.Name = "AficherToolStripMenuItem"
        Me.AficherToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.AficherToolStripMenuItem.Text = "afficher"
        '
        'RendevouToolStripMenuItem
        '
        Me.RendevouToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutRDVToolStripMenuItem, Me.AfficherRDVToolStripMenuItem})
        Me.RendevouToolStripMenuItem.Name = "RendevouToolStripMenuItem"
        Me.RendevouToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.RendevouToolStripMenuItem.Text = "RDV"
        '
        'AjoutRDVToolStripMenuItem
        '
        Me.AjoutRDVToolStripMenuItem.Name = "AjoutRDVToolStripMenuItem"
        Me.AjoutRDVToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AjoutRDVToolStripMenuItem.Text = "ajout RDV"
        '
        'AfficherRDVToolStripMenuItem
        '
        Me.AfficherRDVToolStripMenuItem.Name = "AfficherRDVToolStripMenuItem"
        Me.AfficherRDVToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.AfficherRDVToolStripMenuItem.Text = "Afficher RDV"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AficherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RendevouToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherRDVToolStripMenuItem As ToolStripMenuItem
End Class
