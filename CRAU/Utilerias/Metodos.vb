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

    Friend Shared Function validarUnicoValor(dao As Object) As Boolean
        Dim valor As Boolean = dao.Exist()
        Return valor
    End Function

    Friend Shared Function ValidarCajaTexto(caja As TextBox) As Boolean
        If caja.Text.Trim = "" Or caja.Text.Trim = Nothing Or caja.Text.Trim = "0" Then
            Return False

        Else
            Return True
        End If
    End Function

    Friend Shared Sub ValidarSolocaja(caja As TextBox)
        If Metodos.ValidarCajaTexto(caja) = True Then

        Else
            MsgBox("Rellene los campos faltantes", vbCritical, "Error")
            caja.Text = ""
            caja.Focus()
        End If
    End Sub

    Friend Shared Sub ValidarUnico(dao As Object, caja As TextBox)
        If (Metodos.validarUnicoValor(dao) = True) Then
            MsgBox("La clave ya existe", vbCritical, "Error")
            caja.Text = ""
            caja.Focus()
        End If
    End Sub

    Friend Shared Function ValidarComboSeleccion(combo As ComboBox) As Boolean
        If combo.SelectedValue IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Friend Shared Function ValidarComboVacio(combo As ComboBox) As Boolean
        If combo.Items.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Friend Shared Sub ValidarCombo(combo As ComboBox)
        If Metodos.ValidarComboSeleccion(combo) = True Then
        Else
            MsgBox("Rellene los campos faltantes", vbCritical, "Error")
            combo.Focus()
        End If
    End Sub

    Friend Shared Sub ContadorLabel(label As Label, caja As TextBox)
        label.Text = caja.Text.Length()
        If InStrRev(caja.Text.Length, caja.MaxLength) Then
            MsgBox("Exede Máximo de Caracteres", vbCritical, "Error")
            caja.Focus()
        End If
    End Sub

End Class
