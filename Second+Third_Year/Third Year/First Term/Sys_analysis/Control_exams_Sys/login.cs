using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
//using DefaultNamespace;

namespace WindowsApplication1
{
    public partial class login : UserControl
    {
        public delegate void LoginSuccessful(object sender, EventArgs e);
        public event LoginSuccessful loginSuccessful;

        private const int ID_ERROR = -2147467259;
        private const int DATE_ERROR = -2147217913;
	
        //private OleDbConnection MyConnection;
        private Connection cnn;
        private OleDbDataReader reader;
       /* 
        public void connect()
        {
            try
            {
                MyConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=control_room.mdb");
                MyConnection.Open();
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Error: Database not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }*/
        public login(Connection cn2)
        {
            InitializeComponent();
            cnn = cn2;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = cnn.MyConnection.CreateCommand();
            if (loginRadioButton.Checked)
            {
                cmd.CommandText = "SELECT * FROM Admins  a where a.name='" +
                    nameTextBox.Text + "' and a.pass='" + passwordTextBox.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet dataset = new DataSet();

                int result = adapter.Fill(dataset, "Admins");
                //admin ad = new admin();
                int count = 0;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                reader.Close();
                if (count > 0)
                {
                    this.Hide();

                    loginSuccessful(sender, e);
                    //Form2 ab = new Form2();
                    //ab.Show();
                    //error
                    //else 
                    ;//error
                }
            }
                else if(newAccountRadioButton.Checked)
                {
                    try
                    {
                        string query = "INSERT INTO Admins (Name,Pass) VALUES ('";
                        query +=nameTextBox.Text + "','" + passwordTextBox.Text + "')";
                        //MessageBox.Show(query);

                        if (nameTextBox.Text == "")
                        {

                         MessageBox.Show("Please Enter a value in the name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        if (passwordTextBox.Text == "")
                        {
                            MessageBox.Show("Please Enter a value in the Password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Account has Been Added\nJust Login To IT.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (System.Data.OleDb.OleDbException m)
                    {
                        	MessageBox.Show(m.Message);
                        if (m.ErrorCode == ID_ERROR)
                            MessageBox.Show("Can't add student, a admin with the same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        /* else
                             if (m.ErrorCode == DATE_ERROR)
                                 MessageBox.Show("Please enter a valid date in the date of birth field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         * */
                    }		
                }
}

        private void login_Load(object sender, EventArgs e)
        {
            //this.groupBox1.Top = this.Top;
            //this.groupBox1.Left = this.Left;
            //this.Size = this.groupBox1.Size;
            //connect();
            
            loginRadioButton.Checked = true;
            //connect();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Parent.Controls.Remove(this);
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
