Public Class FaderForm
    Inherits System.Windows.Forms.Form

#Region "FaderForm Variable Declarations"

    Private Enum FadeFlag                           'Enumeration for the current status of the window.
        FADEIN
        FADEOUT
    End Enum

    Private Status As New FadeFlag()                'Var to keep track of which transition is going to take place (fade in or out)
    Private intTransitionStep As New Integer()      'Var to hold the increment amount when increasing/decreasing the Opacity
    Private bFadeEnabled As New Boolean()           'Var used to enable or disable the fade in/out effect

    'TransitionTime: The amount of time (in milliseconds) that elapses before
    'increasing or decreasing the Opacity by intTransitionStep.
    Public Property ffTransitionTime() As Integer
        Get
            Return FadeTimer.Interval
        End Get
        Set(ByVal Value As Integer)

            'If the value is between 1 ms and 1000ms it's valid
            'If not, set the intTransitionTime to 1 (default value)
            If Value <= 0 Or Value > 1000 Then
                FadeTimer.Interval = 1
            Else
                FadeTimer.Interval = Value
            End If

        End Set
    End Property

    'TransitionStep:  The value used to increment the Opacity.
    Public Property ffTransitionStep() As Integer
        Get
            Return intTransitionStep
        End Get
        Set(ByVal Value As Integer)

            'If the incremented value is between 1 and 50 it's valid
            'If not, set it to the default value of 2
            If Value < 1 Or Value > 50 Then
                intTransitionStep = 5
            Else
                intTransitionStep = Value
            End If

        End Set
    End Property

    'ffFadeIn_Out: The value used to enable or disable the fade in/out effect.
    Public Property ffFadeEnabled() As Boolean
        Get
            Return bFadeEnabled
        End Get
        Set(ByVal Value As Boolean)

            bFadeEnabled = Value

            If Value = False Then
                'Since the fade in/out effect is being turned off, set 
                'the opacity to 100%, disable the timer, and even though 
                'it's not necessary set the Status to FADEIN.
                Me.Opacity = 1.0
                FadeTimer.Enabled = False
                Status = FadeFlag.FADEIN

            End If

        End Set
    End Property

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'Set the status of the form when it is created.

        'Set the default values for the FaderForm.
        Status = FadeFlag.FADEIN
        FadeTimer.Enabled = False
        intTransitionStep = 5
        bFadeEnabled = True

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
    Friend WithEvents FadeTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FadeTimer = New System.Windows.Forms.Timer(Me.components)
        '
        'FadeTimer
        '
        Me.FadeTimer.Interval = 1
        '
        'FaderForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Name = "FaderForm"
        Me.Text = "FaderForm"

    End Sub

    'FaderForm Stuff Here!!!!!!!!!
#Region "FadeOut"
    'FadeOut:  Fired when the form loses focus through code or by the user.  If the 
    '          bFadeIn_Out value is set to true then this routine will set the Status
    '          flag to FADEOUT, the timer will gradually decrease the opacity of the form.
    Private Sub FadeOut(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                        Handles MyBase.Deactivate

        'First check the status of the FadeIn_Out property.
        If bFadeEnabled = True Then

            'Set the status to FadeOut
            Status = FadeFlag.FADEOUT

            'Turn the timer ON
            FadeTimer.Enabled = True

        End If

    End Sub
#End Region

#Region "FadeIn"
    'FadeIn:   Fired when the form is activated through code or by the user.  If the 
    '          bFadeIn_Out value is set to true then this routine will set the Status
    '          flag to FADEIN, the timer will gradually increase the opacity of the form.
    Private Sub FadeIn(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles MyBase.Activated

        'First check the status of the FadeIn_Out property.
        If bFadeEnabled = True Then

            'Set the status fo FadeIn
            Status = FadeFlag.FADEIN

            'Turn the timer On
            FadeTimer.Enabled = True

        End If

    End Sub
#End Region

#Region "FadeTimer_Tick"
    'FadeTimer_Tick:  When the timer is enabled, it will check the value held in the 
    '                 Status variable.  If the value is FADEIN the form's opacity is
    '                 gradually increased or decreased by the value held in intTransitionStep
    '                 every ffTransitionTime milliseconds.
    Private Sub FadeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeTimer.Tick
        'Check the value of Status
        If Status = FadeFlag.FADEIN Then

            'We know the status is set to "fade in". Increase the Opacity
            'Check the level of opacity
            If Me.Opacity >= 1 Then
                'Shut the timer off.  Our work is done here.
                FadeTimer.Enabled = False
            Else
                'Increase the opacity by 1%
                Me.Opacity = Me.Opacity + intTransitionStep / 100.0
            End If

        Else

            'We know the status is set to "fade out". Decrease the Opacity
            'Check the level of opacity
            If Me.Opacity <= 0.5 Then
                'Shut off the timer. Our work is done here
                FadeTimer.Enabled = False
            Else
                'Decrease the opacity
                Me.Opacity = Me.Opacity - intTransitionStep / 100.0
            End If

        End If

    End Sub
#End Region

#End Region


End Class

