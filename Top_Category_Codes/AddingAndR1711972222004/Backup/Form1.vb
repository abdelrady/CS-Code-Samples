Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents chkButton As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents panLeft As System.Windows.Forms.Panel
    Friend WithEvents panMain As System.Windows.Forms.Panel
    Friend WithEvents chkLabel As System.Windows.Forms.CheckBox
    Friend WithEvents chkTexbox As System.Windows.Forms.CheckBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkButton = New System.Windows.Forms.CheckBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.panLeft = New System.Windows.Forms.Panel
        Me.chkLabel = New System.Windows.Forms.CheckBox
        Me.chkTexbox = New System.Windows.Forms.CheckBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.panMain = New System.Windows.Forms.Panel
        Me.panLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkButton
        '
        Me.chkButton.Checked = True
        Me.chkButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkButton.Location = New System.Drawing.Point(12, 12)
        Me.chkButton.Name = "chkButton"
        Me.chkButton.Size = New System.Drawing.Size(68, 24)
        Me.chkButton.TabIndex = 1
        Me.chkButton.Text = "&Button"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(16, 160)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add"
        '
        'panLeft
        '
        Me.panLeft.BackColor = System.Drawing.Color.BurlyWood
        Me.panLeft.Controls.Add(Me.chkButton)
        Me.panLeft.Controls.Add(Me.btnAdd)
        Me.panLeft.Controls.Add(Me.chkLabel)
        Me.panLeft.Controls.Add(Me.chkTexbox)
        Me.panLeft.Controls.Add(Me.btnExit)
        Me.panLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panLeft.Location = New System.Drawing.Point(0, 0)
        Me.panLeft.Name = "panLeft"
        Me.panLeft.Size = New System.Drawing.Size(118, 221)
        Me.panLeft.TabIndex = 3
        '
        'chkLabel
        '
        Me.chkLabel.Checked = True
        Me.chkLabel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLabel.Location = New System.Drawing.Point(12, 50)
        Me.chkLabel.Name = "chkLabel"
        Me.chkLabel.Size = New System.Drawing.Size(68, 24)
        Me.chkLabel.TabIndex = 1
        Me.chkLabel.Text = "&Label"
        '
        'chkTexbox
        '
        Me.chkTexbox.Checked = True
        Me.chkTexbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTexbox.Location = New System.Drawing.Point(12, 88)
        Me.chkTexbox.Name = "chkTexbox"
        Me.chkTexbox.Size = New System.Drawing.Size(68, 24)
        Me.chkTexbox.TabIndex = 1
        Me.chkTexbox.Text = "&Textbox"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(16, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'panMain
        '
        Me.panMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panMain.Location = New System.Drawing.Point(118, 0)
        Me.panMain.Name = "panMain"
        Me.panMain.Size = New System.Drawing.Size(144, 221)
        Me.panMain.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(262, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.panMain)
        Me.Controls.Add(Me.panLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.panLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim C, NewControl As Control
        Dim X As Int32

        Try

            With panMain
                .SuspendLayout()
                .Controls.Clear()
            End With

            For Each C In panLeft.Controls
                If TypeOf C Is CheckBox Then
                    If CType(C, CheckBox).Checked Then
                        X += 1
                        NewControl = GetControl(CType(C, CheckBox).Text)
                        NewControl.Location = C.Location
                        NewControl.Width = panMain.Width - C.Left * 2
                        NewControl.Text = "Object " & X.ToString & " is a " & NewControl.GetType.Name
                        panMain.Controls.Add(NewControl)
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            panMain.ResumeLayout()

        End Try

    End Sub

    Private Function GetControl(ByVal S As String) As Control

        Select Case S

            Case "&Button"
                Return New Button

            Case "&Label"
                Return New Label

            Case "&Textbox"
                Return New TextBox

        End Select

    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
