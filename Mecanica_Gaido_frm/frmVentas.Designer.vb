<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.grdGrilla = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOtroimp = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNrocomprobante = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.cboPago = New System.Windows.Forms.ComboBox()
        Me.cboFormato = New System.Windows.Forms.ComboBox()
        Me.cboTipoventa = New System.Windows.Forms.ComboBox()
        Me.cboVentas = New System.Windows.Forms.ComboBox()
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(347, 241)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 99
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(428, 241)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 98
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(509, 241)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 97
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(266, 241)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 96
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'grdGrilla
        '
        Me.grdGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla.Location = New System.Drawing.Point(266, 270)
        Me.grdGrilla.Name = "grdGrilla"
        Me.grdGrilla.Size = New System.Drawing.Size(553, 206)
        Me.grdGrilla.TabIndex = 95
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 368)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Estado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(139, 368)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(59, 17)
        Me.chkActivo.TabIndex = 93
        Me.chkActivo.Text = "Activo."
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "ID_Formto Entrega"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 317)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "ID_Tipo de venta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Subtotal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "IVA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Otros Impuestos:"
        '
        'txtOtroimp
        '
        Me.txtOtroimp.Location = New System.Drawing.Point(139, 262)
        Me.txtOtroimp.Name = "txtOtroimp"
        Me.txtOtroimp.Size = New System.Drawing.Size(121, 20)
        Me.txtOtroimp.TabIndex = 86
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(139, 288)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "ID_Empleado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "ID_Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "ID_FormaPago:"
        '
        'txtNrocomprobante
        '
        Me.txtNrocomprobante.Location = New System.Drawing.Point(139, 103)
        Me.txtNrocomprobante.Name = "txtNrocomprobante"
        Me.txtNrocomprobante.Size = New System.Drawing.Size(121, 20)
        Me.txtNrocomprobante.TabIndex = 81
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(139, 210)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 20)
        Me.txtSubtotal.TabIndex = 80
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(139, 236)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(121, 20)
        Me.txtIVA.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Nro. Comprobante:"
        '
        'txtFechaventa
        '
        Me.txtFechaventa.Location = New System.Drawing.Point(139, 77)
        Me.txtFechaventa.Name = "txtFechaventa"
        Me.txtFechaventa.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaventa.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "ID_Ventas:"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(139, 156)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleado.TabIndex = 74
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(139, 129)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 73
        '
        'cboPago
        '
        Me.cboPago.FormattingEnabled = True
        Me.cboPago.Location = New System.Drawing.Point(139, 183)
        Me.cboPago.Name = "cboPago"
        Me.cboPago.Size = New System.Drawing.Size(121, 21)
        Me.cboPago.TabIndex = 72
        '
        'cboFormato
        '
        Me.cboFormato.FormattingEnabled = True
        Me.cboFormato.Location = New System.Drawing.Point(139, 341)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Size = New System.Drawing.Size(121, 21)
        Me.cboFormato.TabIndex = 71
        '
        'cboTipoventa
        '
        Me.cboTipoventa.FormattingEnabled = True
        Me.cboTipoventa.Location = New System.Drawing.Point(139, 314)
        Me.cboTipoventa.Name = "cboTipoventa"
        Me.cboTipoventa.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoventa.TabIndex = 70
        '
        'cboVentas
        '
        Me.cboVentas.FormattingEnabled = True
        Me.cboVentas.Location = New System.Drawing.Point(139, 50)
        Me.cboVentas.Name = "cboVentas"
        Me.cboVentas.Size = New System.Drawing.Size(121, 21)
        Me.cboVentas.TabIndex = 69
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(939, 581)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.grdGrilla)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOtroimp)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNrocomprobante)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.cboPago)
        Me.Controls.Add(Me.cboFormato)
        Me.Controls.Add(Me.cboTipoventa)
        Me.Controls.Add(Me.cboVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVentas"
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents grdGrilla As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOtroimp As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNrocomprobante As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaventa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents cboPago As ComboBox
    Friend WithEvents cboFormato As ComboBox
    Friend WithEvents cboTipoventa As ComboBox
    Friend WithEvents cboVentas As ComboBox
End Class
