Public Class login
    Private Sub init()
        txt_admin.Clear()
        txt_mdp.Clear()
    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As String
        Dim mdp As String
        login = txt_admin.Text
        mdp = txt_mdp.Text
        If (login = "admin") And (mdp = "1234") Then
            Me.Hide()
            frm_main.Show()
        Else
            init()
        End If
    End Sub





    Private Sub txt_admin_TextChanged(sender As Object, e As EventArgs) Handles txt_admin.TextChanged

    End Sub

    Private Sub txt_mdp_TextChanged(sender As Object, e As EventArgs) Handles txt_mdp.TextChanged

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim login As String
        Dim mdp As String
        login = txt_admin.Text
        mdp = txt_mdp.Text
        If (login = "admin") And (mdp = "1234") Then
            Me.Hide()
            MessageBox.Show("Connexion validé")
            frm_main.Show()

        Else
            MessageBox.Show("Nom ou mdp incorrecte")
            init()
        End If
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Me.Close()
    End Sub
End Class