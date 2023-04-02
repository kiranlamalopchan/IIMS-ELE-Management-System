<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProposalForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProposalForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet = New IIMS_ELE_MANAGEMENT_SYSTEM.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLPDFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1 = New IIMS_ELE_MANAGEMENT_SYSTEM.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1()
        Me.IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPDFTableAdapter = New IIMS_ELE_MANAGEMENT_SYSTEM.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1TableAdapters.TBLPDFTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PDF_Teacher = New AxAcroPDFLib.AxAcroPDF()
        Me.Textbox3 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPDFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDF_Teacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(376, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to IIMS ELE Management System"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.PictureBox1)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.BunifuThinButton21)
        Me.BunifuCards1.Controls.Add(Me.BunifuMetroTextbox1)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.BunifuCards1.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 103)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(319, 437)
        Me.BunifuCards1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Through Gmail Account"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Send"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(111, 391)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(98, 41)
        Me.BunifuThinButton21.TabIndex = 36
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Tomato
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Red
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Tomato
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(21, 236)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(279, 146)
        Me.BunifuMetroTextbox1.TabIndex = 6
        Me.BunifuMetroTextbox1.Text = "Message"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Send Message and Comments"
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Tomato
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Red
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Tomato
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(31, 172)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(259, 44)
        Me.BunifuMaterialTextbox2.TabIndex = 2
        Me.BunifuMaterialTextbox2.Text = "To"
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Tomato
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Red
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Tomato
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(31, 120)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(259, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 1
        Me.BunifuMaterialTextbox1.Text = "From"
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(534, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 26)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Teacher"
        '
        'IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet
        '
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet.DataSetName = "IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet"
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBLPDFBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(404, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(347, 217)
        Me.DataGridView1.TabIndex = 38
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'TBLPDFBindingSource
        '
        Me.TBLPDFBindingSource.DataMember = "TBLPDF"
        Me.TBLPDFBindingSource.DataSource = Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1
        '
        'IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1
        '
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1.DataSetName = "IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1"
        Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource
        '
        Me.IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource.DataSource = Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet
        Me.IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource.Position = 0
        '
        'TBLPDFTableAdapter
        '
        Me.TBLPDFTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(442, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 26)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Student's Proposal Details"
        '
        'Textbox1
        '
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox1.ForeColor = System.Drawing.Color.White
        Me.Textbox1.HintForeColor = System.Drawing.Color.White
        Me.Textbox1.HintText = ""
        Me.Textbox1.isPassword = False
        Me.Textbox1.LineFocusedColor = System.Drawing.Color.Tomato
        Me.Textbox1.LineIdleColor = System.Drawing.Color.Red
        Me.Textbox1.LineMouseHoverColor = System.Drawing.Color.Tomato
        Me.Textbox1.LineThickness = 3
        Me.Textbox1.Location = New System.Drawing.Point(440, 374)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(88, 32)
        Me.Textbox1.TabIndex = 49
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(392, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(446, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(277, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Note: Refresh to perform Database Cleanup"
        '
        'Textbox2
        '
        Me.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Textbox2.ForeColor = System.Drawing.Color.White
        Me.Textbox2.HintForeColor = System.Drawing.Color.White
        Me.Textbox2.HintText = ""
        Me.Textbox2.isPassword = False
        Me.Textbox2.LineFocusedColor = System.Drawing.Color.Tomato
        Me.Textbox2.LineIdleColor = System.Drawing.Color.Red
        Me.Textbox2.LineMouseHoverColor = System.Drawing.Color.Tomato
        Me.Textbox2.LineThickness = 3
        Me.Textbox2.Location = New System.Drawing.Point(626, 376)
        Me.Textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(149, 32)
        Me.Textbox2.TabIndex = 53
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(567, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 22)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(392, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 22)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Location"
        '
        'PDF_Teacher
        '
        Me.PDF_Teacher.Enabled = True
        Me.PDF_Teacher.Location = New System.Drawing.Point(798, 101)
        Me.PDF_Teacher.Name = "PDF_Teacher"
        Me.PDF_Teacher.OcxState = CType(resources.GetObject("PDF_Teacher.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PDF_Teacher.Size = New System.Drawing.Size(340, 437)
        Me.PDF_Teacher.TabIndex = 44
        '
        'Textbox3
        '
        Me.Textbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Textbox3.BackgroundImage = CType(resources.GetObject("Textbox3.BackgroundImage"), System.Drawing.Image)
        Me.Textbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Textbox3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Textbox3.Icon = CType(resources.GetObject("Textbox3.Icon"), System.Drawing.Image)
        Me.Textbox3.Location = New System.Drawing.Point(473, 415)
        Me.Textbox3.Name = "Textbox3"
        Me.Textbox3.Size = New System.Drawing.Size(304, 32)
        Me.Textbox3.TabIndex = 52
        Me.Textbox3.text = "Files for upload only pdf format"
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Delete"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(526, 470)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(98, 41)
        Me.BunifuThinButton23.TabIndex = 45
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Back"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(6, 4)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(98, 41)
        Me.BunifuThinButton22.TabIndex = 34
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton2.Image = Global.IIMS_ELE_MANAGEMENT_SYSTEM.My.Resources.Resources.minimize
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1079, 1)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 34)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 33
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1111, 1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 32
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'ProposalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 547)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Textbox2)
        Me.Controls.Add(Me.Textbox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.PDF_Teacher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProposalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherForm"
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPDFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDF_Teacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet As IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IIMSELEMANAGEMENTSYSTEMDBDataSetBindingSource As BindingSource
    Friend WithEvents IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1 As IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1
    Friend WithEvents TBLPDFBindingSource As BindingSource
    Friend WithEvents TBLPDFTableAdapter As IIMS_ELE_MANAGEMENT_SYSTEM_DBDataSet1TableAdapters.TBLPDFTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents PDF_Teacher As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Textbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox3 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
