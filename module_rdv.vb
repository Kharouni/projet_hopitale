Module rdvvb
    Public Structure RENDVOUS
        Dim code As String
        Dim date1 As Date
        Dim heure As String

    End Structure
    Public TABrdv(100) As RENDVOUS
    Dim nb As Integer
    Public Function ajoutER_RDV(p As RENDVOUS) As Boolean
        If nb < TABrdv.Length Then
            TABrdv(nb) = p
            nb += 1
            Return True
        Else Return False
        End If
    End Function
    Public Function afficher1(dgb As DataGridView)
        Dim p As RENDVOUS
        Dim l As Integer

        For Each p In TABrdv

            If p.code IsNot Nothing Then

                dgb.Rows.Add(p.code, p.date1, p.heure)
                l = l + 1
            End If
        Next
    End Function

End Module
