<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFactura))
        Me.PanelFactura = New System.Windows.Forms.Panel()
        Me.PanelTexto = New System.Windows.Forms.Panel()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.PanelConte = New System.Windows.Forms.Panel()
        Me.PanelMante = New System.Windows.Forms.Panel()
        Me.GroupFactura = New System.Windows.Forms.GroupBox()
        Me.CbmMedicamentos = New System.Windows.Forms.ComboBox()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupPaciente = New System.Windows.Forms.GroupBox()
        Me.BuscarPaciente = New System.Windows.Forms.PictureBox()
        Me.CbmDescuento = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.TxtIdPaciente = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDevolucion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DgvDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medicamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelFactura.SuspendLayout()
        Me.PanelTexto.SuspendLayout()
        Me.PanelConte.SuspendLayout()
        Me.PanelMante.SuspendLayout()
        Me.GroupFactura.SuspendLayout()
        Me.GroupPaciente.SuspendLayout()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFactura
        '
        Me.PanelFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFactura.BackColor = System.Drawing.Color.White
        Me.PanelFactura.Controls.Add(Me.PanelTexto)
        Me.PanelFactura.Controls.Add(Me.PanelConte)
        Me.PanelFactura.Location = New System.Drawing.Point(-1, 0)
        Me.PanelFactura.Name = "PanelFactura"
        Me.PanelFactura.Size = New System.Drawing.Size(871, 732)
        Me.PanelFactura.TabIndex = 29
        '
        'PanelTexto
        '
        Me.PanelTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTexto.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTexto.Controls.Add(Me.LblTexto)
        Me.PanelTexto.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTexto.Location = New System.Drawing.Point(2, 2)
        Me.PanelTexto.Name = "PanelTexto"
        Me.PanelTexto.Size = New System.Drawing.Size(869, 57)
        Me.PanelTexto.TabIndex = 27
        '
        'LblTexto
        '
        Me.LblTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTexto.Location = New System.Drawing.Point(398, 17)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(73, 24)
        Me.LblTexto.TabIndex = 26
        Me.LblTexto.Text = "Factura"
        '
        'PanelConte
        '
        Me.PanelConte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelConte.BackColor = System.Drawing.Color.Transparent
        Me.PanelConte.Controls.Add(Me.PanelMante)
        Me.PanelConte.Location = New System.Drawing.Point(0, 56)
        Me.PanelConte.Name = "PanelConte"
        Me.PanelConte.Size = New System.Drawing.Size(871, 676)
        Me.PanelConte.TabIndex = 29
        '
        'PanelMante
        '
        Me.PanelMante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMante.BackColor = System.Drawing.Color.Transparent
        Me.PanelMante.Controls.Add(Me.GroupFactura)
        Me.PanelMante.Location = New System.Drawing.Point(0, 0)
        Me.PanelMante.Name = "PanelMante"
        Me.PanelMante.Size = New System.Drawing.Size(871, 676)
        Me.PanelMante.TabIndex = 0
        '
        'GroupFactura
        '
        Me.GroupFactura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupFactura.BackColor = System.Drawing.Color.Transparent
        Me.GroupFactura.Controls.Add(Me.CbmMedicamentos)
        Me.GroupFactura.Controls.Add(Me.BtnFinalizar)
        Me.GroupFactura.Controls.Add(Me.TxtIVA)
        Me.GroupFactura.Controls.Add(Me.Label3)
        Me.GroupFactura.Controls.Add(Me.GroupPaciente)
        Me.GroupFactura.Controls.Add(Me.TxtDevolucion)
        Me.GroupFactura.Controls.Add(Me.Label16)
        Me.GroupFactura.Controls.Add(Me.TxtEfectivo)
        Me.GroupFactura.Controls.Add(Me.Label6)
        Me.GroupFactura.Controls.Add(Me.TxtTotal)
        Me.GroupFactura.Controls.Add(Me.Label5)
        Me.GroupFactura.Controls.Add(Me.TxtDescuento)
        Me.GroupFactura.Controls.Add(Me.Label15)
        Me.GroupFactura.Controls.Add(Me.TxtSubTotal)
        Me.GroupFactura.Controls.Add(Me.Label14)
        Me.GroupFactura.Controls.Add(Me.DgvDetalleFactura)
        Me.GroupFactura.Controls.Add(Me.TxtCantidad)
        Me.GroupFactura.Controls.Add(Me.Label13)
        Me.GroupFactura.Controls.Add(Me.TxtPrecio)
        Me.GroupFactura.Controls.Add(Me.Label12)
        Me.GroupFactura.Controls.Add(Me.Label10)
        Me.GroupFactura.Controls.Add(Me.Label4)
        Me.GroupFactura.Controls.Add(Me.BtnEliminar)
        Me.GroupFactura.Controls.Add(Me.BtnAgregar)
        Me.GroupFactura.Controls.Add(Me.Label1)
        Me.GroupFactura.Controls.Add(Me.TxtId)
        Me.GroupFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupFactura.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupFactura.Location = New System.Drawing.Point(25, 19)
        Me.GroupFactura.Name = "GroupFactura"
        Me.GroupFactura.Size = New System.Drawing.Size(820, 642)
        Me.GroupFactura.TabIndex = 31
        Me.GroupFactura.TabStop = False
        Me.GroupFactura.Text = "Generar factura"
        '
        'CbmMedicamentos
        '
        Me.CbmMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmMedicamentos.FormattingEnabled = True
        Me.CbmMedicamentos.Location = New System.Drawing.Point(195, 219)
        Me.CbmMedicamentos.Name = "CbmMedicamentos"
        Me.CbmMedicamentos.Size = New System.Drawing.Size(169, 28)
        Me.CbmMedicamentos.TabIndex = 119
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnFinalizar.Location = New System.Drawing.Point(623, 575)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(116, 44)
        Me.BtnFinalizar.TabIndex = 131
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = False
        '
        'TxtIVA
        '
        Me.TxtIVA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIVA.Location = New System.Drawing.Point(623, 392)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(51, 26)
        Me.TxtIVA.TabIndex = 128
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(620, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 18)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "IVA"
        '
        'GroupPaciente
        '
        Me.GroupPaciente.Controls.Add(Me.BuscarPaciente)
        Me.GroupPaciente.Controls.Add(Me.CbmDescuento)
        Me.GroupPaciente.Controls.Add(Me.Label7)
        Me.GroupPaciente.Controls.Add(Me.TxtPaciente)
        Me.GroupPaciente.Controls.Add(Me.TxtIdPaciente)
        Me.GroupPaciente.Controls.Add(Me.TxtApellidoPa)
        Me.GroupPaciente.Controls.Add(Me.Label9)
        Me.GroupPaciente.Location = New System.Drawing.Point(40, 56)
        Me.GroupPaciente.Name = "GroupPaciente"
        Me.GroupPaciente.Size = New System.Drawing.Size(745, 112)
        Me.GroupPaciente.TabIndex = 125
        Me.GroupPaciente.TabStop = False
        Me.GroupPaciente.Text = "Paciente"
        '
        'BuscarPaciente
        '
        Me.BuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarPaciente.BackColor = System.Drawing.Color.Transparent
        Me.BuscarPaciente.Image = CType(resources.GetObject("BuscarPaciente.Image"), System.Drawing.Image)
        Me.BuscarPaciente.Location = New System.Drawing.Point(70, 60)
        Me.BuscarPaciente.Name = "BuscarPaciente"
        Me.BuscarPaciente.Size = New System.Drawing.Size(30, 26)
        Me.BuscarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarPaciente.TabIndex = 118
        Me.BuscarPaciente.TabStop = False
        '
        'CbmDescuento
        '
        Me.CbmDescuento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmDescuento.FormattingEnabled = True
        Me.CbmDescuento.Location = New System.Drawing.Point(494, 58)
        Me.CbmDescuento.Name = "CbmDescuento"
        Me.CbmDescuento.Size = New System.Drawing.Size(224, 28)
        Me.CbmDescuento.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(67, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Nombre"
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPaciente.Location = New System.Drawing.Point(103, 60)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(191, 26)
        Me.TxtPaciente.TabIndex = 116
        Me.ToolTip1.SetToolTip(Me.TxtPaciente, "Ingrese el nombre del paciente")
        '
        'TxtIdPaciente
        '
        Me.TxtIdPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdPaciente.Location = New System.Drawing.Point(15, 60)
        Me.TxtIdPaciente.Name = "TxtIdPaciente"
        Me.TxtIdPaciente.Size = New System.Drawing.Size(37, 26)
        Me.TxtIdPaciente.TabIndex = 114
        '
        'TxtApellidoPa
        '
        Me.TxtApellidoPa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoPa.Location = New System.Drawing.Point(296, 60)
        Me.TxtApellidoPa.Name = "TxtApellidoPa"
        Me.TxtApellidoPa.Size = New System.Drawing.Size(180, 26)
        Me.TxtApellidoPa.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(495, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 18)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Aplicar descuento"
        '
        'TxtDevolucion
        '
        Me.TxtDevolucion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDevolucion.Location = New System.Drawing.Point(706, 528)
        Me.TxtDevolucion.Name = "TxtDevolucion"
        Me.TxtDevolucion.ReadOnly = True
        Me.TxtDevolucion.Size = New System.Drawing.Size(79, 26)
        Me.TxtDevolucion.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label16.Location = New System.Drawing.Point(703, 500)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 18)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Devolución"
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEfectivo.Location = New System.Drawing.Point(623, 528)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.ReadOnly = True
        Me.TxtEfectivo.Size = New System.Drawing.Size(77, 26)
        Me.TxtEfectivo.TabIndex = 122
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(620, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Efectivo"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotal.Location = New System.Drawing.Point(623, 460)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(77, 26)
        Me.TxtTotal.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(620, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Total"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDescuento.Location = New System.Drawing.Point(624, 322)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(77, 26)
        Me.TxtDescuento.TabIndex = 118
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(621, 294)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Descuento"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSubTotal.Location = New System.Drawing.Point(624, 247)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(77, 26)
        Me.TxtSubTotal.TabIndex = 116
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(621, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 18)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "Sub-total"
        '
        'DgvDetalleFactura
        '
        Me.DgvDetalleFactura.AllowUserToAddRows = False
        Me.DgvDetalleFactura.AllowUserToDeleteRows = False
        Me.DgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.Codigo, Me.Medicamento, Me.IVA, Me.Total})
        Me.DgvDetalleFactura.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvDetalleFactura.Location = New System.Drawing.Point(40, 320)
        Me.DgvDetalleFactura.Name = "DgvDetalleFactura"
        Me.DgvDetalleFactura.ReadOnly = True
        Me.DgvDetalleFactura.Size = New System.Drawing.Size(574, 299)
        Me.DgvDetalleFactura.TabIndex = 114
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCantidad.Location = New System.Drawing.Point(489, 221)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(91, 26)
        Me.TxtCantidad.TabIndex = 113
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(486, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 18)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrecio.Location = New System.Drawing.Point(380, 221)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(91, 26)
        Me.TxtPrecio.TabIndex = 111
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(377, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 18)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(198, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 18)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Medicamento"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(299, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 24)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Sistema Clinico"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(464, 274)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 34)
        Me.BtnEliminar.TabIndex = 99
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(329, 274)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 34)
        Me.BtnAgregar.TabIndex = 97
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(42, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Cod. Factura"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(45, 221)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(134, 26)
        Me.TxtId.TabIndex = 83
        '
        'IdPaciente
        '
        Me.IdPaciente.HeaderText = "IdPaciente"
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 80
        '
        'Medicamento
        '
        Me.Medicamento.HeaderText = "Medicamento"
        Me.Medicamento.Name = "Medicamento"
        Me.Medicamento.ReadOnly = True
        Me.Medicamento.Width = 150
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Width = 98
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 98
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 732)
        Me.Controls.Add(Me.PanelFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFactura"
        Me.Text = "FrmFactura"
        Me.PanelFactura.ResumeLayout(False)
        Me.PanelTexto.ResumeLayout(False)
        Me.PanelTexto.PerformLayout()
        Me.PanelConte.ResumeLayout(False)
        Me.PanelMante.ResumeLayout(False)
        Me.GroupFactura.ResumeLayout(False)
        Me.GroupFactura.PerformLayout()
        Me.GroupPaciente.ResumeLayout(False)
        Me.GroupPaciente.PerformLayout()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFactura As Panel
    Friend WithEvents PanelTexto As Panel
    Friend WithEvents LblTexto As Label
    Friend WithEvents PanelConte As Panel
    Friend WithEvents PanelMante As Panel
    Friend WithEvents GroupFactura As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents DgvDetalleFactura As DataGridView
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupPaciente As GroupBox
    Friend WithEvents CbmDescuento As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents TxtIdPaciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDevolucion As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtEfectivo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtApellidoPa As TextBox
    Friend WithEvents BuscarPaciente As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents CbmMedicamentos As ComboBox
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Medicamento As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
