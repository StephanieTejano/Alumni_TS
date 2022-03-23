Public Class Frm_AddMember


    Dim stud_id As String = ""
    Dim acad_year As String = ""
    Dim mem_type As String = ""

    Dim sql As String = ""

    Private Sub Add_MemberForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stud_id = studid.Text.ToString
        acad_year = acadyear.Text.ToString
        mem_type = memtype.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblMembership(StudentID
            ,AcademicYear
            ,MembershipType
            ,DateCreated)
VALUES('" & stud_id & "'
            ,'" & acad_year & "'
            ,'" & mem_type & "'
            ,GETDATE())"

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class