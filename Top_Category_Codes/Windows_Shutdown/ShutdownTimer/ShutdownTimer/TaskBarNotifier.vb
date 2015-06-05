
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Runtime.InteropServices

'##SUMMARY Class which allows to display Messenger style or other Skinned instant messaging popups
'##REMARKS This code was originally written in C# and ported/modified to VB.NET.<br>
'##REMARKS Special Credits to John O'Byrne who write the original TaskBarNotifier Class in C#.
'##REMARKS <br>
'##REMARKS _<b>Date</b>:06/01/03 &nbsp;&nbsp; <b>Rev</b>: 001<br>
'##REMARKS _<i>Initial Version ported from C#.</i><br>
'##REMARKS <i>Small modification where applied to the variable names in order to reflect my personal naming standards</i>
'##REMARKS <i>Modified the way of event notification to work with Delegates and RaiseEvent.</i>
'##REMARKS <i>Modified the Focus rectangle drawing. It now draws a DarkGrey Solid border instead of the Etched
'##REMARKS _style rectangle that was originally used by John O'Byrne</i>
'##REMARKS <br>
'##REMARKS _<b>Date</b>:10/01/03 &nbsp;&nbsp; <b>Rev</b>: 002<br>
'##REMARKS <i>Update: Added KeepVisibleOnMouseOver property.
'##REMARKS <i>Whenever the mouse is over the popup window, it will remain visible.
'##REMARKS _In the previous version, even if the mouse is over the window, it still was hidden when the
'##REMARKS _iVisibleEvents time expired.</i>
'##REMARKS <i>Update: Added ReShowOnMouseOver property</i>
'##REMARKS <i>If you move the mouse back over the popup while it is disappearing, it will now
'##REMARKS _re-appear again. Basically, if the popup is hiding itself, when the mouse moves over it,
'##REMARKS _it is re-shown.</i>
Public Class TaskBarNotifier
    Inherits System.Windows.Forms.Form

    '##SUMMARY Win32 API Call Declaration which will actually show the TaskBarNotifier window.
    <DllImport("User32")> _
    Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Int32) As Boolean
    End Function


    '##SUMMARY Delegate which defines the signature of a CloseButtonClick event handler.
    Public Delegate Sub CloseClickHandler(ByVal sender As Object, ByVal e As EventArgs)

    '##SUMMARY Delegate which defines the signature of a TitleClick event handler.
    Public Delegate Sub TitleClickHandler(ByVal sender As Object, ByVal e As EventArgs)

    '##SUMMARY Delegate which defines the signature of a TextClick event handler.
    Public Delegate Sub TextClickHandler(ByVal sender As Object, ByVal e As EventArgs)

    '##SUMMARY Event which is triggered when the CloseButton region of the TaskbarNotifierWindow is clicked.
    '##REMARKS This event is only triggered if the 'CloseButtonClickEnabled' property is True.
    Public Event CloseButtonClick As CloseClickHandler

    '##SUMMARY Event which is triggered when the Title text region of the TaskbarNotifierWindow is clicked.
    '##REMARKS This event is only triggered if the 'TitleClickEnabled' property is True.
    Public Event TitleClick As TitleClickHandler

    '##SUMMARY Event which is triggered when the inner Text region of the TaskbarNotifierWindow is clicked.
    '##REMARKS This event is only triggered if the 'TextClickEnabled' property is True.
    Public Event TextClick As TextClickHandler

#Region "Protected Members"

    Protected _bmpBackground As Bitmap = Nothing
    Protected _bmpCloseButton As Bitmap = Nothing
    Protected _ptCloseButtonLocation As Point
    Protected _sizCloseButtonSize As Size
    Protected _rectRealTitle As Rectangle
    Protected _rectRealText As Rectangle
    Protected _rectWorkArea As Rectangle
    Protected _tmrAnimation As New Timer
    Protected _eWindowState As TaskbarStates = TaskbarStates.Hidden
    Protected _sTitle As String
    Protected _sText As String
    Protected _colTitleNormal As Color = Color.Red
    Protected _colTitleHover As Color = Color.Red
    Protected _colTextNormal As Color = Color.Black
    Protected _colTextHover As Color = Color.SlateBlue
    Protected _fntTitleNormal As Font = New Font("Tahoma", 13, FontStyle.Bold, GraphicsUnit.Pixel)
    Protected _fntTitleHover As Font = New Font("Tahoma", 13, FontStyle.Regular, GraphicsUnit.Pixel)
    Protected _fntTextNormal As Font = New Font("Tahoma", 13, FontStyle.Regular, GraphicsUnit.Pixel)
    Protected _fntTextHover As Font = New Font("Tahoma", 13, FontStyle.Underline, GraphicsUnit.Pixel)
    Protected _iShowEvents As Integer
    Protected _iHideEvents As Integer
    Protected _iVisibleEvents As Integer
    Protected _iIncrementShow As Integer
    Protected _iIncrementHide As Integer

    ' Rev 002: Added Property Members
    Protected _bKeepVisibleOnMouseOver As Boolean = True
    Protected _bReShowOnMouseOver As Boolean = False

    ' Mouse State Indicators
    Protected _bMouseOverPopup As Boolean = False
    Protected _bMouseOverClose As Boolean = False
    Protected _bMouseOverText As Boolean = False
    Protected _bMouseOverTitle As Boolean = False
    Protected _bMouseDown As Boolean = False

    Protected _bCloseButtonClickEnabled As Boolean = True
    Protected _bTitleClickEnabled As Boolean = False
    Protected _bTextClickEnabled As Boolean = True

    Protected _rectTitle As Rectangle
    Protected _rectText As Rectangle
    Protected _bDrawFocusRect As Boolean = True
    Protected _eFocusRectStyle As ButtonBorderStyle = ButtonBorderStyle.Solid
    Protected _colFocusRect As Color = Color.DarkGray

#End Region

#Region "Enums"

    '##SUMMARY List of the different popup animation status
    Public Enum TaskbarStates
        '##MEMBER Indicates the the TaskbarNotifierWindow is hidden.
        Hidden = 0
        '##MEMBER Indicates the the TaskbarNotifierWindow in proces of being shown (appearing).
        Appearing = 1
        '##MEMBER Indicates the the TaskbarNotifierWindow is visible.
        Visible = 2
        '##MEMBER Indicates the the TaskbarNotifierWindow in proces of being hidden (disappearing).
        Disappearing = 3
    End Enum

#End Region

#Region "Constructor"

    Public Sub New()

        ' Window Style
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Minimized
        MyBase.Show()
        MyBase.Hide()
        WindowState = FormWindowState.Normal
        ShowInTaskbar = False
        TopMost = True
        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
        Me.SetStyle(ControlStyles.CacheText, True)

        _tmrAnimation.Enabled = True
        AddHandler _tmrAnimation.Tick, AddressOf OnTimer

    End Sub

#End Region

#Region "Public Properties"

    '##SUMMARY Get the current TaskbarState (hidden, showing, visible, hiding)
    Public ReadOnly Property TaskBarState() As TaskbarStates
        Get
            Return Me._eWindowState
        End Get
    End Property

    '##SUMMARY Get/Set the popup Title Text
    Public Property TitleText() As String
        Get
            Return Me._sTitle
        End Get
        Set(ByVal Value As String)
            Me._sTitle = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the popup Content Text
    Public Property ContentText() As String
        Get
            Return Me._sText
        End Get
        Set(ByVal Value As String)
            Me._sText = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Normal Title Color
    Public Property NormalTitleColor() As Color
        Get
            Return Me._colTitleNormal
        End Get
        Set(ByVal Value As Color)
            Me._colTitleNormal = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Hover Title Color
    Public Property HoverTitleColor() As Color
        Get
            Return Me._colTitleHover
        End Get
        Set(ByVal Value As Color)
            Me._colTitleHover = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Normal Content Color
    Public Property NormalContentColor() As Color
        Get
            Return Me._colTextNormal
        End Get
        Set(ByVal Value As Color)
            Me._colTextNormal = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Hover Content Color
    Public Property HoverContentColor() As Color
        Get
            Return Me._colTextHover
        End Get
        Set(ByVal Value As Color)
            Me._colTextHover = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Normal Title Font
    Public Property NormalTitleFont() As Font
        Get
            Return Me._fntTitleNormal
        End Get
        Set(ByVal Value As Font)
            Me._fntTitleNormal = Value
            Refresh()
        End Set
    End Property


    '##SUMMARY Get/Set the Hover Title Font
    Public Property HoverTitleFont() As Font
        Get
            Return Me._fntTitleHover
        End Get
        Set(ByVal Value As Font)
            Me._fntTitleHover = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Normal Content Font
    Public Property NormalContentFont() As Font
        Get
            Return Me._fntTextNormal
        End Get
        Set(ByVal Value As Font)
            Me._fntTextNormal = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Get/Set the Hover Content Font
    Public Property HoverContentFont() As Font
        Get
            Return Me._fntTextHover
        End Get
        Set(ByVal Value As Font)
            Me._fntTextHover = Value
            Refresh()
        End Set
    End Property

    '##SUMMARY Activates/Deactivates the CloseButtonClick event raising.
    < _
      DefaultValue(True) _
    > _
    Public Property CloseButtonClickEnabled() As Boolean
        Get
            Return Me._bCloseButtonClickEnabled
        End Get
        Set(ByVal Value As Boolean)
            Me._bCloseButtonClickEnabled = Value
        End Set
    End Property

    '##SUMMARY Activates/Deactivates the TitleClick event raising
    < _
      DefaultValue(False) _
    > _
    Public Property TitleClickEnabled() As Boolean
        Get
            Return Me._bTitleClickEnabled
        End Get
        Set(ByVal Value As Boolean)
            Me._bTitleClickEnabled = Value
        End Set
    End Property

    '##SUMMARY Activates/Deactivates the TextClick event raising
    < _
      DefaultValue(True) _
    > _
    Public Property TextClickEnabled() As Boolean
        Get
            Return Me._bTextClickEnabled
        End Get
        Set(ByVal Value As Boolean)
            Me._bTextClickEnabled = Value
        End Set
    End Property

    '##SUMMARY Returns or sets the Rectangle reserved for the Title of the window.
    Public Property TitleRectangle() As Rectangle
        Get
            Return Me._rectTitle
        End Get
        Set(ByVal Value As Rectangle)
            Me._rectTitle = Value
        End Set
    End Property

    '##SUMMARY Returns or sets the Rectangle reserved for the Text content of the window.
    Public Property TextRectangle() As Rectangle
        Get
            Return Me._rectText
        End Get
        Set(ByVal Value As Rectangle)
            Me._rectText = Value
        End Set
    End Property

    '##SUMMARY Indicates if the focus rectangle should be draws when the mouse moves over the Title or Text
    < _
      DefaultValue(True) _
    > _
    Public Property DrawTextFocusRect() As Boolean
        Get
            Return Me._bDrawFocusRect
        End Get
        Set(ByVal Value As Boolean)
            Me._bDrawFocusRect = Value
        End Set
    End Property

    '##SUMMARY Returns or sets the Style of the TextFocusRect
    < _
      DefaultValue(System.Windows.Forms.ButtonBorderStyle.Dotted) _
    > _
    Public Property TextFocusRectStyle() As ButtonBorderStyle
        Get
            Return Me._eFocusRectStyle
        End Get
        Set(ByVal Value As ButtonBorderStyle)
            Me._eFocusRectStyle = Value
        End Set
    End Property

    '##SUMMARY Returns or sets the Color of the TextFocusRect
    Public Property TextFocusRectColor() As Color
        Get
            Return Me._colFocusRect
        End Get
        Set(ByVal Value As Color)
            Me._colFocusRect = Value
        End Set
    End Property

    '##SUMMARY Indicates if the TaskBarNotifier window remains statically 
    '##SUMMARY _visible while the mouse pointer is over it. (Rev 002)
    < _
      DefaultValue(True) _
    > _
    Public Property KeepVisibleOnMouseOver() As Boolean
        Get
            Return Me._bKeepVisibleOnMouseOver
        End Get
        Set(ByVal Value As Boolean)
            Me._bKeepVisibleOnMouseOver = Value
        End Set
    End Property

    '##SUMMARY Indicates that the TaskBarNotifier window should be re-appearing if the mouse pointer
    '##SUMMARY _moves over it while it is in the proces of hiding itself. (Rev 002)
    < _
      DefaultValue(False) _
    > _
    Public Property ReShowOnMouseOver() As Boolean
        Get
            Return Me._bReShowOnMouseOver
        End Get
        Set(ByVal Value As Boolean)
            Me._bReShowOnMouseOver = Value
        End Set
    End Property

#End Region

#Region "Public Methods"
    '##SUMMARY Displays the popup for a certain amount of time
    '##PARAM strTitle The string which will be shown as the title of the popup.
    '##PARAM strContent The string which will be shown as the content of the popup.
    '##PARAM nTimeToShow Duration of the showing animation (in milliseconds).
    '##PARAM nTimeToStay Duration of the visible state before collapsing (in milliseconds).
    '##PARAM nTimeToHide Duration of the hiding animation (in milliseconds).
    Public Shadows Sub Show(ByVal strTitle As String, ByVal strContent As String, _
                            ByVal nTimeToShow As Integer, _
                            ByVal nTimeToStay As Integer, _
                            ByVal nTimeToHide As Integer)

        Me._rectWorkArea = Screen.GetWorkingArea(Me._rectWorkArea)
        Me._sTitle = strTitle
        Me._sText = strContent
        Me._iVisibleEvents = nTimeToStay

        CalculateMouseRectangles()

        ' We calculate the pixel increment and the timer value for the showing animation
        Dim nEvents As Integer

        If nTimeToShow > 10 Then
            nEvents = CType(Math.Min((nTimeToShow / 10), Me._bmpBackground.Height), Integer)
            Me._iShowEvents = CType(nTimeToShow / nEvents, Integer)
            Me._iIncrementShow = CType(Me._bmpBackground.Height / nEvents, Integer)
        Else
            Me._iShowEvents = 10
            Me._iIncrementShow = Me._bmpBackground.Height
        End If

        ' We calculate the pixel increment and the timer value for the hiding animation
        If nTimeToHide > 10 Then
            nEvents = CType(Math.Min((nTimeToHide / 10), Me._bmpBackground.Height), Integer)
            Me._iHideEvents = CType(nTimeToHide / nEvents, Integer)
            Me._iIncrementHide = CType(Me._bmpBackground.Height / nEvents, Integer)
        Else
            Me._iHideEvents = 10
            Me._iIncrementHide = Me._bmpBackground.Height
        End If

        Select Case Me._eWindowState

            Case TaskbarStates.Hidden

                Me._eWindowState = TaskbarStates.Appearing
                SetBounds(Me._rectWorkArea.Right - Me._bmpBackground.Width - 17, _
                          Me._rectWorkArea.Bottom - 1, _
                          Me._bmpBackground.Width, 0)
                Me._tmrAnimation.Interval = Me._iShowEvents
                Me._tmrAnimation.Start()

                'We Show the popup without stealing focus
                ShowWindow(Me.Handle, 4)

            Case TaskbarStates.Appearing

                Refresh()

            Case TaskbarStates.Visible

                Me._tmrAnimation.Stop()
                Me._tmrAnimation.Interval = Me._iVisibleEvents
                Me._tmrAnimation.Start()
                Refresh()

            Case TaskbarStates.Disappearing

                Me._tmrAnimation.Stop()
                Me._eWindowState = TaskbarStates.Visible
                SetBounds(Me._rectWorkArea.Right - Me._bmpBackground.Width - 17, _
                          Me._rectWorkArea.Bottom - Me._bmpBackground.Height - 1, _
                          Me._bmpBackground.Width, Me._bmpBackground.Height)
                Me._tmrAnimation.Interval = Me._iVisibleEvents
                Me._tmrAnimation.Start()
                Refresh()

        End Select

    End Sub

    '##SUMMARY Hides the popup
    Public Shadows Sub Hide()

        If Me._eWindowState <> TaskbarStates.Hidden Then
            Me._tmrAnimation.Stop()
            Me._eWindowState = TaskbarStates.Hidden
            MyBase.Hide()
        End If

    End Sub

    '##SUMMARY Sets the background bitmap and its transparency color.
    '##PARAM strFilename Path of the Background Bitmap on the disk.
    '##PARAM transparencyColor Color of the Bitmap which won't be visible.
    Public Sub SetBackgroundBitmap(ByVal strFilename As String, ByVal transparencyColor As Color)

        Me._bmpBackground = New Bitmap(strFilename)
        Width = Me._bmpBackground.Width
        Height = Me._bmpBackground.Height
        Region = BitmapToRegion(Me._bmpBackground, transparencyColor)

    End Sub

    '##SUMMARY Sets the background bitmap and its transparency color.
    '##PARAM image Image/Bitmap object which represents the Background Bitmap.
    '##PARAM transparencyColor Color of the Bitmap which won't be visible.
    Public Sub SetBackgroundBitmap(ByVal image As Image, ByVal transparencyColor As Color)

        Me._bmpBackground = New Bitmap(image)
        Width = Me._bmpBackground.Width
        Height = Me._bmpBackground.Height
        Region = BitmapToRegion(Me._bmpBackground, transparencyColor)

    End Sub

    '##SUMMARY Sets the 3-State Close Button bitmap, its transparency color and its coordinates.
    '##PARAM strFilename Path of the 3-state Close button Bitmap on the disk (width must a multiple of 3).
    '##PARAM transparencyColor Color of the Bitmap which won't be visible.
    '##PARAM position Location of the close button on the popup.
    Public Sub SetCloseBitmap(ByVal strFilename As String, ByVal transparencyColor As Color, ByVal position As Point)

        Me._bmpCloseButton = New Bitmap(strFilename)
        Me._bmpCloseButton.MakeTransparent(transparencyColor)
        Me._sizCloseButtonSize = New Size(CType(Me._bmpCloseButton.Width / 3, Integer), Me._bmpCloseButton.Height)
        Me._ptCloseButtonLocation = position

    End Sub

    '##SUMMARY Sets the 3-State Close Button bitmap, its transparency color and its coordinates.
    '##PARAM image Image/Bitmap object which represents the 3-state Close button Bitmap (width must be a multiple of 3).
    '##PARAM transparencyColor Color of the Bitmap which won't be visible.
    '##PARAM position Location of the close button on the popup.
    Public Sub SetCloseBitmap(ByVal image As Image, ByVal transparencyColor As Color, ByVal position As Point)

        Me._bmpCloseButton = New Bitmap(image)
        Me._bmpCloseButton.MakeTransparent(transparencyColor)
        Me._sizCloseButtonSize = New Size(CType(Me._bmpCloseButton.Width / 3, Integer), Me._bmpCloseButton.Height)
        Me._ptCloseButtonLocation = position

    End Sub

#End Region

#Region "Protected Methods"

    '##SUMMARY Draws the CloseButton based on the inner state.
    Protected Sub DrawCloseButton(ByVal grfx As Graphics)

        If Me._bmpCloseButton Is Nothing Then Exit Sub

        Dim rectDest As Rectangle = New Rectangle(Me._ptCloseButtonLocation, Me._sizCloseButtonSize)
        Dim rectSrc As Rectangle

        If Me._bMouseOverClose Then

            If Me._bMouseDown Then
                rectSrc = New Rectangle(New Point(Me._sizCloseButtonSize.Width * 2, 0), Me._sizCloseButtonSize)
            Else
                rectSrc = New Rectangle(New Point(Me._sizCloseButtonSize.Width, 0), Me._sizCloseButtonSize)
            End If
        Else
            rectSrc = New Rectangle(New Point(0, 0), Me._sizCloseButtonSize)
        End If

        grfx.DrawImage(Me._bmpCloseButton, rectDest, rectSrc, GraphicsUnit.Pixel)

    End Sub

    '##SUMMARY Draws the Title and Text content of the TaskNotifier popup window.
    Protected Sub DrawText(ByVal grfx As Graphics)

        'Draw the Title Text
        If (Not Me._sTitle Is Nothing) AndAlso (Me._sTitle.Length > 0) Then

            Dim sf As New StringFormat
            sf.Alignment = StringAlignment.Near
            sf.LineAlignment = StringAlignment.Center
            sf.FormatFlags = StringFormatFlags.NoWrap
            sf.Trimming = StringTrimming.EllipsisCharacter


            If Me._bMouseOverTitle Then
                grfx.DrawString(Me._sTitle, Me._fntTitleHover, New SolidBrush(Me._colTitleHover), _
                                  RectangleF.op_Implicit(Me._rectTitle), sf)
            Else
                grfx.DrawString(Me._sTitle, Me._fntTitleNormal, New SolidBrush(Me._colTitleNormal), _
                                RectangleF.op_Implicit(Me._rectTitle), sf)
            End If
        End If

        'Draw the content Text
        If (Not Me._sText Is Nothing) AndAlso (Me._sText.Length > 0) Then

            Dim sf As New StringFormat
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            sf.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
            sf.Trimming = StringTrimming.EllipsisWord

            If Me._bMouseOverText Then
                grfx.DrawString(Me._sText, Me._fntTextHover, New SolidBrush(Me._colTextHover), _
                                RectangleF.op_Implicit(Me._rectText), sf)
                If Me._bDrawFocusRect Then
                    Me.DrawFocusRectangle(grfx)
                End If
            Else
                grfx.DrawString(Me._sText, Me._fntTextNormal, New SolidBrush(Me._colTextNormal), _
                                RectangleF.op_Implicit(Me._rectText), sf)
            End If
        End If

    End Sub

    Protected Sub DrawFocusRectangle(ByVal grfx As Graphics)

        If Me._bDrawFocusRect Then

            Dim iBorderWidth As Integer = 1

            ControlPaint.DrawBorder(grfx, Me._rectRealText, _
                                    Me._colFocusRect, iBorderWidth, Me._eFocusRectStyle, _
                                    Me._colFocusRect, iBorderWidth, Me._eFocusRectStyle, _
                                    Me._colFocusRect, iBorderWidth, Me._eFocusRectStyle, _
                                    Me._colFocusRect, iBorderWidth, Me._eFocusRectStyle)

            ' This was the Original Code
            'ControlPaint.DrawBorder3D(grfx, Me._rectRealText, Border3DStyle.Flat, _
            '                          Border3DSide.Top Or Border3DSide.Bottom Or _
            '                          Border3DSide.Left Or Border3DSide.Right)

        End If

    End Sub

    Protected Sub CalculateMouseRectangles()

        Dim grfx As Graphics = CreateGraphics()
        Dim sf As New StringFormat

        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        sf.FormatFlags = StringFormatFlags.MeasureTrailingSpaces

        Dim sizfTitle As SizeF = _
            grfx.MeasureString(Me._sTitle, Me._fntTitleHover, Me._rectTitle.Width, sf)
        Dim sizfText As SizeF = _
            grfx.MeasureString(Me._sText, Me._fntTextHover, Me._rectText.Width, sf)

        grfx.Dispose()

        'We should check if the title size really fits inside the pre-defined title rectangle
        If sizfTitle.Height > Me._rectTitle.Height Then
            Me._rectRealTitle = _
                New Rectangle(Me._rectTitle.Left, _
                              Me._rectTitle.Top, _
                              Me._rectTitle.Width, _
                              Me._rectTitle.Height)
        Else
            Me._rectRealTitle = _
                New Rectangle(Me._rectTitle.Left, _
                              Me._rectTitle.Top, _
                              CType(sizfTitle.Width, Integer), _
                              CType(sizfTitle.Height, Integer))
        End If

        Me._rectRealTitle.Inflate(0, 2)

        'We should check if the text size really fits inside the pre-defined text rectangle
        If sizfText.Height > Me._rectText.Height Then
            Me._rectRealText = _
                New Rectangle(CType((_rectText.Width - sizfText.Width) / 2 + _rectText.Left, Integer), _
                              Me._rectText.Top, _
                              CType(sizfText.Width, Integer), _
                              Me._rectText.Height)
        Else
            Me._rectRealText = _
                New Rectangle(CType((_rectText.Width - sizfText.Width) / 2 + _rectText.Left, Integer), _
                              CType((_rectText.Height - sizfText.Height) / 2 + _rectText.Top, Integer), _
                              CType(sizfText.Width, Integer), _
                              CType(sizfText.Height, Integer))
        End If

        Me._rectRealText.Inflate(0, 2)

    End Sub

    Protected Function BitmapToRegion(ByVal bitmap As Bitmap, ByVal transparencyColor As Color) As Region

        If bitmap Is Nothing Then
            Throw New ArgumentNullException("Bitmap", "Bitmap cannot be Nothing!")
        End If

        Dim height As Integer = bitmap.Height
        Dim width As Integer = bitmap.Width

        Dim path As New GraphicsPath

        Dim i As Integer
        Dim j As Integer

        For j = 0 To (height - 1)
            For i = 0 To (width - 1)
                If Not bitmap.GetPixel(i, j).Equals(transparencyColor) Then

                    Dim x0 As Integer = i

                    Do While ((i < width) AndAlso (Not bitmap.GetPixel(i, j).Equals(transparencyColor)))
                        i += 1
                    Loop

                    path.AddRectangle(New Rectangle(x0, j, i - x0, 1))

                End If
            Next
        Next

        Dim region As New Region(path)
        path.Dispose()

        Return region

    End Function

#End Region

#Region "OnTimer Event Handler"

    Protected Sub OnTimer(ByVal sender As Object, ByVal e As EventArgs)

        Select Case Me._eWindowState

            Case TaskbarStates.Appearing

                If Height < Me._bmpBackground.Height Then
                    SetBounds(Left, Top - Me._iIncrementShow, Width, Height + Me._iIncrementShow)
                Else
                    Me._tmrAnimation.Stop()
                    Height = Me._bmpBackground.Height
                    Me._tmrAnimation.Interval = Me._iVisibleEvents
                    Me._eWindowState = TaskbarStates.Visible
                    Me._tmrAnimation.Start()
                End If

            Case TaskbarStates.Visible

                Me._tmrAnimation.Stop()
                Me._tmrAnimation.Interval = Me._iHideEvents
                ' Rev 002
                If ((Me._bKeepVisibleOnMouseOver) AndAlso (Not Me._bMouseOverPopup)) OrElse _
                   (Not Me._bKeepVisibleOnMouseOver) Then
                    Me._eWindowState = TaskbarStates.Disappearing
                End If
                Me._tmrAnimation.Start()

            Case TaskbarStates.Disappearing

                ' Rev 002
                If (Me._bReShowOnMouseOver) AndAlso (Me._bMouseOverPopup) Then
                    Me._eWindowState = TaskbarStates.Appearing
                Else
                    If Top < Me._rectWorkArea.Bottom Then
                        SetBounds(Left, Top + Me._iIncrementHide, Width, Height - Me._iIncrementHide)
                    Else
                        Hide()
                    End If
                End If

        End Select

    End Sub

#End Region

#Region "Overriden Base Class Methods"

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        Me._bMouseOverPopup = True
        Refresh()
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me._bMouseOverPopup = False
        Me._bMouseOverClose = False
        Me._bMouseOverTitle = False
        Me._bMouseOverText = False
        Refresh()
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        Dim bContentModified As Boolean = False

        If ((e.X > Me._ptCloseButtonLocation.X) AndAlso _
            (e.X < (Me._ptCloseButtonLocation.X + Me._sizCloseButtonSize.Width)) AndAlso _
            (e.Y > Me._ptCloseButtonLocation.Y) AndAlso _
            (e.Y < (Me._ptCloseButtonLocation.Y + Me._sizCloseButtonSize.Height)) AndAlso _
            Me._bCloseButtonClickEnabled) Then

            If Not Me._bMouseOverClose Then

                Me._bMouseOverClose = True
                Me._bMouseOverTitle = False
                Me._bMouseOverText = False
                Cursor = Cursors.Hand
                bContentModified = True

            End If

        Else
            If Me._rectRealText.Contains(New Point(e.X, e.Y)) AndAlso Me._bTextClickEnabled Then

                If Not Me._bMouseOverText Then

                    Me._bMouseOverClose = False
                    Me._bMouseOverTitle = False
                    Me._bMouseOverText = True
                    Cursor = Cursors.Hand
                    bContentModified = True

                End If

            Else
                If Me._rectRealTitle.Contains(New Point(e.X, e.Y)) AndAlso Me._bTitleClickEnabled Then

                    If Not Me._bMouseOverTitle Then

                        Me._bMouseOverClose = False
                        Me._bMouseOverTitle = True
                        Me._bMouseOverText = False
                        Cursor = Cursors.Hand
                        bContentModified = True

                    End If

                Else

                    If Me._bMouseOverClose OrElse Me._bMouseOverTitle OrElse Me._bMouseOverText Then _
                        bContentModified = True

                    Me._bMouseOverClose = False
                    Me._bMouseOverTitle = False
                    Me._bMouseOverText = False
                    Cursor = Cursors.Default

                End If
            End If

        End If

        If bContentModified Then Refresh()

    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)

        MyBase.OnMouseDown(e)
        Me._bMouseDown = True
        If Me._bMouseOverClose Then Refresh()

    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)

        MyBase.OnMouseUp(e)
        Me._bMouseDown = False

        If Me._bMouseOverClose Then
            Hide()

            If Me._bCloseButtonClickEnabled Then _
                RaiseEvent CloseButtonClick(Me, New EventArgs)

        Else

            If Me._bMouseOverTitle Then

                If Me._bTitleClickEnabled Then _
                    RaiseEvent TitleClick(Me, New EventArgs)

            Else

                If Me._bMouseOverText Then

                    If Me._bTextClickEnabled Then _
                        RaiseEvent TextClick(Me, New EventArgs)

                End If

            End If

        End If

    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)

        Dim grfx As Graphics = e.Graphics
        grfx.PageUnit = GraphicsUnit.Pixel

        Dim offScreenGraphics As Graphics
        Dim offScreenBitmap As Bitmap

        offScreenBitmap = New Bitmap(Me._bmpBackground.Width, Me._bmpBackground.Height)
        offScreenGraphics = Graphics.FromImage(offScreenBitmap)

        If Not Me._bmpBackground Is Nothing Then

            offScreenGraphics.DrawImage(Me._bmpBackground, 0, 0, _
                                        Me._bmpBackground.Width, _
                                        Me._bmpBackground.Height)

        End If

        DrawCloseButton(offScreenGraphics)
        DrawText(offScreenGraphics)

        grfx.DrawImage(offScreenBitmap, 0, 0)

    End Sub

#End Region


End Class

