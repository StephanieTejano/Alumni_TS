Public Class ControlStudent

    Dim sql As String = ""
    Private Sub add_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles add_button.ItemClick
        Student_Form.ShowDialog()

    End Sub

    Private Sub ControlStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        Sql = "SELECT * FROM tblStudent"

        Call _populateGridview(Sql, GridControl1, GridView1)

    End Sub
End Class
