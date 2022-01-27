Public Class Professors_Information
    Dim prof_ID As String = ""
    Dim l_name As String = ""
    Dim f_name As String = ""
    Dim m_name As String = ""
    Dim suffix As String = ""
    Dim address As String = ""
    Dim cpnumber As String = ""
    Dim sex As String = ""
    Dim emailadd As String = ""
    Dim fbacc As String = ""

    Dim sql As String = ""

    Private Sub Professors_Information_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        prof_ID = profid.Text.ToString
        l_name = lname.Text.ToString
        f_name = fname.Text.ToString
        m_name = mname.Text.ToString
        suffix = suffix_tb.Text.ToString
        cpnumber = cpnum.Text.ToString
        address = add.Text.ToString
        emailadd = email.Text.ToString
        fbacc = fb.Text.ToString
        sex = sex_tb.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblProfessor(ProfID
            ,ProfLName
            ,ProfFName
            ,ProfMName
            ,ProfSuffix
            ,ProfContactNumber
            ,ProfAddress
            ,ProfEmailAddress
            ,ProfFBAccount
            ,DateCreated)
VALUES('" & prof_ID & "'
            ,'" & l_name & "'
            ,'" & f_name & "'
            ,'" & m_name & "'
            ,'" & suffix & "'
            ,'" & cpnumber & "'
            ,'" & address & "'
            ,'" & emailadd & "'
            ,'" & fbacc & "'
            ,GETDATE())"

        Call _save(sql)
    End Sub


End Class