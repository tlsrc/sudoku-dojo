Public Class Sudokuv2
    Private _grille As New Dictionary(Of Coordinates, Integer)

    Public Sub New()
    End Sub

    Sub SetValue(coordinates As Coordinates, p2 As Integer)
        _grille.Add(coordinates, p2)
    End Sub

    Function GetValue(coordinates As Coordinates) As Object
        Return _grille(coordinates)
    End Function

End Class
