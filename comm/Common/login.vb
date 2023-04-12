Imports System.Data.SqlClient
Imports communication.globalfile
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports Google.Apis.Auth
Imports Google.Cloud.Speech.V1
Imports System.IO
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Protobuf

Public Class login
    Inherits Form

    Private Sub login_Button1_Click(sender As Object, e As EventArgs) Handles login_Button1.Click
        Dim userid
        Dim password
        Dim user_name
        Dim dep
        Dim user_class
        Dim user_year
        If (user_TextBox1.Text = "" And pw_TextBox2.Text = "") Then
            MessageBox.Show("Username And Password is Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf (user_TextBox1.Text = "") Then
            MessageBox.Show("Username is Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        ElseIf (pw_TextBox2.Text = "") Then
            MessageBox.Show("Password is Empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim con As SqlConnection = New SqlConnection(DBConnectionStringstu)
            con.Open()
            Dim checkid As SqlCommand = New SqlCommand("Select spr_no,password,Name,Department,class,year from students where spr_no='" + user_TextBox1.Text + "'", con)
            Dim checkreader As SqlDataReader
            checkreader = checkid.ExecuteReader
            checkreader.Read()
            If checkreader.HasRows = False Then
                con.Close()
                con.Open()
                Dim checkid1 As SqlCommand = New SqlCommand("Select Employee_ID,password,Employee_Name,Department from staffs where Employee_ID='" + user_TextBox1.Text + "'", con)
                Dim checkreader1 As SqlDataReader
                checkreader1 = checkid1.ExecuteReader
                checkreader1.Read()
                If checkreader1.HasRows = False Then
                    con.Close()
                    MessageBox.Show("Invalid UserId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    userid = checkreader1("Employee_ID")
                    password = checkreader1("password")
                    user_name = checkreader1("Employee_Name")
                    dep = checkreader1("Department")
                    con.Close()

                    If (user_TextBox1.Text = userid And pw_TextBox2.Text = password) Then
                        StaffId = userid.ToString
                        StaffName = UCase(user_name.ToString)
                        StaffDep = dep.ToString
                        'MessageBox.Show("Login Successful !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        authentication = "0"
                        Me.Close()
                    Else
                        MessageBox.Show("Invalid credentials", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                userid = checkreader("spr_no")
                password = checkreader("password")
                user_name = checkreader("Name")
                dep = checkreader("Department")
                user_class = checkreader("class")
                user_year = checkreader("year")
                con.Close()
                If (user_TextBox1.Text = userid And pw_TextBox2.Text = password) Then
                    StuSprNo = userid.ToString
                    StuName = user_name.ToString
                    StuDep = dep.ToString
                    StuClass = user_class.ToString
                    StuYear = user_year.ToString
                    'MessageBox.Show("Login Successful !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    authentication = "1"
                    Me.Close()
                Else
                    MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        End If




    End Sub

    Private Sub VersionCheck()
        Dim con As SqlConnection = New SqlConnection(DBConnectionString)
        con.Open()

        Dim cmd As SqlCommand = New SqlCommand("select id,version from communication.dbo.software_details", con)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        Dim version As String
        Dim currentversion As String
        version = myreader("version").ToString
        currentversion = "1.0"
        If version <> currentversion Then
            MessageBox.Show("Update Available!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            admin_panel.Close()


        End If

    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VersionCheck()
        user_TextBox1.Focus()

    End Sub

    Private Sub user_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles user_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            pw_TextBox2.Focus()
        End If
    End Sub

    Private Sub pw_TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles pw_TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login_Button1.Focus()
        End If
    End Sub
End Class