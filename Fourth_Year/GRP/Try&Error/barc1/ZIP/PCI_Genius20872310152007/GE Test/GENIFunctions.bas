Attribute VB_Name = "GENIFunctions"
Option Explicit
' ############################################################################
' The following list of constants is the set of possible return codes from all
' calls to this module.  Of course, not all return codes will be returned by
' all calls, but the caller must be prepared to deal with the entire set.
'
Public Const GENI_NoError                                                       As Integer = 0
' Device is OK
Private Const GENI_NotOK                                                        As Integer = -1

' Device is not OK
Private Const GENI_Busy                                                         As Integer = -2

' Device is busy; command cannot be accepted
Private Const GENI_BadDeviceReference                                           As Integer = -3

' Device not in [0..3]
Private Const GENI_BadOutputsControlRef                                         As Integer = -4

' Outputs control not in [enabled, disabled]
Private Const GENI_BadBaudRateReference                                         As Integer = -5

' Baud rate invalid
Private Const GENI_BadSBAReference                                              As Integer = -6

' SBA not in [0..31]
Private Const GENI_BadCommandSyntax                                             As Integer = -7

' Syntax error detected in command block
Private Const GENI_CommandProcessingError                                       As Integer = -8

' Processing error encountered with command block
Private Const GENI_CommandTimeout                                               As Integer = -9

' Timeout error declared during command processing
Private Const GENI_NoDevice                                                     As Integer = -10

' No device at SBA
Private Const GENI_InappropriateDevice                                          As Integer = -11

' Device type not appropriate for request
Private Const GENI_BadReplyLength                                               As Integer = -12

' Datagram reply length different than expected
Private Const GENI_BadCircuitReference                                          As Integer = -13

' Circuit reference <1 or > maximum supported
Private Const GENI_IOTable_Lockout_Failure                                      As Integer = -14

' I/O table lockout semaphore failure
Private Const GENI_OutputsNotEnabled                                            As Integer = -15

' Outputs must be enabled to write to device
Private Const GENI_CannotEnableOutputs                                          As Integer = -16

' Another controller already assigned to device
Private Const GENI_UnknownError                                                 As Integer = -99

' Unexpected error encountered
' ----------------------------------------------------------------------------
' ############################################################################
' The following list of constants is the set of possible model numbers for
' devices which may be encountered on the Genius bus.
'
'' Hand-held monitors
Private Const DevType_HHM_PhaseA                                                As Integer = 2 ' [IC660HHM500]

Private Const DevType_HHM                                                       As Integer = 5 ' [IC660HHM501]

'' 8 circuit discrete blocks
Private Const DevType_Circ_8_115VAC_Grouped_PhaseA                              As Integer = 64 ' [IC660CBD100]

Private Const DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA                      As Integer = 65 ' [IC660CBS100]

Private Const DevType_Circ_8_115VAC_2A_Grouped                                  As Integer = 69 ' [IC660BBD100]

Private Const DevType_Circ_8_115VAC_125VDC_Isolated                             As Integer = 70 ' [IC660BBS100 / IC660BBS101]

Private Const DevType_Circ_8_220VAC_Grouped                                     As Integer = 71 ' [IC660??????]

Private Const DevType_Circ_8_115VAC_LowLeakage_Grouped                          As Integer = 82 ' [IC660BBD101]

'' 16 circuit discrete blocks
Private Const DevType_Circ_16_24VDC_48VDC_Sink_PhaseA                           As Integer = 67 ' [IC660CBD021]

Private Const DevType_Circ_16_24VDC_48VDC_Source_PhaseA                         As Integer = 68 ' [IC660CBD020]

Private Const DevType_Circ_16_24VDC_48VDC_Sink                                  As Integer = 72 ' [IC660BBD021 / IC660BBD023]

Private Const DevType_Circ_16_12VDC_24VDC_48VDC_Source                          As Integer = 73 ' [IC660BBD020 / IC660BBD022]

Private Const DevType_Circ_16_Normally_Open_Relay                               As Integer = 79 ' [IC660BBR101]

Private Const DevType_Circ_16_Normally_Closed_Relay                             As Integer = 80 ' [IC660BBR100]

Private Const DevType_Circ_16_115VAC_Input                                      As Integer = 81 ' [IC660BBD110]

'' 32 circuit discrete blocks
Private Const DevType_Circ_32_5VDC_12VDC_24VDC_Sink                             As Integer = 74 ' [IC660BBD025]

Private Const DevType_Circ_32_12VDC_24VDC_Source                                As Integer = 75 ' [IC660BBD024]

'' 4 input / 2 output analog blocks
Private Const DevType_Voltage_Current_4in_2out_Analog_115VAC                    As Integer = 131 ' [IC660BBA100]

Private Const DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC               As Integer = 132 ' [IC660BBA020]

Private Const DevType_Voltage_Current_4in_2out_Analog_115VAC_PhaseA             As Integer = 128 ' [IC660CBA100]

Private Const DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC_PhaseA        As Integer = 129 ' [IC660CBA020]

Private Const DevType_Current_Source_4in_2out_Analog_115VAC_125VDC              As Integer = 140 ' [IC660BBA104]

Private Const DevType_Current_Source_4in_2out_Analog_24VDC_48VDC                As Integer = 141 ' [IC660BBA024]

'' 6 output analog blocks
Private Const DevType_Current_Source_6out_Analog_115VAC_125VDC                  As Integer = 142 ' [IC660BBA105]

Private Const DevType_Current_Source_6out_Analog_24VDC_48VDC                    As Integer = 143 ' [IC660BBA025]

'' 6 input analog blocks
Private Const DevType_Current_Source_6in_Analog_115VAC_125VDC                   As Integer = 144 ' [IC660BBA106]

Private Const DevType_Current_Source_6in_Analog_24VDC_48VDC                     As Integer = 145 ' [IC660BBA026]

'' 6 input thermocouple blocks
Private Const DevType_6in_Thermocouple_115VAC_125VDC                            As Integer = 134 ' [IC660BBA103]

Private Const DevType_6in_Thermocouple_24VDC_48VDC                              As Integer = 135 ' [IC660BBA023]

'' 6 input RTD blocks
Private Const DevType_6in_RTD_115VAC_125VDC                                     As Integer = 136 ' [IC660BBA101]

Private Const DevType_6in_RTD_24VDC_48VDC                                       As Integer = 137 ' [IC660BBA021]

'' High speed counter (types A,B,C) block
Private Const DevType_High_Speed_Counter                                        As Integer = 32 ' [IC660BBD120]

'' PowerTRAC block
Private Const DevType_PowerTRAC                                                 As Integer = 127 ' [IC660BPM100]

'' Series 6 Bus Controllers
Private Const DevType_Series_6_Bus_Controller_PhaseA                            As Integer = 1 ' [IC660CBB900]

Private Const DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA                 As Integer = 3 ' [IC660CBB901]

Private Const DevType_Series_6_Bus_Controller                                   As Integer = 6 ' [IC660CBB902]

Private Const DevType_Series_6_Bus_Controller_Wout_Diags                        As Integer = 7 ' [IC660CBB903]

'' Series 90 Bus Controllers
Private Const DevType_Series_9070_Bus_Controller                                As Integer = 10 ' [IC697BEM731]

Private Const DevType_Series_9030_Bus_Controller                                As Integer = 15 ' [IC693BEM331]

'' Series 90-70 Remote I/O Scanner
Private Const DevType_Series_9070_Remote_IO_Scanner                             As Integer = 160 ' [IC697BEM733]

'' Series 90-30 Global Data communications modules
Private Const DevType_Series_9030_Communications_Module                         As Integer = 13 ' [IC693CMM301]

Private Const DevType_Series_9030_Enhanced_Communications_Module                As Integer = 14 ' [IC693CMM302]

'' Field Control Genius Bus Interface Unit
Private Const DevType_FieldControl_GBIU                                         As Integer = 160 ' [IC670GBI001]

'' VersaMax Genius Bus Interface Unit
Private Const DevType_VersaMax_GBIU                                             As Integer = 161 ' [IC200GBI001]

'' ISA-bus and PCI-bus GENI type devices
Private Const DevType_GENI                                                      As Integer = 4

'' [IC660ELB9xx]
' ----------------------------------------------------------------------------
' ############################################################################
' Caution:  The following structure MUST be defined as byte-aligned, not word-
'            aligned.  The structure order cannot be altered.
'
' The GENI_SETUP structure defines the PCGEN setup structure portion of
' dual port RAM.  It is exposed to the user for both read and write purposes.
' See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
Public Type GENI_SETUP
    configuration_register_settings                                                 As Byte
' SBA, baud rate, outputs disable
    reference_address                                                               As Integer
' Reference address
    broadcast_control_data_length                                                   As Byte
' Global data broadcast amount
    directed_control_data_length                                                    As Byte
' Directed data amount accepted
    io_buffer_length                                                                As Byte
' Size of (all) I/O buffers
    reserved(10)                                                                    As Byte
End Type
' ----------------------------------------------------------------------------
' ############################################################################
' Caution:  The following structure MUST be defined as byte-aligned, not word-
'            aligned.  The structure order cannot be altered.
'
' The GENI_STATUS structure defines the PCGEN status structure portion of
' dual port RAM.  It is exposed to the user for read purposes.
' See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
Public Type GENI_STATUS
    firmware_revision                                                               As Byte
' PCGEN firmware revision
    ok_status                                                                       As Byte
' Both board status & heartbeat indicator
    hardware_status                                                                 As Byte
' Error flags to explain "not ok" status
    bus_status                                                                      As Byte
' Warning flag for excessive bus errors
    bus_error_count                                                                 As Integer
' Total bus errors since PCGEN reset
    bus_scan_time                                                                   As Integer
' Time between last two bus cycles
    reserved(8)                                                                     As Byte
End Type

Private Const GENI_OK                                                           As Integer = 1
' Mask for OK bit in "ok_status"

' ----------------------------------------------------------------------------
' ############################################################################
' Caution:  The following structure MUST be defined as byte-aligned, not word-
'            aligned.  The structure order cannot be altered.
'
' The DEVICE_CONFIG structure defines the makeup of each of 32 structures (one
' for each of 32 SBA's) in dual port RAM.  It is exposed to the user for read
' purposes for the entire structure except "Outputs Enable", which is both read
' and write.
' See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
Public Type DEVICE_CONFIG
    model_number                                                                    As Byte
' Device model number
    outputs_disable                                                                 As Byte
' Outputs disable for device
    device_present                                                                  As Byte
' Device present and logged in
    reference_address                                                               As Integer
' Device reference address
    broadcast_control_data_length                                                   As Byte
' Inputs / global data broadcast
    directed_control_data_length                                                    As Byte
' Control data device expects
    block_config                                                                    As Byte
' Inputs only, outputs only or combo
End Type
' ----------------------------------------------------------------------------
' ############################################################################
' Caution:  The following structure MUST be defined as byte-aligned, not word-
'            aligned.  The structure order cannot be altered.
'
' The REQUEST_Q_ENTRY structure is used in processing the receipt of memory
' access datagrams.  It is not currently supported in this module...
' See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
Public Type REQUEST_Q_ENTRY
    COMMAND                                                                         As Byte
    status                                                                          As Byte
    data_length                                                                     As Byte
    host_memory_map(3)                                                              As Byte
    source_device                                                                   As Byte
    aux_source_address                                                              As Byte
    Data(128)                                                                       As Byte
End Type
' ----------------------------------------------------------------------------
' ############################################################################
' The DEVICE_DATA structure defines the makeup of the I/O data for each of the
' possible Genius blocks.
'
' @@ ONLY DISCRETE blocks, 4IN/2OUT ANALOG BLOCKS and GENI-based device global
'    data ARE CURRENTLY DEFINED HERE!!!!!
'
' See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'
' ANALOG_4IN_2OUT ' 4 input / 2 output analog blocks
'    analog_inputs(4) As Integer
'    analog_outputs(2) As Integer
'
'        discrete_blocks(4) As Byte ' 8, 16 & 32 circuit discrete blocks
'        Analog4In2Out As ANALOG_4IN_2OUT ' 4 input / 2 output analog blocks (Was a C++ type struct and Union)
'        broadcast_global_data(128) As Byte ' input from global data producing device
'        directed_control_data(128) As Byte ' directed control inputs in PCI Genius card
' Only care about global data in this application so that's all I defined.  If anything else is desired
'   then just define it and convert the format to or dump the format into the 128 bytes defined.
'   128 Bytes is the maximum, but memory allocation must be 128 bytes irregardless of what is needed.
Public Type DEVICE_DATA
    block_type                                                                      As Byte
    broadcast_global_data(128)                                                      As Byte
' input from global data producing device
End Type

Private Const MAX_CARDS_SUPPORTED                                               As Integer = 4

' PCGEN driver can support up to 4 cards
Public Enum GENI_Outputs
    OutputsEnabled = &H0  ' Outputs enabled for all bus devices
    Outputsdisabled = &H80 ' Outputs disabled for all bus devices
End Enum
#If False Then 'Trick preserves Case of Enums when typing in IDE
Private OutputsEnabled, Outputsdisabled

#End If
' Enumeration used to set PCGEN card bus baud rate during a call to some of
' the class contructors or to the CardSetup function.
Public Enum GENI_BaudRate
    Baud_153p6kEXT = &H0  ' 153.6k extended
    Baud_38p4k = &H20 ' 38.4k
    Baud_76p8k = &H40 ' 76.8k
    baud_153p6kstd = &H60 ' 153.6k standard
End Enum
#If False Then 'Trick preserves Case of Enums when typing in IDE
Private Baud_153p6kEXT, Baud_38p4k, Baud_76p8k, baud_153p6kstd

#End If
'## PCGEN Status Register masks
Private Const COMM_OK_LED                                                       As Byte = &H10
 ' bit b4, 0001_0000

Private Const GENI_OK_LED                                                       As Byte = &H8
 ' bit b3, 0000_1000

Private Const WatchDogStatus                                                    As Byte = &H2
 ' bit b1, 0000_0010

Private Const ResetDetect                                                       As Byte = &H1
 ' bit b0, 0000_0001

Private Const FILE_DEVICE_UNKNOWN                                               As Integer = 34
 'Public Const FILE_DEVICE_UNKNOWN = &H22

Private Const METHOD_BUFFERED                                                   As Long = 0

'PCI Genius card commands
'Declare IOCTL variables to Mimic C++ Macros with CTL_CODE Function
Private IOCTL_GEGENIUS_READ_PORT                                                As Long

Private IOCTL_GEGENIUS_WRITE_PORT                                               As Long

Private IOCTL_GEGENIUS_MAP_MEMORY                                               As Long

Private IOCTL_GEGENIUS_UNMAP_MEMORY                                             As Long

'Use these statements for API DeviceIOControl functions
'IOCTL_GEGENIUS_READ_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H910, METHOD_BUFFERED, FILE_READ_ACCESS)
'IOCTL_GEGENIUS_WRITE_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H911, METHOD_BUFFERED, FILE_WRITE_ACCESS)
'IOCTL_GEGENIUS_MAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H912, METHOD_BUFFERED, FILE_ANY_ACCESS)
'IOCTL_GEGENIUS_UNMAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H913, METHOD_BUFFERED, FILE_ANY_ACCESS)

Private Const MAX_PATH                                                          As Long = 260

Private Const INVALID_HANDLE_VALUE                                              As Long = -1

Private Const ERROR_FILE_NOT_FOUND                                              As Long = 2

'###############################################################################
'## The GENPORT_WRITE_INPUT structure defines the interface for reading/writing
'## one of the 3 PCGEN hardware registers:  configuration, status And control.
'##
'## See GFK-2342, "PCI Genius Card Quick Install Guide" for details.
'##
'Contents of GENPORT_WRITE_INPUT_WriteData
'LongData As Long - Maximum Size
'ShortData As Integer
'CharData As Byte
Public Type GENPORT_WRITE_INPUT
    PortNumber                                                                      As Long
    '## Port # to be accessed
    WriteData                                                                       As Long
    '## Data to be read from / written to port
End Type  'GENPORT_WRITE_INPUT
'## ----------------------------------------------------------------------------
'## PCGEN Register Offsets
Private Const CONFIG_REG                                                        As Integer = 0
 '## configuration register

Private Const STATUS_REG                                                        As Integer = 1
 '## status register

Private Const CONTROL_REG                                                       As Integer = 2
 '## control register

'## ----------------------------------------------------------------------------
'###############################################################################
'## Caution:  The following structure MUST be defined as byte-aligned, not word-
'##             aligned.  The structure order cannot be altered.
'##
'##
'## The COMMAND portion of PCGEN dual-port RAM is used for the processing of
'## datagrams.  The current intent is to shield the user from the nuances of
'## datagrams, which can be rather complex.  Should this portion of dual-port RAM
'## need to be exposed to the user, then the structure definitions would need to
'## moved to PCGEN.h
'##
'## @@ Have not yet added support for the "Change Configuration" datagram...
'##
' Content of COMMAND_OPTIONS
'       read_datagram_options As READ_DATAGRAM
'       xmit_datagram_options As TRANSMIT_DATAGRAM
'       xmit_with_reply_datagram_options As TRANSMIT_DATAGRAM_WITH_REPLY
'       OPTIONS(14) - Maximum Size
Public Type COMMAND
    status                                                                          As Byte
    'Initiation of command + command status
    COMMAND                                                                         As Byte
    'Command type (read, xmit, xmit w/reply, cfg change)
    OPTIONS(14)                                                                     As Byte
    'maximum size
End Type    'COMMAND

'## Bit masks used in processing datagrams
Private Const CMDMASK                                                           As Long = &H3F
Private Const FLGMASK                                                           As Long = &H80
Private Const FREEBLK                                                           As Long = &H0
Private Const INCOMECMD                                                         As Long = &H1
Private Const INPROGRESS                                                        As Long = &H2
Private Const CCOMPLETE                                                         As Long = &H4
Private Const SYNTAXERR                                                         As Long = &H8
Private Const PROCERR                                                           As Long = &H10

'## Command types
Private Const READ_DATAGRAM                                                     As Integer = 1
Private Const XMIT_DATAGRAM                                                     As Integer = 2
Private Const XMIT_DATAGRAM_WITH_REPLY                                          As Integer = 3
Private Const CHANGE_CONFIG                                                     As Integer = 4

'## Command function codes
Private Const GEF_DATAGRAM                                                      As Long = &H20

'## Command Sub-function codes
Private Const SF_READ_ID                                                        As Long = &H0
Private Const SF_READ_ID_REPLY                                                  As Long = &H1
Private Const SF_READ_CONFIG                                                    As Long = &H2
Private Const SF_READ_CONFIG_REPLY                                              As Long = &H3
Private Const SF_WRITE_CONFIG                                                   As Long = &H4
Private Const SF_ASSIGN_MONITOR                                                 As Long = &H5
Private Const SF_BEGIN_PACKET_SEQUENCE                                          As Long = &H6
Private Const SF_END_PACKET_SEQUENCE                                            As Long = &H7
Private Const SF_READ_DIAGS                                                     As Long = &H8
Private Const SF_READ_DIAGS_REPLY                                               As Long = &H9
Private Const SF_WRITE_POINT                                                    As Long = &HB
Private Const SF_READ_BLOCK_IO                                                  As Long = &HC
Private Const SF_READ_BLOCK_IO_REPLY                                            As Long = &HD
Private Const SF_REPORT_FAULT                                                   As Long = &HF
Private Const SF_PULSE_TEST                                                     As Long = &H10
Private Const SF_PULSE_TEST_COMPLETE                                            As Long = &H11
Private Const SF_CLEAR_CIRCUIT_FAULT                                            As Long = &H12
Private Const SF_CLEAR_ALL_CIRCUIT_FAULTS                                       As Long = &H13
Private Const SF_SWITCH_BSM                                                     As Long = &H1C
Private Const SF_READ_DEVICE                                                    As Long = &H1E
Private Const SF_READ_DEVICE_REPLY                                              As Long = &H1F
Private Const SF_WRITE_DEVICE                                                   As Long = &H20
Private Const SF_CONFIG_CHANGE                                                  As Long = &H22
Private Const SF_READ_DATA                                                      As Long = &H27
Private Const SF_READ_DATA_REPLY                                                As Long = &H28
Private Const SF_READ_MAP                                                       As Long = &H2A
Private Const SF_READ_MAP_REPLY                                                 As Long = &H2B
Private Const SF_WRITE_MAP                                                      As Long = &H2C
Private Const SF_ASSIGN_SBA29_HOT_STANDBY                                       As Long = &H2D

'## Transmit datagram priorities
Private Const NORMAL_PRIORITY                                                   As Integer = 0
Private Const HIGH_PRIORITY                                                     As Integer = 1

'## ----------------------------------------------------------------------------
'###############################################################################
'## Caution:  The following structure MUST be defined as byte-aligned, not word-
'##             aligned.  The structure order cannot be altered.
'##
'##
'## This is the master structure definition of the PCGEN dual-port RAM.  The
'## current intent is to shield the user from dealing directly with dual-port RAM.
'## Should dual-port RAM need to be exposed to the user, then the structure
'## definitions would need to move to PCGEN.h
'##
Public Type Shared_RAM_Interface
    request_q(15)                                                                   As REQUEST_Q_ENTRY
 ' Incoming datagram queue
    queue_head_ptr                                                                  As Byte
    ' Entry currently being read
    queue_tail_ptr                                                                  As Byte
    ' Most recent entry in queue
    Setup                                                                           As GENI_SETUP
 ' PCGEN card setup data
    status                                                                          As GENI_STATUS
 ' PCGEN card status data
    interrupt_status(15)                                                            As Byte
    ' Current interrupt status
    interrupt_disable(15)                                                           As Byte
    ' Enable/disable host interrupts
    command_block                                                                   As COMMAND
 ' Outgoing datagram
    transmit_datagram_buffer(239)                                                   As Byte
    ' Temporary xmit datagram buffer
    read_datagram_buffer(133)                                                       As Byte
    ' Read access to recd datagram
    iotable_lockout_request                                                         As Byte
    ' Set/release I/O table lockout
    iotable_lockout_state                                                           As Byte
    ' Actual lockout state
    host_clear                                                                      As Byte
    ' Clear interrupts from host
    reserved_1(63)                                                                  As Byte
    ' Reserved area
    aux_request_q(47)                                                               As Byte
    ' Used with datagram request queue
    heartbeat_enable                                                                As Integer
 ' Enable host/PCGEN heartbeat monitoring
    heartbeat_timeout_multiplier                                                    As Byte
    ' Heartbeat time interval
    reserved_2(4929)                                                                As Byte
    ' Reserved area
    devices(31)                                                                     As DEVICE_CONFIG
 ' Device configuration table
    directed_control_input_table(127)                                               As Byte
    ' PCGEN Directed Control input table
    broadcast_control_output_table(127)                                             As Byte
    ' PCGEN Broadcast Control output table
    device_io_table(8191)                                                           As Byte
    ' Device I/O table
End Type    'Shared_RAM_Interface

'## ----------------------------------------------------------------------------
' Control register declarations
Private Const BoardResetRelease                                                 As Byte = &H40
Private Const WDT_Disable                                                       As Byte = &H20
Private Const HHM_PresentTest                                                   As Byte = &H8

'###############################################################################
'## Method "CardSetup" is used to complete the configuration and initialization
'## of a PCGEN card which has already been located as part of a previous
'## constructor call.
'##
'## Inputs
'##        o Outputs enable/disable
'##        o Genius bus baud rate
'##        o Card's serial bus address
'##
'## Returns one of the following GENI return codes:
'##        o GENI_NoError
'##        o May also return a DeviceIoControl error code (non-zero positive #)
'##          see "System Error Code" in Windows platform SDK for decoding a
'##        device error code.
'##
'## Side effects:
'##        o Stores card's SBA in class static variable "SerialBusAddress".
'##
'## PDL:
'##        Write outputs control, baud rate and SBA to card's configuration register
'##        Write release from reset and disable watchdog timer to control register
'##        Delay 4 seconds to allow board to come out of reset
'###############################################################################
Public Function CardSetup(OutputsControl As GENI_Outputs, _
                          BaudRate As GENI_BaudRate, _
                          ByVal SBA As Integer) As Integer
'## Outputs enabled/disabled  '## Bus baud rate  '## PCGEN card serial bus address
Dim result     As Boolean
Dim dwret      As Long
Dim DeviceData As GENPORT_WRITE_INPUT
Dim tmwait     As Double
'## Set Baud rate, Serial Bus Address and Outputs control
    DeviceData.PortNumber = CONFIG_REG
    DeviceData.WriteData = CLng((OutputsControl) Or (BaudRate) Or (SBA))
    IOCTL_GEGENIUS_WRITE_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H911, METHOD_BUFFERED, FILE_WRITE_ACCESS)
    result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_WRITE_PORT, DeviceData, ByVal CLng(LenB(DeviceData)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
'Grab any errors
    If Not result Then
        CardSetup = (Err.LastDllError())
        InitializationResult = (Err.LastDllError())
        
        Exit Function

    End If
'## Bring board out of reset and disable watchdog timer
'## If watchdog is to be enabled here, need to do a read from Shared RAM
'## to reset watchdog before enabling it (functionality not provided...)
    DeviceData.PortNumber = CONTROL_REG
    DeviceData.WriteData = BoardResetRelease Or WDT_Disable
'## Disable Watchdog, bring out of reset
    result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_WRITE_PORT, DeviceData, ByVal CLng(LenB(DeviceData)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
    If Not result Then
        CardSetup = (Err.LastDllError())
        InitializationResult = (Err.LastDllError())
        
        Exit Function

    End If
'## Wait for 4 seconds to get board up from reset state
'## If the Watchdog is enabled, need to be reading from Shared RAM
'## during a startup delay to service Watchdog
    tmwait = GetTickCount
    Do While GetTickCount < (tmwait + 4000)
        DoEvents
    Loop
    SerialBusAddress = SBA
    CardSetup = (GENI_NoError)
    InitializationResult = (GENI_NoError)
End Function
'###############################################################################
'## Method "GENI_Change_Setup" is used to change the contents of one or more
'## SETUP structure components in the PCGEN card's dual-port RAM.  See GFK-0845,
'## "Genius I/O Geni Board User's Manual" for details.
'##
'## Inputs
'##      o Pointer to filled in GENI_SETUP record (all except configuration settings)
'##
'## Returns
'##      o Result of setup change
'##          - GENI_NoError
'##          - GENI_NotOK
'##          - GENI_Busy
'##          - GENI_BadCommandSyntax
'##          - GENI_CommandProcessingError
'##          - GENI_CommandTimeout
'##          - GENI_UnknownError
'##
'## No side effects
'##
'## PDL:
'##      Copy new setup information into card's dual-port RAM
'##      Initiate configuration change command
'##      Wait maximum of 1.5 seconds for command to complete
'###############################################################################
Public Function GENI_Change_Setup(Setup As GENI_SETUP) As Integer
Dim tmwait As Double
Dim status As Byte
'## Check for GENI OK _and_ command block is free
    If GetVar(MemoryBaseAddress + SRI_GENI_STATUS_OFFSET + 1, 1) <> GENI_OK Then
        GENI_Change_Setup = GENI_NotOK
    End If
    If GetVar(MemoryBaseAddress + SRI_COMMAND_OFFSET, 1) = INPROGRESS Then
        GENI_Change_Setup = GENI_Busy
    End If
'## Update setup data in Shared RAM
    With Setup
        SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 1), .reference_address, 2
        SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 3), .broadcast_control_data_length, 1
        SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 4), .directed_control_data_length, 1
        SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 5), .io_buffer_length, 1
'## Set up command block for configuration change & initiate command
    End With 'Setup
    SetVar (MemoryBaseAddress + SRI_COMMAND_OFFSET + 1), CHANGE_CONFIG, 1
    SetVar (MemoryBaseAddress + SRI_COMMAND_OFFSET), INCOMECMD, 1
'## Check for command complete; wait a maximum of 1.5 seconds
    tmwait = GetTickCount
    Do While GetTickCount < tmwait + 1500
        status = GetVar(MemoryBaseAddress + SRI_COMMAND_OFFSET, 1)
        If status = CCOMPLETE Or SYNTAXERR Or PROCERR Then
            Exit Do
        End If
        DoEvents
    Loop
'## Return result of configuration change command
    If status = CCOMPLETE Then
        GENI_Change_Setup = GENI_NoError
    ElseIf status = SYNTAXERR Then
        GENI_Change_Setup = GENI_BadCommandSyntax
    ElseIf status = PROCERR Then
        GENI_Change_Setup = GENI_CommandProcessingError
    ElseIf GetTickCount > tmwait + 1500 Then
        GENI_Change_Setup = GENI_CommandTimeout
    Else
        GENI_Change_Setup = GENI_UnknownError
    End If
End Function
'## ############################################################################
'## Destructor "~GENI" is used to destroy a GENI class object, releasing all of
'## its resources in the process.  The PCGEN card itself is placed into reset.
'##
'## Inputs
'##        o None
'##
'## Returns nothing
'##
'## Side effects:
'##        o Stores destructor failure error in class static variable "InitializationResult".
'##
'## PDL:
'##        Write board reset to card's control register
'##        Free dual-port memory area
'## ############################################################################
Public Sub GENI_Destruct()
Dim result     As Boolean
Dim dwret      As Long
Dim DeviceData As GENPORT_WRITE_INPUT
    If hWin32Device <> INVALID_HANDLE_VALUE Then
'## Turn off card
        DeviceData.PortNumber = CONTROL_REG
        DeviceData.WriteData = 0
        IOCTL_GEGENIUS_WRITE_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H911, METHOD_BUFFERED, FILE_WRITE_ACCESS)
        result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_WRITE_PORT, DeviceData, ByVal CLng(LenB(DeviceData)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
        If Not result Then
            InitializationResult = Err.LastDllError()
            'Exit Sub
        End If
'## Free Shared Memory range
        IOCTL_GEGENIUS_UNMAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H913, METHOD_BUFFERED, FILE_ANY_ACCESS)
        result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_UNMAP_MEMORY, MemoryBaseAddress, ByVal CLng(LenB(MemoryBaseAddress)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
        If Not result Then
            InitializationResult = Err.LastDllError()
            'Exit Sub
        End If
'## Close windows handle
        CloseHandle (hWin32Device)
    End If
End Sub
'###############################################################################
'## Method "LocateCard" is used to open a PCGEN device and map it into the PCI
'## address space.
'##
'## Inputs
'##        o Device number
'##
'## Returns one of the following GENI return codes:
'##        o GENI_NoError
'##        o GENI_BadDeviceReference
'##        o May also return a DeviceIoControl error code (non-zero positive #)
'##          see "System Error Code" in Windows platform SDK for decoding a
'##        device error code.
'##
'## Side effects:
'##        o Stores card's window handle in class static variable "hWin32Device".
'##        o Stores card's memory pointer in class static variable "MemoryBaseAddress".
'##
'## PDL:
'##        Open device as "\\.\GEGENIUS#" (where # in (0..3))
'##        Map device's dual port memory into PCI address space
'##        Leave device in reset for now
'###############################################################################
Public Function GENI_LocateCard(ByVal Device As Integer) As Integer
Dim result As Boolean
Dim dwret  As Long      ' System.UInt32
'Only dealing with a single card here.
    cGEGENIUS = "\\.\GEGENIUS0"
    If (Device < 0) Or (Device > (MAX_CARDS_SUPPORTED - 1)) Then
        GENI_LocateCard = GENI_BadDeviceReference
        LocationResult = GENI_BadDeviceReference
    End If
' Get Windows handle to Device
    hWin32Device = CreateFile(cGEGENIUS, GENERIC_READ Or GENERIC_WRITE, 0, ByVal CLng(0), OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0)
'Grab any errors
    If hWin32Device = INVALID_HANDLE_VALUE Then
        GENI_LocateCard = (CInt(Fix(Err.LastDllError())))
        LocationResult = (CInt(Fix(Err.LastDllError())))
    End If
' Map Shared RAM into local process
    IOCTL_GEGENIUS_MAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H912, METHOD_BUFFERED, FILE_ANY_ACCESS)
    result = DeviceIoControl(ByVal hWin32Device, IOCTL_GEGENIUS_MAP_MEMORY, CLng(0), ByVal CLng(0), MemoryBaseAddress, ByVal CLng(LenB(MemoryBaseAddress)), dwret, ByVal CLng(0))
'Grab any errors
    If result = 0 Then
        GENI_LocateCard = (CInt(Fix(Err.LastDllError())))
        LocationResult = (CInt(Fix(Err.LastDllError())))
    Else
        GENI_LocateCard = (GENI_NoError)
        LocationResult = (GENI_NoError)
    End If
End Function

