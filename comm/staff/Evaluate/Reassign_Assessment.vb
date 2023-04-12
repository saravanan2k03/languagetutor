Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Reassign_Assessment
    Private Sub list_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Visible = False
        PictureBox1.Visible = False

        'Me.Ex_tableTableAdapter.Fill(Me.CommunicationDataSet.ex_table)
        load_grid(DataGridView1)
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
            .HeaderText = "Deletion"
            .Text = "Delete"
            .CellTemplate = New DataGridViewButtonCell()
        End With
        validate.UseColumnTextForButtonValue = True
        delete.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(validate)
        DataGridView1.Columns.Add(delete)

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If DataGridView1.Columns(e.ColumnIndex).Name = "del" Then
            Dim result As DialogResult = MessageBox.Show("If You Want Delete!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows(e.RowIndex).Selected = True
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim assign_id = dr.Cells(0).Value.ToString()
                Dim assign_to = dr.Cells(2).Value.ToString()
                ReadFromDatabase("Delete from assign_table where assign_id ='" + assign_id.ToString + "'And assign_to='" + assign_to.ToString + "'")
                load_grid(DataGridView1)
                MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "val" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim status = dr.Cells(4).Value.ToString()
            If status = "completed" Then
                Dim t_ex_id = dr.Cells(1).Value.ToString()
                out_put = dr.Cells(6).Value.ToString()
                s_dut = dr.Cells(5).Value.ToString()
                a_s = dr.Cells(7).Value.ToString()
                a_id = dr.Cells(0).Value.ToString()
                s_id = dr.Cells(2).Value.ToString()
                MsgBox(a_s.ToString)
                Dim con As SqlConnection = New SqlConnection(DBConnectionString)
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("select ex_text from ex_table where ex_id='" + t_ex_id.ToString + "'", con)
                Dim myreader As SqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()
                in_put = myreader("ex_text")

                Dim frm = valuation
                frm.Show()
                frm.MdiParent = admin_panel
            Else
                MessageBox.Show("Student is not complete the assessment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub
    Public Sub load_grid(grid)
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand("select assign_id As 'Assign id.',ex_id As 'Exercise No.',assign_to As 'Spr.No',Name,Status,submitted_duration,output,approved_status from communication.dbo.assign_table as ca inner join userdatabase.dbo.students as us on ca.assign_to=us.spr_no where approved_status='Reassign' and assign_by='" + StaffId.ToString() + "'", con)
        con.Open()
        Dim myreader As SqlDataReader
        myreader = command1.ExecuteReader()
        myreader.Read()
        If myreader.HasRows = False Then
            Status.Visible = True
            PictureBox1.Visible = True
            grid.DataSource = ""
        Else
            Status.Visible = False
            PictureBox1.Visible = False
            con.Close()
            Dim sda1 As New SqlDataAdapter(command1)
            Dim dt1 As New DataTable
            sda1.Fill(dt1)
            grid.DataSource = dt1
            DataGridView1.DataSource = dt1
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.RowHeadersVisible = False
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.Columns(2).Width = 130
            DataGridView1.Columns(3).Width = 180
            DataGridView1.Columns(0).Width = 140
            DataGridView1.Columns(1).Width = 180
            DataGridView1.Columns("submitted_duration").Visible = False
            DataGridView1.Columns("output").Visible = False
            DataGridView1.Columns("approved_status").Visible = False
            DataGridView1.RowTemplate.Height = 50
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





End Class