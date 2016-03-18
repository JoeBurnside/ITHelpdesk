Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

'This class uses the ado.net sql classes to provide a connection to an SQL Server database.

Public Class DataConnection
    'the name of the database you are connnecting to (must be in the App_Data folder)
    'change this to suit your needs

    Private DatabaseName As String = "Database.mdf"
    '
    '
    'connection object used to connect to the database
    Private connectionToDB As New SqlConnection
    'data adapter used to transfer data to and from the database
    Private dataChannel As New SqlDataAdapter
    'stores a list of all of the sql parameters
    Private SQLParams As New List(Of SqlParameter)
    'data table used to store the results of the stored procedure
    Private query_Results As New DataTable
    'string variable used to store the connection string
    Private connectionString As String

    Public Sub New(DbName As String)
        ''Use this to connect to Access 2003 dataabases
        ''get the folder for the project
        'Dim DbPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        ''append the database name
        'DbPath = DbPath & "App_Data\" & DatabaseName
        ''set the connection string
        'connectionString = "Provider=Microsoft.Jet.sql.4.0;Data Source=" & DbPath

        Dim DbPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "App_Data\" & DbName
        connectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & DbPath & "; " &
            "Integrated Security=True;Connect Timeout=30;User Instance=True"
    End Sub

    Public Sub New()
        ''get the folder for the project
        'Dim DbPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        ''append the database name
        'DbPath = DbPath & "App_Data\" & DatabaseName
        ''set the connection string
        'connectionString = "Provider=Microsoft.Jet.sql.4.0;Data Source=" & DbPath

        Dim DbPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "App_Data\" & DatabaseName
        connectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & DbPath & "; " &
            "Integrated Security=True;Connect Timeout=30;User Instance=True"
    End Sub

    Public Sub AddParameter(ParamName As String, ParamValue As Object)
        'public method allowing the addition of an sql parameter to the list of parameters
        'it accepts two parameters the name of the parameter and its value
        '
        'create a new instance of the sql parameter object
        Dim AParam As New SqlParameter(ParamName, ParamValue)
        'add the parameter to the list
        SQLParams.Add(AParam)
    End Sub

    Public Function Execute(SProcName As String) As Boolean
        'public method used to execute the named stored procedure
        'accepts one parameter which is the name of the stored procedure to use
        'open the stored procedure
        '
        ' Try
        'initialise the connection to the database
        Dim connectionToDb As New SqlConnection(connectionString)
        'open the database
        connectionToDb.Open()
        'initialise the command object for this connection
        Dim dataCommand As New SqlCommand(SProcName, connectionToDb)
        'add the parameters to the command object
        'loop through each parameter
        For Counter = 0 To SQLParams.Count - 1
            dataCommand.Parameters.Add(SQLParams(Counter))
        Next
        'set the command type as stored procedure
        dataCommand.CommandType = CommandType.StoredProcedure
        'initialise the data adapter
        dataChannel = New SqlDataAdapter()
        'set the select command property for the data adapter
        dataChannel.SelectCommand = dataCommand
        'fill the data adapter
        dataChannel.Fill(query_Results)
        'close the connection
        connectionToDb.Close()
        'return success
        Return True
        'Catch
        '    'return failure
        '    Return False
        'End Try
    End Function

    Public ReadOnly Property Count As Integer
        Get
            'return the count of records found
            Return query_Results.Rows.Count
        End Get
    End Property

    Public ReadOnly Property QueryResults As DataTable
        Get
            'return the results of the query
            Return query_Results
        End Get
    End Property




End Class