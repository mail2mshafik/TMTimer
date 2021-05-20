Public Class frmClose

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        frmSession.DeleteRecordFlag = False
        clsGlobal.DeleteRecordFlag = False
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        frmSession.DeleteRecordFlag = True
        clsGlobal.DeleteRecordFlag = True
        Me.Close()
    End Sub

End Class