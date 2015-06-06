using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SmartDoor
{

    class Door
    {
        private Thread DoorOpen_CloseThread;  
        private  int PinOpen  = 1;
        private  int PinClose = 2;
        private  int PinStop = 0;
        ClientFrm Parent;
        public enum DoorStatus{Open,Close,InWork,Unknown};
        public DoorStatus doorStatus;//For Future Use.........
        public Door(bool Invertbins,ClientFrm Form)
        {
            Parent = Form;          
            porting.Out(Configuration.LptPortAddressBase, PinStop);
            if (Invertbins)
            { 
                PinOpen  = 2; 
                PinClose = 1; 
            }
            this.doorStatus = DoorStatus.Unknown;
        }

        public void InvertBins()
        {
            int temp = PinOpen;
            PinOpen = PinClose;
            PinClose = temp; 
        }

        public void Open_The_Door()
        {
            DoorOpen_CloseThread = new Thread(new ThreadStart(CheckStatus));
            DoorOpen_CloseThread.Start();
        }

        private void CheckStatus()
        {
            int x;
            lock (this)
            {
                //open The Door
                porting.Out(Configuration.LptPortAddressBase, PinOpen);
                doorStatus = DoorStatus.InWork;
                
                while (true)
                {
                    Thread.Sleep(100);
                    x = porting.Inp(Configuration.LptPortAddressBase + 1);
                    Parent.settxt(x.ToString());
                    if (x == 88 || x == 104)
                    {
                        porting.Out(Configuration.LptPortAddressBase, PinStop);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Open;
                        break;
                    }
                    else if (x == 72)//this case occur when the two limit switch are on, & this is Hardware Failure
                    {
                        porting.Out(Configuration.LptPortAddressBase, PinStop);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Unknown;
                        break;
                    }
                }
    
                //wait To Enter
                Thread.Sleep(Configuration.WaitOnOpened);

                //Close The Door
                porting.Out(Configuration.LptPortAddressBase, PinClose);//Send Either 1 or 2 ⁄·Ì Õ”» Õ«·Â «·„Ê Ê— ›Ì «·› Õ Ê«·ﬁ›·(Ì„Ì‰ Ê·« ‘„«·)»‹
                doorStatus = DoorStatus.InWork;
                
                while (true)
                {
                    Thread.Sleep(100);
                    x = porting.Inp(Configuration.LptPortAddressBase + 1);
                    Parent.settxt(x.ToString());
                    if (x == 88 || x == 104)
                    {
                        porting.Out(Configuration.LptPortAddressBase, PinStop);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Close;
                        break;
                    }
                    else if (x == 72)//this case occur when the two limit switch are on, & this is Hardware Failure
                    {
                        porting.Out(Configuration.LptPortAddressBase, PinStop);//Stop Motor Or you Can replace it by 3  ›—„· «·„Ê Ê—
                        doorStatus = DoorStatus.Unknown;
                        break;
                    }
                }
            }    
        }       
    }
}
