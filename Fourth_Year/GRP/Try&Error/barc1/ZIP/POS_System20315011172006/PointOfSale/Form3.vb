Imports System.Data.OleDb

Public Class Form3
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(288, 144)
        Me.DataGrid1.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DataGrid1})
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strSQL As String
      
        Dim objDA As OleDbDataAdapter
        Dim objDS As New DataSet()

        Try
           

            'Build the SQL strings.    
            strSQL = "SELECT ItemCode, Description " & _
                     "FROM Item Master"

            'Initialize the OleDbDataAdapter with SQL and Connection string,
            'and then use the OleDbAdapter to fill the DataSet with data.
            objDA = New OleDbDataAdapter(strSQL, dc)
            objDA.Fill(objDS, "Item Master")

            'Bind the DataSet to DataGrid.
            DataGrid1.SetDataBinding(objDS, "Item Master")

            'Create DataGridTableStyle and map it to the data table.
            Dim subtypeTableStyle As New DataGridTableStyle()
            subtypeTableStyle.MappingName = "Item Master"

            'Create ColumnStyle and set its mapping name & other properties.
            Dim colItemCode As New DataGridTextBoxColumn()
            colItemCode.HeaderText = "Item Code"
            colItemCode.MappingName = "ItemCode"
            colItemCode.Width = 50

            Dim colDescription As New DataGridTextBoxColumn()
            colDescription.HeaderText = "Description"
            colDescription.MappingName = "Description"
            colDescription.Width = 100

            'Call the Add method of GridColumnStylesCollection object to add the column to the table style.
            subtypeTableStyle.GridColumnStyles.Add(colItemCode)
            subtypeTableStyle.GridColumnStyles.Add(colDescription)

            'Call the Add method of GridTbaleStylesCollection object to add the table style to the data grid.
            DataGrid1.TableStyles.Add(subtypeTableStyle)
            DataGrid1.TableStyles("SubType").ReadOnly = True
            DataGrid1.TableStyles("SubType").AllowSorting = False

        Catch Excep As System.Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
