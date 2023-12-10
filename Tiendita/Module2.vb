Imports MySql.Data.MySqlClient

Module Module2

    Function AñadirHistorialInventario(Byval movimiento As String) As String
        Dim ID, inventario, nuevo_inventario As Integer
        Dim prod As String
        conn.Open()
        If (Form4.TB_id_producto.Text = "") Then
            cmd.CommandText = "SELECT * FROM `rayito`.`productos` WHERE Producto='" & Form4.CB_producto.Text & "'"
        Else
            cmd.CommandText = "SELECT * FROM `rayito`.`productos` WHERE IDProducto='" & Form4.TB_id_producto.Text & "'"
        End If
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read
            ID = rd.GetString("IDProducto")
            prod = rd.GetString("Producto")
            inventario = rd.GetString("Inventario")
        End While

        If (prod = "") Then
            MessageBox.Show("Producto con ID: " & Form4.TB_id_producto.Text & " ndao existe, intenta con otro ID", "Producto no existe", MessageBoxButtons.OK)
            rd.Close()
            conn.Close()
            Form4.TB_id_producto.Text = ""
            Return "Nada"
        End If

        If (movimiento = "agregar") Then
          nuevo_inventario = inventario + Form4.TB_cantidad.Text
          Form4.DG_historial.Rows.Add(ID, prod, "+" & Form4.TB_cantidad.Text, nuevo_inventario)
        Else If (movimiento = "remover") Then
          nuevo_inventario = inventario - Form4.TB_cantidad.Text
          Form4.DG_historial.Rows.Add(ID, prod, "-" & Form4.TB_cantidad.Text, nuevo_inventario)
        End IF

        rd.Close()
        conn.Close()
        CambiarInventario(ID, Form4.TB_cantidad.Text, movimiento)
        Form4.TB_id_producto.Text = ""
        Form4.TB_cantidad.Text = ""
    End Function

    Function CambiarInventario(ByVal id As Integer, ByVal cantidad As Integer, Byval movimiento As String)
        Dim update As String
        conn.Open()

        If (movimiento = "agregar") Then
          update = "UPDATE `rayito`.`productos` SET Inventario=Inventario+@cuanto WHERE `IDProducto`=@cual"
        Else If (movimiento = "remover") Then
          update = "UPDATE `rayito`.`productos` SET Inventario=Inventario-@cuanto WHERE `IDProducto`=@cual"
        End If
        Dim mysc2 As New MySqlCommand(update, conn)
        mysc2.CommandText = update
        mysc2.Parameters.AddWithValue("@cuanto", cantidad)
        mysc2.Parameters.AddWithValue("@cual", id)
        mysc2.Connection = conn
        mysc2.ExecuteNonQuery()

        conn.Close()
        ActualizarInventarioDG()
    End Function

    Function ActualizarInventarioDG()
        Try
            Dim sqlcommand As New MySqlCommand
            Dim sqlDataAdapter As New MySqlDataAdapter
            Dim dt As New DataTable
            Dim bSource As New BindingSource

            conn.Open()
            Dim query As String
            query = "SELECT * FROM `rayito`.`productos`"
            sqlcommand = New MySqlCommand(query, conn)
            sqlDataAdapter.SelectCommand = sqlcommand
            sqlDataAdapter.Fill(dt)
            bSource.DataSource = dt
            Form4.DG_inventario.DataSource = bSource
            sqlDataAdapter.Update(dt)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Function

    Function ActualizarCBInv()
        Form4.CB_producto.Items.Clear()
        conn.Open()
        cmd.CommandText = "SELECT Producto FROM `rayito`.`productos`"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            Dim prod As String = rd.GetString("Producto")
            Form4.CB_producto.Items.Add(prod)

        End While

        rd.Close()
        conn.Close()
    End Function

    Function LimpiarForm4()
      Form4.CB_producto.SelectedItem = Nothing
      Form4.TB_cantidad.Text = ""
      Form4.TB_id_producto.Text = ""
      Form4.CB_producto.Text = ""
      Form4.DG_historial.Rows.Clear()
    End Function

End Module
