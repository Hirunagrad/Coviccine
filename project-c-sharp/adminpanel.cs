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
using System.Data.SqlClient;

namespace project_c_sharp
{
    public partial class view : KryptonForm
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30";
        public view()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void updates_Click(object sender, EventArgs e)
        {
            updatedata obj = new updatedata();
            obj.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            delete objone = new delete();
            objone.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from registerdetails", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                guna2DataGridView1.DataSource = dtbl;
            }






          
        }

        private void add_Click(object sender, EventArgs e)
        {
            messagesboxses objnew = new messagesboxses();
            objnew.Show();
        }
    }
}
