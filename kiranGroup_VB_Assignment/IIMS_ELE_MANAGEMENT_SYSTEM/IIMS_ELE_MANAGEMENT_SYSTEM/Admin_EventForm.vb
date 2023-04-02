Imports System.Data.SqlClient

Public Class Admin_EventForm
    Dim conn As SqlConnection
    Dim Command As SqlCommand
    Dim dbdataset As New DataTable
    Public Sub Connection()
        conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True")
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Close()
        Admin.Show()
    End Sub
    Private Sub loaddata()
        Call Connection()
        Dim sda As New SqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            conn.Open()
            Dim query As String
            query = "Select * From Events"
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

    Private Sub Admin_EventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub

    Private Sub Search_textbox_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

End Class