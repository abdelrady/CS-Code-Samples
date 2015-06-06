using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Hospital;

namespace Hospital
{
	/// <summary>
	/// Summary description for DatabaseManager.
	/// </summary>
	public class DatabaseManager
	{
		private MyDate date=new MyDate();
		private int MedId=0;
		private string constr="provider=Microsoft.JET.OLEDB.4.0;"
			+@"Data Source=Hospital";
		private OleDbConnection connection=new OleDbConnection();
		private OleDbDataReader reader;
		string sqlcom;
		Form1 owner;
		OleDbCommand com=new OleDbCommand();
		public ArrayList minimums=new ArrayList();

		public DatabaseManager(Form1 o)
		{
			connection.ConnectionString=constr;
			com.Connection=this.connection;
			this.owner=o;
			this.initializeId();
			this.createInventoryForToday();
			ArrayList l=this.checkForMinimus();
			if(l.Count==0)
				return;
			else
			{
				Form1.ErrorMessage("Â‰«ﬂ »⁄÷ «·«œÊÌ… «· Ï »·€  «·Õœ «·«œ‰Ï ·Â« \n„‰ ›÷·ﬂ —«Ã⁄ Â–Â «·«œÊÌ…",true);
				
			}

			
		}
		private void openConnection()
		{
			if(connection.State==ConnectionState.Open) 
			{
				connection.Close();
				connection.Open();
			}
			else 
				connection.Open();
		}
		void closeConnection()
		{
			this.connection.Close();
		}
		public ArrayList checkForMinimus()
		{
			ArrayList reachedmin=new ArrayList();
			this.openConnection();
			for(int i=0;i<MedId;i++)
			{
				MyDate date=new MyDate();
				string sqlcom="SELECT * from INVENTORY_OPERATION where MEDICIN_ID="+i.ToString()
					+" and DATE='"+date.ToString()+"' and TOTAL_QUANTITY <= "+this.minimums[i].ToString();
				com=new OleDbCommand(sqlcom,this.connection);
				reader=com.ExecuteReader();
				if(reader.Read())
				{
					int rem=Int32.Parse(reader["TOTAL_QUANTITY"].ToString())+Int32.Parse(reader["BUYINGS"].ToString())
						-Int32.Parse(reader["USED_QUANTITY"].ToString())-Int32.Parse(reader["RETURNS"].ToString());
					if(rem<(int)(this.minimums[i]))
					{
                        InventoryRecord r=new InventoryRecord();
						r.total=reader["TOTAL_QUANTITY"].ToString();
                        r.name=this.owner.MedicineName(i);
						r.buyings=reader["BUYINGS"].ToString();
						r.minimum=((int)this.minimums[i]).ToString();
						r.remaining=rem.ToString();
						r.returns=reader["RETURNS"].ToString();
						r.unit=Form1.units[i].ToString();
						r.used=reader["USED_QUANTITY"].ToString();

						reachedmin.Add(r);
					}
				}
				reader.Close();

			}
			return reachedmin;

		}
		public void createInventoryForToday()
		{
			
			this.openConnection();
			MyDate date=new MyDate();
			bool found=false;
			sqlcom="select * from INVENTORY_OPERATION where DATE='"+date.ToString()+"';";
			com.CommandText=sqlcom;
			reader=com.ExecuteReader();
			if(reader.Read())
				return ;
			reader.Close();
			for(int i=0;i<150;i++)
			{
				date.MakeItYesterDay();
				sqlcom="select * from INVENTORY_OPERATION where DATE='"+date.ToString()+"';";
				this.openConnection();
				com.CommandText=sqlcom;
				reader=com.ExecuteReader();
				if(reader.Read())
				{
					found=true;
					break;
				}

			}
			if(!found) return;
			date=new MyDate();
			ArrayList l=new ArrayList();
			do
			{
				//
				int total=Int32.Parse(reader["TOTAL_QUANTITY"].ToString());
				total-=Int32.Parse(reader["RETURNS"].ToString())+Int32.Parse(reader["USED_QUANTITY"].ToString());
				total+=Int32.Parse(reader["BUYINGS"].ToString());
				
				sqlcom="insert into INVENTORY_OPERATION values("+reader["MEDICIN_ID"].ToString()
					+","+total.ToString()+",0"
					+",'"+date.ToString()+"',0,0);";
				l.Add(sqlcom);
				
			}while(reader.Read());
			reader.Close();
			foreach(string sql in l)
			{
				com.CommandText=sql;
				com.ExecuteNonQuery();
			}
			this.closeConnection();

		}
		void initializeId()
		{
			this.openConnection();
			string com="select * from MEDICINS";
			OleDbCommand c=new OleDbCommand(com,this.connection);
			reader=c.ExecuteReader();
			while(reader.Read())
			{
				MedId=Int32.Parse(reader["MEDICIN_ID"].ToString());
				this.minimums.Add(Int32.Parse(reader["MINIMUM_LIMIT"].ToString()));
			}
			if(reader.HasRows)
			{				
				MedId++;
			}
			else MedId=0;
			this.closeConnection();
			

		}
		public void newMedicineHandler(string name,string unit,string min)
		{
			string sqlcom="insert into MEDICINS values(";
			sqlcom+="\'"+name+"\','"+unit+"\',";
			sqlcom+=min+",0,"+MedId.ToString()+");";
			
			this.openConnection();
			try
			{
				
				OleDbCommand command=new OleDbCommand(sqlcom);
				command.Connection=this.connection;
				command.ExecuteNonQuery();
			}
			catch(Exception ex)
			{
				Form1.ErrorMessage(ex.Message,false);
			}
			
			sqlcom="insert into INVENTORY_OPERATION values("+MedId.ToString()+",0,0,'"
				+date.ToString()+"',0,0)";
			com.CommandText=sqlcom;
			com.ExecuteNonQuery();
			this.closeConnection();
			this.minimums.Add(Int32.Parse(min));
			MedId++;
		}
		public bool addNewBuyings(string mid,string quantity,string billNumber,string price)
		{
			this.openConnection();
			
			MyDate date=new MyDate();
			//register a new buying operation in this day
			sqlcom="insert into BUYING_OPERATION values(";
			sqlcom+=mid+",";
			sqlcom+=quantity+",'"+date.ToString()+"',";
			sqlcom+=billNumber+",";
			sqlcom+=price+");";
			com=new OleDbCommand(sqlcom,this.connection);
			com.ExecuteNonQuery();
			//add it to the BUYING field in the INVENTORY_OPERATION table
			sqlcom="select BUYINGS from INVENTORY_OPERATION where DATE='"+date.ToString()+"'";
			sqlcom+=" and MEDICIN_ID="+mid+";";
			com.CommandText=sqlcom;
			reader=com.ExecuteReader();
			if(reader.Read())
			{
				
				int Value=Int32.Parse(reader["BUYINGS"].ToString());
				Value+=Int32.Parse(quantity);
				sqlcom="update INVENTORY_OPERATION set BUYINGS="+Value.ToString();
				sqlcom+=" where MEDICIN_ID="+mid+" and DATE='"+date.ToString()+"';";
				reader.Close();
				com.CommandText=sqlcom;
				com.ExecuteNonQuery();
			}
				//now, if there are no data , this means that we have not created any data today.
			else
			{
				this.closeConnection();
				this.createInventoryForToday();
				this.openConnection();
				date=new MyDate();
				sqlcom="select BUYINGS from INVENTORY_OPERATION where DATE='"+date.ToString()+"'";
				sqlcom+=" and MEDICIN_ID="+mid+";";
				reader=com.ExecuteReader();
				if(reader.Read())
				{
					int Value=Int32.Parse(reader["BUYINGS"].ToString());
					Value+=Int32.Parse(quantity);
					sqlcom="update INVENTORY_OPERATION set BUYINGS="+Value.ToString();
					sqlcom+=" where MEDICIN_ID="+mid+" and DATE='"+date.ToString()+"';";
					reader.Close();
					com=new OleDbCommand(sqlcom,this.connection);
					com.ExecuteNonQuery();
				}
				else
				{
					this.errorMessage();
					return false;
				}

				
			}
			
			this.closeConnection();
			return true;
		}
		public bool addNewReturns(string mid,string quantity,string billNumber,string price)
		{
			this.openConnection();			
			sqlcom="select * from INVENTORY_OPERATION where DATE='"+date.ToString()+"'";
			sqlcom+=" and MEDICIN_ID="+mid+";";
			com.CommandText=sqlcom;
			reader=com.ExecuteReader();
			if(reader.Read())
			{
				int Value=Int32.Parse(reader["RETURNS"].ToString());
				Value+=Int32.Parse(quantity);
				sqlcom="update INVENTORY_OPERATION set RETURNS="+Value.ToString();
				sqlcom+=" where MEDICIN_ID="+mid+" and DATE='"+date.ToString()+"';";
				int rem=Int32.Parse(reader["TOTAL_QUANTITY"].ToString())+Int32.Parse(reader["BUYINGS"].ToString())
					-Int32.Parse(reader["USED_QUANTITY"].ToString())-Value;
				if(rem < 0)
				{
					Form1.ErrorMessage("«·ﬂ„Ì… «·„ÊÃÊœ… «ﬁ· „‰ «·ﬂ„Ì… «·„ÿ·Ê»Â",false);
					return false;
				}
				reader.Close();
				if(rem<(int)minimums[Int32.Parse(mid)])
					Form1.ErrorMessage("\t\t\t Õ–Ì—:\n·ﬁœ »·€ Â–« «·œÊ«¡ «·Õœ «·«œ‰Ï\n„‰ ›÷·ﬂ Õ«Ê· ‘—«¡ ﬂ„Ì… ÃœÌœ… „‰Â",true);
				reader.Close();
				com=new OleDbCommand(sqlcom,this.connection);
				com.ExecuteNonQuery();

				this.openConnection();
				date=new MyDate();
				//register a new buying operation in this day
				sqlcom="insert into RETURNS_OPERATION values(";
				sqlcom+=mid+",";
				sqlcom+=quantity+",'"+date.ToString()+"',";
				sqlcom+=billNumber+",";
				sqlcom+=price+");";
				com=new OleDbCommand(sqlcom,this.connection);
				com.ExecuteNonQuery();				
			}
				//now, if there are no data , this means that we have not created any data today.
			else
			{
				this.closeConnection();
				this.createInventoryForToday();
				this.openConnection();
				date=new MyDate();
				sqlcom="select * from INVENTORY_OPERATION where DATE='"+date.ToString()+"'";
				sqlcom+=" and MEDICIN_ID="+mid+";";
				reader=com.ExecuteReader();
				if(reader.Read())
				{
					int Value=Int32.Parse(reader["RETURNS"].ToString());
					Value+=Int32.Parse(quantity);
					sqlcom="update INVENTORY_OPERATION set RETURNS="+Value.ToString();
					sqlcom+=" where MEDICIN_ID="+mid+" and DATE='"+date.ToString()+"';";
					int rem=Int32.Parse(reader["TOTAL_QUANTITY"].ToString())+Int32.Parse(reader["BUYINGS"].ToString())
						-Int32.Parse(reader["USED_QUANTITY"].ToString())-Value;
					if(rem < 0)
					{
						Form1.ErrorMessage("«·ﬂ„Ì… «·„ÊÃÊœ… «ﬁ· „‰ «·ﬂ„Ì… «·„ÿ·Ê»Â",false);
						return false;
					}
					reader.Close();
					if(rem<(int)minimums[Int32.Parse(mid)])
						Form1.ErrorMessage("\t\t\t Õ–Ì—:\n·ﬁœ »·€ Â–« «·œÊ«¡ «·Õœ «·«œ‰Ï\n„‰ ›÷·ﬂ Õ«Ê· ‘—«¡ ﬂ„Ì… ÃœÌœ… „‰Â",true);

					reader.Close();
					com=new OleDbCommand(sqlcom,this.connection);
					com.ExecuteNonQuery();
				}
				else
				{
					this.errorMessage();
					return false;
				}
			
				this.openConnection();
				date=new MyDate();
				//register a new buying operation in this day
				sqlcom="insert into RETURNS_OPERATION values(";
				sqlcom+=mid+",";
				sqlcom+=quantity+",'"+date.ToString()+"',";
				sqlcom+=billNumber+",";
				sqlcom+=price+");";
				com=new OleDbCommand(sqlcom,this.connection);
				com.ExecuteNonQuery();
			}

			//////////
			this.closeConnection();
			return true;			
		}
		public bool addUsage(string mid,string quantity)
		{
			MyDate date=new MyDate();
			string sqlcom="SELECT * from INVENTORY_OPERATION where MEDICIN_ID ="+mid
				+" and DATE='"+date.ToString()+"';";
			this.openConnection();
			com.CommandText=sqlcom;
			reader=com.ExecuteReader();
			if(!reader.Read())
			{
				reader.Close();
				this.createInventoryForToday();
				this.openConnection();
				com.CommandText=sqlcom;
				reader=com.ExecuteReader();
				if(!reader.Read())
				{
					Form1.ErrorMessage("Fatal error ,please call program developpers",false);
					return false;
				}
   			}
			int usedValue=Int32.Parse(reader["USED_QUANTITY"].ToString());
			usedValue+=Int32.Parse(quantity);
			int rem=Int32.Parse(reader["TOTAL_QUANTITY"].ToString())-usedValue
				-Int32.Parse(reader["RETURNS"].ToString())+Int32.Parse(reader["BUYINGS"].ToString());
			if(rem < 0)
			{
				Form1.ErrorMessage("«·ﬂ„Ì… «·„ÊÃÊœ… «ﬁ· „‰ «·ﬂ„Ì… «·„ÿ·Ê»Â",false);
				return false;
			}
			reader.Close();
			if(rem<(int)minimums[Int32.Parse(mid)])
				Form1.ErrorMessage("\t\t\t Õ–Ì—:\n·ﬁœ »·€ Â« «·œÊ«¡ «·Õœ «·«œ‰Ï\n„‰ ›÷·ﬂ Õ«Ê· ‘—«¡ ﬂ„Ì… ÃœÌœ… „‰Â",true);


			sqlcom="update INVENTORY_OPERATION set USED_QUANTITY="+usedValue.ToString()+" where MEDICIN_ID ="+mid
				+" and DATE='"+date.ToString()+"';";
			com.CommandText=sqlcom;
			com.ExecuteNonQuery();
			return true;
		}

		void errorMessage()
		{
			Form1.ErrorMessage("Â‰«·ﬂ Œÿ√ ,„‰ ›÷·ﬂ Õ«Ê· «” ‘«—… „ÿÊ—Ï «·»—‰«„Ã",false);
			//Application.Exit();
		}
		public bool updateMedicine(int mid,string name,string minLimit,string unit)
		{
			sqlcom="UPDATE MEDICINS set MEDICIN_NAME='"+name+"' ,MEDICIN_UNIT='"+unit+
		"', MINIMUM_LIMIT="+minLimit+" ,TOTAL=0 where MEDICIN_ID="+mid.ToString()+";";
			if(mid>=this.MedId)
				return false;
			this.com.CommandText=sqlcom;
			this.openConnection();
			com.ExecuteNonQuery();
			return true;
		}
		

	}
}
