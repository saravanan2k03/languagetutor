Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class add_ex
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ex_no.Text = "" Or exercise.Text = "" Then
            MessageBox.Show("Please Enter All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim con As SqlConnection = New SqlConnection(communication)
            con.Open()
            Dim cmd1 As New SqlCommand("select Top 1 ex_id from ex_table ORDER BY ID DESC", con)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader()
            Dim resultString As String = Regex.Replace(exercise.Text, "[^\w\s]", "")


            If myreader.HasRows = True Then
                myreader.Read()
                Dim ex As String = myreader("ex_id")
                Dim ex_num = ex.Split(" ")
                Dim x_no As Integer = Integer.Parse(ex_num(1).ToString)
                Dim ex_number = x_no + 1
                d_t()
                dtCustomers = ReadFromDatabase("insert into ex_table (ex_id,ex_text,date_time,created_by,status)values('" + "Exercise " + ex_number.ToString + "','" + resultString.ToString + "','" + c_dt.ToString + "','" + StaffId.ToString + "','Active')")
                MessageBox.Show("Exercise Added!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                exercise_no()
                exercise.Text = ""
                exercise.Focus()
            Else
                d_t()
                dtCustomers = ReadFromDatabase("insert into ex_table (ex_id,ex_text,date_time,created_by,status)values('" + "Exercise " + ex_no.Text + "','" + exercise.Text + "','" + c_dt.ToString + "','" + StaffId.ToString + "','Active')")
                MessageBox.Show("Exercise Added!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                exercise_no()
                exercise.Text = ""
                exercise.Focus()
            End If

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub add_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exercise_no()

    End Sub

    Private Sub exercise_no()
        Dim con As SqlConnection = New SqlConnection(communication)
        con.Open()
        Dim cmd1 As New SqlCommand("select Top 1 ex_id from ex_table ORDER BY ID DESC", con)

        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        If myreader.HasRows = True Then
            myreader.Read()
            Dim ex As String = myreader("ex_id")
            Dim ex_num = ex.Split(" ")
            Dim x_no As Integer = Integer.Parse(ex_num(1).ToString)
            Dim ex_number = x_no + 1
            ex_no.Text = ex_number.ToString
        Else
            ex_no.Text = 1

        End If

        con.Close()
    End Sub
End Class