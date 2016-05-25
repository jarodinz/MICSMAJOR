Imports System.ComponentModel
Public Class Studentslist
    Implements INotifyPropertyChanged

    Private _firstname As String
    Private _lastname As String
    Private _mark As Integer

    Sub New(firstname As String,
            lastname As String,
            mark As Integer)

        _firstname = firstname
        _lastname = lastname
        _mark = mark

    End Sub

    Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
            OnPropertyChanged("Firstname")

        End Set
    End Property

    Property Surname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
            OnPropertyChanged("Surname")

        End Set
    End Property

    Property mark As String
        Get
            Return _mark
        End Get
        Set(value As String)
            _mark = value
            OnPropertyChanged(mark)

        End Set
    End Property

    Protected Sub OnPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged
End Class
