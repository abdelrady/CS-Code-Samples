using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Threading;
using System.Collections;

namespace SmartDoor
{

    public class DBUtility
    {
        private SqlConnection m_DbConnection;
        private SqlCommand cmd_Ins_Image;
        private SqlCommand cmd_Get_Image;
        private SqlParameter GetIparam;
        private SqlParameter[] param = new SqlParameter[2];
        private bool mConnectedToDB = false;
        Form mParent = null;
        public enum User_Status
        { 
            None,     
            User_Valid_And_Allowed,
            User_Invalid,
            User_Not_Exist,
            User_Not_Allowed_To_Enter_Door
        };      
        public bool IsConnected
        {
            get { return mConnectedToDB; }
        }

        public DBUtility(Form ParentFrm)
        {
            mParent = ParentFrm;
        }

        public SqlConnection ConnectToSQL()
        {
        Retry:
            try
            {
                m_DbConnection = new SqlConnection(Configuration.connectionString);
            }
            catch
            {
                MessageBox.Show(mParent, "Bad connection string properity \n\r[" + Configuration.connectionString + "].\n\rYou have to reconfigure connection string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }

            try
            {
                m_DbConnection.Open();
                mConnectedToDB = true;
            }
            catch (Exception e)
            {
                if (MessageBox.Show(mParent, "Can't Open Database\n" + e.Message + "\nApplication will now close.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    goto Retry;
            }
            return m_DbConnection;
        }
        public void DisConnectToSQL()
        {
            try
            {
                m_DbConnection.Close();
                mConnectedToDB = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't Close Connection\n" + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public int ExcuteQuery(string Query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query, m_DbConnection);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(mParent, "Can't Execute Query\n" + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            return -1;
        }

        public User_Status GetRow(string mDoorNumber, string Barcode, out string[] out_Data, out byte[] Image_Data)
        {
            User_Status Us = User_Status.User_Not_Exist; ;
            out_Data = null;
            Image_Data = null;
            /*
             * the scenario is as follow
             * see whether such use exist or no
             * if not exist return null
             * if exist  his validity or activation is checked 
             * if valid see if he is allowed to enter from this door or no
             * if not allowed null,...
             * if he is not activated (not valid )null,...
             */

            try
            {
                SmartDoor.Classes.DataSet1TableAdapters.UserStatusTableAdapter userStatusTableAdapter = new SmartDoor.Classes.DataSet1TableAdapters.UserStatusTableAdapter();
                int? status = 0;
                SmartDoor.Classes.Doors_DataSet.UserStatusDataTable userStatusDataTable = userStatusTableAdapter.GetData(Barcode, int.Parse(mDoorNumber), ref  status);
                if (userStatusDataTable.Rows.Count > 0)
                {
                    out_Data = new string[userStatusDataTable.Columns.Count];
                    out_Data[0] = userStatusDataTable.Rows[0]["UserFname"].ToString();
                    out_Data[1] = userStatusDataTable.Rows[0]["Userlname"].ToString();
                    out_Data[2] = userStatusDataTable.Rows[0]["UserPhone"].ToString();
                    out_Data[3] = userStatusDataTable.Rows[0]["UserStage"].ToString();
                    out_Data[4] = userStatusDataTable.Rows[0]["UserEmail"].ToString();
                    out_Data[5] = userStatusDataTable.Rows[0]["UserDescription"].ToString();
                    if ((byte[])userStatusDataTable.Rows[0]["UserImage"] != null)
                    {
                        Image_Data = ImageCompressor.Compress((byte[])userStatusDataTable.Rows[0]["UserImage"], 25);
                        Array.Resize(ref Image_Data, Image_Data.Length + 9);
                        Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, Image_Data, Image_Data.Length - 9, 9);
                    }
                    switch (status)
                    {
                        case 1:
                            Us = User_Status.User_Not_Allowed_To_Enter_Door;
                            break;
                        case 2:
                            Us = User_Status.User_Valid_And_Allowed;
                            break;
                        case 3:       
                            Us = User_Status.User_Invalid;
                            break;
                        case 0:
                            Us = User_Status.User_Not_Exist;
                            break;
                    }
                }
                else
                    return Us;
            }
            catch (Exception d)
            {
                MessageBox.Show(mParent, "Can not Get Row,\n\r " + d.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return User_Status.None;
            }
            return Us;
        }

        public string[] Users_List(string m_DoorNum)
        {
            if (IsConnected)
            {

                ArrayList values = new ArrayList();
                try
                {
                    /*get count to allocate memory*/

                    SqlCommand cmd = new SqlCommand("EXECUTE @NumOfUsers = UsersList @DoorNum", m_DbConnection);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NumOfUsers", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@DoorNum", SqlDbType.Int));
                    
                    cmd.Parameters[1].Value = int.Parse(m_DoorNum);
                    cmd.Parameters[0].Direction = ParameterDirection.Output;
                    //int x =int.Parse(cmd.ExecuteNonQuery().ToString());
                   
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            values.Add(dr[0].ToString());
                        }
                    }
                    dr.Close(); //You Must Close DataReader Before reading OutPut Value
                    //if(Convert.ToInt32( cmd.Parameters[1].Value)==0)
                    int count = 0;
                    string[] strValues = new string[values.Count];
                    foreach (object obj in values)
                    {
                        strValues[count++] = obj.ToString();
                    }
                    return strValues;
                    }
                catch (Exception d)
                {
                   // MessageBox.Show(mParent, "Can not Get list of students ,\n\r " + d.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return null;
        }
        public static string[] Get_String_Data(object[] param)
        {
            string[] ret = new string[param.Length];
            for (int i = 0; i < param.Length; i++)
            {
                ret[i] = Convert.ToString(param[i]);
            }
            return ret;
        }
        public int InsertImage(string Image_path, string userID)
        {
            int retValue = 0;
            FileStream ImageStream = new FileStream(Image_path, FileMode.Open);
            byte[] buffer = new byte[(int)ImageStream.Length];
            ImageStream.Read(buffer, 0, (int)ImageStream.Length);
            ImageStream.Close();
            cmd_Ins_Image = new SqlCommand("insert_image");
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
                MessageBox.Show(mParent, "Can't insert image into dataBase \n" + e.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retValue;
        }
        public byte[] Retrieve_Image(string BarCodeID)
        {
            byte[] imageData;

            cmd_Get_Image = new SqlCommand("Get_Image", m_DbConnection);
            cmd_Get_Image.CommandType = CommandType.StoredProcedure;

            GetIparam = new SqlParameter("@ID", SqlDbType.NVarChar);
            GetIparam.Value = BarCodeID;
            cmd_Get_Image.Parameters.Add(GetIparam);

            try
            {
                if (!System.Convert.ToBoolean(cmd_Get_Image.ExecuteScalar() == System.DBNull.Value))
                {
                    imageData = (byte[])cmd_Get_Image.ExecuteScalar();
                    if (imageData != null)
                    {
                        Array.Resize(ref imageData, imageData.Length + 9);
                        Array.Copy(Encoding.ASCII.GetBytes("[#<EOF>#]"), 0, imageData, imageData.Length - 9, 9);
                        return imageData;
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(mParent, "Can't Retrieve Image\n" + ex.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public DialogResult Notify(string message)
        {
            return MessageBox.Show(mParent, message, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal bool Verify_Door_Authorization(string DoorID, string Door_Password)
        {
            SqlCommand cmd = new SqlCommand("SELECT doorPassword FROM Doors WHERE doorNum=" + DoorID, m_DbConnection);
            string D_Password = Convert.ToString(cmd.ExecuteScalar()).Trim();
            if (D_Password.Trim() != null)
            {
                return D_Password == Door_Password;
            }
            else return false;
        }

        internal void Append_User_Log(
            string Door_Number,
            string passed_barcode_from_Remote_host,
            string Date,
            string Valid,
            SqlConnection connection)
        {
            /*
             * By Eagles **Ali* *Abdo**
             */
            SqlCommand cmd = new SqlCommand("[add_log]", m_DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] log_params = new SqlParameter[4];

            log_params[0] = new SqlParameter("@time", SqlDbType.DateTime);
            log_params[0].Value = Date;
            cmd.Parameters.Add(log_params[0]);

            log_params[1] = new SqlParameter("@ID", SqlDbType.NVarChar);
            log_params[1].Value = passed_barcode_from_Remote_host;
            cmd.Parameters.Add(log_params[1]);

            log_params[2] = new SqlParameter("@doorNumber", SqlDbType.Int);
            log_params[2].Value = int.Parse(Door_Number);
            cmd.Parameters.Add(log_params[2]);

            log_params[3] = new SqlParameter("@allowed", SqlDbType.Bit);
            log_params[3].Value = Valid;
            cmd.Parameters.Add(log_params[3]);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Thread.Sleep(1000);
                //MessageBox.Show(mParent,"Can't Append User Log into Database \n" + e.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Synchronize_Door_Name(string Door_Name, string Door_Num)
        {

            SqlCommand cmd = new SqlCommand("SELECT doorName FROM Doors WHERE doorNum=" + Door_Num, m_DbConnection);
            string Old_Name = Convert.ToString(cmd.ExecuteScalar()).Trim();
            if (Old_Name == Door_Name) return;//no change in name
            else
            {
                //change , synch NOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW!
                cmd.CommandText = "UPDATE Doors SET doorName='" + Door_Name + "' WHERE doorNum=" + Door_Num;
                cmd.ExecuteNonQuery();
            }
        }

        internal object Get_Single_Value(string Query)
        {
            SqlCommand Command = new SqlCommand(Query, m_DbConnection);
            return Command.ExecuteScalar();

        }

        internal void Update_Door_Time(string m_DoorNumber)
        {

            SqlCommand cmd = new SqlCommand("[Set_Update_To_Door]", m_DbConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] log_params = new SqlParameter[2];

            log_params[0] = new SqlParameter("@time", SqlDbType.DateTime);
            log_params[0].Value = DateTime.Now.ToString();
            cmd.Parameters.Add(log_params[0]);

            log_params[1] = new SqlParameter("@doorNumber", SqlDbType.Int);
            log_params[1].Value = int.Parse(m_DoorNumber);
            cmd.Parameters.Add(log_params[1]);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(mParent, "Can't Update Door 'Last Update' Field \n" + e.Message + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
