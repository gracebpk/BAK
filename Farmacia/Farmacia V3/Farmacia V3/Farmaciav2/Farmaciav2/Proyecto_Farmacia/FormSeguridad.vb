Imports System.Data.SqlClient
Public Class FormSeguridad
    Inherits System.Windows.Forms.Form
    Dim dv As DataView
    Private posicion As Integer
    Dim odataset As New DataSet
    Private oconn As SqlConnection
    Private odataadapter As New SqlDataAdapter
    Private Sub SeguridadForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oconn = New SqlConnection(oConexion)
        Me.odataadapter = New SqlDataAdapter("Select * from USUARIOS", oconn)
        Dim ocommandbuilder As SqlCommandBuilder = New SqlCommandBuilder(odataadapter)
        Me.odataset = New DataSet

        oconn.Open()
        Me.odataadapter.Fill(odataset, "USUARIOS")
        oconn.Close()
        posicion = 0
        Me.cargadatos()
    End Sub

    Private Sub cargadatos()
        Dim odatarow As DataRow
        odatarow = Me.odataset.Tables("USUARIOS").Rows(posicion)
        Me.txtCargarUsuario.Text = odatarow("Nombre")
        Me.txtCargarContraseña.Text = odatarow("Contraseña")
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        comparar()
    End Sub
    Private Sub comparar()
        If Me.txtCargarUsuario.Text = Me.txtUsuario.Text And Me.txtCargarContraseña.Text = Me.txtContraseña.Text Then
            abrir()
        Else
            buscar()
        End If
    End Sub
    Private Sub abrir()
        Dim open As New FormPresentacion
        open.Show()
        Me.Hide()
    End Sub
    Private Sub buscar()
        If Me.posicion = (Me.odataset.Tables("Usuarios").Rows.Count - 1) Then
            MessageBox.Show("Usuario no registrado")
        Else
            posicion += 1
            cargadatos()
            comparar()
        End If
    End Sub
    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.txtContraseña.Focus()
        End If
    End Sub
    Private Sub TxtContraseña_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.btnAceptar.Focus()
        End If
    End Sub
End Class
