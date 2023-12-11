<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        BT_cambiarUsuario = New PictureBox()
        DG_inventario = New DataGridView()
        DG_historial = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Producto = New DataGridViewTextBoxColumn()
        Cambio = New DataGridViewTextBoxColumn()
        Inventario = New DataGridViewTextBoxColumn()
        CB_producto = New ComboBox()
        TB_cantidad = New TextBox()
        BT_añadir = New Button()
        BT_quitar = New Button()
        TB_id_producto = New TextBox()
        BT_caja = New PictureBox()
        BT_inv = New PictureBox()
        BT_ventas = New PictureBox()
        LB_usuario = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_inventario, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_historial, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 452)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' BT_cambiarUsuario
        ' 
        BT_cambiarUsuario.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        BT_cambiarUsuario.Image = CType(resources.GetObject("BT_cambiarUsuario.Image"), Image)
        BT_cambiarUsuario.Location = New Point(738, 11)
        BT_cambiarUsuario.Name = "BT_cambiarUsuario"
        BT_cambiarUsuario.Size = New Size(39, 39)
        BT_cambiarUsuario.SizeMode = PictureBoxSizeMode.StretchImage
        BT_cambiarUsuario.TabIndex = 28
        BT_cambiarUsuario.TabStop = False
        ' 
        ' DG_inventario
        ' 
        DG_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DG_inventario.Location = New Point(26, 182)
        DG_inventario.Name = "DG_inventario"
        DG_inventario.ReadOnly = True
        DG_inventario.RowHeadersVisible = False
        DG_inventario.RowHeadersWidth = 30
        DG_inventario.RowTemplate.Height = 25
        DG_inventario.Size = New Size(424, 220)
        DG_inventario.TabIndex = 29
        ' 
        ' DG_historial
        ' 
        DG_historial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DG_historial.Columns.AddRange(New DataGridViewColumn() {ID, Producto, Cambio, Inventario})
        DG_historial.Location = New Point(518, 182)
        DG_historial.Name = "DG_historial"
        DG_historial.ReadOnly = True
        DG_historial.RowHeadersVisible = False
        DG_historial.RowTemplate.Height = 25
        DG_historial.Size = New Size(249, 220)
        DG_historial.TabIndex = 30
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Width = 35
        ' 
        ' Producto
        ' 
        Producto.HeaderText = "Producto"
        Producto.Name = "Producto"
        Producto.ReadOnly = True
        Producto.Width = 85
        ' 
        ' Cambio
        ' 
        Cambio.HeaderText = "Cambio"
        Cambio.Name = "Cambio"
        Cambio.ReadOnly = True
        Cambio.Width = 55
        ' 
        ' Inventario
        ' 
        Inventario.HeaderText = "Inventario"
        Inventario.Name = "Inventario"
        Inventario.ReadOnly = True
        Inventario.Width = 70
        ' 
        ' CB_producto
        ' 
        CB_producto.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CB_producto.DropDownStyle = ComboBoxStyle.DropDownList
        CB_producto.FormattingEnabled = True
        CB_producto.Location = New Point(162, 98)
        CB_producto.Name = "CB_producto"
        CB_producto.Size = New Size(168, 23)
        CB_producto.TabIndex = 31
        ' 
        ' TB_cantidad
        ' 
        TB_cantidad.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TB_cantidad.BorderStyle = BorderStyle.None
        TB_cantidad.Location = New Point(359, 102)
        TB_cantidad.Name = "TB_cantidad"
        TB_cantidad.Size = New Size(56, 16)
        TB_cantidad.TabIndex = 32
        TB_cantidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' BT_añadir
        ' 
        BT_añadir.BackColor = Color.FromArgb(CByte(0), CByte(191), CByte(99))
        BT_añadir.FlatAppearance.BorderSize = 0
        BT_añadir.FlatStyle = FlatStyle.Flat
        BT_añadir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_añadir.ForeColor = Color.White
        BT_añadir.Location = New Point(277, 134)
        BT_añadir.Name = "BT_añadir"
        BT_añadir.Size = New Size(56, 26)
        BT_añadir.TabIndex = 33
        BT_añadir.Text = "Añadir"
        BT_añadir.UseVisualStyleBackColor = False
        ' 
        ' BT_quitar
        ' 
        BT_quitar.BackColor = Color.FromArgb(CByte(255), CByte(49), CByte(49))
        BT_quitar.FlatAppearance.BorderSize = 0
        BT_quitar.FlatStyle = FlatStyle.Flat
        BT_quitar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BT_quitar.ForeColor = Color.White
        BT_quitar.Location = New Point(358, 134)
        BT_quitar.Name = "BT_quitar"
        BT_quitar.Size = New Size(56, 26)
        BT_quitar.TabIndex = 34
        BT_quitar.Text = "Quitar"
        BT_quitar.UseVisualStyleBackColor = False
        ' 
        ' TB_id_producto
        ' 
        TB_id_producto.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TB_id_producto.BorderStyle = BorderStyle.None
        TB_id_producto.Location = New Point(170, 139)
        TB_id_producto.Name = "TB_id_producto"
        TB_id_producto.Size = New Size(56, 16)
        TB_id_producto.TabIndex = 35
        TB_id_producto.TextAlign = HorizontalAlignment.Center
        ' 
        ' BT_caja
        ' 
        BT_caja.BackColor = Color.White
        BT_caja.Image = CType(resources.GetObject("BT_caja.Image"), Image)
        BT_caja.Location = New Point(26, 421)
        BT_caja.Name = "BT_caja"
        BT_caja.Size = New Size(74, 22)
        BT_caja.SizeMode = PictureBoxSizeMode.StretchImage
        BT_caja.TabIndex = 36
        BT_caja.TabStop = False
        ' 
        ' BT_inv
        ' 
        BT_inv.BackColor = Color.White
        BT_inv.Image = CType(resources.GetObject("BT_inv.Image"), Image)
        BT_inv.Location = New Point(106, 421)
        BT_inv.Name = "BT_inv"
        BT_inv.Size = New Size(91, 22)
        BT_inv.SizeMode = PictureBoxSizeMode.StretchImage
        BT_inv.TabIndex = 37
        BT_inv.TabStop = False
        ' 
        ' BT_ventas
        ' 
        BT_ventas.BackColor = Color.White
        BT_ventas.Image = CType(resources.GetObject("BT_ventas.Image"), Image)
        BT_ventas.Location = New Point(203, 421)
        BT_ventas.Name = "BT_ventas"
        BT_ventas.Size = New Size(74, 22)
        BT_ventas.SizeMode = PictureBoxSizeMode.StretchImage
        BT_ventas.TabIndex = 38
        BT_ventas.TabStop = False
        ' 
        ' LB_usuario
        ' 
        LB_usuario.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        LB_usuario.ForeColor = Color.White
        LB_usuario.Location = New Point(537, 15)
        LB_usuario.Name = "LB_usuario"
        LB_usuario.Size = New Size(183, 24)
        LB_usuario.TabIndex = 39
        LB_usuario.Text = "Cajero"
        LB_usuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LB_usuario)
        Controls.Add(BT_ventas)
        Controls.Add(BT_inv)
        Controls.Add(BT_caja)
        Controls.Add(TB_id_producto)
        Controls.Add(BT_quitar)
        Controls.Add(BT_añadir)
        Controls.Add(TB_cantidad)
        Controls.Add(CB_producto)
        Controls.Add(DG_historial)
        Controls.Add(DG_inventario)
        Controls.Add(BT_cambiarUsuario)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventario"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).EndInit()
        CType(DG_inventario, ComponentModel.ISupportInitialize).EndInit()
        CType(DG_historial, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BT_cambiarUsuario As PictureBox
    Friend WithEvents DG_inventario As DataGridView
    Friend WithEvents DG_historial As DataGridView
    Friend WithEvents CB_producto As ComboBox
    Friend WithEvents TB_cantidad As TextBox
    Friend WithEvents BT_añadir As Button
    Friend WithEvents BT_quitar As Button
    Friend WithEvents TB_id_producto As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cambio As DataGridViewTextBoxColumn
    Friend WithEvents Inventario As DataGridViewTextBoxColumn
    Friend WithEvents BT_caja As PictureBox
    Friend WithEvents BT_inv As PictureBox
    Friend WithEvents BT_ventas As PictureBox
    Friend WithEvents LB_usuario As Label
End Class
