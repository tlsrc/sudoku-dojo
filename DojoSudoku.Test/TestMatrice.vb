Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DojoSudoku.Test.TestSudoku

<TestClass()> Public Class TestMatrice

    <TestMethod()> Public Sub EstisSudokosolved()
        Dim sudokuSolver As New SudokuSolver()
        Dim sudoku As New Sudoku()
        'sudoku = getInitialSudoku()

        Dim solvedSudoku As New Sudoku()


        Assert.AreEqual(sudokuSolver.solve(sudoku), solvedSudoku)
    End Sub

    Private Function getInitialSudoku()

    End Function


    Public Class SudokuSolver
        Public Function solve(ByVal sudoku As Sudoku) As Sudoku
            Return sudoku
        End Function
    End Class




End Class