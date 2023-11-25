<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        LB_cajero = New Label()
        fecha = New Label()
        LB_cantidad = New ListBox()
        LB_articulos = New ListBox()
        LB_precio = New ListBox()
        LB_subtotal = New Label()
        LB_cliente = New Label()
        LB_descuento = New Label()
        LB_total = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LB_cajero
        ' 
        LB_cajero.AutoSize = True
        LB_cajero.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(246))
        LB_cajero.Location = New Point(190, 73)
        LB_cajero.Name = "LB_cajero"
        LB_cajero.Size = New Size(41, 15)
        LB_cajero.TabIndex = 2
        LB_cajero.Text = "Cajero"
        ' 
        ' fecha
        ' 
        fecha.AutoSize = True
        fecha.BackColor = Color.FromArgb(CByte(247), CByte(247), CByte(246))
        fecha.Location = New Point(39, 73)
        fecha.Name = "fecha"
        fecha.Size = New Size(83, 15)
        fecha.TabIndex = 3
        fecha.Text = "04/11/23 11:15"
        ' 
        ' LB_cantidad
        ' 
        LB_cantidad.BackColor = Color.FromArgb(CByte(246), CByte(246), CByte(245))
        LB_cantidad.BorderStyle = BorderStyle.None
        LB_cantidad.FormattingEnabled = True
        LB_cantidad.ItemHeight = 15
        LB_cantidad.Location = New Point(27, 190)
        LB_cantidad.Name = "LB_cantidad"
        LB_cantidad.Size = New Size(32, 120)
        LB_cantidad.TabIndex = 5
        ' 
        ' LB_articulos
        ' 
        LB_articulos.BackColor = Color.FromArgb(CByte(239), CByte(240), CByte(239))
        LB_articulos.BorderStyle = BorderStyle.None
        LB_articulos.FormattingEnabled = True
        LB_articulos.ItemHeight = 15
        LB_articulos.Location = New Point(106, 190)
        LB_articulos.Name = "LB_articulos"
        LB_articulos.Size = New Size(102, 120)
        LB_articulos.TabIndex = 7
        ' 
        ' LB_precio
        ' 
        LB_precio.BackColor = Color.FromArgb(CByte(233), CByte(233), CByte(233))
        LB_precio.BorderStyle = BorderStyle.None
        LB_precio.FormattingEnabled = True
        LB_precio.ItemHeight = 15
        LB_precio.Location = New Point(233, 190)
        LB_precio.Name = "LB_precio"
        LB_precio.Size = New Size(55, 120)
        LB_precio.TabIndex = 9
        ' 
        ' LB_subtotal
        ' 
        LB_subtotal.AutoSize = True
        LB_subtotal.BackColor = Color.FromArgb(CByte(235), CByte(236), CByte(237))
        LB_subtotal.ImageAlign = ContentAlignment.MiddleRight
        LB_subtotal.Location = New Point(213, 340)
        LB_subtotal.Name = "LB_subtotal"
        LB_subtotal.Size = New Size(32, 15)
        LB_subtotal.TabIndex = 11
        LB_subtotal.Text = "Total"
        LB_subtotal.TextAlign = ContentAlignment.TopRight
        ' 
        ' LB_cliente
        ' 
        LB_cliente.AutoSize = True
        LB_cliente.BackColor = Color.FromArgb(CByte(244), CByte(188), CByte(33))
        LB_cliente.Location = New Point(120, 110)
        LB_cliente.Name = "LB_cliente"
        LB_cliente.Size = New Size(69, 15)
        LB_cliente.TabIndex = 13
        LB_cliente.Text = "Abcdf Ghijk"
        ' 
        ' LB_descuento
        ' 
        LB_descuento.AutoSize = True
        LB_descuento.BackColor = Color.FromArgb(CByte(235), CByte(236), CByte(237))
        LB_descuento.Location = New Point(213, 370)
        LB_descuento.Name = "LB_descuento"
        LB_descuento.Size = New Size(32, 15)
        LB_descuento.TabIndex = 17
        LB_descuento.Text = "Total"
        LB_descuento.TextAlign = ContentAlignment.TopRight
        ' 
        ' LB_total
        ' 
        LB_total.AutoSize = True
        LB_total.BackColor = Color.Black
        LB_total.ForeColor = Color.White
        LB_total.Location = New Point(213, 400)
        LB_total.Name = "LB_total"
        LB_total.Size = New Size(32, 15)
        LB_total.TabIndex = 19
        LB_total.Text = "Total"
        LB_total.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(333, 547)
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(334, 543)
        Controls.Add(LB_total)
        Controls.Add(LB_descuento)
        Controls.Add(LB_cliente)
        Controls.Add(LB_subtotal)
        Controls.Add(LB_precio)
        Controls.Add(LB_articulos)
        Controls.Add(LB_cantidad)
        Controls.Add(fecha)
        Controls.Add(LB_cajero)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        Text = "Recibo"
        TopMost = True
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LB_cajero As Label
    Friend WithEvents fecha As Label
    Friend WithEvents LB_cantidad As ListBox
    Friend WithEvents LB_articulos As ListBox
    Friend WithEvents LB_precio As ListBox
    Friend WithEvents LB_subtotal As Label
    Friend WithEvents LB_cliente As Label
    Friend WithEvents LB_descuento As Label
    Friend WithEvents LB_total As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
