Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module SQLConnectionModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public qry As String
    Public adp As New MySqlDataAdapter


    Public Sub connect()
        Dim myConString As String
        myConString = "server=localhost;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=feedmillcontrolsystem"
        'conn = New SqlConnection("Server=.\SQLExpress;AttachDbFilename=|DataDirectory|feedmill.mdf;Database=MyDB;Trusted_Connection=Yes")

        'conn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Desktop\Feedmill Control TRest\Feed Mill Control\Feed Mill Control\Feed Mill Control\feedmill.mdf;Integrated Security=True;User Instance=True")
        conn = New MySqlConnection(myConString)
        'Server = myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;


    End Sub
End Module
