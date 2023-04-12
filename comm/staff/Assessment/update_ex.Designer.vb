<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_ex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update_ex))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exercise = New System.Windows.Forms.RichTextBox()
        Me.ex_no = New System.Windows.Forms.Label()
        Me.status_field = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(766, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 50)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 586)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 50)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 33)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "UPDATE EXERCISE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 28)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TEXT :"
        '
        'exercise
        '
        Me.exercise.BackColor = System.Drawing.Color.White
        Me.exercise.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercise.Location = New System.Drawing.Point(96, 171)
        Me.exercise.Name = "exercise"
        Me.exercise.Size = New System.Drawing.Size(923, 381)
        Me.exercise.TabIndex = 12
        Me.exercise.Text = ""
        '
        'ex_no
        '
        Me.ex_no.AutoSize = True
        Me.ex_no.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex_no.Location = New System.Drawing.Point(583, 125)
        Me.ex_no.Name = "ex_no"
        Me.ex_no.Size = New System.Drawing.Size(25, 26)
        Me.ex_no.TabIndex = 18
        Me.ex_no.Text = "1"
        '
        'status_field
        '
        Me.status_field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_field.FormattingEnabled = True
        Me.status_field.Items.AddRange(New Object() {"Active", "Disabled"})
        Me.status_field.Location = New System.Drawing.Point(847, 125)
        Me.status_field.Name = "status_field"
        Me.status_field.Size = New System.Drawing.Size(172, 28)
        Me.status_field.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(749, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(504, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Ex.No:"
        '
        'update_ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 648)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.status_field)
        Me.Controls.Add(Me.ex_no)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exercise)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "update_ex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents exercise As RichTextBox
    Friend WithEvents ex_no As Label
    Friend WithEvents status_field As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
