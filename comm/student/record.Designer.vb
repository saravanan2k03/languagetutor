<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class record
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(record))
        Me.Recbtn = New System.Windows.Forms.Button()
        Me.Playbtn = New System.Windows.Forms.Button()
        Me.Stopbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mic = New System.Windows.Forms.PictureBox()
        CType(Me.mic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Recbtn
        '
        Me.Recbtn.Location = New System.Drawing.Point(1167, 395)
        Me.Recbtn.Name = "Recbtn"
        Me.Recbtn.Size = New System.Drawing.Size(251, 59)
        Me.Recbtn.TabIndex = 0
        Me.Recbtn.Text = "Record"
        Me.Recbtn.UseVisualStyleBackColor = True
        '
        'Playbtn
        '
        Me.Playbtn.Location = New System.Drawing.Point(1167, 475)
        Me.Playbtn.Name = "Playbtn"
        Me.Playbtn.Size = New System.Drawing.Size(251, 59)
        Me.Playbtn.TabIndex = 1
        Me.Playbtn.Text = "Playback"
        Me.Playbtn.UseVisualStyleBackColor = True
        '
        'Stopbtn
        '
        Me.Stopbtn.Location = New System.Drawing.Point(1167, 554)
        Me.Stopbtn.Name = "Stopbtn"
        Me.Stopbtn.Size = New System.Drawing.Size(251, 59)
        Me.Stopbtn.TabIndex = 2
        Me.Stopbtn.Text = "Stop"
        Me.Stopbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1167, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.White
        Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input.Location = New System.Drawing.Point(37, 75)
        Me.input.Name = "input"
        Me.input.ReadOnly = True
        Me.input.Size = New System.Drawing.Size(1060, 614)
        Me.input.TabIndex = 4
        Me.input.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Read the Passage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1214, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 37)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "00:00:00"
        '
        'Timer1
        '
        '
        'mic
        '
        Me.mic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mic.Image = Global.comm.My.Resources.Resources.giphy
        Me.mic.InitialImage = Nothing
        Me.mic.Location = New System.Drawing.Point(1167, 75)
        Me.mic.Name = "mic"
        Me.mic.Size = New System.Drawing.Size(251, 233)
        Me.mic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mic.TabIndex = 6
        Me.mic.TabStop = False
        '
        'record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1462, 701)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Stopbtn)
        Me.Controls.Add(Me.Playbtn)
        Me.Controls.Add(Me.Recbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "record"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 30, 20)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record"
        CType(Me.mic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Recbtn As Button
    Friend WithEvents Playbtn As Button
    Friend WithEvents Stopbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents input As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mic As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class
