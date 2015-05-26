Public Class Matrice

    Private _valeurs(3, 3) As Integer

    Public Sub New()

    End Sub
    Public Sub New(ByVal valeurs()() As Integer)

    End Sub

    Public Function EstRemplie() As Boolean
        Return True
    End Function

    Function ObtenirValeur(p1 As Integer, p2 As Integer) As Integer
        Return 3
    End Function

    Sub AjouterValeur(p1 As Integer, p2 As Integer, p3 As Integer)
        Throw New NotImplementedException
    End Sub

    Function Valider() As Boolean
        return True
    End Function

End Class
