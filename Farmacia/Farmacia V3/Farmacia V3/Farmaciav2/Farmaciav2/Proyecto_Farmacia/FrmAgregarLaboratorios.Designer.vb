<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarLaboratorios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnCancelar = New Button()
        btnAceptar = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtContacto = New TextBox()
        txtFax = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        txtNombre = New TextBox()
        txtID = New TextBox()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(337, 353)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 29
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(129, 353)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 28
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(127, 191)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 25)
        Label7.TabIndex = 27
        Label7.Text = "Telefono"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(119, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 25)
        Label6.TabIndex = 26
        Label6.Text = "Contacto"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(161, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 25)
        Label4.TabIndex = 25
        Label4.Text = "Fax"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(119, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 25)
        Label3.TabIndex = 24
        Label3.Text = "Dirección"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 25)
        Label2.TabIndex = 23
        Label2.Text = "Nombre de Laboratorio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(51, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 25)
        Label1.TabIndex = 22
        Label1.Text = "ID de Laboratorio"
        ' 
        ' txtContacto
        ' 
        txtContacto.Location = New Point(241, 284)
        txtContacto.Name = "txtContacto"
        txtContacto.Size = New Size(229, 23)
        txtContacto.TabIndex = 21
        ' 
        ' txtFax
        ' 
        txtFax.Location = New Point(241, 233)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(229, 23)
        txtFax.TabIndex = 20
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(241, 191)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(229, 23)
        txtTelefono.TabIndex = 19
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(241, 143)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(229, 23)
        txtDireccion.TabIndex = 18
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(241, 95)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(229, 23)
        txtNombre.TabIndex = 17
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(241, 46)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(229, 23)
        txtID.TabIndex = 16
        ' 
        ' FrmAgregarLaboratorios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 409)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContacto)
        Controls.Add(txtFax)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtNombre)
        Controls.Add(txtID)
        Name = "FrmAgregarLaboratorios"
        Text = "FrmAgregarLaboratorios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
End Class
