Imports MySql.Data.MySqlClient

Public Class DatabaseHelper

    Private Shared connectionString As String =
        "Server=localhost;Port=3306;Database=college_erp;Uid=root;Pwd=S19r22y26;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        conn.Open()
        Return conn
    End Function

    Public Shared Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Shared Function ExecuteNonQuery(query As String) As Integer
        Dim result As Integer = 0
        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    result = cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

    Public Shared Function ExecuteScalar(query As String) As Integer
        Dim result As Integer = 0
        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(query, conn)
                    Dim val = cmd.ExecuteScalar()
                    If val IsNot Nothing AndAlso val IsNot DBNull.Value Then
                        result = Convert.ToInt32(val)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

    Public Shared Function GetLastInsertId() As Integer
        Dim dt = ExecuteQuery("SELECT LAST_INSERT_ID() AS id")
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        End If
        Return 0
    End Function

    Public Shared Function TestConnection() As Boolean
        Try
            Using conn = GetConnection()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class