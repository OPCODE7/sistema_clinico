Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient

Public Class FrmReportePacientes
    Private Sub FrmReportePacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pacientesDT As New DataTable()


        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_PACIENTES_ATENDIDOS", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 4096
            Dim pacientesTA As New SqlDataAdapter(cmd)
            pacientesTA.Fill(pacientesDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReportePacientesAtendidos.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", pacientesDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class