using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace USBDriveSerialNumber
{
    public class USBSerialNumber
    {

        private String _driveLetter;

        public String driveLetter
        {
            get { return _driveLetter; }
            set { _driveLetter = value; }
        }
	
        string _vendor;
        string _product;
        string _serialNumber;


        public string getSerialNumberFromDriveLetter(string driveLetter)
        {
            this._driveLetter = driveLetter.ToUpper();

            if (!this._driveLetter.Contains(":"))
            {
                this._driveLetter += ":";
            }

            matchDriveLetterWithSerial();

            return this._serialNumber;
        }


        public string getSerialNumberFromDriveLetter()
        {
            if (this._driveLetter != null)
            {
                if (!this._driveLetter.Contains(":"))
                {
                    this._driveLetter += ":";
                }
            }

            matchDriveLetterWithSerial();

            //return this._serialNumber;
            
            return this._vendor + " " + this._product + " (" + this._driveLetter + ")";
        }


        private void matchDriveLetterWithSerial()
        {

            string[] diskArray;
            string driveNumber;
            string driveLetter;

            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            foreach (ManagementObject dm in searcher1.Get())
            {
                diskArray = null;
                driveLetter = getValueInQuotes(dm["Dependent"].ToString());
                diskArray = getValueInQuotes(dm["Antecedent"].ToString()).Split(',');
                driveNumber = diskArray[0].Remove(0, 6).Trim();
                if (driveLetter == this._driveLetter || this._driveLetter == null)
                {
                    /* This is where we get the drive serial */
                    ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                    foreach (ManagementObject disk in disks.Get())
                    {

                        if (disk["Name"].ToString() == ("\\\\.\\PHYSICALDRIVE" + driveNumber) & disk["InterfaceType"].ToString() == "USB")
                        {
                            _driveLetter = driveLetter;
                            this._product = parseProductNameFromDeviceID(disk["PNPDeviceID"].ToString());
                            this._vendor = parseVendorNameFromDeviceID(disk["PNPDeviceID"].ToString());
                        }
                    }
                }
            }
        }

        private string parseVendorNameFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen - 1].Split('&');
            serial = serialArray[1].Remove(0,4);

            return serial;
        }

        private string parseSerialFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen].Split('&');
            serial = serialArray[0];

            return serial;
        }

        private string parseProductNameFromDeviceID(string deviceId)
        {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen-1].Split('&');
            serial = serialArray[2].Remove(0, 5);
            return serial;
        }

        private string getValueInQuotes(string inValue)
        {
            string parsedValue = "";

            int posFoundStart = 0;
            int posFoundEnd = 0;

            posFoundStart = inValue.IndexOf("\"");
            posFoundEnd = inValue.IndexOf("\"", posFoundStart + 1);

            parsedValue = inValue.Substring(posFoundStart + 1, (posFoundEnd - posFoundStart) - 1);

            return parsedValue;
        }

    }
}

