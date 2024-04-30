using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_libary_management_system
{
    public partial class splashfrom : Form
    {
        public splashfrom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            bunifuProgressBar1.Value = startpoint;
            Percentage.Text = "" + startpoint;
            if(bunifuProgressBar1.Value== 100)
            {
                bunifuProgressBar1.Value = 0;
                timer1.Stop();
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
            }
        }

        private void splashfrom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
