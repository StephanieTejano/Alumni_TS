Public Class ControlAlumni

    Dim sql As String = ""

    Private Sub ControlAlumni_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        sql = "SELECT * FROM tblAlumni"

        Call _populateGridview(sql, GridControl2, GridView2)

    End Sub

    Private Sub AddButton_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Frm_Alumni.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim sql As String = "SELECT ID, StudentID, AcademicYearGraduated, CompanyName, JobTitle FROM tblAlumni WHERE ID=" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Frm_Alumni.studid.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Frm_Alumni.acadyear.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Frm_Alumni.compname.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Frm_Alumni.job_tb.Text = dset.Tables(sql).Rows(0).ItemArray(4).ToString
        Frm_Alumni.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim sql As String = "DELETE FROM tblAlumni WHERE ID=" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID").ToString

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub
End Class
