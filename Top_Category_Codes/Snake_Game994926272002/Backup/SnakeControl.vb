Option Strict On
Option Explicit On 

' *******************  SnakeDotNet  *******************
'       File:       SnakeControl.vb
'       Version:    1.0
'       Author:     Tim Overbay
'       Date:       June 27, 2002

Namespace SnakeDotNet

    ' This class is used to control the movement of the snake
    ' - The snake can move in four directions: Up, Down, Right, & Left
    ' - The snake cannot reverse direction (i.e. Up to Down, Right to Left)
    ' - The snake's position is defined as the location of its head.
    ' - The snake is moved by incrementing it's position in the current direction
    '   by the amount specified by the width of a node.

    Public Class SnakeControl

        ' SnakeDirection enumerates the possible
        ' directions the snake can move.
        Friend Enum SnakeDirection As Integer
            None = -1
            Left            ' 0     X -= increment
            Down            ' 1     Y += increment
            Right           ' 2     X += increment
            Up              ' 3     Y -= increment
        End Enum

        Private m_location As Point                 ' Current location of the head
        Private m_increment As Integer              ' Increment used to move the snake
        Private m_direction As SnakeDirection       ' Current direction of movement

        ' Default constructor
        Public Sub New()
            m_increment = 8                         ' Default movement increment
            m_location = New Point(0, 0)            ' Default starting location
            Direction = SnakeDirection.Right         ' Default direction
        End Sub

        ' Parametricized constructor where the increment,
        ' starting position, & direction are specified.
        Friend Sub New(ByVal newIncrement As Integer, ByVal startLocation As Point, ByVal newDirection As SnakeDirection)
            ' Check that the new direction is valid
            If (newDirection < SnakeDirection.Left) OrElse (newDirection > SnakeDirection.Up) Then
                Throw New ArgumentOutOfRangeException("Direction", "Direction must be Left [0], Down [1], Right [2], or Up [3]")
                Return
            End If
            ' Set the new direction
            m_direction = newDirection
            ' Set the new increment value
            m_increment = newIncrement
            ' Set the starting location
            m_location = startLocation
        End Sub

        ' Look ahead to the snake's next location without actually moving the snake there.
        ' The optional peekDir parameter allows the caller to peek in a direction
        ' other than the current direction.
        Friend Function PeekNextLocation(Optional ByVal peekDir As SnakeDirection = SnakeDirection.None) As Point
            ' Make a temporary copy of the snake's current location
            Dim retpt As New Point(m_location.X, m_location.Y)

            ' Check for default value. Set peekDir to the snake's current direction.
            If (peekDir = SnakeDirection.None) Then peekDir = m_direction

            ' Increment the temporary location based on the specified direction
            Select Case peekDir
                Case SnakeDirection.Left
                    retpt.X -= m_increment
                    Exit Select
                Case SnakeDirection.Down
                    retpt.Y += m_increment
                    Exit Select
                Case SnakeDirection.Right
                    retpt.X += m_increment
                    Exit Select
                Case SnakeDirection.Up
                    retpt.Y -= m_increment
                    Exit Select
            End Select

            ' Return the new location
            Return retpt
        End Function

        ' Move's the snake to the next location based on the snake's current direction.
        ' The optional moveDir parameter allows the caller to move the snake in a direction
        ' other than the current direction.
        Friend Sub Move(Optional ByVal moveDir As SnakeDirection = SnakeDirection.None)

            ' Check for default value. Set moveDir to the snake's current direction.
            If (moveDir = SnakeDirection.None) Then moveDir = m_direction

            ' Increment the snake's location based on the specified direction
            ' and set the Shape appropriately.
            Select Case moveDir
                Case SnakeDirection.Left
                    m_location.X -= m_increment
                    Exit Select
                Case SnakeDirection.Down
                    m_location.Y += m_increment
                    Exit Select
                Case SnakeDirection.Right
                    m_location.X += m_increment
                    Exit Select
                Case SnakeDirection.Up
                    m_location.Y -= m_increment
                    Exit Select
            End Select
        End Sub

        ' This is a special version of the Move that allows the
        ' controller to "wrap around" the specified bounds.
        Friend Sub Move(ByVal bounds As Rectangle, Optional ByVal moveDir As SnakeDirection = SnakeDirection.None)
            Move(moveDir)

            If (m_location.X > bounds.Right) Then
                m_location.X = CInt(bounds.Left / m_increment) * m_increment
            ElseIf (m_location.X < bounds.Left) Then
                m_location.X = CInt(bounds.Right / m_increment) * m_increment
            ElseIf (m_location.Y > bounds.Bottom) Then
                m_location.Y = CInt(bounds.Top / m_increment) * m_increment
            ElseIf (m_location.Y < bounds.Top) Then
                m_location.Y = CInt(bounds.Bottom / m_increment) * m_increment
            End If
        End Sub

        ' Returns the current position of the snake's head
        Public ReadOnly Property Location() As Point
            Get
                Return m_location
            End Get
        End Property

        ' Sets/Returns the snake's current direction
        Friend Property Direction() As SnakeDirection
            Get
                Return m_direction
            End Get

            Set(ByVal newDirection As SnakeDirection)

                ' Check that the new direction is valid
                If (newDirection < SnakeDirection.Left) OrElse (newDirection > SnakeDirection.Up) Then
                    Throw New ArgumentOutOfRangeException("Direction", "Direction must be Left [0], Down [1], Right [2], or Up [3]")
                    Return
                End If

                ' Check if direction hasn't changed
                If newDirection = m_direction Then Exit Property

                ' Check if direction is reversed
                If CInt(Math.Abs(newDirection - m_direction) Mod 2) = 0 Then Exit Property

                ' Finally, change the snake's direction
                m_direction = newDirection

            End Set
        End Property

        ' Function to rotate the snake's direction 90 degrees counter-clockwise.
        Public Sub TurnLeft()

            ' Check that the snake's current direction is valid.
            If (m_direction < SnakeDirection.Left) Or (m_direction > SnakeDirection.Up) Then Exit Sub

            ' Get the new direction
            Dim newdir As SnakeDirection = CType(m_direction + 1, SnakeDirection)

            ' Wrap it around back to Left, if necessary.
            If newdir > SnakeDirection.Up Then newdir = SnakeDirection.Left

            ' Set the snake's new direction
            Direction = newdir

        End Sub

        ' Function to rotate the snake's direction 90 degrees clockwise.
        Public Sub TurnRight()

            ' Check that the snake's current direction is valid.
            If (m_direction < SnakeDirection.Left) Or (m_direction > SnakeDirection.Up) Then Exit Sub

            ' Get the new direction
            Dim newdir As SnakeDirection = CType(m_direction - 1, SnakeDirection)

            ' Wrap it around back to Up, if necessary.
            If newdir < SnakeDirection.Left Then newdir = SnakeDirection.Up

            ' Set the snake's new direction
            Direction = newdir

        End Sub

        ' Returns the snake's increment value.
        ' NOTE: This property is currently read-only. It might be more
        '       useful to make it read/write.
        Public ReadOnly Property Increment() As Integer
            Get
                Return m_increment
            End Get
        End Property

    End Class

End Namespace