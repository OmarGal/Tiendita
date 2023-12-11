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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_ventas, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_ventasproductos, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Form5
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1366, 705)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DG_ventas As DataGridView
    Friend WithEvents DG_ventasproductos As DataGridView
End Class
