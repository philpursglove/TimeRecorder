Public Class TimesheetReportForm

    Private Sub TimesheetReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub
End Class