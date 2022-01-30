Public Class Guardian_Form
    Dim lname As String = ""
    Dim fname As String = ""
    Dim mname As String = ""
    Dim suffix As String = ""
    Dim address As String = ""
    Dim contact As String = ""
    Dim fb As String = ""


    Dim sql As String = ""
    Private Sub Guardian_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call _openKonneksyon()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lname = lastname.Text.ToString
        fname = firstname.Text.ToString
        mname = middlename.Text.ToString
        suffix = suffix_tb.Text.ToString
        address = add.Text.ToString
        contact = cp_no.Text.ToString
        fb = fb_acc.Text.ToString

        Dim sql As String = ""

        sql = "INSERT INTO tblGuardianDetails(GLName
            ,GFName
            ,GMName
            ,GSuffix
            ,GAddress
            ,GCpnum
            ,GFbAccount
            ,DateCreated)
 VALUES('" & lname & "'
            ,'" & fname & "'
            ,'" & mname & "'
            ,'" & suffix & "'
            ,'" & address & "'
            ,'" & contact & "'
            ,'" & fb & "'
            ,GETDATE())"
        Dim result As DialogResult = MessageBox.Show("Click ok to continue.", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Call _save(sql)
        Else

        End If
    End Sub
End Class