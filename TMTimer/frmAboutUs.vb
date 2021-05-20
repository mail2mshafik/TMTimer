
Public Class frmAboutUs



    Sub initial()

        Label1.Text = "Speech Timer Ver " & clsGlobal.app_version

    End Sub


    Private Sub frmAboutUs_Load(sender As Object, e As EventArgs) Handles Me.Load
        initial()

    End Sub


End Class