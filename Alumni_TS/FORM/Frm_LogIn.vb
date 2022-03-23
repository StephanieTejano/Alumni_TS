Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_LogIn
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-REBBTM8U\MSSQLSERVER01;Initial Catalog=dbALUMNITRACKING;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from tblUsers where Username= '" + UsernameTextBox.Text + "' and Password= '" + PasswordTextBox.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count < 0) Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim frm As New Frm_MAIN()

            Me.Hide()

            frm.Show()

        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
