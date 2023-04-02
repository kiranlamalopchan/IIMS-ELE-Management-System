Imports System.Data.SqlClient
Public Class FourthSemELEAdmin
    Dim conn As SqlConnection
    Dim Command As SqlCommand
    Dim dbdataset As New DataTable
    Dim da As SqlDataAdapter
    Dim ds As DataSet


    Private Sub Connection()
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
    End Sub
    Private Sub loaddata()
        Call Connection()
        Dim sda As New SqlDataAdapter

        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "Select * From FourthSem"
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
    Private Sub FourthSemELEAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub

    Private Sub cleartxt()
        Search_textbox.Text = ""
        Search_textbox.Focus()
    End Sub

    Private Sub Search_textbox_OnValueChanged(sender As Object, e As EventArgs) Handles Search_textbox.OnValueChanged
        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("Student_Name like '%{0}%'", Search_textbox.Text)
        DataGridView1.DataSource = DV
    End Sub
    Sub ShowGrid()
        Call Connection()
        da = New SqlDataAdapter("select * from FourthSem", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Search_textbox.Text = "" Then
            MessageBox.Show("Student Name is missing please fill it..?", "Try Again")
        ElseIf MessageBox.Show("Are you sure to Delete...?", "Be carefull", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Connection()
            conn.Open()
            Dim delete As String = "delete from [FourthSem]  where Student_Name ='" & Search_textbox.Text & "'"
            Command = New SqlCommand(delete, conn)
            Command.ExecuteNonQuery()
            Call ShowGrid()
            Call cleartxt()
            conn.Close()
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Search_textbox.Text = row.Cells("Student_Name").Value.ToString

        End If
    End Sub
End Class