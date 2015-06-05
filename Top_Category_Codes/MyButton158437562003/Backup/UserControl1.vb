Imports System.Drawing
Imports System.Drawing.Drawing2D

'Written by Ken Graci
'
'Portions based on code posted to Planet-Source-Code by:
'   Fausta Curz Arruda (EasyButtons) - mostly inspiration
'   Dave Andrews (Rounded Buttons) - for Color Class, and "roundness" concept
'   Raffaele Zurlo (Irregularly shaped forms) - for irregular regions
'
'   Derived from the Button Class, uses gradient shading and regions to create
'   rounded buttons.  Percise text positioning, Mouseover and Has-Focus effects.
'
'Has all the normal button properties and events, plus these:
'
'ButtonColor1 = start color of gradient
'ButtonColor2 = end color of gradient
'ButtonMouseOver = true for effect when mouse over
'ButtonShadowText = true for shadow text effect
'ButtonEmbossText = true for engraved test effect
'ButtonTextX = the button uses the MyBase.TextAlign for text positioning
'ButtonTextY   but these X and Y's let you fine tune the thext position
'ButtonRadius = radius (up to min(width, height) of button for roundness of button.
'
'Some ToDo's:
'
'Font set at desing time is not used by the class, but font set at run time is.  I 
'can't figure out why...


Public Class MyButton

    Inherits System.Windows.Forms.Button

    Public Enum BTNState As Integer
        ButtonUp = 0
        ButtonDown = 1
    End Enum

    Private eState As BTNState = BTNState.ButtonUp

    'controls how text is displayed
    Private blnEmbossText As Boolean = False
    Private blnShadowText As Boolean = False
    Private blnDoMouseOver As Boolean = False
    'text offsets are used in combination with me.TextAlign
    Private intTextX As Integer = 0
    Private intTextY As Integer = 0

    'some state informaiton
    Private blnMouseIsOver As Boolean = False
    Private blnHasFocus As Boolean = False
    Private blnIsEnabled As Boolean = True

    Private Radius As Integer = 0

    'colors used for style = brush
    Private c1 As Color = System.Drawing.SystemColors.Control
    Private c2 As Color = System.Drawing.SystemColors.ControlDark
    Private g1 As Color = System.Drawing.SystemColors.Control
    Private g2 As Color = System.Drawing.SystemColors.ControlDark


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'UserControl1 overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Public Property ButtonColor1() As Color
        Get
            ButtonColor1 = c1
        End Get
        Set(ByVal Value As Color)
            c1 = Value
            g1 = Brighten(c1, 0.1)
        End Set
    End Property

    Public Property ButtonColor2() As Color
        Get
            ButtonColor2 = c2
        End Get
        Set(ByVal Value As Color)
            c2 = Value
            g2 = Darken(c2, 0.1)
        End Set
    End Property

    Public Property ButtonMouseOver() As Boolean
        Get
            ButtonMouseOver = blnDoMouseOver
        End Get
        Set(ByVal Value As Boolean)
            blnDoMouseOver = Value
        End Set
    End Property

    Public Property ButtonEmbossText() As Boolean
        Get
            ButtonEmbossText = blnEmbossText
        End Get
        Set(ByVal Value As Boolean)
            blnEmbossText = Value
            'Me.Invalidate()
        End Set
    End Property

    Public Property ButtonShadowText() As Boolean
        Get
            ButtonShadowText = blnShadowText
        End Get
        Set(ByVal Value As Boolean)
            blnShadowText = Value
            'Me.Invalidate()
        End Set
    End Property


    Public Property ButtonTextX() As Integer
        Get
            ButtonTextX = intTextX
        End Get
        Set(ByVal Value As Integer)
            intTextX = Value
            'Me.Invalidate()
        End Set
    End Property

    Public Property ButtonTextY() As Integer
        Get
            ButtonTextY = intTextY
        End Get
        Set(ByVal Value As Integer)
            intTextY = Value
            'Me.Invalidate()
        End Set
    End Property

    Public Property ButtonRadius() As Integer
        Get
            ButtonRadius = Radius
        End Get
        Set(ByVal Value As Integer)

            Radius = Value

            If Radius < 0 Then Radius = 0
            If Radius > Me.Height / 2 Then Radius = Me.Height / 2
            If Radius > Me.Width / 2 Then Radius = Me.Width / 2

            SetRegion()
            Me.Invalidate()

        End Set
    End Property

    Private Sub MyButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim g As Graphics = e.Graphics
        Dim r As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        Dim lgb As Drawing2D.LinearGradientBrush
        Dim lgm As Drawing2D.LinearGradientMode = LinearGradientMode.Vertical

        If eState = BTNState.ButtonUp Then
            If blnMouseIsOver And blnDoMouseOver Then
                lgb = New Drawing2D.LinearGradientBrush(r, g1, g2, 0)
            Else
                lgb = New Drawing2D.LinearGradientBrush(r, g1, g2, lgm)
            End If
        Else
            lgb = New Drawing2D.LinearGradientBrush(r, g2, g1, lgm)
        End If

        g.FillRectangle(lgb, r)

        DrawFocusCue(e.Graphics)

        DrawText(e.Graphics)

    End Sub

    Private Sub DrawFocusCue(ByVal g As Graphics)

        Dim rec As Rectangle
        Dim pen As New Pen(Darken(c2, 0.25), 2)

        If eState = BTNState.ButtonUp Then

            If blnHasFocus Then

                If Radius = 0 Then
                    rec = New Rectangle(1, 1, Me.Width - 2, Me.Height - 2)
                    g.DrawRectangle(pen, rec)
                Else

                    Dim Diameter As Integer = Radius * 2

                    'upper left
                    rec = New Rectangle(-1, 0, Diameter, Diameter)
                    g.DrawArc(pen, rec, 180, 90)
                    g.DrawLine(pen, Radius, 1, Me.Width - Radius, 1)

                    'upper right
                    rec = New Rectangle(Me.Width - Diameter - 1, 0, Diameter, Diameter)
                    g.DrawArc(pen, rec, 270, 90)
                    g.DrawLine(pen, Me.Width, Radius, Me.Width, Me.Height - Radius)

                    'lower right
                    rec = New Rectangle(Me.Width - Diameter - 1, Me.Height - Diameter - 1, Diameter, Diameter)
                    g.DrawArc(pen, rec, 0, 90)
                    g.DrawLine(pen, Me.Width - Radius, Me.Height - 1, Radius, Me.Height - 1)

                    'lower left
                    rec = New Rectangle(-1, Me.Height - Diameter - 1, Diameter, Diameter)
                    g.DrawArc(pen, rec, 90, 90)
                    g.DrawLine(pen, 0, Me.Height - Radius + 1, 0, Radius - 1)
                End If
            End If
        End If

    End Sub

    Private Sub DrawText(ByVal G As Graphics)

        Dim Size As SizeF
        Dim x As Single
        Dim y As Single
        Dim B As SolidBrush

        Size = G.MeasureString(Me.Text, Me.Font)
        Dim w As Integer = Size.Width
        Dim h As Integer = Size.Height

        Select Case Me.TextAlign
            Case ContentAlignment.BottomCenter
                x = (Me.Width - w) / 2 : y = Me.Height - h
            Case ContentAlignment.MiddleCenter
                x = (Me.Width - w) / 2 : y = (Me.Height - h) / 2
            Case ContentAlignment.TopCenter
                x = (Me.Width - w) / 2 : y = 0

            Case ContentAlignment.BottomLeft
                x = 0 : y = Me.Height - h
            Case ContentAlignment.MiddleLeft
                x = 0 : y = (Me.Height - h) / 2
            Case ContentAlignment.TopLeft
                x = 0 : y = 0

            Case ContentAlignment.BottomRight
                x = Me.Width - w : y = Me.Height - h
            Case ContentAlignment.MiddleRight
                x = Me.Width - w : y = (Me.Height - h) / 2
            Case ContentAlignment.TopRight
                x = Me.Width - w : y = 0
        End Select

        If eState = BTNState.ButtonDown Then
            x += 1
            y += 1
        End If

        If blnEmbossText Then
            B = New SolidBrush(Invert(Me.ForeColor))
            G.DrawString(Me.Text, Me.Font, B, x + 1, y + 1)
        ElseIf blnShadowText Then
            B = New SolidBrush(Color.Black)
            G.DrawString(Me.Text, Me.Font, B, x - 1, y + 1)
        End If

        B = New SolidBrush(Me.ForeColor)
        G.DrawString(Me.Text, Me.Font, B, x, y)

    End Sub

    Private Function Invert(ByVal C As Color) As Color
        Invert = Color.FromArgb(255 - C.R, 255 - C.G, 255 - C.B)
    End Function

    Private Sub MyButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        eState = BTNState.ButtonDown
    End Sub

    Private Sub MyButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        eState = BTNState.ButtonUp
        Me.Invalidate()
    End Sub

    Private Sub MyButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        blnMouseIsOver = True
        Me.Invalidate()
    End Sub

    Private Sub MyButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        blnMouseIsOver = False
        Me.Invalidate()
    End Sub

    Private Sub SetRegion()

        Dim graphics_path As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim rec As Rectangle

        If Radius = 0 Then
            rec = New Rectangle(0, 0, Me.Width, Me.Height)
            graphics_path.AddRectangle(rec)
        Else

            Dim Diameter As Integer = Radius * 2

            'upper left
            rec = New Rectangle(-1, -1, Diameter, Diameter)
            graphics_path.AddArc(rec, 180, 90)
            graphics_path.AddLine(Radius, 0, Me.Width - Radius, 0)

            'upper right
            rec = New Rectangle(Me.Width - Diameter, -1, Diameter, Diameter)
            graphics_path.AddArc(rec, 270, 90)
            graphics_path.AddLine(Me.Width, Radius, Me.Width, Me.Height - Radius)

            'lower right
            rec = New Rectangle(Me.Width - Diameter, Me.Height - Diameter, Diameter, Diameter)
            graphics_path.AddArc(rec, 0, 90)
            graphics_path.AddLine(Me.Width - Radius, Me.Height, Radius, Me.Height)

            'lower left
            rec = New Rectangle(-1, Me.Height - Diameter, Diameter, Diameter)
            graphics_path.AddArc(rec, 90, 90)
            graphics_path.AddLine(0, Me.Height - Radius, 0, Radius)

        End If

        Me.Region = New Region(graphics_path)

    End Sub


    Private Function Brighten(ByVal C As Color, ByVal Percent As Single) As Color
        Dim HSL As New colorHSL(C)
        Dim L As Single
        If Percent <= 0 Then
            Brighten = C
            Exit Function
        End If
        L = HSL.Lum + (HSLMAX * Percent)
        If L > HSLMAX Then L = HSLMAX
        HSL.Lum = L
        Brighten = HSL.ColorValue
    End Function

    Private Function Darken(ByVal C As Color, ByVal Percent As Single) As Color

        Dim HSL As New colorHSL(C)
        Dim L As Single
        If Percent <= 0 Then
            Darken = C
            Exit Function
        End If

        L = HSL.Lum - (HSLMAX * Percent)
        If L < 0 Then L = 0
        HSL.Lum = L
        Darken = HSL.ColorValue
    End Function

    Private Sub MyButton_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged

        SetRegion()

    End Sub

    Private Sub MyButton_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        blnHasFocus = True
    End Sub

    Private Sub MyButton_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        blnHasFocus = False
    End Sub

    Private Sub MyButton_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        blnIsEnabled = sender.enabled
    End Sub

    Const HSLMAX As Integer = 360 '***

    Private Class colorHSL

        'Portions of this class marked with *** are converted from
        'C/C++ routines for RGB/HSL conversion found in the
        'Microsoft Knowledge Base (PD sample code):
        'http://support.microsoft.com/support/kb/articles/Q29/2/40.asp
        'In addition to the language conversion, some internal
        'calculations have been modified and converted to FP math to
        'reduce rounding errors.
        'Conversion to VB and original code by
        'Dan Redding (bwsoft@revealed.net)
        'http://home.revealed.net/bwsoft
        'converted to VB.NET by Dave Andrews

        Const RGBMAX As Integer = 255 '***
        'R, G, and B value can be 0 - RGBMAX
        Const UNDEFINED As Integer = (HSLMAX * 2 / 3) '***
        'Hue is undefined if Saturation = 0 (greyscale)
        Public Hue As Integer
        Public Sat As Integer
        Public Lum As Integer
        Public Property ColorValue() As Color
            Get
                Return GetColor()
            End Get
            Set(ByVal Value As Color)
                Hue = (Value.GetHue / 360) * HSLMAX
                Sat = Value.GetSaturation * HSLMAX
                Lum = Value.GetBrightness * HSLMAX
            End Set
        End Property

        Public Sub New(ByVal C As Color)
            ColorValue = C
        End Sub
        Public Sub New(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer)
            ColorValue = Color.FromArgb(R, G, B)
        End Sub
        Public Sub New()
            ColorValue = Color.Black
        End Sub
        Public Sub FromHSL(ByVal H As Integer, ByVal S As Integer, ByVal L As Integer)
            Dim C As Color
            Hue = H
            Sat = S
            Lum = L
            C = GetColor()
            ColorValue = C
        End Sub
        Private Function HuetoRGB(ByVal M1 As Single, ByVal M2 As Single, ByVal Hue As Single) As Single
            '***
            'Utility function for HSLtoLong
            'Range check
            If Hue < 0 Then
                Hue = Hue + HSLMAX
            ElseIf Hue > HSLMAX Then
                Hue = Hue - HSLMAX
            End If
            'Return r, g, or b value from parameters
            Select Case Hue 'Values get progressively larger.
                'Only the first true condition will execute
            Case Is < (HSLMAX / 6)
                    HuetoRGB = (M1 + (((M2 - M1) * Hue + (HSLMAX / 12)) / (HSLMAX / 6)))
                Case Is < (HSLMAX / 2)
                    HuetoRGB = M2
                Case Is < (HSLMAX * 2 / 3)
                    HuetoRGB = (M1 + (((M2 - M1) * ((HSLMAX * 2 / 3) - Hue) + (HSLMAX / 12)) / (HSLMAX / 6)))
                Case Else
                    HuetoRGB = M1
            End Select
        End Function

        Private Function GetColor() As Color
            Dim R As Single, G As Single, B As Single
            Dim M1 As Single, M2 As Single
            If CInt(Sat) = 0 Then 'Greyscale
                R = (Lum * RGBMAX) / HSLMAX 'luminescence,
                'converted to the proper range
                G = R 'All RGB values same in greyscale
                B = R
                If CInt(Hue) <> UNDEFINED Then
                    'This is technically an error.
                    'The RGBtoHSL routine will always return
                    'Hue = UNDEFINED (160 when HSLMAX is 240)
                    'when Sat = 0.
                    'if you are writing a color mixer and
                    'letting the user input color values,
                    'you may want to set Hue = UNDEFINED
                    'in this case.
                End If
            Else
                'Get the "Magic Numbers"
                If Lum <= HSLMAX / 2 Then
                    M2 = (Lum * (HSLMAX + Sat) + 0.5) / HSLMAX
                Else
                    M2 = Lum + Sat - ((Lum * Sat) + 0.5) / HSLMAX
                End If

                M1 = 2 * Lum - M2

                'get R, G, B; change units from HSLMAX range
                'to RGBMAX range
                R = (HuetoRGB(M1, M2, Hue + (HSLMAX / 3)) * RGBMAX + 0.5) / HSLMAX
                G = (HuetoRGB(M1, M2, Hue) * RGBMAX + 0.5) / HSLMAX
                B = (HuetoRGB(M1, M2, Hue - (HSLMAX / 3)) * RGBMAX + 0.5) / HSLMAX

            End If

            GetColor = Color.FromArgb(CInt(R), CInt(G), CInt(B))

        End Function
    End Class

End Class
