Imports System.Data.SqlClient
Public Class AdminLogin
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim attempts As Integer = 0
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Not String.IsNullOrEmpty(ad_username.Text) And
            Not String.IsNullOrEmpty(ad_passsword.Text) Then
            conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
            }
            Dim reader As SqlDataReader
            Try
                conn.Open()
                Dim query As String
                query = "SELECT * FROM [Admin] WHERE username = '" & ad_username.Text & "' and password = '" & ad_passsword.Text & "' "
                command = New SqlCommand(query, conn)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While

                If count = 1 Then
                    ad_username.Text = ""
                    ad_passsword.Text = ""

                    Me.Hide()
                    Admin.Show()
                ElseIf count > 1 Then
                    MsgBox("Username and password are Duplicated.", MsgBoxStyle.Critical, "Login | Failed ")
                ElseIf attempts = 3 Then
                    MsgBox("Maximum 3 Three wrong username and password attempted! Program Will be close now.", MsgBoxStyle.Critical, "Login | Failed ")
                    Me.Close()
                Else
                    MsgBox("Username And password didn't match! Try Again " & attempts & " of 3", MsgBoxStyle.Critical, "Login | Failed ")
                    attempts = attempts + 1
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
        Else
            MsgBox("Please enter Username and Password.", MsgBoxStyle.Critical, "Login Form : Empty Field ")
            ad_username.Select()
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        conn = New SqlConnection
        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\ELE Management SystemOrg\ELE Management SystemOrg\Ele_Management_System.mdf;Integrated Security=True"
        Try
            conn.Open()
            MessageBox.Show("Connected to the Database: Connection is ready", "ELE Management System | Ready")
            conn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        With BunifuCheckbox1
            If .Checked Then
                ad_passsword.isPassword = False
            Else
                ad_passsword.isPassword = True
            End If
        End With
    End Sub
End Class