<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.grdGrilla = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFila = New System.Windows.Forms.TextBox()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtAlternativo = New System.Windows.Forms.RadioButton()
        Me.rbtOriginal = New System.Windows.Forms.RadioButton()
        Me.cboRepuestos = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboOriginal = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtNombrediario = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtStockreal = New System.Windows.Forms.TextBox()
        Me.txtFecha1 = New System.Windows.Forms.TextBox()
        Me.txtStockdisponible = New System.Windows.Forms.TextBox()
        Me.txtEstanteria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(123, 350)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 96
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(204, 350)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 95
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(42, 350)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 94
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'grdGrilla
        '
        Me.grdGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla.Location = New System.Drawing.Point(42, 379)
        Me.grdGrilla.Name = "grdGrilla"
        Me.grdGrilla.Size = New System.Drawing.Size(773, 150)
        Me.grdGrilla.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Estado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(449, 286)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(59, 17)
        Me.chkActivo.TabIndex = 91
        Me.chkActivo.Text = "Activo."
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(354, 259)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Origen:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(354, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Cod. Estanteria:"
        '
        'txtFila
        '
        Me.txtFila.Location = New System.Drawing.Point(449, 178)
        Me.txtFila.Name = "txtFila"
        Me.txtFila.Size = New System.Drawing.Size(121, 20)
        Me.txtFila.TabIndex = 88
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(449, 204)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(121, 20)
        Me.txtBarra.TabIndex = 87
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(449, 230)
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(121, 20)
        Me.txtFabricante.TabIndex = 86
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(449, 256)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(121, 20)
        Me.txtOrigen.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(354, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Fecha. Ult. Vent:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(92, 13)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Fecha. Ult. Comp:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(354, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Codigo de Barra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Cod. Fabricante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Numero de Fila:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Precio Compra:"
        '
        'rbtAlternativo
        '
        Me.rbtAlternativo.AutoSize = True
        Me.rbtAlternativo.Location = New System.Drawing.Point(149, 208)
        Me.rbtAlternativo.Name = "rbtAlternativo"
        Me.rbtAlternativo.Size = New System.Drawing.Size(75, 17)
        Me.rbtAlternativo.TabIndex = 78
        Me.rbtAlternativo.TabStop = True
        Me.rbtAlternativo.Text = "Alternativo"
        Me.rbtAlternativo.UseVisualStyleBackColor = True
        '
        'rbtOriginal
        '
        Me.rbtOriginal.AutoSize = True
        Me.rbtOriginal.Location = New System.Drawing.Point(149, 185)
        Me.rbtOriginal.Name = "rbtOriginal"
        Me.rbtOriginal.Size = New System.Drawing.Size(60, 17)
        Me.rbtOriginal.TabIndex = 77
        Me.rbtOriginal.TabStop = True
        Me.rbtOriginal.Text = "Original"
        Me.rbtOriginal.UseVisualStyleBackColor = True
        '
        'cboRepuestos
        '
        Me.cboRepuestos.FormattingEnabled = True
        Me.cboRepuestos.Location = New System.Drawing.Point(134, 52)
        Me.cboRepuestos.Name = "cboRepuestos"
        Me.cboRepuestos.Size = New System.Drawing.Size(121, 21)
        Me.cboRepuestos.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Stock Disponible:"
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(449, 74)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(121, 20)
        Me.txtLista.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 286)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Stock Real:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Canti. Por Bulto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Precio Lista:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "ID_Rubro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ID_Marca:"
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(134, 131)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(121, 21)
        Me.cboMarca.TabIndex = 68
        '
        'cboOriginal
        '
        Me.cboOriginal.FormattingEnabled = True
        Me.cboOriginal.Location = New System.Drawing.Point(134, 231)
        Me.cboOriginal.Name = "cboOriginal"
        Me.cboOriginal.Size = New System.Drawing.Size(121, 21)
        Me.cboOriginal.TabIndex = 67
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 79)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(121, 20)
        Me.txtDescripcion.TabIndex = 66
        '
        'txtCompra
        '
        Me.txtCompra.Location = New System.Drawing.Point(449, 48)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(121, 20)
        Me.txtCompra.TabIndex = 65
        '
        'txtNombrediario
        '
        Me.txtNombrediario.Location = New System.Drawing.Point(134, 105)
        Me.txtNombrediario.Name = "txtNombrediario"
        Me.txtNombrediario.Size = New System.Drawing.Size(121, 20)
        Me.txtNombrediario.TabIndex = 64
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(449, 100)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(121, 20)
        Me.txtFecha.TabIndex = 63
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(134, 258)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidad.TabIndex = 62
        '
        'txtStockreal
        '
        Me.txtStockreal.Location = New System.Drawing.Point(134, 283)
        Me.txtStockreal.Name = "txtStockreal"
        Me.txtStockreal.Size = New System.Drawing.Size(121, 20)
        Me.txtStockreal.TabIndex = 61
        '
        'txtFecha1
        '
        Me.txtFecha1.Location = New System.Drawing.Point(449, 126)
        Me.txtFecha1.Name = "txtFecha1"
        Me.txtFecha1.Size = New System.Drawing.Size(121, 20)
        Me.txtFecha1.TabIndex = 60
        '
        'txtStockdisponible
        '
        Me.txtStockdisponible.Location = New System.Drawing.Point(134, 311)
        Me.txtStockdisponible.Name = "txtStockdisponible"
        Me.txtStockdisponible.Size = New System.Drawing.Size(121, 20)
        Me.txtStockdisponible.TabIndex = 59
        '
        'txtEstanteria
        '
        Me.txtEstanteria.Location = New System.Drawing.Point(449, 152)
        Me.txtEstanteria.Name = "txtEstanteria"
        Me.txtEstanteria.Size = New System.Drawing.Size(121, 20)
        Me.txtEstanteria.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Original/Alternativo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descripcion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Nombre Diario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "ID_Original:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(39, 55)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(73, 13)
        Me.lbl1.TabIndex = 53
        Me.lbl1.Text = "ID_Repuesto:"
        '
        'cboRubro
        '
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(134, 158)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(121, 21)
        Me.cboRubro.TabIndex = 52
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(955, 620)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.grdGrilla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFila)
        Me.Controls.Add(Me.txtBarra)
        Me.Controls.Add(Me.txtFabricante)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtAlternativo)
        Me.Controls.Add(Me.rbtOriginal)
        Me.Controls.Add(Me.cboRepuestos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.cboOriginal)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.txtNombrediario)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtStockreal)
        Me.Controls.Add(Me.txtFecha1)
        Me.Controls.Add(Me.txtStockdisponible)
        Me.Controls.Add(Me.txtEstanteria)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cboRubro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProductos"
        CType(Me.grdGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents grdGrilla As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFila As TextBox
    Friend WithEvents txtBarra As TextBox
    Friend WithEvents txtFabricante As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtAlternativo As RadioButton
    Friend WithEvents rbtOriginal As RadioButton
    Friend WithEvents cboRepuestos As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLista As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents cboOriginal As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtNombrediario As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtStockreal As TextBox
    Friend WithEvents txtFecha1 As TextBox
    Friend WithEvents txtStockdisponible As TextBox
    Friend WithEvents txtEstanteria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents cboRubro As ComboBox
End Class
