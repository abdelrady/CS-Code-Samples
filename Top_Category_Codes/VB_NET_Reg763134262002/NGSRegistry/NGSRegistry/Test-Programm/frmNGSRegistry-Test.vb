Public Class frmNGSRegistryTest
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
	Friend WithEvents cmdStartTest As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.cmdStartTest = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'cmdStartTest
		'
		Me.cmdStartTest.Location = New System.Drawing.Point(8, 16)
		Me.cmdStartTest.Name = "cmdStartTest"
		Me.cmdStartTest.Size = New System.Drawing.Size(272, 48)
		Me.cmdStartTest.TabIndex = 0
		Me.cmdStartTest.Text = "&Start Test"
		'
		'frmNGSRegistryTest
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(292, 77)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdStartTest})
		Me.Name = "frmNGSRegistryTest"
		Me.Text = "NGSRegistry-Test"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub cmdStartTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartTest.Click
		modNGSRegistryTest.Test()
	End Sub
End Class
