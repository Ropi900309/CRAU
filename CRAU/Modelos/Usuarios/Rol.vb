Public Class Rol

    Private _id, _eliminado As String
    Private _rol As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, eliminado As String, rol As String)
        _id = id
        _eliminado = eliminado
        _rol = rol
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

    Public Property Rol As String
        Get
            Return _rol
        End Get
        Set(value As String)
            _rol = value
        End Set
    End Property
End Class
