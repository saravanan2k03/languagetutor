<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.user_label2 = New System.Windows.Forms.Label()
        Me.Password_label3 = New System.Windows.Forms.Label()
        Me.login_Button1 = New System.Windows.Forms.Button()
        Me.user_TextBox1 = New System.Windows.Forms.TextBox()
        Me.pw_TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user_label2
        '
        Me.user_label2.AutoSize = True
        Me.user_label2.BackColor = System.Drawing.Color.Transparent
        Me.user_label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_label2.ForeColor = System.Drawing.Color.Black
        Me.user_label2.Location = New System.Drawing.Point(82, 320)
        Me.user_label2.Name = "user_label2"
        Me.user_label2.Size = New System.Drawing.Size(152, 32)
        Me.user_label2.TabIndex = 1
        Me.user_label2.Text = "User ID        :"
        '
        'Password_label3
        '
        Me.Password_label3.AutoSize = True
        Me.Password_label3.BackColor = System.Drawing.Color.Transparent
        Me.Password_label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_label3.ForeColor = System.Drawing.Color.Black
        Me.Password_label3.Location = New System.Drawing.Point(84, 390)
        Me.Password_label3.Name = "Password_label3"
        Me.Password_label3.Size = New System.Drawing.Size(151, 32)
        Me.Password_label3.TabIndex = 2
        Me.Password_label3.Text = "Password     :"
        '
        'login_Button1
        '
        Me.login_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.login_Button1.ForeColor = System.Drawing.Color.Black
        Me.login_Button1.Location = New System.Drawing.Point(187, 478)
        Me.login_Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.login_Button1.Name = "login_Button1"
        Me.login_Button1.Size = New System.Drawing.Size(198, 57)
        Me.login_Button1.TabIndex = 3
        Me.login_Button1.Text = "Login"
        Me.login_Button1.UseVisualStyleBackColor = True
        '
        'user_TextBox1
        '
        Me.user_TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user_TextBox1.Location = New System.Drawing.Point(264, 326)
        Me.user_TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.user_TextBox1.Name = "user_TextBox1"
        Me.user_TextBox1.Size = New System.Drawing.Size(212, 26)
        Me.user_TextBox1.TabIndex = 4
        '
        'pw_TextBox2
        '
        Me.pw_TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pw_TextBox2.Location = New System.Drawing.Point(262, 395)
        Me.pw_TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pw_TextBox2.Name = "pw_TextBox2"
        Me.pw_TextBox2.Size = New System.Drawing.Size(212, 26)
        Me.pw_TextBox2.TabIndex = 5
        Me.pw_TextBox2.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.comm.My.Resources.Resources.kll
        Me.PictureBox1.Location = New System.Drawing.Point(187, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(199, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MZ-VAASI"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(455, 594)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Version "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(527, 595)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "1.0"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 629)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pw_TextBox2)
        Me.Controls.Add(Me.user_TextBox1)
        Me.Controls.Add(Me.login_Button1)
        Me.Controls.Add(Me.Password_label3)
        Me.Controls.Add(Me.user_label2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Azure
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user_label2 As Label
    Friend WithEvents Password_label3 As Label
    Friend WithEvents login_Button1 As Button
    Friend WithEvents user_TextBox1 As TextBox
    Friend WithEvents pw_TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
