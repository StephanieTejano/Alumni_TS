Public Class ControlProfessors

    Dim sql As String = ""
    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Professors_Information.ShowDialog()
    End Sub

    Private Sub ControlProfessors_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        sql = "SELECT * FROM tblProfessor"

        Call _populateGridview(sql, GridControl1, GridView1)
    End Sub
End Class
