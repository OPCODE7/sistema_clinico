Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient

Public Class FrmReporteCita
    Private Sub FrmReporteCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim citaDT As New DataTable()
        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_CITA", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ESTADO", "NULL")
            cmd.CommandTimeout = 4096
            Dim citaTA As New SqlDataAdapter(cmd)
            citaTA.Fill(citaDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReporteCitaMedica.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", citaDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CmbStatusCita_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbStatusCita.SelectedValueChanged
        Dim citaDT As New DataTable()
        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_CITA", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ESTADO", CmbStatusCita.SelectedItem.ToString())
            cmd.CommandTimeout = 4096
            Dim citaTA As New SqlDataAdapter(cmd)
            citaTA.Fill(citaDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReporteCitaMedica.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", citaDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class