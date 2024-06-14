Public Class SoporteSistemaCorreo
    Inherits ServidorCorreo

    Public Sub New()
        remitenteCorreo = "soportemecanicagaido@gmail.com"
        contraseña = "mecanicagaido"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        inicializacionSmtpClient()
    End Sub

    Public Sub Notificaciones()

    End Sub

    Public Sub errores()

    End Sub
End Class
