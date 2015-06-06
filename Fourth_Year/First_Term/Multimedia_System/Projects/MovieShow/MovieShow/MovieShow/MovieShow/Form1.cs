using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DirectShowLib;
using System.IO;

namespace MovieShow
{
    internal enum PlayState
    {
        Stopped,
        Paused,
        Running,
        Init
    };

    internal enum MediaType
    {
        Audio,
        Video
    }

    public partial class Form1 : Form
    {
  
        private Mci mci= new Mci();
        private bool mute = false;
        private bool nextsong = false;
        private string[] listtoplay;
        private bool playlst = false;
        private Form4 ListForm;
        private Form5 SubtitleForm;
        private bool ratemodified = false;
        private const int WMGraphNotify = 0x0400 + 13;
        private const int VolumeSilence = -4000;
        private int i = -1;
        private IGraphBuilder graphBuilder = null;
        private IMediaControl mediaControl = null;
        private IMediaEventEx mediaEventEx = null;
        private IVideoWindow videoWindow = null;
        private IBasicAudio basicAudio = null;
        private IBasicVideo basicVideo = null;
        private IMediaSeeking mediaSeeking = null;
        private IMediaPosition mediaPosition = null;
        private IVideoFrameStep frameStep = null;

        private string filename = string.Empty;
        private bool isAudioOnly = false;
        private bool isFullScreen = false;
        private int currentVolume = -2500;
        private PlayState currentState = PlayState.Stopped;
        private double currentPlaybackRate = 1.0;

        private IntPtr hDrain = IntPtr.Zero;

#if DEBUG
        private DsROTEntry rot = null;
#endif
        public Form1()
        {
            InitializeComponent();
        }

/// ///////////////////////////////////////////////////////////////////////

        private void OpenClip()
        {
            if (playlst)
                playlst = false;
            try
            {
                // If no filename specified by command line, show file open dialog
                if (this.filename == string.Empty)
                {
                    UpdateStatusBar();
                    UpdateToolStrip();

                    this.filename = FileOpenDialog.FileName;
                    if (this.filename == string.Empty)
                        return;
                }

                // Reset status variables
                this.currentState = PlayState.Stopped;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;

            }
            catch
            {
                CloseClip();
            }
        }
        private void Play()
        {
            if (playlst)
            {
                i++;
                if (i == listtoplay.Length-1)
                    i = 0;
                this.filename = listtoplay[i];
                nextsong = true;
            }
            // Start playing the media file
            PlayMovieInWindow(this.filename);
        }
        private void PlayMovieInWindow(string filename)
        {
            int hr = 0;

            if (filename == string.Empty)
                return;

            this.graphBuilder = (IGraphBuilder)new FilterGraph();

            // Have the graph builder construct its the appropriate graph automatically
            hr = this.graphBuilder.RenderFile(filename, null);
            DsError.ThrowExceptionForHR(hr);

            // QueryInterface for DirectShow interfaces
            this.mediaControl = (IMediaControl)this.graphBuilder;
            this.mediaEventEx = (IMediaEventEx)this.graphBuilder;
            this.mediaSeeking = (IMediaSeeking)this.graphBuilder;
            this.mediaPosition = (IMediaPosition)this.graphBuilder;

            // Query for video interfaces, which may not be relevant for audio files
            this.videoWindow = this.graphBuilder as IVideoWindow;
            this.basicVideo = this.graphBuilder as IBasicVideo;

            // Query for audio interfaces, which may not be relevant for video-only files
            this.basicAudio = this.graphBuilder as IBasicAudio;

            // Is this an audio-only file (no video component)?
            CheckVisibility();

            // Have the graph signal event via window callbacks for performance
            hr = this.mediaEventEx.SetNotifyWindow(this.Handle, WMGraphNotify, IntPtr.Zero);
            DsError.ThrowExceptionForHR(hr);

            if (!this.isAudioOnly)
            {
                this.ClientSize = new Size(379,331);
                // Setup the video window
                hr = this.videoWindow.put_Owner(this.Handle);
                DsError.ThrowExceptionForHR(hr);

                hr = this.videoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings | WindowStyle.ClipChildren);
                DsError.ThrowExceptionForHR(hr);

                hr = InitVideoWindow(1, 1);
                DsError.ThrowExceptionForHR(hr);

                GetFrameStepInterface();
            }
            else
            {
                // Initialize the default player size and enable playback menu items
                hr = InitPlayerWindow();
                DsError.ThrowExceptionForHR(hr);

               // EnablePlaybackMenu(true, MediaType.Audio);
            }

            // Complete window initialization
            // CheckSizeMenu(menuFileSizeNormal);
            this.isFullScreen = false;
            this.currentPlaybackRate = 1.0;
            UpdateStatusBar();
            UpdateToolStrip();

#if DEBUG
            rot = new DsROTEntry(this.graphBuilder);
#endif

            this.Focus();

            // Run the graph to play the media file
            hr = this.mediaControl.Run();
            DsError.ThrowExceptionForHR(hr);

            this.currentState = PlayState.Running;
            Increment.Start();
        }

        private void CloseClip()
        {
            int hr = 0;

            // Stop media playback
            if (this.mediaControl != null)
                hr = this.mediaControl.Stop();

            // Clear global flags
            this.currentState = PlayState.Stopped;
            this.isAudioOnly = true;
            this.isFullScreen = false;

            // Free DirectShow interfaces
            CloseInterfaces();

            // Clear file name to allow selection of new file with open dialog
            this.filename = string.Empty;

            // No current media state
            this.currentState = PlayState.Init;
            UpdateStatusBar();
            UpdateToolStrip();
            InitPlayerWindow();
            
        }

        private int InitVideoWindow(int nMultiplier, int nDivider)
        {
            int hr = 0;
            int lHeight, lWidth;

            if (this.basicVideo == null)
                return 0;

            // Read the default video size
            hr = this.basicVideo.GetVideoSize(out lWidth, out lHeight);
            if (hr == DsResults.E_NoInterface)
                return 0;

           // EnablePlaybackMenu(true, MediaType.Video);

            // Account for requests of normal, half, or double size
            lWidth = lWidth * nMultiplier / nDivider;
            lHeight = lHeight * nMultiplier / nDivider;
            if (!this.isAudioOnly)
            {
                panel1.Size = new Size(lWidth, lHeight);
                PositionTracker.Width = lWidth;
                PositionTracker.Location = new Point(0, lHeight + 52);
                this.ClientSize = new Size(lWidth+1, lHeight+139);
                Application.DoEvents();

                hr = this.videoWindow.SetWindowPosition(panel1.Left, panel1.Top, panel1.Width, panel1.Height);
            }
            return hr;
        }

        private void MoveVideoWindow()
        {
            int hr = 0;

            // Track the movement of the container window and resize as needed
            if (this.videoWindow != null)
            {
                hr = this.videoWindow.SetWindowPosition(panel1.Left,panel1.Top,panel1.Width,panel1.Height);
                DsError.ThrowExceptionForHR(hr);
            }
        }

        private void CheckVisibility()
        {
            int hr = 0;
            OABool lVisible;

            if ((this.videoWindow == null) || (this.basicVideo == null))
            {
                // Audio-only files have no video interfaces.  This might also
                // be a file whose video component uses an unknown video codec.
                this.isAudioOnly = true;
                return;
            }
            else
            {
                // Clear the global flag
                this.isAudioOnly = false;
            }

            hr = this.videoWindow.get_Visible(out lVisible);
            if (hr < 0)
            {
                // If this is an audio-only clip, get_Visible() won't work.
                //
                // Also, if this video is encoded with an unsupported codec,
                // we won't see any video, although the audio will work if it is
                // of a supported format.
                if (hr == unchecked((int)0x80004002)) //E_NOINTERFACE
                {
                    this.isAudioOnly = true;
                }
                else
                    DsError.ThrowExceptionForHR(hr);
            }
        }

        //
        // Some video renderers support stepping media frame by frame with the
        // IVideoFrameStep interface.  See the interface documentation for more
        // details on frame stepping.
        //
        private bool GetFrameStepInterface()
        {
            int hr = 0;

            IVideoFrameStep frameStepTest = null;

            // Get the frame step interface, if supported
            frameStepTest = (IVideoFrameStep)this.graphBuilder;

            // Check if this decoder can step
            hr = frameStepTest.CanStep(0, null);
            if (hr == 0)
            {
                this.frameStep = frameStepTest;
                return true;
            }
            else
            {
                // BUG 1560263 found by husakm (thanks)...
                // Marshal.ReleaseComObject(frameStepTest);
                this.frameStep = null;
                return false;
            }
        }

        private void CloseInterfaces()
        {
            int hr = 0;

            try
            {
                lock (this)
                {
                    // Relinquish ownership (IMPORTANT!) after hiding video window
                    if (!this.isAudioOnly)
                    {
                        hr = this.videoWindow.put_Visible(OABool.False);
                        DsError.ThrowExceptionForHR(hr);
                        hr = this.videoWindow.put_Owner(IntPtr.Zero);
                        DsError.ThrowExceptionForHR(hr);
                    }

                    if (this.mediaEventEx != null)
                    {
                        hr = this.mediaEventEx.SetNotifyWindow(IntPtr.Zero, 0, IntPtr.Zero);
                        DsError.ThrowExceptionForHR(hr);
                    }

#if DEBUG
                    if (rot != null)
                    {
                        rot.Dispose();
                        rot = null;
                    }
#endif
                    // Release and zero DirectShow interfaces
                    if (this.mediaEventEx != null)
                        this.mediaEventEx = null;
                    if (this.mediaSeeking != null)
                        this.mediaSeeking = null;
                    if (this.mediaPosition != null)
                        this.mediaPosition = null;
                    if (this.mediaControl != null)
                        this.mediaControl = null;
                    if (this.basicAudio != null)
                        this.basicAudio = null;
                    if (this.basicVideo != null)
                        this.basicVideo = null;
                    if (this.videoWindow != null)
                        this.videoWindow = null;
                    if (this.frameStep != null)
                        this.frameStep = null;
                    if (this.graphBuilder != null)
                        Marshal.ReleaseComObject(this.graphBuilder); this.graphBuilder = null;

                    GC.Collect();
                }
            }
            catch
            {
            }
        }

        //*
        //* Media Related methods
        //

        private void PauseClip()
        {
            if (this.mediaControl == null)
                return;

            // Toggle pause behavior
            if (this.currentState == PlayState.Paused)
            {
                if (this.mediaControl.Run() >= 0)
                    this.currentState = PlayState.Running;
            }
            else
            {
                if (this.mediaControl.Pause() >= 0)
                    this.currentState = PlayState.Paused;
            }

            UpdateStatusBar();
            UpdateToolStrip();
        }

        private void StopClip()
        {
            int hr = 0;
            DsLong pos = new DsLong(0);

            if ((this.mediaControl == null) || (this.mediaSeeking == null))
                return;

            // Stop and reset postion to beginning
            if ((this.currentState == PlayState.Paused) || (this.currentState == PlayState.Running))
            {
                hr = this.mediaControl.Stop();
                this.currentState = PlayState.Stopped;

                // Seek to the beginning
                hr = this.mediaSeeking.SetPositions(pos, AMSeekingSeekingFlags.AbsolutePositioning, null, AMSeekingSeekingFlags.NoPositioning);

                // Display the first frame to indicate the reset condition
                hr = this.mediaControl.Pause();
            }
            UpdateStatusBar();
            UpdateToolStrip();
        }

        private int ToggleMute()
        {
            int hr = 0;

            if ((this.graphBuilder == null) || (this.basicAudio == null))
                return 0;

            // Read current volume
            hr = this.basicAudio.get_Volume(out this.currentVolume);
            if (hr == -1) //E_NOTIMPL
            {
                // Fail quietly if this is a video-only media file
                return 0;
            }
            else if (hr < 0)
            {
                return hr;
            }
            
            // Switch volume levels
            if (this.currentVolume !=VolumeSilence)
            {
                mute = true;
                toolStripProgressBar1.Enabled = false;
                this.currentVolume = VolumeSilence;
            }
            else
            {
                mute = false;
                toolStripProgressBar1.Enabled = true;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
            }
            // Set new volume
            hr = this.basicAudio.put_Volume(this.currentVolume);
            UpdateStatusBar();
            UpdateToolStrip();
            return hr;
        }

        private int ToggleFullScreen()
        {
            int hr = 0;
            OABool lMode;

            // Don't bother with full-screen for audio-only files
            if ((this.isAudioOnly) || (this.videoWindow == null))
                return 0;

            // Read current state
            hr = this.videoWindow.get_FullScreenMode(out lMode);
            DsError.ThrowExceptionForHR(hr);

            if (lMode == OABool.False)
            {
                // Save current message drain
                hr = this.videoWindow.get_MessageDrain(out hDrain);
                DsError.ThrowExceptionForHR(hr);

                // Set message drain to application main window
                hr = this.videoWindow.put_MessageDrain(this.Handle);
                DsError.ThrowExceptionForHR(hr);

                // Switch to full-screen mode
                lMode = OABool.True;
                hr = this.videoWindow.put_FullScreenMode(lMode);
                DsError.ThrowExceptionForHR(hr);
                this.isFullScreen = true;
            }
            else
            {
                // Switch back to windowed mode
                lMode = OABool.False;
                hr = this.videoWindow.put_FullScreenMode(lMode);
                DsError.ThrowExceptionForHR(hr);

                // Undo change of message drain
                hr = this.videoWindow.put_MessageDrain(hDrain);
                DsError.ThrowExceptionForHR(hr);

                // Reset video window
                hr = this.videoWindow.SetWindowForeground(OABool.True);
                DsError.ThrowExceptionForHR(hr);

                // Reclaim keyboard focus for player application
                //this.Focus();
                this.isFullScreen = false;
            }

            return hr;
        }

        private int StepOneFrame()
        {
            int hr = 0;

            // If the Frame Stepping interface exists, use it to step one frame
            if (this.frameStep != null)
            {
                // The graph must be paused for frame stepping to work
                if (this.currentState != PlayState.Paused)
                    PauseClip();

                // Step the requested number of frames, if supported
                hr = this.frameStep.Step(1, null);
            }

            return hr;
        }

        private int StepFrames(int nFramesToStep)
        {
            int hr = 0;

            // If the Frame Stepping interface exists, use it to step frames
            if (this.frameStep != null)
            {
                // The renderer may not support frame stepping for more than one
                // frame at a time, so check for support.  S_OK indicates that the
                // renderer can step nFramesToStep successfully.
                hr = this.frameStep.CanStep(nFramesToStep, null);
                if (hr == 0)
                {
                    // The graph must be paused for frame stepping to work
                    if (this.currentState != PlayState.Paused)
                        PauseClip();

                    // Step the requested number of frames, if supported
                    hr = this.frameStep.Step(nFramesToStep, null);
                }
            }

            return hr;
        }

        private int ModifyRate(double dRateAdjust)
        {
            int hr = 0;
            double dRate;
            ratemodified = true;
            // If the IMediaPosition interface exists, use it to set rate
            if ((this.mediaPosition != null) && (dRateAdjust != 0.0))
            {
                hr = this.mediaPosition.get_Rate(out dRate);
                if (hr == 0)
                {
                    // Add current rate to adjustment value
                    double dNewRate = dRate + dRateAdjust;
                    hr = this.mediaPosition.put_Rate(dNewRate);

                    // Save global rate
                    if (hr == 0)
                    {
                        this.currentPlaybackRate = dNewRate;
                        UpdateStatusBar();
                        UpdateToolStrip();
                    }
                }
            }

            return hr;
        }

        private int SetRate(double rate)
        {
            int hr = 0;

            // If the IMediaPosition interface exists, use it to set rate
            if (this.mediaPosition != null)
            {
                hr = this.mediaPosition.put_Rate(rate);
                if (hr >= 0)
                {
                    this.currentPlaybackRate = rate;
                    UpdateStatusBar();
                    UpdateToolStrip();
                }
            }

            return hr;
        }

        private void HandleGraphEvent()
        {
            int hr = 0;
            EventCode evCode;
            int evParam1, evParam2;

            // Make sure that we don't access the media event interface
            // after it has already been released.
            if (this.mediaEventEx == null)
                return;

            // Process all queued events
            while (this.mediaEventEx.GetEvent(out evCode, out evParam1, out evParam2, 0) == 0)
            {
                // Free memory associated with callback, since we're not using it
                hr = this.mediaEventEx.FreeEventParams(evCode, evParam1, evParam2);

                // If this is the end of the clip, reset to beginning
                if (evCode == EventCode.Complete)
                {
                    DsLong pos = new DsLong(0);
                    // Reset to first frame of movie
                    hr = this.mediaSeeking.SetPositions(pos, AMSeekingSeekingFlags.AbsolutePositioning,
                      null, AMSeekingSeekingFlags.NoPositioning);
                    if (hr < 0)
                    {
                        // Some custom filters (like the Windows CE MIDI filter)
                        // may not implement seeking interfaces (IMediaSeeking)
                        // to allow seeking to the start.  In that case, just stop
                        // and restart for the same effect.  This should not be
                        // necessary in most cases.
                        hr = this.mediaControl.Stop();
                        hr = this.mediaControl.Run();
                    }
                }
            }
        }

        //
        // WinForm Related methods
        //

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WMGraphNotify:
                    {
                        HandleGraphEvent();
                        break;
                    }
            }

            // Pass this message to the video window for notification of system changes
            if (this.videoWindow != null)
                this.videoWindow.NotifyOwnerMessage(m.HWnd, m.Msg, (int)m.WParam, (int)m.LParam);

            base.WndProc(ref m);
        }


        private int InitPlayerWindow()
        {
            // Reset to a default size for audio and after closing a clip
            this.ClientSize = new Size(379,113);

            // Check the 'full size' menu item
            //CheckSizeMenu(menuFileSizeNormal);
           

            return 0;
        }

        private void UpdateStatusBar()
        {
            try
            {
                if (ListForm.indexchange)
                {
                    ListForm.indexchange = false;
                    i = ListForm.i - 1;
                    StopClip();
                    Play();
                }
            }
            catch
            {
            }
            if (mediaPosition != null)
            {
                double pLength;
                mediaPosition.get_Duration(out pLength);
                int s = (int)pLength;
                PositionTracker.Maximum = s;
                if (nextsong|ratemodified)
                {
                    NextPlay.Interval = PositionTracker.Maximum * 1000;
                    ratemodified = false;
                    nextsong = false;
                    NextPlay.Start();
                }
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);

                DurationStatus.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
                pLength = 0;
                mediaPosition.get_CurrentPosition(out pLength);
                s = (int)pLength;
                PositionTracker.Value = s;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                CurrentStatus2.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                CurrentStatus2.Text = "00:00:00";
                DurationStatus.Text = "00:00:00";
            }
            if (this.currentState == PlayState.Paused)
            {
                NextPlay.Interval = (PositionTracker.Maximum - PositionTracker.Value) * 1000;
            }
        }

        private void UpdateToolStrip()
        {
            // If no file is loaded, just show the application title
            if (this.filename == string.Empty)
                CurrentStatus.Text = "Stopped";
            else
                CurrentStatus.Text = String.Format(System.IO.Path.GetFileName(this.filename));
            
        }
                
        private void MainForm_KeyDown(object sender,KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Space:
                    {
                        StepOneFrame();
                        break;
                    }
                case Keys.Left:
                    {
                        ModifyRate(-0.25);
                        break;
                    }
                case Keys.Right:
                    {
                        ModifyRate(+0.25);
                        break;
                    }
                case Keys.Down:
                    {
                        SetRate(1.0);
                        break;
                    }
                case Keys.P:
                    {
                        PauseClip();
                        break;
                    }
                case Keys.S:
                    {
                        StopClip();
                        break;
                    }
                case Keys.M:
                    {
                        ToggleMute();
                        break;
                    }
                case Keys.F:
                case Keys.Return:
                    {
                        ToggleFullScreen();
                        break;
                    }
                case Keys.N:
                    {
                        InitVideoWindow(1, 1);
                        break;
                    }
                case Keys.D:
                    {
                        InitVideoWindow(2, 1);
                        break;
                    }
                case Keys.T:
                    {
                        InitVideoWindow(3, 4);
                        break;
                    }
                case Keys.Escape:
                    {
                        if (this.isFullScreen)
                            ToggleFullScreen();
                        break;
                    }

                case Keys.I:
                    {
                        incvol();
                        break;
                    }

                case Keys.R:
                    {
                        decvol();
                        break;
                    }
                case Keys.F12 | Keys.Q | Keys.X:
                    {
                        CloseClip();
                        break;
                    }
            }
        }
        
        private void MainForm_Move(object sender, System.EventArgs e)
        {
            if (!this.isAudioOnly)
                MoveVideoWindow();
        }
        
        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if (!this.isAudioOnly)
                MoveVideoWindow();
        }
        
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StopClip();
            CloseInterfaces();
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            PlayBtn.Enabled = false;
            PauseBtn.Enabled = false;
            FFBtn.Enabled = false;
            RewindBtn.Enabled = false;
            mci.Recording();
            
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            PlayBtn.Enabled = true;
            if (mci.recorder)
            {
                mci.Pausing();
            }
            else
            {
                if (playlst)
                {
                    NextPlay.Stop();
                }
                PauseClip();
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            PlayBtn.Enabled = true;
            PauseBtn.Enabled = true;
            RecordBtn.Enabled = true;
            RewindBtn.Enabled = true;
            FFBtn.Enabled = true;
            if (mci.recorder)
            {
                SaveFileDialog.ShowDialog();
                mci.Save(SaveFileDialog.FileName);
            }
            else
            {
                if (playlst)
                    NextPlay.Stop();
                Increment.Stop();
                StopClip();
            }
        }

        private void openCDTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mci.OpenCDTray();
        }

        private void closeCDTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mci.CloseCDTray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If we have ANY file open, close it and shut down DirectShow
            if (this.currentState != PlayState.Init)
                CloseClip();
            FileOpenDialog.ShowDialog();
            OpenClip();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            // If we have ANY file open, close it and shut down DirectShow
            if (this.currentState != PlayState.Init)
                CloseClip();
            FileOpenDialog.ShowDialog();
            OpenClip();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Play();
            PlayBtn.Enabled = false;
            RecordBtn.Enabled = false;
        }

        private void FFBtn_Click(object sender, EventArgs e)
        {
            ModifyRate(+0.25);
        }

        private void fastForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyRate(+0.25);     
        }

        private void RewindBtn_Click(object sender, EventArgs e)
        {
            ModifyRate(-0.25);
        }

        private void slowForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyRate(-0.25);
        }

        private void singleFrameStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepOneFrame();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitVideoWindow(1, 1);           
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitVideoWindow(3, 4);           
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitVideoWindow(2, 1);           
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFullScreen();
            isFullScreen = true;
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleMute();
            if (mute)
                muteToolStripMenuItem.Text = "Un Mute";
            else
                muteToolStripMenuItem.Text = "Mute";
            
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            try
            {

                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
                int hr = this.basicAudio.put_Volume(this.currentVolume);
            }
            catch
            {
            }
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                if (toolStripProgressBar1.Value != toolStripProgressBar1.Maximum)
                    toolStripProgressBar1.Value += 500;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
                int hr = this.basicAudio.put_Volume(this.currentVolume);
            }
        }
        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                if (toolStripProgressBar1.Value != 0)
                    toolStripProgressBar1.Value -= 500;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
                int hr = this.basicAudio.put_Volume(this.currentVolume);
            }
        }
        private void Increase()
        {
            PositionTracker.Value++;
            UpdateStatusBar();
            Increment.Stop();
            Increment.Start();
        }
        private void Increment_Tick(object sender, EventArgs e)
        {
            if (PositionTracker.Value != PositionTracker.Maximum)
                Increase();
            else
            {
                PositionTracker.Value = 0;
            }
        }

        private void PositionTracker_Scroll(object sender, EventArgs e)
        {
            if (playlst)
                try
                {
                    NextPlay.Interval = (PositionTracker.Maximum - PositionTracker.Value) * 1000;
                }
                catch 
                { 
                }
            mediaPosition.put_CurrentPosition((double)PositionTracker.Value);
            UpdateStatusBar();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StopClip();
            if (OpenPlaylist.ShowDialog() == DialogResult.OK)
            {
                FileStream f2 = new FileStream(OpenPlaylist.FileName, FileMode.Open, FileAccess.Read);
                byte[] b = new byte[f2.Length];
                f2.Read(b, 0, (int)f2.Length);
                listtoplay = (System.Text.Encoding.ASCII.GetString(b)).Split('@');
                playlst = true;
                PlayBtn.Enabled = false;
                RecordBtn.Enabled = false;
                Play();       
                f2.Close();
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        


        private void NextPlay_Tick(object sender, EventArgs e)
        {
            NextPlay.Stop();
            Play();
        }

        private void playListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListForm = new Form4(listtoplay);
                ListForm.Show();
            }
            catch
            {
            }
        }
        private void decvol()
        {

            if (!mute)
            {
                if (toolStripProgressBar1.Value != 0)
                    toolStripProgressBar1.Value -= 500;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
                int hr = this.basicAudio.put_Volume(this.currentVolume);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            decvol();
        }
        private void incvol()
        {

            if (!mute)
            {
                if (toolStripProgressBar1.Value != toolStripProgressBar1.Maximum)
                    toolStripProgressBar1.Value += 500;
                this.currentVolume = toolStripProgressBar1.Value + VolumeSilence;
                int hr = this.basicAudio.put_Volume(this.currentVolume);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            incvol();
        }

        private void MainForm_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyPressEventArgs e)
        {

        }

        private void subtitlesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (SubtitlesOpen.ShowDialog() == DialogResult.OK)
            {
                SubtitleForm = new Form5();
                SubtitleForm.Show();
                SubtitleForm.initial(SubtitlesOpen.FileName);
            }   
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colour.ShowDialog();
            if(SubtitleForm!=null)
            {
                SubtitleForm.FontColor(Colour.Color);
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Background.ShowDialog();
            if (SubtitleForm != null)
            {
                SubtitleForm.Background(Background.Color);
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = false;
            italicToolStripMenuItem1.Checked = false;
            strikeoutToolStripMenuItem.Checked = false;
            underlinedToolStripMenuItem.Checked = false;
            if (SubtitleForm != null)
            {
                SubtitleForm.FontRegular();
            }
        }

        private void boldToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            regularToolStripMenuItem.Checked = false;
            italicToolStripMenuItem1.Checked = false;
            strikeoutToolStripMenuItem.Checked = false;
            underlinedToolStripMenuItem.Checked = false;
            if (SubtitleForm != null)
            {
                SubtitleForm.FontBold();
            }

        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = false;
            regularToolStripMenuItem.Checked = false;
            strikeoutToolStripMenuItem.Checked = false;
            underlinedToolStripMenuItem.Checked = false;
            if (SubtitleForm != null)
            {
                SubtitleForm.FontItalics();
            }
        }

        private void underlinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = false;
            italicToolStripMenuItem1.Checked = false;
            strikeoutToolStripMenuItem.Checked = false;
            regularToolStripMenuItem.Checked = false;
            if (SubtitleForm != null)
            {
                SubtitleForm.FontUnderline();
            }
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = false;
            italicToolStripMenuItem1.Checked = false;
            regularToolStripMenuItem.Checked = false;
            underlinedToolStripMenuItem.Checked = false;
            if (SubtitleForm != null)
            {
                SubtitleForm.FontStrikeout();
            }
        }

        private void smallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SubtitleForm != null)
            {
                SubtitleForm.FontSize(8F);
            }
        }

        private void mediumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SubtitleForm != null)
            {
                SubtitleForm.FontSize(12F);
            }
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SubtitleForm != null)
            {
                SubtitleForm.FontSize(14F);
            }
        }

        private void extraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (SubtitleForm != null)
            {
                SubtitleForm.FontSize(15.75F);
            }
        }

        private void playListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageExtractor.ImageExtractor img = new ImageExtractor.ImageExtractor();
            img.ShowDialog();
            
        }

       
        

        
         
       
    }
}