Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock


Public Class admin_panel
    Dim statusLabel As New ToolStripStatusLabel()
    Private ReadOnly timeee As Object
    Private Sub ADDEXCERSICEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm2 As New add_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Public Sub admin_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Form1.ShowDialog()
            login.ShowDialog()
            If (authentication = "0") Then
                validation_strip.Visible = False
                stu_assessment.Visible = False
                Dim frm = dashboard
                frm.Show()
                frm.WindowState = FormWindowState.Normal
                frm.Size = New Size(1906, 894)
                frm.MdiParent = Me
                Dim time As New Timer()
                time.Interval = 1000
                AddHandler time.Tick, AddressOf Timer_Tick
                time.Start()
                Me.WindowState = FormWindowState.Maximized
                user_input.Text = StaffName.ToString
                dep_input.Text = StaffDep.ToString
                ver_input.Text = "1.0"
            ElseIf (authentication = "1") Then
                evaluate_strip.Visible = False
                permission_strip.Visible = False
                Assessment_strip.Visible = False
                Dim time As New Timer()
                time.Interval = 1000
                AddHandler time.Tick, AddressOf Timer_Tick
                time.Start()
                Me.WindowState = FormWindowState.Maximized
                user_input.Text = StuName.ToString
                dep_input.Text = StuDep.ToString
                ver_input.Text = "1.0"
                Dim frm = student_dashboard
                frm.Show()
                frm.WindowState = FormWindowState.Normal
                frm.Size = New Size(1906, 894)
                frm.MdiParent = Me
            Else
                Me.Visible = False
                Application.Exit()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try







    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Try
            Dim today As Date = Date.Now
            Dim dateString As String = today.ToString("dd-MM-yyyy")
            d_t()
            Time_input.Text = c_t.ToString
            date_input.Text = dateString.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub



    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub StudentAssignToolStripMenuItem_Click(sender As Object, e As EventArgs)


        Dim frm2 As New student_assign
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ATTEMPTEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATTEMPTEDToolStripMenuItem.Click
        Dim frm2 As New add_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
    Private Sub UPDATEEXERCISEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm2 As New list_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ASSIGNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Profile_strip.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles dep_label.Click
    End Sub

    Private Sub PlayAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayAudioToolStripMenuItem.Click
        Dim frm2 = select_by_staff
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub AssignToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AssignToolStripMenuItem1.Click

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Logout Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()

        End If


    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
        Dim frm2 As New list_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
    Private Sub ViewAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAssessmentToolStripMenuItem.Click
        Dim frm2 As New list_assign_details
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
    Private Sub FilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilterToolStripMenuItem.Click
        Dim frm2 As New assign_details
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub PermissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles permission_strip.Click
        Dim frm As New Permission
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim frm2 As New select_by_staff
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Dim frm2 As New list_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Dim frm2 As New add_ex
        frm2.Show()
        frm2.MdiParent = Me
    End Sub

    Private Sub ListAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAssessmentToolStripMenuItem.Click
        Dim frm2 As New student_assign
        frm2.Show()
        frm2.MdiParent = Me
    End Sub
    Private Sub NEWASSIGNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWASSIGNToolStripMenuItem.Click
        If StaffId = "" Then
            Dim frm1 = student_dashboard
            frm1.Show()
            frm1.WindowState = FormWindowState.Normal
            frm1.Size = New Size(1906, 894)
            frm1.MdiParent = Me
        End If
        If StuSprNo = "" Then
            Dim frm2 = dashboard
            frm2.Show()
            frm2.WindowState = FormWindowState.Normal
            frm2.Size = New Size(1906, 894)
            frm2.MdiParent = Me
        End If
    End Sub
    Private Sub ListValidataionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListValidataionToolStripMenuItem.Click
        Dim frm = permission_eval
        frm.Show()
        frm.MdiParent = Me
    End Sub
End Class