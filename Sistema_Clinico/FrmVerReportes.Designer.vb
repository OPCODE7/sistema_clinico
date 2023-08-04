<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerReportes
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
        Me.BtnPrescripcion = New System.Windows.Forms.Button()
        Me.BtnReportePacientes = New System.Windows.Forms.Button()
        Me.BtnInventarioMedic = New System.Windows.Forms.Button()
        Me.BtnReporteHistorialClinico = New System.Windows.Forms.Button()
        Me.BtnReporteEquipoMedico = New System.Windows.Forms.Button()
        Me.BtnReporteCitaMedica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPrescripcion
        '
        Me.BtnPrescripcion.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnPrescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPrescripcion.Location = New System.Drawing.Point(105, 406)
        Me.BtnPrescripcion.Name = "BtnPrescripcion"
        Me.BtnPrescripcion.Size = New System.Drawing.Size(129, 50)
        Me.BtnPrescripcion.TabIndex = 11
        Me.BtnPrescripcion.Text = "Prescripcion Medica"
        Me.BtnPrescripcion.UseVisualStyleBackColor = False
        '
        'BtnReportePacientes
        '
        Me.BtnReportePacientes.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnReportePacientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportePacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReportePacientes.Location = New System.Drawing.Point(105, 339)
        Me.BtnReportePacientes.Name = "BtnReportePacientes"
        Me.BtnReportePacientes.Size = New System.Drawing.Size(129, 50)
        Me.BtnReportePacientes.TabIndex = 10
        Me.BtnReportePacientes.Text = "Pacientes"
        Me.BtnReportePacientes.UseVisualStyleBackColor = False
        '
        'BtnInventarioMedic
        '
        Me.BtnInventarioMedic.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnInventarioMedic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventarioMedic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInventarioMedic.Location = New System.Drawing.Point(105, 262)
        Me.BtnInventarioMedic.Name = "BtnInventarioMedic"
        Me.BtnInventarioMedic.Size = New System.Drawing.Size(129, 50)
        Me.BtnInventarioMedic.TabIndex = 9
        Me.BtnInventarioMedic.Text = "Inventario Medicamentos"
        Me.BtnInventarioMedic.UseVisualStyleBackColor = False
        '
        'BtnReporteHistorialClinico
        '
        Me.BtnReporteHistorialClinico.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnReporteHistorialClinico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteHistorialClinico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReporteHistorialClinico.Location = New System.Drawing.Point(105, 195)
        Me.BtnReporteHistorialClinico.Name = "BtnReporteHistorialClinico"
        Me.BtnReporteHistorialClinico.Size = New System.Drawing.Size(129, 50)
        Me.BtnReporteHistorialClinico.TabIndex = 8
        Me.BtnReporteHistorialClinico.Text = "Historial Clinico"
        Me.BtnReporteHistorialClinico.UseVisualStyleBackColor = False
        '
        'BtnReporteEquipoMedico
        '
        Me.BtnReporteEquipoMedico.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnReporteEquipoMedico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteEquipoMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReporteEquipoMedico.Location = New System.Drawing.Point(105, 127)
        Me.BtnReporteEquipoMedico.Name = "BtnReporteEquipoMedico"
        Me.BtnReporteEquipoMedico.Size = New System.Drawing.Size(129, 50)
        Me.BtnReporteEquipoMedico.TabIndex = 7
        Me.BtnReporteEquipoMedico.Text = "Equipo Medico"
        Me.BtnReporteEquipoMedico.UseVisualStyleBackColor = False
        '
        'BtnReporteCitaMedica
        '
        Me.BtnReporteCitaMedica.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnReporteCitaMedica.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteCitaMedica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReporteCitaMedica.Location = New System.Drawing.Point(105, 56)
        Me.BtnReporteCitaMedica.Name = "BtnReporteCitaMedica"
        Me.BtnReporteCitaMedica.Size = New System.Drawing.Size(129, 50)
        Me.BtnReporteCitaMedica.TabIndex = 6
        Me.BtnReporteCitaMedica.Text = "Cita Medica"
        Me.BtnReporteCitaMedica.UseVisualStyleBackColor = False
        '
        'FrmVerReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 512)
        Me.Controls.Add(Me.BtnPrescripcion)
        Me.Controls.Add(Me.BtnReportePacientes)
        Me.Controls.Add(Me.BtnInventarioMedic)
        Me.Controls.Add(Me.BtnReporteHistorialClinico)
        Me.Controls.Add(Me.BtnReporteEquipoMedico)
        Me.Controls.Add(Me.BtnReporteCitaMedica)
        Me.Name = "FrmVerReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPrescripcion As Button
    Friend WithEvents BtnReportePacientes As Button
    Friend WithEvents BtnInventarioMedic As Button
    Friend WithEvents BtnReporteHistorialClinico As Button
    Friend WithEvents BtnReporteEquipoMedico As Button
    Friend WithEvents BtnReporteCitaMedica As Button
End Class
