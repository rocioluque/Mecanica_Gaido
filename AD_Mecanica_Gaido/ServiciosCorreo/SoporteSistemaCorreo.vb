Public Class SoporteSistemaCorreo
    Inherits ServidorCorreo

    Public Sub New()
        remitenteCorreo = "soportemecanicagaido@gmail.com"
        contraseña = "MecanicaGaido2024"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
    End Sub

    Public Sub Notificaciones()

    End Sub

    Public Sub errores()

    End Sub
End Class
