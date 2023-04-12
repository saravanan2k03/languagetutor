Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class student_dashboard
    Dim Count
    Dim WithEvents tmr As New Timer()
    Private Sub grid_io(grid, query)
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand(query, con)
        con.Open()
        Dim myreader As SqlDataReader
        myreader = command1.ExecuteReader()
        myreader.Read()
        Try
            If myreader.HasRows = False Then
                ' status.Visible = True
                'PictureBox1.Visible = True
                'DataGridView1.Visible = False
            Else

                Dim sda1 As New SqlDataAdapter(command1)
                Dim dt1 As New DataTable
                sda1.Fill(dt1)
                grid.DataSource = dt1
                DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
                DataGridView1.ColumnHeadersVisible = True
                DataGridView1.RowHeadersVisible = False
                DataGridView1.AllowUserToAddRows = False
                DataGridView1.AllowUserToDeleteRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.Columns(0).Width = 100
                DataGridView1.RowTemplate.Height = 40
                DataGridView1.Columns(1).Width = 180
                DataGridView1.Columns(2).Width = 180
                DataGridView1.Columns(3).Width = 150
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.EnableHeadersVisualStyles = False
                DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                DataGridView1.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
                DataGridView1.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
                DataGridView1.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                DataGridView1.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
                DataGridView1.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10)
                DataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White
                DataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
                DataGridView1.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True
            End If
        Catch ex As Exception

        End Try
            con.Close()

    End Sub

    Private Sub student_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intial_data()
        tmr.Interval = 4000
        tmr.Start()
        name.Text = "Hi, " + StuName.ToString
        grid_io(DataGridView1, "select  communication.dbo.assign_table.ex_id As 'Exercise.No',userdatabase.dbo.staffs.Employee_Name As 'Assign by',communication.dbo.assign_table.date_time As 'Date & Time' ,communication.dbo.assign_table.Status from communication.dbo.assign_table inner join userdatabase.dbo.staffs on communication.dbo.assign_table.assign_by=userdatabase.dbo.staffs.employee_id  where assign_to='" + StuSprNo.ToString() + "'")
    End Sub
    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        intial_data()
        grid_io(DataGridView1, "select  communication.dbo.assign_table.ex_id As 'Exercise.No',userdatabase.dbo.staffs.Employee_Name As 'Assign by',communication.dbo.assign_table.date_time As 'Date & Time' ,communication.dbo.assign_table.Status from communication.dbo.assign_table inner join userdatabase.dbo.staffs on communication.dbo.assign_table.assign_by=userdatabase.dbo.staffs.employee_id  where assign_to='" + StuSprNo.ToString() + "'")
    End Sub


    Public Sub intial_data()
        get_status("Not-Attempted", "", 1)
        not_attempted_container.Text = Count.ToString
        get_status("completed", "", 1)
        Completed_container.Text = Count.ToString
        get_status("completed", "Attempted", 0)
        attempted_container.Text = Count.ToString
        get_status("", "", 2)
        assign_container.Text = Count.ToString
        grid_io(DataGridView1, "select communication.dbo.assign_table.ex_id As 'Exercise.No',userdatabase.dbo.staffs.Employee_Name As 'Assign by',communication.dbo.assign_table.date_time As 'Date & Time' ,communication.dbo.assign_table.Status from communication.dbo.assign_table inner join userdatabase.dbo.staffs on communication.dbo.assign_table.assign_by=userdatabase.dbo.staffs.employee_id  where assign_to='" + StuSprNo.ToString() + "' order by id desc")
    End Sub

    Public Sub get_status(status, status2, query)
        Try

        Catch ex As Exception

        End Try
        Dim script
        If query = 1 Then
            script = "select count(status) from assign_table where assign_to='" + StuSprNo.ToString + "' And status='" + status.ToString + "'"
        End If
        If query = 0 Then
            script = "select count(status) from assign_table where assign_to='" + StuSprNo.ToString + "' And (status='" + status.ToString + "' or status='" + status2.ToString + "')"
        End If
        If query = 2 Then
            script = "select count(status) from assign_table where assign_to='" + StuSprNo.ToString + "'"

        End If
        Dim con As New SqlConnection(communication)
        con.Open()
        Dim cmd As New SqlCommand(script.ToString, con)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        myreader.Read()
        Count = myreader("")
        con.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim frm = student_assign
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'Dim frm =
        'frm.Show()
        'frm.MdiParent = admin_panel
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Logout Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()

        End If
    End Sub
End Class