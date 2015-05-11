Public Class Person
    Property FirstName As String
    Property LastName As String
    Property Birthday As Date
    ReadOnly Property Age As Integer
        Get
            Return DateDiff(DateInterval.Year, Now, Birthday, FirstDayOfWeek.Sunday)
        End Get
    End Property
End Class
