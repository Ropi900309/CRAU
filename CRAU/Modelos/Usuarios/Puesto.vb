Public Class Puesto

    Private _id, _eliminado As Integer
    Private _puesto As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, puesto As String, eliminado As Integer)
        _id = id

        _puesto = puesto
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

    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property
End Class
