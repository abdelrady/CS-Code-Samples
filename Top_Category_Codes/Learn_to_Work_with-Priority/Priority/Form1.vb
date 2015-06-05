Public Class Form1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '*** this timer check the priority of this program every 0.5 seconds

        'declaration
        Dim MyApp As Process

        Try
            'make MyApp as process 
            'MyApp = Me (form1)
            MyApp = Process.GetCurrentProcess

            'Check priority of MyApp
            Select Case MyApp.PriorityClass
                Case ProcessPriorityClass.Idle
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.Idle.ToString
                Case ProcessPriorityClass.BelowNormal
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.BelowNormal.ToString
                Case ProcessPriorityClass.Normal
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.Normal.ToString
                Case ProcessPriorityClass.AboveNormal
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.AboveNormal.ToString
                Case ProcessPriorityClass.High
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.High.ToString
                Case ProcessPriorityClass.RealTime
                    lblGetPriority.Text = "STATUS: Priority = " & ProcessPriorityClass.RealTime.ToString
            End Select
        Catch ex As Exception
            'exception message
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Dim MyApp As Process
        'make MyApp as process 
        'MyApp = Me (form1)
        MyApp = Process.GetCurrentProcess

        Try
            'check witch radiobutton is checked and
            'change priority of MyApp
            If RadioButton1.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.Idle
            ElseIf RadioButton2.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.BelowNormal
            ElseIf RadioButton3.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.Normal
            ElseIf RadioButton4.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.AboveNormal
            ElseIf RadioButton5.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.High
            ElseIf RadioButton6.Checked = True Then
                MyApp.PriorityClass = ProcessPriorityClass.RealTime
            End If
        Catch ex As Exception
            'exception message
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'on load make radiobutton "Normal" checked
        RadioButton3.Checked = True
    End Sub
End Class
