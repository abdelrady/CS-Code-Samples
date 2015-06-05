Option Strict On
Option Explicit On 

' *******************  SnakeDotNet  *******************
'       File:       SnakeSegment.vb
'       Version:    1.0
'       Author:     Tim Overbay
'       Date:       June 27, 2002

Namespace SnakeDotNet

    ' SnakeSegment describes a rectangle around
    ' a single segment of the snake.
    Public Class SnakeSegment

        ' This segment's rectangle
        Private m_rect As Rectangle

        ' Constructor with specified location and segment width
        Public Sub New(ByVal location As Point, ByVal width As Integer)
            m_rect = New Rectangle(location, New Size(width, width))
        End Sub

        ' returns this segment's rectangle
        Public ReadOnly Property Rectangle() As Rectangle
            Get
                Return m_rect
            End Get
        End Property

        ' returns this segment's location
        Public Property Location() As Point
            Get
                Return m_rect.Location
            End Get
            Set(ByVal Value As Point)
                m_rect.Location = Value
            End Set
        End Property

        ' returns this segment's size
        Public ReadOnly Property Size() As Size
            Get
                Return m_rect.Size
            End Get
        End Property

        ' returns a clone of this segment
        Public Function Clone() As SnakeSegment
            Return New SnakeSegment(m_rect.Location, m_rect.Width)
        End Function

        ' returns a string representation of this segment
        Public Overrides Function ToString() As String
            Return Me.GetType.ToString + ": " + m_rect.Location.ToString
        End Function

    End Class

End Namespace