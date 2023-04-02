Imports System.Data.SqlClient
Public Class TeacherForm
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim doe As String

    Private Sub Connection()
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        Users_Login.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Me.Close()
        ProposalForm.Show()
    End Sub
    Private Sub cleartxt()
        BunifuMaterialTextbox1.Text = ""
        Textbox2.Text = ""
        Textbox2.Focus()
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
            command = New SqlCommand(query, conn)
            sda.SelectCommand = command
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
    Private Sub BunifuThinButton28_Click(sender As Object, e As EventArgs) Handles BunifuThinButton28.Click
        If Textbox2.Text = "" Or BunifuMaterialTextbox1.Text = "" Then
            MessageBox.Show("Please Enter Event name and Point | Most Required", "Try Again")
            Exit Sub
        End If
        Call Connection()
        Dim READER As SqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [Events] (Name,Date,Point)
                    VALUES ('" & Textbox2.Text & "','" & doe & "','" & BunifuMaterialTextbox1.Text & "')"
            command = New SqlCommand(query, conn)
            READER = command.ExecuteReader
            MessageBox.Show("Event | Added Sucessfully")
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Call cleartxt()
        Call loaddata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        doe = DateTimePicker1.Value.ToShortDateString
    End Sub



    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loaddata()
        conn.Close()
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        If Textbox2.Text = "" Then
            MessageBox.Show("Event Name is missing please fill it..?", "Try Again")
        ElseIf MessageBox.Show("Are you sure to Delete...?", "Be carefull", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Connection()
            conn.Open()
            Dim delete As String = "delete from [Events]  where Name ='" & Textbox2.Text & "'"
            command = New SqlCommand(delete, conn)
            command.ExecuteNonQuery()
            Call loaddata()
            Call cleartxt()
            conn.Close()
        Else
        End If
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Call cleartxt()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Student_ELE_Points.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Textbox2.Text = row.Cells("Name").Value.ToString
            DateTimePicker1.Text = row.Cells("Date").Value.ToString
            BunifuMaterialTextbox1.Text = row.Cells("Point").Value.ToString
        End If
    End Sub


End Class