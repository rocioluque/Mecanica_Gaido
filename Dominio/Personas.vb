Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports AD_Mecanica_Gaido

Public Class Personas
    Private objetocD As New AD_Personas()

    Public Function Cargar_Grilla() As DataTable
        Return objetocD.Cargar_Grilla()
    End Function
End Class
