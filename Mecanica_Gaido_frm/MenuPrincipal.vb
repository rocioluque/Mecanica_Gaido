Imports System.Data
Imports System.Runtime.InteropServices
Imports Dominio
Imports Comun_Soporte

Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsuario.Text = UsuarioActivo.usuario
        lblRol.Text = UsuarioActivo.nombre_rol
        lblNombre.Text = UsuarioActivo.nombrePersona & " " & UsuarioActivo.apellidoPersona
        lblCorreo.Text = UsuarioActivo.correoPersona

    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        AbrirFormHijo(New frmVehiculos())
    End Sub

    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        AbrirFormHijo(New frmPersonas())
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormHijo(New frmProductos())
    End Sub

    Private Sub btnOrdenReparacón_Click(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Click
        AbrirFormHijo(New frmOrdenesReparacion())
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New frmVentas())
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormHijo(New frmCompras())
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub AbrirFormHijo(formHijo As Object)
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formHijo, Form)
        If fh IsNot Nothing Then
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.panelContenedor.Controls.Add(fh)
            Me.panelContenedor.Tag = fh
            fh.Show()
            fh.BringToFront()
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If MessageBox.Show("¿Estás seguro de cerrar sesión?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
