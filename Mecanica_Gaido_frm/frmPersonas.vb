Imports System.Data
Imports Dominio

Public Class frmPersonas
    Dim o_Personas As New Personas

    Public Sub Cargar_Grilla()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Grilla
            grdGrillaPersonas.DataSource = tabla
        Catch ex As Exception
            MsgBox("Error al cargar la grilla de personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmEmpeados.ShowDialog()
    End Sub
End Class