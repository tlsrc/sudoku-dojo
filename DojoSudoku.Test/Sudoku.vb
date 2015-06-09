Imports System.Security.Cryptography

Public Class Sudoku
    Private Const _maxValue As Integer = 9
    Private ReadOnly _grille As New Dictionary(Of Coordinates, Integer)


    Public Sub New()
        InitializeGrille()

    End Sub

    Private Sub InitializeGrille()

        For ligne = 1 To _maxValue
            For colonne = 1 To _maxValue
                SetValue(New Coordinates(ligne, colonne), 0)
            Next
        Next
    End Sub

    Sub SetValue(coordinates As Coordinates, p2 As Integer)
        _grille(coordinates) = p2
    End Sub

    Function GetValue(coordinates As Coordinates) As Object
        Return _grille(coordinates)
    End Function

    Public Function IsLineValid(numeroLigne As Integer) As Boolean
        Dim ligne As Ligne = GetLigne(numeroLigne)
        Return ligne.EstValide()
    End Function

    Function EstColonneValide(numeroColonne As Integer) As Boolean
        Dim colonne As Ligne = GetColonne(numeroColonne)
        Return colonne.EstValide
    End Function

    Private Function CompterOccurence(ByVal valeursDeLaLigne As List(Of Integer), ByVal valeur As Integer) As Integer
        Return valeursDeLaLigne.Where(Function(x) x = valeur).Count
    End Function

    Private Function GetLigne(ByVal numeroLigne As Integer) As ligne
        Dim ligne As New Ligne
        For colonne As Integer = 1 To _maxValue
            Dim coordinate As New Coordinates(numeroLigne, colonne)
            ligne.InitialiserValeur(GetValue(coordinate))
        Next
        Return ligne
    End Function

    Private Function GetColonne(numeroColonne As Integer) As Ligne
        Dim colonne As New Ligne
        For ligne As Integer = 1 To _maxValue
            Dim coordinate As New Coordinates(ligne, numeroColonne)
            colonne.InitialiserValeur(GetValue(coordinate))
        Next
        Return colonne
    End Function

End Class
