Public Class afficherrdv
    Private Sub afficherrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher1(rdv)
    End Sub



    Private Sub btn_annulerRDV_Click(sender As Object, e As EventArgs) Handles btn_annulerRDV.Click
        Dim index As Integer
        index = rdv.SelectedCells(0).RowIndex
        TABrdv(index) = Nothing
        rdv.Rows.RemoveAt(index)
        MsgBox("Supprimé avec succes")
    End Sub

    Private Sub rdv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rdv.CellContentClick

    End Sub
End Class