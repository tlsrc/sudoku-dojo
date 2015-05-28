<TestClass()> Public Class TestSudoku

    <TestMethod> Public Sub GetSetValue()
        Dim sudoku As New Sudoku
        sudoku.SetValue(New Coordinates(1, 1), 9)
        sudoku.SetValue(New Coordinates(1, 2), 6)

        Assert.AreEqual(sudoku.GetValue(New Coordinates(1, 1)), 9)
        Assert.AreEqual(sudoku.GetValue(New Coordinates(1, 2)), 6)
    End Sub

    <TestMethod> Public Sub EstCeQueLigneValide()
        Dim sudoku As New Sudoku
        sudoku.SetValue(New Coordinates(1, 1), 1)
        sudoku.SetValue(New Coordinates(1, 2), 2)
        sudoku.SetValue(New Coordinates(1, 3), 3)
        sudoku.SetValue(New Coordinates(1, 4), 4)
        sudoku.SetValue(New Coordinates(1, 5), 5)
        sudoku.SetValue(New Coordinates(1, 6), 6)
        sudoku.SetValue(New Coordinates(1, 7), 7)
        sudoku.SetValue(New Coordinates(1, 8), 8)
        sudoku.SetValue(New Coordinates(1, 9), 9)

        Assert.IsTrue(sudoku.isLineValid(1))

    End Sub

    <TestMethod> Public Sub EstCeQueLigneInvalid()
        Dim sudoku As New Sudoku

        sudoku.SetValue(New Coordinates(1, 1), 1)
        sudoku.SetValue(New Coordinates(1, 2), 1)
        sudoku.SetValue(New Coordinates(1, 3), 1)
        sudoku.SetValue(New Coordinates(1, 4), 1)
        sudoku.SetValue(New Coordinates(1, 5), 1)
        sudoku.SetValue(New Coordinates(1, 6), 1)
        sudoku.SetValue(New Coordinates(1, 7), 1)
        sudoku.SetValue(New Coordinates(1, 8), 1)
        sudoku.SetValue(New Coordinates(1, 9), 1)

        Assert.IsFalse(sudoku.isLineValid(1))
    End Sub

    <TestMethod> Public Sub EstCeQueLigneValideAvecColonnesIncompletes()
        Dim sudoku As New Sudoku
        Dim numeroLigne As Integer = 1
        sudoku.SetValue(New Coordinates(numeroLigne, 1), 1)
        sudoku.SetValue(New Coordinates(numeroLigne, 2), 2)
        sudoku.SetValue(New Coordinates(numeroLigne, 3), 3)
        sudoku.SetValue(New Coordinates(numeroLigne, 6), 6)
        sudoku.SetValue(New Coordinates(numeroLigne, 7), 7)
        sudoku.SetValue(New Coordinates(numeroLigne, 8), 8)
        sudoku.SetValue(New Coordinates(numeroLigne, 9), 9)

        Assert.IsTrue(sudoku.IsLineValid(numeroLigne))

    End Sub

End Class
