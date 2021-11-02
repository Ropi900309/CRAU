Public Class Vmarca
    Private _id As Integer
    Private _marca As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, marca As String)
        _id = id
        _marca = marca
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property
End Class
