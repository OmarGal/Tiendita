Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        ClientSize = New Size(Me.Width, Me.Height)
        ActualizarVentasDG()
        ActualizarVentasProductosDG()
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

End Class