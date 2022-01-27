Imports System.Data.SqlClient

Module Module1
    Public da As New SqlDataAdapter
    Public dset As New DataSet

    ReadOnly Dim str As String

    ReadOnly Dim server As String = "LAPTOP-REBBTM8U\MSSQLSERVER01"
    ReadOnly Dim username As String = "user"
    ReadOnly Dim password As String = "SKYLER18282020"
    ReadOnly Dim database As String = "dbALUMNITRACKING"


    Public konStr As String = "Data Source='" & server & "';User='" & username & "';password='" & password & "'; Initial Catalog='" & database & "';"


    Public kon As New SqlConnection(konStr)

    ''' ================================================================================================
    ''' KONNEKSYON
    ''' ================================================================================================

    Public Sub _openKonneksyon()
        Try
            If kon.State = ConnectionState.Closed Then
                kon.Open() : MessageBox.Show("Database Successfully Connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' ================================================================================================
    ''' POPULATE GRID CONTROL
    ''' ================================================================================================

    Public Sub _populateGridview(ByVal sql As String, ByVal GridControl As DevExpress.XtraGrid.GridControl, ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            da = New SqlDataAdapter(sql, kon)
            dset = New DataSet

            da.Fill(dset, sql)
            GridControl.DataSource = dset.Tables(sql)
            GridView.PopulateColumns()
        Catch ex As Exception

        End Try
        GridView.BestFitColumns()
    End Sub

    ''' ================================================================================================
    ''' SQL QUERY
    ''' ================================================================================================


    Public Sub _save(ByVal saverec As String)
        Try
            Using kom = New SqlCommand
                kom.Connection = kon

                kom.CommandText = saverec
                kom.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("save() - > " & ex.Message & vbCrLf & vbCrLf & saverec)
            Console.WriteLine(saverec)
        End Try
    End Sub


End Module
