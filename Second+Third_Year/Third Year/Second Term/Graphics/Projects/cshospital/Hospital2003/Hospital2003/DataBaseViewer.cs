using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace Hospital
{
	/// <summary>
	/// Summary description for DataBaseViewer.
	/// </summary>
	public class DataBaseViewer
	{
		
		private string constr="provider=Microsoft.JET.OLEDB.4.0;"
			+@"Data Source=Hospital";
		private OleDbConnection connection=new OleDbConnection();
		private OleDbDataReader reader;
		OleDbCommand com=new OleDbCommand();
		public DataBaseViewer()
		{
			this.connection=new OleDbConnection(this.constr);

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
		public ArrayList GetBuyings(DateTime d,int MedId,Form1 owner)
		{
			
			MyDate date=new MyDate(d);
			string sqlcom="SELECT * From BUYING_OPERATION where DATE='"+date.ToString()
				+"' and MEDICIN_ID="+MedId.ToString()+";";
			this.openConnection();
			this.com=new OleDbCommand(sqlcom,this.connection);
			reader=com.ExecuteReader();
			ArrayList l=new ArrayList();
			while(reader.Read())
			{
				ReturnsBuyingsRecord r=new ReturnsBuyingsRecord();
				r.name=owner.MedicineName(MedId);
				r.price=reader["PRICE"].ToString();
				r.quantity=reader["QUANTITY"].ToString();
				r.unit=Form1.units[MedId].ToString();
				r.bellNumber=reader["BILL_NUMBER"].ToString();
				l.Add(r);
			}
			reader.Close();
			this.closeConnection();
			return l;	
		}
		public ArrayList GetReturns(DateTime d,int MedId,Form1 owner)
		{
			
			MyDate date=new MyDate(d);
			string sqlcom="SELECT * From RETURNS_OPERATION where DATE='"+date.ToString()
				+"' and MEDICIN_ID="+MedId.ToString()+";";
			this.openConnection();
			this.com=new OleDbCommand(sqlcom,this.connection);
			reader=com.ExecuteReader();
			ArrayList l=new ArrayList();
			while(reader.Read())
			{
				ReturnsBuyingsRecord r=new ReturnsBuyingsRecord();
				r.name=owner.MedicineName(MedId);
				r.price=reader["PRICE"].ToString();
				r.quantity=reader["QUANTITY"].ToString();
				r.unit=Form1.units[MedId].ToString();
				r.bellNumber=reader["BILL_NUMBER"].ToString();
				l.Add(r);
			}
			reader.Close();
			this.closeConnection();
			return l;	
		}
	}
}
