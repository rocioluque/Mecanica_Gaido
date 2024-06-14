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
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        AbrirFormHijo(New frmPersonas())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormHijo(New frmProductos())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnOrdenReparacón_Click(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Click
        AbrirFormHijo(New frmOrdenesReparacion())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New frmVentas())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormHijo(New frmCompras())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
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

    Private Sub MenuPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Verificar si el formulario secundario está actualmente abierto en el panelContenedor
        If panelContenedor.Controls.Count > 0 AndAlso TypeOf panelContenedor.Controls(0) Is Form Then
            Dim formularioSecundario As Form = DirectCast(panelContenedor.Controls(0), Form)

            ' Verificar si el formulario principal se está maximizando
            If WindowState = FormWindowState.Maximized Then
                ' Ajustar el tamaño y la posición del formulario secundario dentro del panelContenedor
                formularioSecundario.Dock = DockStyle.Fill
            Else
                ' Restaurar el tamaño y la posición del formulario secundario dentro del panelContenedor
                formularioSecundario.Dock = DockStyle.None
                formularioSecundario.Size = New Size(panelContenedor.Width, panelContenedor.Height)
                formularioSecundario.Location = New Point(0, 0)
            End If
        End If
    End Sub

#Region "Control botones"
    Private Sub btnCompras_Leave(sender As Object, e As EventArgs) Handles btnCompras.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub btnVentas_Leave(sender As Object, e As EventArgs) Handles btnVentas.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub btnOrdenReparacón_Leave(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnProductos_Leave(sender As Object, e As EventArgs) Handles btnProductos.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnPersonas_Leave(sender As Object, e As EventArgs) Handles btnPersonas.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnVehiculos_Leave(sender As Object, e As EventArgs) Handles btnVehiculos.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub
#End Region

End Class
