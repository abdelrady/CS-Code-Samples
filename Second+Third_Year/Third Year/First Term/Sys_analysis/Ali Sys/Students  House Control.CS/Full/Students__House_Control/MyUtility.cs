using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class MyUtility
    {

        public static System.Data.OleDb.OleDbDataAdapter dataAdbter;
        public static System.Data.OleDb.OleDbDataReader dataReader;
        public static System.Data.DataRow dataRow;
        public static System.Data.OleDb.OleDbConnection dBConnection;
        public static System.Data.OleDb.OleDbCommand MyCommand;
        public static System.Data.DataTable MyDataTable;

        public MyUtility()
        {
        }

        static MyUtility()
        {
            Students__House_Control.MyUtility.MyCommand = new System.Data.OleDb.OleDbCommand();
            Students__House_Control.MyUtility.dataAdbter = new System.Data.OleDb.OleDbDataAdapter();
            Students__House_Control.MyUtility.MyDataTable = new System.Data.DataTable();
        }

        public void AdjustDataGridColumnWidth(System.Data.DataTable myData2, System.Windows.Forms.DataGrid DataGrid2)
        {
            // trial
        }

        public void AdjustDataGridColumnWidth2(System.Data.DataTable myData2, System.Windows.Forms.DataGrid DataGrid2)
        {
            bool flag;
            System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn;

            System.Windows.Forms.DataGridTableStyle dataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            int i = 0;
            while (flag)
            {
                string s = myData2.Columns[i].ColumnName;
                flag = s != "'\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628'";
                if (!flag)
                {
                    dataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
                    dataGridTextBoxColumn.HeaderText = s;
                    dataGridTextBoxColumn.MappingName = s;
                    dataGridTextBoxColumn.NullText = "";
                    dataGridTextBoxColumn.Width = 120;
                }
                else
                {
                    flag = s != "'\u0633\u0628\u0628 \u0627\u0644\u0641\u0635\u0644'";
                    if (!flag)
                    {
                        dataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
                        dataGridTextBoxColumn.HeaderText = s;
                        dataGridTextBoxColumn.MappingName = s;
                        dataGridTextBoxColumn.NullText = "";
                        dataGridTextBoxColumn.Width = 195;
                    }
                    else
                    {
                        dataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
                        dataGridTextBoxColumn.HeaderText = s;
                        dataGridTextBoxColumn.MappingName = s;
                    }
                }
                dataGridTableStyle.GridColumnStyles.Add(dataGridTextBoxColumn);
                i++;
                flag = i < myData2.Columns.Count;
            }
            DataGrid2.TableStyles.Add(dataGridTableStyle);
        }

        public bool CheckAlreadyOpened(System.Windows.Forms.Form mdiParent, string ChildName)
        {
            // trial
            return false;
        }

        public void exQuery(string query, System.Data.OleDb.OleDbParameter prm)
        {
            // trial
        }

        public void exQuery(string query)
        {
            Students__House_Control.MyUtility.MyCommand = new System.Data.OleDb.OleDbCommand(query);
            Students__House_Control.MyUtility.MyCommand.Connection = Students__House_Control.MyUtility.dBConnection;
            Students__House_Control.MyUtility.MyCommand.ExecuteNonQuery();
        }

        public void fillComboBox(System.Windows.Forms.ComboBox MyComboBox, string query)
        {
            // trial
        }

        public void fillList(System.Windows.Forms.ListBox mYlist, string query)
        {
            bool flag;

            RefreshMe();
            mYlist.Items.Clear();
            Students__House_Control.MyUtility.MyCommand.CommandText = query;
            Students__House_Control.MyUtility.MyCommand.Connection = Students__House_Control.MyUtility.dBConnection;
            Students__House_Control.MyUtility.dataAdbter.SelectCommand = Students__House_Control.MyUtility.MyCommand;
            Students__House_Control.MyUtility.dataAdbter.Fill(Students__House_Control.MyUtility.MyDataTable);
            int i = 0;
            while (flag)
            {
                Students__House_Control.MyUtility.dataRow = Students__House_Control.MyUtility.MyDataTable.Rows[i];
                mYlist.Items.Add(Students__House_Control.MyUtility.dataRow[0].ToString());
                i++;
                flag = i < Students__House_Control.MyUtility.MyDataTable.Rows.Count;
            }
        }

        public System.Data.DataTable getDataTable(string query)
        {
            Students__House_Control.MyUtility.MyDataTable.Clear();
            Students__House_Control.MyUtility.MyCommand.CommandText = query;
            Students__House_Control.MyUtility.dataAdbter.SelectCommand = Students__House_Control.MyUtility.MyCommand;
            Students__House_Control.MyUtility.MyCommand.Connection = Students__House_Control.MyUtility.dBConnection;
            Students__House_Control.MyUtility.dataAdbter.Fill(Students__House_Control.MyUtility.MyDataTable);
            return Students__House_Control.MyUtility.MyDataTable;
        }

        public System.Data.OleDb.OleDbConnection getDbConnection()
        {
            string s1 = System.Windows.Forms.Application.ExecutablePath;
            string s2 = s1.ToString().Remove(s1.Length - System.Windows.Forms.Application.ProductName.Length - 5);
            s2 += "Students2003.mdb";
            string s3 = "provider=Microsoft.Jet.OLEDB.4.0; data source =" + s2 + ";User Id=;Password=;;Jet OLEDB:Database Password=motordl";
            Students__House_Control.MyUtility.dBConnection = new System.Data.OleDb.OleDbConnection(s3);
            try
            {
                Students__House_Control.MyUtility.dBConnection.Open();
            }
            catch (System.Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Database is not exist ", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            }
            return Students__House_Control.MyUtility.dBConnection;
        }

        public System.Data.OleDb.OleDbConnection getDbConnection(string dbName)
        {
            // trial
            return null;
        }

        public string getID(string query)
        {
            bool flag;

            string s1 = "";
            Students__House_Control.MyUtility.MyCommand.CommandText = query;
            Students__House_Control.MyUtility.MyCommand.Connection = Students__House_Control.MyUtility.dBConnection;
            Students__House_Control.MyUtility.dataReader = Students__House_Control.MyUtility.MyCommand.ExecuteReader();
            while (flag)
            {
                s1 = Students__House_Control.MyUtility.dataReader.GetValue(0).ToString();
                flag = Students__House_Control.MyUtility.dataReader.Read();
            }
            Students__House_Control.MyUtility.dataReader.Close();
            return s1;
        }

        public bool isDuplicated(string query)
        {
            // trial
            return false;
        }

        public void RefreshMe()
        {
            Students__House_Control.MyUtility.MyCommand.Dispose();
            Students__House_Control.MyUtility.dataAdbter.Dispose();
            Students__House_Control.MyUtility.MyDataTable.Dispose();
            Students__House_Control.MyUtility.MyCommand = new System.Data.OleDb.OleDbCommand();
            Students__House_Control.MyUtility.dataAdbter = new System.Data.OleDb.OleDbDataAdapter();
            Students__House_Control.MyUtility.MyDataTable = new System.Data.DataTable();
            getDbConnection();
        }

    } // class MyUtility

}

