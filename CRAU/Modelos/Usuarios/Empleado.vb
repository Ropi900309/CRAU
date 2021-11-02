Public Class Empleado

    Private _id As Integer
    Private _nombre, _paterno, _materno, _rfc, _nss As String
    Private _fecha_alta As Date
    Private _departamento As Departamento
    Private _puesto As Puesto

    Public Sub New()
        _departamento = New Departamento()
        _puesto = New Puesto()
    End Sub

    Public Sub New(id As Integer, nombre As String, paterno As String, materno As String, rfc As String, nss As String, fecha_alta As Date, departamento As Departamento, puesto As Puesto)
        _id = id
        _nombre = nombre
        _paterno = paterno
        _materno = materno
        _rfc = rfc
        _nss = nss
        _fecha_alta = fecha_alta
        _departamento = departamento
        _puesto = puesto
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Paterno As String
        Get
            Return _paterno
        End Get
        Set(value As String)
            _paterno = value
        End Set
    End Property

    Public Property Materno As String
        Get
            Return _materno
        End Get
        Set(value As String)
            _materno = value
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

    Public Property Nss As String
        Get
            Return _nss
        End Get
        Set(value As String)
            _nss = value
        End Set
    End Property

    Public Property Fecha_alta As Date
        Get
            Return _fecha_alta
        End Get
        Set(value As Date)
            _fecha_alta = value
        End Set
    End Property

    Public Property Departamento As Departamento
        Get
            Return _departamento
        End Get
        Set(value As Departamento)
            _departamento = value
        End Set
    End Property

    Public Property Puesto As Puesto
        Get
            Return _puesto
        End Get
        Set(value As Puesto)
            _puesto = value
        End Set
    End Property
End Class
