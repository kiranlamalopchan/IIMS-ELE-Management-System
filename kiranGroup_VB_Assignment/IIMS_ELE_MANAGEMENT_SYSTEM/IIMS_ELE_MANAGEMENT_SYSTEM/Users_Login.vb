Imports System.Data.SqlClient
Public Class Users_Login
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim attempts As Integer = 0
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Register.Click
        If Not String.IsNullOrEmpty(BunifuMaterialTextbox1.Text) And
            Not String.IsNullOrEmpty(BunifuMaterialTextbox2.Text) Then
            conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
            }
            Dim reader As SqlDataReader
            Try
                conn.Open()
                Dim query As String
                query = "SELECT * FROM [Lg_Teacher] WHERE username = '" & BunifuMaterialTextbox1.Text & "' and password = '" & BunifuMaterialTextbox2.Text & "' "
                command = New SqlCommand(query, conn)
                reader = Command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While

                If count = 1 Then
                    BunifuMaterialTextbox1.Text = ""
                    BunifuMaterialTextbox2.Text = ""

                    Me.Close()
                    TeacherForm.Show()
                ElseIf count > 1 Then
                    MsgBox("Username and password are Duplicated.", MsgBoxStyle.Critical, "Login | Failed ")
                ElseIf attempts = 3 Then
                    MsgBox("Maximum 3 Three wrong username and password attempted! Program Will be close now.", MsgBoxStyle.Critical, "Login | Failed ")
                    Me.Close()
                Else
                    MsgBox("Username and password didn't match! Try Again." & attempts & " of 3", MsgBoxStyle.Critical, "Login | Failed ")
                    attempts = attempts + 1
                End If
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
        Else
            MsgBox("Please enter Username And Password.", MsgBoxStyle.Critical, "Login Form : Empty Field ")
            BunifuImageButton1.Select()
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If Not String.IsNullOrEmpty(BunifuMaterialTextbox1.Text) And
            Not String.IsNullOrEmpty(BunifuMaterialTextbox2.Text) Then
            conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
            }
            Dim reader As SqlDataReader
            Try
                conn.Open()
                Dim query As String
                query = "SELECT * FROM [Lg_Students] WHERE username = '" & BunifuMaterialTextbox1.Text & "' and password = '" & BunifuMaterialTextbox2.Text & "' "
                command = New SqlCommand(query, conn)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count += 1
                End While

                If count = 1 Then
                    BunifuMaterialTextbox1.Text = ""
                    BunifuMaterialTextbox2.Text = ""

                    Me.Close()
                    StudentForm.Show()
                ElseIf count > 1 Then
                    MsgBox("Username and password are Duplicated.", MsgBoxStyle.Critical, "Login | Failed ")
                ElseIf attempts = 3 Then
                    MsgBox("Maximum 3 Three wrong username and password attempted! Program Will be close now.", MsgBoxStyle.Critical, "Login | Failed ")
                    Me.Close()
                Else
                    MsgBox("Username and password didn't match! Try Again." & attempts & " of 3", MsgBoxStyle.Critical, "Login | Failed ")
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
            BunifuImageButton1.Select()
        End If
    End Sub

    Private Sub BunifuCheckbox1_OnChange(sender As Object, e As EventArgs) Handles BunifuCheckbox1.OnChange
        With BunifuCheckbox1
            If .Checked Then
                BunifuMaterialTextbox2.isPassword = False
            Else
                BunifuMaterialTextbox2.isPassword = True
            End If
        End With
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
            }
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

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        MainForm.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class