Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Module Module1
    Public ids As New List(Of Integer)
    Public inventarios As New List(Of Integer)
    Public precio, total_unitario, subtotal, total, descuento As Double
    Public porcentaje As Integer
    Public ultimo_producto As String
    Public venta_incompleta As Boolean = False

    Function ActualizarProductosCB()
        Form2.CB_producto.Items.Clear()
        conn.Open()
        cmd.CommandText = "SELECT Producto FROM `rayito`.`productos` WHERE Inventario>0"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            Dim prod As String = rd.GetString("Producto")
            Form2.CB_producto.Items.Add(prod)

        End While

        rd.Close()
        conn.Close()
    End Function

    Function ActualizarClientesCB()
        Form2.CB_cliente.Items.Clear()
        conn.Open()
        cmd.CommandText = "SELECT Nombre FROM `rayito`.`clientes`"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            StrVar = rd.GetString("Nombre")
            Form2.CB_cliente.Items.Add(StrVar)

        End While

        rd.Close()
        conn.Close()
    End Function

    Function AñadirProductoALista() As String
        'ActualizarProductosCB()
        Dim ID, inventario As Integer
        Dim prod As String
        conn.Open()
        If (Form2.TB_id_producto.Text = "") Then
            cmd.CommandText = "SELECT * FROM `rayito`.`productos` WHERE Producto='" & Form2.CB_producto.Text & "'"
        Else
            cmd.CommandText = "SELECT * FROM `rayito`.`productos` WHERE IDProducto='" & Form2.TB_id_producto.Text & "'"
        End If
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read
            ID = rd.GetString("IDProducto")
            prod = rd.GetString("Producto")
            precio = rd.GetString("Precio")
            inventario = rd.GetString("Inventario")
        End While

        If (prod = "") Then
            MessageBox.Show("Producto con ID: " & Form2.TB_id_producto.Text & " no existe, intenta con otro ID", "Producto no existe", MessageBoxButtons.OK)
            rd.Close()
            conn.Close()
            Form2.TB_id_producto.Text = ""
            Return "Nada"
        End If

        ultimo_producto = prod

        If (Form2.TB_cantidad.Text > inventario) Then
            MessageBox.Show(prod & ": " & inventario & " piezas disponibles.", "No se agrego producto", MessageBoxButtons.OK)
            rd.Close()
            conn.Close()
            Return "Nada"
        End If

        ids.Add(ID)
        inventarios.Add(inventario)
        total_unitario = precio * Form2.TB_cantidad.Text
        subtotal += total_unitario
        CalcularDescuento()
        Form2.tabla.Rows.Add(ID, prod, "$" & precio, Form2.TB_cantidad.Text, "$" & total_unitario)

        rd.Close()
        conn.Close()
        Form2.TB_id_producto.Text = ""
        RemoverInventario(ID, Form2.TB_cantidad.Text)
    End Function

    Function RemoverInventario(ByVal id As Integer, ByVal cantidad As Integer)
        Dim update As String
        conn.Open()

        update = "UPDATE `rayito`.`productos` SET Inventario=Inventario-@cuanto WHERE `IDProducto`=@cual"
        Dim mysc2 As New MySqlCommand(update, conn)
        mysc2.CommandText = update
        mysc2.Parameters.AddWithValue("@cuanto", cantidad)
        mysc2.Parameters.AddWithValue("@cual", id)
        mysc2.Connection = conn
        mysc2.ExecuteNonQuery()

        conn.Close()
        ActualizarProductosCB()
    End Function

    Function AñadirInventario()
        Dim update As String
        Dim id, cuanto As Integer
        conn.Open()

        For i As Integer = 0 To ids.Count - 1
            id = ids.Item(i)
            cuanto = inventarios.Item(i)
            update = "UPDATE `rayito`.`productos` SET Inventario=@cuanto WHERE `IDProducto`=@cual"
            Dim mysc2 As New MySqlCommand(update, conn)
            mysc2.CommandText = update
            mysc2.Parameters.AddWithValue("@cuanto", inventarios.Item(i))
            mysc2.Parameters.AddWithValue("@cual", ids.Item(i))
            mysc2.Connection = conn
            mysc2.ExecuteNonQuery()
        Next i

        conn.Close()
        ActualizarProductosCB()
        ids.Clear()
        inventarios.Clear()
        LimpiarTicket()
    End Function

    Function LimpiarForm2()
        subtotal = 0
        total = 0
        Form2.CB_producto.SelectedItem = Nothing
        Form2.TB_id_producto.Text = ""
        Form2.TB_cantidad.Text = ""
        Form2.LB_subtotal.Text = "$0"
        Form2.LB_descuento.Text = "$0"
        Form2.LB_total.Text = "$0"
        LimpiarCliente()
        Form2.tabla.Rows.Clear()

    End Function

    Function LimpiarCliente()
        porcentaje = 0
        Form2.CB_cliente.SelectedItem = Nothing
        Form2.TB_id_cliente.Text = ""
        Form2.LB_descuento.Text = ""
        CalcularDescuento()
    End Function

    Function CalcularDescuento()
        descuento = subtotal * (porcentaje / 100)
        total = subtotal - descuento
        Form2.LB_descuento.Text = "$" & descuento
        Form2.LB_total.Text = "$" & total
    End Function

    Function AñadirDescuento() As String
        Dim nombre As String
        conn.Open()
        If (Form2.TB_id_cliente.Text = "") Then
            cmd.CommandText = "SELECT * FROM `rayito`.`clientes` WHERE Nombre='" & Form2.CB_cliente.Text & "'"
        Else
            cmd.CommandText = "SELECT * FROM `rayito`.`clientes` WHERE IDCliente='" & Form2.TB_id_cliente.Text & "'"
        End If
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read
            nombre = rd.GetString("Nombre")
            porcentaje = rd.GetString("Descuento")
        End While

        If (nombre = "") Then
            MessageBox.Show("Cliente con ID: " & Form2.TB_id_cliente.Text & " no existe, intenta con otro ID", "Cliente no existe", MessageBoxButtons.OK)
            rd.Close()
            conn.Close()
            Form2.TB_id_cliente.Text = ""
            Return "Nada"
        End If

        CalcularDescuento()

        rd.Close()
        conn.Close()
        Form2.CB_cliente.SelectedItem = nombre
        Form2.TB_id_cliente.Text = ""
    End Function

    Function EsValorInt(ByVal str As String) As Boolean
        Dim Int_var As Integer
        If Integer.TryParse(str, Int_var) Then
            If (Int_var <= 0) Then
                Return False
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Function LimpiarTicket()
        Form3.LB_cajero.Text = ""
        Form3.fecha.Text = ""
        Form3.LB_subtotal.Text = "$0"
        Form3.LB_descuento.Text = "$0"
        Form3.LB_total.Text = "$0"
        Form3.LB_cliente.Text = ""
        Form3.LB_cantidad.Items.Clear()
        Form3.LB_articulos.Items.Clear()
        Form3.LB_precio.Items.Clear()
    End Function

End Module
