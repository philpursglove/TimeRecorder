


Public Class TimeRecorder

    Private Shared ReadOnly lazy As Lazy(Of TimeRecorder) = New Lazy(Of TimeRecorder)

    Public Shared ReadOnly Property Instance As TimeRecorder
        Get
            Return lazy.Value
        End Get
    End Property

    Private DAL As ITimeRecorderDAL

    Public Sub New()
        DAL = New TimeRecorderDALSQLExpress
    End Sub

    Public Sub addProject(newProject As Project)

        Call DAL.addProject(newProject.ProjectCode, newProject.ProjectName)

    End Sub

    Public Function listProjects() As List(Of Project)

        Dim projects As List(Of Project) = New List(Of Project)

        For Each projectDataRow As DataRow In DAL.listProjects.Rows
            projects.Add(New Project(New Guid(projectDataRow.Item("projectId").ToString), projectDataRow.Item("projectCode").ToString, projectDataRow.Item("projectName").ToString))
        Next
        Return projects
    End Function

    Public Sub editProject(projectId As Guid, newDescription As String, newCode As String)
        Call DAL.editProject(projectId, newDescription, newCode)
    End Sub

    Public Function getTimeEntry(timeEntryId As Guid) As DataRow
        Return DAL.getTimeEntry(timeEntryId)
    End Function

    Public Function listTimeEntryDates() As DataTable
        Return DAL.ListTimeEntryDates
    End Function

    Public Function addTimeEntry(projectId As Guid, startTime As DateTime) As Guid
        Return DAL.addTimeEntry(projectId, startTime)
    End Function

    Public Sub addTimeEntry(projectId As Guid, startTime As DateTime, endTime As DateTime)
        Call DAL.addTimeEntry(projectId, startTime, endTime)
    End Sub

    Public Function listTimeEntries(startDate As DateTime, endDate As DateTime) As DataTable
        Return DAL.listTimeEntries(startDate, endDate)
    End Function

    Public Sub editTimeEntry(timeEntryId As Guid, newStartTime As DateTime, newEndTime As DateTime)
        DAL.editTimeEntry(timeEntryId, newStartTime, newEndTime)
    End Sub

    Public Function listRecentProjects() As List(Of Project)
        'Return DAL.listRecentProjects

        Return New List(Of Project)
    End Function

    Public Sub clearRecentProjectEntries()
        Call DAL.clearRecentTaskEntries()
    End Sub

    Public Function listTimeEntryMonths() As DataTable
        Return DAL.listTimeEntryMonths
    End Function

    Function getProject(mCurrentProjectID As Guid) As Project

        Dim selectedProject As Project

        Return New Project
    End Function

End Class