using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace CreditCardVerification
{
	/// <summary>
	/// Summary description for Service1.
	/// </summary>
	public class CreditCardVerification : System.Web.Services.WebService
	{
		public CreditCardVerification()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion


		[WebMethod]
		public bool VerifyService(string givenCardNumber)
		{
			try 
			{
				ArrayList Card = new ArrayList();
				int CardLength = givenCardNumber.Length;
				for (int i = CardLength-2; i >= 0; i = i - 2)
				{
					Card.Add( Int32.Parse(givenCardNumber[i].ToString())*2 );
				}

				int CheckSum = 0;
            	for (int i = 0; i<= Card.Count-1; i++)
				{
					int count = 0;
					if ((int)Card[i] > 9)
					{
						int Length = ((int)Card[i]).ToString().Length;
						for (int x = 0; x < Length; x++)
						{
							count = count + Int32.Parse(((int)Card[i]).ToString()[x].ToString() );
						}
					}
					else
					{
						count = (int)Card[i];   
					}
					CheckSum = CheckSum + count;
				}

				int OriginalSum = 0;
				for (int y = CardLength-1; y >= 0; y = y - 2)
				{
					OriginalSum = OriginalSum + Int32.Parse(givenCardNumber[y].ToString());
				}
				return (((OriginalSum+CheckSum)%10)==0);
			}
			catch
			{
				return false;
			}
		
		}



	}
}
