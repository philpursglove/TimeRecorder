<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProjectForm
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
        Me.ProjectNameLabel = New System.Windows.Forms.Label()
        Me.ProjectCodeLabel = New System.Windows.Forms.Label()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProjectNameLabel
        '
        Me.ProjectNameLabel.AutoSize = True
        Me.ProjectNameLabel.Location = New System.Drawing.Point(12, 9)
        Me.ProjectNameLabel.Name = "ProjectNameLabel"
        Me.ProjectNameLabel.Size = New System.Drawing.Size(71, 13)
        Me.ProjectNameLabel.TabIndex = 0
        Me.ProjectNameLabel.Text = "Project Name"
        '
        'ProjectCodeLabel
        '
        Me.ProjectCodeLabel.AutoSize = True
        Me.ProjectCodeLabel.Location = New System.Drawing.Point(12, 37)
        Me.ProjectCodeLabel.Name = "ProjectCodeLabel"
        Me.ProjectCodeLabel.Size = New System.Drawing.Size(68, 13)
        Me.ProjectCodeLabel.TabIndex = 1
        Me.ProjectCodeLabel.Text = "Project Code"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(89, 6)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(280, 20)
        Me.ProjectNameTextBox.TabIndex = 2
        '
        'ProjectCodeTextBox
        '
        Me.ProjectCodeTextBox.Location = New System.Drawing.Point(89, 34)
        Me.ProjectCodeTextBox.Name = "ProjectCodeTextBox"
        Me.ProjectCodeTextBox.Size = New System.Drawing.Size(133, 20)
        Me.ProjectCodeTextBox.TabIndex = 3
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(312, 32)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(57, 23)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.Location = New System.Drawing.Point(250, 33)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(56, 23)
        Me.OKButton.TabIndex = 5
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'AddProjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 63)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ProjectCodeTextBox)
        Me.Controls.Add(Me.ProjectNameTextBox)
        Me.Controls.Add(Me.ProjectCodeLabel)
        Me.Controls.Add(Me.ProjectNameLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProjectForm"
        Me.Text = "AddProjectForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectCodeLabel As System.Windows.Forms.Label
    Friend WithEvents ProjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectCodeTextBox As System.Windows.Forms.TextBox
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
