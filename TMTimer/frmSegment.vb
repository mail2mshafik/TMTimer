Imports System.Data
Imports System.IO

Public Class frmSegment

    '0 Timming
    '1 Green
    '2 Yellow
    '3 Red
    '4 Disqualified

    Dim color_green As String = "#008000"
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
    
    Public Shared DeleteRecordFlag As Boolean = False

    Dim rIndex As Integer = 0

    Function getdbFilePath() As String
        Dim dbFileLoc As String = CurDir() + "\db\" & "db.xml"
        Return dbFileLoc
    End Function

 

    Sub initial()

        rIndex = 0

        txtQualifyTime.BackColor = System.Drawing.ColorTranslator.FromHtml(color_green)
        txtMidTime.BackColor = System.Drawing.ColorTranslator.FromHtml(color_yellow)
        txtMaxTime.BackColor = System.Drawing.ColorTranslator.FromHtml(color_red)

        pnlLine.BackColor = System.Drawing.ColorTranslator.FromHtml("#dddddd")


        getList()

        rIndex = 0
        ShowContent()

    End Sub
 
    
    Private Sub frmSegment_Load(sender As Object, e As EventArgs) Handles Me.Load
        initial()
    End Sub


    Sub getList()

        Dim ds As New DataSet
        ds.ReadXml(getdbFilePath)
        dtSegment = ds.Tables("Segment")

    End Sub

    Sub ShowContent()

        If Not IsDBNull(dtSegment.Rows(rIndex)("SegmentId")) Then
            lblSegmentId.Text = dtSegment.Rows(rIndex)("SegmentId")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("SegmentName")) Then
            txtSegmentName.Text = dtSegment.Rows(rIndex)("SegmentName")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("DefaultSpeakerName")) Then
            txtDefaultSpeakerName.Text = dtSegment.Rows(rIndex)("DefaultSpeakerName")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("QualifyTime")) Then
            txtQualifyTime.Text = dtSegment.Rows(rIndex)("QualifyTime")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("MidTime")) Then
            txtMidTime.Text = dtSegment.Rows(rIndex)("MidTime")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("MaxTime")) Then
            txtMaxTime.Text = dtSegment.Rows(rIndex)("MaxTime")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("MinQualifyTime")) Then
            txtMinQualifyTime.Text = dtSegment.Rows(rIndex)("MinQualifyTime")
        End If
        If Not IsDBNull(dtSegment.Rows(rIndex)("MaxQualifyTime")) Then
            txtMaxQualifyTime.Text = dtSegment.Rows(rIndex)("MaxQualifyTime")
        End If

        If Not IsDBNull(dtSegment.Rows(rIndex)("SegmentId")) Then
            If dtSegment.Rows(rIndex)("SegmentId") = 0 Then
                pbDelete.Visible = False
            Else
                pbDelete.Visible = True
            End If
        End If

    End Sub


    Private Sub pbNext_Click(sender As Object, e As EventArgs) Handles pbNext.Click

        If rIndex < dtSegment.Rows.Count - 1 Then
            rIndex = rIndex + 1
        End If
        ShowContent()

    End Sub


    Private Sub pbPrev_Click(sender As Object, e As EventArgs) Handles pbPrev.Click
        If rIndex > 0 Then
            rIndex = rIndex - 1
        End If
        ShowContent()
    End Sub

    Private Sub pbAdd_Click(sender As Object, e As EventArgs) Handles pbAdd.Click

        lblSegmentId.Text = Now.ToString("yyyMMddhhmmss")
        txtSegmentName.Text = ""
        txtDefaultSpeakerName.Text = ""
        txtQualifyTime.Text = ""
        txtMidTime.Text = ""
        txtMaxTime.Text = ""
        txtMinQualifyTime.Text = ""
        txtMaxQualifyTime.Text = ""

        txtSegmentName.Focus()

    End Sub


    Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click

        Dim ds As New DataSet
        ds.ReadXml(getdbFilePath)

        Dim SegmentId As String = lblSegmentId.Text
        Dim SegmentName As String = Trim(txtSegmentName.Text)
        Dim DefaultSpeakerName As String = Trim(txtDefaultSpeakerName.Text)
        Dim QualifyTime As String = Val(txtQualifyTime.Text)
        Dim MidTime As String = Val(txtMidTime.Text)
        Dim MaxTime As String = Val(txtMaxTime.Text)
        Dim MinQualifyTime As String = Val(txtMinQualifyTime.Text)
        Dim MaxQualifyTime As String = Val(txtMaxQualifyTime.Text)

        Dim isAdded As Boolean = False

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

            If ds.Tables(0).Rows(i)("SegmentId") = SegmentId Then

                ds.Tables(0).Rows(i)("SegmentName") = SegmentName
                ds.Tables(0).Rows(i)("DefaultSpeakerName") = DefaultSpeakerName
                ds.Tables(0).Rows(i)("QualifyTime") = QualifyTime
                ds.Tables(0).Rows(i)("MidTime") = MidTime
                ds.Tables(0).Rows(i)("MaxTime") = MaxTime
                ds.Tables(0).Rows(i)("MinQualifyTime") = MinQualifyTime
                ds.Tables(0).Rows(i)("MaxQualifyTime") = MaxQualifyTime

                ds.AcceptChanges()
                ds.WriteXml(getdbFilePath)

                isAdded = True
                Exit For
            End If

        Next

        If isAdded = False Then

            ds.Tables(0).Rows.Add()
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentId") = SegmentId
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentName") = SegmentName
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("DefaultSpeakerName") = DefaultSpeakerName
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("QualifyTime") = QualifyTime
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MidTime") = MidTime
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MaxTime") = MaxTime
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MinQualifyTime") = MinQualifyTime
            ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MaxQualifyTime") = MaxQualifyTime

            ds.AcceptChanges()
            ds.WriteXml(getdbFilePath)

            rIndex = ds.Tables(0).Rows.Count - 1

        End If
       
        
        AlerMessage("Imformation has been saved success!!")

        getList()
        ShowContent()

    End Sub


    Sub AlerMessage(msg)
        Dim frm As New frmMsg
        frm.showMsg(msg)
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()

    End Sub


    
    Private Sub txtMinute_TextChanged(sender As Object, e As EventArgs) Handles txtMinute.TextChanged

        Dim min As Integer = Val(txtMinute.Text)
        txtSec.Text = min * 60

    End Sub


    Private Sub pbDelete_Click(sender As Object, e As EventArgs) Handles pbDelete.Click

        Dim frm As New frmClose
        frm.StartPosition = FormStartPosition.CenterParent
        frm.ShowDialog()

        If clsGlobal.DeleteRecordFlag = True Then

            Dim ds As New DataSet("TMDB")
            ds.Tables.Add("Segment")

            ds.Tables(0).Columns.Add("SegmentId")
            ds.Tables(0).Columns.Add("SegmentName")
            ds.Tables(0).Columns.Add("QualifyTime")
            ds.Tables(0).Columns.Add("MidTime")
            ds.Tables(0).Columns.Add("MaxTime")
            ds.Tables(0).Columns.Add("MinQualifyTime")
            ds.Tables(0).Columns.Add("MaxQualifyTime")
            ds.Tables(0).Columns.Add("DefaultSpeakerName")

            Dim SegmentId As String = lblSegmentId.Text

            For i As Integer = 0 To dtSegment.Rows.Count - 1

                If dtSegment.Rows(i)("SegmentId") = SegmentId Then
                    Continue For
                End If

                ds.Tables(0).Rows.Add()
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentId") = dtSegment.Rows(i)("SegmentId")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("SegmentName") = dtSegment.Rows(i)("SegmentName")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("DefaultSpeakerName") = dtSegment.Rows(i)("DefaultSpeakerName")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("QualifyTime") = dtSegment.Rows(i)("QualifyTime")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MidTime") = dtSegment.Rows(i)("MidTime")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MaxTime") = dtSegment.Rows(i)("MaxTime")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MinQualifyTime") = dtSegment.Rows(i)("MinQualifyTime")
                ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)("MaxQualifyTime") = dtSegment.Rows(i)("MaxQualifyTime")


            Next

            ds.AcceptChanges()
            ds.WriteXml(getdbFilePath)

            AlerMessage("Deleted success!!")
            rIndex = 0
            getList()
            ShowContent()

            clsGlobal.DeleteRecordFlag = False

        End If


    End Sub
End Class