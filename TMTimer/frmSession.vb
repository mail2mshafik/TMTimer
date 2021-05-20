Imports System.Data
Imports System.IO

Public Class frmSession

    '0 Timming
    '1 Green
    '2 Yellow
    '3 Red
    '4 Disqualified

    Dim color_green As String = "#00FF00"
    Dim color_yellow As String = "#FFFF00"
    Dim color_red As String = "#FF0000"

    Dim current_s_stage As Integer = -1
    Dim current_s_time_sec As Long
    Dim sec_for_green As Long
    Dim sec_for_yellow As Long
    Dim sec_for_red As Long

    Dim sec_for_min_qualify As Long
    Dim sec_for_max_qualify As Long

    Dim dtSegment As DataTable
    Dim isSegmentSelected As Boolean = False

    Public Shared current_action_status As Integer = 0
    Public Shared IsTimingLightWindowOpened As Boolean = False
    Public Shared DeleteRecordFlag As Boolean = False

    Dim IsManualLight As Boolean = False

    Function getdbFilePath() As String
        Dim dbFileLoc As String = CurDir() + "\db\" & "db.xml"
        Return dbFileLoc
    End Function

    Function getdbSesionFilePath() As String
        Dim dbFileLoc As String = CurDir() + "\db\" & "dbSession.xml"
        Return dbFileLoc
    End Function

    Function getdbSesionFilePathCopy() As String
        Dim dbFileLoc As String = CurDir() + "\db\copy\" & "dbSession.xml"
        Return dbFileLoc
    End Function

    Sub initial()

        btnStart.Enabled = False
        btnStop.Enabled = False
        btnReset.Enabled = True

        FillDDL()

        pnlGreen.BackColor = System.Drawing.ColorTranslator.FromHtml(color_green)
        pnlYellow.BackColor = System.Drawing.ColorTranslator.FromHtml(color_yellow)
        pnlRed.BackColor = System.Drawing.ColorTranslator.FromHtml(color_red)

        pnlLine.BackColor = System.Drawing.ColorTranslator.FromHtml("#dddddd")


        getData()

    End Sub

    Sub FillDDL()
        Dim ds As New DataSet
        ds.ReadXml(getdbFilePath)
        dtSegment = ds.Tables("Segment")

        cmbSegment.DataSource = dtSegment
        cmbSegment.DisplayMember = "SegmentName"
        cmbSegment.ValueMember = "SegmentId"

        cmbSegment.SelectedIndex = 0
        SegmentSelected()


    End Sub



    Sub SetColor(sid)

        Dim bgColor As String = ""
        Dim showtitle As String = ""

        Select Case sid
            Case -1
                bgColor = "#FFFFFF"
                showtitle = "TIMER"
            Case 0
                bgColor = "#FFFFFF"
                showtitle = "TIMING"
            Case 1
                bgColor = color_green
                showtitle = "GREEN"
            Case 2
                bgColor = color_yellow
                showtitle = "YELLOW"
            Case 3
                bgColor = color_red
                showtitle = "RED"
            Case 4
                bgColor = "#f6b682"
                showtitle = "DISQUALIFIED"



        End Select

        If IsTimingLightWindowOpened = True Then
            frmTimer.BackColor = System.Drawing.ColorTranslator.FromHtml(bgColor)
            frmTimer.lblText.Text = showtitle
            If sid = -1 Then
                frmTimer.picGif.Visible = False
            Else
                frmTimer.picGif.Visible = True
            End If
        End If

      

        If current_action_status = 2 Then
            frmTimer.picGif.Visible = False
        End If

        If current_action_status = 3 Then
            frmTimer.picGif.Visible = False
            frmTimer.pnlPause.Visible = True
        Else
            frmTimer.pnlPause.Visible = False
        End If

        If current_action_status <> 0 Then
            lnkClearGrid.Enabled = False
            lnkSegment.Enabled = False
        Else
            lnkClearGrid.Enabled = True
            lnkSegment.Enabled = True
        End If

        pnlColor.BackColor = System.Drawing.ColorTranslator.FromHtml(bgColor)
        Application.DoEvents()

        


    End Sub

     

     Private Sub lnkTimingLight_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkTimingLight.LinkClicked

        IsTimingLightWindowOpened = True
        SetColor(current_s_stage)
        frmTimer.Show()

    End Sub

    

    Private Sub tmrTM_Tick(sender As Object, e As EventArgs) Handles tmrTM.Tick
        Try

            current_s_time_sec = current_s_time_sec + 1

            If current_s_time_sec = sec_for_green Then
                current_s_stage = 1
            End If

            If current_s_time_sec = sec_for_yellow Then
                current_s_stage = 2
            End If

            If current_s_time_sec = sec_for_red Then
                current_s_stage = 3
            End If

            SetColor(current_s_stage)
            ShowTime(current_s_time_sec)


        Catch ex As Exception
            tmrTM.Enabled = False
            MsgBox(ex.ToString())
        End Try


    End Sub

    Sub ShowTime(SecondsDifference As Integer)

        Dim hms = TimeSpan.FromSeconds(SecondsDifference)
        Dim h = hms.Hours.ToString("00")
        Dim m = hms.Minutes.ToString("00")
        Dim s = hms.Seconds.ToString("00")
        lblTime.Text = m + ":" + s
        Application.DoEvents()

    End Sub

    Function ShowTimeMinute(SecondsDifference As Integer) As String

        Dim hms = TimeSpan.FromSeconds(SecondsDifference)
        Dim h = hms.Hours.ToString
        Dim m = hms.Minutes.ToString("00")
        Dim s = hms.Seconds.ToString("00")
        Return m + ":" + s

    End Function

    Sub setLocation()

        Dim x As Integer
        Dim y As Integer
        Dim app_width As Integer = Me.Width

        'MsgBox(Screen.PrimaryScreen.WorkingArea.Width)
        'MsgBox(app_width)

        x = Screen.PrimaryScreen.WorkingArea.Width - app_width

        Me.Width = app_width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height - 100
        y = 96
        Me.Location = New Point(x, y)

    End Sub

    Private Sub frmSession_Load(sender As Object, e As EventArgs) Handles Me.Load
        setLocation()
        initial()

        Me.Text = "Speech Timer - " & clsGlobal.app_version

    End Sub


    Private Sub cmbSegment_GotFocus(sender As Object, e As EventArgs) Handles cmbSegment.GotFocus
        isSegmentSelected = True

    End Sub

    Private Sub cmbSegment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSegment.SelectedIndexChanged
        If isSegmentSelected = True And cmbSegment.SelectedIndex <> -1 Then

            SegmentSelected()

        End If
    End Sub

    Sub SegmentSelected()

        Dim SegmentId As String = cmbSegment.SelectedValue

        For i As Integer = 0 To dtSegment.Rows.Count - 1

            If SegmentId = dtSegment.Rows(i)("SegmentId") Then

                If Not IsDBNull(dtSegment.Rows(i)("QualifyTime")) Then
                    sec_for_green = dtSegment.Rows(i)("QualifyTime")
                End If
                If Not IsDBNull(dtSegment.Rows(i)("MidTime")) Then
                    sec_for_yellow = dtSegment.Rows(i)("MidTime")
                End If
                If Not IsDBNull(dtSegment.Rows(i)("MaxTime")) Then
                    sec_for_red = dtSegment.Rows(i)("MaxTime")
                End If

                If Not IsDBNull(dtSegment.Rows(i)("MinQualifyTime")) Then
                    sec_for_min_qualify = dtSegment.Rows(i)("MinQualifyTime")
                End If

                If Not IsDBNull(dtSegment.Rows(i)("MaxQualifyTime")) Then
                    sec_for_max_qualify = dtSegment.Rows(i)("MaxQualifyTime")
                End If

                If Not IsDBNull(dtSegment.Rows(i)("DefaultSpeakerName")) Then
                    txtTimeFor.Text = dtSegment.Rows(i)("DefaultSpeakerName")
                End If

                lblQualifyTime.Text = ShowTimeMinute(sec_for_green)
                lblMidTime.Text = ShowTimeMinute(sec_for_yellow)
                lblMaxTime.Text = ShowTimeMinute(sec_for_red)

                'lblMinQualifyTime.Text = ShowTimeMinute(sec_for_min_qualify)
                'lblMaxQualifyTime.Text = ShowTimeMinute(sec_for_max_qualify)

                MetroToolTip1.SetToolTip(pnlGreen, "Qualify min time : " & ShowTimeMinute(sec_for_min_qualify) & vbCr & vbLf & "Qualify max time : " & ShowTimeMinute(sec_for_max_qualify))
                MetroToolTip1.SetToolTip(lblQualifyTime, "Qualify min time : " & ShowTimeMinute(sec_for_min_qualify) & vbCr & vbLf & "Qualify max time : " & ShowTimeMinute(sec_for_max_qualify))
                MetroToolTip1.SetToolTip(pbTooltip, "Qualify min time : " & ShowTimeMinute(sec_for_min_qualify) & vbCr & vbLf & "Qualify max time : " & ShowTimeMinute(sec_for_max_qualify))

                btnStart.Enabled = True
                btnStop.Enabled = False
                btnReset.Enabled = True
                btnPause.Enabled = False

                Application.DoEvents()

                Exit For

            End If

        Next

    End Sub

   


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If Trim(txtTimeFor.Text) = String.Empty Then
                AlerMessage("Please enter name.")
                txtTimeFor.Focus()
                Exit Sub
            End If

            If sec_for_green <> 0 And sec_for_yellow <> 0 And sec_for_red <> 0 Then

                current_action_status = 1

                current_s_time_sec = 0
                current_s_stage = 0

                tmrTM.Enabled = True
                SetColor(current_s_stage)

                btnStart.Enabled = False
                btnStop.Enabled = True
                btnReset.Enabled = False

                btnPause.Enabled = True

                cmbSegment.Enabled = False


                pnlGreen.Cursor = Cursors.Default
                pnlYellow.Cursor = Cursors.Default
                pnlRed.Cursor = Cursors.Default

                lnkClearGrid.Enabled = False
                lnkSegment.Enabled = False


                Application.DoEvents()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try



    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try

            If sec_for_green <> 0 And sec_for_yellow <> 0 And sec_for_red <> 0 Then

                current_action_status = 2

                tmrTM.Enabled = False
                Application.DoEvents()

                If IsTimingLightWindowOpened = True Then
                    frmTimer.picGif.Visible = False
                End If
                Application.DoEvents()

                SaveSession(current_s_time_sec)

                btnStart.Enabled = False
                btnStop.Enabled = False
                btnReset.Enabled = True
                btnPause.Enabled = False

                cmbSegment.Enabled = False

                Application.DoEvents()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        current_action_status = 0

        current_s_time_sec = 0

        tmrTM.Enabled = False

        btnStart.Enabled = True
        btnStop.Enabled = False
        btnReset.Enabled = True
        btnPause.Enabled = False

        cmbSegment.Enabled = True

        current_s_stage = -1
        SetColor(current_s_stage)

        'txtTimeFor.Text = ""
        txtTimeFor.Focus()

        lblTime.Text = "0.00"

        pnlGreen.Cursor = Cursors.Hand
        pnlYellow.Cursor = Cursors.Hand
        pnlRed.Cursor = Cursors.Hand

        Application.DoEvents()

    End Sub

#Region "Read Load"

    Sub CreatSessionDb()


        Dim f1 As String = getdbSesionFilePathCopy()
        Dim f2 As String = getdbSesionFilePath()

        File.Copy(f1, f2, True)

    End Sub
    Sub SaveSession(TimeTaken As Integer)

        Dim SegmentId As String = cmbSegment.SelectedValue
        Dim SegmentName As String = cmbSegment.Text
        Dim TimeFor As String = Trim(txtTimeFor.Text)

        Dim Status As String = "0"
        If current_s_time_sec >= sec_for_min_qualify And current_s_time_sec <= sec_for_max_qualify Then
            Status = "1"
        End If

        Dim p As String = getdbSesionFilePath()
        Dim ds As New DataSet
        ds.ReadXml(p)

        ds.Tables(0).Rows.Add()
        ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentId") = SegmentId
        ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentName") = SegmentName
        ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeFor") = TimeFor
        ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeTaken") = ShowTimeMinute(TimeTaken)
        ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("Status") = Status
        ds.AcceptChanges()
        ds.WriteXml(p)



        'AlerMessage("Imformation has been saved success!!")
        getData()

    End Sub

    Sub getData()

        Try
            Dim p As String = getdbSesionFilePath()

            If File.Exists(p) = False Then
                CreatSessionDb()
            End If

            Dim ds As New DataSet
            ds.ReadXml(p)

            Dim dt As DataTable = ds.Tables("SegmentSession")
            With dgv

                .RowCount = 0

                For i As Integer = 0 To dt.Rows.Count - 1
                    If Val(dt.Rows(i)("SegmentId")) = -1 Then
                        Continue For
                    End If
                    .Rows.Add()

                    If dt.Rows(i)("Status") = 0 Then
                        .Item(0, .Rows.Count - 1).Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#fb6060")
                    Else
                        .Item(0, .Rows.Count - 1).Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#008000")
                    End If

                    .Item(1, .Rows.Count - 1).Value = dt.Rows(i)("SegmentName")
                    .Item(2, .Rows.Count - 1).Value = dt.Rows(i)("TimeFor")
                    .Item(3, .Rows.Count - 1).Value = dt.Rows(i)("TimeTaken")
                    .Item(4, .Rows.Count - 1).Value = dt.Rows(i)("Status")
                    .Item(5, .Rows.Count - 1).Value = dt.Rows(i)("SegmentId")



                    Application.DoEvents()

                Next
            End With


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Sub getDataOnlyQualified()

        Try
            Dim p As String = getdbSesionFilePath()

            If File.Exists(p) = False Then
                CreatSessionDb()
            End If

            Dim ds As New DataSet
            ds.ReadXml(p)

            Dim dt As DataTable = ds.Tables("SegmentSession")
            With dgv

                .RowCount = 0

                For i As Integer = 0 To dt.Rows.Count - 1
                    If Val(dt.Rows(i)("SegmentId")) = -1 Then
                        Continue For
                    End If
                    If dt.Rows(i)("Status") = 0 Then
                        Continue For
                    End If
                    .Rows.Add()

                    If dt.Rows(i)("Status") = 0 Then
                        .Item(0, .Rows.Count - 1).Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#fb6060")
                    Else
                        .Item(0, .Rows.Count - 1).Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#008000")
                    End If

                    .Item(1, .Rows.Count - 1).Value = dt.Rows(i)("SegmentName")
                    .Item(2, .Rows.Count - 1).Value = dt.Rows(i)("TimeFor")
                    .Item(3, .Rows.Count - 1).Value = dt.Rows(i)("TimeTaken")
                    .Item(4, .Rows.Count - 1).Value = dt.Rows(i)("Status")
                    .Item(5, .Rows.Count - 1).Value = dt.Rows(i)("SegmentId")



                    Application.DoEvents()

                Next
            End With


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub lnkClearGrid_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkClearGrid.LinkClicked

        Dim frm As New frmClose
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()


        If DeleteRecordFlag = True Then
            CreatSessionDb()
            DeleteRecordFlag = False
        End If

        getData()

    End Sub

#End Region

    Sub AlerMessage(msg)
        Dim frm As New frmMsg
        frm.showMsg(msg)
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()

    End Sub




    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If e.ColumnIndex = 6 Then

            If current_action_status = 1 Then
                Exit Sub
            End If

            Dim r As Integer = e.RowIndex

            Dim frm As New frmClose
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog()

            If DeleteRecordFlag = True Then

                Dim ds As New DataSet("TMDBS")
                ds.Tables.Add("SegmentSession")

                ds.Tables(0).Columns.Add("SegmentId")
                ds.Tables(0).Columns.Add("SegmentName")
                ds.Tables(0).Columns.Add("TimeFor")
                ds.Tables(0).Columns.Add("TimeTaken")
                ds.Tables(0).Columns.Add("Status")

                ds.Tables(0).Rows.Add()
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentId") = -1
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentName") = ""
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeFor") = ""
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeTaken") = ""
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("Status") = 0

                For i As Integer = 0 To dgv.Rows.Count - 1
                    If i = r Then
                        Continue For
                    End If

                    ds.Tables(0).Rows.Add()
                    ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentId") = dgv.Item(5, i).Value
                    ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentName") = dgv.Item(1, i).Value
                    ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeFor") = dgv.Item(2, i).Value
                    ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("TimeTaken") = dgv.Item(3, i).Value
                    ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("Status") = dgv.Item(4, i).Value

                Next

                Dim p As String = getdbSesionFilePath()
                ds.AcceptChanges()
                ds.WriteXml(p)

                getData()

                DeleteRecordFlag = False
            End If


        End If
    End Sub

    Private Sub lnkSegment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSegment.LinkClicked

        Dim frm As New frmSegment
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()

        FillDDL()

    End Sub

    Private Sub lnkAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAbout.LinkClicked
        Dim frm As New frmAboutUs
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()
    End Sub

    Private Sub cbQualified_CheckedChanged(sender As Object, e As EventArgs) Handles cbQualified.CheckedChanged

        Dim isChecked As Boolean = IIf(cbQualified.Checked, True, False)

        If isChecked = True Then
            getDataOnlyQualified()
        Else
            getData()
        End If

    End Sub


    Private Sub pnlGreen_Click(sender As Object, e As EventArgs) Handles pnlGreen.Click

        If IsTimingLightWindowOpened = True And current_action_status = 0 Then
            frmTimer.BackColor = System.Drawing.ColorTranslator.FromHtml(color_green)
        End If


    End Sub

    Private Sub pnlYellow_Click(sender As Object, e As EventArgs) Handles pnlYellow.Click
        If IsTimingLightWindowOpened = True And current_action_status = 0 Then
            frmTimer.BackColor = System.Drawing.ColorTranslator.FromHtml(color_yellow)
        End If
    End Sub


    Private Sub pnlRed_Click(sender As Object, e As EventArgs) Handles pnlRed.Click
        If IsTimingLightWindowOpened = True And current_action_status = 0 Then
            frmTimer.BackColor = System.Drawing.ColorTranslator.FromHtml(color_red)
        End If
    End Sub


    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        If current_action_status = 1 Then
            current_action_status = 3
            tmrTM.Enabled = False
            btnPause.Text = "Resume"
            btnStop.Enabled = False
        ElseIf current_action_status = 3 Then
            current_action_status = 1
            tmrTM.Enabled = True
            btnPause.Text = "Pause"
            btnStop.Enabled = True
        End If

        SetColor(current_s_stage)
        Application.DoEvents()


    End Sub

End Class