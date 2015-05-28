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
        Dim valeursDeLaLigne As List(Of Integer) = GetLigne(numeroLigne)

        For valeur As Integer = 1 To _maxValue
            If CompterOccurence(valeursDeLaLigne, valeur) > 1 Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function CompterOccurence(ByVal valeursDeLaLigne As List(Of Integer), ByVal valeur As Integer) As Integer

        Return valeursDeLaLigne.Where(Function(x) x = valeur).Count
    End Function

    Private Function GetLigne(ByVal numeroLigne As Integer) As List(Of Integer)
        Dim valeursDeLaLigne As New List(Of Integer)
        For colonne As Integer = 1 To _maxValue
            Dim coordinate As New Coordinates(numeroLigne, colonne)
            valeursDeLaLigne.Add(GetValue(coordinate))
        Next
        Return valeursDeLaLigne
    End Function
End Class
