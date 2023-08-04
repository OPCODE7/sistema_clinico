Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices
Imports System.Data.SqlClient

Public Class FrmReporteEquipoMedico
    Private Sub FrmReporteEquipoMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim equipoMedicoDT As New DataTable()


        Using con As New SqlConnection(My.Settings.SistemaClinico)
            con.Open()
            Dim cmd = New SqlCommand("SP_REPORTE_EQUIPO_MEDICO", con)

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 4096
            Dim equipoMedicoTA As New SqlDataAdapter(cmd)
            equipoMedicoTA.Fill(equipoMedicoDT)


        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "Sistema_Clinico.ReporteEquipoMedico.rdlc"
            .DataSources.Add(New ReportDataSource("DataSet1", equipoMedicoDT))

        End With


        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class