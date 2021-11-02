Public Class Medida

    Private _id, _eliminado As Integer
    Private _medida As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, medida As String, eliminado As Integer)
        _id = id
        _medida = medida
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

    Public Property Medida As String
        Get
            Return _medida
        End Get
        Set(value As String)
            _medida = value
        End Set
    End Property


End Class
