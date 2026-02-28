using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void btnShowBallon_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "this is just the title";
            notifyIcon1.BalloonTipText = "this is the main text to see";
            notifyIcon1.ShowBalloonTip(10000);

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
