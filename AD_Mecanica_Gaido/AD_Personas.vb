Imports System.Data
Imports System.Data.SqlClient

Public Class AD_Personas
    Inherits ConnectionToSql

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand("Cargar_Grilla", connection)
                command.CommandType = CommandType.StoredProcedure

                Using reader = command.ExecuteReader()
                    tabla.Load(reader)
                End Using
            End Using
        End Using
        Return tabla
    End Function

    Public Sub Agregar_Persona(nombre As String, apellido As String, telefono As String, correo As String, direccion As String, idCiudad As Integer, nota As String, estado As Boolean)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand("Agregar_Persona", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Apellido", apellido)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Correo", correo)
                command.Parameters.AddWithValue("@Direccion", direccion)
                command.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                command.Parameters.AddWithValue("@Nota", nota)
                command.Parameters.AddWithValue("@Estado", estado)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
