Imports System.Data.SqlClient
Public Class ThirdSemELEStudentView
    Dim conn As SqlConnection
    Dim Command As SqlCommand
    Dim dbdataset As New DataTable

    Private Sub Connection()
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
    End Sub
    Private Sub loaddata()
        Call Connection()
        Dim sda As New SqlDataAdapter
        Dim bsource As New BindingSource
        If ELE_Search_Spec.Text = "" Or BunifuMaterialTextbox1.Text = "" Then
            MsgBox("Data is Incomplete | Try Again")
            Exit Sub
        End If
        Try
            conn.Open()
            Dim query As String
            query = "Select Event_Name,Point From ThirdSem where Student_ID ='" & ELE_Search_Spec.Text & "'"
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

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Call loaddata()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        StudentForm.Show()
    End Sub

    Private Sub ThirdSemELEStudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class