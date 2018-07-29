namespace dyndnsClient
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.webIPUpdater = new System.Windows.Forms.WebBrowser();
            this.btnMinimizeToTray = new System.Windows.Forms.Button();
            this.sysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // webIPUpdater
            // 
            this.webIPUpdater.Location = new System.Drawing.Point(0, 0);
            this.webIPUpdater.MinimumSize = new System.Drawing.Size(20, 20);
            this.webIPUpdater.Name = "webIPUpdater";
            this.webIPUpdater.Size = new System.Drawing.Size(340, 159);
            this.webIPUpdater.TabIndex = 0;
            // 
            // btnMinimizeToTray
            // 
            this.btnMinimizeToTray.Location = new System.Drawing.Point(0, 123);
            this.btnMinimizeToTray.Name = "btnMinimizeToTray";
            this.btnMinimizeToTray.Size = new System.Drawing.Size(321, 29);
            this.btnMinimizeToTray.TabIndex = 1;
            this.btnMinimizeToTray.Text = "Hide in System Tray";
            this.btnMinimizeToTray.UseVisualStyleBackColor = true;
            this.btnMinimizeToTray.Click += new System.EventHandler(this.btnMinimizeToTray_Click);
            // 
            // sysTrayIcon
            // 
            this.sysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("sysTrayIcon.Icon")));
            this.sysTrayIcon.Text = "IP Updater";
            this.sysTrayIcon.Click += new System.EventHandler(this.sysTrayIcon_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 153);
            this.Controls.Add(this.btnMinimizeToTray);
            this.Controls.Add(this.webIPUpdater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "IP UPDATER";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webIPUpdater;
        private System.Windows.Forms.Button btnMinimizeToTray;
        private System.Windows.Forms.NotifyIcon sysTrayIcon;
    }
}

