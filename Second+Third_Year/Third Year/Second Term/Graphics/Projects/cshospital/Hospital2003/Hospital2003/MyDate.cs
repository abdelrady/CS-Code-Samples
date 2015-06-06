using System;

namespace Hospital
{
	/// <summary>
	/// Summary description for MyDate.
	/// </summary>
	public class MyDate
	{
		/// <summary>
		/// initializes an object with the current date
		/// </summary>
		public MyDate()
		{
			day=DateTime.Now.Day;
			month=DateTime.Now.Month;
			year=DateTime.Now.Year;
		}
		public MyDate(DateTime d)
		{
			day=d.Day;
			this.month=d.Month;
			this.year=d.Year;
		}
		/// <summary>
		/// initializes a dte with a string in the format DD-MM-YYYY
		/// </summary>
		/// <param name="text">format DD-MM-YYYY</param>
		public MyDate(string text)
		{
			if(text.Length!=10)
			{
				Exception e=new Exception("Inavlid day format");
				throw e;
			}
			day=Int32.Parse(text.Substring(0,2));
			year=Int32.Parse(text.Substring(3,2));
			month=Int32.Parse(text.Substring(5,4));
		}
		/// <summary>
		/// returns the date in the format DD-MM-YYYY
		/// </summary>
		/// <returns>returns the date in the format DD-MM-YYYY</returns>
		public override string ToString()
		{
			string d,y,m;

			if(day<10) d="0"+day.ToString();
			else d=day.ToString();

			if(month<10) m="0"+month;
			else m=month.ToString();
			y=year.ToString();
			return d+"-"+m+"-"+y;

		}
		private int day,month,year;
		public int Day
		{
			get
			{
				return day;
			}
			set
			{
				day=value;
			}
		}
		public int Month
		{
			get
			{
				return month;
			}
			set
			{
				month=value;
			}
		}
		public int Year
		{
			get
			{
				return year;
			}
			set
			{
				year=value;
			}
		}
		public void  MakeItYesterDay()
		{
			if(day==1)
			{
				if(month==3)
				{
					if((year%4)==0)
					{
						month=2;
						day=29;
						return;
					}
					else
					{
						day=28;
						month=2;
						return;
					}
				
				}
				else 
				{
					if(month==1)
					{
						day=31;
						month=12;
						year--;
						return;
					}
					if (month == 2 || month == 4 || month == 6 || month == 8 || month == 9 || month == 11)
					{
						day=31;
						month--;
						return;
					}
					else
					{
						day=30;
						month--;
						return;
					}
					
				}
			}
			else day--;
		}
		public void MakeItTomorrow()
		{
			if(day==31)
			{
				if(month==12)
				{
					day=1;
					month=1;
					year++;
				}
				else
				{
					day=1;
					month++;
				}
			}
			else if(day==30)
			{
				day=1;
				month++;
				return;
			}
			else if((day==28 && month==2))
			{
				if((year%4)==0)
				{
					month=3;
					day=1;
					return;
				}
			}
			else if(day==29 && month==2)
			{
				day=1;
				month=3;
				return;
			}
			else
			{
				day++;
				return;
			}

		}
	}	
}
