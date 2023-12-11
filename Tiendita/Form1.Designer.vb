<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TB_contra = New TextBox()
        TB_usuario = New TextBox()
        BT_aceptar = New Button()
        LB_contra = New Label()
        BT_cerrar = New Button()
        PictureBox1 = New PictureBox()
        CB_usuario = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TB_contra
        ' 
        TB_contra.BackColor = Color.FromArgb(CByte(72), CByte(74), CByte(74))
        TB_contra.BorderStyle = BorderStyle.None
        TB_contra.ForeColor = Color.White
        TB_contra.Location = New Point(86, 388)
        TB_contra.Name = "TB_contra"
        TB_contra.PasswordChar = "*"c
        TB_contra.Size = New Size(139, 16)
        TB_contra.TabIndex = 1
        ' 
        ' TB_usuario
        ' 
        TB_usuario.BackColor = Color.FromArgb(CByte(72), CByte(74), CByte(74))
        TB_usuario.BorderStyle = BorderStyle.None
        TB_usuario.ForeColor = Color.White
        TB_usuario.Location = New Point(86, 344)
        TB_usuario.Name = "TB_usuario"
        TB_usuario.Size = New Size(139, 16)
        TB_usuario.TabIndex = 0
        ' 
        ' BT_aceptar
        ' 
        BT_aceptar.BackColor = Color.FromArgb(CByte(0), CByte(74), CByte(173))
        BT_aceptar.FlatAppearance.BorderSize = 0
        BT_aceptar.FlatStyle = FlatStyle.Flat
        BT_aceptar.ForeColor = Color.FromArgb(CByte(28), CByte(33), CByte(32))
        BT_aceptar.Location = New Point(83, 419)
        BT_aceptar.Name = "BT_aceptar"
        BT_aceptar.Size = New Size(142, 27)
        BT_aceptar.TabIndex = 7
        BT_aceptar.Text = "Aceptar"
        BT_aceptar.UseVisualStyleBackColor = False
        ' 
        ' LB_contra
        ' 
        LB_contra.AutoSize = True
        LB_contra.BackColor = Color.FromArgb(CByte(28), CByte(33), CByte(32))
        LB_contra.ForeColor = Color.White
        LB_contra.Location = New Point(247, 390)
        LB_contra.Name = "LB_contra"
        LB_contra.Size = New Size(31, 15)
        LB_contra.TabIndex = 9
        LB_contra.Text = "1234"
        ' 
        ' BT_cerrar
        ' 
        BT_cerrar.Enabled = False
        BT_cerrar.Location = New Point(12, 12)
        BT_cerrar.Name = "BT_cerrar"
        BT_cerrar.Size = New Size(75, 23)
        BT_cerrar.TabIndex = 11
        BT_cerrar.Text = "Cerrar"
        BT_cerrar.UseVisualStyleBackColor = True
        BT_cerrar.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-9, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(322, 600)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' CB_usuario
        ' 
        CB_usuario.FormattingEnabled = True
        CB_usuario.Location = New Point(83, 340)
        CB_usuario.Name = "CB_usuario"
        CB_usuario.Size = New Size(142, 23)
        CB_usuario.TabIndex = 14
        ' 
        ' Form1
        ' 
        AcceptButton = BT_aceptar
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(306, 561)
        Controls.Add(CB_usuario)
        Controls.Add(BT_cerrar)
        Controls.Add(LB_contra)
        Controls.Add(BT_aceptar)
        Controls.Add(TB_contra)
        Controls.Add(TB_usuario)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesion"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TB_contra As TextBox
    Friend WithEvents TB_usuario As TextBox
    Friend WithEvents BT_aceptar As Button
    Friend WithEvents LB_contra As Label
    Friend WithEvents BT_cerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CB_usuario As ComboBox
End Class
