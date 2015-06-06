using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
namespace Media_Player
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------------------------------
        // this api used to get information about a drive ex: its name, seial number
        // if this function return zero means that one of the information could not be retrived
        // so if it is a CD ROM drive and we can't obtain its name ---> CD ROM is empty
        [DllImport("kernel32.dll", EntryPoint = "GetVolumeInformationA")]
        public static extern int GetVolumeInformation(string lpRootPathName, StringBuilder lpVolumeNameBuffer, int nVolumeNameSize, int lpVolumeSerialNumber, int lpMaximumComponentLength, int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);

        //this api get the drive type (0:unknown,1:invalid path,2:removable(floppy,removabledisk),3:fixed(hard disk),
        //4:remote(network drive),5:CDROM,6: RAM disk)
        [DllImport("kernel32.dll", EntryPoint = "GetDriveTypeA")]
        public static extern int GetDriveType(string nDrive);
        //---------------------------------------------------------------------------
        //---------------------------------Private Variable
        private string filepath = "";
        private ArrayList nowPlaylist;
      
        private MediaFile mediaFile;
        private MediaFile cdplay;
        private Rectangle videoRectangle;
        private bool videoType = false;
        private bool pause = false;
        private int count = 0;
        private int index = 0;
        private int lastColorIndex = 0;
        // private int nowPosition = 0;
        private int panelHeight = 0;
        private bool repeat = false;
        private bool cd_play = false;
        private string cd_pausePosition ="01:00:00:00";
        //--------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }
//--------------------------------form1--------------------------------
        private void Form1_Resize(object sender, EventArgs e)
        {

            track_position.Left = panel_video.Left;
            track_position.Top = panel_video.Bottom + 3;
            panel_controls.Left = panel_video.Left;
            panel_controls.Top = track_position.Bottom + 3;
            track_volume.Left = panel_controls.Left + panel_controls.Width - track_volume.Width - 10;
            addToplaylistB.Left = tabControl1.Right - addToplaylistB.Width - 10;
            panelHeight = panel_video.Height;
            if (videoType && mediaFile != null)
                change_Video_rectangle();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelHeight = panel_video.Height;
            pictureBox1.Image = Media_Player.Properties.Resources._1;
            //
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cdplay != null)
                cdplay.stopCD();
        }
//-------------------------------Track_Volume---------------------------------
        private void track_volume_Scroll(object sender, EventArgs e)
        {
            if (mediaFile != null) mediaFile.Volume = track_volume.Value * 100;
        }
//------------------------------Track_Position---------------------------------
        int t = 0;
        private void track_position_Scroll(object sender, EventArgs e)
        {
            if (!cd_play)
            {
                if (mediaFile != null)
                    mediaFile.Position = track_position.Value;
            }
            else
            {
                min = track_position.Value / 60;
                sec = track_position.Value - min * 60;
                t = Convert.ToInt32(cdplay.positionCD().Substring(0, 2));
                cdplay.playFromT_M_SCD(t, min, sec);
            }

        }
//----------------------------Track Balance---------------------------------
        private void trkBalance_Scroll(object sender, EventArgs e)
        {
            if (mediaFile != null)
            {
                mediaFile.Balance = trkBalance.Value * 100;
            }
        }
//------------------------Track Treble--------------------------------------
        private void trkTrabe_Scroll(object sender, EventArgs e)
        {
            if (mediaFile != null)
                mediaFile.Treble = trkTrabe.Value * 100;
        }

//----------------------------------------Buttons----------------------------
        private void PlayB_Click(object sender, EventArgs e)
        {
            if (cdplay==null || cd_play==false)
            {
                if (playSelectItem())
                {
                    PlayB.Enabled = false;
                    playToolStripMenuItem1.Enabled = false;
                    PauseB.Enabled = true;
                    pauseToolStripMenuItem.Enabled = true;
                }
            }
            else if (cdplay!=null && cd_play==true)
            {
                cdplay.playFromAll(cd_pausePosition);
                PlayB.Enabled = false;
                playToolStripMenuItem1.Enabled = false;
                PauseB.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                string s1 = cdplay.lengthTrackCD(cd_pausePosition.Substring(0, 2));
                string s2=s1.Remove(s1.Length - 3);
                min =int.Parse(s2.Substring(0, 2));
                sec =int.Parse(s2.Substring(3, 2));
                toolStripStatusLabel1.Text = "Duration: " + convert_millesecond((min * 60 + sec) * 1000);
                track_position.Maximum = Convert.ToInt32(s1.Substring(0, 2)) * 60 + Convert.ToInt32(s1.Substring(3, 2)); //Convert.ToInt32(s1) * 60+ Convert.ToInt32(s2);
                timer1.Enabled = true;
            }
        }

        private void PauseB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null || cdplay != null)
            {
                PauseB.Enabled = false;
                pauseToolStripMenuItem.Enabled = false;
                PlayB.Enabled = true;
                playToolStripMenuItem1.Enabled = true;
                pause = true;
                timer1.Enabled = false;
               
                if (cdplay != null)
                {
                   cd_pausePosition=cdplay.pauseCD();
                }
                else
                { 
                    mediaFile.Paused = true;
                }
            }
            
                
        }

        private void StopB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null)
            {
                timer1.Enabled = false;
                PlayB.Enabled = true;
                playToolStripMenuItem1.Enabled = true;
                mediaFile.Stop();
                track_position.Value = 0;
            }
            else if (cdplay != null)
            {
                timer1.Enabled = false;
                PlayB.Enabled = true;
                playToolStripMenuItem1.Enabled = true;
                track_position.Value = 0;
                cd_pausePosition = cdplay.pauseCD();
                cdplay.stopCD();
                cd_pausePosition = cd_pausePosition.Substring(0, 2) + ":00:00:00";
            }
        }
        private void NextB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null || cdplay != null)
            {

                lastColorIndex = index;
                count = listView1.Items.Count;
                if (index < count - 1)
                    index++;
                else index = 0;
                //for CD
                cd_pausePosition = Convert.ToString(index+1) + ":00:00:00";
                PlayB_Click(sender, e);
            }

        }

        private void PreviousB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null || cdplay != null)
            {
                lastColorIndex = index;
                if (index > 0)
                {
                    index--;
                    listView1.Items[index].Selected = true;
                    cd_pausePosition = Convert.ToString(index+1) + ":00:00:00";
                    PlayB_Click(sender, e);

                }
            }
        }
        private void repeatB_Click(object sender, EventArgs e)
        {
            if (repeatB.Text == "R")
            {
                repeatB.Text = "NoR";
                repeat = true;
            }
            else
            {
                repeatB.Text = "R";
                repeat = false;
            }
        }


        private void incSpeedB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null)
            {

              //  this.Text = mediaFile.Speed.ToString();
                mediaFile.Speed +=100;

                toolStripStatusLabel3.Text = "Speed: " + mediaFile.Speed;
            }
        }

        private void decSpeedB_Click(object sender, EventArgs e)
        {
            if (mediaFile != null)
            {
                //this.Text = mediaFile.Speed.ToString();
                mediaFile.Speed -= 100;
                toolStripStatusLabel3.Text = "Speed: " + mediaFile.Speed;
            }
        }
        private void loadCDB_Click(object sender, EventArgs e)
        {

            int no = cdplay.trackNoCD();
            if (no > 0)
            {
                listView1.Items.Clear();
                index = 0; lastColorIndex = 0;
                cd_play = true;
                addToplaylistB.Enabled = false;
                closeCDB.Enabled = true;
                loadCDB.Enabled = false;
                loadCDToolStripMenuItem.Enabled = false;
                openToolStripMenuItem.Enabled = false;
                openPlayListToolStripMenuItem.Enabled = false;
                if (mediaFile != null)
                    mediaFile.Dispose();
                for (int i = 0; i < no; i++)
                {

                    addToListView("Track" + i, "Sound");

                }
                PlayB_Click(sender, e);
            }
        }

        private void EjectB_Click(object sender, EventArgs e)
        {
            if (EjectB.Text == "Open CD door")
            {
                EjectB.Text = "Close CD door";
                cdplay.openCDdoor();
                tabControl1_SelectedIndexChanged(sender, e);
            }
            else
                if (EjectB.Text == "Close CD door")
                {
                    EjectB.Text = "Open CD door";
                    cdplay.closeCDdoor();
                    this.Cursor = Cursors.WaitCursor;
                    tabControl1_SelectedIndexChanged(sender, e);
                    this.Cursor = Cursors.Default;
                }
        }

        private void addToplaylistB_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFile();
        }
        private void closeCDB_Click(object sender, EventArgs e)
        {
            if (cdplay != null)
            {
                cdplay.stopCD();
                timer1.Enabled = false;
                cdplay = null;
                cd_play = false;
                listView1.Items.Clear();
                closeCDB.Enabled = false;
                openToolStripMenuItem.Enabled = true;
                openPlayListToolStripMenuItem.Enabled = true;
                addToplaylistB.Enabled = true;
                loadCDB.Enabled = true;
                loadCDToolStripMenuItem.Enabled = true;
            }

        }
        private void nextPicture_Click(object sender, EventArgs e)
        {
            if (noPic < 3)
            {
                noPic = (noPic + 1);
                switch (noPic)
                {
                    case 1:
                        pictureBox1.Image = Media_Player.Properties.Resources._1; break;
                    case 2:
                        pictureBox1.Image = Media_Player.Properties.Resources._2; break;
                    case 3:
                        pictureBox1.Image = Media_Player.Properties.Resources._3; break;
                }
            }
        }

        private void previousPicture_Click(object sender, EventArgs e)
        {
            if (noPic > 1)
            {
                noPic = (noPic - 1) % 3;
                switch (noPic)
                {
                    case 1:
                        pictureBox1.Image = Media_Player.Properties.Resources._1; break;
                    case 2:
                        pictureBox1.Image = Media_Player.Properties.Resources._2; break;
                    case 3:
                        pictureBox1.Image = Media_Player.Properties.Resources._3; break;
                }
            }
        }
//----------------------------------Timer----------------------------------------
        int min = 0, sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!cd_play)
                {
                    if (mediaFile.Status == StatusInfo.Stopped)
                    {
                        if (index < (listView1.Items.Count - 1) || repeat == true)
                        {
                            StopB_Click(sender, e);
                            NextB_Click(sender, e);
                        }
                        else
                        {
                            timer1.Enabled = false;
                        }
                    }
                    else
                    {
                        track_position.Value = mediaFile.Position;
                        toolStripStatusLabel2.Text = " Current Time: " + convert_millesecond(mediaFile.Position);
                    }
                }
                else if (cd_play)
                {

                    min = Convert.ToInt32(cdplay.positionCD().Substring(3, 2));
                    sec = Convert.ToInt32(cdplay.positionCD().Substring(6, 2));
                    track_position.Value = min * 60 + sec;
                    if (track_position.Value == 0)
                    {
                        cd_pausePosition = cdplay.CurrentPositionCD();
                        string s1 = cdplay.lengthTrackCD(cd_pausePosition.Substring(0, 2));
                        string s2 = s1.Remove(s1.Length - 3);
                        int ms = (int.Parse(s2.Substring(0, 2)) * 60 + int.Parse(s2.Substring(3, 2))) * 1000;
                        toolStripStatusLabel1.Text = "Duration: " + convert_millesecond(ms);
                        track_position.Maximum = Convert.ToInt32(s1.Substring(0, 2)) * 60 + Convert.ToInt32(s1.Substring(3, 2));
                    }

                    toolStripStatusLabel2.Text = " Current Time: " + convert_millesecond((min * 60 + sec) * 1000);
                }
             }
           catch
            {
            }
        }
 //--------------------------------CheckBox-----------------------------------------
        private void ChkMuteLeft_CheckedChanged(object sender, EventArgs e)
        {
            ChkMute_CheckedChanged();
        }

        private void ChkMuteRight_CheckedChanged(object sender, EventArgs e)
        {
            ChkMute_CheckedChanged();
        }

 //--------------------------------ToolStripMenue-----------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFile())
            {
                
                lastColorIndex = index;
                index = listView1.Items.Count - 1;
                PlayB_Click(sender, e);
            }

        }
        //--------------------------------------------
        private void openPlayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
           try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog1.Filter = "wpl files (*.wpl)|*.wpl|list files (*.mpl)|*.mpl";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //  ok = true;
                    filepath = openFileDialog1.FileName.ToString();
                    open_PlayList(filepath);
                }
            }
            catch
            {
                MessageBox.Show("can not play Playlist");
            }
        }

        private void savePlayListASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                //-------------------------------------------------------
                string Playlist_Path = "";
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

                SaveFileDialog1.Title = "Save Windows Playlist As...";
                SaveFileDialog1.Filter = "wpl files (*.wpl)|*.wpl|list files (*.mpl)|*.mpl";
                SaveFileDialog1.FilterIndex = 1;
                SaveFileDialog1.RestoreDirectory = true;
                SaveFileDialog1.DefaultExt = "*.mpl";
                SaveFileDialog1.CreatePrompt = false; // Don't prompt the user for permission to Create a file 
                // if the user specifies a file that does not exist
                SaveFileDialog1.OverwritePrompt = true;
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Playlist_Path = SaveFileDialog1.FileName;
                    string[] playList_File = new string[listView1.Items.Count];
                    ListViewItem item;
                    int index = 0;
                    while (index < listView1.Items.Count)
                    {
                        item = listView1.Items[index];
                        playList_File[index] = item.SubItems[0].Text;
                        index++;
                    }
                    readPlaylist writeList = new readPlaylist();
                    writeList.CreatePlayList(Playlist_Path, playList_File);
                }
            }
        }
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseB_Click(sender, e);
            ((VideoFile)(mediaFile)).FullScreen();
        }


        private void playListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void playToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PlayB_Click(sender, e);
        }
      
             //--------------------------------------
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseB_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopB_Click(sender, e);
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!statusBarToolStripMenuItem.Checked)
            {

                statusStrip1.Visible = false;
                panel_video.Height = panel_video.Height + statusStrip1.Height;
                Form1_Resize(sender, e);
            }
            else
            {
                statusStrip1.Visible = true;
                panel_video.Height = panel_video.Height - statusStrip1.Height;
                Form1_Resize(sender, e);
            }
        }
        private void increseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (track_volume.Value < track_volume.Maximum)
            {
                track_volume.Value += 1;
                track_volume_Scroll(sender, e);
            }
        }
        private void decreseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (track_volume.Value > track_volume.Minimum)
            {
                track_volume.Value -= 1;
                track_volume_Scroll(sender, e);
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        int noPic = 1;

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void increseSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incSpeedB_Click(sender, e);
        }

        private void decreseSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decSpeedB_Click(sender, e);
        }
        private void loadCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadCDB_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
//----------------------------------------ListView-------------------------------
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = listView1.SelectedIndices[0];
            playListViewItem(ind);
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!cd_play)
                    if (e.KeyCode == Keys.Delete && listView1.Items.Count > 0 && listView1.SelectedIndices[0] != index)
                    {
                        if (listView1.SelectedIndices[0] < index)
                        {
                            lastColorIndex--;
                            index--;
                        }
                        listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    }
            }
            catch
            {
            }
        }
        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
                // allow them to continue
                // (without this, the cursor stays a "NO" symbol
                e.Effect = DragDropEffects.All;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            // foreach loop in place of "files", but this is easier to understand.)
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // items;
            string type = "";
            // loop through the string array, adding each filename to the ListBox
            foreach (string file in files)
            {
                type = vedio_soundCheck(file);
                if (type != "Unknown")
                {
                    addToListView(file, type);
                }
                else
                {
                    if (Path.GetExtension(file) == ".wpl" || Path.GetExtension(file) == ".mpl")
                    {
                        open_PlayList(file);
                    }
                }
            }
        }
//----------------------------TabControl----------------------------------------
        bool chk;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
            if (tabControl1.SelectedIndex == 2)
            {
                if (cdplay == null)
                {
                    cdplay = new SoundFile("cdaudio");
                    cdplay.Alias = "cdaudio";
                }
                cdlabel.Text = loadCD(ref chk);
                if (chk)
                {

                    loadCDB.Enabled = true;
                    loadCDToolStripMenuItem.Enabled = true;

                }
                else
                {
                    loadCDB.Enabled = false;
                    loadCDToolStripMenuItem.Enabled = false;
                }

            }
            else
            {
                if (!cd_play) cdplay = null;
            }
               
        }
 //*/////////////////////////////////////Functions///////////////////////////////////
        private void play()
        {

            if (!pause)
            {
                if (mediaFile != null) mediaFile.Dispose();
                if (videoType)
                {

                    mediaFile = new VideoFile(filepath, panel_video);
                   
                    change_Video_rectangle();
                    fullScreenToolStripMenuItem.Enabled = true;
                }
                else
                    if (!videoType)
                    {
                        mediaFile = new SoundFile(filepath);
                        fullScreenToolStripMenuItem.Enabled = false;
                    }
                //---------------------------------------
                track_position.Maximum = mediaFile.Length;
                pause = false;
                mediaFile.Play();
                toolStripStatusLabel1.Text = "Duration:" + convert_millesecond(mediaFile.Length);
                toolStripStatusLabel3.Text = "Speed: " + mediaFile.Speed;
            }
            else
            {
                PauseB.Enabled = true;
                pauseToolStripMenuItem.Enabled = true;
                pause = false;
                mediaFile.Play(track_position.Value);
            }
            timer1.Enabled = true;
            this.Text = Path.GetFileNameWithoutExtension(filepath);
            mediaFile.Volume = track_volume.Value * 100;
        }
        //---------------------------------------------------------------------------
        private void change_Video_rectangle()
        {
            videoRectangle.X = panel_video.Left;
            videoRectangle.Y = panel_video.Top;
            videoRectangle.Width = panel_video.Width;
            videoRectangle.Height = panel_video.Height;
            ((VideoFile)mediaFile).OutputRect = new Rectangle(panel_video.Left, panel_video.Top, panel_video.Width, panel_video.Height);
        }
        //----------------------------------------------------------------------------
        int h, m, s;
        private string convert_millesecond(int ms)
        {
            ms /= 1000;
            h = ms / 3600;
            m = (ms - (h * 3600)) / 60;
            s = ms - (h * 3600) - (m * 60);
            return h + ":" + m + ":" + s;
        }
        //--------------------------------------------------------------------
        private bool openFile()
        {
            string []filepaths;
            bool ok = false;
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Video File|*.avi;*.AVI;*.mpg;*.MPG;*.wmv;*.WMV;*.asf;*.ASF;*.3gp;*.3GP|Sound File|*.wav;*.WAV;*.mp3;*.MP3;*.mid;*.MID|All File|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ok = true;
                    filepaths = openFileDialog1.FileNames;
                int count = 0;
                while (count < filepaths.Length)
                {
                    filepath = filepaths[count];
                    string ret = vedio_soundCheck(filepath);
                    if (ret == "Video")
                    {
                        addToListView(filepath, "Video");
                        videoType = true;
                    }
                    else
                        if (ret == "Sound")
                        {
                            addToListView(filepath, "Sound");
                            videoType = false;
                        }
                        else
                        {
                            ok = false;
                        }
                    count++;
                }

            }
            return ok;
        }
        //----------------------------------------------------------------------
        private void addToListView(string filename, string type)
        {
            //FileInfo file = new FileInfo(filename);
            string[] item ={ filename, type };
            ListViewItem i = new ListViewItem(item);
            listView1.Items.Add(i);
        }
        private void playListViewItem(int ind)
        {
            lastColorIndex = index;
            index = ind;
            if (cd_play)
            {
                cdplay.playFromTrackCD(index + 1);

                string s1 = cdplay.lengthTrackCD(index.ToString());
                toolStripStatusLabel1.Text = "Duration: " + s1.Remove(s1.Length - 3);
                track_position.Maximum = Convert.ToInt32(s1.Substring(0, 2)) * 60
                 + Convert.ToInt32(s1.Substring(3, 2));
                timer1.Enabled = true;
            }
            else if (playSelectItem())
            {
                PlayB.Enabled = false;
                playToolStripMenuItem1.Enabled = false;
                PauseB.Enabled = true;
            }
        }
        //----------------------------------------------------------------------
        private bool playSelectItem()
        {
            bool ret = false;

            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.Items[index];

                if (item.SubItems[1].Text == "Video")
                {
                    videoType = true;

                }
                else
                {
                    videoType = false;
                }
                filepath = item.SubItems[0].Text;
                listView1.Items[lastColorIndex].ForeColor = Color.Black;
                listView1.Items[index].ForeColor = Color.Blue;
                play();
                tabControl1.SelectedIndex = 0;
                ChkMute_CheckedChanged();
                ret = true;
            }
            return ret;
        }
        //-------------------------------------
        public string vedio_soundCheck(string path)
        {
            string ext = Path.GetExtension(path);
            string ret = "Unknown";
            if (ext == ".avi" || ext == ".mpg" || ext == ".wmv"||ext==".asf"||ext==".3gp"||
               ext == ".AVI" || ext == ".MPG" || ext == ".WMV"||ext==".ASF"||ext==".3GP")
                ret = "Video";
            else
                if (ext == ".wav" || ext == ".mp3" || ext == ".mid"||
                    ext == ".WAV" || ext == ".MP3" || ext == ".MID")
                    ret = "Sound";
            return ret;
        }
        private void ChkMute_CheckedChanged()
        {
            if (mediaFile != null)
            {
                if (ChkMuteLeft.Checked && ChkMuteRight.Checked)

                    mediaFile.Mute = channels.Both;

                else
                    if (!ChkMuteLeft.Checked && !ChkMuteRight.Checked)
                        mediaFile.Mute = channels.None;
                    else
                        if (ChkMuteLeft.Checked && !ChkMuteRight.Checked)
                            mediaFile.Mute = channels.Left;
                        else
                            if (!ChkMuteLeft.Checked && ChkMuteRight.Checked)
                                mediaFile.Mute = channels.Right;

            }
        }

        //-----------------------For CD----------------------
        public string loadCD(ref bool chk)
        {
            string s = "";
            StringBuilder volumeName = new StringBuilder(256);
            int srNum = new int();
            int comLen = new int();
            string sysName = "";
            int sysFlags = new int();
            int result;
            // Directory.GetLogicalDrives return an array of strings that contain logical drives (c:\,d:\....)
            string[] logDrives = System.IO.Directory.GetLogicalDrives();

            // for every drive check whether it is a CD ROM or not
            for (int i = 0; i < logDrives.Length; i++)
            {
                if (GetDriveType(logDrives[i]) == 5)
                {
                    string drive = logDrives[i].ToString();
                    s += "Your CD ROM is on drive : " + drive.Remove(drive.Length - 2) + "\n";
                    result = GetVolumeInformation(logDrives[i].ToString(), volumeName, 256, srNum, comLen, sysFlags, sysName, 256);
                    if (result == 0)
                    { s += "There is NO CD in your CD ROM"; chk = false; }
                    else
                    {
                        s += "There is a CD inside your CD ROM\nCD Name is " + volumeName;
                        chk = true;
                    }
                }
            }

            return s;
        }
      //-------------------------------------------------------------
        private void open_PlayList(string path)
        {
            readPlaylist readList = new readPlaylist();
            readList.playListPath = path;
            nowPlaylist = readList.PlayList;
            string ret = "";
            for (int x = 0; x < nowPlaylist.Count; x++)
            {
                ret = vedio_soundCheck(nowPlaylist[x].ToString());
                if (ret == "Video")
                {
                    addToListView(nowPlaylist[x].ToString(), "Video");
                    videoType = true;
                }
                else
                    if (ret == "Sound")
                    {
                        addToListView(nowPlaylist[x].ToString(), "Sound");
                        videoType = false;
                    }

            }
            if (nowPlaylist.Count > 0 && mediaFile == null)
            {
                // listView1.Items[0].Selected = true;
                playListViewItem(0);

            }
        }
        }
}