Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient

Public Class FrmReporteHistorialClinico
    Public idPacienteSelected As String
    Private Sub FrmReporteHistorialClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim historialDT As New DataTable()

        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_HISTORIAL_CLINICO", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdPaciente", idPacienteSelected)
            cmd.CommandTimeout = 4096
            Dim historialTA As New SqlDataAdapter(cmd)
            historialTA.Fill(historialDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReporteHistorialClinico.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", historialDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class