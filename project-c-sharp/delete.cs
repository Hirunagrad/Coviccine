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
    public partial class delete : KryptonForm
    {
        public delete()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            String std_ids = std_id.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30");
            String query = "DELETE FROM registerdetails WHERE std_id = '" + std_ids + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Sucsessfull!!");
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

        private void std_id_TextChanged(object sender, EventArgs e)
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
