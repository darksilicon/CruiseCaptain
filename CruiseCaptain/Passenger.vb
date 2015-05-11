Public Class Passenger
    Property FirstName As String
    Property LastName As String
    Property Birthday As Date
    Property CaptainsClubNo As String
    'This is incomplete doesnt reutrn accurate results unless the birthday is on the right side of the year. 
    ReadOnly Property Age
        Get
            Return DateDiff(DateInterval.Day, Now(), Birthday, FirstDayOfWeek.Sunday)
        End Get
    End Property

End Class
