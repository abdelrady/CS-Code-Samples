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
    Friend WithEvents btnReduceMemory As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnReduceMemory = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnReduceMemory
        '
        Me.btnReduceMemory.Location = New System.Drawing.Point(112, 8)
        Me.btnReduceMemory.Name = "btnReduceMemory"
        Me.btnReduceMemory.Size = New System.Drawing.Size(104, 23)
        Me.btnReduceMemory.TabIndex = 0
        Me.btnReduceMemory.Text = "Reduce &Memory"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(8, 48)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(328, 48)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "This program shows how to reduce the amount of used memory for one . NET program." & _
        "  To start, see the used memory of the program and after that click the button a" & _
        "nd check it out again."
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 101)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnReduceMemory)
        Me.Name = "frmMain"
        Me.Text = " Main"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub SetProcessWorkingSetSize()
        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnReduceMemory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReduceMemory.Click
        SetProcessWorkingSetSize()
        MsgBox("See memory used now!")
    End Sub
End Class
