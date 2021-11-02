Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cnx.GetInstance()
    End Sub

    Private Sub Acceder()
        If textUser.Text <> "" And textPasswprd.Text <> "" Then
            Dim user As New DAOUsuario With {
                .Usuario = textUser.Text,
                .Contraseña = textPasswprd.Text
            }
            If user.ValidarUser(user.Usuario).Contraseña = user.Contraseña Then
                Dim frm As New Menu()
                frm.Show()
                AddHandler frm.FormClosed, AddressOf Me.Logout
                Me.Hide()
                'MsgBox("Bienvenido " & user.UserNamePro)
            Else
                MsgBox("Error en las credenciales", vbCritical, "Error")
            End If
        Else
            MsgBox("Faltan campos por rellenar", vbExclamation, "Error")
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Acceder()
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles textPasswprd.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles textUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Close_login(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        textUser.Clear()
        textPasswprd.Clear()
        Me.Show()
        textUser.Focus()
    End Sub
End Class
