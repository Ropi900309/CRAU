Public Interface OpSql

    Sub Guardar()
    Sub Actualizar()
    Sub Eliminar()
    Function Count() As Integer
    Function Exist() As Boolean
    Overloads Function ListarTodos()
    Overloads Function Buscar()

End Interface
