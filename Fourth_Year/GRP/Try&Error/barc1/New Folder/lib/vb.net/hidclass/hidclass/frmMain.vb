Option Strict On
Option Explicit On 
Imports System.Runtime.InteropServices

Friend Class frmMain
    Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents tmrContinuousDataCollect As System.Windows.Forms.Timer
    Public WithEvents cmdContinuous As System.Windows.Forms.Button
    Public WithEvents cmdOnce As System.Windows.Forms.Button
    Public WithEvents fraSendAndReceive As System.Windows.Forms.GroupBox
    Public WithEvents txtBytesReceived As System.Windows.Forms.TextBox
    Public WithEvents fraBytesReceived As System.Windows.Forms.GroupBox
    Public WithEvents chkAutoincrement As System.Windows.Forms.CheckBox
    Public WithEvents cboByte1 As System.Windows.Forms.ComboBox
    Public WithEvents cboByte0 As System.Windows.Forms.ComboBox
    Public WithEvents fraBytesToSend As System.Windows.Forms.GroupBox
    Public WithEvents tmrDelay As System.Windows.Forms.Timer
    Public WithEvents lstResults As System.Windows.Forms.ListBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents fraReportTypes As System.Windows.Forms.GroupBox
    Friend WithEvents optInputOutput As System.Windows.Forms.RadioButton
    Friend WithEvents optFeature As System.Windows.Forms.RadioButton
    Friend WithEvents fraInputReportBufferSize As System.Windows.Forms.GroupBox
    Friend WithEvents txtInputReportBufferSize As System.Windows.Forms.TextBox
    Friend WithEvents cmdInputReportBufferSize As System.Windows.Forms.Button
    Friend WithEvents fraDeviceIdentifiers As System.Windows.Forms.GroupBox
    Friend WithEvents lblVendorID As System.Windows.Forms.Label
    Friend WithEvents txtVendorID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents cmdFindDevice As System.Windows.Forms.Button
    Friend WithEvents chkUseControlTransfersOnly As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrContinuousDataCollect = New System.Windows.Forms.Timer(Me.components)
        Me.fraSendAndReceive = New System.Windows.Forms.GroupBox
        Me.cmdContinuous = New System.Windows.Forms.Button
        Me.cmdOnce = New System.Windows.Forms.Button
        Me.fraBytesReceived = New System.Windows.Forms.GroupBox
        Me.txtBytesReceived = New System.Windows.Forms.TextBox
        Me.fraBytesToSend = New System.Windows.Forms.GroupBox
        Me.chkAutoincrement = New System.Windows.Forms.CheckBox
        Me.cboByte1 = New System.Windows.Forms.ComboBox
        Me.cboByte0 = New System.Windows.Forms.ComboBox
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.lstResults = New System.Windows.Forms.ListBox
        Me.fraReportTypes = New System.Windows.Forms.GroupBox
        Me.chkUseControlTransfersOnly = New System.Windows.Forms.CheckBox
        Me.optFeature = New System.Windows.Forms.RadioButton
        Me.optInputOutput = New System.Windows.Forms.RadioButton
        Me.fraInputReportBufferSize = New System.Windows.Forms.GroupBox
        Me.cmdInputReportBufferSize = New System.Windows.Forms.Button
        Me.txtInputReportBufferSize = New System.Windows.Forms.TextBox
        Me.fraDeviceIdentifiers = New System.Windows.Forms.GroupBox
        Me.txtProductID = New System.Windows.Forms.TextBox
        Me.lblProductID = New System.Windows.Forms.Label
        Me.txtVendorID = New System.Windows.Forms.TextBox
        Me.lblVendorID = New System.Windows.Forms.Label
        Me.cmdFindDevice = New System.Windows.Forms.Button
        Me.fraSendAndReceive.SuspendLayout()
        Me.fraBytesReceived.SuspendLayout()
        Me.fraBytesToSend.SuspendLayout()
        Me.fraReportTypes.SuspendLayout()
        Me.fraInputReportBufferSize.SuspendLayout()
        Me.fraDeviceIdentifiers.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrContinuousDataCollect
        '
        Me.tmrContinuousDataCollect.Interval = 1
        '
        'fraSendAndReceive
        '
        Me.fraSendAndReceive.BackColor = System.Drawing.SystemColors.Control
        Me.fraSendAndReceive.Controls.Add(Me.cmdContinuous)
        Me.fraSendAndReceive.Controls.Add(Me.cmdOnce)
        Me.fraSendAndReceive.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraSendAndReceive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSendAndReceive.Location = New System.Drawing.Point(608, 128)
        Me.fraSendAndReceive.Name = "fraSendAndReceive"
        Me.fraSendAndReceive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSendAndReceive.Size = New System.Drawing.Size(176, 136)
        Me.fraSendAndReceive.TabIndex = 7
        Me.fraSendAndReceive.TabStop = False
        Me.fraSendAndReceive.Text = "Send and Receive Data"
        '
        'cmdContinuous
        '
        Me.cmdContinuous.BackColor = System.Drawing.SystemColors.Control
        Me.cmdContinuous.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdContinuous.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinuous.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdContinuous.Location = New System.Drawing.Point(16, 88)
        Me.cmdContinuous.Name = "cmdContinuous"
        Me.cmdContinuous.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdContinuous.Size = New System.Drawing.Size(121, 36)
        Me.cmdContinuous.TabIndex = 9
        Me.cmdContinuous.Text = "Continuous"
        '
        'cmdOnce
        '
        Me.cmdOnce.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOnce.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOnce.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOnce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOnce.Location = New System.Drawing.Point(16, 32)
        Me.cmdOnce.Name = "cmdOnce"
        Me.cmdOnce.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOnce.Size = New System.Drawing.Size(121, 36)
        Me.cmdOnce.TabIndex = 8
        Me.cmdOnce.Text = "Once"
        '
        'fraBytesReceived
        '
        Me.fraBytesReceived.BackColor = System.Drawing.SystemColors.Control
        Me.fraBytesReceived.Controls.Add(Me.txtBytesReceived)
        Me.fraBytesReceived.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraBytesReceived.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraBytesReceived.Location = New System.Drawing.Point(208, 128)
        Me.fraBytesReceived.Name = "fraBytesReceived"
        Me.fraBytesReceived.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraBytesReceived.Size = New System.Drawing.Size(128, 136)
        Me.fraBytesReceived.TabIndex = 4
        Me.fraBytesReceived.TabStop = False
        Me.fraBytesReceived.Text = "Bytes Received"
        '
        'txtBytesReceived
        '
        Me.txtBytesReceived.AcceptsReturn = True
        Me.txtBytesReceived.AutoSize = False
        Me.txtBytesReceived.BackColor = System.Drawing.SystemColors.Window
        Me.txtBytesReceived.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBytesReceived.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBytesReceived.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBytesReceived.Location = New System.Drawing.Point(16, 24)
        Me.txtBytesReceived.MaxLength = 0
        Me.txtBytesReceived.Multiline = True
        Me.txtBytesReceived.Name = "txtBytesReceived"
        Me.txtBytesReceived.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBytesReceived.Size = New System.Drawing.Size(72, 96)
        Me.txtBytesReceived.TabIndex = 5
        Me.txtBytesReceived.Text = ""
        '
        'fraBytesToSend
        '
        Me.fraBytesToSend.BackColor = System.Drawing.SystemColors.Control
        Me.fraBytesToSend.Controls.Add(Me.chkAutoincrement)
        Me.fraBytesToSend.Controls.Add(Me.cboByte1)
        Me.fraBytesToSend.Controls.Add(Me.cboByte0)
        Me.fraBytesToSend.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraBytesToSend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraBytesToSend.Location = New System.Drawing.Point(16, 128)
        Me.fraBytesToSend.Name = "fraBytesToSend"
        Me.fraBytesToSend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraBytesToSend.Size = New System.Drawing.Size(181, 136)
        Me.fraBytesToSend.TabIndex = 1
        Me.fraBytesToSend.TabStop = False
        Me.fraBytesToSend.Text = "Bytes to Send"
        '
        'chkAutoincrement
        '
        Me.chkAutoincrement.BackColor = System.Drawing.SystemColors.Control
        Me.chkAutoincrement.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAutoincrement.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoincrement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAutoincrement.Location = New System.Drawing.Point(8, 96)
        Me.chkAutoincrement.Name = "chkAutoincrement"
        Me.chkAutoincrement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAutoincrement.Size = New System.Drawing.Size(201, 35)
        Me.chkAutoincrement.TabIndex = 6
        Me.chkAutoincrement.Text = "Autoincrement values"
        '
        'cboByte1
        '
        Me.cboByte1.BackColor = System.Drawing.SystemColors.Window
        Me.cboByte1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboByte1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboByte1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboByte1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboByte1.Location = New System.Drawing.Point(8, 64)
        Me.cboByte1.Name = "cboByte1"
        Me.cboByte1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboByte1.Size = New System.Drawing.Size(101, 24)
        Me.cboByte1.TabIndex = 3
        '
        'cboByte0
        '
        Me.cboByte0.BackColor = System.Drawing.SystemColors.Window
        Me.cboByte0.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboByte0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboByte0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboByte0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboByte0.Location = New System.Drawing.Point(8, 24)
        Me.cboByte0.Name = "cboByte0"
        Me.cboByte0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboByte0.Size = New System.Drawing.Size(101, 24)
        Me.cboByte0.TabIndex = 2
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 1
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.SystemColors.Window
        Me.lstResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstResults.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstResults.HorizontalScrollbar = True
        Me.lstResults.ItemHeight = 16
        Me.lstResults.Location = New System.Drawing.Point(16, 272)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstResults.Size = New System.Drawing.Size(760, 276)
        Me.lstResults.TabIndex = 0
        '
        'fraReportTypes
        '
        Me.fraReportTypes.Controls.Add(Me.chkUseControlTransfersOnly)
        Me.fraReportTypes.Controls.Add(Me.optFeature)
        Me.fraReportTypes.Controls.Add(Me.optInputOutput)
        Me.fraReportTypes.Location = New System.Drawing.Point(344, 128)
        Me.fraReportTypes.Name = "fraReportTypes"
        Me.fraReportTypes.Size = New System.Drawing.Size(248, 104)
        Me.fraReportTypes.TabIndex = 8
        Me.fraReportTypes.TabStop = False
        Me.fraReportTypes.Text = "Report Options"
        '
        'chkUseControlTransfersOnly
        '
        Me.chkUseControlTransfersOnly.Location = New System.Drawing.Point(24, 48)
        Me.chkUseControlTransfersOnly.Name = "chkUseControlTransfersOnly"
        Me.chkUseControlTransfersOnly.Size = New System.Drawing.Size(200, 24)
        Me.chkUseControlTransfersOnly.TabIndex = 2
        Me.chkUseControlTransfersOnly.Text = "Use ControlTransfers Only"
        '
        'optFeature
        '
        Me.optFeature.Location = New System.Drawing.Point(8, 80)
        Me.optFeature.Name = "optFeature"
        Me.optFeature.Size = New System.Drawing.Size(248, 24)
        Me.optFeature.TabIndex = 1
        Me.optFeature.Text = "Exchange Feature Reports"
        '
        'optInputOutput
        '
        Me.optInputOutput.Checked = True
        Me.optInputOutput.Location = New System.Drawing.Point(8, 24)
        Me.optInputOutput.Name = "optInputOutput"
        Me.optInputOutput.Size = New System.Drawing.Size(256, 24)
        Me.optInputOutput.TabIndex = 0
        Me.optInputOutput.TabStop = True
        Me.optInputOutput.Text = "Exchange Input and Output Reports"
        '
        'fraInputReportBufferSize
        '
        Me.fraInputReportBufferSize.Controls.Add(Me.cmdInputReportBufferSize)
        Me.fraInputReportBufferSize.Controls.Add(Me.txtInputReportBufferSize)
        Me.fraInputReportBufferSize.Location = New System.Drawing.Point(248, 16)
        Me.fraInputReportBufferSize.Name = "fraInputReportBufferSize"
        Me.fraInputReportBufferSize.Size = New System.Drawing.Size(208, 96)
        Me.fraInputReportBufferSize.TabIndex = 9
        Me.fraInputReportBufferSize.TabStop = False
        Me.fraInputReportBufferSize.Text = "Input Report Buffer Size"
        '
        'cmdInputReportBufferSize
        '
        Me.cmdInputReportBufferSize.Location = New System.Drawing.Point(96, 32)
        Me.cmdInputReportBufferSize.Name = "cmdInputReportBufferSize"
        Me.cmdInputReportBufferSize.Size = New System.Drawing.Size(96, 56)
        Me.cmdInputReportBufferSize.TabIndex = 1
        Me.cmdInputReportBufferSize.Text = "Change Buffer Size"
        '
        'txtInputReportBufferSize
        '
        Me.txtInputReportBufferSize.Location = New System.Drawing.Point(16, 40)
        Me.txtInputReportBufferSize.Name = "txtInputReportBufferSize"
        Me.txtInputReportBufferSize.Size = New System.Drawing.Size(56, 23)
        Me.txtInputReportBufferSize.TabIndex = 0
        Me.txtInputReportBufferSize.Text = ""
        '
        'fraDeviceIdentifiers
        '
        Me.fraDeviceIdentifiers.Controls.Add(Me.txtProductID)
        Me.fraDeviceIdentifiers.Controls.Add(Me.lblProductID)
        Me.fraDeviceIdentifiers.Controls.Add(Me.txtVendorID)
        Me.fraDeviceIdentifiers.Controls.Add(Me.lblVendorID)
        Me.fraDeviceIdentifiers.Location = New System.Drawing.Point(16, 16)
        Me.fraDeviceIdentifiers.Name = "fraDeviceIdentifiers"
        Me.fraDeviceIdentifiers.Size = New System.Drawing.Size(208, 96)
        Me.fraDeviceIdentifiers.TabIndex = 10
        Me.fraDeviceIdentifiers.TabStop = False
        Me.fraDeviceIdentifiers.Text = "Device Identifiers"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(120, 56)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(72, 23)
        Me.txtProductID.TabIndex = 3
        Me.txtProductID.Text = "1299"
        '
        'lblProductID
        '
        Me.lblProductID.Location = New System.Drawing.Point(16, 56)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(112, 23)
        Me.lblProductID.TabIndex = 2
        Me.lblProductID.Text = "Product ID (hex):"
        '
        'txtVendorID
        '
        Me.txtVendorID.Location = New System.Drawing.Point(120, 24)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Size = New System.Drawing.Size(72, 23)
        Me.txtVendorID.TabIndex = 1
        Me.txtVendorID.Text = "0925"
        '
        'lblVendorID
        '
        Me.lblVendorID.Location = New System.Drawing.Point(16, 24)
        Me.lblVendorID.Name = "lblVendorID"
        Me.lblVendorID.Size = New System.Drawing.Size(112, 23)
        Me.lblVendorID.TabIndex = 0
        Me.lblVendorID.Text = "Vendor ID (hex):"
        '
        'cmdFindDevice
        '
        Me.cmdFindDevice.Location = New System.Drawing.Point(464, 48)
        Me.cmdFindDevice.Name = "cmdFindDevice"
        Me.cmdFindDevice.Size = New System.Drawing.Size(136, 40)
        Me.cmdFindDevice.TabIndex = 11
        Me.cmdFindDevice.Text = "Find My Device"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(792, 557)
        Me.Controls.Add(Me.cmdFindDevice)
        Me.Controls.Add(Me.fraDeviceIdentifiers)
        Me.Controls.Add(Me.fraInputReportBufferSize)
        Me.Controls.Add(Me.fraReportTypes)
        Me.Controls.Add(Me.fraSendAndReceive)
        Me.Controls.Add(Me.fraBytesReceived)
        Me.Controls.Add(Me.fraBytesToSend)
        Me.Controls.Add(Me.lstResults)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(21, 28)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Jan's HID Tester"
        Me.fraSendAndReceive.ResumeLayout(False)
        Me.fraBytesReceived.ResumeLayout(False)
        Me.fraBytesToSend.ResumeLayout(False)
        Me.fraReportTypes.ResumeLayout(False)
        Me.fraInputReportBufferSize.ResumeLayout(False)
        Me.fraDeviceIdentifiers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As frmMain
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmMain
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmMain()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmMain)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    'Project: usbhidio_vbdotnet
    'Version: 2.2
    'Date: 7/13/05
    '
    'Purpose: 
    'Demonstrates USB communications with a generic HID-class device

    'Description:
    'Finds an attached device that matches the vendor and product IDs in the form's 
    'text boxes.
    'Retrieves the device's capabilities.
    'Sends and requests HID reports.

    'Uses RegisterDeviceNotification() and WM_DEVICE_CHANGE messages
    'to detect when a device is attached or removed.
    'RegisterDeviceNotification doesn't work under Windows 98 (not sure why).

    'A list box displays the data sent and received,
    'along with error and status messages.

    'Combo boxes select data to send, and 1-time or timed, periodic transfers.

    'You can change the size of the host's Input report buffer and request to use control
    'transfers only to exchange Input and Output reports.

    'To view additional debugging messages, in the Visual Studio development environment,
    'select the Debug build (Build > Configuration Manager > Active Solution Configuration)
    'and view the Output window (View > Other Windows > Output)

    'The application uses a Delegate and the BeginInvoke and EndInvoke methods to read
    'from the device asynchronously. 

    'If you want to only receive data or only send data, comment out the unwanted code 
    '(In ExchangeInputAndOutputReports or ExchangeFeatureReports, comment out
    'the "Success = " line and the "If Success" block that follows it).

    'This project includes the following modules:
    'frmMain.vb - routines specific to the form.
    'Hid.vb - routines specific to HID communications.
    'DeviceManagement.vb - routines for obtaining a handle to a device from its GUID
    'and receiving device notifications. This routines are not specific to HIDs.
    'Debugging.vb - contains a routine for displaying API error messages.

    'HidDeclarations.vb - Declarations for API functions used by Hid.vb.
    'FileIODeclarations.vb - Declarations for file-related API functions.
    'DeviceManagementDeclarations.vb - Declarations for API functions used by DeviceManagement.vb.
    'DebuggingDeclarations.vb - Declarations for API functions used by Debugging.vb.

    'Companion device firmware for several device CPUs is available from www.Lvr.com/hidpage.htm.
    'You can use any generic HID (not a system mouse or keyboard) that sends and receives reports.

    'New in version 2.2:
    'The application obtains separate handles for device information/Feature reports,
    'Input reports, and Output reports. This enables getting information about
    'mice and keyboards.
    'The application detects if the device is a mouse or keyboard
    'and warns that Windows 2000/XP will not allow exchanging Input or Output reports.
    'The list box's contents are trimmed periodically. 

    'For more information about HIDs and USB, and additional example device firmware to use
    'with this application, visit Lakeview Research at http://www.Lvr.com .

    'Send comments, bug reports, etc. to jan@Lvr.com .

    'This application has been tested under Windows 98SE, Windows 2000, and Windows XP.

    Dim DeviceNotificationHandle As IntPtr
    Dim ExclusiveAccess As Boolean
    Dim HIDHandle As Integer
    Dim HIDUsage As String
    Dim MyDeviceDetected As Boolean
    Dim MyDevicePathName As String
    Dim MyHID As New Hid()
    Dim ReadHandle As Integer
    Dim WriteHandle As Integer

    'Used only in viewing results of API calls in debug.write statements:
    Dim MyDebugging As New Debugging()

    Dim MyDeviceManagement As New DeviceManagement()

    Friend frmMy As frmMain

    'Define a class of delegates that point to the Hid.DeviceReport.Read function.
    'The delegate has the same parameters as Hid.DeviceReport.Read.
    'Used for asynchronous reads from the device.
    Private Delegate Sub ReadInputReportDelegate _
        (ByVal readHandle As Integer, _
        ByVal hidHandle As Integer, _
        ByVal writeHandle As Integer, _
        ByRef myDeviceDetected As Boolean, _
        ByRef readBuffer() As Byte, _
        ByRef success As Boolean)

    Friend Sub OnDeviceChange(ByVal m As Message)

        'Purpose    : Called when a WM_DEVICECHANGE message has arrived,
        '           : indicating that a device has been attached or removed.

        'Accepts    : m - a message with information about the device

        Debug.WriteLine("WM_DEVICECHANGE")

        Try
            If (m.WParam.ToInt32 = DBT_DEVICEARRIVAL) Then

                'If WParam contains DBT_DEVICEARRIVAL, a device has been attached.
                Debug.WriteLine("A device has been attached.")

                'Find out if it's the device we're communicating with.
                If MyDeviceManagement.DeviceNameMatch(m, MyDevicePathName) Then
                    Debug.WriteLine("My device attached")
                    lstResults.Items.Add("My device attached.")
                End If

            ElseIf (m.WParam.ToInt32 = DBT_DEVICEREMOVECOMPLETE) Then

                'If WParam contains DBT_DEVICEREMOVAL, a device has been removed.
                Debug.WriteLine("A device has been removed.")

                'Find out if it's the device we're communicating with.
                If MyDeviceManagement.DeviceNameMatch(m, MyDevicePathName) Then

                    Debug.WriteLine("My device removed")
                    lstResults.Items.Add("My device removed.")

                    'Set MyDeviceDetected False so on the next data-transfer attempt,
                    'FindTheHid() will be called to look for the device 
                    'and get a new handle.
                    frmMy.MyDeviceDetected = False
                End If
            End If

            Call ScrollToBottomOfListBox()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Function FindTheHid() As Boolean

        'Purpose    : Uses a series of API calls to locate a HID-class device
        '           ; by its Vendor ID and Product ID.

        'Returns    : True if the device is detected, False if not detected.

        Dim Count As Short
        Dim DeviceFound As Boolean
        Dim DevicePathName(127) As String
        Dim GUIDString As String
        Dim HidGuid As System.Guid
        Dim LastDevice As Boolean
        Dim MemberIndex As Integer
        Dim MyProductID As Short
        Dim MyVendorID As Short
        Dim Result As Boolean
        Dim Security As SECURITY_ATTRIBUTES
        Dim Success As Boolean

        Try

            HidGuid = Guid.Empty
            LastDevice = False
            MyDeviceDetected = False

            'Values for the SECURITY_ATTRIBUTES structure:
            Security.lpSecurityDescriptor = 0
            Security.bInheritHandle = CInt(True)
            Security.nLength = Len(Security)

            'Get the device's Vendor ID and Product ID from the form's text boxes.
            GetVendorAndProductIDsFromTextBoxes(myVendorID, myProductID)

            '***
            'API function: 'HidD_GetHidGuid

            'Purpose: Retrieves the interface class GUID for the HID class.

            'Accepts: 'A System.Guid object for storing the GUID.
            '***

            HidD_GetHidGuid(HidGuid)
            Debug.WriteLine(MyDebugging.ResultOfAPICall("GetHidGuid"))

            'Display the GUID.
            GUIDString = HidGuid.ToString
            Debug.WriteLine("  GUID for system HIDs: " & GUIDString)

            'Fill an array with the device path names of all attached HIDs.
            DeviceFound = myDeviceManagement.FindDeviceFromGuid _
                (HidGuid, _
                DevicePathName)

            'If there is at least one HID, attempt to read the Vendor ID and Product ID
            'of each device until there is a match or all devices have been examined.

            If DeviceFound = True Then
                MemberIndex = 0
                Do
                    '***
                    'API function:
                    'CreateFile

                    'Purpose:
                    'Retrieves a handle to a device.

                    'Accepts:
                    'A device path name returned by SetupDiGetDeviceInterfaceDetail
                    'The type of access requested (read/write).
                    'FILE_SHARE attributes to allow other processes to access the device while this handle is open.
                    'A Security structure. Using Null for this may cause problems under Windows XP.
                    'A creation disposition value. Use OPEN_EXISTING for devices.
                    'Flags and attributes for files. Not used for devices.
                    'Handle to a template file. Not used.

                    'Returns: a handle without read or write access.
                    'This enables obtaining information about all HIDs, even system
                    'keyboards and mice. 
                    'Separate handles are used for reading and writing.
                    '***

                    HIDHandle = CreateFile _
                        (DevicePathName(MemberIndex), _
                        0, _
                        FILE_SHARE_READ Or FILE_SHARE_WRITE, _
                        Security, _
                        OPEN_EXISTING, _
                        0, _
                        0)

                    Debug.WriteLine(MyDebugging.ResultOfAPICall("CreateFile"))
                    Debug.WriteLine("  Returned handle: " & Hex(HIDHandle) & "h")

                    If (HIDHandle <> INVALID_HANDLE_VALUE) Then

                        'The returned handle is valid, 
                        'so find out if this is the device we're looking for.

                        'Set the Size property of DeviceAttributes to the number of bytes in the structure.
                        myHID.DeviceAttributes.Size = Marshal.SizeOf(myHID.DeviceAttributes)

                        '***
                        'API function:
                        'HidD_GetAttributes

                        'Purpose:
                        'Retrieves a HIDD_ATTRIBUTES structure containing the Vendor ID, 
                        'Product ID, and Product Version Number for a device.

                        'Accepts:
                        'A handle returned by CreateFile.
                        'A pointer to receive a HIDD_ATTRIBUTES structure.

                        'Returns:
                        'True on success, False on failure.
                        '***

                        Result = HidD_GetAttributes(HIDHandle, myHID.DeviceAttributes)


                        Debug.WriteLine(MyDebugging.ResultOfAPICall("HidD_GetAttributes"))

                        If Result Then

                            Debug.WriteLine("  HIDD_ATTRIBUTES structure filled without error.")

                            Debug.WriteLine("  Structure size: " & MyHID.DeviceAttributes.Size)

                            Debug.WriteLine("  Vendor ID: " & Hex(MyHID.DeviceAttributes.VendorID))
                            Debug.WriteLine("  Product ID: " & Hex(MyHID.DeviceAttributes.ProductID))
                            Debug.WriteLine("  Version Number: " & Hex(MyHID.DeviceAttributes.VersionNumber))

                            'Find out if the device matches the one we're looking for.
                            If (MyHID.DeviceAttributes.VendorID = MyVendorID) And _
                                (MyHID.DeviceAttributes.ProductID = MyProductID) Then

                                'It's the desired device.
                                Debug.WriteLine("  My device detected")

                                'Display the information in form's list box.
                                lstResults.Items.Add("Device detected:")
                                lstResults.Items.Add("  Vendor ID= " & Hex(MyHID.DeviceAttributes.VendorID))
                                lstResults.Items.Add("  Product ID = " & Hex(MyHID.DeviceAttributes.ProductID))

                                Call ScrollToBottomOfListBox()

                                MyDeviceDetected = True

                                'Save the DevicePathName so OnDeviceChange() knows which name is my device.
                                MyDevicePathName = DevicePathName(MemberIndex)
                            Else

                                'It's not a match, so close the handle.
                                MyDeviceDetected = False

                                Result = CloseHandle(HIDHandle)

                                Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle"))
                            End If
                        Else
                            'There was a problem in retrieving the information. 
                            Debug.WriteLine("  Error in filling HIDD_ATTRIBUTES structure.")
                            MyDeviceDetected = False
                            Result = CloseHandle(HIDHandle)
                        End If
 
                    End If


                    'Keep looking until we find the device or there are no more left to examine.
                    MemberIndex = MemberIndex + 1

                Loop Until ((MyDeviceDetected = True) Or _
                    (MemberIndex = UBound(DevicePathName) + 1))
            End If

            If MyDeviceDetected Then

                'The device was detected.
                'Register to receive notifications if the device is removed or attached.
                Success = MyDeviceManagement.RegisterForDeviceNotifications _
                    (MyDevicePathName, _
                    frmMy.Handle, _
                    HidGuid, _
                    DeviceNotificationHandle)

                Debug.WriteLine("RegisterForDeviceNotifications = " & Success)

                'Learn the capabilities of the device.
                MyHID.Capabilities = MyHID.GetDeviceCapabilities _
                    (HIDHandle)

                If Success Then

                    'Find out if the device is a system mouse or keyboard.
                    HIDUsage = MyHID.GetHIDUsage(MyHID.Capabilities)

                    'Get and display the Input report buffer size.
                    GetInputReportBufferSize()
                    cmdInputReportBufferSize.Enabled = True

                    'Get handles to use in requesting Input and Output reports.

                    ReadHandle = CreateFile _
                        (MyDevicePathName, _
                        GENERIC_READ, _
                        FILE_SHARE_READ Or FILE_SHARE_WRITE, _
                        Security, _
                        OPEN_EXISTING, _
                        FILE_FLAG_OVERLAPPED, _
                        0)

                    Debug.WriteLine(MyDebugging.ResultOfAPICall("CreateFile, ReadHandle"))
                    Debug.WriteLine("  Returned handle: " & Hex(ReadHandle) & "h")

                    If (ReadHandle = INVALID_HANDLE_VALUE) Then

                        ExclusiveAccess = True
                        lstResults.Items.Add("The device is a system " + HIDUsage + ".")
                        lstResults.Items.Add("Windows 2000 and Windows XP obtain exclusive access to Input and Output reports for this devices.")
                        lstResults.Items.Add("Applications can access Feature reports only.")
                        Call ScrollToBottomOfListBox()

                    Else

                        WriteHandle = CreateFile _
                             (MyDevicePathName, _
                             GENERIC_WRITE, _
                             FILE_SHARE_READ Or FILE_SHARE_WRITE, _
                             Security, _
                             OPEN_EXISTING, _
                             0, _
                             0)

                        Debug.WriteLine(MyDebugging.ResultOfAPICall("CreateFile, WriteHandle"))
                        Debug.WriteLine("  Returned handle: " & Hex(WriteHandle) & "h")

                        '(optional)
                        'Flush any waiting reports in the input buffer.
                        MyHID.FlushQueue(ReadHandle)

                    End If

                End If

            Else

                'The device wasn't detected.
                lstResults.Items.Add("Device not found.")
                cmdInputReportBufferSize.Enabled = False
                cmdOnce.Enabled = True

                Debug.WriteLine(" Device not found.")

                Call ScrollToBottomOfListBox()
            End If
            Return MyDeviceDetected

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Function


    Private Sub cmdContinuous_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdContinuous.Click

        'Start or stop a series of periodic transfers.
        Try
            If cmdContinuous.Text = "Continuous" Then

                'Start doing periodic transfers.

                'Change the command button to "Cancel Continuous"
                cmdContinuous.Text = "Cancel Continuous"

                'Enable the timer event to trigger a set of transfers.
                tmrContinuousDataCollect.Enabled = True
                Call ReadAndWriteToDevice()
            Else

                'Stop doing continuous transfers.

                'Change the command button to "Continuous"
                cmdContinuous.Text = "Continuous"

                'Disable the timer that triggers the transfers.
                tmrContinuousDataCollect.Enabled = False
            End If

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub cmdInputReportBufferSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInputReportBufferSize.Click

        'Set the number of Input reports the host will store.
        Try
            Call SetInputReportBufferSize()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub cmdFindDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindDevice.Click

        'Search for a specific device.
        Try
            Call FindTheHid()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub cmdOnce_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOnce.Click

        'Attempt to write a report and read a report.

        Try
            'Don't allow another transfer request until this one completes.
            cmdOnce.Enabled = False

            Call ReadAndWriteToDevice()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub DeviceHasChanged()

        'Called if the user changes the Vendor ID or Product ID in the text box.
        Try
            'If a device was previously detected, stop receiving notifications about it.
            If MyDeviceDetected Then
                Call MyDeviceManagement.StopReceivingDeviceNotifications(DeviceNotificationHandle)
            End If

            'Search for the device the next time FindTheHid is called.
            MyDeviceDetected = False

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub ExchangeFeatureReports()

        'Purpose    : Sends a Feature report, then retrieves one.
        '           : Assumes report ID = 0 for both reports.

        Dim ByteValue As String
        Dim Count As Integer
        Dim InFeatureReportBuffer() As Byte
        Dim OutFeatureReportBuffer() As Byte
        Dim Success As Boolean

        Try
            Dim myInFeatureReport As New Hid.InFeatureReport()
            Dim myOutFeatureReport As New Hid.OutFeatureReport()

            If (MyHID.Capabilities.FeatureReportByteLength > 0) Then

                'The HID has a Feature report.

                'Set the size of the Feature report buffer. 
                'Subtract 1 from the value in the Capabilities structure because 
                'the array begins at index 0.

                ReDim OutFeatureReportBuffer(MyHID.Capabilities.FeatureReportByteLength - 1)

                'Store the report ID in the buffer:

                OutFeatureReportBuffer(0) = 0

                'Store the report data following the report ID.
                'Use the data in the combo boxes on the form.

                OutFeatureReportBuffer(1) = CByte(cboByte0.SelectedIndex)

                If UBound(OutFeatureReportBuffer) > 1 Then
                    OutFeatureReportBuffer(2) = CByte(cboByte1.SelectedIndex)
                End If

                'Write a report to the device
                Success = myOutFeatureReport.Write(OutFeatureReportBuffer, HIDHandle)

                If Success Then
                    lstResults.Items.Add("A Feature report has been written.")

                    Debug.WriteLine(" Feature Report ID: " & OutFeatureReportBuffer(0))
                    Debug.WriteLine(" Feature Report Data:")

                    'Display the report data sent in the form's list box.
                    lstResults.Items.Add(" Feature Report ID: " & OutFeatureReportBuffer(0))
                    lstResults.Items.Add(" Feature Report Data:")

                    'txtBytesReceived.Text = ""
                    For Count = 1 To UBound(OutFeatureReportBuffer)

                        'Add a leading zero to values from 0 to F.
                        If Len(Hex(OutFeatureReportBuffer(Count))) < 2 Then
                            ByteValue = "0" & Hex(OutFeatureReportBuffer(Count))
                        Else
                            ByteValue = Hex(OutFeatureReportBuffer(Count))
                        End If

                        Debug.WriteLine(" " & ByteValue)
                        lstResults.Items.Add(" " & ByteValue)

                    Next Count
                Else
                    lstResults.Items.Add("The attempt to write a Feature report has failed.")
                End If

                'Read a report from the device.

                'Set the size of the Feature report buffer. 
                'Subtract 1 from the value in the Capabilities structure because 
                'the array begins at index 0.

                If (MyHID.Capabilities.FeatureReportByteLength > 0) Then
                    ReDim InFeatureReportBuffer(MyHID.Capabilities.FeatureReportByteLength - 1)
                End If

                'Read a report.
                myInFeatureReport.Read _
                    (ReadHandle, _
                    HIDHandle, _
                    WriteHandle, _
                    MyDeviceDetected, _
                    InFeatureReportBuffer, _
                    Success)

                If Success Then
                    lstResults.Items.Add("A Feature report has been read.")
                    Debug.WriteLine(" Feature Report ID: " & InFeatureReportBuffer(0))
                    Debug.WriteLine(" Feature Report Data:")

                    'Display the report data received in the form's list box.
                    lstResults.Items.Add(" Feature Report ID: " & InFeatureReportBuffer(0))
                    lstResults.Items.Add(" Feature Report Data:")

                    txtBytesReceived.Text = ""
                    For Count = 1 To UBound(InFeatureReportBuffer)

                        'Add a leading zero to values from 0 to F.
                        If Len(Hex(InFeatureReportBuffer(Count))) < 2 Then

                            ByteValue = "0" & Hex(InFeatureReportBuffer(Count))
                        Else
                            ByteValue = Hex(InFeatureReportBuffer(Count))
                        End If

                        Debug.WriteLine(" " & ByteValue)
                        lstResults.Items.Add(" " & ByteValue)

                        'Display the received bytes in the "Received Bytes" text box.
                        txtBytesReceived.SelectionStart = Len(txtBytesReceived.Text)
                        txtBytesReceived.SelectedText = ByteValue & vbCrLf
                    Next Count
                Else
                    lstResults.Items.Add("The attempt to read a Feature report has failed.")
                End If

            Else
                lstResults.Items.Add("The HID doesn't have a Feature report.")
            End If

            Call ScrollToBottomOfListBox()

            cmdOnce.Enabled = True

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub ExchangeInputAndOutputReports()

        'Purpose    : Sends an Outputreport, then retrieves an Input report.
        '           : Assumes report ID = 0 for both reports.

        Dim ByteValue As String
        Dim Count As Integer
        Dim InputReportBuffer() As Byte
        Dim OutputReportBuffer() As Byte
        Dim Success As Boolean

        Try

            Success = False

            'Don't attempt to exchange reports if valid handles aren't available
            '(as for a mouse or keyboard under Windows 2000/XP.)

            If ((ReadHandle <> INVALID_HANDLE_VALUE) And (WriteHandle <> INVALID_HANDLE_VALUE)) Then

                'Don't attempt to send an Output report if the HID has no Output report.

                If (MyHID.Capabilities.OutputReportByteLength > 0) Then

                    'Set the size of the Output report buffer. 
                    'Subtract 1 from the value in the Capabilities structure because 
                    'the array begins at index 0.

                    ReDim OutputReportBuffer(MyHID.Capabilities.OutputReportByteLength - 1)

                    'Store the report ID in the first byte of the buffer:
                    OutputReportBuffer(0) = 0

                    'Store the report data following the report ID.
                    'Use the data in the combo boxes on the form.
                    OutputReportBuffer(1) = CByte(cboByte0.SelectedIndex)

                    If UBound(OutputReportBuffer) > 1 Then
                        OutputReportBuffer(2) = CByte(cboByte1.SelectedIndex)
                    End If

                    'Write a report.
                    If (chkUseControlTransfersOnly.Checked) = True Then

                        'Use a control transfer to send the report,
                        'even if the HID has an interrupt OUT endpoint.

                        Dim myOutputReport As New Hid.OutputReportViaControlTransfer
                        Success = myOutputReport.Write(OutputReportBuffer, WriteHandle)
                    Else
                        'If the HID has an interrupt OUT endpoint, use an interrupt transfer
                        'to send the report. Otherwise use a control transfer.

                        Dim myOutputReport As New Hid.OutputReport
                        Success = myOutputReport.Write(OutputReportBuffer, WriteHandle)
                    End If


                    If Success Then
                        lstResults.Items.Add("An Output report has been written.")

                        'Display the report data in the form's list box.
                        lstResults.Items.Add(" Output Report ID: " & OutputReportBuffer(0))
                        lstResults.Items.Add(" Output Report Data:")

                        txtBytesReceived.Text = ""
                        For Count = 1 To 2

                            'Add a leading zero to values from 0 to F.
                            If Len(Hex(OutputReportBuffer(Count))) < 2 Then

                                ByteValue = "0" & Hex(OutputReportBuffer(Count))
                            Else
                                ByteValue = Hex(OutputReportBuffer(Count))
                            End If

                            Debug.WriteLine(" Output Report ID: " & OutputReportBuffer(0))
                            Debug.WriteLine(" Output Report Data:")
                            Debug.WriteLine(" " & ByteValue)
                            lstResults.Items.Add(" " & ByteValue)

                        Next Count

                    Else
                        lstResults.Items.Add("The attempt to write an Output report has failed.")
                    End If

                Else
                    lstResults.Items.Add("The HID doesn't have an Output report.")
                End If

                'Read an Input report.

                Success = False

                'Don't attempt to send an Input report if the HID has no Input report.
                '(The HID spec requires all HIDs to have an interrupt IN endpoint,
                'which suggests that all HIDs must support Input reports.)

                If (MyHID.Capabilities.InputReportByteLength > 0) Then

                    'Set the size of the Input report buffer. 
                    'Subtract 1 from the value in the Capabilities structure because 
                    'the array begins at index 0.

                    ReDim InputReportBuffer(MyHID.Capabilities.InputReportByteLength - 1)

                    If (chkUseControlTransfersOnly.Checked = True) Then

                        'Read a report using a control transfer.

                        Dim myInputReport As New Hid.InputReportViaControlTransfer

                        'Read the report.
                        myInputReport.Read _
                            (ReadHandle, _
                            HIDHandle, _
                            WriteHandle, _
                            MyDeviceDetected, _
                            InputReportBuffer, _
                            Success)

                        If Success Then
                            lstResults.Items.Add("An Input report has been read.")


                            Debug.WriteLine(" Input Report ID: " & InputReportBuffer(0))
                            Debug.WriteLine(" Input Report Data:")

                            'Display the report data received in the form's list box.
                            lstResults.Items.Add(" Input Report ID: " & InputReportBuffer(0))
                            lstResults.Items.Add(" Input Report Data:")

                            txtBytesReceived.Text = ""
                            For Count = 1 To UBound(InputReportBuffer)

                                'Add a leading zero to values from 0 to F.
                                If Len(Hex(InputReportBuffer(Count))) < 2 Then

                                    ByteValue = "0" & Hex(InputReportBuffer(Count))
                                Else
                                    ByteValue = Hex(InputReportBuffer(Count))
                                End If

                                Debug.WriteLine(" " & ByteValue)
                                lstResults.Items.Add(" " & ByteValue)

                                'Display the received bytes in the "Received Bytes" text box.
                                txtBytesReceived.SelectionStart = Len(txtBytesReceived.Text)
                                txtBytesReceived.SelectedText = ByteValue & vbCrLf
                            Next Count
                        Else
                            lstResults.Items.Add("The attempt to read an Input report has failed.")

                        End If

                        Call ScrollToBottomOfListBox()

                        'Enable requesting another transfer.
                        cmdOnce.Enabled = True

                    Else

                        'Read a report using interrupt transfers.                
                        'To enable reading a report without blocking the main thread, this
                        'application uses an asynchronous delegate.

                        Dim ar As IAsyncResult
                        Dim myInputReport As New Hid.InputReport

                        'Define a delegate for the Read method of myInputReport.
                        Dim MyReadInputReportDelegate As _
                            New ReadInputReportDelegate(AddressOf myInputReport.Read)

                        'The BeginInvoke method calls myInputReport.Read to attempt to read a report.
                        'The method has the same parameters as the Read function,
                        'plus two additional parameters:
                        'GetInputReportData is the callback procedure that executes when the Read function returns.
                        'MyReadInputReportDelegate is the asynchronous delegate object.
                        'The last parameter can optionally be an object passed to the callback.
                        ar = MyReadInputReportDelegate.BeginInvoke _
                            (ReadHandle, _
                            HIDHandle, _
                            WriteHandle, _
                            MyDeviceDetected, _
                            InputReportBuffer, _
                            Success, _
                            New AsyncCallback(AddressOf GetInputReportData), _
                            MyReadInputReportDelegate)
                    End If

                Else
                    lstResults.Items.Add("No attempt to read an Input report was made.")
                    lstResults.Items.Add("The HID doesn't have an Input report.")
                End If
            Else
                lstResults.Items.Add("Invalid handle. The device is probably a system mouse or keyboard.")
                lstResults.Items.Add("No attempt to write an Output report or read an Input report was made.")

            End If

            Call ScrollToBottomOfListBox()

            'Enable requesting another transfer.
            cmdOnce.Enabled = True

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed

        Try
            'Perform shutdown operations.
            Call Shutdown()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'Perform startup operations.

        Try
            frmMy = Me
            frmMain.DefInstance.Show()
            Call Startup()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub GetInputReportBufferSize()

        'Purpose    : Finds and displays the number of Input buffers
        '           : (the number of Input reports the host will store). 

        Dim NumberOfInputBuffers As Integer

        Try
            'Get the number of input buffers.
            MyHID.GetNumberOfInputBuffers _
                (HIDHandle, _
                NumberOfInputBuffers)

            'Display the result in the text box.
            txtInputReportBufferSize.Text = CStr(NumberOfInputBuffers)

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub GetInputReportData(ByVal ar As IAsyncResult)

        'Purpose    : Retrieves Input report data and status information.
        '           : This routine is called automatically when myInputReport.Read
        '           : returns.

        'Accepts    : ar - an object containing status information about 
        '           : the asynchronous operation.    

        Dim ByteValue As String
        Dim Count As Integer
        Dim InputReportBuffer As Byte()
        Dim ReadResult As String
        Dim Success As Boolean

        Try

            'Define a delegate using the IAsyncResult object.
            Dim deleg As ReadInputReportDelegate = _
                DirectCast(ar.AsyncState, ReadInputReportDelegate)

            'Get the IAsyncResult object and the values of other paramaters that the
            'BeginInvoke method passed ByRef.
            deleg.EndInvoke(MyDeviceDetected, InputReportBuffer, Success, ar)

            'Display the received report data in the form's list box.
            If (ar.IsCompleted And Success) Then

                lstResults.Items.Add("An Input report has been read.")


                Debug.WriteLine(" Input Report ID: " & InputReportBuffer(0))
                Debug.WriteLine(" Input Report Data:")

                lstResults.Items.Add(" Input Report ID: " & InputReportBuffer(0))
                lstResults.Items.Add(" Input Report Data:")

                txtBytesReceived.Text = ""
                For Count = 1 To UBound(InputReportBuffer)

                    'Add a leading zero to values from 0 to F.
                    If Len(Hex(InputReportBuffer(Count))) < 2 Then

                        ByteValue = "0" & Hex(InputReportBuffer(Count))
                    Else
                        ByteValue = Hex(InputReportBuffer(Count))
                    End If

                    Debug.WriteLine(" " & ByteValue)
                    lstResults.Items.Add(" " & ByteValue)

                    'Display the report data in the "Received Data" text box.
                    txtBytesReceived.SelectionStart = Len(txtBytesReceived.Text)
                    txtBytesReceived.SelectedText = ByteValue & vbCrLf
                Next Count

            Else
                lstResults.Items.Add("The attempt to read an Input report has failed.")
                Debug.Write("The attempt to read an Input report has failed")
            End If

            Call ScrollToBottomOfListBox()

            'Enable requesting another transfer.
            cmdOnce.Enabled = True

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub GetVendorAndProductIDsFromTextBoxes _
        (ByRef myVendorID As Short, _
        ByRef myProductID As Short)

        'Purpose    : Retrieves a Vendor ID and Product ID in hexadecimal 
        '           : from the form's text boxes and converts the text to Shorts.

        'Accepts    : myVendorID - the Vendor ID as a Short.
        '           : myProductID - the Product ID as a Short.                    

        Try
            myVendorID = CShort(Val("&h" & txtVendorID.Text))
            myProductID = CShort(Val("&h" & txtProductID.Text))

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub InitializeDisplay()

        'Purpose    : Initialize the elements on the form.

        Dim Count As Short
        Dim ByteValue As String

        Try
            'Create a dropdown list box for each byte to send in a report.
            'Add a leading zero for values from 0 to F.
            For Count = 0 To 255
                If Len(Hex(Count)) < 2 Then
                    ByteValue = "0" & Hex(Count)
                Else
                    ByteValue = Hex(Count)
                End If
                frmMain.DefInstance.cboByte0.Items.Insert(Count, ByteValue)
            Next Count

            For Count = 0 To 255
                If Len(Hex(Count)) < 2 Then
                    ByteValue = "0" & Hex(Count)
                Else
                    ByteValue = Hex(Count)
                End If
                frmMain.DefInstance.cboByte1.Items.Insert(Count, ByteValue)
            Next Count

            'Select a default value for each box
            frmMain.DefInstance.cboByte0.SelectedIndex = 0
            frmMain.DefInstance.cboByte1.SelectedIndex = 128

            'Check the autoincrement box to increment the values each time a report is sent.
            chkAutoincrement.CheckState = System.Windows.Forms.CheckState.Checked

            'Don't allow the user to select an input report buffer size until there is
            'a handle to a HID.
            cmdInputReportBufferSize.Enabled = False

            If MyHID.IsWindowsXpOrLater() Then

                chkUseControlTransfersOnly.Enabled = True

            Else
                'If the operating system is earlier than Windows XP,
                'disable the option to force Input and Output reports to use control transfers
                '(not supported).
                chkUseControlTransfersOnly.Enabled = False
            End If

            lstResults.Items.Add("For a more detailed event log, view debug statements in Visual Studio's Output window:")
            lstResults.Items.Add("Click Build > Configuration Manager > Active Solution Configuration > Debug.")
            lstResults.Items.Add("Then click View > Other Windows > Output.")
            lstResults.Items.Add("")
        Catch ex As Exception
        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub ReadAndWriteToDevice()

        'Purpose    : Initiates the exchanging of reports. 
        '           : The application sends a report and requests to read a report.

        'Report header for the debug display:
        Debug.WriteLine("")
        Debug.WriteLine("***** HID Test Report *****")
        Debug.WriteLine(Today & ": " & TimeOfDay)

        Try
            'If the device hasn't been detected, was removed, or timed out on a previous attempt
            'to access it, look for the device.
            If (MyDeviceDetected = False) Then

                MyDeviceDetected = FindTheHid()
            End If

            If (MyDeviceDetected = True) Then

                'Get the bytes to send in a report from the combo boxes.
                'Increment the values if the autoincrement check box is selected.
                If chkAutoincrement.CheckState = 1 Then
                    If cboByte0.SelectedIndex < 255 Then
                        cboByte0.SelectedIndex = cboByte0.SelectedIndex + 1
                    Else
                        cboByte0.SelectedIndex = 0
                    End If
                    If cboByte1.SelectedIndex < 255 Then
                        cboByte1.SelectedIndex = cboByte1.SelectedIndex + 1
                    Else
                        cboByte1.SelectedIndex = 0
                    End If
                End If

                'An option button selects whether to exchange Input and Output reports
                'or Feature reports.

                If (optInputOutput.Checked = True) Then

                    Call ExchangeInputAndOutputReports()

                Else

                    Call ExchangeFeatureReports()

                End If

            End If

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub

    Private Sub ScrollToBottomOfListBox()

        Try
            Dim count As Integer

            'Scroll to the bottom of the list box.

            lstResults.SelectedIndex = lstResults.Items.Count - 1

            'If the list box is getting too large, trim its contents.

            If lstResults.Items.Count > 1000 Then

                For count = 1 To 800
                    lstResults.Items.RemoveAt(count)
                Next count

            End If

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub

    Private Sub SetInputReportBufferSize()

        'Purpose    : Set the number of Input buffers (the number of Input reports 
        '           : the host will store) from the value in the text box.

        Dim NumberOfInputBuffers As Integer

        Try
            'Get the number of buffers from the text box.
            NumberOfInputBuffers = CInt(Val(txtInputReportBufferSize.Text))

            'Set the number of buffers.
            MyHID.SetNumberOfInputBuffers _
                (HIDHandle, _
                NumberOfInputBuffers)

            'Verify and display the result.
            GetInputReportBufferSize()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub Shutdown()

        'Purpose    : Perform actions that must execute when the program ends.

        Try
            'Close open handles to the device.

            If (HIDHandle <> 0) Then
                CloseHandle(HIDHandle)
                Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle (HIDHandle)"))
            End If

            If (ReadHandle <> 0) Then
                CloseHandle(ReadHandle)
                Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle (ReadHandle)"))
            End If

            If (WriteHandle <> 0) Then
                CloseHandle(WriteHandle)
                Debug.WriteLine(MyDebugging.ResultOfAPICall("CloseHandle (WriteHandle)"))
            End If

            'Stop receiving notifications.

            Call MyDeviceManagement.StopReceivingDeviceNotifications(DeviceNotificationHandle)

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub Startup()

        'Purpose    : Perform actions that must execute when the program starts.

        Try
            MyHID = New Hid()
            Call InitializeDisplay()
            tmrContinuousDataCollect.Enabled = False
            tmrContinuousDataCollect.Interval = 1000

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Private Sub tmrContinuousDataCollect_Tick _
        (ByVal eventSender As System.Object, _
        ByVal eventArgs As System.EventArgs) _
        Handles tmrContinuousDataCollect.Tick

        Try
            'Exchange data with the device.
            'The timer is enabled only if cmdContinous has been clicked, 
            'selecting continous (periodic) transfers.
            Call ReadAndWriteToDevice()
        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub txtProductID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProductID.TextChanged

        'The Product ID has changed in the text box.

        Try
            Call DeviceHasChanged()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try
    End Sub


    Private Sub txtVendorID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVendorID.TextChanged

        'The Vendor ID has changed in the text box.

        Try
            Call DeviceHasChanged()

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Protected Overrides Sub WndProc(ByRef m As Message)

        'Purpose    : Overrides WndProc to enable checking for and handling
        '           : WM_DEVICECHANGE(messages)

        'Accepts    : m - a Windows Message                   

        Try
            'The OnDeviceChange routine processes WM_DEVICECHANGE messages.
            If m.Msg = WM_DEVICECHANGE Then
                OnDeviceChange(m)
            End If

            'Let the base form process the message.
            MyBase.WndProc(m)

        Catch ex As Exception
            Call HandleException(Me.Name, ex)
        End Try

    End Sub


    Shared Sub HandleException(ByVal moduleName As String, ByVal e As Exception)

        'Purpose    : Provides a central mechanism for exception handling.
        '           : Displays a message box that describes the exception.

        'Accepts    : moduleName - the module where the exception occurred.
        '           : e - the exception

        Dim Message As String
        Dim Caption As String

        Try
            'Create an error message.
            Message = "Exception: " & e.Message & ControlChars.CrLf & _
            "Module: " & moduleName & ControlChars.CrLf & _
            "Method: " & e.TargetSite.Name

            'Specify a caption.
            Caption = "Unexpected Exception"

            'Display the message in a message box.
            MessageBox.Show(Message, Caption, MessageBoxButtons.OK)
            Debug.Write(Message)

        Finally
        End Try

    End Sub

    Private Sub lstResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub
End Class