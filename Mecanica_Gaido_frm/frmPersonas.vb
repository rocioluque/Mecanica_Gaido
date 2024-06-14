Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmPersonas
    Dim o_Personas As New AD_Personas

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        Cargar_Provincias()
    End Sub

    Private Sub Cargar_Provincias()
        Try
            Dim o_Personas As New AD_Personas
            Dim tabla As DataTable = o_Personas.Cargar_Provincias()

            If tabla.Rows.Count > 0 Then
                cboProvincia.DataSource = tabla
                cboProvincia.DisplayMember = "Nombre"
                cboProvincia.ValueMember = "ID_Provincia"
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las provincias: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Ciudades(ID_Provincia As String)
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Ciudades_Por_Provincia(ID_Provincia)

            If tabla.Rows.Count > 0 Then
                cboCiudad.DataSource = tabla
                cboCiudad.DisplayMember = "Ciudad"
                cboCiudad.ValueMember = "ID_Ciudad"
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        Try
            If cboProvincia.SelectedValue IsNot Nothing Then
                Dim idProvincia As Integer
                If TypeOf cboProvincia.SelectedValue Is DataRowView Then
                    idProvincia = Convert.ToInt32(DirectCast(cboProvincia.SelectedValue, DataRowView)("ID_Provincia"))
                Else
                    idProvincia = Convert.ToInt32(cboProvincia.SelectedValue)
                End If
                Cargar_Ciudades(idProvincia)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdPersonas.AutoGenerateColumns = True
            grdPersonas.DataSource = oDs.Tables(0)
            grdPersonas.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub


    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub btnCtasCtes_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        frmCuentas.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtTelefono.Text <> Nothing And txtCorreo.Text <> Nothing And
            txtDireccion.Text <> Nothing And cboCiudad.SelectedValue Then

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
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtID.Text <> Nothing And txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtTelefono.Text <> Nothing And txtCorreo.Text <> Nothing And
            txtDireccion.Text <> Nothing And cboCiudad.SelectedValue Then
            Try
                Dim idPersona As Integer = Convert.ToInt32(txtID.Text)
                Dim nombre As String = txtNombre.Text
                Dim apellido As String = txtApellido.Text
                Dim telefono As String = txtTelefono.Text
                Dim correo As String = txtCorreo.Text
                Dim direccion As String = txtDireccion.Text
                Dim idCiudad As Integer = Convert.ToInt32(cboCiudad.SelectedValue)
                Dim nota As String = txtNota.Text
                Dim estado As Boolean = chkEstado.Checked

                o_Personas.Modificar_Persona(idPersona, nombre, apellido, telefono, correo, direccion, idCiudad, nota, estado)
                MsgBox("Persona modificada correctamente.", vbInformation, "Información")


                Cargar_Grilla()
            Catch ex As Exception
                MsgBox("Error al modificar la persona: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
End Class