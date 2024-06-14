<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesReparacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesReparacion))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.grdGrilla = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaentrada = New System.Windows.Forms.TextBox()
        Me.txtFechaturno = New System.Windows.Forms.TextBox()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.cboOrdenes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboServicios = New System.Windows.Forms.ComboBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.txtSeñas = New System.Windows.Forms.TextBox()
        Me.txtFechaestimada = New System.Windows.Forms.TextBox()
        Me.txtFechasalida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(330, 308)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 93
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(411, 308)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 92
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(492, 308)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 91
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(249, 308)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 90
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'grdGrilla
        '
        Me.grdGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla.Location = New System.Drawing.Point(30, 337)
        Me.grdGrilla.Name = "grdGrilla"
        Me.grdGrilla.Size = New System.Drawing.Size(784, 150)
        Me.grdGrilla.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Estado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(122, 314)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(59, 17)
        Me.chkActivo.TabIndex = 87
        Me.chkActivo.Text = "Activo."
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "ID_Serv.Terceros:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Fecha Salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fech.Est.Salida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Fecha Entrada:"
        '
        'txtFechaentrada
        '
        Me.txtFechaentrada.Location = New System.Drawing.Point(122, 182)
        Me.txtFechaentrada.Name = "txtFechaentrada"
        Me.txtFechaentrada.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaentrada.TabIndex = 82
        '
        'txtFechaturno
        '
        Me.txtFechaturno.Location = New System.Drawing.Point(122, 156)
        Me.txtFechaturno.Name = "txtFechaturno"
        Me.txtFechaturno.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaturno.TabIndex = 81
        '
        'cboVehiculo
        '
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(122, 77)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.cboVehiculo.TabIndex = 80
        '
        'cboOrdenes
        '
        Me.cboOrdenes.FormattingEnabled = True
        Me.cboOrdenes.Location = New System.Drawing.Point(122, 51)
        Me.cboOrdenes.Name = "cboOrdenes"
        Me.cboOrdenes.Size = New System.Drawing.Size(121, 21)
        Me.cboOrdenes.TabIndex = 79
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "ID_Cliente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Fecha Turno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Mot. Reparacion:"
        '
        'cboServicios
        '
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(122, 287)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(121, 21)
        Me.cboServicios.TabIndex = 75
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(122, 260)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 74
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(122, 130)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(121, 20)
        Me.txtMotivo.TabIndex = 73
        '
        'txtSeñas
        '
        Me.txtSeñas.Location = New System.Drawing.Point(122, 104)
        Me.txtSeñas.Name = "txtSeñas"
        Me.txtSeñas.Size = New System.Drawing.Size(121, 20)
        Me.txtSeñas.TabIndex = 72
        '
        'txtFechaestimada
        '
        Me.txtFechaestimada.Location = New System.Drawing.Point(122, 208)
        Me.txtFechaestimada.Name = "txtFechaestimada"
        Me.txtFechaestimada.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaestimada.TabIndex = 71
        '
        'txtFechasalida
        '
        Me.txtFechasalida.Location = New System.Drawing.Point(122, 234)
        Me.txtFechasalida.Name = "txtFechasalida"
        Me.txtFechasalida.Size = New System.Drawing.Size(121, 20)
        Me.txtFechasalida.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "ID_Vehiculo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Señas Particulares:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(27, 54)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(69, 13)
        Me.lbl1.TabIndex = 67
        Me.lbl1.Text = "ID_Ord/Rep:"
        '
        'frmOrdenesReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(955, 620)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.grdGrilla)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaentrada)
        Me.Controls.Add(Me.txtFechaturno)
        Me.Controls.Add(Me.cboVehiculo)
        Me.Controls.Add(Me.cboOrdenes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboServicios)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.txtSeñas)
        Me.Controls.Add(Me.txtFechaestimada)
        Me.Controls.Add(Me.txtFechasalida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrdenesReparacion"
        Me.Text = "frmOrdenReparacio"
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents grdGrilla As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaentrada As TextBox
    Friend WithEvents txtFechaturno As TextBox
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents cboOrdenes As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboServicios As ComboBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents txtSeñas As TextBox
    Friend WithEvents txtFechaestimada As TextBox
    Friend WithEvents txtFechasalida As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl1 As Label
End Class
