Imports System.Data.SqlClient
Public Class MainForm
    Dim conn As SqlConnection
    Public Sub connection()
        conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True")
        conn.Open()
    End Sub

    Private Sub Mainfrm_IIMS_Banner_Click(sender As Object, e As EventArgs) Handles mainfrm_IIMS_Banner.Click

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
        Users_Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
