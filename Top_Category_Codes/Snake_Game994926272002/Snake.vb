Option Strict On
Option Explicit On 

' *******************  SnakeDotNet  *******************
'       File:       Snake.vb
'       Version:    1.0
'       Author:     Tim Overbay
'       Date:       June 27, 2002

Namespace SnakeDotNet

    ' This is the class that represents the snake in the game. It
    ' basically keeps track of the segments that make up the snake.
    ' The data structure used to store the segments is a queue.
    Public Class Snake
        ' Maximum length of a snake. Change this for longer snakes
        Private Const MAXSNAKELENGTH As Integer = 1024
        ' Default initial length of a snake
        Private Const DEFAULTLENGTH As Integer = 4
        ' default width of a snake (defines the width and
        ' height of each segment of the snake)
        Private Const DEFAULTWIDTH As Integer = 8

        ' The queue that contains the snake's segments
        Private m_segs As Queue
        ' Width of each of the snake's segments
        Private m_width As Integer

        ' Private initialization sub called by the constructors
        Private Sub InitSnake(ByVal snakePoint As Point, ByVal snakeWidth As Integer, ByVal snakeLength As Integer)
            ' Set the segment width
            m_width = snakeWidth

            ' Define a point used to place each segment
            Dim seglocation As Point = snakePoint
            ' counter
            Dim i As Integer

            ' Segments are added head-to-tail with each new segment
            ' to the left of the previous segment. (i.e.  snakeLength =4:  3 <- 2 <- 1 <- 0)
            For i = 1 To snakeLength                '                                 head ^
                Add(seglocation)
                ' Decrement the location for the next segment
                seglocation.X -= m_width
            Next
        End Sub

        ' Default constructor
        Public Sub New()
            MyBase.New()

            ' Initialize the snake with default values
            InitSnake(New Point(DEFAULTLENGTH * DEFAULTWIDTH, 0), DEFAULTWIDTH, DEFAULTLENGTH)
        End Sub

        ' Parametricized constructor
        Public Sub New(ByVal startPoint As Point, ByVal snakeWidth As Integer, ByVal snakeLength As Integer)
            MyBase.new()

            ' Initialize the snake with specified values
            InitSnake(startPoint, snakeWidth, snakeLength)
        End Sub

        ' Adds a new segment at the specified location
        ' to the front of the snake's segment queue
        Public Sub Add(ByVal newLocation As Point)
            ' Create a new segment using the specified location for the head
            Dim newhead As New SnakeSegment(newLocation, m_width)

            ' Check if the queue array exists
            If (m_segs Is Nothing) Then
                ' initialize the queue
                m_segs = New Queue(MAXSNAKELENGTH)
            ElseIf (m_segs.Count = MAXSNAKELENGTH) Then
                ' If we already have the maximum segments in
                ' the array, Slither to the specified location instead
                Slither(newLocation)
                Exit Sub
            End If

            ' Add the newly defined segment to the queue
            m_segs.Enqueue(newhead)
        End Sub

        ' Clear the segment queue
        Public Sub Clear()
            m_segs.Clear()
        End Sub

        ' Returns an array of this snake's segments copied
        ' from the segment queue.
        Friend ReadOnly Property Segments() As SnakeSegment()
            Get
                Dim retarray(m_segs.Count - 1) As SnakeSegment
                m_segs.CopyTo(retarray, 0)
                Return retarray
            End Get
        End Property

        ' Moves the snake by adding a new head in the specified
        ' location and removing the old tail
        Public Sub Slither(ByVal newLocation As Point)

            ' Create a new segment in the specified location
            Dim newhead As New SnakeSegment(newLocation, m_width)

            ' Add the new head
            m_segs.Enqueue(newhead)

            ' Remove the old tail
            m_segs.Dequeue()

        End Sub

        ' Returns a clone of the segment representing
        ' the snake's head
        Public ReadOnly Property Head() As SnakeSegment
            Get
                Return DirectCast(m_segs.Peek, SnakeSegment).Clone
            End Get
        End Property

        ' Returns whether the specified point is on this snake
        Public Function PointOnSnake(ByVal pt As Point) As Boolean
            Dim myenum As IEnumerator = m_segs.GetEnumerator

            While myenum.MoveNext
                If DirectCast(myenum.Current, SnakeSegment).Rectangle.Contains(pt) Then Return True
            End While
        End Function

    End Class

End Namespace