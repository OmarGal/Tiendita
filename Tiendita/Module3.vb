Imports MySql.Data.MySqlClient

Module Module3
    Dim lst_IDProducto, lst_Cantidad As New List(Of Integer)
    Dim lst_subtotal As New List(Of Double)
    Dim IDVenta_actual As Integer = 0

    ' Esta funcion enlista todos los datos necesarios para llenar la tabla `ventasproductos`
    Function EnlistarDatosVentasProductos(ByVal IDProducto As Integer, ByVal cantidad As Integer, ByVal subtotal As Double)
        lst_IDProducto.Add(IDProducto)
        lst_Cantidad.Add(cantidad)
        lst_subtotal.Add(subtotal)
    End Function

    Function NuevaVentaProducto()
        Dim insert As String
        Dim id, cuanto As Integer

        conn.Open()

        For i As Integer = 0 To lst_IDProducto.Count - 1
            id = ids.Item(i)
            cuanto = inventarios.Item(i)
            ' update = "UPDATE `rayito`.`productos` SET Inventario=@cuanto WHERE `IDProducto`=@cual"
            insert = "INSERT INTO `rayito`.`ventasproductos` (`IDProducto`, `Cantidad`, `Subtotal`, `IDVenta`) VALUES (@producto, @cantidad, @subtotal, @venta)"
            Dim mysc2 As New MySqlCommand(insert, conn)
            mysc2.CommandText = insert
            mysc2.Parameters.AddWithValue("@producto", lst_IDProducto.Item(i))
            mysc2.Parameters.AddWithValue("@cantidad", lst_Cantidad.Item(i))
            mysc2.Parameters.AddWithValue("@subtotal", lst_subtotal.Item(i))
            mysc2.Parameters.AddWithValue("@venta", IDVenta_actual)
            mysc2.Connection = conn
            mysc2.ExecuteNonQuery()
        Next i

        conn.Close()

    End Function

    ' Esta funcion enlista los datos para llenar la tabla `ventas`
    Function NuevaVenta(ByVal total As Double, ByVal fecha As String, ByVal hora As String, ByVal usuario As Integer, ByVal cliente As Integer)
        Dim insert As String
        conn.Open()

        ' update = "UPDATE `rayito`.`productos` SET Inventario=Inventario-@cuanto WHERE `IDProducto`=@cual"
        insert = "INSERT INTO `rayito`.`ventas` (`Total`, `Fecha`, `Hora`, `IDUsuario`, `IDCliente`) VALUES (@total, @fecha, @hora, @usuario, @cliente)"
        Dim mysc2 As New MySqlCommand(insert, conn)
        mysc2.CommandText = insert
        mysc2.Parameters.AddWithValue("@total", total)
        mysc2.Parameters.AddWithValue("@fecha", fecha)
        mysc2.Parameters.AddWithValue("@hora", hora)
        mysc2.Parameters.AddWithValue("@usuario", usuario)
        mysc2.Parameters.AddWithValue("@cliente", cliente)
        mysc2.Connection = conn
        mysc2.ExecuteNonQuery()

        conn.Close()

        IDVenta_actual = ObtenerUltimaVenta()
        NuevaVentaProducto()
        LimpiarModule3()

    End Function

    Function LimpiarModule3()
        lst_IDProducto.Clear()
        lst_Cantidad.Clear()
        lst_subtotal.Clear()
        IDVenta_actual = 0
        IDCliente_comprando = 0
    End Function

    Function ObtenerUltimaVenta() As Integer
        Dim ID As Integer
        conn.Open()
        cmd.CommandText = "SELECT `IDVenta` FROM `rayito`.`ventas` WHERE IDVenta=(SELECT MAX(IDVenta) FROM `rayito`.`ventas`);"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            ID = rd.GetString("IDVenta")

        End While

        rd.Close()
        conn.Close()
        Return ID
    End Function

    Function FormatoFechayHora()
        Dim fechahora As DateTime = DateTime.Now

        Form1.LB_contra.Text = fechahora.ToString("yyyy-MM-dd")
        Form1.LB_contra.Text = fechahora.ToString("HH:mm:ss")

    End Function

End Module
