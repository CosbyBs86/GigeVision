﻿namespace GigeVision.Core.Enums
{
    /// <summary>
    /// They are fixed GigeVision Registers
    /// </summary>
    public enum GvcpRegister
    {
        VersionMajor = 0x0000,
        VersionMinor = 0x0000,
        DeviceModeIsBigEndian = 0x0004,
        DeviceModeCharacterSet = 0x0004,
        MACAddressHigh = 0x0008,
        MACAddressLow = 0x000C,
        SupportedIPConfigurationLLA = 0x0010,
        SupportedIPConfigurationDHCP = 0x0010,
        SupportedIPConfigurationPersistentIP = 0x0010,
        CurrentIPConfigurationLLA = 0x0014,
        CurrentIPConfigurationDHCP = 0x0014,
        CurrentIPConfigurationPersistentIP = 0x0014,
        CurrentIPAddress = 0x0024,
        CurrentSubnetMask = 0x0034,
        CurrentDefaultGateway = 0x0044,
        FirstURL = 0x0200,
        SecondURL = 0x0400,
        NumberOfInterfaces = 0x0600,
        PersistentIPAddress = 0x064C,
        PersistentSubnetMask = 0x065C,
        PersistentDefaultGateway = 0x066C,
        MessageChannelCount = 0x0900,
        StreamChannelCount = 0x0904,
        SupportedOptionalCommandsUserDefinedName = 0x0934,
        SupportedOptionalCommandsSerialNumber = 0x0934,
        SupportedOptionalCommandsEVENTDATA = 0x0934,
        SupportedOptionalCommandsEVENT = 0x0934,
        SupportedOptionalCommandsPACKETRESEND = 0x0934,
        SupportedOptionalCommandsWRITEMEM = 0x0934,
        SupportedOptionalCommandsConcatenation = 0x0934,
        HeartbeatTimeout = 0x0938,
        TimestampTickFrequencyHigh = 0x093C,
        TimestampTickFrequencyLow = 0x0940,
        TimestampControl = 0x0944,
        TimestampValueHigh = 0x0948,
        TimestampValueLow = 0x094C,
        GevCCP = 0x0A00,
        MCPHostPort = 0x0B00,
        MCDA = 0x0B10,
        MCTT = 0x0B14,
        MCRC = 0x0B18,
        SCPInterfaceIndex = 0x0D00,
        GevSCPHostPort = 0x0D00,
        SCPSFireTestPacket = 0x0D04,
        SCPSDoNotFragment = 0x0D04,
        SCPSBigEndian = 0x0D04,
        GevSCPSPacketSize = 0x0D04,
        GevSCPD = 0x0D08,
        GevSCDA = 0x0D18,
        IPConfigurationStatus = 0xA030,
        TimestampCounterSelector = 0xB8DC,
        TimestampSetSource = 0xB8DC,
        TimestampSetActivation = 0xB8DC,
        TimestampResetSource = 0xB8DC,
        TimestampResetActivation = 0xB8DC,
        TimestampValueAtSet = 0xB8E0,
        UserSetLoadUserSet1 = 0xD368,
    }
}