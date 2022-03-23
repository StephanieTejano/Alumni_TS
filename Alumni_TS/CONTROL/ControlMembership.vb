Public Class ControlMembership


    Dim sql As String = ""
    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Frm_AddMember.ShowDialog()
    End Sub

    Private Sub ControlMembership_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        Sql = "SELECT * FROM tblMembership"
        Call _populateGridview(Sql, GridControl1, GridView1)
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim sql As String = "SELECT ID, StudentID, AcademicYear, MembershipType FROM tblMembership WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Frm_AddMember.studid.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Frm_AddMember.acadyear.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Frm_AddMember.memtype.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Frm_AddMember.ShowDialog()
    End Sub

    Private Sub Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Print.ItemClick
        Dim sql As String = "DELETE FROM tblMembership WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub
End Class