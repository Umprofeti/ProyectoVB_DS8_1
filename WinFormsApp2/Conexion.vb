Imports MySql.Data.MySqlClient

Public Class ConexionBD
    Private Shared connectionString As String = "server=localhost;userid='root';password='';database='d8'"
    Private Shared connection As MySqlConnection

    ' Método para obtener la conexión a la base de datos
    Public Shared Function ObtenerConexion() As MySqlConnection
        If connection Is Nothing Then
            connection = New MySqlConnection(connectionString)
        End If
        Return connection
    End Function

    ' Método para abrir la conexión
    Public Shared Sub AbrirConexion()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Método para cerrar la conexión
    Public Shared Sub CerrarConexion()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
