Public Class Vehiculo

    Private _id, _eliminado As Integer
    Private _marca As Vmarca
    Private _tipo As Vtipo
    Private _registro_vehicular, _modelo, _placas, _serie As String

    Public Sub New()
        _marca = New Vmarca
        _tipo = New Vtipo
    End Sub


    Public Sub New(id As Integer, eliminado As Integer, marca As Vmarca, tipo As Vtipo, registro_vehicular As String, modelo As String, placas As String, serie As String)
        _id = id
        _eliminado = eliminado
        _marca = marca
        _tipo = tipo
        _registro_vehicular = registro_vehicular
        _modelo = modelo
        _placas = placas
        _serie = serie
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

    Public Property Marca As Vmarca
        Get
            Return _marca
        End Get
        Set(value As Vmarca)
            _marca = value
        End Set
    End Property

    Public Property Tipo As Vtipo
        Get
            Return _tipo
        End Get
        Set(value As Vtipo)
            _tipo = value
        End Set
    End Property

    Public Property Registro_vehicular As String
        Get
            Return _registro_vehicular
        End Get
        Set(value As String)
            _registro_vehicular = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Placas As String
        Get
            Return _placas
        End Get
        Set(value As String)
            _placas = value
        End Set
    End Property

    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            _serie = value
        End Set
    End Property
End Class
