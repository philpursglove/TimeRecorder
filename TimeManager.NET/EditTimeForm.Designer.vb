<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTimeForm
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
        Me.ProjectLabel = New System.Windows.Forms.Label
        Me.TaskLabel = New System.Windows.Forms.Label
        Me.StartTimeLabel = New System.Windows.Forms.Label
        Me.ProjectComboBox = New System.Windows.Forms.ComboBox
        Me.TaskComboBox = New System.Windows.Forms.ComboBox
        Me.StartTimeTextBox = New System.Windows.Forms.TextBox
        Me.EndTimeLabel = New System.Windows.Forms.Label
        Me.EndTimeTextBox = New System.Windows.Forms.TextBox
        Me.TaskTimeLabel = New System.Windows.Forms.Label
        Me.TaskTimeTextBox = New System.Windows.Forms.TextBox
        Me.CancelButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ProjectLabel
        '
        Me.ProjectLabel.AutoSize = True
        Me.ProjectLabel.Location = New System.Drawing.Point(13, 13)
        Me.ProjectLabel.Name = "ProjectLabel"
        Me.ProjectLabel.Size = New System.Drawing.Size(40, 13)
        Me.ProjectLabel.TabIndex = 0
        Me.ProjectLabel.Text = "Project"
        '
        'TaskLabel
        '
        Me.TaskLabel.AutoSize = True
        Me.TaskLabel.Location = New System.Drawing.Point(13, 42)
        Me.TaskLabel.Name = "TaskLabel"
        Me.TaskLabel.Size = New System.Drawing.Size(31, 13)
        Me.TaskLabel.TabIndex = 1
        Me.TaskLabel.Text = "Task"
        '
        'StartTimeLabel
        '
        Me.StartTimeLabel.AutoSize = True
        Me.StartTimeLabel.Location = New System.Drawing.Point(16, 97)
        Me.StartTimeLabel.Name = "StartTimeLabel"
        Me.StartTimeLabel.Size = New System.Drawing.Size(55, 13)
        Me.StartTimeLabel.TabIndex = 2
        Me.StartTimeLabel.Text = "Start Time"
        '
        'ProjectComboBox
        '
        Me.ProjectComboBox.FormattingEnabled = True
        Me.ProjectComboBox.Location = New System.Drawing.Point(81, 10)
        Me.ProjectComboBox.Name = "ProjectComboBox"
        Me.ProjectComboBox.Size = New System.Drawing.Size(355, 21)
        Me.ProjectComboBox.TabIndex = 3
        '
        'TaskComboBox
        '
        Me.TaskComboBox.FormattingEnabled = True
        Me.TaskComboBox.Location = New System.Drawing.Point(81, 39)
        Me.TaskComboBox.Name = "TaskComboBox"
        Me.TaskComboBox.Size = New System.Drawing.Size(355, 21)
        Me.TaskComboBox.TabIndex = 4
        '
        'StartTimeTextBox
        '
        Me.StartTimeTextBox.Location = New System.Drawing.Point(81, 94)
        Me.StartTimeTextBox.Name = "StartTimeTextBox"
        Me.StartTimeTextBox.Size = New System.Drawing.Size(48, 20)
        Me.StartTimeTextBox.TabIndex = 5
        '
        'EndTimeLabel
        '
        Me.EndTimeLabel.AutoSize = True
        Me.EndTimeLabel.Location = New System.Drawing.Point(167, 97)
        Me.EndTimeLabel.Name = "EndTimeLabel"
        Me.EndTimeLabel.Size = New System.Drawing.Size(52, 13)
        Me.EndTimeLabel.TabIndex = 6
        Me.EndTimeLabel.Text = "End Time"
        '
        'EndTimeTextBox
        '
        Me.EndTimeTextBox.Location = New System.Drawing.Point(225, 94)
        Me.EndTimeTextBox.Name = "EndTimeTextBox"
        Me.EndTimeTextBox.Size = New System.Drawing.Size(53, 20)
        Me.EndTimeTextBox.TabIndex = 7
        '
        'TaskTimeLabel
        '
        Me.TaskTimeLabel.AutoSize = True
        Me.TaskTimeLabel.Location = New System.Drawing.Point(326, 97)
        Me.TaskTimeLabel.Name = "TaskTimeLabel"
        Me.TaskTimeLabel.Size = New System.Drawing.Size(57, 13)
        Me.TaskTimeLabel.TabIndex = 8
        Me.TaskTimeLabel.Text = "Task Time"
        '
        'TaskTimeTextBox
        '
        Me.TaskTimeTextBox.Location = New System.Drawing.Point(390, 94)
        Me.TaskTimeTextBox.Name = "TaskTimeTextBox"
        Me.TaskTimeTextBox.ReadOnly = True
        Me.TaskTimeTextBox.Size = New System.Drawing.Size(46, 20)
        Me.TaskTimeTextBox.TabIndex = 9
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(375, 121)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(60, 23)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(315, 121)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(54, 23)
        Me.OKButton.TabIndex = 12
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'EditTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 152)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TaskTimeTextBox)
        Me.Controls.Add(Me.TaskTimeLabel)
        Me.Controls.Add(Me.EndTimeTextBox)
        Me.Controls.Add(Me.EndTimeLabel)
        Me.Controls.Add(Me.StartTimeTextBox)
        Me.Controls.Add(Me.TaskComboBox)
        Me.Controls.Add(Me.ProjectComboBox)
        Me.Controls.Add(Me.StartTimeLabel)
        Me.Controls.Add(Me.TaskLabel)
        Me.Controls.Add(Me.ProjectLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditTimeForm"
        Me.Text = "EditTimeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectLabel As System.Windows.Forms.Label
    Friend WithEvents TaskLabel As System.Windows.Forms.Label
    Friend WithEvents StartTimeLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TaskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StartTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndTimeLabel As System.Windows.Forms.Label
    Friend WithEvents EndTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaskTimeLabel As System.Windows.Forms.Label
    Friend WithEvents TaskTimeTextBox As System.Windows.Forms.TextBox
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
