Imports System.IO
Imports System.Data.SqlClient
Public Class StudentForm
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim da As SqlDataAdapter


    Public Sub Connection()
        conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True")
    End Sub

    Sub Empetyit()
        On Error Resume Next
        Textbox1.Text = ""
        Textbox2.Text = ""
        Textbox3.text = ""
        Textbox1.Focus()
        PDF.src = (Textbox3.text)
    End Sub

    Sub NewData()
        On Error Resume Next
        Textbox2.Text = ""
        Textbox3.text = ""
        Textbox2.Focus()
        PDF.src = (Textbox3.text)
    End Sub

    Sub Findit()
        On Error Resume Next
        Textbox2.Text = dr(1)
        Textbox3.text = dr(2)
        Textbox2.Focus()
        PDF.src = (Textbox3.text)
    End Sub

    Sub FindCode()
        Call Connection()
        conn.Open()
        command = New SqlCommand("select * from TBLPDF where ID='" & Textbox1.Text & "'", conn)
        dr = command.ExecuteReader
        dr.Read()
    End Sub

    Sub ShowGrid()
        Call Connection()
        conn.Open()
        da = New SqlDataAdapter("select * from TBLPDF", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
        DGV.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
        conn.Close()
    End Sub

    Sub Early()
        Call Empetyit()
        Call ShowGrid()
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

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Textbox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call FindCode()
            If dr.HasRows Then
                Call Findit()
            Else
                Call NewData()
            End If
        End If
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet.TBLPDF' table. You can move, or remove it, as needed.
        Me.TBLPDFTableAdapter.Fill(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet.TBLPDF)
        Me.CenterToScreen()
        Call Early()
        Call loaddata()
    End Sub


    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If Textbox1.Text = "" Or Textbox2.Text = "" Or Textbox3.text = "" Then
            MsgBox("Data is Incomplete")
            Exit Sub
        End If
        Try
            Call FindCode()
            If Not dr.HasRows Then
                Call Connection()
                conn.Open()
                Dim insert As String = "insert into TBLPDF values ('" & Textbox1.Text & "','" & Textbox2.Text & "','" & Textbox3.text & "')"
                command = New SqlCommand(insert, conn)
                command.ExecuteNonQuery()
            Else
                Call Connection()
                Dim edit As String = "update TBLPDF set Name='" & Textbox2.Text & "',Location='" & Textbox3.text & "' where ID='" & Textbox1.Text & "'"
                command = New SqlCommand(edit, conn)
                command.ExecuteNonQuery()
                conn.Close()
            End If
            Call Early()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Call Empetyit()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        Textbox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call FindCode()
        If dr.HasRows Then
            Call Findit()
        End If
    End Sub

    Private Sub BunifuThinButton25_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        On Error Resume Next
        OpenFileDialog1.ShowDialog()
        Textbox3.text = OpenFileDialog1.FileName
        PDF.src = (Textbox3.text)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Close()
        Users_Login.Show()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Me.Close()
        ELEPointStudentView.Show()
    End Sub
End Class