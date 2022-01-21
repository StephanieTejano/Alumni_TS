Public Class ControlAlumni
    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Alumni.ShowDialog()
    End Sub
End Class
