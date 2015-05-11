
Imports System.ComponentModel 'This does something that makes INotifyPropertyChanged Work

Public Class Cruise
    Implements INotifyPropertyChanged
    Property ID As Integer
    Property ReservationNumber As String
    Property NickName As String
    Property Departure As Date
    Property Arrival As Date
    Property DepartureLocation As String
    Property ArrivalLocation As String
    Property Passengers As Passenger
    Property Ship As Ship
    Property Fare As Decimal
    Property Payments As Decimal
    Property Gratuities As Decimal 'The PrePaid Variety
    Property TaxesFees As Decimal
    ReadOnly Property BalanceDue As Decimal
        Get
            Return (Fare + Gratuities + TaxesFees) - Payments
        End Get
    End Property

    Sub New(ByVal Name As String)
        NickName = Name
    End Sub




    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class



