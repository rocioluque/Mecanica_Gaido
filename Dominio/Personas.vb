Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports AD_Mecanica_Gaido

Public Class Personas
    Private objetocD As New AD_Personas()

    Public Function Cargar_Grilla() As DataTable
        Return objetocD.Cargar_Grilla()
    End Function

    Public Sub Agregar_Persona(nombre As String, apellido As String, telefono As String, correo As String, direccion As String, idCiudad As Integer, nota As String, estado As Boolean)
        objetocD.Agregar_Persona(nombre, apellido, telefono, correo, direccion, idCiudad, nota, estado)
    End Sub

End Class
