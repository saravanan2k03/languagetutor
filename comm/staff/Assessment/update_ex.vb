Imports System.Data.SqlClient

Public Class update_ex
    Private Sub update_ex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exercise.Text = ex_text.ToString
        ex_no.Text = ex_no_field.ToString
        status_field.Text = status_drop.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exercise.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If exercise.Text = "" Then
            MessageBox.Show("Please Enter Text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As SqlConnection = New SqlConnection(communication)
            Dim command1 As New SqlCommand("select created_by from ex_table where ex_id='" + E_no.ToString + "'", con)
            con.Open()
            Dim myreader As SqlDataReader
            myreader = command1.ExecuteReader()
            myreader.Read()
            If StaffId.ToString = myreader("created_by") Then
                ReadFromDatabase("Update ex_table set ex_text='" + exercise.Text + "',status='" + status_field.Text + "'where ex_id='" + "Exercise " + ex_no.Text + "'And created_by='" + StaffId.ToString + "'")
                MessageBox.Show("Updated Successful!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim frm = list_ex
                frm.Show()
                frm.MdiParent = admin_panel
                Me.Close()

            Else
                MessageBox.Show("you not have permission to access!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        End If
    End Sub

    Private Sub status_field_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_field.SelectedIndexChanged

    End Sub
End Class