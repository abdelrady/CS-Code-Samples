'========================================================
'
'   Written and Distributed by Purinda Gunasekara
'   for any comments contact the author through
'   purinda@gmail.com.
'   
'========================================================

Public Class frmMain

    Dim stat As Boolean = False


    Private Sub cmbRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRead.Click
        'Declare variables to store read information and Address
        'values
        Dim intAddress As Integer, intReadVal As Integer

        'Get the address from the Textbox
        intAddress = Convert.ToInt32(txtReadAdd.Text)
        'Read the corresponding value and store
        intReadVal = porting.Inp(intAddress)


        txtStatus.Text = intReadVal.ToString()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAll.Click
        txtWriteVal.Text = 255
    End Sub

    Private Sub cmdNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNone.Click
        txtWriteVal.Text = 0
    End Sub

    Private Sub cmbWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWrite.Click
        Dim intAddress As Integer, intVal2Write As Integer

        'Get the address from the Textbox
        intAddress = Convert.ToInt16(txtWriteAdd.Text)
        'Read the corresponding value and store
        intVal2Write = Convert.ToString(txtWriteVal.Text)
        'porting is the name of the module
        porting.Out(intAddress, intVal2Write)
    End Sub

    Private Sub txtReadAdd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReadAdd.KeyDown
        If ((e.KeyValue >= 47) And (e.KeyValue <= 58)) Then

        Else
            If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Decimal)) Then

            Else
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub txtWriteAdd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWriteAdd.KeyDown
        If ((e.KeyValue >= 47) And (e.KeyValue <= 58)) Then

        Else
            If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Decimal)) Then

            Else
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub txtSurPort_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSurPort.KeyDown
        If ((e.KeyValue >= 47) And (e.KeyValue <= 58)) Then

        Else
            If ((e.KeyCode = Keys.Back) Or (e.KeyCode = Keys.Decimal)) Then

            Else
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (stat = False) Then
            Timer1.Enabled = True
            stat = True
            Button1.Text = "De-Activate!"
            Button1.BackColor = Color.Red
        Else
            Timer1.Enabled = False
            stat = False
            Button1.Text = "Activate"
            Button1.BackColor = Color.DarkGreen
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Declare variables to store read information and Address
        'values
        Dim intAddress As Integer, intReadVal As Integer

        'Get the address from the Textbox
        intAddress = Convert.ToInt32(txtSurPort.Text)
        'Read the corresponding value and store
        intReadVal = porting.Inp(intAddress)

        txtSurStat.Text = intReadVal.ToString()


    End Sub

    Private Sub openBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openBtn.Click
        Dim fn As String = ""
        Dim path As String = ""
        Dim file As String = ""

        If (openFileDialog1.ShowDialog() = DialogResult.OK) Then

            fn = System.IO.Path.GetFileName(openFileDialog1.FileName)
            path = System.IO.Path.GetDirectoryName(openFileDialog1.FileName)
            file = path + "\\" + fn

            soundBox.Text = file
            soundBox.Items.Add(file)
        End If
    End Sub

    Private Sub txtSurStat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSurStat.TextChanged
        Dim file__ As String = soundBox.Text

        If PlaySound(file__, 0, 1) = True Then
            'Sleep the thrad for 2secs and play the sound in between
            'System.Threading.Thread.Sleep(2000)
        End If
    End Sub
End Class
