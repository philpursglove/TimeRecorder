Public Class MainForm

    Private mCurrentProjectStartTime As DateTime
    Private mCurrentProjectID As Guid
    Private mCurrentTimeEntryID As Guid

    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click

        If Me.AlwaysOnTopToolStripMenuItem.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

        My.Settings.AlwaysOnTop = AlwaysOnTopToolStripMenuItem.Checked

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.DateTextBox.Text = Date.Today.ToString("dddd, dd MMMM yyyy")
        Me.TimeTextBox.Text = Date.Now.ToString("HH:mm")

        If Me.mCurrentProjectID = Nothing Then
        Else
            Me.ElapsedTimeTextBox.Text = DateTime.Now.Subtract(mCurrentProjectStartTime).ToString
        End If

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.mCurrentProjectID = Nothing Then
        Else
            Call Me.StopCurrentProject()
        End If

        Me.NotifyIcon1.Visible = False
        Me.NotifyIcon1 = Nothing

    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.DateTextBox.Text = Date.Today.ToString("dddd, dd MMMM yyyy")
        Me.TimeTextBox.Text = Date.Now.ToString("HH:mm")

        Call LoadRecentProjects()

        Me.NotifyIcon1.Visible = True
        Me.NotifyIcon1.Icon = Me.Icon

        AlwaysOnTopToolStripMenuItem.Checked = My.Settings.AlwaysOnTop
        Me.TopMost = AlwaysOnTopToolStripMenuItem.Checked

        MinimiseOnSelectionToolStripMenuItem.Checked = My.Settings.MinimiseOnSelection

    End Sub

    Private Sub TasksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectsToolStripMenuItem.Click


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        If Me.Visible = False Then
            Me.Show()
        Else
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            End If
        End If

    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSetupToolStripMenuItem.Click

        PrintDialog1.ShowDialog()

    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProjectToolStripMenuItem.Click

        AddProjectForm.ShowDialog()

        Dim newProject As Project = New Project
        newProject.ProjectCode = AddProjectForm.ProjectCodeTextBox.Text
        newProject.ProjectName = AddProjectForm.ProjectNameTextBox.Text

        TimeRecorder.Instance.addProject(newProject)
    End Sub

    Private Sub StopCurrentProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopCurrentProjectToolStripMenuItem.Click

        Call StopCurrentProject()

    End Sub

    Private Sub StopCurrentProject()

        If mCurrentTimeEntryID = Nothing Then
        Else
            Call TimeRecorder.Instance.editTimeEntry(mCurrentTimeEntryID, mCurrentProjectStartTime, DateTime.Now)

            mCurrentTimeEntryID = Nothing
            mCurrentProjectID = Nothing
            mCurrentProjectStartTime = Nothing

            Me.ProjectCodeTextBox.Text = String.Empty
            Me.ProjectNameTextBox.Text = String.Empty
            Me.ProjectStartedAtTextBox.Text = String.Empty
            Me.ElapsedTimeTextBox.Text = String.Empty

            StopCurrentProjectToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        PrintForm.ShowDialog()

    End Sub

    Private Sub LoadRecentProjects()

        Dim recentProjects As List(Of Project)
        Dim recentProjectMenuItem As ToolStripMenuItem
        Dim itemText As String

        recentProjects = TimeRecorder.Instance.listRecentProjects

        For Each recentProject As Project In recentProjects
            recentProjectMenuItem = New ToolStripMenuItem

            itemText = String.Format("{0} - {1}", recentProject.ProjectCode, recentProject.ProjectName)

            recentProjectMenuItem.Text = itemText
            recentProjectMenuItem.Tag = recentProject.ProjectId

            AddHandler recentProjectMenuItem.Click, AddressOf loadRecentProject

            QuickToolStripMenuItem.DropDownItems.Insert(0, recentProjectMenuItem)
        Next

    End Sub

    Private Sub loadRecentProject(ByVal sender As Object, ByVal e As EventArgs)

        Dim recentProject As Project

        mCurrentProjectID = New Guid(CType(sender, ToolStripMenuItem).Tag.ToString)

        recentProject = TimeRecorder.Instance.getProject(mCurrentProjectID)

        mCurrentProjectStartTime = Now

        ProjectStartedAtTextBox.Text = mCurrentProjectStartTime.ToString("HH:mm")

        Me.ProjectCodeTextBox.Text = recentProject.ProjectCode
        Me.ProjectNameTextBox.Text = recentProject.ProjectName
        
        mCurrentTimeEntryID = TimeRecorder.Instance.addTimeEntry(mCurrentProjectID, mCurrentProjectStartTime)

        Me.StopCurrentProjectToolStripMenuItem.Enabled = True

        If Me.MinimiseOnSelectionToolStripMenuItem.Checked = True Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub ClearAllQuickEntriesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearAllQuickEntriesToolStripMenuItem.Click

        Dim quickToolStripItem As ToolStripItem
        Dim menuCounter As Integer

        Call TimeRecorder.Instance.clearRecentProjectEntries()

        For menuCounter = (QuickToolStripMenuItem.DropDownItems.Count - 1) To 0 Step -1
            quickToolStripItem = QuickToolStripMenuItem.DropDownItems(menuCounter)

            If quickToolStripItem.Tag Is Nothing Then
            Else
                QuickToolStripMenuItem.DropDownItems.RemoveAt(menuCounter)
            End If
        Next menuCounter

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If Me.mCurrentProjectID = Nothing Then
        Else
            Call Me.StopCurrentProject()
        End If

        Me.Close()

    End Sub

    Private Sub TimesheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimesheetToolStripMenuItem.Click

        EditTimesForm.ShowDialog()

    End Sub

    Private Sub MinimiseOnSelectionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MinimiseOnSelectionToolStripMenuItem.Click

        My.Settings.MinimiseOnSelection = MinimiseOnSelectionToolStripMenuItem.Checked

    End Sub

    Private Sub MainForm_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged

        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = True
        End If

    End Sub

End Class
