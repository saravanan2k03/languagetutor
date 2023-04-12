Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class select_by_staff
    Private Sub select_by_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spr_Datas.Clear()
        ind_spr.Clear()
        Students_List.Columns(0).Visible = False
        Students_List.ColumnHeadersVisible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Public chkbox As CheckBox = New CheckBox()

    Private Sub permi()
        Spr_Datas_Eval.Clear()

        If programme.Text = "" And Year.Text = "" And Department.Text = "" And s_class.Text = "" Then
            MessageBox.Show("Select atleast 1 Field", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim pro = programme.Text, dep = Department.Text, yearr = Year.Text, classs = s_class.Text
            status_show = "on"
            Dim t5 = ""
            Dim Sql = "select stu.SPR_NO As SPRNO FROM userdatabase.dbo.STUDENTS as stu  inner join communication.dbo.Permission as per on stu.spr_no = per.spr_no  where 1=1"

            If perchk.ToString = "PermissionGranted" Then t5 = "and per.Permission='1' "
            Sql = Sql & t5


            Dim con As SqlConnection = New SqlConnection(DBConnectionString)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(Sql.ToString, con)
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            While myreader.Read()

                Spr_Datas_Eval.Add(myreader.Item("SPRNO"))

            End While
            'Console.WriteLine(Spr_Datas_Eval.Count)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If programme.Text = "" And Year.Text = "" And Department.Text = "" And s_class.Text = "" Then

            MsgBox("Select Atleast 1 Field")
        Else
            Dim pro = programme.Text, dep = Department.Text, yearr = Year.Text, classs = s_class.Text
            status_show = "on"
            Dim t1 = "", t2 = "", t3 = "", t4 = "", t5 = ""
            Dim Sql = "select stu.SPR_NO As 'SPR NO.',NAME,DEPARTMENT,CLASS,YEAR,GENDER FROM userdatabase.dbo.STUDENTS as stu  inner join communication.dbo.Permission as per on stu.spr_no = per.spr_no  where 1=1"
            If Len(pro) <> 0 Then t1 = " and stu.programme = '" & pro.ToString & "' "
            If Len(dep) <> 0 Then t2 = " and stu.department = '" & dep.ToString & "' "
            If Len(yearr) <> 0 Then t3 = " and stu.year = '" & yearr.ToString & "' "
            If Len(classs) <> 0 Then t4 = " and stu.class ='" & classs.ToString & "'"
            If perchk.ToString = "PermissionGranted" Then
                t5 = "and per.Permission='0' "
            End If
            Sql = Sql & t1 & t2 & t3 & t4 & t5
            list(Sql.ToString)
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
        Students_List.Columns(1).Width = 80
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
            MessageBox.Show("Select atleast 1 Field", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If (status_show = "off") Then
                MessageBox.Show("Please Select Student's !!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                status_show = "off"

                If (chkbox.Checked = False) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            ind_spr.Add(row.Cells("SPR NO.").Value)
                            permi()
                        End If
                    Next

                    Dim frm2 As New assign
                    frm2.Show()
                    frm2.MdiParent = admin_panel
                    Me.Close()

                End If

                If (chkbox.Checked = True) Then
                    For Each row As DataGridViewRow In Students_List.Rows
                        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("chk").Value)


                        If select1 Then
                            Spr_Datas.Add(row.Cells("SPR NO.").Value)
                            permi()
                        End If
                    Next

                    chkbox_status = "select_all"
                    Dim frm2 As New assign
                    frm2.Show()
                    frm2.MdiParent = admin_panel
                    Me.Close()
                End If

            End If



        End If
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Students_List.CellFormatting
        Students_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Students_List.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Outset
        Students_List.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Outset
        Students_List.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Inset
        'Students_List.AdvancedCellBorderStyle.TOP= Color.Red

        If e.RowIndex Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LightBlue
        Else
            e.CellStyle.BackColor = Color.GhostWhite
        End If
    End Sub

    Private Sub Permissionchk_CheckedChanged(sender As Object, e As EventArgs) Handles Permissionchk.CheckedChanged
        If Permissionchk.Checked = True Then
            perchk = "PermissionGranted"
        End If
        If Permissionchk.Checked = False Then
            perchk = "PermissionDenied"
        End If
    End Sub
End Class