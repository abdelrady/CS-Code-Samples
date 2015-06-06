using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Database_Adminstration
{
    public class DBUtility
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlCommand cmd_Ins_Image;
        private SqlParameter [] param = new SqlParameter[2];

        public DBUtility() { }
        public SqlConnection ConnectToSQL()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\db\SDASDB.mdf';Integrated Security=True;Connect Timeout=30;User Instance=True");
            Retry:
            try
            {
              con.Open();
            }
            catch(Exception e)
            {
                if (MessageBox.Show("Can't Open Database\n" + e.Message + "\nApplication will now close.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    goto Retry;
            }
            return con;
        }
        public int ExcuteQuery(string Query, SqlConnection connection)
        {
            cmd = new SqlCommand(Query, connection);
            return cmd.ExecuteNonQuery();

        }
        public DataRow GetRow(string Query, SqlConnection connection)
        {          
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, connection);
            DataTable Dtable = new DataTable();
            Adapter.Fill(Dtable);          
            return Dtable.Rows[0];     
        }
        public int InsertImage(string Image_path,string userID,SqlConnection connection)
        {
            int retValue = 0;
            FileStream ImageStream = new FileStream(Image_path, FileMode.Open);
            byte[] buffer = new byte[(int)ImageStream.Length];
            ImageStream.Read(buffer, 0, (int)ImageStream.Length);
            ImageStream.Close();
            cmd_Ins_Image = new SqlCommand("insert_image", connection);
            cmd_Ins_Image.CommandType = CommandType.StoredProcedure;

            //
            //1st param
            //
            param[0] = new SqlParameter("@image", SqlDbType.Image);
            param[0].Value = buffer;
            
            //
            //2nd param
            //
            param[1] = new SqlParameter("@UserID", SqlDbType.NVarChar);
            param[1].Value = userID;

           
             cmd_Ins_Image.Parameters.AddRange(param);


            try
            {
                retValue = cmd_Ins_Image.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't insert image into th data base \n"+e.Message+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retValue;
        }
        public DialogResult Notify(Form owner,string message)
        {
            return MessageBox.Show(owner, message, "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
