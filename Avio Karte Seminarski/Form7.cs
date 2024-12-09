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

namespace SeminarskiRSOK
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            BinGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void binDataGrid()
        {
            string constring = "Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(constring))
            {




            }


        }
        private void Form7_Load(object sender, EventArgs e)
        {
            this.BinGrid();
        }

        private void BinGrid()
        {
            string constring = @"Data Source=DESKTOP-DMH1A5F;Initial Catalog=AvioKarte;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("Select * FROM karta", con))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }

                }


            }
        }

        private void Form7_Load_1(object sender, EventArgs e)
        {

        }
    }
}
