Imports System.Data.SqlClient
Public Class RegisteredTeacher
    Dim conn As SqlConnection
    Dim Command As SqlCommand
    Dim dbdataset As New DataTable
    Dim ds As New DataSet
    Dim sda As New SqlDataAdapter


    Private Sub Connection()
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
    End Sub
    Private Sub cleartxt()
        Search_textbox.Text = ""
        Search_textbox.Focus()
    End Sub
    Private Sub loaddata()
        Call Connection()

        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "Select * From Lg_Teacher "
            Command = New SqlCommand(query, conn)
            sda.SelectCommand = Command
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            DataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Sub ShowGrid()
        Call Connection()
        sda = New SqlDataAdapter("select * from Lg_Teacher", conn)
        ds = New DataSet
        sda.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
    End Sub
    Private Sub RegisteredTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Search_textbox.Text = "" Then
            MessageBox.Show("Teacher name is missing please fill it..?", "Try Again")
        ElseIf MessageBox.Show("Are you sure to Delete...?", "Be carefull", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Connection()
            conn.Open()
            Dim delete As String = "delete from [Lg_Teacher]  where firstname ='" & Search_textbox.Text & "'"
            Command = New SqlCommand(delete, conn)
            Command.ExecuteNonQuery()
            Call ShowGrid()
            Call cleartxt()
            conn.Close()
        Else
        End If
    End Sub

End Class