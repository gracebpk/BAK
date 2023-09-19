Imports System.Data.SqlClient

Public Class FrmAgregarCatTipoVenta
    Dim EXISTE_ID As Boolean
    Dim EXISTE_NOMBRE As Boolean

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
            ConeccionBD.Abrir_BaseDato()
        Else
            ConeccionBD.Abrir_BaseDato()
        End If


        If Me.txtID.Text = " " Or txtNombre.Text = " " Then
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

        Call BUSCAR_SI_YA_EXISTE_NOMBRE()
        If EXISTE_NOMBRE = True Then
            MsgBox("Esta Categoria(nombre) ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If


        Call GENERAR_CODIGO_ID_CATVENTA()

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If


        Dim Insertar As String = "INSERT INTO DBO.CAT_TIPO_VENTA (ID_TIPO_VENTA, DESCRIPCION) VALUES (@ID, @Nombre)"

        Try
            Using Cmd_Add As New SqlCommand(Insertar, ConeccionBD.CONECCION)
                Cmd_Add.Parameters.AddWithValue("@ID", txtID.Text)
                Cmd_Add.Parameters.AddWithValue("@Nombre", txtNombre.Text)

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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CANCELAR_A_E = False
        Me.Close()
        ClearTextBoxes()
    End Sub

    Private Sub ClearTextBoxes()
        txtID.Clear()
        txtNombre.Clear()
    End Sub

    Private Sub GENERAR_CODIGO_ID_CATVENTA()

        Dim VALOR_ID_PRODUCTO As Integer
        Dim VALOR_DR As SqlDataReader
        txtID.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.CAT_TIPO_VENTA ORDER BY ID_TIPO_VENTA"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader
            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PRODUCTO = VALOR_DR("ID_TIPO_VENTA").ToString
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

    Private Sub BUSCAR_SI_YA_EXISTE_NOMBRE()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CAT_TIPO_VENTA WHERE DESCRIPCION = @NOMBRE", ConeccionBD.CONECCION)
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

    Private Sub BUSCAR_SI_YA_EXISTE_ID()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CAT_TIPO_VENTA WHERE ID_TIPO_VENTA = @ID", ConeccionBD.CONECCION)
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

End Class