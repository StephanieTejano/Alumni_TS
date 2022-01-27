Public Class AddUser

    Dim user_ID As String = ""
    Dim password As String = ""
    Dim fname As String = ""
    Dim accounttype As String = ""

    Dim sql As String = ""

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        user_ID = userid.Text.ToString
        password = pass.Text.ToString
        fname = name_tb.Text.ToString
        accounttype = acctype.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblUsers(UserID
            ,Password
            ,Name
            ,AccountType
            ,DateCreated)
VALUES('" & user_ID & "'
            ,'" & password & "'
            ,'" & fname & "'
            ,'" & accounttype & "'
            ,GETDATE())"

        Call _save(sql)

    End Sub
End Class