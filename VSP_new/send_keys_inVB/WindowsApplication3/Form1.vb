Public Class Form1
    Public Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Int32, ByVal dwExtraInfo As Int32)
    Public Sub MinimizeAll()
        keybd_event(&H5B, 0, 0, 0)
        keybd_event(&H4D, 0, 0, 0)
        keybd_event(&H5B, 0, &H2, 0)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeAll()

    End Sub
End Class
