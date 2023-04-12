Imports System.Data.SqlClient
Imports System.IO
Imports System.Media
Imports System.Net

Public Class Completed_screen
    Dim frm = Waiting_screen
    Private Sub CompletedAudioView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm.show()

        audios()

        Nutural.Visible = True
        playaudio.Visible = False
        If n_a_s = "Approved" Then
            Label3.Text = n_a_d.ToString
            Label4.Text = n_a_sd.ToString
            st.Text = n_a_s.ToString
            Label9.Text = n_a_by.ToString
            Label10.Text = n_a_a_d.ToString
            Label12.Text = n_a_p.ToString + " %"
            If st.Text = "Pending" Then
                st.ForeColor = Color.Red
            Else
                st.ForeColor = Color.Green

            End If
        Else
            Label3.Text = n_a_d.ToString
            Label4.Text = n_a_sd.ToString
            If st.Text = "Pending" Then
                st.ForeColor = Color.Red
            Else
                st.ForeColor = Color.Green

            End If
        End If
    End Sub


    Public Sub audios()
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.mzcet.in/StudentAudio/" + n_a_data.ToString + ".flac"), FtpWebRequest)
        request.Method = WebRequestMethods.Ftp.DownloadFile
        request.Credentials = New NetworkCredential("graduation@mzcet.in", "DEGREE@11")
        Using response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                Using fileStream As New FileStream("C:/Audio/" + n_a_data.ToString + ".wav", FileMode.Create)
                    responseStream.CopyTo(fileStream)
                    frm.close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub play_btn_Click(sender As Object, e As EventArgs) Handles play_btn.Click
        If play_btn.Text = "play" Then
            play_btn.Text = "Stop"
            My.Computer.Audio.Play("C:\Audio\" + n_a_data.ToString + ".wav", AudioPlayMode.Background)
            Nutural.Visible = False
            playaudio.Visible = True
        Else
            play_btn.Text = "play"
            My.Computer.Audio.Stop()
            Nutural.Visible = True
            playaudio.Visible = False
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles st.Click

    End Sub

    Private Sub Completed_screen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub
End Class