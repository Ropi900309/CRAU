Public Class Ccontacto

    Private _id As Integer
    Private _asociado As Cliente
    Private _telefono, _correo_electronico, _nombre_contacto As String

    Public Sub New()
        _asociado = New Cliente
    End Sub

    Public Sub New(id As Integer, asociado As Cliente, telefono As String, correo_electronico As String, nombre_contacto As String)
        _id = id
        _asociado = asociado
        _telefono = telefono
        _correo_electronico = correo_electronico
        _nombre_contacto = nombre_contacto
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Asociado As Cliente
        Get
            Return _asociado
        End Get
        Set(value As Cliente)
            _asociado = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo_electronico As String
        Get
            Return _correo_electronico
        End Get
        Set(value As String)
            _correo_electronico = value
        End Set
    End Property

    Public Property Nombre_contacto As String
        Get
            Return _nombre_contacto
        End Get
        Set(value As String)
            _nombre_contacto = value
        End Set
    End Property
End Class
