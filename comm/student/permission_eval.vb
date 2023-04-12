Imports System.Data.SqlClient
Imports System.Xml
Imports GLib

Public Class Permission_eval
    Private Sub PermissionEval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Visible = False
        PictureBox1.Visible = False
        StudentDetails()
        Dim cmd As SqlCommand = New SqlCommand()
        grid_io(DataGridView1, "select  ev.ex_id As Exercise,ass.assign_by As 'Staff id',ass.assign_to As 'Student id',ass.assign_id As 'Assign id',st.Employee_name As 'Assigned by',ass.date_time,ass.status As Status from assign_table as ass inner join Eval as ev on ev.assign_by = ass.assign_by inner join userdatabase.dbo.Staffs as st on st.Employee_id = ev.assign_by where ev.spr_no ='" + StuSprNo + "' and ev.Active = '1'  and ass.assign_to != '" + StuSprNo + "'")
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
    Private Sub grid_io(grid, query)
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
            DataGridView1.Columns(0).Width = 100
            DataGridView1.RowTemplate.Height = 50
            DataGridView1.Columns(4).Width = 180
            DataGridView1.Columns(5).Width = 180
            DataGridView1.Columns(6).Width = 190
            DataGridView1.Columns("Staff id").Visible = False
            DataGridView1.Columns("Student id").Visible = False
            DataGridView1.Columns("Assign id").Visible = False
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
            If dr.Cells(6).Value.ToString <> "completed" Then
                MessageBox.Show("Student is not complete the assessment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim ex_id = dr.Cells(0).Value.ToString()
                Dim staff_id = dr.Cells(1).Value.ToString()
                Dim stu_id = dr.Cells(2).Value.ToString()
                Dim ass_id = dr.Cells(3).Value.ToString()
                Dim con As SqlConnection = New SqlConnection(communication)
                con.Open()
                Dim cmd1 As New SqlCommand("select ex_text from ex_table where ex_id='" + ex_id.ToString() + "'and created_by='" + staff_id.ToString() + "'", con)
                Dim myreader As SqlDataReader
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                Dim in_txt = myreader("ex_text")
                con.Close()
                in_put = in_txt.ToString()
                con.Open()
                Dim cmd As New SqlCommand("select output from assign_table where assign_id='" + ass_id.ToString() + "'and assign_to='" + stu_id.ToString() + "'", con)
                Dim myreader1 As SqlDataReader
                myreader1 = cmd.ExecuteReader()
                myreader1.Read()
                Dim out_txt = myreader1("output")
                con.Close()
                out_put = out_txt.ToString()
                Dim frm = valuation
                frm.Show()
                frm.MdiParent = admin_panel
            End If
        End If
    End Sub
End Class

