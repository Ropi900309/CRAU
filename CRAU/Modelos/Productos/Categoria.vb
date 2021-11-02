Public Class Categoria

    Private _id, _eliminado As Integer
    Private _categoria As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, categoria As String, eliminado As Integer)
        _id = id
        _categoria = categoria
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

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

End Class
