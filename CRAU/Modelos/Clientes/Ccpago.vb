Public Class Ccpago

    Private _id As Integer
    Private _asociado As Cliente
    Private _pago As String


    Public Sub New()
        _asociado = New Cliente
    End Sub

    Public Sub New(id As Integer, asociado As Cliente, pago As String)
        _id = id
        _asociado = asociado
        _pago = pago
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

    Public Property Pago As String
        Get
            Return _pago
        End Get
        Set(value As String)
            _pago = value
        End Set
    End Property

End Class
