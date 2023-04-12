Imports VisioForge.Libs.DirectShowLib.BDA

Module globalfile


    Public extext
    Public st
    Public auth
    Public database_query_status
    Public StuSprNo
    Public StuName
    Public StuDep
    Public a_s
    Public c_dt
    Public a_id
    Public s_id
    Public c_t
    Public E_no
    Public dur_time
    Public StuClass
    Public authentication
    Public group_id
    Public StuYear
    Public assign_iiid
    Public Ex_iiid
    Public perchk = ""
    Public Spr_Datas_Eval As New List(Of String)
    'Staff Variable
    Public StaffId
    Public StaffName
    Public StaffDep
    Public dut
    Public s_dut
    Public n_a_id
    Public n_a_d
    Public n_a_s
    Public n_a_sd
    Public n_a_p
    Public n_a_data
    Public n_a_by
    Public n_a_a_d




    Public DBConnectionString As String = "Data Source=103.207.1.94;Initial Catalog=communication;User ID=mzcet;Password=checkme@987"
    Public DBConnectionStringstu As String = "Data Source=103.207.1.94;Initial Catalog=userdatabase;User ID=mzcet;Password=checkme@987"
    Function ComputeDistance(s As String, t As String) As Integer
        Dim n As Integer = s.Length
        Dim m As Integer = t.Length
        Dim d(n + 1, m + 1) As Integer

        If n = 0 Then
            Return m
        End If
        If m = 0 Then
            Return n
        End If

        For i As Integer = 0 To n
            d(i, 0) = i
        Next
        For j As Integer = 0 To m
            d(0, j) = j
        Next

        For i As Integer = 1 To n
            For j As Integer = 1 To m
                Dim cost As Integer = If(t(j - 1) = s(i - 1), 0, 1)
                d(i, j) = Math.Min(Math.Min(d(i - 1, j) + 1, d(i, j - 1) + 1), d(i - 1, j - 1) + cost)
            Next
        Next
        Return d(n, m)
    End Function
    Function WordCount(ByVal text As String) As Integer
        text = text.Trim()
        Dim words As String() = text.Split(" "c)
        Return words.Length

    End Function
    Function WordsToSpeakingTime(ByVal words As Integer) As String
        Const WPM As Integer = 150
        Const PAUSE_LENGTH As Double = 0.2
        Const PAUSE_FREQUENCY As Integer = 10
        Dim avgTimePerWord As Double = 60 / (WPM + (PAUSE_FREQUENCY * PAUSE_LENGTH))
        Dim speakingTime As Double = words * avgTimePerWord
        Dim minutes As Integer = Int(speakingTime / 60)
        Dim seconds As Integer = Int(speakingTime - (minutes * 60))
        Return Format(minutes, "00") & ":" & Format(seconds, "00")
    End Function
    Function CalculateTime(time As String) As String
        Dim timeParts As String() = time.Split(":"c)
        Dim minutes As Integer = Convert.ToInt32(timeParts(0))
        Dim seconds As Integer = Convert.ToInt32(timeParts(1))
        Dim totalSeconds As Integer = (minutes * 60) + seconds
        Dim fifteenPercent As Double = totalSeconds * 0.15
        totalSeconds += CInt(fifteenPercent)
        minutes = totalSeconds \ 60
        seconds = totalSeconds Mod 60
        Return String.Format("{0:00}:{1:00}", minutes, seconds)
    End Function

    Function d_t()
        Dim currentDate As DateTime = datetime.Now
        Dim dates = currentDate.ToString("dd/MM/yyyy")
        Dim time = currentDate.ToString("hh:mm:ss tt")
        c_t = time.ToString
        c_dt = dates + " " + time
    End Function

    Function SubtractTimes(time1 As String, time2 As String) As String
        Dim tim1 As TimeSpan = TimeSpan.Parse(time1)
        Dim tim2 As TimeSpan = TimeSpan.Parse(time2)
        Dim result As TimeSpan = tim1.Subtract(tim2)
        Return result.ToString
    End Function
End Module

