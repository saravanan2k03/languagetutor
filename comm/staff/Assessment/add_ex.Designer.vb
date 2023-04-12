<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class add_ex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_ex))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exercise = New System.Windows.Forms.RichTextBox()
        Me.ex_no = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(801, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EX.NO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TEXT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ADD EXERCISE"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 563)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(631, 563)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'exercise
        '
        Me.exercise.BackColor = System.Drawing.Color.White
        Me.exercise.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exercise.Location = New System.Drawing.Point(48, 177)
        Me.exercise.Name = "exercise"
        Me.exercise.Size = New System.Drawing.Size(936, 344)
        Me.exercise.TabIndex = 2
        Me.exercise.Text = ""
        '
        'ex_no
        '
        Me.ex_no.AutoSize = True
        Me.ex_no.Font = New System.Drawing.Font("Cambria", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ex_no.Location = New System.Drawing.Point(890, 129)
        Me.ex_no.Name = "ex_no"
        Me.ex_no.Size = New System.Drawing.Size(25, 26)
        Me.ex_no.TabIndex = 10
        Me.ex_no.Text = "1"
        '
        'add_ex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 650)
        Me.Controls.Add(Me.ex_no)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exercise)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "add_ex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents exercise As RichTextBox
    Friend WithEvents ex_no As Label
End Class
