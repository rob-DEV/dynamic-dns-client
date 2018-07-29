using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dyndnsClient
{
    public partial class FrmMain : Form
    {
        private string ipUpdatePageUri = "http://localhost/dyndns/server/ipupdater.php";

        public FrmMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            webIPUpdater.Navigate(ipUpdatePageUri);
        }

        private void btnMinimizeToTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            sysTrayIcon.Visible = true;
            this.Hide();
        }

        private void sysTrayIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            sysTrayIcon.Visible = false;
        }
    }
}
