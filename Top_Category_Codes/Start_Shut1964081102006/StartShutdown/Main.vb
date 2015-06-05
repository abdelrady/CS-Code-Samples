'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Copyright © 2005-2006 Herbert N. Swearengen III
' All Rights Reserved.
'
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On
Option Explicit On
Imports System
Imports System.IO
Imports System.Diagnostics
Imports Microsoft.VisualBasic

Public Class Main
    Private mintSeconds As Integer
    Private mblnBeeps As Boolean
    Private Const Msg1 As String = "This computer is scheduled to shutdown in "
    Private Const Msg2 As String = " minutes. Click to cancel."
    Private Const Msg3 As String = " seconds. Click to cancel."

    Private Sub Main_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Escape) Then Me.Close()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' set label
        lblWarning.Text = Msg1 & "3:00" & Msg2

        If My.Settings.Item("Beep").ToString = "False" Then
            mblnBeeps = False
            chkDisableBeeps.Checked = True
        ElseIf My.Settings.Item("Beep").ToString = "True" Then
            mblnBeeps = True
            chkDisableBeeps.Checked = False
        End If

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub chkDisableBeeps_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDisableBeeps.CheckedChanged
        If chkDisableBeeps.Checked = True Then
            mblnBeeps = False
            My.Settings.Item("Beep") = "False"
            My.Settings.Save()
        ElseIf chkDisableBeeps.Checked = False Then
            mblnBeeps = True
            My.Settings.Item("Beep") = "True"
            My.Settings.Save()
        End If
    End Sub

    Private Sub tmrShutdown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShutdown.Tick
        Dim strSeconds As String
        mintSeconds += 1

        ' if beeps are enabled, beep every 10 seconds
        If mblnBeeps = True Then
            strSeconds = CStr(mintSeconds)
            If strSeconds.Substring(strSeconds.Length - 1) = "0" Then
                My.Computer.Audio.Play(My.Resources.Beep, AudioPlayMode.Background)
            End If
        End If

        If mintSeconds = 180 Then
            tmrShutdown.Enabled = False
            Shutdown()
        ElseIf mintSeconds <= 120 Then
            prgShutdown.Value = mintSeconds
            lblWarning.Text = Msg1 & FormatShortTime(180 - mintSeconds) & Msg2
        ElseIf mintSeconds > 120 Then
            prgShutdown.Value = mintSeconds
            lblWarning.Text = Msg1 & FormatShortTime(180 - mintSeconds) & Msg3
        End If
    End Sub

    Private Sub Shutdown()
        Try
            ' Now shutdown
            Dim startInfo As New ProcessStartInfo("c:\windows\system32\shutdown.exe", " -s -t 5")
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)

            Try
                ' Write to the event log
                My.Application.Log.WriteEntry("Shutdown Initiated", _
                    TraceEventType.Information)
            Catch exp As Exception
                MessageBox.Show("An error occurred writing to the System Application Log." _
                    & vbCrLf & vbCrLf & "The system returned the following information:" _
                    & vbCrLf & vbCrLf & exp.Message, My.Application.Info.Title, MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
            End Try
            ' now close this application
            Me.Close()
        Catch ex As Exception
            ' Write to the event log
            My.Application.Log.WriteEntry("Failed to Initiate shutdown.", _
                TraceEventType.Error)
        End Try
    End Sub

    Public Function FormatShortTime(ByVal intInSeconds As Integer) As String
        ' returns time formatted as mm:ss, all digits returned, leading zeros retained, from seconds
        Dim intMinutes As Integer
        Dim intSeconds As Integer
        Dim strMinutes As String
        Dim strSeconds As String

        Try
            ' initialize variables
            strMinutes = ""
            strSeconds = ""

            ' get whole minutes
            intMinutes = CInt(Int(intInSeconds / 60))

            ' get whole seconds
            intSeconds = Int(intInSeconds - intMinutes * 60)

            ' format minutes
            If intMinutes < 10 Then strMinutes = "0" & CStr(intMinutes) & ":"

            If intMinutes >= 10 Then strMinutes = CStr(intMinutes) & ":"

            If intMinutes > 59 Or intMinutes < 0 Then strMinutes = "00:"

            ' format seconds
            If intSeconds < 10 Then strSeconds = "0" & CStr(intSeconds)

            If intSeconds >= 10 Then strSeconds = CStr(intSeconds)
            If intSeconds > 59 Or intSeconds < 0 Then strSeconds = "00"

            Return strMinutes & strSeconds
        Catch
            Return vbNullString
        End Try

    End Function

End Class
