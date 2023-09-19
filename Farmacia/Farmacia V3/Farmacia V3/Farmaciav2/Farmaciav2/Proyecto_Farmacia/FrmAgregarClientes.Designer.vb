<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarClientes
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
        txtID = New TextBox()
        txtCedula = New TextBox()
        txtNombre = New TextBox()
        txtTelefono = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(325, 72)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(264, 23)
        txtID.TabIndex = 0
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(325, 181)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(264, 23)
        txtCedula.TabIndex = 1
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(325, 125)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(264, 23)
        txtNombre.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(325, 239)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(264, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(218, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 4
        Label1.Text = "ID Cliente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(230, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 25)
        Label2.TabIndex = 5
        Label2.Text = "Telefono"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(125, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(190, 25)
        Label3.TabIndex = 6
        Label3.Text = "Nombres y Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(244, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 25)
        Label4.TabIndex = 7
        Label4.Text = "Cedula"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(244, 347)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 8
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(514, 347)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 9
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTelefono)
        Controls.Add(txtNombre)
        Controls.Add(txtCedula)
        Controls.Add(txtID)
        Name = "FrmAgregarClientes"
        Text = "FrmAgregarClientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
