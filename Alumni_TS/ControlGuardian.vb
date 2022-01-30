Public Class ControlGuardian


    Dim sql As String = ""
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Guardian_Form.ShowDialog()
    End Sub
    Private Sub ControlGuardian_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        Sql = "SELECT * FROM tblGuardianDetails"

        Call _populateGridview(Sql, GridControl1, GridView1)
    End Sub
End Class
