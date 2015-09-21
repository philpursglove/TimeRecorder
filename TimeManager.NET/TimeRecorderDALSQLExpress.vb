Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class TimeRecorderDALSQLExpress
    Implements WSP.TimeRecorder.Application.ITimeRecorderDAL

    Public Overloads Function listProjects() As DataTable Implements ITimeRecorderDAL.listProjects

        Dim DAL As Database
        Dim command As DbCommand
        Dim projectDataTable As DataTable

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            command = DAL.GetStoredProcCommand("ProjectList")

            projectDataTable = DAL.ExecuteDataSet(command).Tables(0)

            Return projectDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Overloads Function listProjects(ByVal searchString As String) As DataTable Implements ITimeRecorderDAL.listProjects

        Dim DAL As Database
        Dim command As DbCommand
        Dim projectDataTable As DataTable

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            command = DAL.GetStoredProcCommand("ProjectListByDescription")

            projectDataTable = DAL.ExecuteDataSet(command).Tables(0)

            Return projectDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Function listTasksForProject(ByVal projectID As Guid) As DataTable Implements ITimeRecorderDAL.listTasksForProject

        Dim DAL As Database
        Dim command As DbCommand
        Dim taskDataTable As DataTable

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            command = DAL.GetStoredProcCommand("TaskListByProjectID")

            DAL.AddInParameter(command, "@ProjectID", DbType.Guid, projectID)

            taskDataTable = DAL.ExecuteDataSet(command).Tables(0)

            Return taskDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Sub addProject(ByVal projectCode As String, ByVal projectDescription As String) Implements ITimeRecorderDAL.addProject

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            command = DAL.GetStoredProcCommand("ProjectInsert")

            DAL.AddInParameter(command, "@ProjectCode", DbType.String, projectCode)
            DAL.AddInParameter(command, "@ProjectDescription", DbType.String, projectDescription)

            DAL.ExecuteNonQuery(command)
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

    Public Sub addTaskForProject(ByVal projectID As Guid, ByVal taskDescription As String) Implements ITimeRecorderDAL.addTaskForProject

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TaskInsert")

                .AddInParameter(command, "@ProjectID", DbType.Guid, projectID)
                .AddInParameter(command, "@TaskDescription", DbType.String, taskDescription)
                .ExecuteNonQuery(command)
            End With

        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

    Public Sub editProject(ByVal projectID As Guid, ByVal newProjectDescription As String, ByVal newProjectCode As String) Implements ITimeRecorderDAL.editProject

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("ProjectUpdateByProjectID")
                .AddInParameter(command, "@ProjectID", DbType.Guid, projectID)
                .AddInParameter(command, "@ProjectDescription", DbType.String, newProjectDescription)
                .AddInParameter(command, "@ProjectCode", DbType.String, newProjectCode)
                .ExecuteNonQuery(command)
            End With

        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

    Public Sub editTask(ByVal taskID As Guid, ByVal newTaskDescription As String) Implements ITimeRecorderDAL.editTask

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TaskUpdateByTaskID")
                .AddInParameter(command, "@TaskID", DbType.Guid, taskID)
                .AddInParameter(command, "@TaskDescription", DbType.String, newTaskDescription)
                .ExecuteNonQuery(command)
            End With

        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

    Public Function getTask(ByVal taskID As Guid) As DataTable Implements ITimeRecorderDAL.getTask

        Dim DAL As Database
        Dim taskDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TaskGetByTaskID")
                .AddInParameter(command, "@TaskID", DbType.Guid, taskID)
                taskDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return taskDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Overloads Function addTimeEntry(ByVal taskID As Guid, ByVal startTime As DateTime) As Guid Implements ITimeRecorderDAL.addTimeEntry

        Dim DAL As Database
        Dim timeEntryGuid As Guid
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = DAL.GetStoredProcCommand("TimeEntryInsert")
                .AddInParameter(command, "@TaskID", DbType.Guid, taskID)
                .AddInParameter(command, "@StartTime", DbType.DateTime, startTime)
                .AddOutParameter(command, "@TimeEntryID", DbType.Guid, 50)
                .ExecuteNonQuery(command)
                timeEntryGuid = CType(DAL.GetParameterValue(command, "@TimeEntryID"), Guid)
                command = Nothing

                command = .GetStoredProcCommand("spRecentTaskInsert")
                .AddInParameter(command, "@TaskID", DbType.Guid, taskID)
                .ExecuteNonQuery(command)
            End With

            Return timeEntryGuid
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Overloads Function addTimeEntry(ByVal taskID As Guid, ByVal startTime As DateTime, ByVal endTime As DateTime) As Guid Implements ITimeRecorderDAL.addTimeEntry

        Dim DAL As Database
        Dim timeEntryGuid As Guid
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryInsert")
                .AddInParameter(command, "@TaskID", DbType.Guid, taskID)
                .AddInParameter(command, "@StartTime", DbType.DateTime, startTime)
                .AddInParameter(command, "@EndTime", DbType.DateTime, endTime)
                .AddOutParameter(command, "@TimeEntryID", DbType.Guid, 50)
                .ExecuteNonQuery(command)
                timeEntryGuid = CType(DAL.GetParameterValue(command, "@TimeEntryID"), Guid)
            End With

            Return timeEntryGuid
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Sub editTimeEntry(ByVal timeEntryID As Guid, ByVal startTime As DateTime, ByVal endTime As DateTime) Implements ITimeRecorderDAL.editTimeEntry

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryUpdate")
                .AddInParameter(command, "@TimeEntryID", DbType.Guid, timeEntryID)
                .AddInParameter(command, "@StartTime", DbType.DateTime, startTime)
                .AddInParameter(command, "@EndTime", DbType.DateTime, endTime)
                .AddInParameter(command, "@DurationMinutes", DbType.Int32, DateDiff(DateInterval.Minute, startTime, endTime))
                .ExecuteNonQuery(command)
            End With

        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

    Public Function getTimeEntry(ByVal timeEntryID As Guid) As DataRow Implements ITimeRecorderDAL.getTimeEntry

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryGetByID")
                .AddInParameter(command, "@TimeEntryID", DbType.Guid, timeEntryID)
                Return DAL.ExecuteDataSet(command).Tables(0).Rows(0)
            End With
        Catch ex As Exception
            Throw
        Finally
            DAL = Nothing
        End Try

    End Function

    Public Function ListTimeEntryDates() As DataTable Implements ITimeRecorderDAL.ListTimeEntryDates

        Dim DAL As Database
        Dim dateDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryDateList")
                dateDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return dateDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Function listTimeEntryMonths() As DataTable Implements ITimeRecorderDAL.listTimeEntryMonths

        Dim DAL As Database
        Dim monthDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryMonthList")
                monthDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return monthDataTable
        Catch ex As Exception
            Throw
        Finally
            DAL = Nothing
            command = Nothing
        End Try
    End Function

    Public Function listRecentTasks() As DataTable Implements ITimeRecorderDAL.listRecentTasks

        Dim DAL As Database
        Dim recentTaskDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("RecentTaskList")
                recentTaskDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return recentTaskDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Function getLastTimeEntry() As DataTable Implements ITimeRecorderDAL.getLastTimeEntry

        Dim DAL As Database
        Dim LastTimeEntryDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("LastTimeEntryGet")
                LastTimeEntryDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return LastTimeEntryDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Function listTimeEntries(ByVal startDate As Date, ByVal endDate As Date) As DataTable Implements ITimeRecorderDAL.listTimeEntries

        Dim DAL As Database
        Dim timeEntryDataTable As DataTable
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("TimeEntryListByDates")
                .AddInParameter(command, "@StartDate", DbType.DateTime, startDate)
                .AddInParameter(command, "@EndDate", DbType.DateTime, endDate)
                timeEntryDataTable = .ExecuteDataSet(command).Tables(0)
            End With

            Return timeEntryDataTable
        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Function

    Public Sub clearRecentTaskEntries() Implements ITimeRecorderDAL.clearRecentTaskEntries

        Dim DAL As Database
        Dim command As DbCommand

        Try
            DAL = DatabaseFactory.CreateDatabase("TimeRecorder")

            With DAL
                command = .GetStoredProcCommand("RecentTaskDelete")
                .ExecuteNonQuery(command)
            End With

        Catch ex As Exception
            Throw
        Finally
            command = Nothing
            DAL = Nothing
        End Try

    End Sub

End Class
