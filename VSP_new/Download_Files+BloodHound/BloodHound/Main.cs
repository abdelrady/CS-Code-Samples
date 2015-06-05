/* ----------------------------------------------------------------------
 * 
 *  Author: Shailen Sukul BSC, MCSD.Net, Mcsd, Mcad
 *  Date: 9/April/2006
 *  Copyright Ashlen Consulting Services P/L
 * ----------------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Ashlen.Persistence.Form;

namespace BloodHound
{
    public partial class Main : Form
    {
        #region Fields
        StatePersistence persist = null;
        delegate void AsyncMethodCaller();
        /* A store of all created threads. */
        ArrayList _threads = new ArrayList();
        /* A store of all FileDownloader objects. */
        ArrayList _instances = new ArrayList();
        private int _activeDownloadCount = 0;
        object _lockObject = new object();
        #endregion

        public Main()
        {
            InitializeComponent();
            persist = new StatePersistence(this);
        }

        private void BeginButton_VisibleChanged(object sender, EventArgs e)
        {
            btnCancelDownload.Visible = !(sender as Button).Visible;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Browse for a save file operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveToLocation.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// The Start Download button click will locate all items selected for download, 
        /// start the dowload asynchronously on a new thread and add the downloader class 
        /// to an internal store.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginButton_Click(object sender, EventArgs e)
        {
            _instances = new ArrayList();
            _threads = new ArrayList();
            _activeDownloadCount = 0;

            if (lstFiles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select one or more files to download.");
            }
            else
            {
                btnCancelDownload.Visible = true;                
                btnBegin.Enabled = false;
                FileDownloader download = null;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = lstFiles.CheckedItems.Count;
                progressBar1.Value = 0;

                foreach (ListViewItem item in lstFiles.CheckedItems)
                {
                    item.SubItems[1].Text = "Not started";
                    download = new FileDownloader(item.SubItems[0].Text, SaveToLocation.Text);
                    if (txtUri.Text != null && txtUri.Text != string.Empty)
                    {
                        download.ProxyUri = txtUri.Text;
                    }
                    item.Tag = download;
                    try
                    {
                        ThreadStart tsDelegate = new ThreadStart(download.StartDownload);
                        download.DownloadStarting += new FileDownloader._delDownloadStarting(download_DownloadStarting);
                        download.DownloadCompleted += new FileDownloader._delDownloadCompleted(download_DownloadCompleted);
                        Thread t = new Thread(tsDelegate);
                        t.Name = item.SubItems[0].Text;
                        _threads.Add(t);
                        _instances.Add(download);                        
                    }
                    catch
                    {
                        /* If the download fails for some reason, flag and error. */
                        item.SubItems[1].Text = "Error";
                    }
               }
                StartDownload();
            }
        }

        /// <summary>
        /// Gets trigerred when the download has completed.
        /// </summary>
        /// <param name="thread"></param>
        /// <param name="isSuccess"></param>
        void download_DownloadCompleted(FileDownloader thread, bool isSuccess)
        {
            /* When changing the global download count, be sure to make it thread safe via locking. */
            lock (_lockObject)
            {
                _activeDownloadCount--;                
            }
            SetStatus("Completed", thread);
            SetProgressBar();
            RemoveFromInternalPool(thread);
            StartDownload();
            
        }

        /// <summary>
        /// Gets triggered when the download has started.
        /// </summary>
        /// <param name="thread"></param>
        void download_DownloadStarting(FileDownloader thread)
        {
            SetStatus("Downloading", thread);
        }

        delegate void delSetStatus(string Status, FileDownloader f);
        /// <summary>
        /// When updating the file status in the listbox,
        /// use the Invoke method to execute the specified delegate on the thread 
        /// that owns the control's underlying window handle, ie the main UI thread.
        /// </summary>
        /// <param name="Status"></param>
        /// <param name="f"></param>
        private void SetStatus(string Status, FileDownloader f)
        {
            if (lstFiles.InvokeRequired)
            {
                delSetStatus s = new delSetStatus(SetStatus);
                this.Invoke(s, new object[] {Status, f});
            }
            else
            {
                foreach (ListViewItem item in lstFiles.Items)
                {
                    if (item.Tag == f)
                    {
                        /* Use locking to synchronise across mutilple thread calls. */
                        lock (_lockObject)
                        {
                            item.SubItems[1].Text = Status;
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Inspects the internal pool and starts off more downloads threads, if freed.
        /// </summary>
        private void StartDownload()
        {

            int j = 0;
            int limit = int.Parse(NumberofDownloads.Text);
            int iCount = 0;
            lock (_lockObject)
            {
                iCount = _instances.Count;
            }
            if (iCount != 0)
            {
                foreach (Thread thread in _threads)
                {
                    FileDownloader file = ((FileDownloader)_instances[j]);
                    if (file._IsStarted == false)
                    {
                        lock (_lockObject)
                        {
                            thread.Start();
                            _activeDownloadCount++;
                        }
                    }
                    if (_activeDownloadCount == limit)
                    {
                        break;
                    }
                    j++;
                }
            }
            else
            {
                /* If all the files have downloaded, then show the Begin button. */
                EnableBeginButton();
            }
        }

        /// <summary>
        /// Forcilby kills all active threads.
        /// Needed when the download needs to cancel.
        /// </summary>
        private void KillThreads()
        { 
            foreach (Thread t in _threads)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
            _threads = new ArrayList();
            _instances = new ArrayList();
        }

        delegate void delVoidFunction();
        /// <summary>
        /// Enables the  Begin button in a thread safe manner.
        /// </summary>
        private void EnableBeginButton()
        {
            if (btnBegin.InvokeRequired)
            {
                delVoidFunction d = new delVoidFunction(EnableBeginButton);
                this.Invoke(d, null);
            }
            else
            {
                btnBegin.Enabled = true;
                btnCancelDownload.Visible = false;
            }
        }
        /// <summary>
        /// Removes the fiven FileDownLoader thread from the internal pool.
        /// </summary>
        /// <param name="thread"></param>
        private void RemoveFromInternalPool(FileDownloader thread)
        {
            int i = 0;
            foreach (FileDownloader f in _instances)
            {
                if (f == thread)
                {
                    /* If the file has downloaded, remove it from our pool. */
                    lock (_lockObject)
                    {
                        _threads.Remove(_threads[i]);
                        _instances.Remove(f);
                        break;
                    }
                }
                i++;
            }
        }

        delegate void SetProgressBarCallback();
        /// <summary>
        /// Updates the progess bar in a thread-safe manner.
        /// </summary>
        private void SetProgressBar()
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressBarCallback p = new SetProgressBarCallback(SetProgressBar);
                this.Invoke(p);
            }
            else
            {
                lock (_lockObject)
                {
                    progressBar1.Value++;
                }
            }
        }

        /// <summary>
        /// Runs validation checks on Form Data
        /// </summary>
        /// <returns></returns>
        private System.Collections.Specialized.StringCollection  ValidationChecks()
        {
            System.Collections.Specialized.StringCollection sb = new System.Collections.Specialized.StringCollection();
            if (txtWebsiteAddress.Text.Trim().Equals(string.Empty))
            {                
                sb.Add("Website address cannot be null.");
            }
            if (TargetFilter.Text.Trim().Equals(string.Empty))
            {
                sb.Add("Filter text cannot be null.");
            }
            if (SaveToLocation.Text.Trim().Equals(string.Empty))
            {
                sb.Add("Save to location cannot be null.");
            }
            if (NumberofDownloads.Text.Trim().Equals(string.Empty))
            {
                sb.Add("Number of simultaneous downloads cannot be null.");
            }
            if (Convert.ToInt32(NumberofDownloads.Text) > 25)
            {
                sb.Add("Number of simultaneous downloads cannot be more than 25.");
            }
            return sb;
        }

        private string StringBuilderToString(System.Collections.Specialized.StringCollection sb)
        {
            string sRet = string.Empty;
            foreach (string s in sb)
            {
                sRet += s + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Loads a list of items that match the filter from the target website.
        /// </summary>
        private void LoadFiles()
        {
            lstFiles.Items.Clear();
            WebPageInterrogater page = new WebPageInterrogater(txtWebsiteAddress.Text, TargetFilter.Text);
            StringCollection sCol = page.ListFiles();
            foreach (string s in sCol)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("Not started");
                item.Text = s.Replace("%20", " ");
                lstFiles.Items.Add(item);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadFiles();                    
            /*
            try
            {
                progressBar1.Value = 0;
                System.Collections.Specialized.StringCollection sb = ValidationChecks();
                if (sb.Count > 0)
                {
                    MessageBox.Show(StringBuilderToString(sb));
                }
                else
                {
                    btnList.Enabled = false;
                    LoadFiles();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error has occurred. Please check your internet connection." + Environment.NewLine +
                    Environment.NewLine + "More details: " + ex.ToString());
            }
            finally
            {
                btnList.Enabled = true;
            }*/
        }

        /// <summary>
        /// Before the form closes, check for any active threads in the thread pool
        /// and clean up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_threads.Count > 0)
            {
                if (MessageBox.Show("Do you want to cancel active downloads.", "Cancel",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    KillThreads();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void UpdateStatusToCancelled()
        {
            foreach (ListViewItem item in lstFiles.CheckedItems)
            {
                if (item.SubItems[1].Text.Equals("Downloading"))
                {
                    item.SubItems[1].Text = "Cancelled";
                }
            }
        }

        /// <summary>
        /// Cancels the active downloads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelDownload_Click(object sender, EventArgs e)
        {
            KillThreads();
            UpdateStatusToCancelled();
            btnBegin.Enabled = true;
            btnCancelDownload.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstFiles.Items)
            {
                item.Checked = true;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstFiles.Items)
            {
                item.Checked = false;
            }
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            if (btnProxy.Text.Equals("<<"))
            {
                this.Width = 798;
                btnProxy.Text = "Proxy Uri";
            }
            else
            {
                this.Width = 935;
                btnProxy.Text = "<<";
            }
        }


    }
}