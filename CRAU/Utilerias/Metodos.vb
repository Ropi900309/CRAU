Public Class Metodos
    Public Shared Sub Buscar(valor As String, grid As DataGridView, idCol As Integer, nomCol As Integer)


        For Each row As DataGridViewRow In grid.Rows
            'Si el contenido de la columna coinside con el valor del TextBox
            Dim cell As DataGridViewCell = row.Cells("Clave")

            If IsNumeric(valor) Then
                If CStr(row.Cells(idCol).Value).ToLower = Metodos.setCeros(valor.ToLower) Then
                    'Selecciono fila y abandono bucle
                    row.Selected = True
                    grid.FirstDisplayedCell = grid.Item(1, row.Index)
                    grid.CurrentCell = cell
                    Exit For

                Else
                    row.Selected = False
                End If
            Else
                Dim cadena As String = valor.ToLower
                Dim i As Integer = InStr(CStr(row.Cells(nomCol).Value).ToLower, cadena)

                If i > 0 Then
                    row.Selected = True
                    grid.FirstDisplayedCell = grid.Item(1, row.Index)
                    grid.CurrentCell = cell
                    Exit For
                Else
                    row.Selected = False
                End If
            End If

        Next
    End Sub


    'Public Shared Sub LlenarComboEmpleado(combo As ComboBox)
    '    Dim objeto As New DAOEmpleado
    '    Dim ListCat As List(Of Empleado) = objeto.llenarCombo

    '    With combo
    '        '.Items.Clear()
    '        .DataSource = ListCat
    '        .DisplayMember = "Nombre"
    '        .ValueMember = "Clave"
    '        .SelectedIndex = -1
    '    End With

    'End Sub

    'Public Shared Sub LlenarComboCategoria(combo As ComboBox, empleado As Integer)
    '    Dim objeto As New DAOCategoria
    '    Dim ListCat As List(Of Categoria) = objeto.llenarCombo(empleado)

    '    With combo
    '        '.Items.Clear()
    '        .DataSource = ListCat
    '        .DisplayMember = "Categoria"
    '        .ValueMember = "Clave"
    '        .SelectedIndex = -1
    '    End With

    'End Sub

    Public Shared Function setCeros(valor As Integer) As String
        Dim largo As Integer = Len(valor.ToString)
        Dim numero As String
        Select Case largo
            Case 1
                numero = "0000" & valor
            Case 2
                numero = "000" & valor
            Case 3
                numero = "00" & valor
            Case 4
                numero = "0" & valor
            Case Else
                numero = valor
        End Select

        Return numero
    End Function

End Class
