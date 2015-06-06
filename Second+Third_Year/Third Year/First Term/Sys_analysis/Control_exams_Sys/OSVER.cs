using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OSCheck
{
    [StructLayout(LayoutKind.Sequential)]
    internal class OSVersionInfo
    {
        public Int32 OSVersionInfoSize;
        public Int32 majorVersion = 0;
        public Int32 minorVersion = 0;
        public Int32 buildNumber = 0;
        public Int32 platformId = 0;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public String versionString = "";
    }

    /// <summary>
    /// Summary description for OSVersionHelper.
    /// </summary>
    public sealed class OSVersionHelper
    {

        [DllImport("kernel32")]
        private static extern bool GetVersionEx([In, Out]OSVersionInfo osvi);

        private static string osName = "";
        private static string osBuild = "";
        private static string osVersion = "";

        /// <summary>
        /// Returns e.g. "Microsoft Windows 2000"
        /// </summary>
        public static string OSName
        {
            get
            {
                if (osName.Length == 0)
                {
                    GetOSInformation();
                }
                return osName;
            }
        }

        /// <summary>
        /// Returns e.g. "5.0.2195"
        /// </summary>
        public static string OSBuild
        {
            get
            {
                if (osBuild.Length == 0)
                {
                    GetOSInformation();
                }
                return osBuild;
            }
        }

        /// <summary>
        /// Returns e.g. "Service Pack 4"
        /// </summary>
        public static string OSVersion
        {
            get
            {
                if (osVersion.Length == 0)
                {
                    GetOSInformation();
                }
                return osVersion;
            }
        }

        private static void GetOSInformation()
        {
            OSVersionInfo osvi = new OSVersionInfo();
            osvi.OSVersionInfoSize = Marshal.SizeOf(osvi);

            GetVersionEx(osvi);

            osName = "Microsoft Windows ";

            switch ((PlatformID)osvi.platformId)
            {
                case PlatformID.Win32NT:
                    if (osvi.majorVersion <= 4)
                    {
                        osName += "NT";
                    }
                    else if (osvi.majorVersion == 5 && osvi.minorVersion == 0)
                    {
                        osName += "2000";
                    }
                    else if (osvi.majorVersion == 5 && osvi.minorVersion == 1)
                    {
                        osName += "XP";
                    }
                    else if (osvi.majorVersion == 5 && osvi.minorVersion == 2)
                    {
                        osName += ".NET";
                    }
                    break;
                case PlatformID.Win32Windows:
                    if (osvi.majorVersion == 4 && osvi.minorVersion == 0)
                    {
                        osName += "95";
                    }
                    else if (osvi.majorVersion == 4 && osvi.minorVersion == 10)
                    {
                        osName += "98";
                    }
                    else if (osvi.majorVersion == 4 && osvi.minorVersion == 90)
                    {
                        osName += "Millenium Edition";
                    }
                    break;
            }

            osBuild = osvi.majorVersion.ToString() + ".";
            osBuild += osvi.minorVersion.ToString() + ".";

            if ((PlatformID)osvi.platformId == PlatformID.Win32Windows)
            {
                // Win95/98/Me build number is the low-order word in the build number
                Int32 buildNum = osvi.buildNumber & 0x000000000000ffff;
                osBuild += buildNum.ToString();
            }
            else
            {
                osBuild += osvi.buildNumber.ToString();
            }

            if ((PlatformID)osvi.platformId == PlatformID.Win32Windows)
            {
                if (osvi.versionString == "A")
                {
                    osVersion = "Second Edition";
                }
                else if (osvi.versionString == "C")
                {
                    osVersion = "OSR2";
                }
            }
            else
            {
                osVersion = osvi.versionString;
            }
        }

        /// <summary>
        /// Returns whether the application is running on Windows 95 or 98.
        /// </summary>
        /// <returns></returns>
        public static bool IsRunningOnWindows9xOrMillenium()
        {
            return ((OSVersionHelper.OSName.EndsWith("95")) ||
                (OSVersionHelper.OSName.EndsWith("98")) ||
                (OSVersionHelper.OSName.EndsWith("Millenium Edition")));
        }

        public static string GetOSFullName()
        {
            StringBuilder sb = new StringBuilder("");

            sb.Append(OSVersionHelper.OSName);
            sb.Append(" - ");
            sb.Append(OSVersionHelper.OSBuild);
            sb.Append(" - ");
            sb.Append(OSVersionHelper.OSVersion);

            return sb.ToString();
        }
    }
}
