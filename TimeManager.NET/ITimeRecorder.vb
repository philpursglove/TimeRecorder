

Public Interface ITimeRecorderDAL
    Overloads Function listProjects() As DataTable
    Overloads Function listProjects(ByVal searchString As String) As DataTable
    Function listTasksForProject(ByVal projectID As Guid) As DataTable
    Sub addProject(ByVal projectCode As String, ByVal projectDescription As String)
    Sub addTaskForProject(ByVal projectID As Guid, ByVal taskDescription As String)
    Sub editProject(ByVal projectID As Guid, ByVal newProjectDescription As String, ByVal newProjectCode As String)
    Sub editTask(ByVal taskID As Guid, ByVal newTaskDescription As String)
    Function getTask(ByVal taskID As Guid) As DataTable
    Overloads Function addTimeEntry(ByVal taskID As Guid, ByVal startTime As DateTime) As Guid
    Overloads Function addTimeEntry(ByVal taskID As Guid, ByVal startTime As DateTime, ByVal endTime As DateTime) As Guid
    Sub editTimeEntry(ByVal timeEntryID As Guid, ByVal startTime As DateTime, ByVal endTime As DateTime)
    Function getTimeEntry(ByVal timeEntryID As Guid) As DataRow
    Function ListTimeEntryDates() As DataTable
    Function listTimeEntryMonths() As DataTable
    Function listRecentTasks() As DataTable
    Function getLastTimeEntry() As DataTable
    Function listTimeEntries(ByVal startDate As Date, ByVal endDate As Date) As DataTable
    Sub clearRecentTaskEntries()
End Interface