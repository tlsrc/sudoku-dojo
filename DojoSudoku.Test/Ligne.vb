Public Class Ligne

    Private ReadOnly _valeurs As New List(Of Integer)

    'TODO : Tenter de passer le sudoku a l'objet Ligne afin de deplacer la logique d'initilaisation de la ligne dans l'objet.

    Public Sub InitialiserValeur(valeur As Integer)
        _valeurs.Add(valeur)
    End Sub

    Public Function EstValide() As Boolean
        Dim listeValeurReelles = ObtenirListeValeursReelles()
        Return listeValeurReelles.Distinct().Count = listeValeurReelles.Count
    End Function

    Private Function ObtenirListeValeursReelles() As List(Of Integer)
        Return _valeurs.Where(Function(x) x <> 0).ToList()
    End Function

End Class
