Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FrmFactura
    Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtPaciente.Enabled = True
        TxtApellidoPa.Enabled = True
        CbmDescuento.Enabled = True
    End Sub

    Private Sub StartForm()
        TxtId.ReadOnly = True
        TxtId.Enabled = False

        TxtIdPaciente.Enabled = False
        TxtPaciente.Enabled = False
        TxtApellidoPa.Enabled = False
        CbmDescuento.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtPaciente.Clear()
        TxtIdPaciente.Clear()
        TxtApellidoPa.Clear()
        TxtSubTotal.Clear()
        TxtTotal.Clear()
        TxtPrecio.Clear()
        TxtDescuento.Clear()
        TxtIVA.Clear()
        TxtCantidad.Clear()
        CbmDescuento.SelectedIndex = -1
        CbmMedicamentos.SelectedIndex = -1
    End Sub

    Private Sub FillDescuento()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("Select * from Descuento", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try


        CbmDescuento.DataSource = recordset
        CbmDescuento.ValueMember = "IdDescuento"
        CbmDescuento.DisplayMember = "Descripcion"
        CbmDescuento.SelectedIndex = -1
    End Sub

    Private Sub FillMedicamento()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("Select * from Medicamentos", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try


        CbmMedicamentos.DataSource = recordset
        CbmMedicamentos.ValueMember = "Codigo"
        CbmMedicamentos.DisplayMember = "NombreMedicamento"
        CbmMedicamentos.SelectedIndex = -1
    End Sub


    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(NumFactura), 0) + 1 FROM Factura"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub PanelTexto_Paint(sender As Object, e As PaintEventArgs) Handles PanelTexto.Paint

    End Sub

    Private Sub BuscarPaciente_Click(sender As Object, e As EventArgs) Handles BuscarPaciente.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("Select Paciente.IdPaciente, Paciente.NombrePaciente, Paciente.ApellidoPaciente
                                             From Paciente
                                             WHERE NombrePaciente = '" & TxtPaciente.Text & "'", con)

        reader = cmd.ExecuteReader


        If reader.Read Then
            MessageBox.Show("Información encontrada")

            TxtIdPaciente.Text = reader("IdPaciente").ToString()
            TxtPaciente.Text = reader("NombrePaciente").ToString()
            TxtApellidoPa.Text = reader("ApellidoPaciente").ToString()

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Function ObtenerPaciente(textoBusqueda As String) As List(Of String)
        Dim sugerencias As New List(Of String)()

        Dim query As String = "SELECT NombrePaciente FROM Paciente WHERE NombrePaciente LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombrePaciente").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return sugerencias
    End Function

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged
        Dim textoBusqueda As String = TxtPaciente.Text

        ' Realizar la consulta a la base de datos para obtener las sugerencias
        Dim sugerencias As List(Of String) = ObtenerPaciente(textoBusqueda)

        ' Configurar las sugerencias en el control TextBox utilizando AutoComplete
        TxtPaciente.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Crear una colección de sugerencias
        Dim fuenteSugerencias As New AutoCompleteStringCollection()
        fuenteSugerencias.AddRange(sugerencias.ToArray())

        ' Asignar la colección de sugerencias al control TextBox
        TxtPaciente.AutoCompleteCustomSource = fuenteSugerencias
    End Sub

    Private Sub TxtPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarPaciente_Click(sender, e)
        End If
    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDescuento()
        FillMedicamento()
        Dim siguienteID As Integer = ObtenerSiguienteID()

        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
        saveFactura()
    End Sub

    Private Sub saveFactura()
        Try
            con.Open()

            Dim cmd As New SqlCommand("sp_InsertarFactura", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@NumFactura", ObtenerSiguienteID())

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Nueva Factura en proceso!")
            Else
                MessageBox.Show("El registro no se pudo guardar correctamente, algo falló")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtIdPaciente.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar paciente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPaciente.Focus()
            isvalid = False
        ElseIf CbmDescuento.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, seleccionar descuento del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmDescuento.Focus()
            isvalid = False
        ElseIf CbmMedicamentos.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, seleccionar medicamento del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmMedicamentos.Focus()
            isvalid = False
        ElseIf TxtCantidad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar cantidad a llevar de medicamento seleccionado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCantidad.Focus()
            isvalid = False
        ElseIf TxtIVA.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar IVA.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIVA.Focus()
            isvalid = False

        End If
        Return isvalid

    End Function

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Validator() Then

            DgvDetalleFactura.Rows.Add(TxtId.Text.ToString(), CbmMedicamentos.SelectedValue.ToString(), CbmMedicamentos.Text.ToString(), TxtIVA.Text.ToString(), TxtTotal.Text.ToString())
        End If
    End Sub

    Private Sub CbmDescuento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbmDescuento.SelectionChangeCommitted
        If CbmDescuento.SelectedItem IsNot Nothing Then


            Dim query As String = "SELECT Descuento FROM Descuento WHERE IdDescuento = @IdDescuento"
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@IdDescuento", Convert.ToInt32(CbmDescuento.SelectedValue.ToString()))
                    con.Open()
                    Dim discount As Object = cmd.ExecuteScalar()

                    If discount IsNot Nothing AndAlso Not Convert.IsDBNull(discount) Then
                        Dim discountValue As Double
                        If Double.TryParse(discount.ToString(), discountValue) Then
                            TxtDescuento.Text = discountValue.ToString("N2")
                        Else
                            TxtDescuento.Text = "N/A"
                        End If
                    Else
                        TxtDescuento.Text = "N/A"
                    End If

                    con.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub CbmMedicamentos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbmMedicamentos.SelectionChangeCommitted
        If CbmMedicamentos.SelectedItem IsNot Nothing Then
            Dim selectedMed As DataRowView = DirectCast(CbmMedicamentos.SelectedItem, DataRowView)
            Dim selectedMedicamentoId As Integer = Convert.ToInt32(selectedMed("Codigo"))

            ' Aquí obtén el precio del medicamento seleccionado y muéstralo en TxtPrecio
            Dim query As String = "SELECT Precio FROM Medicamentos WHERE Codigo = @Codigo"
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Codigo", selectedMedicamentoId)
                    con.Open()
                    Dim precio As Object = cmd.ExecuteScalar()

                    If precio IsNot Nothing AndAlso Not Convert.IsDBNull(precio) Then
                        TxtPrecio.Text = Convert.ToDecimal(precio).ToString("N2")
                    Else
                        TxtPrecio.Text = "N/A"
                    End If

                    con.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click

        For Each item As DataGridViewRow In DgvDetalleFactura.Rows
            Try
                con.Open()

                Dim cmd As New SqlCommand("sp_DetalleFactura", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Identificador", 1)
                cmd.Parameters.AddWithValue("@NumFactura", TxtId.Text.ToString())
                cmd.Parameters.AddWithValue("@CodigoMedicamento", item.Cells("Codigo").Value.ToString())
                cmd.Parameters.AddWithValue("@IVA", Convert.ToDouble(item.Cells("IVA").Value.ToString()))
                cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(item.Cells("Total").Value.ToString()))
                cmd.Parameters.AddWithValue("@IdPaciente", TxtIdPaciente.Text.ToString())



                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ClearForm()
                Else
                    MessageBox.Show("El registro no se pudo guardar correctamente, algo falló")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            TxtId.Text = ObtenerSiguienteID()

        Next

    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        If TxtPrecio.Text.Trim().Length <> 0 And Regex.IsMatch(TxtCantidad.Text, "^[0-9,$]*$") And TxtCantidad.Text.Trim().Length <> 0 Then
            TxtSubTotal.Text = (Convert.ToDouble(TxtPrecio.Text.Trim()) * Convert.ToDouble(TxtCantidad.Text.Trim())).ToString()
            calculateTotal()
        End If
    End Sub

    Private Sub calculateTotal()
        If Validator() Then
            Dim discount As Double = Convert.ToDouble(TxtDescuento.Text) / 100
            Dim subTotal As Double = Convert.ToDouble(TxtSubTotal.Text.Trim())
            Dim IVA As Double = Convert.ToDouble(TxtIVA.Text / 100) * subTotal

            TxtTotal.Text = (subTotal + IVA) - (subTotal * discount)

        End If
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        calculateTotal()
    End Sub

    Private Sub TxtIVA_TextChanged(sender As Object, e As EventArgs) Handles TxtIVA.TextChanged
        If Regex.IsMatch(TxtIVA.Text, "^[0-9,$]*$") And TxtIVA.Text.Trim.Length <> 0 Then
            calculateTotal()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgvDetalleFactura.Rows.Count > 0 Then
            DgvDetalleFactura.Rows.Remove(DgvDetalleFactura.Rows(DgvDetalleFactura.Rows.Count - 1))
        End If
    End Sub


End Class