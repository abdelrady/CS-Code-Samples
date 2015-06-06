using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SmartDoor
{

    public class Door
    {

        public Label L1 = null;

        public Label L2 = null;

        public Label L3 = null;


        private int PINOPEN = 0x1;
        private int PINCLOSE = 0x2;
        private int PINSTOP = 0x0;


        private readonly int SP_DOOROPEND = 111;
        private readonly int SP_DOORCLOSED = 95;

        private int INITIALSTATE;

        //For Future 
        public enum DoorStatus { Opened, Closed, InWork, Unknown };
        public DoorStatus doorStatus;
       
        public Door(bool Invertbins)
        {
            porting.Out(Configuration.LptPortAddressBase, PINSTOP);

            if (Invertbins)
            {
                PINOPEN = 0x2;
                PINCLOSE = 0x1;
            }
           
            int Status;

            //capture to the initial state
            INITIALSTATE = porting.Inp(Configuration.LptPortAddressBase);
            if (INITIALSTATE != SP_DOORCLOSED)
            {
                porting.Out(Configuration.LptPortAddressBase, PINCLOSE);

                //Set The Status
                doorStatus = DoorStatus.InWork;


                while (true)
                {
                    Thread.Sleep(100);
                    Status = porting.Inp(Configuration.LptPortAddressBase + 1);
                   
                    if (Status == SP_DOORCLOSED)
                    {
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Closed;
                        break;
                    }
                    else if (Status == 72)//this case occur when the two limit switch are on, & this is Hardware Failure
                    {
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Unknown;
                        break;
                    }
                }
            }

            this.doorStatus = DoorStatus.Unknown;
        }

        public void InvertBins()
        {
            int temp = PINOPEN;
            PINOPEN = PINCLOSE;
            PINCLOSE = temp;
        }

        
        public void OpenDoor()
        {
            int Status;
            lock (this)
            {
                //open The Door
                porting.Out(Configuration.LptPortAddressBase, PINOPEN);
                if (L3 != null)
                    L3.Text = PINOPEN.ToString();
                doorStatus = DoorStatus.InWork;
                if (L1 != null)
                    L1.Text = "Door In Work";

                while (true)
                {
                    Thread.Sleep(50);
                    Status = porting.Inp(Configuration.LptPortAddressBase + 1);
                    if (L2 != null)
                        L2.Text = Status.ToString();

                   
                    if (Status == SP_DOOROPEND)
                    {
                        //Stop Motor Or you Can replace it by 3
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);
                        if (L3 != null)
                            L3.Text = PINSTOP.ToString();
                        doorStatus = DoorStatus.Opened;
                        if (L1 != null)
                            L1.Text = "Door Opened";
                        break;
                    }
                    //this case occur when the two limit switch are on, & this is Hardware Failure
                    else if (Status == 72)
                    {
                        //Stop Motor Or you Can replace it by 3 
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);
                        if (L3 != null)
                            L3.Text = PINSTOP.ToString();
                        doorStatus = DoorStatus.Unknown;
                        if (L1 != null)
                            L1.Text = "Unknown Status";
                        break;
                    }
                }
            }
        }
        public void CloseDoor()
        {
            int Status;
            lock (this)
            {
              porting.Out(Configuration.LptPortAddressBase, PINCLOSE);
              if (L3 != null)
                  L3.Text = PINCLOSE.ToString();
                //Set The Status
                doorStatus = DoorStatus.InWork;
                if (L1 != null)
                    L1.Text = "Door In Work";

                while (true)
                {
                    Thread.Sleep(100);
                    Status = porting.Inp(Configuration.LptPortAddressBase + 1);
                    if (L2 != null)
                        L2.Text = Status.ToString();

                   
                    if (Status == SP_DOORCLOSED)
                    {
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        if (L3 != null)
                            L3.Text = PINSTOP.ToString();
                        doorStatus = DoorStatus.Closed;
                        if (L1 != null)
                            L1.Text = "Door Closed";
                        break;
                    }
                    else if (Status == 72)//this case occur when the two limit switch are on, & this is Hardware Failure
                    {
                        porting.Out(Configuration.LptPortAddressBase, PINSTOP);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        if (L3 != null)
                            L3.Text = PINSTOP.ToString();

                        if (L1 != null)
                            L1.Text = "Unknown Status";
                        doorStatus = DoorStatus.Unknown;
                        break;
                    }
                }
            }
        }
    }
}
