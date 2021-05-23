
namespace CidFileChangeTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folderOnWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnWatch = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkLapseSecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLapseText = new System.Windows.Forms.ToolStripTextBox();
            this.btnAction = new System.Windows.Forms.ToolStripMenuItem();
            this.LastCheckLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExploreWatchs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExploreResults = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cid File Tracker";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderOnWatchToolStripMenuItem,
            this.resultsFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkLapseSecondsToolStripMenuItem,
            this.btnAction,
            this.LastCheckLabel,
            this.toolStripSeparator2,
            this.btnExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(263, 184);
            // 
            // folderOnWatchToolStripMenuItem
            // 
            this.folderOnWatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOnWatch,
            this.btnExploreWatchs});
            this.folderOnWatchToolStripMenuItem.Name = "folderOnWatchToolStripMenuItem";
            this.folderOnWatchToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.folderOnWatchToolStripMenuItem.Text = "Folder on Watch";
            // 
            // btnOnWatch
            // 
            this.btnOnWatch.Image = ((System.Drawing.Image)(resources.GetObject("btnOnWatch.Image")));
            this.btnOnWatch.Name = "btnOnWatch";
            this.btnOnWatch.Size = new System.Drawing.Size(414, 28);
            this.btnOnWatch.Text = "This is the folder being watched right now";
            this.btnOnWatch.Click += new System.EventHandler(this.btnOnWatch_Click);
            // 
            // resultsFolderToolStripMenuItem
            // 
            this.resultsFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToSave,
            this.btnExploreResults});
            this.resultsFolderToolStripMenuItem.Name = "resultsFolderToolStripMenuItem";
            this.resultsFolderToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.resultsFolderToolStripMenuItem.Text = "Results Folder";
            // 
            // btnToSave
            // 
            this.btnToSave.Image = ((System.Drawing.Image)(resources.GetObject("btnToSave.Image")));
            this.btnToSave.Name = "btnToSave";
            this.btnToSave.Size = new System.Drawing.Size(527, 28);
            this.btnToSave.Text = "This is the folder to where the changed files will be saved";
            this.btnToSave.Click += new System.EventHandler(this.btnToSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // checkLapseSecondsToolStripMenuItem
            // 
            this.checkLapseSecondsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeLapseText});
            this.checkLapseSecondsToolStripMenuItem.Name = "checkLapseSecondsToolStripMenuItem";
            this.checkLapseSecondsToolStripMenuItem.Size = new System.Drawing.Size(262, 28);
            this.checkLapseSecondsToolStripMenuItem.Text = "Check Lapse(Seconds)";
            // 
            // timeLapseText
            // 
            this.timeLapseText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeLapseText.Name = "timeLapseText";
            this.timeLapseText.Size = new System.Drawing.Size(100, 27);
            this.timeLapseText.Text = "30";
            this.timeLapseText.TextChanged += new System.EventHandler(this.timeLapseText_TextChanged);
            // 
            // btnAction
            // 
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(262, 28);
            this.btnAction.Text = "Start Watching";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // LastCheckLabel
            // 
            this.LastCheckLabel.Name = "LastCheckLabel";
            this.LastCheckLabel.Size = new System.Drawing.Size(262, 28);
            this.LastCheckLabel.Text = "Last Check: 00:00:00 PM";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 28);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExploreWatchs
            // 
            this.btnExploreWatchs.Name = "btnExploreWatchs";
            this.btnExploreWatchs.Size = new System.Drawing.Size(414, 28);
            this.btnExploreWatchs.Text = "Explore...";
            this.btnExploreWatchs.Click += new System.EventHandler(this.btnExploreWatchs_Click);
            // 
            // btnExploreResults
            // 
            this.btnExploreResults.Name = "btnExploreResults";
            this.btnExploreResults.Size = new System.Drawing.Size(527, 28);
            this.btnExploreResults.Text = "Explore...";
            this.btnExploreResults.Click += new System.EventHandler(this.btnExploreResults_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 81);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem folderOnWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnOnWatch;
        private System.Windows.Forms.ToolStripMenuItem btnToSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem checkLapseSecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox timeLapseText;
        private System.Windows.Forms.ToolStripMenuItem LastCheckLabel;
        private System.Windows.Forms.ToolStripMenuItem btnExploreWatchs;
        private System.Windows.Forms.ToolStripMenuItem btnExploreResults;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

