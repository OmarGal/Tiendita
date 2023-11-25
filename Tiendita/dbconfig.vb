Imports MySql.Data.MySqlClient

Module dbconfig
    Public rd As MySqlDataReader
    Public cmd as New MySqlcommand
    Public conn As New MySqlConnection("host=localhost;user=root;password=1234;port=3306;")
    Public StrVar As String
End Module
