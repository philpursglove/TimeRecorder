<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProjectForm
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
        Me.OldProjectNameLabel = New System.Windows.Forms.Label
        Me.NewProjectNameLabel = New System.Windows.Forms.Label
        Me.ProjectCodeLabel = New System.Windows.Forms.Label
        Me.OldProjectNameTextBox = New System.Windows.Forms.TextBox
        Me.NewProjectNameTextBox = New System.Windows.Forms.TextBox
        Me.ProjectCodeTextBox = New System.Windows.Forms.TextBox
        Me.OKButton = New System.Windows.Forms.Button
        Me.CancelButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OldProjectNameLabel
        '
        Me.OldProjectNameLabel.AutoSize = True
        Me.OldProjectNameLabel.Location = New System.Drawing.Point(13, 9)
        Me.OldProjectNameLabel.Name = "OldProjectNameLabel"
        Me.OldProjectNameLabel.Size = New System.Drawing.Size(54, 13)
        Me.OldProjectNameLabel.TabIndex = 0
        Me.OldProjectNameLabel.Text = "Old Name"
        '
        'NewProjectNameLabel
        '
        Me.NewProjectNameLabel.AutoSize = True
        Me.NewProjectNameLabel.Location = New System.Drawing.Point(13, 35)
        Me.NewProjectNameLabel.Name = "NewProjectNameLabel"
        Me.NewProjectNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.NewProjectNameLabel.TabIndex = 1
        Me.NewProjectNameLabel.Text = "New Name"
        '
        'ProjectCodeLabel
        '
        Me.ProjectCodeLabel.AutoSize = True
        Me.ProjectCodeLabel.Location = New System.Drawing.Point(13, 63)
        Me.ProjectCodeLabel.Name = "ProjectCodeLabel"
        Me.ProjectCodeLabel.Size = New System.Drawing.Size(68, 13)
        Me.ProjectCodeLabel.TabIndex = 2
        Me.ProjectCodeLabel.Text = "Project Code"
        '
        'OldProjectNameTextBox
        '
        Me.OldProjectNameTextBox.Location = New System.Drawing.Point(99, 6)
        Me.OldProjectNameTextBox.Name = "OldProjectNameTextBox"
        Me.OldProjectNameTextBox.ReadOnly = True
        Me.OldProjectNameTextBox.Size = New System.Drawing.Size(282, 20)
        Me.OldProjectNameTextBox.TabIndex = 3
        Me.OldProjectNameTextBox.TabStop = False
        '
        'NewProjectNameTextBox
        '
        Me.NewProjectNameTextBox.Location = New System.Drawing.Point(99, 32)
        Me.NewProjectNameTextBox.Name = "NewProjectNameTextBox"
        Me.NewProjectNameTextBox.Size = New System.Drawing.Size(282, 20)
        Me.NewProjectNameTextBox.TabIndex = 4
        '
        'ProjectCodeTextBox
        '
        Me.ProjectCodeTextBox.Location = New System.Drawing.Point(99, 60)
        Me.ProjectCodeTextBox.Name = "ProjectCodeTextBox"
        Me.ProjectCodeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.ProjectCodeTextBox.TabIndex = 5
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.Location = New System.Drawing.Point(262, 58)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(56, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(324, 58)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(57, 23)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'EditProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(393, 92)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ProjectCodeTextBox)
        Me.Controls.Add(Me.NewProjectNameTextBox)
        Me.Controls.Add(Me.OldProjectNameTextBox)
        Me.Controls.Add(Me.ProjectCodeLabel)
        Me.Controls.Add(Me.NewProjectNameLabel)
        Me.Controls.Add(Me.OldProjectNameLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditProjectForm"
        Me.Text = "EditProjectForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OldProjectNameLabel As System.Windows.Forms.Label
    Friend WithEvents NewProjectNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectCodeLabel As System.Windows.Forms.Label
    Friend WithEvents OldProjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewProjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
End Class
