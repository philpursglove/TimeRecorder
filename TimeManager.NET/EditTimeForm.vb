Public Class EditTimeForm

    Private Sub EditTimeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim selectedTaskDataRow As DataRow
        Dim projectEntry As Object
        Dim taskEntry As Object
        Dim elapsedTimeForProject As TimeSpan
        Dim projectEntryDataRow As DataRow
        Dim taskEntryDataRow As DataRow

        Try
            Call Me.loadProjects()

            If My.Forms.EditTimesForm.SelectedTimeEntryId = Nothing Then
            Else
                selectedTaskDataRow = TimeRecorder.Instance.getTimeEntry(timeEntryID:=EditTimesForm.SelectedTimeEntryId)

                With selectedTaskDataRow
                    StartTimeTextBox.Text = DateTime.Parse(.Item("StartTime").ToString).ToString("hh:mm")
                    EndTimeTextBox.Text = DateTime.Parse(.Item("EndTime").ToString).ToString("hh:mm")

                    elapsedTimeForProject = Me.calculateElapsedTimeForProject

                    TaskTimeTextBox.Text = elapsedTimeForProject.Hours.ToString("00") & ":" & (elapsedTimeForProject.Minutes Mod 60).ToString("00")

                    For Each projectEntry In ProjectComboBox.Items
                        projectEntryDataRow = DirectCast(projectEntry, DataRowView).Row

                        If DirectCast(projectEntryDataRow.Item(0), Guid) = DirectCast(.Item("ProjectID"), Guid) Then
                            ProjectComboBox.SelectedIndex = ProjectComboBox.FindString(projectEntryDataRow.Item(1).ToString)

                            Exit For
                        End If
                    Next

                    For Each taskEntry In TaskComboBox.Items
                        taskEntryDataRow = DirectCast(taskEntry, DataRowView).Row

                        If DirectCast(taskEntryDataRow.Item(0), Guid) = DirectCast(.Item("TaskID"), Guid) Then
                            TaskComboBox.SelectedIndex = TaskComboBox.FindString(taskEntryDataRow.Item(1).ToString)

                            Exit For
                        End If
                    Next

                End With
            End If
        Catch ex As Exception
            Throw
        Finally

        End Try

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Hide()

    End Sub

    Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        Me.Hide()

    End Sub

    Private Sub loadProjects()

        Dim projects As List(Of Project)

        projects = TimeRecorder.Instance.listProjects

        With ProjectComboBox
            .Items.Clear()
            .DataSource = projects
            .ValueMember = "ProjectID"
            .DisplayMember = "ProjectName"
        End With

    End Sub

   

    

    Private Function calculateElapsedTimeForProject() As TimeSpan

        Return DateTime.Parse(EndTimeTextBox.Text, System.Globalization.CultureInfo.InvariantCulture) - DateTime.Parse(StartTimeTextBox.Text, System.Globalization.CultureInfo.InvariantCulture)

    End Function
End Class