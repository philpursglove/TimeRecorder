<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimesheetReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.CloseButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WSP.TimeRecorder.Application.Timesheet.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(334, 250)
        Me.ReportViewer1.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(271, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TimesheetReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 301)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TimesheetReportForm"
        Me.Text = "TimesheetReportForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
