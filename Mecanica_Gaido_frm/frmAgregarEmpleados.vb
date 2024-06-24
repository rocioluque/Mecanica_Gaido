Public Class frmAgregarEmpleados
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        txtDireccion.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefono.Clear()
        cboUsuario.SelectedIndex = 0
        txtContraseña.Clear()
        cboSeccion.SelectedIndex = 0
        txtNota.Clear()
        chkEstado.Checked = False
    End Sub
End Class