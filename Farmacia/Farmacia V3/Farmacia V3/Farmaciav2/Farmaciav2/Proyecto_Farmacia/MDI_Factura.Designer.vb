<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_Factura
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
        MenuStrip2 = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        FacturasToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        WindowsToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeCategoriasToolStripMenuItem = New ToolStripMenuItem()
        AgregarCategoriasToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeProveedoresToolStripMenuItem = New ToolStripMenuItem()
        AgregarProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeClientesToolStripMenuItem = New ToolStripMenuItem()
        AgregarClientesToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeProductosToolStripMenuItem = New ToolStripMenuItem()
        AgregarProductosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AgregarLaboratoriosToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeLaboratoriosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        AgregarCategoriaToolStripMenuItem = New ToolStripMenuItem()
        ListadoDeCategoriasToolStripMenuItem1 = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        MenuStrip2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, FacturasToolStripMenuItem, WindowsToolStripMenuItem, SalirToolStripMenuItem, CategoriasToolStripMenuItem, ProveedoresToolStripMenuItem, ClientesToolStripMenuItem, ProductosToolStripMenuItem, ToolStripMenuItem1, ToolStripMenuItem2})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' FacturasToolStripMenuItem
        ' 
        FacturasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConsultasToolStripMenuItem})
        FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        FacturasToolStripMenuItem.Size = New Size(63, 20)
        FacturasToolStripMenuItem.Text = "Facturas"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(126, 22)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' WindowsToolStripMenuItem
        ' 
        WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        WindowsToolStripMenuItem.Size = New Size(68, 20)
        WindowsToolStripMenuItem.Text = "Windows"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListadoDeCategoriasToolStripMenuItem, AgregarCategoriasToolStripMenuItem})
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.Size = New Size(75, 20)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' ListadoDeCategoriasToolStripMenuItem
        ' 
        ListadoDeCategoriasToolStripMenuItem.Name = "ListadoDeCategoriasToolStripMenuItem"
        ListadoDeCategoriasToolStripMenuItem.Size = New Size(187, 22)
        ListadoDeCategoriasToolStripMenuItem.Text = "Listado de Categorias"
        ' 
        ' AgregarCategoriasToolStripMenuItem
        ' 
        AgregarCategoriasToolStripMenuItem.Name = "AgregarCategoriasToolStripMenuItem"
        AgregarCategoriasToolStripMenuItem.Size = New Size(187, 22)
        AgregarCategoriasToolStripMenuItem.Text = "Agregar Categorias"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListadoDeProveedoresToolStripMenuItem, AgregarProveedoresToolStripMenuItem})
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(84, 20)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' ListadoDeProveedoresToolStripMenuItem
        ' 
        ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        ListadoDeProveedoresToolStripMenuItem.Size = New Size(196, 22)
        ListadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores"
        ' 
        ' AgregarProveedoresToolStripMenuItem
        ' 
        AgregarProveedoresToolStripMenuItem.Name = "AgregarProveedoresToolStripMenuItem"
        AgregarProveedoresToolStripMenuItem.Size = New Size(196, 22)
        AgregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListadoDeClientesToolStripMenuItem, AgregarClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(61, 20)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ListadoDeClientesToolStripMenuItem
        ' 
        ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        ListadoDeClientesToolStripMenuItem.Size = New Size(173, 22)
        ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        ' 
        ' AgregarClientesToolStripMenuItem
        ' 
        AgregarClientesToolStripMenuItem.Name = "AgregarClientesToolStripMenuItem"
        AgregarClientesToolStripMenuItem.Size = New Size(173, 22)
        AgregarClientesToolStripMenuItem.Text = "Agregar Clientes"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ListadoDeProductosToolStripMenuItem, AgregarProductosToolStripMenuItem})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(73, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' ListadoDeProductosToolStripMenuItem
        ' 
        ListadoDeProductosToolStripMenuItem.Name = "ListadoDeProductosToolStripMenuItem"
        ListadoDeProductosToolStripMenuItem.Size = New Size(185, 22)
        ListadoDeProductosToolStripMenuItem.Text = "Listado de Productos"
        ' 
        ' AgregarProductosToolStripMenuItem
        ' 
        AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        AgregarProductosToolStripMenuItem.Size = New Size(185, 22)
        AgregarProductosToolStripMenuItem.Text = "Agregar Productos"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AgregarLaboratoriosToolStripMenuItem, ListadoDeLaboratoriosToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(85, 20)
        ToolStripMenuItem1.Text = "Laboratorios"
        ' 
        ' AgregarLaboratoriosToolStripMenuItem
        ' 
        AgregarLaboratoriosToolStripMenuItem.Name = "AgregarLaboratoriosToolStripMenuItem"
        AgregarLaboratoriosToolStripMenuItem.Size = New Size(197, 22)
        AgregarLaboratoriosToolStripMenuItem.Text = "Agregar Laboratorios"
        ' 
        ' ListadoDeLaboratoriosToolStripMenuItem
        ' 
        ListadoDeLaboratoriosToolStripMenuItem.Name = "ListadoDeLaboratoriosToolStripMenuItem"
        ListadoDeLaboratoriosToolStripMenuItem.Size = New Size(197, 22)
        ListadoDeLaboratoriosToolStripMenuItem.Text = "Listado de Laboratorios"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {AgregarCategoriaToolStripMenuItem, ListadoDeCategoriasToolStripMenuItem1})
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(89, 20)
        ToolStripMenuItem2.Text = "CatTipoVenta"
        ' 
        ' AgregarCategoriaToolStripMenuItem
        ' 
        AgregarCategoriaToolStripMenuItem.Name = "AgregarCategoriaToolStripMenuItem"
        AgregarCategoriaToolStripMenuItem.Size = New Size(187, 22)
        AgregarCategoriaToolStripMenuItem.Text = "Agregar Categoria"
        ' 
        ' ListadoDeCategoriasToolStripMenuItem1
        ' 
        ListadoDeCategoriasToolStripMenuItem1.Name = "ListadoDeCategoriasToolStripMenuItem1"
        ListadoDeCategoriasToolStripMenuItem1.Size = New Size(187, 22)
        ListadoDeCategoriasToolStripMenuItem1.Text = "Listado de Categorias"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 27)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(776, 411)
        DataGridView1.TabIndex = 2
        ' 
        ' MDI_Factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip2)
        Name = "MDI_Factura"
        Text = "MDI_Factura"
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgregarLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeLaboratoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AgregarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeCategoriasToolStripMenuItem1 As ToolStripMenuItem
End Class
