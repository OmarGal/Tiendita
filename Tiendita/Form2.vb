Imports MySql.Data.MySqlClient

Public Class Form2
    ' 
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
    ' 
    Dim switch As Boolean = False

    Private Sub CB_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_cliente.SelectedIndexChanged
        If (switch = False) Then
            switch = True
            TB_id_cliente.Text = Nothing
        End If
        switch = False
    End Sub
    Private Sub CB_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_producto.SelectedIndexChanged
        If (switch = False) Then
            switch = True
            TB_id_producto.Text = Nothing
        End If
        switch = False
    End Sub

    Private Sub TB_id_cliente_TextChanged(sender As Object, e As EventArgs) Handles TB_id_cliente.TextChanged
        If (switch = False) Then
            switch = True
            CB_cliente.SelectedItem = Nothing
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

    Private Sub BT_cancelar_Click(sender As Object, e As EventArgs) Handles BT_cancelar.Click
        If (venta_incompleta = True) Then
            Select Case MsgBox("¿Seguro que quieres cancelar la venta actual?", MsgBoxStyle.YesNo, "Cancelar venta")
                Case MsgBoxResult.Yes
                Case MsgBoxResult.No
                    Exit Sub
            End Select

            AñadirInventario()
            venta_incompleta = False
        End If
        LimpiarForm2()
        LimpiarCliente()
    End Sub

    Private Sub BT_añadir_Click(sender As Object, e As EventArgs) Handles BT_añadir.Click
        Dim esIntCantidad As Boolean = EsValorInt(TB_cantidad.Text)
        Dim esInt_IDProducto As Boolean = EsValorInt(TB_id_producto.Text)

        ' If (esIntCantidad = False And (esInt_IDProducto = False And CB_producto.Text = "")) = False Then
        '     MessageBox.Show("Campos cantidad o producto ID son incorrectos, intenta de nuevo", "Valores incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '     TB_cantidad.Text = ""
        '     Exit Sub
        ' End If

        If (esIntCantidad = False And esInt_IDProducto = False And CB_producto.Text = "") Then
            MessageBox.Show("Selecciona un producto y cantidad para poder añadir a la lista", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_cantidad.Text = ""
            TB_id_producto.Text = ""
            Exit Sub
        ElseIf (esIntCantidad = False) Then
            MessageBox.Show("Cantidad tiene que ser un numero entero mayor a 0", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_cantidad.Text = ""
            Exit Sub
        ElseIf (esInt_IDProducto = False And CB_producto.Text = "") Then
            MessageBox.Show("No hay producto seleccionado o la ID de producto es incorrecta", "No se pudo agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_id_producto.Text = ""
            Exit Sub
        End If

        Dim respuesta As String = AñadirProductoALista()

        If (respuesta = "Nada") Then
            Exit Sub
        End If

        venta_incompleta = True

        LB_subtotal.Text = "$" & Module1.subtotal
        Form3.LB_articulos.Items.Add(ultimo_producto)
        Form3.LB_cantidad.Items.Add(TB_cantidad.Text)
        Form3.LB_precio.Items.Add("$" & total_unitario)

        ActualizarProductosCB()
        CB_producto.SelectedItem = ultimo_producto
    End Sub

    Private Sub BT_aceptar_Click(sender As Object, e As EventArgs) Handles BT_aceptar.Click
        If (venta_incompleta = False) Then
            Exit Sub
        End If

        venta_incompleta = False
        Dim thisDate, currentTime As Date
        thisDate = Today
        currentTime = TimeOfDay

        ids.Clear()
        inventarios.Clear()

        Form3.LB_cajero.Text = Form1.TB_usuario.Text
        Form3.fecha.Text = thisDate + ", " + TimeOfDay

        Form3.LB_subtotal.Text = "$" & Module1.subtotal
        Form3.LB_descuento.Text = "$" & Module1.descuento
        Form3.LB_total.Text = "$" & Module1.total
        Form3.LB_cliente.Text = CB_cliente.Text

        Form3.ShowDialog()

    End Sub

    Private Sub Form2_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub BT_cambiarUsuario_Click(sender As Object, e As EventArgs) Handles BT_cambiarUsuario.Click
        If (venta_incompleta = True) Then
            venta_incompleta = False
            Select Case MsgBox("¿Seguro que quieres cancelar la venta actual?", MsgBoxStyle.YesNo, "Cerrar sesion")
                Case MsgBoxResult.Yes
                    AñadirInventario()
                    Me.Hide()
                    Form1.Show()
                    LimpiarForm2()
                Case MsgBoxResult.No
            End Select
        Else
            Select Case MsgBox("¿Seguro que quieres cerrar sesion?", MsgBoxStyle.YesNo, "Cerrar sesion")
                Case MsgBoxResult.Yes
                    AñadirInventario()
                    Me.Hide()
                    Form1.Show()
                    LimpiarForm2()
                Case MsgBoxResult.No
            End Select
        End If
    End Sub

    Private Sub BT_cliente_agregar_Click(sender As Object, e As EventArgs) Handles BT_cliente_agregar.Click
        Dim esInt As Boolean = EsValorInt(TB_id_cliente.Text)
        If (CB_cliente.Text = "" And TB_id_cliente.Text = "") Then
            Exit Sub
        ElseIf (esInt = False And CB_cliente.Text = "") Then
            MessageBox.Show("ID de cliente es incorrecto, intenta de nuevo", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_id_cliente.Text = ""
            Exit Sub
        End If

        AñadirDescuento()
    End Sub

    Private Sub BT_cliente_remover_Click(sender As Object, e As EventArgs) Handles BT_cliente_remover.Click
        LimpiarCliente()
    End Sub
End Class