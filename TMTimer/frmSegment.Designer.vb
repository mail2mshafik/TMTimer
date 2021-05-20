<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSegment))
        Me.tmrTM = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDefaultSpeakerName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMidTime = New System.Windows.Forms.TextBox()
        Me.txtMaxQualifyTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaxTime = New System.Windows.Forms.TextBox()
        Me.txtMinQualifyTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSegmentName = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblSegmentId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQualifyTime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbAdd = New System.Windows.Forms.PictureBox()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.pbDelete = New System.Windows.Forms.PictureBox()
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.pbPrev = New System.Windows.Forms.PictureBox()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrTM
        '
        Me.tmrTM.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtDefaultSpeakerName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtMidTime)
        Me.Panel1.Controls.Add(Me.txtMaxQualifyTime)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtMaxTime)
        Me.Panel1.Controls.Add(Me.txtMinQualifyTime)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtSegmentName)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.txtQualifyTime)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 270)
        Me.Panel1.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(9, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(363, 28)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Time value should be in Seconds"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDefaultSpeakerName
        '
        Me.txtDefaultSpeakerName.Location = New System.Drawing.Point(106, 94)
        Me.txtDefaultSpeakerName.Name = "txtDefaultSpeakerName"
        Me.txtDefaultSpeakerName.Size = New System.Drawing.Size(272, 25)
        Me.txtDefaultSpeakerName.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Speaker"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMidTime
        '
        Me.txtMidTime.Location = New System.Drawing.Point(313, 156)
        Me.txtMidTime.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMidTime.Name = "txtMidTime"
        Me.txtMidTime.Size = New System.Drawing.Size(65, 25)
        Me.txtMidTime.TabIndex = 4
        '
        'txtMaxQualifyTime
        '
        Me.txtMaxQualifyTime.Location = New System.Drawing.Point(313, 227)
        Me.txtMaxQualifyTime.Name = "txtMaxQualifyTime"
        Me.txtMaxQualifyTime.Size = New System.Drawing.Size(65, 25)
        Me.txtMaxQualifyTime.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(193, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 35)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Qualify Max Time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(196, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Mid Time"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMaxTime
        '
        Me.txtMaxTime.Location = New System.Drawing.Point(107, 190)
        Me.txtMaxTime.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMaxTime.Name = "txtMaxTime"
        Me.txtMaxTime.Size = New System.Drawing.Size(65, 25)
        Me.txtMaxTime.TabIndex = 5
        '
        'txtMinQualifyTime
        '
        Me.txtMinQualifyTime.Location = New System.Drawing.Point(108, 227)
        Me.txtMinQualifyTime.Name = "txtMinQualifyTime"
        Me.txtMinQualifyTime.Size = New System.Drawing.Size(65, 25)
        Me.txtMinQualifyTime.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 35)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Qualify Min Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Max Time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSegmentName
        '
        Me.txtSegmentName.Location = New System.Drawing.Point(106, 59)
        Me.txtSegmentName.Name = "txtSegmentName"
        Me.txtSegmentName.Size = New System.Drawing.Size(272, 25)
        Me.txtSegmentName.TabIndex = 1
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
        Me.Panel6.Controls.Add(Me.lblSegmentId)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(380, 47)
        Me.Panel6.TabIndex = 11
        '
        'lblSegmentId
        '
        Me.lblSegmentId.Location = New System.Drawing.Point(289, 11)
        Me.lblSegmentId.Name = "lblSegmentId"
        Me.lblSegmentId.Size = New System.Drawing.Size(86, 23)
        Me.lblSegmentId.TabIndex = 19
        Me.lblSegmentId.Text = "SegmentId"
        Me.lblSegmentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSegmentId.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 31)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Segment"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQualifyTime
        '
        Me.txtQualifyTime.Location = New System.Drawing.Point(106, 156)
        Me.txtQualifyTime.Margin = New System.Windows.Forms.Padding(0)
        Me.txtQualifyTime.Name = "txtQualifyTime"
        Me.txtQualifyTime.Size = New System.Drawing.Size(65, 25)
        Me.txtQualifyTime.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qualify Time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Segment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbAdd)
        Me.Panel2.Controls.Add(Me.pbSave)
        Me.Panel2.Controls.Add(Me.pbDelete)
        Me.Panel2.Controls.Add(Me.pbNext)
        Me.Panel2.Controls.Add(Me.pbPrev)
        Me.Panel2.Controls.Add(Me.pnlLine)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 52)
        Me.Panel2.TabIndex = 8
        '
        'pbAdd
        '
        Me.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAdd.Image = CType(resources.GetObject("pbAdd.Image"), System.Drawing.Image)
        Me.pbAdd.Location = New System.Drawing.Point(260, 6)
        Me.pbAdd.Name = "pbAdd"
        Me.pbAdd.Size = New System.Drawing.Size(35, 35)
        Me.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdd.TabIndex = 16
        Me.pbAdd.TabStop = False
        '
        'pbSave
        '
        Me.pbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSave.Image = CType(resources.GetObject("pbSave.Image"), System.Drawing.Image)
        Me.pbSave.Location = New System.Drawing.Point(300, 6)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(35, 35)
        Me.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSave.TabIndex = 15
        Me.pbSave.TabStop = False
        '
        'pbDelete
        '
        Me.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDelete.Image = CType(resources.GetObject("pbDelete.Image"), System.Drawing.Image)
        Me.pbDelete.Location = New System.Drawing.Point(340, 6)
        Me.pbDelete.Name = "pbDelete"
        Me.pbDelete.Size = New System.Drawing.Size(35, 35)
        Me.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDelete.TabIndex = 14
        Me.pbDelete.TabStop = False
        '
        'pbNext
        '
        Me.pbNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext.Image = CType(resources.GetObject("pbNext.Image"), System.Drawing.Image)
        Me.pbNext.Location = New System.Drawing.Point(39, 6)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(35, 35)
        Me.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNext.TabIndex = 13
        Me.pbNext.TabStop = False
        '
        'pbPrev
        '
        Me.pbPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPrev.Image = CType(resources.GetObject("pbPrev.Image"), System.Drawing.Image)
        Me.pbPrev.Location = New System.Drawing.Point(2, 6)
        Me.pbPrev.Name = "pbPrev"
        Me.pbPrev.Size = New System.Drawing.Size(35, 35)
        Me.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPrev.TabIndex = 12
        Me.pbPrev.TabStop = False
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLine.Location = New System.Drawing.Point(0, 0)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(380, 1)
        Me.pnlLine.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSec)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMinute)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 335)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 58)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Converter"
        Me.GroupBox1.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(174, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "="
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(215, 24)
        Me.txtSec.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(58, 25)
        Me.txtSec.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(277, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Sec"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMinute
        '
        Me.txtMinute.Location = New System.Drawing.Point(49, 24)
        Me.txtMinute.Margin = New System.Windows.Forms.Padding(0)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(58, 25)
        Me.txtMinute.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(110, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Minute"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSegment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSegment"
        Me.Padding = New System.Windows.Forms.Padding(10, 3, 10, 6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Segment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTM As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQualifyTime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDefaultSpeakerName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMidTime As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxQualifyTime As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMaxTime As System.Windows.Forms.TextBox
    Friend WithEvents txtMinQualifyTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSegmentName As System.Windows.Forms.TextBox
    Friend WithEvents pnlLine As System.Windows.Forms.Panel
    Friend WithEvents pbPrev As System.Windows.Forms.PictureBox
    Friend WithEvents pbNext As System.Windows.Forms.PictureBox
    Friend WithEvents pbSave As System.Windows.Forms.PictureBox
    Friend WithEvents pbDelete As System.Windows.Forms.PictureBox
    Friend WithEvents pbAdd As System.Windows.Forms.PictureBox
    Friend WithEvents lblSegmentId As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSec As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMinute As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
