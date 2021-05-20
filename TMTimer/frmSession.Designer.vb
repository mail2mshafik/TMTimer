<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSession
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSession))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmrTM = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbTooltip = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMaxTime = New System.Windows.Forms.Label()
        Me.pnlRed = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMidTime = New System.Windows.Forms.Label()
        Me.pnlYellow = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblQualifyTime = New System.Windows.Forms.Label()
        Me.pnlGreen = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtTimeFor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSegment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkTimingLight = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnStop = New MetroFramework.Controls.MetroButton()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnStart = New MetroFramework.Controls.MetroButton()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbQualified = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPause = New MetroFramework.Controls.MetroButton()
        Me.lnkAbout = New System.Windows.Forms.LinkLabel()
        Me.lnkSegment = New System.Windows.Forms.LinkLabel()
        Me.lnkClearGrid = New System.Windows.Forms.LinkLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.Panel1.SuspendLayout()
        CType(Me.pbTooltip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlColor.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrTM
        '
        Me.tmrTM.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbTooltip)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.txtTimeFor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbSegment)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 153)
        Me.Panel1.TabIndex = 7
        '
        'pbTooltip
        '
        Me.pbTooltip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbTooltip.Image = CType(resources.GetObject("pbTooltip.Image"), System.Drawing.Image)
        Me.pbTooltip.Location = New System.Drawing.Point(72, 93)
        Me.pbTooltip.Name = "pbTooltip"
        Me.pbTooltip.Size = New System.Drawing.Size(15, 16)
        Me.pbTooltip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTooltip.TabIndex = 13
        Me.pbTooltip.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblMaxTime, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.pnlRed, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(306, 90)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(73, 22)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'lblMaxTime
        '
        Me.lblMaxTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMaxTime.Location = New System.Drawing.Point(22, 1)
        Me.lblMaxTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMaxTime.Name = "lblMaxTime"
        Me.lblMaxTime.Size = New System.Drawing.Size(50, 20)
        Me.lblMaxTime.TabIndex = 6
        Me.lblMaxTime.Text = "0"
        '
        'pnlRed
        '
        Me.pnlRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRed.Location = New System.Drawing.Point(1, 1)
        Me.pnlRed.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRed.Name = "pnlRed"
        Me.pnlRed.Size = New System.Drawing.Size(20, 20)
        Me.pnlRed.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblMidTime, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.pnlYellow, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(199, 90)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(73, 22)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'lblMidTime
        '
        Me.lblMidTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMidTime.Location = New System.Drawing.Point(22, 1)
        Me.lblMidTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMidTime.Name = "lblMidTime"
        Me.lblMidTime.Size = New System.Drawing.Size(50, 20)
        Me.lblMidTime.TabIndex = 6
        Me.lblMidTime.Text = "0"
        '
        'pnlYellow
        '
        Me.pnlYellow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlYellow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlYellow.Location = New System.Drawing.Point(1, 1)
        Me.pnlYellow.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlYellow.Name = "pnlYellow"
        Me.pnlYellow.Size = New System.Drawing.Size(20, 20)
        Me.pnlYellow.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblQualifyTime, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlGreen, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(96, 90)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(73, 22)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lblQualifyTime
        '
        Me.lblQualifyTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQualifyTime.Location = New System.Drawing.Point(22, 1)
        Me.lblQualifyTime.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQualifyTime.Name = "lblQualifyTime"
        Me.lblQualifyTime.Size = New System.Drawing.Size(50, 20)
        Me.lblQualifyTime.TabIndex = 6
        Me.lblQualifyTime.Text = "0"
        '
        'pnlGreen
        '
        Me.pnlGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGreen.Location = New System.Drawing.Point(1, 1)
        Me.pnlGreen.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlGreen.Name = "pnlGreen"
        Me.pnlGreen.Size = New System.Drawing.Size(20, 20)
        Me.pnlGreen.TabIndex = 5
        Me.MetroToolTip1.SetToolTip(Me.pnlGreen, "INDIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Welcome")
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 47)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(380, 1)
        Me.Panel7.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(380, 47)
        Me.Panel6.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 31)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Speech Timer"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 38)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'txtTimeFor
        '
        Me.txtTimeFor.Location = New System.Drawing.Point(76, 121)
        Me.txtTimeFor.Name = "txtTimeFor"
        Me.txtTimeFor.Size = New System.Drawing.Size(302, 25)
        Me.txtTimeFor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time For"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSegment
        '
        Me.cmbSegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSegment.FormattingEnabled = True
        Me.cmbSegment.Location = New System.Drawing.Point(76, 58)
        Me.cmbSegment.Name = "cmbSegment"
        Me.cmbSegment.Size = New System.Drawing.Size(302, 25)
        Me.cmbSegment.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkTimingLight
        '
        Me.lnkTimingLight.AutoSize = True
        Me.lnkTimingLight.LinkColor = System.Drawing.Color.Navy
        Me.lnkTimingLight.Location = New System.Drawing.Point(0, 13)
        Me.lnkTimingLight.Name = "lnkTimingLight"
        Me.lnkTimingLight.Size = New System.Drawing.Size(79, 17)
        Me.lnkTimingLight.TabIndex = 10
        Me.lnkTimingLight.TabStop = True
        Me.lnkTimingLight.Text = "Timing Light"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnStop)
        Me.Panel2.Controls.Add(Me.pnlColor)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnStart)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 61)
        Me.Panel2.TabIndex = 8
        '
        'btnStop
        '
        Me.btnStop.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnStop.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnStop.Highlight = False
        Me.btnStop.Location = New System.Drawing.Point(76, 14)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(63, 35)
        Me.btnStop.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnStop.StyleManager = Nothing
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'pnlColor
        '
        Me.pnlColor.Controls.Add(Me.lblTime)
        Me.pnlColor.Location = New System.Drawing.Point(240, 9)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(137, 42)
        Me.pnlColor.TabIndex = 8
        '
        'lblTime
        '
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(0, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(137, 42)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00.00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnReset.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnReset.Highlight = False
        Me.btnReset.Location = New System.Drawing.Point(151, 14)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(63, 35)
        Me.btnReset.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnReset.StyleManager = Nothing
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btnStart
        '
        Me.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnStart.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnStart.Highlight = False
        Me.btnStart.Location = New System.Drawing.Point(2, 14)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(63, 35)
        Me.btnStart.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnStart.StyleManager = Nothing
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLine.Location = New System.Drawing.Point(10, 217)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(380, 1)
        Me.pnlLine.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbQualified)
        Me.Panel3.Controls.Add(Me.lnkTimingLight)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(10, 218)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 42)
        Me.Panel3.TabIndex = 10
        '
        'cbQualified
        '
        Me.cbQualified.AutoSize = True
        Me.cbQualified.BackColor = System.Drawing.Color.Transparent
        Me.cbQualified.Location = New System.Drawing.Point(302, 13)
        Me.cbQualified.Name = "cbQualified"
        Me.cbQualified.Size = New System.Drawing.Size(79, 21)
        Me.cbQualified.TabIndex = 3
        Me.cbQualified.Text = "Qualified"
        Me.cbQualified.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnPause)
        Me.Panel4.Controls.Add(Me.lnkAbout)
        Me.Panel4.Controls.Add(Me.lnkSegment)
        Me.Panel4.Controls.Add(Me.lnkClearGrid)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 440)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(380, 54)
        Me.Panel4.TabIndex = 11
        '
        'btnPause
        '
        Me.btnPause.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPause.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnPause.Highlight = False
        Me.btnPause.Location = New System.Drawing.Point(151, 10)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(63, 35)
        Me.btnPause.Style = MetroFramework.MetroColorStyle.Lime
        Me.btnPause.StyleManager = Nothing
        Me.btnPause.TabIndex = 14
        Me.btnPause.Text = "Pause"
        Me.btnPause.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'lnkAbout
        '
        Me.lnkAbout.AutoSize = True
        Me.lnkAbout.LinkColor = System.Drawing.Color.Navy
        Me.lnkAbout.Location = New System.Drawing.Point(341, 17)
        Me.lnkAbout.Name = "lnkAbout"
        Me.lnkAbout.Size = New System.Drawing.Size(43, 17)
        Me.lnkAbout.TabIndex = 13
        Me.lnkAbout.TabStop = True
        Me.lnkAbout.Text = "About"
        '
        'lnkSegment
        '
        Me.lnkSegment.AutoSize = True
        Me.lnkSegment.LinkColor = System.Drawing.Color.Navy
        Me.lnkSegment.Location = New System.Drawing.Point(80, 17)
        Me.lnkSegment.Name = "lnkSegment"
        Me.lnkSegment.Size = New System.Drawing.Size(59, 17)
        Me.lnkSegment.TabIndex = 12
        Me.lnkSegment.TabStop = True
        Me.lnkSegment.Text = "Segment"
        '
        'lnkClearGrid
        '
        Me.lnkClearGrid.AutoSize = True
        Me.lnkClearGrid.LinkColor = System.Drawing.Color.Navy
        Me.lnkClearGrid.Location = New System.Drawing.Point(0, 17)
        Me.lnkClearGrid.Name = "lnkClearGrid"
        Me.lnkClearGrid.Size = New System.Drawing.Size(61, 17)
        Me.lnkClearGrid.TabIndex = 11
        Me.lnkClearGrid.TabStop = True
        Me.lnkClearGrid.Text = "Clear List"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(10, 260)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(380, 180)
        Me.Panel5.TabIndex = 12
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 10
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(380, 180)
        Me.dgv.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Segment"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Time For"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Time"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "S_State"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "SegmentId"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Del"
        Me.Column7.Image = CType(resources.GetObject("Column7.Image"), System.Drawing.Image)
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 30
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.[Default]
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'frmSession
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlLine)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSession"
        Me.Padding = New System.Windows.Forms.Padding(10, 3, 10, 6)
        Me.Text = "Speech Timer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbTooltip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlColor.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTM As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSegment As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeFor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnStart As MetroFramework.Controls.MetroButton
    Friend WithEvents btnStop As MetroFramework.Controls.MetroButton
    Friend WithEvents lnkTimingLight As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlLine As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lnkClearGrid As System.Windows.Forms.LinkLabel
    Friend WithEvents cbQualified As System.Windows.Forms.CheckBox
    Friend WithEvents lnkSegment As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblQualifyTime As System.Windows.Forms.Label
    Friend WithEvents pnlGreen As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMidTime As System.Windows.Forms.Label
    Friend WithEvents pnlYellow As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblMaxTime As System.Windows.Forms.Label
    Friend WithEvents pnlRed As System.Windows.Forms.Panel
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lnkAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents pbTooltip As System.Windows.Forms.PictureBox
    Friend WithEvents btnPause As MetroFramework.Controls.MetroButton
End Class
