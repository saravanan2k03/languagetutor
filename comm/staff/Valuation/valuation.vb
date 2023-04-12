Imports System.IO
Imports System.Media
Imports System.Net
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.Devices
Imports VisioForge.Libs.MediaFoundation.OPM

Public Class valuation
    Dim a = s_dut.ToString.Split(":")
    Dim b = a(0) + ":" + a(1)
    Dim minutes As Integer = 0
    Dim seconds As Integer = 0
    Private Sub valuation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If a_s.ToString = "Approved" Then
            Button1.Enabled = False
            Button2.Enabled = False
        End If
        end_dur.Text = b.ToString
        Dim directoryPath As String = "C:\Audio"
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        ex_input.Text = in_put.ToString
        stu_output.Text = out_put.ToString
        Dim resultString As String = Regex.Replace(ex_input.Text, "[^\w\s]", "")
        Dim len As Integer = ComputeDistance(resultString.ToString, stu_output.Text)
        Dim actual_precentage = Math.Round(100 - (len / Math.Max(resultString.Length, stu_output.Text.Length)) * 100)
        precentage.Text = actual_precentage.ToString + " %"
        ProgressBar1.BackColor = Color.Green
        ProgressBar1.Value = actual_precentage
        Dim frm As New Waiting_screen()
        frm.Show()
        download()
        frm.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If Button3.Text = "Stop" Then
                seconds = 0
                minutes = 0
                Timer1.Stop()
                ' beg_dur.Text = "00:00"
                My.Computer.Audio.Stop()
                Button3.Text = "Play Audio"
            Else
                Button3.Text = "Stop"
                beg_dur.Text = "00:00"
                My.Computer.Audio.Play("C:\Audio\" + a_id + "_" + s_id.ToString + ".wav", AudioPlayMode.Background)
                Timer1.Interval = 1000
                Timer1.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d_t()
        ReadFromDatabase("update assign_table set approved_status='Approved',Approved_date_time='" + c_dt.ToString + "', performance='" + ProgressBar1.Value.ToString + "',approved_by='" + StaffId.ToString + "' where assign_id='" + a_id.ToString + "'and assign_to='" + s_id.ToString + "'")
        Dim result As DialogResult = MessageBox.Show("confirmation of Approved", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Are you sure to approve the assessment?", "Confirm Approval", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim frm = list_students
            frm.Show()
            frm.MdiParent = admin_panel
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReadFromDatabase("update assign_table set approved_status='Reassign',status='Not-attempted' where assign_id='" + a_id.ToString + "'and assign_to='" + s_id.ToString + "'")
        Dim result As DialogResult = MessageBox.Show("confirmation of Reassign", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Are you sure to Reassign the assessment?", "Redo confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If
    End Sub
    Private Sub download()

        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.mzcet.in/StudentAudio/" & a_id + "_" + s_id+ ".flac"), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.DownloadFile
        request.Credentials = New NetworkCredential("graduation@mzcet.in", "DEGREE@11")
        Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                Using fileStream As New FileStream("C:/Audio/" & a_id + "_" + s_id + ".wav", FileMode.Create)
                    responseStream.CopyTo(fileStream)
                End Using
            End Using
        End Using
    End Sub

    Private Sub valuation_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If beg_dur.Text.ToString = end_dur.Text.ToString Then
            Timer1.Stop()
            Button3.Text = "Play Audio"
            beg_dur.Text = "00:00"
            seconds = 0
            minutes = 0
        Else

            'seconds = 0
            seconds += 1
            If seconds = 60 Then
                minutes += 1
                seconds = 0
            End If
            beg_dur.Text = String.Format("{0:00}:{1:00}", minutes, seconds)

        End If



    End Sub

    Private Sub valuation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim frm = list_students
        frm.Show()
        frm.MdiParent = admin_panel
    End Sub
End Class