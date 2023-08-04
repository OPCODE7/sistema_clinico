Public Class FrmVerReportes
    Private Sub BtnReporteCitaMedica_Click(sender As Object, e As EventArgs) Handles BtnReporteCitaMedica.Click
        FrmReporteCita.ShowDialog()
    End Sub

    Private Sub BtnReporteEquipoMedico_Click(sender As Object, e As EventArgs) Handles BtnReporteEquipoMedico.Click
        FrmEquipoMedico.ShowDialog()
    End Sub

    Private Sub BtnInventarioMedic_Click(sender As Object, e As EventArgs) Handles BtnInventarioMedic.Click
        FrmInventarioMedicamento.ShowDialog()
    End Sub

    Private Sub BtnReportePacientes_Click(sender As Object, e As EventArgs) Handles BtnReportePacientes.Click
        FrmReportePacientes.ShowDialog()
    End Sub

    Private Sub BtnPrescripcion_Click(sender As Object, e As EventArgs) Handles BtnPrescripcion.Click
        FrmReportePrescripcionMedica.ShowDialog()
    End Sub

    Private Sub BtnReporteHistorialClinico_Click(sender As Object, e As EventArgs) Handles BtnReporteHistorialClinico.Click
        FrmVerPacientes.ShowDialog()
    End Sub
End Class