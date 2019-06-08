Public Class UpgradeService

    Private _upgraders As List(Of UpgraderBase)

    Public Sub New()
        _upgraders = New List(Of UpgraderBase)
        _upgraders.Add(New Upgrader1() With {.Title = "One", .Done = False})
        _upgraders.Add(New Upgrader2() With {.Title = "Two", .Done = False})

    End Sub

    Public Sub Upgrade()


        Dim dlg As New UpgradeDialog(_upgraders)
        dlg.Show()

        For i As Integer = 0 To _upgraders.Count - 1

            Dim currUpgr = _upgraders(i)
            Threading.Thread.Sleep(2500)
            currUpgr.Done = True
            currUpgr.Title = "modified"

            dlg.DoEvents()
        Next
    End Sub
End Class
