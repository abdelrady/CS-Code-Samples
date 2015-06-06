using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace game2
{
    public partial class Form1 : Form
    {
//**************************************Variable******************************
        
        SoundPlayer asd = new SoundPlayer();
        int gamesMov = 8;
        int playeNumber=1;
        int xp1, yp1; int xp2, yp2;
        int xp3, yp3; int xp4, yp4;
        int ych, xch;
        int nxp1,nyp1,nxp2,nyp2,nxp3,nyp3,nxp4,nyp4;

        int dis; Random randnumber = new Random();
        int xrand, yrand;
        int win;
        int countTime;
        Boolean b1, b2,b5,b6;
        int xpd, ypd;
        //, b3, b4;
        int MaxPointUp, MaxPointDown;
        int MaxPointRight, MaxPointLeft;
        int secNumber;
        string[] playerinf = new string[10]; int i;
        string[] playerName = new string[10];
        bool newGame=true;
        bool GameOver = false;
        private System.Windows.Forms.ToolStripMenuItem [] newt=new ToolStripMenuItem[10];
        //***************Sound Play*********************************
        public void mysound(string name)
        {
            asd.SoundLocation = Directory.GetCurrentDirectory() + "\\" + name;
            asd.Play();
        }
    //**************************************************************
        public void picturRandom()
        {
            win++;
            label1.Text = "Score:" + win.ToString();
            xrand = randnumber.Next(0, (375 - pictureBox6.Width));
            yrand = randnumber.Next(22, (235 - pictureBox6.Height));
            pictureBox5.Location = new System.Drawing.Point(xrand, yrand);
        }
//**********************Dead*******************************************************
        public void DeadSnake()
        {
           // timer1.Enabled = false;
            //timer2.Enabled = false;
            GameOver = true;
           
        }
//*******************move up*******************************************************
        public void moveUp()
        {

            if (yp1 <= MaxPointUp)
            {
                /*ych = MaxPointDown;
                pictureBox1.Location = new System.Drawing.Point(xp1, ych);
                yp1 = ych;*/
                DeadSnake();
            }
            else
            {
                xp1 = pictureBox1.Location.X;
                yp1 = pictureBox1.Location.Y;
                xp2 = pictureBox2.Location.X;
                yp2 = pictureBox2.Location.Y;
                xp3 = pictureBox3.Location.X;
                yp3 = pictureBox3.Location.Y;
                xp4 = pictureBox4.Location.X;
                yp4 = pictureBox4.Location.Y;
                //move...........
                ych -= dis;
                pictureBox1.Location = new System.Drawing.Point(xp1, ych);
                pictureBox2.Location = new System.Drawing.Point(xp1, yp1);
                pictureBox3.Location = new System.Drawing.Point(xp2, yp2);
                pictureBox4.Location = new System.Drawing.Point(xp3, yp3);



            }
        }
 //************** move down********************************************
        public void moveDown()
        {
            if (yp1 >= MaxPointDown)
            {
                /*ych = MaxPointUp;
                pictureBox1.Location = new System.Drawing.Point(xp1, ych);
                yp1 = ych;*/
                DeadSnake();
            }
            else
            {
                xp1 = pictureBox1.Location.X;
                yp1 = pictureBox1.Location.Y;
                xp2 = pictureBox2.Location.X;
                yp2 = pictureBox2.Location.Y;
                xp3 = pictureBox3.Location.X;
                yp3 = pictureBox3.Location.Y;
                xp4 = pictureBox4.Location.X;
                yp4 = pictureBox4.Location.Y;
                ych += dis;
                pictureBox1.Location = new System.Drawing.Point(xp1, ych);
                pictureBox2.Location = new System.Drawing.Point(xp1, yp1);
                pictureBox3.Location = new System.Drawing.Point(xp2, yp2);
                pictureBox4.Location = new System.Drawing.Point(xp3, yp3);

            }
        }
//*************move right**********************************************
        public void moveRight()
        {
            if (xp1 >= MaxPointRight)
            {
                /*xch = MaxPointLeft;
                pictureBox1.Location = new System.Drawing.Point(xch, yp1);
                xp1 = xch;*/
                DeadSnake();
            }
            else
            {
                xp1 = pictureBox1.Location.X;
                yp1 = pictureBox1.Location.Y;
                xp2 = pictureBox2.Location.X;
                yp2 = pictureBox2.Location.Y;
                xp3 = pictureBox3.Location.X;
                yp3 = pictureBox3.Location.Y;
                xp4 = pictureBox4.Location.X;
                yp4 = pictureBox4.Location.Y;
                xch += dis;
                pictureBox1.Location = new System.Drawing.Point(xch, yp1);
                pictureBox2.Location = new System.Drawing.Point(xp1, yp1);
                pictureBox3.Location = new System.Drawing.Point(xp2, yp2);
                pictureBox4.Location = new System.Drawing.Point(xp3, yp3);

            }
        }
//************move left***********************************************************
        public void moveLeft()
        {
            if (xp1 <= MaxPointLeft)
            {
                /*xch = MaxPointRight;
                pictureBox1.Location = new System.Drawing.Point(xch, yp1);
                xp1 = xch;*/
                DeadSnake();
            }
            else
            {
                xp1 = pictureBox1.Location.X;
                yp1 = pictureBox1.Location.Y;
                xp2 = pictureBox2.Location.X;
                yp2 = pictureBox2.Location.Y;
                xp3 = pictureBox3.Location.X;
                yp3 = pictureBox3.Location.Y;
                xp4 = pictureBox4.Location.X;
                yp4 = pictureBox4.Location.Y;

                xch -= dis;
                pictureBox1.Location = new System.Drawing.Point(xch, yp1);
                pictureBox2.Location = new System.Drawing.Point(xp1, yp1);
                pictureBox3.Location = new System.Drawing.Point(xp2, yp2);
                pictureBox4.Location = new System.Drawing.Point(xp3, yp3);
            }
        }
 //**********************end ************************************************
        public Form1()
        {
            InitializeComponent();
        }
//********************************************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            nxp1 = xp1 = pictureBox1.Location.X;
            nyp1 = yp1 = pictureBox1.Location.Y;
            nxp2 = xp2 = pictureBox2.Location.X;
            nyp2 = yp2 = pictureBox2.Location.Y;
            nxp3 = xp3 = pictureBox3.Location.X;
            nyp3 = yp3 = pictureBox3.Location.Y;
            nxp4 = xp4 = pictureBox4.Location.X;
            nyp4 = yp4 = pictureBox4.Location.Y;
            xrand = pictureBox5.Location.X;
            yrand = pictureBox5.Location.Y;
            xpd = pictureBox6.Location.X;
            ypd = pictureBox6.Location.Y;
            dis = pictureBox4.Height;
            MaxPointDown = panel1.Height - panel1.Location.Y;
            MaxPointUp = panel1.Location.Y;
            MaxPointRight = panel1.Width - panel1.Location.X;
            MaxPointLeft = panel1.Location.X;
            newPlayerToolStripMenuItem.Enabled = false;
            moveToolStripMenuItem.Enabled = false;
            // groupBox1.Visible = t;
            timer1.Enabled = false;
            timer2.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            groupBox1.Text = "Player" + playeNumber.ToString();
            //groupBox2.Visible = false;
            comboBox1.Text = "Second Level";
            comboBox2.Text ="1 Minute";
            button1.Focus();
        }
//***************************************************************************
       private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (gamesMov != 2)
                        gamesMov = 8;
                    break;
                case Keys.Down:
                    if (gamesMov != 8)
                        gamesMov = 2; break;
                case Keys.Left:
                    if (gamesMov != 6)
                        gamesMov = 4; break;
                case Keys.Right:
                    if (gamesMov != 4)
                        gamesMov = 6; break;
                case Keys.Escape: Form1.ActiveForm.Close(); break;
             


            }
        }
//***************************************************************************
        int c1;
        private void timer1_Tick(object sender, EventArgs e)
        {
                //----------------random pictur----------------------------       
            b1 = (xp1 >= xrand && xp1 <= (xrand + pictureBox5.Width));
            b2 = (yp1 >= yrand && yp1 <= yrand + pictureBox5.Height);
            // b3 = ((xp1+pictureBox1.Width) >= xrand && (xp1+pictureBox1.Width) <= (xrand + pictureBox5.Width));
            //b4 = ((yp1+pictureBox1.Height) >= yrand && (yp1+pictureBox1.Height) <= yrand + pictureBox5.Height);
            if ((b1 && b2))//||(b3 && b4))
            {

                picturRandom();
            }
              //-------------------------------------------------------------
            b5 = (xp1 >= xpd && xp1 <= (xpd + pictureBox6.Width));
            b6 = (yp1 >= ypd && yp1 <= ypd + pictureBox6.Height);
            if ((b5 && b6))//||(b7 && b8))
            {
                DeadSnake();
            }
            else if (c1 == 20)
            {
                c1 = 0;
                pictureBox6.Location = new System.Drawing.Point(randnumber.Next(0, (375-pictureBox6.Width)), randnumber.Next(22, (235-pictureBox6.Height)));
                xpd = pictureBox6.Location.X;
                ypd = pictureBox6.Location.Y;
            }
            else
                c1++;
            //---------------------------------------------------------------
            ych = pictureBox1.Location.Y;
            xch = pictureBox1.Location.X;

            //up
            if (gamesMov == 8)
            {
                moveUp();
            }
            // down
            if (gamesMov == 2)
            {
                moveDown();
            }
            //right
            if (gamesMov == 6)
            {
                moveRight();
            }
            //left
            if (gamesMov == 4)
            {

                moveLeft();
            }
            //end
        }
//**************************************************************************
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moveToolStripMenuItem1.Enabled = false;
            moveToolStripMenuItem.Enabled = true;
               gamesMov = 8;
               intPisition();
               timer1.Enabled = true;            
               newGame = false;
              GameOver = false;
              timer2.Enabled = true;
              win = 0;
              i--;
              secNumber = 0;
              label1.Text = "Score:" + win.ToString();
           
        }
//***************************************************************************
        private void firstLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
        }
//**************************************************************************
        private void secondLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }
//**************************************************************************
        private void thirdLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;

        }
//**************************************************************************
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            moveToolStripMenuItem1.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
        }
//**************************************************************************
        private void moveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;
            moveToolStripMenuItem1.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
        }
//*********************Timer For Second*************************************
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((secNumber == countTime)||(GameOver==true))
            { 
                timer1.Enabled = false;
                timer2.Enabled = false;
               GameOver = false;
                
                moveToolStripMenuItem.Enabled = false;
                MessageBox.Show("Game Over.."); 
                newToolStripMenuItem.Enabled = true;
                createNewMenueItem();
                if (secNumber == countTime)
                {
                    MessageBox.Show("       ÇáÝ ãÈÑæß" + "\r\n" + "áÞÏ ÝÒÊ ãÚäÇ ÈåÐå ÇááÃÛäíå");
                    
                }
               
            }
            else
            { 
            secNumber ++;
            label3.Text = "second:" + secNumber;
            }
        }
//*****************************************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Please Enter your Name to Play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
                if (textBox2.Text == "")
                    MessageBox.Show("Please Enter your Number to Play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {   
                    switch (comboBox1.Text)
                    {
                        case "First Level": timer1.Interval = 150; break;
                        case "Second Level": timer1.Interval = 100; break;
                        case "Third Level": timer1.Interval = 50; break;
                        //default: MessageBox.Show("Please Enter Level to Play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }


                    switch (comboBox2.Text)
                    {
                        case "1 Minute": countTime = 60; break;
                        case "2 Minute": countTime = 120; break;
                        case "3 Minute": countTime = 60 * 3; break;
                        case "4 Minute": countTime = 60 * 4; break;
                        case "5 Minute": countTime = 60 * 5; break;
                       // default: MessageBox.Show("Please Enter Time to Play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }
                    groupBox1.Visible = false;
                    groupBox1.Enabled = false;
                    //--------------------------------------------------------
                    try
                    {
                        mysound("ws.wav");
                    }
                  catch
                    {
                    }
                    newPlayerToolStripMenuItem.Enabled = true;
                    moveToolStripMenuItem.Enabled = true;
                    moveToolStripMenuItem1.Enabled = false;
                    //--------------------------------------------------------
                    timer1.Enabled = true;
                    timer2.Enabled = true;

                }

        }
     
   //***************event handler by new menuItem********
        private void newt_Click(object sender, EventArgs e)
        {
                 ShowPlayerInfo(0);
        }
        private void newt1_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(1);
        }
        private void newt2_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(2);
       }
        private void newt3_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(3);
        }
        private void newt4_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(4);
        }
        private void newt5_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(5);
        }
        private void newt6_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(6);
        }
        private void newt7_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(7);
        }
        private void newt8_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(8);
        }
        private void newt9_Click(object sender, EventArgs e)
        {
            ShowPlayerInfo(9);
        }
        //*****************************end event***************
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            newToolStripMenuItem.Enabled = false;
            moveToolStripMenuItem.Enabled = false;
            newGame = true;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            win = 0;
            secNumber = 0;
            playeNumber++;
            groupBox1.Text = "Player" + playeNumber.ToString();
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            gamesMov = 8;
            intPisition();
            //  ych = pictureBox1.Location.Y;
            // xch = pictureBox1.Location.X;
        
            
        }
        //******************************************************************************
        public void createNewMenueItem()
        {
            
            if (i == 10) i = 0;               
            playerinf[i] = "Player Name: " + textBox1.Text + "\r\n" + "Player Number: " + textBox2.Text
            + "\r\n" + "Player Score: " + win+"\r\n"+"Time Game: "+secNumber+" Second";
            playerName[i] = textBox1.Text;
            //**********************menuItem***************************************
            if (newGame == true)
            {
                this.newt[i] = new ToolStripMenuItem();
                this.newt[i].Name = playerName[i];
                // this.newt.ShortcutKeyDisplayString = "Ctr+N";
                this.newt[i].Size = new System.Drawing.Size(162, 22);
                this.newt[i].Text = playerName[i];

                this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.newt[i]});

            }
            switch (i)
            {
                case 0: this.newt[0].Click += new System.EventHandler(this.newt_Click); break;
                case 1: this.newt[1].Click += new System.EventHandler(this.newt1_Click); break;
                case 2: this.newt[2].Click += new System.EventHandler(this.newt2_Click); break;
                case 3: this.newt[3].Click += new System.EventHandler(this.newt3_Click); break;
                case 4: this.newt[4].Click += new System.EventHandler(this.newt4_Click); break;
                case 5: this.newt[5].Click += new System.EventHandler(this.newt5_Click); break;
                case 6: this.newt[6].Click += new System.EventHandler(this.newt6_Click); break;
                case 7: this.newt[7].Click += new System.EventHandler(this.newt7_Click); break;
                case 8: this.newt[8].Click += new System.EventHandler(this.newt8_Click); break;
                case 9: this.newt[9].Click += new System.EventHandler(this.newt9_Click); break;

            }
            //timer1.Enabled = false;
            //timer2.Enabled = false;
            i++;
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //***************initialisition*****************
        public void intPisition()
        {
            pictureBox1.Location = new System.Drawing.Point(269, 180);
            pictureBox2.Location = new System.Drawing.Point(269, 186);
            pictureBox3.Location = new System.Drawing.Point(269, 196);
            pictureBox4.Location = new System.Drawing.Point(269, 202);
            xp1 = 269; yp1 = 180;
            xp2 = 269; yp2 = 186;
            xp3 = 269; yp3 = 196;
            xp4 = 269; yp4 = 202;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ShowPlayerInfo(int n)
        {
            MessageBox.Show(playerinf[n]);
     
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //********************************************************************************
    }
}