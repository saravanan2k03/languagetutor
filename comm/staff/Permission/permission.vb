Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Permission
    Private Sub select_by_stu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spr_Permission.Clear()
        ind_spr_Permission.Clear()
        Students_List.Columns(0).Visible = False
        Students_List.ColumnHeadersVisible = False
        Permissionchk()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Permissionchk()
        Try
            Spr_Datas_per.Clear()

            Dim con As SqlConnection = New SqlConnection(DBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("Select Spr_no from communication.dbo.permission where permission = '1'", con)
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader

            While myreader.Read()

                Spr_Datas_per.Add(myreader.Item("spr_no"))

            End While
            For i = 0 To Spr_Datas_per.ToList.Count - 1
                For Each row As DataGridViewRow In Students_List.Rows
                    If row.Cells(1).Value.ToString = Spr_Datas_per(i) Then
                        row.DefaultCellStyle.ForeColor = Color.White
                        row.DefaultCellStyle.BackColor = Color.Green
                    End If
                Next


            Next





            chkbox.Checked = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Something Went Wrong!")
        End Try

    End Sub


    Public chkbox As CheckBox = New CheckBox()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If programme.Text = "" And Year.Text = "" And Department.Text = "" And s_class.Text = "" Then

            MsgBox("Select Atleast 1 Field")
        Else
            Dim pro = programme.Text, dep = Department.Text, yearr = Year.Text, classs = s_class.Text
            status_show_permission = "on"
            Dim t1 = "", t2 = "", t3 = "", t4 = ""
            Dim Sql = "select SPR_NO As 'SPR.NO',NAME,DEPARTMENT,CLASS,YEAR,GENDER FROM STUDENTS  where 1=1"
            If Len(pro) <> 0 Then t1 = " and programme = '" & pro.ToString & "' "
            If Len(dep) <> 0 Then t2 = " and department = '" & dep.ToString & "' "
            If Len(yearr) <> 0 Then t3 = " and year = '" & yearr.ToString & "' "
            If Len(classs) <> 0 Then t4 = " and class ='" & classs.ToString & "'"
            Sql = Sql & t1 & t2 & t3 & t4
            list(Sql.ToString)
            Permissionchk()
        End If
    End Sub
    Public Sub list(query)
        Dim con As SqlConnection = New SqlConnection(user)
        Dim command1 As New SqlCommand(query, con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        Students_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Students_List.DataSource = dt1
        Students_List.AllowUserToAddRows = False
        Students_List.AllowUserToDeleteRows = False
        Students_List.AllowUserToResizeColumns = False
        Students_List.Columns(0).Visible = True
        Students_List.ColumnHeadersVisible = True
        Students_List.ClearSelection()
        Students_List.Columns(1).Width = 65
        Students_List.Columns(2).Width = 170
        Students_List.Columns(3).Width = 85
        Students_List.Columns(4).Width = 70
        Students_List.Columns(5).Width = 72
        Dim h_location As Point = Students_List.GetCellDisplayRectangle(0, -1, True).Location
        chkbox.Location = New Point(h_location.X + 5, h_location.Y + 11)
        chkbox.Size = New Size(15, 15)
        chkbox.BackColor = Color.White
        AddHandler chkbox.Click, AddressOf chkbox_clicked
        Students_List.Controls.Add(chkbox)
        AddHandler Students_List.CellContentClick, AddressOf DataGridView1_Cellclick

    End Sub


    Private Sub chkbox_clicked(sender As Object, e As EventArgs)
        Students_List.EndEdit()

        For Each row As DataGridViewRow In Students_List.Rows
            Dim check_bx As DataGridViewCheckBoxCell = (TryCast(row.Cells("chk"), DataGridViewCheckBoxCell))
            check_bx.Value = chkbox.Checked

        Next
    End Sub
    Private Sub DataGridView1_Cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_List.CellContentClick
        If e.RowIndex >= 0 Then
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In Students_List.Rows
                If Convert.ToBoolean(row.Cells("chk").EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If

            Next
            chkbox.Checked = isChecked
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pro = programme.Text, dep = Department.Text, yearr = Year.Text, classs = s_class.Text
        group_id = pro + " " + dep + " " + yearr + " " + classs
        If programme.Text = "" And Year.Text = "" And Department.Text = "" And s_class.Text = "" Then
            MsgBox("Select atleast 1 Field")
        Else
            If (status_show_permission = "off") Then
                MsgBox("Please Select Student's !!")
            Else
                status_show_permission = "off"

                If (chkbox.Checked = False) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            ind_spr_Permission.Add(row.Cells("SPR.NO").Value)
                        End If
                    Next
                    '''''''''''Provide Permission''''''''''''''
                    chkbox_status_permission = "not_all"
                    Include_assign()
                    Button1.PerformClick()
                End If

                If (chkbox.Checked = True) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            Spr_Permission.Add(row.Cells("SPR.NO").Value)
                        End If
                    Next

                    chkbox_status_permission = "select_all"
                    ''''''''''Provide permission''''''''''
                    Include_assign()
                    Button1.PerformClick()

                End If

            End If



        End If
    End Sub
    Public Sub Include_assign()

        If chkbox_status_permission = "select_all" Then
            For i = 0 To Spr_Permission.Count - 1
                '''query
                ReadFromDatabase("update communication.dbo.permission set Permission = 1  where Spr_no = '" + Spr_Permission(i) + "'")
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("select spr_no,Active from communication.dbo.Eval where spr_no='" + Spr_Permission(i) + "' and Active = 0", con)
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                If myreader.HasRows = True Then
                    ReadFromDatabase("Update communication.dbo.Eval Set Active = 1  where Spr_no = '" + Spr_Permission(i) + "'")

                End If
                con.Close()
            Next i

            MessageBox.Show("Permission Granted", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Spr_Permission.Clear()
            Permissionchk()


        End If
        If chkbox_status_permission = "not_all" Then
            For i = 0 To ind_spr_Permission.Count - 1
                ''query
                ReadFromDatabase("update communication.dbo.permission set Permission = 1  where Spr_no = '" + ind_spr_Permission(i) + "'")
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("select spr_no,Active from communication.dbo.Eval where spr_no='" + ind_spr_Permission(i) + "' and Active = 0", con)
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                If myreader.HasRows = True Then
                    ReadFromDatabase("Update communication.dbo.Eval Set Active = 1  where Spr_no = '" + ind_spr_Permission(i) + "'")

                End If
                con.Close()

            Next i
            MessageBox.Show("Permission Granted", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ind_spr_Permission.Clear()
            Permissionchk()

        End If


    End Sub
    Public Sub Exclude_assign()

        If chkbox_status_permission = "select_all" Then
            For i = 0 To Spr_Permission.Count - 1
                ''query
                ReadFromDatabase("update communication.dbo.permission set Permission = 0  where Spr_no = '" + Spr_Permission(i) + "'")
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("select spr_no,Active from communication.dbo.Eval where spr_no='" + Spr_Permission(i) + "' and Active = 1 ", con)
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                If myreader.HasRows = True Then
                    ReadFromDatabase("Update communication.dbo.Eval Set Active = 0  where Spr_no = '" + Spr_Permission(i) + "'")

                End If
                con.Close()
            Next i
            MessageBox.Show("Permission Revoked", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Spr_Permission.Clear()
            Permissionchk()


        End If
        If chkbox_status_permission = "not_all" Then
            For i = 0 To ind_spr_Permission.Count - 1
                ''query
                ReadFromDatabase("update communication.dbo.permission set Permission = 0  where Spr_no = '" + ind_spr_Permission(i) + "'")
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("select spr_no,Active from communication.dbo.Eval where spr_no='" + ind_spr_Permission(i) + "' and Active = 1 ", con)
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                If myreader.HasRows = True Then
                    ReadFromDatabase("Update communication.dbo.Eval Set Active = 0  where Spr_no = '" + ind_spr_Permission(i) + "'")

                End If
                con.Close()

            Next i
            MessageBox.Show("Permission Revoked", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ind_spr_Permission.Clear()
            Permissionchk()

        End If


    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Students_List.CellFormatting
        Students_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Students_List.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Outset
        Students_List.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Outset
        Students_List.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Inset
        'Students_List.AdvancedCellBorderStyle.TOP= Color.Red

        'If e.RowIndex Mod 2 = 0 Then
        '    e.CellStyle.BackColor = Color.LightBlue
        'Else
        '    e.CellStyle.BackColor = Color.GhostWhite
        'End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pro = programme.Text, dep = Department.Text, yearr = Year.Text, classs = s_class.Text
        group_id = pro + " " + dep + " " + yearr + " " + classs
        If programme.Text = "" And Year.Text = "" And Department.Text = "" And s_class.Text = "" Then
            MsgBox("Select atleast 1 Field")
        Else
            If (status_show_permission = "off") Then
                MsgBox("Please Select Student's !!")
            Else
                status_show_permission = "off"

                If (chkbox.Checked = False) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            ind_spr_Permission.Add(row.Cells("SPR.NO").Value)
                        End If
                    Next
                    '''''''''''Provide Permission''''''''''''''
                    chkbox_status_permission = "not_all"
                    Exclude_assign()
                    Button1.PerformClick()


                End If

                If (chkbox.Checked = True) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            Spr_Permission.Add(row.Cells("SPR.NO").Value)
                        End If
                    Next

                    chkbox_status_permission = "select_all"
                    ''''''''''Provide permission''''''''''
                    Exclude_assign()
                    Button1.PerformClick()

                End If

            End If



        End If
    End Sub

    Private Sub Levelcombobox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class