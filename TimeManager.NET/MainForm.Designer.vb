<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCurrentProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimesheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllQuickEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimiseOnSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.TodayLabel = New System.Windows.Forms.Label()
        Me.CurrentTaskGroupBox = New System.Windows.Forms.GroupBox()
        Me.ElapsedTimeLabel = New System.Windows.Forms.Label()
        Me.ElapsedTimeTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectStartedAtTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectLabel = New System.Windows.Forms.Label()
        Me.ProjectCodeLabel = New System.Windows.Forms.Label()
        Me.StartedAtLabel = New System.Windows.Forms.Label()
        Me.TotalsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.DateTimeGroupBox.SuspendLayout()
        Me.CurrentTaskGroupBox.SuspendLayout()
        Me.TotalsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.QuickToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(314, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.StopCurrentProjectToolStripMenuItem, Me.ToolStripMenuItem2, Me.PrintToolStripMenuItem, Me.PrintSetupToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project..."
        '
        'StopCurrentProjectToolStripMenuItem
        '
        Me.StopCurrentProjectToolStripMenuItem.Enabled = False
        Me.StopCurrentProjectToolStripMenuItem.Name = "StopCurrentProjectToolStripMenuItem"
        Me.StopCurrentProjectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopCurrentProjectToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StopCurrentProjectToolStripMenuItem.Text = "Stop Current Project"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(218, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Print Setup..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(218, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimesheetToolStripMenuItem, Me.ProjectsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'TimesheetToolStripMenuItem
        '
        Me.TimesheetToolStripMenuItem.Name = "TimesheetToolStripMenuItem"
        Me.TimesheetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TimesheetToolStripMenuItem.Text = "Timesheet..."
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProjectsToolStripMenuItem.Text = "Projects..."
        '
        'QuickToolStripMenuItem
        '
        Me.QuickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ClearAllQuickEntriesToolStripMenuItem})
        Me.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        Me.QuickToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.QuickToolStripMenuItem.Text = "Quick"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 6)
        '
        'ClearAllQuickEntriesToolStripMenuItem
        '
        Me.ClearAllQuickEntriesToolStripMenuItem.Name = "ClearAllQuickEntriesToolStripMenuItem"
        Me.ClearAllQuickEntriesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClearAllQuickEntriesToolStripMenuItem.Text = "Clear all quick entries"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.CheckOnClick = True
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem, Me.MinimiseOnSelectionToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always On Top"
        '
        'MinimiseOnSelectionToolStripMenuItem
        '
        Me.MinimiseOnSelectionToolStripMenuItem.CheckOnClick = True
        Me.MinimiseOnSelectionToolStripMenuItem.Name = "MinimiseOnSelectionToolStripMenuItem"
        Me.MinimiseOnSelectionToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MinimiseOnSelectionToolStripMenuItem.Text = "Minimise on Selection"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'DateTimeGroupBox
        '
        Me.DateTimeGroupBox.Controls.Add(Me.TimeLabel)
        Me.DateTimeGroupBox.Controls.Add(Me.TimeTextBox)
        Me.DateTimeGroupBox.Controls.Add(Me.DateTextBox)
        Me.DateTimeGroupBox.Controls.Add(Me.TodayLabel)
        Me.DateTimeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DateTimeGroupBox.Location = New System.Drawing.Point(6, 27)
        Me.DateTimeGroupBox.Name = "DateTimeGroupBox"
        Me.DateTimeGroupBox.Size = New System.Drawing.Size(303, 42)
        Me.DateTimeGroupBox.TabIndex = 1
        Me.DateTimeGroupBox.TabStop = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Location = New System.Drawing.Point(229, 16)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(33, 13)
        Me.TimeLabel.TabIndex = 3
        Me.TimeLabel.Text = "Time:"
        '
        'TimeTextBox
        '
        Me.TimeTextBox.Location = New System.Drawing.Point(264, 13)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.ReadOnly = True
        Me.TimeTextBox.Size = New System.Drawing.Size(33, 20)
        Me.TimeTextBox.TabIndex = 2
        Me.TimeTextBox.TabStop = False
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(56, 13)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(173, 20)
        Me.DateTextBox.TabIndex = 1
        Me.DateTextBox.TabStop = False
        '
        'TodayLabel
        '
        Me.TodayLabel.AutoSize = True
        Me.TodayLabel.Location = New System.Drawing.Point(6, 16)
        Me.TodayLabel.Name = "TodayLabel"
        Me.TodayLabel.Size = New System.Drawing.Size(50, 13)
        Me.TodayLabel.TabIndex = 0
        Me.TodayLabel.Text = "Today is:"
        '
        'CurrentTaskGroupBox
        '
        Me.CurrentTaskGroupBox.Controls.Add(Me.ElapsedTimeLabel)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ElapsedTimeTextBox)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ProjectNameTextBox)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ProjectCodeTextBox)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ProjectStartedAtTextBox)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ProjectLabel)
        Me.CurrentTaskGroupBox.Controls.Add(Me.ProjectCodeLabel)
        Me.CurrentTaskGroupBox.Controls.Add(Me.StartedAtLabel)
        Me.CurrentTaskGroupBox.ForeColor = System.Drawing.Color.Black
        Me.CurrentTaskGroupBox.Location = New System.Drawing.Point(6, 75)
        Me.CurrentTaskGroupBox.Name = "CurrentTaskGroupBox"
        Me.CurrentTaskGroupBox.Size = New System.Drawing.Size(303, 87)
        Me.CurrentTaskGroupBox.TabIndex = 2
        Me.CurrentTaskGroupBox.TabStop = False
        Me.CurrentTaskGroupBox.Text = "Current Project"
        '
        'ElapsedTimeLabel
        '
        Me.ElapsedTimeLabel.AutoSize = True
        Me.ElapsedTimeLabel.Location = New System.Drawing.Point(184, 12)
        Me.ElapsedTimeLabel.Name = "ElapsedTimeLabel"
        Me.ElapsedTimeLabel.Size = New System.Drawing.Size(74, 13)
        Me.ElapsedTimeLabel.TabIndex = 9
        Me.ElapsedTimeLabel.Text = "Elapsed Time:"
        '
        'ElapsedTimeTextBox
        '
        Me.ElapsedTimeTextBox.Location = New System.Drawing.Point(264, 9)
        Me.ElapsedTimeTextBox.Name = "ElapsedTimeTextBox"
        Me.ElapsedTimeTextBox.ReadOnly = True
        Me.ElapsedTimeTextBox.Size = New System.Drawing.Size(33, 20)
        Me.ElapsedTimeTextBox.TabIndex = 8
        Me.ElapsedTimeTextBox.TabStop = False
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(87, 55)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.ReadOnly = True
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(209, 20)
        Me.ProjectNameTextBox.TabIndex = 6
        Me.ProjectNameTextBox.TabStop = False
        '
        'ProjectCodeTextBox
        '
        Me.ProjectCodeTextBox.Location = New System.Drawing.Point(87, 32)
        Me.ProjectCodeTextBox.Name = "ProjectCodeTextBox"
        Me.ProjectCodeTextBox.ReadOnly = True
        Me.ProjectCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProjectCodeTextBox.TabIndex = 5
        Me.ProjectCodeTextBox.TabStop = False
        '
        'ProjectStartedAtTextBox
        '
        Me.ProjectStartedAtTextBox.Location = New System.Drawing.Point(87, 9)
        Me.ProjectStartedAtTextBox.Name = "ProjectStartedAtTextBox"
        Me.ProjectStartedAtTextBox.ReadOnly = True
        Me.ProjectStartedAtTextBox.Size = New System.Drawing.Size(46, 20)
        Me.ProjectStartedAtTextBox.TabIndex = 4
        Me.ProjectStartedAtTextBox.TabStop = False
        '
        'ProjectLabel
        '
        Me.ProjectLabel.AutoSize = True
        Me.ProjectLabel.Location = New System.Drawing.Point(6, 62)
        Me.ProjectLabel.Name = "ProjectLabel"
        Me.ProjectLabel.Size = New System.Drawing.Size(43, 13)
        Me.ProjectLabel.TabIndex = 2
        Me.ProjectLabel.Text = "Project:"
        '
        'ProjectCodeLabel
        '
        Me.ProjectCodeLabel.AutoSize = True
        Me.ProjectCodeLabel.Location = New System.Drawing.Point(6, 39)
        Me.ProjectCodeLabel.Name = "ProjectCodeLabel"
        Me.ProjectCodeLabel.Size = New System.Drawing.Size(71, 13)
        Me.ProjectCodeLabel.TabIndex = 1
        Me.ProjectCodeLabel.Text = "Project Code:"
        '
        'StartedAtLabel
        '
        Me.StartedAtLabel.AutoSize = True
        Me.StartedAtLabel.Location = New System.Drawing.Point(6, 16)
        Me.StartedAtLabel.Name = "StartedAtLabel"
        Me.StartedAtLabel.Size = New System.Drawing.Size(57, 13)
        Me.StartedAtLabel.TabIndex = 0
        Me.StartedAtLabel.Text = "Started At:"
        '
        'TotalsGroupBox
        '
        Me.TotalsGroupBox.Controls.Add(Me.TotalTextBox)
        Me.TotalsGroupBox.Controls.Add(Me.TotalLabel)
        Me.TotalsGroupBox.ForeColor = System.Drawing.Color.Black
        Me.TotalsGroupBox.Location = New System.Drawing.Point(9, 168)
        Me.TotalsGroupBox.Name = "TotalsGroupBox"
        Me.TotalsGroupBox.Size = New System.Drawing.Size(300, 58)
        Me.TotalsGroupBox.TabIndex = 3
        Me.TotalsGroupBox.TabStop = False
        Me.TotalsGroupBox.Text = "Totals for Day"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(237, 32)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(33, 20)
        Me.TotalTextBox.TabIndex = 5
        Me.TotalTextBox.TabStop = False
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(234, 17)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 2
        Me.TotalLabel.Text = "Total"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "TimeManager"
        Me.NotifyIcon1.Text = "TimeManager"
        Me.NotifyIcon1.Visible = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 232)
        Me.Controls.Add(Me.TotalsGroupBox)
        Me.Controls.Add(Me.CurrentTaskGroupBox)
        Me.Controls.Add(Me.DateTimeGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Time Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DateTimeGroupBox.ResumeLayout(False)
        Me.DateTimeGroupBox.PerformLayout()
        Me.CurrentTaskGroupBox.ResumeLayout(False)
        Me.CurrentTaskGroupBox.PerformLayout()
        Me.TotalsGroupBox.ResumeLayout(False)
        Me.TotalsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TodayLabel As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentTaskGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents StartedAtLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectCodeLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectStartedAtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ElapsedTimeLabel As System.Windows.Forms.Label
    Friend WithEvents ElapsedTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearAllQuickEntriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopCurrentProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimesheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents MinimiseOnSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
