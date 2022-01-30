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

    Private Sub edit_button_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit_button.ItemClick
        Dim sql As String = "SELECT ID, StudentID, LName, FName, MName, Suffix, Sex, Birthday, ContactNumber, PresentAddress, PermanentAddress, PlaceOfBirth, Email, FBAccount FROM tblStudent WHERE ID=" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString

        Call _populate(sql)

        Student_Form.studid.Text = dset.Tables(sql).Rows(0).ItemArray(1).ToString
        Student_Form.lastname.Text = dset.Tables(sql).Rows(0).ItemArray(2).ToString
        Student_Form.firstname.Text = dset.Tables(sql).Rows(0).ItemArray(3).ToString
        Student_Form.middlename.Text = dset.Tables(sql).Rows(0).ItemArray(4).ToString
        Student_Form.suffix_tb.Text = dset.Tables(sql).Rows(0).ItemArray(5).ToString
        Student_Form.sex_tb.Text = dset.Tables(sql).Rows(0).ItemArray(6).ToString
        Student_Form.bday.Text = dset.Tables(sql).Rows(0).ItemArray(7).ToString
        Student_Form.cpnumber.Text = dset.Tables(sql).Rows(0).ItemArray(8).ToString
        Student_Form.prebarangay.Text = dset.Tables(sql).Rows(0).ItemArray(9).ToString
        Student_Form.premunicipality.Text = dset.Tables(sql).Rows(0).ItemArray(9).ToString
        Student_Form.preprovince.Text = dset.Tables(sql).Rows(0).ItemArray(9).ToString
        Student_Form.perbarangay.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Student_Form.permunicipality.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Student_Form.perprovince.Text = dset.Tables(sql).Rows(0).ItemArray(10).ToString
        Student_Form.birthplace.Text = dset.Tables(sql).Rows(0).ItemArray(11).ToString
        Student_Form.email_tb.Text = dset.Tables(sql).Rows(0).ItemArray(12).ToString
        Student_Form.fb_tb.Text = dset.Tables(sql).Rows(0).ItemArray(13).ToString
        Student_Form.ShowDialog()

    End Sub
End Class
