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
        Me.grdVentas = New System.Windows.Forms.DataGridView()
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
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(561, 47)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 99
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(642, 47)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 98
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(723, 47)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 97
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(480, 47)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 96
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'grdVentas
        '
        Me.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVentas.Location = New System.Drawing.Point(141, 344)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.ReadOnly = True
        Me.grdVentas.Size = New System.Drawing.Size(553, 206)
        Me.grdVentas.TabIndex = 95
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(425, 259)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Estado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(141, 271)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(73, 21)
        Me.chkActivo.TabIndex = 93
        Me.chkActivo.Text = "Activo."
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(422, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "ID_Formto Entrega"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(425, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "ID_Tipo de venta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(425, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(425, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Subtotal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(425, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "IVA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(425, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Otros Impuestos:"
        '
        'txtOtroimp
        '
        Me.txtOtroimp.Location = New System.Drawing.Point(578, 179)
        Me.txtOtroimp.Name = "txtOtroimp"
        Me.txtOtroimp.Size = New System.Drawing.Size(121, 20)
        Me.txtOtroimp.TabIndex = 86
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(578, 205)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(106, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "ID_Empleado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(105, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "ID_Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(106, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "ID_FormaPago:"
        '
        'txtNrocomprobante
        '
        Me.txtNrocomprobante.Location = New System.Drawing.Point(259, 100)
        Me.txtNrocomprobante.Name = "txtNrocomprobante"
        Me.txtNrocomprobante.Size = New System.Drawing.Size(121, 20)
        Me.txtNrocomprobante.TabIndex = 81
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(578, 127)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 20)
        Me.txtSubtotal.TabIndex = 80
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(578, 153)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(121, 20)
        Me.txtIVA.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(105, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Nro. Comprobante:"
        '
        'txtFechaventa
        '
        Me.txtFechaventa.Location = New System.Drawing.Point(259, 74)
        Me.txtFechaventa.Name = "txtFechaventa"
        Me.txtFechaventa.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaventa.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "ID_Ventas:"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(259, 153)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleado.TabIndex = 74
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(259, 126)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCliente.TabIndex = 73
        '
        'cboPago
        '
        Me.cboPago.FormattingEnabled = True
        Me.cboPago.Location = New System.Drawing.Point(578, 100)
        Me.cboPago.Name = "cboPago"
        Me.cboPago.Size = New System.Drawing.Size(121, 21)
        Me.cboPago.TabIndex = 72
        '
        'cboFormato
        '
        Me.cboFormato.FormattingEnabled = True
        Me.cboFormato.Location = New System.Drawing.Point(578, 258)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Size = New System.Drawing.Size(121, 21)
        Me.cboFormato.TabIndex = 71
        '
        'cboTipoventa
        '
        Me.cboTipoventa.FormattingEnabled = True
        Me.cboTipoventa.Location = New System.Drawing.Point(578, 231)
        Me.cboTipoventa.Name = "cboTipoventa"
        Me.cboTipoventa.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoventa.TabIndex = 70
        '
        'cboVentas
        '
        Me.cboVentas.FormattingEnabled = True
        Me.cboVentas.Location = New System.Drawing.Point(259, 47)
        Me.cboVentas.Name = "cboVentas"
        Me.cboVentas.Size = New System.Drawing.Size(121, 21)
        Me.cboVentas.TabIndex = 69
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(939, 581)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.grdVentas)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents grdVentas As DataGridView
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
