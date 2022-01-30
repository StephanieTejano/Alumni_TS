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

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim sql As String = "SELECT ID, ProfID, ProfLName, ProfFName, ProfMName, ProfSuffix, ProfAddress, ProfSex, ProfContactNumber, ProfEmailAddress, ProfFBAccount FROM tblProfessor WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Professors_Information.profid.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Professors_Information.lname.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Professors_Information.fname.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Professors_Information.mname.Text = dset.Tables(sql).Rows(0).ItemArray(4).ToString
        Professors_Information.suffix_tb.Text = dset.Tables(sql).Rows(0).ItemArray(5).ToString
        Professors_Information.add.Text = dset.Tables(sql).Rows(0).ItemArray(6).ToString
        Professors_Information.sex_tb.Text = dset.Tables(sql).Rows(0).ItemArray(7).ToString
        Professors_Information.cpnum.Text = dset.Tables(sql).Rows(0).ItemArray(8).ToString
        Professors_Information.email.Text = dset.Tables(sql).Rows(0).ItemArray(9).ToString
        Professors_Information.fb.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Professors_Information.ShowDialog()
    End Sub
End Class
