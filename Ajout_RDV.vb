Public Class Ajout_RDV


    Private Sub btn_AjoutRDV_Click(sender As Object, e As EventArgs) Handles btn_AjoutRDV.Click
        Dim p As RENDVOUS
        With p
            p.code = txt_code2.Text
            p.date1 = date1.Value
            p.heure = txt_heure.Text
        End With
        If ajoutER_RDV(p) Then
            MessageBox.Show("RDV ajouter avec succées")
        Else
            MessageBox.Show("le tableau est saturé")
        End If
        txt_code2.Clear()
        txt_heure.Clear()


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class