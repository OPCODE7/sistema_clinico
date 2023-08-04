<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerPacientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvPacientes = New System.Windows.Forms.DataGridView()
        Me.ID_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_PACIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Doble Click En Cualquier Celda Para Ver Historial Clinico del Paciente"
        '
        'DgvPacientes
        '
        Me.DgvPacientes.AllowUserToAddRows = False
        Me.DgvPacientes.AllowUserToDeleteRows = False
        Me.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_USUARIO, Me.NOMBRE_PACIENTE, Me.TELEFONO, Me.DIRECCION})
        Me.DgvPacientes.Location = New System.Drawing.Point(59, 12)
        Me.DgvPacientes.Name = "DgvPacientes"
        Me.DgvPacientes.ReadOnly = True
        Me.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacientes.Size = New System.Drawing.Size(645, 434)
        Me.DgvPacientes.TabIndex = 2
        '
        'ID_USUARIO
        '
        Me.ID_USUARIO.HeaderText = "ID"
        Me.ID_USUARIO.Name = "ID_USUARIO"
        Me.ID_USUARIO.ReadOnly = True
        '
        'NOMBRE_PACIENTE
        '
        Me.NOMBRE_PACIENTE.HeaderText = "NOMBRE"
        Me.NOMBRE_PACIENTE.Name = "NOMBRE_PACIENTE"
        Me.NOMBRE_PACIENTE.ReadOnly = True
        Me.NOMBRE_PACIENTE.Width = 200
        '
        'TELEFONO
        '
        Me.TELEFONO.HeaderText = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.ReadOnly = True
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Width = 200
        '
        'FrmVerPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 492)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvPacientes)
        Me.Name = "FrmVerPacientes"
        Me.Text = "FrmVerPacientes"
        CType(Me.DgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DgvPacientes As DataGridView
    Friend WithEvents ID_USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_PACIENTE As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
End Class
