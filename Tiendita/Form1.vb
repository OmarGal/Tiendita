Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TB_usuario.Text = "Cajero1"
        TB_contra.Text = "1234"
        Form4.Show()

    End Sub

    Private Sub BT_aceptar_Click(sender As Object, e As EventArgs) Handles BT_aceptar.Click
        If Val(TB_contra.Text = LB_contra.Text) Then
            Form2.LB_usuario.Text = TB_usuario.Text
            Form2.LB_usuario.ForeColor = Color.White
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o contraseña incorrectos")
        End If

        TB_contra.Text = ""
        ActualizarProductosCB()
        ActualizarClientesCB()
    End Sub

    Private Sub BT_cerrar_Click(sender As Object, e As EventArgs) Handles BT_cerrar.Click
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

End Class
