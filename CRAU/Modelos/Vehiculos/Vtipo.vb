Public Class Vtipo
    Private _id, _eliminado As Integer
    Private _tipo As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, eliminado As Integer, tipo As String)
        _id = id
        _eliminado = eliminado
        _tipo = tipo
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

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
End Class
