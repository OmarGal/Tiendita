<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        BT_añadir = New Button()
        BT_aceptar = New Button()
        BT_cancelar = New Button()
        tabla = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Producto = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        TB_cantidad = New TextBox()
        LB_total = New Label()
        CB_producto = New ComboBox()
        CB_cliente = New ComboBox()
        LB_usuario = New Label()
        LB_descuento = New Label()
        LB_subtotal = New Label()
        TB_id_producto = New TextBox()
        TB_id_cliente = New TextBox()
        BT_cliente_agregar = New Button()
        BT_cliente_remover = New Button()
        BT_cambiarUsuario = New PictureBox()
        BT_ventas = New PictureBox()
        BT_inv = New PictureBox()
        BT_caja = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tabla, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 452)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BT_añadir
        ' 
        BT_añadir.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(114))
        BT_añadir.FlatAppearance.BorderSize = 0
        BT_añadir.FlatStyle = FlatStyle.Flat
        BT_añadir.ForeColor = Color.Black
        BT_añadir.Location = New Point(300, 141)
        BT_añadir.Name = "BT_añadir"
        BT_añadir.Size = New Size(56, 26)
        BT_añadir.TabIndex = 1
        BT_añadir.Text = "Añadir"
        BT_añadir.UseVisualStyleBackColor = False
        ' 
        ' BT_aceptar
        ' 
        BT_aceptar.BackColor = Color.FromArgb(CByte(0), CByte(191), CByte(99))
        BT_aceptar.BackgroundImageLayout = ImageLayout.None
        BT_aceptar.FlatAppearance.BorderSize = 0
        BT_aceptar.FlatStyle = FlatStyle.Flat
        BT_aceptar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_aceptar.ForeColor = Color.White
        BT_aceptar.Location = New Point(690, 393)
        BT_aceptar.Name = "BT_aceptar"
        BT_aceptar.Size = New Size(65, 42)
        BT_aceptar.TabIndex = 2
        BT_aceptar.Text = "Aceptar"
        BT_aceptar.UseVisualStyleBackColor = False
        ' 
        ' BT_cancelar
        ' 
        BT_cancelar.BackColor = Color.FromArgb(CByte(255), CByte(49), CByte(49))
        BT_cancelar.BackgroundImageLayout = ImageLayout.None
        BT_cancelar.FlatAppearance.BorderSize = 0
        BT_cancelar.FlatStyle = FlatStyle.Flat
        BT_cancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_cancelar.ForeColor = Color.White
        BT_cancelar.Location = New Point(569, 393)
        BT_cancelar.Name = "BT_cancelar"
        BT_cancelar.Size = New Size(65, 42)
        BT_cancelar.TabIndex = 3
        BT_cancelar.Text = "Cancelar"
        BT_cancelar.UseVisualStyleBackColor = False
        ' 
        ' tabla
        ' 
        tabla.AccessibleName = "tabla"
        tabla.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabla.Columns.AddRange(New DataGridViewColumn() {ID, Producto, Precio, Cantidad, Total})
        tabla.Location = New Point(44, 204)
        tabla.Name = "tabla"
        tabla.ReadOnly = True
        tabla.RowTemplate.Height = 25
        tabla.Size = New Size(374, 158)
        tabla.TabIndex = 8
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Width = 50
        ' 
        ' Producto
        ' 
        Producto.HeaderText = "Producto"
        Producto.Name = "Producto"
        Producto.ReadOnly = True
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.Name = "Precio"
        Precio.ReadOnly = True
        Precio.Width = 50
        ' 
        ' Cantidad
        ' 
        Cantidad.HeaderText = "Cantidad"
        Cantidad.Name = "Cantidad"
        Cantidad.ReadOnly = True
        Cantidad.Width = 60
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.Name = "Total"
        Total.ReadOnly = True
        Total.Width = 70
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        Label4.Enabled = False
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Location = New Point(324, 414)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 9
        ' 
        ' TB_cantidad
        ' 
        TB_cantidad.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TB_cantidad.BorderStyle = BorderStyle.None
        TB_cantidad.Location = New Point(300, 106)
        TB_cantidad.Name = "TB_cantidad"
        TB_cantidad.Size = New Size(56, 16)
        TB_cantidad.TabIndex = 13
        TB_cantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' LB_total
        ' 
        LB_total.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        LB_total.FlatStyle = FlatStyle.Flat
        LB_total.ForeColor = Color.White
        LB_total.Location = New Point(705, 324)
        LB_total.Name = "LB_total"
        LB_total.Size = New Size(64, 15)
        LB_total.TabIndex = 15
        LB_total.Text = "$0"
        LB_total.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CB_producto
        ' 
        CB_producto.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CB_producto.DropDownStyle = ComboBoxStyle.DropDownList
        CB_producto.FormattingEnabled = True
        CB_producto.Location = New Point(157, 102)
        CB_producto.Name = "CB_producto"
        CB_producto.Size = New Size(119, 23)
        CB_producto.TabIndex = 16
        ' 
        ' CB_cliente
        ' 
        CB_cliente.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CB_cliente.DropDownStyle = ComboBoxStyle.DropDownList
        CB_cliente.FormattingEnabled = True
        CB_cliente.Location = New Point(568, 104)
        CB_cliente.Name = "CB_cliente"
        CB_cliente.Size = New Size(204, 23)
        CB_cliente.TabIndex = 19
        ' 
        ' LB_usuario
        ' 
        LB_usuario.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        LB_usuario.ForeColor = Color.White
        LB_usuario.Location = New Point(537, 17)
        LB_usuario.Name = "LB_usuario"
        LB_usuario.Size = New Size(183, 24)
        LB_usuario.TabIndex = 20
        LB_usuario.Text = "Cajero"
        LB_usuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LB_descuento
        ' 
        LB_descuento.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LB_descuento.FlatStyle = FlatStyle.Flat
        LB_descuento.Location = New Point(705, 289)
        LB_descuento.Name = "LB_descuento"
        LB_descuento.Size = New Size(64, 15)
        LB_descuento.TabIndex = 21
        LB_descuento.Text = "$0"
        LB_descuento.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LB_subtotal
        ' 
        LB_subtotal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LB_subtotal.FlatStyle = FlatStyle.Flat
        LB_subtotal.Location = New Point(705, 255)
        LB_subtotal.Name = "LB_subtotal"
        LB_subtotal.Size = New Size(64, 15)
        LB_subtotal.TabIndex = 22
        LB_subtotal.Text = "$0"
        LB_subtotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TB_id_producto
        ' 
        TB_id_producto.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TB_id_producto.BorderStyle = BorderStyle.None
        TB_id_producto.Location = New Point(165, 143)
        TB_id_producto.Name = "TB_id_producto"
        TB_id_producto.Size = New Size(56, 16)
        TB_id_producto.TabIndex = 23
        TB_id_producto.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_id_cliente
        ' 
        TB_id_cliente.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TB_id_cliente.BorderStyle = BorderStyle.None
        TB_id_cliente.Location = New Point(576, 145)
        TB_id_cliente.Name = "TB_id_cliente"
        TB_id_cliente.Size = New Size(56, 16)
        TB_id_cliente.TabIndex = 24
        TB_id_cliente.TextAlign = HorizontalAlignment.Center
        ' 
        ' BT_cliente_agregar
        ' 
        BT_cliente_agregar.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(114))
        BT_cliente_agregar.FlatAppearance.BorderSize = 0
        BT_cliente_agregar.FlatStyle = FlatStyle.Flat
        BT_cliente_agregar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_cliente_agregar.ForeColor = Color.Black
        BT_cliente_agregar.Location = New Point(666, 141)
        BT_cliente_agregar.Name = "BT_cliente_agregar"
        BT_cliente_agregar.Size = New Size(35, 24)
        BT_cliente_agregar.TabIndex = 25
        BT_cliente_agregar.Text = "✔"
        BT_cliente_agregar.UseVisualStyleBackColor = False
        ' 
        ' BT_cliente_remover
        ' 
        BT_cliente_remover.BackColor = Color.FromArgb(CByte(255), CByte(210), CByte(115))
        BT_cliente_remover.FlatAppearance.BorderSize = 0
        BT_cliente_remover.FlatStyle = FlatStyle.Flat
        BT_cliente_remover.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_cliente_remover.ForeColor = Color.Black
        BT_cliente_remover.Location = New Point(729, 141)
        BT_cliente_remover.Name = "BT_cliente_remover"
        BT_cliente_remover.Size = New Size(35, 24)
        BT_cliente_remover.TabIndex = 26
        BT_cliente_remover.Text = "✖"
        BT_cliente_remover.UseVisualStyleBackColor = False
        ' 
        ' BT_cambiarUsuario
        ' 
        BT_cambiarUsuario.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        BT_cambiarUsuario.Image = CType(resources.GetObject("BT_cambiarUsuario.Image"), Image)
        BT_cambiarUsuario.Location = New Point(738, 11)
        BT_cambiarUsuario.Name = "BT_cambiarUsuario"
        BT_cambiarUsuario.Size = New Size(39, 39)
        BT_cambiarUsuario.SizeMode = PictureBoxSizeMode.StretchImage
        BT_cambiarUsuario.TabIndex = 27
        BT_cambiarUsuario.TabStop = False
        ' 
        ' BT_ventas
        ' 
        BT_ventas.BackColor = Color.White
        BT_ventas.Image = CType(resources.GetObject("BT_ventas.Image"), Image)
        BT_ventas.Location = New Point(203, 421)
        BT_ventas.Name = "BT_ventas"
        BT_ventas.Size = New Size(74, 22)
        BT_ventas.SizeMode = PictureBoxSizeMode.StretchImage
        BT_ventas.TabIndex = 41
        BT_ventas.TabStop = False
        ' 
        ' BT_inv
        ' 
        BT_inv.BackColor = Color.White
        BT_inv.Image = CType(resources.GetObject("BT_inv.Image"), Image)
        BT_inv.Location = New Point(106, 421)
        BT_inv.Name = "BT_inv"
        BT_inv.Size = New Size(91, 22)
        BT_inv.SizeMode = PictureBoxSizeMode.StretchImage
        BT_inv.TabIndex = 40
        BT_inv.TabStop = False
        ' 
        ' BT_caja
        ' 
        BT_caja.BackColor = Color.White
        BT_caja.Image = CType(resources.GetObject("BT_caja.Image"), Image)
        BT_caja.Location = New Point(26, 421)
        BT_caja.Name = "BT_caja"
        BT_caja.Size = New Size(74, 22)
        BT_caja.SizeMode = PictureBoxSizeMode.StretchImage
        BT_caja.TabIndex = 39
        BT_caja.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(BT_ventas)
        Controls.Add(BT_inv)
        Controls.Add(BT_caja)
        Controls.Add(BT_cambiarUsuario)
        Controls.Add(BT_cliente_remover)
        Controls.Add(BT_cliente_agregar)
        Controls.Add(TB_id_cliente)
        Controls.Add(TB_id_producto)
        Controls.Add(LB_subtotal)
        Controls.Add(LB_descuento)
        Controls.Add(LB_usuario)
        Controls.Add(CB_cliente)
        Controls.Add(CB_producto)
        Controls.Add(LB_total)
        Controls.Add(TB_cantidad)
        Controls.Add(Label4)
        Controls.Add(tabla)
        Controls.Add(BT_cancelar)
        Controls.Add(BT_aceptar)
        Controls.Add(BT_añadir)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Caja"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tabla, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BT_añadir As Button
    Friend WithEvents BT_aceptar As Button
    Friend WithEvents BT_cancelar As Button
    Friend WithEvents tabla As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_cantidad As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents LB_usuario As Label
    Friend WithEvents LB_total As Label
    Friend WithEvents CB_producto As ComboBox
    Friend WithEvents CB_cliente As ComboBox
    Friend WithEvents LB_subtotal As Label
    Friend WithEvents LB_descuento As Label
    Friend WithEvents TB_id_producto As TextBox
    Friend WithEvents TB_id_cliente As TextBox
    Friend WithEvents BT_cliente_agregar As Button
    Friend WithEvents BT_cliente_remover As Button
    Friend WithEvents BT_cambiarUsuario As PictureBox
    Friend WithEvents BT_ventas As PictureBox
    Friend WithEvents BT_inv As PictureBox
    Friend WithEvents BT_caja As PictureBox
End Class
