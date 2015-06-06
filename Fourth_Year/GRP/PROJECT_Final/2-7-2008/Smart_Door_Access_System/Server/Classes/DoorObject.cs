using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDoor
{
    class DoorObject
    {
        public int Current_Socket;
        public string passed_barcode_from_Remote_host;
        public string Door_Name;
        public string Door_Number;
        public DoorObject(int p1, string p2, string p3, string p4)
        {
            Current_Socket = p1;
            passed_barcode_from_Remote_host = p2;
            Door_Name = p3;
            Door_Number = p4;

 
        }
    }
}
