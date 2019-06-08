Imports System.Windows.Threading

Public Class UpgradeDialog

    'Private timer As DispatcherTimer
    Private _upgraders As List(Of UpgraderBase)

    Public Sub New(upgraders As List(Of UpgraderBase))

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        _upgraders = upgraders
        UpgraderList.ItemsSource = _upgraders

        'timer = New DispatcherTimer()
        'timer.Interval = TimeSpan.FromMilliseconds(2500)
        'AddHandler timer.Tick, AddressOf TimerTick
        'timer.Start()
    End Sub

    'Private Sub TimerTick(sender As Object, e As EventArgs)

    '    timer.Stop()
    '    _upgraders.Add(New Upgrader() With {.Title = "new", .Done = True})
    '    _upgraders(1).Title = "timed"
    '    _upgraders(1).Done = Not _upgraders(1).Done
    'End Sub

    Public Sub DoEvents()
        Me.Dispatcher.Invoke(DispatcherPriority.Background,
    New Action(Function() 7))
    End Sub
End Class
