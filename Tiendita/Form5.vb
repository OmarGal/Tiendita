Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        ClientSize = New Size(Me.Width, Me.Height)
        ActualizarVentasDG()
        ActualizarVentasProductosDG()
        ActualizarCategoriaFiltros()
    End Sub

    Private Sub Form5_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            ClientSize = New Size(Me.Width, Me.Height)
        End If
    End Sub

    Private Sub DG_ventas_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DG_ventas.CellMouseDoubleClick
        Dim index_seleccionado, id_venta_buscar As Integer
        Dim query, comando As String

        comando = "SELECT productos.IDProducto AS ID, productos.Producto, ventasproductos.Cantidad, ventasproductos.Subtotal FROM `rayito`.productos, `rayito`.ventasproductos WHERE ventasproductos.IDProducto = productos.IDProducto AND ventasproductos.IDVenta = "

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DG_ventas.Rows(e.RowIndex)
            index_seleccionado = DG_ventas.CurrentRow.Index

            Try
                id_venta_buscar = DG_ventas.Rows(index_seleccionado).Cells(0).Value
                query = comando & id_venta_buscar
                ActualizarVentasProductosDG(query)

            Catch ex As Exception
                Exit Sub
            End Try


        End If
    End Sub

    Private Sub Form5_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        Module1.ActualizarProductosCB()
        Module1.ActualizarClientesCB()
    End Sub

    Private Sub BT_inv_Click(sender As Object, e As EventArgs) Handles BT_inv.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub BT_ventas_Click(sender As Object, e As EventArgs) Handles BT_ventas.Click

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

    Private Sub BT_aceptar_Click(sender As Object, e As EventArgs) Handles BT_aceptar.Click
        FiltrarVentas()
    End Sub

    Private Sub BT_limpiar_Click(sender As Object, e As EventArgs) Handles BT_limpiar.Click
        LimpiarFiltro()
        ActualizarVentasDG()
        ActualizarVentasProductosDG()
        CB_datos.Enabled = False
    End Sub

    Private Sub CB_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_categoria.SelectedIndexChanged
        CB_datos.Enabled = True
        ActualizarDatosCB()
    End Sub

    Private Sub CK_fechas_CheckedChanged(sender As Object, e As EventArgs) Handles CK_fechas.CheckedChanged
        If CK_fechas.Checked = True Then
            DT_inicio.Enabled = True
            DT_final.Enabled = True
        Else
            DT_inicio.Enabled = False
            DT_final.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class