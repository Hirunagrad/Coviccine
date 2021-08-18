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
using FontAwesome.Sharp;

namespace project_c_sharp
{

    public partial class Form1 : KryptonForm
    {
        private IconButton currentButton;
        public Form1()
        {
            InitializeComponent();
        }
        //object sender = button click call wena eka
        private void ActiveButton(object SenderBtn)
        {
            InnactiveButton();
            if (SenderBtn != null)
            {
                currentButton = (IconButton)SenderBtn;
                currentButton.BackColor = Color.FromArgb(196, 196, 196);
                currentButton.IconColor = Color.FromArgb(8, 112, 248);
            }
        }

        private void InnactiveButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(196, 196, 196);
                currentButton.IconColor = Color.FromArgb(136, 136, 136);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            if (!mainpanel.Controls.Contains(Vaccine.Instance))
            {
                mainpanel.Controls.Add(Vaccine.Instance);
                Vaccine.Instance.Dock = DockStyle.Fill;
                Vaccine.Instance.BringToFront();
            }
            else
            {
                Vaccine.Instance.BringToFront();
            }
        }

       

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);

            if (!mainpanel.Controls.Contains(Information.Instance))
            {
                mainpanel.Controls.Add(Information.Instance);
                Information.Instance.Dock = DockStyle.Fill;
                Information.Instance.BringToFront();
            }
            else
            {
                Information.Instance.BringToFront();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (!mainpanel.Controls.Contains(Home.Instance))
            {
                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
            {
                Home.Instance.BringToFront();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (!mainpanel.Controls.Contains(Phone.Instance))
            {
                mainpanel.Controls.Add(Phone.Instance);
                Phone.Instance.Dock = DockStyle.Fill;
                Phone.Instance.BringToFront();
            }
            else
            {
                Phone.Instance.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!mainpanel.Controls.Contains(Home.Instance))
            {
                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.Dock = DockStyle.Fill;
                Home.Instance.BringToFront();
            }
            else
            {
                Home.Instance.BringToFront();
            }
        }
    }
}
