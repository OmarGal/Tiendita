Public Class Form4
    ' Cambiar tamano 
    Dim CurWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If (Me.Height < 489) Then
            Exit Sub
        End If

        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CurWidth) / CurWidth

        For Each CtrL As Control In Controls
            CtrL.Width += CtrL.Width * RatioWidth
            CtrL.Left += CtrL.Left * RatioWidth
            CtrL.Top += CtrL.Top * RatioHeight
            CtrL.Height += CtrL.Height * RatioHeight
        Next

        CuRHeight = Me.Height
        CurWidth = Me.Width
    End Sub

    Function CamposIncorrectos() As Boolean
        Dim esIntCantidad As Boolean = EsValorInt(TB_cantidad.Text)
        Dim esInt_IDProducto As Boolean = EsValorInt(TB_id_producto.Text)

        If (esIntCantidad = False And esInt_IDProducto = False And CB_producto.Text = "") Then
            MessageBox.Show("Selecciona un producto y cantidad para poder añadir a la lista", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_cantidad.Text = ""
            TB_id_producto.Text = ""
            Return True
        ElseIf (esIntCantidad = False) Then
            MessageBox.Show("Cantidad tiene que ser un numero entero mayor a 0", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_cantidad.Text = ""
            Return True
        ElseIf (esInt_IDProducto = False And CB_producto.Text = "") Then
            MessageBox.Show("No hay producto seleccionado o la ID de producto es incorrecta", "No se pudo agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_id_producto.Text = ""
            Return True
        End If
        Return False
    End Function
    ' 

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarCBInv()
        ActualizarInventarioDG()
    End Sub

    Private Sub BT_añadir_Click(sender As Object, e As EventArgs) Handles BT_añadir.Click
        If (CamposIncorrectos() = True) Then
            Exit Sub
        End If

        Dim respuesta As String = AñadirHistorialInventario("agregar")
        If (respuesta = "Nada") Then
            Exit Sub
        End If

    End Sub

    Private Sub BT_quitar_Click(sender As Object, e As EventArgs) Handles BT_quitar.Click
        If (CamposIncorrectos() = True) Then
            Exit Sub
        End If

        Dim respuesta As String = AñadirHistorialInventario("remover")
        If (respuesta = "Nada") Then
            Exit Sub
        End If

    End Sub

    Private Sub BT_cambiarUsuario_Click(sender As Object, e As EventArgs) Handles BT_cambiarUsuario.Click
        Select Case MsgBox("¿Seguro que quieres cerrar sesion?", MsgBoxStyle.YesNo, "Cerrar sesion")
            Case MsgBoxResult.Yes
                Me.Hide()
                Form1.Show()
                LimpiarForm2()
            Case MsgBoxResult.No
        End Select
    End Sub

    ' Limpiar TextBox o ComboBox al escoger un producto
    Dim switch As Boolean = False
    Private Sub CB_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_producto.SelectedIndexChanged
        If (switch = False) Then
            switch = True
            TB_id_producto.Text = Nothing
        End If
        switch = False
    End Sub
    Private Sub TB_id_producto_TextChanged(sender As Object, e As EventArgs) Handles TB_id_producto.TextChanged
        If (switch = False) Then
            switch = True
            CB_producto.SelectedItem = Nothing
        End If
        switch = False
    End Sub
    ' 

    Private Sub Form4_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (venta_incompleta = True) Then
            Select Case MsgBox("¿Seguro que quieres cancelar la venta actual?", MsgBoxStyle.YesNo, "Cerrar aplicacion")
                Case MsgBoxResult.Yes
                    AñadirInventario()
                    End
                Case MsgBoxResult.No
                    e.Cancel = True
            End Select
        Else
            End
        End If
    End Sub

    Private Sub BT_caja_Click(sender As Object, e As EventArgs) Handles BT_caja.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub BT_inv_Click(sender As Object, e As EventArgs) Handles BT_inv.Click

    End Sub

    Private Sub BT_ventas_Click(sender As Object, e As EventArgs) Handles BT_ventas.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class