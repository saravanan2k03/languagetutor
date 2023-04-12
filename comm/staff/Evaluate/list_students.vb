Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Gst

Public Class list_students
    Dim assign_iid = ""
    Private Sub list_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserdatabaseDataSet.students' table. You can move, or remove it, as needed.
        ' Me.StudentsTableAdapter.Fill(Me.UserdatabaseDataSet.students)

        status.Visible = False
        PictureBox1.Visible = False
        assign_iid = assign_iiid.ToString
        grid_io(DataGridView1, "select assign_id,ex_id,assign_to As 'Spr.No',Name,Status,submitted_duration,approved_status from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where assign_id='" + assign_iid.ToString + "'")
        Dim validate As New DataGridViewButtonColumn()
        Dim delete As New DataGridViewButtonColumn()
        With validate
            .Name = "val"
            .HeaderText = "Validataion"
            .Text = "Validate"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        With delete
            .Name = "del"
            .HeaderText = "Delete"
            .Text = "Delete"
            .CellTemplate = New DataGridViewButtonCell()
        End With
        validate.UseColumnTextForButtonValue = True
        delete.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(validate)
        DataGridView1.Columns.Add(delete)
    End Sub

    Public Sub grid_io(grid, query)
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand(query, con)
        con.Open()
        Dim myreader As SqlDataReader
        myreader = command1.ExecuteReader()
        myreader.Read()

        If myreader.HasRows = False Then
            status.Visible = True
            PictureBox1.Visible = True

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
            DataGridView1.Columns("assign_id").Visible = False
            DataGridView1.Columns("ex_id").Visible = False
            'DataGridView1.Columns("duration").Visible = False
            DataGridView1.Columns("submitted_duration").Visible = False
            DataGridView1.Columns("approved_status").Visible = False
            DataGridView1.Columns(2).Width = 100
            DataGridView1.RowTemplate.Height = 50
            DataGridView1.Columns(3).Width = 260
            DataGridView1.Columns(4).Width = 160
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


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Not-Attempted" Then
            DataGridView1.DataSource = ""
            grid_io(DataGridView1, "select assign_id,ex_id,assign_to As 'Spr.No',Name,Status,submitted_duration from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where assign_id='" + assign_iid.ToString + "' and status='" + ComboBox1.SelectedItem.ToString + "'")
        End If
        If ComboBox1.SelectedItem = "Attempted" Then
            DataGridView1.DataSource = ""
            grid_io(DataGridView1, "select assign_id,ex_id,assign_to As 'Spr.No',Name,Status,submitted_duration from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where assign_id='" + assign_iid.ToString + "' and status='" + ComboBox1.SelectedItem.ToString + "'")
        End If
        If ComboBox1.SelectedItem = "Completed" Then
            DataGridView1.DataSource = ""
            grid_io(DataGridView1, "select assign_id,ex_id,assign_to As 'Spr.No',Name,Status,submitted_duration,approved_status from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where assign_id='" + assign_iid.ToString + "' and  status='" + ComboBox1.SelectedItem.ToString + "'")
        End If
        If ComboBox1.SelectedItem = "All" Then
            DataGridView1.DataSource = ""
            grid_io(DataGridView1, "select assign_id,ex_id,assign_to As 'Spr.No',Name,Status,submitted_duration,approved_status from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where assign_id='" + assign_iid.ToString + "'")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "del" Then
            Dim result As DialogResult = MessageBox.Show("Do you really want to delete this assessment?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows(e.RowIndex).Selected = True
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim spr_no = dr.Cells(0).Value.ToString()
                ReadFromDatabase("Delete from assign_table where assign_id='" + assign_iid.ToString + "'And assign_to='" + spr_no.ToString + "'")
                MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "val" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim status = dr.Cells(4).Value.ToString()
            If status = "completed" Then
                Dim assign_id = dr.Cells(0).Value.ToString()
                Dim ex_id = dr.Cells(1).Value.ToString()
                Dim stu_id = dr.Cells(2).Value.ToString()
                s_dut = dr.Cells(5).Value.ToString()
                a_s = dr.Cells(6).Value.ToString()
                Dim con As SqlConnection = New SqlConnection(communication)
                con.Open()
                Dim cmd1 As New SqlCommand("select ex_text from ex_table where ex_id='" + ex_id.ToString() + "'", con)
                Dim myreader As SqlDataReader
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                Dim in_txt = myreader("ex_text")
                con.Close()
                in_put = in_txt.ToString()
                con.Open()
                Dim cmd As New SqlCommand("select output from assign_table where assign_id='" + assign_id.ToString() + "'and assign_to='" + stu_id.ToString() + "'", con)
                Dim myreader1 As SqlDataReader
                myreader1 = cmd.ExecuteReader()
                myreader1.Read()
                Dim out_txt = myreader1("output")
                con.Close()
                out_put = out_txt.ToString()
                a_id = assign_id.ToString
                s_id = stu_id.ToString()
                Dim frm = valuation
                frm.Show()
                frm.MdiParent = admin_panel
                Me.Close()
            Else
                MessageBox.Show("Student is not complete the assessment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class