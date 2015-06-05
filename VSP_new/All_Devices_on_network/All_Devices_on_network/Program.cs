using System;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Collections.Specialized;
using NetworkIPs;

namespace NetworkIPs
{
    public class Names
    {
        public StringCollection GetNames()
        {
            ProcessStartInfo _startInfo = new ProcessStartInfo("net", "view");
            _startInfo.CreateNoWindow = true;
            _startInfo.UseShellExecute = false;
            _startInfo.RedirectStandardOutput = true;
            Process _process = Process.Start(_startInfo);
            StreamReader _reader = _process.StandardOutput;
            StringCollection _machineNames = GetMachineNamesFromProcessOutput(_reader.ReadToEnd());
            StringCollection _machineIPs = new StringCollection();
            foreach (string machine in _machineNames)
            {
                _machineIPs.Add(IPAddresses(machine));
            }
            return _machineIPs;
        }
        private static string IPAddresses(string server)
        {
            try
            {
                System.Text.ASCIIEncoding ASCII = new System.Text.ASCIIEncoding();
                // Get server related information.
                IPHostEntry heserver = Dns.Resolve(server);
                //assumin the machine has only one IP Address
                return heserver.AddressList[0].ToString();
            }
            catch
            {
                return "Address Retrieval error for " + server;
            }
        }
        //string manipulations
        private StringCollection GetMachineNamesFromProcessOutput(string processOutput)
        {
            string _allMachines = processOutput.Substring(processOutput.IndexOf("\\"));
            StringCollection _machines = new StringCollection(); while (_allMachines.IndexOf("\\") != -1)
            {
                _machines.Add(_allMachines.Substring(_allMachines.IndexOf("\\"),
                _allMachines.IndexOf(" ", _allMachines.IndexOf("\\")) - _allMachines.IndexOf("\\")).Replace("\\", String.Empty));
                _allMachines = _allMachines.Substring(_allMachines.IndexOf(" ", _allMachines.IndexOf("\\") + 1));
            }
            return _machines;
        }
    }
}
public class Runner
{
    static void Main()
    {
        Names _names = new Names();
        StringCollection names = _names.GetNames();
        foreach (string name in names)
            Console.WriteLine(name);
        Console.ReadLine();
    }
}