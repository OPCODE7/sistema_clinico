Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient


Public Class FrmInventarioMedicamento
    Private Sub FrmInventarioMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inventarioMedicamentoDT As New DataTable()


        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_INVENTARIO_MEDICAMENTO", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 4096
            Dim inventarioTA As New SqlDataAdapter(cmd)
            inventarioTA.Fill(inventarioMedicamentoDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReporteInventarioMedicamentos.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", inventarioMedicamentoDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class