Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Module Connection
    Public ind_spr_Permission As New List(Of String)
    Public Spr_Permission As New List(Of String)
    Public status_show_permission = "off"
    Public chkbox_status_permission = "not_all"
    Public ex_text
    Public field_ex
    Public Spr_Datas_per As New List(Of String)
    Public p_ex_num As Integer
    Public status_drop As String
    Public ex_no_field
    Public status_show = "off"
    Public database_query_status As String
    Public Spr_Datas As New List(Of String)
    Public ind_spr As New List(Of String)
    Public i
    Public in_put
    Public out_put
    Public dtCustomers As New DataTable
    Public chkbox_status As String = "not_all"
    Public communication As String = "Data Source=103.207.1.94;Initial Catalog=communication;User ID=mzcet;Password=checkme@987"
    Public user As String = "Data Source=103.207.1.94;Initial Catalog=userdatabase;User ID=mzcet;Password=checkme@987"

    Public Function ReadFromDatabase(ByVal SQL As String) As DataTable
        Dim dtReturn As New DataTable
        Try
            'Open the connection using the connection string
            Using conn As New SqlClient.SqlConnection(communication)
                conn.Open()

                Using cmd As New SqlClient.SqlCommand()
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    Dim da As New SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dtReturn)
                    database_query_status = "Query Excuted Successfuly"
                End Using
                conn.Close()

            End Using
        Catch ex As Exception
            'database_query_status = ex.Message.ToString()
            MsgBox(ex.ToString)
        End Try


        'Return the result data set
        Return dtReturn
    End Function














End Module
