Imports System.Data.SqlClient

Public Class FrmVerPacientes
    Private Sub FrmVerPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPacientes()
    End Sub

    Private Sub getPacientes()
        Dim ConSql = New SqlConnection(My.Settings.SistemaClinico)
        Dim cmd = New SqlCommand("SP_LISTAR_PACIENTES", ConSql)

        cmd.CommandType = CommandType.StoredProcedure

        ConSql.Open()

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        DgvPacientes.AllowUserToAddRows = False
        DgvPacientes.Rows.Clear()


        While reader.Read
            DgvPacientes.Rows.Add(reader.Item("IdPaciente"), reader.Item("NombrePaciente") + " " + reader.Item("ApellidoPaciente"), reader.Item("Telefono"), reader.Item("Direccion"))

        End While
        reader.Close()

    End Sub

    Private Sub DgvPacientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvPacientes.CellMouseDoubleClick
        If DgvPacientes.Rows.Count > 0 Then
            FrmReporteHistorialClinico.idPacienteSelected = DgvPacientes.CurrentRow.Cells(0).Value.ToString()
            Me.Hide()
            FrmReporteHistorialClinico.ShowDialog()

        End If
    End Sub
End Class