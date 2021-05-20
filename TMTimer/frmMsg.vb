Public Class frmMsg

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Sub showMsg(msg As String)
        lblMessage.Text = msg
    End Sub

    Private Sub frmMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class