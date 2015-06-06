Attribute VB_Name = "PCGEN"
Option Explicit
' ############################################################################
' The following list of constants is the set of possible return codes from all
' calls to this module.  Of course, not all return codes will be returned by
' all calls, but the caller must be prepared to deal with the entire set.
'
Public Const GENI_NoError                                                     As Integer = 0
' Device is OK
Public Const GENI_NotOK                                                       As Integer = -1
' Device is not OK
Public Const GENI_Busy                                                        As Integer = -2
' Device is busy; command cannot be accepted
Public Const GENI_BadDeviceReference                                          As Integer = -3
' Device not in [0..3]
Public Const GENI_BadOutputsControlRef                                        As Integer = -4
' Outputs control not in [enabled, disabled]
Public Const GENI_BadBaudRateReference                                        As Integer = -5
' Baud rate invalid
Public Const GENI_BadSBAReference                                             As Integer = -6
' SBA not in [0..31]
Public Const GENI_BadCommandSyntax                                            As Integer = -7
' Syntax error detected in command block
Public Const GENI_CommandProcessingError                                      As Integer = -8
' Processing error encountered with command block
Public Const GENI_CommandTimeout                                              As Integer = -9
' Timeout error declared during command processing
Public Const GENI_NoDevice                                                    As Integer = -10
' No device at SBA
Public Const GENI_InappropriateDevice                                         As Integer = -11
' Device type not appropriate for request
Public Const GENI_BadReplyLength                                              As Integer = -12
' Datagram reply length different than expected
Public Const GENI_BadCircuitReference                                         As Integer = -13
' Circuit reference <1 or > maximum supported
Public Const GENI_IOTable_Lockout_Failure                                     As Integer = -14
' I/O table lockout semaphore failure
Public Const GENI_OutputsNotEnabled                                           As Integer = -15
' Outputs must be enabled to write to device
Public Const GENI_CannotEnableOutputs                                         As Integer = -16
' Another controller already assigned to device
Public Const GENI_UnknownError                                                As Integer = -99
' Unexpected error encountered
' ----------------------------------------------------------------------------
' ############################################################################
' The following list of constants is the set of possible model numbers for
' devices which may be encountered on the Genius bus.
'
'' Hand-held monitors
Public Const DevType_HHM_PhaseA                                                 As Integer = 2              ' [IC660HHM500]
Public Const DevType_HHM                                                        As Integer = 5              ' [IC660HHM501]
'' 8 circuit discrete blocks
Public Const DevType_Circ_8_115VAC_Grouped_PhaseA                               As Integer = 64             ' [IC660CBD100]
Public Const DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA                       As Integer = 65             ' [IC660CBS100]
Public Const DevType_Circ_8_115VAC_2A_Grouped                                   As Integer = 69             ' [IC660BBD100]
Public Const DevType_Circ_8_115VAC_125VDC_Isolated                              As Integer = 70             ' [IC660BBS100 / IC660BBS101]
Public Const DevType_Circ_8_220VAC_Grouped                                      As Integer = 71             ' [IC660??????]
Public Const DevType_Circ_8_115VAC_LowLeakage_Grouped                           As Integer = 82             ' [IC660BBD101]
'' 16 circuit discrete blocks
Public Const DevType_Circ_16_24VDC_48VDC_Sink_PhaseA                            As Integer = 67             ' [IC660CBD021]
Public Const DevType_Circ_16_24VDC_48VDC_Source_PhaseA                          As Integer = 68             ' [IC660CBD020]
Public Const DevType_Circ_16_24VDC_48VDC_Sink                                   As Integer = 72             ' [IC660BBD021 / IC660BBD023]
Public Const DevType_Circ_16_12VDC_24VDC_48VDC_Source                           As Integer = 73             ' [IC660BBD020 / IC660BBD022]
Public Const DevType_Circ_16_Normally_Open_Relay                                As Integer = 79             ' [IC660BBR101]
Public Const DevType_Circ_16_Normally_Closed_Relay                              As Integer = 80             ' [IC660BBR100]
Public Const DevType_Circ_16_115VAC_Input                                       As Integer = 81             ' [IC660BBD110]
'' 32 circuit discrete blocks
Public Const DevType_Circ_32_5VDC_12VDC_24VDC_Sink                              As Integer = 74             ' [IC660BBD025]
Public Const DevType_Circ_32_12VDC_24VDC_Source                                 As Integer = 75             ' [IC660BBD024]
'' 4 input / 2 output analog blocks
Public Const DevType_Voltage_Current_4in_2out_Analog_115VAC                     As Integer = 131            ' [IC660BBA100]
Public Const DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC                As Integer = 132            ' [IC660BBA020]
Public Const DevType_Voltage_Current_4in_2out_Analog_115VAC_PhaseA              As Integer = 128            ' [IC660CBA100]
Public Const DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC_PhaseA As Integer = 129            ' [IC660CBA020]
Public Const DevType_Current_Source_4in_2out_Analog_115VAC_125VDC               As Integer = 140            ' [IC660BBA104]
Public Const DevType_Current_Source_4in_2out_Analog_24VDC_48VDC                 As Integer = 141            ' [IC660BBA024]
'' 6 output analog blocks
Public Const DevType_Current_Source_6out_Analog_115VAC_125VDC                   As Integer = 142            ' [IC660BBA105]

Public Const DevType_Current_Source_6out_Analog_24VDC_48VDC                   As Integer = 143            ' [IC660BBA025]

'' 6 input analog blocks
Public Const DevType_Current_Source_6in_Analog_115VAC_125VDC                  As Integer = 144            ' [IC660BBA106]

Public Const DevType_Current_Source_6in_Analog_24VDC_48VDC                    As Integer = 145            ' [IC660BBA026]

'' 6 input thermocouple blocks
Public Const DevType_6in_Thermocouple_115VAC_125VDC                           As Integer = 134            ' [IC660BBA103]

Public Const DevType_6in_Thermocouple_24VDC_48VDC                             As Integer = 135            ' [IC660BBA023]

'' 6 input RTD blocks
Public Const DevType_6in_RTD_115VAC_125VDC                                    As Integer = 136            ' [IC660BBA101]

Public Const DevType_6in_RTD_24VDC_48VDC                                      As Integer = 137            ' [IC660BBA021]

'' High speed counter (types A,B,C) block
Public Const DevType_High_Speed_Counter                                       As Integer = 32             ' [IC660BBD120]

'' PowerTRAC block
Public Const DevType_PowerTRAC                                                As Integer = 127            ' [IC660BPM100]

'' Series 6 Bus Controllers
Public Const DevType_Series_6_Bus_Controller_PhaseA                           As Integer = 1              ' [IC660CBB900]

Public Const DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA                As Integer = 3              ' [IC660CBB901]

Public Const DevType_Series_6_Bus_Controller                                  As Integer = 6              ' [IC660CBB902]

Public Const DevType_Series_6_Bus_Controller_Wout_Diags                       As Integer = 7              ' [IC660CBB903]

'' Series 90 Bus Controllers
Public Const DevType_Series_9070_Bus_Controller                                As Integer = 10             ' [IC697BEM731]
Public Const DevType_Series_9030_Bus_Controller                               As Integer = 15             ' [IC693BEM331]

'' Series 90-70 Remote I/O Scanner
Public Const DevType_Series_9070_Remote_IO_Scanner                            As Integer = 160            ' [IC697BEM733]

'' Series 90-30 Global Data communications modules
Public Const DevType_Series_9030_Communications_Module                        As Integer = 13             ' [IC693CMM301]

Public Const DevType_Series_9030_Enhanced_Communications_Module               As Integer = 14             ' [IC693CMM302]

'' Field Control Genius Bus Interface Unit
Public Const DevType_FieldControl_GBIU                                        As Integer = 160            ' [IC670GBI001]
'' VersaMax Genius Bus Interface Unit
Public Const DevType_VersaMax_GBIU                                            As Integer = 161            ' [IC200GBI001]

'' ISA-bus and PCI-bus GENI type devices
Public Const DevType_GENI                                                      As Integer = 4
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
    configuration_register_settings                                                As Byte
    ' SBA, baud rate, outputs disable
    reference_address                                                              As Integer
    ' Reference address
    broadcast_control_data_length                                                  As Byte
    ' Global data broadcast amount
    directed_control_data_length                                                   As Byte
    ' Directed data amount accepted
    io_buffer_length                                                               As Byte
    ' Size of (all) I/O buffers
    reserved(10)                                                                   As Byte
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
    firmware_revision                                                              As Byte
    ' PCGEN firmware revision
    ok_status                                                                      As Byte
    ' Both board status & heartbeat indicator
    hardware_status                                                                As Byte
    ' Error flags to explain "not ok" status
    bus_status                                                                     As Byte
    ' Warning flag for excessive bus errors
    bus_error_count                                                                As Integer
    ' Total bus errors since PCGEN reset
    bus_scan_time                                                                  As Integer
    ' Time between last two bus cycles
    reserved(8)                                                                    As Byte
End Type
Public Const GENI_OK                                                           As Integer = 1
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
    model_number                                                                   As Byte
    ' Device model number
    outputs_disable                                                                As Byte
    ' Outputs disable for device
    device_present                                                                 As Byte
    ' Device present and logged in
    reference_address                                                              As Integer
    ' Device reference address
    broadcast_control_data_length                                                  As Byte
    ' Inputs / global data broadcast
    directed_control_data_length                                                   As Byte
    ' Control data device expects
    block_config                                                                   As Byte
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
    COMMAND                                                                        As Byte
    status                                                                         As Byte
    data_length                                                                    As Byte
    host_memory_map(3)                                                             As Byte
    source_device                                                                  As Byte
    aux_source_address                                                             As Byte
    Data(128)                                                                      As Byte
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
'    @@Was a C++ Union
'        discrete_blocks(4) As Byte ' 8, 16 & 32 circuit discrete blocks
'        Analog4In2Out As ANALOG_4IN_2OUT ' 4 input / 2 output analog blocks (Was a C++ type struct and Union)
'        broadcast_global_data(128) As Byte ' input from global data producing device
'        directed_control_data(128) As Byte ' directed control inputs in PCI Genius card
' Only care about global data in this application so that's all I defined.  If anything else is desired
'   then just define it and convert the format to or dump the format into the 128 bytes defined.
'   128 Bytes is the maximum, but memory allocation must be 128 bytes irregardless of what is needed.
Public Type DEVICE_DATA
    block_type                                                                     As Byte
    '    discrete_blocks(4) As Byte ' 8, 16 & 32 circuit discrete blocks
    '    Analog4In2Out As ANALOG_4IN_2OUT ' 4 input / 2 output analog blocks
    broadcast_global_data(128)                                                     As Byte
    ' input from global data producing device
    '    directed_control_data(128) As Byte ' directed control inputs in PCI Genius card
End Type
' ----------------------------------------------------------------------------
' ############################################################################
' The following set of structures defines the makeup of the configuraton data
' for each of the possible Genius blocks.
'
' *IO_CONFIG
'       +GENERIC_DISCRETE_CONFIG
'       +C16_115VAC_INPUT_CONFIG
'       +ANALOG_4IN_2OUT_CONFIG
'               oINPUT_CHANNEL_CONFIG
'               oOUTPUT_CHANNEL_CONFIG
'
' @@ ONLY DISCRETE AND 4IN/2OUT ANALOG BLOCKS ARE CURRENTLY DEFINED HERE!!!!!
'
' See GEK-90486F-1, "Genius I/O System and Communications User's Manual" for details.
Public Type GENERIC_DISCRETE_CONFIG ' 8, 16 & 32 circuit in/out discrete blocks
    circuit_config(32)                                                             As Byte
    ' Circuit configuration, 1 byte per circuit
End Type
Public Type C16_115VAC_INPUT_CONFIG  ' 16 circuit input discrete block
    circuit_config(16)                                                             As Byte
    ' Circuit configuration, 1 byte per circuit
    points_1to8_input_filter_time                                                  As Byte
    ' Input filter time, circuits 1-8
    points_9to16_input_filter_time                                                 As Byte
    ' Input filter time, circuits 9-16
    points_1to8_open_off_threshold                                                 As Byte
    ' Open-off threshold, circuits 1-8
    points_1to8_on_off_threshold                                                   As Byte
    ' On-off threshold, circuits 1-8
    points_9to16_open_off_threshold                                                As Byte
    ' Open-off threshold, circuits 9-16
    points_9to16_on_off_threshold                                                  As Byte
    ' On-off threshold, circuits 9-16
End Type
Public Type INPUT_CHANNEL_CONFIG
    circuit_configuration                                                          As Integer
    ' Circuit configuration, 2 bytes per channel
    high_alarm                                                                     As Integer
    ' High alarm
    low_alarm                                                                      As Integer
    ' Low alarm
    high_scaling_point_eu                                                          As Integer
    ' High scaling point, engineering units
    high_scaling_point_counts                                                      As Integer
    ' High scaling point, counts
    low_scaling_point_eu                                                           As Integer
    ' Low scaling point, engineering units
    low_scaling_point_counts                                                       As Integer
    ' Low scaling point, counts
End Type
Public Type OUTPUT_CHANNEL_CONFIG
    circuit_configuration                                                          As Integer
    ' Circuit configuration, 2 bytes per channel
    default_value                                                                  As Integer
    ' Default value
    high_scaling_point_eu                                                          As Integer
    ' High scaling point, engineering units
    high_scaling_point_counts                                                      As Integer
    ' High scaling point, counts
    low_scaling_point_eu                                                           As Integer
    ' Low scaling point, engineering units
    low_scaling_point_counts                                                       As Integer
    ' Low scaling point, counts
End Type
Public Type ANALOG_4IN_2OUT_CONFIG
    input_channels(4)                                                              As INPUT_CHANNEL_CONFIG     ' Input channels 1-4
    output_channels(2)                                                             As OUTPUT_CHANNEL_CONFIG    ' Output channels 1-2
End Type
'    @@Was a C++ Union
'        discrete_io_config As GENERIC_DISCRETE_CONFIG
'        c16_115vac_input_conf As C16_115VAC_INPUT_CONFIG
'        analog_4in_2out_conf As ANALOG_4IN_2OUT_CONFIG
' Only care about global data in this application so that's all I defined.  If anything else is desired
'   then just define it and convert the format to or dump the format into the 32 bytes defined.
'   32 Bytes is the maximum, but memory allocation must be 32 bytes irregardless of what is needed.
Public Type IO_CONFIG
    block_type                                                                     As Byte
    ' Device block type
    firmware_revision                                                              As Byte
    ' Block firmware revision
    block_config_1                                                                 As Byte
    ' Block configuration, byte 1
    block_config_2                                                                 As Byte
    ' Block configuration, byte 2
    discrete_io_config                                                             As GENERIC_DISCRETE_CONFIG
    '        c16_115vac_input_conf As C16_115VAC_INPUT_CONFIG
    '        analog_4in_2out_conf As ANALOG_4IN_2OUT_CONFIG
End Type
' ----------------------------------------------------------------------------
' ############################################################################
' The following masks and values are useful for decoding configuration bytes
' returned in an IO_CONFIG structure.  The mask should be applied first on the
' configuration byte, then a comparision made for a particular value.
'
' *** Discrete input/output block, block configuration byte # 1***
' ***************************************************************************
Public Const PulseTestMask                                                    As Integer = &H1
' Pulse Test: disabled/not disabled
''Public Const PT_Enabled                                                       As Integer = &H0
''Public Const PT_Disabled                                                      As Integer = &H1
Public Const FilterTimeMask                                                   As Integer = &H3C
' Input filter time
''Public Const FilterTimeRightShift                                             As Integer = 2
Public Const ConfigProtectMask                                                As Integer = &H40
' Configuration Protected: protected/not protected
''Public Const Cfg_Protected                                                    As Integer = &H40
''Public Const Cfg_NotProtected                                                 As Integer = &H0
Public Const ACDCMask                                                         As Integer = &H80
' AC/DC Selected: AC/DC
''Public Const AC                                                               As Integer = &H80
''Public Const DC                                                               As Integer = &H0
' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
' %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
' *** Discrete input/output block, block configuration byte # 2***
Public Const DuplexStateMask                                                  As Integer = &H1
' Duplex Default State: off/on
''Public Const DS_Off                                                           As Integer = &H0
''Public Const DS_On                                                            As Integer = &H1
Public Const OutputDefaultMask                                                As Integer = &H2
' Output Default Time: 2.5sec/10sec
''Public Const OD_2p5s                                                          As Integer = &H0
''Public Const OD_10s                                                           As Integer = &H2
Public Const CPURedundancyMask                                                As Integer = &HC
' Redundancy: none/HSB/duplex/GMR
''Public Const CPURedundancy_None                                               As Integer = &H0
''Public Const CPURedundancy_HS                                                 As Integer = &H4
''Public Const CPURedundancy_Duplex                                             As Integer = &H8
''Public Const CPURedundancy_GMR                                                As Integer = &HC
Public Const BSMPresentMask                                                   As Integer = &H10
' BSM Present: absent/present
''Public Const BP_Absent                                                        As Integer = &H0
''Public Const BP_Present                                                       As Integer = &H10
Public Const BSMControllerMask                                                As Integer = &H20
' BSM Controller: yes/no
''Public Const BSM_Ctr_No                                                       As Integer = &H0
''Public Const BSM_Ctr_Yes                                                      As Integer = &H20
Public Const BSMStateMask                                                     As Integer = &H40
' BSM Actual State:  BusA/BusB
''Public Const BSM_BusA                                                         As Integer = &H0
''Public Const BSM_BusB                                                         As Integer = &H40
Public Const BSMForcedMask                                                    As Integer = &H80
' BSM Forced:  forced/unforced
''Public Const BSM_NoForce                                                      As Integer = &H0
''Public Const BSM_Force                                                        As Integer = &H80
' ***************************************************************************
' *** Discrete input/output block, circuit configuration byte ***
Public Const CircuitTypeMask                                                  As Integer = &H3
' Circuit type: Tri-state/input/output
''Public Const TriStateInputValue                                               As Integer = &H0
''Public Const InputValue                                                       As Integer = &H1
''Public Const OutputValue                                                      As Integer = &H2
Public Const OverloadShutdownMask                                             As Integer = &H4
' Output overload shutdown: enabled/disabled
''Public Const OS_Enabled                                                       As Integer = &H0
''Public Const OS_Disabled                                                      As Integer = &H4
Public Const HoldLastStateMask                                                As Integer = &H8
' Output hold last state: default/last
''Public Const OutputDefault                                                    As Integer = &H0
''Public Const OutputHoldLastState                                              As Integer = &H8
Public Const OutputDefaultStateMask                                           As Integer = &H10
' Output default state: on/off
''Public Const OutputOff                                                        As Integer = &H0
''Public Const OutputOn                                                         As Integer = &H10
Public Const NoLoadDetectionMask                                              As Integer = &H20
' Output no load detection
''Public Const NL_Enabled                                                       As Integer = &H0
''Public Const NL_Disabled                                                      As Integer = &H20
Public Const PointForcedMask                                                  As Integer = &H40
' Circuit forced: yes/no
''Public Const PF_No                                                            As Integer = &H0
''Public Const PF_Yes                                                           As Integer = &H40
Public Const ReportFaultsMask                                                 As Integer = &H80
' Circuit report faults: yes/no
''Public Const RF_Yes                                                           As Integer = &H0
''Public Const RF_No                                                            As Integer = &H80
Public Const VCMask                                                           As Integer = &H7
' Voltage/Current Mask
Public Const InputModeMask                                                    As Integer = &H10
' Input mode: normal/alarm input
''Public Const IM_Normal                                                        As Integer = &H0
''Public Const IM_Alarm                                                         As Integer = &H10
Public Const ChannelActiveMask                                                As Integer = &H20
' Channel active: yes/no
''Public Const CA_Active                                                        As Integer = &H0
''Public Const CA_Inactive                                                      As Integer = &H20
''Public Const VoltageFilterTimeMask                                            As Integer = &HF
Public Const FeedbackTestingMask                                              As Integer = &H8
' Feedback testing: enabled/disabled
''Public Const FT_Enabled                                                       As Integer = &H8
''Public Const FT_Disabled                                                      As Integer = &H0
Public Const MAX_CARDS_SUPPORTED                                               As Integer = 4
' PCGEN driver can support up to 4 cards
' ############################################################################
' Enumeration used to set PCGEN card outputs as either "enabled" or "disabled"
' during a call to some of the class contructors or to the CardSetup function.
Public Enum GENI_Outputs
    OutputsEnabled = &H0  ' Outputs enabled for all bus devices
    Outputsdisabled = &H80 ' Outputs disabled for all bus devices
End Enum
#If False Then 'Trick preserves Case of Enums when typing in IDE
Public OutputsEnabled, Outputsdisabled
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
Public Baud_153p6kEXT, Baud_38p4k, Baud_76p8k, baud_153p6kstd
#End If


'## PCGEN Status Register masks
Public Const COMM_OK_LED                  As Byte = &H10   ' bit b4, 0001_0000
Public Const GENI_OK_LED                  As Byte = &H8    ' bit b3, 0000_1000
Public Const WatchDogStatus               As Byte = &H2    ' bit b1, 0000_0010
Public Const ResetDetect                  As Byte = &H1    ' bit b0, 0000_0001
Public Const FILE_DEVICE_UNKNOWN          As Integer = 34  'Public Const FILE_DEVICE_UNKNOWN = &H22
Public Const METHOD_BUFFERED              As Long = 0

'PCI Genius card commands
'Declare IOCTL variables to Mimic C++ Macros with CTL_CODE Function
Public IOCTL_GEGENIUS_READ_PORT           As Long
Public IOCTL_GEGENIUS_WRITE_PORT          As Long
Public IOCTL_GEGENIUS_MAP_MEMORY          As Long
Public IOCTL_GEGENIUS_UNMAP_MEMORY        As Long
'Use these statements for API DeviceIOControl functions
'IOCTL_GEGENIUS_READ_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H910, METHOD_BUFFERED, FILE_READ_ACCESS)
'IOCTL_GEGENIUS_WRITE_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H911, METHOD_BUFFERED, FILE_WRITE_ACCESS)
'IOCTL_GEGENIUS_MAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H912, METHOD_BUFFERED, FILE_ANY_ACCESS)
'IOCTL_GEGENIUS_UNMAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H913, METHOD_BUFFERED, FILE_ANY_ACCESS)

Public Const MAX_PATH                        As Long = 260
Public Const INVALID_HANDLE_VALUE         As Long = -1
Public Const ERROR_FILE_NOT_FOUND            As Long = 2

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
    PortNumber                              As Long     '## Port # to be accessed
    WriteData                               As Long     '## Data to be read from / written to port
End Type  'GENPORT_WRITE_INPUT

'## ----------------------------------------------------------------------------
'## PCGEN Register Offsets
Public Const CONFIG_REG                   As Integer = 0 '## configuration register
Public Const STATUS_REG                   As Integer = 1 '## status register
Public Const CONTROL_REG                  As Integer = 2 '## control register

'###############################################################################
'## Caution:  The following structure MUST be defined as byte-aligned, not word-
'##             aligned.  The structure order cannot be altered.
'##
'##
'## The READ_DATAGRAM command instructs the PCGEN card to move a reply datagram
'## from its receive queue to dual-port RAM where it may be accessed.
'## See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'##
Public Type READ_DATAGRAM
    Source_SBA      As Byte     'SBA of device sending the datagram
    MainFunction    As Byte     'Datagram function code
    Subfunction     As Byte     'Datagram sub-function code
    DB_Indicator    As Byte     'Directed (=1) or broadcast (=0) indicator
    Length          As Byte     'Length of message
End Type    'READ_DATAGRAM

'## ----------------------------------------------------------------------------
'###############################################################################
'## Caution:  The following structure MUST be defined as byte-aligned, not word-
'##             aligned.  The structure order cannot be altered.
'##
'##
'## The TRANSMIT_DATAGRAM command instructs the PCGEN card to transmit a datagram
'## previously placed in dual-port RAM.
'## See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'##
Public Type TRANSMIT_DATAGRAM
    Destination     As Byte     'SBA of device datagram sent to
    MainFunction    As Byte     'Datagram function code
    Subfunction     As Byte     'Datagram sub-function code
    Priority        As Byte     'Priority (1=high, 0=low)
    Length          As Byte     'Length of message
End Type    'TRANSMIT_DATAGRAM

'## ----------------------------------------------------------------------------
'###############################################################################
'## Caution:  The following structure MUST be defined as byte-aligned, not word-
'##             aligned.  The structure order cannot be altered.
'##
'##
'## The TRANSMIT_DATAGRAM_WITH_REPLY command instructs the PCGEN card to transmit
'## a datagram previously placed in dual-port RAM, and then wait for a reply.
'## See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'##
Public Type TRANSMIT_DATAGRAM_WITH_REPLY
    Destination         As Byte     'SBA of device datagram sent to
    MainFunction        As Byte     'Datagram function code
    Xmit_Subfunction    As Byte     'Datagram transmission sub-function code
    Recv_Subfunction    As Byte     'Datagram reply sub-function code
    Priority            As Byte     'Priority (1=high, 0=low)
    Xmit_Length         As Byte     'Length of transmission message
    Recv_Length         As Byte     'Length of reply message
End Type    'TRANSMIT_DATAGRAM_WITH_REPLY

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
    status          As Byte  'Initiation of command + command status
    COMMAND         As Byte  'Command type (read, xmit, xmit w/reply, cfg change)
    OPTIONS(14)     As Byte  'maximum size
End Type    'COMMAND

'## Bit masks used in processing datagrams
Public Const CMDMASK                       As Long = &H3F
Public Const FLGMASK                       As Long = &H80
Public Const FREEBLK                       As Long = &H0
Public Const INCOMECMD                     As Long = &H1
Public Const INPROGRESS                    As Long = &H2
Public Const CCOMPLETE                     As Long = &H4
Public Const SYNTAXERR                     As Long = &H8
Public Const PROCERR                       As Long = &H10
'## Command types
Public Const READ_DATAGRAM                 As Integer = 1
Public Const XMIT_DATAGRAM                 As Integer = 2
Public Const XMIT_DATAGRAM_WITH_REPLY      As Integer = 3
Public Const CHANGE_CONFIG                 As Integer = 4
'## Command function codes
Public Const GEF_DATAGRAM                  As Long = &H20
'## Command Sub-function codes
Public Const SF_READ_ID                    As Long = &H0
Public Const SF_READ_ID_REPLY              As Long = &H1
Public Const SF_READ_CONFIG                As Long = &H2
Public Const SF_READ_CONFIG_REPLY          As Long = &H3
Public Const SF_WRITE_CONFIG               As Long = &H4
Public Const SF_ASSIGN_MONITOR             As Long = &H5
Public Const SF_BEGIN_PACKET_SEQUENCE      As Long = &H6
Public Const SF_END_PACKET_SEQUENCE        As Long = &H7
Public Const SF_READ_DIAGS                 As Long = &H8
Public Const SF_READ_DIAGS_REPLY           As Long = &H9
Public Const SF_WRITE_POINT                As Long = &HB
Public Const SF_READ_BLOCK_IO              As Long = &HC
Public Const SF_READ_BLOCK_IO_REPLY        As Long = &HD
Public Const SF_REPORT_FAULT               As Long = &HF
Public Const SF_PULSE_TEST                 As Long = &H10
Public Const SF_PULSE_TEST_COMPLETE        As Long = &H11
Public Const SF_CLEAR_CIRCUIT_FAULT        As Long = &H12
Public Const SF_CLEAR_ALL_CIRCUIT_FAULTS   As Long = &H13
Public Const SF_SWITCH_BSM                 As Long = &H1C
Public Const SF_READ_DEVICE                As Long = &H1E
Public Const SF_READ_DEVICE_REPLY          As Long = &H1F
Public Const SF_WRITE_DEVICE               As Long = &H20
Public Const SF_CONFIG_CHANGE              As Long = &H22
Public Const SF_READ_DATA                  As Long = &H27
Public Const SF_READ_DATA_REPLY            As Long = &H28
Public Const SF_READ_MAP                   As Long = &H2A
Public Const SF_READ_MAP_REPLY             As Long = &H2B
Public Const SF_WRITE_MAP                  As Long = &H2C
Public Const SF_ASSIGN_SBA29_HOT_STANDBY   As Long = &H2D
'## Transmit datagram priorities
Public Const NORMAL_PRIORITY               As Integer = 0
Public Const HIGH_PRIORITY                 As Integer = 1

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
Public MemStatus                                As String
Public hMap                                    As Long
Public SharedMem                               As Long
Public MemoryBaseAddress                        As Long
Public SRI                                     As Shared_RAM_Interface

Public Type Shared_RAM_Interface
    request_q(15)                               As REQUEST_Q_ENTRY  ' Incoming datagram queue
    queue_head_ptr                              As Byte             ' Entry currently being read
    queue_tail_ptr                              As Byte             ' Most recent entry in queue
    Setup                                       As GENI_SETUP       ' PCGEN card setup data
    status                                      As GENI_STATUS      ' PCGEN card status data
    interrupt_status(15)                        As Byte             ' Current interrupt status
    interrupt_disable(15)                       As Byte             ' Enable/disable host interrupts
    command_block                               As COMMAND          ' Outgoing datagram
    transmit_datagram_buffer(239)               As Byte             ' Temporary xmit datagram buffer
    read_datagram_buffer(133)                   As Byte             ' Read access to recd datagram
    iotable_lockout_request                     As Byte             ' Set/release I/O table lockout
    iotable_lockout_state                       As Byte             ' Actual lockout state
    host_clear                                  As Byte             ' Clear interrupts from host
    reserved_1(63)                              As Byte             ' Reserved area
    aux_request_q(47)                           As Byte             ' Used with datagram request queue
    heartbeat_enable                            As Integer          ' Enable host/PCGEN heartbeat monitoring
    heartbeat_timeout_multiplier                As Byte             ' Heartbeat time interval
    reserved_2(4929)                            As Byte             ' Reserved area
    devices(31)                                 As DEVICE_CONFIG    ' Device configuration table
    directed_control_input_table(127)           As Byte             ' PCGEN Directed Control input table
    broadcast_control_output_table(127)         As Byte             ' PCGEN Broadcast Control output table
    device_io_table(8191)                       As Byte             ' Device I/O table
End Type    'Shared_RAM_Interface

'## Shared RAM Interface Access Macro
'Public SRI As Shared_RAM_Interface
'#define SRI ((volatile Shared_RAM_Interface *)this.MemoryBaseAddress)

'## ----------------------------------------------------------------------------
' Control register declarations
Public Const BoardResetRelease                 As Byte = &H40
Public Const WDT_Disable                       As Byte = &H20
Public Const HHM_PresentTest                   As Byte = &H8
