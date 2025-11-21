Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=root;database=crud_demo_db;"
        Try
            conn.Open()
            MessageBox.Show("Connected")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim query As String = "INSERT INTO students_tbl (Name, Age, Email) VALUES (@Name, @Age, @Email)"
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_demo_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@Age", CInt(TextBoxAge.Text))
                    cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record has been inserted Successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM crud_demo_db.students_tbl;"
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_demo_db;")
                Dim adapter As New MySqlDataAdapter(query, conn) ' get from 
                Dim table As New DataTable() ' table object
                adapter.Fill(table) ' from adapter to table object
                DataGridView1.DataSource = table ' display to DataGridView
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim id As Integer = CInt(selectedRow.Cells("id").Value)

            Dim query As String = "DELETE FROM students_tbl WHERE id = @id"
            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_demo_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", id)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Record Deleted Successfully")
                        Else
                            MessageBox.Show("No matching record found")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a row to delete")
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        DataGridView1.EndEdit()
        If DataGridView1.CurrentCell Is Nothing Then
            MessageBox.Show("Please select a row first!")
            Return
        End If

        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(rowIndex)

        ' Use the same column name as your DELETE method - "id" instead of index
        Dim idValue = selectedRow.Cells("id").Value
        Dim nameValue = selectedRow.Cells("Name").Value
        Dim ageValue = selectedRow.Cells("Age").Value
        Dim emailValue = selectedRow.Cells("Email").Value

        If idValue IsNot Nothing AndAlso idValue.ToString().Trim() <> "" AndAlso Integer.TryParse(idValue.ToString(), Nothing) Then
            ' Use "id" instead of "StudentID" to match your database column
            Dim query As String = "UPDATE students_tbl SET Name=@Name, Age=@Age, Email=@Email WHERE id=@id"
            Try
                Using conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_demo_db;")
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Name", nameValue.ToString())
                        cmd.Parameters.AddWithValue("@Age", CInt(ageValue))
                        cmd.Parameters.AddWithValue("@Email", emailValue.ToString())
                        cmd.Parameters.AddWithValue("@id", CInt(idValue))
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record has been updated Successfully!")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("ID is invalid. Please select a valid row.")
        End If
    End Sub

End Class
