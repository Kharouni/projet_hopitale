Module Module_patient
    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String

    End Structure
    Public patients(100) As patient
    Dim nb As Integer
    Public Function ajout_patient(p As patient) As Boolean
        If nb < patients.Length Then
            patients(nb) = p
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Public Function afficher(dgb As DataGridView)
        Dim p As patient
        Dim l As Integer

        For Each p In patients

            If p.nom IsNot Nothing Then

                dgb.Rows.Add(p.code, p.nom, p.prenom)
                l = l + 1
            End If
        Next
    End Function
End Module
