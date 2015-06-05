Option Strict Off
Option Explicit On
Imports Microsoft.Win32
Friend Class Form1
    Inherits System.Windows.Forms.Form
    'http://satan.tz4.com
    'So take the good from this program.
    'Take the bad from this program.
    'Visit my website for more visual basic.net, c#, j#, and c++ codes
    'Along with visual studio 2005 express edition.
    'Which is what this was made in...
    'So if it doesn't work
    'Visit my site...
    'Make it work.
    'And many other good things in the forums.
    'http://satan.tz4.com < my website.
	
	Private Sub cmdRegMachine_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRegMachine.Click
        Dim oShell As RegistryKey
        Dim oReg As RegistryKey = Registry.LocalMachine
        oShell = oReg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        oShell.SetValue("MyVbApp", Application.ExecutablePath)
        'Adds this program to the machines startup.
    End Sub

    Private Sub cmdRegUser_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRegUser.Click
        Dim oReg As RegistryKey = Registry.CurrentUser
        Dim oKey As RegistryKey
        oKey = oReg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        oKey.SetValue("MyVbApp", Application.ExecutablePath)
        'Adds this program to the current users startup.
    End Sub

    Private Sub cmdStartup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStartup.Click
        Dim oShell As Object = CreateObject("WScript.Shell")
        Dim sPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim oSCut As Object
        oSCut = oShell.CreateShortcut(sPath & "\TestStartup.lnk")
        oSCut.TargetPath = Application.ExecutablePath
        oSCut.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oShell As Object = CreateObject("WScript.Shell")
        Dim sPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Try
            Kill(sPath & "\TestStartup.lnk")
            MsgBox("The Startup Entry has been removed.", MsgBoxStyle.Information, "Startup Remove")
        Catch
            MsgBox("There was no entry to delete!", MsgBoxStyle.Critical, "Startup Remove")
            'As in all of these if we made it here the file 90% of the time doesn't exist
        End Try
        'Removes the key entered
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim oReg As RegistryKey = Registry.LocalMachine
            Dim oKey As RegistryKey
            oKey = oReg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            oKey.DeleteValue("MyVbApp")
            'Adds this program to the current users startup.
        Catch
            MsgBox("Error", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetToolTips()
    End Sub
    Private Sub SetToolTips()
        ToolTip1.SetToolTip(Button2, "Removes the machines registry entry for this program.")
        ToolTip1.SetToolTip(cmdRegUser, "Sets this program to startup only for this user.")
        ToolTip1.SetToolTip(Button1, "Removes this program from the startup folder.")
        ToolTip1.SetToolTip(cmdStartup, "Sets this program to start via the Windows startup folder.")
        ToolTip1.SetToolTip(cmdRegMachine, "Sets this program to startup every time Windows starts.")
        ToolTip1.SetToolTip(Button3, "Removes this program from the current users registry.")
        'Do i have to explain what this does....
        'The name of the sub says it all ;)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim oReg As RegistryKey = Registry.CurrentUser
            Dim oKey As RegistryKey
            oKey = oReg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            oKey.DeleteValue("MyVbApp")
            'Adds this program to the current users startup.
        Catch
            MsgBox("Error", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class