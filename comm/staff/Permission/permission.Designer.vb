<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Permission
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
        Me.programme = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Department = New System.Windows.Forms.ComboBox()
        Me.s_class = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Students_List = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Students_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'programme
        '
        Me.programme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.programme.FormattingEnabled = True
        Me.programme.Items.AddRange(New Object() {"", "UG", "PG"})
        Me.programme.Location = New System.Drawing.Point(241, 145)
        Me.programme.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.programme.Name = "programme"
        Me.programme.Size = New System.Drawing.Size(214, 28)
        Me.programme.TabIndex = 0
        '
        'Year
        '
        Me.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"", "I Year", "II Year", "III Year", "IV Year"})
        Me.Year.Location = New System.Drawing.Point(241, 236)
        Me.Year.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(214, 28)
        Me.Year.TabIndex = 1
        '
        'Department
        '
        Me.Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Department.FormattingEnabled = True
        Me.Department.Items.AddRange(New Object() {"", "B.E - CIVIL", "B.E - CSE", "B.E - ECE", "B.E - EEE", "B.E - MECH"})
        Me.Department.Location = New System.Drawing.Point(778, 148)
        Me.Department.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(214, 28)
        Me.Department.TabIndex = 2
        '
        's_class
        '
        Me.s_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.s_class.FormattingEnabled = True
        Me.s_class.Items.AddRange(New Object() {"", "A", "B"})
        Me.s_class.Location = New System.Drawing.Point(778, 236)
        Me.s_class.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.s_class.Name = "s_class"
        Me.s_class.Size = New System.Drawing.Size(214, 28)
        Me.s_class.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Programme  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(609, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Department  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year                  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(611, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Class                :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 312)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 312)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 49)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Allow to validate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Students_List
        '
        Me.Students_List.AllowUserToAddRows = False
        Me.Students_List.AllowUserToDeleteRows = False
        Me.Students_List.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Students_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Students_List.ColumnHeadersHeight = 34
        Me.Students_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Students_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.Students_List.Location = New System.Drawing.Point(58, 378)
        Me.Students_List.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Students_List.Name = "Students_List"
        Me.Students_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Students_List.RowHeadersVisible = False
        Me.Students_List.RowHeadersWidth = 62
        Me.Students_List.RowTemplate.Height = 28
        Me.Students_List.Size = New System.Drawing.Size(948, 322)
        Me.Students_List.TabIndex = 10
        '
        'chk
        '
        Me.chk.HeaderText = "     All"
        Me.chk.MinimumWidth = 8
        Me.chk.Name = "chk"
        Me.chk.Width = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Select Student's Permission "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(660, 312)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 49)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Revoke validation rights"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1064, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Students_List)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.s_class)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.programme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(230, 65)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Permission"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student permission"
        CType(Me.Students_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents programme As ComboBox
    Friend WithEvents Year As ComboBox
    Friend WithEvents Department As ComboBox
    Friend WithEvents s_class As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Students_List As DataGridView
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
End Class
