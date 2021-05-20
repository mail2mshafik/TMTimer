<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimer))
        Me.lblText = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picGif = New System.Windows.Forms.PictureBox()
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.lblPause = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPause.SuspendLayout()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Font = New System.Drawing.Font("Segoe UI Semibold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(89, 280)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(545, 182)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Timer"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(242, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 239)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'picGif
        '
        Me.picGif.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picGif.Image = CType(resources.GetObject("picGif.Image"), System.Drawing.Image)
        Me.picGif.Location = New System.Drawing.Point(266, 468)
        Me.picGif.Name = "picGif"
        Me.picGif.Size = New System.Drawing.Size(163, 15)
        Me.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGif.TabIndex = 15
        Me.picGif.TabStop = False
        Me.picGif.Visible = False
        '
        'pnlPause
        '
        Me.pnlPause.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlPause.Controls.Add(Me.lblPause)
        Me.pnlPause.Controls.Add(Me.picPause)
        Me.pnlPause.Location = New System.Drawing.Point(266, 440)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(186, 54)
        Me.pnlPause.TabIndex = 17
        Me.pnlPause.Visible = False
        '
        'picPause
        '
        Me.picPause.BackgroundImage = CType(resources.GetObject("picPause.BackgroundImage"), System.Drawing.Image)
        Me.picPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPause.Location = New System.Drawing.Point(5, 2)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(49, 47)
        Me.picPause.TabIndex = 17
        Me.picPause.TabStop = False
        '
        'lblPause
        '
        Me.lblPause.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.Black
        Me.lblPause.Location = New System.Drawing.Point(48, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(128, 46)
        Me.lblPause.TabIndex = 18
        Me.lblPause.Text = "PAUSE"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTimer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 506)
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.picGif)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTimer"
        Me.Text = "Timing Light"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPause.ResumeLayout(False)
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picGif As System.Windows.Forms.PictureBox
    Friend WithEvents pnlPause As System.Windows.Forms.Panel
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
End Class
