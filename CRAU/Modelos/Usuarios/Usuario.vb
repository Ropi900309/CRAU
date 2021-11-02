Public Class Usuario

    Private _id, _eliminado As Integer
    Private _usuario, _contraseña As String
    Private _empleado As Empleado
    Private _rol As Rol

    Public Sub New()
        _empleado = New Empleado()
        _rol = New Rol
    End Sub

    Public Sub New(id As Integer, eliminado As Integer, usuario As String, contraseña As String, empleado As Empleado, rol As Rol)
        _id = id
        _eliminado = eliminado
        _usuario = usuario
        _contraseña = contraseña
        _empleado = empleado
        _rol = rol
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

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Empleado As Empleado
        Get
            Return _empleado
        End Get
        Set(value As Empleado)
            _empleado = value
        End Set
    End Property

    Public Property Rol As Rol
        Get
            Return _rol
        End Get
        Set(value As Rol)
            _rol = value
        End Set
    End Property
End Class
