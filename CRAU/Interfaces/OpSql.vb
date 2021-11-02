Public Interface OpSql

    Sub Guardar()
    Sub Actualizar()
    Sub Eliminar()
    Function Count() As Integer
    Overloads Function ListarTodos()
    Overloads Function Buscar()

End Interface
