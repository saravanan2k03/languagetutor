Imports comm.My

Public Class messageform
    Private Sub messageform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limitation.Text = dur_time.ToString
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.Myset = "Ok"
            My.Settings.Save()
        End If
        If CheckBox1.Checked = False Then
            My.Settings.Myset = "cancel"
            My.Settings.Save()
        End If
        My.Settings.Save()

        Me.Close()
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

End Class