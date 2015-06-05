using System;
using System.Collections;
using System.ComponentModel;
using System.Data;using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.IO;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
/********************************************************************
	author:		Quartz (quartz@interviewinfo.net) Please keep the comments if you distribute Please keep the comments if you distribute
	created:	18:9:2004   5:55
	created:	11/11/2005
	file base:	dbMain.aspx
	purpose:	list all the tables in the db
*********************************************************************/

namespace AdminLite
{
	/// <summary>
	/// Summary description for Template.
	/// </summary>
	public partial class dbMain : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lbltables2;
		protected void Page_Load(object sender, System.EventArgs e)
		{
			string sAction = "";
            string sTable = "";
            string sField = "";
			string sID = "";
            
			if (Request.QueryString["action"]==null)
			{}
			else
				sAction =(Request.QueryString["action"]).Trim() ;

			if (Request.QueryString["table"]==null)
			{}
			else
				sTable = (Request.QueryString["table"]).Trim();
            
			if (Request.QueryString["field"]==null)
			{}
			else
				sField = (Request.QueryString["field"]).Trim();
			
			if (Request.QueryString["ID"]==null)
			{}
			else
				sID = (Request.QueryString["ID"]).Trim();

			if (sAction == "")
				sAction = "listtb";
			

			if (sAction.ToLower() == "listtb")
			{
				WriteHeaders("Choose Table");
				ListTables();
			}
			if (sAction.ToLower() == "addtable")
			{
				WriteHeaders ("Add Table");
				AddTable();
			}
			if (sAction.ToLower() == "savetable")
			{
				WriteHeaders ("Table Created");
				SaveTable();
			}
			if (sAction.ToLower() == "edittable")
			{
				WriteHeaders ("Edit Table " + sTable);
				EditTable();
			}
			if (sAction.ToLower() == "deletetable")
			{
				WriteHeaders ("Delete Table " + sTable);
				DeleteTable();
			}
			if (sAction.ToLower() == "cleartable")
			{
				WriteHeaders ("Clear Table " + sTable );
				ClearTable();
			}
			if (sAction.ToLower() == "addfield")
			{
				WriteHeaders ("Add Field: in " + sTable);
				AddField();
			}
			if (sAction.ToLower() == "editfield")
			{
				WriteHeaders ("Edit Field " + sField + " in: " + sTable);
				EditField();
			}
			if (sAction.ToLower() == "deletefield")
			{
				WriteHeaders ("Delete " + sField + " From: " + sTable);
				DeleteField();
			}
			if (sAction.ToLower() == "savefield")
			{
				WriteHeaders ("Saving Field " + sField + " in: " + sTable);
				SaveField();
			}
			if (sAction.ToLower() == "executesql")
			{
				WriteHeaders ("Execute Custom SQL Statment");
				ExecSQL();
			}
		}
		private void EditTable()
		{
		    WriteBack();
			string sTable ="";
			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}
			lbltables.Text = "";
			lbltables.Text = lbltables.Text + "<tr><td colspan=6><table width = 100% cellspacing = 0 cellpadding = 0><TR><td align = left><FONT face='Arial' color='#006699' size='2'>Table:[<b>" + sTable + "</b>]  </font></td><td align = right><a href=dbmain.aspx?action=addfield&table=" + sTable + " ><FONT face='Arial' color='#006699' size='2'>Add New Field</a></FONT></TD><tr></table></TD><tr>";
			lbltables.Text = lbltables.Text + "<TR><td><FONT face='Arial' color='gray' size='2'><b>Delete</b></FONT></TD>";
			lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'><b>Edit</b></FONT></TD>";
			lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'><b>Column Name</b></FONT></TD>";
			lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'><b>Data Type</b></FONT></TD>";
			lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'><b>Length</b></FONT></TD>";
			lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'><b>Allow Nulls</b></FONT></TR>";

			string s="";
			
			SqlDataReader myReader;
			s = "SELECT * FROM " + sTable;
			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			myReader = myclass.getData(s);
			DataTable myT;
			myT = myReader.GetSchemaTable(); 

//			foreach (DataRow myField in myT.Rows)
//			{
//				//For each property of the field...
//				foreach (DataColumn myProperty in myT.Columns) 
//				{
//					//Display the field name and value.
//					//Console.WriteLine(myProperty.ColumnName + " = " + myField[myProperty].ToString());
//					lbltables.Text = lbltables.Text + "<TR><td colspan = 6><FONT face='Arial' color='#006699' size='2'>Table:[<b>" + sTable + "</b>]  </font><a href=dbmain.aspx?action=addfield&table=" + sTable + " ><FONT face='Arial' color='#006699' size='2'>" + myProperty.ColumnName + " = " + myField[myProperty].ToString() + "</a></FONT></TD><tr>";
//			
//				}
//			}
			int FirstKeyCnt = 1;
			foreach (DataRow myField in myT.Rows)
			{
				if (FirstKeyCnt ==1)
				{
					lbltables.Text = lbltables.Text + "<TR><td><FONT face='Arial' color='#006699' size='2'>PK</FONT></TD>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='#006699' size='2'>PK</FONT></TD>";
				}
				else
				{
					lbltables.Text = lbltables.Text + "<TR><td><a href=dbmain.aspx?action=deletefield&table=" + sTable + "&field=" + myField["ColumnName"].ToString() + " ><FONT face='Arial' color='#006699' size='2'>Delete</FONT></a></TD>";
					lbltables.Text = lbltables.Text + "<td><a href=dbmain.aspx?action=editfield&table=" + sTable + "&field=" + myField["ColumnName"].ToString() + " ><FONT face='Arial' color='#006699' size='2'>Edit</FONT></a></TD>";
				}
					//if ((String.Compare(myField["IsKey"].ToString(),"true") == 0))
				if (FirstKeyCnt ==1)
				{
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='#006699' size='2'>" + myField["ColumnName"].ToString() + "</b></FONT></TD>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='#006699' size='2'>" + myField["DataType"].ToString() + "</FONT></TD>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='#006699' size='2'>" + myField["ColumnSize"].ToString()  + "</FONT></TR>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='#006699' size='2'>" + myField["AllowDBNull"].ToString()  + "</FONT></TD>";
					}
				else
				{
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'>" + myField["ColumnName"].ToString() + "</FONT></TD>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'>" + myField["DataType"].ToString() + "</FONT></TD>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'>" + myField["ColumnSize"].ToString()  + "</FONT></TR>";
					lbltables.Text = lbltables.Text + "<td><FONT face='Arial' color='gray' size='2'>" + myField["AllowDBNull"].ToString()  + "</FONT></TD>";
					}
					
			FirstKeyCnt++;
			}
	
		}
		private void DeleteTable()
		{
			WriteBack();
			string sTable = (Request.QueryString["table"]).Trim();
			
			if (Request.QueryString["confirm"]==null)
			{
				lbltables.Text = "<tr><td>&nbsp;&nbsp;</td><td><a href=dbmain.aspx?action=deletetable&confirm=yes&table=" + sTable + "><FONT face='Arial' color='#006699' size='2'>Confirm - Delete the Table: <b>" + sTable + "</b> ? </Font></a><br><br> <a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>No - Do not Delete the Table: <b>" + sTable + "</b>  </Font></a></td></tr>";
			}	
			else
			{
				if ((Request.QueryString["confirm"]).ToLower() == "yes")
				{
					if (sTable == "")
						Response.Write("No Name entered for Delete Table operation");
					else
						try
						{
							string s =  "Drop Table " + sTable ;
							clsDataAccess myclass = new clsDataAccess();
							myclass.openConnection();
							int i = myclass.TableWrite(s);
							lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Table Deleted </font><a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a><BR></td></tr>";
						}
                
						catch(Exception e)
						{
							lbltables.Text = "<tr><td>&nbsp;</td><td> <FONT face='Arial' color='#006699' size='2'>Error: </font><FONT face='Arial' color='red' size='2'>" + e.Message + "</font></td></tr>"; 

						}
				
				}
				else
				{
					Response.Write("<BR><BR>");
					WriteHeaders("<a href=dbmain.aspx?action=deletetable&confirm=yes&table=" + sTable + "><FONT face='Arial' color='#006699' size='2'>Confirm - Delete the Table: " + sTable + " ? </Font></a><br><br> <a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>No - Do not Delete the Table: " + sTable + "  </Font></a>");
				}
			}

		}
		private void ClearTable()
		{
	     WriteBack();
			string sTable ="";
			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}
			if (Request.QueryString["confirm"]==null)
			{
				lbltables.Text = "<tr><td>&nbsp;&nbsp;</td><td><a href=dbmain.aspx?action=cleartable&confirm=yes&table=" + sTable + "><FONT face='Arial' color='#006699' size='2'>Confirm - Clear/delete all the records from the Table: <b>" + sTable + "</b> ? </Font></a><br><br> <a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>No - Do not clear the Table: <b>" + sTable + "</b>  </Font></a></td></tr>";
			}
			else
			{
				if ((Request.QueryString["confirm"]).ToLower() == "yes") 
				{
					
                
					if (sTable == "") 
						Response.Write("No Table Name entered for Clear Table Operation");
					else
					{
						try
						{
							string s =  "Truncate Table " + sTable ;
							clsDataAccess myclass = new clsDataAccess();
							myclass.openConnection();
							int i = myclass.TableWrite(s);
							lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Table Cleared </font><a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a><BR></td></tr>";
						
						}
						catch(Exception e)
						{
							lbltables.Text = "<tr><td>&nbsp;</td><td> <FONT face='Arial' color='#006699' size='2'>Error: </font><FONT face='Arial' color='red' size='2'>" + e.Message + "</font></td></tr>"; 

						}
					}
				}
			}
    	}
		private void AddField()
		{
			string sTable ="";
			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}
			
			WriteBack();
			lbltables.Text = "<FORM METHOD='POST' ACTION='dbmain.aspx?action=savefield&table=" + sTable + "'>";
			lbltables.Text = lbltables.Text + "<TR><TD colspan = 2><a href='dbmain.aspx?action=edittable&table=" + sTable + "'><FONT face='Arial' color='#006699' size='2'>Back to Edit Table</FONT></a></TD></tr>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Field Name<font color=red>*</font></FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='field' SIZE='13' VALUE='MyField'></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25% valign = 'top'><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Data Type<font color=red>*</font></FONT><INPUT TYPE='hidden' NAME='datatype' SIZE='5' VALUE='nvarchar'></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<SELECT NAME='cdatatype' SIZE='25' onChange='this.form.length.value=this.value;getOption()'>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >bigint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >binary</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='1' >bit</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='10' >char</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >datetime</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='9' >decimal</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >float</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >image</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >int</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >money</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='10' >nchar</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >ntext</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='9' >numeric</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION  value ='50' selected>nvarchar</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >real</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >smalldatetime</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='2' >smallint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >smallmoney</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='' >sql_variant</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >text</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >timestamp</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='1' >tinyint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >uniqueidentifier</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >varbinary</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >varchar</OPTION>";
			lbltables.Text = lbltables.Text + "</SELECT></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Length</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='length' SIZE='13' VALUE='50'><FONT face='Verdana' color='#006699' size='1'>&nbsp;<a target = '_blank' href='datatype.htm' title = 'Click here to find out Maximum length allowed for a typical data type'>Allowed lengths ^</a></font></TD>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Default Value</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='default' SIZE='13' VALUE=''></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Allow Null</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<SELECT NAME='allownull' SIZE='1'>";
			lbltables.Text = lbltables.Text + "<OPTION value = 'Null' selected>Yes</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='Not Null' >No</OPTION>";

			lbltables.Text = lbltables.Text + "<TR><TD>&nbsp;</TD>";
			lbltables.Text = lbltables.Text + "<TD><INPUT TYPE='Submit' VALUE='Add Field'>&nbsp;&nbsp;&nbsp;&nbsp;<INPUT TYPE='Reset' VALUE='Reset'></TD>";
			lbltables.Text = lbltables.Text + "</TR><TR><td colspan=2><FONT face='Verdana' color='#006699' size='1'>A Field will be added with the data type selected and given length</font></td></tr>";
			lbltables.Text = lbltables.Text + "</FORM>";
		}
		private void EditField()
		{
			string sTable ="";
			string sField ="";
			string sDatatype = "";
			string sLength = "";
			//string sDefault = "";
			string sAllowNull = "";

			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}

			if (Request.QueryString["field"]==null)
			{}
			else
			{
				sField = (Request.QueryString["field"]).Trim();
			}
			
			string s="";
			
			SqlDataReader myReader;
			s = "SELECT * FROM " + sTable;
			clsDataAccess myclass = new clsDataAccess();
			myclass.openConnection();
			myReader = myclass.getData(s);
			DataTable myT;
			myT = myReader.GetSchemaTable();
			

			foreach (DataRow myField in myT.Rows)
			{
				if (String.Compare(myField["ColumnName"].ToString(),sField)==0)
				{
					sDatatype = myField["DataType"].ToString();
					sLength = myField["ColumnSize"].ToString();
					//sDefault = myField["Value"].ToString();
					sAllowNull = myField["AllowDBNull"].ToString();
				}
			}


			WriteBack();
			lbltables.Text = "<FORM METHOD='POST' ACTION='dbmain.aspx?action=savefield&edit=true&table=" + sTable + "'>";
			lbltables.Text = lbltables.Text + "<TR><TD colspan = 2><a href='dbmain.aspx?action=edittable&table=" + sTable + "'><FONT face='Arial' color='#006699' size='2'>Back to Edit Table</FONT></a></TD></tr>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Field Name<font color=red>*</font></FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='field' SIZE='13' VALUE='" + sField + "'></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25% valign = 'top'><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Data Type<font color=red>*</font><br><font  color='#006699' size = 1 face = verdana>" + sDatatype + "</font></FONT><INPUT TYPE='hidden' NAME='datatype' SIZE='5' VALUE='nvarchar'></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<SELECT NAME='cdatatype' SIZE='25' onChange='this.form.dlength.value=this.value;getOption()'>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >bigint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >binary</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='1' >bit</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='10' >char</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >datetime</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='9' >decimal</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >float</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >image</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >int</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >money</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='10' >nchar</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >ntext</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='9' >numeric</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION  value ='50' selected>nvarchar</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >real</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >smalldatetime</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='2' >smallint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='4' >smallmoney</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='' >sql_variant</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >text</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='8' >timestamp</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='1' >tinyint</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='16' >uniqueidentifier</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >varbinary</OPTION>";
			lbltables.Text = lbltables.Text + "<OPTION value ='50' >varchar</OPTION>";
			lbltables.Text = lbltables.Text + "</SELECT></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Default Length</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' ReadOnly ='true' BackColor ='Ghostwhite' NAME='dlength' SIZE='13' VALUE='255'></TD>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Current Length</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='length' SIZE='13' VALUE='" + sLength + "'><FONT face='Verdana' color='#006699' size='1'>&nbsp;<a target = '_blank' href='datatype.htm' title = 'Click here to find out Maximum length allowed for a typical data type'>Allowed lengths ^</a></font></TD>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Default Value</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<INPUT TYPE='text' NAME='default' SIZE='13' VALUE=''></TD>";
			lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 25%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Allow Null</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD>&nbsp;<SELECT NAME='allownull' SIZE='1'>";

			if  (String.Compare(sAllowNull,"True")==0)
			{
				lbltables.Text = lbltables.Text + "<OPTION value = 'Null' selected>Yes</OPTION>";
				lbltables.Text = lbltables.Text + "<OPTION value ='Not Null' >No</OPTION>";
			}
			else
			{
				lbltables.Text = lbltables.Text + "<OPTION value = 'Null' >Yes</OPTION>";
				lbltables.Text = lbltables.Text + "<OPTION value ='Not Null' selected>No</OPTION>";
			}
			lbltables.Text = lbltables.Text + "<TR><TD>&nbsp;</TD>";
			lbltables.Text = lbltables.Text + "<TD><INPUT TYPE='Submit' VALUE='Edit Field'>&nbsp;&nbsp;&nbsp;&nbsp;<INPUT TYPE='Reset' VALUE='Reset'></TD>";
			lbltables.Text = lbltables.Text + "</TR><TR><td colspan=2><FONT face='Verdana' color='#006699' size='1'>A Field will be added with the data type selected and given length</font></td></tr>";
			lbltables.Text = lbltables.Text + "</FORM>";
		}
		private void DeleteField()
		{
			WriteBack();
			string sTable = "";
			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}

			string sField = "";
			if (Request.QueryString["table"]==null)
			{}
			else
			{
				sField= (Request.QueryString["field"]).Trim();
			}

			if (Request.QueryString["confirm"]==null)
			{
				lbltables.Text = "<tr><td>&nbsp;&nbsp;</td><td><a href=dbmain.aspx?action=deletefield&confirm=yes&field="+ sField +"&table=" + sTable + "><FONT face='Arial' color='#006699' size='2'>Confirm - Delete Field:<b>" + sField + "</b> from the Table:" + sTable + "?</Font></a><br><br> <a href='dbmain.aspx?action=edittable&table=" + sTable+ "'><FONT face='Arial' color='#006699' size='2'>No - Do not delete the Field: <b>" + sField + "</b>  </Font></a></td></tr>";
			}
			else
			{
				if ((Request.QueryString["confirm"]).ToLower() == "yes") 
				{
					
                
					if ((sTable == "") || (sField=="")) 
						Response.Write("No Table/Field Name entered for Delete Field Operation");
					else
					{
						try
						{
							string s =  "ALTER TABLE " + sTable + " DROP COLUMN " + sField;
							clsDataAccess myclass = new clsDataAccess();
							myclass.openConnection();
							int i = myclass.TableWrite(s);
							lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Field Deleted </font><a href='dbmain.aspx?action=edittable&table=" + sTable+ "'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a><BR></td></tr>";
						
						}
						catch(Exception e)
						{
							lbltables.Text = "<tr><td>&nbsp;</td><td> <FONT face='Arial' color='#006699' size='2'>Error: </font><FONT face='Arial' color='red' size='2'>" + e.Message + "</font></td></tr>"; 

						}
					}
				}
			}
		}
		private void SaveField()
		{
			WriteBack();
			string sTable ="";
			string sField = "";
			string sDatatype = "";
			string sLength = "";
			string sDefault = "";
			string sAllowNull = "";
			string sEdit = "";
			string s ="";
			
			sDatatype = (Request.Form["datatype"]).Trim();
			sField = (Request.Form["field"]).Trim();
			sLength = (Request.Form["length"]).Trim();
			sDefault = (Request.Form["default"]).Trim();
			sAllowNull = (Request.Form["allownull"]).Trim();
			
			if (Request.QueryString["table"]==null)
			{
			Response.Write("No Table Name found!");
			}
			else
			{
				sTable = (Request.QueryString["table"]).Trim();
			}
			if (Request.QueryString["edit"]==null)
			{
				//Response.Write("No Table Name found!");
			}
			else
			{
				sEdit = (Request.QueryString["edit"]).Trim();
			}
			
		      
			if ((String.Compare(sEdit,"true"))==0)
			{
				s =  "Alter Table " + sTable + "  Alter Column  " + sField + " " + sDatatype ;
				if (sLength != "") 
				{
					s =  s + " (" + sLength + ")";
				}
				if (sDefault != "") 
				{
					s = s + " DEFAULT '" + sDefault + "' ";
				}
				if (sAllowNull != "") 
				{
					s = s + " " + sAllowNull + "";
				}
			}
			else
			{
				s =  "Alter Table " + sTable + " ADD " + sField + " " + sDatatype ;
				if (sLength != "") 
				{
					s =  s + " (" + sLength + ")";
				}
				if (sDefault != "") 
				{
					s = s + " DEFAULT '" + sDefault + "' ";
				}
				if (sAllowNull != "") 
				{
					s = s + " " + sAllowNull + "";
				}
			}

				try
				{
					clsDataAccess myclass = new clsDataAccess();
					myclass.openConnection();
					int i = myclass.TableWrite(s);

					if ((String.Compare(sEdit,"true"))==0)
					lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Field: <b>" + sField + "</b> Updated </font><a href='dbmain.aspx?action=edittable&table=" + sTable + "'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a> <br></td></tr>";
					else
					lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Field: <b>" + sField + "</b> Created </font><a href='dbmain.aspx?action=edittable&table=" + sTable + "'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a> <br></td></tr>";
					
				}
				catch(Exception e)
				{
					lbltables.Text = "<tr><td>&nbsp;</td><td> <FONT face='Arial' color='#006699' size='2'>Error: </font><FONT face='Arial' color='red' size='2'>" + e.Message + " sEdit:" + sEdit + "</font></td></tr>"; 
				}
		
		}
		private void ExecSQL()
		{
		WriteBack();
			if (Request.Form["sql"]==null)
			{
				lbltables.Text ="<FORM METHOD='POST' ACTION='dbmain.aspx?action=executesql'>";
				lbltables.Text = lbltables.Text + "<tr><td>&nbsp;&nbsp;</td><td><FONT face='Arial' color='#006699' size='2'>Enter your SQL Statments below. (<a title = 'Learn to Create/Edit SQL tables at www.w3schools.com' href= 'http://www.w3schools.com/sql/sql_create.asp' target = '_blank'><FONT face='Arial' color='#006699' size='2'>Learn SQL Tables^</font></a>)</font><BR>";
				lbltables.Text = lbltables.Text + "<FONT face='Arial' color='#006699' size='2'>New Lines will be processed as different Statements.</font><BR>";
				lbltables.Text = lbltables.Text + "<FONT face='Arial' color='#006699' size='2'>Comments are shown with a [single quote ' ] in front of them</font></td></tr>";
				lbltables.Text = lbltables.Text + "<tr><td>&nbsp;&nbsp;</td><td><TEXTAREA NAME='sql' ROWS='15' COLS='80'>\n";
				lbltables.Text = lbltables.Text + "'Enter your SQL Statements here as seen below...\n";
				lbltables.Text = lbltables.Text + "'==================================================\n\n";
				lbltables.Text = lbltables.Text + "'Create the table and Add the autonumber ID field as the primary key\n";
				lbltables.Text = lbltables.Text + "Create Table MyTABLENAME ([ID] INTEGER PRIMARY KEY IDENTITY)\n\n";
				lbltables.Text = lbltables.Text + "'Add 6 other fields with data type\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add Firstname varChar(255)\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add Lastname varChar(255)\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add City varChar(255)\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add State varChar(255)\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add Country varChar(255)\n";
				lbltables.Text = lbltables.Text + "Alter table MyTABLENAME Add Age Integer\n</TEXTAREA></td></tr>";
				lbltables.Text = lbltables.Text + "<tr><td>&nbsp;&nbsp;</td><td>";
				lbltables.Text = lbltables.Text + "<TABLE BORDER='0' CELLPADDING='1' CELLSPACING='0'>";
				lbltables.Text = lbltables.Text + "<TR><TD ALIGN='Left'><INPUT TYPE='submit' VALUE='Execute SQL'></TD>";
				lbltables.Text = lbltables.Text + "<TD ALIGN='Left'>&nbsp;&nbsp;<INPUT TYPE='Reset' VALUE='Reset'></TD></TR></TABLE></td></tr></FORM>";
			}
			else
			{
				//'execute the SQL Statment'
				StringReader re = new StringReader(Request.Form["sql"].Trim());
				string input = null;
				int i = 1;
				lbltables.Text =  "<tr><td>&nbsp;&nbsp;</td><td><FONT face='Arial' color='#006699' size='2'>Do not refresh this page or it will execute again!<br><b>Starts Execution...</b>";

				while(( input = re.ReadLine()) != null)
				{

					try
					{
						//Response.Write("input.Substring((1,1):" + input.Substring(1,1)) ;
  
						if (input.Length != 0) 
						{
							if (input.Substring(0,1) == "'") 
								lbltables.Text = lbltables.Text  + "<tr><td valign='top'><b><FONT face='Arial' color='#006699' size='1'>"+i+"</font></b>&nbsp;</td><td><FONT face='Arial' color='#006699' size='1'><b>Comment Line:</b> " + input + "<b><font face = arial size = 1 color = blue><b>&nbsp;Not Executed </font></b></font><BR></td></tr>";
					
							else
							{
								clsDataAccess myclass = new clsDataAccess();
								myclass.openConnection();
								lbltables.Text = lbltables.Text  + "<tr><td valign='top'><b><FONT face='Arial' color='#006699' size='1'>"+i+"</font></b>&nbsp;</td><td><FONT face='Arial' color='#006699' size='1'>Executing #:<b>" + (i) + "</b>:" + input + "</font><BR>\n";
								int j = myclass.TableWrite(input);
								lbltables.Text = lbltables.Text  + "<FONT face='Arial' color='#006699' size='1'>Executed #:<b>" + (i) + ":<font color = '#009900' face = arial size = 1><b>Successful</b></font></font><BR></td></tr>";
					
							}
						}
						else
						{
							lbltables.Text = lbltables.Text  + "<tr><td valign='top'><b><FONT face='Arial' color='#006699' size='1'>"+i+"</font></b>&nbsp;</td><td><FONT face='Arial' color='#006699' size='1'><b>Blank Line: </b>" + input + "<font face = arial size = 1 color = blue><b>&nbsp;Not Executed</font></b> </font><BR>\n";
						}

					}
					catch(Exception e)
					{
						lbltables.Text = lbltables.Text  + "<tr><td valign=top><b><FONT face='Arial' color='#006699' size='1'>"+i+"</font></b>&nbsp;</td><td> <FONT face='Arial' color='red' size='1'><b>Error #: </b>" + (i ) + " </font><FONT face='Arial' color='red' size='1'>" + e.Message + "</font></td></tr>"; 
					}
					finally
					{
					i++;
					}
				}
			

			}
		
       
       
		}

		private void ListTables()
		{
			try
			{
			clsDataAccess myclass = new clsDataAccess();//Login class is called
			DataTable  myT = myclass.getTablenames();
			int i = 1;
			
				foreach (DataRow row in myT.Rows)
				{
					if (i == 1)
						lbltables.Text = "<TR><TD width='23'><FONT face='Arial' color='#006699' size='2'><STRONG>Sno.</STRONG></FONT></TD><TD bgColor='#ffffff'><FONT face='Arial' color='#006699' size='2'><STRONG>TABLE NAME</STRONG></FONT></FONT></TD><TD bgColor='#ffffff'><FONT face='Arial' color='#006699' size='2'><STRONG>Edit</STRONG></FONT></FONT></TD><TD bgColor='#ffffff'><FONT face='Arial' color='#006699' size='2'><STRONG>Clear</STRONG></FONT></FONT></TD><TD bgColor='#ffffff'><FONT face='Arial' color='#006699' size='2'><STRONG>Delete</STRONG></FONT></FONT></TD></TR>";

					lbltables.Text = lbltables.Text + "<TR><TD width='23'><FONT face='Arial' color='#006699' size='2'><STRONG>" + i + "</STRONG></FONT></TD><TD bgColor='#ffffff'><FONT size='2'><A href='db.aspx?table=" + row["TABLE_NAME"] + "'><FONT face='Arial' color='#006699'>" + row["TABLE_NAME"] + " </A></FONT></FONT></TD><TD bgColor='#ffffff'><a href='dbMain.aspx?action=edittable&table=" + row["TABLE_NAME"] + "'><FONT face='Arial' color='#006699' size='2'>Edit</A></FONT></FONT></TD><TD bgColor='#ffffff'><a href='dbMain.aspx?action=cleartable&table=" + row["TABLE_NAME"] + "'><FONT face='Arial' color='#006699' size='2'>Clear</a></FONT></FONT></TD><TD bgColor='#ffffff'><a href='dbMain.aspx?action=deletetable&table=" + row["TABLE_NAME"] + "'><FONT face='Arial' color='#006699' size='2'>Delete</a></FONT></FONT></TD></TR>";
					i++;
				}
			}
			catch(Exception err)
			{
				lbltables.Text = "<TR><TD colspan = '6'><FONT face='Arial' color='red' size='2'><STRONG>&nbsp;&nbsp;ERROR: " + err.Message + "</STRONG></FONT></TD></TR>";
			}
		}
		private void AddTable()
		{
			WriteBack();
			lbltables.Text = "<FORM METHOD='POST' ACTION='dbmain.aspx?action=savetable'>";
			lbltables.Text = lbltables.Text + "<TR><TD width = 20%><FONT COLOR='#000000' FACE='Arial' SIZE='2'>Table Name</FONT></TD>";
			lbltables.Text = lbltables.Text + "<TD><INPUT TYPE='text' NAME='tablename' SIZE='30' VALUE='MyTable1'></TD>";
            lbltables.Text = lbltables.Text + "</TR>";
			lbltables.Text = lbltables.Text + "<TR><TD>&nbsp;</TD>";
			lbltables.Text = lbltables.Text + "<TD><INPUT TYPE='submit' VALUE='Save'>&nbsp;&nbsp;&nbsp;&nbsp;<INPUT TYPE='Reset' VALUE='Reset'></TD>";
			lbltables.Text = lbltables.Text + "</TR><TR><td colspan=2><FONT face='Verdana' color='#006699' size='1'>A table will be added with Primary Key [ID] and data type Integer and Identity with increment and seed 1</font></td></tr>";
			lbltables.Text = lbltables.Text + "</FORM>";
		}
		private void SaveTable()
		{
			WriteBack();
            string sTable = (Request.Form["tablename"]).Trim();
            if (sTable == "")
				Response.Write("No Name entered!");
			else
              
				try
				{
					string s =  "Create Table " + sTable + " ([ID] INTEGER PRIMARY KEY IDENTITY)";
					clsDataAccess myclass = new clsDataAccess();
					myclass.openConnection();
					int i = myclass.TableWrite(s);
					
					lbltables.Text ="<tr><td>&nbsp;&nbsp;</td><td><BR><BR><FONT face='Arial' color='#006699' size='2'>Table: <b>" + sTable + "</b> Created </font><a href='dbmain.aspx?action=listtb'><FONT face='Arial' color='#006699' size='2'>Click here to Continue</a><BR></td></tr>";
						
				}
				catch(Exception e)
				{
					lbltables.Text = "<tr><td>&nbsp;</td><td> <FONT face='Arial' color='#006699' size='2'>Error: </font><FONT face='Arial' color='red' size='2'>" + e.Message + "</font></td></tr>"; 
				}
		}
		private void WriteBack()
		{
			WriteHeaders("<a href=dbmain.aspx?action=listtb><FONT face='Arial' color='#006699' size='2'><b><< Back to Main Page</b></Font></a>");
		}
			
		private void WriteHeaders(string s)
		{
			lblHeader.Text = " " + s; 
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

		
	}
}
