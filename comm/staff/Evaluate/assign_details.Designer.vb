<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class assign_details
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
        Me.department_combo = New System.Windows.Forms.ComboBox()
        Me.semcombo = New System.Windows.Forms.ComboBox()
        Me.classcombo = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerEx = New System.Windows.Forms.DateTimePicker()
        Me.statuscombo = New System.Windows.Forms.ComboBox()
        Me.Showgriddata = New System.Windows.Forms.DataGridView()
        Me.Exercisecom = New System.Windows.Forms.ComboBox()
        Me.view_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Todaydate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Showgriddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'department_combo
        '
        Me.department_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.department_combo.FormattingEnabled = True
        Me.department_combo.Items.AddRange(New Object() {"", "B.E - CIVIL", "B.E - CSE", "B.E - ECE", "B.E - EEE", "B.E - MECH", "M.E - CS", "M.E - CSE", "M.E - PED", "M.E - STE"})
        Me.department_combo.Location = New System.Drawing.Point(627, 91)
        Me.department_combo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.department_combo.Name = "department_combo"
        Me.department_combo.Size = New System.Drawing.Size(281, 28)
        Me.department_combo.TabIndex = 0
        Me.department_combo.TabStop = False
        '
        'semcombo
        '
        Me.semcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semcombo.FormattingEnabled = True
        Me.semcombo.Items.AddRange(New Object() {"", "I Year", "II Year", "III Year", "IV Year"})
        Me.semcombo.Location = New System.Drawing.Point(1084, 88)
        Me.semcombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.semcombo.Name = "semcombo"
        Me.semcombo.Size = New System.Drawing.Size(281, 28)
        Me.semcombo.TabIndex = 1
        '
        'classcombo
        '
        Me.classcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classcombo.FormattingEnabled = True
        Me.classcombo.Items.AddRange(New Object() {"", "A", "B"})
        Me.classcombo.Location = New System.Drawing.Point(155, 178)
        Me.classcombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.classcombo.Name = "classcombo"
        Me.classcombo.Size = New System.Drawing.Size(281, 28)
        Me.classcombo.TabIndex = 2
        '
        'DateTimePickerEx
        '
        Me.DateTimePickerEx.Location = New System.Drawing.Point(155, 90)
        Me.DateTimePickerEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerEx.Name = "DateTimePickerEx"
        Me.DateTimePickerEx.Size = New System.Drawing.Size(281, 26)
        Me.DateTimePickerEx.TabIndex = 3
        Me.DateTimePickerEx.Value = New Date(2023, 1, 15, 0, 0, 0, 0)
        '
        'statuscombo
        '
        Me.statuscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statuscombo.FormattingEnabled = True
        Me.statuscombo.Items.AddRange(New Object() {"", "Attemted", "Assigned", "Not-attempted", "AllStatus"})
        Me.statuscombo.Location = New System.Drawing.Point(1084, 178)
        Me.statuscombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statuscombo.Name = "statuscombo"
        Me.statuscombo.Size = New System.Drawing.Size(281, 28)
        Me.statuscombo.TabIndex = 4
        '
        'Showgriddata
        '
        Me.Showgriddata.AllowUserToAddRows = False
        Me.Showgriddata.AllowUserToDeleteRows = False
        Me.Showgriddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Showgriddata.Location = New System.Drawing.Point(89, 250)
        Me.Showgriddata.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Showgriddata.Name = "Showgriddata"
        Me.Showgriddata.ReadOnly = True
        Me.Showgriddata.RowHeadersWidth = 51
        Me.Showgriddata.RowTemplate.Height = 29
        Me.Showgriddata.Size = New System.Drawing.Size(1277, 418)
        Me.Showgriddata.TabIndex = 5
        '
        'Exercisecom
        '
        Me.Exercisecom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Exercisecom.FormattingEnabled = True
        Me.Exercisecom.Items.AddRange(New Object() {"", "Attemted", "Completed", "Not-Attemted"})
        Me.Exercisecom.Location = New System.Drawing.Point(627, 178)
        Me.Exercisecom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Exercisecom.Name = "Exercisecom"
        Me.Exercisecom.Size = New System.Drawing.Size(281, 28)
        Me.Exercisecom.TabIndex = 6
        '
        'view_btn
        '
        Me.view_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.view_btn.Location = New System.Drawing.Point(561, 692)
        Me.view_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.view_btn.Name = "view_btn"
        Me.view_btn.Size = New System.Drawing.Size(234, 48)
        Me.view_btn.TabIndex = 7
        Me.view_btn.Text = "View"
        Me.view_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date :"
        '
        'Todaydate
        '
        Me.Todaydate.AutoSize = True
        Me.Todaydate.Location = New System.Drawing.Point(129, 38)
        Me.Todaydate.Name = "Todaydate"
        Me.Todaydate.Size = New System.Drawing.Size(91, 20)
        Me.Todaydate.TabIndex = 9
        Me.Todaydate.Text = "Today Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(981, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(981, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(470, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Exercise"
        '
        'assign_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1488, 768)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Todaydate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.view_btn)
        Me.Controls.Add(Me.Exercisecom)
        Me.Controls.Add(Me.Showgriddata)
        Me.Controls.Add(Me.statuscombo)
        Me.Controls.Add(Me.DateTimePickerEx)
        Me.Controls.Add(Me.classcombo)
        Me.Controls.Add(Me.semcombo)
        Me.Controls.Add(Me.department_combo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "assign_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Details"
        CType(Me.Showgriddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents department_combo As ComboBox
    Friend WithEvents semcombo As ComboBox
    Friend WithEvents classcombo As ComboBox
    Friend WithEvents DateTimePickerEx As DateTimePicker
    Friend WithEvents statuscombo As ComboBox
    Friend WithEvents Showgriddata As DataGridView
    Friend WithEvents Exercisecom As ComboBox
    Friend WithEvents view_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Todaydate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class