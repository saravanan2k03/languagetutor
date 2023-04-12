<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class valuation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(valuation))
        Me.ex_input = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.precentage = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.beg_dur = New System.Windows.Forms.Label()
        Me.end_dur = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stu_output = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ex_input
        '
        Me.ex_input.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.ex_input, "ex_input")
        Me.ex_input.Name = "ex_input"
        Me.ex_input.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.GreenYellow
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'precentage
        '
        resources.ApplyResources(Me.precentage, "precentage")
        Me.precentage.Name = "precentage"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'beg_dur
        '
        resources.ApplyResources(Me.beg_dur, "beg_dur")
        Me.beg_dur.ForeColor = System.Drawing.Color.Blue
        Me.beg_dur.Name = "beg_dur"
        '
        'end_dur
        '
        resources.ApplyResources(Me.end_dur, "end_dur")
        Me.end_dur.ForeColor = System.Drawing.Color.Red
        Me.end_dur.Name = "end_dur"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'stu_output
        '
        Me.stu_output.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.stu_output, "stu_output")
        Me.stu_output.Name = "stu_output"
        Me.stu_output.ReadOnly = True
        '
        'Timer1
        '
        '
        'valuation
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.stu_output)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ex_input)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.precentage)
        Me.Controls.Add(Me.beg_dur)
        Me.Controls.Add(Me.end_dur)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "valuation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ex_input As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents precentage As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents beg_dur As Label
    Friend WithEvents end_dur As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents stu_output As RichTextBox
    Friend WithEvents Timer1 As Timer
End Class
