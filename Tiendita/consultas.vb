Imports MySql.Data.MySqlClient

Module consultas

    Function ActualizarVentasDG(Optional ByVal query As String = "SELECT ventas.IDVenta, ventas.Fecha, ventas.Hora, clientes.Nombre AS Cliente, ventas.Total, usuarios.Nombre AS Cajero FROM `rayito`.ventas, `rayito`.clientes, `rayito`.usuarios WHERE ventas.IDCliente = clientes.IDCliente AND ventas.IDUsuario = usuarios.IDUsuario")
        Try
            Dim sqlcommand As New MySqlCommand
            Dim sqlDataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            Dim bSource As New BindingSource

            conn.Open()
            sqlcommand = New MySqlCommand(query, conn)
            sqlDataAdapter.SelectCommand = sqlcommand
            sqlDataAdapter.Fill(dt)
            bSource.DataSource = dt
            Form5.DG_ventas.DataSource = bSource
            sqlDataAdapter.Update(dt)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Function ActualizarVentasProductosDG(Optional ByVal query As String = "SELECT productos.IDProducto AS ID, productos.Producto, ventasproductos.Cantidad, ventasproductos.Subtotal FROM `rayito`.productos, `rayito`.ventasproductos WHERE ventasproductos.IDProducto = productos.IDProducto")
        Try
            Dim sqlcommand As New MySqlCommand
            Dim sqlDataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            Dim bSource As New BindingSource

            conn.Open()
            sqlcommand = New MySqlCommand(query, conn)
            sqlDataAdapter.SelectCommand = sqlcommand
            sqlDataAdapter.Fill(dt)
            bSource.DataSource = dt
            Form5.DG_ventasproductos.DataSource = bSource
            sqlDataAdapter.Update(dt)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function


End Module
