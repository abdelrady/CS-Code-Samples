Option Strict On
Option Explicit On 

' *******************  SnakeDotNet  *******************
'       File:       frmMain.vb
'       Version:    1.0
'       Author:     Tim Overbay
'       Date:       June 27, 2002
'
' This is a VB.NET version of the classic Snake or
' Nibbles game. I wrote it for fun and because my
' son hogs my cell phone playing Snake all the time.
' 
' This implementation is as simple as possible.
' There's plenty of room for improvements/enhancements.
' Here are some suggested enhancements you could try
' as programming exercises:
'       - Improved graphics. Make the snake actually
'         look like a snake.
'
'       - Add sounds and animations
'
'       - More game objects like bugs to eat for extra
'         points, power ups for the snake, or tunnels/warp points.
'
'       - Add walls/obstacles and the ability for the player
'         to draw and save their own layouts.
'
'       - Two-player where you and a friend can try to
'         box each other in.
'
'       - Add an option for a computer-controlled snake as
'         an exercise in AI programming.
'
'       - Extend two-player mode by adding the ability to play
'         over a network.
'
'       - Make it isometric or 3D!!!!
'
'       - Morph it into a completely different game. The old
'         Tron light cycles come to mind.
'
'       - Convert it into a web-based game.
'
'
' This program is provided free of charge and can
' be used or abused any way you like. All I ask is
' that you acknowledge that I'm the original author
' if you decide to use it in your own projects or
' distribute it to others.
'
' Please contact me at luhar@slipnet.net if you find
' this program useful, you found bugs, or you have
' any suggestions for improvement.
'
' Enjoy...

Imports SlipStream.Games.SnakeDotNet

' Main form for the game
Public Class frmMain
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 304)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(88, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 56)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Press Enter to Start"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 317)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.PictureBox1})
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "SnakeDotNet"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This determines how many segments are added
    ' to the snake when it grows
    Private Const GROWTH_FACTOR As Integer = 3
    ' The width of each segment, in pixels
    Private Const SNAKE_WIDTH As Integer = 8

    ' This is our snake object
    Private m_snake As Snake
    ' This is used to control the snake's movement
    Private m_control As SnakeControl
    ' Boolean that determines whether the game is running
    Private m_running As Boolean = False
    ' Boolean that determines whether the snake is growing
    Private m_growing As Boolean = False
    ' Rectangle used to store the size & location of the food
    Private m_foodrec As Rectangle
    ' Keeps track of the player's score
    Private m_score As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set up the game environment
        InitializeGame()
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        ' Make sure the game is running
        If Not m_running Then
            e.Graphics.Clear(PictureBox1.BackColor)
            Exit Sub
        End If

        ' Draw the food
        e.Graphics.FillEllipse(Brushes.Cornsilk, m_foodrec)

        ' temporary segment variable used to
        ' loop through the snake's segments
        Dim thisseg As SnakeSegment

        ' Loop through the snake's segments and draw 'em
        For Each thisseg In m_snake.Segments
            ' Each segment is a simple block of color.
            ' There is definitely room for improved graphics here
            e.Graphics.FillRectangle(Brushes.LimeGreen, thisseg.Rectangle)
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Update the state of the game
        UpdateGame()

        ' Redraw the playing field (This can be optimized with dirty rectangles
        ' and OnDrawBackgroundImage. Hint: you really only need to draw the new
        ' head, neck, and tial of the snake.)
        PictureBox1.Invalidate()
    End Sub

    ' The sad, yet inevitable subroutine that efficiently
    ' dispatches our snake. Change this to show a really
    ' cool death sequence or something.
    Private Sub KillSnake()
        ShowMsg("Press Enter to play again or Esc to quit.")
        MsgBox("Oops! Snakey go bye bye!", vbOKOnly, "Dead Snake")
        ' re-initialize the state of the game
        InitializeGame()
    End Sub

    ' This sub finds a random location on the playing field
    ' for Snakey's food.
    Public Sub PlaceFood()
        Dim foodpt As Point

        ' The loop is needed in case the new food location
        ' ends up on the snake. We need to keep trying new
        ' locations until an open spot is found.
        Do

            foodpt = GetRandomPoint()

            ' Make sure Snakey exists first
            If Not (m_snake Is Nothing) Then
                ' Check if the new food location is not on the snake
                ' We have to obey the basic laws of physics here.
                If Not m_snake.PointOnSnake(foodpt) Then Exit Do
            Else
                Exit Do
            End If

        Loop

        ' Change the location of the rectangle for the food
        ' to our new-found random spot
        m_foodrec.Location = foodpt
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode
            Case Keys.Enter             ' Start/continue game
                HideMsg()
            Case Keys.Escape            ' pause/quit game
                If m_running Then
                    ShowMsg("Press Enter to continue or Esc again to quit.")
                Else
                    Me.Close()
                End If
        End Select

    End Sub

    ' The keydown event is where we let the user control Snakey
    ' Try using the '[' and ']' keys to control Snakey for a more
    ' challenging game.
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right, Keys.NumPad6   ' head Right
                m_control.Direction = SnakeControl.SnakeDirection.Right
            Case Keys.Down, Keys.NumPad2    ' head to Down
                m_control.Direction = SnakeControl.SnakeDirection.Down
            Case Keys.Left, Keys.NumPad4    ' head Left
                m_control.Direction = SnakeControl.SnakeDirection.Left
            Case Keys.Up, Keys.NumPad8      ' head up
                m_control.Direction = SnakeControl.SnakeDirection.Up
            Case Keys.OemOpenBrackets       ' Turn left relative to snake's current direction
                m_control.TurnLeft()
            Case Keys.OemCloseBrackets      ' Turn right relative to snake's current direction
                m_control.TurnRight()
        End Select
    End Sub

    Private Sub InitializeGame()
        ' Reset the score
        m_score = 0
        ' Initialize the food rectangle
        m_foodrec = New Rectangle(0, 0, SNAKE_WIDTH, SNAKE_WIDTH)
        ' Randomly place the food on the playing surface
        PlaceFood()

        ' Get the starting point for the snake (middle of the playing surface)
        Dim startpt As New Point( _
                    CInt(PictureBox1.ClientSize.Width / 2 / SNAKE_WIDTH + 0.5) * SNAKE_WIDTH, _
                    CInt(PictureBox1.ClientSize.Height / 2 / SNAKE_WIDTH + 0.5) * SNAKE_WIDTH)

        ' Initialize the snake with just one segment
        m_snake = New Snake(startpt, SNAKE_WIDTH, 1)
        ' Initialize the controller
        m_control = New SnakeControl(SNAKE_WIDTH, m_snake.Head.Location, SnakeControl.SnakeDirection.Right)
        ' The snake grows when the game starts (it kinda makes it look like the
        ' snake is slithering out of a hole in the ground or something)
        m_growing = True
    End Sub

    Private Sub UpdateGame()
        ' Number of segments the snake needs to add while growing
        Static targetgrowth As Integer = GROWTH_FACTOR
        ' Number of segments that have been added during growth
        Static segmentsadded As Integer

        ' Check if the game is currently running
        If Not m_running Then Exit Sub

        ' Move the controller
        m_control.Move(PictureBox1.ClientRectangle)

        ' Check if the snake bit itself
        If m_snake.PointOnSnake(m_control.Location) Then
            ' Snake gnoshed itself, reset our static
            ' variables...
            targetgrowth = 0
            segmentsadded = 0
            ' ... and kill poor Snakey
            KillSnake()
            Return

            ' Check if the snake ate some food
        ElseIf m_foodrec.Contains(m_control.Location) Then
            '   Snake ate food, let the snake grow
            targetgrowth += GROWTH_FACTOR
            m_growing = True

            ' Replenish the food supply. We don't want
            ' Snakey to starve!!!
            PlaceFood()

            ' and increase the score
            m_score += 10
            Text = "SnakeDotNet - Score: " + m_score.ToString
        End If

        ' Check if the snake is growing
        If m_growing Then

            ' Just in case the target growth has been reset to 0...
            If targetgrowth < GROWTH_FACTOR Then targetgrowth = GROWTH_FACTOR

            ' Check if the snake has grown enough
            If segmentsadded >= targetgrowth Then
                ' Reset the variables for growing
                m_growing = False
                segmentsadded = 0
                targetgrowth = 0
                ' The snake isn't growing anymore,
                ' so slither the snake instead.
                m_snake.Slither(m_control.Location)
            Else
                ' Add a new segment in the new location
                m_snake.Add(m_control.Location)
                ' Increment the number of segments added
                segmentsadded += 1
            End If
        Else
            ' Slither the snake to the new location
            m_snake.Slither(m_control.Location)
        End If

    End Sub

    ' This sub pauses the game and displays
    ' the specified message in the middle of
    ' the playing field.
    Private Sub ShowMsg(ByVal msg As String)
        Label1.Text = msg
        Label1.Visible = True
        m_running = False
        Timer1.Enabled = False
    End Sub

    ' This hides the previous message and
    ' continues the game.
    Private Sub HideMsg()
        Me.Text = "SnakeDotNet - Score: " + m_score.ToString
        Label1.Visible = False
        m_running = True
        Timer1.Enabled = True
    End Sub

    ' This returns a random point within the limits
    ' of the playing field. The point is clamped to
    ' an imaginary grid with the same spacing as the
    ' snake's width.
    Public Function GetRandomPoint() As Point
        ' Initialize the random generator
        Dim r As New Random(Now.Second)

        ' Get the width and height of the field as multiples of the snake's width
        Dim fieldwidth As Integer = ((ClientRectangle.Width \ SNAKE_WIDTH) - 2) * SNAKE_WIDTH
        Dim fieldheight As Integer = ((ClientRectangle.Height \ SNAKE_WIDTH) - 2) * SNAKE_WIDTH

        ' Get random values for the x & y values
        Dim randx As Integer = r.Next(0, fieldwidth)
        Dim randy As Integer = r.Next(0, fieldheight)

        ' Clamp the x & y values to a multiple of the snake's width
        randx = (randx \ SNAKE_WIDTH) * SNAKE_WIDTH
        randy = (randy \ SNAKE_WIDTH) * SNAKE_WIDTH

        Return New Point(randx, randy)
    End Function

End Class