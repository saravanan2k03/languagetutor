Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class list_ex
    Private Sub list_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Visible = False
        PictureBox1.Visible = False
        grid_up()
        Dim View_button As New DataGridViewButtonColumn()
        With View_button
            .Name = "Edit"
            .HeaderText = "View"
            .Text = "View"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        View_button.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(View_button)
        ' tmr.Interval = 2000
        'tmr.Start()
        'Me.Ex_tableTableAdapter.Fill(Me.CommunicationDataSet.ex_table)
    End Sub
    'Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
    'Try
    '       grid()
    'Catch ex As Exception

    'End Try

    'End Sub

    Public Sub grid_up()
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand("select ex_id As 'Exercise No.',date_time As 'Created (Date & Time)',employee_name As 'Created by',Status from communication.dbo.ex_table as ex inner join userdatabase.dbo.staffs as st on ex.created_by=st.employee_id order by id", con)
        con.Open()
        Dim myreader As SqlDataReader
        myreader = command1.ExecuteReader()
        myreader.Read()
        If myreader.HasRows = False Then
            status.Visible = True
            PictureBox1.Visible = True
            DataGridView1.DataSource = ""
        Else
            status.Visible = False
            PictureBox1.Visible = False
            con.Close()
            Dim sda1 As New SqlDataAdapter(command1)
            Dim dt1 As New DataTable
            sda1.Fill(dt1)
            DataGridView1.DataSource = dt1
            DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.RowHeadersVisible = False
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(3).Width = 120
            DataGridView1.Columns(0).Width = 140
            DataGridView1.Columns(1).Width = 180
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim Ex_no = dr.Cells(0).Value.ToString()
            status_drop = dr.Cells(3).Value.ToString()
            Dim con As SqlConnection = New SqlConnection(communication)
            con.Open()
            Dim cmd1 As New SqlCommand("select ex_text from ex_table where ex_id='" + Ex_no.ToString + "'", con)
            Dim myreader As SqlDataReader
            myreader = cmd1.ExecuteReader()
            myreader.Read()
            ex_text = myreader("ex_text")
            E_no = Ex_no.ToString

            field_ex = Ex_no.Split(" ")
            ex_no_field = field_ex(1).ToString
            con.Close()
            Dim frm2 As New update_ex
            frm2.Show()
            frm2.MdiParent = admin_panel
        End If
        Me.Close()
        '   If DataGridView1.Columns(e.ColumnIndex).Name = "delete" Then
        '  Dim result As DialogResult = MessageBox.Show("If You Want Delete!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' If result = DialogResult.Yes Then
        'DataGridView1.Rows(e.RowIndex).Selected = True
        'Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        'Dim Ex_no = dr.Cells(0).Value.ToString()
        'ReadFromDatabase("Delete from ex_table where ex_id='" + Ex_no.ToString + "'And created_by='" + StaffId.ToString + "'")
        'load_grid(DataGridView1)
        'MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        '
        'End If

    End Sub


End Class