<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        PictureBox1 = New PictureBox()
        DG_ventas = New DataGridView()
        DG_ventasproductos = New DataGridView()
        BT_ventas = New PictureBox()
        BT_inv = New PictureBox()
        BT_caja = New PictureBox()
        BT_cambiarUsuario = New PictureBox()
        LB_usuario = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_ventas, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_ventasproductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1366, 705)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DG_ventas
        ' 
        DG_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DG_ventas.Location = New Point(87, 299)
        DG_ventas.Name = "DG_ventas"
        DG_ventas.ReadOnly = True
        DG_ventas.RowHeadersVisible = False
        DG_ventas.RowTemplate.Height = 25
        DG_ventas.Size = New Size(601, 334)
        DG_ventas.TabIndex = 1
        ' 
        ' DG_ventasproductos
        ' 
        DG_ventasproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DG_ventasproductos.Location = New Point(854, 299)
        DG_ventasproductos.Name = "DG_ventasproductos"
        DG_ventasproductos.ReadOnly = True
        DG_ventasproductos.RowHeadersVisible = False
        DG_ventasproductos.RowTemplate.Height = 25
        DG_ventasproductos.Size = New Size(417, 334)
        DG_ventasproductos.TabIndex = 2
        ' 
        ' BT_ventas
        ' 
        BT_ventas.BackColor = Color.White
        BT_ventas.Image = CType(resources.GetObject("BT_ventas.Image"), Image)
        BT_ventas.Location = New Point(301, 664)
        BT_ventas.Name = "BT_ventas"
        BT_ventas.Size = New Size(105, 29)
        BT_ventas.SizeMode = PictureBoxSizeMode.StretchImage
        BT_ventas.TabIndex = 41
        BT_ventas.TabStop = False
        ' 
        ' BT_inv
        ' 
        BT_inv.BackColor = Color.White
        BT_inv.Image = CType(resources.GetObject("BT_inv.Image"), Image)
        BT_inv.Location = New Point(167, 664)
        BT_inv.Name = "BT_inv"
        BT_inv.Size = New Size(114, 29)
        BT_inv.SizeMode = PictureBoxSizeMode.StretchImage
        BT_inv.TabIndex = 40
        BT_inv.TabStop = False
        ' 
        ' BT_caja
        ' 
        BT_caja.BackColor = Color.White
        BT_caja.Image = CType(resources.GetObject("BT_caja.Image"), Image)
        BT_caja.Location = New Point(37, 664)
        BT_caja.Name = "BT_caja"
        BT_caja.Size = New Size(109, 29)
        BT_caja.SizeMode = PictureBoxSizeMode.StretchImage
        BT_caja.TabIndex = 39
        BT_caja.TabStop = False
        ' 
        ' BT_cambiarUsuario
        ' 
        BT_cambiarUsuario.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        BT_cambiarUsuario.Image = CType(resources.GetObject("BT_cambiarUsuario.Image"), Image)
        BT_cambiarUsuario.Location = New Point(1284, 12)
        BT_cambiarUsuario.Name = "BT_cambiarUsuario"
        BT_cambiarUsuario.Size = New Size(51, 49)
        BT_cambiarUsuario.SizeMode = PictureBoxSizeMode.StretchImage
        BT_cambiarUsuario.TabIndex = 42
        BT_cambiarUsuario.TabStop = False
        ' 
        ' LB_usuario
        ' 
        LB_usuario.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        LB_usuario.ForeColor = Color.White
        LB_usuario.Location = New Point(939, 26)
        LB_usuario.Name = "LB_usuario"
        LB_usuario.Size = New Size(183, 24)
        LB_usuario.TabIndex = 43
        LB_usuario.Text = "Cajero"
        LB_usuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form5
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1366, 705)
        Controls.Add(LB_usuario)
        Controls.Add(BT_cambiarUsuario)
        Controls.Add(BT_ventas)
        Controls.Add(BT_inv)
        Controls.Add(BT_caja)
        Controls.Add(DG_ventasproductos)
        Controls.Add(DG_ventas)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form5"
        Text = "Ventas"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DG_ventas, ComponentModel.ISupportInitialize).EndInit()
        CType(DG_ventasproductos, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_ventas, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_inv, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_caja, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DG_ventas As DataGridView
    Friend WithEvents DG_ventasproductos As DataGridView
    Friend WithEvents BT_ventas As PictureBox
    Friend WithEvents BT_inv As PictureBox
    Friend WithEvents BT_caja As PictureBox
    Friend WithEvents BT_cambiarUsuario As PictureBox
    Friend WithEvents LB_usuario As Label
End Class
