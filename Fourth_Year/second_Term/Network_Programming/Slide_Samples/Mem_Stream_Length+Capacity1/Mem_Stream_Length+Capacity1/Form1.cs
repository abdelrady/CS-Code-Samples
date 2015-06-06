using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Mem_Stream_Length_Capacity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] arr = Encoding.Default.GetBytes("Welcokhgjhgjdflgjshruweoprtoqi]3940385723895189iewoutiowuqtudskjaglkdsghhiewotuyq87458734865437me_");
            byte[] arr0 = new byte[100];
            MemoryStream ms = new MemoryStream(arr0);
            MessageBox.Show("Length= " + ms.Length.ToString() + " ,Capacity= " + ms.Capacity.ToString());
            ms.Write(arr, 0, arr.Length - 3);
            ms.Flush();
            byte[] arr2=ms.GetBuffer();
            byte[] arr3=ms.ToArray();
            MessageBox.Show("Length= " + ms.Length.ToString() + " ,Capacity= " + ms.Capacity.ToString());
            MessageBox.Show("Buffer Length= " + arr2.Length.ToString() + " ,ToArray() Length= " + arr3.Length.ToString());

        }
        public string ImageToString(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            Image im = Image.FromFile(path);
            MemoryStream ms = new MemoryStream();
            im.Save(ms, im.RawFormat);
            byte[] array = ms.ToArray();
            string array2=Convert.ToBase64String(array);
            MessageBox.Show("arr1 length= "+array.Length.ToString()+" ,arr2 length= "+array2.Length.ToString());
            return array2;
        }

        public Image StringToImage(string imageString)
        {
            if (imageString == null)
                throw new ArgumentNullException("imageString");
            byte[] array = Convert.FromBase64String(imageString);
            MessageBox.Show("arr1 length= " + array.Length.ToString() + " ,arr2 length= " + imageString.Length.ToString());
            Image image = Image.FromStream(new MemoryStream(array));
            return image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // convert the image to a string.
            string imageAsString = ImageToString(@"E:\img3gray.bmp");
            // or convert it back to an image.
            Image image = StringToImage(imageAsString);


        }
        private MemoryStream GetData()
        {
            //Create the return memorystream object that will hold the buffered data.
            MemoryStream ReturnStream = new MemoryStream();
            //Put together the connection string
            string cn = @"Persist Security Info=False;Integrated Security=false;User ID=sa;Pwd=sa;database=c:\db\sdasdb.mdf;server=.\sqlexpress;Connect Timeout=30";
            try
            {
                //Get the sql string
                string SqlString = "select * from dbo.users";
                //Create a new command object
                SqlCommand sc = new SqlCommand();
                //Set the connection
                sc.Connection = new SqlConnection(cn);
                //Open the connection
                sc.Connection.Open();
                //Set the command type
                sc.CommandType = CommandType.Text;
                //Set the SQL String
                sc.CommandText = SqlString;
                //Execute the SQL Statement/Procedure
                SqlDataReader RS = sc.ExecuteReader();
                //Create a streamwriter to write to the memory stream 
                StreamWriter sw = new StreamWriter(ReturnStream);
                if (RS.HasRows)
                {
                    RS.Read();
                    //Create a header for the file from the names of the columns that we are retrieving
                    string tempstring = "";
                    for (int counter = 0; counter < RS.FieldCount; counter++)
                    {
                        tempstring += RS.IsDBNull(counter) ? "" : RS.GetName(counter) + "\t";
                    }
                    //Write the row of data to the Memory Stream.
                    sw.WriteLine(tempstring);
                    //Loop through the data row and write the contents to the memory stream.
                    do
                    {
                        //Put each columns' data value into a string separated by a tab.
                        tempstring = "";
                        for (int counter = 0; counter < RS.FieldCount; counter++)
                        {
                            tempstring += RS.IsDBNull(counter) ? "" : RS.GetValue(counter).ToString() + "\t";
                        }
                        //Write the row of data to the Memory Stream. 
                        sw.WriteLine(tempstring);
                    }
                    while (RS.Read());
                }
                //Clean up the stream writer
                sw.Flush();
                sw.Close();
                //Clean up the data reader
                RS.Close();
                //Clean up the command object
                sc.Connection.Close();
                sc.Dispose();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            //Return the memory Stream
            return ReturnStream;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Encoding.UTF8.GetString(GetData().ToArray()));
        }

    }
}