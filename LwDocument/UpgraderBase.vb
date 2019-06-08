Imports System.ComponentModel

Public MustInherit Class UpgraderBase
    Implements INotifyPropertyChanged

    Private _done As Boolean = False
    Public Property Done As Boolean
        Get
            Return _done
        End Get
        Set(value As Boolean)
            _done = value
            RaisePropertyChanged(NameOf(Me.Done))
        End Set
    End Property

    Private _title As String
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            _title = value
            RaisePropertyChanged(NameOf(Me.Title))
        End Set
    End Property

    Public Sub New(title As String)
        _title = title
    End Sub

    Private Sub RaisePropertyChanged(propName As String)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

End Class
