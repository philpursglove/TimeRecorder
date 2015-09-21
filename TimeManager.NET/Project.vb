Public Class Project
    Private _projectCode As String
    Public Property ProjectCode() As String
        Get
            Return _projectCode
        End Get
        Set(ByVal value As String)
            _projectCode = value
        End Set
    End Property

    Private _projectName As String
    Public Property ProjectName() As String
        Get
            Return _projectName
        End Get
        Set(ByVal value As String)
            _projectName = value
        End Set
    End Property

    Private _projectId As Guid
    Public ReadOnly Property ProjectId As Guid
        Get
            Return _projectId
        End Get
    End Property

    Public Sub New()

    End Sub
    Public Sub New(id As Guid, name As String, code As String)
        _projectId = id
        _projectName = name
        _projectCode = code
    End Sub
End Class
