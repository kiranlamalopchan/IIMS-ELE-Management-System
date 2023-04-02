Imports System.Data.SqlClient
Public Class SignUp_Student
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim gender As String
    Dim dob As String
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Register.Click
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
        Dim READER As SqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [Lg_teacher] (idno,firstname,lastname,username,password,gender,dateofbirth,contactno,email) 
                    VALUES ('" & Idtxt.Text & "','" & firstnametxt.Text & "','" & lastnametxt.Text & "','" & usernametxt.Text & "',
                    '" & passwordtxt.Text & "','" & gender & "','" & dob & "','" & contacttxt.Text & "','" & emailtxt.Text & "')"
            command = New SqlCommand(query, conn)
            READER = command.ExecuteReader
            MessageBox.Show("Teacher | Registered Sucessfully")

            Idtxt.Text = ""
            Idtxt.Select()
            firstnametxt.Text = ""
            lastnametxt.Text = ""
            usernametxt.Text = ""
            passwordtxt.Text = ""
            gender = ""
            dob = ""
            contacttxt.Text = ""
            emailtxt.Text = ""

            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub RB_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RB_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Female.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
        Dim READER As SqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [Lg_Students] (idno,firstname,lastname,username,password,gender,dateofbirth,contactno,email) 
                    VALUES ('" & Idtxt.Text & "','" & firstnametxt.Text & "','" & lastnametxt.Text & "','" & usernametxt.Text & "',
                    '" & passwordtxt.Text & "','" & gender & "','" & dob & "','" & contacttxt.Text & "','" & emailtxt.Text & "')"
            command = New SqlCommand(query, conn)
            READER = command.ExecuteReader
            MessageBox.Show("Student | Registered Sucessfully")

            Idtxt.Text = ""
            Idtxt.Select()
            Idtxt.Focus()
            firstnametxt.Text = ""
            lastnametxt.Text = ""
            usernametxt.Text = ""
            passwordtxt.Text = ""
            gender = ""
            dob = ""
            contacttxt.Text = ""
            emailtxt.Text = ""

            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dob = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub SignUp_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idtxt.Focus()
        Idtxt.Select()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        RegisteredTeacher.Show()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        RegisteredStudents.Show()
    End Sub
End Class