Public Class Stock

    Private _id As Integer
    Private _stock, _alerta_min_stock, _alerta_max_stock As Double

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, stock As Double, lerta_min_stock As Double, alerta_max_stock As Double)
        _id = id
        _stock = stock
        _alerta_min_stock = lerta_min_stock
        _alerta_max_stock = alerta_max_stock
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Stock As Double
        Get
            Return _stock
        End Get
        Set(value As Double)
            _stock = value
        End Set
    End Property

    Public Property ALerta_min_stock As Double
        Get
            Return _alerta_min_stock
        End Get
        Set(value As Double)
            _alerta_min_stock = value
        End Set
    End Property

    Public Property Alerta_max_stock As Double
        Get
            Return _alerta_max_stock
        End Get
        Set(value As Double)
            _alerta_max_stock = value
        End Set
    End Property
End Class
