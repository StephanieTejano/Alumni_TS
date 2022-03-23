Public Class Frm_Student

    Dim stud_ID As String = ""
    Dim memberid As String = ""
    Dim lname As String = ""
    Dim fname As String = ""
    Dim mname As String = ""
    Dim suffix As String = ""
    Dim sex As String = ""
    Dim birthday As String = ""
    Dim year As String = ""
    Dim cpnum As String = ""
    Dim presentadd As String = ""
    Dim permanentadd As String = ""
    Dim placeofbirth As String = ""
    Dim email As String = ""
    Dim fb As String = ""

    Dim sql As String = ""
    Private Sub Student_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stud_ID = studid.Text.ToString
        memberid = membershipid.Text.ToString
        lname = lastname.Text.ToString
        fname = firstname.Text.ToString
        mname = middlename.Text.ToString
        suffix = suffix_tb.Text.ToString
        sex = sex_tb.Text.ToString
        birthday = bday.Text.ToString
        year = year_tb.Text.ToString
        cpnum = cpnumber.Text.ToString
        presentadd = prebarangay.Text.ToString + "," + premunicipality.Text.ToString + "," + preprovince.Text.ToString
        permanentadd = perbarangay.Text.ToString + "," + permunicipality.Text.ToString + "," + perprovince.Text.ToString
        placeofbirth = birthplace.Text.ToString
        email = email_tb.Text.ToString
        fb = fb_tb.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblStudent(StudentID
            ,LName
            ,FName
            ,MName
            ,Suffix
            ,Sex
            ,Birthday
            ,Year
            ,ContactNumber
            ,PresentAddress
            ,PermanentAddress
            ,PlaceOfBirth
            ,Email
            ,FBAccount
            ,DateCreated)
VALUES('" & stud_ID & "'
            ,'" & lname & "'
            ,'" & fname & "'
            ,'" & mname & "'
            ,'" & suffix & "'
            ,'" & sex & "'
            ,' " & birthday & "'
            ,' " & year & "'
            ,'" & cpnum & "'
            ,'" & presentadd & "'
            ,'" & permanentadd & "'
            ,'" & placeofbirth & "'
            ,'" & email & "'
            ,'" & fb & "'
            ,GETDATE())"

        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_AddGuardian.ShowDialog()
    End Sub
End Class