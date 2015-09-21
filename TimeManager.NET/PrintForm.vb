Imports System.Drawing.Printing

Public Class PrintForm

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        Select Case True
            Case PrintProjectTimeRadioButton.Checked

            Case PrintTimesheetRadioButton.Checked
                TimesheetReportForm.Show()
        End Select

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

    Private Sub PrintForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim datesDataTable As DataTable
        Dim fromDateDataTable As DataTable
        Dim toDateDataTable As DataTable
        Dim monthDataTable As DataTable

        datesDataTable = TimeRecorder.Instance.ListTimeEntryDates

        fromDateDataTable = datesDataTable.Copy
        toDateDataTable = datesDataTable.Copy

        With DateRangeFromComboBox
            .DataSource = fromDateDataTable
            .DisplayMember = "Date"
            .ValueMember = "Date"
            .SelectedIndex = -1
        End With

        With DateRangeToComboBox
            .DataSource = toDateDataTable
            .DisplayMember = "Date"
            .ValueMember = "Date"
            .SelectedIndex = -1
        End With

        datesDataTable = Nothing

        monthDataTable = TimeRecorder.Instance.listTimeEntryMonths

        With MonthComboBox
            .DataSource = monthDataTable
            .DisplayMember = "Month"
            .ValueMember = "Month"
            .SelectedIndex = -1
        End With

        monthDataTable = Nothing

    End Sub

    Private Sub MonthComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonthComboBox.GotFocus

        MonthRadioButton.Checked = True

    End Sub

    Private Sub DateRangeFromComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateRangeFromComboBox.GotFocus

        RangeRadioButton.Checked = True

    End Sub

    Private Sub DateRangeToComboBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateRangeToComboBox.GotFocus

        RangeRadioButton.Checked = True

    End Sub
End Class