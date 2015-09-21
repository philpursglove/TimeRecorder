<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintForm))
        Me.MonthRadioButton = New System.Windows.Forms.RadioButton
        Me.MonthComboBox = New System.Windows.Forms.ComboBox
        Me.RangeRadioButton = New System.Windows.Forms.RadioButton
        Me.RangeFromLabel = New System.Windows.Forms.Label
        Me.RangeToLabel = New System.Windows.Forms.Label
        Me.DateRangeFromComboBox = New System.Windows.Forms.ComboBox
        Me.DateRangeToComboBox = New System.Windows.Forms.ComboBox
        Me.DestinationGroupBox = New System.Windows.Forms.GroupBox
        Me.PrintProjectTimeRadioButton = New System.Windows.Forms.RadioButton
        Me.PrintTimesheetRadioButton = New System.Windows.Forms.RadioButton
        Me.CloseButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.DestinationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthRadioButton
        '
        Me.MonthRadioButton.AutoSize = True
        Me.MonthRadioButton.Location = New System.Drawing.Point(15, 14)
        Me.MonthRadioButton.Name = "MonthRadioButton"
        Me.MonthRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.MonthRadioButton.TabIndex = 0
        Me.MonthRadioButton.TabStop = True
        Me.MonthRadioButton.Text = "Month"
        Me.MonthRadioButton.UseVisualStyleBackColor = True
        '
        'MonthComboBox
        '
        Me.MonthComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MonthComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Location = New System.Drawing.Point(76, 13)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(158, 21)
        Me.MonthComboBox.TabIndex = 1
        '
        'RangeRadioButton
        '
        Me.RangeRadioButton.AutoSize = True
        Me.RangeRadioButton.Location = New System.Drawing.Point(13, 42)
        Me.RangeRadioButton.Name = "RangeRadioButton"
        Me.RangeRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.RangeRadioButton.TabIndex = 2
        Me.RangeRadioButton.TabStop = True
        Me.RangeRadioButton.Text = "Range"
        Me.RangeRadioButton.UseVisualStyleBackColor = True
        '
        'RangeFromLabel
        '
        Me.RangeFromLabel.AutoSize = True
        Me.RangeFromLabel.Location = New System.Drawing.Point(76, 44)
        Me.RangeFromLabel.Name = "RangeFromLabel"
        Me.RangeFromLabel.Size = New System.Drawing.Size(30, 13)
        Me.RangeFromLabel.TabIndex = 3
        Me.RangeFromLabel.Text = "From"
        '
        'RangeToLabel
        '
        Me.RangeToLabel.AutoSize = True
        Me.RangeToLabel.Location = New System.Drawing.Point(76, 72)
        Me.RangeToLabel.Name = "RangeToLabel"
        Me.RangeToLabel.Size = New System.Drawing.Size(20, 13)
        Me.RangeToLabel.TabIndex = 4
        Me.RangeToLabel.Text = "To"
        '
        'DateRangeFromComboBox
        '
        Me.DateRangeFromComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DateRangeFromComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DateRangeFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateRangeFromComboBox.FormattingEnabled = True
        Me.DateRangeFromComboBox.Location = New System.Drawing.Point(113, 41)
        Me.DateRangeFromComboBox.Name = "DateRangeFromComboBox"
        Me.DateRangeFromComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DateRangeFromComboBox.TabIndex = 5
        '
        'DateRangeToComboBox
        '
        Me.DateRangeToComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DateRangeToComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DateRangeToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateRangeToComboBox.FormattingEnabled = True
        Me.DateRangeToComboBox.Location = New System.Drawing.Point(113, 69)
        Me.DateRangeToComboBox.Name = "DateRangeToComboBox"
        Me.DateRangeToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DateRangeToComboBox.TabIndex = 6
        '
        'DestinationGroupBox
        '
        Me.DestinationGroupBox.Controls.Add(Me.PrintProjectTimeRadioButton)
        Me.DestinationGroupBox.Controls.Add(Me.PrintTimesheetRadioButton)
        Me.DestinationGroupBox.ForeColor = System.Drawing.Color.Black
        Me.DestinationGroupBox.Location = New System.Drawing.Point(16, 102)
        Me.DestinationGroupBox.Name = "DestinationGroupBox"
        Me.DestinationGroupBox.Size = New System.Drawing.Size(122, 70)
        Me.DestinationGroupBox.TabIndex = 9
        Me.DestinationGroupBox.TabStop = False
        Me.DestinationGroupBox.Text = "Print"
        '
        'PrintProjectTimeRadioButton
        '
        Me.PrintProjectTimeRadioButton.AutoSize = True
        Me.PrintProjectTimeRadioButton.Location = New System.Drawing.Point(7, 44)
        Me.PrintProjectTimeRadioButton.Name = "PrintProjectTimeRadioButton"
        Me.PrintProjectTimeRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.PrintProjectTimeRadioButton.TabIndex = 1
        Me.PrintProjectTimeRadioButton.TabStop = True
        Me.PrintProjectTimeRadioButton.Text = "Project Time"
        Me.PrintProjectTimeRadioButton.UseVisualStyleBackColor = True
        '
        'PrintTimesheetRadioButton
        '
        Me.PrintTimesheetRadioButton.AutoSize = True
        Me.PrintTimesheetRadioButton.Checked = True
        Me.PrintTimesheetRadioButton.Location = New System.Drawing.Point(7, 20)
        Me.PrintTimesheetRadioButton.Name = "PrintTimesheetRadioButton"
        Me.PrintTimesheetRadioButton.Size = New System.Drawing.Size(74, 17)
        Me.PrintTimesheetRadioButton.TabIndex = 0
        Me.PrintTimesheetRadioButton.TabStop = True
        Me.PrintTimesheetRadioButton.Text = "Timesheet"
        Me.PrintTimesheetRadioButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(159, 151)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 10
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(159, 122)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(245, 184)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DestinationGroupBox)
        Me.Controls.Add(Me.DateRangeToComboBox)
        Me.Controls.Add(Me.DateRangeFromComboBox)
        Me.Controls.Add(Me.RangeToLabel)
        Me.Controls.Add(Me.RangeFromLabel)
        Me.Controls.Add(Me.RangeRadioButton)
        Me.Controls.Add(Me.MonthComboBox)
        Me.Controls.Add(Me.MonthRadioButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintForm"
        Me.Text = "PrintForm"
        Me.DestinationGroupBox.ResumeLayout(False)
        Me.DestinationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RangeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RangeFromLabel As System.Windows.Forms.Label
    Friend WithEvents RangeToLabel As System.Windows.Forms.Label
    Friend WithEvents DateRangeFromComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateRangeToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DestinationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PrintProjectTimeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PrintTimesheetRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class
