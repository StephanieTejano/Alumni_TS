Public Class ControlMembership
    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Membership.ShowDialog()
    End Sub
End Class
