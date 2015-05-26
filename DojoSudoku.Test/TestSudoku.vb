<TestClass()> Public Class TestSudoku

    <TestMethod()> Public Sub GetSetValue()
        Dim sudoku As New Sudoku


        sudoku.SetValue(1, 1, 9)
        sudoku.SetValue(1, 2, 6)

        Assert.AreEqual(sudoku.GetValue(1, 1), 9)
        Assert.AreEqual(sudoku.GetValue(1, 2), 6)
    End Sub

    <TestMethod> Public Sub GetSetValueV2()
        Dim sudoku As New Sudokuv2
        sudoku.SetValue(New Coordinates(1, 1), 9)
        sudoku.SetValue(New Coordinates(1, 2), 6)

        Assert.AreEqual(sudoku.GetValue(New Coordinates(1, 1)), 9)
        Assert.AreEqual(sudoku.GetValue(New Coordinates(1, 2)), 6)
    End Sub


    Public Class Sudoku
        Private _grille As New List(Of List(Of Integer))

        Public Sub New()
            For index = 0 To 8
                Dim list = New List(Of Integer)()
                For index2 = 0 To 8
                    list.Add(0)
                Next
                _grille.Add(list)
            Next
        End Sub

        Public Sub SetValue(ByVal ligne As Integer, ByVal col As Integer, ByVal val As Integer)
            _grille(ligne - 1)(col - 1) = val
        End Sub

        Public Function GetValue(ByVal ligne As Integer, ByVal col As Integer) As Integer
            Return _grille(ligne - 1)(col - 1)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean
            If Object.ReferenceEquals(obj, Me) Then
                Return True
            End If
            Dim otherSudoku As Sudoku = DirectCast(obj, Sudoku)
            Return True
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return 1
        End Function

    End Class
End Class
