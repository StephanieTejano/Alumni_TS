Public Class ControlStudent

    Dim sql As String = ""
    Private Sub add_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles add_button.ItemClick
        Frm_Student.ShowDialog()

    End Sub

    Private Sub ControlStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()

        sql = "SELECT * FROM tblStudent"

        Call _populateGridview(sql, GridControl1, GridView1)

    End Sub

    Private Sub edit_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit_button.ItemClick
        Dim sql As String = "SELECT ID, StudentID, LName, FName, MName, Suffix, Sex, Birthday, Year, ContactNumber, PresentAddress, PermanentAddress, PlaceOfBirth, Email, FBAccount FROM tblStudent WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Frm_Student.studid.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Frm_Student.lastname.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Frm_Student.firstname.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Frm_Student.middlename.Text = dset.Tables(sql).Rows(0).ItemArray(4).ToString
        Frm_Student.suffix_tb.Text = dset.Tables(sql).Rows(0).ItemArray(5).ToString
        Frm_Student.sex_tb.Text = dset.Tables(sql).Rows(0).ItemArray(6).ToString
        Frm_Student.bday.Text = dset.Tables(sql).Rows(0).ItemArray(7).ToString
        Frm_Student.year_tb.Text = dset.Tables(sql).Rows(0).ItemArray(8).ToString
        Frm_Student.cpnumber.Text = dset.Tables(sql).Rows(0).ItemArray(9).ToString
        Frm_Student.prebarangay.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Frm_Student.premunicipality.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Frm_Student.preprovince.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Frm_Student.perbarangay.Text = dset.Tables(sql).Rows(0).ItemArray(11).ToString
        Frm_Student.permunicipality.Text = dset.Tables(sql).Rows(0).ItemArray(11).ToString
        Frm_Student.perprovince.Text = dset.Tables(sql).Rows(0).ItemArray(11).ToString
        Frm_Student.birthplace.Text = dset.Tables(sql).Rows(0).ItemArray(12).ToString
        Frm_Student.email_tb.Text = dset.Tables(sql).Rows(0).ItemArray(13).ToString
        Frm_Student.fb_tb.Text = dset.Tables(sql).Rows(0).ItemArray(14).ToString
        Frm_Student.ShowDialog()

    End Sub

    Private Sub delete_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles delete_button.ItemClick
        Dim sql As String = "DELETE FROM tblStudent WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub
End Class
