Public Class Class1
    Inherits System.Windows.Forms.Form

    Public Sub SnapToControl(ByVal i As Int32, ByVal j As Int32)
        Cursor.Position = New Drawing.Point(i, j)
    End Sub
End Class
