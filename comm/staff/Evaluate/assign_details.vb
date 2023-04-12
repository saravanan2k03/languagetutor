Imports System.Data.SqlClient

Public Class assign_details

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Todaydate.Text = Date.Now

        Try

            comborender()


        Catch ex As Exception
            MessageBox.Show("Something Went Wrong")

        End Try

    End Sub
    Private Sub Conditionquery()

        Dim dep = Me.department_combo.Text
        Dim stuyear = Me.semcombo.Text
        Dim classcomboo = Me.classcombo.Text
        Dim ex = Me.Exercisecom.Text
        Dim stat = Me.statuscombo.Text
        Dim dates = Me.DateTimePickerEx.Value.Date.ToString("dd/MM/yyyy")

        Dim t1 = ""
        Dim t2 = ""
        Dim t3 = ""
        Dim t4 = ""
        Dim t5 = ""
        Dim t6 = ""
        Dim t7 = "and comm.assign_by  = '" + StaffId.ToString + "'"
        Dim querys = "select stu.spr_no As 'SPR.NO',stu.Name As Name,stu.Department,stu.class As Class,stu.year As Year,comm.ex_id As 'Exercise',comm.status As Status,comm.date_time As 'Date Time' from userdatabase.dbo.students As stu inner join communication.dbo.assign_table as comm on stu.spr_no = comm.assign_to where 1=1"
        If Len(ex.ToString) <> 0 Then t1 = " and comm.ex_id = '" + ex.ToString + "'"
        If Len(classcomboo.ToString) <> 0 Then t2 = " and stu.class = '" + classcomboo.ToString + "'"
        If Len(dep.ToString) <> 0 Then t3 = " and stu.Department = '" + dep.ToString + "'"
        If Len(stat.ToString) <> 0 Then t4 = " and comm.status = '" + stat.ToString + "'"
        If Len(dates.ToString) <> 0 Then t5 = " and comm.date_time Like  '" + dates.ToString + "%'"
        If Len(stuyear.ToString) <> 0 Then t6 = " and stu.year  = '" + stuyear.ToString + "'"
        'If Len(StaffId.) <> 0 Then t7 = " and comm.assign_by  = '" + StaffId.ToString + "'"

        querys = querys & t1 & t2 & t3 & t4 & t5 & t6 & t7
        Console.WriteLine(querys)

        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command As New SqlCommand(querys, con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        Showgriddata.DataSource = dt
        Showgriddata.ClearSelection()





    End Sub
    Private Sub allstat()
        Try
            Dim dep = Me.department_combo.Text
            Dim stuyear = Me.semcombo.Text
            Dim classcomboo = Me.classcombo.Text
            Dim ex = Me.Exercisecom.Text
            Dim stat = Me.statuscombo.Text
            Dim dates = Me.DateTimePickerEx.Value.Date.ToString("dd/MM/yyyy")

            Dim t1 = ""
            Dim t2 = ""
            Dim t3 = ""
            Dim t4 = ""
            Dim t5 = ""
            Dim t6 = ""
            Dim t7 = "and comm.assign_by  = '" + StaffId.ToString + "'"
            Dim querys = "select stu.spr_no As 'SPR.NO',stu.Name As Name,stu.Department,stu.class As Class,stu.year As Year,comm.ex_id As 'Exercise',comm.status As Status,comm.date_time As 'Date Time' from userdatabase.dbo.students As stu inner join communication.dbo.assign_table as comm on stu.spr_no = comm.assign_to where 1=1"
            If Len(ex.ToString) <> 0 Then t1 = " and comm.ex_id = '" + ex.ToString + "'"
            If Len(classcomboo.ToString) <> 0 Then t2 = " and stu.class = '" + classcomboo.ToString + "'"
            If Len(dep.ToString) <> 0 Then t3 = " and stu.Department = '" + dep.ToString + "'"
            If Len(dates.ToString) <> 0 Then t5 = " and comm.date_time Like  '" + dates.ToString + "%'"
            If Len(stuyear.ToString) <> 0 Then t6 = " and stu.year  = '" + stuyear.ToString + "'"
            'If Len(StaffId.ToString) <> 0 Then t7 = " and comm.assign_by  = '" + staff_id.ToString + "'"


            querys = querys & t1 & t2 & t3 & t5 & t6 & t7
            'Console.WriteLine(querys)
            Dim con As SqlConnection = New SqlConnection(communication)
            Dim command As New SqlCommand(querys, con)
            Dim sda As New SqlDataAdapter(command)
            Dim dt As New DataTable
            sda.Fill(dt)
            Showgriddata.DataSource = dt
            Showgriddata.ClearSelection()
        Catch exi As Exception
            MessageBox.Show(exi.ToString)
        End Try


    End Sub
    Private Sub comborender()
        Dim con As SqlConnection = New SqlConnection(communication)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select * from ex_table", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Exercisecom.DataSource = table
        Exercisecom.DisplayMember = "ex_id"
        Exercisecom.ValueMember = "ex_id"
        con.Close()
    End Sub

    Private Sub depcomborender()
        Dim con As SqlConnection = New SqlConnection(communication)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select DISTINCT Department from userdatabase.dbo.students order by Department", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        department_combo.DataSource = table
        department_combo.DisplayMember = "Department"
        department_combo.ValueMember = "Department"
        con.Close()
    End Sub

    Private Sub semcomborender()
        Dim con As SqlConnection = New SqlConnection(communication)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select  distinct year from userdatabase.dbo.students order by year", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        semcombo.DataSource = table
        semcombo.DisplayMember = "year"
        semcombo.ValueMember = "year"
        con.Close()
    End Sub

    Private Sub classcomborender()
        Dim con As SqlConnection = New SqlConnection(communication)
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select  distinct class from userdatabase.dbo.students Order by class", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        classcombo.DataSource = table
        classcombo.DisplayMember = "class"
        classcombo.ValueMember = "class"
        con.Close()
    End Sub





    Private Sub view_btn_Click(sender As Object, e As EventArgs) Handles view_btn.Click
        If statuscombo.Text = "AllStatus" Then

            allstat()
        Else
            Conditionquery()
        End If


    End Sub

    Private Sub Showgriddata_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Showgriddata.CellFormatting
        For Each row As DataGridViewRow In Showgriddata.Rows
            If row.Cells(6).Value.ToString = "Assigned" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.LightBlue
            End If
            If row.Cells(6).Value.ToString = "Attemted" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Blue
            End If
            If row.Cells(6).Value.ToString = "Not-attempted" Then
                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub department_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department_combo.SelectedIndexChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If

    End Sub



    Private Sub classcombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classcombo.SelectedIndexChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If

    End Sub

    Private Sub semcombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semcombo.SelectedIndexChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If


    End Sub

    Private Sub statuscombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statuscombo.SelectedIndexChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If

    End Sub

    Private Sub Exercisecom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Exercisecom.SelectedIndexChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If


    End Sub

    Private Sub DateTimePickerEx_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEx.ValueChanged
        If statuscombo.Text = "AllStatus" Then
            allstat()
        Else
            Conditionquery()
        End If

        'MessageBox.Show(Me.DateTimePickerEx.Value.Date.ToString("dd/MM/yyyy"))
    End Sub
End Class