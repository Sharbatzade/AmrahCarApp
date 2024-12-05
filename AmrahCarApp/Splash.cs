using Bunifu.UI.WinForms.Helpers.Transitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace AmrahCarApp
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            CircleProgressBar1.Value = startpoint;
            Percentage.Text="" + startpoint;
            if(CircleProgressBar1.Value == 100)
            {
                CircleProgressBar1.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }
    }
}
