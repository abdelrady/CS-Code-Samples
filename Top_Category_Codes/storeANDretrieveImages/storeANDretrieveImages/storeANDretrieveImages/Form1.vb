Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim cmd As New OleDb.OleDbCommand()
    Dim param As New OleDb.OleDbParameter()
    Dim conn As New OleDb.OleDbConnection("Provider = Microsoft.Jet.OlEDB.4.0; Data Source = c:\myDataBase.mdb")
    Dim da As New OleDb.OleDbDataAdapter()
    Dim ds As New DataSet()
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
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbImagePath As System.Windows.Forms.TextBox
    Friend WithEvents tbBrowse As System.Windows.Forms.Button
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbIDs As System.Windows.Forms.ComboBox
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbImagePath = New System.Windows.Forms.TextBox()
        Me.tbBrowse = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.cbIDs = New System.Windows.Forms.ComboBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(296, 256)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 24)
        Me.btnGet.TabIndex = 1
        Me.btnGet.Text = "get Image"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(296, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "save image"
        '
        'tbImagePath
        '
        Me.tbImagePath.Location = New System.Drawing.Point(104, 296)
        Me.tbImagePath.Name = "tbImagePath"
        Me.tbImagePath.Size = New System.Drawing.Size(184, 20)
        Me.tbImagePath.TabIndex = 3
        Me.tbImagePath.Text = ""
        '
        'tbBrowse
        '
        Me.tbBrowse.Location = New System.Drawing.Point(24, 296)
        Me.tbBrowse.Name = "tbBrowse"
        Me.tbBrowse.Size = New System.Drawing.Size(72, 23)
        Me.tbBrowse.TabIndex = 4
        Me.tbBrowse.Text = "browse"
        '
        'cbIDs
        '
        Me.cbIDs.Location = New System.Drawing.Point(216, 256)
        Me.cbIDs.Name = "cbIDs"
        Me.cbIDs.Size = New System.Drawing.Size(72, 21)
        Me.cbIDs.TabIndex = 5
        '
        'pb
        '
        Me.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb.Location = New System.Drawing.Point(16, 24)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(376, 216)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb.TabIndex = 6
        Me.pb.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 342)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pb, Me.cbIDs, Me.tbBrowse, Me.tbImagePath, Me.btnSave, Me.btnGet})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub tbBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBrowse.Click
        ofd.Filter = "Image Files (*.bmp) | *.bmp|JPEG Files (*.jpg)|*.jpg|AllFiles (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.Title = "pick up a file o open"
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True
        ofd.ValidateNames = True
        ofd.DereferenceLinks = True
        ofd.InitialDirectory = "C:\"
        ofd.RestoreDirectory = True
        ofd.ShowDialog()
        tbImagePath.Text = ofd.FileName
    End Sub

    Private Sub insertImage()
       
        
       
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (tbImagePath.Text = "") Then
            MsgBox("Error You must choose Picture")
            'End
            Return
        End If
        Dim strFile As String = tbImagePath.Text

        Dim imageStream As New System.IO.FileStream(strFile, System.IO.FileMode.Open)
        Dim imageData(imageStream.Length) As Byte

        imageStream.Read(imageData, 0, imageStream.Length)
        imageStream.Close()

        cmd = New OleDb.OleDbCommand("spInsertImage", conn)
        cmd.CommandType = CommandType.StoredProcedure

        param = New OleDb.OleDbParameter("@ImageData", OleDb.OleDbType.LongVarBinary)
        param.Value = imageData
        cmd.Parameters.Add(param)

        Try
            If MessageBox.Show("Â· ›⁄·«  —Ìœ «÷«›… Â–« «·”Ã·", "«÷«›… ”Ã·", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).CompareTo(DialogResult.No) Then
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

        Call getIds()

        tbImagePath.ResetText()

    End Sub

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        Dim imageData() As Byte
        Dim memoryStream As System.IO.MemoryStream

        cmd = New OleDb.OleDbCommand("spGetImage", conn)
        cmd.CommandType = CommandType.StoredProcedure

        param = New OleDb.OleDbParameter("@id", OleDb.OleDbType.Integer)
        param.Value = cbIDs.Text
        cmd.Parameters.Add(param)


        Try
            conn.Open()
            If Not cmd.ExecuteScalar Is System.DBNull.Value Then
                imageData = CType(cmd.ExecuteScalar, Byte())
                If Not imageData Is Nothing Then
                    memoryStream = New IO.MemoryStream(imageData)
                    pb.Image = New Bitmap(memoryStream)
                    memoryStream.Close()
                Else
                    pb.Image = Nothing
                End If
            Else
                pb.Image = Nothing
            End If
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub getIds()
        ds.Clear()

        cmd = New OleDb.OleDbCommand("spImageID", conn)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            conn.Open()


            da.SelectCommand = cmd
            da.Fill(ds, "Id")
            conn.Close()
            cbIDs.DataSource = ds.Tables("Id")
            cbIDs.DisplayMember = "id"
            cbIDs.Text = "«Œ «— —ﬁ„"



        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call getIds()
    End Sub
End Class
