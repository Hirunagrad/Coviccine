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
    public partial class doctor : KryptonForm
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void logindoctor_Click(object sender, EventArgs e)
        {
            String uname = username.Text;
            String pass = password.Text;

            if (uname == "" || pass == "")
            {
                empty.Text = "";
                String errorOne = "please enter username and password";
                empty.Text = errorOne;

            }
            else if (uname != "doctor" && pass != "doctor")
            {
                empty.Text = "";
                String errorTwo = "invalid username or password";
                empty.Text = errorTwo;
            }


            if (uname == "doctor" && pass == "doctor")
            {
                doctor obj = new doctor();
                obj.Show();
                this.Hide();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
