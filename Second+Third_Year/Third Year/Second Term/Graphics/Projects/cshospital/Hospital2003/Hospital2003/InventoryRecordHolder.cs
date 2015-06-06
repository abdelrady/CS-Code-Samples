using System;
using System.Data.OleDb;

namespace Hospital
{
	/// <summary>
	/// Summary description for InventoryRecordHolder.
	/// </summary>
	public class InventoryRecord
	{
		public string name,
			unit,
			remaining,
			used,
			total,
			buyings,
			returns,
			minimum;
		
	}
	public class ReturnsBuyingsRecord
	{
		public string name,
			unit,
			quantity,
			bellNumber,
			price;
	}
}
