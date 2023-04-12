<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_panel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_panel))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.time_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Time_input = New System.Windows.Forms.ToolStripStatusLabel()
        Me.date_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.date_input = New System.Windows.Forms.ToolStripStatusLabel()
        Me.user_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.user_input = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dep_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dep_input = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ver_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ver_input = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mzcet = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Profile_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWASSIGNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Assessment_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATTEMPTEDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.evaluate_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.permission_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.stu_assessment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAssessmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.validation_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListValidataionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.student_assessment_strip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1.SuspendLayout()
        Me.student_assessment_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.time_label, Me.Time_input, Me.date_label, Me.date_input, Me.user_label, Me.user_input, Me.dep_label, Me.dep_input, Me.ver_label, Me.ver_input, Me.mzcet})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1014)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1924, 36)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'time_label
        '
        Me.time_label.BackColor = System.Drawing.Color.White
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(59, 29)
        Me.time_label.Text = "Time :"
        '
        'Time_input
        '
        Me.Time_input.BackColor = System.Drawing.Color.White
        Me.Time_input.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.Time_input.Name = "Time_input"
        Me.Time_input.Size = New System.Drawing.Size(99, 29)
        Me.Time_input.Text = "time_input"
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.White
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(58, 29)
        Me.date_label.Text = "Date :"
        '
        'date_input
        '
        Me.date_input.BackColor = System.Drawing.Color.White
        Me.date_input.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.date_input.Name = "date_input"
        Me.date_input.Size = New System.Drawing.Size(99, 29)
        Me.date_input.Text = "date_input"
        '
        'user_label
        '
        Me.user_label.BackColor = System.Drawing.Color.White
        Me.user_label.Name = "user_label"
        Me.user_label.Size = New System.Drawing.Size(56, 29)
        Me.user_label.Text = "User :"
        '
        'user_input
        '
        Me.user_input.BackColor = System.Drawing.Color.White
        Me.user_input.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.user_input.Name = "user_input"
        Me.user_input.Size = New System.Drawing.Size(97, 29)
        Me.user_input.Text = "user_input"
        '
        'dep_label
        '
        Me.dep_label.BackColor = System.Drawing.Color.White
        Me.dep_label.Name = "dep_label"
        Me.dep_label.Size = New System.Drawing.Size(116, 29)
        Me.dep_label.Text = "Department :"
        '
        'dep_input
        '
        Me.dep_input.BackColor = System.Drawing.Color.White
        Me.dep_input.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.dep_input.Name = "dep_input"
        Me.dep_input.Size = New System.Drawing.Size(95, 29)
        Me.dep_input.Text = "dep_input"
        '
        'ver_label
        '
        Me.ver_label.BackColor = System.Drawing.Color.White
        Me.ver_label.Name = "ver_label"
        Me.ver_label.Size = New System.Drawing.Size(79, 29)
        Me.ver_label.Text = "Version :"
        '
        'ver_input
        '
        Me.ver_input.BackColor = System.Drawing.Color.White
        Me.ver_input.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ver_input.Name = "ver_input"
        Me.ver_input.Size = New System.Drawing.Size(88, 29)
        Me.ver_input.Text = "ver_input"
        '
        'mzcet
        '
        Me.mzcet.BackColor = System.Drawing.Color.White
        Me.mzcet.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.mzcet.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.mzcet.Name = "mzcet"
        Me.mzcet.Size = New System.Drawing.Size(423, 29)
        Me.mzcet.Text = "Mount Zion College of Engineering and Technology"
        '
        'Profile_strip
        '
        Me.Profile_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWASSIGNToolStripMenuItem, Me.AssignToolStripMenuItem1, Me.UpdateToolStripMenuItem})
        Me.Profile_strip.Name = "Profile_strip"
        Me.Profile_strip.Size = New System.Drawing.Size(78, 29)
        Me.Profile_strip.Text = "Profile"
        '
        'NEWASSIGNToolStripMenuItem
        '
        Me.NEWASSIGNToolStripMenuItem.Name = "NEWASSIGNToolStripMenuItem"
        Me.NEWASSIGNToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.NEWASSIGNToolStripMenuItem.Text = "Dashboard"
        '
        'AssignToolStripMenuItem1
        '
        Me.AssignToolStripMenuItem1.Name = "AssignToolStripMenuItem1"
        Me.AssignToolStripMenuItem1.Size = New System.Drawing.Size(254, 34)
        Me.AssignToolStripMenuItem1.Text = "Change Password"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.UpdateToolStripMenuItem.Text = "Logout"
        '
        'Assessment_strip
        '
        Me.Assessment_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ATTEMPTEDToolStripMenuItem, Me.PlayAudioToolStripMenuItem, Me.UpdateToolStripMenuItem1})
        Me.Assessment_strip.Name = "Assessment_strip"
        Me.Assessment_strip.Size = New System.Drawing.Size(122, 29)
        Me.Assessment_strip.Text = "Assessment"
        '
        'ATTEMPTEDToolStripMenuItem
        '
        Me.ATTEMPTEDToolStripMenuItem.Name = "ATTEMPTEDToolStripMenuItem"
        Me.ATTEMPTEDToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ATTEMPTEDToolStripMenuItem.Text = "Create"
        '
        'PlayAudioToolStripMenuItem
        '
        Me.PlayAudioToolStripMenuItem.Name = "PlayAudioToolStripMenuItem"
        Me.PlayAudioToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PlayAudioToolStripMenuItem.Text = "Assign"
        '
        'UpdateToolStripMenuItem1
        '
        Me.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        Me.UpdateToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.UpdateToolStripMenuItem1.Text = "Update"
        '
        'evaluate_strip
        '
        Me.evaluate_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAssessmentToolStripMenuItem, Me.FilterToolStripMenuItem})
        Me.evaluate_strip.Name = "evaluate_strip"
        Me.evaluate_strip.Size = New System.Drawing.Size(93, 29)
        Me.evaluate_strip.Text = "Evaluate"
        '
        'ViewAssessmentToolStripMenuItem
        '
        Me.ViewAssessmentToolStripMenuItem.Name = "ViewAssessmentToolStripMenuItem"
        Me.ViewAssessmentToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ViewAssessmentToolStripMenuItem.Text = "View Assessments"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.FilterToolStripMenuItem.Text = "Filter Assessments"
        '
        'permission_strip
        '
        Me.permission_strip.Name = "permission_strip"
        Me.permission_strip.Size = New System.Drawing.Size(104, 29)
        Me.permission_strip.Text = "Authorize"
        '
        'stu_assessment
        '
        Me.stu_assessment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListAssessmentToolStripMenuItem})
        Me.stu_assessment.Name = "stu_assessment"
        Me.stu_assessment.Size = New System.Drawing.Size(122, 29)
        Me.stu_assessment.Text = "Assessment"
        '
        'ListAssessmentToolStripMenuItem
        '
        Me.ListAssessmentToolStripMenuItem.Name = "ListAssessmentToolStripMenuItem"
        Me.ListAssessmentToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ListAssessmentToolStripMenuItem.Text = "List Assessment"
        '
        'validation_strip
        '
        Me.validation_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListValidataionToolStripMenuItem})
        Me.validation_strip.Name = "validation_strip"
        Me.validation_strip.Size = New System.Drawing.Size(106, 29)
        Me.validation_strip.Text = "Validation"
        '
        'ListValidataionToolStripMenuItem
        '
        Me.ListValidataionToolStripMenuItem.Name = "ListValidataionToolStripMenuItem"
        Me.ListValidataionToolStripMenuItem.Size = New System.Drawing.Size(232, 34)
        Me.ListValidataionToolStripMenuItem.Text = "List Validataion"
        '
        'student_assessment_strip
        '
        Me.student_assessment_strip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.student_assessment_strip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.student_assessment_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Profile_strip, Me.Assessment_strip, Me.evaluate_strip, Me.permission_strip, Me.stu_assessment, Me.validation_strip})
        Me.student_assessment_strip.Location = New System.Drawing.Point(0, 0)
        Me.student_assessment_strip.Name = "student_assessment_strip"
        Me.student_assessment_strip.Size = New System.Drawing.Size(1924, 33)
        Me.student_assessment_strip.TabIndex = 1
        Me.student_assessment_strip.Text = "MenuStrip1"
        '
        'admin_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.student_assessment_strip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.student_assessment_strip
        Me.Name = "admin_panel"
        Me.Text = "MZ-VAASI (An automated language learning environment)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.student_assessment_strip.ResumeLayout(False)
        Me.student_assessment_strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents time_label As ToolStripStatusLabel
    Friend WithEvents Time_input As ToolStripStatusLabel
    Friend WithEvents date_label As ToolStripStatusLabel
    Friend WithEvents date_input As ToolStripStatusLabel
    Friend WithEvents user_label As ToolStripStatusLabel
    Friend WithEvents user_input As ToolStripStatusLabel
    Friend WithEvents dep_label As ToolStripStatusLabel
    Friend WithEvents dep_input As ToolStripStatusLabel
    Friend WithEvents ver_label As ToolStripStatusLabel
    Friend WithEvents ver_input As ToolStripStatusLabel
    Friend WithEvents mzcet As ToolStripStatusLabel
    Friend WithEvents Profile_strip As ToolStripMenuItem
    Friend WithEvents NEWASSIGNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Assessment_strip As ToolStripMenuItem
    Friend WithEvents ATTEMPTEDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayAudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents evaluate_strip As ToolStripMenuItem
    Friend WithEvents ViewAssessmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents permission_strip As ToolStripMenuItem
    Friend WithEvents stu_assessment As ToolStripMenuItem
    Friend WithEvents ListAssessmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents validation_strip As ToolStripMenuItem
    Friend WithEvents ListValidataionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents student_assessment_strip As MenuStrip
End Class
