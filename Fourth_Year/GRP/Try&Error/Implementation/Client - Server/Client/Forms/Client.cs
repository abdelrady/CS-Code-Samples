using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace ChatClient
{
  
   public partial class Client : System.Windows.Forms.Form
   {    

      private NetworkStream output;
      private BinaryWriter writer;
      private BinaryReader reader;
      private string message = "";
      private Thread readThread;
    
   

      // default constructor
      public Client()
      {
         
         InitializeComponent();     
      }

        protected void Client_Closing(object sender, CancelEventArgs e )
      {         
         System.Environment.Exit( System.Environment.ExitCode );
      }

      // sends text the user typed to server
      protected void inputTextBox_KeyDown ( object sender, KeyEventArgs e )
      {
         try
         {         
            if ( e.KeyCode == Keys.Enter )
            {
               writer.Write( inputTextBox.Text );

               displayTextBox.Text +="\r\n Send ID " + inputTextBox.Text;
         
               inputTextBox.Clear();            
            }
         }
         catch ( SocketException )
         {
            displayTextBox.Text += "\nError writing object";
         }

      } // end method inputTextBox_KeyDown

      // connect to server and display server-generated text
      public void RunClient()
      {
         TcpClient client;

         // instantiate TcpClient for sending data to server
         try
         { 
            displayTextBox.Text += "Attempting connection\r\n";

            // Step 1: create TcpClient and connect to server
            client = new TcpClient();
            client.Connect( "localhost", 50000 );

            // Step 2: get NetworkStream associated with TcpClient
            output = client.GetStream();

            // create objects for writing and reading across stream
            writer = new BinaryWriter( output );
            reader = new BinaryReader( output );

            displayTextBox.Text += "\r\nGot I/O streams\r\n";

            inputTextBox.ReadOnly = false;

            /*
             * Write client key at form Title
             */
            this.Text = reader.ReadInt16().ToString();         
            do
            {               
               try
               {                 
                  message = reader.ReadString();
                  if (message == "#USERDATA#")                  
                  { 
                      int length = reader.ReadInt16();
                      byte[]buffer = reader.ReadBytes(length);
                      Seriallized_User user_De_Serial = new Seriallized_User();
                      user_De_Serial.De_Seriallze(buffer);

                      userfnametxt.Text = user_De_Serial.User_Obj.m_userfName;
                      userdescriptiontxt.Text = user_De_Serial.User_Obj.m_userDescription;
                      useremailtxt.Text = user_De_Serial.User_Obj.m_userEmail;                 
                      userlnametxt.Text = user_De_Serial.User_Obj.m_userlName;
                      userphonetxt.Text = user_De_Serial.User_Obj.m_userPhone;
                      userstagecbo.Text = user_De_Serial.User_Obj.m_userStage;
                      vaildCHK.Checked = user_De_Serial.User_Obj.m_userValid;
                       
                  }
                  else
                  displayTextBox.Text += "\r\n" + message; 
               }
               catch (Exception error)
               {
                   MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  System.Environment.Exit(System.Environment.ExitCode );
               }
            } while( message != "SERVER>>> TERMINATE" );      
            displayTextBox.Text += "\r\nClosing connection.\r\n";

            // Step 4: close connection
            writer.Close();
            reader.Close();
            output.Close();
            client.Close();
            Application.Exit();
         }

            // handle exception if error in establishing connection
         catch ( Exception error )
         {
            MessageBox.Show( error.ToString() );
         }

      }

       private void ConnectBTN_Click(object sender, EventArgs e)
       {
           ConnectBTN.Enabled = false;
           readThread = new Thread(new ThreadStart(RunClient));
           readThread.Start();
       } 

   } 
}
