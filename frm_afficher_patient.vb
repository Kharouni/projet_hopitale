Public Class frm_afficher_patient
    Private Sub dgb_patient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgb_patient.CellContentClick

    End Sub

    Private Sub frm_afficher_patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(dgb_patient)
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        Dim index As Integer
        index = dgb_patient.SelectedCells(0).RowIndex
        patients(index) = Nothing
        dgb_patient.Rows.RemoveAt(index)
        MsgBox("suppression avec succes")




    End Sub
End Class