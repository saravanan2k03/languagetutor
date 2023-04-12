Imports System.Data.SqlClient
Imports System.Xml
Imports VisioForge.Libs.DirectShowLib.BDA

Public Class student_assign
    Dim n_ex_num
    Private Sub PermissionEval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Visible = False
        PictureBox1.Visible = False
        StudentDetails()
        grid(DataGridView1, "select communication.dbo.assign_table.ex_id As 'Exercise No.',communication.dbo.assign_table.assign_id,communication.dbo.assign_table.assign_by as 'Staff id',communication.dbo.assign_table.duration,userdatabase.dbo.staffs.Employee_Name As 'Assigned by',communication.dbo.assign_table.date_time As 'Date & Time' ,communication.dbo.assign_table.Status from communication.dbo.assign_table inner join userdatabase.dbo.staffs on communication.dbo.assign_table.assign_by=userdatabase.dbo.staffs.employee_id  where assign_to='" + StuSprNo.ToString() + "'")
        Dim view_btn As New DataGridViewButtonColumn()
        With view_btn
            .Name = "btn_view"
            .HeaderText = "View"
            .Text = "View"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        view_btn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(view_btn)
    End Sub
    Private Sub StudentDetails()
        NameLabel.Text = StuName
        DepLabel.Text = StuDep
        classLabel.Text = StuClass
        yearLabel.Text = StuYear
    End Sub
    Private Sub grid(grid, query)
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand(query, con)
        con.Open()
        Dim myreader As SqlDataReader
        myreader = command1.ExecuteReader()
        myreader.Read()

        If myreader.HasRows = False Then
            status.Visible = True
            PictureBox1.Visible = True
            DataGridView1.Visible = False

        Else
            con.Close()
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
            DataGridView1.Columns("Staff id").Visible = False
            DataGridView1.Columns("assign_id").Visible = False
            DataGridView1.Columns("duration").Visible = False
            DataGridView1.Columns(0).Width = 120
            DataGridView1.RowTemplate.Height = 50
            DataGridView1.Columns(4).Width = 180
            DataGridView1.Columns(5).Width = 180
            DataGridView1.Columns(6).Width = 180
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "btn_view" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            If dr.Cells(6).Value.ToString = "completed" Then
                n_ex_num = dr.Cells(0).Value.ToString
                load()
                Dim frm = Completed_screen
                frm.Show()
                frm.MdiParent = admin_panel
            Else
                Dim ex_id = dr.Cells(0).Value.ToString()
                Dim staff_id = dr.Cells(2).Value.ToString()
                Dim assign_id = dr.Cells(1).Value.ToString()
                Dim duration = dr.Cells(3).Value.ToString()
                dur_time = duration.ToString
                Dim con As SqlConnection = New SqlConnection(communication)
                con.Open()
                Dim cmd1 As New SqlCommand("select ex_text from ex_table where ex_id='" + ex_id.ToString() + "'", con)
                Dim myreader As SqlDataReader
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                Dim txt = myreader("ex_text")
                ex_text = txt.ToString()
                a_id = assign_id.ToString()
                Dim frm = record
                frm.Show()
                frm.MdiParent = admin_panel
                Me.Close()
            End If
        End If

    End Sub
    Public Sub load()
        Try
            Dim con As SqlConnection = New SqlConnection(communication)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("select Assign_id,approved_date_time,submitted_date,approved_status,approved_by,date_time,performance from communication.dbo.assign_table where assign_to = '" + StuSprNo.ToString + "' and ex_id='" + n_ex_num.ToString + "'", con)
            Dim myreader As SqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            n_a_id = myreader("Assign_id").ToString
            Dim nad = myreader("approved_date_time").ToString().Split(" ")
            n_a_d = nad(0)
            Dim nasd = myreader("submitted_date").ToString().Split(" ")
            n_a_sd = nasd(0)
            n_a_s = myreader("approved_status").ToString
            n_a_p = myreader("performance").ToString
            n_a_data = n_a_id + "_" + StuSprNo.ToString
            n_a_by = myreader("approved_by").ToString
            Dim naad = myreader("date_time").ToString().Split(" ")
            n_a_a_d = naad(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class

