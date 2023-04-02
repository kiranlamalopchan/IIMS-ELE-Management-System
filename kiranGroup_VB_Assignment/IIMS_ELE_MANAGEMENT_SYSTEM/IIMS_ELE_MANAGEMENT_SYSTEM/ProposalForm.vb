Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class ProposalForm
    Dim conn As SqlConnection
    Dim command As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim bsource As New BindingSource
    Dim sda As SqlDataAdapter
    Dim dbdataset As New DataTable


    Public Sub connection()
        conn = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elohist\source\repos\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM\IIMS_ELE_MANAGEMENT_SYSTEM_DB.mdf;Integrated Security=True")
        conn.Open()
    End Sub
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim smtp As New SmtpClient
        Dim mail As New MailMessage()
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New Net.NetworkCredential("lamak540@gmail.com", "966554469314")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"
        mail = New MailMessage()
        mail.From = New MailAddress(BunifuMaterialTextbox1.Text)
        mail.To.Add(BunifuMaterialTextbox2.Text)
        mail.Subject = "IIMS ELE MANAGEMENT SYSTEM"
        mail.IsBodyHtml = False
        mail.Body = BunifuMetroTextbox1.Text
        smtp.Send(mail)
        MsgBox("Mail sent Sucessfully")

        BunifuMaterialTextbox1.Text = ""
        BunifuMaterialTextbox2.Text = ""
        BunifuMetroTextbox1.Text = ""

        Try

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        TeacherForm.Show()
    End Sub

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1.TBLPDF' table. You can move, or remove it, as needed.
        Me.TBLPDFTableAdapter.Fill(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1.TBLPDF)
        Call ShowGrid()
    End Sub
    Sub ShowGrid()
        Call connection()
        da = New SqlDataAdapter("select * from TBLPDF", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        If Textbox1.Text = "" Then
            MessageBox.Show("Id is missing please fill it..?", "Try Again")
        ElseIf MessageBox.Show("Are you sure to Delete...?", "Be carefull", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call connection()
            Dim delete As String = "delete from TBLPDF  where ID='" & Textbox1.Text & "'"
            command = New SqlCommand(delete, conn)
            command.ExecuteNonQuery()
            Call ShowGrid()
            Textbox1.Text = ""
            Textbox1.Focus()
            conn.Close()
        Else
        End If
    End Sub


    Sub Findit()
        On Error Resume Next
        Textbox2.Text = dr(1)
        Textbox3.text = dr(2)
        Textbox2.Focus()
        PDF_Teacher.src = (Textbox3.text)
    End Sub

    Sub FindCode()
        Call connection()
        command = New SqlCommand("select * from TBLPDF where ID='" & Textbox1.Text & "'", conn)
        dr = command.ExecuteReader
        dr.Read()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        Textbox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Call FindCode()
        If dr.HasRows Then
            Call Findit()
        End If
    End Sub

End Class