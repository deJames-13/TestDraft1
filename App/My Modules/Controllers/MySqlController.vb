Imports MySql.Data.MySqlClient

Module MySqlController


    '#################################################################################################
    Public server As String = "localhost"
    Public user As String = "root"
    Public password As String = ""
    Public database As String = "mock_db"


    Public _sqlString = ""
    Private _sqlCon As MySqlConnection
    Private _sqlAdapter As MySqlDataAdapter
    Private _sqlCommand As MySqlCommand
    Private _sqlDataSet As DataSet
    Private _sqlDataTable As DataTable
    Private _sqlTransaction As MySqlTransaction

    '#################################################################################################
    '  CONNECTION
    '#################################################################################################
    Public Function CreateConnection() As Boolean
        Try
            _sqlCon = New MySqlConnection

            _sqlCon.ConnectionString = $"DataSource={server};User={user};Password={password};Database={database}"

            _sqlCon.Open()
            Return 1
        Catch ex As MySqlException

            Dim msg As String = $"Can't connect to server right now. Please try again later!"
            msg &= vbNewLine & vbNewLine & $"Server Error: {ex.Message}"


            MsgBox(msg, MsgBoxStyle.Critical, "Connection Error")
            Return 0
        End Try
    End Function

    Public Sub OpenDb()
        Try
            If _sqlCon.State = ConnectionState.Open Then
                _sqlCon.Close()
            End If
            _sqlCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Connection error.")
        End Try
    End Sub

    Public Sub CloseDb()
        Try
            _sqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Connection error.")
        End Try
    End Sub

    Public Function ExecuteQuery(sql As String, Optional table As String = "temp") As DataTable

        _sqlDataSet = New DataSet
        _sqlDataTable = New DataTable
        Try
            OpenDb()
            _sqlAdapter = New MySqlDataAdapter(sql, _sqlCon)

            _sqlAdapter.Fill(_sqlDataSet, table)
            _sqlDataTable = _sqlDataSet.Tables(table)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Query error.")
        Finally
            CloseDb()
        End Try
        Return _sqlDataTable
    End Function

    Public Sub ExecuteNonQuery(sql As String, Optional auto_commit As Boolean = True)
        Try
            OpenDb()

            _sqlCommand = New MySqlCommand()
            _sqlCommand.Connection = _sqlCon
            _sqlTransaction = _sqlCon.BeginTransaction()

            _sqlCommand.CommandText = sql
            _sqlCommand.ExecuteNonQuery()

            If auto_commit Then _sqlTransaction.Commit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Query error.")
            _sqlTransaction.Rollback()
        Finally
            CloseDb()
        End Try
    End Sub



    ' INSERT
    Public Sub InsertInto(table As String, columns As String, values As String)
        ExecuteNonQuery($"INSERT INTO {table}({columns}) VALUES({values})")
    End Sub

    ' UPDATE
    Public Sub UpdateTable(table As String, values As String, condition As String)
        ExecuteNonQuery($"UPDATE {table} SET {values} WHERE {condition}")
    End Sub

    ' DELETE
    Public Sub DeleteFrom(table As String, condition As String)
        ExecuteNonQuery($"DELETE FROM {table} WHERE {condition}")
    End Sub


    Public Function ShowTables() As DataTable
        Return ExecuteQuery("SHOW TABLES")
    End Function


    Public Function SelectAllFrom(table As String, Optional columns As String = "*", Optional condition As String = "") As DataTable
        Return ExecuteQuery($"SELECT {columns} FROM {table} {condition}")
    End Function

    Public Function SelectWhere(table As String, condition As String, Optional columns As String = "*") As DataTable
        Return ExecuteQuery($"SELECT {columns} FROM {table} WHERE {condition}")
    End Function

    ' FILTER
    Public Function FilterFrom(table As String, column As String, value As String) As DataTable
        Dim dt As New DataTable

        Dim condition As String = $"{column} LIKE '%{value}%'"

        Return SelectWhere(table, condition)
    End Function



End Module
