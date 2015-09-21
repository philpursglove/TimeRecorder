<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDateForm
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
        Me.NewDateMonthCalendar = New System.Windows.Forms.MonthCalendar
        Me.CancelButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NewDateMonthCalendar
        '
        Me.NewDateMonthCalendar.Location = New System.Drawing.Point(12, 14)
        Me.NewDateMonthCalendar.Name = "NewDateMonthCalendar"
        Me.NewDateMonthCalendar.TabIndex = 0
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(133, 181)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(57, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(72, 181)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(55, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'NewDateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 212)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.NewDateMonthCalendar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewDateForm"
        Me.Text = "NewDateForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewDateMonthCalendar As System.Windows.Forms.MonthCalendar
    Friend Shadows WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
