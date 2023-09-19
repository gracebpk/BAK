Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAgregarClientes

    Dim EXISTE_CEDULA As Boolean
    Dim EXISTE_TELEFONO As Boolean



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
            ConeccionBD.Abrir_BaseDato()
        Else
            ConeccionBD.Abrir_BaseDato()
        End If

        If Me.txtID.Text = " " Or txtCedula.Text = " " Or txtNombre.Text = " " Or txtTelefono.Text = " " Then
            MsgBox("Uno o más campos están vacios o malos. Por favor revise e intente otra vez", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtID.Focus()
            Exit Sub
        End If


        Dim maxLength As Integer = 15
        Dim minLength As Integer = 14

        If txtCedula.Text.Length < minLength - 1 Then

            MessageBox.Show("Este campo debe tener al menos 14 caracteres.")
            Exit Sub
        End If

        If txtCedula.Text.Length + 1 > maxLength Then

            MessageBox.Show("Este campo debe tener Maximo 14 caracteres.")
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_CEDULA()
        If EXISTE_CEDULA = True Then
            MsgBox("Esta Cedula ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtCedula.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_TELEFONO()
        If EXISTE_TELEFONO = True Then
            MsgBox("Este Telefono ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtCedula.Focus()
            Exit Sub
        End If


        Call GENERAR_CODIGO_ID_CLIENTE()
        Dim Insertar As String
        Dim Cmd_Add As SqlCommand
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If



        Insertar = "Insert Into DBO.CLIENTES (IDCLIENTE, NOMBRES_APELLIDOS, CEDULA, TELEFONO)values('" & CInt(txtID.Text) & "','" & UCase(Me.txtNombre.Text) & "','" & (Me.txtCedula.Text) & "','" & (Me.txtTelefono.Text) & "')"
        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
            MsgBox("registro guardado")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
        CANCELAR_A_E = True
        Close()
        ClearTextBoxes()
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CANCELAR_A_E = False
        Me.Close()
        ClearTextBoxes()
    End Sub

    Private Sub GENERAR_CODIGO_ID_CLIENTE()

        Dim VALOR_ID_PRODUCTO As Integer
        Dim VALOR_DR As SqlDataReader
        txtID.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.CLIENTES ORDER BY IDCLIENTE"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader
            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PRODUCTO = VALOR_DR("IDCLIENTE").ToString
                    txtID.Text = VALOR_ID_PRODUCTO + 1
                End While
            End If
            If txtID.Text = "" Or txtID.Text = 0 Then
                txtID.Text = 1
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try


    End Sub

    Private Sub BUSCAR_SI_YA_EXISTE_CEDULA()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CLIENTES WHERE CEDULA = @CEDULA", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@CEDULA", txtCedula.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_CEDULA = True
            Else
                EXISTE_CEDULA = False
            End If

            drbuscar.Close()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BUSCAR_SI_YA_EXISTE_TELEFONO()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CLIENTES WHERE TELEFONO = @TELEFONO", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_TELEFONO = True
            Else
                EXISTE_TELEFONO = False
            End If

            drbuscar.Close()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub


    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If


        If txtTelefono.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        Dim maxLength As Integer = 14

        If txtCedula.Text.Length > maxLength Then

            txtCedula.Text = txtCedula.Text.Substring(0, maxLength)

            txtCedula.SelectionStart = maxLength
        End If
    End Sub


    Private Sub ClearTextBoxes()
        txtCedula.Clear()
        txtID.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
    End Sub



End Class