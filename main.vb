Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        frm_ajout_pation.MdiParent = Me
        frm_ajout_pation.Show()
    End Sub

    Private Sub AficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AficherToolStripMenuItem.Click
        frm_afficher_patient.Show()
    End Sub

    Private Sub AjoutRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutRDVToolStripMenuItem.Click
        Ajout_RDV.MdiParent = Me
        Ajout_RDV.Show()
    End Sub

    Private Sub AfficherRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherRDVToolStripMenuItem.Click
        afficherrdv.Show()
    End Sub


End Class
