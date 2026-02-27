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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void lblStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblTime.Text = counter.ToString();
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            lblTime.Text = "0";
            counter = 0;
            lblStop_Click(sender, e);
        }
    }
}
