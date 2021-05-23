using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CidFileChangeTracker
{
    public partial class Form1 : Form
    {
        public Dictionary<string, FileWatched> FileList { get; set; }

        public Form1()
        {
            InitializeComponent();
            FileList = new Dictionary<string, FileWatched>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(Settings.Default.PathToWatch))
                Settings.Default.PathToWatch = Application.StartupPath;
            if (String.IsNullOrEmpty(Settings.Default.PathToSave))
                Settings.Default.PathToSave = String.Format("{0}\\Cid File Change Tracker\\Watch Results", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.None));
            
            Settings.Default.Save();
            
            if (!Directory.Exists(Settings.Default.PathToSave))
                Directory.CreateDirectory(Settings.Default.PathToSave);

            btnOnWatch.Text = Settings.Default.PathToWatch;
            btnToSave.Text = Settings.Default.PathToSave;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {//stop
                timer1.Stop();
                btnAction.Text = "Start Watching";
            }
            else
            {//start
                InitializeFileList();
                timer1.Start();
                btnAction.Text = "Stop Watching";
            }
        }

        private void btnOnWatch_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    btnOnWatch.Text = fbd.SelectedPath;
                    Settings.Default.PathToWatch = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
        }

        private void btnToSave_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    btnToSave.Text = fbd.SelectedPath;
                    Settings.Default.PathToSave = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
        }

        private void timeLapseText_TextChanged(object sender, EventArgs e)
        {
            int newVal = 30;
            if (int.TryParse(timeLapseText.Text, out newVal) && newVal > 0)
                timer1.Interval = newVal * 1000;
            else
                timeLapseText.Text = "30";
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Dictionary<string, FileWatched> currentFiles = GetFilesAt(Settings.Default.PathToWatch);
            List<FileWatched> newOrUpdatedFiles = new List<FileWatched>();
            LastCheckLabel.Text = "Last Check: " + DateTime.Now.ToString("hh:mm:ss tt");

            foreach (FileWatched fw in currentFiles.Values)
            {
                if (!FileList.ContainsKey(fw.Signature))
                    newOrUpdatedFiles.Add(fw);
            }

            if (newOrUpdatedFiles.Count > 0)
            {
                try
                {
                    SaveFileChanges(newOrUpdatedFiles);
                    FileList = currentFiles;
                }
                catch (Exception)
                {

                }
            }
        }


        private void InitializeFileList()
        {
            FileList.Clear();
            FileList = GetFilesAt(Settings.Default.PathToWatch);
        }

        private Dictionary<string, FileWatched> GetFilesAt(string pathToWatch)
        {
            int OneMegaByte = 1024 * 1024;
            string[] fileList = Directory.GetFiles(pathToWatch, "*.*", SearchOption.TopDirectoryOnly);
            Dictionary<string, FileWatched> back = new Dictionary<string, FileWatched>();

            foreach (string path in fileList)
            {
                FileInfo buff = new FileInfo(path);
                string fileMd5;

                if(buff.Length > OneMegaByte)
                    fileMd5 = HashHelper.CalculateHash(buff, OneMegaByte);
                else
                    fileMd5 = HashHelper.CalculateFullHash(buff);

                back.Add(fileMd5, new FileWatched(fileMd5, buff));
            }

            return back;
        }

        private void SaveFileChanges(List<FileWatched> newOrUpdatedFiles)
        {
            string pathToSave = Settings.Default.PathToSave + "\\" + DateTime.Now.ToString("MMM-dd hh_mm_ss tt");
            Directory.CreateDirectory(pathToSave);

            foreach (FileWatched fw in newOrUpdatedFiles)
                File.Copy(fw.File.FullName, String.Format("{0}\\{1}", pathToSave, fw.File.Name));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExploreWatchs_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.PathToWatch);
        }

        private void btnExploreResults_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.PathToSave);
        }
    }
}
