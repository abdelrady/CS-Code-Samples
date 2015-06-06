using System;
using System.Windows.Forms;
namespace Client_s_
{
    class Nudge
    {
	
		private Form tmpFrm;		
		public Nudge(Form theForm)
		{
			this.tmpFrm = theForm;
		}
		public void NudgeMe()
		{
			int xCoord = this.tmpFrm.Left;
			int yCoord = this.tmpFrm.Top;
			int rnd = 0;
			Random RandomClass = new Random();
			for (int i = 0;  i <= 500; i++)
			{
				rnd = RandomClass.Next(xCoord + 1, xCoord + 15);
				this.tmpFrm.Left = rnd;
				rnd = RandomClass.Next(yCoord + 1, yCoord + 15);
				this.tmpFrm.Top = rnd;
			}
			this.tmpFrm.Left = xCoord;
			this.tmpFrm.Top = yCoord;
		}
	}
}



