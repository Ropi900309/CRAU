Public Class CategoriaCRUB
    Implements GripMethod

    Friend Shared recibview As ProductoCRUB
    Private cat As New DAOCategoria

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListProductos
            .Rows.Clear()

            'PROPIEDADES DEL GRID
            .DefaultCellStyle.Font = New Font("OCR A", 9)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.OrangeRed
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            'NUMERO DE COLUMNAS 
            .ColumnCount = 4

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "Eliminado"



            'DEFINE EL ANCHO DE LAS COLUMNAS 

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



            .Columns(1).ValueType = Type.GetType("System.Int32")



            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            .Columns(0).Visible = False
            .Columns(3).Visible = False



            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim pro As New DAOCategoria

        Dim resultado As List(Of Categoria) = pro.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListProductos
            .Rows.Clear()


            For Each row As Categoria In resultado
                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Id
                .Item(2, i).Value = row.Categoria
                .Item(3, i).Value = row.Eliminado


                i += 1

                a += 1

            Next


        End With
    End Sub

    Private Sub CategoriaCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            cat.Categoria = textNombre.Text
            cat.Eliminado = 0

            If cat.Id > 0 Then
                cat.Actualizar()
            Else
                If Metodos.ValidarCajaTexto(textNombre) = False Then
                    MsgBox("Rellene los campos faltantes", vbCritical, "Error")
                    textNombre.Text = ""
                    textNombre.Focus()
                Else
                    cat.Guardar()
                End If
            End If
            ClearData()
            recibview.LlenarCategoria()
            LlenarGrid()
            MsgBox("Se actualizaron los datos correctamente", vbInformation, "Resultado")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            With ListProductos

                recibview.comboCategoria.SelectedValue = .Item(0, .CurrentRow.Index).Value


            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            With ListProductos
                cat.Id = .Item(0, .CurrentRow.Index).Value
                cat.Categoria = .Item(2, .CurrentRow.Index).Value
                cat.Eliminado = .Item(3, .CurrentRow.Index).Value

                textNombre.Text = cat.Categoria
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            With ListProductos
                cat.Id = .Item(0, .CurrentRow.Index).Value
                cat.Categoria = .Item(2, .CurrentRow.Index).Value
                cat.Eliminado = 1
                cat.Eliminar()
            End With
            ClearData()
            recibview.LlenarCategoria()
            LlenarGrid()
            MsgBox("Se eliminaron los datos correctamente", vbInformation, "Resultado")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ClearData()
        cat.Id = 0
        cat.Categoria = ""
        cat.Eliminado = 0
        textNombre.Text = ""
    End Sub

    Private Sub Close_form(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class