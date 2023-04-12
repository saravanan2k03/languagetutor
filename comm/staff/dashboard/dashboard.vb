Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class dashboard
    Dim Count
    Dim WithEvents tmr As New Timer()
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intial_data()
        tmr.Interval = 4000
        tmr.Start()
        name.Text = "Hi, " + StaffName.ToString


    End Sub
    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        intial_data()
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
    End Sub

    Public Sub get_status(status, status2, query)
        Try

        Catch ex As Exception

        End Try
        Dim script
        If query = 1 Then
            script = "select count(status) from assign_table where assign_by='" + StaffId.ToString + "' And status='" + status.ToString + "'"
        End If
        If query = 0 Then
            script = "select count(status) from assign_table where assign_by='" + StaffId.ToString + "' And (status='" + status.ToString + "' or status='" + status2.ToString + "')"

        End If
        If query = 2 Then
            script = "select count(status) from assign_table where assign_by='" + StaffId.ToString + "'"

        End If
        Dim con As New SqlConnection(communication)
        con.Open()
        Dim cmd As New SqlCommand(script.ToString, con)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        myreader.Read()
        Count = myreader("")
        con.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel_Products_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Products.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim frm As New Reassign_Assessment
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub tot_as_Click(sender As Object, e As EventArgs) Handles assign_container.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim frm As New select_by_staff
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm As New list_assign_details
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim frm As New add_ex
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim frm As New list_ex
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim result As DialogResult = MessageBox.Show("If you want logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Logout Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()

        End If
    End Sub
End Class