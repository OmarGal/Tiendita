Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Module Module5
    Public categoria, query_filtrar As String

    Function ActualizarCategoriaFiltros()
        Form5.CB_categoria.Items.Clear()
        Form5.CB_categoria.Items.Add("Cliente")
        Form5.CB_categoria.Items.Add("Cajero")
    End Function

    Function ActualizarDatosCB()
        Form5.CB_datos.Items.Clear()
        conn.Open()
        categoria = Form5.CB_categoria.Text
        Select Case categoria
            Case "Cliente"
                cmd.CommandText = "SELECT Nombre FROM `rayito`.`clientes`"
            Case "Cajero"
                cmd.CommandText = "SELECT Nombre FROM `rayito`.`usuarios`"
        End Select
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            Dim nombre As String = rd.GetString("Nombre")
            Form5.CB_datos.Items.Add(nombre)

        End While

        rd.Close()
        conn.Close()
    End Function

    Function FiltrarVentas()
        If Form5.CB_datos.Text = "" Then
            Exit Function
        End If
        Dim ID As Integer
        Dim campoID As String
        Dim fecha_i, fecha_f As String
        fecha_i = Form5.DT_inicio.Value.ToString("yyyy/MM/dd")
        fecha_f = Form5.DT_final.Value.ToString("yyyy/MM/dd")
        ' MsgBox(fecha_i)
        ' MsgBox(fecha_f)

        conn.Open()
        Select Case categoria
            Case "Cliente"
                cmd.CommandText = "SELECT * FROM `rayito`.`clientes` WHERE Nombre='" & Form5.CB_datos.Text & "'"
                campoID = "IDCliente"
                If Form5.CK_fechas.Checked = True Then
                    query_filtrar = "SELECT ventas.IDVenta, ventas.Fecha, ventas.Hora, clientes.Nombre AS Cliente, ventas.Total, usuarios.Nombre AS Cajero FROM ((`rayito`.ventas INNER JOIN `rayito`.clientes ON ventas.IDCliente = clientes.IDCliente) INNER JOIN `rayito`.usuarios ON ventas.IDUsuario = usuarios.IDUsuario) WHERE ventas.Fecha BETWEEN '$ini$' AND '$fin$' AND ventas.IDCliente = $nombre$;"
                Else
                    query_filtrar = "SELECT ventas.IDVenta, ventas.Fecha, ventas.Hora, clientes.Nombre AS Cliente, ventas.Total, usuarios.Nombre AS Cajero FROM `rayito`.ventas, `rayito`.clientes, `rayito`.usuarios WHERE ventas.IDCliente = clientes.IDCliente AND ventas.IDUsuario = usuarios.IDUsuario AND ventas.IDCliente = $nombre$;"
                End IF
            Case "Cajero"
                cmd.CommandText = "SELECT * FROM `rayito`.`usuarios` WHERE Nombre='" & Form5.CB_datos.Text & "'"
                campoID = "IDUsuario"
                If Form5.CK_fechas.Checked = True Then
                    query_filtrar = "SELECT ventas.IDVenta, ventas.Fecha, ventas.Hora, clientes.Nombre AS Cliente, ventas.Total, usuarios.Nombre AS Cajero FROM ((`rayito`.ventas INNER JOIN `rayito`.clientes ON ventas.IDCliente = clientes.IDCliente) INNER JOIN `rayito`.usuarios ON ventas.IDUsuario = usuarios.IDUsuario) WHERE ventas.Fecha BETWEEN '$ini$' AND '$fin$' AND ventas.IDUsuario = $nombre$;"
                Else
                    query_filtrar = "SELECT ventas.IDVenta, ventas.Fecha, ventas.Hora, clientes.Nombre AS Cliente, ventas.Total, usuarios.Nombre AS Cajero FROM `rayito`.ventas, `rayito`.clientes, `rayito`.usuarios WHERE ventas.IDCliente = clientes.IDCliente AND ventas.IDUsuario = usuarios.IDUsuario AND ventas.IDUsuario = $nombre$;"
                End If
        End Select
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            Dim nombre As String = rd.GetString("Nombre")
            ID = rd.GetString(campoID)

        End While

        rd.Close()
        conn.Close()
        sust(ID)
        If Form5.CK_fechas.Checked = True Then
            query_filtrar = query_filtrar.Replace("$ini$", fecha_i)
            query_filtrar = query_filtrar.Replace("$fin$", fecha_f)
            ' MsgBox(query_filtrar)
            ' sust(fecha_i, "$ini$")
            ' sust(fecha_f, "$fin$")
        End If
        ActualizarVentasDG(query_filtrar)
    End Function

    Function sust(ByVal id As Integer)
        query_filtrar = query_filtrar.Replace("$nombre$", id)
    End Function

    Function LimpiarFiltro()
        Form5.CB_categoria.SelectedItem = Nothing
        Form5.CB_datos.SelectedItem = Nothing
        Form5.CK_fechas.Checked = False
        ' MsgBox(Form5.DT_inicio.Value.ToString("dd/MM/yyyy"))
    End Function

End Module
