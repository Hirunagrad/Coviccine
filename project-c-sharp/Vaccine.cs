using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_c_sharp
{
    public partial class Vaccine : UserControl
    {

        private static Vaccine _instance;
        public static Vaccine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Vaccine();
                }
                return _instance;
            }
        }
        public Vaccine()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunabutton1_Click(object sender, EventArgs e)
        {
            
            
            
            
            popup obj = new popup();
            obj.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void std_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void nic_TextChanged(object sender, EventArgs e)
        {

        }

        private void vaccinesType_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void batch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vaccine_Load(object sender, EventArgs e)
        {
           
        }
    }
}
