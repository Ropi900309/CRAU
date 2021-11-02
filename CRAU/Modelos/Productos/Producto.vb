Public Class Producto

    Private _id, _eliminado As Integer
    Private _no_parte, _descripcion
    Private _precio_compra, _precio_venta, _costo_promedio As Double
    Private _medida As Medida
    Private _categoria As Categoria
    Private _marca As Marca
    Private _familia As Familia
    Private _stock As Stock

    Public Sub New()
        _medida = New Medida
        _categoria = New Categoria
        _marca = New Marca
        _familia = New Familia
        _stock = New Stock
    End Sub



    Public Sub New(id As Integer, eliminado As Integer, no_parte As Object, descripcion As Object, precio_compra As Double, precio_venta As Double, costo_promedio As Double, medida As Medida, categoria As Categoria, marca As Marca, familia As Familia)
        _id = id
        _eliminado = eliminado
        _no_parte = no_parte
        _descripcion = descripcion
        _precio_compra = precio_compra
        _precio_venta = precio_venta
        _costo_promedio = costo_promedio
        _medida = medida
        _categoria = categoria
        _marca = marca
        _familia = familia
    End Sub

    Public Sub New(id As Integer, eliminado As Integer, no_parte As Object, descripcion As Object, precio_compra As Double, precio_venta As Double, costo_promedio As Double, medida As Medida, categoria As Categoria, marca As Marca, familia As Familia, stock As Stock)
        _id = id
        _eliminado = eliminado
        _no_parte = no_parte
        _descripcion = descripcion
        _precio_compra = precio_compra
        _precio_venta = precio_venta
        _costo_promedio = costo_promedio
        _medida = medida
        _categoria = categoria
        _marca = marca
        _familia = familia
        _stock = stock
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

    Public Property No_parte As Object
        Get
            Return _no_parte
        End Get
        Set(value As Object)
            _no_parte = value
        End Set
    End Property

    Public Property Descripcion As Object
        Get
            Return _descripcion
        End Get
        Set(value As Object)
            _descripcion = value
        End Set
    End Property

    Public Property Precio_compra As Double
        Get
            Return _precio_compra
        End Get
        Set(value As Double)
            _precio_compra = value
        End Set
    End Property

    Public Property Precio_venta As Double
        Get
            Return _precio_venta
        End Get
        Set(value As Double)
            _precio_venta = value
        End Set
    End Property

    Public Property Costo_promedio As Double
        Get
            Return _costo_promedio
        End Get
        Set(value As Double)
            _costo_promedio = value
        End Set
    End Property

    Public Property Medida As Medida
        Get
            Return _medida
        End Get
        Set(value As Medida)
            _medida = value
        End Set
    End Property

    Public Property Categoria As Categoria
        Get
            Return _categoria
        End Get
        Set(value As Categoria)
            _categoria = value
        End Set
    End Property

    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property

    Public Property Familia As Familia
        Get
            Return _familia
        End Get
        Set(value As Familia)
            _familia = value
        End Set
    End Property

    Public Property Stock As Stock
        Get
            Return _stock
        End Get
        Set(value As Stock)
            _stock = value
        End Set
    End Property
End Class
