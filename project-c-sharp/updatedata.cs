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
using System.Data.SqlClient;

namespace project_c_sharp
{
    public partial class updatedata : KryptonForm
    {
        public updatedata()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void nic_TextChanged(object sender, EventArgs e)
        {

        }

        private void vaccine_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void batch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            String id = std_id.Text;
            String names = name.Text;
            String nicn = nic.Text;
            String vaccines = vaccine.Text;
            String ages = age.Text;
            String batches = batch.Text;
            String dates = date.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "UPDATE registerdetails SET name = '"+names+ "', nic = '"+nicn+ "' ,  vaccine_type = '"+vaccines + "' , age = '"+ages+ "' ,  batch='"+ batches + "',  date = '" +dates+ "'  WHERE std_id = '" +id+"' ";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Sucsessfull!!");
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Error" + Ex.ToString());
            }
            finally
            {
                con.Close();

            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void std_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatedata_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            view obj = new view();
            obj.Show();
            this.Hide();
        }
    }
}
