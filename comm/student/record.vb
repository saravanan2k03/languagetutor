Imports System.IO
Imports System.Net
'Imports VisioForge.Libs.NAudio.Wave
'Imports NAudio.Wave
'Imports NAudio.Lame
Imports VisioForge.Libs.MediaFoundation.OPM
Imports System.Globalization
Imports System.Web.UI.WebControls
Imports GLib

Public Class record
    Dim check = "0"
    Dim frm = Waiting_screen


    Public Declare Function record Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private Sub Recbtn_Click(sender As Object, e As EventArgs) Handles Recbtn.Click
        If My.Settings.Myset = "cancel" Then
            Dim frm = messageform
            frm.ShowDialog()
        End If
        Label7.Text = dur_time.ToString + ":00"
        Timer1.Interval = 10
        Timer1.Start()
        check = "0"
        record("open new Type waveaudio Alias recsound", "", 0, 0)
        record("record recsound", "", 0, 0)
        Recbtn.Text = "Recording"
        Recbtn.Enabled = False
        Playbtn.Enabled = False
        Button1.Enabled = False
        Stopbtn.Enabled = True
        mic.Enabled = True

    End Sub


    Private Sub Stopbtn_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click
        My.Computer.Audio.Stop()
        mic.Enabled = False
        Timer1.Stop()
        record("save recsound C:\Audio\" + a_id + "_" + StuSprNo.ToString + ".wav", "", 0, 0)
        record("save recsound C:\Audio\" + a_id + "_" + StuSprNo.ToString + ".flac", "", 0, 0)
        record("close recsound", "", 0, 0)
        ReadFromDatabase("update assign_table set status='Attempted'where assign_id='" + a_id.ToString() + "'and assign_to='" + StuSprNo.ToString() + "'")
        Recbtn.Text = "Rerecord"
        Playbtn.Enabled = True
        Recbtn.Enabled = True
        If Label7.Text <> "Time's up!" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False

        End If

    End Sub

    Private Sub Playbtn_Click(sender As Object, e As EventArgs) Handles Playbtn.Click
        My.Computer.Audio.Play("C:\Audio\" + a_id + "_" + StuSprNo.ToString + ".wav", AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Recbtn.Enabled = False
        Playbtn.Enabled = False
        Button1.Enabled = False
        Stopbtn.Enabled = False
        Button1.Text = "Processing.."
        frm.Show()
        ftp()
    End Sub



    Private Sub record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label7.Text = dur_time.ToString + ":00"
        Dim directoryPath As String = "C:\Audio"
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        input.Text = ex_text.ToString
        mic.Enabled = False
        Stopbtn.Enabled = False
        Playbtn.Enabled = False
        Button1.Enabled = False
    End Sub
    Public Sub ftp()
        Try
            Dim path = a_id + "_" + StuSprNo.ToString + ".flac"
            Dim ftptargetfileaddress As String = "ftp://ftp.mzcet.in/StudentAudio/" & path
            Dim username As String = "graduation@mzcet.in"
            Dim password As String = "DEGREE@11"
            Dim ftpreq As FtpWebRequest = DirectCast(WebRequest.Create(ftptargetfileaddress), FtpWebRequest)
            ftpreq.Credentials = New NetworkCredential(username, password)
            ftpreq.Method = WebRequestMethods.Ftp.UploadFile
            Dim mfile() As Byte = System.IO.File.ReadAllBytes("C:\Audio\" + path)
            Dim mstream As System.IO.Stream = ftpreq.GetRequestStream()
            mstream.Write(mfile, 0, mfile.Length)
            mstream.Close()
            mstream.Dispose()
            Dim client As WebClient = New WebClient()
            Dim data As String = path
            client.Headers.Add("Content-Type", "text/plain")
            Dim response As String = client.UploadString("http://103.207.1.94:5001/api/data", "POST", data)
            Dim s = SubtractTimes(dur_time + ":00".ToString, Label7.Text)
            d_t()
            ReadFromDatabase("update assign_table set submitted_duration='" + s.ToString + "',status='processing',submitted_date='" + c_dt.ToString + "' where assign_to='" + StuSprNo.ToString + "' and assign_id='" + a_id.ToString + "'")
            frm.close()
            MessageBox.Show("Your assessment has been submitted for validation.", "Record Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim frm1 = student_assign
            frm1.Show()
            frm1.MdiParent = admin_panel
            ''http://103.207.1.94:5001/api/data
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MessageBox.Show(ex.ToString, "failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim time As String = Label7.Text
            Dim minutes, seconds, frames As Integer
            minutes = Integer.Parse(time.Split(":"c)(0))
            seconds = Integer.Parse(time.Split(":"c)(1))
            frames = Integer.Parse(time.Split(":"c)(2))
            Dim totalFrames As Integer = (minutes * 60 + seconds) * 50 + frames

            totalFrames -= 1
            If totalFrames >= 0 Then
                Dim m As Integer = totalFrames \ 3000
                Dim s As Integer = (totalFrames Mod 3000) \ 50
                Dim f As Integer = (totalFrames Mod 3000) Mod 50
                Label7.Text = String.Format("{0:00}:{1:00}:{2:00}", m, s, f)
            Else
                Label7.Text = "Time's up!"
                Timer1.Stop()
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class
