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
End Class
