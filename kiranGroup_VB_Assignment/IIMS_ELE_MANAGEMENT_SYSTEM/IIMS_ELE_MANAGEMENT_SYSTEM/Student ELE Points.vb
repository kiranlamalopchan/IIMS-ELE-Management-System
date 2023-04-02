Imports System.Data.SqlClient
Public Class Student_ELE_Points
    Dim conn As SqlConnection
    Dim Command As SqlCommand
    Private Sub Connection()
        conn = New SqlConnection With {
                .ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True"
        }
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        TeacherForm.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub Cleartxt()
        Textbox1.Text = ""
        Textbox2.Text = ""
        Textbox3.Text = ""
        Textbox4.Text = ""
        Textbox1.Focus()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If Textbox1.Text = "" Or Textbox2.Text = "" Or Textbox3.Text = "" Or Textbox4.Text = "" Then
            MessageBox.Show("Please fill full data | Most Required", "Try Again")
            Exit Sub
        End If
        Call Connection()
        Dim READER As SqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [ThirdSem] (Student_ID,Event_Name,Student_Name,Point)
                    VALUES ('" & Textbox1.Text & "','" & Textbox2.Text & "','" & Textbox4.Text & "','" & Textbox3.Text & "')"
            Command = New SqlCommand(query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data of Third (3rd) semester | Added Sucessfully")
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Call Cleartxt()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If Textbox1.Text = "" Or Textbox2.Text = "" Or Textbox3.Text = "" Or Textbox4.Text = "" Then
            MessageBox.Show("Please fill full data | Most Required", "Try Again")
            Exit Sub
        End If
        Call Connection()
        Dim READER As SqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [FourthSem] (Student_ID,Event_Name,Student_Name,Point)
                    VALUES ('" & Textbox1.Text & "','" & Textbox2.Text & "','" & Textbox4.Text & "','" & Textbox3.Text & "')"
            Command = New SqlCommand(query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data of Fourth (4th) Semester | Added Sucessfully ")
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Call Cleartxt()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        If Textbox1.Text = "" Or Textbox2.Text = "" Or Textbox3.Text = "" Or Textbox4.Text = "" Then
            MessageBox.Show("Please fill full data | Most Required", "Try Again")
            Exit Sub
        End If
        Call Connection()
        Dim READER As SqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO [FifthSem] (Student_ID,Event_Name,Student_Name,Point)
                    VALUES ('" & Textbox1.Text & "','" & Textbox2.Text & "','" & Textbox4.Text & "','" & Textbox3.Text & "')"
            Command = New SqlCommand(query, conn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data of Fifth (5th) Semester | Added Sucessfully ")
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        Call Cleartxt()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Me.Close()
        ThirdSemELEData.Show()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Me.Close()
        FourtthSemELEData.Show()
    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        Me.Close()
        FifthSemELEData.Show()
    End Sub
End Class