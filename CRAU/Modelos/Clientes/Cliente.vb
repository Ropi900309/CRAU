Public Class Cliente
    Private _id As Integer
    Private _tipo As Ctipo
    Private _razon_social, _rfc, _direccion As String

    Public Sub New()
        _tipo = New Ctipo
    End Sub

    Public Sub New(id As Integer, tipo As Ctipo, razon_social As String, rfc As String, direccion As String)
        _id = id
        _tipo = tipo
        _razon_social = razon_social
        _rfc = rfc
        _direccion = direccion
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tipo As Ctipo
        Get
            Return _tipo
        End Get
        Set(value As Ctipo)
            _tipo = value
        End Set
    End Property

    Public Property Razon_social As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
End Class
