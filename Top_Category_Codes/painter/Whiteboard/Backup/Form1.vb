'Author: Nicholas Afxentiou

Imports System.Drawing.Drawing2D
Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents PaletteBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PaletteBox = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PaletteBox
        '
        Me.PaletteBox.BackColor = System.Drawing.Color.White
        Me.PaletteBox.Location = New System.Drawing.Point(2, 304)
        Me.PaletteBox.Name = "PaletteBox"
        Me.PaletteBox.Size = New System.Drawing.Size(238, 22)
        Me.PaletteBox.TabIndex = 0
        Me.PaletteBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ellipse"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(0, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Line"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(0, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Brush"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(0, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Rectangle"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(0, 96)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Path"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(0, 152)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Eraser"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(0, 120)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Text"
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(320, 304)
        Me.TrackBar1.Maximum = 20
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(64, 42)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(384, 304)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(24, 20)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Brush:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(64, 120)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Style"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Location = New System.Drawing.Point(16, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 24)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(16, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 24)
        Me.Panel2.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(16, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 24)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(432, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 325)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PaletteBox)
        Me.Controls.Add(Me.TrackBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "WhiteBoard"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ColorMap As Bitmap

#Region "enumerations"
    Public Enum dModes
        Line
        Rectangle
        Ellipse
        Brush
        Path
        Text
        Eraser
    End Enum

    Public Enum dStyles
        Outline
        OutlineFilled
        Filled
    End Enum
#End Region

#Region "declarations"
    Dim bmp As Bitmap
    Dim bmp2 As Bitmap
    Dim g2 As Graphics
    Dim clr As Color = Color.Red
    Dim clr2 As Color = Color.blue
    Private StartX, StartY, EndX, EndY, BoxWidth, BoxHeight As Integer
    Dim mpath As New Drawing2D.GraphicsPath
    Dim dmode As dModes
    Dim xLoc, yLoc As Integer
    Dim dstyle As dStyles = dStyles.Outline
    Dim pWidth As Int16 = 1
    Dim c As New Cursor(GetEmbeddedFile("Whiteboard.ColorPicker.ico"))
    Dim er As New Cursor(GetEmbeddedFile("Whiteboard.Eraser.ico"))
    Dim isDraw As Boolean
    Dim pF, pFOld As PointF
    Dim nPen As New Pen(clr)
    Declare Function HideCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Dim allow As Boolean
    Declare Function ShowCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function CreateCaret Lib "user32.dll" (ByVal hwnd As Int32, ByVal hBitmap As Int32, ByVal nWidth As Int32, ByVal nHeight As Int32) As Int32
    Declare Function SetCaretPos Lib "user32.dll" (ByVal x As Int32, ByVal y As Int32) As Int32
    WithEvents pbox As New pBoxControl
    Dim txt As String
#End Region

#Region "properties"
    Public ReadOnly Property Color() As Color
        Get
            Return clr
        End Get
    End Property

    Property penWidth() As Int16
        Get
            Return pWidth
        End Get
        Set(ByVal Value As Int16)
            pWidth = Value
            nPen.Width = pWidth
        End Set
    End Property

    Property DrawStyles() As dStyles
        Get
            Return dstyle
        End Get
        Set(ByVal Value As dStyles)
            dstyle = Value
        End Set
    End Property

#End Region

    'creates the color palette
    Sub CreatePalette()
        bmp = New Bitmap(PaletteBox.Width, PaletteBox.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim rect1 As New Rectangle(0, 0, PaletteBox.Width, PaletteBox.Height)
        Dim lbrush As New LinearGradientBrush(rect1, Color.FromArgb(255, 255, 255, 255), Color.FromArgb(255, 0, 0, 0), LinearGradientMode.Vertical)
        g.FillRectangle(lbrush, rect1)


        Dim rect As New Rectangle(0, 1, 20, 20)
        g.CompositingMode = CompositingMode.SourceOver
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 0, 0, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 255, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 255, 0, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)


        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 255, 255, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 255, 255, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 0, 255, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 0, 255, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 0, 255, 255), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 0, 255, 255), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 0, 0, 255), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 0, 0, 255), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 255, 0, 255), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 255, 0, 255), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 255, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        rect.Offset(20, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(255, 255, 0, 0), Color.FromArgb(0, 0, 0, 0), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)

        rect.Offset(10, 0)
        lbrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(255, 255, 255, 255), LinearGradientMode.Horizontal)
        g.FillRectangle(lbrush, rect)
        PaletteBox.Image = bmp
    End Sub

#Region "Drawing Routines"
    Sub DrawPath(ByVal e) 'path
        EndX = e.x
        EndY = e.y

        pbox.Refresh()
        pbox.CreateGraphics.DrawLine(nPen, StartX, StartY, EndX, EndY)
    End Sub

    Sub DrawBrush(ByVal e) 'brush
        mpath.AddLine(e.X, e.Y, e.X, e.Y)
        pbox.CreateGraphics.DrawPath(nPen, mpath)
    End Sub

    Sub DrawLine(ByVal e) 'line
        EndX = e.x
        EndY = e.y
        pbox.Refresh()
        pbox.CreateGraphics.DrawLine(nPen, StartX, StartY, EndX, EndY)
    End Sub

    Sub DrawRectangle(ByVal e As System.Windows.Forms.MouseEventArgs) 'rectangle
        xLoc = 0
        yLoc = 0

        If e.X > StartX Then
            BoxWidth = e.X - StartX
            xLoc = StartX
        Else
            BoxWidth = StartX - e.X
            xLoc = e.X
        End If

        If e.Y > StartY Then
            BoxHeight = e.Y - StartY
            yLoc = StartY
        Else
            BoxHeight = StartY - e.Y
            yLoc = e.Y
        End If

        pbox.Refresh()
        Select Case DrawStyles
            Case dStyles.Filled
                pbox.CreateGraphics.FillRectangle(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
            Case dStyles.Outline
                pbox.CreateGraphics.DrawRectangle(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
            Case dStyles.OutlineFilled
                pbox.CreateGraphics.FillRectangle(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                pbox.CreateGraphics.DrawRectangle(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
        End Select

    End Sub

    Sub DrawEllipse(ByVal e As System.Windows.Forms.MouseEventArgs) 'ellipse
        xLoc = 0
        yLoc = 0

        If e.X > StartX Then
            BoxWidth = e.X - StartX
            xLoc = StartX
        Else
            BoxWidth = StartX - e.X
            xLoc = e.X
        End If

        If e.Y > StartY Then
            BoxHeight = e.Y - StartY
            yLoc = StartY
        Else
            BoxHeight = StartY - e.Y
            yLoc = e.Y
        End If

        pbox.Refresh()
        Select Case DrawStyles
            Case dStyles.Filled
                pbox.CreateGraphics.FillEllipse(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
            Case dStyles.Outline
                pbox.CreateGraphics.DrawEllipse(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
            Case dStyles.OutlineFilled
                pbox.CreateGraphics.FillEllipse(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                pbox.CreateGraphics.DrawEllipse(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
        End Select

    End Sub

    Sub Eraser(ByVal e As System.Windows.Forms.MouseEventArgs) 'eraser
        pbox.Refresh()
        pbox.CreateGraphics.FillRectangle(Brushes.White, e.X - 1, e.Y, penWidth, penWidth)
        pbox.CreateGraphics.DrawRectangle(Pens.Black, e.X - 1, e.Y, penWidth, penWidth)
    End Sub
#End Region

#Region "Events"

    'picks forecolor and backcolor
    Private Sub PaletteBox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PaletteBox.MouseUp
        On Error Resume Next
        'on left click sets forecolor, on right click sets backcolor
        If e.Button = MouseButtons.Left Then
            clr = Color.FromArgb(bmp.GetPixel(e.X, e.Y).ToArgb)
        Else
            clr2 = Color.FromArgb(bmp.GetPixel(e.X, e.Y).ToArgb)
        End If
        Dim rc As New Rectangle(PaletteBox.Left + PaletteBox.Width + 3, PaletteBox.Top + 3, 40, 16)
        Me.Invalidate(rc)
        nPen = New Pen(clr)
        nPen.Width = penWidth
        If dModes.Text Then
            pbox.Refresh()
            pbox.CreateGraphics.DrawString(txt, Me.Font, New SolidBrush(clr), pF.X, pF.Y)

        End If
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.FillRectangle(Brushes.White, PaletteBox.Left - 2, PaletteBox.Top - 1, PaletteBox.Width + 45, PaletteBox.Height + 2)
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(153, 204, 255)), PaletteBox.Left - 2, PaletteBox.Top - 1, PaletteBox.Width + 46, PaletteBox.Height + 2)

        e.Graphics.FillRectangle(New SolidBrush(clr), PaletteBox.Left + PaletteBox.Width + 4, PaletteBox.Top + 4, 15, 15)
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(153, 204, 255)), PaletteBox.Left + PaletteBox.Width + 2, PaletteBox.Top + 2, 18, 18)
        e.Graphics.FillRectangle(New SolidBrush(clr2), PaletteBox.Left + PaletteBox.Width + 25, PaletteBox.Top + 4, 15, 15)
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(153, 204, 255)), PaletteBox.Left + PaletteBox.Width + 23, PaletteBox.Top + 2, 18, 18)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreatePalette()

        'set the picturebox
        pbox.Font = New Font("Arial", 13)
        pbox.Left = 64
        pbox.Top = 0
        pbox.Width = 432
        pbox.Height = 303
        pbox.BackColor = Color.White
        Controls.Add(pbox)
        bmp2 = New Bitmap(pbox.Width, pbox.Height)
        g2 = Graphics.FromImage(bmp2)
        g2.SmoothingMode = SmoothingMode.AntiAlias
    End Sub

    'Starts the virtual drawing
    Private Sub pbox_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbox.MouseDown
        If e.Button = MouseButtons.Left Then
            isDraw = True
            StartX = e.X
            StartY = e.Y

            If dmode = dModes.Text Then 'if text mode is selected it creates a caret on the clicked position 

                pF = New PointF(e.X, e.Y - fontheight / 2)
                If pF.Equals(pFOld) Then
                Else
                    allow = True
                End If
                pbox.Focus()

                CreateCaret(pbox.Handle.ToInt32, 0, 2, Me.FontHeight)
                SetCaretPos(pF.X, pF.Y)
                ShowCaret(pbox.Handle.ToInt32)
            End If

        End If
    End Sub

    'Virtual Drawing
    Private Sub pbox_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbox.MouseMove
        Label2.Text = e.X & ":" & e.Y
        If isDraw Then
            Select Case dmode
                Case dModes.Ellipse
                    DrawEllipse(e)
                Case dModes.Line
                    DrawLine(e)
                Case dModes.Brush
                    DrawBrush(e)
                Case dModes.Rectangle
                    DrawRectangle(e)
                Case dModes.Path
                    DrawPath(e)
                Case dModes.Eraser
                    Eraser(e)
                    g2.FillRectangle(Brushes.White, e.X, e.Y, pWidth, pWidth)
            End Select
        End If
    End Sub

    'Here is where the actual drawing happens
    Private Sub pbox_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbox.MouseUp
        isDraw = False

        Select Case dmode
            Case dModes.Ellipse
                Select Case DrawStyles
                    Case dStyles.Filled
                        g2.FillEllipse(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                    Case dStyles.Outline
                        g2.DrawEllipse(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
                    Case dStyles.OutlineFilled
                        g2.FillEllipse(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                        g2.DrawEllipse(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
                End Select
            Case dModes.Line
                g2.DrawLine(nPen, StartX, StartY, EndX, EndY)
            Case dModes.Brush
                g2.DrawPath(nPen, mpath)
                mpath.Reset()
            Case dModes.Rectangle
                Select Case DrawStyles
                    Case dStyles.Filled
                        g2.FillRectangle(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                    Case dStyles.Outline
                        g2.DrawRectangle(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
                    Case dStyles.OutlineFilled
                        g2.FillRectangle(New SolidBrush(clr2), xLoc, yLoc, BoxWidth, BoxHeight)
                        g2.DrawRectangle(nPen, xLoc, yLoc, BoxWidth, BoxHeight)
                End Select
            Case dModes.Path
                mpath.AddLine(StartX, StartY, e.X, e.Y)
                g2.DrawPath(nPen, mpath)
                'mpath.Reset()
            Case dModes.Text
                If allow Then g2.DrawString(txt, Me.Font, New SolidBrush(clr), pFOld)
                allow = False
                txt = ""
                'tbox.Clear()
        End Select

        pbox.Image = bmp2
    End Sub

    'if in text mode, writes text on the bitmap and moves the caret
    Private Sub pbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pbox.KeyPress
        txt += e.KeyChar
        Me.Refresh()
        On Error Resume Next
        If e.KeyChar = Chr(8) Then 'backspace
            txt = txt.Substring(0, txt.Length - 2)
            e.Handled = True
        End If
        g2.PageUnit = GraphicsUnit.Pixel
        SetCaretPos(pF.X + g2.MeasureString(txt, New Font("arial", 8)).Width, pF.Y)
        pbox.CreateGraphics.DrawString(txt, Me.Font, New SolidBrush(clr), pF.X, pF.Y)
        pFOld = pF
    End Sub
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dmode = dModes.Ellipse
        mpath.Reset()
        hide_Caret()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dmode = dModes.Line
        mpath.Reset()
        hide_Caret()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dmode = dModes.Brush
        mpath.Reset()
        hide_Caret()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dmode = dModes.Rectangle
        mpath.Reset()
        hide_Caret()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dmode = dModes.Path
        hide_Caret()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dmode = dModes.Eraser
        hide_Caret()
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        dmode = dModes.Text
        mpath.Reset()

    End Sub


#Region "Cursors"
    'Sets the appropriate cursor
    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbox.MouseEnter
        Select Case dmode
            Case dModes.Ellipse
                pbox.Cursor = Cursors.Cross
            Case dModes.Line
                pbox.Cursor = Cursors.Cross
            Case dModes.Brush
                pbox.Cursor = Cursors.Cross
            Case dModes.Rectangle
                pbox.Cursor = Cursors.Cross
            Case dModes.Path
                pbox.Cursor = Cursors.Cross
            Case dModes.Eraser
                pbox.Cursor = er
            Case dModes.Text
                pbox.Cursor = Cursors.IBeam
            Case Else
                pbox.Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbox.MouseLeave
        pbox.Cursor = Cursors.Default
    End Sub


    Private Sub PaletteBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PaletteBox.MouseEnter
        PaletteBox.Cursor = c
    End Sub
#End Region

    Function GetEmbeddedFile(ByVal strname As String) As System.IO.Stream
        Return System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strname)
    End Function


#Region "Brush Width" 'sets the brush width
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        TextBox2.Text = TrackBar1.Value
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        penWidth = CInt(TextBox2.Text)
        TrackBar1.Value = penWidth
    End Sub
#End Region


#Region "Drawing Styles" 'Filled, Outlines only or Filled with Outlines
    Private Sub Panel1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        DrawStyles = dStyles.Outline
        GroupBox1.Refresh()
        GroupBox1.CreateGraphics.DrawRectangle(Pens.Blue, Panel1.Left - 4, Panel1.Top - 4, Panel1.Width + 7, Panel1.Height + 7)
    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        DrawStyles = dStyles.OutlineFilled
        GroupBox1.Refresh()
        GroupBox1.CreateGraphics.DrawRectangle(Pens.Blue, Panel2.Left - 4, Panel2.Top - 4, Panel2.Width + 7, Panel2.Height + 7)
    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        DrawStyles = dStyles.Filled
        GroupBox1.Refresh()
        GroupBox1.CreateGraphics.DrawRectangle(Pens.Blue, Panel3.Left - 4, Panel3.Top - 4, Panel3.Width + 7, Panel3.Height + 7)
    End Sub
#End Region

    Function hide_Caret() 'hides the caret
        If txt <> "" Then g2.DrawString(txt, Me.Font, New SolidBrush(clr), pFOld)
        pbox.Image = bmp2
        allow = False
        HideCaret(pbox.Handle.ToInt32)
        txt = ""
    End Function
End Class
