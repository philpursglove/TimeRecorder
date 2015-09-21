<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTimesForm
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
        Me.TimesForLabel = New System.Windows.Forms.Label
        Me.DateComboBox = New System.Windows.Forms.ComboBox
        Me.NewDateButton = New System.Windows.Forms.Button
        Me.DailyTimesGridView = New System.Windows.Forms.DataGridView
        Me.StartTimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EndTimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProjectNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProjectIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaskIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeEntryIDColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DailyTotalGroupBox = New System.Windows.Forms.GroupBox
        Me.TotalLabel = New System.Windows.Forms.Label
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.TaskGroupBox = New System.Windows.Forms.GroupBox
        Me.TaskTextBox = New System.Windows.Forms.TextBox
        Me.CloseButton = New System.Windows.Forms.Button
        Me.DeleteTimeEntryButton = New System.Windows.Forms.Button
        Me.CopyTimeEntryButton = New System.Windows.Forms.Button
        Me.InsertTimeEntryButton = New System.Windows.Forms.Button
        Me.EditTimeEntryButton = New System.Windows.Forms.Button
        Me.NewTimeEntryButton = New System.Windows.Forms.Button
        CType(Me.DailyTimesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DailyTotalGroupBox.SuspendLayout()
        Me.TaskGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimesForLabel
        '
        Me.TimesForLabel.AutoSize = True
        Me.TimesForLabel.Location = New System.Drawing.Point(88, 13)
        Me.TimesForLabel.Name = "TimesForLabel"
        Me.TimesForLabel.Size = New System.Drawing.Size(50, 13)
        Me.TimesForLabel.TabIndex = 0
        Me.TimesForLabel.Text = "Times for"
        '
        'DateComboBox
        '
        Me.DateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateComboBox.FormattingEnabled = True
        Me.DateComboBox.Location = New System.Drawing.Point(144, 10)
        Me.DateComboBox.Name = "DateComboBox"
        Me.DateComboBox.Size = New System.Drawing.Size(174, 21)
        Me.DateComboBox.TabIndex = 1
        '
        'NewDateButton
        '
        Me.NewDateButton.Location = New System.Drawing.Point(324, 8)
        Me.NewDateButton.Name = "NewDateButton"
        Me.NewDateButton.Size = New System.Drawing.Size(75, 23)
        Me.NewDateButton.TabIndex = 2
        Me.NewDateButton.Text = "New Date..."
        Me.NewDateButton.UseVisualStyleBackColor = True
        '
        'DailyTimesGridView
        '
        Me.DailyTimesGridView.AllowUserToAddRows = False
        Me.DailyTimesGridView.AllowUserToDeleteRows = False
        Me.DailyTimesGridView.AllowUserToResizeRows = False
        Me.DailyTimesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DailyTimesGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StartTimeColumn, Me.EndTimeColumn, Me.ProjectNameColumn, Me.TaskNameColumn, Me.ProjectIDColumn, Me.TaskIDColumn, Me.TimeEntryIDColumn})
        Me.DailyTimesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DailyTimesGridView.Location = New System.Drawing.Point(12, 37)
        Me.DailyTimesGridView.Name = "DailyTimesGridView"
        Me.DailyTimesGridView.ReadOnly = True
        Me.DailyTimesGridView.RowHeadersVisible = False
        Me.DailyTimesGridView.Size = New System.Drawing.Size(547, 203)
        Me.DailyTimesGridView.TabIndex = 3
        '
        'StartTimeColumn
        '
        Me.StartTimeColumn.HeaderText = "Start"
        Me.StartTimeColumn.Name = "StartTimeColumn"
        Me.StartTimeColumn.ReadOnly = True
        '
        'EndTimeColumn
        '
        Me.EndTimeColumn.HeaderText = "End"
        Me.EndTimeColumn.Name = "EndTimeColumn"
        Me.EndTimeColumn.ReadOnly = True
        '
        'ProjectNameColumn
        '
        Me.ProjectNameColumn.HeaderText = "Project"
        Me.ProjectNameColumn.Name = "ProjectNameColumn"
        Me.ProjectNameColumn.ReadOnly = True
        '
        'TaskNameColumn
        '
        Me.TaskNameColumn.HeaderText = "Task"
        Me.TaskNameColumn.Name = "TaskNameColumn"
        Me.TaskNameColumn.ReadOnly = True
        '
        'ProjectIDColumn
        '
        Me.ProjectIDColumn.HeaderText = "ProjectID"
        Me.ProjectIDColumn.Name = "ProjectIDColumn"
        Me.ProjectIDColumn.ReadOnly = True
        Me.ProjectIDColumn.Visible = False
        '
        'TaskIDColumn
        '
        Me.TaskIDColumn.HeaderText = "TaskID"
        Me.TaskIDColumn.Name = "TaskIDColumn"
        Me.TaskIDColumn.ReadOnly = True
        Me.TaskIDColumn.Visible = False
        '
        'TimeEntryIDColumn
        '
        Me.TimeEntryIDColumn.HeaderText = "TimeEntryID"
        Me.TimeEntryIDColumn.Name = "TimeEntryIDColumn"
        Me.TimeEntryIDColumn.ReadOnly = True
        Me.TimeEntryIDColumn.Visible = False
        '
        'DailyTotalGroupBox
        '
        Me.DailyTotalGroupBox.Controls.Add(Me.TotalLabel)
        Me.DailyTotalGroupBox.Controls.Add(Me.TotalTextBox)
        Me.DailyTotalGroupBox.Location = New System.Drawing.Point(12, 247)
        Me.DailyTotalGroupBox.Name = "DailyTotalGroupBox"
        Me.DailyTotalGroupBox.Size = New System.Drawing.Size(447, 48)
        Me.DailyTotalGroupBox.TabIndex = 4
        Me.DailyTotalGroupBox.TabStop = False
        Me.DailyTotalGroupBox.Text = "Totals for day"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(354, 19)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 5
        Me.TotalLabel.Text = "Total"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(391, 16)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(50, 20)
        Me.TotalTextBox.TabIndex = 4
        '
        'TaskGroupBox
        '
        Me.TaskGroupBox.Controls.Add(Me.TaskTextBox)
        Me.TaskGroupBox.Location = New System.Drawing.Point(466, 247)
        Me.TaskGroupBox.Name = "TaskGroupBox"
        Me.TaskGroupBox.Size = New System.Drawing.Size(93, 48)
        Me.TaskGroupBox.TabIndex = 5
        Me.TaskGroupBox.TabStop = False
        Me.TaskGroupBox.Text = "Task"
        '
        'TaskTextBox
        '
        Me.TaskTextBox.Location = New System.Drawing.Point(25, 16)
        Me.TaskTextBox.Name = "TaskTextBox"
        Me.TaskTextBox.ReadOnly = True
        Me.TaskTextBox.Size = New System.Drawing.Size(46, 20)
        Me.TaskTextBox.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(466, 298)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DeleteTimeEntryButton
        '
        Me.DeleteTimeEntryButton.Location = New System.Drawing.Point(385, 298)
        Me.DeleteTimeEntryButton.Name = "DeleteTimeEntryButton"
        Me.DeleteTimeEntryButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteTimeEntryButton.TabIndex = 7
        Me.DeleteTimeEntryButton.Text = "Delete"
        Me.DeleteTimeEntryButton.UseVisualStyleBackColor = True
        '
        'CopyTimeEntryButton
        '
        Me.CopyTimeEntryButton.Location = New System.Drawing.Point(304, 298)
        Me.CopyTimeEntryButton.Name = "CopyTimeEntryButton"
        Me.CopyTimeEntryButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyTimeEntryButton.TabIndex = 8
        Me.CopyTimeEntryButton.Text = "Copy..."
        Me.CopyTimeEntryButton.UseVisualStyleBackColor = True
        '
        'InsertTimeEntryButton
        '
        Me.InsertTimeEntryButton.Location = New System.Drawing.Point(223, 298)
        Me.InsertTimeEntryButton.Name = "InsertTimeEntryButton"
        Me.InsertTimeEntryButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertTimeEntryButton.TabIndex = 9
        Me.InsertTimeEntryButton.Text = "Insert..."
        Me.InsertTimeEntryButton.UseVisualStyleBackColor = True
        '
        'EditTimeEntryButton
        '
        Me.EditTimeEntryButton.Location = New System.Drawing.Point(142, 298)
        Me.EditTimeEntryButton.Name = "EditTimeEntryButton"
        Me.EditTimeEntryButton.Size = New System.Drawing.Size(75, 23)
        Me.EditTimeEntryButton.TabIndex = 10
        Me.EditTimeEntryButton.Text = "Edit..."
        Me.EditTimeEntryButton.UseVisualStyleBackColor = True
        '
        'NewTimeEntryButton
        '
        Me.NewTimeEntryButton.Location = New System.Drawing.Point(61, 298)
        Me.NewTimeEntryButton.Name = "NewTimeEntryButton"
        Me.NewTimeEntryButton.Size = New System.Drawing.Size(75, 23)
        Me.NewTimeEntryButton.TabIndex = 11
        Me.NewTimeEntryButton.Text = "New..."
        Me.NewTimeEntryButton.UseVisualStyleBackColor = True
        '
        'EditTimesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 333)
        Me.Controls.Add(Me.NewTimeEntryButton)
        Me.Controls.Add(Me.EditTimeEntryButton)
        Me.Controls.Add(Me.InsertTimeEntryButton)
        Me.Controls.Add(Me.CopyTimeEntryButton)
        Me.Controls.Add(Me.DeleteTimeEntryButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TaskGroupBox)
        Me.Controls.Add(Me.DailyTotalGroupBox)
        Me.Controls.Add(Me.DailyTimesGridView)
        Me.Controls.Add(Me.NewDateButton)
        Me.Controls.Add(Me.DateComboBox)
        Me.Controls.Add(Me.TimesForLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditTimesForm"
        Me.Text = "EditTimesForm"
        CType(Me.DailyTimesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DailyTotalGroupBox.ResumeLayout(False)
        Me.DailyTotalGroupBox.PerformLayout()
        Me.TaskGroupBox.ResumeLayout(False)
        Me.TaskGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimesForLabel As System.Windows.Forms.Label
    Friend WithEvents DateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NewDateButton As System.Windows.Forms.Button
    Friend WithEvents DailyTimesGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DailyTotalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TaskGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartTimeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndTimeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectNameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskNameColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaskIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeEntryIDColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents DeleteTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents CopyTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents InsertTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents EditTimeEntryButton As System.Windows.Forms.Button
    Friend WithEvents NewTimeEntryButton As System.Windows.Forms.Button
End Class
