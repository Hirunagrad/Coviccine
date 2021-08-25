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
    public partial class admin : UserControl
    {
        private static admin _instance;
        public static admin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new admin();
                }
                return _instance;
            }
        }
        public admin()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            String uname = username.Text;
            String pass = password.Text;

            if (uname == "" || pass == "")
            {
                empty.Text = "";
                String errorOne = "please enter username and password";
                empty.Text = errorOne;

            }else if (uname != "admin" && pass != "admin")
            {
                empty.Text = "";
                String errorTwo = "invalid username or password";
                empty.Text = errorTwo;
            }

        
            if (uname == "admin" && pass == "admin" )
            {
                adminpanel obj = new adminpanel();
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

        private void empty_Click(object sender, EventArgs e)
        {

        }
    }
}
