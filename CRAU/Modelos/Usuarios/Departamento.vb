Public Class Departamento

    Private _id, _eliminado As String
    Private _departamento As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, eliminado As String, departamento As String)
        _id = id
        _eliminado = eliminado
        _departamento = departamento
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Eliminado As String
        Get
            Return _eliminado
        End Get
        Set(value As String)
            _eliminado = value
        End Set
    End Property

    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property
End Class
