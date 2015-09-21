Public Class EditTimesForm

    Private mSelectedTimeEntryId As Guid

    Public Property SelectedTimeEntryId() As Guid
        Get
            Return mSelectedTimeEntryID
        End Get
        Set(ByVal value As Guid)
            mSelectedTimeEntryID = value
        End Set
    End Property

    Private Sub EditTimesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim timeEntryDateDataTable As DataTable
        Dim timeEntryDateDataRow As DataRow
        Dim timeEntryDateSortedList As SortedList
        Dim timeEntryDate As Date
        Dim listEntry As DictionaryEntry

        timeEntryDateDataTable = TimeRecorder.Instance.ListTimeEntryDates

        timeEntryDateSortedList = New SortedList

        For Each timeEntryDateDataRow In timeEntryDateDataTable.Rows
            timeEntryDate = Date.Parse(timeEntryDateDataRow.Item("Date").ToString)

            timeEntryDateSortedList.Add(timeEntryDate, timeEntryDate)
        Next

        DateComboBox.Items.Clear()

        For Each listEntry In timeEntryDateSortedList
            timeEntryDate = DirectCast(listEntry.Value, Date)

            DateComboBox.Items.Add(timeEntryDate.ToString("dddd, dd MMMM yyyy"))
        Next

    End Sub

    Private Sub NewDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDateButton.Click

        Dim dateList As SortedList
        Dim entryDateString As String
        Dim newDate As Date

        If NewDateForm.ShowDialog() = Windows.Forms.DialogResult.OK Then

            dateList = New SortedList

            For Each entryDateString In DateComboBox.Items
                dateList.Add(key:=Date.Parse(entryDateString), value:=entryDateString)
            Next

            newDate = NewDateForm.NewDateMonthCalendar.SelectionStart

            If dateList.ContainsKey(newDate) Then
            Else
                dateList.Add(key:=newDate, value:=newDate.ToString("dddd, dd MMMM yyyy"))
            End If

            DateComboBox.Items.Clear()

            For Each newDate In dateList.GetValueList
                DateComboBox.Items.Add(newDate.ToString("dddd, dd MMMM yyyy"))
            Next

            newDate = NewDateForm.NewDateMonthCalendar.SelectionStart

            DateComboBox.SelectedIndex = DateComboBox.FindString(newDate.ToString("dddd, dd MMMM yyyy"))
        Else

        End If

    End Sub

    Private Sub DateComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateComboBox.SelectedIndexChanged

        If DateComboBox.SelectedItem Is String.Empty Then
        Else
            Call loadTimeEntryForDate(selectedDate:=Date.Parse(DateComboBox.SelectedItem.ToString))
        End If

    End Sub

    Private Sub DailyTimesGridView_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DailyTimesGridView.CellMouseClick

        If e.RowIndex >= 0 Then
            Me.SelectedTimeEntryId = DirectCast(DailyTimesGridView.Rows(e.RowIndex).Cells("TimeEntryIDColumn").Value, Guid)
        End If

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

    Private Sub NewTimeEntryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTimeEntryButton.Click

        Me.SelectedTimeEntryID = Nothing

        With EditTimeForm
            .ProjectComboBox.SelectedIndex = -1
            .TaskComboBox.SelectedIndex = -1
            .StartTimeTextBox.Text = String.Empty
            .EndTimeTextBox.Text = String.Empty
            .TaskTimeTextBox.Text = String.Empty
            .ShowDialog()
        End With

        If EditTimeForm.DialogResult = Windows.Forms.DialogResult.OK Then
            Call TimeRecorder.Instance.addTimeEntry(projectId:=New Guid(DirectCast(EditTimeForm.TaskComboBox.SelectedItem, DataRow).Item("TaskID").ToString), _
                                          startTime:=DateTime.Parse(Me.DateComboBox.Text & " " & EditTimeForm.StartTimeTextBox.Text), _
                                          endTime:=DateTime.Parse(Me.DateComboBox.Text & " " & EditTimeForm.EndTimeTextBox.Text))

            Call Me.loadTimeEntryForDate(Date.Parse(DateComboBox.Text))
        End If

    End Sub

    Private Sub loadTimeEntryForDate(ByVal selectedDate As Date)

        Dim timeEntryDataTable As DataTable
        Dim startTime As DateTime
        Dim endTime As DateTime

        startTime = Date.Parse(selectedDate.ToString("dd/MM/yyyy ") & "00:00")
        endTime = Date.Parse(selectedDate.ToString("dd/MM/yyyy ") & "23:59")

        timeEntryDataTable = TimeRecorder.Instance.listTimeEntries(startTime, endTime)

        With DailyTimesGridView
            .AutoGenerateColumns = False
            .DataSource = timeEntryDataTable
            .Columns("StartTimeColumn").DataPropertyName = "StartTime"
            .Columns("StartTimeColumn").ValueType = GetType(DateTime)
            .Columns("EndTimeColumn").DataPropertyName = "EndTime"
            .Columns("EndTimeColumn").ValueType = GetType(DateTime)
            .Columns("TaskNameColumn").DataPropertyName = "TaskDescription"
            .Columns("ProjectNameColumn").DataPropertyName = "ProjectName"
            .Columns("TaskIDColumn").DataPropertyName = "TaskID"
            .Columns("TaskIDColumn").ValueType = GetType(System.Guid)
            .Columns("ProjectIDColumn").DataPropertyName = "ProjectID"
            .Columns("ProjectIDColumn").ValueType = GetType(System.Guid)
            .Columns("TimeEntryIDColumn").DataPropertyName = "TimeEntryID"
            .Columns("TimeEntryIDColumn").ValueType = GetType(System.Guid)
        End With

    End Sub

    Private Sub EditTimeEntryButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditTimeEntryButton.Click

        EditTimeForm.ShowDialog()

        EditTimeForm = Nothing

    End Sub

    Private Sub DailyTimesGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DailyTimesGridView.CellMouseDoubleClick

        Call EditTimeEntryButton_Click(sender, e)

    End Sub
End Class