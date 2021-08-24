using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace project_c_sharp
{
    public partial class loadingscreen : KryptonForm
    {
        public loadingscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            guna2ProgressBar1.Increment(2);
             String x= guna2ProgressBar1.Value.ToString();
            label4.Text = x + "%";



            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                getvaccine.Show();

            }
        }

        private void loadingscreen_Load(object sender, EventArgs e)
        {
            getvaccine.Hide();

        }

        private void getvaccine_Click(object sender, EventArgs e)
        {
            Form1 hm = new Form1();
            hm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
