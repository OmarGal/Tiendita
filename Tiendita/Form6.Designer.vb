<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form6))
        PictureBox1 = New PictureBox()
        LB_usuario = New Label()
        BT_cambiarUsuario = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1366, 705)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LB_usuario
        ' 
        LB_usuario.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        LB_usuario.ForeColor = Color.White
        LB_usuario.Location = New Point(952, 31)
        LB_usuario.Name = "LB_usuario"
        LB_usuario.Size = New Size(183, 24)
        LB_usuario.TabIndex = 45
        LB_usuario.Text = "Cajero"
        LB_usuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BT_cambiarUsuario
        ' 
        BT_cambiarUsuario.BackColor = Color.FromArgb(CByte(82), CByte(113), CByte(255))
        BT_cambiarUsuario.Image = CType(resources.GetObject("BT_cambiarUsuario.Image"), Image)
        BT_cambiarUsuario.Location = New Point(1297, 17)
        BT_cambiarUsuario.Name = "BT_cambiarUsuario"
        BT_cambiarUsuario.Size = New Size(51, 49)
        BT_cambiarUsuario.SizeMode = PictureBoxSizeMode.StretchImage
        BT_cambiarUsuario.TabIndex = 44
        BT_cambiarUsuario.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Open Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(85, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 22)
        Label1.TabIndex = 46
        Label1.Text = "Nombre:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Open Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 22)
        Label2.TabIndex = 47
        Label2.Text = "Precio:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Open Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(73, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 22)
        Label3.TabIndex = 48
        Label3.Text = "Inventario:"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(186, 142)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(160, 23)
        TextBox1.TabIndex = 49
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(186, 196)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(160, 23)
        TextBox2.TabIndex = 50
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(186, 250)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(160, 23)
        TextBox3.TabIndex = 51
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1366, 705)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LB_usuario)
        Controls.Add(BT_cambiarUsuario)
        Controls.Add(PictureBox1)
        Name = "Form6"
        Text = "Form6"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BT_cambiarUsuario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LB_usuario As Label
    Friend WithEvents BT_cambiarUsuario As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
