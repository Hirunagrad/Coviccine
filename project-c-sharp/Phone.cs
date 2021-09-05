using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_c_sharp
{
    public partial class Phone : UserControl
    {
        private static Phone _instance;
        public static Phone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Phone();
                }
                return _instance;
            }
        }

        public Phone()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submits_Click(object sender, EventArgs e)
        {
            String std_id = id.Text;
            String uname = name.Text;
            String phoneNumber = pnumber.Text;
            String messages = message.Text;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
