Imports System.Data.SqlClient
Public Class FrmLogin
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Dim isValid As Boolean

    Private Sub Validator()
        isValid = True
        If TxtUsuario.Text.Trim().Length = 0 Then
            MessageBox.Show("Ingresar nombre de usuario!")
            TxtUsuario.Focus()
            isValid = False
            Return
        End If

        If TxtContraseña.Text.Trim().Length = 0 Then
            MessageBox.Show("Ingresar clave de acceso!")
            TxtContraseña.Focus()
            isValid = False
            Return
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIngresar.PerformClick()
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtContraseña.Focus()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Application.Exit()
        Else
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            con.Open()
            Dim reader As SqlClient.SqlDataReader
            Dim query As String = "SELECT *
                          FROM Usuario
                          WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña AND EstadoActivo = 1"

            Dim cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
            cmd.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text)

            reader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim nombreUsuario As String = reader("IdUsuario").ToString()
                Me.Dispose()
                FrmMenu.ShowDialog()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al acceder a la base de datos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class