Public Class Ptipo
    Private _id, _eliminado As Integer
    Private _tipo_asociado As String

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, eliminado As Integer, tipo_asociado As String)
        _id = id
        _eliminado = eliminado
        _tipo_asociado = tipo_asociado
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


    Public Property Tipo_asociado As String
        Get
            Return _tipo_asociado
        End Get
        Set(value As String)
            _tipo_asociado = value
        End Set
    End Property

End Class
