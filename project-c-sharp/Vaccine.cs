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
            String stdid = std_id.Text;
            String names = name.Text;
            String nicn = nic.Text;
            String vaccinesTypes = vaccinesType.Text;
            String ages = age.Text;
            String batches = batch.Text;
            String dates = date.Text;


            if(stdid == "")
            {
                errorOne.Text = "";
                errorOne.Text = "please enter student id";
            }
            else if (names == "")
            {
                errorTwo.Text = "";
                errorTwo.Text = "please enter name";

            }
            else if (nicn == "")
            {
                errorThree.Text = "";
                errorThree.Text = "please enter nic";

            }
            else if (vaccinesTypes == "")
            {
                levelFour.Text = "";
                levelFour.Text = "please enter Vaccine";

            }
            else if (ages == "")
            {
                levelFive.Text = "";
                levelFive.Text = "please enter age";

            }
            else if (batches == "")
            {
                levelSix.Text = "";
                levelSix.Text = "please enter batches";

            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30");
                String query = "INSERT INTO registerdetails Values ('" + stdid + "', '" + names + "', '" + nicn + "' , '" + vaccinesTypes + "', '" + ages + "', '" + batches + "', '" + dates + "' )";
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Database connection Sucsessfull!!");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void errorOne_Click(object sender, EventArgs e)
        {

        }

        private void errorTwo_Click(object sender, EventArgs e)
        {

        }

        private void errorThree_Click(object sender, EventArgs e)
        {

        }

        private void levelFour_Click(object sender, EventArgs e)
        {

        }

        private void levelFive_Click(object sender, EventArgs e)
        {

        }

        private void levelSix_Click(object sender, EventArgs e)
        {

        }

        private void levelSeven_Click(object sender, EventArgs e)
        {

        }

        private void Vaccine_Load_1(object sender, EventArgs e)
        {

        }
    }
}
