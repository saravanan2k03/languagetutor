Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class list_assign_details
    Dim WithEvents tmr As New Timer()
    Private Sub list_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        status.Visible = False
        PictureBox1.Visible = False

        'Me.Ex_tableTableAdapter.Fill(Me.CommunicationDataSet.ex_table)
        grid()
        Dim validate As New DataGridViewButtonColumn()
        Dim delete As New DataGridViewButtonColumn()
        With validate
            .Name = "viewss"
            .HeaderText = "View"
            .Text = "View"
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

        'DataGridView1.Columns(4).Width = 100
        'DataGridView1.Columns(5).Width = 100
        ' tmr.Interval = 2000
        'tmr.Start()

    End Sub
    'Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
    'Try
    '       grid()
    '      DataGridView1.ColumnHeadersVisible = False
    '     DataGridView1.AllowUserToAddRows = False
    '    DataGridView1.AllowUserToDeleteRows = False
    '   DataGridView1.AllowUserToResizeColumns = False
    '  DataGridView1.Columns(0).Width = 100
    ' DataGridView1.RowTemplate.Height = 90
    'DataGridView1.Columns(1).Width = 200
    'DataGridView1.Columns(2).Width = 200
    'DataGridView1.Columns(3).Width = 200
    'DataGridView1.Columns(4).Width = 100
    'DataGridView1.Columns(5).Width = 100
    'Catch ex As Exception

    'End Try

    'End Sub

    Public Sub grid()
        Dim con As SqlConnection = New SqlConnection(communication)
        Dim command1 As New SqlCommand("select distinct assign_id As 'Assign id',ex_id As 'Exercise No.', group_id As 'Selected by' from assign_table where assign_by='" + StaffId.ToString + "'", con)
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
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.RowHeadersVisible = False
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.Columns(2).Width = 250

            'DataGridView1.Columns(3).Width = 180
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 200
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
        If DataGridView1.Columns(e.ColumnIndex).Name = "viewss" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim t1 = dr.Cells(0).Value.ToString()
            Dim t2 = dr.Cells(1).Value.ToString()
            assign_iiid = t1.ToString
            Dim frm As New list_students
            frm.Show()
            frm.MdiParent = admin_panel
        End If
        If DataGridView1.Columns(e.ColumnIndex).Name = "del" Then
            DataGridView1.Rows(e.RowIndex).Selected = True
            Dim result As DialogResult = MessageBox.Show("Do you really want to delete this assessment? It might affect multiple students!", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView1.Rows(e.RowIndex).Selected = True
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim a_id = dr.Cells(0).Value.ToString()
                ReadFromDatabase("Delete from assign_table where assign_id='" + a_id.ToString + "'")
                grid()
                MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


End Class