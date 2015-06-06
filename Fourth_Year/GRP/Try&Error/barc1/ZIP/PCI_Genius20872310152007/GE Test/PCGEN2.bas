Attribute VB_Name = "PCGEN2"



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
    SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 1), Setup.reference_address, 2
    SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 3), Setup.broadcast_control_data_length, 1
    SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 4), Setup.directed_control_data_length, 1
    SetVar (MemoryBaseAddress + SRI_GENI_SETUP_OFFSET + 5), Setup.io_buffer_length, 1

    '## Set up command block for configuration change & initiate command
    SetVar (MemoryBaseAddress + SRI_COMMAND_OFFSET + 1), CHANGE_CONFIG, 1
    SetVar (MemoryBaseAddress + SRI_COMMAND_OFFSET), INCOMECMD, 1

    '## Check for command complete; wait a maximum of 1.5 seconds
    tmwait = GetTickCount
    Do While GetTickCount < tmwait + 1500
        status = GetVar(MemoryBaseAddress + SRI_COMMAND_OFFSET, 1)
        If status = CCOMPLETE Or SYNTAXERR Or PROCERR Then Exit Do
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

'## ***************************************************************************
Public Sub GENI_Broadcast_Global_Data(devdata As DEVICE_DATA)

Dim I     As Integer
Dim Setup As GENI_SETUP

    For I = 0 To (Setup.broadcast_control_data_length)
        SRI.broadcast_control_output_table(I) = devdata.broadcast_global_data(I)
    Next I

End Sub

'###############################################################################
'## Method "GENI_Current_Setup" is used to return the SETUP structure from the
'## PCGEN card's dual-port RAM.  See GFK-0845, "Genius I/O Geni Board User's Manual"
'## for details.
'##
'## Inputs
'##        o Pointer to GENI_SETUP record
'##
'## Returns
'##        o GENI_SETUP information from dual-port RAM
'##
'## No side effects
'##
'## PDL:
'##        Return card's setup information from dual-port RAM
'###############################################################################
Public Function GENI_Current_Setup(Setup As GENI_SETUP)

    CopyMemory SRI, ByVal VarPtr(MemoryBaseAddress), 14224
    With Setup
        .configuration_register_settings = SRI.Setup.configuration_register_settings
        '## SBA, baud rate, outputs control
        .reference_address = SRI.Setup.reference_address
        '## Reference address
        .broadcast_control_data_length = SRI.Setup.broadcast_control_data_length
        '## Broadcast control data length
        .directed_control_data_length = SRI.Setup.directed_control_data_length
        '## Directed control data length
        .io_buffer_length = SRI.Setup.io_buffer_length
        '## I/O buffer length
    End With 'setup

End Function

'###############################################################################
'## Method "GENI_Current_Status" is used to return the STATUS structure from the
'## PCGEN card's dual-port RAM.  See GFK-0845, "Genius I/O Geni Board User's Manual"
'## for details.
'##
'## Inputs
'##        o Pointer to GENI_STATUS record
'##
'## Returns
'##        o GENI_STATUS information from dual-port RAM
'##
'## No side effects
'##
'## PDL:
'##        Return card's status information from dual-port RAM
'###############################################################################
Public Function GENI_Current_Status(status As GENI_STATUS)

    With status
        .firmware_revision = SRI.status.firmware_revision
        .ok_status = SRI.status.ok_status
        .hardware_status = SRI.status.hardware_status
        .bus_status = SRI.status.bus_status
        .bus_error_count = SRI.status.bus_error_count
        .bus_scan_time = SRI.status.bus_scan_time
    End With 'status

End Function

'// ############################################################################
'// Destructor "~GENI" is used to destroy a GENI class object, releasing all of
'// its resources in the process.  The PCGEN card itself is placed into reset.
'//
'// Inputs
'//        o None
'//
'// Returns nothing
'//
'// Side effects:
'//        o Stores destructor failure error in class static variable "InitializationResult".
'//
'// PDL:
'//        Write board reset to card's control register
'//        Free dual-port memory area
'// ############################################################################
Public Sub GENI_Destruct()

Dim result     As Boolean
Dim dwret      As Long
Dim DeviceData As GENPORT_WRITE_INPUT

    If hWin32Device <> INVALID_HANDLE_VALUE Then
        '// Turn off card
        DeviceData.PortNumber = CONTROL_REG
        DeviceData.WriteData = 0
        IOCTL_GEGENIUS_WRITE_PORT = CTL_CODE(FILE_DEVICE_UNKNOWN, &H911, METHOD_BUFFERED, FILE_WRITE_ACCESS)
        result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_WRITE_PORT, DeviceData, ByVal CLng(LenB(DeviceData)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
        If Not result Then
            InitializationResult = Err.LastDllError()
            'Exit Sub
        End If
        '// Free Shared Memory range
        IOCTL_GEGENIUS_UNMAP_MEMORY = CTL_CODE(FILE_DEVICE_UNKNOWN, &H913, METHOD_BUFFERED, FILE_ANY_ACCESS)
        result = DeviceIoControl(hWin32Device, IOCTL_GEGENIUS_UNMAP_MEMORY, MemoryBaseAddress, ByVal CLng(LenB(MemoryBaseAddress)), CLng(0), ByVal CLng(0), dwret, ByVal CLng(0))
        If Not result Then
            InitializationResult = Err.LastDllError()
            'Exit Sub
        End If
        '// Close windows handle
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

Dim result    As Boolean
Dim dwret     As Long   ' System.UInt32

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
    If result = 0 Then
        GENI_LocateCard = (CInt(Fix(Err.LastDllError())))
        LocationResult = (CInt(Fix(Err.LastDllError())))
    Else 'NOT RESULT...
        GENI_LocateCard = (GENI_NoError)
        LocationResult = (GENI_NoError)
    End If

End Function

'## ***************************************************************************
'## ***************************************************************************
Public Sub GENI_Return_Broadcast_Global_Data(devdata As DEVICE_DATA)

Dim I     As Integer
Dim Setup As GENI_SETUP

    For I = 0 To (Setup.broadcast_control_data_length)
        devdata.broadcast_global_data(I) = SRI.broadcast_control_output_table(I)
    Next I

End Sub

'###############################################################################
'## Method "GENI_Return_Device_Data" is used to return all the broadcast and
'## directed control data provided by a particular device.  See GFK-0845, "Genius
'## I/O Geni Board User's Manual" for details.
'##
'## Inputs
'##        o Serial Bus Address of device to access
'##        o Pointer to structure used to store I/O data
'##
'## Returns
'##        o Result of setup change
'##            - GENI_NoError
'##            - GENI_NotOK
'##            - GENI_BadSBAReference
'##            - GENI_InappropriateDevice
'##            - GENI_IOTable_Lockout_Failure
'##            - GENI_NoDevice
'##
'## Side effects
'##        o Dual-port RAM locked out for multi-byte coherent access to I/O data
'##          (except in case of 8 circuit discrete blocks)
'##
'## PDL:
'##        Use device model number to determine type And quantity of data supported
'##        Look up requested data in dual port RAM device I/O tables
'###############################################################################
Public Function GENI_Return_Device_Data(SBA As Integer, _
                                        devdata As DEVICE_DATA) As Integer

'## Serial Bus Address of device to access  '## Storage for device's data

Dim I      As Integer
Dim result As Integer
Dim Setup  As GENI_SETUP

    ''Dim iOffset As Integer
    '## Check for PCGEN card itself to be OK
    If Not (SRI.status.ok_status And GENI_OK) Then
        GENI_Return_Device_Data = (GENI_NotOK)
    End If
    '## Verify that caller provided SBA is valid, then use it to check for
    '## device present
    If ((SBA < 0) Or (SBA > 31)) Then
        GENI_Return_Device_Data = (GENI_BadSBAReference)
    End If
    If Not (SRI.devices(SBA).device_present) Then
        If SBA <> SerialBusAddress Then
            GENI_Return_Device_Data = (GENI_NoDevice)
        End If
    End If
    If SBA <> SerialBusAddress Then
        devdata.block_type = SRI.devices(SBA).model_number
    Else  '## This PCGEN device, which is of type GENI'NOT SBA...
        devdata.block_type = DevType_GENI
    End If
    Select Case (devdata.block_type)
    Case DevType_Circ_8_115VAC_Grouped_PhaseA                '## (IC660CBD100)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA        '## (IC660CBS100)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_8_115VAC_2A_Grouped                    '## (IC660BBD100)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_8_115VAC_125VDC_Isolated                '## (IC660BBS100)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_8_220VAC_Grouped                        '## (IC660??????)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_8_115VAC_LowLeakage_Grouped            '## (IC660BBD101)
        '## Only 1 byte of data no need to lockout I/O table
        'devdata.discrete_blocks(0) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + 0)
        result = GENI_NoError
    Case DevType_Circ_16_24VDC_48VDC_Sink_PhaseA            '## (IC660CBD021)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_24VDC_48VDC_Source_PhaseA            '## (IC660CBD020)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_24VDC_48VDC_Sink                    '## (IC660BBD020 / IC660BBD023)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_12VDC_24VDC_48VDC_Source            '## (IC660BBD021 / IC660BBD022)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_Normally_Open_Relay                '## (IC660BBR101)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_Normally_Closed_Relay                '## (IC660BBR100)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_16_115VAC_Input                        '## (IC660BBD110)
        '## Two bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 1
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_32_5VDC_12VDC_24VDC_Sink                '## (IC660BBD025)
        '## Four bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Circ_32_12VDC_24VDC_Source                '## (IC660BBD024)
        '## Four bytes of data required must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3
            '     devdata.discrete_blocks(i) = SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + i)
        Next I
        result = RemoveIOTableLockout()
    Case DevType_Voltage_Current_4in_2out_Analog_115VAC             '## (IC660BBA100)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC         '## (IC660BBA020)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_Voltage_Current_4in_2out_Analog_115VAC_PhaseA         '## (IC660CBA100)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC_PhaseA '## (IC660CBA020)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_Current_Source_4in_2out_Analog_115VAC_125VDC         '## (IC660BBA104)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_Current_Source_4in_2out_Analog_24VDC_48VDC         '## (IC660BBA024)
        '## Twelve total bytes of data required (8 bytes inputs, 4 bytes outputs)
        '## must lock out I/O table
        result = RequestIOTableLockout()
        If result <> GENI_NoError Then
            GoTo endselect
        End If
        For I = 0 To 3 '## Access analog inputs from input portion of table (8 bytes)
            'iOffset = 2 * i
            '     devdata.ANALOG_4IN_2OUT.analog_inputs(i) =
            'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
            '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
        Next I
        '## Check to see if this device is the assigned controller if so, can copy
        '## outputs from output table, else must request via datagram
        If Not (SRI.devices(SBA).outputs_disable) Then  '## outputs are enabled
            For I = 0 To 1 '## Access analog outputs from output portion of table
                'iOffset = (32 * SRI.setup.io_buffer_length) + (2 * i)
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.device_io_table ((SBA * SRI.setup.io_buffer_length) + iOffset) +
                '256 * SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + (iOffset + 1))
            Next I
            result = RemoveIOTableLockout()
        Else   '## outputs are disabled request analog outputs via datagram'NOT NOT...
            result = RemoveIOTableLockout()  '## can release I/O table from lockout
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            result = ReadBlockIODatagram(SBA, 22, 4)   '## only need outputs
            If result <> GENI_NoError Then
                GoTo endselect
            End If
            For I = 0 To 1 '## Need to skip first two "overhead" bytes...
                'iOffset = 2 * i
                '         devdata.ANALOG_4IN_2OUT.analog_outputs(i) =
                'SRI.read_datagram_buffer (2 + 0 + iOffset) +
                '256 * SRI.read_datagram_buffer(2 + 0 + iOffset + 1)
            Next I
        End If
    Case DevType_GENI
    Case DevType_Series_9070_Bus_Controller
    Case 0 'DevType_Series_9030_Bus_Controller:
        If SBA <> SerialBusAddress Then    '## GENI or GBC device on the bus
            Select Case (SRI.devices(SBA).broadcast_control_data_length)
            Case 10  '## device is not broadcasting ANY data
                result = GENI_NoError
            Case 1  '## 1 byte being broadcast no need to lock out I/O table
                devdata.broadcast_global_data(0) = SRI.device_io_table((SBA * SRI.Setup.io_buffer_length) + 0)
                result = GENI_NoError
            Case Else   '## (2..128 bytes being broadcast must lock out I/O table
                '      result = RequestIOTableLockout()
                '      If (result <> GENI_NoError) Then GoTo endselect
                For I = 0 To 128 'UBound(SRI.devices(SBA).broadcast_control_data_length)
                    devdata.broadcast_global_data(I) = SRI.device_io_table((SBA * SRI.Setup.io_buffer_length) + I)
                Next I
                '     result = RemoveIOTableLockout()
            End Select
            '         Else   '## This PCGEN device return its directed control input data
            '             GENI_Current_Setup (Andsetup)
            '             For i = 0 To UBound(setup.directed_control_data_length)
            '                 devdata.directed_control_data(i) = SRI.directed_control_input_table(i)
            '             Next i
        End If
    Case Else
        '## @@ Need to expand other data producing/consuming devices here as well...
        result = GENI_InappropriateDevice  '## Unknown or @@unsupported device...
endselect:
    End Select
    GENI_Return_Device_Data = (result)

End Function

'## ***************************************************************************
'## ***************************************************************************
Public Function GENI_Return_Directed_Control_Output_Data(ByVal iSBA As Integer, _
                                                         devdata As DEVICE_DATA) As Integer

'Dim i As Integer

Dim iResult As Integer

    Select Case (SRI.devices(iSBA).directed_control_data_length)
    Case 0
        iResult = GENI_NoError
    Case 1
        '      devdata.directed_control_data(0) =
        'SRI.device_io_table (((32 + iSBA) * SRI.setup.io_buffer_length) + 0)
        iResult = GENI_NoError
    Case Else          '## case 2..128
        iResult = RequestIOTableLockout()
        '       If (iResult <> GENI_NoError) Then End Select
        '       For i = 0 To UBound(SRI.devices(iSBA).directed_control_data_length)
        '           devdata.directed_control_data(i) =
        ''               SRI.device_io_table(((32 + iSBA) * SRI.setup.io_buffer_length) + i)
        '       Next i
        iResult = RemoveIOTableLockout()
    End Select
    GENI_Return_Directed_Control_Output_Data = (iResult)

End Function

'###############################################################################
Public Function ReadBlockIODatagram(ByVal SBA As Integer, _
                                    ByVal Offset As Byte, _
                                    NoBytes As Byte) As Integer

'## Device SBA to interrogate   '## Starting offset in block data memory    '## Number of data bytes to return

Dim iResult As Integer

    '## Set up datagram for transmission -- tells block how many bytes
    '## to return from a given starting offset
    With SRI
        .transmit_datagram_buffer(0) = Offset
        .transmit_datagram_buffer(1) = NoBytes
        '## Set up command block for transmit datagram with reply And initiate command
        .command_block.COMMAND = XMIT_DATAGRAM_WITH_REPLY
        '    SRI.command_block.xmit_with_reply_datagram_options.Destination = CByte(LOBYTE(LOWORD(SBA)))
        '    SRI.command_block.xmit_with_reply_datagram_options.Function = GEF_DATAGRAM
        '    SRI.command_block.xmit_with_reply_datagram_options.Xmit_Subfunction = SF_READ_BLOCK_IO
        '    SRI.command_block.xmit_with_reply_datagram_options.Recv_Subfunction = SF_READ_BLOCK_IO_REPLY
        '    SRI.command_block.xmit_with_reply_datagram_options.Priority = NORMAL_PRIORITY
        '    SRI.command_block.xmit_with_reply_datagram_options.Xmit_Length = 2
    End With 'SRI
    iResult = TransmitDatagramWithReply(NoBytes + 2)  '## Data bytes + xmit echo
    ReadBlockIODatagram = (iResult)

End Function

'###############################################################################
'## Method "ReadConfigurationDatagram" is used to request a segment of an I/O block's
'## configuration data via a "Transmit Datagram with Reply" command.  See GFK-0845,
'## "Genius I/O Geni Board User's Manual" for details on configuration formats.
'## See GEK-90486F-1, "Genius I/O System and Communications User's Manual for
'## details on datagrams.
'##
'## Inputs
'##        o Serial Bus Address of device to interrogate
'##        o Offset into device's configuration data
'##        o Number of consecutive bytes of configuration data requested
'##
'## Returns
'##        o Result of configuration data request
'##            - GENI_NoError
'##            - GENI_BadReplyLength
'##            - GENI_BadCommandSyntax
'##            - GENI_CommandProcessingError
'##            - GENI_CommandTimeout
'##            - GENI_UnknownError
'##
'## Side effects
'##        o "Read Datagram Buffer" in dual port RAM filled in with requested data
'##
'## PDL:
'##        Fill in Transmit Datagram With Reply datagram in dual-port RAM
'##        Initiate command to return portion of device's configuration data
'##        Wait a maximum of 10 seconds for command to complete
'###############################################################################
Public Function ReadConfigurationDatagram(ByVal SBA As Integer, _
                                          ByVal Offset As Byte, _
                                          NoBytes As Byte) As Integer

'## Device SBA to interrogate   '## Starting offset in block cfg memory '## Number of cfg bytes to return

Dim iResult As Integer

    '## Set up datagram for transmission -- tells block how many bytes
    '## to return from a given starting offset
    With SRI
        .transmit_datagram_buffer(0) = Offset
        .transmit_datagram_buffer(1) = NoBytes
        '## Set up command block for transmit datagram with reply And initiate command
        .command_block.COMMAND = XMIT_DATAGRAM_WITH_REPLY
        '    SRI.command_block.xmit_with_reply_datagram_options.Destination = CByte(LOBYTE(LOWORD(SBA)))
        '    SRI.command_block.xmit_with_reply_datagram_options.Function = GEF_DATAGRAM
        '    SRI.command_block.xmit_with_reply_datagram_options.Xmit_Subfunction = SF_READ_CONFIG
        '    SRI.command_block.xmit_with_reply_datagram_options.Recv_Subfunction = SF_READ_CONFIG_REPLY
        '    SRI.command_block.xmit_with_reply_datagram_options.Priority = NORMAL_PRIORITY
        '    SRI.command_block.xmit_with_reply_datagram_options.Xmit_Length = 2
    End With 'SRI
    iResult = TransmitDatagramWithReply(NoBytes + 2)  '## Cfg bytes + xmit echo
    ReadConfigurationDatagram = (iResult)

End Function

'###############################################################################
'## Method "ReadIdentificationDatagram" is used to ...
'###############################################################################
Public Function ReadIdentificationDatagram(ByVal SBA As Integer) As Integer

'## Device SBA to interrogate

Dim iResult As Integer

    '## Set up command block for transmit datagram with reply And initiate command
    SRI.command_block.COMMAND = XMIT_DATAGRAM_WITH_REPLY
    '    SRI.command_block.xmit_with_reply_datagram_options.Destination = CByte(LOBYTE(LOWORD(SBA)))
    '    SRI.command_block.xmit_with_reply_datagram_options.Function = GEF_DATAGRAM
    '    SRI.command_block.xmit_with_reply_datagram_options.Xmit_Subfunction = SF_READ_ID
    '    SRI.command_block.xmit_with_reply_datagram_options.Recv_Subfunction = SF_READ_ID_REPLY
    '    SRI.command_block.xmit_with_reply_datagram_options.Priority = NORMAL_PRIORITY
    '    SRIcommand_block.xmit_with_reply_datagram_options.Xmit_Length = 0
    iResult = TransmitDatagramWithReply(12)
    ReadIdentificationDatagram = (iResult)

End Function

'###############################################################################
'## Method "RemoveIOTableLockout" is used to remove the lock out of the dual-port
'## shared RAM to allow normal access on the field side.  See GFK-0845, "Genius
'## I/O Geni Board User's Manual" for details.
'##
'## Inputs
'##        o None
'##
'## Returns
'##        o Result of setup change
'##            - GENI_NoError
'##            - GENI_IOTable_Lockout_Failure
'##
'## Side effects
'##        o I/O table entries can again be updated by the PCGEN card field side
'##
'## PDL:
'##        Release I/O table lockout semaphore
'##        Wait maximum of 1.5 seconds for the lockout release to be recognized
'###############################################################################
Public Function RemoveIOTableLockout() As Integer

'Dim clkStart As Double
'Dim duration As Double

    '## Can release lockout semaphore when request and state are both true
'    If SRI.iotable_lockout_request And SRI.iotable_lockout_state Then
'        SRI.iotable_lockout_request = False
'    Else 'NOT SRI.IOTABLE_LOCKOUT_REQUEST...
'        RemoveIOTableLockout = (GENI_IOTable_Lockout_Failure)
'    End If
    '## Wait maximum of 1.5 seconds for state to go false, indicating release acknowledged
'    clkStart = getticktime
'    Do While (SRI.iotable_lockout_state) And (duration <= 1500)
'        Sleep (10)
'        duration = getticktime - clkStart
'        DoEvents
'    Loop
'    If SRI.iotable_lockout_state Then
'        RemoveIOTableLockout = (GENI_IOTable_Lockout_Failure)
'    Else 'SRI.IOTABLE_LOCKOUT_STATE = FALSE/0
'        RemoveIOTableLockout = (GENI_NoError)
'    End If

End Function

'###############################################################################
'## Method "RequestIOTableLockout" is used to lock out the dual-port shared RAM
'## from access on the field side, in order to ensure data coherency for the host.
'## The lockout should be released as soon as possible to avoid degrading I/O
'## throughput performance.  See GFK-0845, "Genius I/O Geni Board User's Manual"
'## for details.
'##
'## Inputs
'##        o None
'##
'## Returns
'##        o Result of setup change
'##            - GENI_NoError
'##            - GENI_IOTable_Lockout_Failure
'##
'## Side effects
'##        o I/O table entries cannot be updated by the PCGEN card field side
'##
'## PDL:
'##        Set I/O table lockout semaphore
'##        Wait maximum of 1.5 seconds for the lockout to be recognized
'###############################################################################
Public Function RequestIOTableLockout() As Integer

Dim clkStart As Double
Dim duration As Double

    '## Can set lockout semaphore when request and state are both false
    If Not (SRI.iotable_lockout_request) And Not (SRI.iotable_lockout_state) Then
        SRI.iotable_lockout_request = True
    Else 'NOT NOT...
        RequestIOTableLockout = (GENI_IOTable_Lockout_Failure)
    End If
    '## Wait maximum of 1.5 seconds for state to go true, indicating semaphore acknowledged
    clkStart = GetTickCount
    Do While Not (SRI.iotable_lockout_state) And (duration <= 1500)
        'Sleep (10)
        duration = GetTickCount = clkStart
        DoEvents
    Loop
    If Not (SRI.iotable_lockout_state) Then
        RequestIOTableLockout = (GENI_IOTable_Lockout_Failure)
    Else 'NOT NOT...
        RequestIOTableLockout = (GENI_NoError)
    End If

End Function

'
'###############################################################################
'###############################################################################
Public Function TransmitDatagramWithReply(ByVal iNoReplyBytes As Integer) As Integer

Dim clkStart As Double
Dim duration As Double
Dim status   As Byte

    SRI.command_block.status = INCOMECMD  '## Initiate command
    '## Check for command complete wait a maximum of 10 seconds
    clkStart = GetTickCount
    Do While Not ((status And (CCOMPLETE Or SYNTAXERR Or PROCERR)) And (duration <= 10000))
        'Sleep (4) '## Typical minimum Genius bus scan time let other tasks run
        duration = GetTickCount - clkStart
        status = SRI.command_block.status
        DoEvents
    Loop
    '## Return any error result of command
    If ((status And SYNTAXERR) = SYNTAXERR) Then
        TransmitDatagramWithReply = (GENI_BadCommandSyntax)
    ElseIf ((status And PROCERR) = PROCERR) Then 'NOT ((STATUS...
        TransmitDatagramWithReply = (GENI_CommandProcessingError)
    ElseIf (duration > 10000) Then 'NOT ((STATUS...
        TransmitDatagramWithReply = (GENI_CommandTimeout)
    ElseIf ((status And CCOMPLETE) <> CCOMPLETE) Then 'NOT (DURATION...
        TransmitDatagramWithReply = (GENI_UnknownError)
        'If (SRI.command_block.xmit_with_reply_datagram_options.Recv_Length <> iNoReplyBytes) Then
        '    TransmitDatagramWithReply = (GENI_BadReplyLength)
        'Else
        '    TransmitDatagramWithReply = (GENI_NoError)
        'End If
    End If

End Function

''
'''###############################################################################
'''## Method "GENI_PCI_Address" is used to return a pointer to the start of the
'''## PCGEN card's dual port memory.  This routine is provided to display debugging
'''## information when needed.  User's should not have to access dual port memory
'''## directly rather, additional methods should be supplied as required.
'''##
'''## Inputs
'''##        o None
'''##
'''## Returns
'''##        o Pointer to dual-port memory
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Return pointer to card's dual-port memory
'''###############################################################################
''Public Function GENI_PCI_Address() As Long
''
''
''
''
''GENI_PCI_Address = MemoryBaseAddress
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Windows_Handle" is used to return the handle assigned to the
'''## PCGEN card by Windows.  This routine is provided to display debugging
'''## information when needed.  User's should not have to access card registers
'''## directly rather, additional methods should be supplied as required.
'''##
'''## Inputs
'''##        o None
'''##
'''## Returns
'''##        o Windows device handle
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Return card's Windows device handle
'''###############################################################################
''Public Function GENI_Windows_Handle() As Long
''
''
''
''
''GENI_Windows_Handle = hWin32Device
''End Function
''
''
'''
'''###############################################################################
'''## Method "GENI_Change_Setup" is used to change the contents of one or more
'''## SETUP structure components in the PCGEN card's dual-port RAM.  See GFK-0845,
'''## "Genius I/O Geni Board User's Manual" for details.
'''##
'''## Inputs
'''##        o Pointer to filled in GENI_SETUP record (all except configuration settings)
'''##
'''## Returns
'''##        o Result of setup change
'''##            - GENI_NoError
'''##            - GENI_NotOK
'''##            - GENI_Busy
'''##            - GENI_BadCommandSyntax
'''##            - GENI_CommandProcessingError
'''##            - GENI_CommandTimeout
'''##            - GENI_UnknownError
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Copy new setup information into card's dual-port RAM
'''##        Initiate configuration change command
'''##        Wait maximum of 1.5 seconds for command to complete
'''###############################################################################
''Public Function GENI_Change_Setup(setup As GENI_SETUP) As Integer   '## GENI_SETUP structure
''
''
''
''Dim clkStart As Long
''Dim duration As Double
''Dim status   As Byte
'''
''CopyMemory SRI.setup, ByVal VarPtr(MemoryBaseAddress + 19), 16
'''    '## Check for GENI OK _and_ command block is free
''If ((SRI.status.ok_status And GENI_OK) = False) Then
''GENI_Change_Setup = (GENI_NotOK)
''End If
''If ((SRI.command_block.status And INPROGRESS) <> False) Then
''GENI_Change_Setup = (GENI_Busy)
''End If
'''    '## Update setup data in Shared RAM
''
''With SRI
''.setup.reference_address = setup.reference_address
''.setup.broadcast_control_data_length = setup.broadcast_control_data_length
''.setup.directed_control_data_length = setup.directed_control_data_length
''.setup.io_buffer_length = setup.io_buffer_length
'''    '## Set up command block for configuration change And initiate command
''.command_block.COMMAND = CHANGE_CONFIG
''.command_block.status = INCOMECMD
'''
'''    '## Check for command complete wait a maximum of 1.5 seconds
''End With 'SRI
''clkStart = GetTickCount
''Do While Not ((status And (CCOMPLETE Or SYNTAXERR Or PROCERR)) And (duration <= 1500))
''duration = GetTickCount - clkStart
''status = SRI.command_block.status
''DoEvents
''Loop
'''
'''    '## Return result of configuration change command
''If ((status And CCOMPLETE) = CCOMPLETE) Then
''GENI_Change_Setup = (GENI_NoError)
''ElseIf ((status And SYNTAXERR) = SYNTAXERR) Then
''GENI_Change_Setup = (GENI_BadCommandSyntax)
''ElseIf ((status And PROCERR) = PROCERR) Then
''GENI_Change_Setup = (GENI_CommandProcessingError)
''ElseIf (duration > 1.5) Then
''GENI_Change_Setup = (GENI_CommandTimeout)
''Else
''GENI_Change_Setup = (GENI_UnknownError)
''End If
''CopyMemory ByVal VarPtr(MemoryBaseAddress + 19), SRI.setup, 16
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Device_Configuration" is used to return the DEVICE_CONFIG
'''## structure from the PCGEN card's dual-port RAM, for a device of interest
'''## located at a specific SBA on the Genius bus.  See GFK-0845, "Genius I/O Geni
'''## Board User's Manual" for details.
'''##
'''## Inputs
'''##        o Pointer to DEVICE_CONFIG record
'''##
'''## Returns
'''##        o GENI_STATUS information from dual-port RAM
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Return device configuration from dual-port RAM for given SBA on the bus
'''###############################################################################
''Public Sub GENI_Device_Configuration(ByVal SBA As Integer, dcb As DEVICE_CONFIG)
''
''
''
''
''
'''## Device SBA  '## Device configuration
''CopyMemory SRI, ByVal VarPtr(MemoryBaseAddress), 14224
''
''With dcb
''.model_number = SRI.devices(SBA).model_number
''.outputs_disable = SRI.devices(SBA).outputs_disable
''.device_present = SRI.devices(SBA).device_present
''.reference_address = SRI.devices(SBA).reference_address
''.broadcast_control_data_length = SRI.devices(SBA).broadcast_control_data_length
''.directed_control_data_length = SRI.devices(SBA).directed_control_data_length
''.block_config = SRI.devices(SBA).block_config
'''    return
''End With 'dcb
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Return_IO_Block_Configuration" is used to return an I/O block's
'''## configuration data.  See GFK-0845, "Genius I/O Geni Board User's Manual" for
'''## details.
'''##
'''## Inputs
'''##        o Serial Bus Address of device to interrogate
'''##        o Pointer to structure into which the configuration data will be placed
'''##
'''## Returns
'''##        o Result of configuration data request
'''##            - GENI_NoError
'''##            - GENI_NoDevice
'''##            - GENI_InappropriateDevice
'''##            - GENI_NotOK
'''##            - GENI_Busy
'''##            - GENI_BadReplyLength
'''##            - GENI_BadCommandSyntax
'''##            - GENI_CommandProcessingError
'''##            - GENI_CommandTimeout
'''##            - GENI_UnknownError
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Use device model number to determine number of data requests required
'''##        Issue command(s) to the device to return all its configuration data
'''###############################################################################
''Public Function GENI_Return_IO_Block_Configuration(SBA As Integer, iocb As IO_CONFIG) As Integer
''
''
''
''
''
'''## Device SBA to interrogate   '## Point to IO_CONFIG structure
''Dim result As Integer
''Dim i      As Integer
'''## Check for GENI OK _and_ command block is free
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_Return_IO_Block_Configuration = (GENI_NotOK)
''ElseIf (SRI.command_block.status And INPROGRESS) Then
''GENI_Return_IO_Block_Configuration = (GENI_Busy)
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_Return_IO_Block_Configuration = (GENI_BadSBAReference)
''ElseIf Not (SRI.devices(SBA).device_present) Then
''
'''        If (SBA = SRI.SerialBusAddress) Then
'''            GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)
'''        Else
'''            GENI_Return_IO_Block_Configuration = (GENI_NoDevice)
'''        End If
''End If
'''## The number of datagrams required to obtain the requested configuration
'''## data from a block depends on the model number.  The maximum number of
'''## bytes which can be requested in a single datagram is 16.
''Select Case (SRI.devices(SBA).model_number)
'''## ********************************
'''## 8 Circuit Discrete I/O Blocks **
'''## ********************************
''Case DevType_Circ_8_115VAC_Grouped_PhaseA            '## (IC660CBD100)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
''Case DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA    '## (IC660CBS100)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
''Case DevType_Circ_8_115VAC_2A_Grouped                '## (IC660BBD100)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
''Case DevType_Circ_8_115VAC_125VDC_Isolated            '## (IC660BBS100 / IC660BBS101)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
''Case DevType_Circ_8_220VAC_Grouped                    '## (IC660??????)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
''Case DevType_Circ_8_115VAC_LowLeakage_Grouped        '## (IC660BBD101)
'''## 8 circuit blocks have 12 bytes of configuration data
'''## Request all in one message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## ************************************************************************
'''## 16 Circuit Discrete I/O Blocks (except 16 Circuit 115VAC Input Block) **
'''## ************************************************************************
''Case DevType_Circ_16_24VDC_48VDC_Sink_PhaseA            '## (IC660CBD021)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_16_24VDC_48VDC_Source_PhaseA            '## (IC660CBD020)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_16_24VDC_48VDC_Sink                    '## (IC660BBD020 / IC660BBD023)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_16_12VDC_24VDC_48VDC_Source            '## (IC660BBD021 / IC660BBD022)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_16_Normally_Open_Relay                '## (IC660BBR101)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_16_Normally_Closed_Relay                '## (IC660BBR100)
'''## 16 circuit blocks have 20 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 ' 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
'''## ********************************
'''## 16 Circuit 115VAC Input Block **
'''## ********************************
''Case DevType_Circ_16_115VAC_Input                        '## (IC660BBD110)
'''## 16 circuit 115VAC input blocks have 26 bytes of configuration data
'''## Request in two messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
'''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
'''iocb.discrete_io_config.circuit_config = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 and point info in second message
''result = ReadConfigurationDatagram(SBA, 12, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy circuit configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer),
'''## then additional point config info
''For i = 0 To 7 ' 8 circuits to copy: 9..16
'''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
'''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
'''iocb.discrete_io_config.points_1to8_input_filter_time = SRI.read_datagram_buffer(10)
'''iocb.discrete_io_config.points_9to16_input_filter_time = SRI.read_datagram_buffer(11)
'''iocb.discrete_io_config.points_1to8_open_off_threshold = SRI.read_datagram_buffer(12)
'''iocb.discrete_io_config.points_1to8_on_off_threshold = SRI.read_datagram_buffer(13)
'''iocb.discrete_io_config.points_9to16_open_off_threshold = SRI.read_datagram_buffer(14)
'''iocb.discrete_io_config.points_9to16_on_off_threshold = SRI.read_datagram_buffer(15)
'''## *********************************
'''## 32 Circuit Discrete I/O Blocks **
'''## *********************************
''Case DevType_Circ_32_5VDC_12VDC_24VDC_Sink                '## (IC660BBD025)
'''## 32 circuit blocks have 36 bytes of configuration data
'''## Request in three messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 '## 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
'''## Retrieve circuits 17-32 in third message
''result = ReadConfigurationDatagram(SBA, 20, 16)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
''Next i
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 15 '## 16 circuits to copy: 17..32
''iocb.discrete_io_config.circuit_config(16 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
''Case DevType_Circ_32_12VDC_24VDC_Source                '## (IC660BBD024)
'''## 32 circuit blocks have 36 bytes of configuration data
'''## Request in three messages
'''## Retrieve block info and circuits 1-8 in first message
''result = ReadConfigurationDatagram(SBA, 0, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''Next i
''End With 'iocb
''For i = 0 To 7 ' 8 circuits to copy: 1..8
''iocb.discrete_io_config.circuit_config(i) = SRI.read_datagram_buffer(6 + i)
''Next i
'''## Retrieve circuits 9-16 in second message
''result = ReadConfigurationDatagram(SBA, 12, 8)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 7 '## 8 circuits to copy: 9..16
''iocb.discrete_io_config.circuit_config(8 + i) = SRI.read_datagram_buffer(2 + i)
'''## Retrieve circuits 17-32 in third message
''result = ReadConfigurationDatagram(SBA, 20, 16)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
''Next i
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''For i = 0 To 15 '## 16 circuits to copy: 17..32
''iocb.discrete_io_config.circuit_config(16 + i) = SRI.read_datagram_buffer(2 + i)
''Next i
'''## *****************************
'''## 4 In / 2 Out Analog Blocks **
'''## *****************************
''Case DevType_Voltage_Current_4in_2out_Analog_115VAC              '## (IC660BBA100)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''    (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''    (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''    (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''    (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''    (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''    (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''    (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''    (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''    (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''    (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''    (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
''Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC          '## (IC660BBA020)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)'
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
''Case DevType_Voltage_Current_4in_2out_Analog_115VAC_PhaseA          '## (IC660CBA100)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
''Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC_PhaseA  '## (IC660CBA020)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
''Case DevType_Current_Source_4in_2out_Analog_115VAC_125VDC          '## (IC660BBA104)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)'
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
''Case DevType_Current_Source_4in_2out_Analog_24VDC_48VDC          '## (IC660BBA024)
'''## 4 In / 2 Out analog blocks have 84 bytes of configuration data
'''## It is recommended that each channel's configuration data be retrieved in
'''## individual, separate datagrams.  Request total config in seven messages.
'''## Retrieve block info in first message
''result = ReadConfigurationDatagram(SBA, 0, 4)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
''
''With iocb
''.block_type = SRI.read_datagram_buffer(2)
''.firmware_revision = SRI.read_datagram_buffer(3)
''.block_config_1 = SRI.read_datagram_buffer(4)
''.block_config_2 = SRI.read_datagram_buffer(5)
'''## Retrieve input channel 1 in second message
''End With 'iocb
''result = ReadConfigurationDatagram(SBA, 4, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 2 in third message
''result = ReadConfigurationDatagram(SBA, 18, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)'
'''## Retrieve input channel 3 in fourth message
''result = ReadConfigurationDatagram(SBA, 32, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(2).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve input channel 4 in fifth message
''result = ReadConfigurationDatagram(SBA, 46, 14)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_alarm =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_alarm =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.input_channels(3).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(15)) + SRI.read_datagram_buffer(14)
'''## Retrieve output channel 1 in sixth message
''result = ReadConfigurationDatagram(SBA, 60, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(0).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## Retrieve output channel 2 in seventh message
''result = ReadConfigurationDatagram(SBA, 72, 12)
''If result <> GENI_NoError Then
''
''
''GENI_Return_IO_Block_Configuration = (result)
''End If
'''## Command succeeded copy configuration data to provided iocb
'''## (skip first two "overhead" bytes in datagram reply buffer)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).circuit_configuration =
''''                (256 * SRI.read_datagram_buffer(3)) + SRI.read_datagram_buffer(2)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).default_value =
''''                (256 * SRI.read_datagram_buffer(5)) + SRI.read_datagram_buffer(4)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(7)) + SRI.read_datagram_buffer(6)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).high_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(9)) + SRI.read_datagram_buffer(8)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_eu =
''''                (256 * SRI.read_datagram_buffer(11)) + SRI.read_datagram_buffer(10)
'''            iocb.ANALOG_4IN_2OUT_CONFIG.output_channels(1).low_scaling_point_counts =
''''                (256 * SRI.read_datagram_buffer(13)) + SRI.read_datagram_buffer(12)
'''## *************************
'''## 6 Output Analog Blocks **
'''## *************************
''Case DevType_Current_Source_6out_Analog_115VAC_125VDC    '## (IC660BBA105)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
''Case DevType_Current_Source_6out_Analog_24VDC_48VDC    '## (IC660BBA025)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## ************************
'''## 6 Input Analog Blocks **
'''## ************************
''Case DevType_Current_Source_6in_Analog_115VAC_125VDC    '## (IC660BBA106)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
''Case DevType_Current_Source_6in_Analog_24VDC_48VDC        '## (IC660BBA026)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## ******************************
'''## 6 Input Thermocouple Blocks **
'''## ******************************
''Case DevType_6in_Thermocouple_115VAC_125VDC    '## (IC660BBA103)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
''Case DevType_6in_Thermocouple_24VDC_48VDC        '## (IC660BBA023)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## *********************
'''## 6 Input RTD Blocks **
'''## *********************
''Case DevType_6in_RTD_115VAC_125VDC    '## (IC660BBA101)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
''Case DevType_6in_RTD_24VDC_48VDC    '## (IC660BBA021)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## *****************************************
'''## High speed counter (types A,B,C) Block **
'''## *****************************************
''Case DevType_High_Speed_Counter    '## (IC660BBD120)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## ******************
'''## PowerTRAC Block **
'''## ******************
''Case DevType_PowerTRAC    '## (IC660BPM100)
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)   '## @@ Not implemented yet!!!
'''## ****************************
'''## Non I/O or Unknown Device **
'''## ****************************
''Case Else
''GENI_Return_IO_Block_Configuration = (GENI_InappropriateDevice)
''End Select
''GENI_Return_IO_Block_Configuration = (GENI_NoError)
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Read_Discrete_Input_Bit" is used to read a single discrete bit
'''## (or circuit) from a device capable of producing discrete inputs.  Note that
'''## the bit requested may not actually be configured as an input in the block
'''## configuration, or may not actually be a discrete bit within a device's
'''## broadcasted global data.  See GFK-0845, "Genius I/O Geni Board User's Manual"
'''## for details.
'''##
'''## Inputs
'''##        o Serial Bus Address of device to access
'''##        o Bit / Circuit want status returned for
'''##        o Pointer to variable used to store circuit state
'''##
'''## Returns
'''##        o Result of setup change
'''##            - GENI_NoError
'''##            - GENI_NotOK
'''##            - GENI_BadSBAReference
'''##            - GENI_InappropriateDevice
'''##            - GENI_NoDevice
'''##            - GENI_BadCircuitReference
'''##
'''## No side effects
'''##
'''## PDL:
'''##        Ensure requested circuit present in dual port RAM device input table
'''##        Look up requested circuit in dual port RAM device input table
'''###############################################################################
''Public Function GENI_Read_Discrete_Input_Bit(ByVal SBA As Integer, ByVal Circuit As Byte, CircuitState As Byte) As Integer
''
''
''
''
''
''
'''## Serial Bus Address of device to access  '## Circuit to fetch status of  '## Storage for circuit state
''Dim MaxCircuit As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_Read_Discrete_Input_Bit = (GENI_NotOK)
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_Read_Discrete_Input_Bit = (GENI_BadSBAReference)
''End If
''If Not (SRI.devices(SBA).device_present) Then
''
'''        If (SBA = SRI.SerialBusAddress) Then
'''            GENI_Read_Discrete_Input_Bit = (GENI_InappropriateDevice)
'''        Else
'''            GENI_Read_Discrete_Input_Bit = (GENI_NoDevice)
'''        End If
''End If
'''## Verify that device is of an appropriate type (i.e., is a discrete block,
'''## a global data producing device, etc.) *AND* that it *could* support the
'''## requested circuit
''Select Case (SRI.devices(SBA).model_number)
''Case DevType_Circ_8_115VAC_Grouped_PhaseA                 '## (IC660CBD100)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA         '## (IC660CBS100)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_8_115VAC_2A_Grouped                     '## (IC660BBD100)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated                 '## (IC660BBS100)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_8_220VAC_Grouped                         '## (IC660??????)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_8_115VAC_LowLeakage_Grouped             '## (IC660BBD101)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink_PhaseA             '## (IC660CBD021)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Source_PhaseA             '## (IC660CBD020)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink                     '## (IC660BBD020 / IC660BBD023)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_12VDC_24VDC_48VDC_Source             '## (IC660BBD021 / IC660BBD022)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_Normally_Open_Relay                 '## (IC660BBR101)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_Normally_Closed_Relay                 '## (IC660BBR100)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_16_115VAC_Input                         '## (IC660BBD110)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_32_5VDC_12VDC_24VDC_Sink                 '## (IC660BBD025)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Circ_32_12VDC_24VDC_Source                 '## (IC660BBD024)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_9030_Communications_Module             '## (IC693CMM301)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_9030_Enhanced_Communications_Module '## (IC693CMM302)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_9030_Bus_Controller                 '## (IC693BEM331)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_9070_Bus_Controller                 '## (IC697BEM731)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_9070_Remote_IO_Scanner                 '## (IC697BEM733)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_VersaMax_GBIU                                 '## (IC670GBI001)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_PhaseA             '## (IC660CBB900)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA     '## (IC660CBB901)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_6_Bus_Controller                     '## (IC660CBB902)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags         '## (IC660CBB903)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case DevType_GENI                                         '## (IC660ELB9xx)
''MaxCircuit = SRI.devices(SBA).broadcast_control_data_length * 8
''Case Else
''GENI_Read_Discrete_Input_Bit = (GENI_InappropriateDevice)
''End Select
'''## If reach this point, have a device that *can* support discrete references --
'''##            now check for a good circuit number.
'''## We don't have to worry that the I/O table entries are too small, as the device
'''## could not have logged in if so.
''If ((Circuit < 1) Or (Circuit > MaxCircuit)) Then
''GENI_Read_Discrete_Input_Bit = (GENI_BadCircuitReference)
''End If
'''## No need to lock out I/O table here as we are fetching only a single byte
''CircuitState = (((SRI.device_io_table((SBA * SRI.setup.io_buffer_length) + ((Circuit - 1) > 3))) And (CByte(&H1) < (Circuit - 1))) <> False)
''
''
''
''
''
''
''GENI_Read_Discrete_Input_Bit = (GENI_NoError)
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Write_Discrete_Output_Bit" is used to set/clear a single discrete
'''## bit (or circuit) in a device capable of receiving discrete outputs.  Note that
'''## the bit requested may not actually be configured as an output in the block
'''## configuration.  See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'''##
'''## Inputs
'''##        o Serial Bus Address of device to access
'''##        o Bit / Circuit want to alter output for
'''##        o Circuit state to write to output
'''##
'''## Returns
'''##        o Result of setup change
'''##            - GENI_NoError
'''##            - GENI_NotOK
'''##            - GENI_BadSBAReference
'''##            - GENI_InappropriateDevice
'''##            - GENI_NoDevice
'''##            - GENI_BadCircuitReference
'''##            - GENI_OutputsNotEnabled
'''##
'''## Side effects
'''##        o Dual-port RAM locked out for read/modify/write coherent access to I/O data
'''##
'''## PDL:
'''##        Ensure requested circuit present in dual port RAM device output table
'''##        Write requested circuit to dual port RAM device output table
'''###############################################################################
''Public Function GENI_Write_Discrete_Output_Bit(ByVal SBA As Integer, ByVal Circuit As Byte, ByVal CircuitState As Byte) As Integer
''
''
''
''
''
''
''
''
'''## Serial Bus Address of device to access  '## Circuit to write to '## State to set circuit to
''Dim MaxCircuit As Integer
''Dim result     As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then GENI_Write_Discrete_Output_Bit = (GENI_NotOK)
''
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then GENI_Write_Discrete_Output_Bit = GENI_BadSBAReference
''
''
''
''If Not (SRI.devices(SBA).device_present) Then
''If SBA = SerialBusAddress Then
''
''
''GENI_Write_Discrete_Output_Bit = (GENI_InappropriateDevice)
''
''Else
''GENI_Write_Discrete_Output_Bit = (GENI_NoDevice)
''
''End If
''End If
'''## Verify that device is of an appropriate type (i.e., is a discrete block
'''## or a device capable of receiving discrete directed control data *AND* that
'''## it *could* support the requested circuit
''Select Case (SRI.devices(SBA).model_number)
''Case DevType_Circ_8_115VAC_Grouped_PhaseA                 '## (IC660CBD100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA         '## (IC660CBS100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_2A_Grouped                     '## (IC660BBD100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated                 '## (IC660BBS100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_220VAC_Grouped                         '## (IC660??????)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_LowLeakage_Grouped             '## (IC660BBD101)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink_PhaseA             '## (IC660CBD021)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Source_PhaseA             '## (IC660CBD020)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink                     '## (IC660BBD020 / IC660BBD023)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_12VDC_24VDC_48VDC_Source             '## (IC660BBD021 / IC660BBD022)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_Normally_Open_Relay                 '## (IC660BBR101)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_Normally_Closed_Relay                 '## (IC660BBR100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_32_5VDC_12VDC_24VDC_Sink                 '## (IC660BBD025)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_32_12VDC_24VDC_Source                 '## (IC660BBD024)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9030_Bus_Controller                 '## (IC693BEM331)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9070_Bus_Controller                 '## (IC697BEM731)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9070_Remote_IO_Scanner                 '## (IC697BEM733)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_VersaMax_GBIU                                 '## (IC670GBI001)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_PhaseA             '## (IC660CBB900)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA     '## (IC660CBB901)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller                     '## (IC660CBB902)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags         '## (IC660CBB903)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_GENI                                         '## (IC660ELB9xx)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_115VAC_Input                         '## (IC660BBD110)
''
''Case DevType_Series_9030_Communications_Module             '## (IC693CMM301)
''
''Case DevType_Series_9030_Enhanced_Communications_Module '## (IC693CMM302)
''
''Case Else
''GENI_Write_Discrete_Output_Bit = (GENI_InappropriateDevice)
''
''End Select
'''## If reach this point, have a device that *can* support discrete output
'''##            references -- now check for a good circuit number.
'''## We don't have to worry that the I/O table entries are too small, as the device
'''## could not have logged in if so.
''If ((Circuit < 1) Or (Circuit > MaxCircuit)) Then GENI_Write_Discrete_Output_Bit = GENI_BadCircuitReference
''
''
''
'''## Verify that outputs are enabled for this device
''If (SRI.devices(SBA).outputs_disable) Then GENI_Write_Discrete_Output_Bit = GENI_OutputsNotEnabled
''
''
''
'''## As a read-modify-write cycle will be required, must lockout I/O Table
''result = RequestIOTableLockout()
''If (result <> GENI_NoError) Then GENI_Write_Discrete_Output_Bit = result
''
''
''
'''  If Not (CircuitState) Then '## set circuit to 0 (OFF)
'''      SRI.device_io_table ((32 * SRI.setup.io_buffer_length) +
''''                              (SBA * SRI.setup.io_buffer_length) +
''''                              ((Circuit - 1) > 3))
''''                              And Not (CByte(&H1) < (Circuit - 1))
'''## step over input table
'''## step over preceding output buffers
'''## 8 circuits per byte, numbering starts @ 1
'''## Set specified circuit = 0
'''  Else  '## CircuitState == TRUE set circuit to 1 (ON)
'''      SRI.device_io_table ((32 * SRI.setup.io_buffer_length) +
''''                              (SBA * SRI.setup.io_buffer_length) +
''''                              ((Circuit - 1) > 3))
''''                              Or (CByte(&H1) < (Circuit - 1))
'''## step over input table
'''## step over preceding output buffers
'''## 8 circuits per byte, numbering starts @ 1
'''## Set specified circuit = 1
''result = RemoveIOTableLockout()
''GENI_Write_Discrete_Output_Bit = (result)
''
''End Function
''
''
'''###############################################################################
'''## Method "GENI_Toggle_Discrete_Output_Bit" is used to toggle a single discrete
'''## bit (or circuit) in a device capable of receiving discrete outputs.  Note that
'''## the bit requested may not actually be configured as an output in the block
'''## configuration.  See GFK-0845, "Genius I/O Geni Board User's Manual" for details.
'''## Inputs
'''##        o Serial Bus Address of device to access
'''##        o Bit / Circuit want to alter output for
'''## Returns
'''##        o Result of setup change
'''##            - GENI_NoError
'''##            - GENI_NotOK
'''##            - GENI_BadSBAReference
'''##            - GENI_InappropriateDevice
'''##            - GENI_NoDevice
'''##            - GENI_BadCircuitReference
'''##            - GENI_OutputsNotEnabled
'''## Side effects
'''##        o Dual-port RAM locked out for read/modify/write coherent access to I/O data
'''## PDL:
'''##        Ensure requested circuit present in dual port RAM device output table
'''##        Toggle requested circuit in dual port RAM device output table
'''###############################################################################
''Public Function GENI_Toggle_Discrete_Output_Bit(ByVal SBA As Integer, ByVal Circuit As Byte) As Integer
''
''
''
''
''
''
''
'''## Serial Bus Address of device to access  '## Circuit to write to
''Dim MaxCircuit As Integer
''Dim result     As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_Toggle_Discrete_Output_Bit = (GENI_NotOK)
''
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_Toggle_Discrete_Output_Bit = (GENI_BadSBAReference)
''
''End If
''If Not (SRI.devices(SBA).device_present) Then
''If SBA = SerialBusAddress Then
''
''
''GENI_Toggle_Discrete_Output_Bit = (GENI_InappropriateDevice)
''
''Else
''GENI_Toggle_Discrete_Output_Bit = (GENI_NoDevice)
''
''End If
''End If
'''## Verify that device is of an appropriate type (i.e., is a discrete block
'''## *AND* that it *could* support the requested circuit
''Select Case (SRI.devices(SBA).model_number)
''Case DevType_Circ_8_115VAC_Grouped_PhaseA                 '## (IC660CBD100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated_PhaseA         '## (IC660CBS100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_2A_Grouped                     '## (IC660BBD100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_125VDC_Isolated                 '## (IC660BBS100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_220VAC_Grouped                         '## (IC660??????)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_8_115VAC_LowLeakage_Grouped             '## (IC660BBD101)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink_PhaseA             '## (IC660CBD021)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Source_PhaseA             '## (IC660CBD020)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_24VDC_48VDC_Sink                     '## (IC660BBD020 / IC660BBD023)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_12VDC_24VDC_48VDC_Source             '## (IC660BBD021 / IC660BBD022)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_Normally_Open_Relay                 '## (IC660BBR101)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_Normally_Closed_Relay                 '## (IC660BBR100)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_32_5VDC_12VDC_24VDC_Sink                 '## (IC660BBD025)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_32_12VDC_24VDC_Source                 '## (IC660BBD024)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9030_Bus_Controller                 '## (IC693BEM331)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9070_Bus_Controller                 '## (IC697BEM731)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_9070_Remote_IO_Scanner                 '## (IC697BEM733)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_VersaMax_GBIU                                 '## (IC670GBI001)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_PhaseA             '## (IC660CBB900)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA     '## (IC660CBB901)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller                     '## (IC660CBB902)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Series_6_Bus_Controller_Wout_Diags         '## (IC660CBB903)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_GENI                                         '## (IC660ELB9xx)
''MaxCircuit = SRI.devices(SBA).directed_control_data_length * 8
''Case DevType_Circ_16_115VAC_Input                         '## (IC660BBD110)
''
''Case DevType_Series_9030_Communications_Module             '## (IC693CMM301)
''
''Case DevType_Series_9030_Enhanced_Communications_Module '## (IC693CMM302)
''
''Case Else
''GENI_Toggle_Discrete_Output_Bit = (GENI_InappropriateDevice)
''
''End Select
'''## If reach this point, have a device that *can* support discrete output
'''##            references -- now check for a good circuit number.
'''## We don't have to worry that the I/O table entries are too small, as the device
'''## could not have logged in if so.
''If ((Circuit < 1) Or (Circuit > MaxCircuit)) Then
''GENI_Toggle_Discrete_Output_Bit = (GENI_BadCircuitReference)
''
''End If
'''## Verify that outputs are enabled for this device
''If SRI.devices(SBA).outputs_disable Then
''
''
''GENI_Toggle_Discrete_Output_Bit = (GENI_OutputsNotEnabled)
''
''End If
'''## As a read-modify-write cycle will be required, must lockout I/O Table
''result = RequestIOTableLockout()
''If result <> GENI_NoError Then
''
''
''GENI_Toggle_Discrete_Output_Bit = (result)
''
''End If
'''   If (((SRI.device_io_table((SBA * SRI.setup.io_buffer_length) +
''''                               ((Circuit - 1) > 3))) And Not
''''                               (CByte(&H1) < (Circuit - 1)))) Then
'''                               '## Need to toggle to TRUE (1)
'''       SRI.device_io_table ((32 * SRI.setup.io_buffer_length) +
''''                               (SBA * SRI.setup.io_buffer_length) +
''''                               ((Circuit - 1) > 3))
''''                               Or (CByte(&H1) < (Circuit - 1))
'''                               '## step over input table
'''                               '## step over preceding output buffers
'''                               '## 8 circuits per byte, numbering starts @ 1
'''   Else  '## Need to toggle to FALSE (0)'## Set specified circuit = 1
'''       SRI.device_io_table ((32 * SRI.setup.io_buffer_length) +
''''                               (SBA * SRI.setup.io_buffer_length) +
''''                               ((Circuit - 1) > 3))
''''                               And Not (CByte(&H1) < (Circuit - 1))
'''                               '## step over input table
'''                               '## step over preceding output buffers
'''                               '## 8 circuits per byte, numbering starts @ 1
'''                               '## Set specified circuit = 0'
''result = RemoveIOTableLockout()
''GENI_Toggle_Discrete_Output_Bit = (result)
''
''End Function
''
''
'''###############################################################################
'''###############################################################################
''Public Function GENI_Write_Analog_Channel(ByVal SBA As Integer, ByVal Channel As Byte, value As Integer) As Integer
''
''
''
''
''
''
''Dim result     As Integer
''Dim iOffset    As Integer
''Dim MaxChannel As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then GENI_Write_Analog_Channel = (GENI_NotOK)
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then GENI_Write_Analog_Channel = GENI_BadSBAReference
''
''
''If Not (SRI.devices(SBA).device_present) Then
''If SBA = this.SerialBusAddress Then
''
''
''GENI_Write_Analog_Channel = (GENI_InappropriateDevice)
''Else
''GENI_Write_Analog_Channel = (GENI_NoDevice)
''End If
''End If
'''## Verify that device is of an appropriate type (i.e., is an analog block
'''## or device accepting directed control data *AND* that it *could* support
'''## the requested channel
''Select Case (SRI.devices(SBA).model_number)
''Case DevType_Voltage_Current_4in_2out_Analog_115VAC             '## (IC660BBA100)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC         '## (IC660BBA020)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Voltage_Current_4in_2out_Analog_115VAC_PhaseA         '## (IC660CBA100)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Voltage_Current_4in_2out_Analog_24VDC_48VDC_PhaseA '## (IC660CBA020)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Current_Source_4in_2out_Analog_115VAC_125VDC         '## (IC660BBA104)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Current_Source_4in_2out_Analog_24VDC_48VDC         '## (IC660BBA024)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Current_Source_6out_Analog_115VAC_125VDC            '## (IC660BBA105)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Current_Source_6out_Analog_24VDC_48VDC            '## (IC660BBA025)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_9030_Bus_Controller                 '## (IC693BEM331)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_9070_Bus_Controller                 '## (IC697BEM731)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_9070_Remote_IO_Scanner                 '## (IC697BEM733)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_VersaMax_GBIU                                 '## (IC670GBI001)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_6_Bus_Controller_PhaseA             '## (IC660CBB900)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_6_Bus_Controller_Wout_Diags_PhaseA     '## (IC660CBB901)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_6_Bus_Controller                     '## (IC660CBB902)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_Series_6_Bus_Controller_Wout_Diags         '## (IC660CBB903)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case DevType_GENI                                         '## (IC660ELB9xx)
''MaxChannel = SRI.devices(SBA).directed_control_data_length / 2
''Case Else
''GENI_Write_Analog_Channel = (GENI_InappropriateDevice)
''End Select
'''## If reach this point, have a device that *can* support analog channel
'''##            references -- now check for a good channel number.
'''## We don't have to worry that the I/O table entries are too small, as the device
'''## could not have logged in if so.
''If ((Channel < 1) Or (Channel > MaxChannel)) Then GENI_Write_Analog_Channel = GENI_BadCircuitReference
''
''
'''## Verify that outputs are enabled for this device
''If (SRI.devices(SBA).outputs_disable) Then GENI_Write_Analog_Channel = GENI_OutputsNotEnabled
''
''
'''## As a multi-byte write cycle will be required, must lockout I/O Table
''result = RequestIOTableLockout()
''If (result <> GENI_NoError) Then GENI_Write_Analog_Channel = result
''
''
''
''With SRI
''iOffset = (32 * .setup.io_buffer_length) + (SBA * .setup.io_buffer_length) + (2 * (Channel - 1))
'''## step over input table
'''## step over preceding output buffers
'''## 2 bytes per preceding channel
''.device_io_table(iOffset + 0) = LOBYTE(value)
''.device_io_table(iOffset + 1) = HIBYTE(value)
''End With 'SRI
''result = RemoveIOTableLockout()
''GENI_Write_Analog_Channel = (result)
''End Function
''
''
'''## ***************************************************************************
'''## ***************************************************************************
''Public Function GENI_DisableDeviceOutputs(ByVal SBA As Integer) As Integer
''
''
''
''
'''## Serial bus address of device interested in
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_DisableDeviceOutputs = (GENI_NotOK)
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_DisableDeviceOutputs = (GENI_BadSBAReference)
''End If
'''  If Not (SRI.devices(SBA).device_present) Then
'''      If (SBA = SRI.SerialBusAddress) Then
'''          GENI_DisableDeviceOutputs = (GENI_InappropriateDevice)
'''      Else: GENI_DisableDeviceOutputs = (GENI_NoDevice)
'''      End If
'''  End If
''SRI.devices(SBA).outputs_disable = True
''GENI_DisableDeviceOutputs = (GENI_NoError)
''End Function
''
''
'''## ***************************************************************************
'''## ***************************************************************************
''Public Function GENI_EnableDeviceOutputs(SBA As Integer) As Integer
''
''
''
'''## Serial bus address of device interested in
''Dim iResult As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_EnableDeviceOutputs = (GENI_NotOK)
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_EnableDeviceOutputs = (GENI_BadSBAReference)
''End If
'''   If Not (SRI.devices(SBA).device_present) Then
'''       If (SBA = SRI.SerialBusAddress) Then
'''           GENI_EnableDeviceOutputs = (GENI_InappropriateDevice)
'''       Else
'''           GENI_EnableDeviceOutputs = (GENI_NoDevice)
'''       End If
'''   End If
'''## Now need to determine if another controller is already assigned to device
'''## this is done via a Read Identification Datagram.
''iResult = ReadIdentificationDatagram(SBA)
''If iResult <> GENI_NoError Then
''
''
''GENI_EnableDeviceOutputs = (iResult)
''End If
'''## Look for an assigned controller
'''## If controller assigned, should be valid SBA
''If SRI.read_datagram_buffer(9) < 32 Then
''
''
''GENI_EnableDeviceOutputs = (GENI_CannotEnableOutputs)
''End If
''SRI.devices(SBA).outputs_disable = False  '## No controller previously assigned
''GENI_EnableDeviceOutputs = (GENI_NoError)
''End Function
''
''
'''###############################################################################
'''###############################################################################
''Public Function GENI_Write_Directed_Control_Output_Data(ByVal SBA As Integer, devdata As DEVICE_DATA) As Integer
''
''
''
''
''
''
'''Dim i As Integer
''
''Dim result As Integer
'''## Check for PCGEN card itself to be OK
''If Not (SRI.status.ok_status And GENI_OK) Then
''GENI_Write_Directed_Control_Output_Data = (GENI_NotOK)
''
''End If
'''## Verify that caller provided SBA is valid, then use it to check for
'''## device present
''If ((SBA < 0) Or (SBA > 31)) Then
''GENI_Write_Directed_Control_Output_Data = (GENI_BadSBAReference)
''
''End If
'''    If Not (SRI.devices(SBA).device_present) Then
'''        If (SBA = SRI.SerialBusAddress) Then
'''            GENI_Write_Directed_Control_Output_Data = (GENI_InappropriateDevice)
'''        Else
'''            GENI_Write_Directed_Control_Output_Data = (GENI_NoDevice)
'''        End If
'''    End If
'''## Verify that device is of an appropriate type (i.e., is a GENI type
'''## device.
''Select Case (SRI.devices(SBA).model_number)
''Case DevType_GENI                                         '## (IC660ELB9xx)
''
''Case Else
''GENI_Write_Directed_Control_Output_Data = (GENI_InappropriateDevice)
''
''End Select
'''## Verify that outputs are enabled for this device
''If SRI.devices(SBA).outputs_disable Then
''
''
''GENI_Write_Directed_Control_Output_Data = (GENI_OutputsNotEnabled)
''
''End If
''Select Case (SRI.devices(SBA).directed_control_data_length)
''Case 0  '## no directed output control data configured just return.
''result = GENI_NoError
''Case 1   '## Single byte write does not require I/O table lockout
'''        SRI.device_io_table(((32 + SBA) * SRI.setup.io_buffer_length) + 0) =
''''            devdata.directed_control_data(0)
''result = GENI_NoError
''Case Else          '## 2..128 bytes must lockout I/O table
''result = RequestIOTableLockout()
'''        If (result <> GENI_NoError) Then End Select
'''        For i = 0 To UBound(SRI.devices(SBA).directed_control_data_length)
'''            SRI.device_io_table(((32 + SBA) * SRI.setup.io_buffer_length) + i) =
''''                devdata.directed_control_data(i)
'''        Next i
''result = RemoveIOTableLockout()
''GENI_Write_Directed_Control_Output_Data = (result)
''
''End Select
''End Function
''



