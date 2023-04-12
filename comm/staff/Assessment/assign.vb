Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Xml

Public Class assign
    Dim t1
    Dim cnt
    Public Sub create_assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Input.ReadOnly = True

        t1 = group_id.ToString
        id.Text = StaffId
        Name.Text = StaffName
        select_ex.Enabled = False
        Dim conn As New SqlConnection(communication)
        conn.Open()
        Dim cmd As New SqlCommand("select ex_id from ex_table where status='Active'", conn)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        While myreader.Read
            select_ex.Items.Add(myreader(0))
        End While
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_mode.SelectedIndexChanged
        If select_mode.Text = "Copy Text" Then
            Input.Text = ""
            select_ex.Enabled = False
            Input.ReadOnly = False

        Else
            select_ex.Enabled = True
            Input.ReadOnly = True

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_ex.SelectedIndexChanged
        Dim conn As New SqlConnection(communication)
        conn.Open()
        Dim cmd As New SqlCommand("select ex_text from ex_table where ex_id='" + select_ex.Text + "'", conn)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        myreader.Read()
        Dim text = myreader("ex_text")
        conn.Close()
        Input.Text = text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If select_mode.Text = "Exercise" And select_ex.Text = "" Then
            MessageBox.Show("Select Exercise !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        If select_mode.Text = "" Then
            MessageBox.Show("Select All Fields !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        ElseIf Input.Text = "" Then
            MessageBox.Show("Enter the Text !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            Dim rnd As New Random()
            Dim randomNumber As Integer = rnd.Next(10000, 99999)
            If select_mode.Text = "Copy Text" Then
                get_ex()
                Dim ex = "Exercise " + p_ex_num.ToString
                d_t()
                Dim resultString As String = Regex.Replace(Input.Text, "[^\w\s]", "")

                ReadFromDatabase("insert into ex_table (ex_id,ex_text,date_time,created_by,status)values('" + ex.ToString + "','" + resultString.ToString + "','" + c_dt.ToString + "','" + StaffId.ToString + "','Active')")
                insert_assign(ex.ToString)
            End If
            If select_mode.Text = "Exercise" Then
                insert_assign(select_ex.Text)

            End If


        End If




    End Sub
    Public Sub get_ex()
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
            p_ex_num = ex_number.ToString
        Else
            p_ex_num = 1
        End If

    End Sub
    Public Sub permissioneval(exercise)




        For i = 0 To Spr_Datas_Eval.Count - 1
            Dim con As SqlConnection = New SqlConnection(communication)
            con.Open()
            Dim cmd1 As New SqlCommand("Select spr_no, ex_id,assign_by from Eval where spr_no='" + Spr_Datas_Eval(i) + "' and ex_id='" + exercise + "' and assign_by='" + StaffId.ToString + "'", con)

            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader()
            myreader.Read()
            If myreader.HasRows = False Then

                ReadFromDatabase("INSERT INTO communication.dbo.Eval (spr_no,ex_id,assign_by,Active)values('" + Spr_Datas_Eval(i) + "','" + exercise + "','" + StaffId.ToString + "','1')")


            Else

            End If

        Next


    End Sub
    Public Sub insert_assign(exercise_id)
        Dim vals As String
        Dim vale As String
        Dim dur = duration.Text
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(10000, 99999)
        If chkbox_status = "select_all" Then
            For i = 0 To Spr_Datas.Count - 1
                Dim con As SqlConnection = New SqlConnection(communication)
                con.Open()
                Dim cmd1 As New SqlCommand("select ex_id,assign_by from communication.dbo.assign_table where assign_to ='" + Spr_Datas(i).ToString + "' and assign_by ='" + StaffId + "'and ex_id='" + exercise_id + "'", con)
                Dim myreader As SqlDataReader
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                If select_mode.Text = "Copy Text" Then
                    d_t()
                    ReadFromDatabase("INSERT INTO assign_table (ex_id,Assign_id,assign_by,assign_to,date_time,status,approved_date_time,approved_status,group_id,duration)values('" + exercise_id + "','" + randomNumber.ToString + "','" + StaffId + "','" + Spr_Datas(i) + "','" + c_dt.ToString + "','Not-attempted','','','" + t1.trim.ToString + "','" + dur.ToString + "')")
                Else

                    If myreader.HasRows = False Then
                        d_t()
                        ReadFromDatabase("INSERT INTO assign_table (ex_id,Assign_id,assign_by,assign_to,date_time,status,approved_date_time,approved_status,group_id,duration)values('" + exercise_id + "','" + randomNumber.ToString + "','" + StaffId + "','" + Spr_Datas(i) + "','" + c_dt.ToString + "','Not-attempted','','','" + t1.trim.ToString + "','" + dur.ToString + "')")
                    Else
                        MessageBox.Show("Already Assigned This " + exercise_id + " In " + Spr_Datas(i), "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If Spr_Datas.Count - 1 <> Spr_Datas(i) Then
                            vals = "crt"
                        End If
                    End If
                End If

            Next i
            If perchk = "PermissionGranted" Then
                permissioneval(exercise_id)
            End If
            If vals <> "crt" Then
                MessageBox.Show("Assigned Successful !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Spr_Datas.Clear()
            Spr_Datas_Eval.Clear()

            Me.Close()


        End If
        If chkbox_status = "not_all" Then
            For i = 0 To ind_spr.Count - 1
                Dim con As SqlConnection = New SqlConnection(communication)
                con.Open()
                Dim cmd1 As New SqlCommand("select ex_id,assign_by from communication.dbo.assign_table where assign_to ='" + ind_spr(i).ToString + "' and assign_by='" + StaffId + "' and ex_id='" + exercise_id + "'", con)

                Dim myreader As SqlDataReader
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                If select_mode.Text = "Copy Text" Then
                    d_t()
                    ReadFromDatabase("INSERT INTO assign_table (ex_id,Assign_id,assign_by,assign_to,date_time,status,approved_date_time,approved_status,group_id,duration)values('" + exercise_id + "','" + randomNumber.ToString + "','" + StaffId + "','" + ind_spr(i).ToString + "','" + c_dt.ToString + "','Not-attempted','','','" + t1.trim.ToString + "','" + dur.ToString + "')")
                Else

                    If myreader.HasRows = False Then
                        d_t()
                        ReadFromDatabase("INSERT INTO assign_table (ex_id,Assign_id,assign_by,assign_to,date_time,status,approved_date_time,approved_status,group_id,duration)values('" + exercise_id + "','" + randomNumber.ToString + "','" + StaffId + "','" + ind_spr(i).ToString + "','" + c_dt.ToString + "','Not-attempted','','','" + t1.trim.ToString + "','" + dur.ToString + "')")

                    Else
                        MessageBox.Show("Already Assigned This " + exercise_id + " In " + ind_spr(i).ToString + " ")
                        If ind_spr.Count - 1 <> ind_spr(i) Then
                            vale = "crt"

                        End If
                    End If
                End If
            Next i


            If perchk = "PermissionGranted" Then
                permissioneval(exercise_id)

            End If


            If vale <> "crt" Then
                MessageBox.Show("Assigned Successful !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            ind_spr.Clear()
            Spr_Datas_Eval.Clear()
            Me.Close()
        End If


    End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        If Input.Text = "" Then
            count_words.Text = "0"
            duration.Text = "MM:SS"
            Button3.Text = "Add Duration (15%)"
        Else
            count_words.Text = WordCount(Input.Text)
            duration.Text = WordsToSpeakingTime(count_words.Text)
            cnt = duration.Text
            Button3.Text = "Add Duration (15%)"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        If duration.Text <> "MM:SS" Then
            If Button3.Text = "Add Duration (15%)" Then
                duration.Text = CalculateTime(duration.Text)
                Button3.Text = "Less Duration (15%)"
            Else
                Button3.Text = "Add Duration (15%)"
                duration.Text = cnt.ToString
            End If
        Else

        End If
    End Sub
End Class