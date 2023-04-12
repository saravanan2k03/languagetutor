<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class assign
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(assign))
        Me.Input = New System.Windows.Forms.RichTextBox()
        Me.select_mode = New System.Windows.Forms.ComboBox()
        Me.select_ex = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExtableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.duration = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.count_words = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ExtableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.BackColor = System.Drawing.Color.White
        Me.Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.Location = New System.Drawing.Point(65, 268)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(1116, 393)
        Me.Input.TabIndex = 0
        Me.Input.Text = ""
        '
        'select_mode
        '
        Me.select_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_mode.FormattingEnabled = True
        Me.select_mode.Items.AddRange(New Object() {"", "Exercise", "Copy Text"})
        Me.select_mode.Location = New System.Drawing.Point(180, 136)
        Me.select_mode.Name = "select_mode"
        Me.select_mode.Size = New System.Drawing.Size(253, 28)
        Me.select_mode.TabIndex = 1
        '
        'select_ex
        '
        Me.select_ex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.select_ex.FormattingEnabled = True
        Me.select_ex.Location = New System.Drawing.Point(928, 136)
        Me.select_ex.Name = "select_ex"
        Me.select_ex.Size = New System.Drawing.Size(253, 28)
        Me.select_ex.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Assign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(925, 688)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TEXT :"
        '
        'ExtableBindingSource
        '
        Me.ExtableBindingSource.DataMember = "ex_table"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Staff Id :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(805, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Name       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mode    :"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(167, 42)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(34, 28)
        Me.id.TabIndex = 12
        Me.id.Text = "id"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.Location = New System.Drawing.Point(950, 42)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(75, 28)
        Me.Name.TabIndex = 13
        Me.Name.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(805, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 28)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Exercise :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(506, 748)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Expected Audio duration limit"
        '
        'duration
        '
        Me.duration.AutoSize = True
        Me.duration.ForeColor = System.Drawing.Color.Red
        Me.duration.Location = New System.Drawing.Point(586, 772)
        Me.duration.Name = "duration"
        Me.duration.Size = New System.Drawing.Size(61, 20)
        Me.duration.TabIndex = 16
        Me.duration.Text = "MM:SS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(973, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 28)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "No.of.Words:"
        '
        'count_words
        '
        Me.count_words.AutoSize = True
        Me.count_words.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_words.Location = New System.Drawing.Point(1126, 239)
        Me.count_words.Name = "count_words"
        Me.count_words.Size = New System.Drawing.Size(26, 28)
        Me.count_words.TabIndex = 18
        Me.count_words.Text = "0"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(510, 688)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 50)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Add Duration (15%)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1225, 811)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.count_words)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.duration)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.select_ex)
        Me.Controls.Add(Me.select_mode)
        Me.Controls.Add(Me.Input)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(230, 65)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        'Me.Name = "assign"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign"
        CType(Me.ExtableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As RichTextBox
    Friend WithEvents select_mode As ComboBox
    Friend WithEvents select_ex As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExtableBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id As Label
    Friend WithEvents Name As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents duration As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents count_words As Label
    Friend WithEvents Button3 As Button
End Class
