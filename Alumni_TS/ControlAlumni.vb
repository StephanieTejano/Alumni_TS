Public Class ControlAlumni

    Dim sql As String = ""

    Private Sub ControlAlumni_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        sql = "SELECT * FROM tblAlumni"

        Call _populateGridview(sql, GridControl2, GridView2)

    End Sub

    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Alumni.ShowDialog()
    End Sub
End Class
