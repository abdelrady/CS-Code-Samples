
Public Class frmRegister

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'Reference property is a customer reference which is generated 
    'by SoftwareLock using your supplied AppName, Password,and the 
    'end-user's Hard Disk Serial No.
    'We need to display Reference to the end-user so they can
    'quote it to us, and using that Reference we use the keygen
    'program supplied to give end-user his/her serial key
    lblCustRef.Text = SL.Reference
  End Sub


  Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

    'The text typed in the textboxes by the customer is concatenated and passed to
    'the Register() method of the SoftwareLock object, it returns
    'a boolean value of True if the correct key was entered by the
    'end user, or vice-versa:
    Dim Successful As Boolean
    Successful = SL.Register(txtSK1.Text & txtSK2.Text & txtSK3.Text & txtSK4.Text)

    If Successful = True Then
      MsgBox("Software successfully registered. Thank You!")
      frmMain.Label1.Text = "Software registered." & vbCrLf & _
        "Your Serial Key is:  " & SL.SerialKey
      frmMain.Button1.Text = "Cancel Registration"

    Else
      MsgBox("There was an error registering your software" & vbCrLf & _
        "Make sure you have quoted the correct reference to" & vbCrLf & _
        "the program's vendor and obtained the correct Serial Key.")
    End If
  End Sub

 
  Private Sub txtSK1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
    Handles txtSK1.KeyUp, txtSK2.KeyUp, txtSK3.KeyUp, txtSK4.KeyUp

    'This is just to give our program a professional look and feel
    'and has nothing to do with SoftwareLock:
    'if 5 characters are typed into one of the serial-key textboxes then 
    'the focus is automatically shifted to the next textbox
    Dim txt As TextBox
    txt = CType(sender, TextBox)

    If txt.Text.Length = 5 Then
      Select Case True
        Case sender.Equals(txtSK1)
          e.Handled = True
          txtSK2.Focus()
        Case sender.Equals(txtSK2)
          e.Handled = True
          txtSK3.Focus()
        Case sender.Equals(txtSK3)
          e.Handled = True
          txtSK4.Focus()
        Case sender.Equals(txtSK4)
          e.Handled = True
          btnRegister.Focus()
      End Select

    ElseIf txt.Text.Length = 0 Then
      Select Case True
        Case sender.Equals(txtSK4)
          e.Handled = True
          txtSK3.Focus()
        Case sender.Equals(txtSK3)
          e.Handled = True
          txtSK2.Focus()
        Case sender.Equals(txtSK2)
          e.Handled = True
          txtSK1.Focus()
      End Select
    End If
  End Sub

  
End Class
