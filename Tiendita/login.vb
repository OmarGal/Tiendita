Module login
    Public IDUsuario_actual As Integer

    Function ActualizarUsuariosCB()
        Form1.CB_usuario.Items.Clear()
        conn.Open()
        cmd.CommandText = "SELECT Nombre FROM `rayito`.`usuarios`"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            Dim usuario As String = rd.GetString("Nombre")
            Form1.CB_usuario.Items.Add(usuario)

        End While

        rd.Close()
        conn.Close()
    End Function

    Function ContrasenaCorrecta() As Boolean
        Dim password As String
        Dim id As Integer

        conn.Open()
        cmd.CommandText = "SELECT * FROM `rayito`.`usuarios` WHERE Nombre='" & Form1.CB_usuario.Text & "'"
        cmd.Connection = conn
        rd = cmd.ExecuteReader

        While rd.Read

            id = rd.GetString("IDUsuario")
            password = rd.GetString("Clave")

        End While

        rd.Close()
        conn.Close()

        If (Form1.TB_contra.Text = password) Then
            IDUsuario_actual = id
            EstablecerUsuario()
            Return True
        End If

    End Function

    Function EstablecerUsuario()
        Form2.LB_usuario.Text = Form1.CB_usuario.Text
        Form4.LB_usuario.Text = Form1.CB_usuario.Text
    End Function

End Module
