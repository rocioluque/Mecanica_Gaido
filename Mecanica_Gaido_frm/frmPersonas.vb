Imports System.Data
Imports Dominio

Public Class frmPersonas
    Dim o_Personas As New Personas

    Public Sub Cargar_Grilla()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Grilla()
            grdGrillaPersonas.DataSource = Nothing  ' Limpiar DataSource
            grdGrillaPersonas.DataSource = tabla
            grdGrillaPersonas.Refresh()
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

    Private Sub btnCtasCtes_Click(sender As Object, e As EventArgs) Handles btnCtasCtes.Click
        frmCtasCorrientes.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim nombre As String = txtNombre.Text
            Dim apellido As String = txtApellido.Text
            Dim telefono As String = txtTelefono.Text
            Dim correo As String = txtCorreo.Text
            Dim direccion As String = txtDireccion.Text
            Dim idCiudad As Integer = Convert.ToInt32(cboCiudad.SelectedValue)
            Dim nota As String = txtNota.Text
            Dim estado As Boolean = chkEstado.Checked

            o_Personas.Agregar_Persona(nombre, apellido, telefono, correo, direccion, idCiudad, nota, estado)
            MsgBox("Persona agregada correctamente.", vbInformation, "Información")
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al agregar la persona: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class