Imports System.Data.SqlClient

Public Class FrmAgregarProveedores

    Dim EXISTE_ID As Boolean
    Dim EXISTE_CONTACTO As Boolean
    Dim EXISTE_FAX As Boolean
    Dim EXISTE_NOMBRE As Boolean
    Dim EXISTE_TELEFONO As Boolean
    Dim EXISTE_WEB As Boolean
    Dim Insertar As String
    Dim Cmd_Add As SqlCommand

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
            ConeccionBD.Abrir_BaseDato()
        Else
            ConeccionBD.Abrir_BaseDato()
        End If


        If Me.txtID.Text = " " Or txtDireccion.Text = " " Or txtContacto.Text = " " Or txtFax.Text = " " Or txtNombre.Text = " " Or txtTelefono.Text = " " Or txtWeb.Text = " " Then
            MsgBox("Uno o más campos están vacios o malos. Por favor revise e intente otra vez", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_ID()
        If EXISTE_ID = True Then
            MsgBox("Este ID ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_CONTACTO()
        If EXISTE_CONTACTO = True Then
            MsgBox("Este contacto ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_FAX()
        If EXISTE_FAX = True Then
            MsgBox("Este fax ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_NOMBRE()
        If EXISTE_NOMBRE = True Then
            MsgBox("Este proveedor(nombre) ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_TELEFONO()
        If EXISTE_TELEFONO = True Then
            MsgBox("Este Telefono ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_WEB()
        If EXISTE_WEB = True Then
            MsgBox("Este campo Web ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call GENERAR_CODIGO_ID_PROVEEDORES()

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If


        Dim Insertar As String = "INSERT INTO DBO.PROVEEDORES (IDPROVEEDOR, NOMBREPROVEEDOR, DIRECCION, TELEFONO, FAX, WEB, CONTACTO) VALUES (@ID, @Nombre, @Direccion, @Telefono, @Fax, @Web, @Contacto)"

        Try
            Using Cmd_Add As New SqlCommand(Insertar, ConeccionBD.CONECCION)
                Cmd_Add.Parameters.AddWithValue("@ID", txtID.Text)
                Cmd_Add.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                Cmd_Add.Parameters.AddWithValue("@Direccion", txtDireccion.Text) ' No conversion needed
                Cmd_Add.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                Cmd_Add.Parameters.AddWithValue("@Fax", txtFax.Text)
                Cmd_Add.Parameters.AddWithValue("@Web", txtWeb.Text)
                Cmd_Add.Parameters.AddWithValue("@Contacto", txtContacto.Text)

                ConeccionBD.CONECCION.Open()
                Cmd_Add.ExecuteNonQuery()
                MsgBox("Registro guardado")
            End Using
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

    Private Sub BUSCAR_SI_YA_EXISTE_ID()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE IDPROVEEDOR = @ID", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@ID", txtID.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_ID = True
            Else
                EXISTE_ID = False
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

    Private Sub BUSCAR_SI_YA_EXISTE_CONTACTO()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE CONTACTO = @CONTACTO", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@CONTACTO", txtContacto.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_CONTACTO = True
            Else
                EXISTE_CONTACTO = False
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

    Private Sub BUSCAR_SI_YA_EXISTE_FAX()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE FAX = @FAX", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@FAX", txtFax.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_FAX = True
            Else
                EXISTE_FAX = False
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

    Private Sub BUSCAR_SI_YA_EXISTE_NOMBRE()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE NOMBREPROVEEDOR = @NOMBRE", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@NOMBRE", txtNombre.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_NOMBRE = True
            Else
                EXISTE_NOMBRE = False
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
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE TELEFONO = @TELEFONO", ConeccionBD.CONECCION)
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


    Private Sub BUSCAR_SI_YA_EXISTE_WEB()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PROVEEDORES WHERE WEB = @WEB", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@WEB", txtWeb.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_WEB = True
            Else
                EXISTE_WEB = False
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

    Private Sub txtFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFax.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If

        If txtFax.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CANCELAR_A_E = False
        Me.Close()
        ClearTextBoxes()
    End Sub

    Private Sub ClearTextBoxes()
        txtDireccion.Clear()
        txtContacto.Clear()
        txtFax.Clear()
        txtID.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtWeb.Clear()

    End Sub

    Private Sub GENERAR_CODIGO_ID_PROVEEDORES()

        Dim VALOR_ID_PRODUCTO As Integer
        Dim VALOR_DR As SqlDataReader
        txtID.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.PROVEEDORES ORDER BY IDPROVEEDOR"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader
            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PRODUCTO = VALOR_DR("IDPROVEEDOR").ToString
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



End Class