Public Class ControlGuardian


    Dim sql As String = ""
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim sql As String = "DELETE FROM tblGuardianDetails WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Frm_Guardian.ShowDialog()
    End Sub
    Private Sub ControlGuardian_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        Sql = "SELECT * FROM tblGuardianDetails"

        Call _populateGridview(Sql, GridControl1, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim sql As String = "SELECT ID, GLName, GFName, GMName, GSuffix, GAddress, GCpnum, GFbAccount FROM tblGuardianDetails WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Frm_Guardian.lastname.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Frm_Guardian.firstname.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Frm_Guardian.middlename.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Frm_Guardian.suffix_tb.Text = dset.Tables(sql).Rows(0).ItemArray(4).ToString
        Frm_Guardian.add.Text = dset.Tables(sql).Rows(0).ItemArray(5).ToString
        Frm_Guardian.cp_no.Text = dset.Tables(sql).Rows(0).ItemArray(6).ToString
        Frm_Guardian.fb_acc.Text = dset.Tables(sql).Rows(0).ItemArray(7).ToString
        Frm_Guardian.ShowDialog()
    End Sub
End Class
