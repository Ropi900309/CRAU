Public Class Familia

    Private _id, _eliminado As Integer
    Private _familia As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, familia As String, eliminado As Integer)
        _id = id

        _familia = familia
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

    Public Property Familia As String
        Get
            Return _familia
        End Get
        Set(value As String)
            _familia = value
        End Set
    End Property
End Class
