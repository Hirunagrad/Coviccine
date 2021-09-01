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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace project_c_sharp
{
    public partial class Information : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\coviccine.mdf;Integrated Security=True;Connect Timeout=30";

        private static Information _instance;
        public static Information Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Information();
                }
                return _instance;
            }
        }
        public Information()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            String id = guna2TextBox1.Text;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * from registerdetails WHERE std_id='"+id+"' ", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                guna2DataGridView1.DataSource = dtbl;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void exportgridtopdf(DataGridView dgw,String filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            PrintDialog printdialog1 = new PrintDialog();
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf,10,iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);

            }

            foreach (DataGridViewRow row in dgw.Rows) {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }




            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName,FileMode.Create))
                {
             
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void pdfbutton_Click(object sender, EventArgs e)
        {
            exportgridtopdf(guna2DataGridView1, "test");
        }
    }
}

//add something
//update