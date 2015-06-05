'This application demonstrates how to use SoftwareLock class
'to protect your software against illegal copying or un-authorised 
'use.
'you can use the SofwareLock class, the DLL, or any snippet from 
'this project anywhere you like, but giving me credit where credit 
'is due, is always a good idea!

'PLEASE NOTE THAT: before running this program you need to click on
'SoftwareLock.vb file in the solutions explorer and then click 
'Build to build SoftwareLock.dll, referenced in this project.

Option Explicit On
Option Strict On

Public Class frmMain

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

    'WE NEED TO SET UP A FEW PROPERTIES OF THE SOFTWARELOCK OBJECT, 
    'AND THE BEST PLACE TO DO THIS IS IN THE MAIN FORM'S CONSTRUCTOR:

    'SL is the SoftwareLock object, declared as Public in Module1.vb 
    'and has global scope in the project

    'Name of application
    SL.AppName = "mysoftware"
    'password for the application
    SL.Password = "mypassword"
    'HashAlgorithm used for encryption: I am using MD5!
    SL.HashAlgorithm = SoftwareLock.SoftwareLock.HashAlgorithms.MD5
    'Length of Reference we want to provide to the end-user
    'between 6 and 20 characters
    SL.ReferenceLength = 6
    'Base Registry Key where registration information is stored
    'usually its "CompanyName\ProductName"
    SL.RegistryBaseKey = "AFTech\SoftwareLockDemo"
    'Subkey of Base Registry Key to store end-user's Serial Key
    SL.RegistrySubKey = "SerialNo"
    'THAT's IT!
  End Sub


  Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'in application's main form's load event we have to check if
    'the program is registered if yes, we give the end-user full
    'access to all program features, if not we prompt the user for
    'registration, this is done by checking the isRegistered property
    If SL.isRegistered = True Then
      Label1.Text = "Software registered." & vbCrLf & _
        "Your Serial Key is:  " & SL.SerialKey & vbCrLf & _
        "You now have full access to all program features!"
      Button1.Text = "Cancel Registration"
    Else
      Label1.Text = "Software not registered."
      Button1.Text = "Register"
    End If

  End Sub


  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim btn As Button
    btn = CType(sender, Button)
    If btn.Text = "Register" Then
      frmRegister.ShowDialog()
    Else
      'CancelRegistration() method is for testing purposes, should u
      'wish to delete any test registration data from the windows
      'registry, or maybe you can use it to un-register the software
      'if the end-user does something you don't like!!! LOL!...
      'anyways, it returns true if successful and vice-versa
      If (SL.CancelRegistration()) Then
        Label1.Text = "Software not registered."
        btn.Text = "Register"
      End If
    End If
  End Sub


End Class