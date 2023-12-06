Public Class frm_ajout_pation
    Private Sub btn_ajoute_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim p As patient
        With p
            p.code = txt_cde.Text
            p.nom = txt_nom.Text
            p.prenom = txt_prenom.Text
        End With
        If ajout_patient(p) Then
            MessageBox.Show("patient ajouter avec succées")
        Else
            MessageBox.Show("le tableau est saturé")

        End If
        txt_cde.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()

    End Sub

    Private Sub frm_ajout_pation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        frm_main.Show()

    End Sub
End Class