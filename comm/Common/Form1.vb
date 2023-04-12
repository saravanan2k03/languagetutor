Imports System.Data.SqlClient

Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            pb.Value = pb.Value + 1
            If pb.Value >= 100 Then
                Timer1.Stop()
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time As New Timer()
        time.Interval = 75
        AddHandler time.Tick, AddressOf Timer1_Tick
        time.Start()
    End Sub

End Class