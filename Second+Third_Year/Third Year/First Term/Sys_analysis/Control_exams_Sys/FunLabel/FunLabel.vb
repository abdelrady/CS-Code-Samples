Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class FunLabel
    Inherits System.Windows.Forms.Label

    Private _backColor1 As Color = Color.White
    Private _backColor2 As Color = Color.Blue
    Private _gradientFallOff As Decimal = 0
    Private _gradientSpeed As Decimal = 0
    Private _gradientMode As LinearGradientMode = LinearGradientMode.ForwardDiagonal

    <Category("Gradient Appearance"), Description("Primary background color")> _
       Public Property BackColor1() As Color
        Get
            Return _backColor1
        End Get
        Set(ByVal Value As Color)
            _backColor1 = Value
            Invalidate()
        End Set
    End Property

    <Category("Gradient Appearance"), Description("Secondary background color")> _
       Public Property Backcolor2() As Color
        Get
            Return _backColor2
        End Get
        Set(ByVal Value As Color)
            _backColor2 = Value
            Invalidate()
        End Set
    End Property

    <Category("Gradient Appearance"), _
       Description("Linear Gradient Mode")> _
       Public Property GradientMode() As _
       LinearGradientMode
        Get
            Return _gradientMode
        End Get
        Set(ByVal Value As LinearGradientMode)
            _gradientMode = Value
            Invalidate()
        End Set
    End Property

    <Category("Gradient Appearance"), Description("Value between 0 and 1 " & _
       "dictates the scope of the fall " & "off of the primary color " & _
       "to the secondary color, which " & "creates the fun gradient look " & _
       "and feel. This is ignored if " & _
       "Gradient Speed is not set")> _
       Public Property GradientFallOff() As _
       Decimal
        Get
            Return _gradientFallOff
        End Get
        Set(ByVal Value As Decimal)
            If Value <= 1 Then
                _gradientFallOff = Value
            Else
                MessageBox.Show("Enter a value " & _
                   "between 0 and 1")
            End If
            Invalidate()
        End Set
    End Property

    <Category("Gradient Appearance"), Description("Value between 0 and 1 " & _
       "dictates the speed of the fall off " & "from the primary color " & _
       "to the secondary color")> _
       Public Property GradientSpeed() As Decimal
        Get
            Return _gradientSpeed
        End Get
        Set(ByVal Value As Decimal)
            If Value <= 1 Then
                _gradientSpeed = Value
            Else
                MessageBox.Show("Enter a value " & _
                   "between 0 and 1")
            End If
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)

        ' Create a Rectangle the size of the Label
        Dim rect As New Rectangle(0, 0, Me.Width, _
           Me.Height)

        ' Create new brush based on property settings
        Dim lgb As New LinearGradientBrush _
           (rect, BackColor1, Backcolor2, _
           GradientMode)

        ' If the GradientSpeed is set, then set the 
        ' speed and falloff of
        ' the colors from the edges of the label
        If GradientSpeed > 0 Then
            lgb.SetBlendTriangularShape( _
               _gradientFallOff, _gradientSpeed)
        End If

        ' Paint the label
        Try
            pevent.Graphics.FillRectangle(lgb, _
               rect)
        Catch
            ' Eat any errors, the property settings 
            ' trap any problems that may arise
        Finally
            lgb.Dispose()
        End Try
    End Sub
End Class
