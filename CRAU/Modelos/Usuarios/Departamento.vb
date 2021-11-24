Public Class Departamento

    Private _id, _eliminado As Integer
    Private _departamento As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, departamento As String, eliminado As Integer)
        _id = id

        _departamento = departamento
        _eliminado = eliminado
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Eliminado As Integer
        Get
            Return _eliminado
        End Get
        Set(value As Integer)
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
