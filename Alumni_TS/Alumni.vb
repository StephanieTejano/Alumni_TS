Public Class Alumni

    Dim stud_ID As String = ""
    Dim acad_year As String = ""
    Dim job_title As String = ""
    Dim comp_name As String = ""

    Dim sql As String = ""

    Private Sub Alumni_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stud_ID = studid.Text.ToString
        acad_year = acadyear.Text.ToString
        job_title = job_tb.Text.ToString
        comp_name = compname.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblAlumni(StudentID
            ,AcademicYearGraduated
            ,CompanyName
            ,JobTitle
            ,DateCreated)
VALUES('" & stud_ID & "'
            ,'" & acad_year & "'
            ,'" & job_title & "'
            ,'" & comp_name & "'
            ,GETDATE())"

        Call _save(sql)
    End Sub
End Class