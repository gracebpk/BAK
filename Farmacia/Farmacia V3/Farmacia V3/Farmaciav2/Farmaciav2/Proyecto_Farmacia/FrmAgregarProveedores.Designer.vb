<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarProveedores
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtID = New TextBox()
        txtNombre = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtWeb = New TextBox()
        txtFax = New TextBox()
        txtContacto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(263, 50)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(229, 23)
        txtID.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(263, 99)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(229, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(263, 147)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(229, 23)
        txtDireccion.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(263, 195)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(229, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' txtWeb
        ' 
        txtWeb.Location = New Point(263, 282)
        txtWeb.Name = "txtWeb"
        txtWeb.Size = New Size(229, 23)
        txtWeb.TabIndex = 4
        ' 
        ' txtFax
        ' 
        txtFax.Location = New Point(263, 237)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(229, 23)
        txtFax.TabIndex = 5
        ' 
        ' txtContacto
        ' 
        txtContacto.Location = New Point(263, 331)
        txtContacto.Name = "txtContacto"
        txtContacto.Size = New Size(229, 23)
        txtContacto.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(73, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 25)
        Label1.TabIndex = 7
        Label1.Text = "ID de Proveedor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(50, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(202, 25)
        Label2.TabIndex = 8
        Label2.Text = "Nombre de Proveedor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(141, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 25)
        Label3.TabIndex = 9
        Label3.Text = "Dirección"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(183, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 25)
        Label4.TabIndex = 10
        Label4.Text = "Fax"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(173, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 25)
        Label5.TabIndex = 11
        Label5.Text = "Web"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(141, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 25)
        Label6.TabIndex = 12
        Label6.Text = "Contacto"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(149, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 25)
        Label7.TabIndex = 13
        Label7.Text = "Telefono"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(159, 418)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 14
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(367, 418)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 15
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(593, 483)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContacto)
        Controls.Add(txtFax)
        Controls.Add(txtWeb)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtNombre)
        Controls.Add(txtID)
        Name = "FrmAgregarProveedores"
        Text = "Agregar un Proveedor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
