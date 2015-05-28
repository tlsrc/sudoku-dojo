<TestClass> Public Class CoordinatesTest

    <TestMethod> Public Sub SameXAndYMeansEqualsCoordinates()
        Dim coordinates As New Coordinates(1, 1)
        Dim sameCoordinates As New Coordinates(1, 1)
        Dim otherCoordinates As New Coordinates(1, 2)

        Assert.AreEqual(coordinates, sameCoordinates)
        Assert.AreNotEqual(coordinates, otherCoordinates)
    End Sub

End Class

Public Class Coordinates

    Sub New(ligne As Integer, colonne As Integer)
        X = ligne
        Y = colonne
    End Sub

    Public Property X As Integer
    Public Property Y As Integer

    Public Overrides Function Equals(obj As Object) As Boolean
        If Not (TypeOf obj Is Coordinates) Then Return False
        Dim otherCoordinates = DirectCast(obj, Coordinates)
        Return otherCoordinates.X = X AndAlso otherCoordinates.Y = Y
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return 1
    End Function
End Class
