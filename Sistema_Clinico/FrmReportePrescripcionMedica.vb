Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient

Public Class FrmReportePrescripcionMedica
    Private Sub FrmReportePrescripcionMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prescripcionDT As New DataTable()


        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_PRESCRIPCION_MEDICA", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 4096
            Dim prescripcionTA As New SqlDataAdapter(cmd)
            prescripcionTA.Fill(prescripcionDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReportePrescripcionMedica.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", prescripcionDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class