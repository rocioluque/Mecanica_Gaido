Public Class frmPersonas
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) 
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) 
        frmVehiculos.Show()
        Me.Close()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) 
        frmProductos.Show()
        Me.Close()
    End Sub

    Private Sub btnOrdenReparacón_Click(sender As Object, e As EventArgs) 
        frmOrdenesReparacion.Show()
        Me.Close()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) 
        frmVentas.Show()
        Me.Close()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) 
        frmCompras.Show()
        Me.Close()
    End Sub

End Class