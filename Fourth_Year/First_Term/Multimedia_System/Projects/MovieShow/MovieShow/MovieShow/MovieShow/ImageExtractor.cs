using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

using DexterLib;

namespace ImageExtractor
{	
    
  public partial class ImageExtractor : System.Windows.Forms.Form
  {
    string fileName;           //used to save the movie file name 
    string storagePath;        //used for the path where we save files
    MediaDetClass md;          //needed to extract pictures
    static int counter = 0;    //to generate different file names
    float interval = 1.0f;     //default time interval

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MainMenu File;
    private System.Windows.Forms.MenuItem miFile;
    private System.Windows.Forms.MenuItem miOpenFile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Button ScanButton;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.Button backward;
    private System.Windows.Forms.Button forward;
    private System.Windows.Forms.MenuItem miSpeed;
    private System.Windows.Forms.MenuItem miNormalSpeed;
      private System.Windows.Forms.MenuItem miFastSpeed;
      private IContainer components;


    public ImageExtractor()
    {
      InitializeComponent();

      //initialize a few properties
      trackBar1.Minimum = trackBar1.Maximum = 0;
      this.MaximizeBox = false;
      miNormalSpeed.Checked = true;
      storagePath = Application.StartupPath + "\\tmp\\";

      //if the storage directory doesn't exist we create it
      if( !Directory.Exists( storagePath ) )
        Directory.CreateDirectory( storagePath );     
    }

    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if (components != null) 
        {
          components.Dispose();
        }
      }      
      try 
      { 
        //try to get rid of all the tmp files created during the session
        if( pictureBox1.Image != null )
          pictureBox1.Image.Dispose();
        string [] bmpFiles = Directory.GetFiles( storagePath, "*.bmp" );
        for( int i = 0; i < bmpFiles.Length; i++ )
          System.IO.File.Delete( bmpFiles[i] );
      } 
      catch( Exception ) { MessageBox.Show( "Couldn't delete all temporary files" ); }
      base.Dispose( disposing );
    }

		#region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.SaveButton = new System.Windows.Forms.Button();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.ScanButton = new System.Windows.Forms.Button();
        this.File = new System.Windows.Forms.MainMenu(this.components);
        this.miFile = new System.Windows.Forms.MenuItem();
        this.miOpenFile = new System.Windows.Forms.MenuItem();
        this.menuItem1 = new System.Windows.Forms.MenuItem();
        this.miSpeed = new System.Windows.Forms.MenuItem();
        this.miNormalSpeed = new System.Windows.Forms.MenuItem();
        this.miFastSpeed = new System.Windows.Forms.MenuItem();
        this.label1 = new System.Windows.Forms.Label();
        this.trackBar1 = new System.Windows.Forms.TrackBar();
        this.backward = new System.Windows.Forms.Button();
        this.forward = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
        this.SuspendLayout();
        // 
        // SaveButton
        // 
        this.SaveButton.Location = new System.Drawing.Point(8, 8);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(64, 40);
        this.SaveButton.TabIndex = 0;
        this.SaveButton.Text = "Save";
        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        // 
        // pictureBox1
        // 
        this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pictureBox1.Location = new System.Drawing.Point(8, 64);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(320, 240);
        this.pictureBox1.TabIndex = 1;
        this.pictureBox1.TabStop = false;
        // 
        // ScanButton
        // 
        this.ScanButton.Location = new System.Drawing.Point(88, 8);
        this.ScanButton.Name = "ScanButton";
        this.ScanButton.Size = new System.Drawing.Size(64, 40);
        this.ScanButton.TabIndex = 4;
        this.ScanButton.Text = "Scan";
        this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
        // 
        // File
        // 
        this.File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miFile,
            this.menuItem1});
        // 
        // miFile
        // 
        this.miFile.Index = 0;
        this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miOpenFile});
        this.miFile.Text = "File";
        // 
        // miOpenFile
        // 
        this.miOpenFile.Index = 0;
        this.miOpenFile.Text = "Open File";
        this.miOpenFile.Click += new System.EventHandler(this.miOpenFile_Click);
        // 
        // menuItem1
        // 
        this.menuItem1.Index = 1;
        this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miSpeed});
        this.menuItem1.Text = "Options";
        // 
        // miSpeed
        // 
        this.miSpeed.Index = 0;
        this.miSpeed.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miNormalSpeed,
            this.miFastSpeed});
        this.miSpeed.Text = "Scan Speed";
        // 
        // miNormalSpeed
        // 
        this.miNormalSpeed.Index = 0;
        this.miNormalSpeed.Text = "Every 1.0 sec";
        this.miNormalSpeed.Click += new System.EventHandler(this.miNormalSpeed_Click);
        // 
        // miFastSpeed
        // 
        this.miFastSpeed.Index = 1;
        this.miFastSpeed.Text = "Every 0.1 sec";
        this.miFastSpeed.Click += new System.EventHandler(this.miFastSpeed_Click);
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.label1.Location = new System.Drawing.Point(176, 8);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(56, 40);
        this.label1.TabIndex = 5;
        // 
        // trackBar1
        // 
        this.trackBar1.Location = new System.Drawing.Point(8, 312);
        this.trackBar1.Name = "trackBar1";
        this.trackBar1.Size = new System.Drawing.Size(320, 45);
        this.trackBar1.TabIndex = 6;
        this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
        // 
        // backward
        // 
        this.backward.Location = new System.Drawing.Point(240, 8);
        this.backward.Name = "backward";
        this.backward.Size = new System.Drawing.Size(40, 40);
        this.backward.TabIndex = 7;
        this.backward.Text = "<";
        this.backward.Click += new System.EventHandler(this.backward_Click);
        // 
        // forward
        // 
        this.forward.Location = new System.Drawing.Point(288, 8);
        this.forward.Name = "forward";
        this.forward.Size = new System.Drawing.Size(40, 40);
        this.forward.TabIndex = 8;
        this.forward.Text = ">";
        this.forward.Click += new System.EventHandler(this.forward_Click);
        // 
        // ImageExtractor
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(336, 345);
        this.Controls.Add(this.forward);
        this.Controls.Add(this.backward);
        this.Controls.Add(this.trackBar1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.ScanButton);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.SaveButton);
        this.Menu = this.File;
        this.Name = "ImageExtractor";
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.Text = "ImageExtractor";
        this.Load += new System.EventHandler(this.ImageExtractor_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }
		#endregion

    [STAThread]
   /* static void Main() 
    {
      try 
      {
        Application.Run(new Form1());
      } 
      catch( Exception e ) { MessageBox.Show( e.Message ); }
    }*/

    private void SaveButton_Click(object sender, System.EventArgs e)
    {
      counter++;
      pictureBox1.Image.Dispose();
      string fBitmapName = storagePath + Path.GetFileNameWithoutExtension( fileName ) 
        + "_" + counter.ToString();
      md.WriteBitmapBits( trackBar1.Value, 320, 240, fBitmapName + ".bmp" );
      pictureBox1.Image = new Bitmap( fBitmapName + ".bmp" );      
      //save the picture as jpeg
      Image img = Image.FromFile( fBitmapName + ".bmp" );
      img.Save( fBitmapName + ".jpg", ImageFormat.Jpeg );
      img.Dispose();
    }
    
    // Thread class to be able to display the progress
    // using the static label
    class ScanThread 
    {
      MediaDetClass md;
      string fileName;
      string storagePath;
      float interval;
      public Thread t;      
      public ScanThread( string s, string f, float ival )       
      {        
        storagePath = s;
        fileName = f;
        interval = ival;
        t = new Thread( new ThreadStart( this.Scan) );
        t.Start();
      }
      void Scan() 
      {
        md = new MediaDetClass();
        Image img;
        md.Filename = fileName;      
        md.CurrentStream = 0;
        int len = (int)md.StreamLength;
        for( float i = 0.0f; i < len; i = i + interval ) 
        {
          counter++;
          string fBitmapName = storagePath + Path.GetFileNameWithoutExtension( fileName ) 
            + "_" + counter.ToString();
          md.WriteBitmapBits( i, 320, 240, fBitmapName + ".bmp" );      
          img = Image.FromFile( fBitmapName + ".bmp" );
          img.Save( fBitmapName + ".jpg", ImageFormat.Jpeg );
          img.Dispose();
          System.IO.File.Delete( fBitmapName + ".bmp" );        
        }
      }
    }


    private void ScanButton_Click(object sender, System.EventArgs e)
    {
      if( md == null ) return;
      
      ScanThread st = new ScanThread( storagePath, fileName, interval );
      do 
      {
        //waits until the processing is done, displaying the
        //number of the file we are currently saving
        Thread.Sleep( 1000 );
        label1.Text = "Saving: " + counter.ToString();        
        label1.Invalidate();
        label1.Update();        
      } while (st.t.IsAlive );
      label1.Text = "Saving: DONE"; 
    }

    private void miOpenFile_Click(object sender, System.EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      if( dlg.ShowDialog() == DialogResult.OK ) 
      { 
        try 
        {
          fileName = dlg.FileName;
          this.Text = Path.GetFileName( dlg.FileName );

          //create the MediaDetClass and set its properties
          md = new MediaDetClass();
          md.Filename = fileName;      
          md.CurrentStream = 0;
          int len = (int)md.StreamLength;

          //fix a few Gui stuff
          label1.Text = "Length: " + len.ToString();
          trackBar1.Minimum = 0;
          trackBar1.Maximum = len;
          trackBar1.Value = 0;

          //make sure we have a unique name then call WriteBitmapBits to
          //a file then use it to fill the picture box
          counter++;
          string fBitmapName = storagePath + counter.ToString() + ".bmp" ;
          md.WriteBitmapBits( 0, 320, 240, fBitmapName );
          pictureBox1.Image = new Bitmap( fBitmapName );        
        } 
        catch( Exception ) { MessageBox.Show( "Coulnd't open movie file" ); }
      }          
    }

    private void trackBar1_ValueChanged(object sender, System.EventArgs e)
    {
      if( md == null ) return;
      pictureBox1.Image.Dispose();
      label1.Text = "Cur Pos: " + trackBar1.Value.ToString();
      string fBitmapName = storagePath + "tmp" + counter.ToString() + ".bmp";
      counter++;
      md.WriteBitmapBits( trackBar1.Value, 320, 240, fBitmapName );
      pictureBox1.Image = new Bitmap( fBitmapName );      
    
    }

    private void backward_Click(object sender, System.EventArgs e)
    {
      if( trackBar1.Value >= trackBar1.Minimum + 1 )
        trackBar1.Value = trackBar1.Value - 1;
    }

    private void forward_Click(object sender, System.EventArgs e)
    {
      if( trackBar1.Value <= trackBar1.Maximum - 1 )
        trackBar1.Value = trackBar1.Value + 1;
    }

    private void miNormalSpeed_Click(object sender, System.EventArgs e)
    {
      miNormalSpeed.Checked = true;
      miFastSpeed.Checked = false;
      interval = 1.0f;
    }

    private void miFastSpeed_Click(object sender, System.EventArgs e)
    {
      miNormalSpeed.Checked = false;
      miFastSpeed.Checked = true;
      interval = 0.1f;
    
    }

      private void ImageExtractor_Load(object sender, EventArgs e)
      {

      }

      


      

      
  }  
}
