using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Students__House_Control
{

    public class MyUtility
    {

        public static OleDbDataAdapter dataAdbter;
        public static OleDbDataReader dataReader;
        public static DataRow dataRow;
        public static OleDbConnection dBConnection;
        public static OleDbCommand MyCommand;
        public static DataTable MyDataTable;

        public MyUtility()
        {
        }

        static MyUtility()
        {
            MyUtility.MyCommand = new OleDbCommand();
            MyUtility.dataAdbter = new OleDbDataAdapter();
            MyUtility.MyDataTable = new DataTable();
        }

        public void AdjustDataGridColumnWidth(DataTable myData2, DataGrid DataGrid2)
        {
            // trial
        }

        public void AdjustDataGridColumnWidth2(DataTable myData2, DataGrid DataGrid2)
        {
            bool flag;
            DataGridTextBoxColumn dataGridTextBoxColumn;

            DataGridTableStyle dataGridTableStyle = new DataGridTableStyle();
            int i = 0;
            while (flag)
            {
                string s = myData2.Columns[i].ColumnName;
                flag = s != "'\u0627\u0633\u0645 \u0627\u0644\u0637\u0627\u0644\u0628'";
                if (!flag)
                {
                    dataGridTextBoxColumn = new DataGridTextBoxColumn();
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
                        dataGridTextBoxColumn = new DataGridTextBoxColumn();
                        dataGridTextBoxColumn.HeaderText = s;
                        dataGridTextBoxColumn.MappingName = s;
                        dataGridTextBoxColumn.NullText = "";
                        dataGridTextBoxColumn.Width = 195;
                    }
                    else
                    {
                        dataGridTextBoxColumn = new DataGridTextBoxColumn();
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

        public bool CheckAlreadyOpened(Form mdiParent, string ChildName)
        {
            // trial
            return false;
        }

        public void exQuery(string query, OleDbParameter prm)
        {
            // trial
        }

        public void exQuery(string query)
        {
            MyUtility.MyCommand = new OleDbCommand(query);
            MyUtility.MyCommand.Connection = MyUtility.dBConnection;
            MyUtility.MyCommand.ExecuteNonQuery();
        }

        public void fillComboBox(ComboBox MyComboBox, string query)
        {
            // trial
        }

        public void fillList(ListBox mYlist, string query)
        {
            bool flag;

            RefreshMe();
            mYlist.Items.Clear();
            MyUtility.MyCommand.CommandText = query;
            MyUtility.MyCommand.Connection = MyUtility.dBConnection;
            MyUtility.dataAdbter.SelectCommand = MyUtility.MyCommand;
            MyUtility.dataAdbter.Fill(MyUtility.MyDataTable);
            int i = 0;
            while (flag)
            {
                MyUtility.dataRow = MyUtility.MyDataTable.Rows[i];
                mYlist.Items.Add(MyUtility.dataRow[0].ToString());
                i++;
                flag = i < MyUtility.MyDataTable.Rows.Count;
            }
        }

        public DataTable getDataTable(string query)
        {
            MyUtility.MyDataTable.Clear();
            MyUtility.MyCommand.CommandText = query;
            MyUtility.dataAdbter.SelectCommand = MyUtility.MyCommand;
            MyUtility.MyCommand.Connection = MyUtility.dBConnection;
            MyUtility.dataAdbter.Fill(MyUtility.MyDataTable);
            return MyUtility.MyDataTable;
        }

        public OleDbConnection getDbConnection()
        {
            string s1 = Application.ExecutablePath;
            string s2 = s1.ToString().Remove(s1.Length - Application.ProductName.Length - 5);
            s2 += "Students2003.mdb";
            string s3 = "provider=Microsoft.Jet.OLEDB.4.0; data source =" + s2 + ";User Id=;Password=;;Jet OLEDB:Database Password=motordl";
            MyUtility.dBConnection = new OleDbConnection(s3);
            try
            {
                MyUtility.dBConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database is not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return MyUtility.dBConnection;
        }

        public OleDbConnection getDbConnection(string dbName)
        {
            // trial
            return null;
        }

        public string getID(string query)
        {
            bool flag;

            string s1 = "";
            MyUtility.MyCommand.CommandText = query;
            MyUtility.MyCommand.Connection = MyUtility.dBConnection;
            MyUtility.dataReader = MyUtility.MyCommand.ExecuteReader();
            while (flag)
            {
                s1 = MyUtility.dataReader.GetValue(0).ToString();
                flag = MyUtility.dataReader.Read();
            }
            MyUtility.dataReader.Close();
            return s1;
        }

        public bool isDuplicated(string query)
        {
            // trial
            return false;
        }

        public void RefreshMe()
        {
            MyUtility.MyCommand.Dispose();
            MyUtility.dataAdbter.Dispose();
            MyUtility.MyDataTable.Dispose();
            MyUtility.MyCommand = new OleDbCommand();
            MyUtility.dataAdbter = new OleDbDataAdapter();
            MyUtility.MyDataTable = new DataTable();
            getDbConnection();
        }

    } // class MyUtility

}

