Public Class frmTimer

    Sub setLocation()

        Dim x As Integer
        Dim y As Integer
        Dim app_width As Integer = 415

       
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width - app_width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        x = 0
        y = 5
        Me.Location = New Point(x, y)

    End Sub


    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPause.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff")
        pnlPause.BackColor = System.Drawing.ColorTranslator.FromHtml("#e74c3c")

        setLocation()
    End Sub

    Private Sub frmTimer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmSession.IsTimingLightWindowOpened = False
    End Sub

End Class