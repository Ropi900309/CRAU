
Imports System.Data.SqlClient
Public Class Cnx
    Private Shared conn As Cnx
    Private Shared conexion As SqlConnection
    '.ConnectionString ="Data Source=192.168.1.250;Initial Catalog=nom_ropi_azja;user id=sa;password=AsjaEvol19;Max pool Size=10024"
    Private Sub New()
        conexion = New SqlConnection With {
             .ConnectionString = "Data Source=DESKTOP-GDI323F;Initial Catalog=crau;Integrated Security=True"
        }
        conexion.Open()
        '.ConnectionString = "Data Source=PC-ROPI-G;Initial Catalog=crau;Integrated Security=True"
    End Sub

    Public Shared Function GetInstance() As Cnx

        If (conn Is Nothing) Then
            conn = New Cnx()
        End If

        Return conn
    End Function

    Public Shared ReadOnly Property GetConection As SqlConnection
        Get

            Return conexion
        End Get
    End Property

    Public Sub Close_CnxSqlServer()
        Try
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXIÓN")
        End Try
    End Sub

End Class
