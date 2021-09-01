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
    public partial class doctorpanel : KryptonForm
    {
        public doctorpanel()
        {
            InitializeComponent();
        }

        private void submits_Click(object sender, EventArgs e)
        {
            
            String std_id = id.Text;
            String onvaccine = "True";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "UPDATE registerdetails SET vaccinated = '" + onvaccine + "' WHERE std_id = '"+std_id+"'";

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

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
