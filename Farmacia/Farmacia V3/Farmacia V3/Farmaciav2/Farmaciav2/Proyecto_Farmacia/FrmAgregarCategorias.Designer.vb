<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCategorias
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
        txtDescripcion = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(313, 114)
        txtID.Name = "txtID"
        txtID.Size = New Size(186, 23)
        txtID.TabIndex = 0
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(313, 180)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(186, 23)
        txtDescripcion.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(156, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 30)
        Label1.TabIndex = 2
        Label1.Text = "ID Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(66, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 30)
        Label2.TabIndex = 3
        Label2.Text = "Descripción Categoria"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(93, 351)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 4
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(566, 351)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 5
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarCategorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtDescripcion)
        Controls.Add(txtID)
        Name = "FrmAgregarCategorias"
        Text = "FrmAgregarCategorias"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
