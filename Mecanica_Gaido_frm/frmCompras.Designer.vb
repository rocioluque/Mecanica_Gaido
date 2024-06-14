<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.grbGrilla = New System.Windows.Forms.DataGridView()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtOtrosimp = New System.Windows.Forms.TextBox()
        Me.txtIvamonto = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtNumcomp = New System.Windows.Forms.TextBox()
        Me.txtFechacompra = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbFormapago = New System.Windows.Forms.ComboBox()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grbGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbGrilla
        '
        Me.grbGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grbGrilla.Location = New System.Drawing.Point(46, 321)
        Me.grbGrilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grbGrilla.Name = "grbGrilla"
        Me.grbGrilla.RowHeadersWidth = 51
        Me.grbGrilla.RowTemplate.Height = 24
        Me.grbGrilla.Size = New System.Drawing.Size(838, 206)
        Me.grbGrilla.TabIndex = 45
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(399, 264)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 44
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(524, 224)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtTotal.TabIndex = 43
        '
        'txtOtrosimp
        '
        Me.txtOtrosimp.Location = New System.Drawing.Point(524, 179)
        Me.txtOtrosimp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOtrosimp.Name = "txtOtrosimp"
        Me.txtOtrosimp.Size = New System.Drawing.Size(92, 20)
        Me.txtOtrosimp.TabIndex = 42
        '
        'txtIvamonto
        '
        Me.txtIvamonto.Location = New System.Drawing.Point(524, 134)
        Me.txtIvamonto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIvamonto.Name = "txtIvamonto"
        Me.txtIvamonto.Size = New System.Drawing.Size(92, 20)
        Me.txtIvamonto.TabIndex = 41
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(524, 89)
        Me.txtIva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(92, 20)
        Me.txtIva.TabIndex = 40
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(524, 44)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(92, 20)
        Me.txtSubtotal.TabIndex = 39
        '
        'txtNumcomp
        '
        Me.txtNumcomp.Location = New System.Drawing.Point(165, 134)
        Me.txtNumcomp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumcomp.Name = "txtNumcomp"
        Me.txtNumcomp.Size = New System.Drawing.Size(92, 20)
        Me.txtNumcomp.TabIndex = 38
        '
        'txtFechacompra
        '
        Me.txtFechacompra.Location = New System.Drawing.Point(165, 89)
        Me.txtFechacompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechacompra.Name = "txtFechacompra"
        Me.txtFechacompra.Size = New System.Drawing.Size(92, 20)
        Me.txtFechacompra.TabIndex = 37
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(165, 44)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(92, 20)
        Me.txtID.TabIndex = 36
        '
        'cmbFormapago
        '
        Me.cmbFormapago.FormattingEnabled = True
        Me.cmbFormapago.Location = New System.Drawing.Point(165, 223)
        Me.cmbFormapago.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFormapago.Name = "cmbFormapago"
        Me.cmbFormapago.Size = New System.Drawing.Size(92, 21)
        Me.cmbFormapago.TabIndex = 35
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(165, 179)
        Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(92, 21)
        Me.cmbProveedor.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(396, 227)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(396, 182)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Otros impuestos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(398, 137)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "IVA monto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(396, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(396, 47)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 227)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Forma de pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Proveedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "N° Comprobante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID"
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(939, 581)
        Me.Controls.Add(Me.grbGrilla)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtOtrosimp)
        Me.Controls.Add(Me.txtIvamonto)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtNumcomp)
        Me.Controls.Add(Me.txtFechacompra)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmbFormapago)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCompras"
        CType(Me.grbGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbGrilla As DataGridView
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtOtrosimp As TextBox
    Friend WithEvents txtIvamonto As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtNumcomp As TextBox
    Friend WithEvents txtFechacompra As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbFormapago As ComboBox
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
